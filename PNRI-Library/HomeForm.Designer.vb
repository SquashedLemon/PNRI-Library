<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnRecords = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_exit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCatalog = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAddMaterial = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAddBorrower = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnReturnMaterial = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnBorrowMaterial = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnConfig = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAddStaff = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.settings = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_FormName = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PNRI-Library"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'BtnRecords
        '
        Me.BtnRecords.Activecolor = System.Drawing.Color.Blue
        Me.BtnRecords.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRecords.BorderRadius = 0
        Me.BtnRecords.ButtonText = "        Records"
        Me.BtnRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRecords.DisabledColor = System.Drawing.Color.Gray
        Me.BtnRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRecords.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnRecords.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnRecords.Iconimage = Nothing
        Me.BtnRecords.Iconimage_right = Nothing
        Me.BtnRecords.Iconimage_right_Selected = Nothing
        Me.BtnRecords.Iconimage_Selected = Nothing
        Me.BtnRecords.IconMarginLeft = 0
        Me.BtnRecords.IconMarginRight = 0
        Me.BtnRecords.IconRightVisible = True
        Me.BtnRecords.IconRightZoom = 0R
        Me.BtnRecords.IconVisible = True
        Me.BtnRecords.IconZoom = 90.0R
        Me.BtnRecords.IsTab = False
        Me.BtnRecords.Location = New System.Drawing.Point(0, 291)
        Me.BtnRecords.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnRecords.Name = "BtnRecords"
        Me.BtnRecords.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnRecords.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnRecords.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnRecords.selected = False
        Me.BtnRecords.Size = New System.Drawing.Size(294, 47)
        Me.BtnRecords.TabIndex = 19
        Me.BtnRecords.Text = "        Records"
        Me.BtnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRecords.Textcolor = System.Drawing.Color.White
        Me.BtnRecords.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Activecolor = System.Drawing.Color.Blue
        Me.BtnDashboard.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDashboard.BorderRadius = 0
        Me.BtnDashboard.ButtonText = "        Dashboard"
        Me.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDashboard.DisabledColor = System.Drawing.Color.Gray
        Me.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashboard.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnDashboard.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnDashboard.Iconimage = Nothing
        Me.BtnDashboard.Iconimage_right = Nothing
        Me.BtnDashboard.Iconimage_right_Selected = Nothing
        Me.BtnDashboard.Iconimage_Selected = Nothing
        Me.BtnDashboard.IconMarginLeft = 0
        Me.BtnDashboard.IconMarginRight = 0
        Me.BtnDashboard.IconRightVisible = True
        Me.BtnDashboard.IconRightZoom = 0R
        Me.BtnDashboard.IconVisible = True
        Me.BtnDashboard.IconZoom = 90.0R
        Me.BtnDashboard.IsTab = False
        Me.BtnDashboard.Location = New System.Drawing.Point(0, 244)
        Me.BtnDashboard.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnDashboard.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnDashboard.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnDashboard.selected = False
        Me.BtnDashboard.Size = New System.Drawing.Size(294, 47)
        Me.BtnDashboard.TabIndex = 16
        Me.BtnDashboard.Text = "        Dashboard"
        Me.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.Textcolor = System.Drawing.Color.White
        Me.BtnDashboard.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_minimize.Image = CType(resources.GetObject("btn_minimize.Image"), System.Drawing.Image)
        Me.btn_minimize.ImageActive = Nothing
        Me.btn_minimize.Location = New System.Drawing.Point(1298, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(39, 37)
        Me.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_minimize.TabIndex = 16
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.Zoom = 10
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageActive = Nothing
        Me.btn_exit.Location = New System.Drawing.Point(1337, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(39, 37)
        Me.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_exit.TabIndex = 15
        Me.btn_exit.TabStop = False
        Me.btn_exit.Zoom = 10
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(294, 244)
        Me.Panel3.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnCatalog)
        Me.Panel2.Controls.Add(Me.BtnAddMaterial)
        Me.Panel2.Controls.Add(Me.BtnAddBorrower)
        Me.Panel2.Controls.Add(Me.BtnReturnMaterial)
        Me.Panel2.Controls.Add(Me.BtnBorrowMaterial)
        Me.Panel2.Controls.Add(Me.BtnConfig)
        Me.Panel2.Controls.Add(Me.BtnAddStaff)
        Me.Panel2.Controls.Add(Me.BtnRecords)
        Me.Panel2.Controls.Add(Me.BtnDashboard)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 747)
        Me.Panel2.TabIndex = 17
        '
        'BtnCatalog
        '
        Me.BtnCatalog.Activecolor = System.Drawing.Color.Blue
        Me.BtnCatalog.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCatalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCatalog.BorderRadius = 0
        Me.BtnCatalog.ButtonText = "        Catalog"
        Me.BtnCatalog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCatalog.DisabledColor = System.Drawing.Color.Gray
        Me.BtnCatalog.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCatalog.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnCatalog.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnCatalog.Iconimage = Nothing
        Me.BtnCatalog.Iconimage_right = Nothing
        Me.BtnCatalog.Iconimage_right_Selected = Nothing
        Me.BtnCatalog.Iconimage_Selected = Nothing
        Me.BtnCatalog.IconMarginLeft = 0
        Me.BtnCatalog.IconMarginRight = 0
        Me.BtnCatalog.IconRightVisible = True
        Me.BtnCatalog.IconRightZoom = 0R
        Me.BtnCatalog.IconVisible = True
        Me.BtnCatalog.IconZoom = 90.0R
        Me.BtnCatalog.IsTab = False
        Me.BtnCatalog.Location = New System.Drawing.Point(0, 620)
        Me.BtnCatalog.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnCatalog.Name = "BtnCatalog"
        Me.BtnCatalog.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnCatalog.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnCatalog.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnCatalog.selected = False
        Me.BtnCatalog.Size = New System.Drawing.Size(294, 47)
        Me.BtnCatalog.TabIndex = 26
        Me.BtnCatalog.Text = "        Catalog"
        Me.BtnCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCatalog.Textcolor = System.Drawing.Color.White
        Me.BtnCatalog.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnAddMaterial
        '
        Me.BtnAddMaterial.Activecolor = System.Drawing.Color.Blue
        Me.BtnAddMaterial.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAddMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddMaterial.BorderRadius = 0
        Me.BtnAddMaterial.ButtonText = "        Add Material"
        Me.BtnAddMaterial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddMaterial.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAddMaterial.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAddMaterial.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnAddMaterial.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAddMaterial.Iconimage = Nothing
        Me.BtnAddMaterial.Iconimage_right = Nothing
        Me.BtnAddMaterial.Iconimage_right_Selected = Nothing
        Me.BtnAddMaterial.Iconimage_Selected = Nothing
        Me.BtnAddMaterial.IconMarginLeft = 0
        Me.BtnAddMaterial.IconMarginRight = 0
        Me.BtnAddMaterial.IconRightVisible = True
        Me.BtnAddMaterial.IconRightZoom = 0R
        Me.BtnAddMaterial.IconVisible = True
        Me.BtnAddMaterial.IconZoom = 90.0R
        Me.BtnAddMaterial.IsTab = False
        Me.BtnAddMaterial.Location = New System.Drawing.Point(0, 573)
        Me.BtnAddMaterial.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnAddMaterial.Name = "BtnAddMaterial"
        Me.BtnAddMaterial.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnAddMaterial.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnAddMaterial.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAddMaterial.selected = False
        Me.BtnAddMaterial.Size = New System.Drawing.Size(294, 47)
        Me.BtnAddMaterial.TabIndex = 25
        Me.BtnAddMaterial.Text = "        Add Material"
        Me.BtnAddMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddMaterial.Textcolor = System.Drawing.Color.White
        Me.BtnAddMaterial.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnAddBorrower
        '
        Me.BtnAddBorrower.Activecolor = System.Drawing.Color.Blue
        Me.BtnAddBorrower.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAddBorrower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddBorrower.BorderRadius = 0
        Me.BtnAddBorrower.ButtonText = "        Add Borrower"
        Me.BtnAddBorrower.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddBorrower.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAddBorrower.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAddBorrower.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnAddBorrower.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAddBorrower.Iconimage = Nothing
        Me.BtnAddBorrower.Iconimage_right = Nothing
        Me.BtnAddBorrower.Iconimage_right_Selected = Nothing
        Me.BtnAddBorrower.Iconimage_Selected = Nothing
        Me.BtnAddBorrower.IconMarginLeft = 0
        Me.BtnAddBorrower.IconMarginRight = 0
        Me.BtnAddBorrower.IconRightVisible = True
        Me.BtnAddBorrower.IconRightZoom = 0R
        Me.BtnAddBorrower.IconVisible = True
        Me.BtnAddBorrower.IconZoom = 90.0R
        Me.BtnAddBorrower.IsTab = False
        Me.BtnAddBorrower.Location = New System.Drawing.Point(0, 526)
        Me.BtnAddBorrower.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnAddBorrower.Name = "BtnAddBorrower"
        Me.BtnAddBorrower.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnAddBorrower.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnAddBorrower.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAddBorrower.selected = False
        Me.BtnAddBorrower.Size = New System.Drawing.Size(294, 47)
        Me.BtnAddBorrower.TabIndex = 24
        Me.BtnAddBorrower.Text = "        Add Borrower"
        Me.BtnAddBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddBorrower.Textcolor = System.Drawing.Color.White
        Me.BtnAddBorrower.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnReturnMaterial
        '
        Me.BtnReturnMaterial.Activecolor = System.Drawing.Color.Blue
        Me.BtnReturnMaterial.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnReturnMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReturnMaterial.BorderRadius = 0
        Me.BtnReturnMaterial.ButtonText = "        Return Material"
        Me.BtnReturnMaterial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReturnMaterial.DisabledColor = System.Drawing.Color.Gray
        Me.BtnReturnMaterial.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReturnMaterial.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnReturnMaterial.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnReturnMaterial.Iconimage = Nothing
        Me.BtnReturnMaterial.Iconimage_right = Nothing
        Me.BtnReturnMaterial.Iconimage_right_Selected = Nothing
        Me.BtnReturnMaterial.Iconimage_Selected = Nothing
        Me.BtnReturnMaterial.IconMarginLeft = 0
        Me.BtnReturnMaterial.IconMarginRight = 0
        Me.BtnReturnMaterial.IconRightVisible = True
        Me.BtnReturnMaterial.IconRightZoom = 0R
        Me.BtnReturnMaterial.IconVisible = True
        Me.BtnReturnMaterial.IconZoom = 90.0R
        Me.BtnReturnMaterial.IsTab = False
        Me.BtnReturnMaterial.Location = New System.Drawing.Point(0, 479)
        Me.BtnReturnMaterial.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnReturnMaterial.Name = "BtnReturnMaterial"
        Me.BtnReturnMaterial.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnReturnMaterial.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnReturnMaterial.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnReturnMaterial.selected = False
        Me.BtnReturnMaterial.Size = New System.Drawing.Size(294, 47)
        Me.BtnReturnMaterial.TabIndex = 23
        Me.BtnReturnMaterial.Text = "        Return Material"
        Me.BtnReturnMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReturnMaterial.Textcolor = System.Drawing.Color.White
        Me.BtnReturnMaterial.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnBorrowMaterial
        '
        Me.BtnBorrowMaterial.Activecolor = System.Drawing.Color.Blue
        Me.BtnBorrowMaterial.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnBorrowMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrowMaterial.BorderRadius = 0
        Me.BtnBorrowMaterial.ButtonText = "        Borrow Material"
        Me.BtnBorrowMaterial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBorrowMaterial.DisabledColor = System.Drawing.Color.Gray
        Me.BtnBorrowMaterial.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBorrowMaterial.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnBorrowMaterial.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnBorrowMaterial.Iconimage = Nothing
        Me.BtnBorrowMaterial.Iconimage_right = Nothing
        Me.BtnBorrowMaterial.Iconimage_right_Selected = Nothing
        Me.BtnBorrowMaterial.Iconimage_Selected = Nothing
        Me.BtnBorrowMaterial.IconMarginLeft = 0
        Me.BtnBorrowMaterial.IconMarginRight = 0
        Me.BtnBorrowMaterial.IconRightVisible = True
        Me.BtnBorrowMaterial.IconRightZoom = 0R
        Me.BtnBorrowMaterial.IconVisible = True
        Me.BtnBorrowMaterial.IconZoom = 90.0R
        Me.BtnBorrowMaterial.IsTab = False
        Me.BtnBorrowMaterial.Location = New System.Drawing.Point(0, 432)
        Me.BtnBorrowMaterial.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnBorrowMaterial.Name = "BtnBorrowMaterial"
        Me.BtnBorrowMaterial.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnBorrowMaterial.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnBorrowMaterial.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnBorrowMaterial.selected = False
        Me.BtnBorrowMaterial.Size = New System.Drawing.Size(294, 47)
        Me.BtnBorrowMaterial.TabIndex = 22
        Me.BtnBorrowMaterial.Text = "        Borrow Material"
        Me.BtnBorrowMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrowMaterial.Textcolor = System.Drawing.Color.White
        Me.BtnBorrowMaterial.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnConfig
        '
        Me.BtnConfig.Activecolor = System.Drawing.Color.Blue
        Me.BtnConfig.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnConfig.BorderRadius = 0
        Me.BtnConfig.ButtonText = "        Config"
        Me.BtnConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfig.DisabledColor = System.Drawing.Color.Gray
        Me.BtnConfig.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConfig.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnConfig.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnConfig.Iconimage = Nothing
        Me.BtnConfig.Iconimage_right = Nothing
        Me.BtnConfig.Iconimage_right_Selected = Nothing
        Me.BtnConfig.Iconimage_Selected = Nothing
        Me.BtnConfig.IconMarginLeft = 0
        Me.BtnConfig.IconMarginRight = 0
        Me.BtnConfig.IconRightVisible = True
        Me.BtnConfig.IconRightZoom = 0R
        Me.BtnConfig.IconVisible = True
        Me.BtnConfig.IconZoom = 90.0R
        Me.BtnConfig.IsTab = False
        Me.BtnConfig.Location = New System.Drawing.Point(0, 385)
        Me.BtnConfig.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnConfig.Name = "BtnConfig"
        Me.BtnConfig.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnConfig.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnConfig.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnConfig.selected = False
        Me.BtnConfig.Size = New System.Drawing.Size(294, 47)
        Me.BtnConfig.TabIndex = 21
        Me.BtnConfig.Text = "        Config"
        Me.BtnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfig.Textcolor = System.Drawing.Color.White
        Me.BtnConfig.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnAddStaff
        '
        Me.BtnAddStaff.Activecolor = System.Drawing.Color.Blue
        Me.BtnAddStaff.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAddStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddStaff.BorderRadius = 0
        Me.BtnAddStaff.ButtonText = "        Add Staff"
        Me.BtnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddStaff.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAddStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAddStaff.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnAddStaff.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAddStaff.Iconimage = Nothing
        Me.BtnAddStaff.Iconimage_right = Nothing
        Me.BtnAddStaff.Iconimage_right_Selected = Nothing
        Me.BtnAddStaff.Iconimage_Selected = Nothing
        Me.BtnAddStaff.IconMarginLeft = 0
        Me.BtnAddStaff.IconMarginRight = 0
        Me.BtnAddStaff.IconRightVisible = True
        Me.BtnAddStaff.IconRightZoom = 0R
        Me.BtnAddStaff.IconVisible = True
        Me.BtnAddStaff.IconZoom = 90.0R
        Me.BtnAddStaff.IsTab = False
        Me.BtnAddStaff.Location = New System.Drawing.Point(0, 338)
        Me.BtnAddStaff.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnAddStaff.Name = "BtnAddStaff"
        Me.BtnAddStaff.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnAddStaff.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnAddStaff.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAddStaff.selected = False
        Me.BtnAddStaff.Size = New System.Drawing.Size(294, 47)
        Me.BtnAddStaff.TabIndex = 20
        Me.BtnAddStaff.Text = "        Add Staff"
        Me.BtnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddStaff.Textcolor = System.Drawing.Color.White
        Me.BtnAddStaff.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.btn_minimize)
        Me.Panel4.Controls.Add(Me.btn_exit)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1378, 39)
        Me.Panel4.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1380, 788)
        Me.Panel1.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(306, 118)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1072, 668)
        Me.Panel7.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Label7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Label4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Label5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Label3"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(296, 118)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(10, 668)
        Me.BunifuSeparator1.TabIndex = 26
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.settings)
        Me.Panel5.Controls.Add(Me.BunifuImageButton1)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.lbl_FormName)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(296, 39)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1082, 79)
        Me.Panel5.TabIndex = 25
        '
        'settings
        '
        Me.settings.BackColor = System.Drawing.Color.SeaGreen
        Me.settings.Image = CType(resources.GetObject("settings.Image"), System.Drawing.Image)
        Me.settings.ImageActive = Nothing
        Me.settings.Location = New System.Drawing.Point(915, 14)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(60, 60)
        Me.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.settings.TabIndex = 31
        Me.settings.TabStop = False
        Me.settings.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(981, 14)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(60, 60)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 27
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(79, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 77)
        Me.Panel6.TabIndex = 29
        '
        'lbl_FormName
        '
        Me.lbl_FormName.AutoSize = True
        Me.lbl_FormName.Font = New System.Drawing.Font("Century Gothic", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FormName.ForeColor = System.Drawing.Color.White
        Me.lbl_FormName.Location = New System.Drawing.Point(85, 21)
        Me.lbl_FormName.Name = "lbl_FormName"
        Me.lbl_FormName.Size = New System.Drawing.Size(177, 34)
        Me.lbl_FormName.TabIndex = 20
        Me.lbl_FormName.Text = "PNRI-Library"
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 788)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_exit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnRecords As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btn_exit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_FormName As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnConfig As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnAddStaff As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents settings As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnAddMaterial As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnAddBorrower As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnReturnMaterial As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnBorrowMaterial As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnCatalog As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
End Class
