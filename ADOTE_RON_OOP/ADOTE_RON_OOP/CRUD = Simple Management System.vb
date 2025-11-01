Imports System.IO
Imports MySql.Data.MySqlClient
Public Class CRUD___Simple_Management_System
    Public con As New MySqlConnection("server = localhost; user = root; password = ; database = oop_crud")

    'main process
    Private Sub CRUD___Simple_Management_System_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayTable()
    End Sub

    Dim path As String = ""
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Try
            con.Open()
            Dim query1 As String = "INSERT INTO names(fname,mname,lname,suffix) VALUES (@fname,@mname,@lname,@suffix)"
            Dim cmd As New MySqlCommand(query1, con)
            cmd.Parameters.AddWithValue("@fname", txtFname.Text)
            cmd.Parameters.AddWithValue("@mname", txtMname.Text)
            cmd.Parameters.AddWithValue("@lname", txtLname.Text)
            cmd.Parameters.AddWithValue("@suffix", txtSuffix.Text)
            cmd.ExecuteNonQuery()
            Dim id As Long = cmd.LastInsertedId

            Dim query2 As String = "INSERT INTO students(nameID, phone, birth) VALUES (@id,@phone,@birth)"
            Dim cmd2 As New MySqlCommand(query2, con)
            cmd2.Parameters.AddWithValue("@id", id)
            cmd2.Parameters.AddWithValue("@phone", txtPhoneNumber.Text)
            cmd2.Parameters.AddWithValue("@birth", txtDob.Value.ToString("yyyy-MM-dd"))
            cmd2.ExecuteNonQuery()

            Dim query3 As String = "SELECT studID FROM students WHERE nameID = @nameID"
            Dim cmd3 As New MySqlCommand(query3, con)
            cmd3.Parameters.AddWithValue("@nameID", id)
            Dim studID As Long = Convert.ToInt64(cmd3.ExecuteScalar())

            If path <> "" Then
                Dim queryPic As String = "UPDATE students SET pic = @pic WHERE studID = @studID"
                Dim cmd4 As New MySqlCommand(queryPic, con)
                cmd4.Parameters.AddWithValue("@pic", File.ReadAllBytes(path))
                cmd4.Parameters.AddWithValue("@studID", studID)
                cmd4.ExecuteNonQuery()
            End If

            MsgBox("Student Added!", vbInformation, "Success!")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR")
        Finally
            GC.Collect()
            con.Close()
            displayTable()
            cleartextBox()
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            con.Open()
            Dim studID As Long = Convert.ToInt64(txtID.Text)

            ' Get the nameID for this student
            Dim queryGetNameID As String = "SELECT nameID FROM students WHERE studID = @studID"
            Dim cmdGetNameID As New MySqlCommand(queryGetNameID, con)
            cmdGetNameID.Parameters.AddWithValue("@studID", studID)
            Dim nameID As Long = Convert.ToInt64(cmdGetNameID.ExecuteScalar())

            ' Update names table
            Dim query1 As String = "UPDATE names SET fname=@fname, mname=@mname, lname=@lname, suffix=@suffix WHERE nameID=@nameID"
            Dim cmd As New MySqlCommand(query1, con)
            cmd.Parameters.AddWithValue("@fname", txtFname.Text)
            cmd.Parameters.AddWithValue("@mname", txtMname.Text)
            cmd.Parameters.AddWithValue("@lname", txtLname.Text)
            cmd.Parameters.AddWithValue("@suffix", txtSuffix.Text)
            cmd.Parameters.AddWithValue("@nameID", nameID)
            cmd.ExecuteNonQuery()

            ' Update students table
            Dim query2 As String = "UPDATE students SET phone=@phone, birth=@birth WHERE studID=@studID"
            Dim cmd2 As New MySqlCommand(query2, con)
            cmd2.Parameters.AddWithValue("@phone", txtPhoneNumber.Text)
            cmd2.Parameters.AddWithValue("@birth", txtDob.Value.ToString("yyyy-MM-dd"))
            cmd2.Parameters.AddWithValue("@studID", studID)
            cmd2.ExecuteNonQuery()

            ' Update photo if a new one was selected
            If path <> "" Then
                Dim queryPic As String = "UPDATE students SET pic = @pic WHERE studID = @studID"
                Dim cmd3 As New MySqlCommand(queryPic, con)
                cmd3.Parameters.AddWithValue("@pic", File.ReadAllBytes(path))
                cmd3.Parameters.AddWithValue("@studID", studID)
                cmd3.ExecuteNonQuery()
            End If

            MsgBox("Student Updated!", vbInformation, "Success!")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR")
        Finally
            GC.Collect()
            con.Close()
            displayTable()
            cleartextBox()
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                con.Open()
                Dim studID As Long = Convert.ToInt64(txtID.Text)

                ' Get the nameID for this student
                Dim queryGetNameID As String = "SELECT nameID FROM students WHERE studID = @studID"
                Dim cmdGetNameID As New MySqlCommand(queryGetNameID, con)
                cmdGetNameID.Parameters.AddWithValue("@studID", studID)
                Dim nameID As Long = Convert.ToInt64(cmdGetNameID.ExecuteScalar())

                ' Delete from students table first (child table)
                Dim query1 As String = "DELETE FROM students WHERE studID = @studID"
                Dim cmd1 As New MySqlCommand(query1, con)
                cmd1.Parameters.AddWithValue("@studID", studID)
                cmd1.ExecuteNonQuery()

                ' Delete from names table (parent table)
                Dim query2 As String = "DELETE FROM names WHERE nameID = @nameID"
                Dim cmd2 As New MySqlCommand(query2, con)
                cmd2.Parameters.AddWithValue("@nameID", nameID)
                cmd2.ExecuteNonQuery()

                MsgBox("Student Deleted!", vbInformation, "Success!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ERROR")
        Finally
            GC.Collect()
            con.Close()
            displayTable()
            cleartextBox()
        End Try
    End Sub

    Private Sub BtnUploadPhoto_Click(sender As Object, e As EventArgs) Handles BtnUploadPhoto.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            path = OpenFileDialog1.FileName
            picBox.Image = Image.FromFile(path)
            BtnUploadPhoto.Visible = False
        End If
    End Sub

    Private Sub studentTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentTable.CellClick
        If e.RowIndex < 0 Then
        Else
            Dim id As Long
            Try
                con.Open()
                id = studentTable.Rows(e.RowIndex).Cells(0).Value
                Dim query As String = "SELECT n.*,s.*, 
                                       TIMESTAMPDIFF(YEAR, s.birth, CURDATE()) AS Age
                                       FROM students s JOIN names n ON n.nameID = s.nameID WHERE studID = @id"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", id)
                Dim read As MySqlDataReader = cmd.ExecuteReader
                While read.Read
                    txtLname.Text = read.GetString("lname")
                    txtMname.Text = read.GetString("mname")
                    txtFname.Text = read.GetString("fname")
                    txtSuffix.Text = read.GetString("suffix")
                    txtID.Text = read.GetInt32("studID")
                    txtPhoneNumber.Text = read.GetString("phone")
                    txtDobb.Text = read.GetDateTime("birth")
                    txtAge.Text = read.GetInt64("Age")
                End While

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                GC.Collect()
                con.Close()
                getPhoto(id)
            End Try
        End If
    End Sub

    Private Sub txtDob_ValueChanged(sender As Object, e As EventArgs) Handles txtDob.ValueChanged
        Dim datess As String = txtDob.Value.ToString("yyyy-MM-dd")
        txtDobb.Text = datess
    End Sub
    'main processw

    'methods
    Public Sub displayTable()
        Try
            con.Open()
            Dim query As String = "SELECT * FROM studView"
            Dim dasd As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable
            dasd.Fill(dt)
            studentTable.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "CONNECTION ERROR!")
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub cleartextBox()
        For Each e As Object In CalPanel.Controls
            If TypeOf e Is TextBox Then
                CType(e, TextBox).Clear()
            End If
        Next
        picBox.Image = Nothing
        BtnUploadPhoto.Visible = True
        path = ""
    End Sub

    Public Sub getPhoto(id As Long)
        Try
            con.Open()
            Dim query As String = "SELECT pic FROM students WHERE studID = @userID"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@userID", id)
            Dim result As Object = cmd.ExecuteScalar
            If IsDBNull(result) Then
                BtnUploadPhoto.Visible = True
                picBox.Image = Nothing
            Else
                BtnUploadPhoto.Visible = False
                Dim imageBytes() As Byte = DirectCast(result, Byte())
                Dim ms As New MemoryStream(imageBytes)
                picBox.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GC.Collect()
            con.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartextBox()
    End Sub
    'methods
End Class