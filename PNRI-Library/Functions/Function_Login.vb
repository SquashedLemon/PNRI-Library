Imports MySql.Data.MySqlClient

Public Class Function_Login
    Inherits Class_Connection
    Private Count As Integer = 0
    Private Trials As Integer = 0

    Public Sub Login(LoginForm As Form, Model_User As Entity_User)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT * FROM tbl_user WHERE u_username='" & Model_User.UsernameValue & "' AND u_password='" & Model_User.PasswordValue & "'", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read
                Count = Count + 1
                With Model_User
                    .IDValue = MyReader.GetString("u_id")
                    .FirstnameValue = MyReader.GetString("u_fname")
                    .LastnameValue = MyReader.GetString("u_lname")
                    .TypeValue = MyReader.GetString("u_type")
                End With
            End While

            If Count = 1 Then
                LoginForm.Hide()
                HomeForm.Show()
            ElseIf Trials = 3 Then
                MessageBox.Show("The application will no close.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Application.Exit()
            Else
                Trials = Trials + 1
                MessageBox.Show("Invalid credentials! Three consecutive invalid attempts will result on closing the application. Trials used " & Trials & ".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DetermineAccess(UserID As String, Entity_Login As Entity_Login)
        Try
            OpenConnection()

            MyCommand = New MySqlCommand("SELECT * FROM tbl_access WHERE u_id='" & UserID & "'", MyConnection)
            MyReader = MyCommand.ExecuteReader()

            While MyReader.Read()
                Entity_Login.AddMaterialValue = Convert.ToBoolean(MyReader(1))
                Entity_Login.AddStaffValue = Convert.ToBoolean(MyReader(2))
                Entity_Login.BorrowMaterialValue = Convert.ToBoolean(MyReader(3))
                Entity_Login.CatalogValue = Convert.ToBoolean(MyReader(4))
                Entity_Login.DashboardValue = Convert.ToBoolean(MyReader(6))
                Entity_Login.RecordsValue = Convert.ToBoolean(MyReader(7))
                Entity_Login.ReturnMaterialValue = Convert.ToBoolean(MyReader(8))
                Entity_Login.ViewValue = Convert.ToBoolean(MyReader(9))
            End While

            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
