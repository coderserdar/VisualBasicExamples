' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class FormDialogs
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Application.[Exit]()
    End Sub

    Private Sub saveasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles saveasToolStripMenuItem.Click
        saveFileDialog1.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
        Me.Text = saveFileDialog1.FileName
    End Sub

    Private Sub newToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newToolStripMenuItem.Click
        richTextBox1.Clear()
    End Sub

    Private Sub fontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles fontToolStripMenuItem.Click
        ' let me show font dialog
        Dim result As DialogResult = fontDialog1.ShowDialog()
        ' if OK was pressed
        If result = DialogResult.OK Then
            ' take font 
            Dim font As Font = fontDialog1.Font
            ' set font
            Me.richTextBox1.Font = font
        End If
    End Sub
End Class
