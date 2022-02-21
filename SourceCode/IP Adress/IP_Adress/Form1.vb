' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' need namespace System.Net; 
' need namespace System.IO; 
Imports System.IO
Imports System.Net
' need namespace System.Net.Sockets; 
Imports System.Net.Sockets

Public Class Form1
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        listBox1.Items.Add(LocalIPAddress().ToString())
        label2.Text = GetPublicIP().ToString()
    End Sub

    Public Function LocalIPAddress() As String
        Dim host As IPHostEntry
        Dim localIP As String = ""
        host = Dns.GetHostEntry(Dns.GetHostName())
        For Each ip As IPAddress In host.AddressList
            If ip.AddressFamily = AddressFamily.InterNetwork Then
                localIP = ip.ToString()
                Exit For
            End If
        Next
        Return localIP
    End Function

    Public Function GetPublicIP() As String
        Dim direction As [String] = ""
        Dim request As WebRequest = WebRequest.Create("http://checkip.dyndns.org/")
        Using response As WebResponse = request.GetResponse()
            Using stream As New StreamReader(response.GetResponseStream())
                direction = stream.ReadToEnd()
            End Using
        End Using

        'Search for the ip in the html
        Dim first As Integer = direction.IndexOf("Address: ") + 9
        Dim last As Integer = direction.LastIndexOf("</body>")
        direction = direction.Substring(first, last - first)

        Return direction
    End Function
End Class
