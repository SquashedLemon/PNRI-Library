Public Class HomeForm
    Dim Model_User As Entity_User
    Dim Entity_Login As Entity_Login
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Entity_Login = New Entity_Login()

        CheckAccess(BtnDashboard, Entity_Login.DashboardValue)
        CheckAccess(BtnRecords, Entity_Login.RecordsValue)
        CheckAccess(BtnAddMaterial, Entity_Login.AddMaterialValue)
        CheckAccess(BtnAddStaff, Entity_Login.AddStaffValue)
        CheckAccess(BtnAddBorrower, Entity_Login.ViewValue)
        CheckAccess(BtnCatalog, Entity_Login.CatalogValue)
        CheckAccess(BtnReturnMaterial, Entity_Login.ReturnMaterialValue)
        CheckAccess(BtnBorrowMaterial, Entity_Login.BorrowMaterialValue)
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Model_User = New Entity_User()
        Label2.Text = Model_User.IDValue
        Label3.Text = Model_User.FirstnameValue
        Label4.Text = Model_User.LastnameValue
        Label5.Text = Model_User.UsernameValue
        Label6.Text = Model_User.TypeValue
    End Sub

    Private Sub btn_exit_Click_1(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            LoginForm.Show()
            Me.Dispose()
        Else
            'Do nothing
        End If
    End Sub

    Private Sub btn_minimize_Click_1(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnAddStaff_Click(sender As Object, e As EventArgs) Handles BtnAddStaff.Click
        Dim Add_Staff As New Add_Staff(True)

        With Panel7.Controls
            .Clear()
            .Add(Add_Staff)
        End With
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        Dim DashboardForm As New DashboardForm(True)

        With Panel7.Controls
            .Clear()
            .Add(DashboardForm)
        End With
    End Sub

    Private Sub BtnRecords_Click(sender As Object, e As EventArgs) Handles BtnRecords.Click
        Dim RecordForm As New RecordForm(True)

        With Panel7.Controls
            .Clear()
            .Add(RecordForm)
        End With
    End Sub

    Private Sub BtnBorrowMaterial_Click(sender As Object, e As EventArgs) Handles BtnBorrowMaterial.Click
        Dim BorrowForm As New BorrowForm(True)

        With Panel7.Controls
            .Clear()
            .Add(BorrowForm)
        End With
    End Sub

    Private Sub BtnReturnMaterial_Click(sender As Object, e As EventArgs) Handles BtnReturnMaterial.Click
        Dim ReturnForm As New ReturnForm(True)

        With Panel7.Controls
            .Clear()
            .Add(ReturnForm)
        End With
    End Sub

    Private Sub BtnAddBorrower_Click(sender As Object, e As EventArgs) Handles BtnAddBorrower.Click
        Dim AddBorrower As New AddBorrower(True)

        With Panel7.Controls
            .Clear()
            .Add(AddBorrower)
        End With
    End Sub

    Private Sub BtnAddMaterial_Click(sender As Object, e As EventArgs) Handles BtnAddMaterial.Click
        Dim MaterialForm As New MaterialForm(True)

        With Panel7.Controls
            .Clear()
            .Add(MaterialForm)
        End With
    End Sub

    Private Sub CheckAccess(NavigationButton As Bunifu.Framework.UI.BunifuFlatButton, Access As Boolean)
        If Access Then
            NavigationButton.Visible = True
        Else
            NavigationButton.Visible = False
        End If
    End Sub
End Class