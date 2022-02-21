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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblLink = New System.Windows.Forms.Label()
        Me.button4 = New System.Windows.Forms.Button()
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblLink.ForeColor = System.Drawing.Color.Navy
        Me.lblLink.Location = New System.Drawing.Point(532, 750)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(139, 16)
        Me.lblLink.TabIndex = 3
        Me.lblLink.Text = "www.vclexamples.com"
        '
        'button4
        '
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button4.Location = New System.Drawing.Point(503, 9)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(72, 56)
        Me.button4.TabIndex = 34
        Me.button4.Text = "GO"
        Me.button4.UseVisualStyleBackColor = True
        '
        'webBrowser1
        '
        Me.webBrowser1.Location = New System.Drawing.Point(14, 97)
        Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(1141, 646)
        Me.webBrowser1.TabIndex = 33
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(348, 71)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(384, 20)
        Me.textBox1.TabIndex = 32
        Me.textBox1.Text = "http://www.google.com.tr"
        '
        'button5
        '
        Me.button5.Image = CType(resources.GetObject("button5.Image"), System.Drawing.Image)
        Me.button5.Location = New System.Drawing.Point(426, 9)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(72, 56)
        Me.button5.TabIndex = 31
        Me.button5.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
        Me.button3.Location = New System.Drawing.Point(582, 9)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(72, 56)
        Me.button3.TabIndex = 30
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Image = CType(resources.GetObject("button2.Image"), System.Drawing.Image)
        Me.button2.Location = New System.Drawing.Point(660, 9)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(72, 56)
        Me.button2.TabIndex = 29
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
        Me.button1.Location = New System.Drawing.Point(348, 9)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(72, 56)
        Me.button1.TabIndex = 28
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 749)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.webBrowser1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.lblLink)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Web Browser Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblLink As System.Windows.Forms.Label
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents button5 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button

End Class
