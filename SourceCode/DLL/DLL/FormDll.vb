' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
' make sure that using DLL_library; & added references from DLL_library project ("DLL_library.dll")
Imports DLL_Library

Public Class FormDll
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dll As New ClasFromDLLLibrary
        MessageBox.Show(dll.ExampleMethod("This is typed from DLL!!!"))
    End Sub
End Class
