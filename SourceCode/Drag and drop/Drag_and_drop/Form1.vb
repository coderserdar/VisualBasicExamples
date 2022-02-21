' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
Imports System.IO

Public Class Form1
    Public Sub New()
        MyBase.New
        InitializeComponent()
        ' put AllowDrop to true
        Me.AllowDrop = True
        ' declare and initialize new DragEventHandler
        AddHandler Me.DragEnter, New DragEventHandler(AddressOf Form1_DragEnter)
        AddHandler Me.DragDrop, New DragEventHandler(AddressOf Form1_DragDrop)
    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs)
        ' define DragEvents Effect to copy
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs)
        ' when the File is Dropped fill the array (files) with DragEventsArgs data's
        Dim files As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
        For Each file__1 As String In files
            ' replace basic file location of one slash to double slash
            textBox1.Text = File.ReadAllText(file__1.ToString().Replace("\", "\\"))
        Next
    End Sub

End Class
