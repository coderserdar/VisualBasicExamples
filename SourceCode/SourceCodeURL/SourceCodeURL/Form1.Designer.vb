<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblLink = New System.Windows.Forms.Label()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblLink.ForeColor = System.Drawing.Color.Navy
        Me.lblLink.Location = New System.Drawing.Point(179, 522)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(139, 16)
        Me.lblLink.TabIndex = 3
        Me.lblLink.Text = "www.vclexamples.com"
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(6, 33)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(489, 481)
        Me.richTextBox1.TabIndex = 26
        Me.richTextBox1.Text = ""
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(6, 7)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(489, 20)
        Me.textBox2.TabIndex = 25
        Me.textBox2.Text = "http://www.google.com.tr"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(155, 541)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(192, 24)
        Me.button1.TabIndex = 24
        Me.button1.Text = "Source Code of URL"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 572)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.lblLink)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Source Code of URL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblLink As System.Windows.Forms.Label
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents button1 As System.Windows.Forms.Button

End Class
