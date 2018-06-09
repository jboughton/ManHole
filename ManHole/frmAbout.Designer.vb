<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblAboutAppTitle = New System.Windows.Forms.Label()
        Me.lblAboutVersion = New System.Windows.Forms.Label()
        Me.lblAboutText = New System.Windows.Forms.Label()
        Me.btnAboutClose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAboutAppTitle
        '
        Me.lblAboutAppTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblAboutAppTitle.Font = New System.Drawing.Font("Segoe UI Semilight", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutAppTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAboutAppTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblAboutAppTitle.Name = "lblAboutAppTitle"
        Me.lblAboutAppTitle.Size = New System.Drawing.Size(776, 58)
        Me.lblAboutAppTitle.TabIndex = 1
        Me.lblAboutAppTitle.Text = "ManHole"
        Me.lblAboutAppTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblAboutVersion
        '
        Me.lblAboutVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblAboutVersion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAboutVersion.Location = New System.Drawing.Point(12, 71)
        Me.lblAboutVersion.Name = "lblAboutVersion"
        Me.lblAboutVersion.Size = New System.Drawing.Size(776, 32)
        Me.lblAboutVersion.TabIndex = 2
        Me.lblAboutVersion.Text = "Version"
        Me.lblAboutVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAboutText
        '
        Me.lblAboutText.BackColor = System.Drawing.Color.Transparent
        Me.lblAboutText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutText.ForeColor = System.Drawing.Color.LightGray
        Me.lblAboutText.Location = New System.Drawing.Point(264, 107)
        Me.lblAboutText.Name = "lblAboutText"
        Me.lblAboutText.Size = New System.Drawing.Size(524, 260)
        Me.lblAboutText.TabIndex = 3
        Me.lblAboutText.Text = resources.GetString("lblAboutText.Text")
        '
        'btnAboutClose
        '
        Me.btnAboutClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutClose.ForeColor = System.Drawing.Color.White
        Me.btnAboutClose.Location = New System.Drawing.Point(686, 401)
        Me.btnAboutClose.Name = "btnAboutClose"
        Me.btnAboutClose.Size = New System.Drawing.Size(102, 37)
        Me.btnAboutClose.TabIndex = 4
        Me.btnAboutClose.Text = "Close"
        Me.btnAboutClose.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Donate To Me"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(168, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 37)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Donate To Pi-Hole"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(0, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 261)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAboutClose)
        Me.Controls.Add(Me.lblAboutText)
        Me.Controls.Add(Me.lblAboutVersion)
        Me.Controls.Add(Me.lblAboutAppTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About ManHole"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAboutAppTitle As Label
    Friend WithEvents lblAboutVersion As Label
    Friend WithEvents lblAboutText As Label
    Friend WithEvents btnAboutClose As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
