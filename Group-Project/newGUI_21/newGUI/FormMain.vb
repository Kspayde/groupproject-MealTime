
Public Class frmMain
    Dim lblDays(7) As Label
    Dim arrMyFavoritesFoodID() As Integer
    Dim arrMyFavoritesFoodDefaultMealType() As String
    Dim arrMyExercisesExerciseID() As Integer
    Dim arrMyExercisesExerciseDescription() As String
    Public dateTimeDays(7) As DateTime
    'Dim listMyFavoritesFoodID As List(Of Integer)
    Dim btnAdd(7) As Button
    Dim intCalorieCount(7) As Integer
    Dim lblCalorieCount(7) As Label
    Dim intGoalCalories(7) As Integer
    Dim lblGoalCalories(7) As Label
    Dim intCalorieBalance(7) As Integer
    Dim lblCalorieBalance(7) As Label
    Public flpDailyFoodsContainer(7) As FlowLayoutPanel
    Public intBtnAddClicked As Integer
    Public objParentContainerOfAddButton As Object
    Public user_ID As Integer = 1
    Dim lastSender As Object
    Dim htmlString As String
    Public strHTMLCalendarString As String = ""
    Dim strPrintCalendarHeading As String
    Dim strPrintCalendarDays(6) As String
    Dim strPrintCalendarEntries(6, 4) As String
    Dim strPrintCalendarExerciseEntries(6) As String
    Dim strPrintCalendarTotalRows(6) As String
    Dim intLastHeight As Integer = -1
    Public weightsTable As DataTable
    Public activityTable As DataTable
    Public desiredChangeTable As DataTable
    Public userManager As New UserManagement
    Public thisUser As New UserManagement.user
    Dim strGender As String
    Dim intAge As Integer
    Dim dblHeight As Double
    Public mainFormColor As Color = SystemColors.ScrollBar 'Color.FromArgb(230, 204, 178)
    Public innerFormColor As Color = Color.FromArgb(43, 43, 43)
    Public breakFastColor As Color = Color.FromArgb(249, 199, 79) 'maize-crayola
    Public lunchColor As Color = Color.FromArgb(144, 190, 109) 'pistachio
    Public dinnerColor As Color = Color.FromArgb(243, 114, 44) 'organge red
    Public snackColor As Color = Color.FromArgb(166, 129, 186) 'queen purple
    Public exerciseColor As Color = Color.FromArgb(130, 155, 179) ' queen blue lighter
    Public defaultButtonColor As Color = SystemColors.ButtonFace ' Color.FromArgb(224, 191, 158)
    Public databasePath As String = Environment.GetEnvironmentVariable("APPDATA") + "\HealthTrackDB.accdb"

    '/* SCSS RGB */
    '$red-salsa: rgba(249, 65, 68, 1);
    '$orange-red: rgba(243, 114, 44, 1);
    '$yellow-orange-color-wheel: rgba(248, 150, 30, 1);
    '$mango-tango: rgba(249, 132, 74, 1);
    '$maize-crayola: rgba(249, 199, 79, 1);
    '$pistachio: rgba(144, 190, 109, 1);
    '$zomp: rgba(67, 170, 139, 1);
    '$cadet-blue: rgba(77, 144, 142, 1);
    '$queen-blue: rgba(87, 117, 144, 1); -> modified 'queen-purple' (166, 129, 186)
    '$cg-blue: rgba(39, 125, 161, 1);
    'queen-blue lighter 130 155 179


    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        CloseAllFormsExceptMainForm()
        ' If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        ' Else
        ' e.Cancel = True
        ' End If
    End Sub

    Public Sub CloseAllFormsExceptMainForm()
        Login.Close()
        frmAddEntryRevised.Close()
        frmExercisesRevised.Close()
        frmPrintMealPlan.Close()
        frmUserProfile.Close()
        frmWeights.Close()
        frmNewUser.Close()
        SplashScreen1.Close()
        SplashScreen2.Close()
    End Sub

    Public Sub fillWeightsDataTable()
        Dim strSQL As String = "SELECT * FROM weight WHERE user_ID = " & user_ID.ToString() & " ORDER BY weight_entry_datetime ASC"
        'MsgBox(strSQL)
        weightsTable = getDataTableFromSQLSELECTQuery(strSQL)
    End Sub

    Public Sub fillActivityLevelsDateTable()
        Dim strSQL As String = "SELECT * FROM activity_level WHERE user_ID = " & user_ID.ToString() & " ORDER BY activity_entry_datetime ASC"
        'MsgBox(strSQL)
        activityTable = getDataTableFromSQLSELECTQuery(strSQL)
    End Sub

    Public Sub fillDesiredChangeDataTable()
        Dim strSQL As String = "SELECT * FROM desired_weight_change WHERE user_ID = " & user_ID.ToString() & " ORDER BY desired_change_datetime ASC"
        'MsgBox(strSQL)
        desiredChangeTable = getDataTableFromSQLSELECTQuery(strSQL)

    End Sub

    Public Sub refreshStaticUserBioData()
        thisUser = userManager.lookupUserByID(user_ID)
        strGender = thisUser.sex      '''''''''''''''''''''''
        'MsgBox("sex" & thisUser.sex)
        intAge = userManager.getAge(user_ID) ''''''''''''''''''''' Needs changed read in at form load
        'MsgBox("age" & intAge.ToString())
        dblHeight = CDbl(thisUser.height) '''''''''''''''''''''''
        'MsgBox("height" & dblHeight.ToString())
    End Sub
    Public Sub setColors()

        Me.BackColor = mainFormColor
        flpTopPanel.BackColor = mainFormColor
        flpRightPanel.BackColor = mainFormColor
        flpBottomLeft.BackColor = mainFormColor
        flpBottomRight.BackColor = mainFormColor
        flpLeftPanel.BackColor = mainFormColor
        lblMonth.BackColor = mainFormColor
        lblHiddenSpacer.BackColor = mainFormColor
        lblHiddenSpacer.ForeColor = mainFormColor
        lblHiddenSpacer2.BackColor = mainFormColor
        lblHiddenSpacer2.ForeColor = mainFormColor
        lblProfile.BackColor = mainFormColor
        lblActivityLevel.BackColor = mainFormColor
        lblDesiredWeightLoss.BackColor = mainFormColor
        lblLeftCalorieActual.BackColor = mainFormColor
        lblLeftCalorieGoal.BackColor = mainFormColor
        lblLeftCalorieBalance.BackColor = mainFormColor
        lblMyExercises.BackColor = mainFormColor
        lblMyFavorites.BackColor = mainFormColor
        btnChangeDate.BackColor = mainFormColor
        btnSettings.BackColor = mainFormColor

        'buttons in control panel area
        btnSettings2.BackColor = defaultButtonColor
        btnToggleQuickDropAndNews.BackColor = defaultButtonColor
        btnScreenSizeToggle.BackColor = defaultButtonColor
        btnWeight.BackColor = defaultButtonColor
        btnExercises.BackColor = defaultButtonColor
        btnPrint.BackColor = defaultButtonColor
        btnTrash.BackColor = defaultButtonColor
        btnNavigateWebBack.BackColor = defaultButtonColor
        btnNavigateWebForward.BackColor = defaultButtonColor
        btnWebHome.BackColor = defaultButtonColor

        '/* SCSS RGB */
        '$red-salsa: rgba(249, 65, 68, 1);
        '$orange-red: rgba(243, 114, 44, 1);
        '$yellow-orange-color-wheel: rgba(248, 150, 30, 1);
        '$mango-tango: rgba(249, 132, 74, 1);
        '$maize-crayola: rgba(249, 199, 79, 1);
        '$pistachio: rgba(144, 190, 109, 1);
        '$zomp: rgba(67, 170, 139, 1);
        '$cadet-blue: rgba(77, 144, 142, 1);
        '$queen-blue: rgba(87, 117, 144, 1);
        '$cg-blue: rgba(39, 125, 161, 1);

        'from photos of meal plans
        'yellow (248, 195, 41)
        'green (119, 180, 63)
        'red (207, 82, 38)
        'purple (175, 124, 199)
        'blue (112, 146, 190)

        '        Select Case strMealType
        '            Case "breakfast"
        '                Return Color.FromArgb(248, 195, 41)
        '            Case "lunch"
        '                Return Color.FromArgb(119, 180, 63)
        '           Case "dinner"
        '                Return Color.FromArgb(207, 82, 38)
        '            Case "snack"
        '                Return Color.FromArgb(175, 124, 199)
        '            Case "exercise"
        '                Return Color.FromArgb(112, 146, 190)
        '            Case Else
        '                Return Color.FromArgb(118, 200, 147)
        '       End Select





    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'SplashScreen2.Show()

        setColors()

        fillWeightsDataTable()

        fillActivityLevelsDateTable()

        fillDesiredChangeDataTable()

        refreshStaticUserBioData()

        'initialize string arrays to ""
        For i As Integer = 0 To 6
            For j As Integer = 0 To 3
                strPrintCalendarEntries(i, j) = ""
            Next
            strPrintCalendarTotalRows(i) = ""
            strPrintCalendarDays(i) = ""
            strPrintCalendarExerciseEntries(i) = ""
        Next
        'MsgBox(htmlTableString)

        changeActivityLevelLabel()
        changeDesiredWeightLossLabel()

        'items on form are added to arrays for indexed looping if needed
        addDayLabelsToArray()
        addButtonsToArray()
        addFlowLayoutPanelsToArray()
        addCalorieCountLabelsToArray()
        addGoalCaloriesLabelsToArray()
        addCalorieBalanceLabelsToArray()

        'sets to webpage
        'toggleQuickDropAndNews()

        'updates the days and months starting to current day
        updateDays()
        updateMonth()

        'fills exercise and meal entries from database
        '*** the order of these subroutine calls below is important ***
        populateWeekMealEntries()
        'not yet written, always returns 1800, but will need to get goals for each day based on
        'calculation from user information, weight, activity level, sex and so on.
        populateCalorieGoalsForTheWeek()
        populateCalorieBalanceForTheWeek()
        populateMyFavoritesFiltered()
        populateMyExercises()

        resizeFormToFitTableLayout()

        AddHandler lstMyFavorites.MouseDown, AddressOf lst_MouseDown
        AddHandler lstMyExercises.MouseDown, AddressOf lst_MouseDown

        AddHandler btnTrash.DragOver, AddressOf _DragOver
        AddHandler btnTrash.DragDrop, AddressOf trashDrop

        AddHandler btnClearDay0.DragOver, AddressOf _DragOver
        AddHandler btnClearDay1.DragOver, AddressOf _DragOver
        AddHandler btnClearDay2.DragOver, AddressOf _DragOver
        AddHandler btnClearDay3.DragOver, AddressOf _DragOver
        AddHandler btnClearDay4.DragOver, AddressOf _DragOver
        AddHandler btnClearDay5.DragOver, AddressOf _DragOver
        AddHandler btnClearDay6.DragOver, AddressOf _DragOver

        AddHandler btnClearDay0.DragDrop, AddressOf trashDrop
        AddHandler btnClearDay1.DragDrop, AddressOf trashDrop
        AddHandler btnClearDay2.DragDrop, AddressOf trashDrop
        AddHandler btnClearDay3.DragDrop, AddressOf trashDrop
        AddHandler btnClearDay4.DragDrop, AddressOf trashDrop
        AddHandler btnClearDay5.DragDrop, AddressOf trashDrop
        AddHandler btnClearDay6.DragDrop, AddressOf trashDrop

        htmlString = "<!-- https://www.w3schools.com/css/css_navbar_vertical.asp -->
<!DOCTYPE html>
<html lang='en'>

<head>
  <meta charset='UTF-8'>
  <meta http-equiv='X-UA-Compatible' content='IE=edge'>
  <meta name='viewport' content='width=device-width, initial-scale=1.0'>
  <title>Weekly Planner</title>
  <style>
    *{
      padding: 0px;
      margin: 0px;
    }
    html {
      background-image: linear-gradient(rgb(240, 240, 240), rgb(200, 200, 200));
    }

    #quote{
      color: darkslategrey;
      font-size: .7em;
    }

    article {
      border-style: 1px solid darkslategrey;
      /* border-color: silver; */
      background-image: linear-gradient(rgb(240, 240, 240), rgb(200, 200, 200));

    }

    #display, #date{
      font-size: 1em;
    }

    body div {
      font-family: 'Courier New', 'Times New Roman';
      font-size: 1.2em;
    }

    div {
      text-align: center;
    }

    button {
      background-image: linear-gradient(rgb(240, 240, 240), rgb(200, 200, 200));
    
    }

    div p {
      font: bold;
      font-style: italic;
      color: rgb(182, 178, 178);
    }

    h2 {
      color: darkslategray;
      text-align: center;
    }

    section {
      /* border-style: outset; */
      border-style: 1px solid darkslategrey;
    }

    section p {
      display: block;
      text-align: center;
      padding: 16px;
      /* padding: 16px 64px; */

    }

    ul {
      list-style-type: none;
      text-align: center;

    }

    li a {
      display: block;
      color: rgb(50, 50, 50);
      padding: 8px 16px 8px 16px;
      text-decoration: none;
    }



    li a:hover {
      background-image: linear-gradient(rgb(240, 240, 240), rgb(200, 200, 200));
      color: white;
    }
  </style>
</head>


<body onload='startTime(); startDate()'>

  <article>
    <div class='container'>
      <div id='date'></div>
      <div id='display'></div>
      <div id='content'>
        <p id='quote'>&quotthe people who are crazy enough to think they can change the world are the ones who do.&quot
          <br />- Steve Jobs</p>
      </div>
    </div>
    <div id='b-nav'>
      <ul>
        <button id='gen' onclick='genQuote()'>New Quote</button>
      </ul>
    </div>

    <script>
      function startTime() {
        var today = new Date();
        var h = today.getHours();
        var m = today.getMinutes();
        var s = today.getSeconds();
        var ampm = '';
        m = checkTime(m);

        if (h > 12) {
          h = h - 12;
          ampm = ' PM';
        } else if (h == 12) {
          h = 12;
          ampm = ' AM';
        } else if (h < 12) {
          ampm = ' AM';
        } else {
          ampm = 'PM';
        };

        if (h == 0) {
          h = 12;
        }

        document.getElementById('display').innerHTML = h + ':' + m + ampm;
        var t = setTimeout(function () { startTime() }, 500);
      }

      function checkTime(i) {
        if (i < 10) { i = '0' + i };  // add zero in front of numbers < 10
        return i;
      }

      function genQuote() {
        var randNum = Math.floor(Math.random() * 8) + 1;
        document.getElementById('quote').innerHTML = quotes[randNum];
        var tweetQuote = quotes[randNum].split(' ').join('%20');
        tweetQuote = tweetQuote.split('<br>').join('');
        tweetQuote = 'https://twitter.com/intent/tweet?text=' + tweetQuote.split('&quot').join('')
        $('.twitter-share-button').attr('href', tweetQuote);
      }

      //quote array
      var quotes = ['Blank', '&quotPerfection is not attainable, but if we chase perfection we can catch excellence.&quot<br> - Vince Lombardi', '&quotEither I will find a way, or I will make one.&quot<br> - Philip Sidney',
        '&quotOur greatest weakness lies in giving up. The most certain way to succeed is always to try just one more time.&quot<br>- Thomas A. Edison',
        '&quotYou are never too old to set another goal or to dream a new dream.&quot<br>- C.S Lewis', '&quotIf you can dream it, you can do it.&quot<br>- Walt Disney',
        '&quotNever give up, for that is just the place and time that the tide will turn.&quot<br>- Harriet Beecher Stowe', '&quotI can’t change the direction of the wind, but I can adjust my sails to always reach my destination.&quot<br>- Jimmy Dean',
        '&quotIf you always put limit on everything you do, physical or anything else. It will spread into your work and into your life. There are no limits. There are only plateaus, and you must not stay there, you must go beyond them.&quot<br>- Bruce Lee',
        '&quotBelieve you can and you’re halfway there.&quot<br>- Theodore Roosevelt', '&quotStrive not to be a success, but rather to be of value.&quot<br>- Albert Einstein',
        '&quotI am not a product of my circumstances. I am a product of my decisions.&quot<br>- Stephen Covey', '&quotThe most difficult thing is the decision to act, the rest is merely tenacity.&quot<br>- Amelia Earhart',
        '&quotChange your thoughts and you change your world.&quot<br>- Norman Vincent Peale', '&quotEverything has beauty, but not everyone can see. &quot<br>- Confucius',
        '&quotThe only person you are destined to become is the person you decide to be.&quot<br>- Ralph Waldo Emerson', '&quotWe can’t help everyone, but everyone can help someone. &quot<br>- Ronald Reagan',];

      //date
      function startDate() {
        var d = new Date();
        var days = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
        document.getElementById('date').innerHTML = days[d.getDay()] + ' | ' + [d.getMonth() + 1] + '/' + d.getDate() + '/' + d.getFullYear();
      }


    </script>
  </article>

  <br> </br>


  <section>
    <h2> Useful Information and resources </h2>
    <p>

      It is important when trying to eat healthy and exersise to calculate
      the correct amount of callories that you are burning so you are cosuming the
      correct amount of callories for your weight loss goal. Here is a great Calculator
      to help you figure out how many calories you will be burning with each type of workout.

    <ul>
      <li><a href='https://caloriecontrol.org/healthy-weight-tool-kit/get-moving-calculator/'>Activity Calculator</a>
      </li>
    </ul>


    </p>

    <p>

      Your BMI (Body Mass Index) is a tool used that devids your weight by your height and is used to assist with
      screening method for determing weight catergory.
      It's a good idea to keep an eye on your bmi during your weight loss journy.

    <ul>
      <li><a
          href='https://www.cdc.gov/healthyweight/assessing/bmi/adult_bmi/english_bmi_calculator/bmi_calculator.html'>BMI
          Calculator</a></li>
    </ul>

    </p>
    <p>

      Here are some other great resources from the fda.

    <ul>
      <li><a href='https://www.fda.gov/food'>FDA Food Information</a></li>
      <li><a
          href='https://www.fda.gov/food/nutrition-education-resources-materials/new-nutrition-facts-label'>Nutritional
          Information</a></li>
    </ul>


    </p>

  </section>
</body>

</html>"

        webInfo.DocumentText = htmlString

        btnChangeDate.Visible = False

        SplashScreen2.Close()
    End Sub
    Public Sub changeActivityLevelLabel()
        'get activity level
        Dim index As Integer = frmUserProfile.getComputedComboBoxPhysicalActivityIndex(frmUserProfile.getBestPhysicalActivityFactorByDate2(user_ID, Now()))
        lblActivityLevel.Text = frmUserProfile.cmbActivityLevel.Items(index).ToString()
    End Sub

    Public Sub changeDesiredWeightLossLabel()
        Dim index As Integer = frmUserProfile.getComputedComboBoxWeeklyWeightChangeIndex(frmUserProfile.getBestDesiredWeightChangeByDate2(user_ID, Now()))
        lblDesiredWeightLoss.Text = "Goal: " & frmUserProfile.cmbDesiredWeightChange.Items(index).ToString()
    End Sub

    '**************************************************************************************************
    '
    '                           DRAG AND DROP RELATED CODE START
    '
    '**************************************************************************************************
    'DRAG AND DROP FUNCTIONALITY NOTES ON MEALS
    '
    'myfavorite -> blank day area   (DONE)          is a copy
    '	insert into meal table
    '
    'myfavorite -> meal             (DONE)          is a copy
    '	insert into same day
    '	change meal to same type

    'meal to meal, same day, not self (DONE)        is a move, keep
    '	insert into meal table at destination day
    '	change to destination meal type
    '
    'meal to meal on different day  (DONE)          is a move, should be a copy *** (fixed)
    '	insert into meal table at destination day
    '	change to destination meal type
    '
    'meal to trash                  (DONE)          is a move
    '	remove from meal table
    '
    'meal to blank space            (DONE)          is a copy
    '	insert into meal table at that day
    '
    'meal to self                   (DONE)
    '   do nothing 
    '
    '
    '
    '
    '
    '
    'DRAG AND DROP FUNCTIONALITY NOTES ON EXERCISES
    '
    'myExercise -> blank day area   (DONE)          is a copy
    '	insert into meal table
    '
    'myExercise -> meal             (DONE)          is a copy
    '	insert into same day
    '	change meal to same type

    'exercise to exercise (should be same day only) (DONE)  is a move, keep
    '	do nothing
    '
    'exercise to exercise on different day  (DONE)  is a move, should be a copy
    '	insert into meal table at destination day
    '	change to destination meal type
    '
    'exercise to trash                  (DONE)          is a move
    '	remove from meal table
    '
    'exercise to blank space            (DONE)          is a copy
    '	insert into meal table at that day
    '
    'exercise onto itself
    '   do nothing
    Private Sub lst_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'handless the mouse down even for items in the list box in the listbox
        'and sets the data available to current selected index in the listbox
        lastSender = sender
        Dim itemIndex As Integer = lastSender.IndexFromPoint(e.X, e.Y)
        If itemIndex <> -1 Then
            Dim effect As DragDropEffects = lastSender.DoDragDrop(itemIndex.ToString(), DragDropEffects.Copy Or DragDropEffects.Move)
        End If
    End Sub

    Private Sub mealLabel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'handles the mouse down even for meal labels and sets the data equal to the actual label object
        lastSender = sender
        Dim effect As DragDropEffects = lastSender.DoDragDrop(lastSender, DragDropEffects.Copy Or DragDropEffects.Move)
    End Sub

    Private Sub _DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) ' handles items that are draggable
        e.Effect = DragDropEffects.Move
    End Sub


    Private Sub flpDailyFoodsContainer_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        'handles drops into flow layout panels containing meals and exercise entries
        'handles them differently depending on where the drag and drop event originated from

        'handles drop from myfavorites into daily flow layout panels
        If lastSender.Name = "lstMyFavorites" Then 'originated from the myfavorites list
            lastSender.ClearSelected() 'clear the highligh in the listbox
            Dim intItemIndex As Integer = Int(e.Data.GetData(DataFormats.Text)) 'get the index from the list
            '(these arrays are made when the listbox entries are read in from the database)
            Dim intFood_ID As Integer = arrMyFavoritesFoodID(intItemIndex) 'get the food ID
            Dim strMealType As String = arrMyFavoritesFoodDefaultMealType(intItemIndex) 'get the meal type
            'the 'index' of the day is that  last character of the label days name, ie the index is embedded in the name'
            'get the last character of the days name, which is the index.
            Dim intDayIndex As Integer = CInt((sender.name)(sender.name.length - 1).ToString()) 'get last character, make into string, then int
            addMealEntry(user_ID, intFood_ID, strMealType, dateTimeDays(intDayIndex))
            populateDayEntries(intDayIndex)
            'in case table layout grows or shrinks, resize the form to accomadate
            resizeFormToFitTableLayout()
            'handles drops into daily flow layout panels from other meal entries in the flow layout panels

        ElseIf lastSender.Name.Substring(0, 9) = "mealEntry" Then

            If lastSender.Parent.Name = sender.name Then
                'msgBox("It is a meal entry on same day being dropped into empty space, should do nothing")
            Else
                Dim intDayIndex As Integer = CInt((sender.name)(sender.name.length - 1).ToString()) 'get last character, make into string, then int
                addMealEntry(user_ID, lastSender.intFoodID, lastSender.strMealType(), dateTimeDays(intDayIndex))
                'addMealEntry(lastSender.intFoodID(), intDayIndex, lastSender.strMealType())
                populateDayEntries(intDayIndex)
                resizeFormToFitTableLayout()
            End If

            'handles drops into daily flow layout panels form other exercise entries
        ElseIf lastSender.Name.Substring(0, 13) = "exerciseEntry" Then
            If lastSender.Parent.Name = sender.name Then
                'msgBox("It is an exercise entry on same day being dropped into empty space, should do nothing")
            Else
                Dim intDayIndex As Integer = CInt((sender.name)(sender.name.length - 1).ToString()) 'get last character, make into string, then int
                addExerciseEntry(lastSender.intExerciseID, intDayIndex)
                populateDayEntries(intDayIndex)
                resizeFormToFitTableLayout()
            End If

            'handles drops into daily flow layout panels from the listbox of favorite exercise entries.
        ElseIf lastSender.Name = "lstMyExercises" Then
            lastSender.ClearSelected() 'unhighlight listbox
            Dim intItemIndex As Integer = Int(e.Data.GetData(DataFormats.Text)) 'get the index from the listbox

            Dim intExerciseID As Integer = arrMyExercisesExerciseID(intItemIndex) 'get the index from the favorite exercises listbox
            '(this array is made when the listbox entries are read in from the database)

            Dim intDayIndex As Integer = CInt((sender.name)(sender.name.length - 1).ToString()) 'get last character, make into string, then int
            addExerciseEntry(intExerciseID, intDayIndex)
            populateDayEntries(intDayIndex)
            resizeFormToFitTableLayout()
        End If

    End Sub

    Public Sub trashDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) 'handles different items that are dropped onto the trash button
        'MsgBox("trash drop attempted for " & lastSender.Name)

        If lastSender.Name.Substring(0, 9) = "mealEntry" Then 'meal entry dropped into trash
            Dim thisParentName As String = lastSender.Parent.Name
            Dim dayIndex As Integer = CInt((thisParentName.Substring(thisParentName.Length - 1, 1)).ToString())
            Dim thisMealEntry = lastSender.intMealEntryID()
            deleteMealEntry(thisMealEntry)
            populateDayEntries(dayIndex)
            resizeFormToFitTableLayout()

        ElseIf lastSender.Name.Substring(0, 13) = "exerciseEntry" Then 'exercise entry dropped into trash
            Dim thisParentName As String = lastSender.Parent.Name
            Dim dayIndex As Integer = CInt((thisParentName.Substring(thisParentName.Length - 1, 1)).ToString())
            Dim thisExerciseEntry = lastSender.intExerciseEntryID()
            deleteExerciseEntry(thisExerciseEntry)
            populateDayEntries(dayIndex)
            resizeFormToFitTableLayout()

        ElseIf lastSender.Name = "lstMyFavorites" Then 'originated from the myfavorites list
            lastSender.ClearSelected() 'clear the highligh in the listbox
            Dim intItemIndex As Integer = Int(e.Data.GetData(DataFormats.Text)) 'get the index from the list
            '(these arrays are made when the listbox entries are read in from the database)
            Dim intFood_ID As Integer = arrMyFavoritesFoodID(intItemIndex) 'get the food ID
            deleteFromFavorites(intFood_ID, user_ID)
            populateMyFavoritesFiltered()

        ElseIf lastSender.Name = "lstMyExercises" Then 'originated from the myfavorites list
            'msgBox("favorite exercise dropped to trash")
            Dim intItemIndex As Integer = Int(e.Data.GetData(DataFormats.Text)) 'get the index from the list
            'msgBox("index was" & intItemIndex.ToString())
            Dim intExerciseID = arrMyExercisesExerciseID(intItemIndex)
            'msgBox("exercise ID is" & intExerciseID.ToString())
            lastSender.ClearSelected() 'clear the highligh in the listbox
            deleteFromFavoriteExercises(intExerciseID, user_ID)
            'deleteFromFavorites(intFood_ID, user_ID)
            populateMyExercises()

        End If

        resizeFormToFitTableLayout()
    End Sub



    Public Sub mealLabel_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        'handles various items that are dropped onto a meal label, drop behavior depends on what's being droppped

        If lastSender.Name = "lstMyFavorites" Then
            'my favorite list dropped onto existing meal label
            'adds food to that day, but changes meal type to whatever type the list item is dropped onto
            lastSender.ClearSelected() 'unhighlight listbox
            Dim intItemIndex As Integer = Int(e.Data.GetData(DataFormats.Text)) 'get index from list
            Dim intFood_ID As Integer = arrMyFavoritesFoodID(intItemIndex) 'this array is made when listbox is populated
            Dim strMealType As String = sender.strMealType() 'whatever is dropped onto needs to be the meal type
            Dim intDayIndex As Integer = CInt((sender.parent.name)(sender.parent.name.length - 1).ToString()) 'get last character, make into string, then int

            'addMealEntry(intFood_ID, intDayIndex, strMealType)
            addMealEntry(user_ID, intFood_ID, strMealType, dateTimeDays(intDayIndex))
            populateDayEntries(intDayIndex)
            resizeFormToFitTableLayout()

        ElseIf lastSender.Name.Substring(0, 9) = "mealEntry" Then
            'msgBox("lastSender.Name: " & lastSender.Name)
            'msgBox("sender.Name: " & sender.Name)
            If sender.Name = lastSender.Name Then
                'do nothing if something is being dropped onto itself
            Else
                'a meal entry is being dropped onto a meal entry
                'get source dayindex and destination day index from lastSender and senders parents names
                Dim intSourceDayIndex As Integer = CInt((lastSender.parent.name)(lastSender.parent.name.length - 1).ToString()) 'get last character, make into string, then int
                Dim intDayIndex As Integer = CInt((sender.parent.name)(sender.parent.name.length - 1).ToString()) 'get last character, make into string, then int


                If intSourceDayIndex = intDayIndex Then 'food is dragged from one meal to another on the same day
                    'intent is to move from one meal type to another
                    'msgBox(lastSender.strMealType & " " & sender.strMealtype)
                    If lastSender.strMealType = sender.strMealType Then
                        'do nothing
                    Else
                        addMealEntry(user_ID, lastSender.intFoodID, sender.strMealType, dateTimeDays(intDayIndex))
                        'addMealEntry(lastSender.intFoodID, intDayIndex, sender.strMealType)
                        Dim thisMealEntry = lastSender.intMealEntryID()
                        deleteMealEntry(thisMealEntry)
                        populateDayEntries(intDayIndex)
                        'populateDayEntries(intSourceDayIndex) ' may not need to duplicate if on same day
                        resizeFormToFitTableLayout()
                    End If
                Else
                    addMealEntry(user_ID, lastSender.intFoodID, sender.strMealType, dateTimeDays(intDayIndex))
                    'addMealEntry(lastSender.intFoodID, intDayIndex, sender.strMealType)
                    Dim thisMealEntry = lastSender.intMealEntryID()
                    'deleteMealEntry(thisMealEntry)
                    populateDayEntries(intDayIndex)
                    'populateDayEntries(intSourceDayIndex) ' may not need to duplicate if on same day
                    resizeFormToFitTableLayout()


                End If


            End If


        ElseIf lastSender.Name.Substring(0, 13) = "exerciseEntry" Then
            If sender.Name = lastSender.Name Then
                'do nothing if something is being dropped onto itself
            Else

                If lastSender.Parent.Name = sender.Parent.Name Then ' day is same
                    'msgBox("the exercise entry is being dropped onto a meal or exercise entry for rearranging, no rearrangement needed.")
                    'do nothing

                Else
                    'do something
                    'an exercise entry is being dropped on a meal entry
                    'this occurs possibly when there is no other space in the parent element to drop the exercise entry
                    'and should add an exercise to that day
                    Dim intDayIndex As Integer = CInt((sender.parent.name)(sender.parent.name.length - 1).ToString()) 'get last character, make into string, then int
                    addExerciseEntry(lastSender.intExerciseID, intDayIndex)
                    populateDayEntries(intDayIndex)
                    resizeFormToFitTableLayout()
                End If

            End If

            'add the stipulation that doing something requires the days be different



        ElseIf lastSender.Name = "lstMyExercises" Then
            'an exercise from the list is being dropped onto a meal
            'this occurs possibly when there is no other space in the parent element to drop the exercise entry
            'and should add an exercise to that day
            lastSender.ClearSelected() 'unhighlight
            Dim intItemIndex As Integer = Int(e.Data.GetData(DataFormats.Text))     'get the index from listbox selection
            Dim intExerciseID As Integer = arrMyExercisesExerciseID(intItemIndex)   'this is made when the exercise listbox is made from the database
            Dim intDayIndex As Integer = CInt((sender.parent.name)(sender.parent.name.length - 1).ToString()) 'get last character, make into string, then int
            addExerciseEntry(intExerciseID, intDayIndex)
            populateDayEntries(intDayIndex)
            resizeFormToFitTableLayout()
        End If
    End Sub

    '**************************************************************************************************
    '
    '                           DRAG AND DROP RELATED CODE END
    '
    '**************************************************************************************************


    '**************************************************************************************************
    '
    '                           DATABASE RELATED FUNCTIONS START
    '
    '**************************************************************************************************
    Public Sub addExerciseEntry(ByVal exercise_ID As Integer, ByVal intDayIndex As Integer)
        'user_ID = user_ID
        Dim strSQL As String = "INSERT INTO exercise_entries (user_ID, exercise_entry_date, exercise_ID) VALUES (" &
        user_ID.ToString() & "," &
        "#" & dateTimeDays(intDayIndex).ToString() & "#," &
        exercise_ID.ToString() & ");"
        'MsgBox(strSQL)
        insertIntoTable(strSQL)
    End Sub

    '*************************
    '*************************
    '*****   fix this   ******======>   FIXED 10/31/2021 gd
    '*************************
    '*************************
    '*************************
    '    Public Sub addMealEntry(ByVal food_ID As Integer, ByVal intDayIndex As Integer, Optional ByVal mealType As String = "snack")
    '        'user_ID = user_ID
    '        Dim strSQL As String = "INSERT INTO meal_entries (user_ID, meal_entry_date, meal_type, food_ID) VALUES (" &
    '        user_ID.ToString() & "," &
    '        "#" & dateTimeDays(intDayIndex).ToString() & "#,'" &
    '        mealType.ToString() & "'," &
    '        food_ID.ToString() & ");"
    '        'MsgBox(strSQL)
    '        insertIntoTable(strSQL)
    '    End Sub

    Public Function addMealEntry(ByVal user_ID As Integer, ByVal food_ID As Integer, ByVal meal_type As String, ByVal meal_entry_Date As DateTime)
        Dim strSQL As String = "INSERT INTO meal_entries (user_ID, meal_entry_Date, meal_type, food_ID) VALUES (" &
            user_ID.ToString() & "," &
            "#" & meal_entry_Date.ToString() & "#,'" &
            meal_type.ToString() & "'," &
            food_ID.ToString() & ");"
        'msgBox(strSQL)
        insertIntoTable(strSQL)
    End Function

    Public Function getFavoriteFoodsDataTable(ByVal user_ID As Integer) As DataTable
        Dim dtTempDataTable As DataTable
        Dim strSQL As String = "SELECT favorites.favorites_ID, favorites.user_ID, favorites.food_ID, favorites.default_meal_type,foods.food, foods.food_calories
FROM foods INNER JOIN favorites ON foods.[food_ID] = favorites.[food_ID] WHERE favorites.user_ID=" & user_ID.ToString() & " ORDER BY foods.food ASC;"
        dtTempDataTable = getDataTableFromSQLSELECTQuery(strSQL)
        Return dtTempDataTable
    End Function

    Public Function getFavoriteFoodsDataTableFiltered(ByVal user_ID As Integer) As DataTable
        'MsgBox("in function")
        Dim diabetic As Boolean
        Dim heart_healthy As Boolean
        Dim dtTempDataTable As DataTable
        Dim strSQL As String = "SELECT favorites.favorites_ID, favorites.user_ID, favorites.food_ID, favorites.default_meal_type, favorites.diabetic, favorites.heart_healthy, foods.food, foods.food_calories
FROM foods INNER JOIN favorites ON foods.[food_ID] = favorites.[food_ID] WHERE favorites.user_ID=" & user_ID.ToString()

        If chkLowCarb.Checked = True Then
            strSQL += " AND favorites.diabetic = " & chkLowCarb.Checked
        End If

        If chkHeartHealthy.Checked = True Then
            strSQL += " AND favorites.heart_healthy = " & chkHeartHealthy.Checked
        End If

        strSQL += " ORDER BY foods.food ASC;"

        'MsgBox(strSQL)
        dtTempDataTable = getDataTableFromSQLSELECTQuery(strSQL)
        Return dtTempDataTable
    End Function

    Public Function getFavoriteExercisesDataTable(ByVal user_ID As Integer) As DataTable
        Dim dtTempDataTable As DataTable
        Dim strSQL = "SELECT exercises.exercise_ID AS exercises_exercise_ID, exercises.exercise_description, exercises.calories_burned, favorite_exercises.user_ID, favorite_exercises.exercise_ID AS favorite_exercises_exercise_ID
FROM exercises INNER JOIN favorite_exercises ON exercises.[exercise_ID] = favorite_exercises.[exercise_ID] WHERE favorite_exercises.user_ID = " & user_ID.ToString() & " ORDER BY exercises.exercise_description ASC;"
        dtTempDataTable = getDataTableFromSQLSELECTQuery(strSQL)
        Return dtTempDataTable
    End Function

    Public Sub insertIntoTable(ByVal strSQL As String)
        'contents adapted from https://itsourcecode.com/free-projects/vb-net/connect-access-database-in-vb-net/
        'https://stackoverflow.com/questions/20808528/inserting-data-from-vb-net-to-ms-access-syntax-error-in-insert-into-statement/20808643
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)
        Try
            con.Open()
            Dim cmd As New OleDb.OleDbCommand(strSQL, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & "Error connecting to database, INSERTING OR DELETING." & strSQL)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub deleteFromTable(ByVal strSQL As String)
        insertIntoTable(strSQL)
    End Sub

    Public Sub updateEntryInTable(ByVal strSQL As String)
        insertIntoTable(strSQL)
    End Sub

    Public Function getDataTableFromSQLSELECTQuery(ByVal strSQL As String) As DataTable
        'contents adapted from https://itsourcecode.com/free-projects/vb-net/connect-access-database-in-vb-net/
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath)
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            con.Open()
            cmd.Connection = con
            cmd.CommandText = strSQL
            da.SelectCommand = cmd
            da.Fill(dt)
            'DataGridView1.DataSource = dt
            Return (dt)
        Catch ex As Exception
            MsgBox(ex.Message & "Error with connecting to database or database operation." & strSQL)
        Finally
            con.Close()
        End Try
    End Function

    Public Function getMealEntriesDataTable(ByVal user_ID As Integer, ByVal datetime_onThisDay As DateTime)
        Dim strSQL As String = "SELECT meal_entries.meal_entry_ID, meal_entries.user_ID, meal_entries.meal_entry_Date, meal_entries.meal_type, " &
            "meal_entries.food_ID, foods.food, foods.food_calories FROM foods INNER JOIN meal_entries ON foods.[food_ID] = meal_entries.[food_ID]
            WHERE (" &
            "((meal_entries.meal_entry_Date)>=#" & datetime_onThisDay.Date.ToString() & "#" &
            " AND (meal_entries.meal_entry_Date)<#" & datetime_onThisDay.AddDays(1).Date.ToString & "# ) AND " &
            "meal_entries.user_ID = " & user_ID & ");"
        'MsgBox(strSQL) 'debugging statement
        Dim dtMealEntriesForADay As DataTable 'get the data table which returns
        dtMealEntriesForADay = getDataTableFromSQLSELECTQuery(strSQL)
        Return dtMealEntriesForADay
    End Function

    Public Function getExerciseEntriesDataTable(ByVal user_ID As Integer, ByVal datetime_onThisDay As DateTime)
        Dim strSQL As String = "SELECT exercise_entries.exercise_entry_ID, exercise_entries.user_ID, exercise_entries.exercise_entry_date, " &
            "exercise_entries.exercise_ID, exercises.exercise_description, exercises.calories_burned FROM exercises INNER JOIN exercise_entries " &
            "ON exercises.[exercise_ID] = exercise_entries.[exercise_ID] " &
            "WHERE (" &
            "((exercise_entries.exercise_entry_Date)>=#" & datetime_onThisDay.Date.ToString() & "#" &
            " AND (exercise_entries.exercise_entry_Date)<#" & datetime_onThisDay.AddDays(1).Date.ToString & "# ) AND " &
            "exercise_entries.user_ID = " & user_ID & ");"

        Dim dtExercisesForThisDay As DataTable 'get the data table which returns
        dtExercisesForThisDay = getDataTableFromSQLSELECTQuery(strSQL)
        Return dtExercisesForThisDay
    End Function

    Public Function getCalorieGoalByDay(ByVal user_ID As Integer, ByVal dtThisDate As DateTime) As Integer

        If dtThisDate.Date >= Now.Date Then
            dtThisDate = Now.Date
        End If


        'Dim userManager As New UserManagement
        'Dim thisUser As New UserManagement.user
        'thisUser = userManager.lookupUserByID(user_ID)
        'Dim strGender As String = thisUser.sex

        '
        strGender = strGender
        '

        'MsgBox("sex" & thisUser.sex)
        'Dim intAge As Integer = userManager.getAge(user_ID) ''''''''''''''''''''' Needs changed read in at form load
        'MsgBox("age" & intAge.ToString())

        intAge = intAge


        Dim dblWeight As Double = frmUserProfile.getBestWeightByDate2(user_ID, dtThisDate)
        'MsgBox("weight" & dblWeight.ToString())

        'Dim dblHeight As Double = CDbl(thisUser.height) '''''''''''''''''''''''
        'MsgBox("height" & dblHeight.ToString())

        dblHeight = dblHeight


        Dim dblPhysicalActivityFactor As Double = frmUserProfile.getBestPhysicalActivityFactorByDate2(user_ID, dtThisDate)
        'MsgBox("activity factor" & dblPhysicalActivityFactor.ToString())
        Dim dblDesiredWeeklyWeightChange As Double = frmUserProfile.getBestDesiredWeightChangeByDate2(user_ID, dtThisDate)
        'MsgBox("desired weight change " & dblDesiredWeeklyWeightChange.ToString())

        Dim calorieGoal As Integer

        calorieGoal = frmUserProfile.calculateGoalCalories(strGender, intAge, dblWeight, dblHeight, dblPhysicalActivityFactor, dblDesiredWeeklyWeightChange)

        Return calorieGoal

        'Return 1800
    End Function

    Function deleteMealEntry(ByVal intMealEntryID As Integer)
        Dim strSQL As String = "DELETE FROM meal_entries WHERE meal_entry_ID=" & intMealEntryID
        deleteFromTable(strSQL)
    End Function

    Function deleteExerciseEntry(ByVal intExerciseEntry As Integer)
        Dim strSQL As String = "DELETE FROM exercise_entries WHERE exercise_entry_ID=" & intExerciseEntry
        deleteFromTable(strSQL)
    End Function

    Function deleteAllMealEntriesOnADay(ByVal intUser_ID As Integer, ByVal dtThisDate As DateTime)
        'intUser_ID=user_ID
        Dim strSQL As String = "DELETE FROM meal_entries WHERE " &
           "meal_entry_date" &
           ">=#" & dtThisDate.Date.ToString() & "#" &
           " AND " &
           "meal_entry_date" &
           "<#" & dtThisDate.AddDays(1).Date.ToString & "#" &
           " AND " &
           "user_ID=" & intUser_ID & ";"
        'msgBox(strSQL)
        deleteFromTable(strSQL)
    End Function

    Function deleteAllExerciseEntriesOnADay(ByVal intUser_ID As Integer, ByVal dtThisDate As DateTime)
        Dim strSQL As String = "DELETE FROM exercise_entries WHERE " &
                        "exercise_entry_date" &
                        ">=#" & dtThisDate.Date.ToString() & "#" &
                        " AND " &
                        "exercise_entry_date" &
                        "<#" & dtThisDate.AddDays(1).Date.ToString & "#" &
                        " AND " &
                        "user_ID=" & user_ID & ";"
        'msgBox(strSQL)
        deleteFromTable(strSQL)
    End Function


    Public Function addFoodToFavorites(ByVal user_ID As Integer, ByVal food_ID As Integer, ByVal meal_type As String, ByVal heart_healthy As Boolean, ByVal low_carb As Boolean)
        Dim strSQL As String = "INSERT INTO favorites (user_ID, food_ID, default_meal_type, heart_healthy, diabetic) VALUES (" &
        user_ID.ToString() & "," &
        food_ID.ToString() & "," &
        "'" & meal_type.ToString() & "'," &
        heart_healthy & "," &
        low_carb & ")"
        'MsgBox(strSQL)
        insertIntoTable(strSQL)
    End Function
    Public Sub deleteFromFavorites(ByVal food_ID As Integer, ByVal user_ID As Integer)
        Dim strSQL As String =
            "DELETE FROM favorites WHERE " &
            "user_ID = " & user_ID.ToString() & " AND " &
            "food_ID = " & food_ID.ToString() & ";"
        'MsgBox(strSQL)
        deleteFromTable(strSQL)
    End Sub
    Public Sub deleteFromFavoriteExercises(ByVal exercise_ID As Integer, ByVal user_ID As Integer)
        Dim strSQL As String =
            "DELETE FROM favorite_exercises WHERE " &
            "user_ID = " & user_ID.ToString() & " AND " &
            "exercise_ID = " & exercise_ID.ToString() & ";"
        'MsgBox(strSQL)
        deleteFromTable(strSQL)
    End Sub


    Public Sub addFoodToFoodTable(ByVal user_ID As Integer, ByVal food As String, ByVal food_calories As Integer)
        Dim strSQL As String = "INSERT INTO foods (food,food_calories, user_ID) VALUES ('" &
         food & "'," &
          food_calories & "," &
           user_ID.ToString() &
            ");"
        'msgBox(strSQL)
        insertIntoTable(strSQL)
    End Sub

    Public Function getLastFoodIDInFoodTable() As Integer
        Dim strSQL As String = "SELECT LAST (food_ID) FROM foods" ' & user_ID.ToString()
        Dim dtTempDataTable As DataTable = getDataTableFromSQLSELECTQuery(strSQL)
        Dim food_ID As Integer = dtTempDataTable.Rows(0).Item(0)
        Return (food_ID)
    End Function

    Public Function getLastExerciseIDInExerciseTable() As Integer
        Dim strSQL As String = "SELECT LAST (exercise_ID) FROM exercises" ' & user_ID.ToString()
        Dim dtTempDataTable As DataTable = getDataTableFromSQLSELECTQuery(strSQL)
        Dim exercise_ID As Integer = dtTempDataTable.Rows(0).Item(0)
        Return (exercise_ID)
    End Function



    Public Function getDataTableForFavoritesComboBox(ByVal user_ID As Integer) As DataTable
        Dim strSQL As String = "SELECT foods.food_ID, foods.food, foods.food_calories, foods.serving_size_amount, foods.serving_size_unit, foods.protein, foods.total_fat,
foods.total_carbohydrates, foods.total_sugars, foods.saturated_fat, foods.trans_fat, foods.dietary_fiber, foods.sodium, foods.cholesterol,
foods.user_ID, favorites.favorites_ID, favorites.user_ID, favorites.Default_meal_type, favorites.diabetic, favorites.heart_healthy
FROM foods INNER JOIN favorites ON foods.[food_ID] = favorites.[food_ID] WHERE favorites.user_ID=" & user_ID.ToString() & ";"

        'Dim strSQL As String = "SELECT foods.food_ID, foods.food, foods.food_calories, foods.user_ID, favorites.favorites_ID, favorites.user_ID, favorites.Default_meal_type, favorites.diabetic, favorites.heart_healthy
        'From foods INNER JOIN favorites ON foods.[food_ID] = favorites.[food_ID] WHERE favorites.user_ID=" & user_ID.ToString() & ";"
        Dim dtFavorites As DataTable = getDataTableFromSQLSELECTQuery(strSQL)
        Return dtFavorites
    End Function

    Public Function getDataTableForFavoritesComboBoxAlphabetical(ByVal user_ID As Integer) As DataTable
        Dim strSQL As String = "SELECT foods.food_ID, foods.food, foods.food_calories, foods.serving_size_amount, foods.serving_size_unit, foods.protein, foods.total_fat,
foods.total_carbohydrates, foods.total_sugars, foods.saturated_fat, foods.trans_fat, foods.dietary_fiber, foods.sodium, foods.cholesterol,
foods.user_ID, favorites.favorites_ID, favorites.user_ID, favorites.Default_meal_type, favorites.diabetic, favorites.heart_healthy
FROM foods INNER JOIN favorites ON foods.[food_ID] = favorites.[food_ID] WHERE favorites.user_ID=" & user_ID.ToString() & " ORDER BY foods.food ASC;"

        'Dim strSQL As String = "SELECT foods.food_ID, foods.food, foods.food_calories, foods.user_ID, favorites.favorites_ID, favorites.user_ID, favorites.Default_meal_type, favorites.diabetic, favorites.heart_healthy
        'From foods INNER JOIN favorites ON foods.[food_ID] = favorites.[food_ID] WHERE favorites.user_ID=" & user_ID.ToString() & ";"
        Dim dtFavorites As DataTable = getDataTableFromSQLSELECTQuery(strSQL)
        Return dtFavorites
    End Function


    Public Function getDataTableForFavoriteExercisesComboBox(ByVal user_ID As Integer) As DataTable
        Dim strSQL As String = "SELECT exercises.exercise_ID, exercises.Exercise_description, exercises.calories_burned, 
favorite_exercises.favorite_exercises_ID, favorite_exercises.user_ID, favorite_exercises.exercise_ID
FROM exercises INNER JOIN favorite_exercises ON exercises.[exercise_ID] = favorite_exercises.[exercise_ID] WHERE favorite_exercises.user_ID=" & user_ID.ToString() & ";"

        'Dim strSQL As String = "SELECT foods.food_ID, foods.food, foods.food_calories, foods.user_ID, favorites.favorites_ID, favorites.user_ID, favorites.Default_meal_type, favorites.diabetic, favorites.heart_healthy
        'From foods INNER JOIN favorites ON foods.[food_ID] = favorites.[food_ID] WHERE favorites.user_ID=" & user_ID.ToString() & ";"
        'msgBox(strSQL)
        Dim dtFavoriteExercises As DataTable = getDataTableFromSQLSELECTQuery(strSQL)
        Return dtFavoriteExercises
    End Function


    Public Function getFoodsDataTable() As DataTable
        Dim dtFoods As DataTable = getDataTableFromSQLSELECTQuery("SELECT * FROM foods")
        Return dtFoods
    End Function

    Public Function getFoodsDataTableAlphabetical() As DataTable
        Dim dtFoods As DataTable = getDataTableFromSQLSELECTQuery("SELECT * FROM foods ORDER BY food ASC")
        Return dtFoods
    End Function

    Public Function getExercisesDataTable() As DataTable
        Dim dtExercises As DataTable = getDataTableFromSQLSELECTQuery("SELECT * FROM exercises")
        Return dtExercises
    End Function

    Public Function updateFood(ByVal food_name As String, ByVal food_calories As Integer, ByVal food_ID As Integer)
        Dim strSQL As String = "UPDATE foods SET " &
"food='" & food_name & "'," &
"food_calories=" & food_calories.ToString() & " " &
"WHERE food_ID=" & food_ID.ToString() & ";"
        'msgBox(strSQL)
        updateEntryInTable(strSQL)
    End Function


    Public Function updateFoodExpanded(ByVal str_food_name As String, ByVal str_food_calories As String, ByVal str_food_ID As String, ByVal str_total_fat As String, ByVal str_total_carbohydrates As String, ByVal str_protein As String, ByVal str_serving_size_amount As String, ByVal str_serving_size_unit As String, ByVal str_cholesterol As String, ByVal str_sodium As String, ByVal str_dietary_fiber As String, ByVal str_total_sugars As String, ByVal str_trans_fat As String, ByVal str_saturated_fat As String)
        If str_serving_size_amount = "Null" Then
            str_serving_size_amount = "1"
        End If
        Dim strSQL As String = "UPDATE foods SET " &
"food='" & str_food_name & "'," &
"food_calories=" & str_food_calories & ", " &
"total_fat=" & str_total_fat & ", " &
"total_carbohydrates=" & str_total_carbohydrates & ", " &
"protein=" & str_protein & ", " &
"serving_size_unit='" & str_serving_size_unit & "', " &
"cholesterol=" & str_cholesterol & ", " &
"sodium=" & str_sodium & ", " &
"dietary_fiber=" & str_dietary_fiber & ", " &
"total_sugars=" & str_total_sugars & ", " &
"trans_fat=" & str_trans_fat & ", " &
"saturated_fat=" & str_saturated_fat & " " & '"default_meal_type='" & str_default_meal_type & "' " &
"WHERE food_ID=" & str_food_ID & ";"


        'msgBox(strSQL)
        updateEntryInTable(strSQL)
    End Function




    Function getTextOfTextBox(ByRef txtThisTextBox As TextBox) As String
        If String.IsNullOrEmpty(txtThisTextBox.Text) Then
            Return ("null")
        Else
            Return (txtThisTextBox.Text)
        End If
    End Function



    Public Function updateFavorite(ByVal favorites_ID As Integer, ByVal default_meal_type As String, ByVal low_carb As Boolean, ByVal heart_healthy As Boolean)
        Dim strSQL As String = "UPDATE favorites SET " &
    "default_meal_type = '" & default_meal_type & "'," &
    "diabetic = " & low_carb & "," &
    "heart_healthy = " & heart_healthy & " " &
    "WHERE favorites_ID = " & favorites_ID.ToString & ";"

        'msgBox(strSQL)
        updateEntryInTable(strSQL)
    End Function

    '**************************************************************************************************
    '
    '                           DATABASE RELATED FUNCTIONS END
    '
    '**************************************************************************************************

    Public Sub populateMyFavorites() 'this function adds users favorite to the favorite listbox
        lstMyFavorites.Items.Clear()
        Dim dtTempDataTable As DataTable = getFavoriteFoodsDataTable(user_ID)
        ReDim arrMyFavoritesFoodID(dtTempDataTable.Rows.Count)
        ReDim arrMyFavoritesFoodDefaultMealType(dtTempDataTable.Rows.Count)
        For i As Integer = 0 To dtTempDataTable.Rows.Count - 1
            arrMyFavoritesFoodID(i) = dtTempDataTable.Rows(i).Item("food_ID")
            arrMyFavoritesFoodDefaultMealType(i) = dtTempDataTable.Rows(i).Item("default_meal_type")
            lstMyFavorites.Items.Add(dtTempDataTable.Rows(i).Item("food") & " (" & dtTempDataTable.Rows(i).Item("food_calories").ToString() & " Cal)")
        Next
    End Sub

    Public Sub populateMyFavoritesFiltered() 'this function adds users favorite to the favorite listbox
        'MsgBox("called")
        lstMyFavorites.Items.Clear()
        Dim dtTempDataTable As DataTable = getFavoriteFoodsDataTableFiltered(user_ID)
        ReDim arrMyFavoritesFoodID(dtTempDataTable.Rows.Count)
        ReDim arrMyFavoritesFoodDefaultMealType(dtTempDataTable.Rows.Count)
        For i As Integer = 0 To dtTempDataTable.Rows.Count - 1
            arrMyFavoritesFoodID(i) = dtTempDataTable.Rows(i).Item("food_ID")
            arrMyFavoritesFoodDefaultMealType(i) = dtTempDataTable.Rows(i).Item("default_meal_type")
            lstMyFavorites.Items.Add(dtTempDataTable.Rows(i).Item("food") & " (" & dtTempDataTable.Rows(i).Item("food_calories").ToString() & " Cal)")
        Next
    End Sub

    Public Sub populateMyExercises() 'this function adds users favorite to the favorite listbox
        lstMyExercises.Items.Clear()
        Dim dtTempDataTable As DataTable = getFavoriteExercisesDataTable(user_ID)
        ReDim arrMyExercisesExerciseID(dtTempDataTable.Rows.Count)
        ReDim arrMyExercisesExerciseDescription(dtTempDataTable.Rows.Count)
        For i As Integer = 0 To dtTempDataTable.Rows.Count - 1
            lstMyExercises.Items.Add(dtTempDataTable.Rows(i).Item("exercise_description") & " (" & dtTempDataTable.Rows(i).Item("calories_burned") & " Cal)")
            arrMyExercisesExerciseID(i) = dtTempDataTable.Rows(i).Item("exercises_exercise_ID")
            arrMyExercisesExerciseDescription(i) = dtTempDataTable.Rows(i).Item("exercise_description")
        Next

    End Sub

    Public Sub updateDays()
        For i As Integer = 0 To 6
            'MsgBox(dtpStartDate.Value.Date.ToString())
            lblDays(i).Text = dtpStartDate.Value.AddDays(i).DayOfWeek.ToString() & " " & dtpStartDate.Value.AddDays(i).Day.ToString()
            strPrintCalendarDays(i) = lblDays(i).Text
            dateTimeDays(i) = New Date
            dateTimeDays(i) = dtpStartDate.Value.AddDays(i).Date
        Next
    End Sub

    Public Sub updateMonth()
        lblMonth.Text = dtpStartDate.Value.ToString("MMMM")
        strPrintCalendarHeading = "Weekly Food Planner Starting: " & dtpStartDate.Value.ToString("MMMM") & " " & dtpStartDate.Value.ToString("d")
    End Sub

    ' *************************************************INITIALIZATION OF ARRAYS*************************************************
    Public Sub addButtonsToArray()
        btnAdd = New Button() {btnAddDay0, btnAddDay1, btnAddDay2, btnAddDay3, btnAddDay4, btnAddDay5, btnAddDay6}
        For i As Integer = 0 To 6
            'btnAdd(i).Text = Char.ConvertFromUtf32(8853)
            ToolTip1.SetToolTip(Me.btnAdd(i), "Click Here to add meals or exercises to your planner.")
        Next
    End Sub

    Public Sub addCalorieCountLabelsToArray()
        lblCalorieCount = New Label() {lblCalorieCount0, lblCalorieCount1, lblCalorieCount2, lblCalorieCount3, lblCalorieCount4, lblCalorieCount5, lblCalorieCount6}
        For i As Integer = 0 To 6
            lblCalorieCount(i).Text = "Cal"
            'ToolTip1.SetToolTip(Me.lblCalorieCount(i), "Click Here to Add Foods To your Meal Planner")
        Next
    End Sub

    Public Sub addFlowLayoutPanelsToArray()
        flpDailyFoodsContainer = New FlowLayoutPanel() {flpDailyFoodContainer0, flpDailyFoodContainer1, flpDailyFoodContainer2, flpDailyFoodContainer3, flpDailyFoodContainer4, flpDailyFoodContainer5, flpDailyFoodContainer6}
        For i As Integer = 0 To 6
            AddHandler flpDailyFoodsContainer(i).DragOver, AddressOf _DragOver
            AddHandler flpDailyFoodsContainer(i).DragDrop, AddressOf flpDailyFoodsContainer_DragDrop
        Next
    End Sub

    Public Sub addDayLabelsToArray()
        lblDays = New Label() {lblDay0, lblDay1, lblDay2, lblDay3, lblDay4, lblDay5, lblDay6}
    End Sub

    Public Sub addGoalCaloriesLabelsToArray()
        lblGoalCalories = New Label() {lblCalorieGoal0, lblCalorieGoal1, lblCalorieGoal2, lblCalorieGoal3, lblCalorieGoal4, lblCalorieGoal5, lblCalorieGoal6}
        intGoalCalories = New Integer() {0, 0, 0, 0, 0, 0, 0}
    End Sub

    Public Sub addCalorieBalanceLabelsToArray()
        lblCalorieBalance = New Label() {lblCalorieBalance0, lblCalorieBalance1, lblCalorieBalance2, lblCalorieBalance3, lblCalorieBalance4, lblCalorieBalance5, lblCalorieBalance6}
        intCalorieBalance = New Integer() {0, 0, 0, 0, 0, 0, 0}
    End Sub

    ' *************************************************INITIALIZATION OF ARRAYS   END ******************************************

    Private Sub btnAddDay_Click(sender As Object, e As EventArgs) Handles btnAddDay0.Click, btnAddDay1.Click, btnAddDay2.Click, btnAddDay3.Click, btnAddDay4.Click, btnAddDay5.Click, btnAddDay6.Click
        'just set a variable to which button was clicked, just get from name
        intBtnAddClicked = CInt(sender.name.Substring(sender.name.length() - 1, 1)) 'this is an integer 0-6 representing day of add button clicked
        objParentContainerOfAddButton = sender.parent ' this is the parent container of the add button
        frmAddEntryRevised.Show()
    End Sub

    Public Sub populateCalorieGoalsForTheWeek()
        For i As Integer = 0 To 6
            populateCalorieGoalByDay(i)
        Next
    End Sub

    Public Function populateWeekMealEntries()
        For i As Integer = 0 To 6
            populateDayEntries(i)
        Next
    End Function

    Public Function populateCalorieBalanceForTheWeek()
        For i As Integer = 0 To 6
            populateCalorieBalanceForDay(i)
        Next
    End Function

    Public Sub populateCalorieBalanceForDay(ByVal intDayIndex As Integer)
        'Dim dateTimeDayToPopulate = dateTimeDays(intDayIndex)

        If intCalorieCount(intDayIndex) <> 0 Then
            intCalorieBalance(intDayIndex) = intGoalCalories(intDayIndex) - intCalorieCount(intDayIndex)
            lblCalorieBalance(intDayIndex).Text = intCalorieBalance(intDayIndex).ToString() & " Cal"
            If intCalorieBalance(intDayIndex) < 0 Then
                lblCalorieBalance(intDayIndex).BackColor = Color.LightPink
            Else
                lblCalorieBalance(intDayIndex).BackColor = Color.AliceBlue
            End If
        Else
            lblCalorieBalance(intDayIndex).Text = ""
            lblCalorieBalance(intDayIndex).BackColor = Color.AliceBlue
        End If
    End Sub


    Public Sub populateCalorieGoalByDay(ByVal intDayIndex As Integer)
        If intCalorieCount(intDayIndex) <> 0 Then
            Dim dateTimeDayToPopulate = dateTimeDays(intDayIndex)
            intGoalCalories(intDayIndex) = getCalorieGoalByDay(user_ID, dateTimeDayToPopulate)
            lblGoalCalories(intDayIndex).Text = intGoalCalories(intDayIndex).ToString() & " Cal"
        Else
            lblGoalCalories(intDayIndex).Text = ""
        End If
    End Sub

    Public Sub resizeFormToFitTableLayout()
        'Dim oldWebInfoHeight As Integer = webInfo.Height
        If intLastHeight <> flpDailyFoodContainer6.Height Then
            Me.AutoSize = False

            If Not (flpRightPanel.Controls.Contains(webInfo)) Then
                toggleQuickDropAndNews()
                webInfo.Height = lblDays(6).Height + btnAdd(6).Height + flpDailyFoodsContainer(6).Height - lblActivityLevelOLD.Height + 7
                lstMyFavorites.Height = tlpMain.Height - flpBottomLeft.Height - lstMyExercises.Height - lblMyExercises.Height - flpFavoriteFoodsFilter.Height - lblMyFavorites.Height - lblActivityLevelOLD.Height - flpTopPanel.Height - 25
                toggleQuickDropAndNews()

            Else
                webInfo.Height = lblDays(6).Height + btnAdd(6).Height + flpDailyFoodsContainer(6).Height - lblActivityLevelOLD.Height + 7
                lstMyFavorites.Height = tlpMain.Height - flpBottomLeft.Height - lstMyExercises.Height - lblMyExercises.Height - flpFavoriteFoodsFilter.Height - lblMyFavorites.Height - lblActivityLevelOLD.Height - flpTopPanel.Height - 25
            End If

            Me.Width = tlpMain.Width + 33
            Me.Height = tlpMain.Height + 49

            Me.AutoSize = True

            intLastHeight = flpDailyFoodContainer6.Height
        End If


    End Sub

    Public Sub populateDayEntries(ByVal intDayIndex As Integer)

        '''''''''''''''''''''''''''''
        'flpDailyFoodsContainer(intDayIndex).SuspendLayout()
        'Me.SuspendLayout()
        'Me.ResumeLayout(False)
        'Me.PerformLayout()
        ''''''''''''''''''''''''''''''

        'clear html string for that entire day
        For k As Integer = 0 To 3
            strPrintCalendarEntries(intDayIndex, k) = ""
            strPrintCalendarExerciseEntries(intDayIndex) = ""
        Next

        Dim strArrMealType() As String = {"breakfast", "lunch", "dinner", "snack"}
        'clear the entries for that day


        'Me.SuspendLayout()
        'Me.ResumeLayout(False)
        'Me.PerformLayout()

        flpDailyFoodsContainer(intDayIndex).Controls.Clear()

        'get the day that is being populated
        Dim dateTimeDayToPopulate = dateTimeDays(intDayIndex)

        Dim dtMealEntriesForADay As DataTable = getMealEntriesDataTable(user_ID, dateTimeDayToPopulate)

        'use the returned data to construct a lable, then add that label to the flow layout panel for that day
        Dim mealLabel(dtMealEntriesForADay.Rows.Count) As CustomLabel

        intCalorieCount(intDayIndex) = 0
        Dim intContainerWidth As Integer = flpDailyFoodsContainer(intDayIndex).Width
        If dtMealEntriesForADay.Rows.Count > 0 Then
            For j As Integer = 0 To 3 '0-3 -> breakfast lunch dinner snack
                'add a label for the labels , ie generic like breakfast lunch dinner snack then put entries under each one
                Dim thisLabel As New CustomLabel

                thisLabel.Width = intContainerWidth
                thisLabel.Height = 15
                thisLabel.AllowDrop = True
                thisLabel.strMealType = strArrMealType(j)
                thisLabel.Text = strArrMealType(j)
                thisLabel.BackColor = setColorByMealtype(strArrMealType(j))
                flpDailyFoodsContainer(intDayIndex).Controls.Add(thisLabel)

                thisLabel.AllowDrop = True
                AddHandler thisLabel.DragOver, AddressOf _DragOver
                AddHandler thisLabel.DragDrop, AddressOf mealLabel_DragDrop

                For i As Integer = 0 To dtMealEntriesForADay.Rows.Count - 1
                    If strArrMealType(j) = dtMealEntriesForADay.Rows(i).Item("meal_type") Then

                        mealLabel(i) = New CustomLabel
                        mealLabel(i).Width = intContainerWidth
                        mealLabel(i).Height = 30

                        mealLabel(i).AllowDrop = True
                        mealLabel(i).AutoEllipsis = True
                        'set properties of label

                        mealLabel(i).intMealEntryID = dtMealEntriesForADay.Rows(i).Item("meal_entry_ID")
                        mealLabel(i).Name = "mealEntry " & mealLabel(i).intMealEntryID.ToString()
                        mealLabel(i).intFoodID = dtMealEntriesForADay.Rows(i).Item("food_ID")
                        mealLabel(i).intCalories = dtMealEntriesForADay.Rows(i).Item("food_calories")
                        mealLabel(i).strFoodName = dtMealEntriesForADay.Rows(i).Item("food")
                        mealLabel(i).DateTime = dtMealEntriesForADay.Rows(i).Item("meal_entry_Date")
                        mealLabel(i).strMealType = dtMealEntriesForADay.Rows(i).Item("meal_type")
                        mealLabel(i).Margin = New Padding(2)
                        mealLabel(i).Text = makeCustomLabelText(mealLabel(i).strFoodName, mealLabel(i).intCalories.ToString(), mealLabel(i).strMealType, intContainerWidth)
                        strPrintCalendarEntries(intDayIndex, j) += "<li>" & htmlEncode(mealLabel(i).strFoodName & "..." & mealLabel(i).intCalories.ToString() & "Cal") & "</li>"
                        mealLabel(i).BackColor = setColorByMealtype(dtMealEntriesForADay.Rows(i).Item("meal_type"))

                        'add label to appropriate flow layout panel
                        flpDailyFoodsContainer(intDayIndex).Controls.Add(mealLabel(i))

                        AddHandler mealLabel(i).MouseDown, AddressOf mealLabel_MouseDown
                        AddHandler mealLabel(i).DragOver, AddressOf _DragOver
                        AddHandler mealLabel(i).DragDrop, AddressOf mealLabel_DragDrop

                        'make a tool tip

                        ToolTip1.SetToolTip(mealLabel(i), dtMealEntriesForADay.Rows(i).Item("food").ToString() & mealLabel(i).intCalories.ToString() & " Cal")
                        'accumulate daily calories
                        intCalorieCount(intDayIndex) += mealLabel(i).intCalories
                    End If

                Next
                'Console.WriteLine(strPrintCalendarEntries(intDayIndex, j))
            Next
        End If

        Dim dtExercisesForThisDay As DataTable = getExerciseEntriesDataTable(user_ID, dateTimeDayToPopulate)

        If dtExercisesForThisDay.Rows.Count > 0 Then
            Dim thisLabel As New CustomLabel
            thisLabel.Width = intContainerWidth
            thisLabel.Height = 15
            thisLabel.Name = "exerciseEntry"
            thisLabel.AllowDrop = True
            thisLabel.Text = "exercise"
            thisLabel.BackColor = setColorByMealtype("exercise")
            flpDailyFoodsContainer(intDayIndex).Controls.Add(thisLabel)
            AddHandler thisLabel.MouseDown, AddressOf mealLabel_MouseDown
            AddHandler thisLabel.DragOver, AddressOf _DragOver
            AddHandler thisLabel.DragDrop, AddressOf mealLabel_DragDrop
            For i As Integer = 0 To dtExercisesForThisDay.Rows.Count - 1

                Dim tempLabel As New CustomLabel
                tempLabel.Width = intContainerWidth
                tempLabel.Height = 30

                tempLabel.AllowDrop = True
                tempLabel.AutoEllipsis = True
                'set properties of label

                tempLabel.intExerciseEntryID = dtExercisesForThisDay.Rows(i).Item("exercise_entry_ID")
                tempLabel.Name = "exerciseEntry " & tempLabel.intExerciseEntryID.ToString()
                tempLabel.intExerciseID = dtExercisesForThisDay.Rows(i).Item("exercise_ID")
                tempLabel.intExerciseCaloriesBurned = dtExercisesForThisDay.Rows(i).Item("calories_burned")
                tempLabel.strExerciseDescription = dtExercisesForThisDay.Rows(i).Item("exercise_description")
                tempLabel.DateTime = dtExercisesForThisDay.Rows(i).Item("exercise_entry_Date")

                tempLabel.Margin = New Padding(2)

                tempLabel.Text = makeCustomLabelText(tempLabel.strExerciseDescription, tempLabel.intExerciseCaloriesBurned.ToString(), "exercise", intContainerWidth)

                tempLabel.BackColor = setColorByMealtype("exercise")

                strPrintCalendarExerciseEntries(intDayIndex) += "<li>" & htmlEncode(tempLabel.Text) & "</li>"

                'add label to appropriate flow layout panel
                flpDailyFoodsContainer(intDayIndex).Controls.Add(tempLabel)

                AddHandler tempLabel.MouseDown, AddressOf mealLabel_MouseDown
                AddHandler tempLabel.DragOver, AddressOf _DragOver
                AddHandler tempLabel.DragDrop, AddressOf mealLabel_DragDrop

                'make a tool tip

                ToolTip1.SetToolTip(tempLabel, dtExercisesForThisDay.Rows(i).Item("exercise_description").ToString() & tempLabel.intExerciseCaloriesBurned.ToString() & " Cal")
                'accumulate daily calories
                intCalorieCount(intDayIndex) -= tempLabel.intExerciseCaloriesBurned

            Next
        End If



        'show calories planned for the day
        If intCalorieCount(intDayIndex) = 0 Then
            lblCalorieCount(intDayIndex).Text = ""
        Else
            If intCalorieCount(intDayIndex) < 0 Then
                lblCalorieCount(intDayIndex).Text = "+" & (-intCalorieCount(intDayIndex)).ToString() + " Cal"
            Else
                lblCalorieCount(intDayIndex).Text = "-" & intCalorieCount(intDayIndex).ToString() + " Cal"
            End If


        End If


        populateCalorieGoalByDay(intDayIndex)
        populateCalorieBalanceForDay(intDayIndex)
        updatePrintCalendarTotalRows(intDayIndex)

        ''''''''''''''''''''''
        'Me.SuspendLayout()
        'Me.ResumeLayout()
        'Me.PerformLayout()
        'flpDailyFoodsContainer(intDayIndex).ResumeLayout()
        'flpDailyFoodsContainer(intDayIndex).PerformLayout()
        ''''''''''''''''''''''''

    End Sub

    Public Sub updatePrintCalendarTotalRows(ByVal intDayIndex As Integer)
        strPrintCalendarTotalRows(intDayIndex) = "<li>" & htmlEncode(lblGoalCalories(intDayIndex).Text) & "</li>" &
   "<li>" & htmlEncode(lblCalorieCount(intDayIndex).Text) & "</li>" &
   "<li>" & htmlEncode(lblCalorieBalance(intDayIndex).Text) & "</li>"
    End Sub

    Public Sub updatePrintCalendarTotalRowsForTheWeek()
        For i As Integer = 0 To 6
            updatePrintCalendarTotalRows(i)
        Next
    End Sub

    Public Function setColorByMealtype(ByVal strMealType) As Color
        Select Case strMealType
            Case "breakfast"
                Return breakFastColor
            Case "lunch"
                Return lunchColor
            Case "dinner"
                Return dinnerColor
            Case "snack"
                Return snackColor
            Case "exercise"
                Return exerciseColor
            Case Else
                Return Color.FromArgb(0, 0, 0)
        End Select

        'from photos of meal plans
        'yellow (248, 195, 41)
        'green (119, 180, 63)
        'red (207, 82, 38)
        'purple (175, 124, 199)
        'blue (112, 146, 190)

        'https://coolors.co/d9ed92-b5e48c-99d98c-76c893-52b69a-34a0a4-168aad-1a759f-1e6091-184e77
        '/* SCSS RGB */
        '$key-lime: rgba(217, 237, 146, 1);
        '$yellow-green-crayola: rgba(181, 228, 140, 1);
        '$granny-smith-apple: rgba(153, 217, 140, 1);
        '$ocean-green: rgba(118, 200, 147, 1);
        '$keppel: rgba(82, 182, 154, 1);
        '$viridian-green: rgba(52, 160, 164, 1);
        '$blue-munsell: rgba(22, 138, 173, 1);
        '$celadon-blue: rgba(26, 117, 159, 1);
        '$lapis-lazuli: rgba(30, 96, 145, 1);
        '$yale-blue: rgba(24, 78, 119, 1);

        '        /* CSS HEX */
        '--key-lime: #d9ed92ff;
        '--yellow-green-crayola: #b5e48cff;
        '--granny-smith-apple: #99d98cff;
        '--ocean-green: #76c893ff;
        '--keppel: #52b69aff;
        '--viridian-green: #34a0a4ff;
        '--blue-munsell: #168aadff;
        '--celadon-blue: #1a759fff;
        '--lapis-lazuli: #1e6091ff;
        '--yale-blue: #184e77ff;

        '/* SCSS HEX */
        '$key-lime: #d9ed92ff;
        '$yellow-green-crayola: #b5e48cff;
        '$granny-smith-apple: #99d98cff;
        '$ocean-green: #76c893ff;
        '$keppel: #52b69aff;
        '$viridian-green: #34a0a4ff;
        '$blue-munsell: #168aadff;
        '$celadon-blue: #1a759fff;
        '$lapis-lazuli: #1e6091ff;
        '$yale-blue: #184e77ff;
    End Function



    Public Function makeCustomLabelText(ByVal strFoodName As String, ByVal strFoodCalories As String, ByVal strMealType As String, ByVal intContainerWidth As Integer) As String
        'takes the names and info and formats based on size of parent box
        Dim intStringCutoff As Integer = 10 ' for small boxes
        If intContainerWidth > 93 Then ' larger desktop width, then increase
            intStringCutoff = 16
        End If

        Dim strAccumulator As String = ""
        If strFoodName.Length > intStringCutoff Then
            strAccumulator += strFoodName.Substring(0, intStringCutoff) & "..." & vbNewLine
        Else
            strAccumulator += strFoodName & vbNewLine
        End If
        If strFoodCalories.Length > intStringCutoff - 4 Then
            strAccumulator += strFoodCalories.Substring(0, intStringCutoff - 4) & "..." & vbNewLine
        Else
            strAccumulator += strFoodCalories & " Cal"
        End If

        Return strAccumulator
    End Function

    Private Sub _dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        Me.ActiveControl = lblHiddenSpacer
        btnChangeDate.Visible = True
        'dtpStartDate_ValueChanged()
    End Sub

    Private Sub dtpStartDate_ValueChanged()

        clearAllEntriesOnScreen()
        updateDays()
        updateMonth()
        populateWeekMealEntries()
        resizeFormToFitTableLayout()
        Me.ActiveControl = lblHiddenSpacer
    End Sub

    Public Sub clearAllEntriesOnScreen()
        For i As Integer = 0 To 6
            flpDailyFoodsContainer(i).Controls.Clear()
        Next
    End Sub

    Private Sub _btnToggleQuickDropAndNews_Click(sender As Object, e As EventArgs) Handles btnToggleQuickDropAndNews.Click
        toggleQuickDropAndNews()
    End Sub

    Public Sub toggleQuickDropAndNews()
        flpRightPanel.Visible = False

        If flpRightPanel.Controls.Contains(webInfo) = True Then
            flpRightPanel.Controls.Clear()
            flpRightPanel.Controls.Add(lblActivityLevelOLD)
            flpRightPanel.Controls.Add(lblMyFavorites)
            flpRightPanel.Controls.Add(lstMyFavorites)
            flpRightPanel.Controls.Add(flpFavoriteFoodsFilter)
            flpRightPanel.Controls.Add(lblMyExercises)
            flpRightPanel.Controls.Add(lstMyExercises)
        Else
            flpRightPanel.Controls.Clear()
            flpRightPanel.Controls.Add(lblActivityLevelOLD)
            flpRightPanel.Controls.Add(webInfo)
            flpRightPanel.Controls.Add(flpNavigateWeb)
        End If

        flpRightPanel.Visible = True

        If btnToggleQuickDropAndNews.Text = "Links" Then
            btnToggleQuickDropAndNews.Text = "Favorites"
        Else
            btnToggleQuickDropAndNews.Text = "Links"
        End If

    End Sub

    Private Sub btnNavigateWebBack_Click(sender As Object, e As EventArgs) Handles btnNavigateWebBack.Click
        webInfo.GoBack()
    End Sub

    Private Sub btnNavigateWebForward_Click(sender As Object, e As EventArgs) Handles btnNavigateWebForward.Click
        webInfo.GoForward()
    End Sub

    Private Sub webHome_Click(sender As Object, e As EventArgs) Handles btnWebHome.Click

        'webInfo.Url = New Uri("https://www.fda.gov/food/nutrition-education-resources-materials/new-nutrition-fa" & "cts-label", UriKind.Absolute)

        webInfo.DocumentText = htmlString
    End Sub

    Private Sub btnScreenSizeToggle_Click(sender As Object, e As EventArgs) Handles btnScreenSizeToggle.Click

        tlpMain.Visible = False 'no need to show live changes

        If tlpMain.ColumnStyles.Item(1).Width = 93 Then                             'toggle small to large
            For i As Integer = 1 To 7 'widen columns index 1 through 7
                tlpMain.ColumnStyles.Item(i).SizeType = SizeType.Absolute
                tlpMain.ColumnStyles.Item(i).Width = 130
                btnScreenSizeToggle.Text = "🖵"
                ToolTip1.SetToolTip(btnScreenSizeToggle, "Switch to Tablet Size")
            Next
            Me.Width = Me.Width + 259 '(130-93)*7
        Else                                                                        'toggle large to small
            For i As Integer = 1 To 7 'widen columns index 1 through 7
                tlpMain.ColumnStyles.Item(i).SizeType = SizeType.Absolute
                tlpMain.ColumnStyles.Item(i).Width = 93
                btnScreenSizeToggle.Text = "🖥"
                ToolTip1.SetToolTip(btnScreenSizeToggle, "Switch to Desktop Size")
            Next
            Me.Width = Me.Width - 259 '(130-93)*7
        End If
        populateWeekMealEntries() ' includes a redraw of the lables on a larger size
        resizeFormToFitTableLayout()

        tlpMain.Visible = True ' show main table layout panel

    End Sub

    Private Sub btnClearDay_Click(sender As Object, e As EventArgs) Handles btnClearDay0.Click, btnClearDay1.Click, btnClearDay2.Click, btnClearDay3.Click, btnClearDay4.Click, btnClearDay5.Click, btnClearDay6.Click
        'https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/msgbox-function
        Dim Msg, Style, Title, Response
        Msg = "Do you want to delete all entries for this day?"
        Style = vbOKCancel ' + vbCritical + vbDefaultButton2   ' Define buttons.
        Title = "Clear entries for the day?"

        Response = MsgBox(Msg, Style, Title)
        If Response = vbOK Then    ' User chose Yes.
            'MyString = "Yes"    ' Perform some action.
            'MsgBox("you clicked ok")
            Dim intDayIndex As Integer = CInt((sender.name)(sender.name.length - 1).ToString())
            'MsgBox(intDayIndex.ToString())

            Dim thisDateTime = dateTimeDays(intDayIndex)

            deleteAllMealEntriesOnADay(user_ID, thisDateTime)

            deleteAllExerciseEntriesOnADay(user_ID, thisDateTime)

            populateDayEntries(intDayIndex)
            resizeFormToFitTableLayout()

        Else    ' User chose No.
            'MsgBox("you clicked cancel")
            'MyString = "No"    ' Perform some action.
        End If


    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        buildstrHTMLCalendarString()
        frmPrintMealPlan.Show()
    End Sub

    Public Sub buildstrHTMLCalendarString()
        'format for html printable calendar is
        ' day1, day2, day3, day4, day5, day6	
        ' bf     ...				   (0,0) (0,1) (0,2) (0,3) (0,4) (0,5) (0,6)
        ' lunch  ...				=> (1,0) ...
        ' dinner ...				   (2,0)       and so forth
        ' snacks ... 				   (3,0)       
        '
        ' the strings being built are multiple list entries as one string i.e.:
        '
        '          "<li>egg</li>
        '           <li>toast</li>
        '           <li>milk</li>"
        '

        strHTMLCalendarString = "<!DOCTYPE html>
<html lang='en'>
  <head>
    <meta charset='UTF-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Weekly Planner</title>
<style>
    li {
      list-style-type: none;
      /* 10 point */
      font-size: 0.8em;
    }
    table {
      border: 1px solid black;
      background-color: rgb(200, 200, 200);
    }
    td {
      width: 12.5%;
    }
    td {
      border: 1px solid black;
      /* background-color: white; */
    }
    ul {
      margin: 0px;
      padding: 0px;
    }
    tr:nth-child(even) {
      background-color: rgb(240, 240, 240);
    }
    tr:nth-child(odd) {
      background-color: white;
    }
    tr:first-of-type {
      background-color: rgb(200, 200, 200);
    }
    h1 {
      font-size: 1.4em;
    }
  </style>
    </head>
<body>
  <h1 id='plannername'>" & strPrintCalendarHeading & "</h1>
  <table id='table'>
    <tr id='firstrow'>
      <th></th>
      <th>" & strPrintCalendarDays(0) & "</th>
      <th>" & strPrintCalendarDays(1) & "</th>
      <th>" & strPrintCalendarDays(2) & "</th>
      <th>" & strPrintCalendarDays(3) & "</th>
      <th>" & strPrintCalendarDays(4) & "</th>
      <th>" & strPrintCalendarDays(5) & "</th>
      <th>" & strPrintCalendarDays(6) & "</th>
    </tr>
    <tr>
      <td>Breakfast</td>
      <td>
        <ul>
          " & strPrintCalendarEntries(0, 0) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(1, 0) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(2, 0) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(3, 0) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(4, 0) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(5, 0) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(6, 0) & "
        </ul>
      </td>
    </tr>
    <tr>
      <td>Lunch</td>
      <td>
        <ul>
          " & strPrintCalendarEntries(0, 1) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(1, 1) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(2, 1) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(3, 1) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(4, 1) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(5, 1) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(6, 1) & "
        </ul>
      </td>
    </tr>
    <tr>
      <td>Dinner</td>
      <td>
        <ul>
          " & strPrintCalendarEntries(0, 2) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(1, 2) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(2, 2) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(3, 2) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(4, 2) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(5, 2) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(6, 2) & "
        </ul>
      </td>
    </tr>
    <tr>
      <td>Snacks</td>
      <td>
        <ul>
          " & strPrintCalendarEntries(0, 3) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(1, 3) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(2, 3) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(3, 3) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(4, 3) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(5, 3) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarEntries(6, 3) & "
        </ul>
      </td>
    </tr>
    <tr>
      <td>Exercise</td>
      <td>
        <ul>
          " & strPrintCalendarExerciseEntries(0) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarExerciseEntries(1) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarExerciseEntries(2) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarExerciseEntries(3) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarExerciseEntries(4) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarExerciseEntries(5) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarExerciseEntries(6) & "
        </ul>
      </td>
    </tr>
    <tr>
      <td>Totals</td>
      <td>
        <ul>
          " & strPrintCalendarTotalRows(0) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarTotalRows(1) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarTotalRows(2) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarTotalRows(3) & "
        </ul>
      </td>
      <td>
        <ul>
          " & strPrintCalendarTotalRows(4) & "
        </ul>
      </td>
      <td>
        <ul>
           " & strPrintCalendarTotalRows(5) & "
        </ul>
      </td>
      <td>
        <ul>
        " & strPrintCalendarTotalRows(6) & "
        </ul>
      </td>
    </tr>
  </table>
</body>

</html>"

    End Sub

    Public Function htmlEncode(ByVal htmlToEncode As String) As String
        'Return htmlToEncode
        Return System.Net.WebUtility.HtmlEncode(htmlToEncode)
    End Function

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs)
        frmNewUser.Show()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click, btnSettings2.Click
        frmUserProfile.Show()
    End Sub

    Private Sub btnExercises_Click(sender As Object, e As EventArgs) Handles btnExercises.Click
        frmExercisesRevised.Show()
    End Sub

    Private Sub chkLowCarb_CheckedChanged(sender As Object, e As EventArgs) Handles chkLowCarb.CheckedChanged, chkHeartHealthy.CheckedChanged
        populateMyFavoritesFiltered()
    End Sub

    Private Sub btnChangeDate_Click(sender As Object, e As EventArgs) Handles btnChangeDate.Click
        'MsgBox("Updating")
        btnChangeDate.Visible = False
        Me.ActiveControl = lblHiddenSpacer
        dtpStartDate_ValueChanged()


    End Sub

    Private Sub btnWeight_Click(sender As Object, e As EventArgs) Handles btnWeight.Click
        frmWeights.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/msgbox-function
        Dim Msg, Style, Title, Response
        Msg = "Are you sure you want to exit the program?"
        Style = vbOKCancel ' + vbCritical + vbDefaultButton2   ' Define buttons.
        Title = "Exit?"

        Response = MsgBox(Msg, Style, Title)
        If Response = vbOK Then    ' User chose Yes.
            CloseAllFormsExceptMainForm()
            Me.Close()
        End If



    End Sub
End Class
