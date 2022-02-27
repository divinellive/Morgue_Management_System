Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Data
Imports System.IO
Imports System.Data.OleDb
Imports System.Data.DataTable

Public Class Class_Main
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DATABASE_FOLDER\MORGUE_DATABASE.mdb")
    Private Shared dashtochangepass As Integer = 0
    Private Shared verifyBed As Integer = 0
    Private Shared verifychange As Integer = 0
    Private Shared dashtoblue As Integer = 0
    Private Shared purpletoblue As Integer = 0
    Private Shared searchtoblue As Integer = 0
    ' For verifying change, 0 means uv not moved from , 1 means uv moved from


    'get/set properties to access class variables
    Public Shared Property dash_to_change_pass() As Integer
        Get
            Return dashtochangepass
        End Get
        Set(ByVal value As Integer)
            dashtochangepass = value
        End Set
    End Property

    Public Shared Property verify_Bed() As Integer
        Get
            Return verifyBed
        End Get
        Set(ByVal value As Integer)
            verifyBed = value
        End Set
    End Property

    Public Shared Property dash_to_blue() As Integer
        Get
            Return dashtoblue
        End Get
        Set(ByVal value As Integer)
            dashtoblue = value
        End Set
    End Property

    Public Shared Property purple_to_blue() As Integer
        Get
            Return purpletoblue
        End Get
        Set(ByVal value As Integer)
            purpletoblue = value
        End Set
    End Property

    Public Shared Property verify_change() As Integer
        Get
            Return verifychange
        End Get
        Set(ByVal value As Integer)
            verifychange = value
        End Set
    End Property

    Public Shared Property search_to_blue() As Integer
        Get
            Return searchtoblue
        End Get
        Set(ByVal value As Integer)
            searchtoblue = value
        End Set
    End Property




    'first login page function
    Public Function login1(ByVal username As String, ByVal password As String) As String
        con.Open()
        Dim cmd_user As New OleDbCommand("SELECT * FROM Login_1_TB WHERE Username = '" & username & "'", con)
        Dim cmd_pass As New OleDbCommand("SELECT * FROM Login_1_TB WHERE Password = '" & password & "'", con)
        Dim dr_user As OleDbDataReader = cmd_user.ExecuteReader
        Dim dr_pass As OleDbDataReader = cmd_pass.ExecuteReader
        Dim outcome As String = Nothing

        If (dr_user.Read() = True And dr_pass.Read() = True) Then

            outcome = "castlevaniasdxhgbuhyftyrsrerfgteinsteinsingcxgchjbmhgnbgfjsaertt"
            con.Close()

        ElseIf username = "" And password <> "" Then
            MessageBox.Show("NO USERNAME ENTERED " & vbCrLf & "PLEASE ENTER YOUR USERNAME", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            outcome = "hchgbkjhkjbhcgfgfchjhlkjhvfxghbn,mnb vdtuytrdtfyguvhjhhihjbhcfghcx"
        ElseIf username <> "" And password = "" Then
            MessageBox.Show("NO PASSWORD ENTERED " & vbCrLf & "PLEASE ENTER YOUR PASSWORD", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            outcome = "hchgbkjhkjbhcgfgfchjhlkjhvfxghbn,mnb vdtuytrdtfyguvhjhhihjbhcfghcx"
        ElseIf username = "" And password = "" Then
            MessageBox.Show("NO USERNAME NOR PASSWORD ENTERED " & vbCrLf & "PLEASE ENTER YOUR USERNAME AND PASSWORD", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            outcome = "hchgbkjhkjbhcgfgfchjhlkjhvfxghbn,mnb vdtuytrdtfyguvhjhhihjbhcfghcx"
        ElseIf (dr_user.Read() = False And dr_pass.Read() = False) Then
            MessageBox.Show("WRONG USERNAME AND PASSWORD" & vbCrLf & "PLEASE CHECK AND TRY AGAIN", "LOGIN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            outcome = "hchgbkjhkjbhcgfgfchjhlkjhvfxghbn,mnb vdtuytrdtfyguvhjhhihjbhcfghcx"
        End If

        con.Close()

        Return outcome
    End Function




End Class
