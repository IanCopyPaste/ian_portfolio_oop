Public Class WEEK5
    Private Sub WEEK5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartUpPanel.BringToFront()
        numBox.Text = "0"
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        StartUpPanel.BringToFront()
    End Sub


    'DATA TYPE PANEL SECTION HERE'
    Dim isTrue As Boolean = True
    Private Sub DataTbtn_Click(sender As Object, e As EventArgs) Handles DataTbtn.Click
        DataTypePanel.BringToFront()
        DataTypePanel.AutoScroll = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isTrue Then
            TextBox1.Text = "TRUE"
            isTrue = False
        ElseIf Not isTrue Then
            TextBox1.Text = "FALSE"
            isTrue = True
        End If

        TextBox2.Text = "
            Dim isTrue As Boolean = True

            If isTrue Then
            TextBox1.Text = ""TRUE""
            isTrue = False
        ElseIf Not (isTrue) Then
            TextBox1.Text = ""FALSE""
            isTrue = True
        End If"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bite As Byte = 255
        TextBox1.Text = bite.ToString
        TextBox2.Text = "
        Dim bite As Byte = 255
        TextBox1.Text = bite.ToString()"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num = 69
        TextBox1.Text = num.ToString
        TextBox2.Text = "
        Dim num As Integer = 69
        TextBox1.Text = num.ToString()"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pi = 3.14159265358979
        TextBox1.Text = pi.ToString
        TextBox2.Text = "
        Dim pi As Double = 3.14159265358979
        TextBox1.Text = pi.ToString"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim today = #9/18/2025 3:30:00 PM#
        TextBox1.Text = today.ToLongDateString
        TextBox2.Text = "
        Dim today As Date = #9/18/2025 3:30:00 PM#
        TextBox1.Text = today.ToLongDateString"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Ey = "A"c
        TextBox1.Text = Ey
        TextBox2.Text = "
        Dim Ey As Char = ""A""c
        TextBox1.Text = Ey"
    End Sub

    'DATA TYPE PANEL SECTION ENDS HERE'


    'CALCULATOR PANEL STARTS HERE'
    Dim firstnum, lastnum, result As Double
    Dim ops As Char
    Dim cont As String


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles calPanelBtn.Click
        CalPanel.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainDashboard.Show()
        Me.Close()
    End Sub

    'NUMBERS STARTS HERE
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btn00.Click, btnDot.Click
        Dim btn As Button = DirectCast(sender, Button)
        If numBox.Text = "0" Then
            numBox .Clear
        End If
        numBox.Text += btn.Text
        cont += btn.Text
    End Sub
    ''NUMBERS ENDS HERE


    'OPERATORS STARTS HERE
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        check()
        Try
            If firstnum = 0 Then
                firstnum = cont
            End If
            cont = ""
            ops = "+"c
            numBox.Text += "+"
            checkOperator(False)
        Catch ex As Exception
            MsgBox("ERROR OCCURED")
        End Try
    End Sub

    Private Sub btnDivi_Click(sender As Object, e As EventArgs) Handles btnDivi.Click
        check()
        Try
            If firstnum = 0 Then
                firstnum = cont
            End If
            cont = ""
            ops = "÷"c
            numBox.Text += "÷"
            checkOperator(False)
        Catch ex As Exception
            MsgBox("ERROR OCCURED")
        End Try
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        check()
        Try
            If firstnum = 0 Then
                firstnum = cont
            End If
            cont = ""
            ops = "x"c
            numBox.Text += "x"
            checkOperator(False)
        Catch ex As Exception
            MsgBox("ERROR OCCURED")
        End Try
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        check()
        Try
            If firstnum = 0 Then
                firstnum = cont
            End If
            cont = ""
            ops = "-"c
            numBox.Text += "-"
            checkOperator(False)
        Catch ex As Exception
            MsgBox("ERROR OCCURED")
        End Try
    End Sub

    Private Sub btnExpo_Click(sender As Object, e As EventArgs) Handles btnExpo.Click
        check()
        Try
            If firstnum = 0 Then
                firstnum = cont
            End If
            cont = ""
            ops = "^"c
            numBox.Text += "^"
            checkOperator(False)
        Catch ex As Exception
            MsgBox("ERROR OCCURED")
        End Try
    End Sub

    Private Sub btnIntDivi_Click(sender As Object, e As EventArgs) Handles btnIntDivi.Click
        check()
        Try
            If firstnum = 0 Then
                firstnum = cont
            End If
            cont = ""
            ops = "\"c
            numBox.Text += "\"
            checkOperator(False)
        Catch ex As Exception
            MsgBox("ERROR OCCURED")
        End Try
    End Sub

    Private Sub btrnExponent_Click(sender As Object, e As EventArgs) Handles btrnRemainder.Click
        check()
        Try
            If firstnum = 0 Then
                firstnum = cont
            End If
            cont = ""
            ops = "M"c
            numBox.Text += "%"
            checkOperator(False)
        Catch ex As Exception
            MsgBox("ERROR OCCURED")
        End Try
    End Sub
    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        Try
            If cont <> "" Then
                firstnum = CDbl(cont)
            End If
            result = Math.Sqrt(firstnum)
            firstnum = result
            cont = result.ToString()
            numBox.Text = result.ToString()
        Catch ex As Exception
            MsgBox("ERROR OCCURRED")
        End Try
    End Sub


    'OPERATORS ENDS HERE

    Private Sub btnEqa_Click(sender As Object, e As EventArgs) Handles btnEqa.Click
        Try
            lastnum = cont
            checkOperator(True)
            Select Case ops
                Case "+"c
                    result = firstnum + lastnum
                    firstnum = result
                    numBox.Text = result
                Case "÷"c
                    result = firstnum / lastnum
                    firstnum = result
                    numBox.Text = result
                Case "x"c
                    result = firstnum * lastnum
                    firstnum = result
                    numBox.Text = result
                Case "-"c
                    result = firstnum - lastnum
                    firstnum = result
                    numBox.Text = result
                Case "^"c
                    result = firstnum ^ lastnum
                    firstnum = result
                    numBox.Text = result
                Case "\"c
                    result = firstnum \ lastnum
                    firstnum = result
                    numBox.Text = result
                Case "M"c
                    result = firstnum Mod lastnum
                    firstnum = result
                    numBox.Text = result
            End Select
        Catch ex As Exception
            MsgBox("ERROR OCCURED")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cont = 0
        firstnum = 0
        lastnum = 0
        numBox.Clear()
        numBox.Text = "0"
        checkOperator(True)
    End Sub

    Sub check()
        If numBox.Text = "0" Then
            numBox.Clear()
        End If
    End Sub

    Public Sub checkOperator(work As Boolean)
        btnMulti.Enabled = work
        btnAdd.Enabled = work
        btnDivi.Enabled = work
        btnExpo.Enabled = work
        btrnRemainder.Enabled = work
        btnIntDivi.Enabled = work
        btnSqrt.Enabled = work
    End Sub

    'CALCULATOR PANEL ENDS HERE'
End Class