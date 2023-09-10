Public Class FXIIRPL1
    Private Sub DataSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSiswaToolStripMenuItem.Click
        FDataSiswa.Show()
    End Sub

    Private Sub NilaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NilaiToolStripMenuItem.Click
        FNilai.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        FLogin.Show()
    End Sub
End Class