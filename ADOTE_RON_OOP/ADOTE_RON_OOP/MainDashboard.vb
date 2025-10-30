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
        Me.IsMdiContainer = True

        PictureBox1.SendToBack()

        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.Visible = False
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
        Dim childForm As New WEEK11_12()
        childForm.MdiParent = Me
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.Visible = True
                ctl.BringToFront()
            End If
        Next

        childForm.Show()
    End Sub
    Public Sub RefreshContent()
        Me.Refresh()

        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                If Me.MdiChildren.Length = 0 Then
                    ctl.SendToBack()
                End If
            End If
        Next
    End Sub

End Class