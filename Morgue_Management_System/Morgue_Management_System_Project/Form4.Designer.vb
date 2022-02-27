<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim PhotoLabel As System.Windows.Forms.Label
        Dim Time_Of_BirthLabel As System.Windows.Forms.Label
        Dim Time_Of__DeathLabel As System.Windows.Forms.Label
        Dim Registration_DateLabel As System.Windows.Forms.Label
        Dim Release_DateLabel As System.Windows.Forms.Label
        Dim No_Of_WifesLabel As System.Windows.Forms.Label
        Dim No_Of_ChildrenLabel As System.Windows.Forms.Label
        Dim Autopsy_ReportLabel As System.Windows.Forms.Label
        Dim No_Of_DaysLabel As System.Windows.Forms.Label
        Dim Cost_Per_DayLabel As System.Windows.Forms.Label
        Dim Autopsy_CostLabel As System.Windows.Forms.Label
        Dim Bed_Chamber_CostLabel As System.Windows.Forms.Label
        Dim Others_Processing_ChargesLabel As System.Windows.Forms.Label
        Dim Embalming_CostLabel As System.Windows.Forms.Label
        Dim Ambulance_CostLabel As System.Windows.Forms.Label
        Dim Vault_Purchase_FeesLabel As System.Windows.Forms.Label
        Dim Creamation_RequestLabel As System.Windows.Forms.Label
        Dim Embalming_RequestLabel As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim DetailsLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Person_Deceased_TBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Person_Deceased_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MORGUE_DATABASEDataSet = New Morgue_Management_System_Project.MORGUE_DATABASEDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Person_Deceased_TBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.RaceComboBox = New System.Windows.Forms.ComboBox()
        Me.ProfessionTextBox = New System.Windows.Forms.TextBox()
        Me.Time_Of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Time_Of__DeathDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.EthnicityTextBox = New System.Windows.Forms.TextBox()
        Me.ComplexionTextBox = New System.Windows.Forms.TextBox()
        Me.Registration_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Release_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.No_Of_WifesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.No_Of_ChildrenNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Autopsy_ReportTextBox = New System.Windows.Forms.TextBox()
        Me.Corpse_Tag_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Corpse_Fridge_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Creamation_RequestComboBox = New System.Windows.Forms.ComboBox()
        Me.Embalming_RequestComboBox = New System.Windows.Forms.ComboBox()
        Me.Corpse_in_MorgueComboBox = New System.Windows.Forms.ComboBox()
        Me.Corpse_ReleasedComboBox = New System.Windows.Forms.ComboBox()
        Me.Ambulance_ServiceComboBox = New System.Windows.Forms.ComboBox()
        Me.Autopsy_StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.Casket_Procument_feesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Bed_Chamber_CostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Ambulance_CostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Embalming_CostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Creamation_feesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Vault_Purchase_FeesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Autopsy_CostNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Others_Processing_ChargesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Cost_Per_DayNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Certificate_Processing_FeesNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.No_Of_DaysNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.HeigthNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.WeightNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.IDNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.pbBox = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.AgeNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Person_Deceased_TBTableAdapter = New Morgue_Management_System_Project.MORGUE_DATABASEDataSetTableAdapters.Person_Deceased_TBTableAdapter()
        Me.TableAdapterManager = New Morgue_Management_System_Project.MORGUE_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ChamberTBBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChamberTBBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ChamberTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chamber_TBTableAdapter = New Morgue_Management_System_Project.MORGUE_DATABASEDataSetTableAdapters.Chamber_TBTableAdapter()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        PhotoLabel = New System.Windows.Forms.Label()
        Time_Of_BirthLabel = New System.Windows.Forms.Label()
        Time_Of__DeathLabel = New System.Windows.Forms.Label()
        Registration_DateLabel = New System.Windows.Forms.Label()
        Release_DateLabel = New System.Windows.Forms.Label()
        No_Of_WifesLabel = New System.Windows.Forms.Label()
        No_Of_ChildrenLabel = New System.Windows.Forms.Label()
        Autopsy_ReportLabel = New System.Windows.Forms.Label()
        No_Of_DaysLabel = New System.Windows.Forms.Label()
        Cost_Per_DayLabel = New System.Windows.Forms.Label()
        Autopsy_CostLabel = New System.Windows.Forms.Label()
        Bed_Chamber_CostLabel = New System.Windows.Forms.Label()
        Others_Processing_ChargesLabel = New System.Windows.Forms.Label()
        Embalming_CostLabel = New System.Windows.Forms.Label()
        Ambulance_CostLabel = New System.Windows.Forms.Label()
        Vault_Purchase_FeesLabel = New System.Windows.Forms.Label()
        Creamation_RequestLabel = New System.Windows.Forms.Label()
        Embalming_RequestLabel = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        DetailsLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        CType(Me.Person_Deceased_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Person_Deceased_TBBindingNavigator.SuspendLayout()
        CType(Me.Person_Deceased_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MORGUE_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.No_Of_WifesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.No_Of_ChildrenNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Casket_Procument_feesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bed_Chamber_CostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ambulance_CostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Embalming_CostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Creamation_feesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vault_Purchase_FeesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Autopsy_CostNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Others_Processing_ChargesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cost_Per_DayNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Certificate_Processing_FeesNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.No_Of_DaysNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeigthNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChamberTBBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChamberTBBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChamberTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhotoLabel
        '
        PhotoLabel.AutoSize = True
        PhotoLabel.Location = New System.Drawing.Point(13, 43)
        PhotoLabel.Name = "PhotoLabel"
        PhotoLabel.Size = New System.Drawing.Size(0, 13)
        PhotoLabel.TabIndex = 3
        '
        'Time_Of_BirthLabel
        '
        Time_Of_BirthLabel.AutoSize = True
        Time_Of_BirthLabel.BackColor = System.Drawing.Color.Black
        Time_Of_BirthLabel.ForeColor = System.Drawing.Color.Lime
        Time_Of_BirthLabel.Location = New System.Drawing.Point(751, 62)
        Time_Of_BirthLabel.Name = "Time_Of_BirthLabel"
        Time_Of_BirthLabel.Size = New System.Drawing.Size(71, 13)
        Time_Of_BirthLabel.TabIndex = 25
        Time_Of_BirthLabel.Text = "Time Of Birth:"
        '
        'Time_Of__DeathLabel
        '
        Time_Of__DeathLabel.Location = New System.Drawing.Point(0, 0)
        Time_Of__DeathLabel.Name = "Time_Of__DeathLabel"
        Time_Of__DeathLabel.Size = New System.Drawing.Size(100, 23)
        Time_Of__DeathLabel.TabIndex = 117
        '
        'Registration_DateLabel
        '
        Registration_DateLabel.Location = New System.Drawing.Point(0, 0)
        Registration_DateLabel.Name = "Registration_DateLabel"
        Registration_DateLabel.Size = New System.Drawing.Size(100, 23)
        Registration_DateLabel.TabIndex = 116
        '
        'Release_DateLabel
        '
        Release_DateLabel.Location = New System.Drawing.Point(0, 0)
        Release_DateLabel.Name = "Release_DateLabel"
        Release_DateLabel.Size = New System.Drawing.Size(100, 23)
        Release_DateLabel.TabIndex = 115
        '
        'No_Of_WifesLabel
        '
        No_Of_WifesLabel.AutoSize = True
        No_Of_WifesLabel.BackColor = System.Drawing.Color.Black
        No_Of_WifesLabel.ForeColor = System.Drawing.Color.Lime
        No_Of_WifesLabel.Location = New System.Drawing.Point(289, 148)
        No_Of_WifesLabel.Name = "No_Of_WifesLabel"
        No_Of_WifesLabel.Size = New System.Drawing.Size(68, 13)
        No_Of_WifesLabel.TabIndex = 39
        No_Of_WifesLabel.Text = "No Of Wifes:"
        '
        'No_Of_ChildrenLabel
        '
        No_Of_ChildrenLabel.AutoSize = True
        No_Of_ChildrenLabel.BackColor = System.Drawing.Color.Black
        No_Of_ChildrenLabel.ForeColor = System.Drawing.Color.Lime
        No_Of_ChildrenLabel.Location = New System.Drawing.Point(279, 172)
        No_Of_ChildrenLabel.Name = "No_Of_ChildrenLabel"
        No_Of_ChildrenLabel.Size = New System.Drawing.Size(79, 13)
        No_Of_ChildrenLabel.TabIndex = 41
        No_Of_ChildrenLabel.Text = "No Of Children:"
        '
        'Autopsy_ReportLabel
        '
        Autopsy_ReportLabel.AutoSize = True
        Autopsy_ReportLabel.BackColor = System.Drawing.Color.Black
        Autopsy_ReportLabel.ForeColor = System.Drawing.Color.Lime
        Autopsy_ReportLabel.Location = New System.Drawing.Point(279, 71)
        Autopsy_ReportLabel.Name = "Autopsy_ReportLabel"
        Autopsy_ReportLabel.Size = New System.Drawing.Size(83, 13)
        Autopsy_ReportLabel.TabIndex = 43
        Autopsy_ReportLabel.Text = "Autopsy Report:"
        '
        'No_Of_DaysLabel
        '
        No_Of_DaysLabel.AutoSize = True
        No_Of_DaysLabel.BackColor = System.Drawing.Color.Black
        No_Of_DaysLabel.ForeColor = System.Drawing.Color.Lime
        No_Of_DaysLabel.Location = New System.Drawing.Point(804, 268)
        No_Of_DaysLabel.Name = "No_Of_DaysLabel"
        No_Of_DaysLabel.Size = New System.Drawing.Size(71, 13)
        No_Of_DaysLabel.TabIndex = 45
        No_Of_DaysLabel.Text = "No Of _Days:"
        '
        'Cost_Per_DayLabel
        '
        Cost_Per_DayLabel.Location = New System.Drawing.Point(0, 0)
        Cost_Per_DayLabel.Name = "Cost_Per_DayLabel"
        Cost_Per_DayLabel.Size = New System.Drawing.Size(100, 23)
        Cost_Per_DayLabel.TabIndex = 114
        '
        'Autopsy_CostLabel
        '
        Autopsy_CostLabel.Location = New System.Drawing.Point(0, 0)
        Autopsy_CostLabel.Name = "Autopsy_CostLabel"
        Autopsy_CostLabel.Size = New System.Drawing.Size(100, 23)
        Autopsy_CostLabel.TabIndex = 113
        '
        'Bed_Chamber_CostLabel
        '
        Bed_Chamber_CostLabel.AutoSize = True
        Bed_Chamber_CostLabel.BackColor = System.Drawing.Color.Black
        Bed_Chamber_CostLabel.ForeColor = System.Drawing.Color.Lime
        Bed_Chamber_CostLabel.Location = New System.Drawing.Point(804, 167)
        Bed_Chamber_CostLabel.Name = "Bed_Chamber_CostLabel"
        Bed_Chamber_CostLabel.Size = New System.Drawing.Size(116, 13)
        Bed_Chamber_CostLabel.TabIndex = 51
        Bed_Chamber_CostLabel.Text = "Bed_..Chamber_..Cost:"
        '
        'Others_Processing_ChargesLabel
        '
        Others_Processing_ChargesLabel.AutoSize = True
        Others_Processing_ChargesLabel.BackColor = System.Drawing.Color.Black
        Others_Processing_ChargesLabel.ForeColor = System.Drawing.Color.Lime
        Others_Processing_ChargesLabel.Location = New System.Drawing.Point(804, 348)
        Others_Processing_ChargesLabel.Name = "Others_Processing_ChargesLabel"
        Others_Processing_ChargesLabel.Size = New System.Drawing.Size(78, 13)
        Others_Processing_ChargesLabel.TabIndex = 53
        Others_Processing_ChargesLabel.Text = "Other Charges:"
        '
        'Embalming_CostLabel
        '
        Embalming_CostLabel.AutoSize = True
        Embalming_CostLabel.BackColor = System.Drawing.Color.Black
        Embalming_CostLabel.ForeColor = System.Drawing.Color.Lime
        Embalming_CostLabel.Location = New System.Drawing.Point(804, 216)
        Embalming_CostLabel.Name = "Embalming_CostLabel"
        Embalming_CostLabel.Size = New System.Drawing.Size(85, 13)
        Embalming_CostLabel.TabIndex = 55
        Embalming_CostLabel.Text = "Embalming Cost:"
        '
        'Ambulance_CostLabel
        '
        Ambulance_CostLabel.AutoSize = True
        Ambulance_CostLabel.BackColor = System.Drawing.Color.Black
        Ambulance_CostLabel.ForeColor = System.Drawing.Color.Lime
        Ambulance_CostLabel.Location = New System.Drawing.Point(804, 191)
        Ambulance_CostLabel.Name = "Ambulance_CostLabel"
        Ambulance_CostLabel.Size = New System.Drawing.Size(90, 13)
        Ambulance_CostLabel.TabIndex = 57
        Ambulance_CostLabel.Text = "Ambulance  Cost:"
        '
        'Vault_Purchase_FeesLabel
        '
        Vault_Purchase_FeesLabel.AutoSize = True
        Vault_Purchase_FeesLabel.BackColor = System.Drawing.Color.Black
        Vault_Purchase_FeesLabel.ForeColor = System.Drawing.Color.Lime
        Vault_Purchase_FeesLabel.Location = New System.Drawing.Point(804, 298)
        Vault_Purchase_FeesLabel.Name = "Vault_Purchase_FeesLabel"
        Vault_Purchase_FeesLabel.Size = New System.Drawing.Size(69, 13)
        Vault_Purchase_FeesLabel.TabIndex = 63
        Vault_Purchase_FeesLabel.Text = "Vault _ Fees:"
        '
        'Creamation_RequestLabel
        '
        Creamation_RequestLabel.AutoSize = True
        Creamation_RequestLabel.BackColor = System.Drawing.Color.Black
        Creamation_RequestLabel.ForeColor = System.Drawing.Color.Lime
        Creamation_RequestLabel.Location = New System.Drawing.Point(806, 115)
        Creamation_RequestLabel.Name = "Creamation_RequestLabel"
        Creamation_RequestLabel.Size = New System.Drawing.Size(112, 13)
        Creamation_RequestLabel.TabIndex = 71
        Creamation_RequestLabel.Text = "Creamation_.Request:"
        '
        'Embalming_RequestLabel
        '
        Embalming_RequestLabel.AutoSize = True
        Embalming_RequestLabel.BackColor = System.Drawing.Color.Black
        Embalming_RequestLabel.ForeColor = System.Drawing.Color.Lime
        Embalming_RequestLabel.Location = New System.Drawing.Point(803, 142)
        Embalming_RequestLabel.Name = "Embalming_RequestLabel"
        Embalming_RequestLabel.Size = New System.Drawing.Size(116, 13)
        Embalming_RequestLabel.TabIndex = 73
        Embalming_RequestLabel.Text = "Embalming__.Request:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.BackColor = System.Drawing.Color.Black
        Label14.ForeColor = System.Drawing.Color.Lime
        Label14.Location = New System.Drawing.Point(803, 376)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(84, 13)
        Label14.TabIndex = 118
        Label14.Text = "Cost _Per _Day:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.BackColor = System.Drawing.Color.Black
        Label15.ForeColor = System.Drawing.Color.Lime
        Label15.Location = New System.Drawing.Point(803, 320)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(72, 13)
        Label15.TabIndex = 119
        Label15.Text = "Autopsy Cost:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.BackColor = System.Drawing.Color.Black
        Label16.ForeColor = System.Drawing.Color.Lime
        Label16.Location = New System.Drawing.Point(746, 40)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(75, 13)
        Label16.TabIndex = 120
        Label16.Text = "Release_Date"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.BackColor = System.Drawing.Color.Black
        Label17.ForeColor = System.Drawing.Color.Lime
        Label17.Location = New System.Drawing.Point(766, 80)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(56, 13)
        Label17.TabIndex = 121
        Label17.Text = "Reg_Date"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.BackColor = System.Drawing.Color.Black
        Label18.ForeColor = System.Drawing.Color.Lime
        Label18.Location = New System.Drawing.Point(740, 19)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(82, 13)
        Label18.TabIndex = 122
        Label18.Text = "Time_Of_Death"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.ForeColor = System.Drawing.Color.Lime
        AddressLabel.Location = New System.Drawing.Point(474, 121)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 132
        AddressLabel.Text = "Address:"
        '
        'DetailsLabel
        '
        DetailsLabel.AutoSize = True
        DetailsLabel.ForeColor = System.Drawing.Color.Lime
        DetailsLabel.Location = New System.Drawing.Point(476, 99)
        DetailsLabel.Name = "DetailsLabel"
        DetailsLabel.Size = New System.Drawing.Size(42, 13)
        DetailsLabel.TabIndex = 133
        DetailsLabel.Text = "Details:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(665, 47)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 148
        IDLabel.Text = "ID:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(658, 19)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(28, 13)
        Label23.TabIndex = 154
        Label23.Text = "AID:"
        '
        'Person_Deceased_TBBindingNavigator
        '
        Me.Person_Deceased_TBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Person_Deceased_TBBindingNavigator.BindingSource = Me.Person_Deceased_TBBindingSource
        Me.Person_Deceased_TBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Person_Deceased_TBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Person_Deceased_TBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Person_Deceased_TBBindingNavigatorSaveItem})
        Me.Person_Deceased_TBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Person_Deceased_TBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Person_Deceased_TBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Person_Deceased_TBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Person_Deceased_TBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Person_Deceased_TBBindingNavigator.Name = "Person_Deceased_TBBindingNavigator"
        Me.Person_Deceased_TBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Person_Deceased_TBBindingNavigator.Size = New System.Drawing.Size(961, 25)
        Me.Person_Deceased_TBBindingNavigator.TabIndex = 0
        Me.Person_Deceased_TBBindingNavigator.Text = "BindingNavigator1"
        Me.Person_Deceased_TBBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Person_Deceased_TBBindingSource
        '
        Me.Person_Deceased_TBBindingSource.DataMember = "Person_Deceased_TB"
        Me.Person_Deceased_TBBindingSource.DataSource = Me.MORGUE_DATABASEDataSet
        '
        'MORGUE_DATABASEDataSet
        '
        Me.MORGUE_DATABASEDataSet.DataSetName = "MORGUE_DATABASEDataSet"
        Me.MORGUE_DATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Person_Deceased_TBBindingNavigatorSaveItem
        '
        Me.Person_Deceased_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Person_Deceased_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Person_Deceased_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Person_Deceased_TBBindingNavigatorSaveItem.Name = "Person_Deceased_TBBindingNavigatorSaveItem"
        Me.Person_Deceased_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Person_Deceased_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(13, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "<< BROWSE >>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(13, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(175, 429)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "CLEAR ALL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.ForeColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(94, 429)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "DELETE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(437, 429)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "ACTIVATE FIELDS"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'LNameTextBox
        '
        Me.LNameTextBox.BackColor = System.Drawing.Color.Black
        Me.LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "LName", True))
        Me.LNameTextBox.ForeColor = System.Drawing.Color.White
        Me.LNameTextBox.Location = New System.Drawing.Point(179, 13)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LNameTextBox.TabIndex = 11
        '
        'FNameTextBox
        '
        Me.FNameTextBox.BackColor = System.Drawing.Color.Black
        Me.FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "FName", True))
        Me.FNameTextBox.ForeColor = System.Drawing.Color.White
        Me.FNameTextBox.Location = New System.Drawing.Point(179, 38)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FNameTextBox.TabIndex = 14
        '
        'GenderComboBox
        '
        Me.GenderComboBox.BackColor = System.Drawing.Color.Black
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Gender", True))
        Me.GenderComboBox.ForeColor = System.Drawing.Color.White
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"MALE", "FEMALE", "TRANSGENDER", "OTHERS"})
        Me.GenderComboBox.Location = New System.Drawing.Point(179, 91)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(100, 21)
        Me.GenderComboBox.TabIndex = 20
        '
        'RaceComboBox
        '
        Me.RaceComboBox.BackColor = System.Drawing.Color.Black
        Me.RaceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Race", True))
        Me.RaceComboBox.ForeColor = System.Drawing.Color.White
        Me.RaceComboBox.FormattingEnabled = True
        Me.RaceComboBox.Items.AddRange(New Object() {"", "", "", "", "", "AMERICAN INDIAN", "ARYANS", "AUSTRALOID", "CAUCASIAN", "CHINESE", "ESKIMO", "HAMITES", "INDO-CHINESE", "JAPANESE", "KOREAN", "MALAYAN", "MAORI", "MICRONESIAN", "MONGOLIAN", "MONGOLOID/ASIAN", "NEGROID/BLACK", "NORTHERN MONGOLIAN", "POLYNESIAN", "SEMITES", "TIBETAN"})
        Me.RaceComboBox.Location = New System.Drawing.Point(179, 118)
        Me.RaceComboBox.Name = "RaceComboBox"
        Me.RaceComboBox.Size = New System.Drawing.Size(100, 21)
        Me.RaceComboBox.Sorted = True
        Me.RaceComboBox.TabIndex = 22
        '
        'ProfessionTextBox
        '
        Me.ProfessionTextBox.BackColor = System.Drawing.Color.Black
        Me.ProfessionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Profession", True))
        Me.ProfessionTextBox.ForeColor = System.Drawing.Color.White
        Me.ProfessionTextBox.Location = New System.Drawing.Point(534, 13)
        Me.ProfessionTextBox.Name = "ProfessionTextBox"
        Me.ProfessionTextBox.Size = New System.Drawing.Size(96, 20)
        Me.ProfessionTextBox.TabIndex = 24
        '
        'Time_Of_BirthDateTimePicker
        '
        Me.Time_Of_BirthDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Yellow
        Me.Time_Of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Time_Of_Birth", True))
        Me.Time_Of_BirthDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_Of_BirthDateTimePicker.Location = New System.Drawing.Point(818, 55)
        Me.Time_Of_BirthDateTimePicker.Name = "Time_Of_BirthDateTimePicker"
        Me.Time_Of_BirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Time_Of_BirthDateTimePicker.TabIndex = 26
        '
        'Time_Of__DeathDateTimePicker
        '
        Me.Time_Of__DeathDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Yellow
        Me.Time_Of__DeathDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Time_Of_ Death", True))
        Me.Time_Of__DeathDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_Of__DeathDateTimePicker.Location = New System.Drawing.Point(818, 14)
        Me.Time_Of__DeathDateTimePicker.Name = "Time_Of__DeathDateTimePicker"
        Me.Time_Of__DeathDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Time_Of__DeathDateTimePicker.TabIndex = 28
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.BackColor = System.Drawing.Color.Black
        Me.NationalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Nationality", True))
        Me.NationalityTextBox.ForeColor = System.Drawing.Color.White
        Me.NationalityTextBox.Location = New System.Drawing.Point(534, 39)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(96, 20)
        Me.NationalityTextBox.TabIndex = 30
        '
        'EthnicityTextBox
        '
        Me.EthnicityTextBox.BackColor = System.Drawing.Color.Black
        Me.EthnicityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Ethnicity", True))
        Me.EthnicityTextBox.ForeColor = System.Drawing.Color.White
        Me.EthnicityTextBox.Location = New System.Drawing.Point(359, 40)
        Me.EthnicityTextBox.Name = "EthnicityTextBox"
        Me.EthnicityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EthnicityTextBox.TabIndex = 32
        '
        'ComplexionTextBox
        '
        Me.ComplexionTextBox.BackColor = System.Drawing.Color.Black
        Me.ComplexionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Complexion", True))
        Me.ComplexionTextBox.ForeColor = System.Drawing.Color.White
        Me.ComplexionTextBox.Location = New System.Drawing.Point(534, 67)
        Me.ComplexionTextBox.Name = "ComplexionTextBox"
        Me.ComplexionTextBox.Size = New System.Drawing.Size(96, 20)
        Me.ComplexionTextBox.TabIndex = 34
        '
        'Registration_DateDateTimePicker
        '
        Me.Registration_DateDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Yellow
        Me.Registration_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Registration_Date", True))
        Me.Registration_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registration_DateDateTimePicker.Location = New System.Drawing.Point(818, 76)
        Me.Registration_DateDateTimePicker.Name = "Registration_DateDateTimePicker"
        Me.Registration_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Registration_DateDateTimePicker.TabIndex = 36
        '
        'Release_DateDateTimePicker
        '
        Me.Release_DateDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Yellow
        Me.Release_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Release_Date", True))
        Me.Release_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Release_DateDateTimePicker.Location = New System.Drawing.Point(818, 35)
        Me.Release_DateDateTimePicker.Name = "Release_DateDateTimePicker"
        Me.Release_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Release_DateDateTimePicker.TabIndex = 38
        '
        'No_Of_WifesNumericUpDown
        '
        Me.No_Of_WifesNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.No_Of_WifesNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "No_Of_Wifes", True))
        Me.No_Of_WifesNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.No_Of_WifesNumericUpDown.Location = New System.Drawing.Point(359, 146)
        Me.No_Of_WifesNumericUpDown.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.No_Of_WifesNumericUpDown.Name = "No_Of_WifesNumericUpDown"
        Me.No_Of_WifesNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.No_Of_WifesNumericUpDown.TabIndex = 40
        '
        'No_Of_ChildrenNumericUpDown
        '
        Me.No_Of_ChildrenNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.No_Of_ChildrenNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "No_Of_Children", True))
        Me.No_Of_ChildrenNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.No_Of_ChildrenNumericUpDown.Location = New System.Drawing.Point(359, 170)
        Me.No_Of_ChildrenNumericUpDown.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.No_Of_ChildrenNumericUpDown.Name = "No_Of_ChildrenNumericUpDown"
        Me.No_Of_ChildrenNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.No_Of_ChildrenNumericUpDown.TabIndex = 42
        '
        'Autopsy_ReportTextBox
        '
        Me.Autopsy_ReportTextBox.BackColor = System.Drawing.Color.Black
        Me.Autopsy_ReportTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Autopsy_Report", True))
        Me.Autopsy_ReportTextBox.ForeColor = System.Drawing.Color.White
        Me.Autopsy_ReportTextBox.Location = New System.Drawing.Point(359, 67)
        Me.Autopsy_ReportTextBox.Name = "Autopsy_ReportTextBox"
        Me.Autopsy_ReportTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Autopsy_ReportTextBox.TabIndex = 44
        '
        'Corpse_Tag_NoTextBox
        '
        Me.Corpse_Tag_NoTextBox.BackColor = System.Drawing.Color.Black
        Me.Corpse_Tag_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Corpse_Tag_No", True))
        Me.Corpse_Tag_NoTextBox.ForeColor = System.Drawing.Color.White
        Me.Corpse_Tag_NoTextBox.Location = New System.Drawing.Point(178, 145)
        Me.Corpse_Tag_NoTextBox.Name = "Corpse_Tag_NoTextBox"
        Me.Corpse_Tag_NoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Corpse_Tag_NoTextBox.TabIndex = 68
        '
        'Corpse_Fridge_NoTextBox
        '
        Me.Corpse_Fridge_NoTextBox.BackColor = System.Drawing.Color.Black
        Me.Corpse_Fridge_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Corpse_Fridge_No", True))
        Me.Corpse_Fridge_NoTextBox.ForeColor = System.Drawing.Color.White
        Me.Corpse_Fridge_NoTextBox.Location = New System.Drawing.Point(359, 13)
        Me.Corpse_Fridge_NoTextBox.Name = "Corpse_Fridge_NoTextBox"
        Me.Corpse_Fridge_NoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Corpse_Fridge_NoTextBox.TabIndex = 70
        '
        'Creamation_RequestComboBox
        '
        Me.Creamation_RequestComboBox.BackColor = System.Drawing.Color.Black
        Me.Creamation_RequestComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Creamation_Request", True))
        Me.Creamation_RequestComboBox.Enabled = False
        Me.Creamation_RequestComboBox.ForeColor = System.Drawing.Color.White
        Me.Creamation_RequestComboBox.FormattingEnabled = True
        Me.Creamation_RequestComboBox.Items.AddRange(New Object() {"NO", "YES"})
        Me.Creamation_RequestComboBox.Location = New System.Drawing.Point(918, 107)
        Me.Creamation_RequestComboBox.Name = "Creamation_RequestComboBox"
        Me.Creamation_RequestComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Creamation_RequestComboBox.TabIndex = 72
        '
        'Embalming_RequestComboBox
        '
        Me.Embalming_RequestComboBox.BackColor = System.Drawing.Color.Black
        Me.Embalming_RequestComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Embalming_Request", True))
        Me.Embalming_RequestComboBox.Enabled = False
        Me.Embalming_RequestComboBox.ForeColor = System.Drawing.Color.White
        Me.Embalming_RequestComboBox.FormattingEnabled = True
        Me.Embalming_RequestComboBox.Items.AddRange(New Object() {"NO", "YES"})
        Me.Embalming_RequestComboBox.Location = New System.Drawing.Point(918, 131)
        Me.Embalming_RequestComboBox.Name = "Embalming_RequestComboBox"
        Me.Embalming_RequestComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Embalming_RequestComboBox.TabIndex = 74
        '
        'Corpse_in_MorgueComboBox
        '
        Me.Corpse_in_MorgueComboBox.BackColor = System.Drawing.Color.Black
        Me.Corpse_in_MorgueComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Corpse_in_Morgue", True))
        Me.Corpse_in_MorgueComboBox.ForeColor = System.Drawing.Color.White
        Me.Corpse_in_MorgueComboBox.FormattingEnabled = True
        Me.Corpse_in_MorgueComboBox.Items.AddRange(New Object() {"NO", "YES"})
        Me.Corpse_in_MorgueComboBox.Location = New System.Drawing.Point(692, 66)
        Me.Corpse_in_MorgueComboBox.Name = "Corpse_in_MorgueComboBox"
        Me.Corpse_in_MorgueComboBox.Size = New System.Drawing.Size(49, 21)
        Me.Corpse_in_MorgueComboBox.TabIndex = 76
        '
        'Corpse_ReleasedComboBox
        '
        Me.Corpse_ReleasedComboBox.BackColor = System.Drawing.Color.Black
        Me.Corpse_ReleasedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Corpse_Released", True))
        Me.Corpse_ReleasedComboBox.Enabled = False
        Me.Corpse_ReleasedComboBox.ForeColor = System.Drawing.Color.White
        Me.Corpse_ReleasedComboBox.FormattingEnabled = True
        Me.Corpse_ReleasedComboBox.Items.AddRange(New Object() {"NO", "YES"})
        Me.Corpse_ReleasedComboBox.Location = New System.Drawing.Point(692, 92)
        Me.Corpse_ReleasedComboBox.Name = "Corpse_ReleasedComboBox"
        Me.Corpse_ReleasedComboBox.Size = New System.Drawing.Size(48, 21)
        Me.Corpse_ReleasedComboBox.TabIndex = 78
        '
        'Ambulance_ServiceComboBox
        '
        Me.Ambulance_ServiceComboBox.BackColor = System.Drawing.Color.Black
        Me.Ambulance_ServiceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Ambulance_Service", True))
        Me.Ambulance_ServiceComboBox.ForeColor = System.Drawing.Color.White
        Me.Ambulance_ServiceComboBox.FormattingEnabled = True
        Me.Ambulance_ServiceComboBox.Items.AddRange(New Object() {"NO", "YES"})
        Me.Ambulance_ServiceComboBox.Location = New System.Drawing.Point(359, 119)
        Me.Ambulance_ServiceComboBox.Name = "Ambulance_ServiceComboBox"
        Me.Ambulance_ServiceComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Ambulance_ServiceComboBox.TabIndex = 80
        '
        'Autopsy_StatusComboBox
        '
        Me.Autopsy_StatusComboBox.BackColor = System.Drawing.Color.Black
        Me.Autopsy_StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Autopsy_Status", True))
        Me.Autopsy_StatusComboBox.ForeColor = System.Drawing.Color.White
        Me.Autopsy_StatusComboBox.FormattingEnabled = True
        Me.Autopsy_StatusComboBox.Items.AddRange(New Object() {"NO", "YES"})
        Me.Autopsy_StatusComboBox.Location = New System.Drawing.Point(359, 92)
        Me.Autopsy_StatusComboBox.Name = "Autopsy_StatusComboBox"
        Me.Autopsy_StatusComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Autopsy_StatusComboBox.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(131, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "LName:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(129, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "FName:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(144, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(635, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Released:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(464, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Casket _Fee:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(309, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Autopsy:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(294, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Ambulance:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(307, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Ethnicity:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.ForeColor = System.Drawing.Color.Lime
        Me.Label9.Location = New System.Drawing.Point(474, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Weight:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.ForeColor = System.Drawing.Color.Lime
        Me.Label10.Location = New System.Drawing.Point(130, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Gender:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.ForeColor = System.Drawing.Color.Lime
        Me.Label11.Location = New System.Drawing.Point(130, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Heigth:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.ForeColor = System.Drawing.Color.Lime
        Me.Label12.Location = New System.Drawing.Point(129, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Tag No:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(137, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "Race:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Black
        Me.Label22.ForeColor = System.Drawing.Color.Lime
        Me.Label22.Location = New System.Drawing.Point(640, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 13)
        Me.Label22.TabIndex = 104
        Me.Label22.Text = "Present:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Black
        Me.Label24.ForeColor = System.Drawing.Color.Lime
        Me.Label24.Location = New System.Drawing.Point(803, 242)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 13)
        Me.Label24.TabIndex = 106
        Me.Label24.Text = "Creamation fee:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Black
        Me.Label25.ForeColor = System.Drawing.Color.Lime
        Me.Label25.Location = New System.Drawing.Point(803, 400)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 13)
        Me.Label25.TabIndex = 107
        Me.Label25.Text = "Certificate _fees:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Black
        Me.Label26.ForeColor = System.Drawing.Color.Lime
        Me.Label26.Location = New System.Drawing.Point(302, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(56, 13)
        Me.Label26.TabIndex = 108
        Me.Label26.Text = "Fridge No:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Black
        Me.Label27.ForeColor = System.Drawing.Color.Lime
        Me.Label27.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label27.Location = New System.Drawing.Point(464, 72)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 13)
        Me.Label27.TabIndex = 109
        Me.Label27.Text = "Complexion:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Black
        Me.Label28.ForeColor = System.Drawing.Color.Lime
        Me.Label28.Location = New System.Drawing.Point(464, 47)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 13)
        Me.Label28.TabIndex = 110
        Me.Label28.Text = "Nationality:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Black
        Me.Label29.ForeColor = System.Drawing.Color.Lime
        Me.Label29.Location = New System.Drawing.Point(465, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 13)
        Me.Label29.TabIndex = 111
        Me.Label29.Text = "Profession:"
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Location = New System.Drawing.Point(14, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(45, 21)
        Me.Button7.TabIndex = 112
        Me.Button7.Text = "<< "
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.ForeColor = System.Drawing.Color.Red
        Me.Button8.Location = New System.Drawing.Point(66, 12)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(59, 21)
        Me.Button8.TabIndex = 123
        Me.Button8.Text = "QUIT"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button10.Location = New System.Drawing.Point(347, 429)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(28, 23)
        Me.Button10.TabIndex = 128
        Me.Button10.Text = ">>"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button11.Location = New System.Drawing.Point(313, 429)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(28, 23)
        Me.Button11.TabIndex = 129
        Me.Button11.Text = "<<"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button12.Location = New System.Drawing.Point(381, 429)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(50, 23)
        Me.Button12.TabIndex = 131
        Me.Button12.Text = "END>>"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
        Me.Button13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button13.Location = New System.Drawing.Point(256, 429)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(51, 23)
        Me.Button13.TabIndex = 132
        Me.Button13.Text = "<<SKIP "
        Me.Button13.UseVisualStyleBackColor = True
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.Black
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Address", True))
        Me.AddressTextBox.ForeColor = System.Drawing.Color.White
        Me.AddressTextBox.Location = New System.Drawing.Point(534, 118)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(96, 20)
        Me.AddressTextBox.TabIndex = 133
        '
        'DetailsTextBox
        '
        Me.DetailsTextBox.BackColor = System.Drawing.Color.Black
        Me.DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Details", True))
        Me.DetailsTextBox.ForeColor = System.Drawing.Color.White
        Me.DetailsTextBox.Location = New System.Drawing.Point(534, 92)
        Me.DetailsTextBox.Name = "DetailsTextBox"
        Me.DetailsTextBox.Size = New System.Drawing.Size(96, 20)
        Me.DetailsTextBox.TabIndex = 134
        '
        'Casket_Procument_feesNumericUpDown
        '
        Me.Casket_Procument_feesNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.Casket_Procument_feesNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Casket_Procument_fees", True))
        Me.Casket_Procument_feesNumericUpDown.DecimalPlaces = 2
        Me.Casket_Procument_feesNumericUpDown.Enabled = False
        Me.Casket_Procument_feesNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.Casket_Procument_feesNumericUpDown.Location = New System.Drawing.Point(534, 170)
        Me.Casket_Procument_feesNumericUpDown.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Casket_Procument_feesNumericUpDown.Name = "Casket_Procument_feesNumericUpDown"
        Me.Casket_Procument_feesNumericUpDown.Size = New System.Drawing.Size(96, 20)
        Me.Casket_Procument_feesNumericUpDown.TabIndex = 135
        '
        'Bed_Chamber_CostNumericUpDown
        '
        Me.Bed_Chamber_CostNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.Bed_Chamber_CostNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Bed/Chamber_Cost", True))
        Me.Bed_Chamber_CostNumericUpDown.DecimalPlaces = 2
        Me.Bed_Chamber_CostNumericUpDown.Enabled = False
        Me.Bed_Chamber_CostNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.Bed_Chamber_CostNumericUpDown.Location = New System.Drawing.Point(918, 158)
        Me.Bed_Chamber_CostNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Bed_Chamber_CostNumericUpDown.Name = "Bed_Chamber_CostNumericUpDown"
        Me.Bed_Chamber_CostNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Bed_Chamber_CostNumericUpDown.TabIndex = 136
        '
        'Ambulance_CostNumericUpDown
        '
        Me.Ambulance_CostNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.Ambulance_CostNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Ambulance_Cost", True))
        Me.Ambulance_CostNumericUpDown.DecimalPlaces = 2
        Me.Ambulance_CostNumericUpDown.Enabled = False
        Me.Ambulance_CostNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.Ambulance_CostNumericUpDown.Location = New System.Drawing.Point(918, 184)
        Me.Ambulance_CostNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Ambulance_CostNumericUpDown.Name = "Ambulance_CostNumericUpDown"
        Me.Ambulance_CostNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Ambulance_CostNumericUpDown.TabIndex = 137
        '
        'Embalming_CostNumericUpDown
        '
        Me.Embalming_CostNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.Embalming_CostNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Embalming_Cost", True))
        Me.Embalming_CostNumericUpDown.DecimalPlaces = 2
        Me.Embalming_CostNumericUpDown.Enabled = False
        Me.Embalming_CostNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.Embalming_CostNumericUpDown.Location = New System.Drawing.Point(918, 209)
        Me.Embalming_CostNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Embalming_CostNumericUpDown.Name = "Embalming_CostNumericUpDown"
        Me.Embalming_CostNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Embalming_CostNumericUpDown.TabIndex = 138
        '
        'Creamation_feesNumericUpDown
        '
        Me.Creamation_feesNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.Creamation_feesNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Creamation_fees", True))
        Me.Creamation_feesNumericUpDown.DecimalPlaces = 2
        Me.Creamation_feesNumericUpDown.Enabled = False
        Me.Creamation_feesNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.Creamation_feesNumericUpDown.Location = New System.Drawing.Point(918, 235)
        Me.Creamation_feesNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Creamation_feesNumericUpDown.Name = "Creamation_feesNumericUpDown"
        Me.Creamation_feesNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Creamation_feesNumericUpDown.TabIndex = 139
        '
        'Vault_Purchase_FeesNumericUpDown
        '
        Me.Vault_Purchase_FeesNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.Vault_Purchase_FeesNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Vault_Purchase_Fees", True))
        Me.Vault_Purchase_FeesNumericUpDown.DecimalPlaces = 2
        Me.Vault_Purchase_FeesNumericUpDown.Enabled = False
        Me.Vault_Purchase_FeesNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.Vault_Purchase_FeesNumericUpDown.Location = New System.Drawing.Point(918, 287)
        Me.Vault_Purchase_FeesNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Vault_Purchase_FeesNumericUpDown.Name = "Vault_Purchase_FeesNumericUpDown"
        Me.Vault_Purchase_FeesNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Vault_Purchase_FeesNumericUpDown.TabIndex = 141
        '
        'Autopsy_CostNumericUpDown
        '
        Me.Autopsy_CostNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.Autopsy_CostNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Autopsy_Cost", True))
        Me.Autopsy_CostNumericUpDown.DecimalPlaces = 2
        Me.Autopsy_CostNumericUpDown.Enabled = False
        Me.Autopsy_CostNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.Autopsy_CostNumericUpDown.Location = New System.Drawing.Point(918, 313)
        Me.Autopsy_CostNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Autopsy_CostNumericUpDown.Name = "Autopsy_CostNumericUpDown"
        Me.Autopsy_CostNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Autopsy_CostNumericUpDown.TabIndex = 142
        '
        'Others_Processing_ChargesNumericUpDown
        '
        Me.Others_Processing_ChargesNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.Others_Processing_ChargesNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Others/Processing_Charges", True))
        Me.Others_Processing_ChargesNumericUpDown.DecimalPlaces = 2
        Me.Others_Processing_ChargesNumericUpDown.Enabled = False
        Me.Others_Processing_ChargesNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.Others_Processing_ChargesNumericUpDown.Location = New System.Drawing.Point(918, 341)
        Me.Others_Processing_ChargesNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Others_Processing_ChargesNumericUpDown.Name = "Others_Processing_ChargesNumericUpDown"
        Me.Others_Processing_ChargesNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Others_Processing_ChargesNumericUpDown.TabIndex = 143
        '
        'Cost_Per_DayNumericUpDown
        '
        Me.Cost_Per_DayNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.Cost_Per_DayNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Cost_Per_Day", True))
        Me.Cost_Per_DayNumericUpDown.DecimalPlaces = 2
        Me.Cost_Per_DayNumericUpDown.Enabled = False
        Me.Cost_Per_DayNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.Cost_Per_DayNumericUpDown.Location = New System.Drawing.Point(918, 369)
        Me.Cost_Per_DayNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Cost_Per_DayNumericUpDown.Name = "Cost_Per_DayNumericUpDown"
        Me.Cost_Per_DayNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Cost_Per_DayNumericUpDown.TabIndex = 144
        '
        'Certificate_Processing_FeesNumericUpDown
        '
        Me.Certificate_Processing_FeesNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.Certificate_Processing_FeesNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Certificate_Processing_Fees", True))
        Me.Certificate_Processing_FeesNumericUpDown.DecimalPlaces = 2
        Me.Certificate_Processing_FeesNumericUpDown.Enabled = False
        Me.Certificate_Processing_FeesNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.Certificate_Processing_FeesNumericUpDown.Location = New System.Drawing.Point(918, 395)
        Me.Certificate_Processing_FeesNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Certificate_Processing_FeesNumericUpDown.Name = "Certificate_Processing_FeesNumericUpDown"
        Me.Certificate_Processing_FeesNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.Certificate_Processing_FeesNumericUpDown.TabIndex = 145
        '
        'No_Of_DaysNumericUpDown
        '
        Me.No_Of_DaysNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.No_Of_DaysNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "No_Of_Days", True))
        Me.No_Of_DaysNumericUpDown.Enabled = False
        Me.No_Of_DaysNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.No_Of_DaysNumericUpDown.Location = New System.Drawing.Point(918, 261)
        Me.No_Of_DaysNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.No_Of_DaysNumericUpDown.Name = "No_Of_DaysNumericUpDown"
        Me.No_Of_DaysNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.No_Of_DaysNumericUpDown.TabIndex = 146
        '
        'HeigthNumericUpDown
        '
        Me.HeigthNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.HeigthNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Heigth", True))
        Me.HeigthNumericUpDown.DecimalPlaces = 2
        Me.HeigthNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.HeigthNumericUpDown.Location = New System.Drawing.Point(179, 169)
        Me.HeigthNumericUpDown.Name = "HeigthNumericUpDown"
        Me.HeigthNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.HeigthNumericUpDown.TabIndex = 147
        '
        'WeightNumericUpDown
        '
        Me.WeightNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.WeightNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Weight", True))
        Me.WeightNumericUpDown.DecimalPlaces = 2
        Me.WeightNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.WeightNumericUpDown.Location = New System.Drawing.Point(534, 144)
        Me.WeightNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.WeightNumericUpDown.Name = "WeightNumericUpDown"
        Me.WeightNumericUpDown.Size = New System.Drawing.Size(96, 20)
        Me.WeightNumericUpDown.TabIndex = 148
        '
        'IDNumericUpDown
        '
        Me.IDNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.IDNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "ID", True))
        Me.IDNumericUpDown.Enabled = False
        Me.IDNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.IDNumericUpDown.Location = New System.Drawing.Point(692, 40)
        Me.IDNumericUpDown.Name = "IDNumericUpDown"
        Me.IDNumericUpDown.Size = New System.Drawing.Size(49, 20)
        Me.IDNumericUpDown.TabIndex = 149
        '
        'pbBox
        '
        Me.pbBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pbBox.BackgroundImage = Global.Morgue_Management_System_Project.My.Resources.Resources.very_basic_android_l_lollipop_by_ivan_boyko_62461
        Me.pbBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Person_Deceased_TBBindingSource, "Photo", True))
        Me.pbBox.Location = New System.Drawing.Point(12, 39)
        Me.pbBox.Name = "pbBox"
        Me.pbBox.Size = New System.Drawing.Size(111, 123)
        Me.pbBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBox.TabIndex = 150
        Me.pbBox.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(622, 429)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 23)
        Me.Button4.TabIndex = 151
        Me.Button4.Text = "VIEW ALL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'AgeNumericUpDown
        '
        Me.AgeNumericUpDown.BackColor = System.Drawing.Color.Black
        Me.AgeNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "Age", True))
        Me.AgeNumericUpDown.ForeColor = System.Drawing.Color.White
        Me.AgeNumericUpDown.Location = New System.Drawing.Point(179, 65)
        Me.AgeNumericUpDown.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.AgeNumericUpDown.Name = "AgeNumericUpDown"
        Me.AgeNumericUpDown.Size = New System.Drawing.Size(100, 20)
        Me.AgeNumericUpDown.TabIndex = 152
        '
        'Person_Deceased_TBTableAdapter
        '
        Me.Person_Deceased_TBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bills_TBTableAdapter = Nothing
        Me.TableAdapterManager.Chamber_TBTableAdapter = Nothing
        Me.TableAdapterManager.Login_1_TBTableAdapter = Nothing
        Me.TableAdapterManager.Miscellaneous_TBTableAdapter = Nothing
        Me.TableAdapterManager.Person_Deceased_TBTableAdapter = Me.Person_Deceased_TBTableAdapter
        Me.TableAdapterManager.Staff_TBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Morgue_Management_System_Project.MORGUE_DATABASEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.Black
        Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_Deceased_TBBindingSource, "ID", True))
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown1.Location = New System.Drawing.Point(692, 14)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown1.TabIndex = 153
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(551, 429)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(66, 23)
        Me.Button9.TabIndex = 155
        Me.Button9.Text = "REFRESH"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Black
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChamberTBBindingSource2, "chamber_ID", True))
        Me.ComboBox1.DropDownHeight = 110
        Me.ComboBox1.DropDownWidth = 80
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Location = New System.Drawing.Point(692, 121)
        Me.ComboBox1.MaxDropDownItems = 100
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(48, 21)
        Me.ComboBox1.TabIndex = 156
        '
        'ChamberTBBindingSource2
        '
        Me.ChamberTBBindingSource2.DataMember = "Chamber_TB"
        Me.ChamberTBBindingSource2.DataSource = Me.MORGUE_DATABASEDataSet
        '
        'ChamberTBBindingSource1
        '
        Me.ChamberTBBindingSource1.DataMember = "Chamber_TB"
        Me.ChamberTBBindingSource1.DataSource = Me.MORGUE_DATABASEDataSet
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(647, 123)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(43, 13)
        Me.Label30.TabIndex = 157
        Me.Label30.Text = "Bed ID:"
        '
        'ChamberTBBindingSource
        '
        Me.ChamberTBBindingSource.DataMember = "Chamber_TB"
        Me.ChamberTBBindingSource.DataSource = Me.MORGUE_DATABASEDataSet
        '
        'Chamber_TBTableAdapter
        '
        Me.Chamber_TBTableAdapter.ClearBeforeFill = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Purple
        Me.Label31.Location = New System.Drawing.Point(908, 439)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(60, 13)
        Me.Label31.TabIndex = 161
        Me.Label31.Text = "EDENLIVE"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Purple
        Me.Label32.Location = New System.Drawing.Point(965, 439)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(50, 13)
        Me.Label32.TabIndex = 160
        Me.Label32.Text = "copyright"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(858, 439)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 13)
        Me.Label33.TabIndex = 159
        Me.Label33.Text = "Ver. 0.1"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label34.Location = New System.Drawing.Point(715, 439)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(148, 13)
        Me.Label34.TabIndex = 158
        Me.Label34.Text = "Morgue Management System "
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1038, 461)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Label23)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Autopsy_ReportTextBox)
        Me.Controls.Add(Me.AgeNumericUpDown)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.pbBox)
        Me.Controls.Add(Me.IDNumericUpDown)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.WeightNumericUpDown)
        Me.Controls.Add(Me.HeigthNumericUpDown)
        Me.Controls.Add(Me.No_Of_DaysNumericUpDown)
        Me.Controls.Add(Me.Certificate_Processing_FeesNumericUpDown)
        Me.Controls.Add(Me.Cost_Per_DayNumericUpDown)
        Me.Controls.Add(Me.Others_Processing_ChargesNumericUpDown)
        Me.Controls.Add(Me.Autopsy_CostNumericUpDown)
        Me.Controls.Add(Me.Vault_Purchase_FeesNumericUpDown)
        Me.Controls.Add(Me.Creamation_feesNumericUpDown)
        Me.Controls.Add(Me.Embalming_CostNumericUpDown)
        Me.Controls.Add(Me.Ambulance_CostNumericUpDown)
        Me.Controls.Add(Me.Bed_Chamber_CostNumericUpDown)
        Me.Controls.Add(Me.Casket_Procument_feesNumericUpDown)
        Me.Controls.Add(DetailsLabel)
        Me.Controls.Add(Me.DetailsTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Autopsy_StatusComboBox)
        Me.Controls.Add(Me.Ambulance_ServiceComboBox)
        Me.Controls.Add(Me.Corpse_ReleasedComboBox)
        Me.Controls.Add(Me.Corpse_in_MorgueComboBox)
        Me.Controls.Add(Embalming_RequestLabel)
        Me.Controls.Add(Me.Embalming_RequestComboBox)
        Me.Controls.Add(Creamation_RequestLabel)
        Me.Controls.Add(Me.Creamation_RequestComboBox)
        Me.Controls.Add(Me.Corpse_Fridge_NoTextBox)
        Me.Controls.Add(Me.Corpse_Tag_NoTextBox)
        Me.Controls.Add(Vault_Purchase_FeesLabel)
        Me.Controls.Add(Ambulance_CostLabel)
        Me.Controls.Add(Embalming_CostLabel)
        Me.Controls.Add(Others_Processing_ChargesLabel)
        Me.Controls.Add(Bed_Chamber_CostLabel)
        Me.Controls.Add(Autopsy_CostLabel)
        Me.Controls.Add(Cost_Per_DayLabel)
        Me.Controls.Add(No_Of_DaysLabel)
        Me.Controls.Add(Autopsy_ReportLabel)
        Me.Controls.Add(No_Of_ChildrenLabel)
        Me.Controls.Add(Me.No_Of_ChildrenNumericUpDown)
        Me.Controls.Add(No_Of_WifesLabel)
        Me.Controls.Add(Me.No_Of_WifesNumericUpDown)
        Me.Controls.Add(Release_DateLabel)
        Me.Controls.Add(Me.Release_DateDateTimePicker)
        Me.Controls.Add(Registration_DateLabel)
        Me.Controls.Add(Me.Registration_DateDateTimePicker)
        Me.Controls.Add(Me.ComplexionTextBox)
        Me.Controls.Add(Me.EthnicityTextBox)
        Me.Controls.Add(Me.NationalityTextBox)
        Me.Controls.Add(Time_Of__DeathLabel)
        Me.Controls.Add(Me.Time_Of__DeathDateTimePicker)
        Me.Controls.Add(Me.Time_Of_BirthDateTimePicker)
        Me.Controls.Add(Me.ProfessionTextBox)
        Me.Controls.Add(Me.RaceComboBox)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.FNameTextBox)
        Me.Controls.Add(Me.LNameTextBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PhotoLabel)
        Me.Controls.Add(Me.Person_Deceased_TBBindingNavigator)
        Me.Controls.Add(Label18)
        Me.Controls.Add(Time_Of_BirthLabel)
        Me.Controls.Add(Label16)
        Me.Controls.Add(Label17)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Person_Deceased_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Person_Deceased_TBBindingNavigator.ResumeLayout(False)
        Me.Person_Deceased_TBBindingNavigator.PerformLayout()
        CType(Me.Person_Deceased_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MORGUE_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.No_Of_WifesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.No_Of_ChildrenNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Casket_Procument_feesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bed_Chamber_CostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ambulance_CostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Embalming_CostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Creamation_feesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vault_Purchase_FeesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Autopsy_CostNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Others_Processing_ChargesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cost_Per_DayNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Certificate_Processing_FeesNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.No_Of_DaysNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeigthNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChamberTBBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChamberTBBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChamberTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MORGUE_DATABASEDataSet As MORGUE_DATABASEDataSet
    Friend WithEvents Person_Deceased_TBBindingSource As BindingSource
    Friend WithEvents Person_Deceased_TBTableAdapter As MORGUE_DATABASEDataSetTableAdapters.Person_Deceased_TBTableAdapter
    Friend WithEvents TableAdapterManager As MORGUE_DATABASEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Person_Deceased_TBBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Person_Deceased_TBBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents LNameTextBox As TextBox
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents RaceComboBox As ComboBox
    Friend WithEvents ProfessionTextBox As TextBox
    Friend WithEvents Time_Of_BirthDateTimePicker As DateTimePicker
    Friend WithEvents Time_Of__DeathDateTimePicker As DateTimePicker
    Friend WithEvents NationalityTextBox As TextBox
    Friend WithEvents EthnicityTextBox As TextBox
    Friend WithEvents ComplexionTextBox As TextBox
    Friend WithEvents Registration_DateDateTimePicker As DateTimePicker
    Friend WithEvents Release_DateDateTimePicker As DateTimePicker
    Friend WithEvents No_Of_WifesNumericUpDown As NumericUpDown
    Friend WithEvents No_Of_ChildrenNumericUpDown As NumericUpDown
    Friend WithEvents Autopsy_ReportTextBox As TextBox
    Friend WithEvents Corpse_Tag_NoTextBox As TextBox
    Friend WithEvents Corpse_Fridge_NoTextBox As TextBox
    Friend WithEvents Creamation_RequestComboBox As ComboBox
    Friend WithEvents Embalming_RequestComboBox As ComboBox
    Friend WithEvents Corpse_in_MorgueComboBox As ComboBox
    Friend WithEvents Corpse_ReleasedComboBox As ComboBox
    Friend WithEvents Ambulance_ServiceComboBox As ComboBox
    Friend WithEvents Autopsy_StatusComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents DetailsTextBox As TextBox
    Friend WithEvents Casket_Procument_feesNumericUpDown As NumericUpDown
    Friend WithEvents Bed_Chamber_CostNumericUpDown As NumericUpDown
    Friend WithEvents Ambulance_CostNumericUpDown As NumericUpDown
    Friend WithEvents Embalming_CostNumericUpDown As NumericUpDown
    Friend WithEvents Creamation_feesNumericUpDown As NumericUpDown
    Friend WithEvents Vault_Purchase_FeesNumericUpDown As NumericUpDown
    Friend WithEvents Autopsy_CostNumericUpDown As NumericUpDown
    Friend WithEvents Others_Processing_ChargesNumericUpDown As NumericUpDown
    Friend WithEvents Cost_Per_DayNumericUpDown As NumericUpDown
    Friend WithEvents Certificate_Processing_FeesNumericUpDown As NumericUpDown
    Friend WithEvents No_Of_DaysNumericUpDown As NumericUpDown
    Friend WithEvents HeigthNumericUpDown As NumericUpDown
    Friend WithEvents WeightNumericUpDown As NumericUpDown
    Friend WithEvents IDNumericUpDown As NumericUpDown
    Friend WithEvents pbBox As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents AgeNumericUpDown As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button9 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents ChamberTBBindingSource As BindingSource
    Friend WithEvents Chamber_TBTableAdapter As MORGUE_DATABASEDataSetTableAdapters.Chamber_TBTableAdapter
    Friend WithEvents ChamberTBBindingSource1 As BindingSource
    Friend WithEvents ChamberTBBindingSource2 As BindingSource
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
End Class
