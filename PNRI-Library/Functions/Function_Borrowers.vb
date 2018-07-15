Imports MySql.Data.MySqlClient

Public Class Function_Borrowers
    Inherits Class_Connection

    Public Function GenerateBorrowerID()
        Dim id As String = ""

        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT COUNT(*) FROM tbl_borrower", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read()
                id = Convert.ToInt32(MyReader(0)) + 1
            End While

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return id
    End Function

    Public Sub InsertBorrower(Entity_Borrowers As Entity_Borrowers)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("INSERT INTO tbl_borrowers() VALUES(@id, @firstname, @lastname, @division, @section, @username, @password, @contact, @address, @barangay, @city)", MyConnection)
            With MyCommand
                .Parameters.AddWithValue("@id", Entity_Borrowers.BorrowerIdValue)
                .Parameters.AddWithValue("@firstname", Entity_Borrowers.BorrowerFirstnameValue)
                .Parameters.AddWithValue("@lastname", Entity_Borrowers.BorrowerLastnameValue)
                .Parameters.AddWithValue("@division", Entity_Borrowers.BorrowerDivisionValue)
                .Parameters.AddWithValue("@section", Entity_Borrowers.BorrowerSectionValue)
                .Parameters.AddWithValue("@username", Entity_Borrowers.BorrowerUsernameValue)
                .Parameters.AddWithValue("@password", Entity_Borrowers.BorrowerPasswordValue)
                .Parameters.AddWithValue("@contact", Entity_Borrowers.BorrowerContactValue)
                .Parameters.AddWithValue("@address", Entity_Borrowers.BorrowerAddressValue)
                .Parameters.AddWithValue("@barangay", Entity_Borrowers.BorrowerBarangayValue)
                .Parameters.AddWithValue("@city", Entity_Borrowers.BorrowerCityValue)
                .ExecuteNonQuery()
            End With

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PopulateBorrowers(DgvBorrowers As DataGridView)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT b_id AS 'Borrower ID', b_fname AS 'Firstname', b_lname AS 'Lastname', b_div AS 'Division', b_sec AS 'Section', b_username AS 'Username', b_contact AS 'Contact Number', b_address AS 'Address' FROM tbl_borrower", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvBorrowers.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchBorrower(DgvBorrowers As DataGridView, keyword As String)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT b_id AS 'Borrower ID', b_fname AS 'Firstname', b_lname AS 'Lastname', b_div AS 'Division', b_sec AS 'Section', b_username AS 'Username', b_contact AS 'Contact Number', b_address AS 'Address' FROM tbl_borrower WHERE CONCAT(b_fname, b_lname, b_username, b_id) LIKE '%" & keyword & "%'", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvBorrowers.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateBorrower(id As String, Entity_Borrowers As Entity_Borrowers)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("UPDATE tbl_borrower SET b_fname=@firstname, b_lname=@lastname, b_div=@division, b_sec=@section, b_username=@username, b_password=@password, b_contact=@contact, b_address=@address, b_barangay=@barangay, b_city=@city WHERE b_id=@id", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@id", id)
                .Parameters.AddWithValue("@firstname", Entity_Borrowers.BorrowerFirstnameValue)
                .Parameters.AddWithValue("@lastname", Entity_Borrowers.BorrowerLastnameValue)
                .Parameters.AddWithValue("@division", Entity_Borrowers.BorrowerDivisionValue)
                .Parameters.AddWithValue("@section", Entity_Borrowers.BorrowerSectionValue)
                .Parameters.AddWithValue("@username", Entity_Borrowers.BorrowerUsernameValue)
                .Parameters.AddWithValue("@password", Entity_Borrowers.BorrowerPasswordValue)
                .Parameters.AddWithValue("@contact", Entity_Borrowers.BorrowerContactValue)
                .Parameters.AddWithValue("@address", Entity_Borrowers.BorrowerAddressValue)
                .Parameters.AddWithValue("@barangay", Entity_Borrowers.BorrowerBarangayValue)
                .Parameters.AddWithValue("@city", Entity_Borrowers.BorrowerCityValue)
                .ExecuteNonQuery()
            End With

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
