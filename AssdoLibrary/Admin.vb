Imports MySql.Data.MySqlClient
Public Class Admin
    Dim con As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    Public Sub connection()                                                     'Connection Part
        con = New MySqlConnection("server=localhost; user=root; password=; database=assdokalmunai")
        Try
            con.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub authCheck()                                                   'Display Part
        connection()
        Dim dt As New DataTable
        cmd = New MySqlCommand("SELECT * FROM librarian WHERE Username='" & txtUsername.Text & "' AND Password='" & txtPassword.Text & "'", con)

        reader = cmd.ExecuteReader()

        If reader.Read Then
            MsgBox("Successfully Login")
            Main_Menu___Admin.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect user name or password")
            Me.Show()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        authCheck()

    End Sub
End Class