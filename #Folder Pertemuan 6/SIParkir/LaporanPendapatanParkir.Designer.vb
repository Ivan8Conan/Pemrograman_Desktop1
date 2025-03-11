<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanPendapatanParkir
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
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        btnClose = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 0
        Label1.Text = "Periode"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 20)
        Label2.TabIndex = 1
        Label2.Text = "Laporan : "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        ComboBox1.Location = New Point(132, 25)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(145, 28)
        ComboBox1.TabIndex = 3
        ComboBox1.Text = "Bulan"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(398, 42)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 35)
        Button1.TabIndex = 4
        Button1.Text = "Tampilkan!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(293, 24)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(78, 27)
        TextBox1.TabIndex = 5
        TextBox1.Text = "Tahun"
        ' 
        ' btnClose
        ' 
        btnClose.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(670, 389)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 38)
        btnClose.TabIndex = 6
        btnClose.Text = "Tutup"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(43, 96)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(721, 287)
        DataGridView1.TabIndex = 7
        ' 
        ' LaporanPendapatanParkir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnClose)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LaporanPendapatanParkir"
        Text = "SIParkir - Laporan Pendapatan Parkir"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
