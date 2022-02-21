' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
Imports System.IO

Public Class FormDragDrop
    Public Sub New()
        MyBase.New
        InitializeComponent()
        ' put AllowDrop to true
        Me.AllowDrop = True
        ' declare and initialize new DragEventHandler
        AddHandler Me.DragEnter, New DragEventHandler(AddressOf FormDragDrop_DragEnter)
        AddHandler Me.DragDrop, New DragEventHandler(AddressOf FormDragDrop_DragDrop)
    End Sub

    Private Sub FormDragDrop_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        ' when the File is Dropped fill the array (files) with DragEventsArgs data's
        Dim files As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
        For Each file__1 As String In files
            ' replace basic file location of one slash to double slash
            textBox1.Text = File.ReadAllText(file__1.ToString().Replace("\", "\\"))
        Next
    End Sub

    Private Sub FormDragDrop_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        ' define DragEvents Effect to copy
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
End Class
