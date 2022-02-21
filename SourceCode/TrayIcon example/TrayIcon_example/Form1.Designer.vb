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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.c = New System.Windows.Forms.CheckBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.hideAplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.showApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Location = New System.Drawing.Point(121, 25)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(98, 17)
        Me.c.TabIndex = 20
        Me.c.Text = "Show TrayIcon"
        Me.c.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(109, 60)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(128, 36)
        Me.button1.TabIndex = 19
        Me.button1.Text = "Show TrayIcon hint"
        Me.button1.UseVisualStyleBackColor = True
        '
        'notifyIcon1
        '
        Me.notifyIcon1.ContextMenuStrip = Me.contextMenuStrip1
        Me.notifyIcon1.Icon = CType(resources.GetObject("notifyIcon1.Icon"), System.Drawing.Icon)
        Me.notifyIcon1.Text = "notifyIcon1"
        Me.notifyIcon1.Visible = True
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hideAplicationToolStripMenuItem, Me.showApplicationToolStripMenuItem, Me.closeToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(166, 70)
        '
        'hideAplicationToolStripMenuItem
        '
        Me.hideAplicationToolStripMenuItem.Name = "hideAplicationToolStripMenuItem"
        Me.hideAplicationToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.hideAplicationToolStripMenuItem.Text = "Hide application"
        '
        'showApplicationToolStripMenuItem
        '
        Me.showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem"
        Me.showApplicationToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.showApplicationToolStripMenuItem.Text = "Show application"
        '
        'closeToolStripMenuItem
        '
        Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
        Me.closeToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.closeToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 115)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrayIcon example"
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents c As System.Windows.Forms.CheckBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents notifyIcon1 As System.Windows.Forms.NotifyIcon
    Private WithEvents contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents hideAplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents showApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents closeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
