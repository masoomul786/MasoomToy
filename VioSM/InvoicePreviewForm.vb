Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class InvoicePreviewForm
    Private _customerName As String
    Private _phoneNumber As String
    Private _invoiceText As String

    Public Sub New(customerName As String, phoneNumber As String, invoiceText As String)
        InitializeComponent()
        _customerName = customerName
        _phoneNumber = phoneNumber
        _invoiceText = invoiceText
    End Sub

    Private Sub InvoicePreviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the RichTextBox text to the invoice preview text
        rtbInvoicePreview.Text = _invoiceText
    End Sub

    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        If String.IsNullOrEmpty(rtbInvoicePreview.Text) Then
            MessageBox.Show("Please preview the invoice before generating the PDF.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Generate final invoice PDF when this button is clicked
        Dim pdfPath As String = "C:\Users\Masoomul\Documents\Bills\Invoice_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".pdf"
        Try
            Using doc As New Document(PageSize.A4)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(pdfPath, FileMode.Create))
                doc.Open()

                ' Add Logo
                Dim logoPath As String = "C:\Users\Masoomul\Documents\MasoomToy\VioSM\Resources\logo.png"
                If File.Exists(logoPath) Then
                    Dim logo As Image = Image.GetInstance(logoPath)
                    logo.ScaleToFit(100, 100)
                    logo.Alignment = Image.ALIGN_LEFT
                    doc.Add(logo)
                End If

                ' Add Company Name and Address
                doc.Add(New Paragraph("MasoomToy Ltd.", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18)))
                doc.Add(New Paragraph("123 Toy Street, Toy City, Country"))
                doc.Add(New Paragraph("Phone: +1234567890"))
                doc.Add(New Paragraph("Email: info@masoomtoy.com"))
                doc.Add(New Paragraph("-----------------------------------------------------------"))

                ' Add Invoice Title
                doc.Add(New Paragraph("INVOICE", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22)))
                doc.Add(New Paragraph("-----------------------------------------------------------"))


                ' Add Preview Content
                Dim invoiceParagraph As New Paragraph(_invoiceText, FontFactory.GetFont(FontFactory.HELVETICA, 12))
                doc.Add(invoiceParagraph)



                ' Close the document
                doc.Close()
            End Using

            ' Notify user of successful PDF generation
            MessageBox.Show("PDF generated successfully at: " & pdfPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
