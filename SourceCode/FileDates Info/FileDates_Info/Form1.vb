' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.IO; is included
Imports System.IO

Public Class Form1
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Public Sub FileDataInfo(file As String)

        Dim info As New FileInfo(file)

        Dim time As DateTime = info.CreationTime

        time = info.LastWriteTime

        listBox1.Items.Add(time.ToString())

        time = info.LastAccessTime

        '  MessageBox.Show(time.ToString());

        '  
        '   Console.WriteLine(time.ToString());

        listBox1.Items.Add(time.ToString())
    End Sub

    Private Sub listBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox1.SelectedIndexChanged

    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            FileDataInfo(Path.GetFullPath(OpenFileDialog1.FileName))
        End If
    End Sub
End Class
