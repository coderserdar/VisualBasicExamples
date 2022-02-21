' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class Form1

    Public value_1 As Double
    Public value_2 As Double
    Public result As Double
    Public equal As String

    Public Sub New()
        MyBase.New()
        InitializeComponent()

    End Sub

    Private Sub buttonPlus_Click(sender As Object, e As EventArgs) Handles buttonPlus.Click
        value_1 = Double.Parse(textBox1.Text)
        textBox1.Text = ""
        equal = "+"
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        textBox1.Text = textBox1.Text + button1.Text
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textBox1.Text = textBox1.Text + button2.Text
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        textBox1.Text = textBox1.Text + button3.Text
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        textBox1.Text = textBox1.Text + button4.Text
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        textBox1.Text = textBox1.Text + button5.Text
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        textBox1.Text = textBox1.Text + button6.Text
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        textBox1.Text = textBox1.Text + button7.Text
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        textBox1.Text = textBox1.Text + button8.Text
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        textBox1.Text = textBox1.Text + button9.Text
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        textBox1.Text = textBox1.Text + button10.Text
    End Sub

    Private Sub buttonMinuse_Click(sender As Object, e As EventArgs) Handles buttonMinuse.Click
        value_1 = Double.Parse(textBox1.Text)
        textBox1.Text = ""
        equal = "-"
    End Sub

    Private Sub buttonMultiple_Click(sender As Object, e As EventArgs) Handles buttonMultiple.Click
        value_1 = Double.Parse(textBox1.Text)
        textBox1.Text = ""
        equal = "*"
    End Sub

    Private Sub buttonDivide_Click(sender As Object, e As EventArgs) Handles buttonDivide.Click
        value_1 = Double.Parse(textBox1.Text)
        textBox1.Text = ""
        equal = "/"
    End Sub

    Private Sub buttonEqual_Click(sender As Object, e As EventArgs) Handles buttonEqual.Click
        Select Case equal
            Case ("+")
                value_2 = Double.Parse(textBox1.Text)
                result = value_1 + value_2
                textBox1.Text = result.ToString()
                Exit Select

            Case ("-")
                value_2 = Double.Parse(textBox1.Text)
                result = value_1 - value_2
                textBox1.Text = result.ToString()
                Exit Select

            Case ("*")
                value_2 = Double.Parse(textBox1.Text)
                result = value_1 * value_2
                textBox1.Text = result.ToString()
                Exit Select

            Case ("/")
                value_2 = Double.Parse(textBox1.Text)
                result = value_1 / value_2
                textBox1.Text = result.ToString()
                Exit Select
        End Select
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        textBox1.Text = ""
    End Sub
End Class
