﻿' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class Form1
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        button1.TextAlign = ContentAlignment.MiddleLeft
    End Sub
End Class
