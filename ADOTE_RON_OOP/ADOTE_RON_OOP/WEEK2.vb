Imports System.Linq.Expressions
Public Class WEEK2
    Private Sub WEEK2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartUpPanel.BringToFront()
        Label2.Parent = PictureBox5
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Sub back2Main_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MainDashboard.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        StartUpPanel.BringToFront()
    End Sub
    'THIS IS CLASS AND OBJECTS SECTION: 
    Dim initiate As New class_object

    Private Sub GenBtn_Click(sender As Object, e As EventArgs) Handles GenBtn.Click
        genNameBox.Text = initiate.name
        GenAgeBox.Text = initiate.age
        GenSexBox.Text = initiate.sex
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        genNameBox.Clear()
        GenAgeBox.Clear()
        GenSexBox.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ClassBtn.Click
        ClassPanel.BringToFront()
    End Sub

    'THE CLASS AND OBJECTS SECTION ENDS HERE


    'THE ENCAPSULATION SECTION STARTS HERE:
    Dim rand As New Random
    Private names() As String = {"JACK MARSTON", "JOHN MARSTON", "ARTHUR MORGAN", "MICAH BELL", "DUTCH VAN DER LINDE"}
    Private age() As Integer = {29, 30, 36, 47, 50}
    Dim rando As Integer

    Public Function getName() As String
        Dim name As String
        name = names(rando)
        Return name
    End Function
    Public Function getAge() As Integer
        Dim ages As Integer
        ages = age(rando)
        Return ages
    End Function

    Public Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        rando = rand.Next(5)
        nameBox.Text = getName()
        ageBox.Text = getAge.ToString()
    End Sub

    Private Sub EncapBtn_Click(sender As Object, e As EventArgs) Handles EncapBtn.Click
        EncapPanel.BringToFront()
    End Sub

    'THE ENCAPSULATION SECTION ENDS HERE


    'THE INHERITANCE SECTION STARTS HERE:
    Dim a As New Puppy()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles animalbtn.Click
        nimal.Text = "Animals"
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.Items.RemoveAt(0)
        Next
        CheckedListBox1.Items.Add(a.type)
        CheckedListBox1.SetItemChecked(0, True)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        nimal.Text = "Dogs"
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.Items.RemoveAt(0)
        Next

        CheckedListBox1.Items.Add(a.type)
        CheckedListBox1.Items.Add(a.sound)

        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        nimal.Text = "Puppies"
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.Items.RemoveAt(0)
        Next

        CheckedListBox1.Items.Add(a.type)
        CheckedListBox1.Items.Add(a.sound)
        CheckedListBox1.Items.Add(a.trick)

        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, True)
        Next
    End Sub
    Private Sub InheritBtn_Click(sender As Object, e As EventArgs) Handles InheritBtn.Click
        InheritPanel.BringToFront()
        InheritPanel.AutoScroll = True
    End Sub

    'THE INHERITANCE SECTION ENDS HERE:


    'THE POLYMORPHISM SECTION STARTS HERE:
    Dim b As New basedAnimal
    Dim c As New CAT
    Dim d As New lion
    Private Sub PolyBtn_Click(sender As Object, e As EventArgs) Handles PolyBtn.Click
        PolyPanel.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BaseBtn.Click
        Label9.Text = "Animals"
        CheckedListBox2.Items.RemoveAt(0)
        CheckedListBox2.Items.Add(b.sound)
        CheckedListBox2.SetItemChecked(0, True)
    End Sub

    Private Sub catBtn_Click(sender As Object, e As EventArgs) Handles catBtn.Click
        Label9.Text = "Cats"
        CheckedListBox2.Items.RemoveAt(0)
        CheckedListBox2.Items.Add(c.sound)
        CheckedListBox2.SetItemChecked(0, True)
    End Sub

    Private Sub LionBtn_Click(sender As Object, e As EventArgs) Handles LionBtn.Click
        Label9.Text = "Lions"
        CheckedListBox2.Items.RemoveAt(0)
        CheckedListBox2.Items.Add(d.sound)
        CheckedListBox2.SetItemChecked(0, True)
    End Sub
    'THE POLYMORPHISM SECTION ENDS HERE:



    'THE INTERFACE SECTION STARTS HERE
    Dim dog As InterfaceAnimal = New ClassDog
    Dim cat As InterfaceAnimal = New ClassCat
    Private Sub InterBtn_Click(sender As Object, e As EventArgs) Handles InterBtn.Click
        InterPanel.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles PusaBtn.Click
        cat.Speak()
        cat.Tricks()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BogBtn.Click
        dog.Speak()
        dog.Tricks()
    End Sub
    'THE INTERFACE SECTION ENDS HERE
End Class