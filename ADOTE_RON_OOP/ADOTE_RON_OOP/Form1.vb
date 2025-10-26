Public Class Form1
    Dim user As String = "admin"
    Dim pass As String = "1234"

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("PLEASE ENTER CREDENTIALS")
        ElseIf TextBox1.Text = user And TextBox2.Text = pass Then
            MainDashboard.Show()
            Me.Hide()
        Else
            MsgBox("INCORRECT USERNAME/PASSWORD TANGA")
        End If
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = LogInBtn
    End Sub
End Class