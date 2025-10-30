Imports System.Media

Public Class MainDashboard
    Private Sub WEEK1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        WEEK1.Show()
        Me.Hide()
    End Sub

    Private Sub WEEK2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WEEK2ToolStripMenuItem.Click
        WEEK2.Show()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub WEEK5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WEEK5ToolStripMenuItem.Click
        WEEK5.Show()
        Me.Hide()
    End Sub

    Private Sub WEEK5ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WEEK6ToolStripMenuItem1.Click
        WEEK6.Show()
        Me.Hide()
    End Sub

    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        ' Make parent form an MDI container
        Me.IsMdiContainer = True

        ' --- Ensure PictureBox stays behind everything ---
        PictureBox1.SendToBack()

        ' --- Bring the MdiClient area to the front ---
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.Visible = False  ' Hide initially
            End If
        Next
    End Sub

    Private Sub WEEK7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WEEK7ToolStripMenuItem.Click
        WEEK7.Show()
        Me.Hide()
    End Sub
    Sub PlayGnarly()
        Dim player As New SoundPlayer("C:\Users\CLIENT\Downloads\gnarly.wav")
        player.Play()
    End Sub

    Private Sub GamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GamesToolStripMenuItem.Click
        GAME.Show()
        Me.Close()
    End Sub

    Private Sub WEEK1011ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WEEK1011ToolStripMenuItem.Click
        ShowMdiChild()
    End Sub

    Private Sub ShowMdiChild()
        ' Show your MDI child form
        Dim childForm As New WEEK11_12()
        childForm.MdiParent = Me

        ' Make MDI client visible and bring to front
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.Visible = True
                ctl.BringToFront()
            End If
        Next

        childForm.Show()
    End Sub
    Public Sub RefreshContent()
        ' Refresh your controls, data, etc.
        Me.Refresh()

        ' Send MDI client to back if no children
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                If Me.MdiChildren.Length = 0 Then
                    ctl.SendToBack()
                End If
            End If
        Next
    End Sub

End Class