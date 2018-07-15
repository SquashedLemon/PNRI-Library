<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBorrower
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
        Me.BtnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBorrowerID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtCity = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtBarangay = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DgvBorrowers = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtContact = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAddress = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFirstname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtLastname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbDivision = New Bunifu.Framework.UI.BunifuDropdown()
        Me.CmbSection = New Bunifu.Framework.UI.BunifuDropdown()
        CType(Me.DgvBorrowers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Activecolor = System.Drawing.Color.Blue
        Me.BtnAdd.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdd.BorderRadius = 5
        Me.BtnAdd.ButtonText = "Add Staff"
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.DisabledColor = System.Drawing.Color.Gray
        Me.BtnAdd.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnAdd.Iconimage = Nothing
        Me.BtnAdd.Iconimage_right = Nothing
        Me.BtnAdd.Iconimage_right_Selected = Nothing
        Me.BtnAdd.Iconimage_Selected = Nothing
        Me.BtnAdd.IconMarginLeft = 0
        Me.BtnAdd.IconMarginRight = 0
        Me.BtnAdd.IconRightVisible = True
        Me.BtnAdd.IconRightZoom = 0R
        Me.BtnAdd.IconVisible = True
        Me.BtnAdd.IconZoom = 90.0R
        Me.BtnAdd.IsTab = False
        Me.BtnAdd.Location = New System.Drawing.Point(683, 602)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnAdd.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAdd.selected = False
        Me.BtnAdd.Size = New System.Drawing.Size(112, 47)
        Me.BtnAdd.TabIndex = 149
        Me.BtnAdd.Text = "Add Staff"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Textcolor = System.Drawing.Color.White
        Me.BtnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Activecolor = System.Drawing.Color.Blue
        Me.BtnUpdate.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.BorderRadius = 5
        Me.BtnUpdate.ButtonText = "Update"
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.DisabledColor = System.Drawing.Color.Gray
        Me.BtnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnUpdate.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnUpdate.Iconimage = Nothing
        Me.BtnUpdate.Iconimage_right = Nothing
        Me.BtnUpdate.Iconimage_right_Selected = Nothing
        Me.BtnUpdate.Iconimage_Selected = Nothing
        Me.BtnUpdate.IconMarginLeft = 0
        Me.BtnUpdate.IconMarginRight = 0
        Me.BtnUpdate.IconRightVisible = True
        Me.BtnUpdate.IconRightZoom = 0R
        Me.BtnUpdate.IconVisible = True
        Me.BtnUpdate.IconZoom = 90.0R
        Me.BtnUpdate.IsTab = False
        Me.BtnUpdate.Location = New System.Drawing.Point(805, 602)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdate.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnUpdate.selected = False
        Me.BtnUpdate.Size = New System.Drawing.Size(112, 47)
        Me.BtnUpdate.TabIndex = 148
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnUpdate.Textcolor = System.Drawing.Color.White
        Me.BtnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnCancel
        '
        Me.BtnCancel.Activecolor = System.Drawing.Color.Blue
        Me.BtnCancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.BorderRadius = 5
        Me.BtnCancel.ButtonText = "Cancel"
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.DisabledColor = System.Drawing.Color.Gray
        Me.BtnCancel.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnCancel.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnCancel.Iconimage = Nothing
        Me.BtnCancel.Iconimage_right = Nothing
        Me.BtnCancel.Iconimage_right_Selected = Nothing
        Me.BtnCancel.Iconimage_Selected = Nothing
        Me.BtnCancel.IconMarginLeft = 0
        Me.BtnCancel.IconMarginRight = 0
        Me.BtnCancel.IconRightVisible = True
        Me.BtnCancel.IconRightZoom = 0R
        Me.BtnCancel.IconVisible = True
        Me.BtnCancel.IconZoom = 90.0R
        Me.BtnCancel.IsTab = False
        Me.BtnCancel.Location = New System.Drawing.Point(927, 602)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnCancel.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnCancel.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnCancel.selected = False
        Me.BtnCancel.Size = New System.Drawing.Size(112, 47)
        Me.BtnCancel.TabIndex = 147
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnCancel.Textcolor = System.Drawing.Color.White
        Me.BtnCancel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label9.Location = New System.Drawing.Point(627, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 21)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Borrower ID:"
        '
        'TxtBorrowerID
        '
        Me.TxtBorrowerID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBorrowerID.Enabled = False
        Me.TxtBorrowerID.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtBorrowerID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBorrowerID.HintForeColor = System.Drawing.Color.Empty
        Me.TxtBorrowerID.HintText = ""
        Me.TxtBorrowerID.isPassword = False
        Me.TxtBorrowerID.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtBorrowerID.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtBorrowerID.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtBorrowerID.LineThickness = 4
        Me.TxtBorrowerID.Location = New System.Drawing.Point(745, 49)
        Me.TxtBorrowerID.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtBorrowerID.Name = "TxtBorrowerID"
        Me.TxtBorrowerID.Size = New System.Drawing.Size(294, 41)
        Me.TxtBorrowerID.TabIndex = 110
        Me.TxtBorrowerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtCity
        '
        Me.TxtCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCity.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtCity.HintForeColor = System.Drawing.Color.Empty
        Me.TxtCity.HintText = ""
        Me.TxtCity.isPassword = False
        Me.TxtCity.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtCity.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtCity.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtCity.LineThickness = 4
        Me.TxtCity.Location = New System.Drawing.Point(835, 336)
        Me.TxtCity.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(205, 41)
        Me.TxtCity.TabIndex = 109
        Me.TxtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtBarangay
        '
        Me.TxtBarangay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBarangay.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtBarangay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBarangay.HintForeColor = System.Drawing.Color.Empty
        Me.TxtBarangay.HintText = ""
        Me.TxtBarangay.isPassword = False
        Me.TxtBarangay.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtBarangay.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtBarangay.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtBarangay.LineThickness = 4
        Me.TxtBarangay.Location = New System.Drawing.Point(576, 336)
        Me.TxtBarangay.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtBarangay.Name = "TxtBarangay"
        Me.TxtBarangay.Size = New System.Drawing.Size(245, 41)
        Me.TxtBarangay.TabIndex = 108
        Me.TxtBarangay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label16.Location = New System.Drawing.Point(38, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Search:"
        '
        'TxtSearch
        '
        Me.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSearch.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtSearch.HintForeColor = System.Drawing.Color.Empty
        Me.TxtSearch.HintText = ""
        Me.TxtSearch.isPassword = False
        Me.TxtSearch.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtSearch.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtSearch.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtSearch.LineThickness = 4
        Me.TxtSearch.Location = New System.Drawing.Point(118, 28)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(427, 41)
        Me.TxtSearch.TabIndex = 106
        Me.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DgvBorrowers
        '
        Me.DgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBorrowers.Location = New System.Drawing.Point(42, 78)
        Me.DgvBorrowers.Name = "DgvBorrowers"
        Me.DgvBorrowers.Size = New System.Drawing.Size(503, 578)
        Me.DgvBorrowers.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(567, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(206, 25)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Register a Borrower"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(551, 19)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(10, 637)
        Me.BunifuSeparator1.TabIndex = 103
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label7.Location = New System.Drawing.Point(571, 525)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 21)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Email:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEmail.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtEmail.HintForeColor = System.Drawing.Color.Empty
        Me.TxtEmail.HintText = ""
        Me.TxtEmail.isPassword = False
        Me.TxtEmail.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtEmail.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtEmail.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtEmail.LineThickness = 4
        Me.TxtEmail.Location = New System.Drawing.Point(569, 551)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(467, 41)
        Me.TxtEmail.TabIndex = 101
        Me.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label6.Location = New System.Drawing.Point(570, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 21)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Contact Number:"
        '
        'TxtContact
        '
        Me.TxtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtContact.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtContact.HintForeColor = System.Drawing.Color.Empty
        Me.TxtContact.HintText = ""
        Me.TxtContact.isPassword = False
        Me.TxtContact.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtContact.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtContact.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtContact.LineThickness = 4
        Me.TxtContact.Location = New System.Drawing.Point(574, 408)
        Me.TxtContact.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(466, 41)
        Me.TxtContact.TabIndex = 99
        Me.TxtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label5.Location = New System.Drawing.Point(831, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 21)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "City:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label4.Location = New System.Drawing.Point(584, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Barangay:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label3.Location = New System.Drawing.Point(572, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Home Address:"
        '
        'TxtAddress
        '
        Me.TxtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAddress.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAddress.HintForeColor = System.Drawing.Color.Empty
        Me.TxtAddress.HintText = ""
        Me.TxtAddress.isPassword = False
        Me.TxtAddress.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtAddress.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtAddress.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtAddress.LineThickness = 4
        Me.TxtAddress.Location = New System.Drawing.Point(574, 259)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(465, 41)
        Me.TxtAddress.TabIndex = 95
        Me.TxtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label2.Location = New System.Drawing.Point(574, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 21)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label1.Location = New System.Drawing.Point(574, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "First Name:"
        '
        'TxtFirstname
        '
        Me.TxtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFirstname.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtFirstname.HintForeColor = System.Drawing.Color.Empty
        Me.TxtFirstname.HintText = ""
        Me.TxtFirstname.isPassword = False
        Me.TxtFirstname.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtFirstname.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtFirstname.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtFirstname.LineThickness = 4
        Me.TxtFirstname.Location = New System.Drawing.Point(576, 115)
        Me.TxtFirstname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.Size = New System.Drawing.Size(463, 41)
        Me.TxtFirstname.TabIndex = 91
        Me.TxtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtLastname
        '
        Me.TxtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtLastname.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtLastname.HintForeColor = System.Drawing.Color.Empty
        Me.TxtLastname.HintText = ""
        Me.TxtLastname.isPassword = False
        Me.TxtLastname.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtLastname.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtLastname.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtLastname.LineThickness = 4
        Me.TxtLastname.Location = New System.Drawing.Point(576, 187)
        Me.TxtLastname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.Size = New System.Drawing.Size(463, 41)
        Me.TxtLastname.TabIndex = 152
        Me.TxtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label11.Location = New System.Drawing.Point(570, 454)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 21)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "Division"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label12.Location = New System.Drawing.Point(842, 454)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 21)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "Section:"
        '
        'CmbDivision
        '
        Me.CmbDivision.BackColor = System.Drawing.Color.Transparent
        Me.CmbDivision.BorderRadius = 3
        Me.CmbDivision.DisabledColor = System.Drawing.Color.Gray
        Me.CmbDivision.ForeColor = System.Drawing.Color.White
        Me.CmbDivision.Items = New String(-1) {}
        Me.CmbDivision.Location = New System.Drawing.Point(574, 478)
        Me.CmbDivision.Name = "CmbDivision"
        Me.CmbDivision.NomalColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.CmbDivision.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.CmbDivision.selectedIndex = -1
        Me.CmbDivision.Size = New System.Drawing.Size(247, 39)
        Me.CmbDivision.TabIndex = 157
        '
        'CmbSection
        '
        Me.CmbSection.BackColor = System.Drawing.Color.Transparent
        Me.CmbSection.BorderRadius = 3
        Me.CmbSection.DisabledColor = System.Drawing.Color.Gray
        Me.CmbSection.ForeColor = System.Drawing.Color.White
        Me.CmbSection.Items = New String(-1) {}
        Me.CmbSection.Location = New System.Drawing.Point(849, 478)
        Me.CmbSection.Name = "CmbSection"
        Me.CmbSection.NomalColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.CmbSection.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.CmbSection.selectedIndex = -1
        Me.CmbSection.Size = New System.Drawing.Size(191, 39)
        Me.CmbSection.TabIndex = 158
        '
        'AddBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 668)
        Me.Controls.Add(Me.CmbSection)
        Me.Controls.Add(Me.CmbDivision)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtLastname)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtBorrowerID)
        Me.Controls.Add(Me.TxtCity)
        Me.Controls.Add(Me.TxtBarangay)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.DgvBorrowers)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtContact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFirstname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddBorrower"
        Me.Text = "AddBorrower"
        CType(Me.DgvBorrowers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtBorrowerID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtCity As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtBarangay As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DgvBorrowers As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtContact As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAddress As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFirstname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtLastname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbDivision As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents CmbSection As Bunifu.Framework.UI.BunifuDropdown
End Class
