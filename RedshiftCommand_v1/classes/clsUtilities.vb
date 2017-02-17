Imports System.Data.Odbc

Public Class clsUtilities

    Public Structure rs_connection
        Public url As String
        Public username As String
        Public password As String
        Public port As Integer
        Public database As String
    End Structure


    Public Function CreateView(strViewName As String, strTargetSchema As String, objReader As OdbcDataReader) As String

        Dim strSQL As String, strGrant As String
        Dim arrFieldNames As New ArrayList

        strSQL = "DROP view if exists " & strTargetSchema & "." & strViewName & ";" + vbCrLf
        strSQL += vbCrLf
        strSQL += "CREATE view " & strViewName & "(" + vbCrLf


        While objReader.Read()
            arrFieldNames.Add(objReader("name").ToString)
        End While

        Dim intCount As Integer = arrFieldNames.Count
        Dim i As Integer = -1

        For Each x In arrFieldNames
            i += 1
            If i < intCount - 1 Then
                strSQL += UCase(x) + "," + vbCrLf  'Add comma after end of field
            Else
                strSQL += UCase(x) + vbCrLf        'Don't add commma
            End If
        Next

        strSQL += ");" + vbCrLf + vbCrLf

        strGrant = "GRANT all on " & strTargetSchema & "." & strViewName & " to talend_process;" + vbCrLf
        strGrant += "GRANT all on " & strTargetSchema & "." & strViewName & " to group rs_developers;"

        Return strSQL + strGrant

    End Function


    Public Function CreateView(strViewName As String, arrFieldNames As ArrayList) As String

        Dim strSQL As String, strGrant As String

        strSQL = "DROP view if exists " & strViewName & ";" + vbCrLf
        strSQL += vbCrLf
        strSQL += "CREATE view " & strViewName & "(" + vbCrLf

        Dim intCount As Integer = arrFieldNames.Count
        Dim i As Integer = -1

        For Each x In arrFieldNames
            i += 1
            If i < intCount - 1 Then
                strSQL += UCase(x) + "," + vbCrLf  'Add comma after end of field
            Else
                strSQL += UCase(x) + vbCrLf        'Don't add commma
            End If
        Next

        strSQL += ");" + vbCrLf + vbCrLf

        strGrant = "GRANT all on " & strViewName & " to talend_process;" + vbCrLf
        strGrant += "GRANT all on " & strViewName & " to group rs_developers;"

        Return strSQL + strGrant

    End Function

End Class
