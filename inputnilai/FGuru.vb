Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FGuru

    Private Sub FGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
        Call isiComboNamaLevel()
    End Sub
    Sub tampilUser()

        Call koneksi()
        DA = New MySqlDataAdapter("SELECT guru.id, guru.nama, guru.nip, guru.jk, level.nama_level " &
                                  "FROM guru " &
                                  "INNER JOIN level ON guru.id_level = level.id_level", CONN)
        DS = New DataSet
        DA.Fill(DS, "guru")
        DGdataguru.DataSource = DS.Tables("guru")

    End Sub

    Sub isiComboNamaLevel()
        Call koneksi()
        Dim query As String = "select nama_level from level"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim namaLevel As String = RD("nama_level").ToString()
            level.Items.Add(namaLevel)
        End While
    End Sub

    Sub aturDGV()
        Try
            DGdataguru.Columns(0).Width = 70
            DGdataguru.Columns(1).Width = 210
            DGdataguru.Columns(2).Width = 130
            DGdataguru.Columns(3).Width = 180
            DGdataguru.Columns(4).Width = 130
            DGdataguru.Columns(0).HeaderText = "ID"
            DGdataguru.Columns(1).HeaderText = "NAMA"
            DGdataguru.Columns(2).HeaderText = "NIP"
            DGdataguru.Columns(3).HeaderText = "JENIS KELAMIN"
            DGdataguru.Columns(2).HeaderText = "LEVEL"
        Catch ex As Exception
        End Try
    End Sub
    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            str = "INSERT INTO guru (id, nama, nip, jk, id_level) VALUES ('" & idTxt.Text & "','" & namaTxt.Text & "','" & nipTxt.Text & "','" & jk.Text & "', (Select id_level from level where nama_level='" & level.Text & "'))"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Guru Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert data Guru gagal dilakukan.")
        End Try
        Call tampilUser()
        Call aturDGV()
        cariTxt.Text = ""
    End Sub
    Sub Edit()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE guru SET id = '" & idTxt.Text & "', nama = '" & namaTxt.Text & "', nip = '" & nipTxt.Text & "', jk = '" & jk.Text & "', id_level = (Select id_level from level where nama_level='" & level.Text & "') WHERE id = '" & idTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Guru Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Guru gagal dilakukan")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from guru where id = '" & idTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Guru Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Guru Gagal Dihapus.")
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

    Private Sub DGdataguru_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGdataguru.CellContentClick
        idTxt.Text = DGdataguru.Rows(e.RowIndex).Cells(0).Value
        namaTxt.Text = DGdataguru.Rows(e.RowIndex).Cells(1).Value
        nipTxt.Text = DGdataguru.Rows(e.RowIndex).Cells(2).Value
        jk.Text = DGdataguru.Rows(e.RowIndex).Cells(3).Value
        level.Text = DGdataguru.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub cariBtn_Click(sender As Object, e As EventArgs) Handles cariBtn.Click
        Dim tables As DataTableCollection = DS.Tables
        Dim source1 As New BindingSource
        DA = New MySqlDataAdapter("select * from guru", CONN)
        DS = New DataSet
        DA.Fill(DS, "guru")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGdataguru.DataSource = tampil
        DGdataguru.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "nama = '" & cariTxt.Text & "'"
        DGdataguru.Refresh()
    End Sub
End Class