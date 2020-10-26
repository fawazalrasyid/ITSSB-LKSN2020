Imports System.Data.Entity
Imports System.Data.SqlClient

Public Class frmManageService
    Private db As PC_BE_MODUL2Entities

    Private Sub frmManageEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New PC_BE_MODUL2Entities
        db.Services.Load()
        ServiceBindingSource.DataSource = db.Services.Local

        txtEmployeeId.Enabled = False
        txtName.Enabled = False
        numSalary.Enabled = False
        NumericUpDown1.Enabled = False
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
        ServiceBindingSource.AddNew()

        btnInsert.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        NumericUpDown1.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        txtEmployeeId.Enabled = False
        txtName.Enabled = True
        comboJobTitle.Enabled = True
        numSalary.Enabled = True
        NumericUpDown1.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        txtEmployeeId.Enabled = True
        txtName.Enabled = True
        comboJobTitle.Enabled = True
        numSalary.Enabled = True
        NumericUpDown1.Enabled = True

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ServiceBindingSource.RemoveCurrent()
            db.SaveChanges()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        db.SaveChanges()
        MessageBox.Show("Your data has been succesfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtEmployeeId.Clear()
        txtName.Clear()
        numSalary.Value = numSalary.Minimum

        txtEmployeeId.Enabled = False
        txtName.Enabled = False
        comboJobTitle.Enabled = False
        numSalary.Enabled = False
        NumericUpDown1.Enabled = False

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
        numSalary.Value = numSalary.Minimum

        txtEmployeeId.Enabled = False
        txtName.Enabled = False
        comboJobTitle.Enabled = False
        numSalary.Enabled = False
        NumericUpDown1.Enabled = False
    End Sub

    Private Sub comboJobTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboJobTitle.SelectedIndexChanged

    End Sub
End Class