Imports System.Data
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class Form3
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DATABASE_FOLDER\MORGUE_DATABASE.mdb")
    Dim ID As Integer = 1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'IF STATEMENT TO VERIFY WHERE YOUR FROM   --WHEATHER LOGIN OR FORM2
        If Class_Main.dash_to_change_pass = 1 Then
            Class_Main.dash_to_change_pass = 0
            Me.Close()
            Form2.Show()
        Else
            Me.Close()
            Form1.Show()
        End If

    End Sub

    Private Sub Login_1_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Login_1_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MORGUE_DATABASEDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MORGUE_DATABASEDataSet.Login_1_TB' table. You can move, or remove it, as needed.
        Me.Login_1_TBTableAdapter.Fill(Me.MORGUE_DATABASEDataSet.Login_1_TB)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub btnLogin1_Click(sender As Object, e As EventArgs) Handles btnLogin1.Click

        conn.Open()
        Dim cmd_user As New OleDbCommand("SELECT * FROM Login_1_TB WHERE Username = '" & txtCurrentName.Text & "'", conn)
        Dim cmd_pass As New OleDbCommand("SELECT * FROM Login_1_TB WHERE Password = '" & txtCurrentPassword.Text & "'", conn)
        Dim dr_user As OleDbDataReader = cmd_user.ExecuteReader
        Dim dr_pass As OleDbDataReader = cmd_pass.ExecuteReader
        Dim cmdupdate As New OleDbCommand("UPDATE Login_1_TB SET [Username] = '" & txtNewUser.Text & "',[Password] = '" & txtNewPassword.Text & "' WHERE [ID] = " & ID & " ", conn)

        If (dr_user.Read() = True And dr_pass.Read() = True) Then

            If txtNewPassword.Text = txtVerifyPassword.Text Then

                Try

                    cmdupdate.ExecuteNonQuery()
                    cmdupdate.Dispose()

                    txtCurrentName.BackColor = Color.Black
                    txtCurrentPassword.BackColor = Color.Black

                    txtCurrentName.Clear()
                    txtCurrentPassword.Clear()
                    txtNewUser.Clear()
                    txtNewPassword.Clear()
                    txtVerifyPassword.Clear()

                    lblNewPassword.Text = "WRONG PASSWORD"
                    lblNewPassword.ForeColor = Color.Red
                    lblNewPassword.Visible = False
                    lblVerifyNewPassword.Text = "WRONG PASSWORD"
                    lblVerifyNewPassword.ForeColor = Color.Red
                    lblVerifyNewPassword.Visible = False

                    pbThumb.Visible = True
                    MessageBox.Show("USERNAME AND PASSWORD CHANGED SUCCESSFULLY!!!!", "UPDATE STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Catch ex As Exception
                    MsgBox("ERRORRR!!!! PROBABLY GENERATED WHILE CONECTING" & vbCrLf & " TO THE DATABASE OR ERROR IN QUERY PARAMETERS " & vbCrLf & "checking to place database at it " & vbCrLf & "right location migth fix this error")
                    Me.Close()
                End Try


            Else
                txtCurrentName.BackColor = Color.Black
                txtCurrentPassword.BackColor = Color.Black

                txtCurrentName.Clear()
                txtCurrentPassword.Clear()
                txtNewUser.Clear()
                txtNewPassword.Clear()
                txtVerifyPassword.Clear()

                lblNewPassword.Text = "WRONG PASSWORD"
                lblNewPassword.ForeColor = Color.Red
                lblNewPassword.Visible = True
                lblVerifyNewPassword.Text = "WRONG PASSWORD"
                lblVerifyNewPassword.ForeColor = Color.Red
                lblVerifyNewPassword.Visible = True

                pbThumb.Visible = False
                MessageBox.Show("YOUR NEW PASSWORDS MISMATCHED" & vbCrLf & "Please Check And Try Again", "Login Change Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

            End If



        ElseIf txtCurrentName.Text = "" And txtCurrentPassword.Text <> "" Then
            txtCurrentName.BackColor = Color.Black
            txtCurrentPassword.BackColor = Color.Black

            txtCurrentName.Clear()
            txtCurrentPassword.Clear()
            txtNewUser.Clear()
            txtNewPassword.Clear()
            txtVerifyPassword.Clear()

            lblNewPassword.Text = "WRONG PASSWORD"
            lblNewPassword.ForeColor = Color.Red
            lblNewPassword.Visible = False
            lblVerifyNewPassword.Text = "WRONG PASSWORD"
            lblVerifyNewPassword.ForeColor = Color.Red
            lblVerifyNewPassword.Visible = False

            pbThumb.Visible = False
            MessageBox.Show("NO USERNAME ENTERED " & vbCrLf & "PLEASE ENTER YOUR USERNAME", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf txtCurrentName.Text <> "" And txtCurrentPassword.Text = "" Then
            txtCurrentName.Clear()
            txtCurrentPassword.Clear()
            txtNewUser.Clear()
            txtNewPassword.Clear()
            txtVerifyPassword.Clear()
            MessageBox.Show("NO PASSWORD ENTERED " & vbCrLf & "PLEASE ENTER YOUR PASSWORD", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf txtCurrentName.Text = "" And txtCurrentPassword.Text = "" Then
            txtCurrentName.Clear()
            txtCurrentPassword.Clear()
            txtNewUser.Clear()
            txtNewPassword.Clear()
            txtVerifyPassword.Clear()
            MessageBox.Show("NO USERNAME NOR PASSWORD ENTERED " & vbCrLf & "PLEASE ENTER YOUR USERNAME AND PASSWORD", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            txtCurrentName.BackColor = Color.Red
            txtCurrentPassword.BackColor = Color.Red

            txtCurrentName.Clear()
            txtCurrentPassword.Clear()
            txtNewUser.Clear()
            txtNewPassword.Clear()
            txtVerifyPassword.Clear()

            lblNewPassword.Text = "WRONG PASSWORD"
            lblNewPassword.ForeColor = Color.Red
            lblNewPassword.Visible = False
            lblVerifyNewPassword.Text = "WRONG PASSWORD"
            lblVerifyNewPassword.ForeColor = Color.Red
            lblVerifyNewPassword.Visible = False

            pbThumb.Visible = False
            MessageBox.Show("YOUR PREVIOUS LOGIN CREDENTIALS ARE WRONG" & vbCrLf & "Please Check And Try Again", "Login Change Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

        End If

        conn.Close()


    End Sub


End Class