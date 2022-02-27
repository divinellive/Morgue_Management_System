Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Data
Imports System.IO
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class Form8
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DATABASE_FOLDER\MORGUE_DATABASE.mdb")
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MORGUE_DATABASEDataSet.Staff_TB' table. You can move, or remove it, as needed.
        Me.Staff_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Staff_TB)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Staff_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Staff_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Staff_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MORGUE_DATABASEDataSet)

    End Sub

    Private Sub LnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LnameTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Staff_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Staff_TB)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        OpenFileDialog1.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.* "
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.PhotoPictureBox.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Not IDLabel1.Text = Nothing Then
            Dim gridrowIndex As Integer = Staff_TBDataGridView.CurrentRow.Index
            gridrowIndex += 1
            Label5.Text = gridrowIndex
            Dim ID As Integer


            ID = CType(IDLabel1.Text, Integer)









            Dim msgdialogresult As New DialogResult


            msgdialogresult = MessageBox.Show("                  ATTENTION!!!! " & vbCrLf & "YOU ARE ABOUT TO DELETE RECORD : " & gridrowIndex & " " & vbCrLf & "NAME: " & LnameTextBox.Text & " " & FnameTextBox.Text & "" & vbCrLf & " If you still want to proceed, Enter" & vbCrLf & " Administration credential and hit enter", "DELETE!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

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

                        If ID >= 1 Then
                            Me.Staff_TBTableAdapter.DeleteQueryBySpecificID(ID)
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


            Me.Staff_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Staff_TB)

        Else
            MessageBox.Show("NOTHING TO DELETE", "DELETE!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Staff_TBBindingSource.RemoveCurrent()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If LnameTextBox.Text <> Nothing OrElse FnameTextBox.Text <> Nothing OrElse TextBox4.Text <> Nothing OrElse TextBox1.Text <> Nothing OrElse PhotoPictureBox.Image IsNot Nothing Then

            If PhotoPictureBox.Image IsNot Nothing Then

                con.Open()
                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()
                Me.PhotoPictureBox.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)

                Dim cmd As OleDbCommand = New OleDbCommand("insert into Staff_TB(LName, FName, StaffID, Profession, Photo )                      values(@LName, @FName, @StaffID, @Profession, @Photo)", con)
                '  Dim cmd As OleDbCommand = New OleDbCommand("UPDATE Person_Deceased_TB SET [Photo] = ' @EmpPic ' WHERE [ID] = " & AID & " ", con)
                ' image content

                Dim LName As OleDbParameter = New OleDbParameter("@LName", TextBox3.Text)
                Dim FName As OleDbParameter = New OleDbParameter("@FName", TextBox2.Text)
                Dim StaffID As OleDbParameter = New OleDbParameter("@StaffID", TextBox4.Text)
                Dim Profession As OleDbParameter = New OleDbParameter("@Profession", TextBox1.Text)
                Dim photo As OleDbParameter = New OleDbParameter("@Photo", SqlDbType.Image)


                photo.Value = DataPic_Update
                cmd.Parameters.Add(LName)
                cmd.Parameters.Add(FName)
                cmd.Parameters.Add(StaffID)
                cmd.Parameters.Add(Profession)
                cmd.Parameters.Add(photo)


                cmd.ExecuteNonQuery()
                MessageBox.Show("IMAGE ATTACHED", "STAFF REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



                con.Close()
            Else


                con.Open()

                Dim cmd As OleDbCommand = New OleDbCommand("insert into Staff_TB(LName, FName, StaffID, Profession )                      values(@LName, @FName, @StaffID, @Profession)", con)
                '  Dim cmd As OleDbCommand = New OleDbCommand("UPDATE Person_Deceased_TB SET [Photo] = ' @EmpPic ' WHERE [ID] = " & AID & " ", con)
                ' image content

                Dim LName As OleDbParameter = New OleDbParameter("@LName", LnameTextBox.Text)
                Dim FName As OleDbParameter = New OleDbParameter("@FName", FnameTextBox.Text)
                Dim StaffID As OleDbParameter = New OleDbParameter("@StaffID", TextBox4.Text)
                Dim Profession As OleDbParameter = New OleDbParameter("@Profession", TextBox1.Text)




                cmd.Parameters.Add(LName)
                cmd.Parameters.Add(FName)
                cmd.Parameters.Add(StaffID)
                cmd.Parameters.Add(Profession)



                cmd.ExecuteNonQuery()
                MessageBox.Show("STAFF DETAILS ATTACHED", "STAFF REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



                con.Close()

            End If



            ' pbBox.Image = class_main.GetImageFromDB()
            MessageBox.Show("NEW RECORD ADDED SUCCESSFULLY", "DECEASED REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Else


            MessageBox.Show("ZERO!!! records entered", "DECEASED REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        End If

        FnameTextBox.Clear()
        LnameTextBox.Clear()
        TextBox4.Clear()
        TextBox1.Clear()


        PhotoPictureBox.Image = Nothing
        Me.Staff_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Staff_TB)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Staff_TBBindingSource.RemoveCurrent()
    End Sub
End Class