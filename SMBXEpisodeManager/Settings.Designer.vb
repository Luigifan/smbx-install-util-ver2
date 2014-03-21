<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.smbxDir = New System.Windows.Forms.TextBox()
        Me.worldsDir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.execDir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.mikesIndexRbutton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ver = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.smbRadio = New System.Windows.Forms.RadioButton()
        Me.wfRadio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.customIndexRbutton = New System.Windows.Forms.RadioButton()
        Me.customIndexTb = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMBX Directory: "
        '
        'smbxDir
        '
        Me.smbxDir.Location = New System.Drawing.Point(129, 10)
        Me.smbxDir.Name = "smbxDir"
        Me.smbxDir.Size = New System.Drawing.Size(311, 20)
        Me.smbxDir.TabIndex = 1
        '
        'worldsDir
        '
        Me.worldsDir.Location = New System.Drawing.Point(129, 39)
        Me.worldsDir.Name = "worldsDir"
        Me.worldsDir.Size = New System.Drawing.Size(311, 20)
        Me.worldsDir.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Worlds Directory: "
        '
        'execDir
        '
        Me.execDir.Location = New System.Drawing.Point(129, 65)
        Me.execDir.Name = "execDir"
        Me.execDir.Size = New System.Drawing.Size(311, 20)
        Me.execDir.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Executable Directory: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(446, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.Location = New System.Drawing.Point(0, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(532, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save All Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'mikesIndexRbutton
        '
        Me.mikesIndexRbutton.AutoSize = True
        Me.mikesIndexRbutton.Checked = True
        Me.mikesIndexRbutton.Location = New System.Drawing.Point(122, 27)
        Me.mikesIndexRbutton.Name = "mikesIndexRbutton"
        Me.mikesIndexRbutton.Size = New System.Drawing.Size(55, 17)
        Me.mikesIndexRbutton.TabIndex = 9
        Me.mikesIndexRbutton.TabStop = True
        Me.mikesIndexRbutton.Text = "Mike's"
        Me.mikesIndexRbutton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Download Servers: "
        '
        'ver
        '
        Me.ver.AutoSize = True
        Me.ver.ForeColor = System.Drawing.Color.Red
        Me.ver.Location = New System.Drawing.Point(446, 68)
        Me.ver.Name = "ver"
        Me.ver.Size = New System.Drawing.Size(39, 13)
        Me.ver.TabIndex = 11
        Me.ver.Text = "Label5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Look and Feel: "
        '
        'smbRadio
        '
        Me.smbRadio.AutoSize = True
        Me.smbRadio.Checked = True
        Me.smbRadio.Location = New System.Drawing.Point(122, 16)
        Me.smbRadio.Name = "smbRadio"
        Me.smbRadio.Size = New System.Drawing.Size(82, 17)
        Me.smbRadio.TabIndex = 13
        Me.smbRadio.TabStop = True
        Me.smbRadio.Text = "Super Mario"
        Me.smbRadio.UseVisualStyleBackColor = True
        '
        'wfRadio
        '
        Me.wfRadio.AutoSize = True
        Me.wfRadio.Location = New System.Drawing.Point(210, 16)
        Me.wfRadio.Name = "wfRadio"
        Me.wfRadio.Size = New System.Drawing.Size(100, 17)
        Me.wfRadio.TabIndex = 14
        Me.wfRadio.Text = "Windows Forms"
        Me.wfRadio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.wfRadio)
        Me.GroupBox1.Controls.Add(Me.smbRadio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 59)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Look and Feel"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.customIndexTb)
        Me.GroupBox2.Controls.Add(Me.customIndexRbutton)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.mikesIndexRbutton)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(532, 61)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Servers"
        '
        'customIndexRbutton
        '
        Me.customIndexRbutton.AutoSize = True
        Me.customIndexRbutton.Location = New System.Drawing.Point(183, 27)
        Me.customIndexRbutton.Name = "customIndexRbutton"
        Me.customIndexRbutton.Size = New System.Drawing.Size(89, 17)
        Me.customIndexRbutton.TabIndex = 11
        Me.customIndexRbutton.TabStop = True
        Me.customIndexRbutton.Text = "Custom Index"
        Me.customIndexRbutton.UseVisualStyleBackColor = True
        '
        'customIndexTb
        '
        Me.customIndexTb.Enabled = False
        Me.customIndexTb.Location = New System.Drawing.Point(280, 27)
        Me.customIndexTb.Name = "customIndexTb"
        Me.customIndexTb.Size = New System.Drawing.Size(241, 20)
        Me.customIndexTb.TabIndex = 12
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 239)
        Me.Controls.Add(Me.ver)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.execDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.worldsDir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.smbxDir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents smbxDir As System.Windows.Forms.TextBox
    Friend WithEvents worldsDir As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents execDir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents mikesIndexRbutton As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ver As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents smbRadio As System.Windows.Forms.RadioButton
    Friend WithEvents wfRadio As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents customIndexRbutton As System.Windows.Forms.RadioButton
    Friend WithEvents customIndexTb As System.Windows.Forms.TextBox
End Class
