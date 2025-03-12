Imports System.Data.SqlClient

Public Class Category_Form
    ' Connection string to your database file
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Masoomul\Documents\MasoomToy\VioSM\SMMSD.mdf;Integrated Security=True"

    ' Form Load event handler
    Private Sub Category_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize DataGridView columns
        CatagoriesDGV.Columns.Add("CategoryID", "Category ID")
        CatagoriesDGV.Columns.Add("CategoryName", "Category Name")
        CatagoriesDGV.Columns.Add("CategoryDescription", "Category Description")
        LoadCategories() ' Load categories from the database into DataGridView
    End Sub

    ' Load categories from database into DataGridView
    Private Sub LoadCategories()
        Try
            ' Clear existing rows
            CatagoriesDGV.Rows.Clear()

            ' Check if the database file exists
            If Not IO.File.Exists("C:\Users\Masoomul\Documents\MasoomToy\VioSM\SMMSD.mdf") Then
                MessageBox.Show("Database file not found!")
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT CatId, CatName, CatDesc FROM Categoriestbl"
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    If table.Rows.Count = 0 Then
                        MessageBox.Show("No categories found.")
                        Return
                    End If
                    For Each row As DataRow In table.Rows
                        CatagoriesDGV.Rows.Add(row("CatId"), row("CatName"), row("CatDesc"))
                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    ' DataGridView CellClick event to populate TextBoxes with selected row data
    Private Sub CatagoriesDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CatagoriesDGV.CellClick
        ' Ensure a valid row is selected
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = CatagoriesDGV.Rows(e.RowIndex)
            TextBox2.Text = selectedRow.Cells("CategoryID").Value.ToString()
            TextBox4.Text = selectedRow.Cells("CategoryName").Value.ToString()
            TextBox3.Text = selectedRow.Cells("CategoryDescription").Value.ToString()
        End If
    End Sub

    ' Add Button Click Event
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim categoryID As String = TextBox2.Text
        Dim categoryName As String = TextBox4.Text
        Dim categoryDescription As String = TextBox3.Text

        If String.IsNullOrEmpty(categoryID) Or String.IsNullOrEmpty(categoryName) Or String.IsNullOrEmpty(categoryDescription) Then
            MessageBox.Show("Please fill in all fields before adding.")
        Else
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO Categoriestbl (CatId, CatName, CatDesc) VALUES (@CatId, @CatName, @CatDesc)"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@CatId", categoryID)
                        command.Parameters.AddWithValue("@CatName", categoryName)
                        command.Parameters.AddWithValue("@CatDesc", categoryDescription)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Category Added Successfully!")
                LoadCategories() ' Refresh the DataGridView
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
            Catch ex As Exception
                MessageBox.Show("Error adding category: " & ex.Message)
            End Try
        End If
    End Sub

    ' Update Button Click Event
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim categoryID As String = TextBox2.Text
        Dim categoryName As String = TextBox4.Text
        Dim categoryDescription As String = TextBox3.Text

        If String.IsNullOrEmpty(categoryID) Or String.IsNullOrEmpty(categoryName) Or String.IsNullOrEmpty(categoryDescription) Then
            MessageBox.Show("Please fill in all fields before updating.")
        Else
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "UPDATE Categoriestbl SET CatName = @CatName, CatDesc = @CatDesc WHERE CatId = @CatId"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@CatId", categoryID)
                        command.Parameters.AddWithValue("@CatName", categoryName)
                        command.Parameters.AddWithValue("@CatDesc", categoryDescription)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Category Updated Successfully!")
                LoadCategories() ' Refresh the DataGridView
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
            Catch ex As Exception
                MessageBox.Show("Error updating category: " & ex.Message)
            End Try
        End If
    End Sub

    ' Delete Button Click Event
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim categoryID As String = TextBox2.Text
        If String.IsNullOrEmpty(categoryID) Then
            MessageBox.Show("Please enter the category ID to delete.")
        Else
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM Categoriestbl WHERE CatId = @CatId"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@CatId", categoryID)
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Category Deleted Successfully!")
                LoadCategories() ' Refresh the DataGridView
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
            Catch ex As Exception
                MessageBox.Show("Error deleting category: " & ex.Message)
            End Try
        End If
    End Sub

    ' Logout Button Click Event
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MessageBox.Show("Logged Out Successfully!")
        Me.Close()
        Dim loginForm As New login()
        loginForm.Show()
    End Sub

    ' Close button (X) to exit the form
    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        Me.Close()
        Application.Exit()
    End Sub

    ' Return Button Click Event
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim adminDashboard As New Admin_Dashboard()
        adminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub CatagoriesDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CatagoriesDGV.CellContentClick

    End Sub

    Private Sub txtCategoryName_Click(sender As Object, e As EventArgs) Handles txtCategoryName.Click

    End Sub
End Class
