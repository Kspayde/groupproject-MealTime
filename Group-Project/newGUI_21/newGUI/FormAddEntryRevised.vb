Public Class frmAddEntryRevised

    Dim user_ID As Integer
    Dim dtFoods As DataTable
    Dim dtFavorites As DataTable
    Dim intArrayFoodIDForComboBoxLocal() As Integer
    Dim intArrayFoodIDForComboBoxFavorite() As Integer
    Dim intArrayFavoriteIDForComboBoxFavorite() As Integer
    Dim intAddButtonIndex As Integer
    Dim bolUsingLocalDatabase As Boolean = False
    Dim bolUsingFavorites As Boolean = False
    Dim bolUsingCreate As Boolean = False
    Dim collectionForEdit As New Collection
    Dim intLastFoodID As Integer = 0

    Private Sub _frmAddEntryRevised_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmAddEntryRevised_Load()
    End Sub

    Public Sub frmAddEntryRevised_Load()
        grpFavorites.Visible = False
        'collectionForEdit.Add(btnEdit)
        collectionForEdit.Add(txtFoodName)
        collectionForEdit.Add(txtFoodCalories)
        collectionForEdit.Add(txtServingSizeAmount)
        collectionForEdit.Add(txtServingSizeUnit)
        collectionForEdit.Add(txtProtein)
        collectionForEdit.Add(txtTotalFat)
        collectionForEdit.Add(txtCarbohydrates)
        collectionForEdit.Add(txtSugars)
        collectionForEdit.Add(txtSaturatedFat)
        collectionForEdit.Add(txtTransFat)
        collectionForEdit.Add(txtDietaryFiber)
        collectionForEdit.Add(txtSodium)
        collectionForEdit.Add(txtCholesterol)

        'collectionForEdit.Add(btnUpdate)
        AddHandler txtServingSizeAmount.KeyPress, AddressOf onlyAllowDigits
        AddHandler txtFoodCalories.KeyPress, AddressOf onlyAllowDigits
        AddHandler txtProtein.KeyPress, AddressOf onlyAllowDigits
        AddHandler txtTotalFat.KeyPress, AddressOf onlyAllowDigits
        AddHandler txtCarbohydrates.KeyPress, AddressOf onlyAllowDigits
        AddHandler txtSugars.KeyPress, AddressOf onlyAllowDigits
        AddHandler txtSaturatedFat.KeyPress, AddressOf onlyAllowDigits
        AddHandler txtTransFat.KeyPress, AddressOf onlyAllowDigits
        AddHandler txtDietaryFiber.KeyPress, AddressOf onlyAllowDigits
        AddHandler txtSodium.KeyPress, AddressOf onlyAllowDigits
        AddHandler txtCholesterol.KeyPress, AddressOf onlyAllowDigits

        populateFoodSearchComboBoxWithLocalDatabase()
        populateFavoritesComboBox()
        Me.ActiveControl = DataGridView1
    End Sub

    Public Sub populateFoodSearchComboBoxWithLocalDatabase()
        cmbSearchLocalFoods.Items.Clear()
        user_ID = frmMain.user_ID
        dtFoods = frmMain.getFoodsDataTableAlphabetical()
        ReDim intArrayFoodIDForComboBoxLocal(dtFoods.Rows().Count)
        'DataGridView1.DataSource = dtFoods
        Dim strFoodName As String
        Dim intFoodCalories As Integer
        For i As Integer = 0 To dtFoods.Rows().Count - 1
            intArrayFoodIDForComboBoxLocal(i) = dtFoods.Rows(i).Item("food_ID")
            strFoodName = dtFoods.Rows(i).Item("food")
            intFoodCalories = dtFoods.Rows(i).Item("food_calories")
            strFoodName = If(strFoodName.Length > 14, strFoodName.Substring(0, 14), strFoodName.Substring(0, strFoodName.Length))
            cmbSearchLocalFoods.Items.Add(strFoodName & " (" & intFoodCalories.ToString() & " Cal)")
        Next
    End Sub

    Public Sub populateFavoritesComboBox()
        cmbSearchFavoriteFoods.Items.Clear()
        user_ID = frmMain.user_ID
        dtFavorites = frmMain.getDataTableForFavoritesComboBoxAlphabetical(user_ID)
        ReDim intArrayFoodIDForComboBoxFavorite(dtFavorites.Rows().Count)
        ReDim intArrayFavoriteIDForComboBoxFavorite(dtFavorites.Rows().Count)
        DataGridView1.DataSource = dtFavorites
        'DataGridView1.Visible = True
        Dim strFoodName As String
        Dim intFoodCalories As Integer

        For i As Integer = 0 To dtFavorites.Rows().Count - 1
            intArrayFoodIDForComboBoxFavorite(i) = dtFavorites.Rows(i).Item("food_ID")
            intArrayFavoriteIDForComboBoxFavorite(i) = dtFavorites.Rows(i).Item("favorites_ID")
            strFoodName = dtFavorites.Rows(i).Item("food")
            intFoodCalories = dtFavorites.Rows(i).Item("food_calories")
            strFoodName = If(strFoodName.Length > 14, strFoodName.Substring(0, 14), strFoodName.Substring(0, strFoodName.Length))
            cmbSearchFavoriteFoods.Items.Add(strFoodName & " (" & intFoodCalories.ToString() & " Cal)")
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub _cmbSearchFavoriteFoods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchFavoriteFoods.SelectedIndexChanged
        cmbSearchFavoriteFoods_SelectedIndexChanged()
    End Sub
    Public Sub cmbSearchFavoriteFoods_SelectedIndexChanged()
        'https://stackoverflow.com/questions/20649164/vb-net-combobox-autocomplete/20659538
        'https://stackoverflow.com/users/2118383/vignesh-kumar-a
        bolUsingLocalDatabase = False
        bolUsingFavorites = True
        bolUsingCreate = False
        'cmbSearchLocalFoods.SelectedIndex = -1
        If cmbSearchFavoriteFoods.SelectedIndex <> -1 Then

            Dim thisRow = dtFavorites.Rows(cmbSearchFavoriteFoods.SelectedIndex)

            txtFoodName.Text = thisRow.Item("food")
            Dim intCalories As Integer = thisRow.Item("food_calories")
            txtFoodCalories.Text = intCalories.ToString()

            'need 
            If Not (System.Convert.IsDBNull(thisRow.Item("serving_size_amount"))) Then
                txtServingSizeAmount.Text = thisRow.Item("serving_size_amount").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("serving_size_unit"))) Then
                txtServingSizeUnit.Text = thisRow.Item("serving_size_unit")
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("protein"))) Then
                txtProtein.Text = thisRow.Item("protein").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("total_fat"))) Then
                txtTotalFat.Text = thisRow.Item("total_fat").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("total_carbohydrates"))) Then
                txtCarbohydrates.Text = thisRow.Item("total_carbohydrates").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("total_sugars"))) Then
                txtSugars.Text = thisRow.Item("total_sugars").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("saturated_fat"))) Then
                txtSaturatedFat.Text = thisRow.Item("saturated_fat").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("trans_fat"))) Then
                txtTransFat.Text = thisRow.Item("trans_fat").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("dietary_fiber"))) Then
                txtDietaryFiber.Text = thisRow.Item("dietary_fiber").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("sodium"))) Then
                txtSodium.Text = thisRow.Item("sodium").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("cholesterol"))) Then
                txtCholesterol.Text = thisRow.Item("cholesterol").ToString()
            End If


            checkMealButton("") 'sets to snack, will be readdressed later when revising code

            'grpFavorites.Visible = False
            pnlFavorites.Visible = False

            grpEntryDetails.Visible = True
            grpMain.Visible = False

            ' If bolUsingFavorites = True Then
            chkFoodAddToFavorites.Checked = True
            chkFoodAddToFavorites.Visible = False
            'End If

            'see if this selection is owned by the user, if so allow edit
            btnEdit.Visible = doesUserOwn(thisRow.Item("foods.user_ID"))
            btnDeleteFromFavorites.Visible = True

            btnUpdate.Visible = False
            cmbNumberOfServings.SelectedIndex = 0

        End If
    End Sub

    Private Sub _cmbSearchLocalFoods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchLocalFoods.SelectedIndexChanged
        cmbSearchLocalFoods_SelectedIndexChanged()
    End Sub

    Public Sub cmbSearchLocalFoods_SelectedIndexChanged()
        'https://stackoverflow.com/questions/20649164/vb-net-combobox-autocomplete/20659538
        'https://stackoverflow.com/users/2118383/vignesh-kumar-a
        bolUsingLocalDatabase = True
        bolUsingFavorites = False
        bolUsingCreate = False
        'cmbSearchFavoriteFoods.SelectedIndex = -1
        If cmbSearchLocalFoods.SelectedIndex <> -1 Then

            Dim thisRow = dtFoods.Rows(cmbSearchLocalFoods.SelectedIndex)

            txtFoodName.Text = thisRow.Item("food")
            Dim intCalories As Integer = thisRow.Item("food_calories")
            txtFoodCalories.Text = intCalories.ToString()

            'load in values from database if they are not null
            If Not (System.Convert.IsDBNull(thisRow.Item("serving_size_amount"))) Then
                txtServingSizeAmount.Text = thisRow.Item("serving_size_amount").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("serving_size_unit"))) Then
                txtServingSizeUnit.Text = thisRow.Item("serving_size_unit")
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("protein"))) Then
                txtProtein.Text = thisRow.Item("protein").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("total_fat"))) Then
                txtTotalFat.Text = thisRow.Item("total_fat").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("total_carbohydrates"))) Then
                txtCarbohydrates.Text = thisRow.Item("total_carbohydrates").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("total_sugars"))) Then
                txtSugars.Text = thisRow.Item("total_sugars").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("saturated_fat"))) Then
                txtSaturatedFat.Text = thisRow.Item("saturated_fat").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("trans_fat"))) Then
                txtTransFat.Text = thisRow.Item("trans_fat").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("dietary_fiber"))) Then
                txtDietaryFiber.Text = thisRow.Item("dietary_fiber").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("sodium"))) Then
                txtSodium.Text = thisRow.Item("sodium").ToString()
            End If
            If Not (System.Convert.IsDBNull(thisRow.Item("cholesterol"))) Then
                txtCholesterol.Text = thisRow.Item("cholesterol").ToString()
            End If


            checkMealButton("") ' no longer using default meal type in foods table, so may revise this later

            grpEntryDetails.Visible = True
            grpMain.Visible = False

            'see if this selection is owned by the user, if so allow edit
            btnEdit.Visible = doesUserOwn(thisRow.Item("user_ID"))
            btnUpdate.Visible = False

            cmbNumberOfServings.SelectedIndex = 0

            'foods From local database

            'If its Then In favorites, don't check add to favorites
            Dim food_ID As Integer = thisRow.Item("food_ID")
            If intArrayFoodIDForComboBoxFavorite.Contains(food_ID) Then 'this food is a favorite of the user

                'Do show delete from favorites
                btnDeleteFromFavorites.Visible = True
                'don't show add to favorites, it already is
                chkFoodAddToFavorites.Checked = False
                chkFoodAddToFavorites.Visible = False
                'If its Then Not In favorites, check favorites
            Else
                btnDeleteFromFavorites.Visible = False
                chkFoodAddToFavorites.Checked = True
                chkFoodAddToFavorites.Visible = True
                'Do Not show delete from favorites
            End If

        End If
    End Sub

    Private Sub btnCreateFood_Click(sender As Object, e As EventArgs) Handles btnCreateFood.Click
        bolUsingLocalDatabase = False
        bolUsingFavorites = False
        bolUsingCreate = True
        grpMain.Visible = False
        grpEntryDetails.Visible = True
        For Each formControl As Object In collectionForEdit
            formControl.Enabled = True
        Next
        lblFoodName.Enabled = True
        lblFoodCalories.Enabled = True

        lblNumberOfServings.Visible = False
        cmbNumberOfServings.Visible = False
        btnDeleteFromFavorites.Visible = False
        btnAdd.Visible = False
        btnSave.Visible = True
        btnEdit.Visible = False
        resetAllEditableFields()
    End Sub

    Public Function resetAllEditableFields()
        txtFoodName.Text = String.Empty
        txtFoodCalories.Text = String.Empty

        rbFoodSnacks.Checked = True
        chkFoodAddToFavorites.Checked = False

        For Each formTextBox As TextBox In collectionForEdit
            formTextBox.Text = String.Empty
        Next

        cmbSearchLocalFoods.SelectedIndex = -1
        cmbSearchFavoriteFoods.SelectedIndex = -1

    End Function

    Public Function doesUserOwn(ByVal fieldEntry As Object) As Boolean
        'checks to see field has an entry and also if the entry is the current user
        'returns true if the owner matches the owner of the food
        If System.Convert.IsDBNull(fieldEntry) = False Then
            'MsgBox("not null")
            If fieldEntry <> user_ID Then
                'user doesn't own
                Return False
            Else
                'user owns
                Return True
            End If
        Else
            'is null no owner listed
            Return False
        End If

    End Function

    Private Sub chkFoodAddToFavorites_CheckedChanged(sender As Object, e As EventArgs) Handles chkFoodAddToFavorites.CheckedChanged
        'expands or contracts subheadings if add to favorites is checked
        If chkFoodAddToFavorites.Checked = True Then
            chkFoodLowCarb.Visible = True
            chkFoodHeartHealthy.Visible = True
        Else
            chkFoodLowCarb.Visible = False
            chkFoodHeartHealthy.Visible = False
            chkFoodLowCarb.Checked = False
            chkFoodHeartHealthy.Checked = False
        End If
    End Sub

    Private Sub checkMealButton(ByVal meal_type As String)
        'sets the meal type based on meal type
        If meal_type = "breakfast" Then
            rbFoodBreakfast.Checked = True
        ElseIf meal_type = "lunch" Then
            rbFoodLunch.Checked = True
        ElseIf meal_type = "dinner" Then
            rbFoodDinner.Checked = True
        Else
            rbFoodSnacks.Checked = True
        End If
    End Sub

    Private Sub _btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        btnBack_Click()
    End Sub

    Public Sub btnBack_Click()
        'resetting visual and functional aspects of form
        For Each formControl As Object In collectionForEdit
            formControl.Enabled = False
        Next
        If bolUsingFavorites = True Then
            'cmbSearchLocalFoods.SelectedIndex = -1
            cmbSearchLocalFoods.SelectedIndex = -1
            cmbSearchFavoriteFoods.SelectedIndex = -1
        ElseIf bolUsingLocalDatabase = True Then
            'cmbSearchFavoriteFoods.SelectedIndex = -1
            cmbSearchLocalFoods.SelectedIndex = -1
            cmbSearchFavoriteFoods.SelectedIndex = -1
        ElseIf bolUsingCreate = True Then
            grpMain.Visible = True
            grpEntryDetails.Visible = False
            For Each formControl As Object In collectionForEdit
                formControl.Enabled = False
            Next
            cmbSearchLocalFoods.SelectedIndex = -1
            cmbSearchFavoriteFoods.SelectedIndex = -1
            lblNumberOfServings.Visible = True
            cmbNumberOfServings.Visible = True
            btnAdd.Visible = True
            btnSave.Visible = False
            btnDeleteFromFavorites.Visible = True
            btnEdit.Visible = True
            lblFoodName.Enabled = False
            lblFoodCalories.Enabled = False
            resetAllEditableFields()
        End If

        chkFoodAddToFavorites.Visible = True
        'grpFavorites.Visible = True
        pnlFavorites.Visible = True

        grpEntryDetails.Hide()
        grpMain.Show()


    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        user_ID = frmMain.user_ID
        Dim food_ID As Integer
        'get index of combobox and food id associated with it depending on if using database or favorites

        If bolUsingLocalDatabase = True Then
            If cmbSearchLocalFoods.SelectedIndex <> -1 Then
                food_ID = intArrayFoodIDForComboBoxLocal(cmbSearchLocalFoods.SelectedIndex)
            Else
                food_ID = intLastFoodID
            End If
        ElseIf bolUsingFavorites = True Then
            If cmbSearchFavoriteFoods.SelectedIndex <> -1 Then
                food_ID = intArrayFoodIDForComboBoxFavorite(cmbSearchFavoriteFoods.SelectedIndex)
            Else
                food_ID = intLastFoodID
            End If
        End If

        intAddButtonIndex = frmMain.intBtnAddClicked ' day of week column 0 through 6, set when this form is opened
        Dim meal_entry_Date As DateTime = frmMain.dateTimeDays(intAddButtonIndex)
        Dim meal_type As String = getMealTypeFromRadioButton()
        'add meal to meal entry, loop multiple times for each serving

        Dim intServings As Integer = cmbNumberOfServings.SelectedIndex + 1

        For i As Integer = 0 To intServings - 1
            frmMain.addMealEntry(user_ID, food_ID, meal_type, meal_entry_Date) 'meal entry made here
        Next

        'add to favorites if checked
        If chkFoodAddToFavorites.Checked = True Then
            If intArrayFoodIDForComboBoxFavorite.Contains(food_ID) = False Then
                Dim heart_healthy As Boolean = chkFoodHeartHealthy.Checked
                Dim low_carb As Boolean = chkFoodLowCarb.Checked
                frmMain.addFoodToFavorites(user_ID, food_ID, meal_type, heart_healthy, low_carb)
                'update favorites on main page
                frmMain.populateMyFavoritesFiltered() 'reload favorites on main form
                populateFavoritesComboBox() ' reload favorites 
            End If
        End If
        'repopulate day entries
        frmMain.populateDayEntries(intAddButtonIndex) 'refresh that days entries on the main form
        'Close form
        Me.Close()

    End Sub

    Public Function getMealTypeFromRadioButton() As String
        If rbFoodBreakfast.Checked = True Then
            Return "breakfast"
        ElseIf rbFoodLunch.Checked = True Then
            Return "lunch"
        ElseIf rbFoodDinner.Checked = True Then
            Return "dinner"
        Else
            Return "snack"
        End If
    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        For Each formControl As Object In collectionForEdit
            formControl.Enabled = True
        Next
        btnEdit.Visible = False
        'grpFavorites.Visible = True
        pnlFavorites.Visible = True
        lblNumberOfServings.Visible = False
        cmbNumberOfServings.Visible = False

        btnUpdate.Visible = True
        btnAdd.Visible = False
        btnCancel.Visible = True
        btnBack.Visible = False


    End Sub

    Private Sub _btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCancel_Click()
    End Sub

    Private Sub btnCancel_Click()
        If bolUsingLocalDatabase = True Then
            For Each formControl As Object In collectionForEdit
                formControl.Enabled = False
            Next
            btnEdit.Visible = True
            lblNumberOfServings.Visible = True
            cmbNumberOfServings.Visible = True

            btnUpdate.Visible = False
            btnAdd.Visible = True
            btnCancel.Visible = False
            btnBack.Visible = True

            Dim intLastIndex As Integer = cmbSearchLocalFoods.SelectedIndex

            populateFoodSearchComboBoxWithLocalDatabase() ' repopulate the table and combobox
            populateFavoritesComboBox() 'repopulate favorites table and combo box

            cmbSearchLocalFoods.SelectedIndex = intLastIndex 'select the last index

            cmbSearchLocalFoods_SelectedIndexChanged() 'run the initialization code when edit details is opened

        ElseIf bolUsingFavorites = True Then
            For Each formControl As Object In collectionForEdit
                formControl.Enabled = False
            Next
            btnEdit.Visible = True
            btnUpdate.Visible = False
            btnAdd.Visible = True
            btnCancel.Visible = False
            btnBack.Visible = True
            'grpFavorites.Visible = False
            pnlFavorites.Visible = False
            lblNumberOfServings.Visible = True
            cmbNumberOfServings.Visible = True

            Dim intLastIndex As Integer = cmbSearchFavoriteFoods.SelectedIndex

            populateFoodSearchComboBoxWithLocalDatabase() ' repopulate the table and combobox
            populateFavoritesComboBox() 'repopulate favorites table and combo box

            cmbSearchFavoriteFoods.SelectedIndex = intLastIndex 'select the last index

            cmbSearchFavoriteFoods_SelectedIndexChanged() 'run the initialization code when edit details is opened

        End If
    End Sub

    Public Sub onlyAllowDigits(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'can only enter digits into text box
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


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim food_ID As Integer
        'get index of combobox and food id associated with it
        If bolUsingLocalDatabase = True Then
            food_ID = intArrayFoodIDForComboBoxLocal(cmbSearchLocalFoods.SelectedIndex)
            intLastFoodID = food_ID
        ElseIf bolUsingFavorites = True Then
            food_ID = intArrayFoodIDForComboBoxFavorite(cmbSearchFavoriteFoods.SelectedIndex)
            intLastFoodID = food_ID
        End If

        'https://stackoverflow.com/questions/9489671/check-for-empty-textbox-controls-in-vb-net


        'getTextOfTextBox returns a string 'null' if the textbox is empty for building the query string
        Dim str_food_name As String = sanitizeString(frmMain.getTextOfTextBox(txtFoodName))
        Dim str_food_calories As String = frmMain.getTextOfTextBox(txtFoodCalories)
        Dim str_food_ID As String = food_ID.ToString()
        Dim str_total_fat As String = frmMain.getTextOfTextBox(txtTotalFat)
        Dim str_total_carbohydrates As String = frmMain.getTextOfTextBox(txtCarbohydrates)
        Dim str_protein As String = frmMain.getTextOfTextBox(txtProtein)
        Dim str_serving_size_amount As String = frmMain.getTextOfTextBox(txtServingSizeAmount)
        Dim str_serving_size_unit As String = sanitizeString(frmMain.getTextOfTextBox(txtServingSizeUnit))
        Dim str_cholesterol As String = frmMain.getTextOfTextBox(txtCholesterol)
        Dim str_sodium As String = frmMain.getTextOfTextBox(txtSodium)
        Dim str_dietary_fiber As String = frmMain.getTextOfTextBox(txtDietaryFiber)
        Dim str_total_sugars As String = frmMain.getTextOfTextBox(txtSugars)
        Dim str_trans_fat As String = frmMain.getTextOfTextBox(txtTransFat)
        Dim str_saturated_fat As String = frmMain.getTextOfTextBox(txtSaturatedFat)

        frmMain.updateFoodExpanded(str_food_name, str_food_calories, str_food_ID, str_total_fat, str_total_carbohydrates, str_protein, str_serving_size_amount, str_serving_size_unit, str_cholesterol, str_sodium, str_dietary_fiber, str_total_sugars, str_trans_fat, str_saturated_fat)
        'updateFoodExpanded( str_food_ID As String, ByVal str_total_fat As String, ByVal  ByVal str_serving_size_unit As String, ByVal str_cholesterol As String, ByVal str_sodium As String, ByVal str_dietary_fiber As String, ByVal str_total_sugars As String, ByVal str_trans_fat As String, ByVal str_saturated_fat As String)


        If chkFoodAddToFavorites.Checked = True Then
            If intArrayFoodIDForComboBoxFavorite.Contains(food_ID) = False Then
                Dim meal_type As String = getMealTypeFromRadioButton()
                Dim heart_healthy As Boolean = chkFoodHeartHealthy.Checked
                Dim low_carb As Boolean = chkFoodLowCarb.Checked
                frmMain.addFoodToFavorites(user_ID, food_ID, meal_type, heart_healthy, low_carb)
                'update favorites on main page
                'frmMain.populateMyFavoritesFiltered()
                'populateFavoritesComboBox()
            End If
        End If

        populateFoodSearchComboBoxWithLocalDatabase()
        populateFavoritesComboBox()
        frmMain.populateMyFavoritesFiltered()
        frmMain.populateWeekMealEntries()

        btnCancel_Click()
    End Sub

    Private Sub btnDeleteFromFavorites_Click(sender As Object, e As EventArgs) Handles btnDeleteFromFavorites.Click
        Dim food_ID As Integer
        If bolUsingLocalDatabase = True Then
            food_ID = intArrayFoodIDForComboBoxLocal(cmbSearchLocalFoods.SelectedIndex)
        ElseIf bolUsingFavorites = True Then
            food_ID = intArrayFoodIDForComboBoxFavorite(cmbSearchFavoriteFoods.SelectedIndex)
        End If
        user_ID = frmMain.user_ID
        btnDeleteFromFavorites.Visible = False
        frmMain.deleteFromFavorites(food_ID, user_ID)
        frmMain.populateMyFavoritesFiltered()
        populateFavoritesComboBox()
        'goBackFromUpdate()
        'btnBack_Click()
        cmbSearchFavoriteFoods.SelectedIndex = -1
        cmbSearchLocalFoods.SelectedIndex = -1
        btnBack_Click()
        'frmAddEntryRevised_Load()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'pseudocode
        'save
        '-> make a food entry

        '-> get id of that last food entry
        'Dim food_ID As Integer = 1

        '-> add that food entry to favorites if applicable

        '-> update frmmain favorites list

        '-> update the favorites combo box

        '-> update the local combobox

        '-> show the main

        '-> set to the correct id on foods combobox
        '(may need a function to get id for food_id index)

        Dim str_food_name As String = frmMain.getTextOfTextBox(txtFoodName)
        'Dim str_food_calories As String = frmMain.getTextOfTextBox(txtFoodCalories)
        'Dim str_food_ID As String = food_ID.ToString()
        Dim str_total_fat As String = frmMain.getTextOfTextBox(txtTotalFat)
        Dim str_total_carbohydrates As String = frmMain.getTextOfTextBox(txtCarbohydrates)
        Dim str_protein As String = frmMain.getTextOfTextBox(txtProtein)
        Dim str_serving_size_amount As String = frmMain.getTextOfTextBox(txtServingSizeAmount)
        Dim str_serving_size_unit As String = frmMain.getTextOfTextBox(txtServingSizeUnit)
        Dim str_cholesterol As String = frmMain.getTextOfTextBox(txtCholesterol)
        Dim str_sodium As String = frmMain.getTextOfTextBox(txtSodium)
        Dim str_dietary_fiber As String = frmMain.getTextOfTextBox(txtDietaryFiber)
        Dim str_total_sugars As String = frmMain.getTextOfTextBox(txtSugars)
        Dim str_trans_fat As String = frmMain.getTextOfTextBox(txtTransFat)
        Dim str_saturated_fat As String = frmMain.getTextOfTextBox(txtSaturatedFat)

        'make a food entry/call the function to insert the food entry
        Dim myFood As New foodManagement.foodObject
        myFood.food = txtFoodName.Text
        If frmMain.getTextOfTextBox(txtFoodCalories) <> "null" Then
            myFood.calories = CInt(frmMain.getTextOfTextBox(txtFoodCalories))
        End If
        If frmMain.getTextOfTextBox(txtServingSizeAmount) <> "null" Then
            myFood.servingSizeAmount = CInt(frmMain.getTextOfTextBox(txtServingSizeAmount))
        End If
        If frmMain.getTextOfTextBox(txtServingSizeUnit) <> "null" Then
            myFood.servingSizeUnit = frmMain.getTextOfTextBox(txtServingSizeUnit)
        End If
        If frmMain.getTextOfTextBox(txtProtein) <> "null" Then
            myFood.protein = CInt(frmMain.getTextOfTextBox(txtProtein))
        End If
        If frmMain.getTextOfTextBox(txtTotalFat) <> "null" Then
            myFood.fat = CInt(frmMain.getTextOfTextBox(txtTotalFat))
        End If
        If frmMain.getTextOfTextBox(txtCarbohydrates) <> "null" Then
            myFood.carbs = CInt(frmMain.getTextOfTextBox(txtCarbohydrates))
        End If
        If frmMain.getTextOfTextBox(txtSugars) <> "null" Then
            myFood.sugar = CInt(frmMain.getTextOfTextBox(txtSugars))
        End If
        If frmMain.getTextOfTextBox(txtSaturatedFat) <> "null" Then
            myFood.satFat = CInt(frmMain.getTextOfTextBox(txtSaturatedFat))
        End If
        If frmMain.getTextOfTextBox(txtTransFat) <> "null" Then
            myFood.transFat = CInt(frmMain.getTextOfTextBox(txtTransFat))
        End If
        If frmMain.getTextOfTextBox(txtTransFat) <> "null" Then
            myFood.fiber = CInt(frmMain.getTextOfTextBox(txtTransFat))
        End If
        If frmMain.getTextOfTextBox(txtSodium) <> "null" Then
            myFood.sodium = CInt(frmMain.getTextOfTextBox(txtSodium))
        End If
        If frmMain.getTextOfTextBox(txtCholesterol) <> "null" Then
            myFood.cholesterol = CInt(frmMain.getTextOfTextBox(txtCholesterol))
        End If
        myFood.userId = frmMain.user_ID


        'myFood.food = txtFoodName.Text
        'myFood.calories = CInt(frmMain.getTextOfTextBox(txtFoodCalories))
        'myFood.servingSizeAmount = CInt(txtServingSizeAmount.Text)
        'myFood.servingSizeUnit = txtServingSizeUnit.Text
        'myFood.protein = CInt(txtProtein.Text)
        'myFood.fat = CInt(txtTotalFat.Text)
        'myFood.carbs = CInt(txtCarbohydrates.Text)
        'myFood.sugar = CInt(txtSugars.Text)
        'myFood.satFat = CInt(txtSaturatedFat.Text)
        'myFood.transFat = CInt(txtTransFat.Text)
        'myFood.fiber = CInt(txtDietaryFiber.Text)
        'myFood.sodium = CInt(txtSodium.Text)
        'myFood.cholesterol = CInt(txtCholesterol.Text)

        Dim foodManager As New foodManagement

        If frmMain.getTextOfTextBox(txtFoodCalories) = "null" Or frmMain.getTextOfTextBox(txtFoodName) = "null" Then
            MsgBox("Please enter the food name and calories.")
        Else

            foodManager.createfood(myFood)
            'get id of that last food entry

            Dim food_ID As Integer = frmMain.getLastFoodIDInFoodTable()

            'add to favorites if needed
            If chkFoodAddToFavorites.Checked = True Then
                If intArrayFoodIDForComboBoxFavorite.Contains(food_ID) = False Then
                    Dim meal_type As String = getMealTypeFromRadioButton()
                    Dim heart_healthy As Boolean = chkFoodHeartHealthy.Checked
                    Dim low_carb As Boolean = chkFoodLowCarb.Checked
                    frmMain.addFoodToFavorites(user_ID, food_ID, meal_type, heart_healthy, low_carb)
                    'update favorites on main page
                    frmMain.populateMyFavoritesFiltered()
                    populateFavoritesComboBox()
                End If
            End If

            '-> update frmmain favorites list
            frmMain.populateMyFavoritesFiltered()

            '-> update the favorites combo box
            populateFavoritesComboBox()

            '-> update the local combobox
            populateFoodSearchComboBoxWithLocalDatabase()

            '-> show the main
            'goBackFromUpdate()
            btnBack_Click()

            'set to the correct id on foodcombobox
            Dim thisIndex As Integer = Array.IndexOf(intArrayFoodIDForComboBoxLocal, food_ID)
            cmbSearchLocalFoods.SelectedIndex = thisIndex
            'Needs done here
        End If
    End Sub


    Function sanitizeString(ByVal thisString As String) As String
        thisString = thisString.Replace("""", "``")
        thisString = thisString.Replace("'", "`")
        Return thisString
    End Function
End Class