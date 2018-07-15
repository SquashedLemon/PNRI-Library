Imports MySql.Data.MySqlClient

Public Class Function_Records
    Inherits Class_Connection

    Public Sub PopulateRecords(DgvRecords As DataGridView)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT t_id AS 'Transaction ID', b_id AS 'Borrowers ID', c_id AS 'Catalog ID', DATE_FORMAT(t_borrowdate, '%M %d %Y') AS 'Date Borrowed', DATE_FORMAT(t_returneddate, '%M %d %Y') AS 'Date Returned' FROM tbl_transaction", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvRecords.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchRecords(DgvRecords As DataGridView, Keyword As String)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT t_id AS 'Transaction ID', b_id AS 'Borrowers ID', c_id AS 'Catalog ID', DATE_FORMAT(t_borrowdate, '%M %d %Y') AS 'Date Borrowed', DATE_FORMAT(t_returneddate, '%M %d %Y') AS 'Date Returned' FROM tbl_transaction WHERE CONCAT(t_id, b_id, c_id) LIKE '%" & Keyword & "%'", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvRecords.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub FilterByDate(DgvRecords As DataGridView, DateFrom As String, DateTo As String)
        Try
            OpenConnection()

            MyAdapter = New MySqlDataAdapter("SELECT t_id AS 'Transaction ID', b_id AS 'Borrowers ID', c_id AS 'Catalog ID', DATE_FORMAT(t_borrowdate, '%M %d %Y') AS 'Date Borrowed', DATE_FORMAT(t_returneddate, '%M %d %Y') AS 'Date Returned' FROM tbl_transaction WHERE t_borrowdate BETWEEN '" & DateFrom & "' AND '" & DateTo & "'", MyConnection)
            MyDataSet = New DataSet()
            MyBindingSource = New BindingSource()

            MyAdapter.Fill(MyDataSet)

            MyBindingSource.DataSource = MyDataSet.Tables(0)
            DgvRecords.DataSource = MyBindingSource

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
