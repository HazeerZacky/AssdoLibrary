Imports MySql.Data.MySqlClient

Public Class Issues

    Dim con As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim last As Integer
    Dim index As Integer = 0 'Record cound
    Dim NumBook = 0
    Dim bookid As String = "" 'book

    Public Sub connection()                                                     'Connection Part
        con = New MySqlConnection("server=localhost; user=root; password=; database=assdokalmunai")
        Try
            con.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Display()                                                        'Display Part
        Dim adapter As MySqlDataAdapter
        Dim dt As New DataTable
        connection()
        adapter = New MySqlDataAdapter("SELECT * FROM  issue", con)
        adapter.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
    End Sub

    Public Sub Clear()                                                          'Clear Part
        txtMemID.Text = "ASDM"
        txtMemberName.Clear()
        txtBookID.Text = "ASDB"
        txtBookName.Clear()
        DateTimePicker1.Value = DateTime.Now

    End Sub

    Public Sub SearchMember()                                                         'Search Part
        connection()
        cmd = New MySqlCommand("SELECT 	* FROM member WHERE MemID='" & txtMemID.Text & "' ", con)
        reader = cmd.ExecuteReader()
        reader.Read()
        If (reader.HasRows) Then
            txtMemberName.Text = reader(1)
        Else
            MsgBox("Data is not found")
        End If
    End Sub

    Public Sub SearchBook()                                                         'Search Part
        connection()
        cmd = New MySqlCommand("SELECT 	* FROM book WHERE BookID='" & txtBookID.Text & "' ", con)
        reader = cmd.ExecuteReader()
        reader.Read()
        If (reader.HasRows) Then
            bookid = reader(0)
            txtBookName.Text = reader(1)

        Else
            MsgBox("Data is not found")
        End If
    End Sub

    Public Sub CountBook()
        Try
            connection()
            cmd = New MySqlCommand("SELECT COUNT(*) FROM issue WHERE MemID=('" & txtMemID.Text & "') AND IssueStatus = 'Enable'", con)
            'cmd.ExecuteNonQuery()
            NumBook = cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DecrementBookCount()
        connection()
        cmd = New MySqlCommand("UPDATE book SET Quantity = Quantity - 1 WHERE BookID='" & bookid & "'", con)
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub Insert()                                                         'Insert Part
        CountBook()
        If (txtMemID.Text = "ASDM" Or txtMemberName.Text = "" Or txtBookID.Text = "" Or txtBookName.Text = "" Or DateTimePicker1.Text = "") Then
            MsgBox("Please fill all details")
        Else
            If txtBookID.Text = "" Or txtBookName.Text = "" Or txtMemID.Text = "" Or txtMemberName.Text = "" Then
                MsgBox("Missing Information")
            ElseIf NumBook = 5 Then
                MsgBox("Reache Limit")
            Else
                connection()

                Dim Status = "Enable"
                cmd = New MySqlCommand("INSERT INTO issue VALUES('null','" & txtMemID.Text & "','" & txtMemberName.Text & "','" & txtBookID.Text & "','" & txtBookName.Text & "','" & DateTimePicker1.Text & "','" & Status & "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Issue details saved sucessfuly")
                DecrementBookCount()
                Clear()
                Display()
            End If
        End If

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
        DateTimePicker1.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Public Sub Update()                                                         'Update Part
        connection()
        If (txtMemID.Text = "ASDM" Or txtMemberName.Text = "" Or txtBookID.Text = "" Or txtBookName.Text = "" Or DateTimePicker1.Text = "") Then
            MsgBox("Please fill all details")
        Else
            cmd = New MySqlCommand("UPDATE issue SET MemID='" & txtMemID.Text & "', MemberName='" & txtMemberName.Text & "', BookID='" & txtBookID.Text & "', BookName='" & txtBookName.Text & "', 	IssueDate='" & DateTimePicker1.Text & "' WHERE IssueID='" & lblIssueID.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Issue details update sucessfuly")
            Display()
            Clear()
        End If

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnMemFind.Click
        SearchMember()
    End Sub

    Private Sub btnBkFind_Click(sender As Object, e As EventArgs) Handles btnBkFind.Click
        SearchBook()
    End Sub

    Private Sub Issues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class