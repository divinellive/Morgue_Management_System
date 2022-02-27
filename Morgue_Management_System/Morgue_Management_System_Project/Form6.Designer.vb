<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Dim Casket_Procument_feesLabel As System.Windows.Forms.Label
        Dim Vault_Purchase_FeesLabel As System.Windows.Forms.Label
        Dim Creamation_feesLabel As System.Windows.Forms.Label
        Dim Certificate_Processing_FeesLabel As System.Windows.Forms.Label
        Dim Ambulance_CostLabel As System.Windows.Forms.Label
        Dim Embalming_CostLabel As System.Windows.Forms.Label
        Dim Others_Processing_ChargesLabel As System.Windows.Forms.Label
        Dim Bed_Chamber_CostLabel As System.Windows.Forms.Label
        Dim Autopsy_CostLabel As System.Windows.Forms.Label
        Dim Cost_Per_DayLabel As System.Windows.Forms.Label
        Dim No_Of_DaysLabel As System.Windows.Forms.Label
        Dim LNameLabel As System.Windows.Forms.Label
        Dim FNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
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
        Me.Casket_Procument_feesTextBox = New System.Windows.Forms.TextBox()
        Me.Vault_Purchase_FeesTextBox = New System.Windows.Forms.TextBox()
        Me.Creamation_feesTextBox = New System.Windows.Forms.TextBox()
        Me.Certificate_Processing_FeesTextBox = New System.Windows.Forms.TextBox()
        Me.Ambulance_CostTextBox = New System.Windows.Forms.TextBox()
        Me.Embalming_CostTextBox = New System.Windows.Forms.TextBox()
        Me.Others_Processing_ChargesTextBox = New System.Windows.Forms.TextBox()
        Me.Bed_Chamber_CostTextBox = New System.Windows.Forms.TextBox()
        Me.Autopsy_CostTextBox = New System.Windows.Forms.TextBox()
        Me.Cost_Per_DayTextBox = New System.Windows.Forms.TextBox()
        Me.No_Of_DaysTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.searchComboBox = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.searchInput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.IDLabel1 = New System.Windows.Forms.Label()
        Me.Person_Deceased_TBTableAdapter = New Morgue_Management_System_Project.MORGUE_DATABASEDataSetTableAdapters.Person_Deceased_TBTableAdapter()
        Me.TableAdapterManager = New Morgue_Management_System_Project.MORGUE_DATABASEDataSetTableAdapters.TableAdapterManager()
        Me.Bills_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bills_TBTableAdapter = New Morgue_Management_System_Project.MORGUE_DATABASEDataSetTableAdapters.Bills_TBTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Casket_Procument_feesLabel = New System.Windows.Forms.Label()
        Vault_Purchase_FeesLabel = New System.Windows.Forms.Label()
        Creamation_feesLabel = New System.Windows.Forms.Label()
        Certificate_Processing_FeesLabel = New System.Windows.Forms.Label()
        Ambulance_CostLabel = New System.Windows.Forms.Label()
        Embalming_CostLabel = New System.Windows.Forms.Label()
        Others_Processing_ChargesLabel = New System.Windows.Forms.Label()
        Bed_Chamber_CostLabel = New System.Windows.Forms.Label()
        Autopsy_CostLabel = New System.Windows.Forms.Label()
        Cost_Per_DayLabel = New System.Windows.Forms.Label()
        No_Of_DaysLabel = New System.Windows.Forms.Label()
        LNameLabel = New System.Windows.Forms.Label()
        FNameLabel = New System.Windows.Forms.Label()
        CType(Me.Person_Deceased_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Person_Deceased_TBBindingNavigator.SuspendLayout()
        CType(Me.Person_Deceased_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MORGUE_DATABASEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bills_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Casket_Procument_feesLabel
        '
        Casket_Procument_feesLabel.AutoSize = True
        Casket_Procument_feesLabel.ForeColor = System.Drawing.Color.Red
        Casket_Procument_feesLabel.Location = New System.Drawing.Point(200, 482)
        Casket_Procument_feesLabel.Name = "Casket_Procument_feesLabel"
        Casket_Procument_feesLabel.Size = New System.Drawing.Size(120, 13)
        Casket_Procument_feesLabel.TabIndex = 1
        Casket_Procument_feesLabel.Text = "Casket Procument fees:"
        '
        'Vault_Purchase_FeesLabel
        '
        Vault_Purchase_FeesLabel.AutoSize = True
        Vault_Purchase_FeesLabel.ForeColor = System.Drawing.Color.Red
        Vault_Purchase_FeesLabel.Location = New System.Drawing.Point(211, 446)
        Vault_Purchase_FeesLabel.Name = "Vault_Purchase_FeesLabel"
        Vault_Purchase_FeesLabel.Size = New System.Drawing.Size(108, 13)
        Vault_Purchase_FeesLabel.TabIndex = 3
        Vault_Purchase_FeesLabel.Text = "Vault Purchase Fees:"
        '
        'Creamation_feesLabel
        '
        Creamation_feesLabel.AutoSize = True
        Creamation_feesLabel.ForeColor = System.Drawing.Color.Red
        Creamation_feesLabel.Location = New System.Drawing.Point(233, 375)
        Creamation_feesLabel.Name = "Creamation_feesLabel"
        Creamation_feesLabel.Size = New System.Drawing.Size(86, 13)
        Creamation_feesLabel.TabIndex = 5
        Creamation_feesLabel.Text = "Creamation fees:"
        '
        'Certificate_Processing_FeesLabel
        '
        Certificate_Processing_FeesLabel.AutoSize = True
        Certificate_Processing_FeesLabel.ForeColor = System.Drawing.Color.Red
        Certificate_Processing_FeesLabel.Location = New System.Drawing.Point(169, 541)
        Certificate_Processing_FeesLabel.Name = "Certificate_Processing_FeesLabel"
        Certificate_Processing_FeesLabel.Size = New System.Drawing.Size(150, 13)
        Certificate_Processing_FeesLabel.TabIndex = 7
        Certificate_Processing_FeesLabel.Text = "Certificate   Processing   Fees:"
        '
        'Ambulance_CostLabel
        '
        Ambulance_CostLabel.AutoSize = True
        Ambulance_CostLabel.ForeColor = System.Drawing.Color.Red
        Ambulance_CostLabel.Location = New System.Drawing.Point(233, 339)
        Ambulance_CostLabel.Name = "Ambulance_CostLabel"
        Ambulance_CostLabel.Size = New System.Drawing.Size(87, 13)
        Ambulance_CostLabel.TabIndex = 9
        Ambulance_CostLabel.Text = "Ambulance Cost:"
        '
        'Embalming_CostLabel
        '
        Embalming_CostLabel.AutoSize = True
        Embalming_CostLabel.ForeColor = System.Drawing.Color.Red
        Embalming_CostLabel.Location = New System.Drawing.Point(237, 302)
        Embalming_CostLabel.Name = "Embalming_CostLabel"
        Embalming_CostLabel.Size = New System.Drawing.Size(85, 13)
        Embalming_CostLabel.TabIndex = 11
        Embalming_CostLabel.Text = "Embalming Cost:"
        '
        'Others_Processing_ChargesLabel
        '
        Others_Processing_ChargesLabel.AutoSize = True
        Others_Processing_ChargesLabel.ForeColor = System.Drawing.Color.Red
        Others_Processing_ChargesLabel.Location = New System.Drawing.Point(182, 515)
        Others_Processing_ChargesLabel.Name = "Others_Processing_ChargesLabel"
        Others_Processing_ChargesLabel.Size = New System.Drawing.Size(140, 13)
        Others_Processing_ChargesLabel.TabIndex = 13
        Others_Processing_ChargesLabel.Text = "Others/Processing Charges:"
        '
        'Bed_Chamber_CostLabel
        '
        Bed_Chamber_CostLabel.AutoSize = True
        Bed_Chamber_CostLabel.ForeColor = System.Drawing.Color.Red
        Bed_Chamber_CostLabel.Location = New System.Drawing.Point(219, 411)
        Bed_Chamber_CostLabel.Name = "Bed_Chamber_CostLabel"
        Bed_Chamber_CostLabel.Size = New System.Drawing.Size(100, 13)
        Bed_Chamber_CostLabel.TabIndex = 15
        Bed_Chamber_CostLabel.Text = "Bed/Chamber Cost:"
        '
        'Autopsy_CostLabel
        '
        Autopsy_CostLabel.AutoSize = True
        Autopsy_CostLabel.ForeColor = System.Drawing.Color.Red
        Autopsy_CostLabel.Location = New System.Drawing.Point(247, 231)
        Autopsy_CostLabel.Name = "Autopsy_CostLabel"
        Autopsy_CostLabel.Size = New System.Drawing.Size(72, 13)
        Autopsy_CostLabel.TabIndex = 17
        Autopsy_CostLabel.Text = "Autopsy Cost:"
        '
        'Cost_Per_DayLabel
        '
        Cost_Per_DayLabel.AutoSize = True
        Cost_Per_DayLabel.ForeColor = System.Drawing.Color.Red
        Cost_Per_DayLabel.Location = New System.Drawing.Point(247, 266)
        Cost_Per_DayLabel.Name = "Cost_Per_DayLabel"
        Cost_Per_DayLabel.Size = New System.Drawing.Size(72, 13)
        Cost_Per_DayLabel.TabIndex = 19
        Cost_Per_DayLabel.Text = "Cost Per Day:"
        '
        'No_Of_DaysLabel
        '
        No_Of_DaysLabel.AutoSize = True
        No_Of_DaysLabel.ForeColor = System.Drawing.Color.Red
        No_Of_DaysLabel.Location = New System.Drawing.Point(255, 194)
        No_Of_DaysLabel.Name = "No_Of_DaysLabel"
        No_Of_DaysLabel.Size = New System.Drawing.Size(65, 13)
        No_Of_DaysLabel.TabIndex = 21
        No_Of_DaysLabel.Text = "No Of Days:"
        '
        'LNameLabel
        '
        LNameLabel.AutoSize = True
        LNameLabel.ForeColor = System.Drawing.Color.Red
        LNameLabel.Location = New System.Drawing.Point(261, 70)
        LNameLabel.Name = "LNameLabel"
        LNameLabel.Size = New System.Drawing.Size(61, 13)
        LNameLabel.TabIndex = 144
        LNameLabel.Text = "Last Name:"
        '
        'FNameLabel
        '
        FNameLabel.AutoSize = True
        FNameLabel.ForeColor = System.Drawing.Color.Red
        FNameLabel.Location = New System.Drawing.Point(276, 96)
        FNameLabel.Name = "FNameLabel"
        FNameLabel.Size = New System.Drawing.Size(44, 13)
        FNameLabel.TabIndex = 145
        FNameLabel.Text = "FName:"
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
        Me.Person_Deceased_TBBindingNavigator.Size = New System.Drawing.Size(448, 25)
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
        'Casket_Procument_feesTextBox
        '
        Me.Casket_Procument_feesTextBox.BackColor = System.Drawing.Color.Black
        Me.Casket_Procument_feesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Casket_Procument_fees", True))
        Me.Casket_Procument_feesTextBox.Enabled = False
        Me.Casket_Procument_feesTextBox.ForeColor = System.Drawing.Color.Red
        Me.Casket_Procument_feesTextBox.Location = New System.Drawing.Point(326, 479)
        Me.Casket_Procument_feesTextBox.Name = "Casket_Procument_feesTextBox"
        Me.Casket_Procument_feesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Casket_Procument_feesTextBox.TabIndex = 2
        '
        'Vault_Purchase_FeesTextBox
        '
        Me.Vault_Purchase_FeesTextBox.BackColor = System.Drawing.Color.Black
        Me.Vault_Purchase_FeesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Vault_Purchase_Fees", True))
        Me.Vault_Purchase_FeesTextBox.Enabled = False
        Me.Vault_Purchase_FeesTextBox.ForeColor = System.Drawing.Color.Red
        Me.Vault_Purchase_FeesTextBox.Location = New System.Drawing.Point(326, 443)
        Me.Vault_Purchase_FeesTextBox.Name = "Vault_Purchase_FeesTextBox"
        Me.Vault_Purchase_FeesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Vault_Purchase_FeesTextBox.TabIndex = 4
        '
        'Creamation_feesTextBox
        '
        Me.Creamation_feesTextBox.BackColor = System.Drawing.Color.Black
        Me.Creamation_feesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Creamation_fees", True))
        Me.Creamation_feesTextBox.Enabled = False
        Me.Creamation_feesTextBox.ForeColor = System.Drawing.Color.Red
        Me.Creamation_feesTextBox.Location = New System.Drawing.Point(326, 372)
        Me.Creamation_feesTextBox.Name = "Creamation_feesTextBox"
        Me.Creamation_feesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Creamation_feesTextBox.TabIndex = 6
        '
        'Certificate_Processing_FeesTextBox
        '
        Me.Certificate_Processing_FeesTextBox.BackColor = System.Drawing.Color.Black
        Me.Certificate_Processing_FeesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Certificate_Processing_Fees", True))
        Me.Certificate_Processing_FeesTextBox.Enabled = False
        Me.Certificate_Processing_FeesTextBox.ForeColor = System.Drawing.Color.Red
        Me.Certificate_Processing_FeesTextBox.Location = New System.Drawing.Point(326, 538)
        Me.Certificate_Processing_FeesTextBox.Name = "Certificate_Processing_FeesTextBox"
        Me.Certificate_Processing_FeesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Certificate_Processing_FeesTextBox.TabIndex = 8
        '
        'Ambulance_CostTextBox
        '
        Me.Ambulance_CostTextBox.BackColor = System.Drawing.Color.Black
        Me.Ambulance_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Ambulance_Cost", True))
        Me.Ambulance_CostTextBox.Enabled = False
        Me.Ambulance_CostTextBox.ForeColor = System.Drawing.Color.Red
        Me.Ambulance_CostTextBox.Location = New System.Drawing.Point(326, 336)
        Me.Ambulance_CostTextBox.Name = "Ambulance_CostTextBox"
        Me.Ambulance_CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ambulance_CostTextBox.TabIndex = 10
        '
        'Embalming_CostTextBox
        '
        Me.Embalming_CostTextBox.BackColor = System.Drawing.Color.Black
        Me.Embalming_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Embalming_Cost", True))
        Me.Embalming_CostTextBox.Enabled = False
        Me.Embalming_CostTextBox.ForeColor = System.Drawing.Color.Red
        Me.Embalming_CostTextBox.Location = New System.Drawing.Point(326, 299)
        Me.Embalming_CostTextBox.Name = "Embalming_CostTextBox"
        Me.Embalming_CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Embalming_CostTextBox.TabIndex = 12
        '
        'Others_Processing_ChargesTextBox
        '
        Me.Others_Processing_ChargesTextBox.BackColor = System.Drawing.Color.Black
        Me.Others_Processing_ChargesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Others/Processing_Charges", True))
        Me.Others_Processing_ChargesTextBox.Enabled = False
        Me.Others_Processing_ChargesTextBox.ForeColor = System.Drawing.Color.Red
        Me.Others_Processing_ChargesTextBox.Location = New System.Drawing.Point(326, 508)
        Me.Others_Processing_ChargesTextBox.Name = "Others_Processing_ChargesTextBox"
        Me.Others_Processing_ChargesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Others_Processing_ChargesTextBox.TabIndex = 14
        '
        'Bed_Chamber_CostTextBox
        '
        Me.Bed_Chamber_CostTextBox.BackColor = System.Drawing.Color.Black
        Me.Bed_Chamber_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Bed/Chamber_Cost", True))
        Me.Bed_Chamber_CostTextBox.Enabled = False
        Me.Bed_Chamber_CostTextBox.ForeColor = System.Drawing.Color.Red
        Me.Bed_Chamber_CostTextBox.Location = New System.Drawing.Point(326, 408)
        Me.Bed_Chamber_CostTextBox.Name = "Bed_Chamber_CostTextBox"
        Me.Bed_Chamber_CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Bed_Chamber_CostTextBox.TabIndex = 16
        '
        'Autopsy_CostTextBox
        '
        Me.Autopsy_CostTextBox.BackColor = System.Drawing.Color.Black
        Me.Autopsy_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Autopsy_Cost", True))
        Me.Autopsy_CostTextBox.Enabled = False
        Me.Autopsy_CostTextBox.ForeColor = System.Drawing.Color.Red
        Me.Autopsy_CostTextBox.Location = New System.Drawing.Point(326, 228)
        Me.Autopsy_CostTextBox.Name = "Autopsy_CostTextBox"
        Me.Autopsy_CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Autopsy_CostTextBox.TabIndex = 18
        '
        'Cost_Per_DayTextBox
        '
        Me.Cost_Per_DayTextBox.BackColor = System.Drawing.Color.Black
        Me.Cost_Per_DayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "Cost_Per_Day", True))
        Me.Cost_Per_DayTextBox.Enabled = False
        Me.Cost_Per_DayTextBox.ForeColor = System.Drawing.Color.Red
        Me.Cost_Per_DayTextBox.Location = New System.Drawing.Point(326, 263)
        Me.Cost_Per_DayTextBox.Name = "Cost_Per_DayTextBox"
        Me.Cost_Per_DayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cost_Per_DayTextBox.TabIndex = 20
        '
        'No_Of_DaysTextBox
        '
        Me.No_Of_DaysTextBox.BackColor = System.Drawing.Color.Black
        Me.No_Of_DaysTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "No_Of_Days", True))
        Me.No_Of_DaysTextBox.ForeColor = System.Drawing.Color.Red
        Me.No_Of_DaysTextBox.Location = New System.Drawing.Point(326, 191)
        Me.No_Of_DaysTextBox.Name = "No_Of_DaysTextBox"
        Me.No_Of_DaysTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_Of_DaysTextBox.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(21, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "TOTAL COST"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.ForeColor = System.Drawing.Color.Red
        Me.Button7.Location = New System.Drawing.Point(12, 37)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(47, 21)
        Me.Button7.TabIndex = 136
        Me.Button7.Text = "<< "
        Me.Button7.UseVisualStyleBackColor = True
        '
        'searchComboBox
        '
        Me.searchComboBox.BackColor = System.Drawing.Color.Black
        Me.searchComboBox.DropDownWidth = 130
        Me.searchComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.searchComboBox.FormattingEnabled = True
        Me.searchComboBox.Items.AddRange(New Object() {"ID"})
        Me.searchComboBox.Location = New System.Drawing.Point(313, 37)
        Me.searchComboBox.Name = "searchComboBox"
        Me.searchComboBox.Size = New System.Drawing.Size(17, 21)
        Me.searchComboBox.Sorted = True
        Me.searchComboBox.TabIndex = 143
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(239, 37)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 21)
        Me.Button3.TabIndex = 142
        Me.Button3.Text = "SEARCH BY"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'searchInput
        '
        Me.searchInput.BackColor = System.Drawing.Color.Black
        Me.searchInput.ForeColor = System.Drawing.Color.Lime
        Me.searchInput.Location = New System.Drawing.Point(329, 38)
        Me.searchInput.Name = "searchInput"
        Me.searchInput.Size = New System.Drawing.Size(97, 20)
        Me.searchInput.TabIndex = 141
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(21, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 21)
        Me.Button1.TabIndex = 144
        Me.Button1.Text = "SUM TOTAL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LNameTextBox
        '
        Me.LNameTextBox.BackColor = System.Drawing.Color.Black
        Me.LNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "LName", True))
        Me.LNameTextBox.Enabled = False
        Me.LNameTextBox.ForeColor = System.Drawing.Color.Lime
        Me.LNameTextBox.Location = New System.Drawing.Point(326, 67)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LNameTextBox.TabIndex = 146
        '
        'FNameTextBox
        '
        Me.FNameTextBox.BackColor = System.Drawing.Color.Black
        Me.FNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "FName", True))
        Me.FNameTextBox.Enabled = False
        Me.FNameTextBox.ForeColor = System.Drawing.Color.Lime
        Me.FNameTextBox.Location = New System.Drawing.Point(326, 93)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FNameTextBox.TabIndex = 147
        '
        'IDLabel1
        '
        Me.IDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_Deceased_TBBindingSource, "ID", True))
        Me.IDLabel1.ForeColor = System.Drawing.Color.Red
        Me.IDLabel1.Location = New System.Drawing.Point(65, 36)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(33, 23)
        Me.IDLabel1.TabIndex = 148
        Me.IDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Bills_TBBindingSource
        '
        Me.Bills_TBBindingSource.DataMember = "Bills_TB"
        Me.Bills_TBBindingSource.DataSource = Me.MORGUE_DATABASEDataSet
        '
        'Bills_TBTableAdapter
        '
        Me.Bills_TBTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(349, 565)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "EDIN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(378, 565)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "copyright"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(271, 565)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Ver. 0.1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(128, 565)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 13)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Morgue Management System "
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 578)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IDLabel1)
        Me.Controls.Add(Me.FNameTextBox)
        Me.Controls.Add(Me.LNameTextBox)
        Me.Controls.Add(FNameLabel)
        Me.Controls.Add(LNameLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.searchComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.searchInput)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(No_Of_DaysLabel)
        Me.Controls.Add(Me.No_Of_DaysTextBox)
        Me.Controls.Add(Cost_Per_DayLabel)
        Me.Controls.Add(Me.Cost_Per_DayTextBox)
        Me.Controls.Add(Autopsy_CostLabel)
        Me.Controls.Add(Me.Autopsy_CostTextBox)
        Me.Controls.Add(Bed_Chamber_CostLabel)
        Me.Controls.Add(Me.Bed_Chamber_CostTextBox)
        Me.Controls.Add(Others_Processing_ChargesLabel)
        Me.Controls.Add(Me.Others_Processing_ChargesTextBox)
        Me.Controls.Add(Embalming_CostLabel)
        Me.Controls.Add(Me.Embalming_CostTextBox)
        Me.Controls.Add(Ambulance_CostLabel)
        Me.Controls.Add(Me.Ambulance_CostTextBox)
        Me.Controls.Add(Certificate_Processing_FeesLabel)
        Me.Controls.Add(Me.Certificate_Processing_FeesTextBox)
        Me.Controls.Add(Creamation_feesLabel)
        Me.Controls.Add(Me.Creamation_feesTextBox)
        Me.Controls.Add(Vault_Purchase_FeesLabel)
        Me.Controls.Add(Me.Vault_Purchase_FeesTextBox)
        Me.Controls.Add(Casket_Procument_feesLabel)
        Me.Controls.Add(Me.Casket_Procument_feesTextBox)
        Me.Controls.Add(Me.Person_Deceased_TBBindingNavigator)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.Person_Deceased_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Person_Deceased_TBBindingNavigator.ResumeLayout(False)
        Me.Person_Deceased_TBBindingNavigator.PerformLayout()
        CType(Me.Person_Deceased_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MORGUE_DATABASEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bills_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Casket_Procument_feesTextBox As TextBox
    Friend WithEvents Vault_Purchase_FeesTextBox As TextBox
    Friend WithEvents Creamation_feesTextBox As TextBox
    Friend WithEvents Certificate_Processing_FeesTextBox As TextBox
    Friend WithEvents Ambulance_CostTextBox As TextBox
    Friend WithEvents Embalming_CostTextBox As TextBox
    Friend WithEvents Others_Processing_ChargesTextBox As TextBox
    Friend WithEvents Bed_Chamber_CostTextBox As TextBox
    Friend WithEvents Autopsy_CostTextBox As TextBox
    Friend WithEvents Cost_Per_DayTextBox As TextBox
    Friend WithEvents No_Of_DaysTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents searchComboBox As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents searchInput As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Bills_TBBindingSource As BindingSource
    Friend WithEvents Bills_TBTableAdapter As MORGUE_DATABASEDataSetTableAdapters.Bills_TBTableAdapter
    Friend WithEvents LNameTextBox As TextBox
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents IDLabel1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
