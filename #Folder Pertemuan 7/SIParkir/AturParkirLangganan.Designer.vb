<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLangganan
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
        lblNama = New Label()
        lblNoPlat = New Label()
        lblBiaya = New Label()
        lblExpired = New Label()
        txtNoPlat = New TextBox()
        txtNama = New TextBox()
        txtBiaya = New TextBox()
        lblId = New Label()
        cmbJenis = New ComboBox()
        lblJenis = New Label()
        DateTimePicker1 = New DateTimePicker()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        btnClose = New Button()
        btnCancel = New Button()
        DataGridView2 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(30, 72)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' lblNoPlat
        ' 
        lblNoPlat.AutoSize = True
        lblNoPlat.Location = New Point(30, 32)
        lblNoPlat.Name = "lblNoPlat"
        lblNoPlat.Size = New Size(61, 20)
        lblNoPlat.TabIndex = 1
        lblNoPlat.Text = "No. Plat"
        ' 
        ' lblBiaya
        ' 
        lblBiaya.AutoSize = True
        lblBiaya.Location = New Point(30, 111)
        lblBiaya.Name = "lblBiaya"
        lblBiaya.Size = New Size(45, 20)
        lblBiaya.TabIndex = 2
        lblBiaya.Text = "Biaya"
        ' 
        ' lblExpired
        ' 
        lblExpired.AutoSize = True
        lblExpired.Location = New Point(30, 158)
        lblExpired.Name = "lblExpired"
        lblExpired.Size = New Size(59, 20)
        lblExpired.TabIndex = 3
        lblExpired.Text = "Expired"
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.Location = New Point(167, 27)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(243, 27)
        txtNoPlat.TabIndex = 4
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(167, 67)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(342, 27)
        txtNama.TabIndex = 5
        ' 
        ' txtBiaya
        ' 
        txtBiaya.Location = New Point(167, 108)
        txtBiaya.Name = "txtBiaya"
        txtBiaya.Size = New Size(243, 27)
        txtBiaya.TabIndex = 6
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(442, 30)
        lblId.Name = "lblId"
        lblId.Size = New Size(22, 20)
        lblId.TabIndex = 8
        lblId.Text = "id"
        lblId.Visible = False
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Items.AddRange(New Object() {"Motor ", "Mobil ", "Taxi/Umum ", "Truk ", "Sepeda "})
        cmbJenis.Location = New Point(506, 105)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(151, 28)
        cmbJenis.TabIndex = 9
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(442, 108)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(40, 20)
        lblJenis.TabIndex = 10
        lblJenis.Text = "Jenis"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(167, 153)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(243, 27)
        DateTimePicker1.TabIndex = 11
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.Location = New Point(445, 144)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(76, 38)
        btnTambah.TabIndex = 12
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(528, 145)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(71, 37)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(607, 144)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(70, 38)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
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
        btnClose.Location = New Point(661, 399)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 33)
        btnClose.TabIndex = 17
        btnClose.Text = "Tutup"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(686, 143)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(69, 38)
        btnCancel.TabIndex = 18
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        btnCancel.Visible = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView2.Location = New Point(30, 225)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(758, 177)
        DataGridView2.TabIndex = 19
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Id"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "No Plat"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Nama Pemilik"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Biaya"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Jenis"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Expired"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' frmLangganan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView2)
        Controls.Add(btnCancel)
        Controls.Add(btnClose)
        Controls.Add(DataGridView1)
        Controls.Add(Label7)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnTambah)
        Controls.Add(DateTimePicker1)
        Controls.Add(lblJenis)
        Controls.Add(cmbJenis)
        Controls.Add(lblId)
        Controls.Add(txtBiaya)
        Controls.Add(txtNama)
        Controls.Add(txtNoPlat)
        Controls.Add(lblExpired)
        Controls.Add(lblBiaya)
        Controls.Add(lblNoPlat)
        Controls.Add(lblNama)
        KeyPreview = True
        Name = "frmLangganan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Kendaraan Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents lblBiaya As Label
    Friend WithEvents lblExpired As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents lblJenis As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
