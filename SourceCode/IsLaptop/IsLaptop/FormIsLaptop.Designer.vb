<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIsLaptop
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(30, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(263, 13)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Are you running this application on a laptop computer?"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(110, 54)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(109, 24)
        Me.button1.TabIndex = 21
        Me.button1.Text = "Check"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 91)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Runnin on laptop?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button

End Class
