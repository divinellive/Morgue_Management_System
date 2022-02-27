Imports System.Data
Imports System.Data.OleDb
Imports System.Data.DataTable
Public Class Form2
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DATABASE_FOLDER\MORGUE_DATABASE.mdb")
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MORGUE_DATABASEDataSet.Person_Deceased_TB' table. You can move, or remove it, as needed.
        Label2.Hide()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Class_Main.dash_to_change_pass = 1

        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form1.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Class_Main.dash_to_blue = 1
        Class_Main.purple_to_blue = 0
        Me.Hide()
        Form7.Show()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Button2.Show()
        Button6.Show()
        Button9.Show()
        Button4.Show()
        Button1.Show()
        Label2.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Class_Main.dash_to_blue = 1
        Class_Main.purple_to_blue = 0
        Form7.form2searchinput = TextBox1.Text
        Class_Main.search_to_blue = 1
        Me.Hide()
        Form7.Close()
        Form7.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button2.Hide()
        Button6.Hide()
        Button9.Hide()
        Button4.Hide()
        Button1.Hide()
        Label2.Text = "This project was inspired by DR. Lempogo forgor of Ghana Technology University college. Its main intention is to digitalize the morgue management in Ghana which would inturn reduce embezzlement of resources and promote transparency. credit to Watson Elor oghenerobo and ephraim. Divine Letsu"
        Label2.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Dim msgdialogresult As New DialogResult


        msgdialogresult = MessageBox.Show("                                       ATTENTION!!!! " & vbCrLf & "YOU ARE ABOUT TO WIPE THE ENTIRE SOFTWARE BACK TO ITS DEFAULT STATE. ALL DATA WOULD BE LOST. LOGIN CREDENTIALS WOULD BE CHANGED BACK TO THIER FACTORY VALUES. NUMBER OF CHAMBERS AVAILABLE FOR THE DECEASED WOULD HAVE TO BE SET UPORN THE NEXT SYSTEM LOGIN.YOU WOULD BE LOGGED OUT OF THE CURRENT SESSION. TO CONTINUE, ENTER Administration credential and hit enter", "FACTORY RESTORE!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

        If msgdialogresult = System.Windows.Forms.DialogResult.Yes Then

            Dim result As String
        Dim main As New Class_Main

        Dim user As String
        Dim pass As String
        con.Open()

        user = InputBox("ENTER ADMIN USERNAME ", "ADMIN AUTHENTICATION", "")
        pass = InputBox("ENTER ADMIN PASSWORD ", "ADMIN AUTHENTICATION", "")
        result = main.login1(user, pass)
            If result = "castlevaniasdxhgbuhyftyrsrerfgteinsteinsingcxgchjbmhgnbgfjsaertt" Then


                'RESSETING OF MISCELLANEOUS BED CONFIGURATION TABLE
                Dim cmdupdate As New OleDbCommand("UPDATE Miscellaneous_TB SET [first_time_opening] = 1 WHERE [ID] = 1  ", con)
                'RESETTING OF LOGIN
                Dim cmdupdate1 As New OleDbCommand("UPDATE Login_1_TB SET [Username] = 'Admin' ,[Password] = '1234' WHERE [ID] = 1 ", con)

                cmdupdate.ExecuteNonQuery()
                cmdupdate1.ExecuteNonQuery()
                cmdupdate.Dispose()
                cmdupdate1.Dispose()
                con.Close()
                'DELETION OF BILLS TABLE
                con.Open()
                Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM Bills_TB ", con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()

                'RESETTING OF CHAMBER BED NUMBER
                con.Open()
                Dim cmd1 As OleDbCommand = New OleDbCommand("DELETE FROM Chamber_TB ", con)
                cmd1.ExecuteNonQuery()
                cmd1.Dispose()
                con.Close()

                'RESETTING OF PERSON
                con.Open()
                Dim cmd2 As OleDbCommand = New OleDbCommand("DELETE FROM Person_Deceased_TB ", con)
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()
                con.Close()

                'RESETTING OF STAFF TABLE
                con.Open()
                Dim cmd3 As OleDbCommand = New OleDbCommand("DELETE FROM Staff_TB ", con)
                cmd3.ExecuteNonQuery()
                cmd3.Dispose()
                con.Close()


                MessageBox.Show("SYSTEM HAS BEEN RESTORED TO ITS DEFAULTS SETTINGS. REFER TO SYSTEM MANUAL FOR LOGIN USERNAME AND PASSWORD. THE NUMBER OF CHAMBERS TO USE WOULD ALSO BE CONFIGURED UPORN THE NEXT SYSTEM LOGIN ", "LOGIN ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.Close()
                Form1.Show()
            Else

            End If
        Else

        End If

        con.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form8.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form9.Show()
    End Sub
End Class