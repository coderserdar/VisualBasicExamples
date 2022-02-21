' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class FormSafeModeDetection
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If SystemInformation.BootMode <> BootMode.Normal Then
            MessageBox.Show("System is running in safe mode")
        Else
            MessageBox.Show("System is running in normal boot mode")
        End If
    End Sub
End Class
