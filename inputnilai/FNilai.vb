Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FNilai
    Private Sub FNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
        Call isiComboMapel()
        Call isiComboNama()
    End Sub

    Sub isiComboMapel()
        Call koneksi()
        Dim query As String = "select nama from mata_pelajaran"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaMapel As String = RD("nama").ToString()
            mapel.Items.Add(namaMapel)
        End While
    End Sub

    Sub isiComboNama()
        Call koneksi()
        Dim query As String = "select nama from data_siswa"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaSiswa As String = RD("nama").ToString()
            siswa.Items.Add(namaSiswa)
        End While
    End Sub

    Sub tampilUser()

        Call koneksi()
        DA = New MySqlDataAdapter("SELECT nilai.id_nilai, mata_pelajaran.nama, data_siswa.nama, nilai.uts1, nilai.uts2, nilai.uas1, nilai.uas2 " &
    "FROM nilai " &
    "INNER JOIN mata_pelajaran ON nilai.mata_pelajaran = mata_pelajaran.id_mapel " &
    "INNER JOIN data_siswa ON nilai.nama_siswa = data_siswa.id_siswa", CONN)
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
            str = "INSERT INTO nilai (id_nilai, mata_pelajaran, nama_siswa, uts1, uts2, uas1, uas2) VALUES ('" & idTxt.Text & "', (Select id_mapel from mata_pelajaran where nama='" & mapel.Text & "'), (Select id_siswa from data_siswa where nama='" & siswa.Text & "'),'" & uts1Txt.Text & "','" & uts2Txt.Text & "','" & uas1Txt.Text & "','" & uas2Txt.Text & "')"
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
            str = "UPDATE nilai SET id_nilai = '" & idTxt.Text & "', mata_pelajaran = (Select id_mapel from mata_pelajaran where nama='" & mapel.Text & "'), nama_siswa = (Select id_siswa from data_siswa where nama='" & siswa.Text & "'), uts1 = '" & uts1Txt.Text & "', uts2 = '" & uts2Txt.Text & "', uas1 = '" & uas1Txt.Text & "', uas2 = '" & uas2Txt.Text & "' WHERE id_nilai = '" & idTxt.Text & "'"
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
            str = "delete from nilai where id_nilai = '" & idTxt.Text & "'"
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
        siswa.Text = DGnilai.Rows(e.RowIndex).Cells(1).Value
        mapel.Text = DGnilai.Rows(e.RowIndex).Cells(2).Value
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