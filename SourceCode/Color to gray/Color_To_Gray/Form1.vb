' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class Form1
    Private bit As Bitmap
    Private file As Image
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If pictureBox1.Image Is Nothing Then
            Return
        End If
        pictureBox1.Image = bit
        For x As Integer = 0 To bit.Width - 1
            For y As Integer = 0 To bit.Height - 1
                Dim originalColor As Color = bit.GetPixel(x, y)
                Dim grayScale As Integer = CInt(Math.Truncate((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11)))
                Dim newColor As Color = Color.FromArgb(grayScale, grayScale, grayScale)
                bit.SetPixel(x, y, newColor)
            Next
        Next
        pictureBox1.Image = bit
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        OpenFileDialog1.FileName = ""
        Dim dr As DialogResult = OpenFileDialog1.ShowDialog()

        If dr = DialogResult.OK Then
            file = Image.FromFile(OpenFileDialog1.FileName.ToString())
            pictureBox1.Image = file
            bit = New Bitmap(OpenFileDialog1.FileName.ToString())
        End If
    End Sub
End Class
