' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Net; is included
' make sure that using System.IO;  is included
Imports System.IO
Imports System.Net

Public Class FormSourceCodeUrl
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Url As String = textBox2.Text
        Dim Request As HttpWebRequest = DirectCast(WebRequest.Create(Url), HttpWebRequest)
        Dim Response As HttpWebResponse = DirectCast(Request.GetResponse(), HttpWebResponse)
        Dim Stream As New StreamReader(Response.GetResponseStream())
        richTextBox1.Text = Stream.ReadToEnd()
        Stream.Close()
    End Sub
End Class
