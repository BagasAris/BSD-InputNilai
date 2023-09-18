Imports MySql.Data.MySqlClient

Public Class FLogin

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

    Private Sub batalBtn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub login1Btn_Click(sender As Object, e As EventArgs) Handles login1Btn.Click
        If usernameTxt.Text = "" Or passwordTxt.Text = "" Then
            MessageBox.Show("Harap isi username dan password!")
        Else
            Call koneksi()
            CMD = New MySqlCommand("Select * from wali_kelas where username ='" & usernameTxt.Text & "' and password = '" & passwordTxt.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD("id").ToString = "2" Then
                Me.Hide()
                FMenuAdmin.Show()
            ElseIf RD("id").ToString = "1" Then
                Me.Hide()
                FXIIRPL1.Show()
            End If
            RD.Close()
        End If
    End Sub
End Class
