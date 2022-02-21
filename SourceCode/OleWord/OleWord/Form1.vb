' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using Microsoft.Office.Interop.Word; is included & added references Office 14 version

' make sure that using System.IO;
Imports System.IO

' make sure that using System.Threading;
Imports System.Threading

Public Class Form1
    Public filePath As String = "c:\msword.docx"

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Process.Start("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft Word 2010.lnk")
    End Sub

    Public Sub openWordDocument(filePath As String)
        Dim missing As Object = System.Reflection.Missing.Value

        'create a document in this path  
        Dim fileName As Object = filePath

        Dim wordApp As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Word.Application"))
        'Setup our Word.Document  
        Dim wordDoc As Object = wordApp.[GetType]().InvokeMember("Documents", System.Reflection.BindingFlags.GetProperty, Nothing, wordApp, Nothing)
        'Set Word to be not visible  
        wordApp.[GetType]().InvokeMember("Visible", System.Reflection.BindingFlags.SetProperty, Nothing, wordApp, New Object() {True})

        'Open the word document fileName  
        Dim activeDoc As Object = wordDoc.[GetType]().InvokeMember("Open", System.Reflection.BindingFlags.InvokeMethod, Nothing, wordDoc, New [Object]() {fileName})
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' create file
        If Not File.Exists(filePath) Then
            Using st As FileStream = System.IO.File.Create(filePath)
                Thread.Sleep(700)
            End Using
            openWordDocument(filePath)
        Else
            MessageBox.Show("Document already exists!" & vbLf & "Delete """ & filePath & """ to create new document!")
        End If
    End Sub
End Class
