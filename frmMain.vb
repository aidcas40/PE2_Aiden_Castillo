Imports System.Drawing.Print
Public Class frmProduct
    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AllegroDatabaseDataSet)

    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllegroDatabaseDataSet.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.AllegroDatabaseDataSet.User)
        'TODO: This line of code loads data into the 'AllegroDatabaseDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.AllegroDatabaseDataSet.Product)

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
End Class