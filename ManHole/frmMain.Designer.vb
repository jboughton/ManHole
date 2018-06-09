<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPHAdminLink = New System.Windows.Forms.LinkLabel()
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
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPHEnabled = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExitManHole = New System.Windows.Forms.ToolStripMenuItem()
        Me.listTop = New System.Windows.Forms.ListBox()
        Me.lblDomainsBlocked = New System.Windows.Forms.Label()
        Me.lblDNSQueriesToday = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblAdsBlocked = New System.Windows.Forms.Label()
        Me.lblAdsPercentage = New System.Windows.Forms.Label()
        Me.lblUniqueDomains = New System.Windows.Forms.Label()
        Me.lblQueriesForwarded = New System.Windows.Forms.Label()
        Me.lblQueriesCached = New System.Windows.Forms.Label()
        Me.lblClientsEverSeen = New System.Windows.Forms.Label()
        Me.lblUniqueClients = New System.Windows.Forms.Label()
        Me.prgBlocked = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCloseToTray = New System.Windows.Forms.Button()
        Me.TrayMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrayIcon
        '
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "ManHole"
        Me.TrayIcon.Visible = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pi-Hole Admin URL:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPHAdminLink
        '
        Me.lblPHAdminLink.BackColor = System.Drawing.Color.Transparent
        Me.lblPHAdminLink.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHAdminLink.LinkColor = System.Drawing.Color.Cyan
        Me.lblPHAdminLink.Location = New System.Drawing.Point(163, 31)
        Me.lblPHAdminLink.Name = "lblPHAdminLink"
        Me.lblPHAdminLink.Size = New System.Drawing.Size(192, 23)
        Me.lblPHAdminLink.TabIndex = 6
        Me.lblPHAdminLink.TabStop = True
        Me.lblPHAdminLink.Text = "Not set!"
        Me.lblPHAdminLink.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblPHAdminLink.VisitedLinkColor = System.Drawing.Color.Cyan
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 503)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 25)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Refresh Manually"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Pi-Hole Status:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPHStatus
        '
        Me.lblPHStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblPHStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHStatus.Location = New System.Drawing.Point(226, 54)
        Me.lblPHStatus.Name = "lblPHStatus"
        Me.lblPHStatus.Size = New System.Drawing.Size(129, 23)
        Me.lblPHStatus.TabIndex = 10
        Me.lblPHStatus.Text = "undefined"
        Me.lblPHStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tmrUpdate
        '
        '
        'btnAutoRefresh
        '
        Me.btnAutoRefresh.BackColor = System.Drawing.Color.Black
        Me.btnAutoRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutoRefresh.ForeColor = System.Drawing.Color.White
        Me.btnAutoRefresh.Location = New System.Drawing.Point(125, 503)
        Me.btnAutoRefresh.Name = "btnAutoRefresh"
        Me.btnAutoRefresh.Size = New System.Drawing.Size(123, 25)
        Me.btnAutoRefresh.TabIndex = 11
        Me.btnAutoRefresh.Text = "&Auto-refresh: Disabled"
        Me.btnAutoRefresh.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Recently Blocked:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRecentlyBlocked
        '
        Me.lblRecentlyBlocked.BackColor = System.Drawing.Color.Transparent
        Me.lblRecentlyBlocked.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentlyBlocked.LinkColor = System.Drawing.Color.Cyan
        Me.lblRecentlyBlocked.Location = New System.Drawing.Point(150, 77)
        Me.lblRecentlyBlocked.Name = "lblRecentlyBlocked"
        Me.lblRecentlyBlocked.Size = New System.Drawing.Size(205, 23)
        Me.lblRecentlyBlocked.TabIndex = 13
        Me.lblRecentlyBlocked.TabStop = True
        Me.lblRecentlyBlocked.Text = "(recently_blocked)"
        Me.lblRecentlyBlocked.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblRecentlyBlocked.VisitedLinkColor = System.Drawing.Color.Cyan
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowMainWindow, Me.mnuSettings, Me.mnuAbout, Me.mnuAutoRefresh, Me.mnuPHEnabled, Me.mnuExitManHole})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(181, 158)
        '
        'mnuShowMainWindow
        '
        Me.mnuShowMainWindow.Name = "mnuShowMainWindow"
        Me.mnuShowMainWindow.Size = New System.Drawing.Size(180, 22)
        Me.mnuShowMainWindow.Text = "Show &Main Window"
        '
        'mnuSettings
        '
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(180, 22)
        Me.mnuSettings.Text = "&Settings"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuAbout.Text = "&About ManHole"
        '
        'mnuAutoRefresh
        '
        Me.mnuAutoRefresh.CheckOnClick = True
        Me.mnuAutoRefresh.Name = "mnuAutoRefresh"
        Me.mnuAutoRefresh.Size = New System.Drawing.Size(180, 22)
        Me.mnuAutoRefresh.Text = "Enable Auto-&refresh"
        '
        'mnuPHEnabled
        '
        Me.mnuPHEnabled.CheckOnClick = True
        Me.mnuPHEnabled.Name = "mnuPHEnabled"
        Me.mnuPHEnabled.Size = New System.Drawing.Size(180, 22)
        Me.mnuPHEnabled.Text = "&Pi-Hole Enabled"
        '
        'mnuExitManHole
        '
        Me.mnuExitManHole.Name = "mnuExitManHole"
        Me.mnuExitManHole.Size = New System.Drawing.Size(180, 22)
        Me.mnuExitManHole.Text = "E&xit ManHole"
        '
        'listTop
        '
        Me.listTop.BackColor = System.Drawing.Color.Black
        Me.listTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listTop.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTop.ForeColor = System.Drawing.Color.LightGray
        Me.listTop.FormattingEnabled = True
        Me.listTop.ItemHeight = 21
        Me.listTop.Location = New System.Drawing.Point(10, 159)
        Me.listTop.Name = "listTop"
        Me.listTop.Size = New System.Drawing.Size(340, 44)
        Me.listTop.TabIndex = 14
        '
        'lblDomainsBlocked
        '
        Me.lblDomainsBlocked.BackColor = System.Drawing.Color.Transparent
        Me.lblDomainsBlocked.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomainsBlocked.ForeColor = System.Drawing.Color.Red
        Me.lblDomainsBlocked.Location = New System.Drawing.Point(200, 29)
        Me.lblDomainsBlocked.Name = "lblDomainsBlocked"
        Me.lblDomainsBlocked.Size = New System.Drawing.Size(155, 23)
        Me.lblDomainsBlocked.TabIndex = 15
        Me.lblDomainsBlocked.Text = "(domains_blocked)"
        Me.lblDomainsBlocked.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDNSQueriesToday
        '
        Me.lblDNSQueriesToday.BackColor = System.Drawing.Color.Transparent
        Me.lblDNSQueriesToday.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNSQueriesToday.ForeColor = System.Drawing.Color.Orange
        Me.lblDNSQueriesToday.Location = New System.Drawing.Point(227, 29)
        Me.lblDNSQueriesToday.Name = "lblDNSQueriesToday"
        Me.lblDNSQueriesToday.Size = New System.Drawing.Size(127, 26)
        Me.lblDNSQueriesToday.TabIndex = 16
        Me.lblDNSQueriesToday.Text = "(dns_queries)"
        Me.lblDNSQueriesToday.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Domains Being Blocked:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 23)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "DNS Queries Today:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "ADs Blocked Today:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 23)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Percentage Blocked:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 23)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Unique Domains:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Queries Forwarded:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 23)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Queries Cached:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 23)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Clients Ever Seen:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 23)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Unique Clients:"
        '
        'lblAdsBlocked
        '
        Me.lblAdsBlocked.BackColor = System.Drawing.Color.Transparent
        Me.lblAdsBlocked.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdsBlocked.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblAdsBlocked.Location = New System.Drawing.Point(228, 52)
        Me.lblAdsBlocked.Name = "lblAdsBlocked"
        Me.lblAdsBlocked.Size = New System.Drawing.Size(127, 26)
        Me.lblAdsBlocked.TabIndex = 26
        Me.lblAdsBlocked.Text = "(ads_blocked)"
        Me.lblAdsBlocked.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblAdsPercentage
        '
        Me.lblAdsPercentage.BackColor = System.Drawing.Color.Transparent
        Me.lblAdsPercentage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdsPercentage.ForeColor = System.Drawing.Color.DeepPink
        Me.lblAdsPercentage.Location = New System.Drawing.Point(226, 100)
        Me.lblAdsPercentage.Name = "lblAdsPercentage"
        Me.lblAdsPercentage.Size = New System.Drawing.Size(127, 26)
        Me.lblAdsPercentage.TabIndex = 27
        Me.lblAdsPercentage.Text = "(ads_percentage)"
        Me.lblAdsPercentage.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUniqueDomains
        '
        Me.lblUniqueDomains.BackColor = System.Drawing.Color.Transparent
        Me.lblUniqueDomains.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueDomains.ForeColor = System.Drawing.Color.Teal
        Me.lblUniqueDomains.Location = New System.Drawing.Point(172, 98)
        Me.lblUniqueDomains.Name = "lblUniqueDomains"
        Me.lblUniqueDomains.Size = New System.Drawing.Size(183, 26)
        Me.lblUniqueDomains.TabIndex = 28
        Me.lblUniqueDomains.Text = "(unique_domains)"
        Me.lblUniqueDomains.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblQueriesForwarded
        '
        Me.lblQueriesForwarded.BackColor = System.Drawing.Color.Transparent
        Me.lblQueriesForwarded.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQueriesForwarded.ForeColor = System.Drawing.Color.LightPink
        Me.lblQueriesForwarded.Location = New System.Drawing.Point(180, 52)
        Me.lblQueriesForwarded.Name = "lblQueriesForwarded"
        Me.lblQueriesForwarded.Size = New System.Drawing.Size(174, 26)
        Me.lblQueriesForwarded.TabIndex = 29
        Me.lblQueriesForwarded.Text = "(queries_forwarded)"
        Me.lblQueriesForwarded.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblQueriesCached
        '
        Me.lblQueriesCached.BackColor = System.Drawing.Color.Transparent
        Me.lblQueriesCached.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQueriesCached.ForeColor = System.Drawing.Color.Yellow
        Me.lblQueriesCached.Location = New System.Drawing.Point(155, 75)
        Me.lblQueriesCached.Name = "lblQueriesCached"
        Me.lblQueriesCached.Size = New System.Drawing.Size(199, 26)
        Me.lblQueriesCached.TabIndex = 30
        Me.lblQueriesCached.Text = "(queries_cached)"
        Me.lblQueriesCached.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblClientsEverSeen
        '
        Me.lblClientsEverSeen.BackColor = System.Drawing.Color.Transparent
        Me.lblClientsEverSeen.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientsEverSeen.ForeColor = System.Drawing.Color.Cyan
        Me.lblClientsEverSeen.Location = New System.Drawing.Point(160, 121)
        Me.lblClientsEverSeen.Name = "lblClientsEverSeen"
        Me.lblClientsEverSeen.Size = New System.Drawing.Size(195, 26)
        Me.lblClientsEverSeen.TabIndex = 31
        Me.lblClientsEverSeen.Text = "(clients_ever_seen)"
        Me.lblClientsEverSeen.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUniqueClients
        '
        Me.lblUniqueClients.BackColor = System.Drawing.Color.Transparent
        Me.lblUniqueClients.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueClients.ForeColor = System.Drawing.Color.DarkOrchid
        Me.lblUniqueClients.Location = New System.Drawing.Point(146, 144)
        Me.lblUniqueClients.Name = "lblUniqueClients"
        Me.lblUniqueClients.Size = New System.Drawing.Size(209, 26)
        Me.lblUniqueClients.TabIndex = 32
        Me.lblUniqueClients.Text = "(unique_clients)"
        Me.lblUniqueClients.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'prgBlocked
        '
        Me.prgBlocked.BackColor = System.Drawing.Color.Black
        Me.prgBlocked.ForeColor = System.Drawing.Color.White
        Me.prgBlocked.Location = New System.Drawing.Point(10, 126)
        Me.prgBlocked.Name = "prgBlocked"
        Me.prgBlocked.Size = New System.Drawing.Size(340, 23)
        Me.prgBlocked.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgBlocked.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblDomainsBlocked)
        Me.GroupBox1.Controls.Add(Me.prgBlocked)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblAdsBlocked)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblAdsPercentage)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblRecentlyBlocked)
        Me.GroupBox1.Controls.Add(Me.listTop)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 213)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Blocking"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblPHAdminLink)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblPHStatus)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 83)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Your Pi-hole"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lblDNSQueriesToday)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lblQueriesForwarded)
        Me.GroupBox3.Controls.Add(Me.lblUniqueClients)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lblClientsEverSeen)
        Me.GroupBox3.Controls.Add(Me.lblQueriesCached)
        Me.GroupBox3.Controls.Add(Me.lblUniqueDomains)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 175)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stats"
        '
        'btnCloseToTray
        '
        Me.btnCloseToTray.BackColor = System.Drawing.Color.Black
        Me.btnCloseToTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseToTray.ForeColor = System.Drawing.Color.White
        Me.btnCloseToTray.Location = New System.Drawing.Point(254, 503)
        Me.btnCloseToTray.Name = "btnCloseToTray"
        Me.btnCloseToTray.Size = New System.Drawing.Size(119, 25)
        Me.btnCloseToTray.TabIndex = 37
        Me.btnCloseToTray.Text = "&Close to tray"
        Me.btnCloseToTray.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(387, 542)
        Me.Controls.Add(Me.btnCloseToTray)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAutoRefresh)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.Text = "ManHole"
        Me.TopMost = True
        Me.TrayMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrayIcon As NotifyIcon
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPHAdminLink As LinkLabel
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
    Friend WithEvents listTop As ListBox
    Friend WithEvents lblDomainsBlocked As Label
    Friend WithEvents lblDNSQueriesToday As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblAdsBlocked As Label
    Friend WithEvents lblAdsPercentage As Label
    Friend WithEvents lblUniqueDomains As Label
    Friend WithEvents lblQueriesForwarded As Label
    Friend WithEvents lblQueriesCached As Label
    Friend WithEvents lblClientsEverSeen As Label
    Friend WithEvents lblUniqueClients As Label
    Friend WithEvents prgBlocked As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCloseToTray As Button
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
