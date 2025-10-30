Public Class WEEK11_12

    Private Sub CloseAndRefreshParent()
        Dim parentForm As Form = Me.MdiParent
        Me.Close()

        ' Refresh the parent after closing
        If parentForm IsNot Nothing Then
            ' Call a refresh method on parent if you have one
            CType(parentForm, MainDashboard).RefreshContent()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CloseAndRefreshParent()
    End Sub

    Public Sub clearTextBox(obj As String)
        Dim targetPanel As Panel = DirectCast(AllPanel.Controls(obj), Panel)

        For Each ctrl As Control In targetPanel.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            End If
        Next
    End Sub

    'ASC AREA START
    Private Sub AscBtn_Click(sender As Object, e As EventArgs) Handles AscBtn.Click
        AscPanel.BringToFront()
        clearTextBox("AscPanel")
    End Sub

    Private Sub ascConvertBtn_Click(sender As Object, e As EventArgs) Handles ascConvertBtn.Click
        Try
            If txtASC.Text = "" Then
                MsgBox("PLS ENTER ANYTHING ATLEAST", vbInformation, "ERROR")
            Else
                Dim puso = Asc(txtASC.Text)
                txtASCresult.Text = puso
                txtASC.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Please Enter a valid value")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtASCW.Text = "" Then
                MsgBox("PLS ENTER ANYTHING ATLEAST", vbInformation, "ERROR")
            Else
                Dim nigga = Asc(txtASCW.Text)
                txtASCWresult.Text = nigga
                txtASCW.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Please Enter a valid value")
        End Try
    End Sub


    'ASC AREA ENDS


    'CHAR/W AREA START
    Private Sub chrBtn_Click(sender As Object, e As EventArgs) Handles chrBtn.Click
        characterPanel.BringToFront()
        clearTextBox("characterPanel")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles chrConvert.Click
        Try
            If txtCHR.Text = "" Then
                MsgBox("PLS ENTER ANYTHING ATLEAST", vbInformation, "ERROR")
            Else
                Dim chr1 = Chr(txtCHR.Text)
                txtCHRresult.Text = chr1
                txtCHR.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Please Enter a valid value")
        End Try
    End Sub

    Private Sub CHRW_Click(sender As Object, e As EventArgs) Handles CHRW.Click
        Try
            If txtCHRW.Text = "" Then
                MsgBox("PLS ENTER ANYTHING ATLEAST", vbInformation, "ERROR")
            Else
                Dim chrw = Chr(txtCHRW.Text)
                txtCHRWresult.Text = chrw
                txtCHRW.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Please Enter a valid value")
        End Try
    End Sub

    'CHAR/W AREA ENDS

    'FILTER AREA STARTS
    Private Sub filterBtn_Click(sender As Object, e As EventArgs) Handles filterBtn.Click
        filterPanel.BringToFront()
        clearTextBox("filterPanel")
        For Each ctrl As Control In filterPanel.Controls
            If TypeOf ctrl Is ListBox Then
                CType(ctrl, ListBox).Items.Clear()
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If txtAddItems.Text = "" Then
            MsgBox("Please Enter Something", vbInformation, "Pls Add Item")
        ElseIf findDupe(txtAddItems.text) Then
            MsgBox("'" & txtAddItems.Text & "'" & " Already exists!!", vbInformation, "Duplication Error")
        Else
            AddItems.Items.Add(txtAddItems.Text)
        End If
        txtAddItems.Focus()
        txtAddItems.Clear()
    End Sub

    Public Function findDupe(text As String)
        For Each e In AddItems.Items
            If e = text Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub filtbtn_Click(sender As Object, e As EventArgs) Handles filtbtn.Click
        If String.IsNullOrWhiteSpace(txtFilterItems.Text) Then
            MsgBox("Please enter something.", vbInformation, "Input Required")
            Exit Sub
        End If

        FilterItems.Items.Clear()

        Dim tempList As New List(Of String)
        For Each itm In AddItems.Items
            tempList.Add(itm.ToString)
        Next

        Dim result = Filter(tempList.ToArray, txtFilterItems.Text, True, vbTextCompare)

        If result.Length > 0 Then
            For Each itm In result
                FilterItems.Items.Add(itm)
            Next
        Else
            MsgBox("No matching items found.", vbInformation, "Filter Result")
        End If
        txtFilterItems.Clear()
    End Sub

    'FILTER AREA ENDS


    'FORMAT AREA STARTS
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim val = MonthCalendar1.SelectionStart
        formatbox.Text = "You picked " & Format(val, "yyyy-MM-dd")
    End Sub

    Private Sub formatBtn_Click(sender As Object, e As EventArgs) Handles formatBtn.Click
        FormatPanel.BringToFront()
        formatbox.Clear()
    End Sub

    'FORMAT AREA STARTS


    'FORMAT CURRENCY AREA STARTS
    Private Sub formatCurBtn_Click(sender As Object, e As EventArgs) Handles formatCurBtn.Click
        FormatCurPanel.BringToFront()
        clearTextBox("FormatCurPanel")
    End Sub

    Private Sub conv_Click(sender As Object, e As EventArgs) Handles conv.Click
        If IsNumeric(txtPrice.Text) Then
            Dim prc = FormatCurrency(txtPrice.Text)
            priceResult.Text = prc
        Else
            MsgBox("Please Enter a Number", vbInformation, "Wrong Input")
        End If
    End Sub

    'FORMAT CURRENCY AREA ENDS

    'FORMAT DATE AND TIME AREA STARTS
    Private Sub formatDateTimeBtn_Click(sender As Object, e As EventArgs) Handles formatDateTimeBtn.Click
        FormatDateTimePanel.BringToFront()
        clearTextBox("FormatDateTimePanel")
    End Sub

    Private Sub timerforFormatDT_Tick(sender As Object, e As EventArgs) Handles timerforFormatDT.Tick
        Dim dt As Date = Now
        genDate.Text = FormatDateTime(dt, vbGeneralDate)
        LDate.Text = FormatDateTime(dt, vbLongDate)
        SDate.Text = FormatDateTime(dt, vbShortDate)
        LTime.Text = FormatDateTime(dt, vbLongTime)
        STime.Text = FormatDateTime(dt, vbShortTime)
    End Sub


    'FORMAT DATE AND TIME AREA STARTS

    'FORMAT NUMBER AREA STARTS
    Private Sub formatNumberBtn_Click(sender As Object, e As EventArgs) Handles formatNumberBtn.Click
        FormatNumberPanel.BringToFront()
        clearTextBox("FormatNumberPanel")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNumeric(txtNum.Text) Then
            Dim num As Double = txtNum.Text
            num1.Text = FormatNumber(num)
            num2.Text = FormatNumber(num, 3)
            num3.Text = FormatNumber(num, 0)
            num4.Text = FormatNumber(-5000, 2, , vbTrue)
            num5.Text = FormatNumber(0.75, 2, vbTrue)
            num6.Text = FormatNumber(0.75, 2, vbFalse)
        Else
            MsgBox("Please Enter a Number", vbInformation, "Wrong Input")
        End If
    End Sub


    'FORMAT NUMBER AREA ENDS


    'FORMAT PERCENT AREA STARTS
    Private Sub formatPercentbtn_Click(sender As Object, e As EventArgs) Handles formatPercentbtn.Click
        FormatPercentPanel.BringToFront()
        clearTextBox("FormatPercentPanel")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles percentBtn.Click
        If IsNumeric(txtPercent.Text) Then
            Dim val As Double = txtPercent.Text
            num01.Text = FormatPercent(val)
            num02.Text = FormatPercent(val, 1)
            num03.Text = FormatPercent(val, 0)
            num04.Text = FormatPercent(-0.25, 2, , vbTrue)
            num05.Text = FormatPercent(0.045, 3, vbTrue)
            num06.Text = FormatPercent(0.045, 3, vbFalse)
        Else
            MsgBox("Please Enter a Number", vbInformation, "Wrong Input")
        End If
    End Sub

    'FORMAT PERCENT AREA ENDS


    'RIGHT AREA STARTS
    Private Sub rightBtn_Click(sender As Object, e As EventArgs) Handles rightBtn.Click
        RightPanel.BringToFront()
        clearTextBox("RightPanel")
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        Dim val As String = txtWord.Text
        word1.Text = Microsoft.VisualBasic.Strings.Right(val, 5)
        word2.Text = Microsoft.VisualBasic.Strings.Right(val, 2)
        word3.Text = Microsoft.VisualBasic.Strings.Right(val, 20)
    End Sub

    'RIGHT AREA ENDS


    'RSET AREA STARTS
    Private Sub btnRSet_Click(sender As Object, e As EventArgs) Handles btnRSet.Click
        Dim val = txtword1.Text
        txtResult1.Text = RSet(val, 5)
        txtResult2.Text = RSet(val, 2)
        txtResult3.Text = RSet(val, 10)
    End Sub

    Private Sub rsetBtn_Click(sender As Object, e As EventArgs) Handles rsetBtn.Click
        RsetPanel.BringToFront()
        clearTextBox("RsetPanel")
    End Sub
    'RSET AREA ENDS

    'RSET AREA STARTS
End Class