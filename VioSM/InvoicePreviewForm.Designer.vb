<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoicePreviewForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        rtbInvoicePreview = New RichTextBox()
        btnGeneratePDF = New Button()
        SuspendLayout()
        ' 
        ' rtbInvoicePreview
        ' 
        rtbInvoicePreview.Location = New Point(98, 12)
        rtbInvoicePreview.Name = "rtbInvoicePreview"
        rtbInvoicePreview.ReadOnly = True
        rtbInvoicePreview.ScrollBars = RichTextBoxScrollBars.Vertical
        rtbInvoicePreview.Size = New Size(327, 426)
        rtbInvoicePreview.TabIndex = 0
        rtbInvoicePreview.Text = ""
        ' 
        ' btnGeneratePDF
        ' 
        btnGeneratePDF.BackColor = Color.MediumSlateBlue
        btnGeneratePDF.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnGeneratePDF.Location = New Point(445, 199)
        btnGeneratePDF.Name = "btnGeneratePDF"
        btnGeneratePDF.Size = New Size(94, 29)
        btnGeneratePDF.TabIndex = 1
        btnGeneratePDF.Text = "Invoice Gen"
        btnGeneratePDF.UseVisualStyleBackColor = False
        ' 
        ' InvoicePreviewForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(568, 450)
        Controls.Add(btnGeneratePDF)
        Controls.Add(rtbInvoicePreview)
        Name = "InvoicePreviewForm"
        Text = "InvoicePreviewForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents rtbInvoicePreview As RichTextBox
    Friend WithEvents btnGeneratePDF As Button
End Class
