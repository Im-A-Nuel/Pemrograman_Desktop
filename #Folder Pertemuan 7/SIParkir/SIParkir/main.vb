Imports MySql.Data.MySqlClient

Public Class main
    Private Sub txtNamaPelanggan_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AturProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProfilToolStripMenuItem.Click
        profil.Show()

    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        langganan.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        login.txtUsername.Clear()
        login.txtPassword.Clear()
        login.txtUsername.Focus()
        login.ShowDialog()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Dim sql As String = "select sum(harga) from tblparkir where DATE(waktu_masuk) = CURDATE() and DATE(waktu_keluar) = CURDATE()"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        Dim hasil As Object = myCommand.ExecuteScalar
        Dim total As String = ""
        If hasil.Equals(DBNull.Value) Then
            total = "0"
        Else
            total = hasil.ToString
        End If
        MsgBox("Total Pendapatan hari ini: Rp. " & total)
        myConn.Close()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTgl.Text = "Tanggal : " & Now.ToString("dd-MM-yyyy")
        Timer1.Start()
    End Sub


    Private Sub lblPlat_Click(sender As Object, e As EventArgs) Handles lblPlat.Click

    End Sub

    Sub RefreshGrid()
        Dim i
        i = 0
        DataGridView1.Rows.Clear()
        Dim sql As String = "select * from tblparkir where DATE(`waktu_masuk`) = CURDATE()"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = myDataReader("no_plat")
                DataGridView1.Item(1, i).Value = myDataReader("waktu_masuk")
                DataGridView1.Item(2, i).Value = myDataReader("waktu_keluar")
                DataGridView1.Item(3, i).Value = myDataReader("harga")
                DataGridView1.Item(4, i).Value = myDataReader("jenis")
                DataGridView1.Item(5, i).Value = myDataReader("id")
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Sub HitungJumlah()
        Dim motor As Integer = 0
        Dim mobil As Integer = 0
        Dim taksi As Integer = 0
        Dim sepeda As Integer = 0
        Dim bus As Integer = 0

        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If

        Dim sql = "SELECT jenis, COUNT(*) AS jumlah FROM tblparkir WHERE waktu_keluar IS NULL AND DATE(waktu_masuk) = CURDATE() GROUP BY jenis"
        Using cmd As New MySqlCommand(sql, myConn)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    Dim jenis As String = reader("jenis").ToString()
                    Dim jumlah As Integer = CInt(reader("jumlah"))

                    Select Case jenis.ToLower()
                        Case "motor"
                            motor = jumlah
                        Case "mobil"
                            mobil = jumlah
                        Case "taksi/umum"
                            taksi = jumlah
                        Case "sepeda"
                            sepeda = jumlah
                        Case "bus/truk"
                            bus = jumlah
                    End Select
                End While
            End Using
        End Using

        lblJmlKendaraan.Text = $"{motor} Motor, {mobil} Mobil, {taksi} Taksi/Umum, {sepeda} Sepeda, {bus} Bus/Truk"
    End Sub


    Private Sub main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim sql As String
        Dim harga As Integer = 0
        Dim nomor As String = String.Empty

        If e.KeyCode = Keys.F1 Then
            jns = "Motor"
        ElseIf e.KeyCode = Keys.F2 Then
            jns = "Mobil"
        ElseIf e.KeyCode = Keys.F3 Then
            jns = "Taksi/Umum"
        ElseIf e.KeyCode = Keys.F4 Then
            jns = "Sepeda"
        ElseIf e.KeyCode = Keys.F5 Then
            jns = "Bus/Truk"
        End If
        lblInfoJenis.Text = jns

        If e.KeyCode = Keys.Enter Then
            If txtPlat.Text.Trim() = "" Then
                MessageBox.Show("Plat nomor tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If myConn.State = ConnectionState.Closed Then myConn.Open()

            sql = "SELECT * FROM tblparkir WHERE no_plat = @plat AND waktu_keluar IS NULL AND DATE(waktu_masuk) = CURDATE()"
            Using cmd As New MySqlCommand(sql, myConn)
                cmd.Parameters.AddWithValue("@plat", txtPlat.Text.Trim().ToUpper())
                Using reader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        ' Kendaraan keluar
                        reader.Read()
                        nomor = reader("id").ToString()
                        jns = reader("jenis").ToString()

                        If Not reader.IsClosed Then reader.Close()

                        ' Hitung harga
                        If jns = "Motor" Then
                            harga = 2000
                        ElseIf jns = "Mobil" OrElse jns = "Taksi/Umum" Then
                            harga = 3000
                        ElseIf jns = "Sepeda" Then
                            harga = 1000
                        ElseIf jns = "Bus/Truk" Then
                            harga = 4000
                        End If

                        sql = "UPDATE tblparkir SET waktu_keluar = CURRENT_TIMESTAMP(), harga = IF(CEIL((UNIX_TIMESTAMP(waktu_keluar) - UNIX_TIMESTAMP(waktu_masuk))/3600) > 1, CEIL((UNIX_TIMESTAMP(waktu_keluar) - UNIX_TIMESTAMP(waktu_masuk))/3600) * @harga, @harga) WHERE id = @id"
                        Using cmdUpdate As New MySqlCommand(sql, myConn)
                            cmdUpdate.Parameters.AddWithValue("@harga", harga)
                            cmdUpdate.Parameters.AddWithValue("@id", nomor)
                            cmdUpdate.ExecuteNonQuery()
                        End Using

                        ' Tampilkan harga keluar
                        lblHarga.Text = "Rp. " & harga.ToString("#,##0")

                        MessageBox.Show("Kendaraan berhasil keluar. Plat: " & txtPlat.Text.ToUpper(), "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ' Kendaraan masuk
                        reader.Close()

                        If jns = "" Then
                            MessageBox.Show("Pilih jenis kendaraan dulu (tekan F1 - F5).", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If

                        sql = "INSERT INTO tblparkir (no_plat, jenis, user) VALUES (@plat, @jenis, @user)"
                        Using cmdInsert As New MySqlCommand(sql, myConn)
                            cmdInsert.Parameters.AddWithValue("@plat", txtPlat.Text.Trim().ToUpper())
                            cmdInsert.Parameters.AddWithValue("@jenis", lblInfoJenis.Text)
                            cmdInsert.Parameters.AddWithValue("@user", pengguna)
                            cmdInsert.ExecuteNonQuery()
                        End Using

                        lblHarga.Text = "Rp. 0"

                        MessageBox.Show("Kendaraan berhasil masuk. Plat: " & txtPlat.Text.ToUpper(), "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

            ' Refresh data
            RefreshGrid()
            HitungJumlah()

            ' Reset input
            txtPlat.Clear()
            txtPlat.Focus()

            If myConn.State = ConnectionState.Open Then myConn.Close()
        End If
    End Sub


    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Dim sql As String = "delete from tblparkir where id=" & DataGridView1.CurrentRow.Cells(5).Value.ToString

            MsgBox(sql)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql

            End If
            Dim hasil As Integer = myCommand.ExecuteNonQuery
            If hasil = 1 Then
                MsgBox("Delete success!")
                RefreshGrid()
                HitungJumlah()
            End If
        Else
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        lblPlat.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblJam.Text = Now.ToString("HH:mm:ss")
    End Sub

End Class