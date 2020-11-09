Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class Form1
    '
#Region "String Processing"
    'حساب وزن الجمله
    Public Function weight_Calc(ByVal str As String)
        'weight calculation
        Dim sum As Integer = 0
        For Each chX As String In str

            Dim VAl As Integer ' = SQL Query Get Char(chX) Value 
            sum += VAl
        Next
        Return sum
    End Function
    Public Function CharDuplicated(ByVal Full_String As String, ByVal chX As String)
        'حساب عدد مرات تكرار حرف معين
        Dim sum As Integer
        sum = Len(Full_String) - Len(Replace(Full_String, chX, ""))
        Return sum
    End Function
#End Region


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' list اضافه جدول الحروف الي 
        Dim Table_Of_ChX As New List(Of String)

        For i As Integer = 1 To 5
            Table_Of_ChX.Add(i)
        Next

        ' انشاء عمليه جديده يفضل ان تكون Thread
        'Dim t As New Thread(Sub() newGenerator.StartGenerate(Table_Of_ChX, 3))

        'If not (t.ThreadState = ThreadState.Running) Then

        ' do something
        'End If

        Dim newGenerator As New Generator
        newGenerator.StartGenerate(Table_Of_ChX, 3)

        ' newGenerator.Result_permutations.Count                عدد الكلمات التي تم تكوينها


        ' فلتره الكلمات

        For Each item In newGenerator.Result_permutations
            '  weight_Calc(item) ' الوزن
            ' CharDuplicated(item, "A") '  A عدد مرات تكرار حرف
            ' If item.Length = 4 Then MsgBox("الكلمه من 4 احرف")   

            TextBox1.AppendText(item & vbNewLine)
        Next item

    End Sub
End Class
