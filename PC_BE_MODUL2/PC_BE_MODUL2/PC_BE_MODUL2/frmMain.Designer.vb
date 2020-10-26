<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnManageEmployee = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnManageService = New System.Windows.Forms.Button()
        Me.btnManagePackage = New System.Windows.Forms.Button()
        Me.btnTransactionDeposit = New System.Windows.Forms.Button()
        Me.btnPrepaidPackage = New System.Windows.Forms.Button()
        Me.btnViewTransaction = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnManageEmployee
        '
        Me.btnManageEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnManageEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageEmployee.Location = New System.Drawing.Point(19, 79)
        Me.btnManageEmployee.Name = "btnManageEmployee"
        Me.btnManageEmployee.Size = New System.Drawing.Size(177, 74)
        Me.btnManageEmployee.TabIndex = 7
        Me.btnManageEmployee.Text = "Manage Employee"
        Me.btnManageEmployee.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Esemka Laundry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1031, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hello, User"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnManageService
        '
        Me.btnManageService.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnManageService.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageService.Location = New System.Drawing.Point(19, 170)
        Me.btnManageService.Name = "btnManageService"
        Me.btnManageService.Size = New System.Drawing.Size(177, 74)
        Me.btnManageService.TabIndex = 10
        Me.btnManageService.Text = "Manage Service"
        Me.btnManageService.UseVisualStyleBackColor = False
        '
        'btnManagePackage
        '
        Me.btnManagePackage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnManagePackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagePackage.Location = New System.Drawing.Point(19, 259)
        Me.btnManagePackage.Name = "btnManagePackage"
        Me.btnManagePackage.Size = New System.Drawing.Size(177, 74)
        Me.btnManagePackage.TabIndex = 11
        Me.btnManagePackage.Text = "Manage Package"
        Me.btnManagePackage.UseVisualStyleBackColor = False
        '
        'btnTransactionDeposit
        '
        Me.btnTransactionDeposit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTransactionDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransactionDeposit.Location = New System.Drawing.Point(19, 348)
        Me.btnTransactionDeposit.Name = "btnTransactionDeposit"
        Me.btnTransactionDeposit.Size = New System.Drawing.Size(177, 74)
        Me.btnTransactionDeposit.TabIndex = 12
        Me.btnTransactionDeposit.Text = "Transaction Deposit"
        Me.btnTransactionDeposit.UseVisualStyleBackColor = False
        '
        'btnPrepaidPackage
        '
        Me.btnPrepaidPackage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPrepaidPackage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrepaidPackage.Location = New System.Drawing.Point(19, 439)
        Me.btnPrepaidPackage.Name = "btnPrepaidPackage"
        Me.btnPrepaidPackage.Size = New System.Drawing.Size(177, 74)
        Me.btnPrepaidPackage.TabIndex = 13
        Me.btnPrepaidPackage.Text = "Prepaid Package"
        Me.btnPrepaidPackage.UseVisualStyleBackColor = False
        '
        'btnViewTransaction
        '
        Me.btnViewTransaction.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnViewTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTransaction.Location = New System.Drawing.Point(19, 528)
        Me.btnViewTransaction.Name = "btnViewTransaction"
        Me.btnViewTransaction.Size = New System.Drawing.Size(177, 74)
        Me.btnViewTransaction.TabIndex = 14
        Me.btnViewTransaction.Text = "View Transaction"
        Me.btnViewTransaction.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(223, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 523)
        Me.Panel1.TabIndex = 15
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 624)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnViewTransaction)
        Me.Controls.Add(Me.btnPrepaidPackage)
        Me.Controls.Add(Me.btnTransactionDeposit)
        Me.Controls.Add(Me.btnManagePackage)
        Me.Controls.Add(Me.btnManageService)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnManageEmployee)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManageEmployee As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnManageService As Button
    Friend WithEvents btnManagePackage As Button
    Friend WithEvents btnTransactionDeposit As Button
    Friend WithEvents btnPrepaidPackage As Button
    Friend WithEvents btnViewTransaction As Button
    Friend WithEvents Panel1 As Panel
End Class
