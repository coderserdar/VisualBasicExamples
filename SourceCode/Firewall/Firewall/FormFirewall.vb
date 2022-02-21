' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Threading; is included

Public Class FormFirewall
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim firewall As New Process()
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "\windows\system32\"
        firewall.StartInfo.Arguments = "/c netsh firewall set opmode mode=disable"
        firewall.Start()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim firewall As New Process()
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "\windows\system32\"
        firewall.StartInfo.Arguments = "/c netsh firewall set opmode mode=enable"
        firewall.Start()
    End Sub
End Class
