Imports System.ComponentModel
' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class FormBackgroundWorker
    Public Sub New()
        MyBase.New
        InitializeComponent()
        AddHandler Shown, New EventHandler(AddressOf Form1_Shown)

        BackgroundWorker1.WorkerReportsProgress = True

        AddHandler BackgroundWorker1.DoWork, AddressOf backgroundWorker1_DoWork

        AddHandler BackgroundWorker1.ProgressChanged, AddressOf backgroundWorker1_ProgressChanged

    End Sub

    Private Sub backgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        progressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub backgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs)
        For i As Integer = 0 To 100
            BackgroundWorker1.ReportProgress(i)
            Threading.Thread.Sleep(100)
        Next

    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs)
        BackgroundWorker1.RunWorkerAsync()
    End Sub

End Class
