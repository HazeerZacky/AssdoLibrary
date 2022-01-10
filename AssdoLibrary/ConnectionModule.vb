Imports MySql.Data.MySqlClient
Module ConnectionModule
    Public Conn As New MySqlConnection
    Dim Result As Boolean
    Dim StrConn As String
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim last As Integer
    Dim index As Integer = 0 'Record cound

    Public Function OpenDB() As Boolean
        Try
            If Conn.State = ConnectionState.Closed Then
                StrConn = "server=localhost; user=root; password=; database=assdokalmunai"
                Conn.ConnectionString = StrConn
                Conn.Open()
                Result = True
            End If
        Catch ex As Exception
            Result = False
        End Try
        Return Result
    End Function

End Module
