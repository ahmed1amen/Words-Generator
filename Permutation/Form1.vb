Imports System.Text
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports BigMath

Public Class Form1

   Private _Modes As CombinatoricMode() = {CombinatoricMode.Combination_NoRepetition, CombinatoricMode.Combination_WithRepetitions, CombinatoricMode.Variation_NoRepetition, CombinatoricMode.Variation_WithRepetitions}

   Private _rgxWords As New Regex("\s+")

   Public Sub New()
      InitializeComponent()
      cmbMode.DataSource = _Modes
      UpdateWordCount()
   End Sub

   Private Sub AnythingHappend(sender As Object, e As EventArgs) Handles btCountWords.Click, btApply2Words.Click, btApplyNumeric.Click, cmbMode.SelectedIndexChanged, ckRespectOrder.CheckedChanged, ckWithRepetitions.CheckedChanged, btPermutateWords.Click
      Select Case True
         Case sender Is btPermutateWords : PermutateWords()

         Case sender Is btCountWords : UpdateWordCount()

         Case sender Is btApply2Words : Apply2Words(CInt(numChooseK.Value), CInt(numFromN.Value), _Modes(cmbMode.SelectedIndex))

         Case sender Is btApplyNumeric : ApplyNumeric(CInt(numChooseK.Value), CInt(numFromN.Value), _Modes(cmbMode.SelectedIndex))

         Case sender Is ckRespectOrder, sender Is ckWithRepetitions 'synchronisize CombinatoricMode with Checkboxes
            Dim i = Convert.ToInt32(ckRespectOrder.Checked) * 2 + Convert.ToInt32(ckWithRepetitions.Checked)
            cmbMode.SelectedIndex = i

         Case sender Is cmbMode 'synchronisize CombinatoricMode with Checkboxes
            Dim mode = _Modes(cmbMode.SelectedIndex)
            ckRespectOrder.Checked = (mode And CombinatoricMode.Variation_NoRepetition) = CombinatoricMode.Variation_NoRepetition
            ckWithRepetitions.Checked = (mode And CombinatoricMode.Combination_WithRepetitions) = CombinatoricMode.Combination_WithRepetitions
      End Select
   End Sub

   Private Sub UpdateWordCount()
      Dim wrdCount As Long= _rgxWords.Split(txtInput.Text.Trim).Length
      numFromN.Value = wrdCount
      lbWordCount.Text = wrdCount.ToString
   End Sub

   Private Sub PermutateWords()
      Dim words = _rgxWords.Split(txtInput.Text.Trim)
        If words.Length > 7 Then
            txtOutput.Text = "Many permutations requested - may take some time..."
            txtOutput.Refresh()
        End If
        If words.Length > 9 Then
            MessageBox.Show("avoid to input more than 9 Word - Richtextbox has Trouble to display millions of results ( eg 10! = 3.628.800 )")
            '    Return
        End If
        Dim wordCounts = From w In words Group By w Into Count() Select Count
      Dim indexCounter As Counter = 0
      Dim indicees = wordCounts.SelectMany(Function(cnt) Enumerable.Repeat(indexCounter.Up, cnt))
      Dim distinctWords = words.Distinct.ToArray
      Dim sb = New StringBuilder()
        Dim counter As Int256 = 0
        For Each result In Combinatorics.Permutation(indicees)
         sb.AppendLine(String.Join(" ", result.Select(Function(i) distinctWords(i))))
         counter += 1
      Next
        txtOutput.Text = String.Concat("Permutating the given set of word yields ", counter, " results")
    End Sub

   Private Sub Apply2Words(chooseK As Integer, fromN As Integer, mode As CombinatoricMode)
      'demo, how to transform the int-results to any other DataType: Just take them as Indicees of an Source-Element-Array (of any type).
      Dim sb = New StringBuilder()
      Dim words = _rgxWords.Split(txtInput.Text.Trim)
      If words.Length <> fromN Then
         MessageBox.Show("number of words must equal the fromN-Parameter")
            '   Return
        End If
        Dim counter As Int256 = 0
        For Each result In Combinatorics.ChooseKfromN(chooseK, fromN, mode)
            sb.AppendLine(String.Join(" ", result.Select(Function(i) words(i))))
            counter += 1

        Next
      txtOutput.Text = String.Concat(Preambel(chooseK, fromN, mode), counter, " results", Lf, Lf, sb.ToString)
   End Sub

    Private Sub ApplyNumeric(chooseK As Integer, fromN As Integer, mode As CombinatoricMode)
        Dim sb = New StringBuilder()
        Dim counter = 0
        For Each result In Combinatorics.ChooseKfromN(chooseK, fromN, mode)
            sb.Append(String.Concat(result)).Append(" ")
            counter += 1
        Next
        txtOutput.Text = String.Concat(Preambel(chooseK, fromN, mode), counter, " results", Lf, Lf, sb.ToString)
    End Sub
    Private Function Preambel(chooseK As Integer, fromN As Integer, mode As CombinatoricMode) As String
      Dim sElementSet = String.Concat(Enumerable.Range(0, fromN))
      Return String.Format("CombinatoricMode.{1}{0}choose {2} from {3} {{{4}}}{0}", Lf, mode, chooseK, fromN, sElementSet)
   End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class