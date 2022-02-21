' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure to indlude reference System.Management; and using System.Management; is included

Public Class FormEnumarateNetwork
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Public Function ListOfComputers() As List(Of [String])
        Dim ComputersNames As New List(Of [String])()
        Dim Computers As [String] = "Computer"
        Dim _WinNTDirectoryEntries As New System.DirectoryServices.DirectoryEntry("WinNT:")
        For Each _AvailDomains As System.DirectoryServices.DirectoryEntry In _WinNTDirectoryEntries.Children
            For Each _PCNameEntry As System.DirectoryServices.DirectoryEntry In _AvailDomains.Children
                If _PCNameEntry.SchemaClassName.ToLower().Contains(Computers.ToLower()) Then
                    ComputersNames.Add(_PCNameEntry.Name)
                    listBox1.Items.Add(_PCNameEntry.Name.ToString())
                End If
            Next
        Next
        Return ComputersNames
    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ListOfComputers()
    End Sub
End Class
