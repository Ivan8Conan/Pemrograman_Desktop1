<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        ComboBox2 = New ComboBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        GroupBox3 = New GroupBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(235, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(352, 28)
        Label1.TabIndex = 0
        Label1.Text = "Pemesanan Tempat Duduk Restoran"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Window
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 50)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(191, 364)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informasi Meja"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(48, 324)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(3)
        Label7.Size = New Size(125, 26)
        Label7.TabIndex = 12
        Label7.Text = "Sedang Dipesan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(51, 291)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(3)
        Label6.Size = New Size(50, 26)
        Label6.TabIndex = 11
        Label6.Text = "Terisi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(51, 258)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(3)
        Label5.Size = New Size(71, 26)
        Label5.TabIndex = 10
        Label5.Text = "Tersedia"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Yellow
        Button3.Location = New Point(19, 324)
        Button3.Name = "Button3"
        Button3.Size = New Size(26, 27)
        Button3.TabIndex = 9
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Location = New Point(19, 291)
        Button2.Name = "Button2"
        Button2.Size = New Size(26, 27)
        Button2.TabIndex = 8
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Location = New Point(19, 258)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 27)
        Button1.TabIndex = 7
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(6, 229)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(3)
        Label4.Size = New Size(171, 26)
        Label4.TabIndex = 6
        Label4.Text = "Status Kesediaan Meja :"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"2 kursi", "4 kursi", "6 / 8 kursi"})
        ComboBox2.Location = New Point(6, 147)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 31)
        ComboBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 118)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(3)
        Label3.Size = New Size(124, 26)
        Label3.TabIndex = 4
        Label3.Text = "Preferensi Meja :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        ComboBox1.Location = New Point(6, 73)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 31)
        ComboBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 44)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(3)
        Label2.Size = New Size(107, 26)
        Label2.TabIndex = 2
        Label2.Text = "Jumlah Tamu :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Window
        GroupBox2.Controls.Add(Button10)
        GroupBox2.Controls.Add(Button9)
        GroupBox2.Controls.Add(Button8)
        GroupBox2.Controls.Add(Button7)
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(209, 50)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(378, 364)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Layout Meja Restoran"
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Lime
        Button10.Location = New Point(125, 169)
        Button10.Name = "Button10"
        Button10.Size = New Size(116, 98)
        Button10.TabIndex = 6
        Button10.Text = "Meja 6 " & vbCrLf & "@6/8"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Silver
        Button9.Location = New Point(26, 288)
        Button9.Name = "Button9"
        Button9.Size = New Size(315, 71)
        Button9.TabIndex = 5
        Button9.Text = "Restoran"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Yellow
        Button8.Location = New Point(257, 127)
        Button8.Name = "Button8"
        Button8.Size = New Size(84, 71)
        Button8.TabIndex = 4
        Button8.Text = "Meja 5 @4"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Lime
        Button7.Location = New Point(26, 127)
        Button7.Name = "Button7"
        Button7.Size = New Size(84, 71)
        Button7.TabIndex = 3
        Button7.Text = "Meja 4 @4"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Red
        Button6.Location = New Point(266, 44)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 60)
        Button6.TabIndex = 2
        Button6.Text = "Meja 3" & vbCrLf & "@2"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Lime
        Button5.Location = New Point(144, 44)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 60)
        Button5.TabIndex = 1
        Button5.Text = "Meja 2" & vbCrLf & "@2"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Lime
        Button4.Location = New Point(26, 44)
        Button4.Name = "Button4"
        Button4.Size = New Size(72, 60)
        Button4.TabIndex = 0
        Button4.Text = "Meja 1" & vbCrLf & "@2"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.Window
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(593, 50)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(195, 364)
        GroupBox3.TabIndex = 7
        GroupBox3.TabStop = False
        GroupBox3.Text = "Pemesanan Menu"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(0, 267)
        Label12.Name = "Label12"
        Label12.Size = New Size(196, 60)
        Label12.TabIndex = 4
        Label12.Text = "1. Signature Steak ☆☆☆☆☆" & vbCrLf & "2. Seafood Pasta ☆☆☆☆☆" & vbCrLf & "3. Luxury Salad ☆☆☆☆☆"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(6, 247)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 20)
        Label11.TabIndex = 3
        Label11.Text = "Menu Favorit"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(6, 124)
        Label10.Name = "Label10"
        Label10.Size = New Size(144, 20)
        Label10.TabIndex = 2
        Label10.Text = "Menu Rekomendasi"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.PowderBlue
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(12, 147)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 80)
        Label9.TabIndex = 1
        Label9.Text = "Paket Keluarga (4 orang):" & vbCrLf & "- 1 Soup of the Harmony" & vbCrLf & "- 4 Main  Choice Course" & vbCrLf & "- 2 Harmony Desert "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.WhiteSmoke
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(22, 44)
        Label8.Name = "Label8"
        Label8.Size = New Size(156, 40)
        Label8.TabIndex = 0
        Label8.Text = "Meja               : Meja 5" & vbCrLf & "Jumlah Tamu : 4 orang"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label

End Class
