' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Net.NetworkInformation; is included
Imports System.Net.NetworkInformation
' make sure that using System.Threading; is included for method Sleep

Public Class Form1
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        For i As Integer = 0 To 3
            ' Thread.Sleep(500);
            Using p As New Ping()
                ' label1.Text = p.Send("www.google.com").RoundtripTime.ToString() + "ms";
                listView1.Items.Add(p.Send("www.google.com").RoundtripTime.ToString() & "ms" & vbLf)
            End Using
        Next
    End Sub
End Class
