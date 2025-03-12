Imports System.Data.SqlClient

Public Class Product_Form
    ' Connection string to the local database file
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Masoomul\Documents\MasoomToy\VioSM\SMMSD.mdf;Integrated Security=True"

    ' Load Form and retrieve data from the database
    Private Sub Product_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCategoryComboBox()    ' Populate the combo boxes with data on load
        PopulateSearchCategoryComboBox()  ' Populate search category ComboBox dynamically
        LoadData()    ' Load all products into DataGridView initially
    End Sub

    ' Populate categories in the ComboBox from the database (for product addition)
    Private Sub PopulateCategoryComboBox()
        ' Clear existing items to avoid duplicates
        cbSelectCategory.Items.Clear()

        ' Connect to the database and fetch categories
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT CatName FROM CategoriesTbl" ' Adjusted to match the correct column name
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ' Check if there are categories in the database
                If reader.HasRows Then
                    While reader.Read()
                        If reader("CatName") IsNot DBNull.Value Then ' Ensure value is not null
                            cbSelectCategory.Items.Add(reader("CatName").ToString()) ' Adjusted to match the correct column name
                        End If
                    End While
                Else
                    MessageBox.Show("No categories found in the database.")
                End If

                ' Add "Select Category" as a placeholder, but don't make it selectable
                cbSelectCategory.Text = "Select Category"
                cbSelectCategory.SelectedIndex = -1

            Catch ex As Exception
                MessageBox.Show("Error loading categories: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Populate categories in the ComboBox for searching products dynamically from the database
    Private Sub PopulateSearchCategoryComboBox()
        cbSearchCategory.Items.Clear()  ' Clear the previous items in the ComboBox

        ' Connect to the database and fetch categories for search
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT CatName FROM CategoriesTbl" ' Fetch categories dynamically
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ' Check if there are categories in the database
                If reader.HasRows Then
                    While reader.Read()
                        If reader("CatName") IsNot DBNull.Value Then ' Ensure value is not null
                            cbSearchCategory.Items.Add(reader("CatName").ToString()) ' Dynamically add categories
                        End If
                    End While
                Else
                    MessageBox.Show("No categories found in the database.")
                End If

                ' Add "Select Category" as a placeholder
                cbSearchCategory.Text = "Select Category"
                cbSearchCategory.SelectedIndex = -1

            Catch ex As Exception
                MessageBox.Show("Error loading search categories: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Load data into DataGridView (Products list)
    Private Sub LoadData(Optional ByVal categoryFilter As String = "")
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM ProductsTbl"

                ' If a category is selected in cbSearchCategory, filter by category
                If Not String.IsNullOrEmpty(categoryFilter) Then
                    query &= " WHERE ProdCat = @ProdCat"
                End If

                Dim adapter As New SqlDataAdapter(query, conn)
                If Not String.IsNullOrEmpty(categoryFilter) Then
                    adapter.SelectCommand.Parameters.AddWithValue("@ProdCat", categoryFilter)
                End If

                Dim table As New DataTable()
                adapter.Fill(table)
                ProductsDGV.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Add Product (using selected category from ComboBox)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtProductID.Text = "" OrElse txtProductName.Text = "" OrElse txtProductQuantity.Text = "" OrElse txtProductPrice.Text = "" OrElse cbSelectCategory.SelectedItem Is Nothing OrElse cbSelectCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO ProductsTbl (ProdId, ProdName, ProdQty, ProdPrice, ProdCat) VALUES (@ProdId, @ProdName, @ProdQty, @ProdPrice, @ProdCat)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProdID", txtProductID.Text)
                    cmd.Parameters.AddWithValue("@ProdName", txtProductName.Text)
                    cmd.Parameters.AddWithValue("@ProdQty", CInt(txtProductQuantity.Text))
                    cmd.Parameters.AddWithValue("@ProdPrice", CDbl(txtProductPrice.Text))
                    cmd.Parameters.AddWithValue("@ProdCat", cbSelectCategory.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product added successfully!")
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error adding product: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Update Product
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtProductID.Text = "" Then
            MessageBox.Show("Please enter the Product ID to update.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "UPDATE ProductsTbl SET ProdName = @ProdName, ProdQty = @ProdQty, ProdPrice = @ProdPrice, ProdCat = @ProdCat WHERE ProdID = @ProdID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProdID", txtProductID.Text)
                    cmd.Parameters.AddWithValue("@ProdName", txtProductName.Text)
                    cmd.Parameters.AddWithValue("@ProdQty", CInt(txtProductQuantity.Text))
                    cmd.Parameters.AddWithValue("@ProdPrice", CDbl(txtProductPrice.Text))
                    cmd.Parameters.AddWithValue("@ProdCat", cbSelectCategory.SelectedItem.ToString())
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product updated successfully!")
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error updating product: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Delete Product
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtProductID.Text = "" Then
            MessageBox.Show("Please enter the Product ID to delete.")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "DELETE FROM ProductsTbl WHERE ProdID = @ProdID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProdID", txtProductID.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product deleted successfully!")
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error deleting product: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Search Products by Category
    Private Sub cbSearchCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchCategory.SelectedIndexChanged
        ' If a category is selected in the search ComboBox, reload the data with a category filter
        If cbSearchCategory.SelectedIndex >= 0 Then
            LoadData(cbSearchCategory.SelectedItem.ToString())
        End If
    End Sub

    ' Refresh to show all products
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ' Reset cbSearchCategory and reload all data
        cbSearchCategory.SelectedIndex = -1
        LoadData()
    End Sub

    ' Close Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles X.Click
        ' Close the application and stop all processes
        Application.Exit()
    End Sub

    ' When a row is clicked in the DataGridView, populate the textboxes
    Private Sub ProductsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDGV.CellClick
        ' Get the index of the clicked row
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex >= 0 Then
            ' Retrieve the product details from the selected row
            txtProductID.Text = ProductsDGV.Rows(rowIndex).Cells("ProdID").Value.ToString()
            txtProductName.Text = ProductsDGV.Rows(rowIndex).Cells("ProdName").Value.ToString()
            txtProductQuantity.Text = ProductsDGV.Rows(rowIndex).Cells("ProdQty").Value.ToString()
            txtProductPrice.Text = ProductsDGV.Rows(rowIndex).Cells("ProdPrice").Value.ToString()
            cbSelectCategory.SelectedItem = ProductsDGV.Rows(rowIndex).Cells("ProdCat").Value.ToString()
        End If
    End Sub
    ' Navigation to Sellers section
    Private Sub btnSellers_Click(sender As Object, e As EventArgs)
        Dim sellerForm As New Seller_Form ' Ensure Seller_Form is the correct form name
        sellerForm.Show ' Open Seller_Form
        Hide ' Hide the current Category_Form
    End Sub
    ' Navigate to Category Form when btnCategories is clicked
    Private Sub btnCategories_Click(sender As Object, e As EventArgs)
        Dim categoryForm As New Category_Form
        categoryForm.Show
        Hide
    End Sub
    ' Navigation to Selling section

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MessageBox.Show("Logged Out Successfully!")
        Me.Close()
        Dim loginForm As New login()
        loginForm.Show()
    End Sub

    Private Sub txtProductName_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged

    End Sub

    Private Sub txtProductPrice_TextChanged(sender As Object, e As EventArgs) Handles txtProductPrice.TextChanged

    End Sub

    Private Sub txtProductQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtProductQuantity.TextChanged

    End Sub

    Private Sub txtProductID_TextChanged(sender As Object, e As EventArgs) Handles txtProductID.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' Create an instance of the Admin_Dashboard form
        Dim adminDashboard As New Admin_Dashboard()

        ' Show the Admin_Dashboard form
        adminDashboard.Show()

        ' Close the Selling_Form
        Me.Close()
    End Sub

    Private Sub ProductsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDGV.CellContentClick

    End Sub
End Class
