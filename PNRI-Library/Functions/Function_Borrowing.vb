Imports MySql.Data.MySqlClient

Public Class Function_Borrowing
    Inherits Class_Connection

    Public Sub SaveTransaction(BorrowerID As String, CatalogID As String)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("INSERT INTO tbl_transaction(b_id, c_id, t_borrowdate) VALUES(@BorrowerID, @CatalogID, @BorrowDate)", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@BorrowerID", BorrowerID)
                .Parameters.AddWithValue("@CatalogID", CatalogID)
                .Parameters.AddWithValue("@BorrowDate", DateTime.Now)
            End With
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ChangeStatus(CatalogID As String)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("UPDATE tbl_catalog SET c_status='Borrowed' WHERE c_id=@CatalogID", MyConnection)

            With MyCommand
                .Parameters.AddWithValue("@CatalogID", CatalogID)
                .ExecuteNonQuery()
            End With

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PopulateBorrowing(DgvCatalog As DataGridView)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT c_id AS 'ID', c_access AS 'Accession Number', c_call AS 'Call Number', c_title AS 'Title', c_author AS 'Author', c_publisher AS 'Publisher', c_copyright AS 'Copyright', c_status AS 'Status' FROM tbl_catalog WHERE c_status='Available'", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvCatalog.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchBorrowing(DgvCatalog As DataGridView, Keyword As String)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT c_id AS 'ID', c_access AS 'Accession Number', c_call AS 'Call Number', c_title AS 'Title', c_author AS 'Author', c_publisher AS 'Publisher', c_copyright AS 'Copyright', c_status AS 'Status' FROM tbl_catalog WHERE c_status='Available' AND CONCAT(c_id, c_access, c_call, c_title, c_author, c_publisher, c_copyright) LIKE '%" & Keyword & "%'", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvCatalog.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
