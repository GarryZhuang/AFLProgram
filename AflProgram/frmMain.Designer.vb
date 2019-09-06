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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbxLater = New System.Windows.Forms.PictureBox()
        Me.pbxCurrent = New System.Windows.Forms.PictureBox()
        Me.lblWSW = New System.Windows.Forms.Label()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRounds = New System.Windows.Forms.Label()
        Me.btnCheckStats = New System.Windows.Forms.Button()
        Me.cbxRound = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTeam = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxLater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Team:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.pbxLater)
        Me.Panel1.Controls.Add(Me.pbxCurrent)
        Me.Panel1.Controls.Add(Me.lblWSW)
        Me.Panel1.Controls.Add(Me.lblPW)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRounds)
        Me.Panel1.Controls.Add(Me.btnCheckStats)
        Me.Panel1.Controls.Add(Me.cbxRound)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbxTeam)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(276, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 555)
        Me.Panel1.TabIndex = 1
        '
        'pbxLater
        '
        Me.pbxLater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLater.Location = New System.Drawing.Point(338, 206)
        Me.pbxLater.Name = "pbxLater"
        Me.pbxLater.Size = New System.Drawing.Size(120, 120)
        Me.pbxLater.TabIndex = 11
        Me.pbxLater.TabStop = False
        '
        'pbxCurrent
        '
        Me.pbxCurrent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCurrent.Location = New System.Drawing.Point(10, 206)
        Me.pbxCurrent.Name = "pbxCurrent"
        Me.pbxCurrent.Size = New System.Drawing.Size(120, 120)
        Me.pbxCurrent.TabIndex = 10
        Me.pbxCurrent.TabStop = False
        '
        'lblWSW
        '
        Me.lblWSW.AutoSize = True
        Me.lblWSW.BackColor = System.Drawing.Color.Transparent
        Me.lblWSW.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWSW.ForeColor = System.Drawing.Color.White
        Me.lblWSW.Location = New System.Drawing.Point(319, 459)
        Me.lblWSW.Name = "lblWSW"
        Me.lblWSW.Size = New System.Drawing.Size(22, 25)
        Me.lblWSW.TabIndex = 9
        Me.lblWSW.Text = "-"
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.BackColor = System.Drawing.Color.Transparent
        Me.lblPW.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPW.ForeColor = System.Drawing.Color.White
        Me.lblPW.Location = New System.Drawing.Point(319, 415)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(22, 25)
        Me.lblPW.TabIndex = 8
        Me.lblPW.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(115, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Wooden Spoons Won:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(136, 415)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Premierships Won:"
        '
        'txtRounds
        '
        Me.txtRounds.BackColor = System.Drawing.Color.Transparent
        Me.txtRounds.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRounds.ForeColor = System.Drawing.Color.White
        Me.txtRounds.Location = New System.Drawing.Point(136, 206)
        Me.txtRounds.Name = "txtRounds"
        Me.txtRounds.Size = New System.Drawing.Size(196, 120)
        Me.txtRounds.TabIndex = 5
        Me.txtRounds.Text = "Round -" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Team vs Team"
        Me.txtRounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheckStats
        '
        Me.btnCheckStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCheckStats.Font = New System.Drawing.Font("Bahnschrift Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckStats.Location = New System.Drawing.Point(49, 145)
        Me.btnCheckStats.Name = "btnCheckStats"
        Me.btnCheckStats.Size = New System.Drawing.Size(383, 38)
        Me.btnCheckStats.TabIndex = 4
        Me.btnCheckStats.Text = "Check Statistics"
        Me.btnCheckStats.UseVisualStyleBackColor = False
        '
        'cbxRound
        '
        Me.cbxRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRound.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRound.FormattingEnabled = True
        Me.cbxRound.Items.AddRange(New Object() {"-Select Round-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbxRound.Location = New System.Drawing.Point(154, 82)
        Me.cbxRound.Name = "cbxRound"
        Me.cbxRound.Size = New System.Drawing.Size(256, 27)
        Me.cbxRound.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Round:"
        '
        'cbxTeam
        '
        Me.cbxTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTeam.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTeam.FormattingEnabled = True
        Me.cbxTeam.Items.AddRange(New Object() {"-Select Team-", "Adelaide", "Brisbane", "Carlton", "Collingwood", "Essendon", "Fremantle", "Geelong", "Gold coast", "GWS", "Hawthorn", "Melbourne", "North Melbourne", "Port Adelaide", "Richmond", "St. Kilda", "Sydney", "West Coast ", "Bulldogs"})
        Me.cbxTeam.Location = New System.Drawing.Point(154, 29)
        Me.cbxTeam.Name = "cbxTeam"
        Me.cbxTeam.Size = New System.Drawing.Size(256, 27)
        Me.cbxTeam.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(993, 555)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "AFL Program"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxLater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbxRound As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTeam As ComboBox
    Friend WithEvents btnCheckStats As Button
    Friend WithEvents txtRounds As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pbxLater As PictureBox
    Friend WithEvents pbxCurrent As PictureBox
    Friend WithEvents lblWSW As Label
    Friend WithEvents lblPW As Label
End Class
