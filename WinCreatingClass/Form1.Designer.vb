<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpDatabases = New System.Windows.Forms.GroupBox
        Me.cmbDatabases = New System.Windows.Forms.ComboBox
        Me.grpServer = New System.Windows.Forms.GroupBox
        Me.txtSqlServer = New System.Windows.Forms.TextBox
        Me.grpTables = New System.Windows.Forms.GroupBox
        Me.clbTables = New System.Windows.Forms.CheckedListBox
        Me.grpAuthentication = New System.Windows.Forms.GroupBox
        Me.pnlSqlAut = New System.Windows.Forms.Panel
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.lblUserID = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.rdbSqlAut = New System.Windows.Forms.RadioButton
        Me.rdbWinAut = New System.Windows.Forms.RadioButton
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.cmnuTabControl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuCloseTabPage = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuOpenEmptyTabPage = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpDatabases.SuspendLayout()
        Me.grpServer.SuspendLayout()
        Me.grpTables.SuspendLayout()
        Me.grpAuthentication.SuspendLayout()
        Me.pnlSqlAut.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.cmnuTabControl.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripContainer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(878, 537)
        Me.SplitContainer1.SplitterDistance = 238
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grpDatabases)
        Me.Panel1.Controls.Add(Me.grpServer)
        Me.Panel1.Controls.Add(Me.grpTables)
        Me.Panel1.Controls.Add(Me.grpAuthentication)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 537)
        Me.Panel1.TabIndex = 12
        '
        'grpDatabases
        '
        Me.grpDatabases.Controls.Add(Me.cmbDatabases)
        Me.grpDatabases.Location = New System.Drawing.Point(17, 221)
        Me.grpDatabases.Name = "grpDatabases"
        Me.grpDatabases.Size = New System.Drawing.Size(200, 55)
        Me.grpDatabases.TabIndex = 13
        Me.grpDatabases.TabStop = False
        Me.grpDatabases.Text = "Databases"
        '
        'cmbDatabases
        '
        Me.cmbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDatabases.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDatabases.FormattingEnabled = True
        Me.cmbDatabases.Location = New System.Drawing.Point(6, 19)
        Me.cmbDatabases.Name = "cmbDatabases"
        Me.cmbDatabases.Size = New System.Drawing.Size(188, 24)
        Me.cmbDatabases.TabIndex = 0
        '
        'grpServer
        '
        Me.grpServer.Controls.Add(Me.txtSqlServer)
        Me.grpServer.Location = New System.Drawing.Point(17, 16)
        Me.grpServer.Name = "grpServer"
        Me.grpServer.Size = New System.Drawing.Size(200, 57)
        Me.grpServer.TabIndex = 11
        Me.grpServer.TabStop = False
        Me.grpServer.Text = "SQL Server"
        '
        'txtSqlServer
        '
        Me.txtSqlServer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSqlServer.Location = New System.Drawing.Point(6, 19)
        Me.txtSqlServer.Name = "txtSqlServer"
        Me.txtSqlServer.Size = New System.Drawing.Size(188, 25)
        Me.txtSqlServer.TabIndex = 0
        '
        'grpTables
        '
        Me.grpTables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpTables.Controls.Add(Me.clbTables)
        Me.grpTables.Location = New System.Drawing.Point(17, 282)
        Me.grpTables.Name = "grpTables"
        Me.grpTables.Size = New System.Drawing.Size(200, 239)
        Me.grpTables.TabIndex = 14
        Me.grpTables.TabStop = False
        Me.grpTables.Text = "Tables"
        '
        'clbTables
        '
        Me.clbTables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.clbTables.CheckOnClick = True
        Me.clbTables.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.clbTables.FormattingEnabled = True
        Me.clbTables.Location = New System.Drawing.Point(6, 19)
        Me.clbTables.Name = "clbTables"
        Me.clbTables.Size = New System.Drawing.Size(188, 202)
        Me.clbTables.TabIndex = 0
        '
        'grpAuthentication
        '
        Me.grpAuthentication.Controls.Add(Me.pnlSqlAut)
        Me.grpAuthentication.Controls.Add(Me.rdbSqlAut)
        Me.grpAuthentication.Controls.Add(Me.rdbWinAut)
        Me.grpAuthentication.Location = New System.Drawing.Point(17, 82)
        Me.grpAuthentication.Name = "grpAuthentication"
        Me.grpAuthentication.Size = New System.Drawing.Size(200, 133)
        Me.grpAuthentication.TabIndex = 12
        Me.grpAuthentication.TabStop = False
        Me.grpAuthentication.Text = "Authentication"
        '
        'pnlSqlAut
        '
        Me.pnlSqlAut.Controls.Add(Me.txtPassword)
        Me.pnlSqlAut.Controls.Add(Me.txtUserID)
        Me.pnlSqlAut.Controls.Add(Me.lblUserID)
        Me.pnlSqlAut.Controls.Add(Me.lblPassword)
        Me.pnlSqlAut.Enabled = False
        Me.pnlSqlAut.Location = New System.Drawing.Point(7, 67)
        Me.pnlSqlAut.Name = "pnlSqlAut"
        Me.pnlSqlAut.Size = New System.Drawing.Size(187, 60)
        Me.pnlSqlAut.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(64, 34)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(117, 25)
        Me.txtPassword.TabIndex = 5
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(64, 3)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(117, 25)
        Me.txtUserID.TabIndex = 4
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(5, 9)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(40, 13)
        Me.lblUserID.TabIndex = 2
        Me.lblUserID.Text = "UserID"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(5, 40)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'rdbSqlAut
        '
        Me.rdbSqlAut.AutoSize = True
        Me.rdbSqlAut.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rdbSqlAut.Location = New System.Drawing.Point(6, 42)
        Me.rdbSqlAut.Name = "rdbSqlAut"
        Me.rdbSqlAut.Size = New System.Drawing.Size(135, 19)
        Me.rdbSqlAut.TabIndex = 1
        Me.rdbSqlAut.Text = "SQL Authentication"
        Me.rdbSqlAut.UseVisualStyleBackColor = True
        '
        'rdbWinAut
        '
        Me.rdbWinAut.AutoSize = True
        Me.rdbWinAut.Checked = True
        Me.rdbWinAut.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rdbWinAut.Location = New System.Drawing.Point(6, 19)
        Me.rdbWinAut.Name = "rdbWinAut"
        Me.rdbWinAut.Size = New System.Drawing.Size(159, 19)
        Me.rdbWinAut.TabIndex = 0
        Me.rdbWinAut.TabStop = True
        Me.rdbWinAut.Text = "Windows Authentication"
        Me.rdbWinAut.UseVisualStyleBackColor = True
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 537)
        Me.Splitter1.TabIndex = 11
        Me.Splitter1.TabStop = False
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(636, 512)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(636, 537)
        Me.ToolStripContainer1.TabIndex = 11
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'TabControl1
        '
        Me.TabControl1.ContextMenuStrip = Me.cmnuTabControl
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(636, 512)
        Me.TabControl1.TabIndex = 7
        '
        'cmnuTabControl
        '
        Me.cmnuTabControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuCloseTabPage, Me.ToolStripMenuItem1, Me.cmnuOpenEmptyTabPage})
        Me.cmnuTabControl.Name = "cmnuTabControl"
        Me.cmnuTabControl.Size = New System.Drawing.Size(156, 76)
        '
        'cmnuCloseTabPage
        '
        Me.cmnuCloseTabPage.Name = "cmnuCloseTabPage"
        Me.cmnuCloseTabPage.Size = New System.Drawing.Size(155, 22)
        Me.cmnuCloseTabPage.Text = "Sekmeyi Kapat"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 6)
        '
        'cmnuOpenEmptyTabPage
        '
        Me.cmnuOpenEmptyTabPage.Name = "cmnuOpenEmptyTabPage"
        Me.cmnuOpenEmptyTabPage.Size = New System.Drawing.Size(155, 22)
        Me.cmnuOpenEmptyTabPage.Text = "Boþ Sekme Aç"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(185, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 537)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "CLASS GENERATOR FROM SQL DATABASE"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.grpDatabases.ResumeLayout(False)
        Me.grpServer.ResumeLayout(False)
        Me.grpServer.PerformLayout()
        Me.grpTables.ResumeLayout(False)
        Me.grpAuthentication.ResumeLayout(False)
        Me.grpAuthentication.PerformLayout()
        Me.pnlSqlAut.ResumeLayout(False)
        Me.pnlSqlAut.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.cmnuTabControl.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpDatabases As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDatabases As System.Windows.Forms.ComboBox
    Friend WithEvents grpServer As System.Windows.Forms.GroupBox
    Friend WithEvents txtSqlServer As System.Windows.Forms.TextBox
    Friend WithEvents grpTables As System.Windows.Forms.GroupBox
    Friend WithEvents clbTables As System.Windows.Forms.CheckedListBox
    Friend WithEvents grpAuthentication As System.Windows.Forms.GroupBox
    Friend WithEvents pnlSqlAut As System.Windows.Forms.Panel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents rdbSqlAut As System.Windows.Forms.RadioButton
    Friend WithEvents rdbWinAut As System.Windows.Forms.RadioButton
    Friend WithEvents cmnuTabControl As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuCloseTabPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuOpenEmptyTabPage As System.Windows.Forms.ToolStripMenuItem

End Class
