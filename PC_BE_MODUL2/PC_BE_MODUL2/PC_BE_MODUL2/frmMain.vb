Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Form1
            .TopLevel = False
            Panel1.Controls.Add(Form1)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnManageEmployee_Click(sender As Object, e As EventArgs) Handles btnManageEmployee.Click
        With frmManageEmployee
            .TopLevel = False
            Panel1.Controls.Add(frmManageEmployee)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnManageService_Click(sender As Object, e As EventArgs) Handles btnManageService.Click
        With frmManageService
            .TopLevel = False
            Panel1.Controls.Add(frmManageService)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class