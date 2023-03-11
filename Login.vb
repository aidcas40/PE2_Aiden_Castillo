Imports System.Data
Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AllegroDatabase.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from [User] where UserName='" + txtUserName.Text + "' and UserPwd='" + txtUserPwd.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            frmProduct.Show()

        ElseIf txtUserName.Text = "" And txtUserPwd.Text = "" Then

            MessageBox.Show("Username and Password cannot be blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf txtUserName.Text = "" Then

            MessageBox.Show("Username cannot be blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf txtUserPwd.Text = "" Then

            MessageBox.Show("Password cannot be blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Incorrect input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class
