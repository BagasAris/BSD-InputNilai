Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI.WinForms
Imports MySql.Data.MySqlClient

Public Class FWaliKelas
    Private Sub FWaliKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
        Call isiComboNamaGuru()
        Call isiComboKelas()
    End Sub
    Sub isiComboNamaGuru()
        Call koneksi()
        Dim query As String = "select nama from guru"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaGuru As String = RD("nama").ToString()
            guru.Items.Add(namaGuru)
        End While
    End Sub
    Sub isiComboKelas()
        Call koneksi()
        Dim query As String = "select nama from kelas"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaKelas As String = RD("nama").ToString()
            kelas.Items.Add(namaKelas)
        End While
    End Sub
    Sub tampilUser()
        Call koneksi()
        DA = New MySqlDataAdapter("SELECT wali_kelas.id, guru.nama, kelas.nama, wali_kelas.jurusan, wali_kelas.username, wali_kelas.password " &
                         "FROM wali_kelas " &
                         "INNER JOIN guru ON wali_kelas.nama = guru.id " &
                         "INNER JOIN kelas ON wali_kelas.kelas = kelas.id_kelas", CONN)
        DS = New DataSet
        DA.Fill(DS, "wali_kelas")
        DGdatawalikelas.DataSource = DS.Tables("wali_kelas")
    End Sub
    Sub aturDGV()
        Try
            DGdatawalikelas.Columns(0).Width = 70
            DGdatawalikelas.Columns(1).Width = 210
            DGdatawalikelas.Columns(2).Width = 100
            DGdatawalikelas.Columns(3).Width = 280
            DGdatawalikelas.Columns(4).Width = 100
            DGdatawalikelas.Columns(5).Width = 100
            DGdatawalikelas.Columns(0).HeaderText = "ID"
            DGdatawalikelas.Columns(1).HeaderText = "NAMA GURU"
            DGdatawalikelas.Columns(2).HeaderText = "KELAS"
            DGdatawalikelas.Columns(3).HeaderText = "JURUSAN"
            DGdatawalikelas.Columns(4).HeaderText = "USERNAME"
            DGdatawalikelas.Columns(5).HeaderText = "PASSWORD"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DGdatawalikelas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGdatawalikelas.CellContentClick
        idTxt.Text = DGdatawalikelas.Rows(e.RowIndex).Cells(0).Value
        guru.Text = DGdatawalikelas.Rows(e.RowIndex).Cells(1).Value
        kelas.Text = DGdatawalikelas.Rows(e.RowIndex).Cells(2).Value
        jurusan.Text = DGdatawalikelas.Rows(e.RowIndex).Cells(3).Value
        usernameTxt.Text = DGdatawalikelas.Rows(e.RowIndex).Cells(4).Value
        passwordTxt.Text = DGdatawalikelas.Rows(e.RowIndex).Cells(5).Value
    End Sub
    Sub Simpan()
        Call koneksi()
        Try
            Select Case kelas.Text
                Case "XII RPL 1", "XII RPL 2"
                    jurusan.Text = "Pengembangan Perangkat Lunak dan Gim"
                Case "XII TSM 1"
                    jurusan.Text = "Teknik Kendaraan Ringan Otomotif"
                Case Else
                    jurusan.Text = "Harap isi kelas terlebih dahulu" ' Isi dengan nilai default jika tidak ada yang cocok
            End Select

            ' Setelah Anda mengatur nilai jurusan, buat string SQL
            Dim str As String
            str = "INSERT INTO wali_kelas (id, nama, kelas, jurusan, username, password) VALUES ('" & idTxt.Text & "',
        (Select id from guru where nama='" & guru.Text & "'),
        (Select id_kelas from kelas where nama='" & kelas.Text & "'),
        '" & jurusan.Text & "','" & usernameTxt.Text & "','" & passwordTxt.Text & "')"



            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Wali Kelas Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Wali Kelas gagal dilakukan.")
        End Try
        Call tampilUser()
        Call aturDGV()
        cariTxt.Text = ""
    End Sub
    Sub Edit()
        Try
            Call koneksi()
            Select Case kelas.Text
                Case "XII RPL 1"
                    jurusan.Text = "Pengembangan Perangkat Lunak dan Gim"
                Case "XII RPL 2"
                    jurusan.Text = "Pengembangan Perangkat Lunak dan Gim"
                Case "XII TSM 1"
                    jurusan.Text = "Teknik Kendaraan Ringan Otomotif"
                Case Else
                    jurusan.Text = "Harap isi kelas terlebih dahulu" ' Isi dengan nilai default jika tidak ada yang cocok
            End Select
            Dim str As String
            str = "UPDATE wali_kelas SET id = '" & idTxt.Text & "', 
                    nama = (Select id from guru where nama='" & guru.Text & "'), 
                    kelas = (Select id_kelas from kelas where nama='" & kelas.Text & "'), 
                    jurusan = '" & jurusan.Text & "', username = '" & usernameTxt.Text & "', password = '" & passwordTxt.Text & "' 
                    WHERE id = '" & idTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Wali Kelas Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Wali Kelas gagal dilakukan")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from wali_kelas where id = '" & idTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Wali Kelas Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Wali Kelas Gagal Dihapus.")
        End Try
        Call tampilUser()
        Call aturDGV()
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
        DA = New MySqlDataAdapter("select * from wali_kelas", CONN)
        DS = New DataSet
        DA.Fill(DS, "wali_kelas")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGdatawalikelas.DataSource = tampil
        DGdatawalikelas.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "kelas = '" & cariTxt.Text & "'"
        DGdatawalikelas.Refresh()
    End Sub
End Class