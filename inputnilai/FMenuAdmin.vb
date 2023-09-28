Public Class FMenuAdmin
    Private Sub GuruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuruToolStripMenuItem.Click
        FGuru.Show()
    End Sub

    Private Sub WaliKelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaliKelasToolStripMenuItem.Click
        FWaliKelas.Show()
    End Sub

    Private Sub KelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KelasToolStripMenuItem.Click
        FKelas.Show()
    End Sub

    Private Sub LevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LevelToolStripMenuItem.Click
        FLevel.Show()
    End Sub
End Class