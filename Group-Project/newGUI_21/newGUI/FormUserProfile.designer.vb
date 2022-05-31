<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserProfile
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
        Me.numHeight = New System.Windows.Forms.NumericUpDown()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblBDay = New System.Windows.Forms.Label()
        Me.dateBDay = New System.Windows.Forms.DateTimePicker()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.lblEMail = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.btnMale = New System.Windows.Forms.RadioButton()
        Me.btnFemale = New System.Windows.Forms.RadioButton()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblActivityLevel = New System.Windows.Forms.Label()
        Me.lblRepeatPassword = New System.Windows.Forms.Label()
        Me.cmbActivityLevel = New System.Windows.Forms.ComboBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDesiredWeightChange = New System.Windows.Forms.ComboBox()
        Me.lblDesiredWeightChange = New System.Windows.Forms.Label()
        Me.maskedTxtNewPassword = New System.Windows.Forms.MaskedTextBox()
        Me.maskedTxtRepeatPassword = New System.Windows.Forms.MaskedTextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblCurrentPassword = New System.Windows.Forms.Label()
        Me.chkChangePassword = New System.Windows.Forms.CheckBox()
        Me.maskedTxtCurrentPassword = New System.Windows.Forms.MaskedTextBox()
        Me.numWeight = New System.Windows.Forms.NumericUpDown()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblTargetCalories = New System.Windows.Forms.Label()
        Me.txtBoxTargetCalories = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numHeight
        '
        Me.numHeight.DecimalPlaces = 1
        Me.numHeight.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numHeight.Location = New System.Drawing.Point(247, 46)
        Me.numHeight.Maximum = New Decimal(New Integer() {96, 0, 0, 0})
        Me.numHeight.Minimum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numHeight.Name = "numHeight"
        Me.numHeight.Size = New System.Drawing.Size(200, 20)
        Me.numHeight.TabIndex = 38
        Me.numHeight.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(247, 411)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 28)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Menu
        Me.btnUpdate.Location = New System.Drawing.Point(30, 411)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(200, 28)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.Text = "Update Info"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblBDay
        '
        Me.lblBDay.AutoSize = True
        Me.lblBDay.Location = New System.Drawing.Point(247, 128)
        Me.lblBDay.Name = "lblBDay"
        Me.lblBDay.Size = New System.Drawing.Size(54, 13)
        Me.lblBDay.TabIndex = 32
        Me.lblBDay.Text = "Birth Date"
        '
        'dateBDay
        '
        Me.dateBDay.Location = New System.Drawing.Point(247, 149)
        Me.dateBDay.MaxDate = New Date(2900, 1, 1, 0, 0, 0, 0)
        Me.dateBDay.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dateBDay.Name = "dateBDay"
        Me.dateBDay.Size = New System.Drawing.Size(200, 20)
        Me.dateBDay.TabIndex = 31
        Me.dateBDay.Value = New Date(2021, 11, 6, 0, 0, 0, 0)
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(247, 30)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(58, 13)
        Me.lblHeight.TabIndex = 30
        Me.lblHeight.Text = "Height (in.)"
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(30, 195)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(200, 20)
        Me.txtEMail.TabIndex = 29
        '
        'lblEMail
        '
        Me.lblEMail.AutoSize = True
        Me.lblEMail.Location = New System.Drawing.Point(30, 174)
        Me.lblEMail.Name = "lblEMail"
        Me.lblEMail.Size = New System.Drawing.Size(32, 13)
        Me.lblEMail.TabIndex = 28
        Me.lblEMail.Text = "Email"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(30, 146)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(200, 20)
        Me.txtLName.TabIndex = 27
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(30, 125)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(58, 13)
        Me.lblLName.TabIndex = 26
        Me.lblLName.Text = "Last Name"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(30, 97)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(200, 20)
        Me.txtFName.TabIndex = 25
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(30, 76)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(57, 13)
        Me.lblFName.TabIndex = 24
        Me.lblFName.Text = "First Name"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(30, 27)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(55, 13)
        Me.lblUserName.TabIndex = 21
        Me.lblUserName.Text = "Username"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(30, 48)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(200, 20)
        Me.txtUserName.TabIndex = 20
        '
        'btnMale
        '
        Me.btnMale.AutoSize = True
        Me.btnMale.Location = New System.Drawing.Point(247, 199)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(48, 17)
        Me.btnMale.TabIndex = 33
        Me.btnMale.TabStop = True
        Me.btnMale.Text = "Male"
        Me.btnMale.UseVisualStyleBackColor = True
        '
        'btnFemale
        '
        Me.btnFemale.AutoSize = True
        Me.btnFemale.Location = New System.Drawing.Point(308, 199)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(59, 17)
        Me.btnFemale.TabIndex = 34
        Me.btnFemale.TabStop = True
        Me.btnFemale.Text = "Female"
        Me.btnFemale.UseVisualStyleBackColor = True
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(247, 177)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(25, 13)
        Me.lblSex.TabIndex = 35
        Me.lblSex.Text = "Sex"
        '
        'lblActivityLevel
        '
        Me.lblActivityLevel.AutoSize = True
        Me.lblActivityLevel.Location = New System.Drawing.Point(247, 226)
        Me.lblActivityLevel.Name = "lblActivityLevel"
        Me.lblActivityLevel.Size = New System.Drawing.Size(70, 13)
        Me.lblActivityLevel.TabIndex = 43
        Me.lblActivityLevel.Text = "Activity Level"
        '
        'lblRepeatPassword
        '
        Me.lblRepeatPassword.AutoSize = True
        Me.lblRepeatPassword.Location = New System.Drawing.Point(30, 325)
        Me.lblRepeatPassword.Name = "lblRepeatPassword"
        Me.lblRepeatPassword.Size = New System.Drawing.Size(91, 13)
        Me.lblRepeatPassword.TabIndex = 41
        Me.lblRepeatPassword.Text = "Repeat Password"
        '
        'cmbActivityLevel
        '
        Me.cmbActivityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActivityLevel.DropDownWidth = 340
        Me.cmbActivityLevel.FormattingEnabled = True
        Me.cmbActivityLevel.Items.AddRange(New Object() {"Sedentary (little or no exercise)", "Lightly Active (light exercise/sports 1-3 days/week)", "Moderately Active (moderate exerxcise/sports 3-5 days/week)"})
        Me.cmbActivityLevel.Location = New System.Drawing.Point(247, 247)
        Me.cmbActivityLevel.Name = "cmbActivityLevel"
        Me.cmbActivityLevel.Size = New System.Drawing.Size(200, 21)
        Me.cmbActivityLevel.TabIndex = 52
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Enabled = False
        Me.lblUserID.Location = New System.Drawing.Point(244, -1)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(44, 13)
        Me.lblUserID.TabIndex = 53
        Me.lblUserID.Text = "user_ID"
        Me.lblUserID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(189, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "user_ID"
        Me.Label4.Visible = False
        '
        'cmbDesiredWeightChange
        '
        Me.cmbDesiredWeightChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDesiredWeightChange.DropDownWidth = 340
        Me.cmbDesiredWeightChange.FormattingEnabled = True
        Me.cmbDesiredWeightChange.Items.AddRange(New Object() {"-2 pounds per week", "-1 pounds per week", "-0.5 pounds per week", "0 pounds per week", "0.5 pounds per week", "1 pound per week", "2 pounds per week"})
        Me.cmbDesiredWeightChange.Location = New System.Drawing.Point(247, 296)
        Me.cmbDesiredWeightChange.Name = "cmbDesiredWeightChange"
        Me.cmbDesiredWeightChange.Size = New System.Drawing.Size(200, 21)
        Me.cmbDesiredWeightChange.TabIndex = 55
        '
        'lblDesiredWeightChange
        '
        Me.lblDesiredWeightChange.AutoSize = True
        Me.lblDesiredWeightChange.Location = New System.Drawing.Point(247, 275)
        Me.lblDesiredWeightChange.Name = "lblDesiredWeightChange"
        Me.lblDesiredWeightChange.Size = New System.Drawing.Size(159, 13)
        Me.lblDesiredWeightChange.TabIndex = 56
        Me.lblDesiredWeightChange.Text = "Desired Weekly Weight Change"
        '
        'maskedTxtNewPassword
        '
        Me.maskedTxtNewPassword.Enabled = False
        Me.maskedTxtNewPassword.Location = New System.Drawing.Point(30, 297)
        Me.maskedTxtNewPassword.Name = "maskedTxtNewPassword"
        Me.maskedTxtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.maskedTxtNewPassword.Size = New System.Drawing.Size(200, 20)
        Me.maskedTxtNewPassword.TabIndex = 57
        '
        'maskedTxtRepeatPassword
        '
        Me.maskedTxtRepeatPassword.Enabled = False
        Me.maskedTxtRepeatPassword.Location = New System.Drawing.Point(30, 346)
        Me.maskedTxtRepeatPassword.Name = "maskedTxtRepeatPassword"
        Me.maskedTxtRepeatPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.maskedTxtRepeatPassword.Size = New System.Drawing.Size(200, 20)
        Me.maskedTxtRepeatPassword.TabIndex = 58
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(375, 201)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 59
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Enabled = False
        Me.txtAge.Location = New System.Drawing.Point(407, 198)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(46, 20)
        Me.txtAge.TabIndex = 60
        Me.txtAge.Text = "18"
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.AutoSize = True
        Me.lblCurrentPassword.Location = New System.Drawing.Point(30, 223)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(90, 13)
        Me.lblCurrentPassword.TabIndex = 61
        Me.lblCurrentPassword.Text = "Current Password"
        '
        'chkChangePassword
        '
        Me.chkChangePassword.AutoSize = True
        Me.chkChangePassword.Location = New System.Drawing.Point(30, 272)
        Me.chkChangePassword.Name = "chkChangePassword"
        Me.chkChangePassword.Size = New System.Drawing.Size(112, 17)
        Me.chkChangePassword.TabIndex = 62
        Me.chkChangePassword.Text = "Change Password"
        Me.chkChangePassword.UseVisualStyleBackColor = True
        '
        'maskedTxtCurrentPassword
        '
        Me.maskedTxtCurrentPassword.Location = New System.Drawing.Point(30, 244)
        Me.maskedTxtCurrentPassword.Name = "maskedTxtCurrentPassword"
        Me.maskedTxtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.maskedTxtCurrentPassword.Size = New System.Drawing.Size(200, 20)
        Me.maskedTxtCurrentPassword.TabIndex = 63
        '
        'numWeight
        '
        Me.numWeight.DecimalPlaces = 1
        Me.numWeight.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.numWeight.Location = New System.Drawing.Point(247, 88)
        Me.numWeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numWeight.Minimum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.numWeight.Name = "numWeight"
        Me.numWeight.Size = New System.Drawing.Size(200, 20)
        Me.numWeight.TabIndex = 65
        Me.numWeight.Value = New Decimal(New Integer() {154, 0, 0, 0})
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(247, 72)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(85, 13)
        Me.lblWeight.TabIndex = 64
        Me.lblWeight.Text = "Weight (pounds)"
        '
        'lblTargetCalories
        '
        Me.lblTargetCalories.AutoSize = True
        Me.lblTargetCalories.Location = New System.Drawing.Point(247, 325)
        Me.lblTargetCalories.Name = "lblTargetCalories"
        Me.lblTargetCalories.Size = New System.Drawing.Size(104, 13)
        Me.lblTargetCalories.TabIndex = 66
        Me.lblTargetCalories.Text = "Target Daily Calories"
        '
        'txtBoxTargetCalories
        '
        Me.txtBoxTargetCalories.Enabled = False
        Me.txtBoxTargetCalories.Location = New System.Drawing.Point(247, 346)
        Me.txtBoxTargetCalories.Name = "txtBoxTargetCalories"
        Me.txtBoxTargetCalories.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxTargetCalories.TabIndex = 67
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(490, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(609, 465)
        Me.DataGridView1.TabIndex = 68
        Me.DataGridView1.Visible = False
        '
        'frmUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 464)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtBoxTargetCalories)
        Me.Controls.Add(Me.lblTargetCalories)
        Me.Controls.Add(Me.numWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.maskedTxtCurrentPassword)
        Me.Controls.Add(Me.chkChangePassword)
        Me.Controls.Add(Me.lblCurrentPassword)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.maskedTxtRepeatPassword)
        Me.Controls.Add(Me.maskedTxtNewPassword)
        Me.Controls.Add(Me.lblDesiredWeightChange)
        Me.Controls.Add(Me.cmbDesiredWeightChange)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.cmbActivityLevel)
        Me.Controls.Add(Me.lblActivityLevel)
        Me.Controls.Add(Me.lblRepeatPassword)
        Me.Controls.Add(Me.numHeight)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.btnFemale)
        Me.Controls.Add(Me.btnMale)
        Me.Controls.Add(Me.lblBDay)
        Me.Controls.Add(Me.dateBDay)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtEMail)
        Me.Controls.Add(Me.lblEMail)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUserName)
        Me.Name = "frmUserProfile"
        Me.Text = "User Profile"
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numHeight As NumericUpDown
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblBDay As Label
    Friend WithEvents dateBDay As DateTimePicker
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtEMail As TextBox
    Friend WithEvents lblEMail As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents lblLName As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents lblFName As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents btnMale As RadioButton
    Friend WithEvents btnFemale As RadioButton
    Friend WithEvents lblSex As Label
    Friend WithEvents lblActivityLevel As Label
    Friend WithEvents lblRepeatPassword As Label
    Friend WithEvents cmbActivityLevel As ComboBox
    Friend WithEvents lblUserID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbDesiredWeightChange As ComboBox
    Friend WithEvents lblDesiredWeightChange As Label
    Friend WithEvents maskedTxtNewPassword As MaskedTextBox
    Friend WithEvents maskedTxtRepeatPassword As MaskedTextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents chkChangePassword As CheckBox
    Friend WithEvents maskedTxtCurrentPassword As MaskedTextBox
    Friend WithEvents numWeight As NumericUpDown
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblTargetCalories As Label
    Friend WithEvents txtBoxTargetCalories As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
