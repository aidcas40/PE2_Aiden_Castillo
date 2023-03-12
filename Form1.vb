Public Class Form1
    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AllegroDatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllegroDatabaseDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.AllegroDatabaseDataSet.Product)

    End Sub
End Class