<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEntryRevised
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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.cmbSearchLocalFoods = New System.Windows.Forms.ComboBox()
        Me.lblSearchLocalDatabaseFoods = New System.Windows.Forms.Label()
        Me.btnCreateFood = New System.Windows.Forms.Button()
        Me.lblSearchFavoritesDatabaseFoods = New System.Windows.Forms.Label()
        Me.cmbSearchFavoriteFoods = New System.Windows.Forms.ComboBox()
        Me.grpEntryDetails = New System.Windows.Forms.GroupBox()
        Me.pnlFavorites = New System.Windows.Forms.Panel()
        Me.chkFoodAddToFavorites = New System.Windows.Forms.CheckBox()
        Me.chkFoodLowCarb = New System.Windows.Forms.CheckBox()
        Me.btnDeleteFromFavorites = New System.Windows.Forms.Button()
        Me.chkFoodHeartHealthy = New System.Windows.Forms.CheckBox()
        Me.grpFavorites = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtServingSizeAmount = New System.Windows.Forms.TextBox()
        Me.lblServingSizeAmount = New System.Windows.Forms.Label()
        Me.txtCholesterol = New System.Windows.Forms.TextBox()
        Me.txtSodium = New System.Windows.Forms.TextBox()
        Me.txtDietaryFiber = New System.Windows.Forms.TextBox()
        Me.txtTransFat = New System.Windows.Forms.TextBox()
        Me.txtSaturatedFat = New System.Windows.Forms.TextBox()
        Me.txtSugars = New System.Windows.Forms.TextBox()
        Me.txtCarbohydrates = New System.Windows.Forms.TextBox()
        Me.txtTotalFat = New System.Windows.Forms.TextBox()
        Me.txtProtein = New System.Windows.Forms.TextBox()
        Me.txtServingSizeUnit = New System.Windows.Forms.TextBox()
        Me.lblCholesterol = New System.Windows.Forms.Label()
        Me.lblSodium = New System.Windows.Forms.Label()
        Me.lblDietaryFiber = New System.Windows.Forms.Label()
        Me.lblTransFat = New System.Windows.Forms.Label()
        Me.lblSaturatedFat = New System.Windows.Forms.Label()
        Me.lblSugars = New System.Windows.Forms.Label()
        Me.lblCarbohydrates = New System.Windows.Forms.Label()
        Me.lblTotalFat = New System.Windows.Forms.Label()
        Me.lblProtein = New System.Windows.Forms.Label()
        Me.lblServingSizeUnit = New System.Windows.Forms.Label()
        Me.lblFoodName = New System.Windows.Forms.Label()
        Me.lblNumberOfServings = New System.Windows.Forms.Label()
        Me.lblFoodCalories = New System.Windows.Forms.Label()
        Me.cmbNumberOfServings = New System.Windows.Forms.ComboBox()
        Me.txtFoodName = New System.Windows.Forms.TextBox()
        Me.txtFoodCalories = New System.Windows.Forms.TextBox()
        Me.rbFoodLunch = New System.Windows.Forms.RadioButton()
        Me.rbFoodSnacks = New System.Windows.Forms.RadioButton()
        Me.rbFoodBreakfast = New System.Windows.Forms.RadioButton()
        Me.rbFoodDinner = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.grpMain.SuspendLayout()
        Me.grpEntryDetails.SuspendLayout()
        Me.pnlFavorites.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.grpMain)
        Me.FlowLayoutPanel2.Controls.Add(Me.grpEntryDetails)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnClose)
        Me.FlowLayoutPanel2.Controls.Add(Me.DataGridView1)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(2, 2)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(412, 703)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.cmbSearchLocalFoods)
        Me.grpMain.Controls.Add(Me.lblSearchLocalDatabaseFoods)
        Me.grpMain.Controls.Add(Me.btnCreateFood)
        Me.grpMain.Controls.Add(Me.lblSearchFavoritesDatabaseFoods)
        Me.grpMain.Controls.Add(Me.cmbSearchFavoriteFoods)
        Me.grpMain.Location = New System.Drawing.Point(3, 3)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(224, 171)
        Me.grpMain.TabIndex = 65
        Me.grpMain.TabStop = False
        '
        'cmbSearchLocalFoods
        '
        Me.cmbSearchLocalFoods.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSearchLocalFoods.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSearchLocalFoods.FormattingEnabled = True
        Me.cmbSearchLocalFoods.Location = New System.Drawing.Point(13, 44)
        Me.cmbSearchLocalFoods.Name = "cmbSearchLocalFoods"
        Me.cmbSearchLocalFoods.Size = New System.Drawing.Size(193, 21)
        Me.cmbSearchLocalFoods.TabIndex = 2
        '
        'lblSearchLocalDatabaseFoods
        '
        Me.lblSearchLocalDatabaseFoods.AutoSize = True
        Me.lblSearchLocalDatabaseFoods.Location = New System.Drawing.Point(10, 28)
        Me.lblSearchLocalDatabaseFoods.Name = "lblSearchLocalDatabaseFoods"
        Me.lblSearchLocalDatabaseFoods.Size = New System.Drawing.Size(119, 13)
        Me.lblSearchLocalDatabaseFoods.TabIndex = 3
        Me.lblSearchLocalDatabaseFoods.Text = "Search Local Database"
        '
        'btnCreateFood
        '
        Me.btnCreateFood.Location = New System.Drawing.Point(13, 121)
        Me.btnCreateFood.Name = "btnCreateFood"
        Me.btnCreateFood.Size = New System.Drawing.Size(192, 23)
        Me.btnCreateFood.TabIndex = 4
        Me.btnCreateFood.Text = "Create Food"
        Me.btnCreateFood.UseVisualStyleBackColor = True
        '
        'lblSearchFavoritesDatabaseFoods
        '
        Me.lblSearchFavoritesDatabaseFoods.AutoSize = True
        Me.lblSearchFavoritesDatabaseFoods.Location = New System.Drawing.Point(10, 68)
        Me.lblSearchFavoritesDatabaseFoods.Name = "lblSearchFavoritesDatabaseFoods"
        Me.lblSearchFavoritesDatabaseFoods.Size = New System.Drawing.Size(87, 13)
        Me.lblSearchFavoritesDatabaseFoods.TabIndex = 48
        Me.lblSearchFavoritesDatabaseFoods.Text = "Search Favorites"
        '
        'cmbSearchFavoriteFoods
        '
        Me.cmbSearchFavoriteFoods.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSearchFavoriteFoods.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSearchFavoriteFoods.FormattingEnabled = True
        Me.cmbSearchFavoriteFoods.Location = New System.Drawing.Point(13, 84)
        Me.cmbSearchFavoriteFoods.Name = "cmbSearchFavoriteFoods"
        Me.cmbSearchFavoriteFoods.Size = New System.Drawing.Size(193, 21)
        Me.cmbSearchFavoriteFoods.TabIndex = 47
        '
        'grpEntryDetails
        '
        Me.grpEntryDetails.Controls.Add(Me.pnlFavorites)
        Me.grpEntryDetails.Controls.Add(Me.grpFavorites)
        Me.grpEntryDetails.Controls.Add(Me.FlowLayoutPanel1)
        Me.grpEntryDetails.Controls.Add(Me.btnEdit)
        Me.grpEntryDetails.Controls.Add(Me.GroupBox1)
        Me.grpEntryDetails.Controls.Add(Me.lblFoodName)
        Me.grpEntryDetails.Controls.Add(Me.lblNumberOfServings)
        Me.grpEntryDetails.Controls.Add(Me.lblFoodCalories)
        Me.grpEntryDetails.Controls.Add(Me.cmbNumberOfServings)
        Me.grpEntryDetails.Controls.Add(Me.txtFoodName)
        Me.grpEntryDetails.Controls.Add(Me.txtFoodCalories)
        Me.grpEntryDetails.Controls.Add(Me.rbFoodLunch)
        Me.grpEntryDetails.Controls.Add(Me.rbFoodSnacks)
        Me.grpEntryDetails.Controls.Add(Me.rbFoodBreakfast)
        Me.grpEntryDetails.Controls.Add(Me.rbFoodDinner)
        Me.grpEntryDetails.Location = New System.Drawing.Point(3, 180)
        Me.grpEntryDetails.Name = "grpEntryDetails"
        Me.grpEntryDetails.Size = New System.Drawing.Size(406, 467)
        Me.grpEntryDetails.TabIndex = 64
        Me.grpEntryDetails.TabStop = False
        Me.grpEntryDetails.Text = "Entry Details"
        Me.grpEntryDetails.Visible = False
        '
        'pnlFavorites
        '
        Me.pnlFavorites.Controls.Add(Me.chkFoodAddToFavorites)
        Me.pnlFavorites.Controls.Add(Me.chkFoodLowCarb)
        Me.pnlFavorites.Controls.Add(Me.btnDeleteFromFavorites)
        Me.pnlFavorites.Controls.Add(Me.chkFoodHeartHealthy)
        Me.pnlFavorites.Location = New System.Drawing.Point(86, 170)
        Me.pnlFavorites.Name = "pnlFavorites"
        Me.pnlFavorites.Size = New System.Drawing.Size(127, 98)
        Me.pnlFavorites.TabIndex = 71
        '
        'chkFoodAddToFavorites
        '
        Me.chkFoodAddToFavorites.AutoSize = True
        Me.chkFoodAddToFavorites.Location = New System.Drawing.Point(3, 5)
        Me.chkFoodAddToFavorites.Name = "chkFoodAddToFavorites"
        Me.chkFoodAddToFavorites.Size = New System.Drawing.Size(120, 17)
        Me.chkFoodAddToFavorites.TabIndex = 59
        Me.chkFoodAddToFavorites.Text = "Add to My Favorites"
        Me.chkFoodAddToFavorites.UseVisualStyleBackColor = True
        '
        'chkFoodLowCarb
        '
        Me.chkFoodLowCarb.AutoSize = True
        Me.chkFoodLowCarb.Location = New System.Drawing.Point(22, 27)
        Me.chkFoodLowCarb.Name = "chkFoodLowCarb"
        Me.chkFoodLowCarb.Size = New System.Drawing.Size(71, 17)
        Me.chkFoodLowCarb.TabIndex = 60
        Me.chkFoodLowCarb.Text = "Low Carb"
        Me.chkFoodLowCarb.UseVisualStyleBackColor = True
        Me.chkFoodLowCarb.Visible = False
        '
        'btnDeleteFromFavorites
        '
        Me.btnDeleteFromFavorites.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeleteFromFavorites.Location = New System.Drawing.Point(3, 4)
        Me.btnDeleteFromFavorites.Name = "btnDeleteFromFavorites"
        Me.btnDeleteFromFavorites.Size = New System.Drawing.Size(120, 20)
        Me.btnDeleteFromFavorites.TabIndex = 71
        Me.btnDeleteFromFavorites.Text = "Delete From Favorites"
        Me.btnDeleteFromFavorites.UseVisualStyleBackColor = False
        Me.btnDeleteFromFavorites.Visible = False
        '
        'chkFoodHeartHealthy
        '
        Me.chkFoodHeartHealthy.AutoSize = True
        Me.chkFoodHeartHealthy.Location = New System.Drawing.Point(22, 51)
        Me.chkFoodHeartHealthy.Name = "chkFoodHeartHealthy"
        Me.chkFoodHeartHealthy.Size = New System.Drawing.Size(91, 17)
        Me.chkFoodHeartHealthy.TabIndex = 61
        Me.chkFoodHeartHealthy.Text = "Heart Healthy"
        Me.chkFoodHeartHealthy.UseVisualStyleBackColor = True
        Me.chkFoodHeartHealthy.Visible = False
        '
        'grpFavorites
        '
        Me.grpFavorites.Location = New System.Drawing.Point(132, 389)
        Me.grpFavorites.Name = "grpFavorites"
        Me.grpFavorites.Size = New System.Drawing.Size(40, 24)
        Me.grpFavorites.TabIndex = 29
        Me.grpFavorites.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAdd)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBack)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnUpdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCancel)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(10, 266)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(104, 164)
        Me.FlowLayoutPanel1.TabIndex = 70
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 27)
        Me.btnAdd.TabIndex = 67
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(3, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 26)
        Me.btnSave.TabIndex = 71
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(3, 68)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 27)
        Me.btnBack.TabIndex = 54
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(3, 101)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(98, 27)
        Me.btnUpdate.TabIndex = 68
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(3, 134)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 27)
        Me.btnCancel.TabIndex = 69
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(172, 10)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(41, 37)
        Me.btnEdit.TabIndex = 66
        Me.btnEdit.Text = "✎"
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtServingSizeAmount)
        Me.GroupBox1.Controls.Add(Me.lblServingSizeAmount)
        Me.GroupBox1.Controls.Add(Me.txtCholesterol)
        Me.GroupBox1.Controls.Add(Me.txtSodium)
        Me.GroupBox1.Controls.Add(Me.txtDietaryFiber)
        Me.GroupBox1.Controls.Add(Me.txtTransFat)
        Me.GroupBox1.Controls.Add(Me.txtSaturatedFat)
        Me.GroupBox1.Controls.Add(Me.txtSugars)
        Me.GroupBox1.Controls.Add(Me.txtCarbohydrates)
        Me.GroupBox1.Controls.Add(Me.txtTotalFat)
        Me.GroupBox1.Controls.Add(Me.txtProtein)
        Me.GroupBox1.Controls.Add(Me.txtServingSizeUnit)
        Me.GroupBox1.Controls.Add(Me.lblCholesterol)
        Me.GroupBox1.Controls.Add(Me.lblSodium)
        Me.GroupBox1.Controls.Add(Me.lblDietaryFiber)
        Me.GroupBox1.Controls.Add(Me.lblTransFat)
        Me.GroupBox1.Controls.Add(Me.lblSaturatedFat)
        Me.GroupBox1.Controls.Add(Me.lblSugars)
        Me.GroupBox1.Controls.Add(Me.lblCarbohydrates)
        Me.GroupBox1.Controls.Add(Me.lblTotalFat)
        Me.GroupBox1.Controls.Add(Me.lblProtein)
        Me.GroupBox1.Controls.Add(Me.lblServingSizeUnit)
        Me.GroupBox1.Location = New System.Drawing.Point(218, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 451)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nutritional Info"
        '
        'txtServingSizeAmount
        '
        Me.txtServingSizeAmount.Enabled = False
        Me.txtServingSizeAmount.Location = New System.Drawing.Point(37, 43)
        Me.txtServingSizeAmount.Name = "txtServingSizeAmount"
        Me.txtServingSizeAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtServingSizeAmount.TabIndex = 22
        '
        'lblServingSizeAmount
        '
        Me.lblServingSizeAmount.AutoSize = True
        Me.lblServingSizeAmount.Location = New System.Drawing.Point(37, 29)
        Me.lblServingSizeAmount.Name = "lblServingSizeAmount"
        Me.lblServingSizeAmount.Size = New System.Drawing.Size(105, 13)
        Me.lblServingSizeAmount.TabIndex = 20
        Me.lblServingSizeAmount.Text = "Serving Size Amount"
        '
        'txtCholesterol
        '
        Me.txtCholesterol.Enabled = False
        Me.txtCholesterol.Location = New System.Drawing.Point(37, 398)
        Me.txtCholesterol.Name = "txtCholesterol"
        Me.txtCholesterol.Size = New System.Drawing.Size(100, 20)
        Me.txtCholesterol.TabIndex = 19
        '
        'txtSodium
        '
        Me.txtSodium.Enabled = False
        Me.txtSodium.Location = New System.Drawing.Point(37, 363)
        Me.txtSodium.Name = "txtSodium"
        Me.txtSodium.Size = New System.Drawing.Size(100, 20)
        Me.txtSodium.TabIndex = 18
        '
        'txtDietaryFiber
        '
        Me.txtDietaryFiber.Enabled = False
        Me.txtDietaryFiber.Location = New System.Drawing.Point(37, 328)
        Me.txtDietaryFiber.Name = "txtDietaryFiber"
        Me.txtDietaryFiber.Size = New System.Drawing.Size(100, 20)
        Me.txtDietaryFiber.TabIndex = 17
        '
        'txtTransFat
        '
        Me.txtTransFat.Enabled = False
        Me.txtTransFat.Location = New System.Drawing.Point(37, 293)
        Me.txtTransFat.Name = "txtTransFat"
        Me.txtTransFat.Size = New System.Drawing.Size(100, 20)
        Me.txtTransFat.TabIndex = 16
        '
        'txtSaturatedFat
        '
        Me.txtSaturatedFat.Enabled = False
        Me.txtSaturatedFat.Location = New System.Drawing.Point(37, 258)
        Me.txtSaturatedFat.Name = "txtSaturatedFat"
        Me.txtSaturatedFat.Size = New System.Drawing.Size(100, 20)
        Me.txtSaturatedFat.TabIndex = 15
        '
        'txtSugars
        '
        Me.txtSugars.Enabled = False
        Me.txtSugars.Location = New System.Drawing.Point(37, 223)
        Me.txtSugars.Name = "txtSugars"
        Me.txtSugars.Size = New System.Drawing.Size(100, 20)
        Me.txtSugars.TabIndex = 14
        '
        'txtCarbohydrates
        '
        Me.txtCarbohydrates.Enabled = False
        Me.txtCarbohydrates.Location = New System.Drawing.Point(37, 188)
        Me.txtCarbohydrates.Name = "txtCarbohydrates"
        Me.txtCarbohydrates.Size = New System.Drawing.Size(100, 20)
        Me.txtCarbohydrates.TabIndex = 13
        '
        'txtTotalFat
        '
        Me.txtTotalFat.Enabled = False
        Me.txtTotalFat.Location = New System.Drawing.Point(37, 153)
        Me.txtTotalFat.Name = "txtTotalFat"
        Me.txtTotalFat.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalFat.TabIndex = 12
        '
        'txtProtein
        '
        Me.txtProtein.Enabled = False
        Me.txtProtein.Location = New System.Drawing.Point(37, 118)
        Me.txtProtein.Name = "txtProtein"
        Me.txtProtein.Size = New System.Drawing.Size(100, 20)
        Me.txtProtein.TabIndex = 11
        '
        'txtServingSizeUnit
        '
        Me.txtServingSizeUnit.Enabled = False
        Me.txtServingSizeUnit.Location = New System.Drawing.Point(37, 83)
        Me.txtServingSizeUnit.Name = "txtServingSizeUnit"
        Me.txtServingSizeUnit.Size = New System.Drawing.Size(100, 20)
        Me.txtServingSizeUnit.TabIndex = 10
        '
        'lblCholesterol
        '
        Me.lblCholesterol.AutoSize = True
        Me.lblCholesterol.Location = New System.Drawing.Point(37, 384)
        Me.lblCholesterol.Name = "lblCholesterol"
        Me.lblCholesterol.Size = New System.Drawing.Size(59, 13)
        Me.lblCholesterol.TabIndex = 9
        Me.lblCholesterol.Text = "Cholesterol"
        '
        'lblSodium
        '
        Me.lblSodium.AutoSize = True
        Me.lblSodium.Location = New System.Drawing.Point(37, 349)
        Me.lblSodium.Name = "lblSodium"
        Me.lblSodium.Size = New System.Drawing.Size(42, 13)
        Me.lblSodium.TabIndex = 8
        Me.lblSodium.Text = "Sodium"
        '
        'lblDietaryFiber
        '
        Me.lblDietaryFiber.AutoSize = True
        Me.lblDietaryFiber.Location = New System.Drawing.Point(37, 314)
        Me.lblDietaryFiber.Name = "lblDietaryFiber"
        Me.lblDietaryFiber.Size = New System.Drawing.Size(66, 13)
        Me.lblDietaryFiber.TabIndex = 7
        Me.lblDietaryFiber.Text = "Dietary Fiber"
        '
        'lblTransFat
        '
        Me.lblTransFat.AutoSize = True
        Me.lblTransFat.Location = New System.Drawing.Point(37, 279)
        Me.lblTransFat.Name = "lblTransFat"
        Me.lblTransFat.Size = New System.Drawing.Size(52, 13)
        Me.lblTransFat.TabIndex = 6
        Me.lblTransFat.Text = "Trans Fat"
        '
        'lblSaturatedFat
        '
        Me.lblSaturatedFat.AutoSize = True
        Me.lblSaturatedFat.Location = New System.Drawing.Point(37, 244)
        Me.lblSaturatedFat.Name = "lblSaturatedFat"
        Me.lblSaturatedFat.Size = New System.Drawing.Size(71, 13)
        Me.lblSaturatedFat.TabIndex = 5
        Me.lblSaturatedFat.Text = "Saturated Fat"
        '
        'lblSugars
        '
        Me.lblSugars.AutoSize = True
        Me.lblSugars.Location = New System.Drawing.Point(37, 209)
        Me.lblSugars.Name = "lblSugars"
        Me.lblSugars.Size = New System.Drawing.Size(40, 13)
        Me.lblSugars.TabIndex = 4
        Me.lblSugars.Text = "Sugars"
        '
        'lblCarbohydrates
        '
        Me.lblCarbohydrates.AutoSize = True
        Me.lblCarbohydrates.Location = New System.Drawing.Point(37, 174)
        Me.lblCarbohydrates.Name = "lblCarbohydrates"
        Me.lblCarbohydrates.Size = New System.Drawing.Size(75, 13)
        Me.lblCarbohydrates.TabIndex = 3
        Me.lblCarbohydrates.Text = "Carbohydrates"
        '
        'lblTotalFat
        '
        Me.lblTotalFat.AutoSize = True
        Me.lblTotalFat.Location = New System.Drawing.Point(37, 139)
        Me.lblTotalFat.Name = "lblTotalFat"
        Me.lblTotalFat.Size = New System.Drawing.Size(49, 13)
        Me.lblTotalFat.TabIndex = 2
        Me.lblTotalFat.Text = "Total Fat"
        '
        'lblProtein
        '
        Me.lblProtein.AutoSize = True
        Me.lblProtein.Location = New System.Drawing.Point(37, 104)
        Me.lblProtein.Name = "lblProtein"
        Me.lblProtein.Size = New System.Drawing.Size(40, 13)
        Me.lblProtein.TabIndex = 1
        Me.lblProtein.Text = "Protein"
        '
        'lblServingSizeUnit
        '
        Me.lblServingSizeUnit.AutoSize = True
        Me.lblServingSizeUnit.Location = New System.Drawing.Point(37, 69)
        Me.lblServingSizeUnit.Name = "lblServingSizeUnit"
        Me.lblServingSizeUnit.Size = New System.Drawing.Size(88, 13)
        Me.lblServingSizeUnit.TabIndex = 0
        Me.lblServingSizeUnit.Text = "Serving Size Unit"
        '
        'lblFoodName
        '
        Me.lblFoodName.AutoSize = True
        Me.lblFoodName.Enabled = False
        Me.lblFoodName.Location = New System.Drawing.Point(6, 16)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(62, 13)
        Me.lblFoodName.TabIndex = 52
        Me.lblFoodName.Text = "Food Name"
        '
        'lblNumberOfServings
        '
        Me.lblNumberOfServings.AutoSize = True
        Me.lblNumberOfServings.Location = New System.Drawing.Point(7, 119)
        Me.lblNumberOfServings.Name = "lblNumberOfServings"
        Me.lblNumberOfServings.Size = New System.Drawing.Size(100, 13)
        Me.lblNumberOfServings.TabIndex = 63
        Me.lblNumberOfServings.Text = "Number of Servings"
        '
        'lblFoodCalories
        '
        Me.lblFoodCalories.AutoSize = True
        Me.lblFoodCalories.Enabled = False
        Me.lblFoodCalories.Location = New System.Drawing.Point(7, 66)
        Me.lblFoodCalories.Name = "lblFoodCalories"
        Me.lblFoodCalories.Size = New System.Drawing.Size(44, 13)
        Me.lblFoodCalories.TabIndex = 53
        Me.lblFoodCalories.Text = "Calories"
        '
        'cmbNumberOfServings
        '
        Me.cmbNumberOfServings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNumberOfServings.FormattingEnabled = True
        Me.cmbNumberOfServings.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbNumberOfServings.Location = New System.Drawing.Point(9, 135)
        Me.cmbNumberOfServings.Name = "cmbNumberOfServings"
        Me.cmbNumberOfServings.Size = New System.Drawing.Size(99, 21)
        Me.cmbNumberOfServings.TabIndex = 62
        '
        'txtFoodName
        '
        Me.txtFoodName.Enabled = False
        Me.txtFoodName.Location = New System.Drawing.Point(9, 32)
        Me.txtFoodName.Name = "txtFoodName"
        Me.txtFoodName.Size = New System.Drawing.Size(100, 20)
        Me.txtFoodName.TabIndex = 50
        '
        'txtFoodCalories
        '
        Me.txtFoodCalories.Enabled = False
        Me.txtFoodCalories.Location = New System.Drawing.Point(9, 82)
        Me.txtFoodCalories.Name = "txtFoodCalories"
        Me.txtFoodCalories.Size = New System.Drawing.Size(100, 20)
        Me.txtFoodCalories.TabIndex = 51
        '
        'rbFoodLunch
        '
        Me.rbFoodLunch.AutoSize = True
        Me.rbFoodLunch.Location = New System.Drawing.Point(9, 197)
        Me.rbFoodLunch.Name = "rbFoodLunch"
        Me.rbFoodLunch.Size = New System.Drawing.Size(55, 17)
        Me.rbFoodLunch.TabIndex = 56
        Me.rbFoodLunch.Text = "Lunch"
        Me.rbFoodLunch.UseVisualStyleBackColor = True
        '
        'rbFoodSnacks
        '
        Me.rbFoodSnacks.AutoSize = True
        Me.rbFoodSnacks.Checked = True
        Me.rbFoodSnacks.Location = New System.Drawing.Point(9, 243)
        Me.rbFoodSnacks.Name = "rbFoodSnacks"
        Me.rbFoodSnacks.Size = New System.Drawing.Size(61, 17)
        Me.rbFoodSnacks.TabIndex = 58
        Me.rbFoodSnacks.TabStop = True
        Me.rbFoodSnacks.Text = "Snacks"
        Me.rbFoodSnacks.UseVisualStyleBackColor = True
        '
        'rbFoodBreakfast
        '
        Me.rbFoodBreakfast.AutoSize = True
        Me.rbFoodBreakfast.Location = New System.Drawing.Point(9, 174)
        Me.rbFoodBreakfast.Name = "rbFoodBreakfast"
        Me.rbFoodBreakfast.Size = New System.Drawing.Size(70, 17)
        Me.rbFoodBreakfast.TabIndex = 55
        Me.rbFoodBreakfast.Text = "Breakfast"
        Me.rbFoodBreakfast.UseVisualStyleBackColor = True
        '
        'rbFoodDinner
        '
        Me.rbFoodDinner.AutoSize = True
        Me.rbFoodDinner.Location = New System.Drawing.Point(9, 220)
        Me.rbFoodDinner.Name = "rbFoodDinner"
        Me.rbFoodDinner.Size = New System.Drawing.Size(56, 17)
        Me.rbFoodDinner.TabIndex = 57
        Me.rbFoodDinner.Text = "Dinner"
        Me.rbFoodDinner.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(3, 653)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(406, 31)
        Me.btnClose.TabIndex = 49
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 690)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(88, 10)
        Me.DataGridView1.TabIndex = 28
        Me.DataGridView1.Visible = False
        '
        'frmAddEntryRevised
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(410, 736)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Name = "frmAddEntryRevised"
        Me.Text = "Add Entry"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.grpEntryDetails.ResumeLayout(False)
        Me.grpEntryDetails.PerformLayout()
        Me.pnlFavorites.ResumeLayout(False)
        Me.pnlFavorites.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents grpMain As GroupBox
    Friend WithEvents cmbSearchLocalFoods As ComboBox
    Friend WithEvents lblSearchLocalDatabaseFoods As Label
    Friend WithEvents btnCreateFood As Button
    Friend WithEvents lblSearchFavoritesDatabaseFoods As Label
    Friend WithEvents cmbSearchFavoriteFoods As ComboBox
    Friend WithEvents grpEntryDetails As GroupBox
    Friend WithEvents grpFavorites As GroupBox
    Friend WithEvents btnDeleteFromFavorites As Button
    Friend WithEvents chkFoodAddToFavorites As CheckBox
    Friend WithEvents chkFoodLowCarb As CheckBox
    Friend WithEvents chkFoodHeartHealthy As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtServingSizeAmount As TextBox
    Friend WithEvents lblServingSizeAmount As Label
    Friend WithEvents txtCholesterol As TextBox
    Friend WithEvents txtSodium As TextBox
    Friend WithEvents txtDietaryFiber As TextBox
    Friend WithEvents txtTransFat As TextBox
    Friend WithEvents txtSaturatedFat As TextBox
    Friend WithEvents txtSugars As TextBox
    Friend WithEvents txtCarbohydrates As TextBox
    Friend WithEvents txtTotalFat As TextBox
    Friend WithEvents txtProtein As TextBox
    Friend WithEvents txtServingSizeUnit As TextBox
    Friend WithEvents lblCholesterol As Label
    Friend WithEvents lblSodium As Label
    Friend WithEvents lblDietaryFiber As Label
    Friend WithEvents lblTransFat As Label
    Friend WithEvents lblSaturatedFat As Label
    Friend WithEvents lblSugars As Label
    Friend WithEvents lblCarbohydrates As Label
    Friend WithEvents lblTotalFat As Label
    Friend WithEvents lblProtein As Label
    Friend WithEvents lblServingSizeUnit As Label
    Friend WithEvents lblFoodName As Label
    Friend WithEvents lblNumberOfServings As Label
    Friend WithEvents lblFoodCalories As Label
    Friend WithEvents cmbNumberOfServings As ComboBox
    Friend WithEvents txtFoodName As TextBox
    Friend WithEvents txtFoodCalories As TextBox
    Friend WithEvents rbFoodLunch As RadioButton
    Friend WithEvents rbFoodSnacks As RadioButton
    Friend WithEvents rbFoodBreakfast As RadioButton
    Friend WithEvents rbFoodDinner As RadioButton
    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents pnlFavorites As Panel
End Class
