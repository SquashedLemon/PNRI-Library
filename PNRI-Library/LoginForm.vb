Public Class LoginForm
    Dim Class_Login As Function_Login
    Dim Model_User As Entity_User

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username.Focus()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        Else
            'Do nothing
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Class_Login = New Function_Login()
        Model_User = New Entity_User()

        Model_User.UsernameValue = txt_username.Text
        Model_User.PasswordValue = txt_password.Text

        Class_Login.Login(Me, Model_User)

        txt_password.Text = String.Empty
        txt_username.Text = String.Empty
    End Sub
End Class