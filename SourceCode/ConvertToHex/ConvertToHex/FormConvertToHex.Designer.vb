<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConvertToHex
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
        Me.richTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'richTextBox2
        '
        Me.richTextBox2.Location = New System.Drawing.Point(196, 32)
        Me.richTextBox2.Name = "richTextBox2"
        Me.richTextBox2.Size = New System.Drawing.Size(183, 131)
        Me.richTextBox2.TabIndex = 25
        Me.richTextBox2.Text = ""
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(7, 32)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(183, 131)
        Me.richTextBox1.TabIndex = 24
        Me.richTextBox1.Text = ""
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(125, 169)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(139, 24)
        Me.button1.TabIndex = 23
        Me.button1.Text = "Convert to hex"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 200)
        Me.Controls.Add(Me.richTextBox2)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert to hex"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents richTextBox2 As System.Windows.Forms.RichTextBox
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Private WithEvents button1 As System.Windows.Forms.Button

End Class
