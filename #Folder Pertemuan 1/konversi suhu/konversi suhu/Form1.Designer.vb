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
        txtCelcius = New TextBox()
        btnConvert = New Button()
        btnkeluar = New Button()
        txtFahrenheit = New TextBox()
        txtReamur = New TextBox()
        txtKelvin = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 25)
        Label1.TabIndex = 0
        Label1.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(119, 54)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(150, 31)
        txtCelcius.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(292, 52)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 2
        btnConvert.Text = "convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnkeluar
        ' 
        btnkeluar.Location = New Point(420, 54)
        btnkeluar.Name = "btnkeluar"
        btnkeluar.Size = New Size(112, 34)
        btnkeluar.TabIndex = 3
        btnkeluar.Text = "Keluar"
        btnkeluar.UseVisualStyleBackColor = True
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(40, 140)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.ReadOnly = True
        txtFahrenheit.Size = New Size(150, 31)
        txtFahrenheit.TabIndex = 4
        ' 
        ' txtReamur
        ' 
        txtReamur.Location = New Point(226, 140)
        txtReamur.Name = "txtReamur"
        txtReamur.ReadOnly = True
        txtReamur.Size = New Size(150, 31)
        txtReamur.TabIndex = 5
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Location = New Point(403, 140)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.ReadOnly = True
        txtKelvin.Size = New Size(150, 31)
        txtKelvin.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 25)
        Label2.TabIndex = 7
        Label2.Text = "Fahrenheit"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(265, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 25)
        Label3.TabIndex = 8
        Label3.Text = "Reamur"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(448, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 25)
        Label4.TabIndex = 9
        Label4.Text = "Kelvin"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(575, 187)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtKelvin)
        Controls.Add(txtReamur)
        Controls.Add(txtFahrenheit)
        Controls.Add(btnkeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtCelcius)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Kalkulator Suhu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
