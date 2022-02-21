' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Runtime.InteropServices; is included
Imports System.Runtime.InteropServices

Public Class Form1
    <StructLayout(LayoutKind.Sequential)>
    Public Structure PointStruct
        Public X As Integer
        Public Y As Integer

        Public Shared Widening Operator CType(point As Point) As PointStruct
            Return New Point(point.X, point.Y)
        End Operator
    End Structure

    <DllImport("user32.dll")>
    Public Shared Function GetCursorPos(ByRef lpPoint As Point) As Boolean
    End Function

    Public Shared Function GetCursorPosition() As Point
        Dim lpPoint As Point
        GetCursorPos(lpPoint)
        Return lpPoint
    End Function

    Public Sub New()
        MyBase.New()
        InitializeComponent()

    End Sub

    Private Sub Form1_MouseMove_1(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        label1.Text = GetCursorPosition().ToString()
    End Sub
End Class
