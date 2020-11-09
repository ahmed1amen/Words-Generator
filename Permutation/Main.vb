Imports System.IO
Imports System.Windows.Forms

Public Module Main

   Private _fiMemo, _fiNew, _fiMemoUser, _fiNewUser As FileInfo

   Public Sub Main()
      Dim dir = Path.GetFullPath("..\..\TestMemento")
      _fiMemo = New FileInfo(Path.Combine(dir, "Memo.txt"))
      _fiNew = New FileInfo(Path.Combine(dir, "New.txt"))
      _fiMemoUser = New FileInfo(Path.Combine(dir, "Memo.User.txt"))
      _fiNewUser = New FileInfo(Path.Combine(dir, "New.User.txt"))
      AutomaticTests()

#If True Then
      Benchmarks()
#ElseIf True Then
#ElseIf True Then
      AutomaticTests()
#ElseIf True Then
ToOutputWindow
#ElseIf True Then
#End If
   End Sub

   Private Sub Benchmarks()
      Dim indicees = "0123456789".Select(AddressOf Integer.Parse)
      Dim sw = Stopwatch.StartNew

#If True Then
      Debug.WriteLine(Lf & "PermutationMicroOptimized:")
      sw.Restart()
      Debug.WriteLine("{0:n0} in {1}ms", Combinatorics.PermutationMicroOptimized(indicees).Count, sw.ElapsedMilliseconds)
#ElseIf True Then
      Debug.WriteLine(Lf & "Permutation 10 elements:")
      sw.Restart()
      Debug.WriteLine("{0:n0} in {1}ms", Combinatorics.Permutation(indicees).Count, sw.ElapsedMilliseconds)
#ElseIf True Then
      Debug.WriteLine(Lf & "ChooseKfromN(7, 10, Variation_WithRepetitions):")
      sw.Restart()
      Debug.WriteLine("{0:n0} in {1}ms", Combinatorics.ChooseKfromN(7, 10, CombinatoricMode.Variation_WithRepetitions).Count, sw.ElapsedMilliseconds)
#ElseIf True Then
#End If

   End Sub

   Private Sub ToOutputWindow()
#If True Then
      Combinatorics.Permutation("123".Select(AddressOf Integer.Parse).ToArray()).OutputAll()
#ElseIf True Then
      ChooseKfromN(3, 5, CombinatoricMode.Variation_WithRepetitions).OutputAll()
      ChooseKfromN(3, 5, CombinatoricMode.Variation_NoRepetition).OutputAll()
      ChooseKfromN(3, 5, CombinatoricMode.Combination_WithRepetitions).OutputAll()
      ChooseKfromN(3, 5, CombinatoricMode.Combination_NoRepetition).OutputAll()
      Combinatorics.Permutation("12334".Select(AddressOf Integer.Parse).ToArray).OutputAll()
#ElseIf True Then
      Combinatorics.Permutation("12334".Select(AddressOf Integer.Parse).ToArray).OutputAll()
#ElseIf True Then
      ChooseKfromN(3, 5, CombinatoricMode.Variation_WithRepetitions).OutputAll()
#ElseIf True Then
      ChooseKfromN(3, 5, CombinatoricMode.Variation_NoRepetition).OutputAll()
#ElseIf True Then
      ChooseKfromN(3, 5, CombinatoricMode.Combination_WithRepetitions).OutputAll()
#ElseIf True Then
      ChooseKfromN(3, 5, CombinatoricMode.Combination_NoRepetition).OutputAll()
#ElseIf True Then
#End If

   End Sub

   ''' <summary>
   ''' collects several tests and write them to a new Memo-File.
   ''' compares the new with the old memo and give User-Feedback, if a difference occurs.
   ''' Either you have messed up an algo, or you have changed the tests. In latter case you can accept the new Memo as new standard.
   ''' You can edit the files and copy to "Memo.User.txt" to make the output more readable. "Memo.User.txt" will not be overwritten on accepting a new standard.
   ''' </summary>
   Private Sub AutomaticTests()
      Dim newTests = New List(Of Integer()())
      newTests.Add(ChooseKfromN(1, 5, CombinatoricMode.Combination_NoRepetition).ToArray())
      newTests.Add(ChooseKfromN(1, 5, CombinatoricMode.Variation_NoRepetition).ToArray())
      newTests.Add(ChooseKfromN(1, 5, CombinatoricMode.Combination_WithRepetitions).ToArray())
      newTests.Add(ChooseKfromN(1, 5, CombinatoricMode.Variation_WithRepetitions).ToArray())

      newTests.Add(ChooseKfromN(5, 5, CombinatoricMode.Combination_NoRepetition).ToArray())
      newTests.Add(ChooseKfromN(5, 5, CombinatoricMode.Variation_NoRepetition).ToArray())
      newTests.Add(Combinatorics.Permutation("01234".Select(AddressOf Integer.Parse).ToArray()).ToArray())

      newTests.Add(ChooseKfromN(5, 5, CombinatoricMode.Combination_WithRepetitions).ToArray())
      newTests.Add(ChooseKfromN(5, 5, CombinatoricMode.Variation_WithRepetitions).ToArray())

      newTests.Add(ChooseKfromN(3, 5, CombinatoricMode.Combination_NoRepetition).ToArray())
      newTests.Add(ChooseKfromN(3, 5, CombinatoricMode.Variation_NoRepetition).ToArray())
      newTests.Add(ChooseKfromN(3, 5, CombinatoricMode.Combination_WithRepetitions).ToArray())
      newTests.Add(ChooseKfromN(3, 5, CombinatoricMode.Variation_WithRepetitions).ToArray())
      newTests.Add(Combinatorics.Permutation("12334".Select(AddressOf Integer.Parse).ToArray()).ToArray())

      ' check Permutation and MicroOptimized against each other
      Dim indicees = "12234".Select(AddressOf Integer.Parse)
      Dim m1 = Combinatorics.Permutation(indicees).ToArray()
      Dim m2 = Combinatorics.PermutationMicroOptimized(indicees).Select(AddressOf Enumerable.ToArray).ToArray()
      If Not m1.SelectMany().SequenceEqual(m2.SelectMany()) Then newTests.Add(m1) : newTests.Add(m2)

      ReportTests(newTests, _fiNew)
      If Not _fiNewUser.Exists Then _fiNew.CopyTo(_fiNewUser.FullName, True)
      If Not _fiMemoUser.Exists Then _fiNew.CopyTo(_fiMemoUser.FullName, True)

      Dim sOld = If(_fiMemo.Exists, File.ReadAllText(_fiMemo.FullName), "no Memo available")
      If sOld = File.ReadAllText(_fiNew.FullName) Then Return
      _fiNew.CopyTo(_fiNewUser.FullName, True)
      If MessageBox.Show(String.Format("Tests not equal the previous tests.{0}Click Yes to accept new tests as new standard", Lf), _
                         "Test-Divergence detected", MessageBoxButtons.YesNo) = DialogResult.Yes Then
         _fiNew.CopyTo(_fiMemo.FullName, True)
      End If
   End Sub
   Private Sub ReportTests(tests As List(Of Integer()()), fi As FileInfo)
      Dim lines = tests.Select(Function(tst) String.Join(" ", tst.Select(Function(result) String.Concat(result))) & Lf)
      If Not fi.Directory.Exists Then fi.Directory.Create()
      File.WriteAllLines(fi.FullName, lines)
   End Sub
End Module
