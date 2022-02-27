<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnLogin1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewUser = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MORGUE_DATABASEDataSet = New Morgue_Management_System_Project.MORGUE_DATABASEDataSet()
        Me.Login_1_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login_1_TBTableAdapter = New Morgue_Management_System_Project.MORGUE_DATABASEDataSetTableAdapters.Login_1_TBTableAdapter()
        Me.TableAdapterManager = New Morgue_Management_System_Project.MORGUE_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.txtVerifyPassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblVerifyNewPassword = New System.Windows.Forms.Label()
        Me.pbThumb = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.MORGUE_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login_1_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Baskerville Old Face", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(-40, -27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(276, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "MORGUE MANAGEMENT SYSTEM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(313, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "copyright"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(208, 472)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Ver. 0.1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(66, 472)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Morgue Management System "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(147, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnLogin1
        '
        Me.btnLogin1.BackColor = System.Drawing.Color.LimeGreen
        Me.btnLogin1.Location = New System.Drawing.Point(231, 359)
        Me.btnLogin1.Name = "btnLogin1"
        Me.btnLogin1.Size = New System.Drawing.Size(76, 23)
        Me.btnLogin1.TabIndex = 17
        Me.btnLogin1.Text = "APPLY"
        Me.btnLogin1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label3.Location = New System.Drawing.Point(-1, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(383, 39)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ADMIN PASSWORD CHANGE"
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.BackColor = System.Drawing.Color.Black
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(147, 120)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(160, 20)
        Me.txtCurrentPassword.TabIndex = 15
        Me.txtCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurrentName
        '
        Me.txtCurrentName.BackColor = System.Drawing.Color.Black
        Me.txtCurrentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCurrentName.Location = New System.Drawing.Point(149, 82)
        Me.txtCurrentName.Name = "txtCurrentName"
        Me.txtCurrentName.Size = New System.Drawing.Size(158, 20)
        Me.txtCurrentName.TabIndex = 14
        Me.txtCurrentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(2, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "CURRENT  _  PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(2, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "CURRENT  _  USERNAME"
        '
        'txtNewUser
        '
        Me.txtNewUser.BackColor = System.Drawing.Color.Black
        Me.txtNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNewUser.Location = New System.Drawing.Point(147, 156)
        Me.txtNewUser.Name = "txtNewUser"
        Me.txtNewUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(45)
        Me.txtNewUser.Size = New System.Drawing.Size(160, 20)
        Me.txtNewUser.TabIndex = 24
        Me.txtNewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.Black
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(147, 194)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(160, 20)
        Me.txtNewPassword.TabIndex = 25
        Me.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(42, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "NEW USERNAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(42, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "NEW PASSWORD"
        '
        'MORGUE_DATABASEDataSet
        '
        Me.MORGUE_DATABASEDataSet.DataSetName = "MORGUE_DATABASEDataSet"
        Me.MORGUE_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Login_1_TBBindingSource
        '
        Me.Login_1_TBBindingSource.DataMember = "Login_1_TB"
        Me.Login_1_TBBindingSource.DataSource = Me.MORGUE_DATABASEDataSet
        '
        'Login_1_TBTableAdapter
        '
        Me.Login_1_TBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bills_TBTableAdapter = Nothing
        Me.TableAdapterManager.Chamber_TBTableAdapter = Nothing
        Me.TableAdapterManager.Login_1_TBTableAdapter = Me.Login_1_TBTableAdapter
        Me.TableAdapterManager.Miscellaneous_TBTableAdapter = Nothing
        Me.TableAdapterManager.Person_Deceased_TBTableAdapter = Nothing
        Me.TableAdapterManager.Staff_TBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Morgue_Management_System_Project.MORGUE_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.BackColor = System.Drawing.Color.Black
        Me.txtVerifyPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerifyPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtVerifyPassword.Location = New System.Drawing.Point(147, 229)
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtVerifyPassword.Size = New System.Drawing.Size(160, 20)
        Me.txtVerifyPassword.TabIndex = 28
        Me.txtVerifyPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Lime
        Me.Label10.Location = New System.Drawing.Point(0, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "VERIFY NEW PASSWORD"
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPassword.ForeColor = System.Drawing.Color.Red
        Me.lblNewPassword.Location = New System.Drawing.Point(178, 213)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(0, 13)
        Me.lblNewPassword.TabIndex = 30
        Me.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVerifyNewPassword
        '
        Me.lblVerifyNewPassword.AutoSize = True
        Me.lblVerifyNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblVerifyNewPassword.ForeColor = System.Drawing.Color.Red
        Me.lblVerifyNewPassword.Location = New System.Drawing.Point(178, 252)
        Me.lblVerifyNewPassword.Name = "lblVerifyNewPassword"
        Me.lblVerifyNewPassword.Size = New System.Drawing.Size(0, 13)
        Me.lblVerifyNewPassword.TabIndex = 31
        Me.lblVerifyNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbThumb
        '
        Me.pbThumb.BackColor = System.Drawing.Color.Transparent
        Me.pbThumb.BackgroundImage = CType(resources.GetObject("pbThumb.BackgroundImage"), System.Drawing.Image)
        Me.pbThumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbThumb.Location = New System.Drawing.Point(181, 274)
        Me.pbThumb.Name = "pbThumb"
        Me.pbThumb.Size = New System.Drawing.Size(88, 79)
        Me.pbThumb.TabIndex = 32
        Me.pbThumb.TabStop = False
        Me.pbThumb.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.HotPink
        Me.Label11.Location = New System.Drawing.Point(284, 472)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "EDIN"
        '
        'Form3
        '
        Me.AcceptButton = Me.btnLogin1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(364, 486)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pbThumb)
        Me.Controls.Add(Me.lblVerifyNewPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtVerifyPassword)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtNewUser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnLogin1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.txtCurrentName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Form3"
        Me.Text = "PASSWORD CHANGE"
        CType(Me.MORGUE_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login_1_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnLogin1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents txtCurrentName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewUser As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MORGUE_DATABASEDataSet As MORGUE_DATABASEDataSet
    Friend WithEvents Login_1_TBBindingSource As BindingSource
    Friend WithEvents Login_1_TBTableAdapter As MORGUE_DATABASEDataSetTableAdapters.Login_1_TBTableAdapter
    Friend WithEvents TableAdapterManager As MORGUE_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtVerifyPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents lblVerifyNewPassword As Label
    Friend WithEvents pbThumb As PictureBox
    Friend WithEvents Label11 As Label
End Class
