' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class FormConvertToHex
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Public Sub ConvertToHex(asciiString As String)
        Dim hex As String = ""
        For Each c As Char In asciiString
            Dim tmp As Integer = Asc(c)
            hex += [String].Format("{0:x2}", CUInt(System.Convert.ToUInt32(tmp.ToString())))
        Next
        richTextBox2.Text = hex.ToString()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ConvertToHex(richTextBox1.Text)
    End Sub
End Class
