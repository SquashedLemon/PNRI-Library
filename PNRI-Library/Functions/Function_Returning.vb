Imports MySql.Data.MySqlClient

Public Class Function_Returning
    Inherits Class_Connection

    Public Sub PopulateTransaction(DgvTransaction As DataGridView)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT t_id AS 'Transaction ID', b_id AS 'Borrowers ID', c_id 'Catalog ID', DATE_FORMAT(t_borrowdate, '%M %d %Y') AS 'Date Borrowed' FROM tbl_transaction WHERE t_returneddate='0000-00-00'", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvTransaction.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchTransaction(DgvTransaction As DataGridView, Keyword As String)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT t_id AS 'Transaction ID', b_id AS 'Borrowers ID', c_id 'Catalog ID', DATE_FORMAT(t_borrowdate, '%M %d %Y') AS 'Date Borrowed' FROM tbl_transaction WHERE t_returneddate='0000-00-00' AND CONCAT(t_id, b_id, c_id) LIKE '" & Keyword & "'", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvTransaction.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ReturnTransaction(TransactionID As String)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("UPDATE tbl_transaction SET t_returneddate=@ReturnDate WHERE t_id=@TransactionID", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@ReturnDate", Date.Now)
                .Parameters.AddWithValue("@TransactionID", TransactionID)
                .ExecuteNonQuery()
            End With
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RevertAvailability(CatalogID As String)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("UPDATE tbl_catalog SET c_status='Available' WHERE c_id=@CatalogID", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@CatalogID", CatalogID)
                .ExecuteNonQuery()
            End With

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetBorrowerInfo(Entity_Borrowers As Entity_Borrowers)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT b_fname, b_lname, b_div, b_sec, b_contact FROM tbl_borrower WHERE b_id='" & Entity_Borrowers.BorrowerIdValue & "'", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read()
                Entity_Borrowers.BorrowerFirstnameValue = MyReader(0).ToString()
                Entity_Borrowers.BorrowerLastnameValue = MyReader(1).ToString()
                Entity_Borrowers.BorrowerDivisionValue = MyReader(2).ToString()
                Entity_Borrowers.BorrowerSectionValue = MyReader(3).ToString()
                Entity_Borrowers.BorrowerContactValue = MyReader(4).ToString()
            End While

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GetCatalogInfo(Entity_Catalog As Entity_Catalog)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT c_access, c_call, c_title, c_author, c_publisher, c_copyright FROM tbl_catalog WHERE c_id='" & Entity_Catalog.CatalogIDValue & "'", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read
                Entity_Catalog.CatalogAccessValue = MyReader(0).ToString()
                Entity_Catalog.CatalogCallNumberValue = MyReader(1).ToString()
                Entity_Catalog.CatalogTitleValue = MyReader(2).ToString()
                Entity_Catalog.CatalogPublisherValue = MyReader(3).ToString()
                Entity_Catalog.CatalogCopyrightValue = MyReader(4).ToString()
            End While

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
