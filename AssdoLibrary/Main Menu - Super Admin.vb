Public Class Main_Menu___Super_Admin
    Sub switchPanel(ByVal panel As Form)
        MainPanel.Controls.Clear()
        panel.TopLevel = False
        MainPanel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Main_Menu___Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        switchPanel(Member)
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        switchPanel(Books)
    End Sub

    Private Sub btnIssues_Click(sender As Object, e As EventArgs) Handles btnIssues.Click
        switchPanel(Issues)
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        switchPanel(Returns)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(Librarians)
    End Sub

    Private Sub MemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberToolStripMenuItem.Click
        switchPanel(Member)
    End Sub

    Private Sub BooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooksToolStripMenuItem.Click
        switchPanel(Books)
    End Sub

    Private Sub IssuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssuesToolStripMenuItem.Click
        switchPanel(Issues)
    End Sub

    Private Sub ReturnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnsToolStripMenuItem.Click
        switchPanel(Returns)
    End Sub

    Private Sub LibrariansToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrariansToolStripMenuItem.Click
        switchPanel(Librarians)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        SuperAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        SuperAdmin.Show()
        Me.Hide()
    End Sub
End Class