<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        btnSimpan = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password Baru"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(67, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 20)
        Label3.TabIndex = 2
        Label3.Text = "Ketik lagi"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(172, 53)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(194, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(172, 98)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(194, 27)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(172, 145)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(194, 27)
        TextBox3.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(172, 193)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(84, 39)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(279, 193)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(87, 39)
        btnClose.TabIndex = 7
        btnClose.Text = "Tutup"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(439, 281)
        Controls.Add(btnClose)
        Controls.Add(btnSimpan)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "SIParkir - Ubah Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnClose As Button
End Class
