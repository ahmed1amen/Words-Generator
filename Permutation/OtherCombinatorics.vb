Public Module OtherCombinatorics

   Public Iterator Function CombinationWithRepeatingProjected(chooseK As Integer, fromN As Integer) As IEnumerable(Of Integer())
#If False Then
There is a "projection-Rule", to convert a Combination without Repetition to another, with Repetitions:
first add chooseK - 1 to fromN
permutate without repetitions
build result-projections by aggregating the gaps between the result-elements, from 2. position on:
eg 235 -> 223, because between 2 and 3 there is no gap, and between 3 and 5 there is a gap of 1
#End If
      fromN += chooseK - 1
      Dim output(chooseK - 1) As Integer
      Dim ubound = chooseK - 1
      For Each NoRepeatResult In ChooseKfromN(chooseK, fromN, CombinatoricMode.Combination_NoRepetition)
         Dim gap = NoRepeatResult(0)
         output(0) = gap
         'Projection from no-repetition-result to with-repetition-result: aggregate the gap between two elements and take it as value of the second
         For i = 1 To ubound
            gap += NoRepeatResult(i) - NoRepeatResult(i - 1) - 1
            output(i) = gap
         Next
         Yield output
      Next
   End Function
End Module
