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
        Me.gbInsert = New System.Windows.Forms.GroupBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbNickname = New System.Windows.Forms.TextBox()
        Me.lblNickname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.gbSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.gbDisplay = New System.Windows.Forms.GroupBox()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbInsert.SuspendLayout()
        Me.gbSearch.SuspendLayout()
        Me.gbDisplay.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbInsert
        '
        Me.gbInsert.Controls.Add(Me.tbEmail)
        Me.gbInsert.Controls.Add(Me.btnInsert)
        Me.gbInsert.Controls.Add(Me.tbName)
        Me.gbInsert.Controls.Add(Me.tbNickname)
        Me.gbInsert.Controls.Add(Me.lblNickname)
        Me.gbInsert.Controls.Add(Me.lblName)
        Me.gbInsert.Controls.Add(Me.lblEmail)
        Me.gbInsert.Location = New System.Drawing.Point(18, 42)
        Me.gbInsert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbInsert.Name = "gbInsert"
        Me.gbInsert.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbInsert.Size = New System.Drawing.Size(432, 448)
        Me.gbInsert.TabIndex = 0
        Me.gbInsert.TabStop = False
        Me.gbInsert.Text = "Insert New Contact"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(30, 274)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(366, 26)
        Me.tbEmail.TabIndex = 6
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(110, 348)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(206, 57)
        Me.btnInsert.TabIndex = 3
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(30, 174)
        Me.tbName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(366, 26)
        Me.tbName.TabIndex = 5
        '
        'tbNickname
        '
        Me.tbNickname.Location = New System.Drawing.Point(30, 74)
        Me.tbNickname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbNickname.Name = "tbNickname"
        Me.tbNickname.Size = New System.Drawing.Size(366, 26)
        Me.tbNickname.TabIndex = 4
        '
        'lblNickname
        '
        Me.lblNickname.AutoSize = True
        Me.lblNickname.Location = New System.Drawing.Point(32, 49)
        Me.lblNickname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNickname.Name = "lblNickname"
        Me.lblNickname.Size = New System.Drawing.Size(79, 20)
        Me.lblNickname.TabIndex = 0
        Me.lblNickname.Text = "Nickname"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(32, 149)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(167, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Last name, First name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(32, 249)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email"
        '
        'gbSearch
        '
        Me.gbSearch.Controls.Add(Me.btnSearch)
        Me.gbSearch.Controls.Add(Me.tbSearch)
        Me.gbSearch.Controls.Add(Me.lblSearch)
        Me.gbSearch.Location = New System.Drawing.Point(471, 42)
        Me.gbSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbSearch.Size = New System.Drawing.Size(738, 138)
        Me.gbSearch.TabIndex = 0
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(519, 40)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(138, 58)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(170, 55)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(284, 26)
        Me.tbSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(26, 60)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(100, 20)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search Term"
        '
        'gbDisplay
        '
        Me.gbDisplay.Controls.Add(Me.dgvResults)
        Me.gbDisplay.Location = New System.Drawing.Point(471, 191)
        Me.gbDisplay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbDisplay.Name = "gbDisplay"
        Me.gbDisplay.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbDisplay.Size = New System.Drawing.Size(738, 448)
        Me.gbDisplay.TabIndex = 0
        Me.gbDisplay.TabStop = False
        Me.gbDisplay.Text = "Results"
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AllowUserToOrderColumns = True
        Me.dgvResults.AllowUserToResizeRows = False
        Me.dgvResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Location = New System.Drawing.Point(10, 45)
        Me.dgvResults.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.Size = New System.Drawing.Size(718, 394)
        Me.dgvResults.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1227, 35)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearSearchToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ClearSearchToolStripMenuItem
        '
        Me.ClearSearchToolStripMenuItem.Name = "ClearSearchToolStripMenuItem"
        Me.ClearSearchToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.ClearSearchToolStripMenuItem.Text = "&Clear Search"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 657)
        Me.Controls.Add(Me.gbDisplay)
        Me.Controls.Add(Me.gbInsert)
        Me.Controls.Add(Me.gbSearch)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1240, 678)
        Me.Name = "Form1"
        Me.Text = "Address Book"
        Me.gbInsert.ResumeLayout(False)
        Me.gbInsert.PerformLayout()
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        Me.gbDisplay.ResumeLayout(False)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbInsert As GroupBox
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbNickname As TextBox
    Friend WithEvents lblNickname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents gbSearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents gbDisplay As GroupBox
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
