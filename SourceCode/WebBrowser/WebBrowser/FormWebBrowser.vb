' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class FormWebBrowser
    Public Sub New()
        MyBase.New()
        InitializeComponent()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        webBrowser1.GoBack()
        textBox1.Text = webBrowser1.Url.ToString()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        webBrowser1.Refresh()
        textBox1.Text = webBrowser1.Url.ToString()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        webBrowser1.[Stop]()
        textBox1.Text = webBrowser1.Url.ToString()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        webBrowser1.GoForward()
        textBox1.Text = webBrowser1.Url.ToString()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        webBrowser1.Navigate(textBox1.Text)
    End Sub
End Class
