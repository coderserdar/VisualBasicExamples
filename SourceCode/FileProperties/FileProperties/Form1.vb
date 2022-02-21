' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Runtime.InteropServices; is included
' make sure that using System.IO; is included
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form1
    Inherits Form
    <DllImport("shell32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function ShellExecuteEx(ByRef lpExecInfo As SHELLEXECUTEINFO) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)>
    Public Structure SHELLEXECUTEINFO
        Public cbSize As Integer
        Public fMask As UInteger
        Public hwnd As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)>
        Public lpVerb As String
        <MarshalAs(UnmanagedType.LPTStr)>
        Public lpFile As String
        <MarshalAs(UnmanagedType.LPTStr)>
        Public lpParameters As String
        <MarshalAs(UnmanagedType.LPTStr)>
        Public lpDirectory As String
        Public nShow As Integer
        Public hInstApp As IntPtr
        Public lpIDList As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)>
        Public lpClass As String
        Public hkeyClass As IntPtr
        Public dwHotKey As UInteger
        Public hIcon As IntPtr
        Public hProcess As IntPtr
    End Structure

    Private Const SW_SHOW As Integer = 5
    Private Const SEE_MASK_INVOKEIDLIST As UInteger = 12

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Shared Function ShowFileProperties(Filename As String) As Boolean
        Dim info As New SHELLEXECUTEINFO()
        info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info)
        info.lpVerb = "properties"
        info.lpFile = Filename
        info.nShow = SW_SHOW
        info.fMask = SEE_MASK_INVOKEIDLIST
        Return ShellExecuteEx(info)
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ShowFileProperties(Path.GetFullPath(openFileDialog1.FileName))
        End If
    End Sub
End Class
