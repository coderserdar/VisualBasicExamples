' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
Imports System.Drawing.Imaging
Imports System.IO

Public Class Form1
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' set Filename to blank
        OpenFileDialog1.FileName = ""
        ' fileter onyl bmp files
        OpenFileDialog1.Filter = "BMP files (*.bmp)|*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim raw As Byte() = System.IO.File.ReadAllBytes(OpenFileDialog1.FileName)
            Path.GetDirectoryName(OpenFileDialog1.FileName)
            Using img As Image = Image.FromStream(New MemoryStream(raw))
                img.Save(OpenFileDialog1.InitialDirectory + OpenFileDialog1.FileName.Replace(".bmp", ".jpg"), ImageFormat.Jpeg)
            End Using
        End If
    End Sub
End Class
