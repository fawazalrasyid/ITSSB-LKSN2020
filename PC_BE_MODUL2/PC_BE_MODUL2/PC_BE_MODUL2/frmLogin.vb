Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        koneksi()

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!")
            Return
        End If

        Try

            cmd = New SqlCommand("SELECT * FROM Employee where email='" & txtUsername.Text & "'and password='" & txtPassword.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows = True Then
                frmMain.Show()
                Me.Hide()

            Else
                MsgBox("Username atau password salah!")
                txtUsername.Text = ""
                txtPassword.Text = ""

            End If

            dr.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class
