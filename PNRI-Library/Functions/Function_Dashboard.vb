Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class Function_Dashboard
    Inherits Class_Connection

    Public Function CountBorrowers() As Integer
        Dim Count As Integer = 0

        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT COUNT(*) FROM tbl_borrower", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read()
                Count = 0
            End While

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Count
    End Function

    Public Function CountTransactions() As Integer
        Dim Count As Integer = 0

        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT COUNT(*) FROM tbl_transaction", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read()
                Count = 0
            End While

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Count
    End Function

    Public Function CountMaterials() As Integer
        Dim Count As Integer = 0

        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT COUNT(*) FROM tbl_catalog", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read()
                Count = 0
            End While

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Count
    End Function

    Public Sub LoadTransactionChart(TransactionChart As Chart, Year As Integer)
        With TransactionChart
            .Series("Month").Points.AddXY("January", CountTransactionByMonth(1, Year))
            .Series("Month").Points.AddXY("February", CountTransactionByMonth(2, Year))
            .Series("Month").Points.AddXY("March", CountTransactionByMonth(3, Year))
            .Series("Month").Points.AddXY("April", CountTransactionByMonth(4, Year))
            .Series("Month").Points.AddXY("May", CountTransactionByMonth(5, Year))
            .Series("Month").Points.AddXY("June", CountTransactionByMonth(6, Year))
            .Series("Month").Points.AddXY("July", CountTransactionByMonth(7, Year))
            .Series("Month").Points.AddXY("August", CountTransactionByMonth(8, Year))
            .Series("Month").Points.AddXY("September", CountTransactionByMonth(9, Year))
            .Series("Month").Points.AddXY("October", CountTransactionByMonth(10, Year))
            .Series("Month").Points.AddXY("November", CountTransactionByMonth(11, Year))
            .Series("Month").Points.AddXY("December", CountTransactionByMonth(12, Year))
        End With
    End Sub

    Private Function CountTransactionByMonth(Month As Integer, Year As Integer) As Integer
        Dim Count As Integer = 0

        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT COUNT(*) FROM tbl_transaction WHERE MONTH(t_borrowdate)='" & Month & "' AND YEAR()", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read()
                Count = MyReader(0).ToString()
            End While

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Count
    End Function
End Class
