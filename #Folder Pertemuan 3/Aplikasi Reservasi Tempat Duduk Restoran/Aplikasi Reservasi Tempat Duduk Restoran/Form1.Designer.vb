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
        Label1 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        Label4 = New Label()
        Label6 = New Label()
        CheckedListBox1 = New CheckedListBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 25)
        Label1.TabIndex = 0
        Label1.Text = "Reservasi Tempat Duduk Restoran"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 25)
        Label2.TabIndex = 1
        Label2.Text = "Variasi Kursi"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1 kursi", "2 kursi", "3 kursi", "4 kursi", "5 kursi", "6 kursi", "7 kursi", "8 kursi"})
        ComboBox1.Location = New Point(193, 75)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 2
        ComboBox1.Text = "Pilih variasi kursi"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(225, 25)
        Label3.TabIndex = 3
        Label3.Text = "Jumlah kapasitas maksimal"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(42, 53)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(453, 236)
        Panel1.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(279, 129)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(96, 31)
        TextBox1.TabIndex = 7
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Ruangan depan", "Ruangan tengah", "Ruangan atas"})
        ComboBox2.Location = New Point(193, 16)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(182, 33)
        ComboBox2.TabIndex = 6
        ComboBox2.Text = "Pilih Ruangan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 25)
        Label5.TabIndex = 5
        Label5.Text = "Ruangan"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(383, 295)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 6
        Button1.Text = "Pilih"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(254, 295)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 7
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CheckedListBox1)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(536, 63)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 252)
        Panel2.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(536, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 25)
        Label4.TabIndex = 9
        Label4.Text = "Saranan Makanan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 14)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 25)
        Label6.TabIndex = 0
        Label6.Text = "Makanan Favorit"
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Nasi Sayur", "Nasi Padang", "Nasi Remes"})
        CheckedListBox1.Location = New Point(31, 54)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(248, 172)
        CheckedListBox1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(935, 395)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Aplikasi Reservasi Kursi"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label

End Class
