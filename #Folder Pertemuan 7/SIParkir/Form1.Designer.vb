<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 79)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 124)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(172, 76)
        txtUsername.Margin = New Padding(2, 3, 2, 3)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(194, 27)
        txtUsername.TabIndex = 2
        txtUsername.Text = "Username"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(173, 121)
        txtPassword.Margin = New Padding(2, 3, 2, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(194, 27)
        txtPassword.TabIndex = 3
        txtPassword.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(173, 176)
        btnLogin.Margin = New Padding(2, 3, 2, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(87, 37)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(279, 176)
        btnExit.Margin = New Padding(2, 3, 2, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(87, 37)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(438, 278)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        KeyPreview = True
        Margin = New Padding(2, 3, 2, 3)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button

End Class
