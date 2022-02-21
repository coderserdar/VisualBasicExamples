' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class Form1
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub closeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        notifyIcon1.Visible = False
    End Sub

    Private Sub showApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Show()
    End Sub

    Private Sub hideAplicationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        notifyIcon1.Visible = True
        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        notifyIcon1.BalloonTipText = "Application working..."
        notifyIcon1.BalloonTipTitle = "TrayIcon example application"
        notifyIcon1.ShowBalloonTip(2000)
    End Sub
End Class
