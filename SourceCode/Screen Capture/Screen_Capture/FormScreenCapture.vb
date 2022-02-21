' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.IO; is included
' make sure that using System.Drawing.Imaging; is included
Imports System.Drawing.Imaging
Imports System.IO

Public Class FormScreenCapture
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private tempfile As String = "C://tempfile_.jpg"

    Private Sub ScreanCapture()
        If Directory.Exists(Path.GetDirectoryName(tempfile)) Then
            pictureBox1.Image = Nothing
            File.Delete(tempfile)
        End If
        Dim bounds As Rectangle = Me.Bounds
        Using bitmap As New Bitmap(bounds.Width, bounds.Height)
            Using g As Graphics = Graphics.FromImage(bitmap)
                g.CopyFromScreen(New Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size)
            End Using
            bitmap.Save(tempfile, ImageFormat.Jpeg)
        End Using
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ScreanCapture()
        Dim fs As New FileStream(tempfile, FileMode.Open)
        ' pictureBox1.Image = new Bitmap(tempfile);
        pictureBox1.Image = New Bitmap(fs)
        fs.Close()
    End Sub
End Class
