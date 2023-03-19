<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim lblUserName As System.Windows.Forms.Label
        Dim lblUserPwd As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnLogExit = New System.Windows.Forms.Button()
        Me.pctPwd = New System.Windows.Forms.PictureBox()
        Me.pctUsername = New System.Windows.Forms.PictureBox()
        Me.txtUserPwd = New System.Windows.Forms.TextBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllegroDatabaseDataSet = New Allegro.AllegroDatabaseDataSet()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.pctLogo = New System.Windows.Forms.PictureBox()
        Me.lblAllegro = New System.Windows.Forms.Label()
        Me.UserTableAdapter = New Allegro.AllegroDatabaseDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New Allegro.AllegroDatabaseDataSetTableAdapters.TableAdapterManager()
        lblUserName = New System.Windows.Forms.Label()
        lblUserPwd = New System.Windows.Forms.Label()
        Me.pnlLogin.SuspendLayout()
        CType(Me.pctPwd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllegroDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        lblUserName.AutoSize = True
        lblUserName.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblUserName.Location = New System.Drawing.Point(48, 79)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New System.Drawing.Size(67, 15)
        lblUserName.TabIndex = 6
        lblUserName.Text = "Username"
        '
        'lblUserPwd
        '
        lblUserPwd.AutoSize = True
        lblUserPwd.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUserPwd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblUserPwd.Location = New System.Drawing.Point(48, 132)
        lblUserPwd.Name = "lblUserPwd"
        lblUserPwd.Size = New System.Drawing.Size(66, 15)
        lblUserPwd.TabIndex = 7
        lblUserPwd.Text = "Password"
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.pnlLogin.Controls.Add(Me.btnLogExit)
        Me.pnlLogin.Controls.Add(Me.pctPwd)
        Me.pnlLogin.Controls.Add(Me.pctUsername)
        Me.pnlLogin.Controls.Add(lblUserPwd)
        Me.pnlLogin.Controls.Add(Me.txtUserPwd)
        Me.pnlLogin.Controls.Add(lblUserName)
        Me.pnlLogin.Controls.Add(Me.txtUserName)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.lblLogin)
        Me.pnlLogin.Location = New System.Drawing.Point(225, 72)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(348, 280)
        Me.pnlLogin.TabIndex = 0
        '
        'btnLogExit
        '
        Me.btnLogExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnLogExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogExit.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogExit.Location = New System.Drawing.Point(179, 190)
        Me.btnLogExit.Name = "btnLogExit"
        Me.btnLogExit.Size = New System.Drawing.Size(119, 29)
        Me.btnLogExit.TabIndex = 3
        Me.btnLogExit.Text = "&Exit"
        Me.btnLogExit.UseVisualStyleBackColor = False
        '
        'pctPwd
        '
        Me.pctPwd.Image = CType(resources.GetObject("pctPwd.Image"), System.Drawing.Image)
        Me.pctPwd.Location = New System.Drawing.Point(18, 150)
        Me.pctPwd.Name = "pctPwd"
        Me.pctPwd.Size = New System.Drawing.Size(24, 21)
        Me.pctPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPwd.TabIndex = 10
        Me.pctPwd.TabStop = False
        '
        'pctUsername
        '
        Me.pctUsername.Image = CType(resources.GetObject("pctUsername.Image"), System.Drawing.Image)
        Me.pctUsername.Location = New System.Drawing.Point(18, 94)
        Me.pctUsername.Name = "pctUsername"
        Me.pctUsername.Size = New System.Drawing.Size(24, 21)
        Me.pctUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctUsername.TabIndex = 9
        Me.pctUsername.TabStop = False
        '
        'txtUserPwd
        '
        Me.txtUserPwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserPwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "UserPwd", True))
        Me.txtUserPwd.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPwd.Location = New System.Drawing.Point(48, 153)
        Me.txtUserPwd.MaxLength = 25
        Me.txtUserPwd.Name = "txtUserPwd"
        Me.txtUserPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserPwd.Size = New System.Drawing.Size(250, 15)
        Me.txtUserPwd.TabIndex = 1
        Me.txtUserPwd.UseSystemPasswordChar = True
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.AllegroDatabaseDataSet
        '
        'AllegroDatabaseDataSet
        '
        Me.AllegroDatabaseDataSet.DataSetName = "AllegroDatabaseDataSet"
        Me.AllegroDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "UserName", True))
        Me.txtUserName.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(48, 97)
        Me.txtUserName.MaxLength = 25
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(250, 15)
        Me.txtUserName.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(48, 190)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(119, 29)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLogin.Location = New System.Drawing.Point(82, 15)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(183, 19)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Log Into Your Account"
        '
        'pctLogo
        '
        Me.pctLogo.Image = CType(resources.GetObject("pctLogo.Image"), System.Drawing.Image)
        Me.pctLogo.Location = New System.Drawing.Point(12, 12)
        Me.pctLogo.Name = "pctLogo"
        Me.pctLogo.Size = New System.Drawing.Size(71, 73)
        Me.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctLogo.TabIndex = 1
        Me.pctLogo.TabStop = False
        '
        'lblAllegro
        '
        Me.lblAllegro.AutoSize = True
        Me.lblAllegro.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllegro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAllegro.Location = New System.Drawing.Point(21, 88)
        Me.lblAllegro.Name = "lblAllegro"
        Me.lblAllegro.Size = New System.Drawing.Size(55, 16)
        Me.lblAllegro.TabIndex = 2
        Me.lblAllegro.Text = "Allegro"
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Allegro.AllegroDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnLogExit
        Me.ClientSize = New System.Drawing.Size(784, 415)
        Me.Controls.Add(Me.lblAllegro)
        Me.Controls.Add(Me.pctLogo)
        Me.Controls.Add(Me.pnlLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allegro"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.pctPwd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllegroDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblLogin As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents pctLogo As PictureBox
    Friend WithEvents lblAllegro As Label
    Friend WithEvents AllegroDatabaseDataSet As AllegroDatabaseDataSet
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As AllegroDatabaseDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As AllegroDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtUserPwd As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents pctPwd As PictureBox
    Friend WithEvents pctUsername As PictureBox
    Friend WithEvents btnLogExit As Button
End Class
