<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordForm
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
        Me.DgvBorrowers = New System.Windows.Forms.DataGridView()
        Me.DgvTransaction = New System.Windows.Forms.DataGridView()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBorrowSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TxtTransactionSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DtpTo = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.DtpFrom = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DgvBorrowers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvBorrowers
        '
        Me.DgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBorrowers.Location = New System.Drawing.Point(12, 94)
        Me.DgvBorrowers.Name = "DgvBorrowers"
        Me.DgvBorrowers.Size = New System.Drawing.Size(304, 562)
        Me.DgvBorrowers.TabIndex = 0
        '
        'DgvTransaction
        '
        Me.DgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTransaction.Location = New System.Drawing.Point(322, 94)
        Me.DgvTransaction.Name = "DgvTransaction"
        Me.DgvTransaction.Size = New System.Drawing.Size(737, 507)
        Me.DgvTransaction.TabIndex = 1
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Blue
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.MidnightBlue
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 5
        Me.BunifuFlatButton2.ButtonText = "Print"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(901, 609)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(164, 47)
        Me.BunifuFlatButton2.TabIndex = 46
        Me.BunifuFlatButton2.Text = "Print"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(7, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 25)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "List Of Borrowers"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(317, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 25)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Borrowed Books"
        '
        'TxtBorrowSearch
        '
        Me.TxtBorrowSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBorrowSearch.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtBorrowSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBorrowSearch.HintForeColor = System.Drawing.Color.Empty
        Me.TxtBorrowSearch.HintText = ""
        Me.TxtBorrowSearch.isPassword = False
        Me.TxtBorrowSearch.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtBorrowSearch.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtBorrowSearch.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtBorrowSearch.LineThickness = 4
        Me.TxtBorrowSearch.Location = New System.Drawing.Point(109, 45)
        Me.TxtBorrowSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtBorrowSearch.Name = "TxtBorrowSearch"
        Me.TxtBorrowSearch.Size = New System.Drawing.Size(207, 41)
        Me.TxtBorrowSearch.TabIndex = 49
        Me.TxtBorrowSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TxtTransactionSearch
        '
        Me.TxtTransactionSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTransactionSearch.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.TxtTransactionSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtTransactionSearch.HintForeColor = System.Drawing.Color.Empty
        Me.TxtTransactionSearch.HintText = ""
        Me.TxtTransactionSearch.isPassword = False
        Me.TxtTransactionSearch.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.TxtTransactionSearch.LineIdleColor = System.Drawing.Color.Gray
        Me.TxtTransactionSearch.LineMouseHoverColor = System.Drawing.Color.MidnightBlue
        Me.TxtTransactionSearch.LineThickness = 4
        Me.TxtTransactionSearch.Location = New System.Drawing.Point(421, 45)
        Me.TxtTransactionSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtTransactionSearch.Name = "TxtTransactionSearch"
        Me.TxtTransactionSearch.Size = New System.Drawing.Size(326, 41)
        Me.TxtTransactionSearch.TabIndex = 50
        Me.TxtTransactionSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DtpTo
        '
        Me.DtpTo.BackColor = System.Drawing.Color.SeaGreen
        Me.DtpTo.BorderRadius = 0
        Me.DtpTo.ForeColor = System.Drawing.Color.White
        Me.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTo.FormatCustom = Nothing
        Me.DtpTo.Location = New System.Drawing.Point(933, 45)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(132, 36)
        Me.DtpTo.TabIndex = 53
        Me.DtpTo.Value = New Date(2018, 3, 15, 19, 27, 11, 955)
        '
        'DtpFrom
        '
        Me.DtpFrom.BackColor = System.Drawing.Color.SeaGreen
        Me.DtpFrom.BorderRadius = 0
        Me.DtpFrom.ForeColor = System.Drawing.Color.White
        Me.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFrom.FormatCustom = Nothing
        Me.DtpFrom.Location = New System.Drawing.Point(758, 45)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.Size = New System.Drawing.Size(132, 36)
        Me.DtpFrom.TabIndex = 54
        Me.DtpFrom.Value = New Date(2018, 3, 15, 19, 27, 11, 955)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(747, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 25)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Filter by Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.Location = New System.Drawing.Point(896, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 25)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "to"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(324, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Search:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label5.Location = New System.Drawing.Point(12, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Search:"
        '
        'RecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 668)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpFrom)
        Me.Controls.Add(Me.DtpTo)
        Me.Controls.Add(Me.TxtTransactionSearch)
        Me.Controls.Add(Me.TxtBorrowSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.DgvTransaction)
        Me.Controls.Add(Me.DgvBorrowers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecordForm"
        Me.Text = "RecordForm"
        CType(Me.DgvBorrowers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvBorrowers As DataGridView
    Friend WithEvents DgvTransaction As DataGridView
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBorrowSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TxtTransactionSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DtpTo As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents DtpFrom As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
