Public Class WEEK6
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainDashboard.Show()
        Me.Close()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        StartUpPanel.BringToFront()
    End Sub
    Private Sub WEEK6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartUpPanel.BringToFront()
        ComboBox1.Text = "AND"
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'DATE AND TIME PANEL STARTS HERE

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DateTimePanelbtn.Click
        ditntaymPanel.BringToFront()
        labelDate.Text = Format(Date.Now, ("MMMM dd, yyyy"))
        For i = 0 To 23
            For x = 0 To 59
                For o = 0 To 59
                    LtimeLabel.Text = $"{i:D2}:{x:D2}:{o:D2}"
                    Application.DoEvents()
                    Threading.Thread.Sleep(100)
                Next
            Next
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelTime.Text = TimeOfDay
    End Sub

    'DATE AND TIME PANEL ENDS HERE



    'AGE CALCULATOR PANEL STARTS HERE
    Private Sub DataTbtn_Click(sender As Object, e As EventArgs) Handles DataTbtn.Click
        AgeCalcuPanel.BringToFront()
        MonthCalendar1.MaxDate = Date.Now
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label19.Text = TimeOfDay
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userBirth As Date = MonthCalendar1.SelectionStart
        Dim now As Date = Date.Now
        Dim age As Integer = now.Year - userBirth.Year

        If (now.Month < userBirth.Month) OrElse (now.Day = userBirth.Day AndAlso now.Day < userBirth.Day) Then
            age -= 1
        End If

        AgeBox.Text = "YOUR ARE " & age.ToString & " YEARS OLD!"
    End Sub

    'AGE CALCULATOR PANEL ENDS HERE



    'TRUTH TABLE PANEL STARTS HERE
    Private Sub calPanelBtn_Click(sender As Object, e As EventArgs) Handles calPanelBtn.Click
        TruthTablePanel.BringToFront()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim a As Boolean = True
        Dim b As Boolean = False
        Dim show As Boolean = True
        Label4.Text = "B"
        Select Case ComboBox1.Text
            Case "AND"
                BOXA1.Visible = show
                BOXA2.Visible = show
                BOXA3.Visible = show
                BOXA4.Visible = show
                Label3.Visible = show
                BOXB3.Visible = show
                BOXB4.Visible = show
                BOXRES3.Visible = show
                BOXRES4.Visible = show
                Label10.Visible = show
                Label11.Visible = show

                BOXA1.Text = a
                BOXB1.Text = b
                BOXA2.Text = b
                BOXB2.Text = a
                BOXA3.Text = a
                BOXB3.Text = a
                BOXA4.Text = b
                BOXB4.Text = b

                BOXRES1.Text = a And b
                BOXRES2.Text = b And b
                BOXRES3.Text = a And a
                BOXRES4.Text = b And b
            Case "OR"
                BOXA1.Visible = show
                BOXA2.Visible = show
                BOXA3.Visible = show
                BOXA4.Visible = show
                Label3.Visible = show
                BOXB3.Visible = show
                BOXB4.Visible = show
                BOXRES3.Visible = show
                BOXRES4.Visible = show
                Label10.Visible = show
                Label11.Visible = show

                BOXA1.Text = a
                BOXB1.Text = b
                BOXA2.Text = b
                BOXB2.Text = a
                BOXA3.Text = a
                BOXB3.Text = a
                BOXA4.Text = b
                BOXB4.Text = b

                BOXRES1.Text = a Or b
                BOXRES2.Text = b Or a
                BOXRES3.Text = a Or a
                BOXRES4.Text = b Or b
            Case "NOT"
                show = False
                BOXB1.Text = a
                BOXB2.Text = b
                BOXA1.Visible = show
                BOXA2.Visible = show
                BOXA3.Visible = show
                BOXA4.Visible = show
                Label3.Visible = show
                BOXB3.Visible = show
                BOXB4.Visible = show
                BOXRES3.Visible = show
                BOXRES4.Visible = show
                Label10.Visible = show
                Label11.Visible = show
                Label4.Text = "A"

                BOXRES1.Text = Not a
                BOXRES2.Text = Not b
            Case "XOR"
                BOXA1.Visible = show
                BOXA2.Visible = show
                BOXA3.Visible = show
                BOXA4.Visible = show
                Label3.Visible = show
                BOXB3.Visible = show
                BOXB4.Visible = show
                BOXRES3.Visible = show
                BOXRES4.Visible = show
                Label10.Visible = show
                Label11.Visible = show

                BOXA1.Text = a
                BOXB1.Text = b
                BOXA2.Text = b
                BOXB2.Text = a
                BOXA3.Text = a
                BOXB3.Text = a
                BOXA4.Text = b
                BOXB4.Text = b

                BOXRES1.Text = a Xor b
                BOXRES2.Text = b Xor a
                BOXRES3.Text = a Xor a
                BOXRES4.Text = b Xor b
        End Select
    End Sub
    'TRUTH TABLE PANEL ENDS HERE

End Class