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

    Private Sub ScriptGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim a As New Configuration.AppSettingsReader

        Me.txtUrl.Text = a.GetValue("last_redshift_url", GetType(String)).ToString
        Me.txtPort.Text = a.GetValue("redshift_port", GetType(String)).ToString
        Me.txtUserName.Text = a.GetValue("redshift_username", GetType(String)).ToString
        Me.txtDatabase.Text = a.GetValue("redshift_db", GetType(String)).ToString

    End Sub

    Private Sub cmdCreateView_Click(sender As Object, e As EventArgs) Handles cmdCreateView.Click

        Dim objSQL As New clsSQLServer

        Dim strTable As String = Me.lstTables.SelectedItem.ToString
        Dim strTargetSchema As String = Trim(Me.txtTargetSchema.Text)

        Dim reader As Odbc.OdbcDataReader = objSQL.GetFields(strTable)


        Dim ss As New clsUtilities()
        Me.txtSQL.Text = ""
        Me.txtSQL.Text = ss.CreateView("vw_" & strTable, strTargetSchema, reader)

        objSQL.close_me()


    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        Dim objFile As New IO.StreamWriter(SaveFileDialog1.FileName)

        If Me.txtSQL.Text <> "" Then
            objFile.Write(Me.txtSQL.Text)
        End If

        objFile.Close()

    End Sub

    Private Sub cmdSaveToFile_Click(sender As Object, e As EventArgs) Handles cmdSaveToFile.Click

        Me.SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim objSQL As New clsSQLServer
        Dim reader As Odbc.OdbcDataReader = objSQL.GetTables()

        While reader.Read()

            Me.lstTables.Items.Add(reader("name").ToString)

        End While

        reader.Close()

        objSQL.close_me()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim objSQL As New clsSQLServer

        Dim strTable As String = Me.lstTables.SelectedItem.ToString
        Dim strTargetSchema As String = Trim(Me.txtTargetSchema.Text)

        ListView1.Columns.Clear()

        Dim objReader As Odbc.OdbcDataReader = objSQL.GetFields(strTable)

        ListView1.Columns.Add("Name")

        ListView1.Columns(0).Width = 160
        ListView1.CheckBoxes = True


        While objReader.Read()
            Me.ListView1.Items.Add(objReader("name").ToString)
        End While


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim ggg As CheckedListBox.CheckedIndexCollection

        ggg = ListView1.CheckedItems

        For Each d In ggg

        Next


    End Sub
End Class