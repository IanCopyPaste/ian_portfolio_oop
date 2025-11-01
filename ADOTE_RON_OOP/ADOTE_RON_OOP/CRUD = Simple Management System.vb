Imports MySql.Data.MySqlClient
Public Class CRUD___Simple_Management_System
    Public con As New MySqlConnection("server = localhost; user = root; password = ; database = oop_crud")
    Private Sub CRUD___Simple_Management_System_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayTable()
    End Sub

    Dim path As String = ""
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        If IsNumeric(txtPhoneNumber.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPhoneNumber.Text) Then
            Try
                con.Open()

                ' Insert into stud_names and get the auto-generated ID
                Dim query As String = "INSERT INTO stud_names(lname,fname,mname,suffix) VALUES (@l,@f,@m,@s); SELECT LAST_INSERT_ID();"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@l", UCase(txtLname.Text.Trim()))
                cmd.Parameters.AddWithValue("@f", UCase(txtFname.Text.Trim()))
                cmd.Parameters.AddWithValue("@m", UCase(txtMname.Text.Trim()))
                cmd.Parameters.AddWithValue("@s", UCase(txtSuffix.Text.Trim()))

                Dim id As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Dim query2 As String = "INSERT INTO students(nameID, phone_no, dateOfBirth, pic) VALUES (@id,@pn,@dob,@pic)"
                Dim cmd2 As New MySqlCommand(query2, con)
                cmd2.Parameters.AddWithValue("@id", id)
                cmd2.Parameters.AddWithValue("@pn", txtPhoneNumber.Text.Trim())
                cmd2.Parameters.AddWithValue("@dob", txtDob.Value.ToString("yyyy-MM-dd"))

                If Not String.IsNullOrEmpty(path) AndAlso IO.File.Exists(path) Then
                    Dim imgBytes() As Byte = IO.File.ReadAllBytes(path)
                    cmd2.Parameters.AddWithValue("@pic", imgBytes)
                Else
                    cmd2.Parameters.AddWithValue("@pic", DBNull.Value)
                End If

                cmd2.ExecuteNonQuery()
                MsgBox("Student inserted successfully!", vbInformation, "Success")

            Catch ex As MySqlException
                MsgBox("Database Error: " & ex.Message, vbCritical, "MySQL Error")
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, vbCritical, "Connection Error")
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                displayTable()
                cleartxtBoxes()
            End Try
        Else
            MsgBox("Please enter a valid phone number!", vbExclamation, "Invalid Input")
        End If
    End Sub

    Private Sub BtnUploadPhoto_Click(sender As Object, e As EventArgs) Handles BtnUploadPhoto.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            path = OpenFileDialog1.FileName
            picBox.Image = Image.FromFile(path)
            MsgBox(pushPhotoToDatabase(path))
            BtnUploadPhoto.Visible = False
        End If
    End Sub
    Public Function pushPhotoToDatabase(path As String)
        For Each p As String In path
            If p = "\" Then
                p = "\\"
            End If
            path += p
        Next
        Return path
    End Function

    Private Sub studentTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentTable.CellClick
        Dim id As Integer = studentTable.Rows(e.RowIndex).Cells(0).Value

    End Sub

    'methods
    Public Sub displayTable()
        Try
            con.Open()
            Dim query As String = "SELECT * FROM stud_view"
            Dim dapt As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable
            dapt.Fill(dt)
            studentTable.DataSource = dt
            MsgBox("database connected")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Connection Error!")
        Finally
            GC.Collect()
            con.Close()
        End Try
    End Sub
    Public Sub cleartxtBoxes()
        For Each e As Object In CalPanel.Controls
            If TypeOf e Is TextBox Then
                CType(e, TextBox).Clear()
            End If
        Next
    End Sub
    'methods end
End Class