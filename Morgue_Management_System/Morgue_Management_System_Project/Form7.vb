Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Data
Imports System.IO
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class Form7
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DATABASE_FOLDER\MORGUE_DATABASE.mdb")
    Public Shared form2searchinput As String
    Private Sub Person_Deceased_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Person_Deceased_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Person_Deceased_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MORGUE_DATABASEDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MORGUE_DATABASEDataSet.Person_Deceased_TB' table. You can move, or remove it, as needed.


        If Class_Main.search_to_blue = 1 Then
            Me.Person_Deceased_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
            searchComboBox.SelectedItem = "All"
            searchInput.Text = form2searchinput
            Me.Person_Deceased_TBTableAdapter.searchByAllString(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%")
        Else
            Me.Person_Deceased_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
            searchComboBox.SelectedItem = "All"
        End If




    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Class_Main.purple_to_blue = 1 Then
            Me.Hide()
            Form4.Show()

        ElseIf Class_Main.dash_to_blue = 1 Then

            Me.Hide()
            Form2.Show()
        ElseIf Class_Main.search_to_blue = 1 Then
            Class_Main.search_to_blue = 0
            Me.Hide()
            Form2.Show()
        End If
        Class_Main.search_to_blue = 0

        ' Dim purple As New Class_Main
        'Dim dash As New Class_Main

    End Sub

    Private Sub Person_Deceased_TBDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim count As Integer
        ' count = Me.Person_Deceased_TBTableAdapter.ScalarQueryCount()

        If Not Label4.Text = Nothing Then
            Dim gridrowIndex As Integer = Person_Deceased_TBDataGridView.CurrentRow.Index
            gridrowIndex += 1
            Label1.Text = gridrowIndex
            Dim ID As Integer


            ID = CType(Label4.Text, Integer)









            Dim msgdialogresult As New DialogResult


            msgdialogresult = MessageBox.Show("                  ATTENTION!!!! " & vbCrLf & "YOU ARE ABOUT TO DELETE RECORD : " & gridrowIndex & " " & vbCrLf & "NAME: " & Label2.Text & " " & Label3.Text & "" & vbCrLf & " If you still want to proceed, Enter" & vbCrLf & " Administration credential and hit enter", "DELETE!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

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
                        '   currentID = Me.Person_Deceased_TBTableAdapter.ScalarQueryCount()

                        If gridrowIndex >= 1 Then
                            Me.Person_Deceased_TBTableAdapter.DeleteQueryBySpecificID(ID)
                            MessageBox.Show("RECORD ID : " & gridrowIndex & " DELETED SUCCESSFULLY", "DELETE!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
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


            Me.Person_Deceased_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)

        Else
            MessageBox.Show("NOTHING TO DELETE", "DELETE!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


        End If

    End Sub

    Private Sub Person_Deceased_TBDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click






        Select Case searchComboBox.SelectedItem
            Case "All"


                Me.Person_Deceased_TBTableAdapter.searchByAllString(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%", searchInput.Text & "%")


            Case "ID"
                Me.Person_Deceased_TBTableAdapter.SelectSpecificID(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Last Name"
                Me.Person_Deceased_TBTableAdapter.searchByLName(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "First Name"
                Me.Person_Deceased_TBTableAdapter.searchByFName(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Gender Male"
                Me.Person_Deceased_TBTableAdapter.searchByGenderMale(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
            Case "Gender Female"
                Me.Person_Deceased_TBTableAdapter.searchByGenderFemale(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
            Case "Gender Transgender"
                Me.Person_Deceased_TBTableAdapter.searchByGenderTransgender(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
            Case "Gender Others"
                Me.Person_Deceased_TBTableAdapter.searchByGenderOthers(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
            Case "Age"
                Me.Person_Deceased_TBTableAdapter.searchByAge(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Profession"
                Me.Person_Deceased_TBTableAdapter.searchByProfession(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Nationality"
                Me.Person_Deceased_TBTableAdapter.searchByNationality(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Ethnicity"
                Me.Person_Deceased_TBTableAdapter.searchByEthnicity(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Race"
                Me.Person_Deceased_TBTableAdapter.searchByRace(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Complexion"
                Me.Person_Deceased_TBTableAdapter.searchByComplexion(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Ambulance Request Yes"
                Me.Person_Deceased_TBTableAdapter.searchByAmbulanceServiceYES(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
            Case "Ambulance Request No"
                Me.Person_Deceased_TBTableAdapter.searchByAmbulanceServiceNO(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
            Case "Corpse Present In Morgue"
                Me.Person_Deceased_TBTableAdapter.searchByCorpseInMorgueYES(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
            Case "Corpse Released"
                Me.Person_Deceased_TBTableAdapter.searchByCorpseResleasedYES(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)
            Case "Corpse Fridge Number"
                Me.Person_Deceased_TBTableAdapter.searchByCorpseFridgeNo(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Corpse Tag Number"
                Me.Person_Deceased_TBTableAdapter.searchByCorpseTagNo(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Height"
                Me.Person_Deceased_TBTableAdapter.searchByHeight(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
            Case "Weight"
                Me.Person_Deceased_TBTableAdapter.searchByWeight(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB, searchInput.Text & "%")
        End Select




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Person_Deceased_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Person_Deceased_TB)





    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Person_Deceased_TBDataGridView_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles Person_Deceased_TBDataGridView.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub searchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchComboBox.SelectedIndexChanged

    End Sub

    Private Sub searchInput_TextChanged(sender As Object, e As EventArgs) Handles searchInput.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Person_Deceased_TBBindingSource.RemoveCurrent()
    End Sub
End Class