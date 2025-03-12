Imports System.Data.SqlClient

Public Class CustomerRecordsForm
    Inherits Form

    ' Connection string to the local database file
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Masoomul\Documents\MasoomToy\VioSM\SMMSD.mdf;Integrated Security=True"

    ' Declare the DataGridView and Button as WithEvents for event handling
    Friend WithEvents dgvCustomerRecords As DataGridView
    Friend WithEvents btnClose As Button

    ' Event handler for form load
    Private Sub CustomerRecordsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerRecords()
    End Sub

    ' Load customer records from database
    Private Sub LoadCustomerRecords()
        Try
            Dim customerRecordsTable As New DataTable()

            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim query As String = "SELECT CustomerName AS [Customer Name], PhoneNumber AS [Phone Number], 
                                       Product AS [Product Name], Quantity, TotalAmount AS [Total Amount], 
                                       InvoiceDate AS [Invoice Date] FROM CustomerRecordsTbl"

                Using cmd As New SqlCommand(query, conn)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(customerRecordsTable)
                    End Using
                End Using
            End Using

            dgvCustomerRecords.DataSource = customerRecordsTable
            dgvCustomerRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show($"Error loading customer records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Close button event handler
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
