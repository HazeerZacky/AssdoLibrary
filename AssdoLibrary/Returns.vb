Imports MySql.Data.MySqlClient


Public Class Returns
    Dim con As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim last As Integer
    Dim index As Integer = 0 'Record cound
    Dim NumBook = 0
    Dim Fine As Integer

    Public Sub connection()                                                     'Connection Part
        con = New MySqlConnection("server=localhost; user=root; password=; database=assdokalmunai")
        Try
            con.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Display()                                                        'Display Part
        Dim adapter As MySqlDataAdapter
        Dim dt As New DataTable
        connection()
        adapter = New MySqlDataAdapter("SELECT * FROM  issue WHERE 	IssueStatus = 'Enable'", con)
        adapter.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
    End Sub

    Private Sub Display2()                                                        'Display Part
        Dim adapter As MySqlDataAdapter
        Dim dr As New DataTable
        connection()
        adapter = New MySqlDataAdapter("SELECT * FROM  Retur", con)
        adapter.Fill(dr)
        DataGridView2.DataSource = dr.DefaultView
    End Sub

    Public Sub Clear()                                                          'Clear Part
        txtMemID.Text = "ASDM"
        txtMemberName.Clear()
        txtBookID.Text = "ASDB"
        txtBookName.Clear()
        dtpIssueDate.Value = DateTime.Now
        dtpReturnDate.Value = DateTime.Now
        lblIssueID.Text = ""
        txtFime.Clear()
    End Sub

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        Display2()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        lblIssueID.Text = selectedRow.Cells(0).Value.ToString()
        txtMemID.Text = selectedRow.Cells(1).Value.ToString()
        txtMemberName.Text = selectedRow.Cells(2).Value.ToString()
        txtBookID.Text = selectedRow.Cells(3).Value.ToString()
        txtBookName.Text = selectedRow.Cells(4).Value.ToString()
        dtpIssueDate.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Dif As TimeSpan
        Dif = dtpReturnDate.Value.Date - dtpIssueDate.Value.Date
        Dim Days = Dif.Days
        If Days <= 5 Then
            Fine = 0
            txtFime.Text = "No Fine"
        Else
            Fine = Days - 5
            txtFime.Text = "Rs " + Convert.ToString(Fine * 10)
        End If
    End Sub
    Public Sub DecrementBookCount()
        connection()
        cmd = New MySqlCommand("UPDATE book SET Quantity = Quantity + 1 WHERE BookID='" & txtBookID.Text & "'", con)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub Returns()
        connection()
        If (txtMemID.Text = "ASDM" Or txtMemberName.Text = "" Or txtBookID.Text = "" Or txtBookName.Text = "" Or dtpIssueDate.Text = "" Or dtpIssueDate.Text = "" Or dtpReturnDate.Text = "") Then
            MsgBox("Please fill all details")
        Else
            cmd = New MySqlCommand("INSERT INTO retur VALUES('null','" & txtMemID.Text & "','" & txtMemberName.Text & "','" & txtBookID.Text & "','" & txtBookName.Text & "','" & dtpIssueDate.Text & "','" & dtpReturnDate.Text & "', " & Fine & ")", con)
            cmd.ExecuteNonQuery()
            MsgBox("Return details saved sucessfuly")
            DecrementBookCount()
            statusChane()
            Display2()
            Display()
            Clear()
        End If
    End Sub

    Public Sub statusChane()
        connection()
        Dim st = "Disable"
        cmd = New MySqlCommand("UPDATE issue SET 	IssueStatus='" & st & "' WHERE IssueID='" & lblIssueID.Text & "'", con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Returns()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Clear()
    End Sub
End Class