' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Runtime.InteropServices; is included
Imports System.Runtime.InteropServices

Public Class FormOsFunctions
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    <DllImport("user32.dll")>
    Public Shared Function ExitWindowsEx(operationFlag As Integer, operationReason As Integer) As Integer
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' Log off  the System 
        ExitWindowsEx(0, 0)
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ' Shut Down the System
        ExitWindowsEx(1, 0)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' Restart the System 
        ExitWindowsEx(2, 0)
    End Sub
End Class
