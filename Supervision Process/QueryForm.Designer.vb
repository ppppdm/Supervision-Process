﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryForm
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
        Me.SendInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SendOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddPeopleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ButtonQuery = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.PanelQuery = New System.Windows.Forms.Panel
        Me.PanelResult = New System.Windows.Forms.Panel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CheckUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendInToolStripMenuItem, Me.SendOutToolStripMenuItem, Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SendInToolStripMenuItem
        '
        Me.SendInToolStripMenuItem.Name = "SendInToolStripMenuItem"
        Me.SendInToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.SendInToolStripMenuItem.Text = "送带"
        '
        'SendOutToolStripMenuItem
        '
        Me.SendOutToolStripMenuItem.Name = "SendOutToolStripMenuItem"
        Me.SendOutToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.SendOutToolStripMenuItem.Text = "发带"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.AddPeopleToolStripMenuItem1})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.SettingToolStripMenuItem.Text = "设置"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OptionsToolStripMenuItem.Text = "选项..."
        '
        'AddPeopleToolStripMenuItem1
        '
        Me.AddPeopleToolStripMenuItem1.Name = "AddPeopleToolStripMenuItem1"
        Me.AddPeopleToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AddPeopleToolStripMenuItem1.Text = "人员添加"
        '
        'ButtonQuery
        '
        Me.ButtonQuery.Location = New System.Drawing.Point(25, 69)
        Me.ButtonQuery.Name = "ButtonQuery"
        Me.ButtonQuery.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuery.TabIndex = 1
        Me.ButtonQuery.Text = "查询"
        Me.ButtonQuery.UseVisualStyleBackColor = True
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
        Me.PanelQuery.Controls.Add(Me.ButtonQuery)
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UploadToolStripMenuItem, Me.CheckUpToolStripMenuItem, Me.BackCheckToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 92)
        '
        'UploadToolStripMenuItem
        '
        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UploadToolStripMenuItem.Text = "采集"
        '
        'CheckUpToolStripMenuItem
        '
        Me.CheckUpToolStripMenuItem.Name = "CheckUpToolStripMenuItem"
        Me.CheckUpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CheckUpToolStripMenuItem.Text = "审核"
        '
        'BackCheckToolStripMenuItem
        '
        Me.BackCheckToolStripMenuItem.Name = "BackCheckToolStripMenuItem"
        Me.BackCheckToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackCheckToolStripMenuItem.Text = "回迁审核"
        '
        'QueryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 357)
        Me.Controls.Add(Me.PanelResult)
        Me.Controls.Add(Me.PanelQuery)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "QueryForm"
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
    Friend WithEvents SendInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonQuery As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PanelQuery As System.Windows.Forms.Panel
    Friend WithEvents PanelResult As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPeopleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UploadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
