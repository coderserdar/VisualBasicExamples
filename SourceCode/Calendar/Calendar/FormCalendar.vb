' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class FormCalendar
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        If groupBox1.Visible = False Then
            groupBox1.Show()
        Else
            groupBox1.Hide()
            textBox1.Text = Nothing
        End If
    End Sub

    Private Sub monthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles monthCalendar1.DateChanged
        textBox1.Text = monthCalendar1.SelectionStart.ToString()
    End Sub
End Class
