' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class FormAlwaysOnTop
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Public Shared Function AlwaysOnTop() As Boolean
        FormAlwaysOnTop.TopMost = True
        Return FormAlwaysOnTop.TopMost
    End Function

    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
        AlwaysOnTop()
    End Sub
End Class
