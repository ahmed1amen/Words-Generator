Imports System.Runtime.CompilerServices
Imports System.IO

Class Extensions


    Public Sub Swap(Subj As IList, I1 As Integer, I2 As Integer)
        Dim Tmp = Subj(I1)
        Subj(I1) = Subj(I2)
        Subj(I2) = Tmp
    End Sub

    Private counter As Counter = 0

    Public Sub OutputLine(ints As Integer())
        Debug.WriteLine("{0,4}: {1}", counter.Up, String.Concat(ints))
    End Sub

    Public Function SelectMany(Of T)(operation As IEnumerable(Of IEnumerable(Of T))) As IEnumerable(Of T)
        Return operation.SelectMany(Function(o) o)
    End Function

    Public Sub OutputAll(operation As IEnumerable(Of Integer()))
        counter = 1
        For Each result In operation
            OutputLine(result)
        Next
        Debug.WriteLine("")
    End Sub

End Class


Public Class Counter
   Public Value As Integer = 0

   ''' <summary> gibt den aktuellen Wert zurück und incrementiert anschließend </summary>
   <DebuggerStepThrough()> _
   Public Function Up(Optional stp As Integer = 1) As Integer
      Up = Value
      Value += stp
   End Function

    ''' <summary> gibt den aktuellen Wert zurück und decrementiert anschließend </summary>
    <DebuggerStepThrough()> _
   Public Function Down() As Integer
      Return Up(-1)
   End Function
   ''' <summary>Decrementiert und returnt beim 0-Durchgang True</summary>
   <DebuggerStepThrough()> _
   Public Function Fallback() As Boolean
      Return Up(-1) = 0
   End Function
   ''' <summary>Decrementiert oder returnt False, wann 0 unterschritten würde</summary>
   <DebuggerStepThrough()> _
   Public Function TryFallback() As Boolean
      If Value < 1 Then Return False
      Value -= 1
      Return True
   End Function
   <DebuggerStepThrough()> _
   Public Shared Widening Operator CType(i As Integer) As Counter
      Return New Counter() With {.Value = i}
   End Operator
   <DebuggerStepThrough()> _
   Public Shared Widening Operator CType(i As Counter) As Integer
      Return i.Value
   End Operator
   <DebuggerStepThrough()> _
   Public Shared Operator &(left As String, right As Counter) As String
      Return right.Value.ToString
   End Operator
   <DebuggerStepThrough()> _
   Public Overrides Function ToString() As String
      Return Value.ToString()
   End Function
End Class