' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
Imports System.Threading

Public Class FormMutex
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        If Not IsSingleInstance() Then
            label1.Text = "There are more instance!"
        Else
            label1.Text = "Only one instance!"
        End If
        ' Put label in center
    End Sub

    ' Declare Mutex object
    Public mutexx As Mutex
    Public Function IsSingleInstance() As Boolean
        Try
            ' Open existing mutex
            Mutex.OpenExisting("Mutex")
        Catch
            ' Run new instance if app don't exist    
            mutexx = New Mutex(True, "Mutex")

            ' App start normally 
            Return True
        End Try
        ' Return false is app is already opened
        Return False
    End Function

End Class
