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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusDimension = New ToolStripStatusLabel()
        ToolStripStatusBits = New ToolStripStatusLabel()
        ToolStripStatusResolution = New ToolStripStatusLabel()
        ToolStripStatusRawFormat = New ToolStripStatusLabel()
        ImageList1 = New ImageList(components)
        ToolTip1 = New ToolTip(components)
        tvDrive = New TreeView()
        lvImage = New ListView()
        chName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chFileSize = New ColumnHeader()
        chLastModified = New ColumnHeader()
        chLastAccessed = New ColumnHeader()
        chCreatedDate = New ColumnHeader()
        chAttributes = New ColumnHeader()
        PictureBox1 = New PictureBox()
        SplitContainerUtama = New SplitContainer()
        SplitContainerBawah = New SplitContainer()
        SplitContainerBawah2 = New SplitContainer()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        PropertyGrid1 = New PropertyGrid()
        TabPage2 = New TabPage()
        lvExif = New ListView()
        chProperty = New ColumnHeader()
        chValue = New ColumnHeader()
        StatusStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainerUtama, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerUtama.Panel1.SuspendLayout()
        SplitContainerUtama.Panel2.SuspendLayout()
        SplitContainerUtama.SuspendLayout()
        CType(SplitContainerBawah, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerBawah.Panel1.SuspendLayout()
        SplitContainerBawah.Panel2.SuspendLayout()
        SplitContainerBawah.SuspendLayout()
        CType(SplitContainerBawah2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerBawah2.Panel1.SuspendLayout()
        SplitContainerBawah2.Panel2.SuspendLayout()
        SplitContainerBawah2.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusDimension, ToolStripStatusBits, ToolStripStatusResolution, ToolStripStatusRawFormat})
        StatusStrip1.Location = New Point(0, 628)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1258, 36)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(64, 29)
        ToolStripStatusReady.Text = "Ready."
        ' 
        ' ToolStripStatusDimension
        ' 
        ToolStripStatusDimension.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusDimension.BorderStyle = Border3DStyle.Etched
        ToolStripStatusDimension.Name = "ToolStripStatusDimension"
        ToolStripStatusDimension.Size = New Size(101, 29)
        ToolStripStatusDimension.Text = "Dimension"
        ' 
        ' ToolStripStatusBits
        ' 
        ToolStripStatusBits.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusBits.BorderStyle = Border3DStyle.Etched
        ToolStripStatusBits.Name = "ToolStripStatusBits"
        ToolStripStatusBits.Size = New Size(96, 29)
        ToolStripStatusBits.Text = "No of bits"
        ' 
        ' ToolStripStatusResolution
        ' 
        ToolStripStatusResolution.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusResolution.BorderStyle = Border3DStyle.Etched
        ToolStripStatusResolution.Name = "ToolStripStatusResolution"
        ToolStripStatusResolution.Size = New Size(99, 29)
        ToolStripStatusResolution.Text = "Resolution"
        ' 
        ' ToolStripStatusRawFormat
        ' 
        ToolStripStatusRawFormat.BorderSides = ToolStripStatusLabelBorderSides.Left
        ToolStripStatusRawFormat.BorderStyle = Border3DStyle.Etched
        ToolStripStatusRawFormat.Name = "ToolStripStatusRawFormat"
        ToolStripStatusRawFormat.Size = New Size(111, 29)
        ToolStripStatusRawFormat.Text = "Raw Format"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "6556720_eye_eyeball_lens_picture_view_icon.ico")
        ImageList1.Images.SetKeyName(1, "6556720_eye_eyeball_lens_picture_view_icon.png")
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "ImageViewer Tip:"
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(0, 0)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(337, 628)
        tvDrive.TabIndex = 0
        ToolTip1.SetToolTip(tvDrive, "Please select drive/folder that contain one or more images")
        ' 
        ' lvImage
        ' 
        lvImage.Columns.AddRange(New ColumnHeader() {chName, chExtension, chFileSize, chLastModified, chLastAccessed, chCreatedDate, chAttributes})
        lvImage.GridLines = True
        lvImage.Location = New Point(0, 0)
        lvImage.Name = "lvImage"
        lvImage.Size = New Size(917, 358)
        lvImage.SmallImageList = ImageList1
        lvImage.TabIndex = 0
        ToolTip1.SetToolTip(lvImage, "Image file(s)")
        lvImage.UseCompatibleStateImageBehavior = False
        lvImage.View = View.Details
        ' 
        ' chName
        ' 
        chName.Text = "Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chFileSize
        ' 
        chFileSize.Text = "File Size"
        ' 
        ' chLastModified
        ' 
        chLastModified.Text = "Modified Date"
        ' 
        ' chLastAccessed
        ' 
        chLastAccessed.Text = "Last Accessed"
        ' 
        ' chCreatedDate
        ' 
        chCreatedDate.Text = "Created Date"
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = "Attributes"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(-2, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(610, 264)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ToolTip1.SetToolTip(PictureBox1, "Double click to view this image in auto size mode!")
        ' 
        ' SplitContainerUtama
        ' 
        SplitContainerUtama.Dock = DockStyle.Fill
        SplitContainerUtama.Location = New Point(0, 0)
        SplitContainerUtama.Name = "SplitContainerUtama"
        ' 
        ' SplitContainerUtama.Panel1
        ' 
        SplitContainerUtama.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainerUtama.Panel2
        ' 
        SplitContainerUtama.Panel2.Controls.Add(SplitContainerBawah)
        SplitContainerUtama.Size = New Size(1258, 628)
        SplitContainerUtama.SplitterDistance = 337
        SplitContainerUtama.TabIndex = 3
        ' 
        ' SplitContainerBawah
        ' 
        SplitContainerBawah.Dock = DockStyle.Fill
        SplitContainerBawah.Location = New Point(0, 0)
        SplitContainerBawah.Name = "SplitContainerBawah"
        SplitContainerBawah.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainerBawah.Panel1
        ' 
        SplitContainerBawah.Panel1.Controls.Add(lvImage)
        ' 
        ' SplitContainerBawah.Panel2
        ' 
        SplitContainerBawah.Panel2.Controls.Add(SplitContainerBawah2)
        SplitContainerBawah.Size = New Size(917, 628)
        SplitContainerBawah.SplitterDistance = 360
        SplitContainerBawah.TabIndex = 0
        ' 
        ' SplitContainerBawah2
        ' 
        SplitContainerBawah2.Dock = DockStyle.Fill
        SplitContainerBawah2.Location = New Point(0, 0)
        SplitContainerBawah2.Name = "SplitContainerBawah2"
        ' 
        ' SplitContainerBawah2.Panel1
        ' 
        SplitContainerBawah2.Panel1.Controls.Add(TabControl1)
        ' 
        ' SplitContainerBawah2.Panel2
        ' 
        SplitContainerBawah2.Panel2.Controls.Add(PictureBox1)
        SplitContainerBawah2.Size = New Size(917, 264)
        SplitContainerBawah2.SplitterDistance = 305
        SplitContainerBawah2.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(305, 264)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(PropertyGrid1)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(297, 226)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Image Properties"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' PropertyGrid1
        ' 
        PropertyGrid1.Dock = DockStyle.Fill
        PropertyGrid1.Location = New Point(3, 3)
        PropertyGrid1.Name = "PropertyGrid1"
        PropertyGrid1.Size = New Size(291, 220)
        PropertyGrid1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lvExif)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(297, 226)
        TabPage2.TabIndex = 1
        TabPage2.Text = "EXIF Metadata"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lvExif
        ' 
        lvExif.Columns.AddRange(New ColumnHeader() {chProperty, chValue})
        lvExif.GridLines = True
        lvExif.Location = New Point(0, 0)
        lvExif.Name = "lvExif"
        lvExif.Size = New Size(292, 224)
        lvExif.TabIndex = 0
        lvExif.UseCompatibleStateImageBehavior = False
        lvExif.View = View.Details
        ' 
        ' chProperty
        ' 
        chProperty.Text = "Property"
        ' 
        ' chValue
        ' 
        chValue.Text = "Value"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1258, 664)
        Controls.Add(SplitContainerUtama)
        Controls.Add(StatusStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Image Viewer"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerUtama.Panel1.ResumeLayout(False)
        SplitContainerUtama.Panel2.ResumeLayout(False)
        CType(SplitContainerUtama, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerUtama.ResumeLayout(False)
        SplitContainerBawah.Panel1.ResumeLayout(False)
        SplitContainerBawah.Panel2.ResumeLayout(False)
        CType(SplitContainerBawah, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerBawah.ResumeLayout(False)
        SplitContainerBawah2.Panel1.ResumeLayout(False)
        SplitContainerBawah2.Panel2.ResumeLayout(False)
        CType(SplitContainerBawah2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerBawah2.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusDimension As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusBits As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusResolution As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusRawFormat As ToolStripStatusLabel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainerUtama As SplitContainer
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents SplitContainerBawah As SplitContainer
    Friend WithEvents SplitContainerBawah2 As SplitContainer
    Friend WithEvents lvImage As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lvExif As ListView
    Friend WithEvents chProperty As ColumnHeader
    Friend WithEvents chValue As ColumnHeader
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents PictureBox1 As PictureBox

End Class
