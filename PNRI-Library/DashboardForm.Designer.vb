<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.ChartTransactions = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTransactions = New System.Windows.Forms.Label()
        Me.LblBorrowers = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblMaterials = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DdYear = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ChartTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChartTransactions
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartTransactions.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartTransactions.Legends.Add(Legend2)
        Me.ChartTransactions.Location = New System.Drawing.Point(12, 96)
        Me.ChartTransactions.Name = "ChartTransactions"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Month"
        Me.ChartTransactions.Series.Add(Series2)
        Me.ChartTransactions.Size = New System.Drawing.Size(739, 560)
        Me.ChartTransactions.TabIndex = 0
        Me.ChartTransactions.Text = "Chart1"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.LblTransactions)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(778, 38)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(281, 185)
        Me.BunifuGradientPanel1.TabIndex = 1
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.LblBorrowers)
        Me.BunifuGradientPanel2.Controls.Add(Me.Label4)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(778, 262)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(281, 167)
        Me.BunifuGradientPanel2.TabIndex = 2
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Controls.Add(Me.LblMaterials)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label6)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(778, 477)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(281, 179)
        Me.BunifuGradientPanel3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Transactions:"
        '
        'LblTransactions
        '
        Me.LblTransactions.AutoSize = True
        Me.LblTransactions.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransactions.Location = New System.Drawing.Point(20, 107)
        Me.LblTransactions.Name = "LblTransactions"
        Me.LblTransactions.Size = New System.Drawing.Size(89, 39)
        Me.LblTransactions.TabIndex = 1
        Me.LblTransactions.Text = "0000"
        '
        'LblBorrowers
        '
        Me.LblBorrowers.AutoSize = True
        Me.LblBorrowers.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBorrowers.Location = New System.Drawing.Point(20, 96)
        Me.LblBorrowers.Name = "LblBorrowers"
        Me.LblBorrowers.Size = New System.Drawing.Size(89, 39)
        Me.LblBorrowers.TabIndex = 3
        Me.LblBorrowers.Text = "0000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Number of Borrowers:"
        '
        'LblMaterials
        '
        Me.LblMaterials.AutoSize = True
        Me.LblMaterials.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterials.Location = New System.Drawing.Point(20, 109)
        Me.LblMaterials.Name = "LblMaterials"
        Me.LblMaterials.Size = New System.Drawing.Size(89, 39)
        Me.LblMaterials.TabIndex = 3
        Me.LblMaterials.Text = "0000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Number of Materials:"
        '
        'DdYear
        '
        Me.DdYear.BackColor = System.Drawing.Color.Transparent
        Me.DdYear.BorderRadius = 3
        Me.DdYear.DisabledColor = System.Drawing.Color.Gray
        Me.DdYear.ForeColor = System.Drawing.Color.White
        Me.DdYear.Items = New String() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"}
        Me.DdYear.Location = New System.Drawing.Point(157, 38)
        Me.DdYear.Name = "DdYear"
        Me.DdYear.NomalColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.DdYear.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.DdYear.selectedIndex = -1
        Me.DdYear.Size = New System.Drawing.Size(217, 35)
        Me.DdYear.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Filter by Year:"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 668)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DdYear)
        Me.Controls.Add(Me.BunifuGradientPanel3)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.ChartTransactions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        CType(Me.ChartTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChartTransactions As DataVisualization.Charting.Chart
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents LblTransactions As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblBorrowers As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblMaterials As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DdYear As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label3 As Label
End Class
