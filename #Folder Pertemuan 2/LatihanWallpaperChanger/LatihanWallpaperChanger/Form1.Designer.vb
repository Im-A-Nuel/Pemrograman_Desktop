<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        txtPath = New TextBox()
        btnBrowse = New Button()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusCurrent = New ToolStripStatusLabel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        TimerWall = New Timer(components)
        TimerElapsed = New Timer(components)
        Label2 = New Label()
        cbPreview = New CheckBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        cbInterval = New ComboBox()
        btnRun = New Button()
        clbWallpaper = New CheckedListBox()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(9, 3, 0, 3)
        MenuStrip1.Size = New Size(853, 35)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(149, 34)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(149, 34)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(65, 29)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(164, 34)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(164, 34)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 67)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 25)
        Label1.TabIndex = 1
        Label1.Text = "Folder Path :"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(144, 62)
        txtPath.Margin = New Padding(4, 5, 4, 5)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(571, 31)
        txtPath.TabIndex = 2
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(729, 62)
        btnBrowse.Margin = New Padding(4, 5, 4, 5)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(74, 38)
        btnBrowse.TabIndex = 3
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusCurrent})
        StatusStrip1.Location = New Point(0, 533)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 20, 0)
        StatusStrip1.Size = New Size(853, 32)
        StatusStrip1.TabIndex = 4
        StatusStrip1.Text = "Ready"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(60, 25)
        ToolStripStatusReady.Text = "Ready"
        ' 
        ' ToolStripStatusCurrent
        ' 
        ToolStripStatusCurrent.Name = "ToolStripStatusCurrent"
        ToolStripStatusCurrent.Size = New Size(203, 25)
        ToolStripStatusCurrent.Text = "Current Wallpaper: none"
        ' 
        ' TimerWall
        ' 
        ' 
        ' TimerElapsed
        ' 
        TimerElapsed.Interval = 1000
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 123)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(334, 25)
        Label2.TabIndex = 5
        Label2.Text = "Please select one or more pictures below"
        ' 
        ' cbPreview
        ' 
        cbPreview.AutoSize = True
        cbPreview.Checked = True
        cbPreview.CheckState = CheckState.Checked
        cbPreview.Location = New Point(441, 123)
        cbPreview.Margin = New Padding(4, 5, 4, 5)
        cbPreview.Name = "cbPreview"
        cbPreview.Size = New Size(153, 29)
        cbPreview.TabIndex = 6
        cbPreview.Text = "Preview Image"
        cbPreview.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(413, 153)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(381, 261)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(4, 5)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(369, 247)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(413, 440)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 25)
        Label3.TabIndex = 9
        Label3.Text = "Interval:"
        ' 
        ' cbInterval
        ' 
        cbInterval.FormattingEnabled = True
        cbInterval.Items.AddRange(New Object() {"10 ", "30 ", "1 Minutes"})
        cbInterval.Location = New Point(491, 435)
        cbInterval.Margin = New Padding(4, 5, 4, 5)
        cbInterval.Name = "cbInterval"
        cbInterval.Size = New Size(171, 33)
        cbInterval.TabIndex = 10
        cbInterval.Text = "Select First"
        ' 
        ' btnRun
        ' 
        btnRun.Location = New Point(696, 435)
        btnRun.Margin = New Padding(4, 5, 4, 5)
        btnRun.Name = "btnRun"
        btnRun.Size = New Size(107, 38)
        btnRun.TabIndex = 11
        btnRun.Text = "Run!"
        btnRun.UseVisualStyleBackColor = True
        ' 
        ' clbWallpaper
        ' 
        clbWallpaper.FormattingEnabled = True
        clbWallpaper.Location = New Point(47, 158)
        clbWallpaper.Margin = New Padding(4, 5, 4, 5)
        clbWallpaper.Name = "clbWallpaper"
        clbWallpaper.Size = New Size(337, 256)
        clbWallpaper.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(853, 565)
        Controls.Add(clbWallpaper)
        Controls.Add(btnRun)
        Controls.Add(cbInterval)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(cbPreview)
        Controls.Add(Label2)
        Controls.Add(StatusStrip1)
        Controls.Add(btnBrowse)
        Controls.Add(txtPath)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Wallpaper Changer"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TimerWall As Timer
    Friend WithEvents TimerElapsed As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents cbPreview As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbInterval As ComboBox
    Friend WithEvents btnRun As Button
    Friend WithEvents clbWallpaper As CheckedListBox
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusCurrent As ToolStripStatusLabel

End Class
