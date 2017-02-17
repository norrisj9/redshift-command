<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScriptGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.cmdCreateView = New System.Windows.Forms.Button()
        Me.cmdSaveToFile = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTargetSchema = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grpConnection.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.lstTables.Size = New System.Drawing.Size(282, 212)
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
        Me.cmdConnect.Location = New System.Drawing.Point(473, 63)
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
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(20, 127)
        Me.txtDatabase.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(115, 22)
        Me.txtDatabase.TabIndex = 14
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(20, 63)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(115, 22)
        Me.txtUserName.TabIndex = 13
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
        Me.txtUrl.Size = New System.Drawing.Size(534, 22)
        Me.txtUrl.TabIndex = 11
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
        Me.grpConnection.Size = New System.Drawing.Size(573, 302)
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
        Me.txtConnErrors.Size = New System.Drawing.Size(534, 74)
        Me.txtConnErrors.TabIndex = 17
        '
        'txtSQL
        '
        Me.txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSQL.Location = New System.Drawing.Point(22, 21)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSQL.Size = New System.Drawing.Size(822, 385)
        Me.txtSQL.TabIndex = 18
        '
        'cmdCreateView
        '
        Me.cmdCreateView.Location = New System.Drawing.Point(393, 259)
        Me.cmdCreateView.Name = "cmdCreateView"
        Me.cmdCreateView.Size = New System.Drawing.Size(111, 29)
        Me.cmdCreateView.TabIndex = 20
        Me.cmdCreateView.Text = "Create View"
        Me.cmdCreateView.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdCreateView.UseVisualStyleBackColor = True
        '
        'cmdSaveToFile
        '
        Me.cmdSaveToFile.Location = New System.Drawing.Point(1162, 359)
        Me.cmdSaveToFile.Name = "cmdSaveToFile"
        Me.cmdSaveToFile.Size = New System.Drawing.Size(111, 29)
        Me.cmdSaveToFile.TabIndex = 21
        Me.cmdSaveToFile.Text = "Save"
        Me.cmdSaveToFile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSaveToFile.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "sql"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(393, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTargetSchema
        '
        Me.txtTargetSchema.Location = New System.Drawing.Point(558, 266)
        Me.txtTargetSchema.Name = "txtTargetSchema"
        Me.txtTargetSchema.Size = New System.Drawing.Size(133, 22)
        Me.txtTargetSchema.TabIndex = 23
        Me.txtTargetSchema.Text = "consume"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(555, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Target Schema:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(105, 317)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(937, 615)
        Me.TabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(929, 586)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtSQL)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(929, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(393, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 29)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Create View"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(31, 17)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(405, 324)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(393, 171)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 29)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Create View"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ScriptGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 932)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTargetSchema)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdSaveToFile)
        Me.Controls.Add(Me.cmdCreateView)
        Me.Controls.Add(Me.grpConnection)
        Me.Controls.Add(Me.lblTables)
        Me.Controls.Add(Me.lstTables)
        Me.Controls.Add(Me.cmbSchema)
        Me.Controls.Add(Me.lblSchema)
        Me.Controls.Add(Me.lblDataSources)
        Me.Controls.Add(Me.txtDataSource)
        Me.Name = "ScriptGenerator"
        Me.grpConnection.ResumeLayout(False)
        Me.grpConnection.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
    Friend WithEvents txtSQL As TextBox
    Friend WithEvents cmdCreateView As Button
    Friend WithEvents cmdSaveToFile As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTargetSchema As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button3 As Button
End Class
