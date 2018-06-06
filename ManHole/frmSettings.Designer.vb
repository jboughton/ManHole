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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnExitWithoutSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trkUpdateInterval = New System.Windows.Forms.TrackBar()
        Me.lblInterval = New System.Windows.Forms.Label()
        CType(Me.trkUpdateInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPHInterfaceURL
        '
        Me.lblPHInterfaceURL.AutoSize = True
        Me.lblPHInterfaceURL.BackColor = System.Drawing.Color.Transparent
        Me.lblPHInterfaceURL.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPHInterfaceURL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPHInterfaceURL.Location = New System.Drawing.Point(12, 9)
        Me.lblPHInterfaceURL.Name = "lblPHInterfaceURL"
        Me.lblPHInterfaceURL.Size = New System.Drawing.Size(252, 25)
        Me.lblPHInterfaceURL.TabIndex = 0
        Me.lblPHInterfaceURL.Text = "Pi-Hole Admin Interface URL"
        '
        'txtPiHoleURL
        '
        Me.txtPiHoleURL.Location = New System.Drawing.Point(17, 37)
        Me.txtPiHoleURL.Name = "txtPiHoleURL"
        Me.txtPiHoleURL.Size = New System.Drawing.Size(375, 20)
        Me.txtPiHoleURL.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Typically you can just use http://pi.hole/admin/"
        '
        'btnSetDefaultURL
        '
        Me.btnSetDefaultURL.Location = New System.Drawing.Point(282, 80)
        Me.btnSetDefaultURL.Name = "btnSetDefaultURL"
        Me.btnSetDefaultURL.Size = New System.Drawing.Size(110, 23)
        Me.btnSetDefaultURL.TabIndex = 3
        Me.btnSetDefaultURL.Text = "Set to default"
        Me.btnSetDefaultURL.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Your Auth Key"
        '
        'txtAuthKey
        '
        Me.txtAuthKey.Location = New System.Drawing.Point(17, 135)
        Me.txtAuthKey.Name = "txtAuthKey"
        Me.txtAuthKey.Size = New System.Drawing.Size(375, 20)
        Me.txtAuthKey.TabIndex = 5
        '
        'lblAuthKeyInstruct
        '
        Me.lblAuthKeyInstruct.BackColor = System.Drawing.Color.Transparent
        Me.lblAuthKeyInstruct.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthKeyInstruct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAuthKeyInstruct.Location = New System.Drawing.Point(14, 158)
        Me.lblAuthKeyInstruct.Name = "lblAuthKeyInstruct"
        Me.lblAuthKeyInstruct.Size = New System.Drawing.Size(378, 118)
        Me.lblAuthKeyInstruct.TabIndex = 6
        Me.lblAuthKeyInstruct.Text = resources.GetString("lblAuthKeyInstruct.Text")
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(282, 408)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnExitWithoutSave
        '
        Me.btnExitWithoutSave.Location = New System.Drawing.Point(12, 408)
        Me.btnExitWithoutSave.Name = "btnExitWithoutSave"
        Me.btnExitWithoutSave.Size = New System.Drawing.Size(125, 23)
        Me.btnExitWithoutSave.TabIndex = 8
        Me.btnExitWithoutSave.Text = "Exit Without Saving"
        Me.btnExitWithoutSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Refresh Interval"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(378, 39)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "The refresh interval is set in seconds. Don't set this too low or it might cause " &
    "problems."
        '
        'trkUpdateInterval
        '
        Me.trkUpdateInterval.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.trkUpdateInterval.Location = New System.Drawing.Point(12, 318)
        Me.trkUpdateInterval.Maximum = 60
        Me.trkUpdateInterval.Minimum = 5
        Me.trkUpdateInterval.Name = "trkUpdateInterval"
        Me.trkUpdateInterval.Size = New System.Drawing.Size(380, 45)
        Me.trkUpdateInterval.TabIndex = 11
        Me.trkUpdateInterval.Value = 5
        '
        'lblInterval
        '
        Me.lblInterval.BackColor = System.Drawing.Color.Transparent
        Me.lblInterval.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterval.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblInterval.Location = New System.Drawing.Point(14, 366)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(378, 39)
        Me.lblInterval.TabIndex = 12
        Me.lblInterval.Text = "ManHole will update every %s seconds"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(404, 443)
        Me.Controls.Add(Me.lblInterval)
        Me.Controls.Add(Me.trkUpdateInterval)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExitWithoutSave)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblAuthKeyInstruct)
        Me.Controls.Add(Me.txtAuthKey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSetDefaultURL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPiHoleURL)
        Me.Controls.Add(Me.lblPHInterfaceURL)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPHInterfaceURL As Label
    Friend WithEvents txtPiHoleURL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSetDefaultURL As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthKey As MaskedTextBox
    Friend WithEvents lblAuthKeyInstruct As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnExitWithoutSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents trkUpdateInterval As TrackBar
    Friend WithEvents lblInterval As Label
End Class
