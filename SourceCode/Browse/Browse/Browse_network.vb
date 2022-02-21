Public Class Browse_network

    Public Function ListOfComputers() As List(Of [String])
        Dim ComputerNames As New List(Of [String])()
        Dim _ComputerSchema As [String] = "Computer"
        Dim _WinNTDirectoryEntries As New System.DirectoryServices.DirectoryEntry("WinNT:")
        For Each _AvailDomains As System.DirectoryServices.DirectoryEntry In _WinNTDirectoryEntries.Children
            For Each PCNames As System.DirectoryServices.DirectoryEntry In _AvailDomains.Children
                If PCNames.SchemaClassName.ToLower().Contains(_ComputerSchema.ToLower()) Then
                    ComputerNames.Add(PCNames.Name)
                    listBox1.Items.Add(PCNames.Name)
                End If
            Next
        Next
        Return ComputerNames
    End Function

    Private Sub Browse_network_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListOfComputers()
    End Sub
End Class