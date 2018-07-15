Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Function_Staffs
    Inherits Class_Connection

    Public Function GenerateStaffID() As String
        Dim id As Integer = 0

        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT COUNT(*) FROM tbl_user", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read
                id = Convert.ToInt32(MyReader.GetString(0)) + 1
            End While

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        GenerateStaffID = id.ToString()
    End Function

    Public Sub InsertStaff(Entity_Staff As Entity_Staff)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("INSERT INTO tbl_user(u_id, u_type, u_fname, u_lname, u_username, u_password) VALUES(@u_id, @u_type, @u_fname, @u_lname, @u_username, @u_password)", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@u_id", Entity_Staff.StaffIdValue)
                .Parameters.AddWithValue("@u_type", Entity_Staff.StaffTypeValue)
                .Parameters.AddWithValue("@u_fname", Entity_Staff.StaffFirstnamValue)
                .Parameters.AddWithValue("@u_lname", Entity_Staff.StaffLastnameValue)
                .Parameters.AddWithValue("@u_username", Entity_Staff.StaffUsernameValue)
                .Parameters.AddWithValue("@u_password", Entity_Staff.StaffPasswordValue)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub InsertAccess(userId As String, Entity_Access As Entity_Access)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("INSERT INTO tbl_access() VALUES(@id, @add_material, @add_staff, @borrow, @catalog, @config, @dashboard, @records, @return, @view)", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@id", userId)
                .Parameters.AddWithValue("@add_material", Entity_Access.AdminAddValue)
                .Parameters.AddWithValue("@add_staff", Entity_Access.AdminAddStaffValue)
                .Parameters.AddWithValue("@borrow", Entity_Access.StaffBorrowValue)
                .Parameters.AddWithValue("@catalog", Entity_Access.DefaultAdminCatalogValue)
                .Parameters.AddWithValue("@config", Entity_Access.AdminConfigValue)
                .Parameters.AddWithValue("@dashboard", Entity_Access.DefaultDashboardValue)
                .Parameters.AddWithValue("@records", Entity_Access.DefaultRecordsValue)
                .Parameters.AddWithValue("@return", Entity_Access.StaffReturnValue)
                .Parameters.AddWithValue("@view", Entity_Access.DefaultViewValue)
                .ExecuteNonQuery()
            End With
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PopulateAccess(id As String)
        Dim Add_Staff As New Add_Staff

        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT * FROM tbl_access WHERE u_id='" & id & "'", MyConnection)
            MyReader = MyCommand.ExecuteReader

            While MyReader.Read
                Add_Staff.chkAdminAdd.Checked = MyReader("access_add_material")
                Add_Staff.chkAdminAddStaff.Checked = MyReader("access_add_staff")
                Add_Staff.chkAdminBorrow.Checked = MyReader("access_borrow_material")
                Add_Staff.chkAdminCatalog.Checked = MyReader("access_catalog")
                Add_Staff.chkAdminConfig.Checked = MyReader("access_config")
                Add_Staff.chkAdminDashboard.Checked = MyReader("access_dashboard")
                Add_Staff.chkAdminRecords.Checked = MyReader("access_records")
                Add_Staff.chkAdminReturn.Checked = MyReader("access_return_material")
                Add_Staff.chkAdminView.Checked = MyReader("access_view")
                Add_Staff.chkDefaultCatalog.Checked = MyReader("access_catalog")
                Add_Staff.chkDefaultRecords.Checked = MyReader("access_records")
                Add_Staff.chkDefaultView.Checked = MyReader("access_view")
                Add_Staff.chkStaffAdd.Checked = MyReader("access_add_staff")
                Add_Staff.chkStaffBorrow.Checked = MyReader("access_borrow_material")
                Add_Staff.chkStaffReturn.Checked = MyReader("access_return_material")
            End While

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PopulateStaffs(dgvStaffs As DataGridView, userId As String)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT u_id AS 'ID', u_fname AS 'Firstname', u_lname AS 'Lastname', u_username AS 'Username', u_type AS 'Type' FROM tbl_user WHERE NOT u_id='" & userId & "'", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            dgvStaffs.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchStaff(dgvStaffs As DataGridView, keyword As String, userId As String)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT u_id AS 'ID', u_fname AS 'Firstname', u_lname AS 'Lastname', u_username AS 'Username' FROM tbl_user WHERE CONCAT(u_fname, u_lname) LIKE '%" & keyword & "%' AND NOT u_id='" & userId & "'", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            dgvStaffs.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateStaff(Entity_Staff As Entity_Staff)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("UPDATE tbl_user SET u_type, u_fname, u_lname, u_username, u_password WHERE u_id=", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@id", Entity_Staff.StaffIdValue)
                .Parameters.AddWithValue("@type", Entity_Staff.StaffTypeValue)
                .Parameters.AddWithValue("@firstname", Entity_Staff.StaffFirstnamValue)
                .Parameters.AddWithValue("@lastname", Entity_Staff.StaffLastnameValue)
                .Parameters.AddWithValue("@username", Entity_Staff.StaffUsernameValue)
                .Parameters.AddWithValue("@password", Entity_Staff.StaffPasswordValue)
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Data has been successfully updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateAccess(userid As String, Entity_Access As Entity_Access)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("UPDATE tbl_access SET access_add_material=@add_material, access_add_staff=@add_staff, access_borrow_material=@borrow, access_catalog=@catalog, access_config=@config, access_dashboard=@dashboard, access_records=@records, access_return_material=@return, access_view=@view WHERE u_id=@id", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@id", userid)
                .Parameters.AddWithValue("@add_material", Entity_Access.AdminAddValue)
                .Parameters.AddWithValue("@add_staff", Entity_Access.AdminAddStaffValue)
                .Parameters.AddWithValue("@borrow", Entity_Access.StaffBorrowValue)
                .Parameters.AddWithValue("@catalog", Entity_Access.DefaultAdminCatalogValue)
                .Parameters.AddWithValue("@config", Entity_Access.AdminConfigValue)
                .Parameters.AddWithValue("@dashboard", Entity_Access.DefaultDashboardValue)
                .Parameters.AddWithValue("@records", Entity_Access.DefaultRecordsValue)
                .Parameters.AddWithValue("@return", Entity_Access.StaffReturnValue)
                .Parameters.AddWithValue("@view", Entity_Access.DefaultViewValue)
                .ExecuteNonQuery()
            End With

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class