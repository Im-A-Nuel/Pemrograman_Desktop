Public Class Form2
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBasis2.Text = String.Empty
        txtBasis8.Text = String.Empty
        txtBasis16.Text = String.Empty

        txtInput.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim basis10 As Integer = Integer.Parse(txtInput.Text)

        txtBasis2.Text = Convert.ToString(basis10, 2)
        txtBasis8.Text = Convert.ToString(basis10, 8)
        txtBasis10.Text = Convert.ToString(basis10, 10)
        txtBasis16.Text = Convert.ToString(basis10, 16)


    End Sub


End Class