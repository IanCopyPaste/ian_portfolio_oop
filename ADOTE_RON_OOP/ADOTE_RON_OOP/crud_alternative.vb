Imports MySql.Data.MySqlClient

Public Class crud_alternative
    Dim con As New MySqlConnection("server = localhost; user = root; password = ; database = oop_crud")
    Private Sub crud_alternative_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayTable()
    End Sub

    Public Sub displayTable()
        Try
            con.Open()
            Dim query As String = "SELECT * FROM alt_crud"
            Dim dasd As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable
            dasd.Fill(dt)
            studentTable.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Connection Error")
        Finally
            con.Close()
        End Try
    End Sub

    Dim id As Integer

    Private Sub crtBtn_Click(sender As Object, e As EventArgs) Handles crtBtn.Click
        If txtProdName.Text <> "" And txtProdId.Text <> "" Then
            txtProdName.Clear()
            txtProdId.Clear()
        Else
            Try
                con.Open()
                Dim query As String = "INSERT INTO alt_crud (prod_name) VALUES (@name)"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@name", txtProdName.Text)
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                displayTable()
                txtProdId.Clear()
                txtProdId.Clear()
            End Try
        End If
    End Sub

    Private Sub updBtn_Click(sender As Object, e As EventArgs) Handles updBtn.Click
        Try
            con.Open()
            Dim query As String = "UPDATE alt_crud
                                  SET prod_name = @name
                                  WHERE prod_id = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@name", txtProdName.Text)
            cmd.Parameters.AddWithValue("@id", txtProdId.Text)
            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            displayTable()
            txtProdId.Clear()
            txtProdName.Clear()
        End Try
    End Sub

    Private Sub studentTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentTable.CellClick
        id = studentTable.Rows(e.RowIndex).Cells(0).Value
        Try
            con.Open()
            Dim query As String = "SELECT * FROM alt_crud WHERE prod_id = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            Dim read As MySqlDataReader = cmd.ExecuteReader
            While read.Read
                txtProdId.Text = read.GetInt32("prod_id")
                txtProdName.Text = read.GetString("prod_name")
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        Try
            con.Open()
            Dim query As String = "DELETE FROM alt_crud
                                  WHERE prod_id = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", txtProdId.Text)
            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            displayTable()
            txtProdId.Clear()
            txtProdName.Clear()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            con.Open()
            Dim query As String
            If String.IsNullOrWhiteSpace(txtSearch.Text) Then
                query = "SELECT * FROM alt_crud"
            Else
                query = "SELECT * FROM alt_crud WHERE prod_id LIKE @text OR prod_name LIKE @text"
            End If
            Dim cmd As New MySqlCommand(query, con)
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                cmd.Parameters.AddWithValue("@text", "%" & txtSearch.Text & "%")
            End If
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            studentTable.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Connection Error")
        Finally
            con.Close()
        End Try
    End Sub
End Class