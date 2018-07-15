<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowForm
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
        Me.DgvBorrow = New System.Windows.Forms.DataGridView()
        Me.TxtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtFirstname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtDivision = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtContact = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAccession = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtCallNumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtDate = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtTitle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtAuthor = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCopyright = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtPublisher = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnBorrow = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnRemove = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DgvBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvBorrow
        '
        Me.DgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBorrow.Cursor = System.Windows.Forms.Cursors.No
        Me.DgvBorrow.Enabled = False
        Me.DgvBorrow.Location = New System.Drawing.Point(12, 74)
        Me.DgvBorrow.Name = "DgvBorrow"
        Me.DgvBorrow.Size = New System.Drawing.Size(539, 555)
        Me.DgvBorrow.TabIndex = 0
        '
        'TxtSearch
        '
        Me.TxtSearch.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtSearch.Enabled = False
        Me.TxtSearch.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtSearch.HintForeColor = System.Drawing.Color.Empty
        Me.TxtSearch.HintText = ""
        Me.TxtSearch.isPassword = False
        Me.TxtSearch.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtSearch.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtSearch.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtSearch.LineThickness = 4
        Me.TxtSearch.Location = New System.Drawing.Point(76, 23)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(472, 41)
        Me.TxtSearch.TabIndex = 15
        Me.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtFirstname
        '
        Me.TxtFirstname.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtFirstname.Enabled = False
        Me.TxtFirstname.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtFirstname.HintForeColor = System.Drawing.Color.Empty
        Me.TxtFirstname.HintText = ""
        Me.TxtFirstname.isPassword = False
        Me.TxtFirstname.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtFirstname.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtFirstname.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtFirstname.LineThickness = 4
        Me.TxtFirstname.Location = New System.Drawing.Point(750, 62)
        Me.TxtFirstname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.Size = New System.Drawing.Size(307, 41)
        Me.TxtFirstname.TabIndex = 17
        Me.TxtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtDivision
        '
        Me.TxtDivision.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtDivision.Enabled = False
        Me.TxtDivision.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtDivision.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtDivision.HintForeColor = System.Drawing.Color.Empty
        Me.TxtDivision.HintText = ""
        Me.TxtDivision.isPassword = False
        Me.TxtDivision.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtDivision.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtDivision.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtDivision.LineThickness = 4
        Me.TxtDivision.Location = New System.Drawing.Point(750, 113)
        Me.TxtDivision.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtDivision.Name = "TxtDivision"
        Me.TxtDivision.Size = New System.Drawing.Size(307, 41)
        Me.TxtDivision.TabIndex = 18
        Me.TxtDivision.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtContact
        '
        Me.TxtContact.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtContact.Enabled = False
        Me.TxtContact.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtContact.HintForeColor = System.Drawing.Color.Empty
        Me.TxtContact.HintText = ""
        Me.TxtContact.isPassword = False
        Me.TxtContact.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtContact.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtContact.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtContact.LineThickness = 4
        Me.TxtContact.Location = New System.Drawing.Point(750, 164)
        Me.TxtContact.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(307, 41)
        Me.TxtContact.TabIndex = 19
        Me.TxtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label2.Location = New System.Drawing.Point(559, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Division/Section"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label1.Location = New System.Drawing.Point(559, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Contact No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label3.Location = New System.Drawing.Point(559, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Full Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label4.Location = New System.Drawing.Point(727, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label5.Location = New System.Drawing.Point(727, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 21)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label6.Location = New System.Drawing.Point(727, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label7.Location = New System.Drawing.Point(556, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(237, 25)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Borrower's Information"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(554, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 25)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Book Information"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(561, 215)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(491, 10)
        Me.BunifuSeparator1.TabIndex = 28
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label9.Location = New System.Drawing.Point(555, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 21)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Accession Number:"
        '
        'TxtAccession
        '
        Me.TxtAccession.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtAccession.Enabled = False
        Me.TxtAccession.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtAccession.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAccession.HintForeColor = System.Drawing.Color.Empty
        Me.TxtAccession.HintText = ""
        Me.TxtAccession.isPassword = False
        Me.TxtAccession.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtAccession.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtAccession.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtAccession.LineThickness = 4
        Me.TxtAccession.Location = New System.Drawing.Point(559, 302)
        Me.TxtAccession.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAccession.Name = "TxtAccession"
        Me.TxtAccession.Size = New System.Drawing.Size(166, 41)
        Me.TxtAccession.TabIndex = 30
        Me.TxtAccession.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtCallNumber
        '
        Me.TxtCallNumber.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtCallNumber.Enabled = False
        Me.TxtCallNumber.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtCallNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtCallNumber.HintForeColor = System.Drawing.Color.Empty
        Me.TxtCallNumber.HintText = ""
        Me.TxtCallNumber.isPassword = False
        Me.TxtCallNumber.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtCallNumber.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtCallNumber.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtCallNumber.LineThickness = 4
        Me.TxtCallNumber.Location = New System.Drawing.Point(746, 302)
        Me.TxtCallNumber.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCallNumber.Name = "TxtCallNumber"
        Me.TxtCallNumber.Size = New System.Drawing.Size(177, 41)
        Me.TxtCallNumber.TabIndex = 31
        Me.TxtCallNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label10.Location = New System.Drawing.Point(742, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 21)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Call Number:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label11.Location = New System.Drawing.Point(809, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Date:"
        '
        'TxtDate
        '
        Me.TxtDate.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtDate.Enabled = False
        Me.TxtDate.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtDate.HintForeColor = System.Drawing.Color.Empty
        Me.TxtDate.HintText = ""
        Me.TxtDate.isPassword = False
        Me.TxtDate.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtDate.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtDate.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtDate.LineThickness = 4
        Me.TxtDate.Location = New System.Drawing.Point(875, 230)
        Me.TxtDate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(177, 41)
        Me.TxtDate.TabIndex = 34
        Me.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtTitle
        '
        Me.TxtTitle.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtTitle.Enabled = False
        Me.TxtTitle.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtTitle.HintForeColor = System.Drawing.Color.Empty
        Me.TxtTitle.HintText = ""
        Me.TxtTitle.isPassword = False
        Me.TxtTitle.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtTitle.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtTitle.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtTitle.LineThickness = 4
        Me.TxtTitle.Location = New System.Drawing.Point(559, 379)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(498, 41)
        Me.TxtTitle.TabIndex = 35
        Me.TxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label12.Location = New System.Drawing.Point(553, 353)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 21)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Title:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label13.Location = New System.Drawing.Point(555, 425)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 21)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Author:"
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtAuthor.Enabled = False
        Me.TxtAuthor.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAuthor.HintForeColor = System.Drawing.Color.Empty
        Me.TxtAuthor.HintText = ""
        Me.TxtAuthor.isPassword = False
        Me.TxtAuthor.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtAuthor.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtAuthor.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtAuthor.LineThickness = 4
        Me.TxtAuthor.Location = New System.Drawing.Point(559, 451)
        Me.TxtAuthor.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(319, 41)
        Me.TxtAuthor.TabIndex = 38
        Me.TxtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label14.Location = New System.Drawing.Point(884, 425)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 21)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Copyright:"
        '
        'TxtCopyright
        '
        Me.TxtCopyright.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtCopyright.Enabled = False
        Me.TxtCopyright.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtCopyright.HintForeColor = System.Drawing.Color.Empty
        Me.TxtCopyright.HintText = ""
        Me.TxtCopyright.isPassword = False
        Me.TxtCopyright.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtCopyright.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtCopyright.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtCopyright.LineThickness = 4
        Me.TxtCopyright.Location = New System.Drawing.Point(888, 451)
        Me.TxtCopyright.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCopyright.Name = "TxtCopyright"
        Me.TxtCopyright.Size = New System.Drawing.Size(169, 41)
        Me.TxtCopyright.TabIndex = 40
        Me.TxtCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtPublisher
        '
        Me.TxtPublisher.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtPublisher.Enabled = False
        Me.TxtPublisher.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtPublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPublisher.HintForeColor = System.Drawing.Color.Empty
        Me.TxtPublisher.HintText = ""
        Me.TxtPublisher.isPassword = False
        Me.TxtPublisher.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtPublisher.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtPublisher.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtPublisher.LineThickness = 4
        Me.TxtPublisher.Location = New System.Drawing.Point(557, 523)
        Me.TxtPublisher.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtPublisher.Name = "TxtPublisher"
        Me.TxtPublisher.Size = New System.Drawing.Size(500, 41)
        Me.TxtPublisher.TabIndex = 41
        Me.TxtPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label15.Location = New System.Drawing.Point(555, 497)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 21)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Publisher"
        '
        'BtnBorrow
        '
        Me.BtnBorrow.Activecolor = System.Drawing.Color.Blue
        Me.BtnBorrow.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBorrow.BorderRadius = 5
        Me.BtnBorrow.ButtonText = "Borrow"
        Me.BtnBorrow.Cursor = System.Windows.Forms.Cursors.No
        Me.BtnBorrow.DisabledColor = System.Drawing.Color.Gray
        Me.BtnBorrow.Enabled = False
        Me.BtnBorrow.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnBorrow.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnBorrow.Iconimage = Nothing
        Me.BtnBorrow.Iconimage_right = Nothing
        Me.BtnBorrow.Iconimage_right_Selected = Nothing
        Me.BtnBorrow.Iconimage_Selected = Nothing
        Me.BtnBorrow.IconMarginLeft = 0
        Me.BtnBorrow.IconMarginRight = 0
        Me.BtnBorrow.IconRightVisible = True
        Me.BtnBorrow.IconRightZoom = 0R
        Me.BtnBorrow.IconVisible = True
        Me.BtnBorrow.IconZoom = 90.0R
        Me.BtnBorrow.IsTab = False
        Me.BtnBorrow.Location = New System.Drawing.Point(940, 582)
        Me.BtnBorrow.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnBorrow.Name = "BtnBorrow"
        Me.BtnBorrow.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnBorrow.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnBorrow.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnBorrow.selected = False
        Me.BtnBorrow.Size = New System.Drawing.Size(117, 47)
        Me.BtnBorrow.TabIndex = 43
        Me.BtnBorrow.Text = "Borrow"
        Me.BtnBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnBorrow.Textcolor = System.Drawing.Color.White
        Me.BtnBorrow.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnRemove
        '
        Me.BtnRemove.Activecolor = System.Drawing.Color.Blue
        Me.BtnRemove.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRemove.BorderRadius = 5
        Me.BtnRemove.ButtonText = "Remove"
        Me.BtnRemove.Cursor = System.Windows.Forms.Cursors.No
        Me.BtnRemove.DisabledColor = System.Drawing.Color.Gray
        Me.BtnRemove.Enabled = False
        Me.BtnRemove.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnRemove.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnRemove.Iconimage = Nothing
        Me.BtnRemove.Iconimage_right = Nothing
        Me.BtnRemove.Iconimage_right_Selected = Nothing
        Me.BtnRemove.Iconimage_Selected = Nothing
        Me.BtnRemove.IconMarginLeft = 0
        Me.BtnRemove.IconMarginRight = 0
        Me.BtnRemove.IconRightVisible = True
        Me.BtnRemove.IconRightZoom = 0R
        Me.BtnRemove.IconVisible = True
        Me.BtnRemove.IconZoom = 90.0R
        Me.BtnRemove.IsTab = False
        Me.BtnRemove.Location = New System.Drawing.Point(690, 582)
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnRemove.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnRemove.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnRemove.selected = False
        Me.BtnRemove.Size = New System.Drawing.Size(117, 47)
        Me.BtnRemove.TabIndex = 44
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnRemove.Textcolor = System.Drawing.Color.White
        Me.BtnRemove.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnAdd
        '
        Me.BtnAdd.Activecolor = System.Drawing.Color.Blue
        Me.BtnAdd.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdd.BorderRadius = 5
        Me.BtnAdd.ButtonText = "Add"
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
        Me.BtnAdd.Location = New System.Drawing.Point(563, 582)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnAdd.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAdd.selected = False
        Me.BtnAdd.Size = New System.Drawing.Size(117, 47)
        Me.BtnAdd.TabIndex = 45
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Textcolor = System.Drawing.Color.White
        Me.BtnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label16.Location = New System.Drawing.Point(8, 34)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Search:"
        '
        'BorrowForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 668)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnBorrow)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtPublisher)
        Me.Controls.Add(Me.TxtCopyright)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtAuthor)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtCallNumber)
        Me.Controls.Add(Me.TxtAccession)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtContact)
        Me.Controls.Add(Me.TxtDivision)
        Me.Controls.Add(Me.TxtFirstname)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.DgvBorrow)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BorrowForm"
        Me.Text = "BorrowForm"
        CType(Me.DgvBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtAccession As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtCallNumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtDate As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtTitle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtAuthor As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtCopyright As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtPublisher As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnBorrow As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label16 As Label
    Public WithEvents TxtFirstname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents TxtDivision As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents TxtContact As Bunifu.Framework.UI.BunifuMaterialTextbox
    Public WithEvents BtnRemove As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents BtnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents DgvBorrow As DataGridView
    Public WithEvents TxtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
