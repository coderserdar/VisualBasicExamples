' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class Form1
    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Private Sub createbuttons(sender As Object, e As EventArgs)
        Dim newButton As New Button()
        AddHandler newButton.Click, New EventHandler(AddressOf newButton_Clicked)
    End Sub

    Private Sub newButton_Clicked(sender As Object, e As EventArgs)
        For i As Integer = 0 To 4
            Dim button As New Button()
            button.Location = New Point(100, 30 * i + 10)
            AddHandler button.Click, New EventHandler(AddressOf buttonclickedoneevent)
            button.Tag = i
            button.Text = i.ToString()
            Me.Controls.Add(button)
        Next
    End Sub

    Private Sub buttonclickedoneevent(sender As Object, e As EventArgs)
        Dim button As Button = TryCast(sender, Button)
        If button IsNot Nothing Then
            For i As Integer = 0 To 4
                If button.Text = i.ToString() Then
                    MessageBox.Show(i.ToString())
                    Return
                End If
            Next
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        For i As Integer = 0 To 4
            Dim button As New Button()
            button.Location = New Point(Height \ 2, 30 * i + 10)
            AddHandler button.Click, New EventHandler(AddressOf createbuttons)
            button.Tag = i
            button.Text = i.ToString()
            Me.Controls.Add(button)
        Next
    End Sub
End Class
