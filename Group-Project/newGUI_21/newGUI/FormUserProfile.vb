Public Class frmUserProfile
    Public Shared user_ID As Integer
    Dim userManager As New UserManagement
    Dim thisUser = userManager.lookupUserByID(user_ID) ' this is a user
    Private Sub frmUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = frmMain.desiredChangeTable

        'MsgBox(getBestDesiredWeightChangeByDate2(1, Now().AddDays(-5)).ToString())

        'ensures something is checked
        cmbActivityLevel.SelectedIndex = 0
        cmbDesiredWeightChange.SelectedIndex = 3
        btnFemale.Checked = True
        lblUserID.Text = user_ID
        txtUserName.Text = thisUser.username
        'maskedTxtPass.Text = thisUser.password
        txtFName.Text = thisUser.firstName
        txtLName.Text = thisUser.lastName
        txtEMail.Text = thisUser.email

        'limit heights, ensure something is present
        If thisUser.height < 12 Then
            numHeight.Value = 12
        ElseIf thisUser.height > 96 Then
            numHeight.Value = 96
        Else numHeight.Value = thisUser.height
        End If
        'set Age based on bday
        'txtAge.Text = intCalculateAge(dateBDay.Value).ToString()

        numWeight.Value = getBestWeightByDate2(user_ID, Now())

        Dim intTempIndex As Integer = 0

        Dim dblBestActivityLevel As Double = getBestPhysicalActivityFactorByDate2(user_ID, Now())
        intTempIndex = getComputedComboBoxPhysicalActivityIndex(dblBestActivityLevel)
        cmbActivityLevel.SelectedIndex = intTempIndex

        Dim dblBestDesiredWeightChange As Double = getBestDesiredWeightChangeByDate2(user_ID, Now())
        intTempIndex = getComputedComboBoxWeeklyWeightChangeIndex(dblBestDesiredWeightChange)
        cmbDesiredWeightChange.SelectedIndex = intTempIndex

        'limit age, ensure something is present
        If thisUser.dob < Now().AddYears(-120) Then
            dateBDay.Value = Now.AddYears(-120)
        Else
            dateBDay.Value = thisUser.dob
        End If

        'set Age based on bday
        txtAge.Text = intCalculateAge(dateBDay.Value).ToString()

        'ensure something checked
        If thisUser.sex = "female" Then
            btnFemale.Checked = True
        Else
            btnMale.Checked = True
        End If

        showTargetCalories()
        'getBestWeightByDate(1, Now().AddDays(0))
        'getBestDesiredWeightChangeByDate(1, Now().AddDays(0))
        'getBestPhysicalActivityFactorByDate(1, Now().AddDays(0))
    End Sub

    Public Function getComputedComboBoxPhysicalActivityIndex(ByVal dblActivityLevel As Double) As Integer
        Dim dblDelta As Double
        Dim bestIndex As Integer
        Dim dblMinDistance As Double

        'whichever value in the combobox is closest determines where to set the combobox

        dblDelta = Math.Abs(dblActivityLevel - 1.2)
        dblMinDistance = dblDelta
        bestIndex = 0

        dblDelta = Math.Abs(dblActivityLevel - 1.4)
        If dblDelta <= dblMinDistance Then
            dblMinDistance = dblDelta
            bestIndex = 1
        End If

        dblDelta = Math.Abs(dblActivityLevel - 1.6)
        If dblDelta <= dblMinDistance Then
            dblMinDistance = dblDelta
            bestIndex = 2
        End If

        'cmbActivityLevel.SelectedIndex = bestIndex

        Return bestIndex

    End Function


    Public Function getComputedComboBoxWeeklyWeightChangeIndex(ByVal dblDesiredWeeklyWeightChange As Double) As Integer
        Dim dblDelta As Double
        Dim bestIndex As Integer
        Dim dblMinDistance As Double

        'whichever value in the combobox is closest determines where to set the combobox

        dblDelta = Math.Abs(dblDesiredWeeklyWeightChange - (-2.0))
        dblMinDistance = dblDelta
        bestIndex = 0

        dblDelta = Math.Abs(dblDesiredWeeklyWeightChange - (-1.0))
        If dblDelta <= dblMinDistance Then
            dblMinDistance = dblDelta
            bestIndex = 1
        End If

        dblDelta = Math.Abs(dblDesiredWeeklyWeightChange - (-0.5))
        If dblDelta <= dblMinDistance Then
            dblMinDistance = dblDelta
            bestIndex = 2
        End If

        dblDelta = Math.Abs(dblDesiredWeeklyWeightChange - 0.0)
        If dblDelta <= dblMinDistance Then
            dblMinDistance = dblDelta
            bestIndex = 3
        End If

        dblDelta = Math.Abs(dblDesiredWeeklyWeightChange - 0.5)
        If dblDelta <= dblMinDistance Then
            dblMinDistance = dblDelta
            bestIndex = 4
        End If

        dblDelta = Math.Abs(dblDesiredWeeklyWeightChange - 1.0)
        If dblDelta <= dblMinDistance Then
            dblMinDistance = dblDelta
            bestIndex = 5
        End If

        dblDelta = Math.Abs(dblDesiredWeeklyWeightChange - 2.0)
        If dblDelta <= dblMinDistance Then
            dblMinDistance = dblDelta
            bestIndex = 6
        End If

        cmbDesiredWeightChange.SelectedIndex = bestIndex

        Return bestIndex

    End Function




    Public Function getGender()
        If btnFemale.Checked = True Then
            Return "female"
        Else
            Return "male"
        End If
    End Function
    Public Function intCalculateAge(ByVal birthDate As DateTime) As Integer
        'subtract this year from date of birth year and take note of that number estimatedDate
        'add that number to their birthdate and call that testDate
        'if testDate is greater than now, then add 1 to estimatedDate to get age

        Dim estimatedAge As Integer = Year(Now) - Year(birthDate)
        Dim testDate As DateTime = birthDate.AddYears(estimatedAge)

        If testDate >= Now Then

            estimatedAge = estimatedAge + 1

        Else
            estimatedAge = estimatedAge
        End If

        'MsgBox(estimatedAge.ToString())
        Return estimatedAge
    End Function

    Private Sub dateBDay_ValueChanged(sender As Object, e As EventArgs) Handles dateBDay.ValueChanged
        'show age after birthday entered
        txtAge.Text = intCalculateAge(dateBDay.Value).ToString()
        showTargetCalories()
    End Sub

    Public Function checkPassword(ByVal user_ID As Integer, ByVal strPassword As String) As Boolean
        Dim userManager As New UserManagement
        Dim thisUser = userManager.lookupUserByID(user_ID) ' this is a user
        If strPassword = thisUser.password Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub chkChangePassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkChangePassword.CheckedChanged
        'enable new password boxes if checked
        If chkChangePassword.Checked = True Then
            Me.maskedTxtNewPassword.Enabled = True
            maskedTxtRepeatPassword.Enabled = True
        Else
            Me.maskedTxtNewPassword.Text = ""
            Me.maskedTxtNewPassword.Enabled = False
            maskedTxtRepeatPassword.Text = ""
            maskedTxtRepeatPassword.Enabled = False
        End If
    End Sub

    Public Function validateUpdateForm(Optional ByVal bolQuiet As Boolean = False) As Boolean
        'Optional ByVal office As String = "QJZ"
        'validates that form is filled out correctly, should be elseifs intend to change
        If checkPassword(user_ID, maskedTxtCurrentPassword.Text) = False Then
            If Not bolQuiet Then MsgBox("Pasword is incorrect.")
            Return False
        End If
        If chkChangePassword.Checked = True Then
            If newPasswordsMatch() = False Then
                If Not bolQuiet Then MsgBox("New passwords do not match.")
                Return False
            End If
            If newPasswordsLongEnough(8) = False Then
                If Not bolQuiet Then MsgBox("Password must be 8 characters or more.")
                Return False
            End If
        End If
        If firstNameFilledOut() = False Then
            If Not bolQuiet Then MsgBox("Please fill in your first name")
            Return False
        End If
        Return True
    End Function

    Public Function newPasswordsMatch() As Boolean
        Return (maskedTxtNewPassword.Text = maskedTxtRepeatPassword.Text)
    End Function

    Public Function newPasswordsLongEnough(ByVal intMinLength As Integer) As Boolean
        Return maskedTxtNewPassword.Text.Length >= intMinLength
    End Function

    Public Function firstNameFilledOut()
        If (txtFName.Text = String.Empty) Or (txtFName.Text = "") Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function textBoxNotEmpty(ByRef someTextBox) As Boolean 'will consolidate these 2 functions
        If (someTextBox.Text = String.Empty) Or (someTextBox.Text = "") Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If validateUpdateForm() = True Then
            'MsgBox("Form has been validated.")
            thisUser.username = txtUserName.Text
            If chkChangePassword.Checked = True Then
                thisUser.password = maskedTxtNewPassword.Text
            Else
                thisUser.password = maskedTxtCurrentPassword.Text
            End If
            thisUser.email = txtEMail.Text
            thisUser.firstName = txtFName.Text
            thisUser.lastName = txtLName.Text
            thisUser.dob = dateBDay.Value
            If btnMale.Checked = True Then
                thisUser.sex = "male"
            Else
                thisUser.sex = "female"
            End If
            thisUser.height = numHeight.Value
            MsgBox("Updated user information.")
            userManager.updateUser(thisUser) ' 'static' user data updated
            frmMain.refreshStaticUserBioData()

            '''''''''''''''''''''''''''''''''
            ''''
            '''' This section needs to
            ''''
            '''' 1) update user related info (done)
            ''''
            '''' 2) enter a weight into the weight table (not done)
            ''''
            '''' 3) enter a user activity level into the activity_level table (attempted not working)
            ''''
            '''' 4) enter a user calorie goal into the goal_calories table (not done)


            ''''''''''''''''''''''''''''''''
            ''' not currently working will need to address
            ''''''''''''''''''''''''''''
            '          Dim mySQL As String = "INSERT INTO activity_level (user_ID, activity_level_datetime, level) VALUES (" &
            '          user_ID.ToString() & ", " &
            '          "#" & Now().ToString() & "#, " &
            '          cmbActivityLevel.SelectedIndex.ToString() & ");"
            '
            '            MsgBox(mySQL)'

            '            Dim dataControl = New DatabaseControl
            '            dataControl.runStatement(mySQL)

            '''''''''''''''''''''''''''''


            ''''''''''''''''''''''''''

            Dim dblPhysicalActivityFactor As Double = getPhysicalActivityFactor(cmbActivityLevel.SelectedIndex)
            Dim dblDesiredWeeklyChange As Double = getDesiredWeeklyChange(cmbDesiredWeightChange.SelectedIndex)

            insertActivityLevel(user_ID, Now(), dblPhysicalActivityFactor)
            frmMain.fillActivityLevelsDateTable()
            insertDesiredWeeklyChange(user_ID, Now(), dblDesiredWeeklyChange)
            frmMain.fillDesiredChangeDataTable()

            Dim weightManager As New weightManagement
            Dim thisWeight As New weightManagement.weightObject

            thisWeight.userId = user_ID
            thisWeight.weightDate = Now()
            thisWeight.weight = CDbl(numWeight.Value)
            'MsgBox(thisWeight.ToString())

            weightManager.createWeight(thisWeight)

            frmMain.fillWeightsDataTable()



            'Dim goalCalories As Integer = calculateGoalCalories(thisUser.sex, CInt(txtAge.Text), numWeight.Value, thisUser.height, dblPhysicalActivityFactor, dblDesiredWeeklyChange)

            'MsgBox("target calories " & goalCalories.ToString())

            If Now().Date <= frmMain.dtpStartDate.Value.AddDays(7).Date Then
                frmMain.populateCalorieGoalsForTheWeek()
                frmMain.populateCalorieBalanceForTheWeek()
                frmMain.updatePrintCalendarTotalRowsForTheWeek()
            End If

            frmMain.changeActivityLevelLabel()
            frmMain.changeDesiredWeightLossLabel()

            Me.Close()
            End If

    End Sub

    Public Function getBestWeightByDate(ByVal user_ID As Integer, ByVal thisDate As DateTime) As Double

        'MsgBox(thisDate.Date.AddDays(1).ToString())

        Dim dblBestWeight As Double = 150.0

        'look back from before thisDate at at 11:59:59 pm and earlier, (all datetimes on this date and earlier)
        'if there is a time, pick the latest and return that
        Dim strSQL As String = "SELECT weight.weight, weight.weight_entry_datetime FROM weight WHERE user_ID =" & user_ID.ToString() & " AND weight_entry_datetime < " &
                   "#" & thisDate.Date.AddDays(1) & "# ORDER BY weight.weight_entry_datetime DESC"

        Dim weightTable As DataTable = frmMain.getDataTableFromSQLSELECTQuery(strSQL)
        'DataGridView1.DataSource = weightTable
        If weightTable.Rows().Count() > 0 Then
            dblBestWeight = weightTable.Rows(0).Item("weight")
            'MsgBox("weight before date equals " & dblBestWeight)
            Return dblBestWeight
        End If

        strSQL = "SELECT weight.weight, weight.weight_entry_datetime FROM weight WHERE user_ID =" & user_ID.ToString() & " AND weight_entry_datetime >= " &
                   "#" & thisDate.Date.AddDays(1) & "# ORDER BY weight.weight_entry_datetime ASC"

        weightTable = frmMain.getDataTableFromSQLSELECTQuery(strSQL)
        'DataGridView1.DataSource = weightTable
        If weightTable.Rows().Count() > 0 Then
            dblBestWeight = weightTable.Rows(0).Item("weight")
            'MsgBox("weight after date equals" & dblBestWeight)
            Return dblBestWeight
        End If

        Return dblBestWeight

        'check to see if there are weights before this date order by desc
        'if table length >0 return first one

        'check to see if there are weights after this date
        'if table length >0 return first one

        'return 150pounds

    End Function

    Public Function getBestWeightByDate2(ByVal user_ID As Integer, ByVal thisDateTime As DateTime) As Double
        Dim weights As DataTable = frmMain.weightsTable
        Dim rowCount As Integer = weights.Rows().Count()
        Dim thisDate As DateTime = thisDateTime.Date
        Dim thisWeight As Double = 150 ' default if no weights found

        If weights.Rows().Count() > 0 Then
            If thisDate < (weights.Rows(0).Item("weight_entry_datetime")).Date Then
                thisWeight = weights.Rows(0).Item("weight")
                Return thisWeight
            End If

            If thisDate >= (weights.Rows(rowCount - 1).Item("weight_entry_datetime")).Date Then
                thisWeight = weights.Rows(rowCount - 1).Item("weight")
                Return thisWeight
            End If

            For i As Integer = 0 To rowCount - 1
                If thisDate >= weights.Rows(i).Item("weight_entry_datetime").Date Then
                    thisWeight = weights.Rows(i).Item("weight")
                End If
            Next
        End If

        Return thisWeight
    End Function


    Public Function getBestPhysicalActivityFactorByDate(ByVal user_ID As Integer, ByVal thisDate As DateTime) As Double

        'MsgBox(thisDate.Date.AddDays(1).ToString())

        Dim dblPhysicalActivityFactor As Double = 1.2

        Dim strSQL As String = "SELECT activity_level.activity_level, activity_level.activity_entry_datetime FROM activity_level WHERE user_ID =" & user_ID.ToString() & " AND activity_entry_datetime < " &
                   "#" & thisDate.Date.AddDays(1) & "# ORDER BY activity_level.activity_entry_datetime DESC"

        Dim physicalActivityFactorTable As DataTable = frmMain.getDataTableFromSQLSELECTQuery(strSQL)
        'DataGridView1.DataSource = physicalActivityFactorTable
        If physicalActivityFactorTable.Rows().Count() > 0 Then
            dblPhysicalActivityFactor = physicalActivityFactorTable.Rows(0).Item("activity_level")
            'MsgBox("physical activity factor before date equals " & dblPhysicalActivityFactor)
            Return dblPhysicalActivityFactor
        End If

        strSQL = "SELECT activity_level.activity_level, activity_level.activity_entry_datetime FROM activity_level WHERE user_ID =" & user_ID.ToString() & " AND activity_entry_datetime >= " &
        "#" & thisDate.Date.AddDays(1) & "# ORDER BY activity_level.activity_entry_datetime ASC"

        physicalActivityFactorTable = frmMain.getDataTableFromSQLSELECTQuery(strSQL)
        'DataGridView1.DataSource = physicalActivityFactorTable
        If physicalActivityFactorTable.Rows().Count() > 0 Then
            dblPhysicalActivityFactor = physicalActivityFactorTable.Rows(0).Item("activity_level")
            'MsgBox("physical activity factor after date equals " & dblPhysicalActivityFactor)
            Return dblPhysicalActivityFactor
        End If

        If dblPhysicalActivityFactor < 1.2 Then dblPhysicalActivityFactor = 1.2
        If dblPhysicalActivityFactor > 1.6 Then dblPhysicalActivityFactor = 1.6

        Return dblPhysicalActivityFactor

    End Function

    Public Function getBestPhysicalActivityFactorByDate2(ByVal user_ID As Integer, ByVal thisDateTime As DateTime) As Double
        Dim activities As DataTable = frmMain.activityTable
        Dim rowCount As Integer = activities.Rows().Count()
        Dim thisDate As DateTime = thisDateTime.Date
        Dim thisActivityFactor As Double = 1.2 ' default if no weights found
        ' Dim temprow As Integer = 0
        If activities.Rows().Count() > 0 Then
            If thisDate < (activities.Rows(0).Item("activity_entry_datetime")).Date Then
                thisActivityFactor = activities.Rows(0).Item("activity_level")
                ' MsgBox("row is 0 activity level is " & thisActivityFactor.ToString())
                Return thisActivityFactor
            End If

            If thisDate >= (activities.Rows(rowCount - 1).Item("activity_entry_datetime")).Date Then
                thisActivityFactor = activities.Rows(rowCount - 1).Item("activity_level")
                ' MsgBox("row is" & (rowCount - 1).ToString() & " activity level is " & thisActivityFactor.ToString())
                Return thisActivityFactor
            End If

            For i As Integer = 0 To rowCount - 1
                If thisDate >= activities.Rows(i).Item("activity_entry_datetime").Date Then
                    thisActivityFactor = activities.Rows(i).Item("activity_level")
                    '    temprow = i
                End If
            Next
        End If
        ' MsgBox("row is" & temprow.ToString() & " activity level is " & thisActivityFactor.ToString())
        Return thisActivityFactor
    End Function

    Public Function getBestDesiredWeightChangeByDate(ByVal user_ID As Integer, ByVal thisDate As DateTime) As Double

        'MsgBox(thisDate.Date.AddDays(1).ToString())

        Dim dblDesiredWeeklyWeightChange As Double = 0.0

        Dim strSQL As String = "SELECT desired_weight_change.desired_weekly_change, desired_weight_change.desired_change_datetime FROM desired_weight_change WHERE user_ID =" & user_ID.ToString() & " AND desired_change_datetime < " &
                   "#" & thisDate.Date.AddDays(1) & "# ORDER BY desired_weight_change.desired_change_datetime DESC"

        Dim desiredWeightChangeTable As DataTable = frmMain.getDataTableFromSQLSELECTQuery(strSQL)
        'DataGridView1.DataSource = desiredWeightChangeTable
        If desiredWeightChangeTable.Rows().Count() > 0 Then
            dblDesiredWeeklyWeightChange = desiredWeightChangeTable.Rows(0).Item("desired_weekly_change")
            'MsgBox("desired weekly change before date equals " & dblDesiredWeeklyWeightChange)
            Return dblDesiredWeeklyWeightChange
        End If

        strSQL = "SELECT desired_weight_change.desired_weekly_change, desired_weight_change.desired_change_datetime FROM desired_weight_change WHERE user_ID =" & user_ID.ToString() & " AND desired_change_datetime >= " &
                   "#" & thisDate.Date.AddDays(1) & "# ORDER BY desired_weight_change.desired_change_datetime ASC"

        desiredWeightChangeTable = frmMain.getDataTableFromSQLSELECTQuery(strSQL)
        'DataGridView1.DataSource = desiredWeightChangeTable
        If desiredWeightChangeTable.Rows().Count() > 0 Then
            dblDesiredWeeklyWeightChange = desiredWeightChangeTable.Rows(0).Item("desired_weekly_change")
            'MsgBox("desired weekly change after date equals" & dblDesiredWeeklyWeightChange)
            Return dblDesiredWeeklyWeightChange
        End If

        If dblDesiredWeeklyWeightChange < -2.0 Then dblDesiredWeeklyWeightChange = -2.0
        If dblDesiredWeeklyWeightChange > 2.0 Then dblDesiredWeeklyWeightChange = 2.0

        Return dblDesiredWeeklyWeightChange

    End Function

    Public Function getBestDesiredWeightChangeByDate2(ByVal user_ID As Integer, ByVal thisDateTime As DateTime) As Double
        Dim desiredChange As DataTable = frmMain.desiredChangeTable
        Dim rowCount As Integer = desiredChange.Rows().Count()
        Dim thisDate As DateTime = thisDateTime.Date
        Dim thisChange As Double = 0.0 ' default if no weight change found
        Dim inttemprow As Integer = 0

        'MsgBox(thisDateTime)
        'MsgBox(thisDate)

        If desiredChange.Rows().Count() > 0 Then
            If thisDate < (desiredChange.Rows(0).Item("desired_change_datetime")).Date Then
                thisChange = desiredChange.Rows(0).Item("desired_weekly_change")
                'MsgBox("before")
                'MsgBox(thisChange.ToString())
                Return thisChange
            End If

            If thisDate >= (desiredChange.Rows(rowCount - 1).Item("desired_change_datetime")).Date Then
                thisChange = desiredChange.Rows(rowCount - 1).Item("desired_weekly_change")
                'MsgBox("after")
                'MsgBox(thisChange.ToString())
                Return thisChange
            End If

            For i As Integer = 0 To rowCount - 1
                'MsgBox(thisDate.ToString() & "compared to" & desiredChange.Rows(i).Item("desired_change_datetime").Date.ToString())

                If thisDate >= desiredChange.Rows(i).Item("desired_change_datetime").Date Then

                    thisChange = desiredChange.Rows(i).Item("desired_weekly_change")
                    'MsgBox("greater than or equal setting thisChange to " & thisChange.ToString())
                    inttemprow = i
                End If
            Next
        End If

        'MsgBox("final decision is that " & thisDate.ToString() & " is at row" & inttemprow.ToString() & "with this value " & thisChange.ToString())
        Return thisChange
    End Function

    Public Sub insertActivityLevel(ByVal user_ID As Integer, ByVal thisDateTime As DateTime, ByVal dblPhysicalActivityFactor As Double)
        Dim strSQL As String = "INSERT INTO activity_level (user_ID, activity_entry_datetime, activity_level) VALUES (" &
          user_ID.ToString() & "," &
      "#" & thisDateTime.ToString() & "#," &
          dblPhysicalActivityFactor.ToString() & ");"
        'MsgBox(strSQL)
        frmMain.insertIntoTable(strSQL)
    End Sub

    Public Sub insertDesiredWeeklyChange(ByVal user_ID As Integer, ByVal thisDateTime As DateTime, ByVal dblDesiredWeeklyChange As Double)
        Dim strSQL As String = "INSERT INTO desired_weight_change (user_ID, desired_change_datetime, desired_weekly_change) VALUES (" &
          user_ID.ToString() & "," &
      "#" & thisDateTime.ToString() & "#," &
          dblDesiredWeeklyChange.ToString() & ");"
        'MsgBox(strSQL)
        frmMain.insertIntoTable(strSQL)
    End Sub


    Public Function getPhysicalActivityFactor(ByVal intLevel As Integer) As Double
        Dim dblPhysicalActivityFactor As Double = 1.2
        If intLevel = 0 Then
            dblPhysicalActivityFactor = 1.2
        ElseIf intLevel = 1 Then
            dblPhysicalActivityFactor = 1.4
        ElseIf intLevel = 2 Then
            dblPhysicalActivityFactor = 1.6
        Else
            dblPhysicalActivityFactor = 1.2 'shouldn't get to here, but just in case
        End If
        'MsgBox("acivity factor" & dblPhysicalActivityFactor)
        Return dblPhysicalActivityFactor
    End Function


    Public Function getDesiredWeeklyChange(ByVal intCmbSelection As Integer) As Double
        If intCmbSelection = 0 Then
            Return -2.0
        ElseIf intCmbSelection = 1 Then
            Return -1.0
        ElseIf intCmbSelection = 2 Then
            Return -0.5
        ElseIf intCmbSelection = 3 Then
            Return 0
        ElseIf intCmbSelection = 4 Then
            Return 0.5
        ElseIf intCmbSelection = 5 Then
            Return 1.0
        ElseIf intCmbSelection = 6 Then
            Return 2.0
        Else
            Return 0.0 'shouldn't get to here, but just in case
        End If
    End Function





    Public Function calculateGoalCalories(ByVal strGender As String, ByVal intAge As Integer, ByVal dblWeight As Double, ByVal dblHeight As Double, ByVal dblPhysicalActivityFactor As Double, ByVal dblDesiredWeeklyWeightChange As Double) As Integer
        Dim dblBMR As Double
        If strGender = "female" Then
            dblBMR = 655.0 + (4.35 * dblWeight) + (4.7 * dblHeight) - (4.7 * intAge)
            'Return CInt(dblResult)

        Else
            dblBMR = 66.0 + (6.23 * dblWeight) + (12.7 * dblHeight) - (6.8 * intAge)
            'Return CInt(dblResult)

        End If

        dblBMR = dblBMR * dblPhysicalActivityFactor

        Dim dblWeeklyCalorieRequirement As Double = 7 * dblBMR
        Dim calorieDeficitOrExcess As Double = 3500 * dblDesiredWeeklyWeightChange

        dblWeeklyCalorieRequirement = dblWeeklyCalorieRequirement + calorieDeficitOrExcess

        Return CInt(dblWeeklyCalorieRequirement / 7.0)


        'https://www.omnicalculator.com/health/bmr-harris-benedict-equation

        'Notes:
        '
        'Harris-Benedict Formula: This formula Is commonly used by nutritionists.
        'It takes age, gender, body weight, body height And your level of physical activities into account.
        'The formula used to calculate men's calorie needs is = 66.5 + 13.8 x (body weight in kilograms) + 5 x (body height in cm) divided by 6.8 x age.
        'Meanwhile for women it is 655.1 + 9.6 x (body weight in kilograms) + 1.9 x (body height in cm) divided by 4.7 x age.
        'The result of the equation must be multiplied with your physical activity factor.
        'If you have low physical activity, then multiply by 1.2.
        'If you participate in average physical activity then multiply by 1.3.
        'For people who do heavy physical activities, multiply by 1.4.
        'thejakartapost.com/ life / 2016 / 9 / 27 / how -to-calculate-your-ideal-calorie-intake.html

        'pounds instead of kg ->

        'female
        '655 + (4.35 × weight in pounds) + (4.7 × height in inches) − (4.7 × age in years)

        'male
        '66 + (6.23 × weight in pounds) + (12.7 × height in inches) − (6.8 × age in years)


        'https://www.medicinenet.com/what_is_the_formula_to_calculate_bmr/article.htm

    End Function

    Public Sub showTargetCalories()
        If txtAge.Text <> "" Then
            txtBoxTargetCalories.Text = calculateGoalCalories(getGender(), CInt(txtAge.Text), CDbl(numWeight.Value), CDbl(numHeight.Value), getPhysicalActivityFactor(cmbActivityLevel.SelectedIndex), getDesiredWeeklyChange(cmbDesiredWeightChange.SelectedIndex))
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub numHeight_ValueChanged(sender As Object, e As EventArgs) Handles numHeight.ValueChanged
        showTargetCalories()
    End Sub

    Private Sub numWeight_ValueChanged(sender As Object, e As EventArgs) Handles numWeight.ValueChanged
        showTargetCalories()
    End Sub

    Private Sub btnMale_CheckedChanged(sender As Object, e As EventArgs) Handles btnMale.CheckedChanged
        showTargetCalories()
    End Sub

    Private Sub btnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles btnFemale.CheckedChanged
        showTargetCalories()
    End Sub

    Private Sub cmbActivityLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbActivityLevel.SelectedIndexChanged
        showTargetCalories()
    End Sub

    Private Sub cmbDesiredWeightChange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDesiredWeightChange.SelectedIndexChanged
        showTargetCalories()
    End Sub
End Class

