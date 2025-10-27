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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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
End Class