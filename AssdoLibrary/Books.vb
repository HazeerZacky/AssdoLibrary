Imports MySql.Data.MySqlClient

Public Class Books
    Dim con As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim last As Integer
    Dim index As Integer = 0 'Record cound

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
        adapter = New MySqlDataAdapter("SELECT * FROM book", con)
        adapter.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
    End Sub

    Public Sub Clear()                                                          'Clear Part
        txtBookID.Text = "ASDB"
        txtName.Clear()
        txtPublisher.Clear()
        txtAurhor.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()

    End Sub

    Public Sub Insert()                                                         'Insert Part
        connection()
        If (txtBookID.Text = "ASDB" Or txtName.Text = "" Or txtAurhor.Text = "" Or txtPrice.Text = "" Or txtPublisher.Text = "" Or txtQuantity.Text = "") Then
            MsgBox("Please fill all details")
        Else
            cmd = New MySqlCommand("INSERT INTO book VALUES('" & txtBookID.Text & "','" & txtName.Text & "','" & txtPublisher.Text & "','" & txtAurhor.Text & "','" & txtPrice.Text & "','" & txtQuantity.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("book details saved sucessfuly")
            Clear()
            Display()
            laser()
        End If

    End Sub

    Public Sub Search()                                                         'Search Part
        connection()
        cmd = New MySqlCommand("SELECT * FROM book WHERE BookID='" & txtBookID.Text & "' ", con)
        reader = cmd.ExecuteReader()
        reader.Read()
        If (reader.HasRows) Then
            txtName.Text = reader(1)
            txtAurhor.Text = reader(2)
            txtPublisher.Text = reader(3)
            txtPrice.Text = reader(4)
            txtQuantity.Text = reader(5)
        Else
            MsgBox("Data is not found")
        End If
    End Sub

    Public Sub Update()                                                         'Update Part
        connection()
        If (txtBookID.Text = "ASDB" Or txtName.Text = "" Or txtAurhor.Text = "" Or txtPrice.Text = "" Or txtPublisher.Text = "" Or txtQuantity.Text = "") Then
            MsgBox("Please fill all details")
        Else
            cmd = New MySqlCommand("UPDATE book SET NookName='" & txtName.Text & "', Author='" & txtAurhor.Text & "', Publisher='" & txtPublisher.Text & "', Price='" & txtPrice.Text & "', Quantity='" & txtQuantity.Text & "' WHERE BookID='" & txtBookID.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Book details update sucessfuly")
            Display()
            Clear()
            laser()
        End If
    End Sub

    Public Sub showRecord(ByVal i As Integer)                                   'Last Record View Part
        connection()
        cmd = New MySqlCommand("SELECT * FROM book", con)
        Dim adapter As MySqlDataAdapter
        Dim dtable As New DataTable
        adapter = New MySqlDataAdapter(cmd)
        adapter.Fill(dtable)
        lblLastID.Text = "Last Enterd ID : " + dtable.Rows(i)(0)
    End Sub

    Public Sub laser()
        Dim lastIndex As Integer
        lastIndex = DataGridView1.RowCount - 2
        showRecord(lastIndex)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        txtBookID.Text = selectedRow.Cells(0).Value.ToString()
        txtName.Text = selectedRow.Cells(1).Value.ToString()
        txtAurhor.Text = selectedRow.Cells(2).Value.ToString()
        txtPublisher.Text = selectedRow.Cells(3).Value.ToString()
        txtPrice.Text = selectedRow.Cells(4).Value.ToString()
        txtQuantity.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        laser()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub gbBook_Enter(sender As Object, e As EventArgs) Handles gbBook.Enter

    End Sub
End Class