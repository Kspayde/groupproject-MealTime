<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUser
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
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblEMail = New System.Windows.Forms.Label()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.dateBDay = New System.Windows.Forms.DateTimePicker()
        Me.lblBDay = New System.Windows.Forms.Label()
        Me.btnMale = New System.Windows.Forms.RadioButton()
        Me.btnFemale = New System.Windows.Forms.RadioButton()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.numHeight = New System.Windows.Forms.NumericUpDown()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.numWeight = New System.Windows.Forms.NumericUpDown()
        Me.lblMessage = New System.Windows.Forms.Label()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(37, 57)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(200, 20)
        Me.txtUserName.TabIndex = 0
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(37, 38)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(55, 13)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(37, 101)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(200, 20)
        Me.txtPass.TabIndex = 3
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(37, 128)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(57, 13)
        Me.lblFName.TabIndex = 4
        Me.lblFName.Text = "First Name"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(37, 145)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(200, 20)
        Me.txtFName.TabIndex = 5
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(37, 173)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(58, 13)
        Me.lblLName.TabIndex = 6
        Me.lblLName.Text = "Last Name"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(37, 189)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(200, 20)
        Me.txtLName.TabIndex = 7
        '
        'lblEMail
        '
        Me.lblEMail.AutoSize = True
        Me.lblEMail.Location = New System.Drawing.Point(37, 217)
        Me.lblEMail.Name = "lblEMail"
        Me.lblEMail.Size = New System.Drawing.Size(32, 13)
        Me.lblEMail.TabIndex = 8
        Me.lblEMail.Text = "Email"
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(37, 233)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(200, 20)
        Me.txtEMail.TabIndex = 9
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(37, 256)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(58, 13)
        Me.lblHeight.TabIndex = 10
        Me.lblHeight.Text = "Height (in.)"
        '
        'dateBDay
        '
        Me.dateBDay.Location = New System.Drawing.Point(37, 371)
        Me.dateBDay.Name = "dateBDay"
        Me.dateBDay.Size = New System.Drawing.Size(200, 20)
        Me.dateBDay.TabIndex = 12
        '
        'lblBDay
        '
        Me.lblBDay.AutoSize = True
        Me.lblBDay.Location = New System.Drawing.Point(34, 344)
        Me.lblBDay.Name = "lblBDay"
        Me.lblBDay.Size = New System.Drawing.Size(54, 13)
        Me.lblBDay.TabIndex = 13
        Me.lblBDay.Text = "Birth Date"
        '
        'btnMale
        '
        Me.btnMale.AutoSize = True
        Me.btnMale.Location = New System.Drawing.Point(37, 420)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(48, 17)
        Me.btnMale.TabIndex = 14
        Me.btnMale.TabStop = True
        Me.btnMale.Text = "Male"
        Me.btnMale.UseVisualStyleBackColor = True
        '
        'btnFemale
        '
        Me.btnFemale.AutoSize = True
        Me.btnFemale.Location = New System.Drawing.Point(91, 420)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(59, 17)
        Me.btnFemale.TabIndex = 15
        Me.btnFemale.TabStop = True
        Me.btnFemale.Text = "Female"
        Me.btnFemale.UseVisualStyleBackColor = True
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(34, 404)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(25, 13)
        Me.lblSex.TabIndex = 16
        Me.lblSex.Text = "Sex"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(37, 458)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 17
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(118, 458)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'numHeight
        '
        Me.numHeight.Location = New System.Drawing.Point(37, 272)
        Me.numHeight.Name = "numHeight"
        Me.numHeight.Size = New System.Drawing.Size(200, 20)
        Me.numHeight.TabIndex = 19
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(37, 299)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight.TabIndex = 20
        Me.lblWeight.Text = "Weight"
        '
        'numWeight
        '
        Me.numWeight.Location = New System.Drawing.Point(37, 315)
        Me.numWeight.Name = "numWeight"
        Me.numWeight.Size = New System.Drawing.Size(200, 20)
        Me.numWeight.TabIndex = 21
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(37, 492)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblMessage.TabIndex = 22
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 517)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.numWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.numHeight)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
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
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUserName)
        Me.Name = "frmNewUser"
        Me.Text = "newUserForm"
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblFName As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents lblLName As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents lblEMail As Label
    Friend WithEvents txtEMail As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents dateBDay As DateTimePicker
    Friend WithEvents lblBDay As Label
    Friend WithEvents btnMale As RadioButton
    Friend WithEvents btnFemale As RadioButton
    Friend WithEvents lblSex As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents numHeight As NumericUpDown
    Friend WithEvents lblWeight As Label
    Friend WithEvents numWeight As NumericUpDown
    Friend WithEvents lblMessage As Label
End Class
