Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FLevel
    Private Sub FLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser()
        Call aturDGV()
    End Sub
    Sub tampilUser()
        Call koneksi()
        DA = New MySqlDataAdapter("SELECT * from level", CONN)
        DS = New DataSet
        DA.Fill(DS, "level")
        DGdatalevel.DataSource = DS.Tables("level")
    End Sub
    Sub aturDGV()
        Try
            DGdatalevel.Columns(0).Width = 70
            DGdatalevel.Columns(1).Width = 210
            DGdatalevel.Columns(0).HeaderText = "ID"
            DGdatalevel.Columns(1).HeaderText = "Level"
        Catch ex As Exception
        End Try
    End Sub
    Sub Simpan()
        Call koneksi()
        Try
            Dim str As String
            str = "INSERT INTO level (id_level, nama_level) VALUES ('" & idTxt.Text & "','" & GunaComboBox1.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Level Berhasil Dilakukan")
        Catch ex As Exception
            MessageBox.Show("Insert Data Level gagal dilakukan.")
        End Try
        Call tampilUser()
        Call aturDGV()
        cariTxt.Text = ""
    End Sub
    Sub Edit()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE level SET id_level = '" & idTxt.Text & "', nama_level = '" & GunaComboBox1.Text & "' WHERE id_level = '" & idTxt.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Level Berhasil Dilakukan.")

        Catch ex As Exception
            MessageBox.Show("Update Data Level gagal dilakukan")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub
    Sub Hapus()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from level where id_level = '" & idTxt.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Level Berhasil Dihapus.")

        Catch ex As Exception
            MessageBox.Show("Data Level Gagal Dihapus.")
        End Try
        Call tampilUser()
        Call aturDGV()
    End Sub

    Private Sub DGdatalevel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGdatalevel.CellContentClick
        idTxt.Text = DGdatalevel.Rows(e.RowIndex).Cells(0).Value
        GunaComboBox1.Text = DGdatalevel.Rows(e.RowIndex).Cells(1).Value
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
        DA = New MySqlDataAdapter("select * from level", CONN)
        DS = New DataSet
        DA.Fill(DS, "level")
        'memunculkan data-data di dalam tabel
        Dim tampil As New DataView(tables(0))
        source1.DataSource = tampil
        DGdatalevel.DataSource = tampil
        DGdatalevel.Refresh()
        'memunculkan data tabel berdasarkan pencarian Txt_Cari(memasukkan ID Anggota)
        tampil.RowFilter = "nama_level = '" & cariTxt.Text & "'"
        DGdatalevel.Refresh()
    End Sub
End Class