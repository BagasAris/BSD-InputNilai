Imports MySql.Data.MySqlClient

Public Class FDataSiswa
    Private Sub FDataSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
        ComboBox1.Items.Add("Laki-Laki")
        ComboBox1.Items.Add("Perempuan")
    End Sub

    Sub tampilUser()

        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from data_siswa", CONN)
        DS = New DataSet
        DA.Fill(DS, "data_siswa")
        DGdatasiswa.DataSource = DS.Tables("data_siswa")

    End Sub

    Sub aturDGV()
        Try
            DGdatasiswa.Columns(0).Width = 70
            DGdatasiswa.Columns(1).Width = 130
            DGdatasiswa.Columns(2).Width = 130
            DGdatasiswa.Columns(3).Width = 130
            DGdatasiswa.Columns(4).Width = 130
            DGdatasiswa.Columns(0).HeaderText = "ID"
            DGdatasiswa.Columns(1).HeaderText = "NAMA"
            DGdatasiswa.Columns(2).HeaderText = "NISN"
            DGdatasiswa.Columns(3).HeaderText = "JENIS KELAMIN"
            DGdatasiswa.Columns(4).HeaderText = "KELAS" '
        Catch ex As Exception
        End Try
    End Sub

    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            'str = "INSERT INTO tb_petugas (id_petugas, username, password, nama_petugas, id_level) VALUES ('" & idPetugasTxt.Text & "','" & usernameTxt.Text & "', '" & passwordTxt.Text & "', '" & namaTxt.Text & "',' SELECT id_level FROM tb_level WHERE id_level = '" & idTxt.Text & "')"
            str = "INSERT INTO data_siswa (id, nama, nisn, jk, kelas) VALUES ('" & idTxt.Text & "','" & namaTxt.Text & "','" & nisnTxt.Text & "','" & ComboBox1.Text & "','" & kelasTxt.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Siswa Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Siswa gagal dilakukan.")
        End Try
        Call tampilUser()
        Call aturDGV()
        cariTxt.Text = ""
    End Sub
    Sub Edit()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE data_siswa SET id = '" & idTxt.Text & "', nama = '" & namaTxt.Text & "',, nisn = '" & nisnTxt.Text & "' jk = '" & ComboBox1.Text & "', kelas = '" & kelasTxt.Text & "' WHERE id = '" & idTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Siswa Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Siswa gagal dilakukan")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from data_siswa where id = '" & idTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Siswa Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Siswa Gagal Dihapus.")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub

    Private Sub DGdatasiswa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGdatasiswa.CellContentClick
        idTxt.Text = DGdatasiswa.Rows(e.RowIndex).Cells(0).Value
        namaTxt.Text = DGdatasiswa.Rows(e.RowIndex).Cells(1).Value
        nisnTxt.Text = DGdatasiswa.Rows(e.RowIndex).Cells(2).Value
        ComboBox1.Text = DGdatasiswa.Rows(e.RowIndex).Cells(3).Value
        kelasTxt.Text = DGdatasiswa.Rows(e.RowIndex).Cells(4).Value
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
        DA = New MySqlDataAdapter("select * from data_siswa", CONN)
        DS = New DataSet
        DA.Fill(DS, "data_siswa")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGdatasiswa.DataSource = tampil
        DGdatasiswa.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "nama = '" & cariTxt.Text & "'"
        DGdatasiswa.Refresh()
    End Sub

End Class