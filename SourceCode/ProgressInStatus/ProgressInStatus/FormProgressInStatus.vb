' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class FormProgressInStatus
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To toolStripProgressBar1.Maximum - 1
            toolStripProgressBar1.Value += 1
            If toolStripProgressBar1.Value = 80 Then
                Return
            End If
        Next
    End Sub
End Class
