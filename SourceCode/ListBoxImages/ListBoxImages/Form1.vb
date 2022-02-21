' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class Form1
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
End Class

Public Class CustomDrawListBox
    Inherits ListBox

    Public Sub New()
        Me.DrawMode = DrawMode.OwnerDrawVariable
        ' We're using custom drawing.
        ' Set the item height to 40.
        Me.ItemHeight = 40
    End Sub

    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        ' Make sure we're not trying to draw something that isn't there.
        If e.Index >= Me.Items.Count OrElse e.Index <= -1 Then
            Return
        End If

        ' Get the item object.
        Dim item As Object = Me.Items(e.Index)
        If item Is Nothing Then
            Return
        End If

        ' Draw the background color depending on 
        ' if the item is selected or not.
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            ' The item is selected.
            ' We want a blue background color.
            e.Graphics.FillRectangle(New SolidBrush(Color.Blue), e.Bounds)
        Else
            ' The item is NOT selected.
            ' We want a white background color.
            e.Graphics.FillRectangle(New SolidBrush(Color.White), e.Bounds)
        End If

        ' Draw the item.
        Dim text As String = item.ToString()
        Dim stringSize As SizeF = e.Graphics.MeasureString(text, Me.Font)
        e.Graphics.DrawString(text, Me.Font, New SolidBrush(Color.White), New PointF(5, e.Bounds.Y + (e.Bounds.Height - stringSize.Height) / 2))
    End Sub
End Class
