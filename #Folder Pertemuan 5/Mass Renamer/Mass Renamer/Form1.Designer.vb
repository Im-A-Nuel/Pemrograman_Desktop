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
        lblPath = New Label()
        txtPath = New TextBox()
        btnPath = New Button()
        txtExt = New TextBox()
        lblExt = New Label()
        lvOri = New ListView()
        chFileName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chSize = New ColumnHeader()
        chAttributes = New ColumnHeader()
        chCreated = New ColumnHeader()
        chAccessed = New ColumnHeader()
        chModified = New ColumnHeader()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cbCaseF = New ComboBox()
        lblCaseF = New Label()
        txtWithThisF = New TextBox()
        lblWithThisF = New Label()
        txtRightCropNCharF = New TextBox()
        rbRightCropNCharF = New RadioButton()
        txtInsertAfterF = New TextBox()
        rbInsertAfterF = New RadioButton()
        txtLeftCropNCharF = New TextBox()
        txtInsertBeforeF = New TextBox()
        txtReplaceThisF = New TextBox()
        txtReplaceWithF = New TextBox()
        rbLeftCropNCharF = New RadioButton()
        rbInsertBeforeF = New RadioButton()
        rbReplaceThisF = New RadioButton()
        rbReplaceWithF = New RadioButton()
        TabPage2 = New TabPage()
        cbCaseE = New ComboBox()
        lblCaseE = New Label()
        txtWithThisE = New TextBox()
        lblWithThisE = New Label()
        txtRightCropNCharE = New TextBox()
        rbRightCropNCharE = New RadioButton()
        txtInsertAfterE = New TextBox()
        rbInsertAfterE = New RadioButton()
        txtLeftCropNCharE = New TextBox()
        txtInsertBeforeE = New TextBox()
        txtReplaceThisE = New TextBox()
        txtReplaceWithE = New TextBox()
        rbLeftCropNCharE = New RadioButton()
        rbInsertBeforeE = New RadioButton()
        rbReplaceThisE = New RadioButton()
        rbReplaceWithE = New RadioButton()
        TabPage3 = New TabPage()
        gbWith = New GroupBox()
        nudIncrementBy = New NumericUpDown()
        nudStartWithNumber = New NumericUpDown()
        lblIncrementBy = New Label()
        lblStartWithNumber = New Label()
        gbPlace = New GroupBox()
        rbBeforeFileName = New RadioButton()
        rbAfterFileName = New RadioButton()
        btnPreview = New Button()
        btnRename = New Button()
        btnUndo = New Button()
        lblOri = New Label()
        lblPreview = New Label()
        lvPreview = New ListView()
        chFileName2 = New ColumnHeader()
        chExtension2 = New ColumnHeader()
        chSize2 = New ColumnHeader()
        chAttributes2 = New ColumnHeader()
        chCreated2 = New ColumnHeader()
        chAccessed2 = New ColumnHeader()
        chModified2 = New ColumnHeader()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        ImageList1 = New ImageList(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbWith.SuspendLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).BeginInit()
        gbPlace.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(23, 34)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(40, 20)
        lblPath.TabIndex = 0
        lblPath.Text = "Path:"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(87, 27)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(541, 27)
        txtPath.TabIndex = 1
        ' 
        ' btnPath
        ' 
        btnPath.Location = New Point(634, 26)
        btnPath.Name = "btnPath"
        btnPath.Size = New Size(54, 29)
        btnPath.TabIndex = 2
        btnPath.Text = "..."
        btnPath.UseVisualStyleBackColor = True
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(768, 27)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(48, 27)
        txtExt.TabIndex = 3
        txtExt.Text = "*.* "
        ' 
        ' lblExt
        ' 
        lblExt.AutoSize = True
        lblExt.Location = New Point(703, 35)
        lblExt.Name = "lblExt"
        lblExt.Size = New Size(59, 20)
        lblExt.TabIndex = 4
        lblExt.Text = "File Ext:"
        ' 
        ' lvOri
        ' 
        lvOri.Columns.AddRange(New ColumnHeader() {chFileName, chExtension, chSize, chAttributes, chCreated, chAccessed, chModified})
        lvOri.Location = New Point(23, 89)
        lvOri.Name = "lvOri"
        lvOri.Size = New Size(453, 289)
        lvOri.TabIndex = 5
        lvOri.UseCompatibleStateImageBehavior = False
        lvOri.View = View.Details
        ' 
        ' chFileName
        ' 
        chFileName.Text = "File Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chSize
        ' 
        chSize.Text = "File Size"
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = "Attributes"
        ' 
        ' chCreated
        ' 
        chCreated.Text = "Date Created"
        ' 
        ' chAccessed
        ' 
        chAccessed.Text = "Last Accessed"
        ' 
        ' chModified
        ' 
        chModified.Text = "Date Modified"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(23, 394)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(741, 204)
        TabControl1.TabIndex = 7
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(cbCaseF)
        TabPage1.Controls.Add(lblCaseF)
        TabPage1.Controls.Add(txtWithThisF)
        TabPage1.Controls.Add(lblWithThisF)
        TabPage1.Controls.Add(txtRightCropNCharF)
        TabPage1.Controls.Add(rbRightCropNCharF)
        TabPage1.Controls.Add(txtInsertAfterF)
        TabPage1.Controls.Add(rbInsertAfterF)
        TabPage1.Controls.Add(txtLeftCropNCharF)
        TabPage1.Controls.Add(txtInsertBeforeF)
        TabPage1.Controls.Add(txtReplaceThisF)
        TabPage1.Controls.Add(txtReplaceWithF)
        TabPage1.Controls.Add(rbLeftCropNCharF)
        TabPage1.Controls.Add(rbInsertBeforeF)
        TabPage1.Controls.Add(rbReplaceThisF)
        TabPage1.Controls.Add(rbReplaceWithF)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(733, 171)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Filename"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' cbCaseF
        ' 
        cbCaseF.FormattingEnabled = True
        cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE"})
        cbCaseF.Location = New Point(528, 5)
        cbCaseF.Name = "cbCaseF"
        cbCaseF.Size = New Size(151, 28)
        cbCaseF.TabIndex = 15
        cbCaseF.Text = "No Change"
        ' 
        ' lblCaseF
        ' 
        lblCaseF.AutoSize = True
        lblCaseF.Location = New Point(467, 9)
        lblCaseF.Name = "lblCaseF"
        lblCaseF.Size = New Size(43, 20)
        lblCaseF.TabIndex = 14
        lblCaseF.Text = "Case:"
        ' 
        ' txtWithThisF
        ' 
        txtWithThisF.Location = New Point(528, 38)
        txtWithThisF.Name = "txtWithThisF"
        txtWithThisF.Size = New Size(184, 27)
        txtWithThisF.TabIndex = 13
        ' 
        ' lblWithThisF
        ' 
        lblWithThisF.AutoSize = True
        lblWithThisF.Location = New Point(458, 45)
        lblWithThisF.Name = "lblWithThisF"
        lblWithThisF.Size = New Size(64, 20)
        lblWithThisF.TabIndex = 12
        lblWithThisF.Text = "with this"
        ' 
        ' txtRightCropNCharF
        ' 
        txtRightCropNCharF.Location = New Point(560, 104)
        txtRightCropNCharF.Name = "txtRightCropNCharF"
        txtRightCropNCharF.Size = New Size(167, 27)
        txtRightCropNCharF.TabIndex = 11
        ' 
        ' rbRightCropNCharF
        ' 
        rbRightCropNCharF.AutoSize = True
        rbRightCropNCharF.Location = New Point(412, 107)
        rbRightCropNCharF.Name = "rbRightCropNCharF"
        rbRightCropNCharF.Size = New Size(146, 24)
        rbRightCropNCharF.TabIndex = 10
        rbRightCropNCharF.TabStop = True
        rbRightCropNCharF.Text = "Right crop n char:"
        rbRightCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' txtInsertAfterF
        ' 
        txtInsertAfterF.Location = New Point(535, 71)
        txtInsertAfterF.Name = "txtInsertAfterF"
        txtInsertAfterF.Size = New Size(177, 27)
        txtInsertAfterF.TabIndex = 9
        ' 
        ' rbInsertAfterF
        ' 
        rbInsertAfterF.AutoSize = True
        rbInsertAfterF.Location = New Point(412, 74)
        rbInsertAfterF.Name = "rbInsertAfterF"
        rbInsertAfterF.Size = New Size(104, 24)
        rbInsertAfterF.TabIndex = 8
        rbInsertAfterF.TabStop = True
        rbInsertAfterF.Text = "Insert after:"
        rbInsertAfterF.UseVisualStyleBackColor = True
        ' 
        ' txtLeftCropNCharF
        ' 
        txtLeftCropNCharF.Location = New Point(157, 106)
        txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        txtLeftCropNCharF.Size = New Size(233, 27)
        txtLeftCropNCharF.TabIndex = 7
        ' 
        ' txtInsertBeforeF
        ' 
        txtInsertBeforeF.Location = New Point(138, 74)
        txtInsertBeforeF.Name = "txtInsertBeforeF"
        txtInsertBeforeF.Size = New Size(252, 27)
        txtInsertBeforeF.TabIndex = 6
        ' 
        ' txtReplaceThisF
        ' 
        txtReplaceThisF.Location = New Point(136, 37)
        txtReplaceThisF.Name = "txtReplaceThisF"
        txtReplaceThisF.Size = New Size(286, 27)
        txtReplaceThisF.TabIndex = 5
        ' 
        ' txtReplaceWithF
        ' 
        txtReplaceWithF.Location = New Point(136, 4)
        txtReplaceWithF.Name = "txtReplaceWithF"
        txtReplaceWithF.ReadOnly = True
        txtReplaceWithF.Size = New Size(305, 27)
        txtReplaceWithF.TabIndex = 4
        ' 
        ' rbLeftCropNCharF
        ' 
        rbLeftCropNCharF.AutoSize = True
        rbLeftCropNCharF.Location = New Point(15, 107)
        rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        rbLeftCropNCharF.Size = New Size(136, 24)
        rbLeftCropNCharF.TabIndex = 3
        rbLeftCropNCharF.TabStop = True
        rbLeftCropNCharF.Text = "Left crop n char:"
        rbLeftCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeF
        ' 
        rbInsertBeforeF.AutoSize = True
        rbInsertBeforeF.Location = New Point(15, 77)
        rbInsertBeforeF.Name = "rbInsertBeforeF"
        rbInsertBeforeF.Size = New Size(117, 24)
        rbInsertBeforeF.TabIndex = 2
        rbInsertBeforeF.TabStop = True
        rbInsertBeforeF.Text = "Insert before:"
        rbInsertBeforeF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisF
        ' 
        rbReplaceThisF.AutoSize = True
        rbReplaceThisF.Location = New Point(15, 36)
        rbReplaceThisF.Name = "rbReplaceThisF"
        rbReplaceThisF.Size = New Size(113, 24)
        rbReplaceThisF.TabIndex = 1
        rbReplaceThisF.TabStop = True
        rbReplaceThisF.Text = "Replace this:"
        rbReplaceThisF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithF
        ' 
        rbReplaceWithF.AutoSize = True
        rbReplaceWithF.Location = New Point(15, 6)
        rbReplaceWithF.Name = "rbReplaceWithF"
        rbReplaceWithF.Size = New Size(118, 24)
        rbReplaceWithF.TabIndex = 0
        rbReplaceWithF.TabStop = True
        rbReplaceWithF.Text = "Replace with:"
        rbReplaceWithF.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(cbCaseE)
        TabPage2.Controls.Add(lblCaseE)
        TabPage2.Controls.Add(txtWithThisE)
        TabPage2.Controls.Add(lblWithThisE)
        TabPage2.Controls.Add(txtRightCropNCharE)
        TabPage2.Controls.Add(rbRightCropNCharE)
        TabPage2.Controls.Add(txtInsertAfterE)
        TabPage2.Controls.Add(rbInsertAfterE)
        TabPage2.Controls.Add(txtLeftCropNCharE)
        TabPage2.Controls.Add(txtInsertBeforeE)
        TabPage2.Controls.Add(txtReplaceThisE)
        TabPage2.Controls.Add(txtReplaceWithE)
        TabPage2.Controls.Add(rbLeftCropNCharE)
        TabPage2.Controls.Add(rbInsertBeforeE)
        TabPage2.Controls.Add(rbReplaceThisE)
        TabPage2.Controls.Add(rbReplaceWithE)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(733, 171)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Extension"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' cbCaseE
        ' 
        cbCaseE.FormattingEnabled = True
        cbCaseE.Items.AddRange(New Object() {"lowercase ", "UPPERCASE ", "No Change"})
        cbCaseE.Location = New Point(523, 8)
        cbCaseE.Name = "cbCaseE"
        cbCaseE.Size = New Size(151, 28)
        cbCaseE.TabIndex = 31
        cbCaseE.Text = "No Change"
        ' 
        ' lblCaseE
        ' 
        lblCaseE.AutoSize = True
        lblCaseE.Location = New Point(462, 12)
        lblCaseE.Name = "lblCaseE"
        lblCaseE.Size = New Size(43, 20)
        lblCaseE.TabIndex = 30
        lblCaseE.Text = "Case:"
        ' 
        ' txtWithThisE
        ' 
        txtWithThisE.Location = New Point(523, 41)
        txtWithThisE.Name = "txtWithThisE"
        txtWithThisE.ReadOnly = True
        txtWithThisE.Size = New Size(184, 27)
        txtWithThisE.TabIndex = 29
        ' 
        ' lblWithThisE
        ' 
        lblWithThisE.AutoSize = True
        lblWithThisE.Location = New Point(453, 48)
        lblWithThisE.Name = "lblWithThisE"
        lblWithThisE.Size = New Size(64, 20)
        lblWithThisE.TabIndex = 28
        lblWithThisE.Text = "with this"
        ' 
        ' txtRightCropNCharE
        ' 
        txtRightCropNCharE.Location = New Point(555, 107)
        txtRightCropNCharE.Name = "txtRightCropNCharE"
        txtRightCropNCharE.ReadOnly = True
        txtRightCropNCharE.Size = New Size(167, 27)
        txtRightCropNCharE.TabIndex = 27
        ' 
        ' rbRightCropNCharE
        ' 
        rbRightCropNCharE.AutoSize = True
        rbRightCropNCharE.Location = New Point(407, 110)
        rbRightCropNCharE.Name = "rbRightCropNCharE"
        rbRightCropNCharE.Size = New Size(146, 24)
        rbRightCropNCharE.TabIndex = 26
        rbRightCropNCharE.TabStop = True
        rbRightCropNCharE.Text = "Right crop n char:"
        rbRightCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' txtInsertAfterE
        ' 
        txtInsertAfterE.Location = New Point(530, 74)
        txtInsertAfterE.Name = "txtInsertAfterE"
        txtInsertAfterE.ReadOnly = True
        txtInsertAfterE.Size = New Size(177, 27)
        txtInsertAfterE.TabIndex = 25
        ' 
        ' rbInsertAfterE
        ' 
        rbInsertAfterE.AutoSize = True
        rbInsertAfterE.Location = New Point(407, 77)
        rbInsertAfterE.Name = "rbInsertAfterE"
        rbInsertAfterE.Size = New Size(104, 24)
        rbInsertAfterE.TabIndex = 24
        rbInsertAfterE.TabStop = True
        rbInsertAfterE.Text = "Insert after:"
        rbInsertAfterE.UseVisualStyleBackColor = True
        ' 
        ' txtLeftCropNCharE
        ' 
        txtLeftCropNCharE.Location = New Point(152, 109)
        txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        txtLeftCropNCharE.ReadOnly = True
        txtLeftCropNCharE.Size = New Size(233, 27)
        txtLeftCropNCharE.TabIndex = 23
        ' 
        ' txtInsertBeforeE
        ' 
        txtInsertBeforeE.Location = New Point(133, 77)
        txtInsertBeforeE.Name = "txtInsertBeforeE"
        txtInsertBeforeE.ReadOnly = True
        txtInsertBeforeE.Size = New Size(252, 27)
        txtInsertBeforeE.TabIndex = 22
        ' 
        ' txtReplaceThisE
        ' 
        txtReplaceThisE.Location = New Point(131, 40)
        txtReplaceThisE.Name = "txtReplaceThisE"
        txtReplaceThisE.ReadOnly = True
        txtReplaceThisE.Size = New Size(286, 27)
        txtReplaceThisE.TabIndex = 21
        ' 
        ' txtReplaceWithE
        ' 
        txtReplaceWithE.Location = New Point(131, 7)
        txtReplaceWithE.Name = "txtReplaceWithE"
        txtReplaceWithE.ReadOnly = True
        txtReplaceWithE.Size = New Size(305, 27)
        txtReplaceWithE.TabIndex = 20
        ' 
        ' rbLeftCropNCharE
        ' 
        rbLeftCropNCharE.AutoSize = True
        rbLeftCropNCharE.Location = New Point(10, 110)
        rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        rbLeftCropNCharE.Size = New Size(136, 24)
        rbLeftCropNCharE.TabIndex = 19
        rbLeftCropNCharE.TabStop = True
        rbLeftCropNCharE.Text = "Left crop n char:"
        rbLeftCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeE
        ' 
        rbInsertBeforeE.AutoSize = True
        rbInsertBeforeE.Location = New Point(10, 80)
        rbInsertBeforeE.Name = "rbInsertBeforeE"
        rbInsertBeforeE.Size = New Size(117, 24)
        rbInsertBeforeE.TabIndex = 18
        rbInsertBeforeE.TabStop = True
        rbInsertBeforeE.Text = "Insert before:"
        rbInsertBeforeE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisE
        ' 
        rbReplaceThisE.AutoSize = True
        rbReplaceThisE.Location = New Point(10, 39)
        rbReplaceThisE.Name = "rbReplaceThisE"
        rbReplaceThisE.Size = New Size(113, 24)
        rbReplaceThisE.TabIndex = 17
        rbReplaceThisE.TabStop = True
        rbReplaceThisE.Text = "Replace this:"
        rbReplaceThisE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithE
        ' 
        rbReplaceWithE.AutoSize = True
        rbReplaceWithE.Location = New Point(10, 9)
        rbReplaceWithE.Name = "rbReplaceWithE"
        rbReplaceWithE.Size = New Size(118, 24)
        rbReplaceWithE.TabIndex = 16
        rbReplaceWithE.TabStop = True
        rbReplaceWithE.Text = "Replace with:"
        rbReplaceWithE.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(gbWith)
        TabPage3.Controls.Add(gbPlace)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(733, 171)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Autonumber"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' gbWith
        ' 
        gbWith.Controls.Add(nudIncrementBy)
        gbWith.Controls.Add(nudStartWithNumber)
        gbWith.Controls.Add(lblIncrementBy)
        gbWith.Controls.Add(lblStartWithNumber)
        gbWith.Location = New Point(334, 16)
        gbWith.Name = "gbWith"
        gbWith.Size = New Size(327, 125)
        gbWith.TabIndex = 1
        gbWith.TabStop = False
        gbWith.Text = "With:"
        ' 
        ' nudIncrementBy
        ' 
        nudIncrementBy.Location = New Point(160, 68)
        nudIncrementBy.Name = "nudIncrementBy"
        nudIncrementBy.Size = New Size(150, 27)
        nudIncrementBy.TabIndex = 3
        ' 
        ' nudStartWithNumber
        ' 
        nudStartWithNumber.Location = New Point(160, 33)
        nudStartWithNumber.Name = "nudStartWithNumber"
        nudStartWithNumber.Size = New Size(150, 27)
        nudStartWithNumber.TabIndex = 2
        ' 
        ' lblIncrementBy
        ' 
        lblIncrementBy.AutoSize = True
        lblIncrementBy.Location = New Point(20, 68)
        lblIncrementBy.Name = "lblIncrementBy"
        lblIncrementBy.Size = New Size(98, 20)
        lblIncrementBy.TabIndex = 1
        lblIncrementBy.Text = "Increment by:"
        ' 
        ' lblStartWithNumber
        ' 
        lblStartWithNumber.AutoSize = True
        lblStartWithNumber.Location = New Point(20, 35)
        lblStartWithNumber.Name = "lblStartWithNumber"
        lblStartWithNumber.Size = New Size(134, 20)
        lblStartWithNumber.TabIndex = 0
        lblStartWithNumber.Text = "Start with number: "
        ' 
        ' gbPlace
        ' 
        gbPlace.Controls.Add(rbBeforeFileName)
        gbPlace.Controls.Add(rbAfterFileName)
        gbPlace.Location = New Point(23, 16)
        gbPlace.Name = "gbPlace"
        gbPlace.Size = New Size(246, 125)
        gbPlace.TabIndex = 0
        gbPlace.TabStop = False
        gbPlace.Text = "Place:"
        ' 
        ' rbBeforeFileName
        ' 
        rbBeforeFileName.AutoSize = True
        rbBeforeFileName.Location = New Point(28, 64)
        rbBeforeFileName.Name = "rbBeforeFileName"
        rbBeforeFileName.Size = New Size(140, 24)
        rbBeforeFileName.TabIndex = 1
        rbBeforeFileName.TabStop = True
        rbBeforeFileName.Text = "Before filename "
        rbBeforeFileName.UseVisualStyleBackColor = True
        ' 
        ' rbAfterFileName
        ' 
        rbAfterFileName.AutoSize = True
        rbAfterFileName.Location = New Point(28, 33)
        rbAfterFileName.Name = "rbAfterFileName"
        rbAfterFileName.Size = New Size(129, 24)
        rbAfterFileName.TabIndex = 0
        rbAfterFileName.TabStop = True
        rbAfterFileName.Text = "After filename "
        rbAfterFileName.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Location = New Point(821, 423)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(94, 29)
        btnPreview.TabIndex = 8
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnRename
        ' 
        btnRename.Location = New Point(821, 461)
        btnRename.Name = "btnRename"
        btnRename.Size = New Size(94, 29)
        btnRename.TabIndex = 9
        btnRename.Text = "Rename"
        btnRename.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(821, 498)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(94, 29)
        btnUndo.TabIndex = 10
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' lblOri
        ' 
        lblOri.AutoSize = True
        lblOri.Location = New Point(24, 65)
        lblOri.Name = "lblOri"
        lblOri.Size = New Size(92, 20)
        lblOri.TabIndex = 11
        lblOri.Text = "Original File:"
        ' 
        ' lblPreview
        ' 
        lblPreview.AutoSize = True
        lblPreview.Location = New Point(502, 65)
        lblPreview.Name = "lblPreview"
        lblPreview.Size = New Size(90, 20)
        lblPreview.TabIndex = 12
        lblPreview.Text = "Preview File:"
        ' 
        ' lvPreview
        ' 
        lvPreview.Columns.AddRange(New ColumnHeader() {chFileName2, chExtension2, chSize2, chAttributes2, chCreated2, chAccessed2, chModified2})
        lvPreview.Location = New Point(502, 89)
        lvPreview.Name = "lvPreview"
        lvPreview.Size = New Size(462, 289)
        lvPreview.TabIndex = 6
        lvPreview.UseCompatibleStateImageBehavior = False
        lvPreview.View = View.Details
        ' 
        ' chFileName2
        ' 
        chFileName2.Text = "File Name"
        ' 
        ' chExtension2
        ' 
        chExtension2.Text = "Extension"
        ' 
        ' chSize2
        ' 
        chSize2.Text = "File Size"
        ' 
        ' chAttributes2
        ' 
        chAttributes2.Text = "Attributes"
        ' 
        ' chCreated2
        ' 
        chCreated2.Text = "Date Created"
        ' 
        ' chAccessed2
        ' 
        chAccessed2.Text = "Accessed Last"
        ' 
        ' chModified2
        ' 
        chModified2.Text = "Modified"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(976, 600)
        Controls.Add(lblPreview)
        Controls.Add(lblOri)
        Controls.Add(btnUndo)
        Controls.Add(btnRename)
        Controls.Add(btnPreview)
        Controls.Add(TabControl1)
        Controls.Add(lvPreview)
        Controls.Add(lvOri)
        Controls.Add(lblExt)
        Controls.Add(txtExt)
        Controls.Add(btnPath)
        Controls.Add(txtPath)
        Controls.Add(lblPath)
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mass Renamer"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbWith.ResumeLayout(False)
        gbWith.PerformLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).EndInit()
        gbPlace.ResumeLayout(False)
        gbPlace.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblExt As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents lblCaseF As Label
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chSize As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvPreview As ListView
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chSize2 As ColumnHeader
    Friend WithEvents chAttributes2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents lblCaseE As Label
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents ImageList1 As ImageList

End Class
