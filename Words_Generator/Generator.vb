Public Class Generator
    Inherits Combinatorics
    Interface helpers
    End Interface
    Public Result_permutations As New List(Of String)()


    Private Sub Permute(ByVal permutations As List(Of String), ByVal possibilities As List(Of String), ByVal digitsLeft As Integer, ByVal current As String)

        If digitsLeft < 0 Then '
            Return
        End If
        'stop
        If digitsLeft = 0 Then
            permutations.Add(current)
            Return
        End If

        ' FLAGS
        For Each item In possibilities
            Permute(permutations, possibilities, digitsLeft - 1, current & item)
        Next item
    End Sub
    Public Sub StartGenerate(ByVal possibilities As List(Of String), ByVal howManyWords As Integer)

        Dim digits As Integer = howManyWords
        Permute(Result_permutations, possibilities, digits, "")

    End Sub


    Public Shared Function Create(array As Char()) As List(Of String)
        Return Generator.Create(array, False)
    End Function

    Public Shared Function Create(array As Char(), sort As Boolean) As List(Of String)
        If (array Is Nothing) Then
            Throw New ArgumentNullException("array")
        ElseIf ((array.Length < 0) OrElse (array.Length > 13)) Then
            Throw New ArgumentOutOfRangeException("array")
        End If
        Dim list As New List(Of String)
        Dim n As Integer = array.Length
        Generator.Permute(list, array, 0, array.Length)
        If (sort) Then
            list.Sort()
        End If
        Return list
    End Function

    Private Shared Sub Permute(list As List(Of String), array As Char(), start As Integer, n As Integer)
        Generator.Print(list, array, n)
        If (start < n) Then
            Dim i, j As Integer
            For i = (n - 2) To start Step -1
                For j = (i + 1) To (n - 1)
                    Generator.Swap(array, i, j)
                    Generator.Permute(list, array, (i + 1), n)
                Next
                Generator.RotateLeft(array, i, n)
            Next
        End If
    End Sub

    Private Shared Sub Print(list As List(Of String), array As Char(), size As Integer)
        If (array.Length <> 0) Then
            Dim s As Char() = New Char(size - 1) {}
            For i As Integer = 0 To (size - 1)
                s(i) = array(i)
            Next
            list.Add(s)
        End If
    End Sub

    Private Shared Sub RotateLeft(array As Char(), start As Integer, n As Integer)
        Dim tmp As Char = array(start)
        For i As Integer = start To (n - 2)
            array(i) = array(i + 1)
        Next
        array(n - 1) = tmp
    End Sub

    Private Shared Sub Swap(array As Char(), i As Integer, j As Integer)
        Dim tmp As Char
        tmp = array(i)
        array(i) = array(j)
        array(j) = tmp
    End Sub

End Class