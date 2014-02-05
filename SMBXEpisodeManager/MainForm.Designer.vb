<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.isUpdated = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.launchSMBXButton = New System.Windows.Forms.ToolStripButton()
        Me.feedbackButton = New System.Windows.Forms.ToolStripButton()
        Me.settingsToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.episodeTab = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RefreshWorlds = New System.Windows.Forms.Button()
        Me.RefreshIndex = New System.Windows.Forms.Button()
        Me.IconImage = New System.Windows.Forms.PictureBox()
        Me.AvailableEpisodes = New System.Windows.Forms.ListBox()
        Me.InstalledWorlds = New System.Windows.Forms.ListBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.smbxVersionsTab = New System.Windows.Forms.TabPage()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.isExtract = New System.Windows.Forms.ToolStripLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.episodeTab.SuspendLayout()
        CType(Me.IconImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.smbxVersionsTab.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.isUpdated})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 572)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(572, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'isUpdated
        '
        Me.isUpdated.Name = "isUpdated"
        Me.isUpdated.Size = New System.Drawing.Size(68, 17)
        Me.isUpdated.Text = "isUpToDate"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.launchSMBXButton, Me.feedbackButton, Me.settingsToolStrip, Me.ToolStripLabel1, Me.ToolStripProgressBar1, Me.isExtract})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(572, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'launchSMBXButton
        '
        Me.launchSMBXButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.launchSMBXButton.Image = Global.SMBXEpisodeManager.My.Resources.Resources.favicon
        Me.launchSMBXButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.launchSMBXButton.Name = "launchSMBXButton"
        Me.launchSMBXButton.Size = New System.Drawing.Size(23, 22)
        Me.launchSMBXButton.Text = "Launch SMBX"
        '
        'feedbackButton
        '
        Me.feedbackButton.BackColor = System.Drawing.Color.Transparent
        Me.feedbackButton.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.Gnome_dialog_question
        Me.feedbackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.feedbackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.feedbackButton.Image = Global.SMBXEpisodeManager.My.Resources.Resources.Gnome_dialog_question
        Me.feedbackButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.feedbackButton.Name = "feedbackButton"
        Me.feedbackButton.Size = New System.Drawing.Size(23, 22)
        Me.feedbackButton.Text = "Submit Feedback on the Program from Here"
        '
        'settingsToolStrip
        '
        Me.settingsToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.settingsToolStrip.Image = Global.SMBXEpisodeManager.My.Resources.Resources.Settings
        Me.settingsToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.settingsToolStrip.Name = "settingsToolStrip"
        Me.settingsToolStrip.Size = New System.Drawing.Size(23, 22)
        Me.settingsToolStrip.Text = "Program Settings"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.IsLink = True
        Me.ToolStripLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripLabel1.Text = "SMBX Update Available!"
        Me.ToolStripLabel1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.episodeTab)
        Me.TabControl1.Controls.Add(Me.smbxVersionsTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(572, 547)
        Me.TabControl1.TabIndex = 17
        '
        'episodeTab
        '
        Me.episodeTab.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.Background_Main_Full
        Me.episodeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.episodeTab.Controls.Add(Me.Label3)
        Me.episodeTab.Controls.Add(Me.RefreshWorlds)
        Me.episodeTab.Controls.Add(Me.RefreshIndex)
        Me.episodeTab.Controls.Add(Me.IconImage)
        Me.episodeTab.Controls.Add(Me.AvailableEpisodes)
        Me.episodeTab.Controls.Add(Me.InstalledWorlds)
        Me.episodeTab.Controls.Add(Me.DescriptionTextBox)
        Me.episodeTab.Controls.Add(Me.Label4)
        Me.episodeTab.Controls.Add(Me.AuthorTextBox)
        Me.episodeTab.Controls.Add(Me.Label1)
        Me.episodeTab.Controls.Add(Me.deleteButton)
        Me.episodeTab.Controls.Add(Me.Label2)
        Me.episodeTab.Controls.Add(Me.Button1)
        Me.episodeTab.Controls.Add(Me.PictureBox1)
        Me.episodeTab.Location = New System.Drawing.Point(4, 22)
        Me.episodeTab.Name = "episodeTab"
        Me.episodeTab.Padding = New System.Windows.Forms.Padding(3)
        Me.episodeTab.Size = New System.Drawing.Size(564, 521)
        Me.episodeTab.TabIndex = 0
        Me.episodeTab.Text = "Episodes"
        Me.episodeTab.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(15, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Available for Download:"
        '
        'RefreshWorlds
        '
        Me.RefreshWorlds.BackgroundImage = CType(resources.GetObject("RefreshWorlds.BackgroundImage"), System.Drawing.Image)
        Me.RefreshWorlds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefreshWorlds.Location = New System.Drawing.Point(333, 334)
        Me.RefreshWorlds.Name = "RefreshWorlds"
        Me.RefreshWorlds.Size = New System.Drawing.Size(36, 36)
        Me.RefreshWorlds.TabIndex = 16
        Me.RefreshWorlds.UseVisualStyleBackColor = True
        '
        'RefreshIndex
        '
        Me.RefreshIndex.BackgroundImage = CType(resources.GetObject("RefreshIndex.BackgroundImage"), System.Drawing.Image)
        Me.RefreshIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefreshIndex.Location = New System.Drawing.Point(101, 334)
        Me.RefreshIndex.Name = "RefreshIndex"
        Me.RefreshIndex.Size = New System.Drawing.Size(36, 36)
        Me.RefreshIndex.TabIndex = 15
        Me.RefreshIndex.UseVisualStyleBackColor = True
        '
        'IconImage
        '
        Me.IconImage.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.Test
        Me.IconImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconImage.Location = New System.Drawing.Point(407, 377)
        Me.IconImage.Name = "IconImage"
        Me.IconImage.Size = New System.Drawing.Size(112, 100)
        Me.IconImage.TabIndex = 5
        Me.IconImage.TabStop = False
        '
        'AvailableEpisodes
        '
        Me.AvailableEpisodes.FormattingEnabled = True
        Me.AvailableEpisodes.Location = New System.Drawing.Point(14, 22)
        Me.AvailableEpisodes.Name = "AvailableEpisodes"
        Me.AvailableEpisodes.Size = New System.Drawing.Size(227, 277)
        Me.AvailableEpisodes.TabIndex = 0
        '
        'InstalledWorlds
        '
        Me.InstalledWorlds.FormattingEnabled = True
        Me.InstalledWorlds.Location = New System.Drawing.Point(247, 22)
        Me.InstalledWorlds.Name = "InstalledWorlds"
        Me.InstalledWorlds.Size = New System.Drawing.Size(319, 277)
        Me.InstalledWorlds.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(91, 393)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(299, 62)
        Me.DescriptionTextBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(244, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Already Installed: "
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(91, 461)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.ReadOnly = True
        Me.AuthorTextBox.Size = New System.Drawing.Size(299, 20)
        Me.AuthorTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(22, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Description:"
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(247, 305)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(80, 80)
        Me.deleteButton.TabIndex = 9
        Me.deleteButton.Text = "Delete Selected World"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(44, 464)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Author:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Install Selected World"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.Frame
        Me.PictureBox1.Location = New System.Drawing.Point(399, 369)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 116)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'smbxVersionsTab
        '
        Me.smbxVersionsTab.Controls.Add(Me.PictureBox2)
        Me.smbxVersionsTab.Location = New System.Drawing.Point(4, 22)
        Me.smbxVersionsTab.Name = "smbxVersionsTab"
        Me.smbxVersionsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.smbxVersionsTab.Size = New System.Drawing.Size(564, 521)
        Me.smbxVersionsTab.TabIndex = 1
        Me.smbxVersionsTab.Text = "SMBX Versions"
        Me.smbxVersionsTab.ToolTipText = "Download and Manage Additional SMBX Versions from Here"
        Me.smbxVersionsTab.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ToolStripProgressBar1.Visible = False
        '
        'isExtract
        '
        Me.isExtract.Name = "isExtract"
        Me.isExtract.Size = New System.Drawing.Size(68, 22)
        Me.isExtract.Text = "Extracting..."
        Me.isExtract.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.LuigiSkid
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(568, 522)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 594)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Super Mario Bros X. Episode Manager"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.episodeTab.ResumeLayout(False)
        Me.episodeTab.PerformLayout()
        CType(Me.IconImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.smbxVersionsTab.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AvailableEpisodes As System.Windows.Forms.ListBox
    Friend WithEvents InstalledWorlds As System.Windows.Forms.ListBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents IconImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents isUpdated As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents launchSMBXButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents RefreshIndex As System.Windows.Forms.Button
    Friend WithEvents RefreshWorlds As System.Windows.Forms.Button
    Friend WithEvents feedbackButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents episodeTab As System.Windows.Forms.TabPage
    Friend WithEvents smbxVersionsTab As System.Windows.Forms.TabPage
    Friend WithEvents settingsToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents isExtract As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
