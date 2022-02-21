' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class Form1
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        For Each item As String
 In comboBox1.Items
            If comboBox1.SelectedIndex = 0 Then
                ' no icon
                MessageBox.Show(textBox1.Text, "MessageBox", MessageBoxButtons.OK)
                Exit For
            End If
            If comboBox1.SelectedIndex = 1 Then
                ' info icon ...
                MessageBox.Show(textBox1.Text, "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit For
            End If
            If comboBox1.SelectedIndex = 2 Then
                ' question icon
                MessageBox.Show(textBox1.Text, "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Question)
                Exit For
            End If
            If comboBox1.SelectedIndex = 3 Then
                ' warning icon
                MessageBox.Show(textBox1.Text, "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit For
            End If
            If comboBox1.SelectedIndex = 4 Then
                ' error icon
                MessageBox.Show(textBox1.Text, "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Exit For
            End If
        Next
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim d As DialogResult = MessageBox.Show("Choose Yes or No", "MsgBox result", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If d = DialogResult.Yes Then
            MessageBox.Show("Your choice: YES", "MessageBoxExample", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
        If d = DialogResult.No Then
            MessageBox.Show("Your choice: NO", "MessageBoxExample", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub
End Class
