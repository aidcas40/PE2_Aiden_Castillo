Imports System.Drawing.Print
Public Class frmProduct
    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles btnSave.Click, btnDelete.Click, btnAdd.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AllegroDatabaseDataSet)

    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllegroDatabaseDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.AllegroDatabaseDataSet.User)
        'TODO: This line of code loads data into the 'AllegroDatabaseDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.AllegroDatabaseDataSet.Product)

        pnlUser.Visible = False
        pnlProducts.Visible = True

        dgvProduct.Columns(0).HeaderText = "Product ID"
        dgvProduct.Columns(1).HeaderText = "Name"
        dgvProduct.Columns(2).HeaderText = "Product Image"
        dgvProduct.Columns(3).HeaderText = "Manufacturer"
        dgvProduct.Columns(4).HeaderText = "Category"
        dgvProduct.Columns(5).HeaderText = "Price"
        dgvProduct.Columns(6).HeaderText = "Quantity"
        dgvProduct.Columns(7).HeaderText = "Date Released"
        dgvProduct.Columns(8).HeaderText = "Date Received"

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
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlUser.Visible = False
        pnlProducts.Visible = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Application.Exit()
    End Sub
End Class