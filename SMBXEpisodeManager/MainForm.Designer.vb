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
        Me.launchSMBXSplit = New System.Windows.Forms.ToolStripSplitButton()
        Me.LaunchMainGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.feedbackButton = New System.Windows.Forms.ToolStripButton()
        Me.settingsToolStrip = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.isExtract = New System.Windows.Forms.ToolStripLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.smbxVersionsTab = New System.Windows.Forms.TabPage()
        Me.curSMBXLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.smbx1301button = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.smbx121button = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.smbx59button = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.smbx1button = New System.Windows.Forms.Button()
        Me.episodeTab = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.AvailableEpisodes = New System.Windows.Forms.ListBox()
        Me.IconImage = New System.Windows.Forms.PictureBox()
        Me.RefreshIndex = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.installedTab = New System.Windows.Forms.TabPage()
        Me.RefreshWorlds = New System.Windows.Forms.Button()
        Me.InstalledWorlds = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.epName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Author = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.smbxVersionsTab.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.episodeTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.installedTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.launchSMBXButton, Me.launchSMBXSplit, Me.feedbackButton, Me.settingsToolStrip, Me.ToolStripLabel1, Me.ToolStripProgressBar1, Me.isExtract})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(572, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'launchSMBXButton
        '
        Me.launchSMBXButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.launchSMBXButton.Image = Global.SMBXEpisodeManager.My.Resources.Resources.smbx
        Me.launchSMBXButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.launchSMBXButton.Name = "launchSMBXButton"
        Me.launchSMBXButton.Size = New System.Drawing.Size(23, 22)
        Me.launchSMBXButton.Text = "Launch SMBX"
        '
        'launchSMBXSplit
        '
        Me.launchSMBXSplit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.launchSMBXSplit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchMainGameToolStripMenuItem, Me.LaunchEditorToolStripMenuItem})
        Me.launchSMBXSplit.Image = Global.SMBXEpisodeManager.My.Resources.Resources.smbx
        Me.launchSMBXSplit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.launchSMBXSplit.Name = "launchSMBXSplit"
        Me.launchSMBXSplit.Size = New System.Drawing.Size(32, 22)
        Me.launchSMBXSplit.Text = "Launch SMBX"
        Me.launchSMBXSplit.Visible = False
        '
        'LaunchMainGameToolStripMenuItem
        '
        Me.LaunchMainGameToolStripMenuItem.Image = Global.SMBXEpisodeManager.My.Resources.Resources.smbx
        Me.LaunchMainGameToolStripMenuItem.Name = "LaunchMainGameToolStripMenuItem"
        Me.LaunchMainGameToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LaunchMainGameToolStripMenuItem.Text = "Launch Main Game"
        '
        'LaunchEditorToolStripMenuItem
        '
        Me.LaunchEditorToolStripMenuItem.Image = Global.SMBXEpisodeManager.My.Resources.Resources.smbx
        Me.LaunchEditorToolStripMenuItem.Name = "LaunchEditorToolStripMenuItem"
        Me.LaunchEditorToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LaunchEditorToolStripMenuItem.Text = "Launch Editor"
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
        'BackgroundWorker1
        '
        '
        'smbxVersionsTab
        '
        Me.smbxVersionsTab.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.Backgrond_Secondary
        Me.smbxVersionsTab.Controls.Add(Me.smbx1button)
        Me.smbxVersionsTab.Controls.Add(Me.Label8)
        Me.smbxVersionsTab.Controls.Add(Me.PictureBox5)
        Me.smbxVersionsTab.Controls.Add(Me.smbx59button)
        Me.smbxVersionsTab.Controls.Add(Me.Label7)
        Me.smbxVersionsTab.Controls.Add(Me.PictureBox4)
        Me.smbxVersionsTab.Controls.Add(Me.smbx121button)
        Me.smbxVersionsTab.Controls.Add(Me.Label6)
        Me.smbxVersionsTab.Controls.Add(Me.PictureBox3)
        Me.smbxVersionsTab.Controls.Add(Me.smbx1301button)
        Me.smbxVersionsTab.Controls.Add(Me.Label5)
        Me.smbxVersionsTab.Controls.Add(Me.PictureBox2)
        Me.smbxVersionsTab.Controls.Add(Me.curSMBXLabel)
        Me.smbxVersionsTab.Location = New System.Drawing.Point(4, 22)
        Me.smbxVersionsTab.Name = "smbxVersionsTab"
        Me.smbxVersionsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.smbxVersionsTab.Size = New System.Drawing.Size(564, 521)
        Me.smbxVersionsTab.TabIndex = 1
        Me.smbxVersionsTab.Text = "SMBX Versions"
        Me.smbxVersionsTab.ToolTipText = "Download and Manage Additional SMBX Versions from Here"
        Me.smbxVersionsTab.UseVisualStyleBackColor = True
        '
        'curSMBXLabel
        '
        Me.curSMBXLabel.AutoSize = True
        Me.curSMBXLabel.ForeColor = System.Drawing.Color.White
        Me.curSMBXLabel.Location = New System.Drawing.Point(40, 50)
        Me.curSMBXLabel.Name = "curSMBXLabel"
        Me.curSMBXLabel.Size = New System.Drawing.Size(118, 13)
        Me.curSMBXLabel.TabIndex = 0
        Me.curSMBXLabel.Text = "Current SMBX Version: "
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.SMBXEpisodeManager.My.Resources.Resources.smbx
        Me.PictureBox2.Location = New System.Drawing.Point(43, 101)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(83, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "SMBX 1.3.0.1"
        '
        'smbx1301button
        '
        Me.smbx1301button.Location = New System.Drawing.Point(204, 114)
        Me.smbx1301button.Name = "smbx1301button"
        Me.smbx1301button.Size = New System.Drawing.Size(75, 23)
        Me.smbx1301button.TabIndex = 3
        Me.smbx1301button.Text = "Install"
        Me.smbx1301button.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = Global.SMBXEpisodeManager.My.Resources.Resources.smbx
        Me.PictureBox3.Location = New System.Drawing.Point(43, 146)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(83, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SMBX 1.2.1"
        '
        'smbx121button
        '
        Me.smbx121button.Location = New System.Drawing.Point(204, 159)
        Me.smbx121button.Name = "smbx121button"
        Me.smbx121button.Size = New System.Drawing.Size(75, 23)
        Me.smbx121button.TabIndex = 6
        Me.smbx121button.Text = "Install"
        Me.smbx121button.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = Global.SMBXEpisodeManager.My.Resources.Resources.smbx
        Me.PictureBox4.Location = New System.Drawing.Point(43, 192)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(83, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "SMBX Beta 59"
        '
        'smbx59button
        '
        Me.smbx59button.Location = New System.Drawing.Point(204, 205)
        Me.smbx59button.Name = "smbx59button"
        Me.smbx59button.Size = New System.Drawing.Size(75, 23)
        Me.smbx59button.TabIndex = 9
        Me.smbx59button.Text = "Install"
        Me.smbx59button.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Image = Global.SMBXEpisodeManager.My.Resources.Resources.smbx
        Me.PictureBox5.Location = New System.Drawing.Point(43, 236)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(83, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "SMBX 1.0.0"
        '
        'smbx1button
        '
        Me.smbx1button.Location = New System.Drawing.Point(204, 249)
        Me.smbx1button.Name = "smbx1button"
        Me.smbx1button.Size = New System.Drawing.Size(75, 23)
        Me.smbx1button.TabIndex = 12
        Me.smbx1button.Text = "Install"
        Me.smbx1button.UseVisualStyleBackColor = True
        '
        'episodeTab
        '
        Me.episodeTab.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.Background_Main_Full
        Me.episodeTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.episodeTab.Controls.Add(Me.Label3)
        Me.episodeTab.Controls.Add(Me.RefreshIndex)
        Me.episodeTab.Controls.Add(Me.IconImage)
        Me.episodeTab.Controls.Add(Me.AvailableEpisodes)
        Me.episodeTab.Controls.Add(Me.DescriptionTextBox)
        Me.episodeTab.Controls.Add(Me.AuthorTextBox)
        Me.episodeTab.Controls.Add(Me.Label1)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Install Selected World"
        Me.Button1.UseVisualStyleBackColor = True
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
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(91, 461)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.ReadOnly = True
        Me.AuthorTextBox.Size = New System.Drawing.Size(299, 20)
        Me.AuthorTextBox.TabIndex = 3
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
        'AvailableEpisodes
        '
        Me.AvailableEpisodes.FormattingEnabled = True
        Me.AvailableEpisodes.Location = New System.Drawing.Point(14, 22)
        Me.AvailableEpisodes.Name = "AvailableEpisodes"
        Me.AvailableEpisodes.Size = New System.Drawing.Size(542, 277)
        Me.AvailableEpisodes.TabIndex = 0
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.episodeTab)
        Me.TabControl1.Controls.Add(Me.installedTab)
        Me.TabControl1.Controls.Add(Me.smbxVersionsTab)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(572, 547)
        Me.TabControl1.TabIndex = 17
        '
        'installedTab
        '
        Me.installedTab.Controls.Add(Me.RefreshWorlds)
        Me.installedTab.Controls.Add(Me.InstalledWorlds)
        Me.installedTab.Controls.Add(Me.Label4)
        Me.installedTab.Controls.Add(Me.deleteButton)
        Me.installedTab.Location = New System.Drawing.Point(4, 22)
        Me.installedTab.Name = "installedTab"
        Me.installedTab.Size = New System.Drawing.Size(564, 521)
        Me.installedTab.TabIndex = 2
        Me.installedTab.Text = "Currently Installed"
        Me.installedTab.UseVisualStyleBackColor = True
        '
        'RefreshWorlds
        '
        Me.RefreshWorlds.BackgroundImage = CType(resources.GetObject("RefreshWorlds.BackgroundImage"), System.Drawing.Image)
        Me.RefreshWorlds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefreshWorlds.Location = New System.Drawing.Point(94, 350)
        Me.RefreshWorlds.Name = "RefreshWorlds"
        Me.RefreshWorlds.Size = New System.Drawing.Size(36, 36)
        Me.RefreshWorlds.TabIndex = 20
        Me.RefreshWorlds.UseVisualStyleBackColor = True
        '
        'InstalledWorlds
        '
        Me.InstalledWorlds.FormattingEnabled = True
        Me.InstalledWorlds.Location = New System.Drawing.Point(8, 23)
        Me.InstalledWorlds.Name = "InstalledWorlds"
        Me.InstalledWorlds.Size = New System.Drawing.Size(548, 277)
        Me.InstalledWorlds.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(120, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Already Installed: "
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(8, 306)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(80, 80)
        Me.deleteButton.TabIndex = 18
        Me.deleteButton.Text = "Delete Selected World"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(564, 521)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.epName, Me.Author})
        Me.ListView1.Location = New System.Drawing.Point(9, 7)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(547, 324)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'epName
        '
        Me.epName.Text = "Episode Name"
        Me.epName.Width = 236
        '
        'Author
        '
        Me.Author.Text = "Author"
        Me.Author.Width = 94
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "POPULATE"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.smbxVersionsTab.ResumeLayout(False)
        Me.smbxVersionsTab.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.episodeTab.ResumeLayout(False)
        Me.episodeTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.installedTab.ResumeLayout(False)
        Me.installedTab.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents isUpdated As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents launchSMBXButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents feedbackButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents settingsToolStrip As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents isExtract As System.Windows.Forms.ToolStripLabel
    Friend WithEvents launchSMBXSplit As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents LaunchMainGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaunchEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smbxVersionsTab As System.Windows.Forms.TabPage
    Friend WithEvents smbx1button As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents smbx59button As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents smbx121button As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents smbx1301button As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents curSMBXLabel As System.Windows.Forms.Label
    Friend WithEvents episodeTab As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RefreshIndex As System.Windows.Forms.Button
    Friend WithEvents IconImage As System.Windows.Forms.PictureBox
    Friend WithEvents AvailableEpisodes As System.Windows.Forms.ListBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents installedTab As System.Windows.Forms.TabPage
    Friend WithEvents RefreshWorlds As System.Windows.Forms.Button
    Friend WithEvents InstalledWorlds As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents epName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Author As System.Windows.Forms.ColumnHeader

End Class
