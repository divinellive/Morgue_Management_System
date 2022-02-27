Imports System.Data
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class Form6
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DATABASE_FOLDER\MORGUE_DATABASE.mdb")
    Private Sub Person_Deceased_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Person_Deceased_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Person_Deceased_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MORGUE_DATABASEDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MORGUE_DATABASEDataSet.Bills_TB' table. You can move, or remove it, as needed.
        Me.Bills_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Bills_TB)
        'TODO: This line of code loads data into the 'MORGUE_DATABASEDataSet.Person_Deceased_TB' table. You can move, or remove it, as needed.
        Me.Person_Deceased_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
        searchComboBox.SelectedItem = "ID"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LNameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FNameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checker As Integer = 0









        If No_Of_DaysTextBox.Text IsNot Nothing OrElse Autopsy_CostTextBox.Text <> Nothing OrElse Cost_Per_DayTextBox.Text <> Nothing OrElse Embalming_CostTextBox.Text <> Nothing OrElse Ambulance_CostTextBox.Text <> Nothing OrElse Creamation_feesTextBox.Text <> Nothing OrElse Bed_Chamber_CostTextBox.Text <> Nothing OrElse Vault_Purchase_FeesTextBox.Text <> Nothing OrElse Casket_Procument_feesTextBox.Text <> Nothing OrElse Others_Processing_ChargesTextBox.Text <> Nothing OrElse Certificate_Processing_FeesTextBox.Text <> Nothing Then



            If Not IsNumeric(No_Of_DaysTextBox.Text) Then
                No_Of_DaysTextBox.Text = 0
            End If
            If Not IsNumeric(Autopsy_CostTextBox.Text) Then
                Autopsy_CostTextBox.Text = 0
            End If
            If Not IsNumeric(Cost_Per_DayTextBox.Text) Then
                Cost_Per_DayTextBox.Text = 0
            End If
            If Not IsNumeric(Embalming_CostTextBox.Text) Then
                Embalming_CostTextBox.Text = 0
            End If
            If Not IsNumeric(Ambulance_CostTextBox.Text) Then
                Ambulance_CostTextBox.Text = 0
            End If
            If Not IsNumeric(Creamation_feesTextBox.Text) Then
                Creamation_feesTextBox.Text = 0
            End If
            If Not IsNumeric(Bed_Chamber_CostTextBox.Text) Then
                Bed_Chamber_CostTextBox.Text = 0
            End If
            If Not IsNumeric(Vault_Purchase_FeesTextBox.Text) Then
                Vault_Purchase_FeesTextBox.Text = 0
            End If
            If Not IsNumeric(Casket_Procument_feesTextBox.Text) Then
                Casket_Procument_feesTextBox.Text = 0
            End If
            If Not IsNumeric(Others_Processing_ChargesTextBox.Text) Then
                Others_Processing_ChargesTextBox.Text = 0
            End If
            If Not IsNumeric(Certificate_Processing_FeesTextBox.Text) Then
                Certificate_Processing_FeesTextBox.Text = 0
            End If



            Dim A, B, C, D, EN, F, G, H, I, J, K As Integer
            Dim final As Double
            A = CType(No_Of_DaysTextBox.Text, Double)
            B = CType(Autopsy_CostTextBox.Text, Double)
            C = CType(Cost_Per_DayTextBox.Text, Double)
            D = CType(Embalming_CostTextBox.Text, Double)
            EN = CType(Ambulance_CostTextBox.Text, Double)
            F = CType(Creamation_feesTextBox.Text, Double)
            G = CType(Bed_Chamber_CostTextBox.Text, Double)
            H = CType(Vault_Purchase_FeesTextBox.Text, Double)
            I = CType(Casket_Procument_feesTextBox.Text, Double)
            J = CType(Others_Processing_ChargesTextBox.Text, Double)
            K = CType(Certificate_Processing_FeesTextBox.Text, Double)

            If A <> 0 Then

                final = (A * C) + (A * G) + B + D + EN + F + H + I + J + K

                Label1.Text = FormatCurrency(final, 2, TriState.True,, TriState.True)
                No_Of_DaysTextBox.BackColor = Color.Black


            End If



            If Not IsNumeric(Label1.Text) Then
                Label1.Text = 0
            End If
            If Not IsNumeric(IDLabel1.Text) Then
                IDLabel1.Text = 0
            End If






            If Label1.Text IsNot Nothing And Label1.Text > 0 Then








                con.Open()

                Dim cmd As OleDbCommand = New OleDbCommand("insert into Bills_TB(LName, FName, Total_Cost, Deceased_ID)                      values(@LName, @FName, @Total_Cost, @Deceased_ID)", con)
                '  Dim cmd As OleDbCommand = New OleDbCommand("UPDATE Person_Deceased_TB SET [Photo] = ' @EmpPic ' WHERE [ID] = " & AID & " ", con)
                ' image content

                Dim LName As OleDbParameter = New OleDbParameter("@LName", LNameTextBox.Text)
                Dim FName As OleDbParameter = New OleDbParameter("@FName", FNameTextBox.Text)
                Dim Total_Cost As OleDbParameter = New OleDbParameter("@Total_Cost", Label1.Text)
                Dim Deceased_ID As OleDbParameter = New OleDbParameter("@Deceased_ID", IDLabel1.Text)




                cmd.Parameters.Add(LName)
                cmd.Parameters.Add(FName)
                cmd.Parameters.Add(Total_Cost)
                cmd.Parameters.Add(Deceased_ID)

                cmd.ExecuteNonQuery()
                MessageBox.Show("TOTAL COST RECORDED", "BILLS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                con.Close()
            ElseIf No_Of_DaysTextBox.Text < 1 Then


                MessageBox.Show("NUMBER OF DAYS CANNOT BE EMPTY" & vbCrLf & "        ENTER NUMBER OF DAYS THEN " & vbCrLf & " Click search by deceased ID at the top right corner before summing-up", "BILLS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)





            Else

                MessageBox.Show("NO BILLS RECORDED" & vbCrLf & "Click search by deceased ID at the top right corner before summing-up", "BILLS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            End If
        End If
        FNameTextBox.Clear()
        LNameTextBox.Clear()
        Label1.Text = String.Empty
        IDLabel1.Text = String.Empty

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Select Case searchComboBox.SelectedItem
            Case "ID"
                Me.Person_Deceased_TBTableAdapter.SelectSpecificID(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
        End Select

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class