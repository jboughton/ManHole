<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.lblPHInterfaceURL = New System.Windows.Forms.Label()
        Me.txtPiHoleURL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSetDefaultURL = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAuthKey = New System.Windows.Forms.MaskedTextBox()
        Me.lblAuthKeyInstruct = New System.Windows.Forms.Label()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.btnExitWithoutSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trkUpdateInterval = New System.Windows.Forms.TrackBar()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.chkAutoStart = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.trkUpdateInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPHInterfaceURL
        '
        Me.lblPHInterfaceURL.AutoSize = True
        Me.lblPHInterfaceURL.BackColor = System.Drawing.Color.Transparent
        Me.lblPHInterfaceURL.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHInterfaceURL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPHInterfaceURL.Location = New System.Drawing.Point(6, 29)
        Me.lblPHInterfaceURL.Name = "lblPHInterfaceURL"
        Me.lblPHInterfaceURL.Size = New System.Drawing.Size(252, 25)
        Me.lblPHInterfaceURL.TabIndex = 0
        Me.lblPHInterfaceURL.Text = "Pi-Hole Admin Interface URL"
        '
        'txtPiHoleURL
        '
        Me.txtPiHoleURL.Location = New System.Drawing.Point(6, 57)
        Me.txtPiHoleURL.Name = "txtPiHoleURL"
        Me.txtPiHoleURL.Size = New System.Drawing.Size(258, 33)
        Me.txtPiHoleURL.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Typically you can just use http://pi.hole/admin/"
        '
        'btnSetDefaultURL
        '
        Me.btnSetDefaultURL.BackColor = System.Drawing.Color.Black
        Me.btnSetDefaultURL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetDefaultURL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetDefaultURL.ForeColor = System.Drawing.Color.White
        Me.btnSetDefaultURL.Location = New System.Drawing.Point(270, 57)
        Me.btnSetDefaultURL.Name = "btnSetDefaultURL"
        Me.btnSetDefaultURL.Size = New System.Drawing.Size(104, 33)
        Me.btnSetDefaultURL.TabIndex = 3
        Me.btnSetDefaultURL.Text = "Set to default"
        Me.btnSetDefaultURL.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Your Auth Key"
        '
        'txtAuthKey
        '
        Me.txtAuthKey.Location = New System.Drawing.Point(5, 154)
        Me.txtAuthKey.Name = "txtAuthKey"
        Me.txtAuthKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAuthKey.Size = New System.Drawing.Size(369, 33)
        Me.txtAuthKey.TabIndex = 5
        '
        'lblAuthKeyInstruct
        '
        Me.lblAuthKeyInstruct.BackColor = System.Drawing.Color.Transparent
        Me.lblAuthKeyInstruct.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthKeyInstruct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAuthKeyInstruct.Location = New System.Drawing.Point(8, 190)
        Me.lblAuthKeyInstruct.Name = "lblAuthKeyInstruct"
        Me.lblAuthKeyInstruct.Size = New System.Drawing.Size(366, 95)
        Me.lblAuthKeyInstruct.TabIndex = 6
        Me.lblAuthKeyInstruct.Text = resources.GetString("lblAuthKeyInstruct.Text")
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.BackColor = System.Drawing.Color.Black
        Me.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSettings.ForeColor = System.Drawing.Color.White
        Me.btnSaveSettings.Location = New System.Drawing.Point(282, 533)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(110, 23)
        Me.btnSaveSettings.TabIndex = 7
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = False
        '
        'btnExitWithoutSave
        '
        Me.btnExitWithoutSave.BackColor = System.Drawing.Color.Black
        Me.btnExitWithoutSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitWithoutSave.ForeColor = System.Drawing.Color.White
        Me.btnExitWithoutSave.Location = New System.Drawing.Point(12, 533)
        Me.btnExitWithoutSave.Name = "btnExitWithoutSave"
        Me.btnExitWithoutSave.Size = New System.Drawing.Size(125, 23)
        Me.btnExitWithoutSave.TabIndex = 8
        Me.btnExitWithoutSave.Text = "Exit Without Saving"
        Me.btnExitWithoutSave.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(366, 39)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "The refresh interval is set in seconds. Don't set this too low or it might cause " &
    "problems."
        '
        'trkUpdateInterval
        '
        Me.trkUpdateInterval.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.trkUpdateInterval.Location = New System.Drawing.Point(11, 71)
        Me.trkUpdateInterval.Maximum = 60
        Me.trkUpdateInterval.Minimum = 5
        Me.trkUpdateInterval.Name = "trkUpdateInterval"
        Me.trkUpdateInterval.Size = New System.Drawing.Size(363, 45)
        Me.trkUpdateInterval.TabIndex = 11
        Me.trkUpdateInterval.Value = 5
        '
        'lblInterval
        '
        Me.lblInterval.BackColor = System.Drawing.Color.Transparent
        Me.lblInterval.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblInterval.Location = New System.Drawing.Point(8, 119)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(366, 23)
        Me.lblInterval.TabIndex = 12
        Me.lblInterval.Text = "ManHole will update every %s seconds"
        '
        'chkAutoStart
        '
        Me.chkAutoStart.AutoSize = True
        Me.chkAutoStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoStart.ForeColor = System.Drawing.Color.White
        Me.chkAutoStart.Location = New System.Drawing.Point(11, 32)
        Me.chkAutoStart.Name = "chkAutoStart"
        Me.chkAutoStart.Size = New System.Drawing.Size(329, 25)
        Me.chkAutoStart.TabIndex = 13
        Me.chkAutoStart.Text = "Start ManHole with Windows (current user)"
        Me.chkAutoStart.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPHInterfaceURL)
        Me.GroupBox1.Controls.Add(Me.txtPiHoleURL)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAuthKey)
        Me.GroupBox1.Controls.Add(Me.btnSetDefaultURL)
        Me.GroupBox1.Controls.Add(Me.lblAuthKeyInstruct)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 290)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Pi-hole"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.trkUpdateInterval)
        Me.GroupBox2.Controls.Add(Me.lblInterval)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 147)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Refresh Interval"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkAutoStart)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 461)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 66)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Startup Options"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 568)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExitWithoutSave)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TopMost = True
        CType(Me.trkUpdateInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPHInterfaceURL As Label
    Friend WithEvents txtPiHoleURL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSetDefaultURL As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthKey As MaskedTextBox
    Friend WithEvents lblAuthKeyInstruct As Label
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents btnExitWithoutSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents trkUpdateInterval As TrackBar
    Friend WithEvents lblInterval As Label
    Friend WithEvents chkAutoStart As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
