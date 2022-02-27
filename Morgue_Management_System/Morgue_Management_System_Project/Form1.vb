Imports System.Data
Imports System.Data.OleDb
Imports System.Data.DataTable

Public Class Form1
    Public Shared verify As Integer

    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DATABASE_FOLDER\MORGUE_DATABASE.mdb")



    Private Sub btnLogin1_Click(sender As Object, e As EventArgs) Handles btnLogin1.Click
        con.Open()
        Dim cmd_user As New OleDbCommand("SELECT * FROM Login_1_TB WHERE Username = '" & txtUsername1.Text & "'", con)
        Dim cmd_pass As New OleDbCommand("SELECT * FROM Login_1_TB WHERE Password = '" & txtPassword1.Text & "'", con)
        Dim cmdbed As New OleDbCommand("SELECT * FROM Miscellaneous_TB WHERE first_time_opening = 0 ", con)
        Dim dr_user As OleDbDataReader = cmd_user.ExecuteReader
        Dim dr_pass As OleDbDataReader = cmd_pass.ExecuteReader
        Dim dr_bed As OleDbDataReader = cmdbed.ExecuteReader

        cmd_user.Dispose()
        cmd_pass.Dispose()
        cmdbed.Dispose()

        If (dr_user.Read() = True And dr_pass.Read() = True) Then

            'Dim cmdVerifybed As New OleDbCommand("SELECT VerifyBed FROM Login_1_TB WHERE  ID = 1 ", con)
            ' Dim VerifybedReader As OleDbDataReader = cmdVerifybed.ExecuteReader

            If (dr_bed.Read() = True) Then





            Else



                Dim A As String
                Dim idd As Integer = 1
                Dim chambe_IDD As Integer = 1
                Do

                    A = InputBox("HOW MANY CHAMBERS ARE AVAILABLE IN YOUR MORGUE" & vbCrLf & "PLEASE ENTER A COUNTING NUMBER")
                    If IsNumeric(A) = True Then

                        If A > 0 Then

                            Dim i As Integer = 1

                            For i = 1 To A Step 1

                                Dim cmd As OleDbCommand = New OleDbCommand("insert into Chamber_TB(ID,chamber_ID)     values(@ID,@chamber_ID)", con)

                                Dim ID As OleDbParameter = New OleDbParameter("@ID", idd)
                                Dim chambe_ID As OleDbParameter = New OleDbParameter("@chambe_ID", "BED" & chambe_IDD)



                                cmd.Parameters.Add(ID)
                                cmd.Parameters.Add(chambe_ID)

                                cmd.ExecuteNonQuery()
                                cmd.Dispose()
                                chambe_IDD += 1
                                idd += 1
                            Next

                            Exit Do


                        End If
                        MessageBox.Show("                      INVALID ENTRY " & vbCrLf & "PLEASE ENTER A POSSITIVE NUMBER 1 OR ABOVE", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Else
                        MessageBox.Show("                      INVALID ENTRY " & vbCrLf & "PLEASE ENTER A POSSITIVE NUMBER 1 OR ABOVE", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

                    End If
                Loop

                Dim cmdupdate As New OleDbCommand("UPDATE Miscellaneous_TB SET [first_time_opening] = 0 WHERE [ID] = 1  ", con)
                cmdupdate.ExecuteNonQuery()
                cmdupdate.Dispose()
                con.Close()

                MessageBox.Show("SYSTEM CONFIGURED SUCCESFULLY YOU COULD RESTORE TO DEFAULT/FACTORY SETTINGS LATTER IN THE SETTINGS MENU. " & vbCrLf & " HIT OK TO CONTINUE", "LOGIN ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            End If

            Me.Hide()
                Form2.Show()
                txtUsername1.Clear()
                txtPassword1.Clear()
                con.Close()

            ElseIf txtUsername1.Text = "" And txtPassword1.Text <> "" Then
                MessageBox.Show("NO USERNAME ENTERED " & vbCrLf & "PLEASE ENTER YOUR USERNAME", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            ElseIf txtUsername1.Text <> "" And txtPassword1.Text = "" Then
                MessageBox.Show("NO PASSWORD ENTERED " & vbCrLf & "PLEASE ENTER YOUR PASSWORD", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            ElseIf txtUsername1.Text = "" And txtPassword1.Text = "" Then
                MessageBox.Show("NO USERNAME NOR PASSWORD ENTERED " & vbCrLf & "PLEASE ENTER YOUR USERNAME AND PASSWORD", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            ElseIf (dr_user.Read() = False And dr_pass.Read() = False) Then
                txtUsername1.Clear()
            txtPassword1.Clear()
            MessageBox.Show("WRONG USERNAME AND PASSWORD" & vbCrLf & "PLEASE CHECK AND TRY AGAIN", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        End If

        con.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'CLOSES FORM1 WHICH IS THE FIRST LOADUP FORM THEREFORE CLOSES THE ENTIRE PROGRAM
        con.Close()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'TAKES YOU TO 
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Login_1_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Login_1_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Login_1_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MORGUE_DATABASEDataSet)

    End Sub

    Private Sub txtUsername1_TextChanged(sender As Object, e As EventArgs) Handles txtUsername1.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
