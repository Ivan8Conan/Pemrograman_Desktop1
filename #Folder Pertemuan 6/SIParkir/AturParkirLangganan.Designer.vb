<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AturParkirLangganan
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
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        btnClose = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Pelanggan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nomor Plat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 2
        Label3.Text = "Tarif Langganan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 20)
        Label4.TabIndex = 3
        Label4.Text = "Berlaku Hingga"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(167, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(319, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(167, 67)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(243, 27)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(167, 108)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(243, 27)
        TextBox3.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(506, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 20)
        Label5.TabIndex = 8
        Label5.Text = "ID Pelanggan : "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(506, 66)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(442, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 20)
        Label6.TabIndex = 10
        Label6.Text = "Jenis "
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(167, 153)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(243, 27)
        DateTimePicker1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(442, 144)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 38)
        Button1.TabIndex = 12
        Button1.Text = "Tambah"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(551, 144)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 38)
        Button2.TabIndex = 13
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(661, 144)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 38)
        Button3.TabIndex = 14
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 202)
        Label7.Name = "Label7"
        Label7.Size = New Size(223, 20)
        Label7.TabIndex = 15
        Label7.Text = "Kendaraan terdaftar langganan :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(30, 225)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(725, 158)
        DataGridView1.TabIndex = 16
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(661, 389)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 33)
        btnClose.TabIndex = 17
        btnClose.Text = "Tutup"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' AturParkirLangganan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(DataGridView1)
        Controls.Add(Label7)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label6)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AturParkirLangganan"
        Text = "SIParkir - Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnClose As Button
End Class
