<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoiceForm))
        txtSearchProduct = New TextBox()
        lblSearchProduct = New Label()
        clbProducts = New CheckedListBox()
        txtCustomerName = New TextBox()
        txtPhoneNumber = New TextBox()
        btnGenerateInvoice = New Button()
        lblCustomerName = New Label()
        lblPhoneNumber = New Label()
        lblProduct = New Label()
        btnViewCustomerRecords = New Button()
        Label2 = New Label()
        Label1 = New Label()
        btnReturn = New Button()
        btnLogout = New Button()
        btnLogo = New PictureBox()
        CType(btnLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearchProduct
        ' 
        txtSearchProduct.BackColor = Color.MediumSlateBlue
        txtSearchProduct.Location = New Point(384, 240)
        txtSearchProduct.Margin = New Padding(3, 4, 3, 4)
        txtSearchProduct.Name = "txtSearchProduct"
        txtSearchProduct.Size = New Size(455, 27)
        txtSearchProduct.TabIndex = 1
        ' 
        ' lblSearchProduct
        ' 
        lblSearchProduct.AutoSize = True
        lblSearchProduct.BackColor = Color.MediumSlateBlue
        lblSearchProduct.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblSearchProduct.ForeColor = Color.Transparent
        lblSearchProduct.Location = New Point(155, 239)
        lblSearchProduct.Name = "lblSearchProduct"
        lblSearchProduct.Size = New Size(160, 28)
        lblSearchProduct.TabIndex = 8
        lblSearchProduct.Text = "Search Product:"
        ' 
        ' clbProducts
        ' 
        clbProducts.BackColor = Color.MediumSlateBlue
        clbProducts.FormattingEnabled = True
        clbProducts.Location = New Point(384, 303)
        clbProducts.Margin = New Padding(3, 4, 3, 4)
        clbProducts.Name = "clbProducts"
        clbProducts.Size = New Size(455, 114)
        clbProducts.TabIndex = 2
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.BackColor = Color.MediumSlateBlue
        txtCustomerName.Location = New Point(384, 142)
        txtCustomerName.Margin = New Padding(3, 4, 3, 4)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(455, 27)
        txtCustomerName.TabIndex = 0
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = Color.MediumSlateBlue
        txtPhoneNumber.Location = New Point(384, 189)
        txtPhoneNumber.Margin = New Padding(3, 4, 3, 4)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(455, 27)
        txtPhoneNumber.TabIndex = 3
        ' 
        ' btnGenerateInvoice
        ' 
        btnGenerateInvoice.BackColor = Color.MediumSlateBlue
        btnGenerateInvoice.Font = New Font("Open Sans Semibold", 13F, FontStyle.Bold)
        btnGenerateInvoice.ForeColor = Color.White
        btnGenerateInvoice.Location = New Point(155, 450)
        btnGenerateInvoice.Margin = New Padding(3, 4, 3, 4)
        btnGenerateInvoice.Name = "btnGenerateInvoice"
        btnGenerateInvoice.Size = New Size(327, 44)
        btnGenerateInvoice.TabIndex = 4
        btnGenerateInvoice.Text = "Generate Invoice"
        btnGenerateInvoice.UseVisualStyleBackColor = False
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.BackColor = Color.MediumSlateBlue
        lblCustomerName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblCustomerName.ForeColor = Color.Transparent
        lblCustomerName.Location = New Point(155, 138)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(169, 28)
        lblCustomerName.TabIndex = 5
        lblCustomerName.Text = "Customer Name:"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.BackColor = Color.MediumSlateBlue
        lblPhoneNumber.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPhoneNumber.ForeColor = Color.Transparent
        lblPhoneNumber.Location = New Point(155, 188)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(160, 28)
        lblPhoneNumber.TabIndex = 6
        lblPhoneNumber.Text = "Phone Number:"
        ' 
        ' lblProduct
        ' 
        lblProduct.AutoSize = True
        lblProduct.BackColor = Color.MediumSlateBlue
        lblProduct.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblProduct.ForeColor = Color.Transparent
        lblProduct.Location = New Point(155, 303)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(100, 28)
        lblProduct.TabIndex = 7
        lblProduct.Text = "Products:"
        ' 
        ' btnViewCustomerRecords
        ' 
        btnViewCustomerRecords.BackColor = Color.MediumSlateBlue
        btnViewCustomerRecords.Font = New Font("Open Sans Semibold", 13F, FontStyle.Bold)
        btnViewCustomerRecords.ForeColor = Color.White
        btnViewCustomerRecords.Location = New Point(488, 450)
        btnViewCustomerRecords.Name = "btnViewCustomerRecords"
        btnViewCustomerRecords.Size = New Size(351, 44)
        btnViewCustomerRecords.TabIndex = 5
        btnViewCustomerRecords.Text = "Customer Records"
        btnViewCustomerRecords.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gray
        Label2.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(292, 24)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(431, 34)
        Label2.TabIndex = 46
        Label2.Text = "Toy Shop Management System"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DimGray
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(433, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 20)
        Label1.TabIndex = 47
        Label1.Text = "Invoice Generator"
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.DarkGray
        btnReturn.FlatAppearance.BorderColor = Color.DarkGray
        btnReturn.FlatAppearance.BorderSize = 0
        btnReturn.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnReturn.ForeColor = Color.MediumSlateBlue
        btnReturn.Location = New Point(22, 461)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(94, 35)
        btnReturn.TabIndex = 48
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.DarkGray
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        btnLogout.ForeColor = Color.MediumSlateBlue
        btnLogout.Location = New Point(22, 502)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 33)
        btnLogout.TabIndex = 49
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnLogo
        ' 
        btnLogo.BackColor = Color.Transparent
        btnLogo.Image = CType(resources.GetObject("btnLogo.Image"), Image)
        btnLogo.Location = New Point(22, 12)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(135, 108)
        btnLogo.SizeMode = PictureBoxSizeMode.Zoom
        btnLogo.TabIndex = 50
        btnLogo.TabStop = False
        ' 
        ' InvoiceForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(984, 547)
        Controls.Add(btnLogo)
        Controls.Add(btnLogout)
        Controls.Add(btnReturn)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(btnViewCustomerRecords)
        Controls.Add(lblCustomerName)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblProduct)
        Controls.Add(lblSearchProduct)
        Controls.Add(txtSearchProduct)
        Controls.Add(clbProducts)
        Controls.Add(txtCustomerName)
        Controls.Add(txtPhoneNumber)
        Controls.Add(btnGenerateInvoice)
        Name = "InvoiceForm"
        Text = "Invoice Form"
        CType(btnLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearchProduct As TextBox
    Friend WithEvents lblSearchProduct As Label
    Friend WithEvents clbProducts As CheckedListBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents btnGenerateInvoice As Button
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents btnViewCustomerRecords As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLogo As PictureBox
End Class
