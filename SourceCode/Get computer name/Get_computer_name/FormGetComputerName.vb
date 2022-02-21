' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class FormGetComputerName
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        MessageBox.Show("Computer name: " & System.Environment.MachineName.ToString(), "GetComputername")
    End Sub
End Class
