Public Class frmWeights
    Dim dtWeightsDescending As DataTable
    Public firstChronoligicalDateInWeightsTable As DateTime
    Public dblMostRecentWeight As Double
    Private Sub frmWeights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillWeightsDesendingTableAndWeightsListBox()

        btnAddWeight.Visible = True
        btnClose.Visible = True
        btnCancel.Visible = False

        dtpWeightDate.Visible = False
        dtpWeightDate.MaxDate = Date.Today.AddDays(1).AddMilliseconds(-1)
        numWeight.Visible = False
        btnSaveWeight.Visible = False

        plotWeightsOnChart(30)

        Me.ActiveControl = lblFocusDump

        'AddHandler txtBoxWeight.KeyPress, AddressOf frmAddEntryRevised.onlyAllowDigits

    End Sub

    Public Sub plotWeightsOnChart(ByVal numberOfDays As Integer)
        chartWeight.Series("Weight (pounds)").Points.Clear()
        chartWeight.ChartAreas(0).AxisX.LabelStyle.Enabled = False
        Dim thisWeight As Double
        Dim intDaysToPlot As Integer = numberOfDays
        Dim startDate As DateTime = Now().AddDays(-intDaysToPlot).Date
        lblStartDate.Text = startDate.ToShortDateString()
        Dim endDate As DateTime = Now().Date()
        lblEndDate.Text = endDate.ToShortDateString()
        For i As Integer = -intDaysToPlot To 0
            thisWeight = frmUserProfile.getBestWeightByDate2(frmMain.user_ID, Now().AddDays(i))
            chartWeight.Series("Weight (pounds)").Points.AddXY(CDbl(i), thisWeight)
        Next
    End Sub


    Public Sub fillWeightsDesendingTableAndWeightsListBox()
        Dim strSQL As String = "SELECT weight_entry_ID, weight_entry_datetime, weight from weight WHERE user_ID =" & frmMain.user_ID & " ORDER BY weight_entry_datetime DESC"
        dtWeightsDescending = frmMain.getDataTableFromSQLSELECTQuery(strSQL)
        dataGridViewWeightsDescending.DataSource = dtWeightsDescending
        'dataGridViewWeightsDescending.Columns(1).HeaderText = "       Date       "
        'dataGridViewWeightsDescending.Columns(2).HeaderText = "      Weight      "
        Dim tempString As String
        lstWeights.Items.Clear()
        For i As Integer = 0 To dtWeightsDescending.Rows().Count() - 1
            tempString = dtWeightsDescending.Rows(i).Item("weight_entry_datetime").ToString() & vbTab & dtWeightsDescending.Rows(i).Item("weight").ToString & " pounds"
            lstWeights.Items.Add(tempString)
        Next


        Try
            firstChronoligicalDateInWeightsTable = dtWeightsDescending.Rows(dtWeightsDescending.Rows.Count() - 1).Item("weight_entry_datetime")
        Catch ex As Exception
            firstChronoligicalDateInWeightsTable = Now()
        End Try


        'datetimeFirstChronoligicalDateInWeightsTable =\
        '
        'dtWeightsDescending.Rows(dtWeightsDescending.Rows().Count() - 1).Item("weight_entry_datetime")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddWeight_Click(sender As Object, e As EventArgs) Handles btnAddWeight.Click
        'MsgBox(dtpWeightDate.MaxDate.ToString())
        dtpWeightDate.Value = Now()
        dtpWeightDate.Visible = True
        numWeight.Visible = True
        Try
            numWeight.Value = dtWeightsDescending.Rows(0).Item("weight")
        Catch ex As Exception
            numWeight.Value = 150
        End Try

        btnDeleteWeight.Visible = False
        btnCancel.Visible = True
        btnSaveWeight.Visible = True
        btnAddWeight.Visible = False

        Me.ActiveControl = lblFocusDump

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dtpWeightDate.Visible = False
        numWeight.Visible = False
        btnCancel.Visible = False
        btnDeleteWeight.Visible = True
        btnSaveWeight.Visible = False
        btnAddWeight.Visible = True

        Me.ActiveControl = lblFocusDump
    End Sub

    Private Sub btnSaveWeight_Click(sender As Object, e As EventArgs) Handles btnSaveWeight.Click
        Dim weightManagementInstance As New weightManagement
        Dim thisWeightObject As New weightManagement.weightObject
        thisWeightObject.userId = frmMain.user_ID
        thisWeightObject.weight = CDbl(numWeight.Value)
        thisWeightObject.weightDate = dtpWeightDate.Value

        weightManagementInstance.createWeight(thisWeightObject)

        fillWeightsDesendingTableAndWeightsListBox()

        btnCancel.PerformClick()
        frmMain.fillWeightsDataTable()
        Dim thisDate As DateTime = Now()
        If (thisDate.Date >= frmMain.dtpStartDate.Value.Date) And (thisDate.Date <= frmMain.dtpStartDate.Value.AddDays(6).Date) Then
            frmMain.populateCalorieGoalsForTheWeek()
            frmMain.populateCalorieBalanceForTheWeek()
            frmMain.updatePrintCalendarTotalRowsForTheWeek()
        End If
        plotWeightsOnChart(30)
        Me.ActiveControl = lblFocusDump
    End Sub

    Private Sub btnDeleteWeight_Click(sender As Object, e As EventArgs) Handles btnDeleteWeight.Click

        If lstWeights.SelectedIndex <> -1 Then
            Dim weightManagementInstance As New weightManagement
            'Dim thisWeightObject As New weightManagement.weightObject
            'thisWeightObject.userId = frmMain.user_ID
            'thisWeightObject.weight = CDbl(numWeight.Value)
            'thisWeightObject.weightDate = dtpWeightDate.Value

            'weightManagementInstance.createWeight(thisWeightObject)
            Dim weight_ID As Integer = dtWeightsDescending.Rows(lstWeights.SelectedIndex).Item("weight_entry_ID")
            Dim thisDate As DateTime = dtWeightsDescending.Rows(lstWeights.SelectedIndex).Item("weight_entry_datetime")
            weightManagementInstance.deleteWeight(weight_ID)


            fillWeightsDesendingTableAndWeightsListBox()
            frmMain.fillWeightsDataTable()


            If (thisDate.Date >= frmMain.dtpStartDate.Value.Date) And (thisDate.Date <= frmMain.dtpStartDate.Value.AddDays(6).Date) Then
                frmMain.populateCalorieGoalsForTheWeek()
                frmMain.populateCalorieBalanceForTheWeek()
                frmMain.updatePrintCalendarTotalRowsForTheWeek()
            End If


        End If
        plotWeightsOnChart(30)

        Me.ActiveControl = lblFocusDump

    End Sub

    Private Sub rbGraph_CheckedChanged(sender As Object, e As EventArgs) Handles rbChart.CheckedChanged, rbTable.CheckedChanged

        If rbChart.Checked = True Then
            chartWeight.Visible = True
            lstWeights.Visible = False
            btnDeleteWeight.Enabled = False
            lblEndDate.Visible = True
            lblStartDate.Visible = True
            btnLast30.Visible = True
            btnLast90.Visible = True
            btnAll.Visible = True
        Else
            chartWeight.Visible = False
            lstWeights.Visible = True
            btnDeleteWeight.Enabled = True
            lblEndDate.Visible = False
            lblStartDate.Visible = False
            btnLast30.Visible = False
            btnLast90.Visible = False
            btnAll.Visible = False
        End If

    End Sub

    Private Sub btnLast30_Click(sender As Object, e As EventArgs) Handles btnLast30.Click
        plotWeightsOnChart(30)
        btnLast30.BackColor = Color.SeaGreen
        btnLast90.BackColor = SystemColors.Control
        btnAll.BackColor = SystemColors.Control
    End Sub

    Private Sub btnLast90_Click(sender As Object, e As EventArgs) Handles btnLast90.Click
        plotWeightsOnChart(90)
        btnLast30.BackColor = SystemColors.Control
        btnLast90.BackColor = Color.SeaGreen
        btnAll.BackColor = SystemColors.Control
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        'From:
        'https://stackoverflow.com/questions/42560803/get-calendar-days-between-two-dates
        'Dim days As Integer =(date2.Date-date1.Date).Days 
        'https://stackoverflow.com/users/134204/panagiotis-kanavos

        Dim intDays As Integer = (Now.Date - firstChronoligicalDateInWeightsTable.Date).Days
        plotWeightsOnChart(intDays)
        btnLast30.BackColor = SystemColors.Control
        btnLast90.BackColor = SystemColors.Control
        btnAll.BackColor = Color.SeaGreen

    End Sub
End Class