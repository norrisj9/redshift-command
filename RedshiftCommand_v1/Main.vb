Public Class Main

    Private Structure rs_connection
        Public url As String
        Public username As String
        Public password As String
        Public port As Integer
        Public database As String
    End Structure


    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


        Dim objRS As New clsRedshift
        Dim s As clsUtilities.rs_connection

        s.url = txtUrl.Text
        s.password = Trim(Me.txtPassword.Text)
        s.username = Trim(Me.txtUserName.Text)
        s.database = Trim(Me.txtDatabase.Text)
        s.port = Trim(Me.txtPort.Text)


        Dim reader As Odbc.OdbcDataReader = objRS.GetUsers(s)

        While reader.Read()

            Dim i As Integer = Me.DataGridView1.Rows.Add()
            Dim row As DataGridViewRow = DataGridView1.Rows(i)

            row.Cells("usename").Value = reader("usename").ToString
            row.Cells("usesysid").Value = reader("usesysid").ToString


        End While

        reader.Close()

        objRS.close()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
