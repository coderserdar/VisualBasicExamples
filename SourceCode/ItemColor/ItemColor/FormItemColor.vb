' make sure that using System.Diagnostics; is included
' make sure that using System.Security.Principal; is included

Public Class FormItemColor
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        listBox1.DrawMode = DrawMode.OwnerDrawFixed
        AddHandler listBox1.DrawItem, AddressOf listBox1_DrawItem
    End Sub

    Private Sub listBox1_DrawItem(sender As Object, e As DrawItemEventArgs)
        e.DrawBackground()
        Dim g As Graphics = e.Graphics

        Dim color__1 As Color = Color.Blue

        For i As Integer = 0 To listBox1.Items.Count - 1
            g.DrawString("ListBoxItem", e.Font, New SolidBrush(color__1), New PointF(e.Bounds.X, e.Bounds.Y))
        Next
        e.DrawFocusRectangle()
    End Sub
End Class
