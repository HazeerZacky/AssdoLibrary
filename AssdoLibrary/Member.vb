Imports MySql.Data.MySqlClient
Imports System.Data.DataTable

Public Class Member
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
        adapter = New MySqlDataAdapter("SELECT * FROM member", con)
        adapter.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
    End Sub

    Public Sub Clear()                                                          'Clear Part
        txtMemID.Text = "ASDM"
        txtName.Clear()
        txtAddress.Clear()
        txtPhoneNo.Clear()
    End Sub

    Public Sub Insert()                                                         'Insert Part
        connection()
        If (txtMemID.Text = "ASDM" Or txtName.Text = "" Or txtAddress.Text = "" Or txtPhoneNo.Text = "") Then
            MsgBox("Please fill all details")
        Else
            cmd = New MySqlCommand("INSERT INTO member VALUES('" & txtMemID.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhoneNo.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Member details saved sucessfuly")
            Clear()
            Display()
            laser()
        End If

    End Sub

    Public Sub Search()                                                         'Search Part
        connection()
        cmd = New MySqlCommand("SELECT * FROM member WHERE MemID='" & txtMemID.Text & "' ", con)
        reader = cmd.ExecuteReader()
        reader.Read()
        If (reader.HasRows) Then
            txtName.Text = reader(1)
            txtAddress.Text = reader(2)
            txtPhoneNo.Text = reader(3)
        Else
            MsgBox("Data is not found")
        End If
    End Sub

    Public Sub Update()                                                         'Update Part
        connection()
        If (txtMemID.Text = "ASDM" Or txtName.Text = "" Or txtAddress.Text = "" Or txtPhoneNo.Text = "") Then
            MsgBox("Please fill all details")
        Else
            cmd = New MySqlCommand("UPDATE member SET MemName='" & txtName.Text & "', MemAddress='" & txtAddress.Text & "', MemPhoneNo='" & txtPhoneNo.Text & "' WHERE MemID='" & txtMemID.Text & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Member details update sucessfuly")
            Display()
            laser()
            Clear()
        End If

    End Sub

    Public Sub showRecord(ByVal i As Integer)                                   'Last Record View Part
        connection()
        cmd = New MySqlCommand("SELECT * FROM member", con)
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


    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        laser()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        txtMemID.Text = selectedRow.Cells(0).Value.ToString()
        txtName.Text = selectedRow.Cells(1).Value.ToString()
        txtAddress.Text = selectedRow.Cells(2).Value.ToString()
        txtPhoneNo.Text = selectedRow.Cells(3).Value.ToString()
    End Sub
End Class