' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

' make sure that using System.IO; is included
' make sure that using System.Drawing.Printing; is included
Imports System.Drawing.Printing
Imports System.IO

Public Class Form1

    Private Verdana11FontSize As Font
    Private Reader As StreamReader

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim filename As String = textBox1.Text.ToString()
        Reader = New StreamReader(filename)
        Verdana11FontSize = New Font("Verdana", 10)
        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, New PrintPageEventHandler(AddressOf Me.PrintTextFileHandler)
        pd.Print()
        If Reader IsNot Nothing Then
            Reader.Close()
        End If
    End Sub
    Private Sub PrintTextFileHandler(sender As Object, PrinterArgs As PrintPageEventArgs)
        Dim g As Graphics = PrinterArgs.Graphics
        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = PrinterArgs.MarginBounds.Left
        Dim topMargin As Single = PrinterArgs.MarginBounds.Top
        Dim line As String = Nothing

        linesPerPage = PrinterArgs.MarginBounds.Height / Verdana11FontSize.GetHeight(g)
        While count < linesPerPage AndAlso ((InlineAssignHelper(line, Reader.ReadLine())) IsNot Nothing)
            yPos = topMargin + (count * Verdana11FontSize.GetHeight(g))
            g.DrawString(line, Verdana11FontSize, Brushes.Black, leftMargin, yPos, New StringFormat())
            count += 1
        End While

        If line IsNot Nothing Then
            PrinterArgs.HasMorePages = True
        Else
            PrinterArgs.HasMorePages = False
        End If
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim filename As String = textBox1.Text.ToString()
        Reader = New StreamReader(filename)
        Verdana11FontSize = New Font("Verdana", 10)
        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, New PrintPageEventHandler(AddressOf Me.PrintTextFileHandler)
        pd.Print()
        If Reader IsNot Nothing Then
            Reader.Close()
        End If
    End Sub
End Class
