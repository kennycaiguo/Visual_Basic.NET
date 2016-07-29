<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.TextBoxNum1 = New System.Windows.Forms.TextBox()
        Me.TextBoxNum2 = New System.Windows.Forms.TextBox()
        Me.TextBoxNum3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSubtract = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNum1
        '
        Me.TextBoxNum1.BackColor = System.Drawing.Color.Yellow
        Me.TextBoxNum1.Location = New System.Drawing.Point(132, 9)
        Me.TextBoxNum1.Name = "TextBoxNum1"
        Me.TextBoxNum1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNum1.TabIndex = 0
        '
        'TextBoxNum2
        '
        Me.TextBoxNum2.BackColor = System.Drawing.Color.Yellow
        Me.TextBoxNum2.Location = New System.Drawing.Point(132, 46)
        Me.TextBoxNum2.Name = "TextBoxNum2"
        Me.TextBoxNum2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNum2.TabIndex = 1
        '
        'TextBoxNum3
        '
        Me.TextBoxNum3.BackColor = System.Drawing.Color.Yellow
        Me.TextBoxNum3.Location = New System.Drawing.Point(132, 88)
        Me.TextBoxNum3.Name = "TextBoxNum3"
        Me.TextBoxNum3.ReadOnly = True
        Me.TextBoxNum3.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNum3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Results"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(47, 130)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(50, 43)
        Me.ButtonAdd.TabIndex = 6
        Me.ButtonAdd.Text = "+"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSubtract
        '
        Me.ButtonSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubtract.Location = New System.Drawing.Point(132, 130)
        Me.ButtonSubtract.Name = "ButtonSubtract"
        Me.ButtonSubtract.Size = New System.Drawing.Size(50, 43)
        Me.ButtonSubtract.TabIndex = 7
        Me.ButtonSubtract.Text = "-"
        Me.ButtonSubtract.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivide.Location = New System.Drawing.Point(47, 200)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(50, 43)
        Me.ButtonDivide.TabIndex = 8
        Me.ButtonDivide.Text = "/"
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiply.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonMultiply.Location = New System.Drawing.Point(132, 200)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(50, 43)
        Me.ButtonMultiply.TabIndex = 9
        Me.ButtonMultiply.Text = "*"
        Me.ButtonMultiply.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnDisplay)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.TextBoxNum2)
        Me.Panel1.Controls.Add(Me.ButtonMultiply)
        Me.Panel1.Controls.Add(Me.TextBoxNum1)
        Me.Panel1.Controls.Add(Me.ButtonDivide)
        Me.Panel1.Controls.Add(Me.TextBoxNum3)
        Me.Panel1.Controls.Add(Me.ButtonSubtract)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ButtonAdd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 338)
        Me.Panel1.TabIndex = 10
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(132, 265)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(50, 47)
        Me.btnDisplay.TabIndex = 11
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSave.Location = New System.Drawing.Point(47, 265)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(50, 48)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Location = New System.Drawing.Point(300, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 338)
        Me.Panel2.TabIndex = 11
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Yellow
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(14, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(217, 199)
        Me.ListBox1.TabIndex = 11
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(73, 235)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'MyApplicationBindingSource
        '
        Me.MyApplicationBindingSource.DataSource = GetType(ENTD461_Assignment1_WK2.My.MyApplication)
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(574, 431)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxNum1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNum2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNum3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonSubtract As System.Windows.Forms.Button
    Friend WithEvents ButtonDivide As System.Windows.Forms.Button
    Friend WithEvents ButtonMultiply As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents MyApplicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
