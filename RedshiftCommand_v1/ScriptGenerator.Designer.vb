<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScriptGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDataSource = New System.Windows.Forms.TextBox()
        Me.lblDataSources = New System.Windows.Forms.Label()
        Me.lblSchema = New System.Windows.Forms.Label()
        Me.cmbSchema = New System.Windows.Forms.ComboBox()
        Me.lstTables = New System.Windows.Forms.ListBox()
        Me.lblTables = New System.Windows.Forms.Label()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.grpConnection = New System.Windows.Forms.GroupBox()
        Me.txtConnErrors = New System.Windows.Forms.TextBox()
        Me.grpConnection.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDataSource
        '
        Me.txtDataSource.Location = New System.Drawing.Point(105, 19)
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(282, 22)
        Me.txtDataSource.TabIndex = 0
        '
        'lblDataSources
        '
        Me.lblDataSources.AutoSize = True
        Me.lblDataSources.Location = New System.Drawing.Point(12, 22)
        Me.lblDataSources.Name = "lblDataSources"
        Me.lblDataSources.Size = New System.Drawing.Size(91, 17)
        Me.lblDataSources.TabIndex = 1
        Me.lblDataSources.Text = "Data Source:"
        '
        'lblSchema
        '
        Me.lblSchema.AutoSize = True
        Me.lblSchema.Location = New System.Drawing.Point(12, 50)
        Me.lblSchema.Name = "lblSchema"
        Me.lblSchema.Size = New System.Drawing.Size(63, 17)
        Me.lblSchema.TabIndex = 3
        Me.lblSchema.Text = "Schema:"
        '
        'cmbSchema
        '
        Me.cmbSchema.FormattingEnabled = True
        Me.cmbSchema.Items.AddRange(New Object() {"load", "process", "comsume"})
        Me.cmbSchema.Location = New System.Drawing.Point(105, 47)
        Me.cmbSchema.Name = "cmbSchema"
        Me.cmbSchema.Size = New System.Drawing.Size(282, 24)
        Me.cmbSchema.TabIndex = 4
        '
        'lstTables
        '
        Me.lstTables.FormattingEnabled = True
        Me.lstTables.ItemHeight = 16
        Me.lstTables.Location = New System.Drawing.Point(105, 77)
        Me.lstTables.Name = "lstTables"
        Me.lstTables.Size = New System.Drawing.Size(282, 404)
        Me.lstTables.TabIndex = 5
        '
        'lblTables
        '
        Me.lblTables.AutoSize = True
        Me.lblTables.Location = New System.Drawing.Point(12, 77)
        Me.lblTables.Name = "lblTables"
        Me.lblTables.Size = New System.Drawing.Size(55, 17)
        Me.lblTables.TabIndex = 6
        Me.lblTables.Text = "Tables:"
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(325, 63)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(81, 26)
        Me.cmdConnect.TabIndex = 7
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(20, 159)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(115, 22)
        Me.txtPort.TabIndex = 15
        Me.txtPort.Text = "5439"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(20, 127)
        Me.txtDatabase.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(115, 22)
        Me.txtDatabase.TabIndex = 14
        Me.txtDatabase.Text = "dev"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(20, 63)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(115, 22)
        Me.txtUserName.TabIndex = 13
        Me.txtUserName.Text = "rs_admin"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(20, 95)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(115, 22)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.Text = "Vendetta01"
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(20, 31)
        Me.txtUrl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(386, 22)
        Me.txtUrl.TabIndex = 11
        Me.txtUrl.Text = "redshift-test.cayq9aizq1mt.eu-west-1.redshift.amazonaws.com"
        '
        'grpConnection
        '
        Me.grpConnection.Controls.Add(Me.txtConnErrors)
        Me.grpConnection.Controls.Add(Me.txtUrl)
        Me.grpConnection.Controls.Add(Me.txtPort)
        Me.grpConnection.Controls.Add(Me.cmdConnect)
        Me.grpConnection.Controls.Add(Me.txtDatabase)
        Me.grpConnection.Controls.Add(Me.txtPassword)
        Me.grpConnection.Controls.Add(Me.txtUserName)
        Me.grpConnection.Location = New System.Drawing.Point(719, 19)
        Me.grpConnection.Name = "grpConnection"
        Me.grpConnection.Size = New System.Drawing.Size(432, 302)
        Me.grpConnection.TabIndex = 16
        Me.grpConnection.TabStop = False
        Me.grpConnection.Text = "Connection Details:"
        '
        'txtConnErrors
        '
        Me.txtConnErrors.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConnErrors.Location = New System.Drawing.Point(20, 203)
        Me.txtConnErrors.Multiline = True
        Me.txtConnErrors.Name = "txtConnErrors"
        Me.txtConnErrors.Size = New System.Drawing.Size(386, 74)
        Me.txtConnErrors.TabIndex = 17
        '
        'ScriptGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 780)
        Me.Controls.Add(Me.grpConnection)
        Me.Controls.Add(Me.lblTables)
        Me.Controls.Add(Me.lstTables)
        Me.Controls.Add(Me.cmbSchema)
        Me.Controls.Add(Me.lblSchema)
        Me.Controls.Add(Me.lblDataSources)
        Me.Controls.Add(Me.txtDataSource)
        Me.Name = "ScriptGenerator"
        Me.Text = "ScriptGenerator"
        Me.grpConnection.ResumeLayout(False)
        Me.grpConnection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDataSource As TextBox
    Friend WithEvents lblDataSources As Label
    Friend WithEvents lblSchema As Label
    Friend WithEvents cmbSchema As ComboBox
    Friend WithEvents lstTables As ListBox
    Friend WithEvents lblTables As Label
    Friend WithEvents cmdConnect As Button
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents grpConnection As GroupBox
    Friend WithEvents txtConnErrors As TextBox
End Class
