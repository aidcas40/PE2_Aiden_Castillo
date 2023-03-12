<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ProdIdLabel As System.Windows.Forms.Label
        Dim ProdNameLabel As System.Windows.Forms.Label
        Dim ProdImgLabel As System.Windows.Forms.Label
        Dim ProdMfrLabel As System.Windows.Forms.Label
        Dim ProdCtgyLabel As System.Windows.Forms.Label
        Dim ProdPriceLabel As System.Windows.Forms.Label
        Dim ProdQtyLabel As System.Windows.Forms.Label
        Dim ProdRelDateLabel As System.Windows.Forms.Label
        Dim ProdRecDateLabel As System.Windows.Forms.Label
        Me.AllegroDatabaseDataSet = New Allegro.AllegroDatabaseDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New Allegro.AllegroDatabaseDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New Allegro.AllegroDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProdIdTextBox = New System.Windows.Forms.TextBox()
        Me.ProdNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProdImgPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProdMfrComboBox = New System.Windows.Forms.ComboBox()
        Me.ProdCtgyComboBox = New System.Windows.Forms.ComboBox()
        Me.ProdPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProdQtyNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ProdRelDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProdRecDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        ProdIdLabel = New System.Windows.Forms.Label()
        ProdNameLabel = New System.Windows.Forms.Label()
        ProdImgLabel = New System.Windows.Forms.Label()
        ProdMfrLabel = New System.Windows.Forms.Label()
        ProdCtgyLabel = New System.Windows.Forms.Label()
        ProdPriceLabel = New System.Windows.Forms.Label()
        ProdQtyLabel = New System.Windows.Forms.Label()
        ProdRelDateLabel = New System.Windows.Forms.Label()
        ProdRecDateLabel = New System.Windows.Forms.Label()
        CType(Me.AllegroDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        CType(Me.ProdImgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdQtyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AllegroDatabaseDataSet
        '
        Me.AllegroDatabaseDataSet.DataSetName = "AllegroDatabaseDataSet"
        Me.AllegroDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.AllegroDatabaseDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = Allegro.AllegroDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'ProductBindingNavigator
        '
        Me.ProductBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductBindingNavigator.BindingSource = Me.ProductBindingSource
        Me.ProductBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductBindingNavigatorSaveItem})
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductBindingNavigator.Name = "ProductBindingNavigator"
        Me.ProductBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ProductBindingNavigator.TabIndex = 0
        Me.ProductBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ProductBindingNavigatorSaveItem
        '
        Me.ProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductBindingNavigatorSaveItem.Name = "ProductBindingNavigatorSaveItem"
        Me.ProductBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProductBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProdIdLabel
        '
        ProdIdLabel.AutoSize = True
        ProdIdLabel.Location = New System.Drawing.Point(356, 161)
        ProdIdLabel.Name = "ProdIdLabel"
        ProdIdLabel.Size = New System.Drawing.Size(44, 13)
        ProdIdLabel.TabIndex = 1
        ProdIdLabel.Text = "Prod Id:"
        '
        'ProdIdTextBox
        '
        Me.ProdIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdId", True))
        Me.ProdIdTextBox.Location = New System.Drawing.Point(443, 158)
        Me.ProdIdTextBox.Name = "ProdIdTextBox"
        Me.ProdIdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProdIdTextBox.TabIndex = 2
        '
        'ProdNameLabel
        '
        ProdNameLabel.AutoSize = True
        ProdNameLabel.Location = New System.Drawing.Point(356, 187)
        ProdNameLabel.Name = "ProdNameLabel"
        ProdNameLabel.Size = New System.Drawing.Size(63, 13)
        ProdNameLabel.TabIndex = 3
        ProdNameLabel.Text = "Prod Name:"
        '
        'ProdNameTextBox
        '
        Me.ProdNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdName", True))
        Me.ProdNameTextBox.Location = New System.Drawing.Point(443, 184)
        Me.ProdNameTextBox.Name = "ProdNameTextBox"
        Me.ProdNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProdNameTextBox.TabIndex = 4
        '
        'ProdImgLabel
        '
        ProdImgLabel.AutoSize = True
        ProdImgLabel.Location = New System.Drawing.Point(356, 210)
        ProdImgLabel.Name = "ProdImgLabel"
        ProdImgLabel.Size = New System.Drawing.Size(52, 13)
        ProdImgLabel.TabIndex = 5
        ProdImgLabel.Text = "Prod Img:"
        '
        'ProdImgPictureBox
        '
        Me.ProdImgPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductBindingSource, "ProdImg", True))
        Me.ProdImgPictureBox.Location = New System.Drawing.Point(443, 210)
        Me.ProdImgPictureBox.Name = "ProdImgPictureBox"
        Me.ProdImgPictureBox.Size = New System.Drawing.Size(200, 50)
        Me.ProdImgPictureBox.TabIndex = 6
        Me.ProdImgPictureBox.TabStop = False
        '
        'ProdMfrLabel
        '
        ProdMfrLabel.AutoSize = True
        ProdMfrLabel.Location = New System.Drawing.Point(356, 269)
        ProdMfrLabel.Name = "ProdMfrLabel"
        ProdMfrLabel.Size = New System.Drawing.Size(50, 13)
        ProdMfrLabel.TabIndex = 7
        ProdMfrLabel.Text = "Prod Mfr:"
        '
        'ProdMfrComboBox
        '
        Me.ProdMfrComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdMfr", True))
        Me.ProdMfrComboBox.FormattingEnabled = True
        Me.ProdMfrComboBox.Location = New System.Drawing.Point(443, 266)
        Me.ProdMfrComboBox.Name = "ProdMfrComboBox"
        Me.ProdMfrComboBox.Size = New System.Drawing.Size(200, 21)
        Me.ProdMfrComboBox.TabIndex = 8
        '
        'ProdCtgyLabel
        '
        ProdCtgyLabel.AutoSize = True
        ProdCtgyLabel.Location = New System.Drawing.Point(356, 296)
        ProdCtgyLabel.Name = "ProdCtgyLabel"
        ProdCtgyLabel.Size = New System.Drawing.Size(56, 13)
        ProdCtgyLabel.TabIndex = 9
        ProdCtgyLabel.Text = "Prod Ctgy:"
        '
        'ProdCtgyComboBox
        '
        Me.ProdCtgyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdCtgy", True))
        Me.ProdCtgyComboBox.FormattingEnabled = True
        Me.ProdCtgyComboBox.Location = New System.Drawing.Point(443, 293)
        Me.ProdCtgyComboBox.Name = "ProdCtgyComboBox"
        Me.ProdCtgyComboBox.Size = New System.Drawing.Size(200, 21)
        Me.ProdCtgyComboBox.TabIndex = 10
        '
        'ProdPriceLabel
        '
        ProdPriceLabel.AutoSize = True
        ProdPriceLabel.Location = New System.Drawing.Point(356, 323)
        ProdPriceLabel.Name = "ProdPriceLabel"
        ProdPriceLabel.Size = New System.Drawing.Size(59, 13)
        ProdPriceLabel.TabIndex = 11
        ProdPriceLabel.Text = "Prod Price:"
        '
        'ProdPriceTextBox
        '
        Me.ProdPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdPrice", True))
        Me.ProdPriceTextBox.Location = New System.Drawing.Point(443, 320)
        Me.ProdPriceTextBox.Name = "ProdPriceTextBox"
        Me.ProdPriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProdPriceTextBox.TabIndex = 12
        '
        'ProdQtyLabel
        '
        ProdQtyLabel.AutoSize = True
        ProdQtyLabel.Location = New System.Drawing.Point(356, 346)
        ProdQtyLabel.Name = "ProdQtyLabel"
        ProdQtyLabel.Size = New System.Drawing.Size(51, 13)
        ProdQtyLabel.TabIndex = 13
        ProdQtyLabel.Text = "Prod Qty:"
        '
        'ProdQtyNumericUpDown
        '
        Me.ProdQtyNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdQty", True))
        Me.ProdQtyNumericUpDown.Location = New System.Drawing.Point(443, 346)
        Me.ProdQtyNumericUpDown.Name = "ProdQtyNumericUpDown"
        Me.ProdQtyNumericUpDown.Size = New System.Drawing.Size(200, 20)
        Me.ProdQtyNumericUpDown.TabIndex = 14
        '
        'ProdRelDateLabel
        '
        ProdRelDateLabel.AutoSize = True
        ProdRelDateLabel.Location = New System.Drawing.Point(356, 376)
        ProdRelDateLabel.Name = "ProdRelDateLabel"
        ProdRelDateLabel.Size = New System.Drawing.Size(77, 13)
        ProdRelDateLabel.TabIndex = 15
        ProdRelDateLabel.Text = "Prod Rel Date:"
        '
        'ProdRelDateDateTimePicker
        '
        Me.ProdRelDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdRelDate", True))
        Me.ProdRelDateDateTimePicker.Location = New System.Drawing.Point(443, 372)
        Me.ProdRelDateDateTimePicker.Name = "ProdRelDateDateTimePicker"
        Me.ProdRelDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ProdRelDateDateTimePicker.TabIndex = 16
        '
        'ProdRecDateLabel
        '
        ProdRecDateLabel.AutoSize = True
        ProdRecDateLabel.Location = New System.Drawing.Point(356, 402)
        ProdRecDateLabel.Name = "ProdRecDateLabel"
        ProdRecDateLabel.Size = New System.Drawing.Size(81, 13)
        ProdRecDateLabel.TabIndex = 17
        ProdRecDateLabel.Text = "Prod Rec Date:"
        '
        'ProdRecDateDateTimePicker
        '
        Me.ProdRecDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdRecDate", True))
        Me.ProdRecDateDateTimePicker.Location = New System.Drawing.Point(443, 398)
        Me.ProdRecDateDateTimePicker.Name = "ProdRecDateDateTimePicker"
        Me.ProdRecDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ProdRecDateDateTimePicker.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(ProdIdLabel)
        Me.Controls.Add(Me.ProdIdTextBox)
        Me.Controls.Add(ProdNameLabel)
        Me.Controls.Add(Me.ProdNameTextBox)
        Me.Controls.Add(ProdImgLabel)
        Me.Controls.Add(Me.ProdImgPictureBox)
        Me.Controls.Add(ProdMfrLabel)
        Me.Controls.Add(Me.ProdMfrComboBox)
        Me.Controls.Add(ProdCtgyLabel)
        Me.Controls.Add(Me.ProdCtgyComboBox)
        Me.Controls.Add(ProdPriceLabel)
        Me.Controls.Add(Me.ProdPriceTextBox)
        Me.Controls.Add(ProdQtyLabel)
        Me.Controls.Add(Me.ProdQtyNumericUpDown)
        Me.Controls.Add(ProdRelDateLabel)
        Me.Controls.Add(Me.ProdRelDateDateTimePicker)
        Me.Controls.Add(ProdRecDateLabel)
        Me.Controls.Add(Me.ProdRecDateDateTimePicker)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AllegroDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        CType(Me.ProdImgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdQtyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AllegroDatabaseDataSet As AllegroDatabaseDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As AllegroDatabaseDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As AllegroDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProdIdTextBox As TextBox
    Friend WithEvents ProdNameTextBox As TextBox
    Friend WithEvents ProdImgPictureBox As PictureBox
    Friend WithEvents ProdMfrComboBox As ComboBox
    Friend WithEvents ProdCtgyComboBox As ComboBox
    Friend WithEvents ProdPriceTextBox As TextBox
    Friend WithEvents ProdQtyNumericUpDown As NumericUpDown
    Friend WithEvents ProdRelDateDateTimePicker As DateTimePicker
    Friend WithEvents ProdRecDateDateTimePicker As DateTimePicker
End Class
