' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
' make sure include reference Windows Script Host Object 
' make sure that using IWshRuntimeLibrary; is included
Imports System.IO

Public Class FormCreateDesktopShortcut
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub ShortToDesktop(linkName As String)
        Dim deskDir As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)

        Using writer As New StreamWriter(deskDir & "\" & linkName & ".url")
            Dim app As String = System.Reflection.Assembly.GetExecutingAssembly().Location
            writer.WriteLine("[InternetShortcut]")
            writer.WriteLine("URL=file:///" & app)
            writer.WriteLine("IconIndex=0")
            Dim icon As String = app.Replace("\"c, "/"c)
            writer.WriteLine("IconFile=" & icon)
            writer.Flush()
        End Using
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ShortToDesktop(System.AppDomain.CurrentDomain.FriendlyName)
    End Sub
End Class
