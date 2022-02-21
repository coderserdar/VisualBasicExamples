' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class Form1
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private StartPos As Integer = 0
    Private TextToShow As String = "Catch me if you can :)"
    Private Position As Integer = 20

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        Me.Refresh()
        Dim gra As Graphics = Me.CreateGraphics()
        gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        gra.DrawString(TextToShow, New Font("Arial", Position), New SolidBrush(Color.Black), StartPos, 35)
        StartPos += 10
        If StartPos >= Me.Width Then
            StartPos = TextToShow.Length * Position * -1
        End If
    End Sub
End Class
