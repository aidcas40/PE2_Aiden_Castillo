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
        Dim lblProdPrice As System.Windows.Forms.Label
        Dim lblProdQty As System.Windows.Forms.Label
        Dim lblProdRelDate As System.Windows.Forms.Label
        Dim lblProdRecDate As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduct))
        Dim lblProdDesc As System.Windows.Forms.Label
        Dim lblProdMfr As System.Windows.Forms.Label
        Dim lblProdCtgy As System.Windows.Forms.Label
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblProdMan = New System.Windows.Forms.Label()
        Me.txtProdId = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtProdPrice = New System.Windows.Forms.TextBox()
        Me.nudProdQty = New System.Windows.Forms.NumericUpDown()
        Me.dtpProdRelDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpProdRecDate = New System.Windows.Forms.DateTimePicker()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserViewer = New System.Windows.Forms.Label()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.pnlDeveloper = New System.Windows.Forms.Panel()
        Me.pctDeveloper = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProdDescTextBox = New System.Windows.Forms.TextBox()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.txtProdMfr = New System.Windows.Forms.TextBox()
        Me.txtProdCtgy = New System.Windows.Forms.TextBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllegroDatabaseDataSet = New Allegro.AllegroDatabaseDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New Allegro.AllegroDatabaseDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New Allegro.AllegroDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.UserTableAdapter = New Allegro.AllegroDatabaseDataSetTableAdapters.UserTableAdapter()
        Me.pnlProgram = New System.Windows.Forms.Panel()
        Me.pctAllegro = New System.Windows.Forms.PictureBox()
        Me.lblAllegro = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblRDate = New System.Windows.Forms.Label()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.btnfpProducts = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAboutMe = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPNumber = New System.Windows.Forms.Label()
        Me.btnadProducts = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        lblProdId = New System.Windows.Forms.Label()
        lblProdName = New System.Windows.Forms.Label()
        lblProdPrice = New System.Windows.Forms.Label()
        lblProdQty = New System.Windows.Forms.Label()
        lblProdRelDate = New System.Windows.Forms.Label()
        lblProdRecDate = New System.Windows.Forms.Label()
        lblProdDesc = New System.Windows.Forms.Label()
        lblProdMfr = New System.Windows.Forms.Label()
        lblProdCtgy = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.pnlProducts.SuspendLayout()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.nudProdQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUser.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDeveloper.SuspendLayout()
        CType(Me.pctDeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllegroDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProgram.SuspendLayout()
        CType(Me.pctAllegro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mnuMain.Size = New System.Drawing.Size(827, 24)
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
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.OpenToolStripMenuItem.Text = "&Open User Viewer"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
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
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Image = CType(resources.GetObject("ClearToolStripMenuItem.Image"), System.Drawing.Image)
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
        Me.AboutDeveloperToolStripMenuItem.Image = CType(resources.GetObject("AboutDeveloperToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem"
        Me.AboutDeveloperToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AboutDeveloperToolStripMenuItem.Text = "About &Developer"
        '
        'AboutProgramToolStripMenuItem
        '
        Me.AboutProgramToolStripMenuItem.Image = CType(resources.GetObject("AboutProgramToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem"
        Me.AboutProgramToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.AboutProgramToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AboutProgramToolStripMenuItem.Text = "About P&rogram"
        '
        'pnlProducts
        '
        Me.pnlProducts.Controls.Add(lblProdCtgy)
        Me.pnlProducts.Controls.Add(Me.txtProdCtgy)
        Me.pnlProducts.Controls.Add(lblProdMfr)
        Me.pnlProducts.Controls.Add(Me.txtProdMfr)
        Me.pnlProducts.Controls.Add(Me.dgvProduct)
        Me.pnlProducts.Controls.Add(lblProdDesc)
        Me.pnlProducts.Controls.Add(Me.ProdDescTextBox)
        Me.pnlProducts.Controls.Add(Me.ProductBindingNavigator)
        Me.pnlProducts.Controls.Add(Me.btnNextP)
        Me.pnlProducts.Controls.Add(Me.btnBackP)
        Me.pnlProducts.Controls.Add(Me.btnAdd)
        Me.pnlProducts.Controls.Add(Me.btnSave)
        Me.pnlProducts.Controls.Add(Me.btnDelete)
        Me.pnlProducts.Controls.Add(Me.btnClose)
        Me.pnlProducts.Controls.Add(Me.pnlHeader)
        Me.pnlProducts.Controls.Add(lblProdId)
        Me.pnlProducts.Controls.Add(Me.txtProdId)
        Me.pnlProducts.Controls.Add(lblProdName)
        Me.pnlProducts.Controls.Add(Me.txtProdName)
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
        Me.pnlProducts.Size = New System.Drawing.Size(827, 601)
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
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(827, 25)
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
        Me.btnNextP.Image = CType(resources.GetObject("btnNextP.Image"), System.Drawing.Image)
        Me.btnNextP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNextP.Location = New System.Drawing.Point(157, 233)
        Me.btnNextP.Name = "btnNextP"
        Me.btnNextP.Size = New System.Drawing.Size(119, 29)
        Me.btnNextP.TabIndex = 10
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
        Me.btnBackP.Image = CType(resources.GetObject("btnBackP.Image"), System.Drawing.Image)
        Me.btnBackP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackP.Location = New System.Drawing.Point(32, 233)
        Me.btnBackP.Name = "btnBackP"
        Me.btnBackP.Size = New System.Drawing.Size(119, 29)
        Me.btnBackP.TabIndex = 9
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
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(406, 233)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 29)
        Me.btnAdd.TabIndex = 11
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
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(529, 233)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 29)
        Me.btnSave.TabIndex = 12
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
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(652, 233)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 29)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(342, 552)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(119, 29)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblProdMan)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 21)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(827, 34)
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
        Me.txtProdId.TabIndex = 0
        '
        'txtProdName
        '
        Me.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdName", True))
        Me.txtProdName.Location = New System.Drawing.Point(137, 97)
        Me.txtProdName.MaxLength = 50
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 23)
        Me.txtProdName.TabIndex = 1
        '
        'txtProdPrice
        '
        Me.txtProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdPrice", True))
        Me.txtProdPrice.Location = New System.Drawing.Point(137, 127)
        Me.txtProdPrice.MaxLength = 30
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.Size = New System.Drawing.Size(200, 23)
        Me.txtProdPrice.TabIndex = 2
        '
        'nudProdQty
        '
        Me.nudProdQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nudProdQty.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdQty", True))
        Me.nudProdQty.Location = New System.Drawing.Point(498, 69)
        Me.nudProdQty.Name = "nudProdQty"
        Me.nudProdQty.Size = New System.Drawing.Size(200, 19)
        Me.nudProdQty.TabIndex = 5
        '
        'dtpProdRelDate
        '
        Me.dtpProdRelDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdRelDate", True))
        Me.dtpProdRelDate.Location = New System.Drawing.Point(498, 97)
        Me.dtpProdRelDate.MaxDate = New Date(2023, 12, 31, 0, 0, 0, 0)
        Me.dtpProdRelDate.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.dtpProdRelDate.Name = "dtpProdRelDate"
        Me.dtpProdRelDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpProdRelDate.TabIndex = 6
        '
        'dtpProdRecDate
        '
        Me.dtpProdRecDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdRecDate", True))
        Me.dtpProdRecDate.Location = New System.Drawing.Point(498, 127)
        Me.dtpProdRecDate.MaxDate = New Date(2023, 12, 31, 0, 0, 0, 0)
        Me.dtpProdRecDate.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpProdRecDate.Name = "dtpProdRecDate"
        Me.dtpProdRecDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpProdRecDate.TabIndex = 7
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
        Me.pnlUser.Size = New System.Drawing.Size(827, 601)
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
        Me.btnBack.Location = New System.Drawing.Point(344, 337)
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
        Me.Panel1.Size = New System.Drawing.Size(827, 37)
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
        Me.dgvUser.Location = New System.Drawing.Point(242, 80)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvUser.Size = New System.Drawing.Size(344, 235)
        Me.dgvUser.TabIndex = 0
        '
        'pnlDeveloper
        '
        Me.pnlDeveloper.Controls.Add(Me.PictureBox1)
        Me.pnlDeveloper.Controls.Add(Me.btnadProducts)
        Me.pnlDeveloper.Controls.Add(Me.lblPNumber)
        Me.pnlDeveloper.Controls.Add(Me.lblAddress)
        Me.pnlDeveloper.Controls.Add(Me.lblEmail)
        Me.pnlDeveloper.Controls.Add(Me.lblWebsite)
        Me.pnlDeveloper.Controls.Add(Me.lblContact)
        Me.pnlDeveloper.Controls.Add(Me.lblAboutMe)
        Me.pnlDeveloper.Controls.Add(Me.lblName)
        Me.pnlDeveloper.Controls.Add(Me.pctDeveloper)
        Me.pnlDeveloper.Location = New System.Drawing.Point(0, 23)
        Me.pnlDeveloper.Name = "pnlDeveloper"
        Me.pnlDeveloper.Size = New System.Drawing.Size(827, 601)
        Me.pnlDeveloper.TabIndex = 27
        '
        'pctDeveloper
        '
        Me.pctDeveloper.Image = CType(resources.GetObject("pctDeveloper.Image"), System.Drawing.Image)
        Me.pctDeveloper.Location = New System.Drawing.Point(336, 17)
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
        'lblProdDesc
        '
        lblProdDesc.AutoSize = True
        lblProdDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdDesc.Location = New System.Drawing.Point(376, 161)
        lblProdDesc.Name = "lblProdDesc"
        lblProdDesc.Size = New System.Drawing.Size(83, 16)
        lblProdDesc.TabIndex = 26
        lblProdDesc.Text = "Description:"
        '
        'ProdDescTextBox
        '
        Me.ProdDescTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdDesc", True))
        Me.ProdDescTextBox.Location = New System.Drawing.Point(498, 158)
        Me.ProdDescTextBox.MaxLength = 150
        Me.ProdDescTextBox.Name = "ProdDescTextBox"
        Me.ProdDescTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ProdDescTextBox.TabIndex = 8
        '
        'dgvProduct
        '
        Me.dgvProduct.AutoGenerateColumns = False
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn12})
        Me.dgvProduct.DataSource = Me.ProductBindingSource
        Me.dgvProduct.Location = New System.Drawing.Point(32, 290)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.Size = New System.Drawing.Size(739, 256)
        Me.dgvProduct.TabIndex = 14
        '
        'lblProdMfr
        '
        lblProdMfr.AutoSize = True
        lblProdMfr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdMfr.Location = New System.Drawing.Point(34, 190)
        lblProdMfr.Name = "lblProdMfr"
        lblProdMfr.Size = New System.Drawing.Size(93, 16)
        lblProdMfr.TabIndex = 27
        lblProdMfr.Text = "Manufacturer"
        '
        'txtProdMfr
        '
        Me.txtProdMfr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdMfr", True))
        Me.txtProdMfr.Location = New System.Drawing.Point(137, 187)
        Me.txtProdMfr.MaxLength = 100
        Me.txtProdMfr.Name = "txtProdMfr"
        Me.txtProdMfr.Size = New System.Drawing.Size(200, 23)
        Me.txtProdMfr.TabIndex = 4
        '
        'lblProdCtgy
        '
        lblProdCtgy.AutoSize = True
        lblProdCtgy.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdCtgy.Location = New System.Drawing.Point(32, 161)
        lblProdCtgy.Name = "lblProdCtgy"
        lblProdCtgy.Size = New System.Drawing.Size(69, 16)
        lblProdCtgy.TabIndex = 28
        lblProdCtgy.Text = "Category:"
        '
        'txtProdCtgy
        '
        Me.txtProdCtgy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdCtgy", True))
        Me.txtProdCtgy.Location = New System.Drawing.Point(137, 158)
        Me.txtProdCtgy.MaxLength = 100
        Me.txtProdCtgy.Name = "txtProdCtgy"
        Me.txtProdCtgy.Size = New System.Drawing.Size(200, 23)
        Me.txtProdCtgy.TabIndex = 3
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
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ProdDesc"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ProdDesc"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
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
        'pnlProgram
        '
        Me.pnlProgram.Controls.Add(Me.btnfpProducts)
        Me.pnlProgram.Controls.Add(Me.lblDescr)
        Me.pnlProgram.Controls.Add(Me.lblRDate)
        Me.pnlProgram.Controls.Add(Me.lblVersion)
        Me.pnlProgram.Controls.Add(Me.lblAllegro)
        Me.pnlProgram.Controls.Add(Me.pctAllegro)
        Me.pnlProgram.Location = New System.Drawing.Point(0, 23)
        Me.pnlProgram.Name = "pnlProgram"
        Me.pnlProgram.Size = New System.Drawing.Size(827, 601)
        Me.pnlProgram.TabIndex = 1
        '
        'pctAllegro
        '
        Me.pctAllegro.Image = CType(resources.GetObject("pctAllegro.Image"), System.Drawing.Image)
        Me.pctAllegro.Location = New System.Drawing.Point(338, 24)
        Me.pctAllegro.Name = "pctAllegro"
        Me.pctAllegro.Size = New System.Drawing.Size(151, 126)
        Me.pctAllegro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctAllegro.TabIndex = 0
        Me.pctAllegro.TabStop = False
        '
        'lblAllegro
        '
        Me.lblAllegro.AutoSize = True
        Me.lblAllegro.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllegro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAllegro.Location = New System.Drawing.Point(364, 145)
        Me.lblAllegro.Name = "lblAllegro"
        Me.lblAllegro.Size = New System.Drawing.Size(98, 29)
        Me.lblAllegro.TabIndex = 1
        Me.lblAllegro.Text = "Allegro"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblVersion.Location = New System.Drawing.Point(368, 177)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(90, 19)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version 1.0"
        '
        'lblRDate
        '
        Me.lblRDate.AutoSize = True
        Me.lblRDate.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRDate.Location = New System.Drawing.Point(337, 199)
        Me.lblRDate.Name = "lblRDate"
        Me.lblRDate.Size = New System.Drawing.Size(152, 19)
        Me.lblRDate.TabIndex = 3
        Me.lblRDate.Text = "Released: 03/11/23"
        '
        'lblDescr
        '
        Me.lblDescr.AutoSize = True
        Me.lblDescr.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDescr.Location = New System.Drawing.Point(134, 256)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(0, 16)
        Me.lblDescr.TabIndex = 4
        '
        'btnfpProducts
        '
        Me.btnfpProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnfpProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnfpProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfpProducts.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfpProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnfpProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfpProducts.Location = New System.Drawing.Point(351, 372)
        Me.btnfpProducts.Name = "btnfpProducts"
        Me.btnfpProducts.Size = New System.Drawing.Size(141, 29)
        Me.btnfpProducts.TabIndex = 22
        Me.btnfpProducts.Text = "Back to Products"
        Me.btnfpProducts.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblName.Location = New System.Drawing.Point(258, 151)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(311, 29)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Developer: Aiden Castillo"
        '
        'lblAboutMe
        '
        Me.lblAboutMe.AutoSize = True
        Me.lblAboutMe.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutMe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAboutMe.Location = New System.Drawing.Point(134, 215)
        Me.lblAboutMe.Name = "lblAboutMe"
        Me.lblAboutMe.Size = New System.Drawing.Size(0, 16)
        Me.lblAboutMe.TabIndex = 5
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContact.Location = New System.Drawing.Point(315, 290)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(196, 23)
        Me.lblContact.TabIndex = 6
        Me.lblContact.Text = "Contact Information"
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWebsite.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWebsite.Location = New System.Drawing.Point(254, 335)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(318, 19)
        Me.lblWebsite.TabIndex = 7
        Me.lblWebsite.Text = "Website: http://aidcascs210.byethost15.com"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmail.Location = New System.Drawing.Point(311, 376)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(205, 19)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email: aidcas40@cjc.edu.bz"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAddress.Location = New System.Drawing.Point(277, 417)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(273, 19)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address: San Andres Village, Corozal"
        '
        'lblPNumber
        '
        Me.lblPNumber.AutoSize = True
        Me.lblPNumber.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPNumber.Location = New System.Drawing.Point(316, 458)
        Me.lblPNumber.Name = "lblPNumber"
        Me.lblPNumber.Size = New System.Drawing.Size(194, 19)
        Me.lblPNumber.TabIndex = 10
        Me.lblPNumber.Text = "Phone Number: 660-5057"
        '
        'btnadProducts
        '
        Me.btnadProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnadProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnadProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnadProducts.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnadProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadProducts.Location = New System.Drawing.Point(343, 505)
        Me.btnadProducts.Name = "btnadProducts"
        Me.btnadProducts.Size = New System.Drawing.Size(141, 29)
        Me.btnadProducts.TabIndex = 23
        Me.btnadProducts.Text = "Back to Products"
        Me.btnadProducts.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(723, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(827, 624)
        Me.Controls.Add(Me.pnlProducts)
        Me.Controls.Add(Me.pnlUser)
        Me.Controls.Add(Me.pnlDeveloper)
        Me.Controls.Add(Me.pnlProgram)
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
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.nudProdQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUser.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDeveloper.ResumeLayout(False)
        Me.pnlDeveloper.PerformLayout()
        CType(Me.pctDeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllegroDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProgram.ResumeLayout(False)
        Me.pnlProgram.PerformLayout()
        CType(Me.pctAllegro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ProdDescTextBox As TextBox
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents txtProdCtgy As TextBox
    Friend WithEvents txtProdMfr As TextBox
    Friend WithEvents pnlProgram As Panel
    Friend WithEvents lblAllegro As Label
    Friend WithEvents pctAllegro As PictureBox
    Friend WithEvents lblRDate As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblDescr As Label
    Friend WithEvents btnfpProducts As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblAboutMe As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblWebsite As Label
    Friend WithEvents lblPNumber As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnadProducts As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
