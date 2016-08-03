<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.WindowToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(763, 24)
    Me.MenuStrip1.TabIndex = 1
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'NewToolStripMenuItem
    '
    Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.CloseToolStripMenuItem})
    Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
    Me.NewToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
    Me.NewToolStripMenuItem.Text = "&File"
    '
    'NewToolStripMenuItem1
    '
    Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
    Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
    Me.NewToolStripMenuItem1.Text = "&New"
    '
    'CloseToolStripMenuItem
    '
    Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
    Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.CloseToolStripMenuItem.Text = "&Close"
    '
    'WindowToolStripMenuItem
    '
    Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
    Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
    Me.WindowToolStripMenuItem.Text = "&Window"
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(763, 512)
    Me.Controls.Add(Me.MenuStrip1)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "MainForm"
    Me.Text = "MainForm"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents NewToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
