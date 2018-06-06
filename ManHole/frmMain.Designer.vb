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
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.lblAppVersion = New System.Windows.Forms.Label()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPHAdminLink = New System.Windows.Forms.LinkLabel()
        Me.listVars = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPHStatus = New System.Windows.Forms.Label()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.btnAutoRefresh = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRecentlyBlocked = New System.Windows.Forms.LinkLabel()
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuShowMainWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPHEnabled = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExitManHole = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAppName
        '
        Me.lblAppName.BackColor = System.Drawing.Color.Transparent
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(12, 9)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(360, 49)
        Me.lblAppName.TabIndex = 0
        Me.lblAppName.Text = "ManHole"
        Me.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAppVersion
        '
        Me.lblAppVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblAppVersion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppVersion.Location = New System.Drawing.Point(12, 58)
        Me.lblAppVersion.Name = "lblAppVersion"
        Me.lblAppVersion.Size = New System.Drawing.Size(360, 28)
        Me.lblAppVersion.TabIndex = 1
        Me.lblAppVersion.Text = "Version"
        Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrayIcon
        '
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "ManHole"
        Me.TrayIcon.Visible = True
        '
        'btnSettings
        '
        Me.btnSettings.ForeColor = System.Drawing.Color.Black
        Me.btnSettings.Location = New System.Drawing.Point(12, 460)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(117, 36)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.ForeColor = System.Drawing.Color.Black
        Me.btnAbout.Location = New System.Drawing.Point(135, 460)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(117, 36)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(258, 460)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 36)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pi-Hole Admin URL:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPHAdminLink
        '
        Me.lblPHAdminLink.BackColor = System.Drawing.Color.Transparent
        Me.lblPHAdminLink.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHAdminLink.LinkColor = System.Drawing.Color.Cyan
        Me.lblPHAdminLink.Location = New System.Drawing.Point(173, 91)
        Me.lblPHAdminLink.Name = "lblPHAdminLink"
        Me.lblPHAdminLink.Size = New System.Drawing.Size(202, 23)
        Me.lblPHAdminLink.TabIndex = 6
        Me.lblPHAdminLink.TabStop = True
        Me.lblPHAdminLink.Text = "Not set!"
        Me.lblPHAdminLink.VisitedLinkColor = System.Drawing.Color.Cyan
        '
        'listVars
        '
        Me.listVars.BackColor = System.Drawing.Color.Black
        Me.listVars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listVars.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listVars.ForeColor = System.Drawing.Color.LightGray
        Me.listVars.FormattingEnabled = True
        Me.listVars.ItemHeight = 21
        Me.listVars.Location = New System.Drawing.Point(12, 201)
        Me.listVars.Name = "listVars"
        Me.listVars.Size = New System.Drawing.Size(363, 212)
        Me.listVars.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(12, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Refresh Manually"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Pi-Hole Status:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPHStatus
        '
        Me.lblPHStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblPHStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHStatus.Location = New System.Drawing.Point(135, 114)
        Me.lblPHStatus.Name = "lblPHStatus"
        Me.lblPHStatus.Size = New System.Drawing.Size(129, 28)
        Me.lblPHStatus.TabIndex = 10
        Me.lblPHStatus.Text = "undefined"
        Me.lblPHStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrUpdate
        '
        '
        'btnAutoRefresh
        '
        Me.btnAutoRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnAutoRefresh.Location = New System.Drawing.Point(135, 419)
        Me.btnAutoRefresh.Name = "btnAutoRefresh"
        Me.btnAutoRefresh.Size = New System.Drawing.Size(240, 35)
        Me.btnAutoRefresh.TabIndex = 11
        Me.btnAutoRefresh.Text = "Auto-refresh: Disabled"
        Me.btnAutoRefresh.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Recently Blocked:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRecentlyBlocked
        '
        Me.lblRecentlyBlocked.BackColor = System.Drawing.Color.Transparent
        Me.lblRecentlyBlocked.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentlyBlocked.LinkColor = System.Drawing.Color.Cyan
        Me.lblRecentlyBlocked.Location = New System.Drawing.Point(160, 147)
        Me.lblRecentlyBlocked.Name = "lblRecentlyBlocked"
        Me.lblRecentlyBlocked.Size = New System.Drawing.Size(215, 23)
        Me.lblRecentlyBlocked.TabIndex = 13
        Me.lblRecentlyBlocked.VisitedLinkColor = System.Drawing.Color.Cyan
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowMainWindow, Me.mnuSettings, Me.mnuAutoRefresh, Me.mnuPHEnabled, Me.mnuExitManHole})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(181, 114)
        '
        'mnuShowMainWindow
        '
        Me.mnuShowMainWindow.Name = "mnuShowMainWindow"
        Me.mnuShowMainWindow.Size = New System.Drawing.Size(180, 22)
        Me.mnuShowMainWindow.Text = "Show Main Window"
        '
        'mnuSettings
        '
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(180, 22)
        Me.mnuSettings.Text = "Settings"
        '
        'mnuAutoRefresh
        '
        Me.mnuAutoRefresh.CheckOnClick = True
        Me.mnuAutoRefresh.Name = "mnuAutoRefresh"
        Me.mnuAutoRefresh.Size = New System.Drawing.Size(180, 22)
        Me.mnuAutoRefresh.Text = "Enable Auto-refresh"
        '
        'mnuPHEnabled
        '
        Me.mnuPHEnabled.CheckOnClick = True
        Me.mnuPHEnabled.Name = "mnuPHEnabled"
        Me.mnuPHEnabled.Size = New System.Drawing.Size(180, 22)
        Me.mnuPHEnabled.Text = "Pi-Hole Enabled"
        '
        'mnuExitManHole
        '
        Me.mnuExitManHole.Name = "mnuExitManHole"
        Me.mnuExitManHole.Size = New System.Drawing.Size(180, 22)
        Me.mnuExitManHole.Text = "Exit ManHole"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(387, 508)
        Me.Controls.Add(Me.lblRecentlyBlocked)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAutoRefresh)
        Me.Controls.Add(Me.lblPHStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.listVars)
        Me.Controls.Add(Me.lblPHAdminLink)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.lblAppVersion)
        Me.Controls.Add(Me.lblAppName)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.Text = "ManHole"
        Me.TopMost = True
        Me.TrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblAppName As Label
    Friend WithEvents lblAppVersion As Label
    Friend WithEvents TrayIcon As NotifyIcon
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPHAdminLink As LinkLabel
    Friend WithEvents listVars As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPHStatus As Label
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents btnAutoRefresh As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRecentlyBlocked As LinkLabel
    Friend WithEvents TrayMenu As ContextMenuStrip
    Friend WithEvents mnuExitManHole As ToolStripMenuItem
    Friend WithEvents mnuShowMainWindow As ToolStripMenuItem
    Friend WithEvents mnuSettings As ToolStripMenuItem
    Friend WithEvents mnuAutoRefresh As ToolStripMenuItem
    Friend WithEvents mnuPHEnabled As ToolStripMenuItem
End Class
