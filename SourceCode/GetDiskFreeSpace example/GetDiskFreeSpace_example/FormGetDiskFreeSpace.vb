' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Runtime.InteropServices; is included
Imports System.Runtime.InteropServices

Public Class FormGetDiskFreeSpace
    Public Sub New()
        MyBase.New
        InitializeComponent()
        comboBox1.SelectedIndex = 2
    End Sub

    Private Function ConvertBytesToMegabytes(bytes As ULong) As ULong
        Return (bytes \ 1024) \ 1024
    End Function

    Public Function GetDiskSizeTotal(volumeName As String, ByRef avail As ULong, ByRef total As ULong, ByRef totalfree As ULong) As ULong
        [MyClass].GetDiskFreeSpaceEx(volumeName, avail, total, totalfree)
        Return total
    End Function

    Public Function GetDiskSize(volumeName As String) As ULong
        Dim avail As ULong = 0
        Dim total As ULong = 0
        Dim totalfree As ULong = 0
        [MyClass].GetDiskFreeSpaceEx(volumeName, avail, total, totalfree)
        Return total
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim avail As ULong = 0, total As ULong = 0, totalfree As ULong = 0
        ' read size
        GetDiskSizeTotal(comboBox1.SelectedItem.ToString(), avail, total, totalfree)
        ' write size in label
        label1.Text = "Avaliable disk space (for this user): " & ConvertBytesToMegabytes(avail).ToString() & " MB"
        label2.Text = "Total disk space: " & ConvertBytesToMegabytes(GetDiskSizeTotal(comboBox1.SelectedItem.ToString(), avail, total, totalfree)) & " MB"
        label3.Text = "Free disk space: " & ConvertBytesToMegabytes(avail).ToString() & " MB"
    End Sub
End Class

Public Class [MyClass]
    ' import from kernel32.dll function GetDiskFreeSpaceEx (total amount)
    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Friend Shared Function GetDiskFreeSpaceEx(lpDirectoryName As String, ByRef lpFreeBytesAvailable As ULong, ByRef lpTotalNumberOfBytes As ULong, ByRef lpTotalNumberOfFreeBytes As ULong) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    ' import from kernel32.dll function GetDiskFreeSpaceEx
    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Friend Shared Function GetDiskFreeSpace(GetDiskFreeSpaces As ULong, ByRef lpSectorsPerCluster As ULong, ByRef lpBytesPerSector As ULong, ByRef lpNumberOfFreeClusters As ULong, ByRef lpTotalNumberOfClusters As ULong) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
End Class
