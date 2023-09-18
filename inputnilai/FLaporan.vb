Public Class FLaporan
    Private Sub FLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilUser1()
        Call aturDGV1()

        Call tampilUser2()
        Call aturDGV2()

        Call tampilUser3()
        Call aturDGV3()
    End Sub

    Sub tampilUser1()

        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from data_siswa", CONN)
        DS = New DataSet
        DA.Fill(DS, "data_siswa")
        DGdatasiswa.DataSource = DS.Tables("data_siswa")

    End Sub

    Sub aturDGV1()
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

    Sub tampilUser2()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from mata_pelajaran", CONN)
        DS = New DataSet
        DA.Fill(DS, "mata_pelajaran")
        DGmapel.DataSource = DS.Tables("mata_pelajaran")
    End Sub

    Sub aturDGV2()
        Try
            DGmapel.Columns(0).Width = 70
            DGmapel.Columns(1).Width = 130
            DGmapel.Columns(0).HeaderText = "ID"
            DGmapel.Columns(1).HeaderText = "NAMA MATA PELAJARAN"
        Catch ex As Exception
        End Try
    End Sub

    Sub tampilUser3()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from nilai", CONN)
        DS = New DataSet
        DA.Fill(DS, "nilai")
        DGnilai.DataSource = DS.Tables("nilai")
    End Sub

    Sub aturDGV3()
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

    Private Sub keluarBtn_Click(sender As Object, e As EventArgs) Handles keluarBtn.Click
        Me.Close()
    End Sub
End Class