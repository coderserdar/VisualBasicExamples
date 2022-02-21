' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
' make sure that using System.IO; is included
Imports System.IO

Public Class Form1
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim filepath As String = "c:\CreateFileExample.txt"
        Using fs = File.Create(filepath)
            For Each a As String In richTextBox1.Text
                'fs.WriteByte(CByte(a))
                fs.WriteByte(Asc(a))
            Next
        End Using
        If File.Exists(filepath) Then
            Process.Start(filepath)
        End If
    End Sub
End Class
