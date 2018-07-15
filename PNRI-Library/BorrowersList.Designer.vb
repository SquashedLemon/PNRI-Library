<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowersList
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvBorrowers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvBorrowers
        '
        Me.DgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBorrowers.Location = New System.Drawing.Point(22, 86)
        Me.DgvBorrowers.Name = "DgvBorrowers"
        Me.DgvBorrowers.ReadOnly = True
        Me.DgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBorrowers.Size = New System.Drawing.Size(755, 437)
        Me.DgvBorrowers.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 30)
        Me.Panel1.TabIndex = 1
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
        Me.BtnAdd.Location = New System.Drawing.Point(660, 531)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Normalcolor = System.Drawing.Color.MidnightBlue
        Me.BtnAdd.OnHovercolor = System.Drawing.Color.Navy
        Me.BtnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnAdd.selected = False
        Me.BtnAdd.Size = New System.Drawing.Size(117, 47)
        Me.BtnAdd.TabIndex = 46
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Textcolor = System.Drawing.Color.White
        Me.BtnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.Label16.Location = New System.Drawing.Point(22, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Search:"
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
        Me.TxtSearch.Location = New System.Drawing.Point(90, 37)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(687, 41)
        Me.TxtSearch.TabIndex = 47
        Me.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(774, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "X"
        '
        'BorrowersList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 592)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvBorrowers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BorrowersList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BorrowersList"
        CType(Me.DgvBorrowers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvBorrowers As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
End Class
