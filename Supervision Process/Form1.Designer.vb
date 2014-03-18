<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.送带ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.发带ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.选项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.人员添加ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.PanelQuery = New System.Windows.Forms.Panel
        Me.PanelResult = New System.Windows.Forms.Panel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.采集ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.审核ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.回迁审核ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelQuery.SuspendLayout()
        Me.PanelResult.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.送带ToolStripMenuItem, Me.发带ToolStripMenuItem, Me.设置ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '送带ToolStripMenuItem
        '
        Me.送带ToolStripMenuItem.Name = "送带ToolStripMenuItem"
        Me.送带ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.送带ToolStripMenuItem.Text = "送带"
        '
        '发带ToolStripMenuItem
        '
        Me.发带ToolStripMenuItem.Name = "发带ToolStripMenuItem"
        Me.发带ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.发带ToolStripMenuItem.Text = "发带"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.选项ToolStripMenuItem, Me.人员添加ToolStripMenuItem1})
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        '选项ToolStripMenuItem
        '
        Me.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem"
        Me.选项ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.选项ToolStripMenuItem.Text = "选项..."
        '
        '人员添加ToolStripMenuItem1
        '
        Me.人员添加ToolStripMenuItem1.Name = "人员添加ToolStripMenuItem1"
        Me.人员添加ToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.人员添加ToolStripMenuItem1.Text = "人员添加"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "查询"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(58, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "名称"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 166)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询选项"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(15, 62)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "未审核"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 31)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "未采集"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PanelQuery
        '
        Me.PanelQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelQuery.Controls.Add(Me.TextBox1)
        Me.PanelQuery.Controls.Add(Me.GroupBox1)
        Me.PanelQuery.Controls.Add(Me.Label1)
        Me.PanelQuery.Controls.Add(Me.Button1)
        Me.PanelQuery.Location = New System.Drawing.Point(12, 25)
        Me.PanelQuery.Name = "PanelQuery"
        Me.PanelQuery.Size = New System.Drawing.Size(176, 320)
        Me.PanelQuery.TabIndex = 5
        '
        'PanelResult
        '
        Me.PanelResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelResult.Controls.Add(Me.DataGridView1)
        Me.PanelResult.Location = New System.Drawing.Point(201, 25)
        Me.PanelResult.Margin = New System.Windows.Forms.Padding(10)
        Me.PanelResult.Name = "PanelResult"
        Me.PanelResult.Size = New System.Drawing.Size(772, 322)
        Me.PanelResult.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, -1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(779, 322)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.采集ToolStripMenuItem, Me.审核ToolStripMenuItem, Me.回迁审核ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(125, 70)
        '
        '采集ToolStripMenuItem
        '
        Me.采集ToolStripMenuItem.Name = "采集ToolStripMenuItem"
        Me.采集ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.采集ToolStripMenuItem.Text = "采集"
        '
        '审核ToolStripMenuItem
        '
        Me.审核ToolStripMenuItem.Name = "审核ToolStripMenuItem"
        Me.审核ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.审核ToolStripMenuItem.Text = "审核"
        '
        '回迁审核ToolStripMenuItem
        '
        Me.回迁审核ToolStripMenuItem.Name = "回迁审核ToolStripMenuItem"
        Me.回迁审核ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.回迁审核ToolStripMenuItem.Text = "回迁审核"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 357)
        Me.Controls.Add(Me.PanelResult)
        Me.Controls.Add(Me.PanelQuery)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "监理流程"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelQuery.ResumeLayout(False)
        Me.PanelQuery.PerformLayout()
        Me.PanelResult.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 送带ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 发带ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PanelQuery As System.Windows.Forms.Panel
    Friend WithEvents PanelResult As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents 选项ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 人员添加ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 采集ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 审核ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 回迁审核ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
