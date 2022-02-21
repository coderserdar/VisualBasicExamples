' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
Imports System.IO

Public Class FormCreateBitmap
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim SomeImagePath As String = Directory.GetCurrentDirectory() + "\Koala.jpg"
        Dim MyImage As Image = Image.FromFile(SomeImagePath)
        Dim ConvertedImage As Image = ImageToRectangle(MyImage, New Size(50, 50), Imaging.ImageFormat.Jpeg)
        Dim SavePath As String = "C:\Koala.jpg" '<Replace with your path
        ConvertedImage.Save(SavePath)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function ImageToRectangle(ByVal aImage As Image, ByVal NewSize As Size, ByVal OutPutFormat As Imaging.ImageFormat) As Image
        Dim BitMap As New Bitmap(NewSize.Width, NewSize.Height)
        Dim G As Graphics = Graphics.FromImage(BitMap)
        Dim NewImageRectangle As New Rectangle(New Point(0, 0), NewSize)
        G.DrawImage(aImage, NewImageRectangle)
        Dim MS As New IO.MemoryStream
        Dim Tmp As Image = BitMap
        Tmp.Save(MS, OutPutFormat)
        Return Image.FromStream(MS)
    End Function
End Class
