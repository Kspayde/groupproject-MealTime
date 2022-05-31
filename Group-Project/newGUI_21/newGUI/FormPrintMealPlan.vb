Public Class frmPrintMealPlan
    Dim strHTMLString As String

    Private Sub frmPrintMealPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        webPrintMealPlan.DocumentText = frmMain.strHTMLCalendarString
        'https://stackoverflow.com/questions/9428587/only-horizontal-scrolling-in-a-panel
        'https://stackoverflow.com/users/5781465/kamgman
        ' Me.AutoScroll = False
        '  Me.VerticalScroll.Enabled = False
        '  Me.VerticalScroll.Visible = False
        '  Me.VerticalScroll.Maximum = 0
        '  Me.AutoScroll = True

        'Me.AutoScroll = False
        'Me.HorizontalScroll.Enabled = True
        'Me.HorizontalScroll.Visible = True
        'Me.AutoScroll = True

        webPrintMealPlan.ScrollBarsEnabled = True


        'https://stackoverflow.com/questions/27628216/how-to-make-button-background-transparent
        'https://stackoverflow.com/users/1354960/hkimpact
        'Making Existing Button Transparent
        'btnClose.FlatStyle = Windows.Forms.FlatStyle.Flat
        'btnClose.FlatAppearance.BorderSize = 0
        'btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent
        'btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent
        'btnClose.BackColor = Color.Transparent

        '       btnSavePrintablePlan.FlatStyle = Windows.Forms.FlatStyle.Flat
        '       btnSavePrintablePlan.FlatAppearance.BorderSize = 0
        '       btnSavePrintablePlan.FlatAppearance.MouseDownBackColor = Color.Transparent
        '       btnSavePrintablePlan.FlatAppearance.MouseOverBackColor = Color.Transparent
        '       btnSavePrintablePlan.BackColor = Color.Transparent
    End Sub

    '  Private Sub btnSavePrintablePlan_Click_1(sender As Object, e As EventArgs)
    '      'https://www.tutorialspoint.com/vb.net/vb.net_savefile_dialog.htm
    '      SaveFileDialog1.Filter = "html Files (*.html*)|*.html"
    '      SaveFileDialog1.FileName = "MyWeeklyPlan.html"
    '  If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
    '     Then
    '          My.Computer.FileSystem.WriteAllText _
    '       (SaveFileDialog1.FileName, strHTMLString, True)
    '  End If
    '  End Sub

    '  Private Sub btnClose_Click(sender As Object, e As EventArgs)
    '  Me.Close()
    '  End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'https://www.tutorialspoint.com/vb.net/vb.net_savefile_dialog.htm
        SaveFileDialog1.Filter = "html Files (*.html*)|*.html"
        SaveFileDialog1.FileName = "MyWeeklyPlan.html"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
       Then
            My.Computer.FileSystem.WriteAllText _
         (SaveFileDialog1.FileName, strHTMLString, True)
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub


    'https://www.codeproject.com/Tips/1025766/VB-NET-Dynamically-Resize-and-Reposition-All-Contr
    '   Public Class Form1
    '   Dim rs As New Resizer
    '
    ''    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '           rs.FindAllControls(Me)
    '
    '    End Sub

    '  Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    '         rs.ResizeAllControls(Me)
    'End Sub
    'End Class





End Class