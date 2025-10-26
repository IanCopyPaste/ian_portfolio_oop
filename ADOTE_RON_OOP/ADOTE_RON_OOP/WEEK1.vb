Public Class WEEK1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub WEEK1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        Label1.Parent = PictureBox3
        Label2.Parent = PictureBox3
        PictureBox1.Parent = PictureBox3
        PictureBox2.Parent = PictureBox3
    End Sub
End Class