' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Imports System.Runtime.InteropServices

Public Class FormSystemFonts

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)>
    Public Class LOGFONT
        Public lfHeight As Integer = 0
        Public lfWidth As Integer = 0
        Public lfEscapement As Integer = 0
        Public lfOrientation As Integer = 0
        Public lfWeight As Integer = 0
        Public lfItalic As Byte = 0
        Public lfUnderline As Byte = 0
        Public lfStrikeOut As Byte = 0
        Public lfCharSet As Byte = 0
        Public lfOutPrecision As Byte = 0
        Public lfClipPrecision As Byte = 0
        Public lfQuality As Byte = 0
        Public lfPitchAndFamily As Byte = 0
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public lfFaceName As String = String.Empty
    End Class

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        For Each font As FontFamily In FontFamily.Families
            listBox1.Items.Add(font.Name)
        Next
    End Sub
End Class
