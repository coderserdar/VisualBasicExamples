' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class Form1
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Function GetScreen() As Rectangle
        Return Screen.FromControl(Me).Bounds
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        MessageBox.Show(GetScreen().ToString())
    End Sub
End Class
