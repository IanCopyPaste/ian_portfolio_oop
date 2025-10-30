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
    End Sub
    'FILTER AREA ENDS
End Class