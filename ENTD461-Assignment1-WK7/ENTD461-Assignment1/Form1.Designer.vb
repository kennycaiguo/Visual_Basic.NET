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
        Me.btnLoadXML = New System.Windows.Forms.Button()
        Me.btnLoadDB = New System.Windows.Forms.Button()
        Me.btnWriteXML = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnWriteDB = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Equations1 = New ENTD461_Assignment1.Equations()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Equations1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNum1
        '
        Me.TextBoxNum1.BackColor = System.Drawing.Color.Yellow
        Me.TextBoxNum1.Location = New System.Drawing.Point(113, 9)
        Me.TextBoxNum1.Name = "TextBoxNum1"
        Me.TextBoxNum1.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxNum1.TabIndex = 0
        '
        'TextBoxNum2
        '
        Me.TextBoxNum2.BackColor = System.Drawing.Color.Yellow
        Me.TextBoxNum2.Location = New System.Drawing.Point(113, 46)
        Me.TextBoxNum2.Name = "TextBoxNum2"
        Me.TextBoxNum2.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxNum2.TabIndex = 1
        '
        'TextBoxNum3
        '
        Me.TextBoxNum3.BackColor = System.Drawing.Color.Yellow
        Me.TextBoxNum3.Location = New System.Drawing.Point(113, 88)
        Me.TextBoxNum3.Name = "TextBoxNum3"
        Me.TextBoxNum3.ReadOnly = True
        Me.TextBoxNum3.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxNum3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Results"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.Location = New System.Drawing.Point(13, 130)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(39, 36)
        Me.ButtonAdd.TabIndex = 6
        Me.ButtonAdd.Text = "+"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSubtract
        '
        Me.ButtonSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubtract.Location = New System.Drawing.Point(73, 130)
        Me.ButtonSubtract.Name = "ButtonSubtract"
        Me.ButtonSubtract.Size = New System.Drawing.Size(39, 36)
        Me.ButtonSubtract.TabIndex = 7
        Me.ButtonSubtract.Text = "-"
        Me.ButtonSubtract.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDivide.Location = New System.Drawing.Point(132, 130)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(39, 36)
        Me.ButtonDivide.TabIndex = 8
        Me.ButtonDivide.Text = "/"
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiply.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonMultiply.Location = New System.Drawing.Point(192, 130)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(39, 36)
        Me.ButtonMultiply.TabIndex = 9
        Me.ButtonMultiply.Text = "*"
        Me.ButtonMultiply.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnLoadXML)
        Me.Panel1.Controls.Add(Me.btnLoadDB)
        Me.Panel1.Controls.Add(Me.btnWriteXML)
        Me.Panel1.Controls.Add(Me.btnDisplay)
        Me.Panel1.Controls.Add(Me.btnWriteDB)
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
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 332)
        Me.Panel1.TabIndex = 10
        '
        'btnLoadXML
        '
        Me.btnLoadXML.Location = New System.Drawing.Point(122, 267)
        Me.btnLoadXML.Name = "btnLoadXML"
        Me.btnLoadXML.Size = New System.Drawing.Size(109, 29)
        Me.btnLoadXML.TabIndex = 11
        Me.btnLoadXML.Text = "Load XML File"
        Me.btnLoadXML.UseVisualStyleBackColor = True
        '
        'btnLoadDB
        '
        Me.btnLoadDB.Location = New System.Drawing.Point(122, 232)
        Me.btnLoadDB.Name = "btnLoadDB"
        Me.btnLoadDB.Size = New System.Drawing.Size(109, 29)
        Me.btnLoadDB.TabIndex = 11
        Me.btnLoadDB.Text = "Load Database"
        Me.btnLoadDB.UseVisualStyleBackColor = True
        '
        'btnWriteXML
        '
        Me.btnWriteXML.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnWriteXML.Location = New System.Drawing.Point(13, 268)
        Me.btnWriteXML.Name = "btnWriteXML"
        Me.btnWriteXML.Size = New System.Drawing.Size(99, 30)
        Me.btnWriteXML.TabIndex = 10
        Me.btnWriteXML.Text = "Write XML File"
        Me.btnWriteXML.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(122, 196)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(109, 29)
        Me.btnDisplay.TabIndex = 11
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnWriteDB
        '
        Me.btnWriteDB.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnWriteDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWriteDB.Location = New System.Drawing.Point(13, 232)
        Me.btnWriteDB.Name = "btnWriteDB"
        Me.btnWriteDB.Size = New System.Drawing.Size(99, 30)
        Me.btnWriteDB.TabIndex = 10
        Me.btnWriteDB.Text = "Write Database"
        Me.btnWriteDB.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(12, 196)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 30)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Location = New System.Drawing.Point(268, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 332)
        Me.Panel2.TabIndex = 11
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Yellow
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(16, 12)
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
        'Equations1
        '
        Me.Equations1.DataSetName = "Equations"
        Me.Equations1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(530, 400)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Equations1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnLoadDB As System.Windows.Forms.Button
    Friend WithEvents btnWriteDB As System.Windows.Forms.Button
    Friend WithEvents Equations1 As ENTD461_Assignment1.Equations
    Friend WithEvents btnLoadXML As System.Windows.Forms.Button
    Friend WithEvents btnWriteXML As System.Windows.Forms.Button

End Class
