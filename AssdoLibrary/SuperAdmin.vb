Public Class SuperAdmin
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "Admin" And txtPassword.Text = "admin") Then
            Main_Menu___Super_Admin.Show()
            Me.Hide()

        Else
            MsgBox("Invalid Username and Password")
        End If


    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        'Set to no text.
        txtPassword.Text = ""
        'The password character Is an asterisk.
        txtPassword.PasswordChar = "*"
        'The control will allow no more than 14 characters.
        txtPassword.MaxLength = 14
    End Sub
End Class