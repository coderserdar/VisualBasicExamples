Imports System.ComponentModel
' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Net; is included
Imports System.Net

Public Class Form1
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private webClient As New WebClient()

    Private Sub webClient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        progressBar1.Value = Integer.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub webclient_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)
        MessageBox.Show("Saved as C:\MYRAR.EXE", "Httpdownload")
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        AddHandler webClient.DownloadProgressChanged, New DownloadProgressChangedEventHandler(AddressOf webClient_DownloadProgressChanged)
        AddHandler webClient.DownloadFileCompleted, New AsyncCompletedEventHandler(AddressOf webclient_DownloadFileCompleted)
        ' start download
        webClient.DownloadFileAsync(New Uri(textBox1.Text), "C:\\MYRAR.EXE")
    End Sub
End Class
