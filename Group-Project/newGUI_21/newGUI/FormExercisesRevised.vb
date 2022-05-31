Public Class frmExercisesRevised
    Dim user_ID As Integer = frmMain.user_ID
    Dim dtFavorites As DataTable
    Dim intArrayExerciseIDForComboBox() As Integer
    Dim intArrayFavoriteIDForListBox() As Integer
    Dim intArrayExerciseIDForListBox() As Integer
    Private Sub btnCreateNewExercise_Click(sender As Object, e As EventArgs) Handles btnCreateNewExercise.Click
        grpMain.Visible = False
        grpCreate.Visible = True
        grpManageFavorites.Visible = False
    End Sub

    Private Sub frmExercisesRevised_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateExerciseSearchComboBoxWithLocalDatabase()
        populateExerciseFavoritesListBox()
        AddHandler txtExerciseCalories.KeyPress, AddressOf onlyAllowDigits
        grpMain.Visible = True
        grpCreate.Visible = False
        grpManageFavorites.Visible = False
        txtExerciseCalories.Text = ""
        txtExerciseName.Text = ""
        cmbExercises.SelectedIndex = -1
        lstFavorites.SelectedIndex = -1
        chkExerciseAddToFavorites.Checked = True
        DataGridView1.Visible = False
        DataGridView2.Visible = False
    End Sub

    Private Sub btnManageFavorites_Click(sender As Object, e As EventArgs) Handles btnManageFavorites.Click
        grpMain.Visible = False
        grpCreate.Visible = False
        grpManageFavorites.Visible = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        backToMainGroupBoxAndReset()

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        backToMainGroupBoxAndReset()
    End Sub

    Private Sub backToMainGroupBoxAndReset()
        grpMain.Visible = True
        grpCreate.Visible = False
        grpManageFavorites.Visible = False
        txtExerciseCalories.Text = ""
        txtExerciseName.Text = ""
        cmbExercises.SelectedIndex = -1
        lstFavorites.SelectedIndex = -1
        chkExerciseAddToFavorites.Checked = True
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If validateCreateExerciseForm() Then
            'msgBox("valid form")
            'put entry into database
            Dim strSQL As String = "INSERT INTO exercises (exercise_description, calories_burned) " &
                "VALUES ('" &
                txtExerciseName.Text & "', " &
                txtExerciseCalories.Text &
                ");"
            'msgBox(strSQL)
            Dim dataInterface = New DatabaseControl
            dataInterface.runStatement(strSQL)
            populateExerciseSearchComboBoxWithLocalDatabase()

            If chkExerciseAddToFavorites.Checked = True Then
                Dim exercise_ID As Integer = frmMain.getLastExerciseIDInExerciseTable()
                addExerciseToFavorites(user_ID, exercise_ID)

                frmMain.populateMyExercises()
                populateExerciseFavoritesListBox()
            End If

            grpMain.Visible = True
            grpCreate.Visible = False
            grpManageFavorites.Visible = False
        Else
            'msgBox("invalid form")
        End If
    End Sub


    Public Sub addExerciseToFavorites(ByVal user_ID As Integer, exercise_ID As Integer)

        Dim strSQL As String = "INSERT INTO favorite_exercises (user_ID, exercise_ID) VALUES (" &
            user_ID.ToString & ", " &
            exercise_ID.ToString & ");"

        'msgBox(strSQL)
        Dim dataInterface = New DatabaseControl
        dataInterface.runStatement(strSQL)
    End Sub

    Private Sub btnDeleteFromFavorites_Click(sender As Object, e As EventArgs) Handles btnDeleteFromFavorites.Click
        If lstFavorites.SelectedIndex <> -1 Then
            Dim strSQL As String = "DELETE FROM favorite_exercises WHERE favorite_exercises_ID = " & intArrayFavoriteIDForListBox(lstFavorites.SelectedIndex)
            'msgBox(strSQL)
            Dim dataInterface = New DatabaseControl
            dataInterface.runStatement(strSQL)
            populateExerciseFavoritesListBox()
            frmMain.populateMyExercises()
        End If
    End Sub

    Public Function validateCreateExerciseForm() As Boolean
        If textBoxEmpty(txtExerciseName) Then
            MsgBox("Please put a name in for the exercise.")
            Return False
        End If
        If textBoxEmpty(txtExerciseCalories) Then
            MsgBox("Please enter an amount for calories.")
            Return False
        End If
        Return True
    End Function

    Public Function textBoxEmpty(ByRef someTextBox As TextBox) As Boolean
        If (someTextBox.Text = String.Empty) Or (someTextBox.Text = "") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub onlyAllowDigits(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'https://stackoverflow.com/questions/9969824/vb-net-need-text-box-to-only-accept-numbers
        'https://stackoverflow.com/users/1077789/isuru
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Public Sub populateExerciseSearchComboBoxWithLocalDatabase()
        cmbExercises.Items.Clear()
        Dim dtExercises As DataTable = frmMain.getExercisesDataTable()
        ReDim intArrayExerciseIDForComboBox(dtExercises.Rows().Count)
        ''DataGridView1.Visible = True
        'DataGridView1.DataSource = dtExercises
        Dim strExerciseName As String
        Dim intExerciseCalories As Integer
        For i As Integer = 0 To dtExercises.Rows().Count - 1
            intArrayExerciseIDForComboBox(i) = dtExercises.Rows(i).Item("exercise_ID")
            strExerciseName = dtExercises.Rows(i).Item("Exercise_description")
            intExerciseCalories = dtExercises.Rows(i).Item("calories_burned")
            strExerciseName = If(strExerciseName.Length > 40, strExerciseName.Substring(0, 40), strExerciseName.Substring(0, strExerciseName.Length))
            cmbExercises.Items.Add(strExerciseName & " (" & intExerciseCalories.ToString() & " Cal)")
        Next
    End Sub

    Public Sub populateExerciseFavoritesListBox()
        lstFavorites.Items.Clear()
        user_ID = frmMain.user_ID
        dtFavorites = frmMain.getDataTableForFavoriteExercisesComboBox(user_ID)
        ReDim intArrayFavoriteIDForListBox(dtFavorites.Rows().Count)
        ReDim intArrayExerciseIDForListBox(dtFavorites.Rows().Count)

        Dim tempExerciseID As Integer
        Dim tempCMBNameAtIndex As String
        Dim tempIndex As Integer
        For i As Integer = 0 To dtFavorites.Rows().Count - 1
            intArrayExerciseIDForListBox(i) = dtFavorites.Rows(i).Item("exercises.exercise_ID")
            intArrayFavoriteIDForListBox(i) = dtFavorites.Rows(i).Item("favorite_exercises_ID")

            tempExerciseID = dtFavorites.Rows(i).Item("exercises.exercise_ID")

            tempIndex = Array.IndexOf(intArrayExerciseIDForComboBox, tempExerciseID)
            'Console.WriteLine(tempIndex)

            tempCMBNameAtIndex = cmbExercises.Items(tempIndex)

            lstFavorites.Items.Add(tempCMBNameAtIndex)

        Next
    End Sub

    Private Sub btnAddToFavorites_Click(sender As Object, e As EventArgs) Handles btnAddToFavorites.Click
        'msgBox(cmbExercises.SelectedIndex.ToString())
        If cmbExercises.SelectedIndex <> -1 Then

            Dim exercise_ID As Integer = intArrayExerciseIDForComboBox(cmbExercises.SelectedIndex)

            'msgBox(exercise_ID.ToString())

            'intArrayFoodIDForComboBoxFavorite.Contains(food_ID)
            If intArrayExerciseIDForListBox.Contains(exercise_ID) Then
                MsgBox("Already a favorite:)")
            Else
                'msgBox("not a favorite!, can add")
                addExerciseToFavorites(user_ID, exercise_ID)
                frmMain.populateMyExercises()
                populateExerciseFavoritesListBox()
                cmbExercises.SelectedIndex = -1

            End If

        End If

    End Sub


End Class