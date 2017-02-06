﻿Imports System.Data.Odbc

Public Class clsRedshift

    Public Structure rs_connection
        Public url As String
        Public username As String
        Public password As String
        Public port As Integer
        Public database As String
    End Structure


    Private objDataConn As Odbc.OdbcConnection

    Public Function GetUsers(conn As rs_connection) As Odbc.OdbcDataReader

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

    Protected Overrides Sub Finalize()




        MyBase.Finalize()
    End Sub
End Class