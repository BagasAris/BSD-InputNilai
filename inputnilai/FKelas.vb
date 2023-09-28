Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient

Public Class FKelas

    Private Sub FKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
    End Sub
    Sub tampilUser()
        Call koneksi()
        DA = New MySqlDataAdapter("SELECT * from kelas", CONN)
        DS = New DataSet
        DA.Fill(DS, "kelas")
        DGdatakelas.DataSource = DS.Tables("kelas")
    End Sub
    Sub aturDGV()
        Try
            DGdatakelas.Columns(0).Width = 70
            DGdatakelas.Columns(1).Width = 210
            DGdatakelas.Columns(2).Width = 130
            DGdatakelas.Columns(3).Width = 180
            DGdatakelas.Columns(0).HeaderText = "ID"
            DGdatakelas.Columns(1).HeaderText = "JURUSAN"
            DGdatakelas.Columns(2).HeaderText = "NAMA KELAS"
            DGdatakelas.Columns(3).HeaderText = "GENERASI"
        Catch ex As Exception
        End Try
    End Sub
    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            str = "INSERT INTO kelas (id_kelas, jurusan, nama, generasi) VALUES ('" & idTxt.Text & "','" & ComboBox1.Text & "','" & namaTxt.Text & "','" & generasiTxt.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Kelas Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Kelas gagal dilakukan.")
        End Try
        Call tampilUser()
        Call aturDGV()
        cariTxt.Text = ""
    End Sub
    Sub Edit()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE kelas SET id_kelas = '" & idTxt.Text & "', jurusan = '" & ComboBox1.Text & "', nama = '" & namaTxt.Text & "', generasi = '" & generasiTxt.Text & "' WHERE id_kelas = '" & idTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Kelas Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Kelas gagal dilakukan")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from kelas where id_kelas = '" & idTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Kelas Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Kelas Gagal Dihapus.")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub

    Private Sub DGdatakelas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGdatakelas.CellContentClick
        idTxt.Text = DGdatakelas.Rows(e.RowIndex).Cells(0).Value
        ComboBox1.Text = DGdatakelas.Rows(e.RowIndex).Cells(1).Value
        namaTxt.Text = DGdatakelas.Rows(e.RowIndex).Cells(2).Value
        generasiTxt.Text = DGdatakelas.Rows(e.RowIndex).Cells(3).Value
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
        DA = New MySqlDataAdapter("select * from kelas", CONN)
        DS = New DataSet
        DA.Fill(DS, "kelas")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGdatakelas.DataSource = tampil
        DGdatakelas.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "nama = '" & cariTxt.Text & "'"
        DGdatakelas.Refresh()
    End Sub
End Class