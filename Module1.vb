Imports System.Data.Odbc

Module Module1

    Public Con As OdbcConnection
    Public DS As DataSet
    Public CMd As OdbcCommand
    Public Rd As OdbcDataReader
    Public da As OdbcDataAdapter
    Public dt As DataTable

    Public MyDB As String
    Public Sub Koneksi()
        Con = New OdbcConnection
        Con.ConnectionString = "dsn=db_uas"
        If Con.State = ConnectionState.Closed Then Con.Open()
    End Sub


End Module