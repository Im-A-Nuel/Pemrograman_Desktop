﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShapeIsian = New System.Windows.Forms.Panel()
        Me.ShapeTepi = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioElipsIsi = New System.Windows.Forms.RadioButton()
        Me.RadioKotakIsi = New System.Windows.Forms.RadioButton()
        Me.RadioElips = New System.Windows.Forms.RadioButton()
        Me.RadioKotak = New System.Windows.Forms.RadioButton()
        Me.RadioGaris = New System.Windows.Forms.RadioButton()
        Me.RadioBebas = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Warna6 = New System.Windows.Forms.Panel()
        Me.Warna5 = New System.Windows.Forms.Panel()
        Me.Warna4 = New System.Windows.Forms.Panel()
        Me.Warna3 = New System.Windows.Forms.Panel()
        Me.Warna2 = New System.Windows.Forms.Panel()
        Me.Warna1 = New System.Windows.Forms.Panel()
        Me.btnGbrUlang = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(151, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(540, 376)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShapeIsian)
        Me.GroupBox1.Controls.Add(Me.ShapeTepi)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadioElipsIsi)
        Me.GroupBox1.Controls.Add(Me.RadioKotakIsi)
        Me.GroupBox1.Controls.Add(Me.RadioElips)
        Me.GroupBox1.Controls.Add(Me.RadioKotak)
        Me.GroupBox1.Controls.Add(Me.RadioGaris)
        Me.GroupBox1.Controls.Add(Me.RadioBebas)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 453)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'ShapeIsian
        '
        Me.ShapeIsian.BackColor = System.Drawing.Color.White
        Me.ShapeIsian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShapeIsian.Location = New System.Drawing.Point(73, 327)
        Me.ShapeIsian.Name = "ShapeIsian"
        Me.ShapeIsian.Size = New System.Drawing.Size(49, 46)
        Me.ShapeIsian.TabIndex = 9
        '
        'ShapeTepi
        '
        Me.ShapeTepi.BackColor = System.Drawing.Color.Black
        Me.ShapeTepi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShapeTepi.Location = New System.Drawing.Point(20, 327)
        Me.ShapeTepi.Name = "ShapeTepi"
        Me.ShapeTepi.Size = New System.Drawing.Size(47, 46)
        Me.ShapeTepi.TabIndex = 8
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(20, 269)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(75, 22)
        Me.NumericUpDown1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ukuran Garis Tepi "
        '
        'RadioElipsIsi
        '
        Me.RadioElipsIsi.AutoSize = True
        Me.RadioElipsIsi.Location = New System.Drawing.Point(17, 210)
        Me.RadioElipsIsi.Name = "RadioElipsIsi"
        Me.RadioElipsIsi.Size = New System.Drawing.Size(74, 20)
        Me.RadioElipsIsi.TabIndex = 5
        Me.RadioElipsIsi.TabStop = True
        Me.RadioElipsIsi.Text = "Elips Isi"
        Me.RadioElipsIsi.UseVisualStyleBackColor = True
        '
        'RadioKotakIsi
        '
        Me.RadioKotakIsi.AutoSize = True
        Me.RadioKotakIsi.Location = New System.Drawing.Point(17, 175)
        Me.RadioKotakIsi.Name = "RadioKotakIsi"
        Me.RadioKotakIsi.Size = New System.Drawing.Size(78, 20)
        Me.RadioKotakIsi.TabIndex = 4
        Me.RadioKotakIsi.TabStop = True
        Me.RadioKotakIsi.Text = "Kotak Isi"
        Me.RadioKotakIsi.UseVisualStyleBackColor = True
        '
        'RadioElips
        '
        Me.RadioElips.AutoSize = True
        Me.RadioElips.Location = New System.Drawing.Point(17, 138)
        Me.RadioElips.Name = "RadioElips"
        Me.RadioElips.Size = New System.Drawing.Size(58, 20)
        Me.RadioElips.TabIndex = 3
        Me.RadioElips.TabStop = True
        Me.RadioElips.Text = "Elips"
        Me.RadioElips.UseVisualStyleBackColor = True
        '
        'RadioKotak
        '
        Me.RadioKotak.AutoSize = True
        Me.RadioKotak.Location = New System.Drawing.Point(17, 101)
        Me.RadioKotak.Name = "RadioKotak"
        Me.RadioKotak.Size = New System.Drawing.Size(62, 20)
        Me.RadioKotak.TabIndex = 2
        Me.RadioKotak.TabStop = True
        Me.RadioKotak.Text = "Kotak"
        Me.RadioKotak.UseVisualStyleBackColor = True
        '
        'RadioGaris
        '
        Me.RadioGaris.AutoSize = True
        Me.RadioGaris.Location = New System.Drawing.Point(17, 64)
        Me.RadioGaris.Name = "RadioGaris"
        Me.RadioGaris.Size = New System.Drawing.Size(60, 20)
        Me.RadioGaris.TabIndex = 1
        Me.RadioGaris.TabStop = True
        Me.RadioGaris.Text = "Garis"
        Me.RadioGaris.UseVisualStyleBackColor = True
        '
        'RadioBebas
        '
        Me.RadioBebas.AutoSize = True
        Me.RadioBebas.Location = New System.Drawing.Point(17, 29)
        Me.RadioBebas.Name = "RadioBebas"
        Me.RadioBebas.Size = New System.Drawing.Size(68, 20)
        Me.RadioBebas.TabIndex = 0
        Me.RadioBebas.TabStop = True
        Me.RadioBebas.Text = "Bebas"
        Me.RadioBebas.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(942, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaToolStripMenuItem, Me.SimpanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BukaToolStripMenuItem
        '
        Me.BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        Me.BukaToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.BukaToolStripMenuItem.Text = "Buka"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Warna6)
        Me.GroupBox2.Controls.Add(Me.Warna5)
        Me.GroupBox2.Controls.Add(Me.Warna4)
        Me.GroupBox2.Controls.Add(Me.Warna3)
        Me.GroupBox2.Controls.Add(Me.Warna2)
        Me.GroupBox2.Controls.Add(Me.Warna1)
        Me.GroupBox2.Controls.Add(Me.btnGbrUlang)
        Me.GroupBox2.Controls.Add(Me.btnBersihkan)
        Me.GroupBox2.Controls.Add(Me.btnUndo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(145, 424)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(797, 57)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warna"
        '
        'Warna6
        '
        Me.Warna6.BackColor = System.Drawing.Color.Black
        Me.Warna6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna6.Location = New System.Drawing.Point(192, 21)
        Me.Warna6.Name = "Warna6"
        Me.Warna6.Size = New System.Drawing.Size(29, 26)
        Me.Warna6.TabIndex = 14
        '
        'Warna5
        '
        Me.Warna5.BackColor = System.Drawing.Color.White
        Me.Warna5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna5.Location = New System.Drawing.Point(157, 22)
        Me.Warna5.Name = "Warna5"
        Me.Warna5.Size = New System.Drawing.Size(29, 26)
        Me.Warna5.TabIndex = 13
        '
        'Warna4
        '
        Me.Warna4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Warna4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna4.Location = New System.Drawing.Point(122, 21)
        Me.Warna4.Name = "Warna4"
        Me.Warna4.Size = New System.Drawing.Size(29, 26)
        Me.Warna4.TabIndex = 12
        '
        'Warna3
        '
        Me.Warna3.BackColor = System.Drawing.Color.Green
        Me.Warna3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna3.Location = New System.Drawing.Point(87, 21)
        Me.Warna3.Name = "Warna3"
        Me.Warna3.Size = New System.Drawing.Size(29, 26)
        Me.Warna3.TabIndex = 11
        '
        'Warna2
        '
        Me.Warna2.BackColor = System.Drawing.Color.Yellow
        Me.Warna2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna2.Location = New System.Drawing.Point(52, 21)
        Me.Warna2.Name = "Warna2"
        Me.Warna2.Size = New System.Drawing.Size(29, 26)
        Me.Warna2.TabIndex = 10
        '
        'Warna1
        '
        Me.Warna1.BackColor = System.Drawing.Color.Red
        Me.Warna1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna1.Location = New System.Drawing.Point(17, 21)
        Me.Warna1.Name = "Warna1"
        Me.Warna1.Size = New System.Drawing.Size(29, 26)
        Me.Warna1.TabIndex = 9
        '
        'btnGbrUlang
        '
        Me.btnGbrUlang.Location = New System.Drawing.Point(577, 21)
        Me.btnGbrUlang.Name = "btnGbrUlang"
        Me.btnGbrUlang.Size = New System.Drawing.Size(119, 23)
        Me.btnGbrUlang.TabIndex = 2
        Me.btnGbrUlang.Text = "Gambar Ulang!"
        Me.btnGbrUlang.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(394, 22)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(149, 23)
        Me.btnBersihkan.TabIndex = 1
        Me.btnBersihkan.Text = "Bersihkan Canvas"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(313, 21)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 23)
        Me.btnUndo.TabIndex = 0
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(697, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 396)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Objek"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 18)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(239, 375)
        Me.TextBox1.TabIndex = 0
        '
        'frmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 481)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmUtama"
        Me.Text = "Corat-Coret Vektor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioKotakIsi As RadioButton
    Friend WithEvents RadioElips As RadioButton
    Friend WithEvents RadioKotak As RadioButton
    Friend WithEvents RadioGaris As RadioButton
    Friend WithEvents RadioBebas As RadioButton
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioElipsIsi As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnGbrUlang As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ShapeIsian As Panel
    Friend WithEvents ShapeTepi As Panel
    Friend WithEvents Warna1 As Panel
    Friend WithEvents Warna6 As Panel
    Friend WithEvents Warna5 As Panel
    Friend WithEvents Warna4 As Panel
    Friend WithEvents Warna3 As Panel
    Friend WithEvents Warna2 As Panel
End Class
