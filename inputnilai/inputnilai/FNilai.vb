Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FNilai
    Private Sub FNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
    End Sub

    Sub tampilUser()

        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from nilai", CONN)
        DS = New DataSet
        DA.Fill(DS, "nilai")
        DGnilai.DataSource = DS.Tables("nilai")

    End Sub

    Sub aturDGV()
        Try
            DGnilai.Columns(0).Width = 70
            DGnilai.Columns(1).Width = 130
            DGnilai.Columns(2).Width = 130
            DGnilai.Columns(3).Width = 130
            DGnilai.Columns(4).Width = 130
            DGnilai.Columns(5).Width = 130
            DGnilai.Columns(6).Width = 130
            DGnilai.Columns(0).HeaderText = "ID"
            DGnilai.Columns(1).HeaderText = "NAMA MATA PELAJARAN"
            DGnilai.Columns(2).HeaderText = "NAMA SISWA"
            DGnilai.Columns(3).HeaderText = "UTS 1"
            DGnilai.Columns(4).HeaderText = "UTS 2"
            DGnilai.Columns(5).HeaderText = "UAS 1"
            DGnilai.Columns(6).HeaderText = "UAS 2"
        Catch ex As Exception
        End Try
    End Sub

    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            'str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "',' SELECT id_level FROM tb_level WHERE id_level = '" & idTxt.Text & "')"
            str = "INSERT INTO nilai (id, mata_pelajaran, nama_siswa, uts1, uts2, uas1, uas2) VALUES ('" & idTxt.Text & "','" & namaTxt.Text & "','" & namaSiswaTxt.Text & "','" & uts1Txt.Text & "','" & uts2Txt.Text & "','" & uas1Txt.Text & "','" & uas2Txt.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Nilai Siswa Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Nilai Siswa gagal dilakukan.")
        End Try
        Call tampilUser()
        Call aturDGV()
        cariTxt.Text = ""
    End Sub
    Sub Edit()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE nilai SET id = '" & idTxt.Text & "', mata_pelajaran = '" & namaTxt.Text & "', nama_siswa = '" & namaSiswaTxt.Text & "', uts1 = '" & uts1Txt.Text & "', uts2 = '" & uts2Txt.Text & "', uas1 = '" & uas1Txt.Text & "', uas2 = '" & uas2Txt.Text & "' WHERE id = '" & idTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Nilai Siswa Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Nilai Siswa gagal dilakukan")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from nilai where id = '" & idTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Nilai Siswa Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Nilai Siswa Gagal Dihapus.")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub

    Private Sub DGnilai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGnilai.CellContentClick
        idTxt.Text = DGnilai.Rows(e.RowIndex).Cells(0).Value
        namaTxt.Text = DGnilai.Rows(e.RowIndex).Cells(1).Value
        namaSiswaTxt.Text = DGnilai.Rows(e.RowIndex).Cells(2).Value
        uts1Txt.Text = DGnilai.Rows(e.RowIndex).Cells(3).Value
        uts2Txt.Text = DGnilai.Rows(e.RowIndex).Cells(4).Value
        uas1Txt.Text = DGnilai.Rows(e.RowIndex).Cells(5).Value
        uas2Txt.Text = DGnilai.Rows(e.RowIndex).Cells(6).Value
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
        DA = New MySqlDataAdapter("select * from nilai", CONN)
        DS = New DataSet
        DA.Fill(DS, "nilai")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGnilai.DataSource = tampil
        DGnilai.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "nama_siswa = '" & cariTxt.Text & "'"
        DGnilai.Refresh()
    End Sub
End Class