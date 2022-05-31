<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWeights
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dataGridViewWeightsDescending = New System.Windows.Forms.DataGridView()
        Me.btnAddWeight = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDeleteWeight = New System.Windows.Forms.Button()
        Me.dtpWeightDate = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.numWeight = New System.Windows.Forms.NumericUpDown()
        Me.btnSaveWeight = New System.Windows.Forms.Button()
        Me.lstWeights = New System.Windows.Forms.ListBox()
        Me.lblFocusDump = New System.Windows.Forms.Label()
        Me.chartWeight = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.rbTable = New System.Windows.Forms.RadioButton()
        Me.rbChart = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLast30 = New System.Windows.Forms.Button()
        Me.btnLast90 = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        CType(Me.dataGridViewWeightsDescending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGridViewWeightsDescending
        '
        Me.dataGridViewWeightsDescending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataGridViewWeightsDescending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewWeightsDescending.Enabled = False
        Me.dataGridViewWeightsDescending.Location = New System.Drawing.Point(129, 512)
        Me.dataGridViewWeightsDescending.MultiSelect = False
        Me.dataGridViewWeightsDescending.Name = "dataGridViewWeightsDescending"
        Me.dataGridViewWeightsDescending.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dataGridViewWeightsDescending.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewWeightsDescending.Size = New System.Drawing.Size(52, 54)
        Me.dataGridViewWeightsDescending.TabIndex = 0
        '
        'btnAddWeight
        '
        Me.btnAddWeight.Location = New System.Drawing.Point(57, 355)
        Me.btnAddWeight.Name = "btnAddWeight"
        Me.btnAddWeight.Size = New System.Drawing.Size(216, 23)
        Me.btnAddWeight.TabIndex = 2
        Me.btnAddWeight.Text = "Add Weight"
        Me.btnAddWeight.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(4, 452)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(321, 29)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDeleteWeight
        '
        Me.btnDeleteWeight.Location = New System.Drawing.Point(57, 384)
        Me.btnDeleteWeight.Name = "btnDeleteWeight"
        Me.btnDeleteWeight.Size = New System.Drawing.Size(216, 23)
        Me.btnDeleteWeight.TabIndex = 4
        Me.btnDeleteWeight.Text = "Delete Weight"
        Me.btnDeleteWeight.UseVisualStyleBackColor = True
        '
        'dtpWeightDate
        '
        Me.dtpWeightDate.Location = New System.Drawing.Point(58, 358)
        Me.dtpWeightDate.MaxDate = New Date(9021, 11, 13, 19, 34, 0, 0)
        Me.dtpWeightDate.Name = "dtpWeightDate"
        Me.dtpWeightDate.Size = New System.Drawing.Size(214, 20)
        Me.dtpWeightDate.TabIndex = 5
        Me.dtpWeightDate.Value = New Date(2021, 11, 13, 0, 0, 0, 0)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(57, 413)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(216, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'numWeight
        '
        Me.numWeight.DecimalPlaces = 1
        Me.numWeight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numWeight.Location = New System.Drawing.Point(96, 329)
        Me.numWeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numWeight.Minimum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.numWeight.Name = "numWeight"
        Me.numWeight.Size = New System.Drawing.Size(138, 20)
        Me.numWeight.TabIndex = 7
        Me.numWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numWeight.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'btnSaveWeight
        '
        Me.btnSaveWeight.Location = New System.Drawing.Point(57, 384)
        Me.btnSaveWeight.Name = "btnSaveWeight"
        Me.btnSaveWeight.Size = New System.Drawing.Size(216, 23)
        Me.btnSaveWeight.TabIndex = 8
        Me.btnSaveWeight.Text = "Save"
        Me.btnSaveWeight.UseVisualStyleBackColor = True
        '
        'lstWeights
        '
        Me.lstWeights.FormattingEnabled = True
        Me.lstWeights.Location = New System.Drawing.Point(24, 3)
        Me.lstWeights.Name = "lstWeights"
        Me.lstWeights.Size = New System.Drawing.Size(278, 264)
        Me.lstWeights.TabIndex = 9
        '
        'lblFocusDump
        '
        Me.lblFocusDump.AutoSize = True
        Me.lblFocusDump.Location = New System.Drawing.Point(259, 301)
        Me.lblFocusDump.Name = "lblFocusDump"
        Me.lblFocusDump.Size = New System.Drawing.Size(13, 13)
        Me.lblFocusDump.TabIndex = 10
        Me.lblFocusDump.Text = "0"
        Me.lblFocusDump.Visible = False
        '
        'chartWeight
        '
        ChartArea2.AxisY.Title = "Weight (pounds)"
        ChartArea2.Name = "ChartArea1"
        Me.chartWeight.ChartAreas.Add(ChartArea2)
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.chartWeight.Legends.Add(Legend2)
        Me.chartWeight.Location = New System.Drawing.Point(4, 3)
        Me.chartWeight.Name = "chartWeight"
        Me.chartWeight.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Weight (pounds)"
        Me.chartWeight.Series.Add(Series2)
        Me.chartWeight.Size = New System.Drawing.Size(321, 264)
        Me.chartWeight.TabIndex = 11
        Me.chartWeight.Text = "Weight Chart"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(21, 270)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(53, 13)
        Me.lblStartDate.TabIndex = 12
        Me.lblStartDate.Text = "01/01/01"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(259, 270)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(53, 13)
        Me.lblEndDate.TabIndex = 13
        Me.lblEndDate.Text = "12/31/99"
        '
        'rbTable
        '
        Me.rbTable.AutoSize = True
        Me.rbTable.Checked = True
        Me.rbTable.Location = New System.Drawing.Point(3, 1)
        Me.rbTable.Name = "rbTable"
        Me.rbTable.Size = New System.Drawing.Size(52, 17)
        Me.rbTable.TabIndex = 14
        Me.rbTable.TabStop = True
        Me.rbTable.Text = "Table"
        Me.rbTable.UseVisualStyleBackColor = True
        '
        'rbChart
        '
        Me.rbChart.AutoSize = True
        Me.rbChart.Location = New System.Drawing.Point(59, 1)
        Me.rbChart.Name = "rbChart"
        Me.rbChart.Size = New System.Drawing.Size(50, 17)
        Me.rbChart.TabIndex = 15
        Me.rbChart.Text = "Chart"
        Me.rbChart.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbChart)
        Me.Panel1.Controls.Add(Me.rbTable)
        Me.Panel1.Location = New System.Drawing.Point(105, 301)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 19)
        Me.Panel1.TabIndex = 16
        '
        'btnLast30
        '
        Me.btnLast30.AutoSize = True
        Me.btnLast30.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLast30.BackColor = System.Drawing.Color.SeaGreen
        Me.btnLast30.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLast30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast30.Location = New System.Drawing.Point(96, 270)
        Me.btnLast30.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLast30.Name = "btnLast30"
        Me.btnLast30.Size = New System.Drawing.Size(56, 25)
        Me.btnLast30.TabIndex = 17
        Me.btnLast30.Text = "30 days"
        Me.btnLast30.UseVisualStyleBackColor = False
        '
        'btnLast90
        '
        Me.btnLast90.AutoSize = True
        Me.btnLast90.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLast90.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLast90.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast90.Location = New System.Drawing.Point(150, 270)
        Me.btnLast90.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLast90.Name = "btnLast90"
        Me.btnLast90.Size = New System.Drawing.Size(56, 25)
        Me.btnLast90.TabIndex = 18
        Me.btnLast90.Text = "90 days"
        Me.btnLast90.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.AutoSize = True
        Me.btnAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Location = New System.Drawing.Point(204, 270)
        Me.btnAll.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(30, 25)
        Me.btnAll.TabIndex = 19
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'frmWeights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 484)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnLast90)
        Me.Controls.Add(Me.btnLast30)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.chartWeight)
        Me.Controls.Add(Me.lblFocusDump)
        Me.Controls.Add(Me.btnAddWeight)
        Me.Controls.Add(Me.btnSaveWeight)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lstWeights)
        Me.Controls.Add(Me.btnDeleteWeight)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.numWeight)
        Me.Controls.Add(Me.dataGridViewWeightsDescending)
        Me.Controls.Add(Me.dtpWeightDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmWeights"
        Me.Text = "Weights"
        CType(Me.dataGridViewWeightsDescending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataGridViewWeightsDescending As DataGridView
    Friend WithEvents btnAddWeight As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDeleteWeight As Button
    Friend WithEvents dtpWeightDate As DateTimePicker
    Friend WithEvents btnCancel As Button
    Friend WithEvents numWeight As NumericUpDown
    Friend WithEvents btnSaveWeight As Button
    Friend WithEvents lstWeights As ListBox
    Friend WithEvents lblFocusDump As Label
    Friend WithEvents chartWeight As DataVisualization.Charting.Chart
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents rbTable As RadioButton
    Friend WithEvents rbChart As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLast30 As Button
    Friend WithEvents btnLast90 As Button
    Friend WithEvents btnAll As Button
End Class
