'----------------------------------------------------------------------------------
'Program Title: 		Allegro
'Program Author: 		Aiden Castillo & Luis Garcia
'Date Created:  		11 March, 2023
'School:			    Corozal Junior College
'Course Number/Name:	CS206 - Programming II
'Program Description:	This program demonstrates various database entry functionalities and controls using MS SQL.
'----------------------------------------------------------------------------------
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLogin
    'Login Button
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Defining variables in order to connect to the database to validate user login
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AllegroDatabase.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from [User] where UserName='" + txtUserName.Text + "' and UserPwd='" + txtUserPwd.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        'If statements that output a message box depending on the given scenarios for the username and password input 
        If (dt.Rows.Count > 0) Then
            'Message box notifies you of a successful login when both username and password inputted correctly
            MessageBox.Show("Login success.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            frmProduct.Show()

        ElseIf txtUserName.Text = "" And txtUserPwd.Text = "" Then
            'If username and password is blank then message notifies you
            MessageBox.Show("Username and Password cannot be blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf txtUserName.Text = "" Then
            'If only username is blank then message notifies you
            MessageBox.Show("Username cannot be blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf txtUserPwd.Text = "" Then
            ''If only password is blank then message notifies you
            MessageBox.Show("Password cannot be blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            'If username and/or password is inputted incorrectly the message box notifies you
            MessageBox.Show("Incorrect input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    'Exit button for Login form
    Private Sub btnLogExit_Click(sender As Object, e As EventArgs) Handles btnLogExit.Click
        Dim msgLogExit = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgLogExit = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub
End Class
