Imports MySql.Data.MySqlClient

Public Class Class_Connection
    Protected MyConnection As MySqlConnection
    Protected MyCommand As MySqlCommand
    Protected MyAdapter As MySqlDataAdapter
    Protected MyReader As MySqlDataReader
    Protected MyBindingSource As BindingSource
    Protected MyDataSet As DataSet
    Protected MyDataTable As DataTable

    Private Function VarConnection() As String
        Return "DataSource=localhost; Username=root; Password=; Database=db_library_pnri"
    End Function

    Protected Sub OpenConnection()
        MyConnection = New MySqlConnection(VarConnection)

        If (MyConnection.State = ConnectionState.Closed) Then
            MyConnection.Open()
        End If
    End Sub

    Protected Sub CloseConnection()
        If MyConnection.State = ConnectionState.Open Then
            MyConnection.Close()
        End If
    End Sub
End Class
