﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Usename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usesysid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(109, 43)
        Me.txtUrl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(509, 22)
        Me.txtUrl.TabIndex = 0
        Me.txtUrl.Text = "redshift-test.cayq9aizq1mt.eu-west-1.redshift.amazonaws.com"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 255)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(509, 22)
        Me.TextBox2.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(109, 107)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(256, 22)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Vendetta01"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(109, 75)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(256, 22)
        Me.txtUserName.TabIndex = 3
        Me.txtUserName.Text = "rs_admin"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(109, 139)
        Me.txtDatabase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(256, 22)
        Me.txtDatabase.TabIndex = 5
        Me.txtDatabase.Text = "dev"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 513)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1444, 22)
        Me.TextBox1.TabIndex = 7
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(109, 171)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(256, 22)
        Me.txtPort.TabIndex = 8
        Me.txtPort.Text = "5439"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Usename, Me.usesysid})
        Me.DataGridView1.Location = New System.Drawing.Point(109, 305)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(424, 185)
        Me.DataGridView1.TabIndex = 9
        '
        'Usename
        '
        Me.Usename.HeaderText = "Username"
        Me.Usename.Name = "Usename"
        Me.Usename.ReadOnly = True
        '
        'usesysid
        '
        Me.usesysid.HeaderText = "System ID"
        Me.usesysid.Name = "usesysid"
        Me.usesysid.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(520, 75)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 566)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtUrl)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Main"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUrl As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Usename As DataGridViewTextBoxColumn
    Friend WithEvents usesysid As DataGridViewTextBoxColumn
End Class
