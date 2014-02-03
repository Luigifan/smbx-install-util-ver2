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
        Me.AvailableEpisodes = New System.Windows.Forms.ListBox()
        Me.InstalledWorlds = New System.Windows.Forms.ListBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.isUpdated = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IconImage = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.progressbar2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.RefreshIndex = New System.Windows.Forms.Button()
        Me.RefreshWorlds = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.IconImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AvailableEpisodes
        '
        Me.AvailableEpisodes.FormattingEnabled = True
        Me.AvailableEpisodes.Location = New System.Drawing.Point(12, 49)
        Me.AvailableEpisodes.Name = "AvailableEpisodes"
        Me.AvailableEpisodes.Size = New System.Drawing.Size(227, 277)
        Me.AvailableEpisodes.TabIndex = 0
        '
        'InstalledWorlds
        '
        Me.InstalledWorlds.FormattingEnabled = True
        Me.InstalledWorlds.Location = New System.Drawing.Point(245, 49)
        Me.InstalledWorlds.Name = "InstalledWorlds"
        Me.InstalledWorlds.Size = New System.Drawing.Size(319, 277)
        Me.InstalledWorlds.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(89, 420)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(299, 62)
        Me.DescriptionTextBox.TabIndex = 2
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Location = New System.Drawing.Point(89, 488)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.ReadOnly = True
        Me.AuthorTextBox.Size = New System.Drawing.Size(299, 20)
        Me.AuthorTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(20, 428)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(42, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Author:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Install Selected World"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(245, 332)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(80, 80)
        Me.deleteButton.TabIndex = 9
        Me.deleteButton.Text = "Delete Selected World"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Available for Download:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(242, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Already Installed: "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(397, 361)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Program Settings"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.isUpdated})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 520)
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
        'IconImage
        '
        Me.IconImage.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.Test
        Me.IconImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconImage.Location = New System.Drawing.Point(405, 404)
        Me.IconImage.Name = "IconImage"
        Me.IconImage.Size = New System.Drawing.Size(112, 100)
        Me.IconImage.TabIndex = 5
        Me.IconImage.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.Frame
        Me.PictureBox1.Location = New System.Drawing.Point(397, 396)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 116)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.progressbar2, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(572, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.SMBXEpisodeManager.My.Resources.Resources.favicon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Launch SMBX"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton2.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.Gnome_dialog_question
        Me.ToolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.SMBXEpisodeManager.My.Resources.Resources.Gnome_dialog_question
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Submit Feedback on the Program from Here"
        '
        'progressbar2
        '
        Me.progressbar2.Name = "progressbar2"
        Me.progressbar2.Size = New System.Drawing.Size(100, 22)
        Me.progressbar2.Visible = False
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
        'RefreshIndex
        '
        Me.RefreshIndex.BackgroundImage = CType(resources.GetObject("RefreshIndex.BackgroundImage"), System.Drawing.Image)
        Me.RefreshIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefreshIndex.Location = New System.Drawing.Point(99, 361)
        Me.RefreshIndex.Name = "RefreshIndex"
        Me.RefreshIndex.Size = New System.Drawing.Size(36, 36)
        Me.RefreshIndex.TabIndex = 15
        Me.RefreshIndex.UseVisualStyleBackColor = True
        '
        'RefreshWorlds
        '
        Me.RefreshWorlds.BackgroundImage = CType(resources.GetObject("RefreshWorlds.BackgroundImage"), System.Drawing.Image)
        Me.RefreshWorlds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RefreshWorlds.Location = New System.Drawing.Point(331, 361)
        Me.RefreshWorlds.Name = "RefreshWorlds"
        Me.RefreshWorlds.Size = New System.Drawing.Size(36, 36)
        Me.RefreshWorlds.TabIndex = 16
        Me.RefreshWorlds.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SMBXEpisodeManager.My.Resources.Resources.Background_Main_Full
        Me.ClientSize = New System.Drawing.Size(572, 542)
        Me.Controls.Add(Me.RefreshWorlds)
        Me.Controls.Add(Me.RefreshIndex)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.InstalledWorlds)
        Me.Controls.Add(Me.AvailableEpisodes)
        Me.Controls.Add(Me.IconImage)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Super Mario Bros X. Episode Manager"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.IconImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents isUpdated As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RefreshIndex As System.Windows.Forms.Button
    Friend WithEvents RefreshWorlds As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents progressbar2 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel

End Class
