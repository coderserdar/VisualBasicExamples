' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Drawing.Drawing2D; is included
Imports System.Drawing.Drawing2D

Public Class FormPanelGradient
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim brush As Brush = New LinearGradientBrush(panel1.ClientRectangle, Color.Black, Color.White, LinearGradientMode.ForwardDiagonal)
        panel1.CreateGraphics().FillRectangle(brush, panel1.ClientRectangle)
    End Sub
End Class
