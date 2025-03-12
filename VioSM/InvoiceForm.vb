Imports System.Data.SqlClient

Public Class InvoiceForm
    ' Connection string to the local database file
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Masoomul\Documents\MasoomToy\VioSM\SMMSD.mdf;Integrated Security=True"

    ' Dictionary to store selected product quantities
    Private ProductQuantities As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()

    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load products into the CheckedListBox
        UpdateProductList()
    End Sub

    Private Sub UpdateProductList(Optional filter As String = "")
        ' Clear existing items
        clbProducts.Items.Clear()

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' SQL Query with optional filter for search
                Dim query As String = "SELECT ProdName FROM ProductsTbl WHERE ProdName LIKE @Filter"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Filter", "%" & filter & "%")

                    ' Execute query and add products to the CheckedListBox
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            If reader("ProdName") IsNot DBNull.Value Then
                                clbProducts.Items.Add(reader("ProdName").ToString())
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        ' Update the product list based on the search term
        UpdateProductList(txtSearchProduct.Text)
    End Sub

    Private Sub btnGenerateInvoice_Click(sender As Object, e As EventArgs) Handles btnGenerateInvoice.Click
        ' Get selected products and their quantities
        ProductQuantities.Clear()
        For Each product In clbProducts.CheckedItems
            Dim quantity As Integer = GetQuantity(product.ToString())
            ProductQuantities(product.ToString()) = quantity
        Next

        ' Insert the invoice data into the database
        InsertInvoiceData()

        ' Show a preview of the invoice
        PreviewInvoice()

        ' Open the Customer Records Form to show the updated data
        Dim customerRecordsForm As New CustomerRecordsForm()
        customerRecordsForm.ShowDialog()
    End Sub

    Private Sub InsertInvoiceData()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                ' Insert each product record into the database
                For Each kvp In ProductQuantities
                    Dim query As String = "INSERT INTO CustomerRecordsTbl (CustomerName, PhoneNumber, Product, Quantity, TotalAmount, InvoiceDate) 
                                           VALUES (@CustomerName, @PhoneNumber, @Product, @Quantity, @TotalAmount, @InvoiceDate)"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                        cmd.Parameters.AddWithValue("@Product", kvp.Key)
                        cmd.Parameters.AddWithValue("@Quantity", kvp.Value)
                        cmd.Parameters.AddWithValue("@TotalAmount", kvp.Value * GetProductPrice(kvp.Key))
                        cmd.Parameters.AddWithValue("@InvoiceDate", DateTime.Now)

                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PreviewInvoice()
        ' Build the invoice text preview
        Dim previewText As String = "Invoice Preview" & vbCrLf
        previewText &= "-----------------------------------------------------------" & vbCrLf
        previewText &= "Customer Name: " & txtCustomerName.Text & vbCrLf
        previewText &= "Phone Number: " & txtPhoneNumber.Text & vbCrLf
        previewText &= "Invoice Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & vbCrLf
        previewText &= "-----------------------------------------------------------" & vbCrLf

        Dim totalInvoiceAmount As Decimal = 0
        For Each kvp In ProductQuantities
            Dim productName As String = kvp.Key
            Dim quantity As Integer = kvp.Value
            Dim productPrice As Decimal = GetProductPrice(productName)
            Dim totalAmount As Decimal = quantity * productPrice
            totalInvoiceAmount += totalAmount
            previewText &= $"Product: {productName}, Quantity: {quantity}, Unit Price: {productPrice:C}, Total: {totalAmount:C}" & vbCrLf
        Next

        previewText &= "-----------------------------------------------------------" & vbCrLf
        previewText &= $"Total Invoice Amount: {totalInvoiceAmount:C}" & vbCrLf
        previewText &= "-----------------------------------------------------------" & vbCrLf
        previewText &= "Terms and Conditions:" & vbCrLf
        previewText &= "1. Payment is due within 30 days of the invoice date." & vbCrLf
        previewText &= "2. For any inquiries, contact our customer service." & vbCrLf
        previewText &= "Thank you for doing business with us!"

        ' Show preview form with the generated text
        Dim previewForm As New InvoicePreviewForm(txtCustomerName.Text, txtPhoneNumber.Text, previewText)
        previewForm.ShowDialog()
    End Sub

    ' Method to get the quantity for a product
    Private Function GetQuantity(productName As String) As Integer
        ' For simplicity, return a fixed quantity (replace with actual input logic)
        Return 1 ' Example default quantity
    End Function

    ' Method to get the product price from the database
    Private Function GetProductPrice(productName As String) As Decimal
        Dim productPrice As Decimal = 0

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT ProdPrice FROM ProductsTbl WHERE ProdName = @ProductName"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductName", productName)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        productPrice = Convert.ToDecimal(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching product price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return productPrice
    End Function

    Private Sub btnViewCustomerRecords_Click(sender As Object, e As EventArgs) Handles btnViewCustomerRecords.Click
        Dim customerRecordsForm As New CustomerRecordsForm()
        customerRecordsForm.ShowDialog()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim adminDashboard As New Admin_Dashboard()
        adminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MessageBox.Show("Logged Out Successfully!")
        Me.Close()
        Dim loginForm As New login()
        loginForm.Show()
    End Sub
End Class
