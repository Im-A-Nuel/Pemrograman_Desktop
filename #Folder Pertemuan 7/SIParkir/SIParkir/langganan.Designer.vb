<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class langganan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBiaya = New System.Windows.Forms.TextBox()
        Me.lblKetikLagi = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtNoPlat = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblNoPlat = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_plat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 49)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIParkir - Langganan"
        '
        'txtBiaya
        '
        Me.txtBiaya.BackColor = System.Drawing.SystemColors.Window
        Me.txtBiaya.Location = New System.Drawing.Point(162, 150)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Size = New System.Drawing.Size(152, 22)
        Me.txtBiaya.TabIndex = 24
        Me.txtBiaya.Text = "text"
        '
        'lblKetikLagi
        '
        Me.lblKetikLagi.AutoSize = True
        Me.lblKetikLagi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblKetikLagi.Location = New System.Drawing.Point(27, 156)
        Me.lblKetikLagi.Name = "lblKetikLagi"
        Me.lblKetikLagi.Size = New System.Drawing.Size(101, 16)
        Me.lblKetikLagi.TabIndex = 23
        Me.lblKetikLagi.Text = "Tarif langganan"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(655, 181)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 32)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(365, 181)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(87, 32)
        Me.btnTambah.TabIndex = 20
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtNoPlat
        '
        Me.txtNoPlat.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoPlat.Location = New System.Drawing.Point(162, 114)
        Me.txtNoPlat.Name = "txtNoPlat"
        Me.txtNoPlat.Size = New System.Drawing.Size(152, 22)
        Me.txtNoPlat.TabIndex = 19
        Me.txtNoPlat.Text = "text"
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.SystemColors.Window
        Me.txtNama.Location = New System.Drawing.Point(162, 77)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(220, 22)
        Me.txtNama.TabIndex = 18
        Me.txtNama.Text = "text"
        '
        'lblNoPlat
        '
        Me.lblNoPlat.AutoSize = True
        Me.lblNoPlat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNoPlat.Location = New System.Drawing.Point(27, 120)
        Me.lblNoPlat.Name = "lblNoPlat"
        Me.lblNoPlat.Size = New System.Drawing.Size(73, 16)
        Me.lblNoPlat.TabIndex = 17
        Me.lblNoPlat.Text = "Nomot Plat"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNama.Location = New System.Drawing.Point(27, 80)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(113, 16)
        Me.lblNama.TabIndex = 16
        Me.lblNama.Text = "Nama Pelanggan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(27, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Berlaku hingga"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(556, 181)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(92, 32)
        Me.btnHapus.TabIndex = 27
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Kendaraan Terdaftar Langganan : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.no_plat, Me.nama, Me.biaya, Me.jenis, Me.expired})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 274)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(755, 131)
        Me.DataGridView1.TabIndex = 29
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'no_plat
        '
        Me.no_plat.HeaderText = "No Plat"
        Me.no_plat.MinimumWidth = 6
        Me.no_plat.Name = "no_plat"
        Me.no_plat.Width = 125
        '
        'nama
        '
        Me.nama.HeaderText = "Nama Pemilik"
        Me.nama.MinimumWidth = 6
        Me.nama.Name = "nama"
        Me.nama.Width = 125
        '
        'biaya
        '
        Me.biaya.HeaderText = "Biaya"
        Me.biaya.MinimumWidth = 6
        Me.biaya.Name = "biaya"
        Me.biaya.Width = 125
        '
        'jenis
        '
        Me.jenis.HeaderText = "Jenis"
        Me.jenis.MinimumWidth = 6
        Me.jenis.Name = "jenis"
        Me.jenis.Width = 125
        '
        'expired
        '
        Me.expired.HeaderText = "Expired"
        Me.expired.MinimumWidth = 6
        Me.expired.Name = "expired"
        Me.expired.Width = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Jenis"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(415, 83)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(98, 16)
        Me.lblId.TabIndex = 31
        Me.lblId.Text = "ID Pelanggan : "
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Motor ", "Mobil ", "Taxi/Umum ", "Truk ", "Sepeda "})
        Me.cmbJenis.Location = New System.Drawing.Point(442, 114)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(121, 24)
        Me.cmbJenis.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 194)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(175, 22)
        Me.DateTimePicker1.TabIndex = 33
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(458, 181)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 32)
        Me.btnEdit.TabIndex = 34
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'langganan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 481)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBiaya)
        Me.Controls.Add(Me.lblKetikLagi)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtNoPlat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblNoPlat)
        Me.Controls.Add(Me.lblNama)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "langganan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIParkir"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents lblKetikLagi As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents lblId As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnEdit As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents no_plat As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents biaya As DataGridViewTextBoxColumn
    Friend WithEvents jenis As DataGridViewTextBoxColumn
    Friend WithEvents expired As DataGridViewTextBoxColumn
End Class
