<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblProdId As System.Windows.Forms.Label
        Dim lblProdName As System.Windows.Forms.Label
        Dim lblProdMfr As System.Windows.Forms.Label
        Dim lblProdCtgy As System.Windows.Forms.Label
        Dim lblProdPrice As System.Windows.Forms.Label
        Dim lblProdQty As System.Windows.Forms.Label
        Dim lblProdRelDate As System.Windows.Forms.Label
        Dim lblProdRecDate As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlProducts = New System.Windows.Forms.Panel()
        Me.ProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllegroDatabaseDataSet = New Allegro.AllegroDatabaseDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnNextP = New System.Windows.Forms.Button()
        Me.btnBackP = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblProdMan = New System.Windows.Forms.Label()
        Me.txtProdId = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.cbxProdMfr = New System.Windows.Forms.ComboBox()
        Me.cbxProdCtgy = New System.Windows.Forms.ComboBox()
        Me.txtProdPrice = New System.Windows.Forms.TextBox()
        Me.nudProdQty = New System.Windows.Forms.NumericUpDown()
        Me.dtpProdRelDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpProdRecDate = New System.Windows.Forms.DateTimePicker()
        Me.ProductTableAdapter = New Allegro.AllegroDatabaseDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New Allegro.AllegroDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.UserTableAdapter = New Allegro.AllegroDatabaseDataSetTableAdapters.UserTableAdapter()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserViewer = New System.Windows.Forms.Label()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlDeveloper = New System.Windows.Forms.Panel()
        Me.pctDeveloper = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        lblProdId = New System.Windows.Forms.Label()
        lblProdName = New System.Windows.Forms.Label()
        lblProdMfr = New System.Windows.Forms.Label()
        lblProdCtgy = New System.Windows.Forms.Label()
        lblProdPrice = New System.Windows.Forms.Label()
        lblProdQty = New System.Windows.Forms.Label()
        lblProdRelDate = New System.Windows.Forms.Label()
        lblProdRecDate = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.pnlProducts.SuspendLayout()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllegroDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.nudProdQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUser.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDeveloper.SuspendLayout()
        CType(Me.pctDeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProdId
        '
        lblProdId.AutoSize = True
        lblProdId.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdId.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdId.Location = New System.Drawing.Point(32, 70)
        lblProdId.Name = "lblProdId"
        lblProdId.Size = New System.Drawing.Size(77, 16)
        lblProdId.TabIndex = 1
        lblProdId.Text = "Product ID:"
        '
        'lblProdName
        '
        lblProdName.AutoSize = True
        lblProdName.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdName.Location = New System.Drawing.Point(32, 100)
        lblProdName.Name = "lblProdName"
        lblProdName.Size = New System.Drawing.Size(48, 16)
        lblProdName.TabIndex = 3
        lblProdName.Text = "Name:"
        '
        'lblProdMfr
        '
        lblProdMfr.AutoSize = True
        lblProdMfr.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdMfr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdMfr.Location = New System.Drawing.Point(32, 192)
        lblProdMfr.Name = "lblProdMfr"
        lblProdMfr.Size = New System.Drawing.Size(97, 16)
        lblProdMfr.TabIndex = 7
        lblProdMfr.Text = "Manufacturer:"
        '
        'lblProdCtgy
        '
        lblProdCtgy.AutoSize = True
        lblProdCtgy.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdCtgy.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdCtgy.Location = New System.Drawing.Point(32, 161)
        lblProdCtgy.Name = "lblProdCtgy"
        lblProdCtgy.Size = New System.Drawing.Size(69, 16)
        lblProdCtgy.TabIndex = 9
        lblProdCtgy.Text = "Category:"
        '
        'lblProdPrice
        '
        lblProdPrice.AutoSize = True
        lblProdPrice.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdPrice.Location = New System.Drawing.Point(32, 130)
        lblProdPrice.Name = "lblProdPrice"
        lblProdPrice.Size = New System.Drawing.Size(43, 16)
        lblProdPrice.TabIndex = 11
        lblProdPrice.Text = "Price:"
        '
        'lblProdQty
        '
        lblProdQty.AutoSize = True
        lblProdQty.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdQty.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdQty.Location = New System.Drawing.Point(376, 70)
        lblProdQty.Name = "lblProdQty"
        lblProdQty.Size = New System.Drawing.Size(65, 16)
        lblProdQty.TabIndex = 13
        lblProdQty.Text = "Quantity:"
        '
        'lblProdRelDate
        '
        lblProdRelDate.AutoSize = True
        lblProdRelDate.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdRelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdRelDate.Location = New System.Drawing.Point(376, 100)
        lblProdRelDate.Name = "lblProdRelDate"
        lblProdRelDate.Size = New System.Drawing.Size(102, 16)
        lblProdRelDate.TabIndex = 15
        lblProdRelDate.Text = "Date Released:"
        '
        'lblProdRecDate
        '
        lblProdRecDate.AutoSize = True
        lblProdRecDate.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdRecDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdRecDate.Location = New System.Drawing.Point(376, 130)
        lblProdRecDate.Name = "lblProdRecDate"
        lblProdRecDate.Size = New System.Drawing.Size(102, 16)
        lblProdRecDate.TabIndex = 17
        lblProdRecDate.Text = "Date Received:"
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(804, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "mnuMain"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.OpenToolStripMenuItem.Text = "&Open User Viewer"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Op&tions"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutDeveloperToolStripMenuItem, Me.AboutProgramToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'AboutDeveloperToolStripMenuItem
        '
        Me.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem"
        Me.AboutDeveloperToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AboutDeveloperToolStripMenuItem.Text = "About &Developer"
        '
        'AboutProgramToolStripMenuItem
        '
        Me.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem"
        Me.AboutProgramToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.AboutProgramToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AboutProgramToolStripMenuItem.Text = "About P&rogram"
        '
        'pnlProducts
        '
        Me.pnlProducts.Controls.Add(Me.ProductBindingNavigator)
        Me.pnlProducts.Controls.Add(Me.btnNextP)
        Me.pnlProducts.Controls.Add(Me.btnBackP)
        Me.pnlProducts.Controls.Add(Me.btnAdd)
        Me.pnlProducts.Controls.Add(Me.btnSave)
        Me.pnlProducts.Controls.Add(Me.btnDelete)
        Me.pnlProducts.Controls.Add(Me.dgvProduct)
        Me.pnlProducts.Controls.Add(Me.btnClose)
        Me.pnlProducts.Controls.Add(Me.pnlHeader)
        Me.pnlProducts.Controls.Add(lblProdId)
        Me.pnlProducts.Controls.Add(Me.txtProdId)
        Me.pnlProducts.Controls.Add(lblProdName)
        Me.pnlProducts.Controls.Add(Me.txtProdName)
        Me.pnlProducts.Controls.Add(lblProdMfr)
        Me.pnlProducts.Controls.Add(Me.cbxProdMfr)
        Me.pnlProducts.Controls.Add(lblProdCtgy)
        Me.pnlProducts.Controls.Add(Me.cbxProdCtgy)
        Me.pnlProducts.Controls.Add(lblProdPrice)
        Me.pnlProducts.Controls.Add(Me.txtProdPrice)
        Me.pnlProducts.Controls.Add(lblProdQty)
        Me.pnlProducts.Controls.Add(Me.nudProdQty)
        Me.pnlProducts.Controls.Add(lblProdRelDate)
        Me.pnlProducts.Controls.Add(Me.dtpProdRelDate)
        Me.pnlProducts.Controls.Add(lblProdRecDate)
        Me.pnlProducts.Controls.Add(Me.dtpProdRecDate)
        Me.pnlProducts.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlProducts.Location = New System.Drawing.Point(0, 23)
        Me.pnlProducts.Name = "pnlProducts"
        Me.pnlProducts.Size = New System.Drawing.Size(804, 551)
        Me.pnlProducts.TabIndex = 1
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
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(804, 25)
        Me.ProductBindingNavigator.TabIndex = 26
        Me.ProductBindingNavigator.Text = "BindingNavigator1"
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
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.AllegroDatabaseDataSet
        '
        'AllegroDatabaseDataSet
        '
        Me.AllegroDatabaseDataSet.DataSetName = "AllegroDatabaseDataSet"
        Me.AllegroDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductBindingNavigatorSaveItem
        '
        Me.ProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductBindingNavigatorSaveItem.Name = "ProductBindingNavigatorSaveItem"
        Me.ProductBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnNextP
        '
        Me.btnNextP.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnNextP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNextP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNextP.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNextP.Location = New System.Drawing.Point(157, 233)
        Me.btnNextP.Name = "btnNextP"
        Me.btnNextP.Size = New System.Drawing.Size(119, 29)
        Me.btnNextP.TabIndex = 25
        Me.btnNextP.Text = "Next"
        Me.btnNextP.UseVisualStyleBackColor = False
        '
        'btnBackP
        '
        Me.btnBackP.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnBackP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBackP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackP.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBackP.Location = New System.Drawing.Point(32, 233)
        Me.btnBackP.Name = "btnBackP"
        Me.btnBackP.Size = New System.Drawing.Size(119, 29)
        Me.btnBackP.TabIndex = 24
        Me.btnBackP.Text = "Back"
        Me.btnBackP.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Location = New System.Drawing.Point(406, 233)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 29)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.Location = New System.Drawing.Point(529, 233)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 29)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(652, 233)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 29)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dgvProduct
        '
        Me.dgvProduct.AutoGenerateColumns = False
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgvProduct.DataSource = Me.ProductBindingSource
        Me.dgvProduct.Location = New System.Drawing.Point(32, 311)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.Size = New System.Drawing.Size(740, 193)
        Me.dgvProduct.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProdId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProdId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProdName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProdName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "ProdImg"
        Me.DataGridViewImageColumn1.HeaderText = "ProdImg"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProdMfr"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProdMfr"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProdCtgy"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProdCtgy"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ProdPrice"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ProdPrice"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ProdQty"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ProdQty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ProdRelDate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ProdRelDate"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ProdRecDate"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ProdRecDate"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(343, 510)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(119, 29)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblProdMan)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 21)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(807, 34)
        Me.pnlHeader.TabIndex = 19
        '
        'lblProdMan
        '
        Me.lblProdMan.AutoSize = True
        Me.lblProdMan.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdMan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblProdMan.Location = New System.Drawing.Point(4, 11)
        Me.lblProdMan.Name = "lblProdMan"
        Me.lblProdMan.Size = New System.Drawing.Size(179, 19)
        Me.lblProdMan.TabIndex = 0
        Me.lblProdMan.Text = "Product Management"
        '
        'txtProdId
        '
        Me.txtProdId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdId", True))
        Me.txtProdId.Location = New System.Drawing.Point(137, 67)
        Me.txtProdId.MaxLength = 50
        Me.txtProdId.Name = "txtProdId"
        Me.txtProdId.ReadOnly = True
        Me.txtProdId.Size = New System.Drawing.Size(200, 23)
        Me.txtProdId.TabIndex = 2
        '
        'txtProdName
        '
        Me.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdName", True))
        Me.txtProdName.Location = New System.Drawing.Point(137, 97)
        Me.txtProdName.MaxLength = 50
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 23)
        Me.txtProdName.TabIndex = 4
        '
        'cbxProdMfr
        '
        Me.cbxProdMfr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdMfr", True))
        Me.cbxProdMfr.FormattingEnabled = True
        Me.cbxProdMfr.Items.AddRange(New Object() {"Moog", "Arturia", "Korg", "Roland", "Yamaha", "Ibanez", "Fender", "Rickenbacker", "Universal Audio", "Eventide", "WesAudio", "Tube-Tech"})
        Me.cbxProdMfr.Location = New System.Drawing.Point(137, 188)
        Me.cbxProdMfr.Name = "cbxProdMfr"
        Me.cbxProdMfr.Size = New System.Drawing.Size(200, 24)
        Me.cbxProdMfr.TabIndex = 8
        '
        'cbxProdCtgy
        '
        Me.cbxProdCtgy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdCtgy", True))
        Me.cbxProdCtgy.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxProdCtgy.FormattingEnabled = True
        Me.cbxProdCtgy.Items.AddRange(New Object() {"Synthesizer", "Electric Guitar", "Guitar Pedal", "Compressor", "Equalizer", "Limiter"})
        Me.cbxProdCtgy.Location = New System.Drawing.Point(137, 157)
        Me.cbxProdCtgy.Name = "cbxProdCtgy"
        Me.cbxProdCtgy.Size = New System.Drawing.Size(200, 24)
        Me.cbxProdCtgy.TabIndex = 10
        '
        'txtProdPrice
        '
        Me.txtProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdPrice", True))
        Me.txtProdPrice.Location = New System.Drawing.Point(137, 127)
        Me.txtProdPrice.MaxLength = 30
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.Size = New System.Drawing.Size(200, 23)
        Me.txtProdPrice.TabIndex = 12
        '
        'nudProdQty
        '
        Me.nudProdQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nudProdQty.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdQty", True))
        Me.nudProdQty.Location = New System.Drawing.Point(484, 69)
        Me.nudProdQty.Name = "nudProdQty"
        Me.nudProdQty.Size = New System.Drawing.Size(200, 19)
        Me.nudProdQty.TabIndex = 14
        '
        'dtpProdRelDate
        '
        Me.dtpProdRelDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdRelDate", True))
        Me.dtpProdRelDate.Location = New System.Drawing.Point(484, 97)
        Me.dtpProdRelDate.MaxDate = New Date(2023, 12, 31, 0, 0, 0, 0)
        Me.dtpProdRelDate.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.dtpProdRelDate.Name = "dtpProdRelDate"
        Me.dtpProdRelDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpProdRelDate.TabIndex = 16
        '
        'dtpProdRecDate
        '
        Me.dtpProdRecDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdRecDate", True))
        Me.dtpProdRecDate.Location = New System.Drawing.Point(484, 127)
        Me.dtpProdRecDate.MaxDate = New Date(2023, 12, 31, 0, 0, 0, 0)
        Me.dtpProdRecDate.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpProdRecDate.Name = "dtpProdRecDate"
        Me.dtpProdRecDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpProdRecDate.TabIndex = 18
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
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.Document = Me.PrintDocument
        Me.PrintPreviewDialog.UseEXDialog = True
        '
        'PrintDocument
        '
        '
        'pnlUser
        '
        Me.pnlUser.Controls.Add(Me.btnBack)
        Me.pnlUser.Controls.Add(Me.Panel1)
        Me.pnlUser.Controls.Add(Me.dgvUser)
        Me.pnlUser.Location = New System.Drawing.Point(0, 23)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(804, 551)
        Me.pnlUser.TabIndex = 20
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(322, 337)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(141, 29)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back to Products"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblUserViewer)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 37)
        Me.Panel1.TabIndex = 20
        '
        'lblUserViewer
        '
        Me.lblUserViewer.AutoSize = True
        Me.lblUserViewer.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserViewer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUserViewer.Location = New System.Drawing.Point(4, 11)
        Me.lblUserViewer.Name = "lblUserViewer"
        Me.lblUserViewer.Size = New System.Drawing.Size(108, 19)
        Me.lblUserViewer.TabIndex = 0
        Me.lblUserViewer.Text = "User Viewer"
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.AllowUserToOrderColumns = True
        Me.dgvUser.AllowUserToResizeRows = False
        Me.dgvUser.AutoGenerateColumns = False
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.dgvUser.DataSource = Me.UserBindingSource
        Me.dgvUser.Location = New System.Drawing.Point(220, 80)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvUser.Size = New System.Drawing.Size(344, 235)
        Me.dgvUser.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UserId"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UserId"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn10.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "UserPwd"
        Me.DataGridViewTextBoxColumn11.HeaderText = "UserPwd"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.AllegroDatabaseDataSet
        '
        'pnlDeveloper
        '
        Me.pnlDeveloper.Controls.Add(Me.pctDeveloper)
        Me.pnlDeveloper.Location = New System.Drawing.Point(0, 23)
        Me.pnlDeveloper.Name = "pnlDeveloper"
        Me.pnlDeveloper.Size = New System.Drawing.Size(804, 551)
        Me.pnlDeveloper.TabIndex = 27
        '
        'pctDeveloper
        '
        Me.pctDeveloper.Image = CType(resources.GetObject("pctDeveloper.Image"), System.Drawing.Image)
        Me.pctDeveloper.Location = New System.Drawing.Point(323, 21)
        Me.pctDeveloper.Name = "pctDeveloper"
        Me.pctDeveloper.Size = New System.Drawing.Size(155, 125)
        Me.pctDeveloper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctDeveloper.TabIndex = 0
        Me.pctDeveloper.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(804, 574)
        Me.Controls.Add(Me.pnlProducts)
        Me.Controls.Add(Me.pnlDeveloper)
        Me.Controls.Add(Me.pnlUser)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allegro"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.pnlProducts.ResumeLayout(False)
        Me.pnlProducts.PerformLayout()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllegroDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.nudProdQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUser.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDeveloper.ResumeLayout(False)
        CType(Me.pctDeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutDeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlProducts As Panel
    Friend WithEvents AllegroDatabaseDataSet As AllegroDatabaseDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As AllegroDatabaseDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As AllegroDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtProdId As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents cbxProdMfr As ComboBox
    Friend WithEvents cbxProdCtgy As ComboBox
    Friend WithEvents txtProdPrice As TextBox
    Friend WithEvents nudProdQty As NumericUpDown
    Friend WithEvents dtpProdRelDate As DateTimePicker
    Friend WithEvents dtpProdRecDate As DateTimePicker
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblProdMan As Label
    Friend WithEvents PrintPreviewDialog As PrintDialog
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents UserTableAdapter As AllegroDatabaseDataSetTableAdapters.UserTableAdapter
    Friend WithEvents pnlUser As Panel
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblUserViewer As Label
    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents btnNextP As Button
    Friend WithEvents btnBackP As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
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
    Friend WithEvents pnlDeveloper As Panel
    Friend WithEvents pctDeveloper As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
