<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        txtInput = New TextBox()
        btnConvert = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        txtBasis2 = New TextBox()
        txtBasis8 = New TextBox()
        txtBasis16 = New TextBox()
        btnClear = New Button()
        btnExit = New Button()
        txtBasis10 = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 25)
        Label1.TabIndex = 0
        Label1.Text = "Basis 10"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(123, 50)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(196, 31)
        txtInput.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(344, 48)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(95, 34)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 25)
        Label2.TabIndex = 3
        Label2.Text = "Basis 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(180, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 25)
        Label3.TabIndex = 4
        Label3.Text = "Basis 8"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(452, 133)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 25)
        Label5.TabIndex = 6
        Label5.Text = "Basis 16"
        ' 
        ' txtBasis2
        ' 
        txtBasis2.Location = New Point(30, 161)
        txtBasis2.Name = "txtBasis2"
        txtBasis2.ReadOnly = True
        txtBasis2.Size = New Size(99, 31)
        txtBasis2.TabIndex = 7
        ' 
        ' txtBasis8
        ' 
        txtBasis8.Location = New Point(163, 161)
        txtBasis8.Name = "txtBasis8"
        txtBasis8.ReadOnly = True
        txtBasis8.Size = New Size(99, 31)
        txtBasis8.TabIndex = 8
        ' 
        ' txtBasis16
        ' 
        txtBasis16.Location = New Point(441, 161)
        txtBasis16.Name = "txtBasis16"
        txtBasis16.ReadOnly = True
        txtBasis16.Size = New Size(99, 31)
        txtBasis16.TabIndex = 10
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(452, 49)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(88, 34)
        btnClear.TabIndex = 11
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(452, 89)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(88, 34)
        btnExit.TabIndex = 12
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtBasis10
        ' 
        txtBasis10.Location = New Point(305, 161)
        txtBasis10.Name = "txtBasis10"
        txtBasis10.ReadOnly = True
        txtBasis10.Size = New Size(99, 31)
        txtBasis10.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(322, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 25)
        Label4.TabIndex = 13
        Label4.Text = "Basis 10"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(574, 204)
        Controls.Add(txtBasis10)
        Controls.Add(Label4)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(txtBasis16)
        Controls.Add(txtBasis8)
        Controls.Add(txtBasis2)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnConvert)
        Controls.Add(txtInput)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Basis Convert"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBasis2 As TextBox
    Friend WithEvents txtBasis8 As TextBox
    Friend WithEvents txtBasis16 As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtBasis10 As TextBox
    Friend WithEvents Label4 As Label
End Class
