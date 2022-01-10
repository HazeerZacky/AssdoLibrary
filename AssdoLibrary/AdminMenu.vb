Public Class AdminMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnSuperAdmin_Click(sender As Object, e As EventArgs) Handles btnSuperAdmin.Click
        SuperAdmin.Show()
        Me.Hide()
        'If OpenDB() Then
        'MsgBox("S")
        'Else
        'MsgBox("f")
        'End If

    End Sub
End Class
