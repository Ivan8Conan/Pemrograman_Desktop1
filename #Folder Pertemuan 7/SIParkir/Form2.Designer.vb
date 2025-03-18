<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfil
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
        lblUsername = New Label()
        lblPassword = New Label()
        lblRetype = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtRetype = New TextBox()
        btnSave = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(67, 56)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(75, 20)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(67, 101)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(70, 20)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password"
        ' 
        ' lblRetype
        ' 
        lblRetype.AutoSize = True
        lblRetype.Location = New Point(67, 148)
        lblRetype.Name = "lblRetype"
        lblRetype.Size = New Size(93, 20)
        lblRetype.TabIndex = 2
        lblRetype.Text = "Retype Pass: "
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(172, 53)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(194, 27)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(172, 98)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(194, 27)
        txtPassword.TabIndex = 4
        ' 
        ' txtRetype
        ' 
        txtRetype.Location = New Point(172, 145)
        txtRetype.Name = "txtRetype"
        txtRetype.Size = New Size(194, 27)
        txtRetype.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(172, 193)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(84, 39)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(279, 193)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(87, 39)
        btnClose.TabIndex = 7
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmProfil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(439, 281)
        Controls.Add(btnClose)
        Controls.Add(btnSave)
        Controls.Add(txtRetype)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblRetype)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        KeyPreview = True
        Name = "frmProfil"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblRetype As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtRetype As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
End Class
