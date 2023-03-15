'Imports System.Drawing.Print
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmProduct
    'Main Product form
    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllegroDatabaseDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.AllegroDatabaseDataSet.User)
        'TODO: This line of code loads data into the 'AllegroDatabaseDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.AllegroDatabaseDataSet.Product)

        'Makes only Product panel visible when forms load
        pnlUser.Visible = False
        pnlProducts.Visible = True
        pnlDeveloper.Visible = False
        pnlProgram.Visible = False

        'Changing text in header columns
        dgvProduct.Columns(0).HeaderText = "Product ID"
        dgvProduct.Columns(1).HeaderText = "Name"
        dgvProduct.Columns(2).HeaderText = "Manufacturer"
        dgvProduct.Columns(3).HeaderText = "Category"
        dgvProduct.Columns(4).HeaderText = "Price"
        dgvProduct.Columns(5).HeaderText = "Quantity"
        dgvProduct.Columns(6).HeaderText = "Date Released"
        dgvProduct.Columns(7).HeaderText = "Date Received"
        dgvProduct.Columns(8).HeaderText = "Description"

        'Changing text in header columns
        dgvUser.Columns(0).HeaderText = "User ID"
        dgvUser.Columns(1).HeaderText = "Username"
        dgvUser.Columns(2).HeaderText = "Password"
    End Sub

    'Exit button in menu strip. Message box to confirm leaving Main form
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim msgExit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgExit = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmLogin.Show()
        Else
            Exit Sub
        End If
    End Sub

    'Prints menu strip dialog setup
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintPreviewDialog.Document = PrintDocument
        PrintPreviewDialog.ShowDialog()
        PrintDocument.Print()
    End Sub

    'Prints Data Grid View for Products table
    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim imagebmp As New Bitmap(Me.dgvProduct.Width, Me.dgvProduct.Height)
        dgvProduct.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.dgvProduct.Width, Me.dgvProduct.Height))
        e.Graphics.DrawImage(imagebmp, 0, 0)
    End Sub

    'Makes only User panel visible when clicked
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        pnlUser.Visible = True
        pnlProducts.Visible = False
        pnlDeveloper.Visible = False
        pnlProgram.Visible = False
    End Sub

    'Maes only Products Management panel visible when clicked. Found in Menu Strip.
    Private Sub OpenProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProductToolStripMenuItem.Click
        pnlUser.Visible = False
        pnlProducts.Visible = True
        pnlDeveloper.Visible = False
        pnlProgram.Visible = False
    End Sub

    ''Makes only Developer panel visible when clicked
    Private Sub AboutDeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutDeveloperToolStripMenuItem.Click
        pnlUser.Visible = False
        pnlProducts.Visible = False
        pnlDeveloper.Visible = True
        pnlProgram.Visible = False
    End Sub

    ''Makes only Program panel visible when clicked
    Private Sub AboutProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutProgramToolStripMenuItem.Click
        pnlUser.Visible = False
        pnlProducts.Visible = False
        pnlDeveloper.Visible = False
        pnlProgram.Visible = True
    End Sub

    'Takes you back to Products panel and makes only Products panel visible when clicked
    Private Sub btnfpProducts_Click(sender As Object, e As EventArgs) Handles btnfpProducts.Click
        pnlUser.Visible = False
        pnlProducts.Visible = True
        pnlDeveloper.Visible = False
        pnlProgram.Visible = False
    End Sub

    'Takes you back to Products panel and makes only Products panel visible when clicked
    Private Sub btnadProducts_Click(sender As Object, e As EventArgs) Handles btnadProducts.Click
        pnlUser.Visible = False
        pnlProducts.Visible = True
        pnlDeveloper.Visible = False
        pnlProgram.Visible = False
    End Sub

    'Takes you back to Products panel and makes only Products panel visible when clicked
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlUser.Visible = False
        pnlProducts.Visible = True
        pnlDeveloper.Visible = False
        pnlProgram.Visible = False
    End Sub

    'Replaces the displayed data on the datagridview user password column with *
    Private Sub dgvUser_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUser.CellFormatting
        If e.ColumnIndex = 2 Then
            If e.Value IsNot Nothing Then
                e.Value = New String("*", e.Value.ToString().Length)
            End If
        End If
    End Sub

    'Saves new items to the Products table
    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Dim maxLen As Integer = 50 'Maximum length of ProdCtgy column
        Dim selectedValue As String = cbxProdCtgy.SelectedItem.ToString()
        Dim selectedValue2 As String = cbxProdMfr.SelectedItem.ToString()
        Dim truncatedValue As String = selectedValue.Substring(0, Math.Min(selectedValue.Length, maxLen))
        Dim truncatedValue2 As String = selectedValue2.Substring(0, Math.Min(selectedValue2.Length, maxLen))

        'Now set the truncated value for the ProdCtgy column
        Dim dr As DataRow = AllegroDatabaseDataSet.Tables("Product").NewRow()
        dr("ProdCtgy") = truncatedValue
        dr("ProdMfr") = truncatedValue2
        ' Set other column values...
        'AllegroDatabaseDataSet.Tables("Product").Rows.Add(dr)

        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AllegroDatabaseDataSet)

    End Sub

    'Adds new item to the Product Table
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    'Deletes an item from the Product Table
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Messae Box to confirm deletion of an item from the database
        Dim msgDelete = MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgDelete = Windows.Forms.DialogResult.Yes Then
            BindingNavigatorDeleteItem.PerformClick()
        Else
            Exit Sub
        End If
    End Sub

    'Saves an item to the Product Table. If any fields are empty then a message box warns to field all required fields
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtProdName.Text) OrElse String.IsNullOrEmpty(txtProdPrice.Text) OrElse String.IsNullOrEmpty(cbxProdCtgy.Text) OrElse String.IsNullOrEmpty(cbxProdMfr.Text) OrElse
            String.IsNullOrEmpty(nudProdQty.Text) OrElse dtpProdRelDate.Value = Nothing OrElse dtpProdRecDate.Value = Nothing OrElse String.IsNullOrEmpty(txtProdDesc.Text) Then
            MessageBox.Show("Please enter a value in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ProductBindingNavigatorSaveItem.PerformClick()
        End If
    End Sub

    'Goes to the previous item within the Product Table
    Private Sub btnBackP_Click(sender As Object, e As EventArgs) Handles btnBackP.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    'Goes to the next item with the Product Table
    Private Sub btnNextP_Click(sender As Object, e As EventArgs) Handles btnNextP.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    'Creating search function for Product datagridview table. Connects to the database to accomplish this
    Private Function search1() As DataTable
        Dim query1 As String = "SELECT * From Product"
        query1 &= " Where ProdName Like '%' +@parm1+ '%' "
        query1 &= " or ProdMfr Like '%' +@parm1+ '%' "
        query1 &= " or ProdCtgy Like '%' +@parm1+ '%' Order by ProdId"
        Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AllegroDatabase.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand(query1, conn)
        cmd.Parameters.AddWithValue("parm1", txtSearch.Text.Trim)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvProduct.DataSource = dt
        Return dt
    End Function

    'Using search1() on a textbox. Search is active when the text in the textbox is changed/typed
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search1()
    End Sub

    'Closes the entire application. Message box ask for confirmation to close application
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim msgClose = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgClose = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    'For loop that clears the various inputs for Products
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        For Each control As Control In pnlProducts.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
            If TypeOf control Is ComboBox Then
                control.Text = ""
            End If
            If TypeOf control Is NumericUpDown Then
                control.Text = ""
            End If
            If TypeOf control Is DateTimePicker Then
                control.Text = Date.Now
            End If
        Next
    End Sub

    'Displays text for Program panel when it loads
    Private Sub pnlProgram_Paint(sender As Object, e As PaintEventArgs) Handles pnlProgram.Paint
        lblDescr.Text = "Allegro  is a database management system designed to help music gear distributors 
manage their inventory of musical instruments and equipment, including synthesizers, 
pedals, electric guitars, and other related items. The program allows you to maintain 
detailed information about each item in your inventory, such as the product name, price, 
quantity category, manufacturer, year of production, and any additional relevant information"
    End Sub

    'Takes you to Aiden Castillo's CS210 website when you click the label 
    Private Sub lblWebsite_Click(sender As Object, e As EventArgs) Handles lblWebsite.Click
        Dim website As String
        website = "http://aidcascs210.byethost15.com/"
        Process.Start(website)
    End Sub

    'Takes you to Luis Garcia's CS210 Website when you clic the label
    Private Sub lblWebsiteDev2_Click(sender As Object, e As EventArgs) Handles lblWebsiteDev2.Click
        Dim websiteDev2 As String
        websiteDev2 = "http://luigar59.byethost10.com/"
        Process.Start(websiteDev2)
    End Sub

    'Displays text for Developer panel when it loads
    Private Sub pnlDeveloper_Paint(sender As Object, e As PaintEventArgs) Handles pnlDeveloper.Paint
        lblAboutMe.Text = "Hello there, we're the developers of this program. We're officially apart of LAAG, which 
is a company that focuses on the development of Windows Desktop Applications. We try our 
best in creating a user-friendly interface that enables users to easily input and access information."
    End Sub

    'Displays text for User Viewer panel when it loads
    Private Sub pnlUser_Paint(sender As Object, e As PaintEventArgs) Handles pnlUser.Paint
        lblUserViewerDesc.Text = " View information about users in system."
    End Sub

End Class