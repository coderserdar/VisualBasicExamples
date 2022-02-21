' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Threading; is included
Imports System.Threading

Public Class Form1
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Sub first_thread_procedure()
        Thread.Sleep(500)
        MessageBox.Show("Hello from first thread :) ... ")
    End Sub

    Public Sub second_thread_procedure()
        Thread.Sleep(1000)
        MessageBox.Show("Hello from second thread :) ... ")
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim first_thread As New Thread(New ThreadStart(AddressOf first_thread_procedure))
        Dim second_thread As New Thread(New ThreadStart(AddressOf second_thread_procedure))
        first_thread.Start()
        second_thread.Start()
        first_thread.Join()
    End Sub
End Class
