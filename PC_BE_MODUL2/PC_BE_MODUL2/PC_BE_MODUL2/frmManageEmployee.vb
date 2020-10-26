Imports System.Data.Entity
Imports System.Data.SqlClient

Public Class frmManageEmployee

    Private db As PC_BE_MODUL2Entities

    Private Sub frmManageEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New PC_BE_MODUL2Entities
        db.Employees.Load()
        EmployeeBindingSource.DataSource = db.Employees.Local

        txtEmployeeId.Enabled = False
        txtName.Enabled = False
        txtEmail.Enabled = False
        txtPhone.Enabled = False
        txtAddress.Enabled = False
        DateofBirth.Enabled = False
        comboJobTitle.Enabled = False
        numSalary.Enabled = False
        txtPassword.Enabled = False
        txtConfirmPassword.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        koneksi()

        Dim dt As New DataTable
        cmd = New SqlCommand("SELECT Name FROM Employee", conn)
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)

        Dim col As New AutoCompleteStringCollection

        For i = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("Name").ToString())
        Next
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox1.AutoCompleteCustomSource = col
        TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        EmployeeBindingSource.AddNew()

        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        txtEmployeeId.Enabled = False
        txtName.Enabled = True
        txtEmail.Enabled = True
        txtPhone.Enabled = True
        txtAddress.Enabled = True
        DateofBirth.Enabled = True
        comboJobTitle.Enabled = True
        numSalary.Enabled = True
        txtPassword.Enabled = True
        txtConfirmPassword.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        txtEmployeeId.Enabled = True
        txtName.Enabled = True
        txtEmail.Enabled = True
        txtPhone.Enabled = True
        txtAddress.Enabled = True
        DateofBirth.Enabled = True
        comboJobTitle.Enabled = True
        numSalary.Enabled = True
        txtPassword.Enabled = True
        txtConfirmPassword.Enabled = True

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            EmployeeBindingSource.RemoveCurrent()
            db.SaveChanges()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        db.SaveChanges()
        MessageBox.Show("Your data has been succesfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtEmployeeId.Clear()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        numSalary.Value = numSalary.Minimum
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        txtEmployeeId.Enabled = False
        txtName.Enabled = False
        txtEmail.Enabled = False
        txtPhone.Enabled = False
        txtAddress.Enabled = False
        DateofBirth.Enabled = False
        comboJobTitle.Enabled = False
        numSalary.Enabled = False
        txtPassword.Enabled = False
        txtConfirmPassword.Enabled = False

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim changed = db.ChangeTracker.Entries().Where(Function(x) x.State <> EntityState.Unchanged).ToList
        For Each obj In changed
            Select Case obj.State
                Case EntityState.Modified
                    obj.CurrentValues.SetValues(obj.OriginalValues)
                    obj.State = EntityState.Unchanged
                Case EntityState.Added
                    obj.State = EntityState.Detached
                Case EntityState.Deleted
                    obj.State = EntityState.Unchanged
            End Select
        Next

        txtEmployeeId.Clear()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        numSalary.Value = numSalary.Minimum
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        txtEmployeeId.Enabled = False
        txtName.Enabled = False
        txtEmail.Enabled = False
        txtPhone.Enabled = False
        txtAddress.Enabled = False
        DateofBirth.Enabled = False
        comboJobTitle.Enabled = False
        numSalary.Enabled = False
        txtPassword.Enabled = False
        txtConfirmPassword.Enabled = False
    End Sub
End Class