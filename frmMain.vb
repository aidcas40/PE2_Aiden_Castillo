Imports System.Drawing.Print
Imports System.IO
Public Class frmProduct

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllegroDatabaseDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.AllegroDatabaseDataSet.User)
        'TODO: This line of code loads data into the 'AllegroDatabaseDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.AllegroDatabaseDataSet.Product)

        pnlUser.Visible = False
        pnlProducts.Visible = True
        pnlDeveloper.Visible = False

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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintPreviewDialog.Document = PrintDocument
        PrintPreviewDialog.ShowDialog()
        PrintDocument.Print()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim imagebmp As New Bitmap(Me.dgvProduct.Width, Me.dgvProduct.Height)
        dgvProduct.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.dgvProduct.Width, Me.dgvProduct.Height))
        e.Graphics.DrawImage(imagebmp, 0, 0)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        pnlUser.Visible = True
        pnlProducts.Visible = False
        pnlDeveloper.Visible = False
    End Sub

    Private Sub AboutDeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutDeveloperToolStripMenuItem.Click
        pnlUser.Visible = False
        pnlProducts.Visible = False
        pnlDeveloper.Visible = True
    End Sub
    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Dim maxLen As Integer = 50 'Maximum length of ProdCtgy column
        Dim selectedValue As String = txtProdCtgy.Text
        Dim selectedValue2 As String = txtProdMfr.Text
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
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlUser.Visible = False
        pnlProducts.Visible = True
        pnlDeveloper.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Application.Exit()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        BindingNavigatorDeleteItem.PerformClick()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ProductBindingNavigatorSaveItem.PerformClick()
    End Sub

    Private Sub btnBackP_Click(sender As Object, e As EventArgs) Handles btnBackP.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    Private Sub btnNextP_Click(sender As Object, e As EventArgs) Handles btnNextP.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

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
            If TypeOf control Is PictureBox Then
                Dim prodImg As PictureBox = CType(control, PictureBox)
                prodImg.Image = Nothing
            End If
            If TypeOf control Is DateTimePicker Then
                control.Text = Date.Now
            End If
        Next
    End Sub
End Class