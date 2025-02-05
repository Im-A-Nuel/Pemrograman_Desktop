Public Class Form1


    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click

        Me.Close()

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim celcius, fahrenheit, reamur, kelvin As Double

        celcius = Val(txtCelcius.Text)

        fahrenheit = 9 / 5 * (celcius) + 32

        reamur = 4 / 5 * (celcius)

        kelvin = 273 + celcius

        txtFahrenheit.Text = CStr(fahrenheit)
        txtReamur.Text = CStr(reamur)
        txtKelvin.Text = CStr(kelvin)


    End Sub


End Class
