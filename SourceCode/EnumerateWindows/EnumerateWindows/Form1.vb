' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' namespace for DLL import
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Form1
    Protected Delegate Function EnumWindowsProc(hWnd As IntPtr, lParam As IntPtr) As Boolean
    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Protected Shared Function GetWindowText(hWnd As IntPtr, strText As StringBuilder, maxCount As Integer) As Integer
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Protected Shared Function GetWindowTextLength(hWnd As IntPtr) As Integer
    End Function
    <DllImport("user32.dll")>
    Protected Shared Function EnumWindows(enumProc As EnumWindowsProc, lParam As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll")>
    Protected Shared Function IsWindowVisible(hWnd As IntPtr) As Boolean
    End Function
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Protected Function EnumWindows(hWnd As IntPtr, lParam As IntPtr) As Boolean
        Dim size As Integer = GetWindowTextLength(hWnd)
        If System.Math.Max(System.Threading.Interlocked.Increment(size), size - 1) > 0 AndAlso IsWindowVisible(hWnd) Then
            Dim sb As New StringBuilder(size)
            GetWindowText(hWnd, sb, size)
            Me.ListBox1.Items.Add(sb.ToString())
        End If
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EnumWindows(New EnumWindowsProc(AddressOf EnumWindows), IntPtr.Zero)
    End Sub
End Class
