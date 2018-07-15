Imports System.Text.RegularExpressions

Public Class Add_Staff
    Dim Entity_Access As Entity_Access
    Dim Entity_User As Entity_User
    Dim Entity_Staff As Entity_Staff
    Dim Function_Staffs As Function_Staffs

    Sub New(Optional args As Boolean = True)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If args Then
            TopLevel = False
            Visible = True
        Else
            TopLevel = False
            Visible = False
        End If

        Function_Staffs = New Function_Staffs()
        Entity_User = New Entity_User()

        With Function_Staffs
            txtStaff.Text = .GenerateStaffID()
            .PopulateStaffs(DgvStaffs, Entity_User.IDValue)
        End With
    End Sub

    Private Sub Add_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DgvStaffs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvStaffs.CellClick
        Function_Staffs = New Function_Staffs()

        With Function_Staffs
            .PopulateAccess(DgvStaffs.CurrentRow.Cells(0).Value.ToString())
        End With

        BtnAdd.Enabled = False
        BtnAdd.Cursor = Cursors.No

        BtnUpdate.Enabled = True
        BtnUpdate.Cursor = Cursors.Hand

        BtnCancel.Enabled = True
        BtnCancel.Cursor = Cursors.Hand

        txtStaff.Text = DgvStaffs.CurrentRow.Cells(0).Value.ToString()
        TxtFirstname.Text = DgvStaffs.CurrentRow.Cells(1).Value.ToString()
        TxtLastname.Text = DgvStaffs.CurrentRow.Cells(2).Value.ToString()
        txtUsername.Text = DgvStaffs.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If MessageBox.Show("Do you want to continue on saving this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Entity_Staff = New Entity_Staff With {
                .StaffIdValue = txtStaff.Text,
                .StaffFirstnamValue = TxtFirstname.Text,
                .StaffLastnameValue = TxtLastname.Text,
                .StaffTypeValue = "Staff",
                .StaffUsernameValue = TxtFirstname.Text,
                .StaffPasswordValue = TxtLastname.Text
                }
            Function_Staffs = New Function_Staffs()
            Entity_Access = New Entity_Access()

            With Function_Staffs
                .InsertStaff(Entity_Staff)
                .InsertAccess(Entity_Staff.StaffIdValue, Entity_Access)
            End With
        End If
    End Sub

    Private Sub TxtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles TxtSearch.OnValueChanged
        Function_Staffs = New Function_Staffs()
        Entity_User = New Entity_User()

        With Function_Staffs
            .SearchStaff(DgvStaffs, TxtSearch.Text, Entity_User.IDValue)
        End With
    End Sub

    Public Sub Modules()
        Entity_Access = New Entity_Access()

        If chkAdminAdd.Checked Then
            Entity_Access.AdminAddValue = 1
        Else
            Entity_Access.AdminAddValue = 0
        End If

        If chkAdminAddStaff.Checked Then
            Entity_Access.AdminAddStaffValue = 1
        Else
            Entity_Access.AdminAddStaffValue = 0
        End If

        If chkAdminBorrow.Checked Then
            Entity_Access.AdminBorrowValue = 1
        Else
            Entity_Access.AdminBorrowValue = 0
        End If

        If chkAdminCatalog.Checked Then
            Entity_Access.DefaultAdminCatalogValue = 1
        Else
            Entity_Access.DefaultAdminCatalogValue = 0
        End If

        If chkAdminConfig.Checked Then
            Entity_Access.AdminConfigValue = 1
        Else
            Entity_Access.AdminConfigValue = 0
        End If

        If chkAdminDashboard.Checked Then
            Entity_Access.DefaultDashboardValue = 1
        Else
            Entity_Access.DefaultDashboardValue = 0
        End If

        If chkAdminRecords.Checked Then
            Entity_Access.DefaultAdminRecordsValue = 1
        Else
            Entity_Access.DefaultAdminRecordsValue = 0
        End If

        If chkAdminReturn.Checked Then
            Entity_Access.AdminReturnValue = 1
        Else
            Entity_Access.AdminReturnValue = 0
        End If

        If chkAdminView.Checked Then
            Entity_Access.DefaultAdminViewValue = 1
        Else
            Entity_Access.DefaultAdminViewValue = 0
        End If

        If chkDefaultCatalog.Checked Then
            Entity_Access.DefaultCatalogValue = 1
        Else
            Entity_Access.DefaultCatalogValue = 0
        End If

        If chkDefaultRecords.Checked Then
            Entity_Access.DefaultRecordsValue = 1
        Else
            Entity_Access.DefaultRecordsValue = 0
        End If

        If chkDefaultView.Checked Then
            Entity_Access.DefaultViewValue = 1
        Else
            Entity_Access.DefaultViewValue = 0
        End If

        If chkStaffAdd.Checked Then
            Entity_Access.StaffAddValue = 1
        Else
            Entity_Access.StaffAddValue = 0
        End If

        If chkStaffBorrow.Checked Then
            Entity_Access.StaffBorrowValue = 1
        Else
            Entity_Access.StaffBorrowValue = 0
        End If

        If chkStaffReturn.Checked Then
            Entity_Access.StaffReturnValue = 1
        Else
            Entity_Access.StaffReturnValue = 0
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If MessageBox.Show("Do you want to cancel your editing?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Function_Staffs = New Function_Staffs()
            Entity_User = New Entity_User()

            TxtFirstname.Text = String.Empty
            TxtLastname.Text = String.Empty
            txtUsername.Text = String.Empty

            For Each Controls As Control In Me.Controls
                If TypeOf Controls Is Bunifu.Framework.UI.BunifuCheckbox Then
                    DirectCast(Controls, Bunifu.Framework.UI.BunifuCheckbox).Checked = False
                End If
            Next

            With Function_Staffs
                txtStaff.Text = .GenerateStaffID()
                .PopulateStaffs(DgvStaffs, Entity_User.IDValue)
            End With
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If MessageBox.Show("Do you want to update this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Entity_Staff = New Entity_Staff() With {
                .StaffIdValue = txtStaff.Text,
                .StaffFirstnamValue = TxtFirstname.Text,
                .StaffLastnameValue = TxtLastname.Text,
                .StaffUsernameValue = txtUsername.Text,
                .StaffPasswordValue = txtPassword.Text,
                .StaffTypeValue = DgvStaffs.CurrentRow.Cells(5).Value.ToString()
            }

            Entity_User = New Entity_User()
            Entity_Access = New Entity_Access()
            Function_Staffs = New Function_Staffs()

            Modules()

            With Function_Staffs
                .UpdateStaff(Entity_Staff)
                .UpdateAccess(Entity_Staff.StaffIdValue, Entity_Access)
                .PopulateStaffs(DgvStaffs, Entity_User.IDValue)
            End With

            For Each Controls As Control In Me.Controls
                If TypeOf Controls Is Bunifu.Framework.UI.BunifuCheckbox Then
                    DirectCast(Controls, Bunifu.Framework.UI.BunifuCheckbox).Checked = False
                ElseIf TypeOf Controls Is Bunifu.Framework.UI.BunifuMaterialTextbox Then
                    CType(Controls, Bunifu.Framework.UI.BunifuMaterialTextbox).Text = String.Empty
                End If
            Next

            txtStaff.Text = Function_Staffs.GenerateStaffID()
        End If
    End Sub

    Private Sub TxtFirstname_OnValueChanged(sender As Object, e As EventArgs) Handles TxtFirstname.OnValueChanged
        If TxtFirstname.Text.Length > 0 Then
            BtnCancel.Enabled = True
            BtnCancel.Cursor = Cursors.Hand

            If Regex.IsMatch(TxtFirstname.Text, "^[A-Za-z ,]+$") = False Then
                MessageBox.Show("This field only accepts letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtFirstname.Text = TxtFirstname.Text.Remove(TxtFirstname.Text.Length - 1)
            End If
        Else
            BtnCancel.Enabled = False
            BtnCancel.Cursor = Cursors.No
        End If
    End Sub

    Private Sub TxtLastname_OnValueChanged(sender As Object, e As EventArgs) Handles TxtLastname.OnValueChanged
        If TxtLastname.Text.Length > 0 Then
            BtnCancel.Enabled = True
            BtnCancel.Cursor = Cursors.Hand

            If Regex.IsMatch(TxtLastname.Text, "^[A-Za-z ,]+$") = False Then
                MessageBox.Show("This field only accepts letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtLastname.Text = TxtLastname.Text.Remove(TxtLastname.Text.Length - 1)
            End If
        Else
            BtnCancel.Enabled = False
            BtnCancel.Cursor = Cursors.No
        End If
    End Sub
End Class