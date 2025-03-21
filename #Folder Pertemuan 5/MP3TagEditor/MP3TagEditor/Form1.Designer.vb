﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        tvDrive = New TreeView()
        ImageList1 = New ImageList(components)
        LvMP3 = New ListView()
        chName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chFileSize = New ColumnHeader()
        chLastModified = New ColumnHeader()
        chLastAccessed = New ColumnHeader()
        chCreateDate = New ColumnHeader()
        chAttributes = New ColumnHeader()
        SplitContainer1 = New SplitContainer()
        SplitContainer2 = New SplitContainer()
        SplitContainer3 = New SplitContainer()
        btnEdit = New Button()
        txtYear = New TextBox()
        txtAlbum = New TextBox()
        txtArtist = New TextBox()
        txtTitle = New TextBox()
        txtTrack = New TextBox()
        lblYear = New Label()
        lblAlbum = New Label()
        lblArtist = New Label()
        lblTitle = New Label()
        lblTrack = New Label()
        lblMp3Editor = New Label()
        GroupBox1 = New GroupBox()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        btnStop = New Button()
        btnPlay = New Button()
        lblDuration = New Label()
        lblPlaying = New Label()
        lblTextDuration = New Label()
        lblTextPlaying = New Label()
        Timer1 = New Timer(components)
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(SplitContainer3, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer3.Panel1.SuspendLayout()
        SplitContainer3.Panel2.SuspendLayout()
        SplitContainer3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tvDrive
        ' 
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(3, 3)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(270, 513)
        tvDrive.TabIndex = 0
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.png")
        ImageList1.Images.SetKeyName(1, "folder.png")
        ' 
        ' LvMP3
        ' 
        LvMP3.Columns.AddRange(New ColumnHeader() {chName, chExtension, chFileSize, chLastModified, chLastAccessed, chCreateDate, chAttributes})
        LvMP3.GridLines = True
        LvMP3.Location = New Point(3, 0)
        LvMP3.Name = "LvMP3"
        LvMP3.Size = New Size(651, 222)
        LvMP3.TabIndex = 1
        LvMP3.UseCompatibleStateImageBehavior = False
        LvMP3.View = View.Details
        ' 
        ' chName
        ' 
        chName.Text = "Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chFileSize
        ' 
        chFileSize.Text = "File Size"
        ' 
        ' chLastModified
        ' 
        chLastModified.Text = "Last Modified"
        ' 
        ' chLastAccessed
        ' 
        chLastAccessed.Text = "Last Accessed"
        ' 
        ' chCreateDate
        ' 
        chCreateDate.Text = "Create Date"
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = "Attributes"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(-4, 3)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New Size(963, 519)
        SplitContainer1.SplitterDistance = 276
        SplitContainer1.TabIndex = 2
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Location = New Point(3, 3)
        SplitContainer2.Name = "SplitContainer2"
        SplitContainer2.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(LvMP3)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(SplitContainer3)
        SplitContainer2.Size = New Size(657, 513)
        SplitContainer2.SplitterDistance = 219
        SplitContainer2.TabIndex = 2
        ' 
        ' SplitContainer3
        ' 
        SplitContainer3.Dock = DockStyle.Fill
        SplitContainer3.Location = New Point(0, 0)
        SplitContainer3.Name = "SplitContainer3"
        ' 
        ' SplitContainer3.Panel1
        ' 
        SplitContainer3.Panel1.Controls.Add(btnEdit)
        SplitContainer3.Panel1.Controls.Add(txtYear)
        SplitContainer3.Panel1.Controls.Add(txtAlbum)
        SplitContainer3.Panel1.Controls.Add(txtArtist)
        SplitContainer3.Panel1.Controls.Add(txtTitle)
        SplitContainer3.Panel1.Controls.Add(txtTrack)
        SplitContainer3.Panel1.Controls.Add(lblYear)
        SplitContainer3.Panel1.Controls.Add(lblAlbum)
        SplitContainer3.Panel1.Controls.Add(lblArtist)
        SplitContainer3.Panel1.Controls.Add(lblTitle)
        SplitContainer3.Panel1.Controls.Add(lblTrack)
        SplitContainer3.Panel1.Controls.Add(lblMp3Editor)
        ' 
        ' SplitContainer3.Panel2
        ' 
        SplitContainer3.Panel2.Controls.Add(GroupBox1)
        SplitContainer3.Size = New Size(657, 290)
        SplitContainer3.SplitterDistance = 390
        SplitContainer3.TabIndex = 0
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(281, 234)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 29)
        btnEdit.TabIndex = 11
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(97, 187)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(243, 27)
        txtYear.TabIndex = 10
        ' 
        ' txtAlbum
        ' 
        txtAlbum.Location = New Point(97, 152)
        txtAlbum.Name = "txtAlbum"
        txtAlbum.Size = New Size(243, 27)
        txtAlbum.TabIndex = 9
        ' 
        ' txtArtist
        ' 
        txtArtist.Location = New Point(97, 123)
        txtArtist.Name = "txtArtist"
        txtArtist.Size = New Size(243, 27)
        txtArtist.TabIndex = 8
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(97, 90)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(243, 27)
        txtTitle.TabIndex = 7
        ' 
        ' txtTrack
        ' 
        txtTrack.Location = New Point(97, 54)
        txtTrack.Name = "txtTrack"
        txtTrack.Size = New Size(125, 27)
        txtTrack.TabIndex = 6
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(16, 187)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(44, 20)
        lblYear.TabIndex = 5
        lblYear.Text = "Year: "
        ' 
        ' lblAlbum
        ' 
        lblAlbum.AutoSize = True
        lblAlbum.Location = New Point(16, 155)
        lblAlbum.Name = "lblAlbum"
        lblAlbum.Size = New Size(60, 20)
        lblAlbum.TabIndex = 4
        lblAlbum.Text = "Album: "
        ' 
        ' lblArtist
        ' 
        lblArtist.AutoSize = True
        lblArtist.Location = New Point(16, 121)
        lblArtist.Name = "lblArtist"
        lblArtist.Size = New Size(47, 20)
        lblArtist.TabIndex = 3
        lblArtist.Text = "Artist:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(16, 93)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(41, 20)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Title:"
        ' 
        ' lblTrack
        ' 
        lblTrack.AutoSize = True
        lblTrack.Location = New Point(16, 61)
        lblTrack.Name = "lblTrack"
        lblTrack.Size = New Size(46, 20)
        lblTrack.TabIndex = 1
        lblTrack.Text = "Track:"
        ' 
        ' lblMp3Editor
        ' 
        lblMp3Editor.AutoSize = True
        lblMp3Editor.Location = New Point(16, 19)
        lblMp3Editor.Name = "lblMp3Editor"
        lblMp3Editor.Size = New Size(109, 20)
        lblMp3Editor.TabIndex = 0
        lblMp3Editor.Text = "MP3 ID3 Editor"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(AxWindowsMediaPlayer1)
        GroupBox1.Controls.Add(btnStop)
        GroupBox1.Controls.Add(btnPlay)
        GroupBox1.Controls.Add(lblDuration)
        GroupBox1.Controls.Add(lblPlaying)
        GroupBox1.Controls.Add(lblTextDuration)
        GroupBox1.Controls.Add(lblTextPlaying)
        GroupBox1.Location = New Point(3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(243, 281)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Preview"
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(26, 183)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(92, 66)
        AxWindowsMediaPlayer1.TabIndex = 6
        ' 
        ' btnStop
        ' 
        btnStop.Location = New Point(122, 136)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(81, 29)
        btnStop.TabIndex = 5
        btnStop.Text = "Stop"
        btnStop.UseVisualStyleBackColor = True
        ' 
        ' btnPlay
        ' 
        btnPlay.Location = New Point(26, 136)
        btnPlay.Name = "btnPlay"
        btnPlay.Size = New Size(69, 29)
        btnPlay.TabIndex = 4
        btnPlay.Text = "Play"
        btnPlay.UseVisualStyleBackColor = True
        ' 
        ' lblDuration
        ' 
        lblDuration.AutoSize = True
        lblDuration.Location = New Point(122, 71)
        lblDuration.Name = "lblDuration"
        lblDuration.Size = New Size(48, 20)
        lblDuration.TabIndex = 3
        lblDuration.Text = "00:00 "
        ' 
        ' lblPlaying
        ' 
        lblPlaying.AutoSize = True
        lblPlaying.Location = New Point(122, 41)
        lblPlaying.Name = "lblPlaying"
        lblPlaying.Size = New Size(48, 20)
        lblPlaying.TabIndex = 2
        lblPlaying.Text = "00:00 "
        ' 
        ' lblTextDuration
        ' 
        lblTextDuration.AutoSize = True
        lblTextDuration.Location = New Point(26, 71)
        lblTextDuration.Name = "lblTextDuration"
        lblTextDuration.Size = New Size(70, 20)
        lblTextDuration.TabIndex = 1
        lblTextDuration.Text = "Duration:"
        ' 
        ' lblTextPlaying
        ' 
        lblTextPlaying.AutoSize = True
        lblTextPlaying.Location = New Point(26, 41)
        lblTextPlaying.Name = "lblTextPlaying"
        lblTextPlaying.Size = New Size(60, 20)
        lblTextPlaying.TabIndex = 0
        lblTextPlaying.Text = "Playing:"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(961, 534)
        Controls.Add(SplitContainer1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MP3TagEditor"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        SplitContainer3.Panel1.ResumeLayout(False)
        SplitContainer3.Panel1.PerformLayout()
        SplitContainer3.Panel2.ResumeLayout(False)
        CType(SplitContainer3, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer3.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tvDrive As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents LvMP3 As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreateDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPlaying As Label
    Friend WithEvents lblTextDuration As Label
    Friend WithEvents lblTextPlaying As Label
    Friend WithEvents btnStop As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblDuration As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtTrack As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblAlbum As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTrack As Label
    Friend WithEvents lblMp3Editor As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnEdit As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer

End Class
