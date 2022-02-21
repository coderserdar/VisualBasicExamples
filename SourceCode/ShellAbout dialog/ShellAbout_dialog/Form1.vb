' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Runtime.InteropServices; is included
' make sure that using System.Reflection; is included
Imports System.Reflection
Imports System.Runtime.InteropServices

Public Class Form1
    <DllImport("shell32.dll")>
    Private Shared Function ShellAbout(hWnd As IntPtr, szApp As String, szOtherStuff As String, hIcon As IntPtr) As Integer
    End Function

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ShellAbout(Me.Handle, "AppName " & Assembly.GetExecutingAssembly().GetName().Version.ToString(), "", IntPtr.Zero)
    End Sub
End Class
