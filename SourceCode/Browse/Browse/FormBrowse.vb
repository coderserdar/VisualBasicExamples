' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
' WARRNING: also be sure to include System.DirectoryServices as reference

Public Class FormBrowse
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        FolderBrowserDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim test As New Browse_network()
        test.ShowDialog()
    End Sub
End Class
