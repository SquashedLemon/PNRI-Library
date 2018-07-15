<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaterialForm
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPublisher = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtCopyright = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtAuthor = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTitle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCallNumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtAccession = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DgvCatalog = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnClear = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TxtCatalogID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvCatalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label16.Location = New System.Drawing.Point(10, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Search:"
        '
        'BtnAdd
        '
        Me.BtnAdd.Activecolor = System.Drawing.Color.Blue
        Me.BtnAdd.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdd.BorderRadius = 5
        Me.BtnAdd.ButtonText = "Add Material"
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
        Me.BtnAdd.Location = New System.Drawing.Point(593, 545)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnAdd.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAdd.selected = False
        Me.BtnAdd.Size = New System.Drawing.Size(145, 47)
        Me.BtnAdd.TabIndex = 75
        Me.BtnAdd.Text = "Add Material"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Textcolor = System.Drawing.Color.White
        Me.BtnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label15.Location = New System.Drawing.Point(589, 375)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 21)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Publisher"
        '
        'TxtPublisher
        '
        Me.TxtPublisher.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.TxtPublisher.Location = New System.Drawing.Point(593, 408)
        Me.TxtPublisher.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtPublisher.Name = "TxtPublisher"
        Me.TxtPublisher.Size = New System.Drawing.Size(464, 41)
        Me.TxtPublisher.TabIndex = 73
        Me.TxtPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtCopyright
        '
        Me.TxtCopyright.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.TxtCopyright.Location = New System.Drawing.Point(593, 480)
        Me.TxtCopyright.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCopyright.Name = "TxtCopyright"
        Me.TxtCopyright.Size = New System.Drawing.Size(464, 41)
        Me.TxtCopyright.TabIndex = 72
        Me.TxtCopyright.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label14.Location = New System.Drawing.Point(587, 454)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 21)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Copyright:"
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.TxtAuthor.Location = New System.Drawing.Point(591, 320)
        Me.TxtAuthor.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(464, 41)
        Me.TxtAuthor.TabIndex = 70
        Me.TxtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label13.Location = New System.Drawing.Point(587, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 21)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Author:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label12.Location = New System.Drawing.Point(585, 218)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 21)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Title:"
        '
        'TxtTitle
        '
        Me.TxtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.TxtTitle.Location = New System.Drawing.Point(591, 244)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(466, 41)
        Me.TxtTitle.TabIndex = 67
        Me.TxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label10.Location = New System.Drawing.Point(821, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 21)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Call Number:"
        '
        'TxtCallNumber
        '
        Me.TxtCallNumber.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.TxtCallNumber.Location = New System.Drawing.Point(825, 160)
        Me.TxtCallNumber.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCallNumber.Name = "TxtCallNumber"
        Me.TxtCallNumber.Size = New System.Drawing.Size(223, 41)
        Me.TxtCallNumber.TabIndex = 63
        Me.TxtCallNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtAccession
        '
        Me.TxtAccession.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.TxtAccession.Location = New System.Drawing.Point(591, 160)
        Me.TxtAccession.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAccession.Name = "TxtAccession"
        Me.TxtAccession.Size = New System.Drawing.Size(214, 41)
        Me.TxtAccession.TabIndex = 62
        Me.TxtAccession.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label9.Location = New System.Drawing.Point(587, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 21)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Accession Number:"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(570, 28)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(10, 564)
        Me.BunifuSeparator1.TabIndex = 60
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(586, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 25)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Book Information"
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
        Me.TxtSearch.Location = New System.Drawing.Point(90, 19)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(469, 41)
        Me.TxtSearch.TabIndex = 48
        Me.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DgvCatalog
        '
        Me.DgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCatalog.Location = New System.Drawing.Point(14, 68)
        Me.DgvCatalog.Name = "DgvCatalog"
        Me.DgvCatalog.Size = New System.Drawing.Size(545, 524)
        Me.DgvCatalog.TabIndex = 47
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Activecolor = System.Drawing.Color.Blue
        Me.BtnUpdate.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUpdate.BorderRadius = 5
        Me.BtnUpdate.ButtonText = "Update Material"
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
        Me.BtnUpdate.Location = New System.Drawing.Point(748, 545)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnUpdate.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnUpdate.selected = False
        Me.BtnUpdate.Size = New System.Drawing.Size(145, 47)
        Me.BtnUpdate.TabIndex = 79
        Me.BtnUpdate.Text = "Update Material"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnUpdate.Textcolor = System.Drawing.Color.White
        Me.BtnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'BtnClear
        '
        Me.BtnClear.Activecolor = System.Drawing.Color.Blue
        Me.BtnClear.BackColor = System.Drawing.Color.MidnightBlue
        Me.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClear.BorderRadius = 5
        Me.BtnClear.ButtonText = "Clear"
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.DisabledColor = System.Drawing.Color.Gray
        Me.BtnClear.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BtnClear.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnClear.Iconimage = Nothing
        Me.BtnClear.Iconimage_right = Nothing
        Me.BtnClear.Iconimage_right_Selected = Nothing
        Me.BtnClear.Iconimage_Selected = Nothing
        Me.BtnClear.IconMarginLeft = 0
        Me.BtnClear.IconMarginRight = 0
        Me.BtnClear.IconRightVisible = True
        Me.BtnClear.IconRightZoom = 0R
        Me.BtnClear.IconVisible = True
        Me.BtnClear.IconZoom = 90.0R
        Me.BtnClear.IsTab = False
        Me.BtnClear.Location = New System.Drawing.Point(903, 545)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnClear.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnClear.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnClear.selected = False
        Me.BtnClear.Size = New System.Drawing.Size(145, 47)
        Me.BtnClear.TabIndex = 80
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClear.Textcolor = System.Drawing.Color.White
        Me.BtnClear.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'TxtCatalogID
        '
        Me.TxtCatalogID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCatalogID.Enabled = False
        Me.TxtCatalogID.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtCatalogID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtCatalogID.HintForeColor = System.Drawing.Color.Empty
        Me.TxtCatalogID.HintText = ""
        Me.TxtCatalogID.isPassword = False
        Me.TxtCatalogID.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtCatalogID.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtCatalogID.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtCatalogID.LineThickness = 4
        Me.TxtCatalogID.Location = New System.Drawing.Point(588, 88)
        Me.TxtCatalogID.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCatalogID.Name = "TxtCatalogID"
        Me.TxtCatalogID.Size = New System.Drawing.Size(214, 41)
        Me.TxtCatalogID.TabIndex = 82
        Me.TxtCatalogID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label1.Location = New System.Drawing.Point(584, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Catalog ID:"
        '
        'MaterialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 668)
        Me.Controls.Add(Me.TxtCatalogID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtPublisher)
        Me.Controls.Add(Me.TxtCopyright)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtAuthor)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtCallNumber)
        Me.Controls.Add(Me.TxtAccession)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.DgvCatalog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MaterialForm"
        Me.Text = "MaterialForm"
        CType(Me.DgvCatalog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents BtnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtPublisher As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtCopyright As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtAuthor As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtTitle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCallNumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtAccession As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DgvCatalog As DataGridView
    Friend WithEvents BtnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BtnClear As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TxtCatalogID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
End Class
