Imports System.Data.Odbc

Public Class clsSQLServer

    Private objDataConn As Odbc.OdbcConnection
    Private strConn As String

    Public Sub New()

        strConn = "Driver={SQL Server}; Server=DESKTOP-C326P95; Database=Octopus; UID=octo_user; PWD=octo_user;"

    End Sub

    Public Function GetUsers(conn As clsUtilities.rs_connection) As Odbc.OdbcDataReader

        objDataConn = New Odbc.OdbcConnection(strConn)

        objDataConn.Open()

        Dim strSQL As String

        strSQL = "select * from pg_catalog.pg_user"

        Dim objSQL As New Odbc.OdbcCommand(strSQL, objDataConn)

        Return objSQL.ExecuteReader()

        objDataConn.Close()


    End Function


    Public Function GetTables() As Odbc.OdbcDataReader

        objDataConn = New Odbc.OdbcConnection(strConn)
        objDataConn.Open()

        Dim strSQL As String = "select * from sys.tables order by name asc"
        Dim objSQL As New Odbc.OdbcCommand(strSQL, objDataConn)

        Return objSQL.ExecuteReader()

        objDataConn.Close()


    End Function

    Public Function GetFields(strTableName As String) As Odbc.OdbcDataReader

        objDataConn = New Odbc.OdbcConnection(strConn)
        objDataConn.Open()

        Dim strSQL As String = "select b.name from sys.tables a inner join sys.all_columns b on a.object_id = b.object_id " &
                                "where a.name  = '" + strTableName + "' order by b.column_id asc"

        Dim objSQL As New Odbc.OdbcCommand(strSQL, objDataConn)

        Return objSQL.ExecuteReader()

        objDataConn.Close()


    End Function


    Public Function close_me()

        If objDataConn.State = 1 Then
            objDataConn.Close()
        End If

    End Function

End Class
