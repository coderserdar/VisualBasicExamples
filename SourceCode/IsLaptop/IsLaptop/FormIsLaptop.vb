' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.Diagnostics; is included
Imports System.Management

' add reference system.management (.NET directory)

Public Class FormIsLaptop
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Public Enum ChassisTypes
        Other = 1
        Unknown
        Desktop
        LowProfileDesktop
        PizzaBox
        MiniTower
        Tower
        Portable
        Laptop
        Notebook
        Handheld
        DockingStation
        AllInOne
        SubNotebook
        SpaceSaving
        LunchBox
        MainSystemChassis
        ExpansionChassis
        SubChassis
        BusExpansionChassis
        PeripheralChassis
        StorageChassis
        RackMountChassis
        SealedCasePC
    End Enum

    Public Shared Function GetCurrentChassisType() As ChassisTypes
        Dim systemEnclosures As New ManagementClass("Win32_SystemEnclosure")
        For Each obj As ManagementObject In systemEnclosures.GetInstances()
            For Each i As Integer In DirectCast(obj("ChassisTypes"), UInt16())
                If i > 0 AndAlso i < 25 Then
                    Return CType(i, ChassisTypes)
                End If
            Next
        Next
        Return ChassisTypes.Unknown
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        MessageBox.Show(GetCurrentChassisType().ToString())
    End Sub
End Class
