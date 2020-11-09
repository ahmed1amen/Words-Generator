#Region "FileHeader"
#If False Then
its not necessary, but convenient, to get permutation-results in lexicographic order.
lexicographic order compares two results stepwise on each position. The first occurance of a difference determines the order between both collections
eg compare 3544 with 3539: the first difference occurs at 3rd position, and determines 3539 as smaller than 3544
#End If '-- Options, Imports
#End Region 'FileHeader#



Public Module Combinatorics

   Public Iterator Function ChooseKfromN(chooseK As Integer, fromN As Integer, mode As CombinatoricMode) As IEnumerable(Of Integer())
#If False Then
imagine the digits as mechanical counter: K is the number of digits and N is the number of options of each digit
three algos follow a general pattern of alterning Output-Loop and "Regeneration":
1) output-loop: count up the last digit upto N-1, and each time yield a resultSet. After that the resultSet is "exhausted", and is to "regenerate"
2) Find the pivot-element, which is the last one, which can be incremented: the "Incrementability" depends on the CombinatoricMode
3) increment it, and regenerate the array-range behind it - how to do that also depends on the CombinatoricMode
4) the algo terminates when 2) couldn't find a propper pivot-element

the forth algo differs - it combines combination with permutation, and yields results not lexicographic ordered
#End If
      Dim ubound = chooseK - 1, nMax = fromN - 1
      Dim iPivot As Integer
      Select Case mode
         Case CombinatoricMode.Combination_NoRepetition ' keeps the resultSet asc-ordered
            Dim resultSet = Enumerable.Range(0, chooseK).ToArray ' init resultSet with ascending sequence
            Do
               ' 1) output-loop: enumerate last digit and yield results
               For n = resultSet(ubound) To nMax
                  resultSet(ubound) = n
                  Yield resultSet.ToArray
               Next
               ' 2) find incrementable pivot-element: must have a gap to its successor 
               For iPivot = ubound - 1 To 0 Step -1
                  If resultSet(iPivot) < resultSet(iPivot + 1) - 1 Then Exit For
               Next
               If iPivot < 0 Then Return ' 4) possibly terminate
               ' 3) "regeneration"
               Dim diff = resultSet(iPivot) + 1 - iPivot ' difference between pivotValue and its index
               For i = iPivot To ubound     ' fill resultSet from pivot on with ascending sequence keeps it ordered without Repetitions
                  resultSet(i) = i + diff
               Next
            Loop
         Case CombinatoricMode.Combination_WithRepetitions ' keeps the resultSet asc-ordered
            Dim resultSet = Enumerable.Repeat(0, chooseK).ToArray ' init resultSet with 0
            Do
               For n = resultSet(ubound) To nMax ' output-loop
                  resultSet(ubound) = n
                  Yield resultSet.ToArray
               Next
               For iPivot = ubound - 1 To 0 Step -1 ' find incrementable position 
                  If resultSet(iPivot) < nMax Then Exit For '  pivot-element must be smaller than nMax
               Next
               If iPivot < 0 Then Return
               Dim pivotValue = resultSet(iPivot) + 1
               For i = iPivot To ubound         ' fill resultSet after pivot with same pivotValue keeps it ordered with Repetitions
                  resultSet(i) = pivotValue
               Next
            Loop
         Case CombinatoricMode.Variation_WithRepetitions
            Dim resultSet = Enumerable.Repeat(0, chooseK).ToArray
            Do
               For n = resultSet(ubound) To nMax ' output-loop
                  resultSet(ubound) = n
                  Yield resultSet.ToArray
               Next
               For iPivot = ubound To 0 Step -1 ' find incrementable position, set others to 0
                  If resultSet(iPivot) >= nMax Then resultSet(iPivot) = 0 Else Exit For ' pivot-element must be smaller than nMax
               Next
               If iPivot < 0 Then Return
               resultSet(iPivot) += 1
            Loop
         Case CombinatoricMode.Variation_NoRepetition ' this is different, and results are not in lexicographic order
            ' to each Combination_NoRepetition-result the Permutation-algo is applied
            ' (Variation_WithRepetitions could be implemented analogously, but its actual Algo is faster, and ordered)
            For Each result In ChooseKfromN(chooseK, fromN, CombinatoricMode.Combination_NoRepetition)
               For Each perm In Permutation(result)
                  Yield perm
               Next
            Next
      End Select
   End Function

   Public Iterator Function Permutation(sortedElements As IEnumerable(Of Integer)) As IEnumerable(Of Integer())
#If False Then
lexicographic Permutation-Algo as described by Dijkstra:
works correct (no redundant results), even if sortedElements contains some elements of equal value
1) output perm-clone
2) find pivot-element: the last, which is smaller than its successor
3) find swap-element: the last, which is bigger than pivot
4) swap them - this preserves the descending sort-order after the pivot-position
5) reverse the array after pivot-position: now behind pivot the array is sorted ascending - which is the lexicographic minimum
6) algo terminates, when in 2) no pivot could be found
#End If
      Dim perm = sortedElements.ToArray()
      Dim ubound = perm.Length - 1
      Dim pivot, iPivot As Integer
      Do
         Yield perm.ToArray()   '1
         For iPivot = ubound - 1 To 0 Step -1
            pivot = perm(iPivot)
            If pivot < perm(iPivot + 1) Then Exit For '2
         Next
         If iPivot < 0 Then Return '6
         Dim iSwap = Array.FindLastIndex(perm, Function(p) p > pivot) '3
         perm(iPivot) = perm(iSwap)                    '4
         perm(iSwap) = pivot
         Array.Reverse(perm, iPivot + 1, ubound - iPivot) '5
      Loop
   End Function

   Public Iterator Function PermutationMicroOptimized(sortedElements As IEnumerable(Of Integer)) As IEnumerable(Of Integer())
      'same as above, 3 times faster
      'biggest performance-improvement is to yield perm directly instead of cloning it first. But such is very unsafe!
      '(much less important) next performance bottlenecks are: 1) calling other functions, 2) Array-Set-Accessor
      Dim perm = sortedElements.ToArray()
      Dim ubound = perm.Length - 1
      Dim reverseThreshold = ubound - 1 ' helps to avoid calling Array.Reverse, when there is only one element to reverse
OUTPUT:
      Yield perm ' very fast but very unsafe to yield perm directly!
      For iPivot = reverseThreshold To 0 Step -1
         Dim pivot = perm(iPivot)
         If pivot >= perm(iPivot + 1) Then Continue For
         For iSwap = ubound To 0 Step -1
            If perm(iSwap) <= pivot Then Continue For
            perm(iPivot) = perm(iSwap)
            perm(iSwap) = pivot
            If iPivot < reverseThreshold Then Array.Reverse(perm, iPivot + 1, ubound - iPivot) '5
            GoTo OUTPUT
         Next
      Next
   End Function

End Module
<Flags> Public Enum CombinatoricMode
   Combination_NoRepetition = 0
   Combination_WithRepetitions
   Variation_NoRepetition
   Variation_WithRepetitions
End Enum