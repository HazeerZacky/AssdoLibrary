Imports MySql.Data.MySqlClient
Imports System.Data.DataTable

Public Class Librarians
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
        adapter = New MySqlDataAdapter("SELECT * FROM librarian", con)
        adapter.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
    End Sub

    Public Sub Clear()                                                          'Clear Part
        txtLID.Text = "LIB"
        txtName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        txtPassword.Clear()
    End Sub

    Public Sub Insert()                                                         'Insert Part
        If (txtLID.Text = "LIB" Or txtName.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Or txtAddress.Text = "" Or txtPassword.Text = "") Then
            MsgBox("Please fill all details")
        Else
            connection()
            cmd = New MySqlCommand("INSERT INTO librarian VALUES('" & txtLID.Text & "','" & txtName.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "','" & txtAddress.Text & "','" & txtPassword.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian details saved sucessfuly")
            Clear()
            Display()
            laser()
        End If

    End Sub

    Public Sub Update()                                                         'Update Part
        If (txtLID.Text = "LIB" Or txtName.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Or txtAddress.Text = "" Or txtPassword.Text = "") Then
            MsgBox("Please fill all details")
        Else
            connection()
            cmd = New MySqlCommand("UPDATE librarian SET Username='" & txtName.Text & "', PhoneNo='" & txtPhone.Text & "', Email='" & txtEmail.Text & "', Address='" & txtAddress.Text & "', Password='" & txtPassword.Text & "' WHERE LibID ='" & txtLID.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian details update sucessfuly")
            Display()
            laser()
            Clear()
        End If

    End Sub

    Public Sub Delete()                                                         'Update Part
        connection()
        cmd = New MySqlCommand("DELETE From librarian WHERE LibID ='" & txtLID.Text & "'", con)
        cmd.ExecuteNonQuery()
        MsgBox("Librarian details sucessfuly deleted")
        Display()
        Clear()
        laser()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        txtLID.Text = selectedRow.Cells(0).Value.ToString()
        txtName.Text = selectedRow.Cells(1).Value.ToString()
        txtPhone.Text = selectedRow.Cells(2).Value.ToString()
        txtEmail.Text = selectedRow.Cells(3).Value.ToString()
        txtAddress.Text = selectedRow.Cells(4).Value.ToString()
        txtPassword.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Public Sub showRecord(ByVal i As Integer)                                   'Last Record View Part
        connection()
        cmd = New MySqlCommand("SELECT * FROM librarian", con)
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

    Private Sub Librarians_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        laser()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class