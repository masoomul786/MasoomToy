Public Class Seller_Dashboard
    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        ' Navigate to Category Form when btnCategories is clicked
        Dim categoryForm As New Category_Form()
        categoryForm.Show()
        Me.Hide()
    End Sub
    ' Navigate to Product Form when btnProducts is clicked
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Dim productForm As New Product_Form() ' Assuming Product_Form exists
        productForm.Show()
        Me.Hide()
    End Sub
    ' Navigate to Selling Form when btnSelling is clicked

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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub btnRedirectInvoice_Click(sender As Object, e As EventArgs) Handles btnRedirectInvoice.Click
        ' Check if the InvoiceForm is already open
        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is InvoiceForm Then
                ' If it's already open, bring it to the front
                openForm.BringToFront()
                Return ' Exit the event handler
            End If
        Next

        ' If the form is not open, create and show it
        Dim invoiceForm As New InvoiceForm()
        invoiceForm.Show()
    End Sub

    Private Sub Seller_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class