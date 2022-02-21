' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' IO it is needed for working with File object

Public Class FormTotalPhysicalMemory
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Shared Function GetTotalPhysicalMemory() As ULong
        Return New Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory
    End Function

    Private Shared Function ConvertBytesToMegabytes(bytes As Long) As Long
        Return (bytes \ 1024) \ 1024
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        MessageBox.Show(ConvertBytesToMegabytes(CLng(GetTotalPhysicalMemory())).ToString() & " MB")
    End Sub
End Class
