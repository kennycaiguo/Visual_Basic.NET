<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim NumberLabel As System.Windows.Forms.Label
        Dim PlayDateLabel As System.Windows.Forms.Label
        Dim OpposingTeamLabel As System.Windows.Forms.Label
        Dim HomeTeamScoreLabel As System.Windows.Forms.Label
        Dim OpposingScoreLabel As System.Windows.Forms.Label
        Me.SportsDataSet = New Sports_Action_Project.SportsDataSet()
        Me.TblScoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblScoresTableAdapter = New Sports_Action_Project.SportsDataSetTableAdapters.tblScoresTableAdapter()
        Me.TableAdapterManager = New Sports_Action_Project.SportsDataSetTableAdapters.TableAdapterManager()
        Me.TblScoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAvgHome = New System.Windows.Forms.ToolStripButton()
        Me.NumberLabel1 = New System.Windows.Forms.Label()
        Me.PlayDateLabel1 = New System.Windows.Forms.Label()
        Me.OpposingTeamLabel1 = New System.Windows.Forms.Label()
        Me.HomeTeamScoreLabel1 = New System.Windows.Forms.Label()
        Me.OpposingScoreLabel1 = New System.Windows.Forms.Label()
        NumberLabel = New System.Windows.Forms.Label()
        PlayDateLabel = New System.Windows.Forms.Label()
        OpposingTeamLabel = New System.Windows.Forms.Label()
        HomeTeamScoreLabel = New System.Windows.Forms.Label()
        OpposingScoreLabel = New System.Windows.Forms.Label()
        CType(Me.SportsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblScoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblScoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblScoresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SportsDataSet
        '
        Me.SportsDataSet.DataSetName = "SportsDataSet"
        Me.SportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblScoresBindingSource
        '
        Me.TblScoresBindingSource.DataMember = "tblScores"
        Me.TblScoresBindingSource.DataSource = Me.SportsDataSet
        '
        'TblScoresTableAdapter
        '
        Me.TblScoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblScoresTableAdapter = Me.TblScoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sports_Action_Project.SportsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblScoresBindingNavigator
        '
        Me.TblScoresBindingNavigator.AddNewItem = Nothing
        Me.TblScoresBindingNavigator.BindingSource = Me.TblScoresBindingSource
        Me.TblScoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblScoresBindingNavigator.DeleteItem = Nothing
        Me.TblScoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnAvgHome})
        Me.TblScoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblScoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblScoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblScoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblScoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblScoresBindingNavigator.Name = "TblScoresBindingNavigator"
        Me.TblScoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblScoresBindingNavigator.Size = New System.Drawing.Size(371, 25)
        Me.TblScoresBindingNavigator.TabIndex = 0
        Me.TblScoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnAvgHome
        '
        Me.btnAvgHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAvgHome.Image = CType(resources.GetObject("btnAvgHome.Image"), System.Drawing.Image)
        Me.btnAvgHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAvgHome.Name = "btnAvgHome"
        Me.btnAvgHome.Size = New System.Drawing.Size(122, 22)
        Me.btnAvgHome.Text = "&Average Home Score"
        '
        'NumberLabel
        '
        NumberLabel.AutoSize = True
        NumberLabel.Location = New System.Drawing.Point(77, 58)
        NumberLabel.Name = "NumberLabel"
        NumberLabel.Size = New System.Drawing.Size(54, 15)
        NumberLabel.TabIndex = 1
        NumberLabel.Text = "Number:"
        '
        'NumberLabel1
        '
        Me.NumberLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblScoresBindingSource, "Number", True))
        Me.NumberLabel1.Location = New System.Drawing.Point(191, 58)
        Me.NumberLabel1.Name = "NumberLabel1"
        Me.NumberLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NumberLabel1.TabIndex = 2
        Me.NumberLabel1.Text = "Label1"
        '
        'PlayDateLabel
        '
        PlayDateLabel.AutoSize = True
        PlayDateLabel.Location = New System.Drawing.Point(77, 81)
        PlayDateLabel.Name = "PlayDateLabel"
        PlayDateLabel.Size = New System.Drawing.Size(59, 15)
        PlayDateLabel.TabIndex = 3
        PlayDateLabel.Text = "Play Date:"
        '
        'PlayDateLabel1
        '
        Me.PlayDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblScoresBindingSource, "PlayDate", True))
        Me.PlayDateLabel1.Location = New System.Drawing.Point(191, 81)
        Me.PlayDateLabel1.Name = "PlayDateLabel1"
        Me.PlayDateLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PlayDateLabel1.TabIndex = 4
        Me.PlayDateLabel1.Text = "Label1"
        '
        'OpposingTeamLabel
        '
        OpposingTeamLabel.AutoSize = True
        OpposingTeamLabel.Location = New System.Drawing.Point(77, 104)
        OpposingTeamLabel.Name = "OpposingTeamLabel"
        OpposingTeamLabel.Size = New System.Drawing.Size(95, 15)
        OpposingTeamLabel.TabIndex = 5
        OpposingTeamLabel.Text = "Opposing Team:"
        '
        'OpposingTeamLabel1
        '
        Me.OpposingTeamLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblScoresBindingSource, "OpposingTeam", True))
        Me.OpposingTeamLabel1.Location = New System.Drawing.Point(191, 104)
        Me.OpposingTeamLabel1.Name = "OpposingTeamLabel1"
        Me.OpposingTeamLabel1.Size = New System.Drawing.Size(100, 23)
        Me.OpposingTeamLabel1.TabIndex = 6
        Me.OpposingTeamLabel1.Text = "Label1"
        '
        'HomeTeamScoreLabel
        '
        HomeTeamScoreLabel.AutoSize = True
        HomeTeamScoreLabel.Location = New System.Drawing.Point(77, 127)
        HomeTeamScoreLabel.Name = "HomeTeamScoreLabel"
        HomeTeamScoreLabel.Size = New System.Drawing.Size(108, 15)
        HomeTeamScoreLabel.TabIndex = 7
        HomeTeamScoreLabel.Text = "Home Team Score:"
        '
        'HomeTeamScoreLabel1
        '
        Me.HomeTeamScoreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblScoresBindingSource, "HomeTeamScore", True))
        Me.HomeTeamScoreLabel1.Location = New System.Drawing.Point(191, 127)
        Me.HomeTeamScoreLabel1.Name = "HomeTeamScoreLabel1"
        Me.HomeTeamScoreLabel1.Size = New System.Drawing.Size(100, 23)
        Me.HomeTeamScoreLabel1.TabIndex = 8
        Me.HomeTeamScoreLabel1.Text = "Label1"
        '
        'OpposingScoreLabel
        '
        OpposingScoreLabel.AutoSize = True
        OpposingScoreLabel.Location = New System.Drawing.Point(77, 150)
        OpposingScoreLabel.Name = "OpposingScoreLabel"
        OpposingScoreLabel.Size = New System.Drawing.Size(94, 15)
        OpposingScoreLabel.TabIndex = 9
        OpposingScoreLabel.Text = "Opposing Score:"
        '
        'OpposingScoreLabel1
        '
        Me.OpposingScoreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblScoresBindingSource, "OpposingScore", True))
        Me.OpposingScoreLabel1.Location = New System.Drawing.Point(191, 150)
        Me.OpposingScoreLabel1.Name = "OpposingScoreLabel1"
        Me.OpposingScoreLabel1.Size = New System.Drawing.Size(100, 23)
        Me.OpposingScoreLabel1.TabIndex = 10
        Me.OpposingScoreLabel1.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 209)
        Me.Controls.Add(NumberLabel)
        Me.Controls.Add(Me.NumberLabel1)
        Me.Controls.Add(PlayDateLabel)
        Me.Controls.Add(Me.PlayDateLabel1)
        Me.Controls.Add(OpposingTeamLabel)
        Me.Controls.Add(Me.OpposingTeamLabel1)
        Me.Controls.Add(HomeTeamScoreLabel)
        Me.Controls.Add(Me.HomeTeamScoreLabel1)
        Me.Controls.Add(OpposingScoreLabel)
        Me.Controls.Add(Me.OpposingScoreLabel1)
        Me.Controls.Add(Me.TblScoresBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sports Action"
        CType(Me.SportsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblScoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblScoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblScoresBindingNavigator.ResumeLayout(False)
        Me.TblScoresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SportsDataSet As Sports_Action_Project.SportsDataSet
    Friend WithEvents TblScoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblScoresTableAdapter As Sports_Action_Project.SportsDataSetTableAdapters.tblScoresTableAdapter
    Friend WithEvents TableAdapterManager As Sports_Action_Project.SportsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblScoresBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAvgHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents NumberLabel1 As System.Windows.Forms.Label
    Friend WithEvents PlayDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents OpposingTeamLabel1 As System.Windows.Forms.Label
    Friend WithEvents HomeTeamScoreLabel1 As System.Windows.Forms.Label
    Friend WithEvents OpposingScoreLabel1 As System.Windows.Forms.Label

End Class
