Public Class ScriptGenerator
    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click

        Try

            Dim objRS As New clsRedshift
            Dim s As clsUtilities.rs_connection

            s.url = Trim(Me.txtUrl.Text)
            s.password = Trim(Me.txtPassword.Text)
            s.username = Trim(Me.txtUserName.Text)
            s.database = Trim(Me.txtDatabase.Text)
            s.port = Trim(Me.txtPort.Text)


            Dim reader As Odbc.OdbcDataReader = objRS.GetSchemas(s)

            While reader.Read()
                cmbSchema.Items.Add(reader("schema_name").ToString)
            End While

            reader.Close()

            objRS.close()

        Catch ex As Exception
            Me.txtConnErrors.Text = ex.Message
        End Try


    End Sub

    Private Sub cmbSchema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSchema.SelectedIndexChanged

        Dim strSchema As String

        strSchema = Me.cmbSchema.SelectedItem.ToString


    End Sub
End Class