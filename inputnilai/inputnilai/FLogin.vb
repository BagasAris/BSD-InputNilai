Imports MySql.Data.MySqlClient

Public Class FLogin
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If usernameTxt.Text = "" Or passwordTxt.Text = "" Then
            MessageBox.Show("Harap isi username dan password!")
        Else
            Call koneksi()
            CMD = New MySqlCommand("Select * from guru where username ='" & usernameTxt.Text & "' and password = '" & passwordTxt.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD("id_level").ToString = "1" Then
                Me.Hide()
                FMenuAdmin.Show()
            ElseIf RD("id_level").ToString = "2" Then
                Me.Hide()
                FXIIRPL1.Show()
            End If
                RD.Close()
        End If
    End Sub

    Private Sub FLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordTxt.UseSystemPasswordChar = True
    End Sub

    Private Sub ShowBtn_Click(sender As Object, e As EventArgs) Handles ShowBtn.Click
        If passwordTxt.UseSystemPasswordChar = True Then
            passwordTxt.UseSystemPasswordChar = False
        Else
            passwordTxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub batalBtn_Click(sender As Object, e As EventArgs) Handles batalBtn.Click
        Me.Close()
    End Sub
End Class
