' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is includeda
' make sure that using System.Runtime.InteropServices; is included
Imports System.Runtime.InteropServices

Public Class Form1
    Private SC_MONITORPOWER As Integer = &HF170
    Private WM_SYSCOMMAND As UInteger = &H112

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As UInteger, wParam As IntPtr, lParam As IntPtr) As IntPtr

    End Function
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        SendMessage(Me.Handle, WM_SYSCOMMAND, CType(SC_MONITORPOWER, IntPtr), CType(2, IntPtr))
    End Sub
End Class
