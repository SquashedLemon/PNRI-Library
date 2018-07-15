<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Staff
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
    Public components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFirstname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtLastname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DgvStaffs = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStaff = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkStaffAdd = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.chkStaffBorrow = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkStaffReturn = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkAdminReturn = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.chkAdminBorrow = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.chkAdminAdd = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chkDefaultView = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.chkDefaultCatalog = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.chkDefaultRecords = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.chkAdminDashboard = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.chkAdminConfig = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.chkAdminAddStaff = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.chkAdminView = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.chkAdminCatalog = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.chkAdminRecords = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.BtnCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.DgvStaffs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label1.Location = New System.Drawing.Point(411, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 17
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
        Me.TxtFirstname.Location = New System.Drawing.Point(413, 180)
        Me.TxtFirstname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.Size = New System.Drawing.Size(278, 41)
        Me.TxtFirstname.TabIndex = 16
        Me.TxtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label2.Location = New System.Drawing.Point(411, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Last Name:"
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
        Me.TxtLastname.Location = New System.Drawing.Point(413, 252)
        Me.TxtLastname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtLastname.Name = "TxtLastname"
        Me.TxtLastname.Size = New System.Drawing.Size(278, 41)
        Me.TxtLastname.TabIndex = 18
        Me.TxtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsername.HintForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HintText = ""
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.txtUsername.LineIdleColor = System.Drawing.Color.Gray
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.txtUsername.LineThickness = 4
        Me.txtUsername.Location = New System.Drawing.Point(413, 324)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(278, 41)
        Me.txtUsername.TabIndex = 20
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label3.Location = New System.Drawing.Point(411, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label4.Location = New System.Drawing.Point(411, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Password:"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(395, 98)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(11, 559)
        Me.BunifuSeparator1.TabIndex = 30
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(411, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 25)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Staff Information"
        '
        'DgvStaffs
        '
        Me.DgvStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvStaffs.Location = New System.Drawing.Point(12, 94)
        Me.DgvStaffs.Name = "DgvStaffs"
        Me.DgvStaffs.ReadOnly = True
        Me.DgvStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvStaffs.Size = New System.Drawing.Size(376, 563)
        Me.DgvStaffs.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label16.Location = New System.Drawing.Point(8, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 48
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
        Me.TxtSearch.Location = New System.Drawing.Point(88, 44)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(300, 41)
        Me.TxtSearch.TabIndex = 47
        Me.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Enabled = False
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtPassword.HintText = ""
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.txtPassword.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.txtPassword.LineThickness = 4
        Me.txtPassword.Location = New System.Drawing.Point(413, 396)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(278, 41)
        Me.txtPassword.TabIndex = 49
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label9.Location = New System.Drawing.Point(411, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 21)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Staff ID:"
        '
        'txtStaff
        '
        Me.txtStaff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStaff.Enabled = False
        Me.txtStaff.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.txtStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStaff.HintForeColor = System.Drawing.Color.Empty
        Me.txtStaff.HintText = ""
        Me.txtStaff.isPassword = False
        Me.txtStaff.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.txtStaff.LineIdleColor = System.Drawing.Color.Gray
        Me.txtStaff.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.txtStaff.LineThickness = 4
        Me.txtStaff.Location = New System.Drawing.Point(413, 108)
        Me.txtStaff.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtStaff.Name = "txtStaff"
        Me.txtStaff.Size = New System.Drawing.Size(278, 41)
        Me.txtStaff.TabIndex = 51
        Me.txtStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label10.Location = New System.Drawing.Point(714, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 25)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Modules"
        '
        'chkStaffAdd
        '
        Me.chkStaffAdd.AccessibleName = ""
        Me.chkStaffAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkStaffAdd.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkStaffAdd.Checked = False
        Me.chkStaffAdd.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkStaffAdd.ForeColor = System.Drawing.Color.White
        Me.chkStaffAdd.Location = New System.Drawing.Point(719, 141)
        Me.chkStaffAdd.Name = "chkStaffAdd"
        Me.chkStaffAdd.Size = New System.Drawing.Size(20, 20)
        Me.chkStaffAdd.TabIndex = 54
        '
        'chkStaffBorrow
        '
        Me.chkStaffBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkStaffBorrow.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkStaffBorrow.Checked = False
        Me.chkStaffBorrow.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkStaffBorrow.ForeColor = System.Drawing.Color.White
        Me.chkStaffBorrow.Location = New System.Drawing.Point(719, 178)
        Me.chkStaffBorrow.Name = "chkStaffBorrow"
        Me.chkStaffBorrow.Size = New System.Drawing.Size(20, 20)
        Me.chkStaffBorrow.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label11.Location = New System.Drawing.Point(745, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 21)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Add Material"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label12.Location = New System.Drawing.Point(745, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 21)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Borrow Material"
        '
        'chkStaffReturn
        '
        Me.chkStaffReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkStaffReturn.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkStaffReturn.Checked = False
        Me.chkStaffReturn.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkStaffReturn.ForeColor = System.Drawing.Color.White
        Me.chkStaffReturn.Location = New System.Drawing.Point(719, 214)
        Me.chkStaffReturn.Name = "chkStaffReturn"
        Me.chkStaffReturn.Size = New System.Drawing.Size(20, 20)
        Me.chkStaffReturn.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label13.Location = New System.Drawing.Point(745, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 21)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Return Material"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label14.Location = New System.Drawing.Point(714, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 25)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Staff"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label15.Location = New System.Drawing.Point(714, 275)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 25)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Administrator"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label17.Location = New System.Drawing.Point(745, 383)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(138, 21)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "Return Material"
        '
        'chkAdminReturn
        '
        Me.chkAdminReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminReturn.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminReturn.Checked = False
        Me.chkAdminReturn.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkAdminReturn.ForeColor = System.Drawing.Color.White
        Me.chkAdminReturn.Location = New System.Drawing.Point(719, 383)
        Me.chkAdminReturn.Name = "chkAdminReturn"
        Me.chkAdminReturn.Size = New System.Drawing.Size(20, 20)
        Me.chkAdminReturn.TabIndex = 66
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label18.Location = New System.Drawing.Point(745, 347)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 21)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Borrow Material"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label19.Location = New System.Drawing.Point(745, 310)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 21)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "Add Material"
        '
        'chkAdminBorrow
        '
        Me.chkAdminBorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminBorrow.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminBorrow.Checked = False
        Me.chkAdminBorrow.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkAdminBorrow.ForeColor = System.Drawing.Color.White
        Me.chkAdminBorrow.Location = New System.Drawing.Point(719, 347)
        Me.chkAdminBorrow.Name = "chkAdminBorrow"
        Me.chkAdminBorrow.Size = New System.Drawing.Size(20, 20)
        Me.chkAdminBorrow.TabIndex = 63
        '
        'chkAdminAdd
        '
        Me.chkAdminAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminAdd.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminAdd.Checked = False
        Me.chkAdminAdd.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkAdminAdd.ForeColor = System.Drawing.Color.White
        Me.chkAdminAdd.Location = New System.Drawing.Point(719, 310)
        Me.chkAdminAdd.Name = "chkAdminAdd"
        Me.chkAdminAdd.Size = New System.Drawing.Size(20, 20)
        Me.chkAdminAdd.TabIndex = 62
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label20.Location = New System.Drawing.Point(902, 105)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 25)
        Me.Label20.TabIndex = 68
        Me.Label20.Text = "Default"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label21.Location = New System.Drawing.Point(933, 213)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 21)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "Add Borrower"
        '
        'chkDefaultView
        '
        Me.chkDefaultView.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkDefaultView.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkDefaultView.Checked = False
        Me.chkDefaultView.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkDefaultView.ForeColor = System.Drawing.Color.White
        Me.chkDefaultView.Location = New System.Drawing.Point(907, 213)
        Me.chkDefaultView.Name = "chkDefaultView"
        Me.chkDefaultView.Size = New System.Drawing.Size(20, 20)
        Me.chkDefaultView.TabIndex = 73
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label22.Location = New System.Drawing.Point(933, 177)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 21)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "Catalog"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label23.Location = New System.Drawing.Point(933, 140)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 21)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "Records"
        '
        'chkDefaultCatalog
        '
        Me.chkDefaultCatalog.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkDefaultCatalog.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkDefaultCatalog.Checked = False
        Me.chkDefaultCatalog.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkDefaultCatalog.ForeColor = System.Drawing.Color.White
        Me.chkDefaultCatalog.Location = New System.Drawing.Point(907, 177)
        Me.chkDefaultCatalog.Name = "chkDefaultCatalog"
        Me.chkDefaultCatalog.Size = New System.Drawing.Size(20, 20)
        Me.chkDefaultCatalog.TabIndex = 70
        '
        'chkDefaultRecords
        '
        Me.chkDefaultRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkDefaultRecords.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkDefaultRecords.Checked = False
        Me.chkDefaultRecords.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkDefaultRecords.ForeColor = System.Drawing.Color.White
        Me.chkDefaultRecords.Location = New System.Drawing.Point(907, 140)
        Me.chkDefaultRecords.Name = "chkDefaultRecords"
        Me.chkDefaultRecords.Size = New System.Drawing.Size(20, 20)
        Me.chkDefaultRecords.TabIndex = 69
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label24.Location = New System.Drawing.Point(933, 417)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 21)
        Me.Label24.TabIndex = 80
        Me.Label24.Text = "Dashboard"
        '
        'chkAdminDashboard
        '
        Me.chkAdminDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminDashboard.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminDashboard.Checked = False
        Me.chkAdminDashboard.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkAdminDashboard.ForeColor = System.Drawing.Color.White
        Me.chkAdminDashboard.Location = New System.Drawing.Point(907, 417)
        Me.chkAdminDashboard.Name = "chkAdminDashboard"
        Me.chkAdminDashboard.Size = New System.Drawing.Size(20, 20)
        Me.chkAdminDashboard.TabIndex = 79
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label25.Location = New System.Drawing.Point(745, 455)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 21)
        Me.Label25.TabIndex = 78
        Me.Label25.Text = "Config"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label26.Location = New System.Drawing.Point(745, 418)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(89, 21)
        Me.Label26.TabIndex = 77
        Me.Label26.Text = "Add Staff"
        '
        'chkAdminConfig
        '
        Me.chkAdminConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminConfig.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminConfig.Checked = False
        Me.chkAdminConfig.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkAdminConfig.ForeColor = System.Drawing.Color.White
        Me.chkAdminConfig.Location = New System.Drawing.Point(719, 455)
        Me.chkAdminConfig.Name = "chkAdminConfig"
        Me.chkAdminConfig.Size = New System.Drawing.Size(20, 20)
        Me.chkAdminConfig.TabIndex = 76
        '
        'chkAdminAddStaff
        '
        Me.chkAdminAddStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminAddStaff.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminAddStaff.Checked = False
        Me.chkAdminAddStaff.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkAdminAddStaff.ForeColor = System.Drawing.Color.White
        Me.chkAdminAddStaff.Location = New System.Drawing.Point(719, 418)
        Me.chkAdminAddStaff.Name = "chkAdminAddStaff"
        Me.chkAdminAddStaff.Size = New System.Drawing.Size(20, 20)
        Me.chkAdminAddStaff.TabIndex = 75
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label27.Location = New System.Drawing.Point(933, 383)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(124, 21)
        Me.Label27.TabIndex = 87
        Me.Label27.Text = "Add Borrower"
        '
        'chkAdminView
        '
        Me.chkAdminView.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminView.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminView.Checked = False
        Me.chkAdminView.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkAdminView.ForeColor = System.Drawing.Color.White
        Me.chkAdminView.Location = New System.Drawing.Point(907, 383)
        Me.chkAdminView.Name = "chkAdminView"
        Me.chkAdminView.Size = New System.Drawing.Size(20, 20)
        Me.chkAdminView.TabIndex = 86
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label28.Location = New System.Drawing.Point(933, 347)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 21)
        Me.Label28.TabIndex = 85
        Me.Label28.Text = "Catalog"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label29.Location = New System.Drawing.Point(933, 310)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 21)
        Me.Label29.TabIndex = 84
        Me.Label29.Text = "Records"
        '
        'chkAdminCatalog
        '
        Me.chkAdminCatalog.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminCatalog.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminCatalog.Checked = False
        Me.chkAdminCatalog.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkAdminCatalog.ForeColor = System.Drawing.Color.White
        Me.chkAdminCatalog.Location = New System.Drawing.Point(907, 347)
        Me.chkAdminCatalog.Name = "chkAdminCatalog"
        Me.chkAdminCatalog.Size = New System.Drawing.Size(20, 20)
        Me.chkAdminCatalog.TabIndex = 83
        '
        'chkAdminRecords
        '
        Me.chkAdminRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminRecords.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkAdminRecords.Checked = False
        Me.chkAdminRecords.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.chkAdminRecords.ForeColor = System.Drawing.Color.White
        Me.chkAdminRecords.Location = New System.Drawing.Point(907, 310)
        Me.chkAdminRecords.Name = "chkAdminRecords"
        Me.chkAdminRecords.Size = New System.Drawing.Size(20, 20)
        Me.chkAdminRecords.TabIndex = 82
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label30.Location = New System.Drawing.Point(902, 275)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(84, 25)
        Me.Label30.TabIndex = 81
        Me.Label30.Text = "Default"
        '
        'BtnCancel
        '
        Me.BtnCancel.Activecolor = System.Drawing.Color.Blue
        Me.BtnCancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.BorderRadius = 5
        Me.BtnCancel.ButtonText = "Cancel"
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.No
        Me.BtnCancel.DisabledColor = System.Drawing.Color.Gray
        Me.BtnCancel.Enabled = False
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
        Me.BtnCancel.Location = New System.Drawing.Point(719, 607)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnCancel.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnCancel.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnCancel.selected = False
        Me.BtnCancel.Size = New System.Drawing.Size(318, 47)
        Me.BtnCancel.TabIndex = 88
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnCancel.Textcolor = System.Drawing.Color.White
        Me.BtnCancel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Activecolor = System.Drawing.Color.Blue
        Me.BtnUpdate.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.BorderRadius = 5
        Me.BtnUpdate.ButtonText = "Update"
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.No
        Me.BtnUpdate.DisabledColor = System.Drawing.Color.Gray
        Me.BtnUpdate.Enabled = False
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
        Me.BtnUpdate.Location = New System.Drawing.Point(719, 498)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdate.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnUpdate.selected = False
        Me.BtnUpdate.Size = New System.Drawing.Size(318, 47)
        Me.BtnUpdate.TabIndex = 89
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnUpdate.Textcolor = System.Drawing.Color.White
        Me.BtnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
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
        Me.BtnAdd.Location = New System.Drawing.Point(719, 550)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnAdd.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAdd.selected = False
        Me.BtnAdd.Size = New System.Drawing.Size(318, 47)
        Me.BtnAdd.TabIndex = 90
        Me.BtnAdd.Text = "Add Staff"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Textcolor = System.Drawing.Color.White
        Me.BtnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'Add_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 668)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.chkAdminView)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.chkAdminCatalog)
        Me.Controls.Add(Me.chkAdminRecords)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.chkAdminDashboard)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.chkAdminConfig)
        Me.Controls.Add(Me.chkAdminAddStaff)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.chkDefaultView)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.chkDefaultCatalog)
        Me.Controls.Add(Me.chkDefaultRecords)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.chkAdminReturn)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.chkAdminBorrow)
        Me.Controls.Add(Me.chkAdminAdd)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkStaffReturn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chkStaffBorrow)
        Me.Controls.Add(Me.chkStaffAdd)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtStaff)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.DgvStaffs)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtLastname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFirstname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Add_Staff"
        Me.Text = "Add_Staff"
        CType(Me.DgvStaffs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFirstname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtLastname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label8 As Label
    Friend WithEvents DgvStaffs As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStaff As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents BtnCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents chkStaffAdd As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkStaffBorrow As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkStaffReturn As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkAdminReturn As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkAdminBorrow As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkAdminAdd As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkDefaultView As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkDefaultCatalog As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkDefaultRecords As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkAdminDashboard As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkAdminConfig As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkAdminAddStaff As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkAdminView As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkAdminCatalog As Bunifu.Framework.UI.BunifuCheckbox
    Public WithEvents chkAdminRecords As Bunifu.Framework.UI.BunifuCheckbox
End Class
