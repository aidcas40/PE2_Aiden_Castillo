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
        Dim ProdImgLabel As System.Windows.Forms.Label
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
        Me.AllegroDatabaseDataSet = New Allegro.AllegroDatabaseDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New Allegro.AllegroDatabaseDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New Allegro.AllegroDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ProdIdTextBox = New System.Windows.Forms.TextBox()
        Me.ProdNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProdImgPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProdMfrComboBox = New System.Windows.Forms.ComboBox()
        Me.ProdCtgyComboBox = New System.Windows.Forms.ComboBox()
        Me.ProdPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProdQtyNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ProdRelDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProdRecDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblProdMan = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New Allegro.AllegroDatabaseDataSetTableAdapters.UserTableAdapter()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserViewer = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBackP = New System.Windows.Forms.Button()
        Me.btnNextP = New System.Windows.Forms.Button()
        lblProdId = New System.Windows.Forms.Label()
        lblProdName = New System.Windows.Forms.Label()
        ProdImgLabel = New System.Windows.Forms.Label()
        lblProdMfr = New System.Windows.Forms.Label()
        lblProdCtgy = New System.Windows.Forms.Label()
        lblProdPrice = New System.Windows.Forms.Label()
        lblProdQty = New System.Windows.Forms.Label()
        lblProdRelDate = New System.Windows.Forms.Label()
        lblProdRecDate = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.pnlProducts.SuspendLayout()
        CType(Me.AllegroDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdImgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdQtyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.pnlUser.SuspendLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.AboutDeveloperToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AboutDeveloperToolStripMenuItem.Text = "About &Developer"
        '
        'AboutProgramToolStripMenuItem
        '
        Me.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem"
        Me.AboutProgramToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.AboutProgramToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AboutProgramToolStripMenuItem.Text = "About P&rogram"
        '
        'pnlProducts
        '
        Me.pnlProducts.Controls.Add(Me.btnNextP)
        Me.pnlProducts.Controls.Add(Me.btnBackP)
        Me.pnlProducts.Controls.Add(Me.btnAdd)
        Me.pnlProducts.Controls.Add(Me.btnSave)
        Me.pnlProducts.Controls.Add(Me.btnDelete)
        Me.pnlProducts.Controls.Add(Me.dgvProduct)
        Me.pnlProducts.Controls.Add(Me.btnClose)
        Me.pnlProducts.Controls.Add(Me.pnlHeader)
        Me.pnlProducts.Controls.Add(lblProdId)
        Me.pnlProducts.Controls.Add(Me.ProdIdTextBox)
        Me.pnlProducts.Controls.Add(lblProdName)
        Me.pnlProducts.Controls.Add(Me.ProdNameTextBox)
        Me.pnlProducts.Controls.Add(ProdImgLabel)
        Me.pnlProducts.Controls.Add(Me.ProdImgPictureBox)
        Me.pnlProducts.Controls.Add(lblProdMfr)
        Me.pnlProducts.Controls.Add(Me.ProdMfrComboBox)
        Me.pnlProducts.Controls.Add(lblProdCtgy)
        Me.pnlProducts.Controls.Add(Me.ProdCtgyComboBox)
        Me.pnlProducts.Controls.Add(lblProdPrice)
        Me.pnlProducts.Controls.Add(Me.ProdPriceTextBox)
        Me.pnlProducts.Controls.Add(lblProdQty)
        Me.pnlProducts.Controls.Add(Me.ProdQtyNumericUpDown)
        Me.pnlProducts.Controls.Add(lblProdRelDate)
        Me.pnlProducts.Controls.Add(Me.ProdRelDateDateTimePicker)
        Me.pnlProducts.Controls.Add(lblProdRecDate)
        Me.pnlProducts.Controls.Add(Me.ProdRecDateDateTimePicker)
        Me.pnlProducts.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlProducts.Location = New System.Drawing.Point(0, 23)
        Me.pnlProducts.Name = "pnlProducts"
        Me.pnlProducts.Size = New System.Drawing.Size(804, 551)
        Me.pnlProducts.TabIndex = 1
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
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'lblProdId
        '
        lblProdId.AutoSize = True
        lblProdId.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdId.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdId.Location = New System.Drawing.Point(32, 58)
        lblProdId.Name = "lblProdId"
        lblProdId.Size = New System.Drawing.Size(77, 16)
        lblProdId.TabIndex = 1
        lblProdId.Text = "Product ID:"
        '
        'ProdIdTextBox
        '
        Me.ProdIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdId", True))
        Me.ProdIdTextBox.Location = New System.Drawing.Point(134, 55)
        Me.ProdIdTextBox.Name = "ProdIdTextBox"
        Me.ProdIdTextBox.ReadOnly = True
        Me.ProdIdTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ProdIdTextBox.TabIndex = 2
        '
        'lblProdName
        '
        lblProdName.AutoSize = True
        lblProdName.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdName.Location = New System.Drawing.Point(32, 88)
        lblProdName.Name = "lblProdName"
        lblProdName.Size = New System.Drawing.Size(48, 16)
        lblProdName.TabIndex = 3
        lblProdName.Text = "Name:"
        '
        'ProdNameTextBox
        '
        Me.ProdNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdName", True))
        Me.ProdNameTextBox.Location = New System.Drawing.Point(134, 85)
        Me.ProdNameTextBox.Name = "ProdNameTextBox"
        Me.ProdNameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ProdNameTextBox.TabIndex = 4
        '
        'ProdImgLabel
        '
        ProdImgLabel.AutoSize = True
        ProdImgLabel.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProdImgLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        ProdImgLabel.Location = New System.Drawing.Point(373, 148)
        ProdImgLabel.Name = "ProdImgLabel"
        ProdImgLabel.Size = New System.Drawing.Size(82, 16)
        ProdImgLabel.TabIndex = 5
        ProdImgLabel.Text = "Prod Image:"
        '
        'ProdImgPictureBox
        '
        Me.ProdImgPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductBindingSource, "ProdImg", True))
        Me.ProdImgPictureBox.Location = New System.Drawing.Point(481, 148)
        Me.ProdImgPictureBox.Name = "ProdImgPictureBox"
        Me.ProdImgPictureBox.Size = New System.Drawing.Size(200, 52)
        Me.ProdImgPictureBox.TabIndex = 6
        Me.ProdImgPictureBox.TabStop = False
        '
        'lblProdMfr
        '
        lblProdMfr.AutoSize = True
        lblProdMfr.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdMfr.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdMfr.Location = New System.Drawing.Point(32, 180)
        lblProdMfr.Name = "lblProdMfr"
        lblProdMfr.Size = New System.Drawing.Size(97, 16)
        lblProdMfr.TabIndex = 7
        lblProdMfr.Text = "Manufacturer:"
        '
        'ProdMfrComboBox
        '
        Me.ProdMfrComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdMfr", True))
        Me.ProdMfrComboBox.FormattingEnabled = True
        Me.ProdMfrComboBox.Items.AddRange(New Object() {"Moog", "Arturia", "Korg", "Roland", "Yamaha", "Ibanez", "Fender", "Rickenbacker", "Universal Audio", "Eventide", "WesAudio", "Tube-Tech"})
        Me.ProdMfrComboBox.Location = New System.Drawing.Point(134, 176)
        Me.ProdMfrComboBox.Name = "ProdMfrComboBox"
        Me.ProdMfrComboBox.Size = New System.Drawing.Size(200, 24)
        Me.ProdMfrComboBox.TabIndex = 8
        '
        'lblProdCtgy
        '
        lblProdCtgy.AutoSize = True
        lblProdCtgy.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdCtgy.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdCtgy.Location = New System.Drawing.Point(32, 149)
        lblProdCtgy.Name = "lblProdCtgy"
        lblProdCtgy.Size = New System.Drawing.Size(69, 16)
        lblProdCtgy.TabIndex = 9
        lblProdCtgy.Text = "Category:"
        '
        'ProdCtgyComboBox
        '
        Me.ProdCtgyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdCtgy", True))
        Me.ProdCtgyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ProdCtgyComboBox.FormattingEnabled = True
        Me.ProdCtgyComboBox.Items.AddRange(New Object() {"Synthesizer", "Electric Guitar", "Guitar Pedal", "Compressor", "Equalizer", "Limiter"})
        Me.ProdCtgyComboBox.Location = New System.Drawing.Point(134, 145)
        Me.ProdCtgyComboBox.Name = "ProdCtgyComboBox"
        Me.ProdCtgyComboBox.Size = New System.Drawing.Size(200, 24)
        Me.ProdCtgyComboBox.TabIndex = 10
        '
        'lblProdPrice
        '
        lblProdPrice.AutoSize = True
        lblProdPrice.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdPrice.Location = New System.Drawing.Point(32, 118)
        lblProdPrice.Name = "lblProdPrice"
        lblProdPrice.Size = New System.Drawing.Size(43, 16)
        lblProdPrice.TabIndex = 11
        lblProdPrice.Text = "Price:"
        '
        'ProdPriceTextBox
        '
        Me.ProdPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProdPrice", True))
        Me.ProdPriceTextBox.Location = New System.Drawing.Point(134, 115)
        Me.ProdPriceTextBox.Name = "ProdPriceTextBox"
        Me.ProdPriceTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ProdPriceTextBox.TabIndex = 12
        '
        'lblProdQty
        '
        lblProdQty.AutoSize = True
        lblProdQty.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdQty.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdQty.Location = New System.Drawing.Point(373, 58)
        lblProdQty.Name = "lblProdQty"
        lblProdQty.Size = New System.Drawing.Size(65, 16)
        lblProdQty.TabIndex = 13
        lblProdQty.Text = "Quantity:"
        '
        'ProdQtyNumericUpDown
        '
        Me.ProdQtyNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProdQtyNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdQty", True))
        Me.ProdQtyNumericUpDown.Location = New System.Drawing.Point(481, 57)
        Me.ProdQtyNumericUpDown.Name = "ProdQtyNumericUpDown"
        Me.ProdQtyNumericUpDown.Size = New System.Drawing.Size(200, 19)
        Me.ProdQtyNumericUpDown.TabIndex = 14
        '
        'lblProdRelDate
        '
        lblProdRelDate.AutoSize = True
        lblProdRelDate.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdRelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdRelDate.Location = New System.Drawing.Point(373, 88)
        lblProdRelDate.Name = "lblProdRelDate"
        lblProdRelDate.Size = New System.Drawing.Size(102, 16)
        lblProdRelDate.TabIndex = 15
        lblProdRelDate.Text = "Date Released:"
        '
        'ProdRelDateDateTimePicker
        '
        Me.ProdRelDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdRelDate", True))
        Me.ProdRelDateDateTimePicker.Location = New System.Drawing.Point(481, 85)
        Me.ProdRelDateDateTimePicker.MaxDate = New Date(2023, 12, 31, 0, 0, 0, 0)
        Me.ProdRelDateDateTimePicker.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.ProdRelDateDateTimePicker.Name = "ProdRelDateDateTimePicker"
        Me.ProdRelDateDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.ProdRelDateDateTimePicker.TabIndex = 16
        '
        'lblProdRecDate
        '
        lblProdRecDate.AutoSize = True
        lblProdRecDate.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProdRecDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        lblProdRecDate.Location = New System.Drawing.Point(373, 118)
        lblProdRecDate.Name = "lblProdRecDate"
        lblProdRecDate.Size = New System.Drawing.Size(102, 16)
        lblProdRecDate.TabIndex = 17
        lblProdRecDate.Text = "Date Received:"
        '
        'ProdRecDateDateTimePicker
        '
        Me.ProdRecDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ProdRecDate", True))
        Me.ProdRecDateDateTimePicker.Location = New System.Drawing.Point(481, 115)
        Me.ProdRecDateDateTimePicker.MaxDate = New Date(2023, 12, 31, 0, 0, 0, 0)
        Me.ProdRecDateDateTimePicker.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.ProdRecDateDateTimePicker.Name = "ProdRecDateDateTimePicker"
        Me.ProdRecDateDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.ProdRecDateDateTimePicker.TabIndex = 18
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblProdMan)
        Me.pnlHeader.Location = New System.Drawing.Point(3, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(804, 34)
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
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.AllegroDatabaseDataSet
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
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
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
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
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(653, 221)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 29)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.Location = New System.Drawing.Point(528, 221)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 29)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Location = New System.Drawing.Point(403, 221)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 29)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBackP
        '
        Me.btnBackP.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnBackP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBackP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackP.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBackP.Location = New System.Drawing.Point(32, 221)
        Me.btnBackP.Name = "btnBackP"
        Me.btnBackP.Size = New System.Drawing.Size(119, 29)
        Me.btnBackP.TabIndex = 24
        Me.btnBackP.Text = "Back"
        Me.btnBackP.UseVisualStyleBackColor = False
        '
        'btnNextP
        '
        Me.btnNextP.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnNextP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNextP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNextP.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNextP.Location = New System.Drawing.Point(160, 221)
        Me.btnNextP.Name = "btnNextP"
        Me.btnNextP.Size = New System.Drawing.Size(119, 29)
        Me.btnNextP.TabIndex = 25
        Me.btnNextP.Text = "Next"
        Me.btnNextP.UseVisualStyleBackColor = False
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(804, 574)
        Me.Controls.Add(Me.pnlProducts)
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
        CType(Me.AllegroDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdImgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdQtyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlUser.ResumeLayout(False)
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ProdIdTextBox As TextBox
    Friend WithEvents ProdNameTextBox As TextBox
    Friend WithEvents ProdImgPictureBox As PictureBox
    Friend WithEvents ProdMfrComboBox As ComboBox
    Friend WithEvents ProdCtgyComboBox As ComboBox
    Friend WithEvents ProdPriceTextBox As TextBox
    Friend WithEvents ProdQtyNumericUpDown As NumericUpDown
    Friend WithEvents ProdRelDateDateTimePicker As DateTimePicker
    Friend WithEvents ProdRecDateDateTimePicker As DateTimePicker
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
End Class
