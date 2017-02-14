Imports System.Data.Odbc

Public Class clsRedshift

    Private objDataConn As Odbc.OdbcConnection

    Public Function GetUsers(conn As clsUtilities.rs_connection) As Odbc.OdbcDataReader

        Dim strConn As String

        strConn = "Driver={Amazon Redshift (x64)}; Server=" & conn.url & "; Database=" & conn.database & "; UID=" & conn.username & "; PWD=" & conn.password & "; Port=" & conn.port & ""

        objDataConn = New Odbc.OdbcConnection(strConn)

        objDataConn.Open()


        Dim strSQL As String

        strSQL = "select * from pg_catalog.pg_user"

        Dim objSQL As New Odbc.OdbcCommand(strSQL, objDataConn)

        Return objSQL.ExecuteReader()

        objDataConn.Close()


    End Function

    Public Function close()

        objDataConn.Close()

    End Function


    Public Function GetSchemas(conn As clsUtilities.rs_connection) As Odbc.OdbcDataReader

        Dim strConn As String
        strConn = "Driver={Amazon Redshift (x64)}; Server=" & conn.url & "; Database=" & conn.database & "; UID=" & conn.username & "; PWD=" & conn.password & "; Port=" & conn.port & ""

        objDataConn = New Odbc.OdbcConnection(strConn)
        objDataConn.Open()

        Dim strSQL As String = "select schema_name from information_schema.schemata order by schema_name asc"
        Dim objSQL As New Odbc.OdbcCommand(strSQL, objDataConn)

        Return objSQL.ExecuteReader()

        objDataConn.Close()


    End Function


End Class
