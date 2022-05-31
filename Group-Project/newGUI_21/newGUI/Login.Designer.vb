<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.lblLink1 = New System.Windows.Forms.Label()
        Me.lblLink2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLink3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(194, 135)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(86, 17)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(196, 171)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(82, 17)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(274, 135)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(109, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(274, 169)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(109, 20)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(262, 205)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(70, 26)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(262, 258)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(70, 26)
        Me.btnNewUser.TabIndex = 26
        Me.btnNewUser.Text = "New User"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'lblLink1
        '
        Me.lblLink1.AutoSize = True
        Me.lblLink1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblLink1.Location = New System.Drawing.Point(107, 321)
        Me.lblLink1.Name = "lblLink1"
        Me.lblLink1.Size = New System.Drawing.Size(398, 13)
        Me.lblLink1.TabIndex = 27
        Me.lblLink1.Text = "This program requires the Microsoft Access Database Engine 2016 Redistributable."
        '
        'lblLink2
        '
        Me.lblLink2.AutoSize = True
        Me.lblLink2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblLink2.Location = New System.Drawing.Point(169, 334)
        Me.lblLink2.Name = "lblLink2"
        Me.lblLink2.Size = New System.Drawing.Size(275, 13)
        Me.lblLink2.TabIndex = 28
        Me.lblLink2.Text = "accessdatabaseengine_X64.exe may be downloaded at "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(2, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 29
        '
        'lblLink3
        '
        Me.lblLink3.AutoSize = True
        Me.lblLink3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblLink3.Location = New System.Drawing.Point(138, 347)
        Me.lblLink3.Name = "lblLink3"
        Me.lblLink3.Size = New System.Drawing.Size(327, 13)
        Me.lblLink3.TabIndex = 30
        Me.lblLink3.Text = "https://www.microsoft.com/en-us/download/details.aspx?id=54920"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblLink3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLink2)
        Me.Controls.Add(Me.lblLink1)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnNewUser As Button
    Friend WithEvents lblLink1 As Label
    Friend WithEvents lblLink2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLink3 As Label
End Class
