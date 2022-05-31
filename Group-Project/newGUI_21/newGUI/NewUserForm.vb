Public Class frmNewUser
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim um As New UserManagement
        'Dim wm As New weightManagement
        Dim newUser As New UserManagement.user

        If txtUserName.Text = "" Or txtPass.Text = "" Or txtFName.Text = "" Or txtLName.Text = "" Or txtEMail.Text = "" Then
            MsgBox("Please enter something in every field!")
            'TODO: fix checking if username already exists
            'ElseIf um.lookupUserByUsername(txtUserName.Text).username = txtUserName.Text Then
            'MsgBox("Username already exists!")
        Else

            With newUser

                .username = txtUserName.Text
                .password = txtPass.Text
                .firstName = txtFName.Text
                .lastName = txtLName.Text
                .email = txtEMail.Text
                .height = numHeight.Value
                .dob = dateBDay.Value.Date

                If btnMale.Checked Then
                    .sex = "Male"
                ElseIf btnFemale.Checked Then
                    .sex = "Female"
                End If

            End With

            um.createUser(newUser)

            Me.Close()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    ' Delete ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    Private Sub frmNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWeight.Visible = False
        numWeight.Visible = False
    End Sub
    ' Delete ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
End Class