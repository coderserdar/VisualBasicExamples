' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class Form1
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub GetDrivers()
        Dim query As New System.Management.SelectQuery("Win32_SystemDriver")
        Dim searcher As New System.Management.ManagementObjectSearcher(query)
        af.Items.Clear()
        For Each ManageObject As System.Management.ManagementObject In searcher.[Get]()
            af.Items.Add((((("Name: " + ManageObject("Name") & " StartMode: ") + ManageObject("StartMode") & " State: ") + ManageObject("State") & " Description: ") + ManageObject("Description") & " PathName: ") + ManageObject("PathName"))
        Next
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        GetDrivers()
    End Sub
End Class
