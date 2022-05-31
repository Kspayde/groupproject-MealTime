<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExercisesRevised
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
        Me.btnCreateNewExercise = New System.Windows.Forms.Button()
        Me.btnManageFavorites = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblFoodName = New System.Windows.Forms.Label()
        Me.lblFoodCalories = New System.Windows.Forms.Label()
        Me.txtExerciseName = New System.Windows.Forms.TextBox()
        Me.txtExerciseCalories = New System.Windows.Forms.TextBox()
        Me.chkExerciseAddToFavorites = New System.Windows.Forms.CheckBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.grpCreate = New System.Windows.Forms.GroupBox()
        Me.lstFavorites = New System.Windows.Forms.ListBox()
        Me.cmbExercises = New System.Windows.Forms.ComboBox()
        Me.btnAddToFavorites = New System.Windows.Forms.Button()
        Me.btnDeleteFromFavorites = New System.Windows.Forms.Button()
        Me.grpManageFavorites = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMyFavorites = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.flpMain = New System.Windows.Forms.FlowLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpMain.SuspendLayout()
        Me.grpCreate.SuspendLayout()
        Me.grpManageFavorites.SuspendLayout()
        Me.flpMain.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateNewExercise
        '
        Me.btnCreateNewExercise.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCreateNewExercise.BackColor = System.Drawing.SystemColors.Menu
        Me.btnCreateNewExercise.Location = New System.Drawing.Point(11, 19)
        Me.btnCreateNewExercise.Name = "btnCreateNewExercise"
        Me.btnCreateNewExercise.Size = New System.Drawing.Size(182, 23)
        Me.btnCreateNewExercise.TabIndex = 0
        Me.btnCreateNewExercise.Text = "Create New Exercise"
        Me.btnCreateNewExercise.UseVisualStyleBackColor = False
        '
        'btnManageFavorites
        '
        Me.btnManageFavorites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnManageFavorites.BackColor = System.Drawing.SystemColors.Menu
        Me.btnManageFavorites.Location = New System.Drawing.Point(11, 50)
        Me.btnManageFavorites.Name = "btnManageFavorites"
        Me.btnManageFavorites.Size = New System.Drawing.Size(182, 23)
        Me.btnManageFavorites.TabIndex = 1
        Me.btnManageFavorites.Text = "Manage Favorite Exercises"
        Me.btnManageFavorites.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Location = New System.Drawing.Point(11, 79)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(182, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblFoodName
        '
        Me.lblFoodName.AutoSize = True
        Me.lblFoodName.Location = New System.Drawing.Point(8, 29)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(78, 13)
        Me.lblFoodName.TabIndex = 56
        Me.lblFoodName.Text = "Exercise Name"
        '
        'lblFoodCalories
        '
        Me.lblFoodCalories.AutoSize = True
        Me.lblFoodCalories.Location = New System.Drawing.Point(8, 69)
        Me.lblFoodCalories.Name = "lblFoodCalories"
        Me.lblFoodCalories.Size = New System.Drawing.Size(81, 13)
        Me.lblFoodCalories.TabIndex = 57
        Me.lblFoodCalories.Text = "Calories Burned"
        '
        'txtExerciseName
        '
        Me.txtExerciseName.Location = New System.Drawing.Point(11, 45)
        Me.txtExerciseName.Name = "txtExerciseName"
        Me.txtExerciseName.Size = New System.Drawing.Size(183, 20)
        Me.txtExerciseName.TabIndex = 54
        '
        'txtExerciseCalories
        '
        Me.txtExerciseCalories.Location = New System.Drawing.Point(10, 85)
        Me.txtExerciseCalories.Name = "txtExerciseCalories"
        Me.txtExerciseCalories.Size = New System.Drawing.Size(183, 20)
        Me.txtExerciseCalories.TabIndex = 55
        '
        'chkExerciseAddToFavorites
        '
        Me.chkExerciseAddToFavorites.AutoSize = True
        Me.chkExerciseAddToFavorites.Location = New System.Drawing.Point(11, 155)
        Me.chkExerciseAddToFavorites.Name = "chkExerciseAddToFavorites"
        Me.chkExerciseAddToFavorites.Size = New System.Drawing.Size(120, 17)
        Me.chkExerciseAddToFavorites.TabIndex = 72
        Me.chkExerciseAddToFavorites.Text = "Add to My Favorites"
        Me.chkExerciseAddToFavorites.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCreate.BackColor = System.Drawing.SystemColors.Menu
        Me.btnCreate.Location = New System.Drawing.Point(10, 122)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(183, 23)
        Me.btnCreate.TabIndex = 74
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Location = New System.Drawing.Point(10, 178)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(183, 23)
        Me.btnCancel.TabIndex = 75
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.btnManageFavorites)
        Me.grpMain.Controls.Add(Me.btnCreateNewExercise)
        Me.grpMain.Controls.Add(Me.btnClose)
        Me.grpMain.Location = New System.Drawing.Point(3, 3)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(209, 117)
        Me.grpMain.TabIndex = 76
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "Exercises"
        '
        'grpCreate
        '
        Me.grpCreate.Controls.Add(Me.btnCancel)
        Me.grpCreate.Controls.Add(Me.btnCreate)
        Me.grpCreate.Controls.Add(Me.chkExerciseAddToFavorites)
        Me.grpCreate.Controls.Add(Me.lblFoodName)
        Me.grpCreate.Controls.Add(Me.lblFoodCalories)
        Me.grpCreate.Controls.Add(Me.txtExerciseName)
        Me.grpCreate.Controls.Add(Me.txtExerciseCalories)
        Me.grpCreate.Location = New System.Drawing.Point(3, 126)
        Me.grpCreate.Name = "grpCreate"
        Me.grpCreate.Size = New System.Drawing.Size(209, 227)
        Me.grpCreate.TabIndex = 77
        Me.grpCreate.TabStop = False
        Me.grpCreate.Text = "Create"
        '
        'lstFavorites
        '
        Me.lstFavorites.FormattingEnabled = True
        Me.lstFavorites.Location = New System.Drawing.Point(217, 37)
        Me.lstFavorites.Name = "lstFavorites"
        Me.lstFavorites.Size = New System.Drawing.Size(182, 173)
        Me.lstFavorites.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.lstFavorites, "These are your exercises.  You can remove them from your available list here.")
        '
        'cmbExercises
        '
        Me.cmbExercises.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbExercises.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbExercises.DropDownWidth = 400
        Me.cmbExercises.FormattingEnabled = True
        Me.cmbExercises.Location = New System.Drawing.Point(10, 99)
        Me.cmbExercises.Name = "cmbExercises"
        Me.cmbExercises.Size = New System.Drawing.Size(182, 21)
        Me.cmbExercises.TabIndex = 79
        Me.ToolTip1.SetToolTip(Me.cmbExercises, "Choose which exercises are accessible to you here.")
        '
        'btnAddToFavorites
        '
        Me.btnAddToFavorites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddToFavorites.BackColor = System.Drawing.SystemColors.Menu
        Me.btnAddToFavorites.Location = New System.Drawing.Point(9, 126)
        Me.btnAddToFavorites.Name = "btnAddToFavorites"
        Me.btnAddToFavorites.Size = New System.Drawing.Size(182, 23)
        Me.btnAddToFavorites.TabIndex = 80
        Me.btnAddToFavorites.Text = "Add To Favorites"
        Me.ToolTip1.SetToolTip(Me.btnAddToFavorites, "Choose which exercises are accessible to you here.")
        Me.btnAddToFavorites.UseVisualStyleBackColor = False
        '
        'btnDeleteFromFavorites
        '
        Me.btnDeleteFromFavorites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDeleteFromFavorites.BackColor = System.Drawing.SystemColors.Menu
        Me.btnDeleteFromFavorites.Location = New System.Drawing.Point(217, 216)
        Me.btnDeleteFromFavorites.Name = "btnDeleteFromFavorites"
        Me.btnDeleteFromFavorites.Size = New System.Drawing.Size(182, 23)
        Me.btnDeleteFromFavorites.TabIndex = 81
        Me.btnDeleteFromFavorites.Text = "Delete From Favorites"
        Me.ToolTip1.SetToolTip(Me.btnDeleteFromFavorites, "These are your exercises.  You can remove them from your available list here.")
        Me.btnDeleteFromFavorites.UseVisualStyleBackColor = False
        '
        'grpManageFavorites
        '
        Me.grpManageFavorites.Controls.Add(Me.Label1)
        Me.grpManageFavorites.Controls.Add(Me.lblMyFavorites)
        Me.grpManageFavorites.Controls.Add(Me.btnDone)
        Me.grpManageFavorites.Controls.Add(Me.btnDeleteFromFavorites)
        Me.grpManageFavorites.Controls.Add(Me.btnAddToFavorites)
        Me.grpManageFavorites.Controls.Add(Me.cmbExercises)
        Me.grpManageFavorites.Controls.Add(Me.lstFavorites)
        Me.grpManageFavorites.Location = New System.Drawing.Point(3, 359)
        Me.grpManageFavorites.Name = "grpManageFavorites"
        Me.grpManageFavorites.Size = New System.Drawing.Size(405, 296)
        Me.grpManageFavorites.TabIndex = 82
        Me.grpManageFavorites.TabStop = False
        Me.grpManageFavorites.Text = "Manage Favorites"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Exercises"
        '
        'lblMyFavorites
        '
        Me.lblMyFavorites.AutoSize = True
        Me.lblMyFavorites.Location = New System.Drawing.Point(151, 21)
        Me.lblMyFavorites.Name = "lblMyFavorites"
        Me.lblMyFavorites.Size = New System.Drawing.Size(67, 13)
        Me.lblMyFavorites.TabIndex = 83
        Me.lblMyFavorites.Text = "My Favorites"
        '
        'btnDone
        '
        Me.btnDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDone.Location = New System.Drawing.Point(0, 254)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(408, 23)
        Me.btnDone.TabIndex = 82
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'flpMain
        '
        Me.flpMain.AutoSize = True
        Me.flpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpMain.Controls.Add(Me.grpMain)
        Me.flpMain.Controls.Add(Me.grpCreate)
        Me.flpMain.Controls.Add(Me.grpManageFavorites)
        Me.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpMain.Location = New System.Drawing.Point(0, 0)
        Me.flpMain.Name = "flpMain"
        Me.flpMain.Size = New System.Drawing.Size(411, 658)
        Me.flpMain.TabIndex = 83
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(568, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(498, 286)
        Me.DataGridView1.TabIndex = 84
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(568, 295)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(498, 274)
        Me.DataGridView2.TabIndex = 85
        '
        'frmExercisesRevised
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1167, 646)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.flpMain)
        Me.Name = "frmExercisesRevised"
        Me.Text = "Manage Exercises"
        Me.grpMain.ResumeLayout(False)
        Me.grpCreate.ResumeLayout(False)
        Me.grpCreate.PerformLayout()
        Me.grpManageFavorites.ResumeLayout(False)
        Me.grpManageFavorites.PerformLayout()
        Me.flpMain.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateNewExercise As Button
    Friend WithEvents btnManageFavorites As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblFoodName As Label
    Friend WithEvents lblFoodCalories As Label
    Friend WithEvents txtExerciseName As TextBox
    Friend WithEvents txtExerciseCalories As TextBox
    Friend WithEvents chkExerciseAddToFavorites As CheckBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents grpMain As GroupBox
    Friend WithEvents grpCreate As GroupBox
    Friend WithEvents lstFavorites As ListBox
    Friend WithEvents cmbExercises As ComboBox
    Friend WithEvents btnAddToFavorites As Button
    Friend WithEvents btnDeleteFromFavorites As Button
    Friend WithEvents grpManageFavorites As GroupBox
    Friend WithEvents btnDone As Button
    Friend WithEvents flpMain As FlowLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMyFavorites As Label
End Class
