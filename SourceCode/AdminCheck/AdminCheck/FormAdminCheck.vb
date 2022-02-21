' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
Imports System.Security.Principal

Public Class FormAdminCheck
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Public Shared Function IsAdministrator() As Boolean
        Dim identity As WindowsIdentity = WindowsIdentity.GetCurrent
        Dim principal As WindowsPrincipal = New WindowsPrincipal(identity)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
        Dim admin As String = IsAdministrator()
        If admin Then
            MessageBox.Show("User is admin!")
        Else
            MessageBox.Show("User is not admin!")
        End If

    End Sub
End Class
