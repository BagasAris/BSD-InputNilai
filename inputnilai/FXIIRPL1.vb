Public Class FXIIRPL1
    Private Sub DataSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSiswaToolStripMenuItem.Click
        FDataSiswa.Show()
    End Sub

    Private Sub NilaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NilaiToolStripMenuItem.Click
        FNilai.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FLogin.Show()
    End Sub

    Private Sub MataPelajaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MataPelajaranToolStripMenuItem.Click
        FMataPelajaran.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        FLaporan.Show()
    End Sub

    Private Sub FXIIRPL1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Hide()
        FLogin.Show()
    End Sub
End Class