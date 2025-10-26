Public Class WEEK7
    '7 DAYS SECTION STARTS HERE
    Dim days(6) As String
    Private Sub DataTbtn_Click(sender As Object, e As EventArgs) Handles DaysBtn.Click
        DaysPanel.BringToFront()
        days(0) = "MONDAY"
        days(1) = "TUESDAY"
        days(2) = "WEDNESDAY"
        days(3) = "THURSDAY"
        days(4) = "FRIDAY"
        days(5) = "SATURDAY"
        days(6) = "SUNDAY"
    End Sub

    Private Sub Combo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo1.SelectedIndexChanged
        For i = 0 To days.Length - 1
            If Combo1.Text = days(i) Then
                dayLabel.Text = "Today is " & days(i)
                Exit Sub
            End If
        Next
    End Sub
    '7 DAYS SECTION ENDS HERE

    '12 MONTHS SECTIONS STARTS HERE
    Dim months(11) As String
    Private Sub calPanelBtn_Click(sender As Object, e As EventArgs) Handles MonthsBtn.Click
        MonthsPanel.BringToFront()
        months(0) = "JANUARY"
        months(1) = "FEBUARY"
        months(2) = "MARCH"
        months(3) = "APRIL"
        months(4) = "MAY"
        months(5) = "JUNE"
        months(6) = "JULY"
        months(7) = "AUGUST"
        months(8) = "SEPTEMBER"
        months(9) = "OCTOBER"
        months(10) = "NOVEMBER"
        months(11) = "DECEMBER"
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo2.SelectedIndexChanged
        For i = 0 To months.Length - 1
            If Combo2.Text = months(i) Then
                monthLabel.Text = "Month is " & months(i)
                Exit Sub
            End If
        Next
    End Sub

    '12 MONTHS SECTION ENDS HERE

    Private Sub WEEK7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartUpPanel.BringToFront()
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        StartUpPanel.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainDashboard.Show()
        Me.Close()
    End Sub
End Class