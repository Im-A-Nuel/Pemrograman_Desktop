﻿Imports MySql.Data.MySqlClient

Public Class langganan

    Private Sub RefreshGrid()
        Dim i
        i = 0
        DataGridView1.Rows.Clear()
        Dim sql As String = "select * from tbllangganan"

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
                DataGridView1.Item(0, i).Value = myDataReader("id")
                DataGridView1.Item(1, i).Value = myDataReader("no_plat")
                DataGridView1.Item(2, i).Value = myDataReader("nama")
                DataGridView1.Item(3, i).Value = myDataReader("biaya")
                DataGridView1.Item(4, i).Value = myDataReader("jenis")
                If Not Convert.IsDBNull(myDataReader("expired")) Then
                    DataGridView1.Item(5, i).Value = Convert.ToDateTime(myDataReader("expired")).ToString("yyyy-MM-dd")
                Else
                    DataGridView1.Item(5, i).Value = "-"
                End If


                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub langganan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim idx As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim sql As String = "select * from tbllangganan where id=" & idx
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
                lblId.Text = myDataReader("id")
                txtNoPlat.Text = myDataReader("no_plat")
                txtNama.Text = myDataReader("nama")
                txtBiaya.Text = myDataReader("biaya")
                cmbJenis.Text = myDataReader("jenis")
                If Not Convert.IsDBNull(myDataReader("expired")) Then
                    DateTimePicker1.Value = Convert.ToDateTime(myDataReader("expired"))
                Else
                    DateTimePicker1.Value = DateTime.Now
                End If


            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            btnTambah.Text = "Simpan"
            txtNoPlat.Enabled = True
            txtNama.Enabled = True
            txtBiaya.Enabled = True
            cmbJenis.Enabled = True
            DateTimePicker1.Enabled = True
            btnCancel.Visible = True
            btnEdit.Enabled = False
            btnHapus.Enabled = False
            txtNoPlat.Clear()
            txtNama.Clear()
            txtBiaya.Clear()
            cmbJenis.Text = ""
        ElseIf btnTambah.Text = "Simpan" Then
            Dim hasil As DateTime = DateTimePicker1.Value
            Dim waktu As String = hasil.Year & "-" & hasil.Month & "-" & hasil.Day & "16:00:00"
            Dim Sql As String = "insert into tbllangganan(no_plat,nama,jenis,biaya,expired) values ('" & txtNoPlat.Text & "','" & txtNama.Text & "','" & cmbJenis.Text & "'," & txtBiaya.Text & ",'" & waktu & "')"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(Sql, myConn)
            Else
                myCommand.CommandText = Sql
            End If
            myCommand.ExecuteNonQuery()
            btnTambah.Text = "Tambah"
            txtNoPlat.Enabled = False
            txtNama.Enabled = False
            txtBiaya.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
            RefreshGrid()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            btnEdit.Text = "Simpan"
            txtNoPlat.Enabled = True
            txtNama.Enabled = True
            txtBiaya.Enabled = True
            cmbJenis.Enabled = True
            DateTimePicker1.Enabled = True
            btnCancel.Visible = True
            btnTambah.Enabled = False
            btnHapus.Enabled = False
        ElseIf btnEdit.Text = "Simpan" Then
            Dim hasil As DateTime = DateTimePicker1.Value
            Dim waktu As String = hasil.Year & "-" & hasil.Month & "-" & hasil.Day & "00:00:00"
            Dim sql As String = "update tbllangganan set no_plat = '" & txtNoPlat.Text & "',nama = '" & txtNama.Text & "',jenis = '" & cmbJenis.Text & "',biaya = '" & txtBiaya.Text & "',expired = '" & waktu & "' where id = " & lblId.Text
            MsgBox(sql)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            Dim hsl As Integer = myCommand.ExecuteNonQuery
            If hsl = 1 Then
                MsgBox("Update success!")
                RefreshGrid()
            End If
            btnEdit.Text = "Edit"
            txtNoPlat.Enabled = False
            txtNama.Enabled = False
            txtBiaya.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnTambah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If btnTambah.Text = "Simpan" Then
            btnTambah.Text = "Tambah"
            txtNoPlat.Enabled = False
            txtNama.Enabled = False
            txtBiaya.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
        ElseIf btnEdit.Text = "Simpan" Then
            btnEdit.Text = "Edit"
            txtNoPlat.Enabled = False
            txtNama.Enabled = False
            txtBiaya.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnTambah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView1.CurrentRow.Cells(0).Value.ToString <> "" Then
            If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) =
            Windows.Forms.DialogResult.Yes Then
                Dim sql As String = "delete from tbllangganan where id=" & DataGridView1.CurrentRow.Cells(0).Value.ToString
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
                End If
            Else
            End If
        End If
    End Sub

    Private Function SafeGetDate(reader As MySqlDataReader, columnName As String) As DateTime
        If Not Convert.IsDBNull(reader(columnName)) Then
            Return Convert.ToDateTime(reader(columnName))
        Else
            Return DateTime.Now
        End If
    End Function


End Class