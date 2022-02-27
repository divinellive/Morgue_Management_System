Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Data
Imports System.IO
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class Form4
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DATABASE_FOLDER\MORGUE_DATABASE.mdb")
    Shared totalnum As Integer = 0
    Shared currentID As Integer = 0

    Private Sub Person_Deceased_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Person_Deceased_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Person_Deceased_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MORGUE_DATABASEDataSet)

    End Sub
    Public ReadOnly Property currentIID() As Integer
        Get
            Return currentID
        End Get
    End Property
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MORGUE_DATABASEDataSet.Chamber_TB' table. You can move, or remove it, as needed.
        Me.Chamber_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Chamber_TB)
        'TODO: This line of code loads data into the 'MORGUE_DATABASEDataSet.Person_Deceased_TB' table. You can move, or remove it, as needed.
        Person_Deceased_TBTableAdapter.Fill(MORGUE_DATABASEDataSet.Person_Deceased_TB)
        currentID = Me.Person_Deceased_TBTableAdapter.ScalarQueryCount()
        IDNumericUpDown.Value = currentID

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.* "
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.pbBox.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\EDEN\Documents\Visual Studio 2015\Projects\Morgue_Management_System_Project\DATABASE_FOLDER\MORGUE_DATABASE.mdb")
        'Dim cmdSelect As New OleDbCommand("SELECT * FROM Login_1_TB ", conn)
        'Dim cmdUpdate As New OleDbCommand("INSERT INTO  Person_Deceased_TB(Photo,LName,FName,Age,Gender,Address,Details,Profession,Nationality,Ethnicity,Race,Heigth,Weight,Time_Of_Birth,Time_Of_ Death,Complexion,Registration_Date,Release_Date,No_Of_Wifes,No_Of_Children,Corpse_Tag_No,Corpse_Fridge_No,Creamation_Request,Embalming_Request,Corpse_in_Morgue,Corpse_Released,Ambulance_Service,Autopsy_Status,Autopsy_Report,No_Of_Days,Cost_Per_Day,Autopsy_Cost,Bed/Chamber_Cost,Others/Processing_Charges,Embalming_Cost,Ambulance_Cost,Certificate_Processing_Fees,Creamation_fees,Vault_Purchase_Fees,Casket_Procument_fees) VALUES('" & pbBox & "','" & LNameTextBox & "','" & FNameTextBox & "','" & AgeTextBox & "','" & GenderComboBox & "','" & AddressTextBox & "','" & DetailsTextBox & "','" & ProfessionTextBox & "','" & NationalityTextBox & "','" & EthnicityTextBox & "','" & RaceComboBox & "','" & HeigthTextBox & "','" & WeightTextBox & "','" & Time_Of_BirthDateTimePicker & "','" & Time_Of__DeathDateTimePicker & "','" & ComplexionTextBox & "','" & Registration_DateDateTimePicker & "','" & Release_DateDateTimePicker & "','" & No_Of_WifesNumericUpDown & "','" & No_Of_ChildrenNumericUpDown & "','" & Corpse_Tag_NoTextBox & "','" & Corpse_Fridge_NoTextBox & "','" & Creamation_RequestComboBox & "','" & Embalming_RequestComboBox & "','" & Corpse_in_MorgueComboBox & "','" & Corpse_ReleasedComboBox & "','" & Ambulance_ServiceComboBox & "','" & Autopsy_StatusComboBox & "','" & Autopsy_ReportTextBox & "','" & No_Of_DaysNumericUpDown & "','" & Cost_Per_DayTextBox & "','" & Autopsy_CostTextBox & "','" & Bed_Chamber_CostTextBox & "','" & Others_Processing_ChargesTextBox & "','" & Embalming_CostTextBox & "','" & Ambulance_CostTextBox & "','" & Certificate_Processing_FeesTextBox & "','" & Creamation_feesTextBox & "','" & Vault_Purchase_FeesTextBox & "','" & Casket_Procument_feesTextBox & "')", conn)
        Dim AID As Integer = NumericUpDown1.Value

        If pbBox.Image IsNot Nothing OrElse LNameTextBox.Text <> Nothing OrElse FNameTextBox.Text <> Nothing OrElse AgeNumericUpDown.Value <> Nothing OrElse GenderComboBox.Text <> Nothing OrElse AddressTextBox.Text <> Nothing OrElse DetailsTextBox.Text <> Nothing OrElse ProfessionTextBox.Text <> Nothing OrElse NationalityTextBox.Text <> Nothing OrElse EthnicityTextBox.Text <> Nothing OrElse RaceComboBox.Text <> Nothing OrElse HeigthNumericUpDown.Value > 0 OrElse WeightNumericUpDown.Value > 0 OrElse ComplexionTextBox.Text <> Nothing OrElse No_Of_WifesNumericUpDown.Value > 0 OrElse No_Of_ChildrenNumericUpDown.Value > 0 OrElse Corpse_Tag_NoTextBox.Text <> Nothing OrElse Corpse_Fridge_NoTextBox.Text <> Nothing OrElse Creamation_RequestComboBox.Text <> Nothing OrElse Embalming_RequestComboBox.Text <> Nothing OrElse Corpse_in_MorgueComboBox.Text <> Nothing OrElse Corpse_ReleasedComboBox.Text <> Nothing OrElse Ambulance_ServiceComboBox.Text <> Nothing OrElse Autopsy_StatusComboBox.Text <> Nothing OrElse Autopsy_ReportTextBox.Text <> Nothing OrElse No_Of_DaysNumericUpDown.Value > 0 OrElse Cost_Per_DayNumericUpDown.Value > 0 OrElse Autopsy_CostNumericUpDown.Value > 0 OrElse Bed_Chamber_CostNumericUpDown.Value > 0 OrElse Others_Processing_ChargesNumericUpDown.Value > 0 OrElse Embalming_CostNumericUpDown.Value > 0 OrElse Ambulance_CostNumericUpDown.Value > 0 OrElse Certificate_Processing_FeesNumericUpDown.Value > 0 OrElse Creamation_feesNumericUpDown.Value > 0 OrElse Vault_Purchase_FeesNumericUpDown.Value > 0 OrElse Casket_Procument_feesNumericUpDown.Value > 0 Then



            If Not IsNumeric(AgeNumericUpDown.Value) Then
                AgeNumericUpDown.Value = 0
            End If
            If Not IsNumeric(HeigthNumericUpDown.Value) Then
                HeigthNumericUpDown.Value = 0
            End If
            If Not IsNumeric(WeightNumericUpDown.Value) Then
                WeightNumericUpDown.Value = 0
            End If
            If Not IsNumeric(No_Of_WifesNumericUpDown.Value) Then
                No_Of_WifesNumericUpDown.Value = 0
            End If
            If Not IsNumeric(No_Of_ChildrenNumericUpDown.Value) Then
                No_Of_ChildrenNumericUpDown.Value = 0
            End If
            If Not IsNumeric(No_Of_DaysNumericUpDown.Value) Then
                No_Of_DaysNumericUpDown.Value = 0
            End If
            If Not IsNumeric(Casket_Procument_feesNumericUpDown.Value) Then
                Casket_Procument_feesNumericUpDown.Value = 0
            End If
            If Not IsNumeric(Bed_Chamber_CostNumericUpDown.Value) Then
                Bed_Chamber_CostNumericUpDown.Value = 0
            End If
            If Not IsNumeric(Ambulance_CostNumericUpDown.Value) Then
                Embalming_CostNumericUpDown.Value = 0
            End If
            If Not IsNumeric(Creamation_feesNumericUpDown.Value) Then
                Creamation_feesNumericUpDown.Value = 0
            End If
            If Not IsNumeric(Vault_Purchase_FeesNumericUpDown.Value) Then
                Vault_Purchase_FeesNumericUpDown.Value = 0
            End If
            If Not IsNumeric(Autopsy_CostNumericUpDown.Value) Then
                Autopsy_CostNumericUpDown.Value = 0
            End If
            If Not IsNumeric(Others_Processing_ChargesNumericUpDown.Value) Then
                Others_Processing_ChargesNumericUpDown.Value = 0
            End If
            If Not IsNumeric(Cost_Per_DayNumericUpDown.Value) Then
                Cost_Per_DayNumericUpDown.Value = 0
            End If
            If Not IsNumeric(Certificate_Processing_FeesNumericUpDown.Value) Then
                Certificate_Processing_FeesNumericUpDown.Value = 0
            End If

            currentID = Me.Person_Deceased_TBTableAdapter.ScalarQueryCount()
            currentID = currentID + 1
            Me.Validate()
            Me.Person_Deceased_TBBindingSource.EndEdit()


            If pbBox.Image IsNot Nothing Then

                con.Open()
                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()
                Me.pbBox.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)

                Dim cmd As OleDbCommand = New OleDbCommand("insert into Person_Deceased_TB(Photo,LName, FName, Age, Gender, Address, Details, Profession, Nationality,Ethnicity, Race, Heigth, Weight, Time_Of_Birth,[Time_Of_ Death], Complexion, Registration_Date, Release_Date, No_Of_Wifes, No_Of_Children, Corpse_Tag_No, Corpse_Fridge_No, Creamation_Request, Embalming_Request, Corpse_in_Morgue, Corpse_Released, Ambulance_Service, Autopsy_Status, Autopsy_Report, No_Of_Days, Cost_Per_Day, Autopsy_Cost, [Bed/Chamber_Cost], [Others/Processing_Charges], Embalming_Cost, Ambulance_Cost, Certificate_Processing_Fees, Creamation_fees, Vault_Purchase_Fees, Casket_Procument_fees)                      values(@EmpPic,@LName, @FName, @Age, @Gender, @Address, @Details, @Profession, @Nationality, @Ethnicity, @Race , @Heigth, @Weight, @Time_Of_Birth,[@Time_Of_ Death], @Complexion, @Registration_Date, @Release_Date, @No_Of_Wifes, @No_Of_Children, @Corpse_Tag_No, @Corpse_Fridge_No, @Creamation_Request, @Embalming_Request, @Corpse_in_Morgue, @Corpse_Released, @Ambulance_Service, @Autopsy_Status, @Autopsy_Report, @No_Of_Days, @Cost_Per_Day, @Autopsy_Cost, [@Bed/Chamber_Cost], [@Others/Processing_Charges], @Embalming_Cost, @Ambulance_Cost, @Certificate_Processing_Fees, @Creamation_fees, @Vault_Purchase_Fees, @Casket_Procument_fees)", con)
                '  Dim cmd As OleDbCommand = New OleDbCommand("UPDATE Person_Deceased_TB SET [Photo] = ' @EmpPic ' WHERE [ID] = " & AID & " ", con)
                ' image content
                Dim photo As OleDbParameter = New OleDbParameter("@EmpPic", SqlDbType.Image)
                Dim LName As OleDbParameter = New OleDbParameter("@LName", LNameTextBox.Text)
                Dim FName As OleDbParameter = New OleDbParameter("@FName", FNameTextBox.Text)
                Dim Age As OleDbParameter = New OleDbParameter("@Age", AgeNumericUpDown.Value)
                Dim Gender As OleDbParameter = New OleDbParameter("@Gender", GenderComboBox.Text)
                Dim Address As OleDbParameter = New OleDbParameter("@Address", AddressTextBox.Text)
                Dim Details As OleDbParameter = New OleDbParameter("@Details", DetailsTextBox.Text)
                Dim Profession As OleDbParameter = New OleDbParameter("@Profession", ProfessionTextBox.Text)
                Dim Nationality As OleDbParameter = New OleDbParameter("@Nationality", NationalityTextBox.Text)
                Dim Ethnicity As OleDbParameter = New OleDbParameter("@Ethnicity", EthnicityTextBox.Text)
                Dim Race As OleDbParameter = New OleDbParameter("@Race", RaceComboBox.Text)
                Dim Heigth As OleDbParameter = New OleDbParameter("@Heigth", HeigthNumericUpDown.Value)
                Dim Weight As OleDbParameter = New OleDbParameter("@Weight", WeightNumericUpDown.Value)
                Dim Time_Of_Birth As OleDbParameter = New OleDbParameter("@Time_Of_Birth", Time_Of_BirthDateTimePicker.Text)
                Dim Time_Of_Death As OleDbParameter = New OleDbParameter("@Time_Of_ Death", Time_Of__DeathDateTimePicker.Text)
                Dim Complexion As OleDbParameter = New OleDbParameter("@Complexion", ComplexionTextBox.Text)
                Dim Registration_Date As OleDbParameter = New OleDbParameter("@Registration_Date", Registration_DateDateTimePicker.Text)
                Dim Release_Date As OleDbParameter = New OleDbParameter("@Release_Date", Release_DateDateTimePicker.Text)
                Dim No_Of_Wifes As OleDbParameter = New OleDbParameter("@No_Of_Wifes", No_Of_WifesNumericUpDown.Value)
                Dim No_Of_Children As OleDbParameter = New OleDbParameter("@No_Of_Children", No_Of_ChildrenNumericUpDown.Value)
                Dim Corpse_Tag_No As OleDbParameter = New OleDbParameter("@Corpse_Tag_No", Corpse_Tag_NoTextBox.Text)
                Dim Corpse_Fridge_No As OleDbParameter = New OleDbParameter("@Corpse_Fridge_No", Corpse_Fridge_NoTextBox.Text)
                Dim Creamation_Request As OleDbParameter = New OleDbParameter("@Creamation_Request", Creamation_RequestComboBox.Text)
                Dim Embalming_Request As OleDbParameter = New OleDbParameter("@Embalming_Request", Embalming_RequestComboBox.Text)
                Dim Corpse_in_Morgue As OleDbParameter = New OleDbParameter("@Corpse_in_Morgue", Corpse_in_MorgueComboBox.Text)
                Dim Corpse_Released As OleDbParameter = New OleDbParameter("@Corpse_Released", Corpse_ReleasedComboBox.Text)
                Dim Ambulance_Service As OleDbParameter = New OleDbParameter("@Ambulance_Service", Ambulance_ServiceComboBox.Text)
                Dim Autopsy_Status As OleDbParameter = New OleDbParameter("@Autopsy_Status", Autopsy_StatusComboBox.Text)
                Dim Autopsy_Report As OleDbParameter = New OleDbParameter("@Autopsy_Report", Autopsy_ReportTextBox.Text)
                Dim No_Of_Days As OleDbParameter = New OleDbParameter("@No_Of_Days", No_Of_DaysNumericUpDown.Value)
                Dim Cost_Per_Day As OleDbParameter = New OleDbParameter("@Cost_Per_Day", Cost_Per_DayNumericUpDown.Value)
                Dim Autopsy_Cost As OleDbParameter = New OleDbParameter("@Autopsy_Cost", Autopsy_CostNumericUpDown.Value)
                Dim Bed_Chamber_Cost As OleDbParameter = New OleDbParameter("@Bed/Chamber_Cost", Bed_Chamber_CostNumericUpDown.Value)
                Dim Others_Processing_Charges As OleDbParameter = New OleDbParameter("@Others/Processing_Charges", Others_Processing_ChargesNumericUpDown.Value)
                Dim Embalming_Cost As OleDbParameter = New OleDbParameter("@Embalming_Cost", Embalming_CostNumericUpDown.Value)
                Dim Ambulance_Cost As OleDbParameter = New OleDbParameter("@Ambulance_Cost", Ambulance_CostNumericUpDown.Value)
                Dim Certificate_Processing_Fees As OleDbParameter = New OleDbParameter("@Certificate_Processing_Fees", Certificate_Processing_FeesNumericUpDown.Value)
                Dim Creamation_fees As OleDbParameter = New OleDbParameter("@Creamation_fees", Creamation_feesNumericUpDown.Value)
                Dim Vault_Purchase_Fees As OleDbParameter = New OleDbParameter("@Vault_Purchase_Fees", Vault_Purchase_FeesNumericUpDown.Value)
                Dim Casket_Procument_fees As OleDbParameter = New OleDbParameter("@Casket_Procument_fees", Casket_Procument_feesNumericUpDown.Value)



                photo.Value = DataPic_Update
                cmd.Parameters.Add(photo)
                cmd.Parameters.Add(LName)
                cmd.Parameters.Add(FName)
                cmd.Parameters.Add(Age)
                cmd.Parameters.Add(Gender)
                cmd.Parameters.Add(Address)
                cmd.Parameters.Add(Details)
                cmd.Parameters.Add(Profession)
                cmd.Parameters.Add(Nationality)
                cmd.Parameters.Add(Ethnicity)
                cmd.Parameters.Add(Race)
                cmd.Parameters.Add(Heigth)
                cmd.Parameters.Add(Weight)
                cmd.Parameters.Add(Time_Of_Birth)
                cmd.Parameters.Add(Time_Of_Death)
                cmd.Parameters.Add(Complexion)
                cmd.Parameters.Add(Registration_Date)
                cmd.Parameters.Add(Release_Date)
                cmd.Parameters.Add(No_Of_Wifes)
                cmd.Parameters.Add(No_Of_Children)
                cmd.Parameters.Add(Corpse_Tag_No)
                cmd.Parameters.Add(Corpse_Fridge_No)
                cmd.Parameters.Add(Creamation_Request)
                cmd.Parameters.Add(Embalming_Request)
                cmd.Parameters.Add(Corpse_in_Morgue)
                cmd.Parameters.Add(Corpse_Released)
                cmd.Parameters.Add(Ambulance_Service)
                cmd.Parameters.Add(Autopsy_Status)
                cmd.Parameters.Add(Autopsy_Report)
                cmd.Parameters.Add(No_Of_Days)
                cmd.Parameters.Add(Cost_Per_Day)
                cmd.Parameters.Add(Autopsy_Cost)
                cmd.Parameters.Add(Bed_Chamber_Cost)
                cmd.Parameters.Add(Others_Processing_Charges)
                cmd.Parameters.Add(Embalming_Cost)
                cmd.Parameters.Add(Ambulance_Cost)
                cmd.Parameters.Add(Certificate_Processing_Fees)
                cmd.Parameters.Add(Creamation_fees)
                cmd.Parameters.Add(Vault_Purchase_Fees)
                cmd.Parameters.Add(Casket_Procument_fees)




                cmd.ExecuteNonQuery()
                MessageBox.Show("IMAGE ATTACHED", "DECEASED REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



                con.Close()




            End If


            IDNumericUpDown.Value = currentID
            ' pbBox.Image = class_main.GetImageFromDB()
            MessageBox.Show("NEW RECORD ADDED SUCCESSFULLY", "DECEASED REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else


            MessageBox.Show("ZERO!!! records entered", "DECEASED REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        End If

        FNameTextBox.Clear()
        LNameTextBox.Clear()
        AgeNumericUpDown.ResetText()
        HeigthNumericUpDown.ResetText()
        WeightNumericUpDown.ResetText()
        GenderComboBox.Text = String.Empty
        RaceComboBox.Text = String.Empty
        ProfessionTextBox.Clear()
        Ambulance_ServiceComboBox.ResetText()
        NationalityTextBox.Clear()
        EthnicityTextBox.Clear()
        ComplexionTextBox.Clear()
        Embalming_RequestComboBox.Text = String.Empty
        No_Of_WifesNumericUpDown.ResetText()
        No_Of_ChildrenNumericUpDown.ResetText()
        Corpse_Tag_NoTextBox.Clear()
        Corpse_Fridge_NoTextBox.Clear()
        Creamation_RequestComboBox.Text = String.Empty
        Embalming_CostNumericUpDown.ResetText()
        Corpse_in_MorgueComboBox.Text = String.Empty
        Corpse_ReleasedComboBox.Text = String.Empty
        Ambulance_CostNumericUpDown.ResetText()
        Autopsy_StatusComboBox.Text = String.Empty
        Autopsy_ReportTextBox.Clear()
        No_Of_DaysNumericUpDown.ResetText()
        Cost_Per_DayNumericUpDown.ResetText()
        Autopsy_CostNumericUpDown.ResetText()
        Bed_Chamber_CostNumericUpDown.ResetText()
        Others_Processing_ChargesNumericUpDown.ResetText()
        Embalming_CostNumericUpDown.ResetText()
        Ambulance_CostNumericUpDown.ResetText()
        Certificate_Processing_FeesNumericUpDown.ResetText()
        Creamation_feesNumericUpDown.ResetText()
        Vault_Purchase_FeesNumericUpDown.ResetText()
        Casket_Procument_feesNumericUpDown.ResetText()
        DetailsTextBox.Text = String.Empty
        AddressTextBox.Text = String.Empty
        pbBox.Image = Nothing


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FNameTextBox.Clear()
        LNameTextBox.Clear()
        AgeNumericUpDown.ResetText()
        HeigthNumericUpDown.ResetText()
        WeightNumericUpDown.ResetText()
        GenderComboBox.Text = String.Empty
        RaceComboBox.Text = String.Empty
        ProfessionTextBox.Clear()
        Ambulance_ServiceComboBox.ResetText()
        NationalityTextBox.Clear()
        EthnicityTextBox.Clear()
        ComplexionTextBox.Clear()
        Embalming_RequestComboBox.Text = String.Empty
        No_Of_WifesNumericUpDown.ResetText()
        No_Of_ChildrenNumericUpDown.ResetText()
        Corpse_Tag_NoTextBox.Clear()
        Corpse_Fridge_NoTextBox.Clear()
        Creamation_RequestComboBox.Text = String.Empty
        Embalming_CostNumericUpDown.ResetText()
        Corpse_in_MorgueComboBox.Text = String.Empty
        Corpse_ReleasedComboBox.Text = String.Empty
        Ambulance_CostNumericUpDown.ResetText()
        Autopsy_StatusComboBox.Text = String.Empty
        Autopsy_ReportTextBox.Clear()
        No_Of_DaysNumericUpDown.ResetText()
        Cost_Per_DayNumericUpDown.ResetText()
        Autopsy_CostNumericUpDown.ResetText()
        Bed_Chamber_CostNumericUpDown.ResetText()
        Others_Processing_ChargesNumericUpDown.ResetText()
        Embalming_CostNumericUpDown.ResetText()
        Ambulance_CostNumericUpDown.ResetText()
        Certificate_Processing_FeesNumericUpDown.ResetText()
        Creamation_feesNumericUpDown.ResetText()
        Vault_Purchase_FeesNumericUpDown.ResetText()
        Casket_Procument_feesNumericUpDown.ResetText()
        DetailsTextBox.Text = String.Empty
        AddressTextBox.Text = String.Empty

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Person_Deceased_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MORGUE_DATABASEDataSet)
        MessageBox.Show("UPDATE COMPLETED SUCCESSFULLY", "DECEASED REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim AID As Integer
        AID = NumericUpDown1.Value
        Dim id As New Integer
        id = IDNumericUpDown.Value
        Me.Person_Deceased_TBTableAdapter.SelectSpecificLNameFName(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, AID)
        Dim LLname, FFname As String
        LLname = LNameTextBox.Text
        FFname = FNameTextBox.Text


        Dim msgdialogresult As New DialogResult


        msgdialogresult = MessageBox.Show("                  ATTENTION!!!! " & vbCrLf & "YOU ARE ABOUT TO DELETE RECORD : " & id & " " & vbCrLf & "NAME: " & LLname & " " & FFname & "" & vbCrLf & " If you still want to proceed, Enter" & vbCrLf & " Administration credential and hit enter", "DELETE!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

        If msgdialogresult = System.Windows.Forms.DialogResult.Yes Then


            Dim result As String
            Dim main As New Class_Main

            Dim user As String
            Dim pass As String


            Do
                user = InputBox("ENTER ADMIN USERNAME ", "ADMIN AUTHENTICATION", "")
                pass = InputBox("ENTER ADMIN PASSWORD ", "ADMIN AUTHENTICATION", "")
                result = main.login1(user, pass)
                If result = "castlevaniasdxhgbuhyftyrsrerfgteinsteinsingcxgchjbmhgnbgfjsaertt" Then
                    Me.Validate()
                    currentID = Me.Person_Deceased_TBTableAdapter.ScalarQueryCount()

                    If currentID > 0 Then
                        Me.Person_Deceased_TBTableAdapter.DeleteQueryBySpecificID(AID)
                        MessageBox.Show("RECORD ID : " & id & " DELETED SUCCESSFULLY", "DELETE!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        id = id - 1
                        IDNumericUpDown.Value = id
                        Exit Do
                    Else
                        MessageBox.Show("THERE ARE NO RECORDS TO DELETE", "DELETE!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Exit Do
                    End If
                End If
            Loop Until (user = "" And pass = "")


        ElseIf msgdialogresult = System.Windows.Forms.DialogResult.No Then
            MessageBox.Show("OPERATION CANCEALED", "DELETE!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Corpse_ReleasedComboBox.Enabled = True
        Casket_Procument_feesNumericUpDown.Enabled = True
        FNameTextBox.Enabled = True
        LNameTextBox.Enabled = True
        AgeNumericUpDown.Enabled = True
        HeigthNumericUpDown.Enabled = True
        WeightNumericUpDown.Enabled = True
        GenderComboBox.Enabled = True
        RaceComboBox.Enabled = True
        ProfessionTextBox.Enabled = True
        Time_Of_BirthDateTimePicker.Enabled = True
        Time_Of__DeathDateTimePicker.Enabled = True
        NationalityTextBox.Enabled = True
        EthnicityTextBox.Enabled = True
        ComplexionTextBox.Enabled = True
        Registration_DateDateTimePicker.Enabled = True
        Release_DateDateTimePicker.Enabled = True
        No_Of_WifesNumericUpDown.Enabled = True
        No_Of_ChildrenNumericUpDown.Enabled = True
        Corpse_Tag_NoTextBox.Enabled = True
        Corpse_Fridge_NoTextBox.Enabled = True
        Creamation_RequestComboBox.Enabled = True
        Embalming_CostNumericUpDown.Enabled = True
        Corpse_in_MorgueComboBox.Enabled = True
        Corpse_ReleasedComboBox.Enabled = True
        Ambulance_CostNumericUpDown.Enabled = True
        Autopsy_StatusComboBox.Enabled = True
        Autopsy_ReportTextBox.Enabled = True
        No_Of_DaysNumericUpDown.Enabled = True
        Cost_Per_DayNumericUpDown.Enabled = True
        Autopsy_CostNumericUpDown.Enabled = True
        Bed_Chamber_CostNumericUpDown.Enabled = True
        Others_Processing_ChargesNumericUpDown.Enabled = True
        Embalming_CostNumericUpDown.Enabled = True
        Certificate_Processing_FeesNumericUpDown.Enabled = True
        Creamation_feesNumericUpDown.Enabled = True
        Vault_Purchase_FeesNumericUpDown.Enabled = True
        Casket_Procument_feesNumericUpDown.Enabled = True
        Embalming_RequestComboBox.Enabled = True

    End Sub

    Private Sub pbBox_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Corpse_Tag_NoTextBox_TextChanged(sender As Object, e As EventArgs) Handles Corpse_Tag_NoTextBox.TextChanged

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Creamation_feesTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Registration_DateLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Release_DateLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Time_Of__DeathLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Time_Of_BirthLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Creamation_RequestComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Creamation_RequestComboBox.SelectedIndexChanged

    End Sub

    Private Sub No_Of_ChildrenNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles No_Of_ChildrenNumericUpDown.ValueChanged

    End Sub

    Private Sub Cost_Per_DayLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Autopsy_CostLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Corpse_ReleasedComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Corpse_ReleasedComboBox.SelectedIndexChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form1.Close()
    End Sub

    Private Sub Person_Deceased_TBBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Person_Deceased_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Person_Deceased_TBBindingSource.MoveNext()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click


        Person_Deceased_TBBindingSource.MovePrevious()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Person_Deceased_TBBindingSource.MoveLast()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Person_Deceased_TBBindingSource.MoveFirst()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Class_Main.dash_to_blue = 0
        Class_Main.purple_to_blue = 1
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub LNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LNameTextBox.TextChanged

    End Sub

    Private Sub WeightNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles WeightNumericUpDown.ValueChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Person_Deceased_TBTableAdapter.Fill(MORGUE_DATABASEDataSet.Person_Deceased_TB)

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub
End Class