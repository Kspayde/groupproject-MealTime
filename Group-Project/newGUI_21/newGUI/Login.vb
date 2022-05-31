Public Class Login
    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        frmNewUser.Show()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim manageUsers As New UserManagement
        Dim user As UserManagement.user = manageUsers.lookupUserByUsername(txtUsername.Text)

        If user.id > 0 Then
            If user.password = txtPassword.Text Then
                frmMain.user_ID = user.id
                frmUserProfile.user_ID = user.id
                Hide()

                '''''''''''''''''''''
                SplashScreen2.Show()
                '''''''''''''''''''''

                frmMain.Show()

            Else
                MsgBox("Incorrect login! Please verify your credentials and try again.")
            End If
        Else
            MsgBox("Incorrect login! Please verify your credentials and try again.")
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblLink1.Click, lblLink2.Click, lblLink3.Click
        Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=54920")
    End Sub

End Class