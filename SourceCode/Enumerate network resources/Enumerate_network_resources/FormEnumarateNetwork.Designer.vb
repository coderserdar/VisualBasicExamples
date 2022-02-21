<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnumarateNetwork
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.SuspendLayout()
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(5, 8)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(319, 225)
        Me.listBox1.TabIndex = 30
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(11, 263)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(306, 24)
        Me.button2.TabIndex = 29
        Me.button2.Text = "Enumerate network resources"
        Me.button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 295)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enumerate network resources"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents listBox1 As System.Windows.Forms.ListBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry

End Class
