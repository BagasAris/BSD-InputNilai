﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FMataPelajaran
    Private Sub FMataPelajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
        Call isiComboNamaGuru()
    End Sub

    Sub tampilUser()

        Call koneksi()
        DA = New MySqlDataAdapter("SELECT mata_pelajaran.id_mapel, mata_pelajaran.nama, guru.nama " &
                                  "FROM mata_pelajaran " &
                                  "INNER JOIN guru ON mata_pelajaran.id_guru = guru.id", CONN)
        DS = New DataSet
        DA.Fill(DS, "mata_pelajaran")
        DGmapel.DataSource = DS.Tables("mata_pelajaran")

    End Sub

    Sub isiComboNamaGuru()
        Call koneksi()
        Dim query As String = "select nama from guru"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaGuru As String = RD("nama").ToString()
            ComboBox1.Items.Add(namaGuru)
        End While
    End Sub

    Sub aturDGV()
        Try
            DGmapel.Columns(0).Width = 70
            DGmapel.Columns(1).Width = 210
            DGmapel.Columns(2).Width = 210
            DGmapel.Columns(0).HeaderText = "ID"
            DGmapel.Columns(1).HeaderText = "NAMA MATA PELAJARAN"
            DGmapel.Columns(2).HeaderText = "NAMA GURU"
        Catch ex As Exception
        End Try
    End Sub

    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            str = "INSERT INTO mata_pelajaran (id_mapel, nama, id_guru) VALUES ('" & idTxt.Text & "','" & namaTxt.Text & "', (Select id from guru where nama='" & ComboBox1.Text & "'))"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Mata Pelajaran Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert data Mata Pelajaran gagal dilakukan.")
        End Try
        Call tampilUser()
        Call aturDGV()
        cariTxt.Text = ""
    End Sub
    Sub Edit()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE mata_pelajaran SET id_mapel = '" & idTxt.Text & "', nama = '" & namaTxt.Text & "', id_guru = (Select id from guru where nama='" & ComboBox1.Text & "') WHERE id_mapel = '" & idTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Mata Pelajaran Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update data Mata Pelajaran gagal dilakukan")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from mata_pelajaran where id = '" & idTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Mata Pelajaran Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Mata Pelajaran Gagal Dihapus.")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub

    Private Sub DGmapel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGmapel.CellContentClick
        idTxt.Text = DGmapel.Rows(e.RowIndex).Cells(0).Value
        namaTxt.Text = DGmapel.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DGmapel.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub tambahBtn_Click(sender As Object, e As EventArgs) Handles tambahBtn.Click
        Call Simpan()
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        Call Edit()
    End Sub

    Private Sub hapusBtn_Click(sender As Object, e As EventArgs) Handles hapusBtn.Click
        Call Hapus()
    End Sub

    Private Sub keluarBtn_Click(sender As Object, e As EventArgs) Handles keluarBtn.Click
        Me.Close()
    End Sub

    Private Sub cariBtn_Click(sender As Object, e As EventArgs) Handles cariBtn.Click
        Dim tables As DataTableCollection = DS.Tables
        Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("select * from mata_pelajaran", CONN)
        DS = New DataSet
        DA.Fill(DS, "mata_pelajaran")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGmapel.DataSource = tampil
        DGmapel.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "nama = '" & cariTxt.Text & "'"
        DGmapel.Refresh()
    End Sub

End Class