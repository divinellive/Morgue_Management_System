Imports System.Data
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class Form9
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DATABASE_FOLDER\MORGUE_DATABASE.mdb")

    Private Sub Bills_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Bills_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Bills_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MORGUE_DATABASEDataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MORGUE_DATABASEDataSet.Chamber_TB' table. You can move, or remove it, as needed.
        Me.Chamber_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Chamber_TB)
        'TODO: This line of code loads data into the 'MORGUE_DATABASEDataSet.Bills_TB' table. You can move, or remove it, as needed.
        Me.Bills_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Bills_TB)

    End Sub

    Private Sub Bills_TBDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Bills_TBDataGridView.CellContentClick

    End Sub

    Private Sub Chamber_TBDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Chamber_TBDataGridView.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Bills_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Bills_TB)
        Me.Chamber_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Chamber_TB)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Chamber_TBBindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Chamber_TBBindingSource.MoveLast()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Chamber_TBBindingSource.MovePrevious()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Chamber_TBBindingSource.MoveNext()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Bills_TBBindingSource.MoveLast()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Bills_TBBindingSource.MoveFirst()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Bills_TBBindingSource.MoveNext()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Bills_TBBindingSource.MovePrevious()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click





        Dim msgdialogresult As New DialogResult


        msgdialogresult = MessageBox.Show("                  ATTENTION!!!! " & vbCrLf & "YOU ARE ABOUT TO DELETE ALL COST RECORDS. If you still want to proceed, Enter Administration credential and hit enter", "DELETE!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

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
                    Dim BID As Integer
                    BID = CType(BIDLabel1.Text, Integer)

                    If BID >= 1 Then
                        Dim A As Integer
                        Bills_TBTableAdapter.Fill(MORGUE_DATABASEDataSet.Bills_TB)
                        A = Bills_TBTableAdapter.CountScalarQueryCount
                        con.Open()
                        Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM Bills_TB ", con)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        con.Close()
                        MessageBox.Show("ALL BILLS HAS BEEN DELETED SUCESSFULLY", "DELETE!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

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


        Me.Bills_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Bills_TB)












    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click






        If Not BIDLabel1.Text = Nothing Then
            Dim gridrowIndex As Integer = Bills_TBDataGridView.CurrentRow.Index
            gridrowIndex += 1
            Label3.Text = gridrowIndex
            Dim BID As Integer


            BID = CType(BIDLabel1.Text, Integer)









            Dim msgdialogresult As New DialogResult


            msgdialogresult = MessageBox.Show("                  ATTENTION!!!! " & vbCrLf & "YOU ARE ABOUT TO DELETE RECORD : " & gridrowIndex & " " & vbCrLf & "NAME: " & LNameTextBox.Text & " " & FnameTextBox.Text & "" & vbCrLf & " If you still want to proceed, Enter" & vbCrLf & " Administration credential and hit enter", "DELETE!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

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

                        If BID >= 1 Then
                            Me.Bills_TBTableAdapter.DeleteBySpecificBID(BID)
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


            Me.Bills_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Bills_TB)

        Else
            MessageBox.Show("NOTHING TO DELETE", "DELETE!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        End If


    End Sub
End Class