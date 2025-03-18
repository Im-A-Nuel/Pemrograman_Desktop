Imports MySql.Data.MySqlClient

Public Class profil
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtPassword.Text = txtRetype.Text Then
            Dim sql As String = "update users set password='" & txtPassword.Text & "' where username='" & pengguna & "'"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            If myCommand.ExecuteNonQuery = 1 Then
                MsgBox("Password berhasil diganti, silahkan login ulang!")
                login.txtPassword.Clear()
                login.txtUsername.Clear()
                Me.Close()
                main.Close()
                login.txtUsername.Focus()
                login.ShowDialog()
            End If
        ElseIf txtRetype.Text <> "" Then
            MsgBox("Password tidak sama!")
        End If

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub txtVerifikasiPassword_TextChanged(sender As Object, e As EventArgs) Handles txtRetype.TextChanged

    End Sub

    Private Sub lblKetikLagi_Click(sender As Object, e As EventArgs) Handles lblKetikLagi.Click

    End Sub

    Private Sub profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = pengguna
        txtPassword.Text = ppassword
    End Sub
End Class