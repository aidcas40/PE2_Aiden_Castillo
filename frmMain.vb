Imports System.Drawing.Print
Imports System.IO
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

    End Sub

    'Exit button in menu strip. Message box to confirm leaving Main form
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Me.Close()
        frmLogin.Show()
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
        BindingNavigatorDeleteItem.PerformClick()
    End Sub

    'Saves an item to the Product Table
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ProductBindingNavigatorSaveItem.PerformClick()
    End Sub

    'Goes to the previous item within the Product Table
    Private Sub btnBackP_Click(sender As Object, e As EventArgs) Handles btnBackP.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    'Goes to the next item with the Product Table
    Private Sub btnNextP_Click(sender As Object, e As EventArgs) Handles btnNextP.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    'Closes the entire application
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Application.Exit()
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

    'Takes you to my CS210 website when you click the label 
    Private Sub lblWebsite_Click(sender As Object, e As EventArgs) Handles lblWebsite.Click
        Dim website As String
        website = "http://aidcascs210.byethost15.com/"
        Process.Start(website)
    End Sub

    'Displays text for Developer panel when it loads
    Private Sub pnlDeveloper_Paint(sender As Object, e As PaintEventArgs) Handles pnlDeveloper.Paint
        lblAboutMe.Text = "Hello there, I'm the developer of this program. I'm officially apart of the LAAG, which 
focuses on the development of Windows Desktop Applications. We try our best in creating a 
user-friendly interface that enables users to easily input and access information."
    End Sub
End Class