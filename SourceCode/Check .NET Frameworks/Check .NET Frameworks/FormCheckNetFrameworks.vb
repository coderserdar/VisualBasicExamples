' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included
' make sure that using Microsoft.Win32.SafeHandles; is included
' make sure that using Microsoft.Win32; is included
Imports Microsoft.Win32

Public Class FormCheckNetFrameworks
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim hkNDP = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\NET Framework Setup\NDP", False)
        Keys(hkNDP, "")
        hkNDP.Close()
    End Sub

    Private Sub Keys(hk As RegistryKey, relPath As String)
        If relPath <> "" Then
            relPath += "/"
        End If

        For Each keyname As String In hk.GetSubKeyNames()
            Dim key = hk.OpenSubKey(keyname, False)

            Dim keySP = key.GetValue("SP")
            Dim keyVersion = key.GetValue("Version")
            If keyVersion IsNot Nothing Then
                listBox1.Items.Add(relPath & keyname & ": Version " & keyVersion.ToString() & (If((keySP IsNot Nothing), " SP " & keySP.ToString(), "")) & (If(1.Equals(key.GetValue("Install")), " installed", "")))
            End If

            Keys(key, relPath & keyname)

            key.Close()
        Next
    End Sub

End Class
