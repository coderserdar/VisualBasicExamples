' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure you have include using System.Runtime.InteropServices; for dllimport
Imports System.Runtime.InteropServices
' make sure you have include using System.Threading; for new thread (notepad)
Imports System.Threading

Public Class FormSendMessagesAndKeys
    <DllImport("user32.dll", EntryPoint:="FindWindowEx")>
    Public Shared Function FindWindowEx(hwndParent As IntPtr, hwndChild As IntPtr, lpszClass As String, lpszWindow As String) As IntPtr
    End Function
    <DllImport("user32.dll", EntryPoint:="SendMessage")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As String) As IntPtr
    End Function
    <DllImport("user32.dll", EntryPoint:="FindWindow")>
    Public Shared Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr
    End Function

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public process As Process

    Private Function SendKeystrokesToNotepad(text As String) As Integer
        process = Process.Start("notepad.exe")
        Thread.Sleep(500)
        Dim notepad? As IntPtr = FindWindow("notepad", vbNullString)
        Dim edit? As IntPtr = FindWindowEx(notepad, New IntPtr(0), "Edit", Nothing)
        If notepad Is Nothing Then
            Return 0
        End If
        'edit = FindWindowEx(notepad, New IntPtr(0), "Edit", Nothing)
        If edit Is Nothing Then
            Return 0
        End If
        ' 0x00C2 is macro which is replace for EM_REPLACESEL
        SendMessage(edit, &HC2, 0, text)
        Return 1

    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        SendKeystrokesToNotepad(textBox1.Text)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        process.Kill()
    End Sub
End Class
