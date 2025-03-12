<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Form))
        X = New Button()
        btnLogout = New Button()
        ProductsDGV = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnAdd = New Button()
        txtProductName = New TextBox()
        txtProductQuantity = New TextBox()
        txtCategoryName = New Label()
        txtCategoryQuantity = New Label()
        txtProductID = New TextBox()
        txtCategoryID = New Label()
        btnLogo = New PictureBox()
        Panel1 = New Panel()
        btnRefresh = New Button()
        cbSearchCategory = New ComboBox()
        cbSelectCategory = New ComboBox()
        txtCategory = New Label()
        txtProductPrice = New TextBox()
        txtCategoryPrice = New Label()
        Label1 = New Label()
        btnReturn = New Button()
        Label2 = New Label()
        CType(ProductsDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' X
        ' 
        X.ForeColor = Color.Transparent
        X.Image = CType(resources.GetObject("X.Image"), Image)
        X.Location = New Point(1241, 0)
        X.Margin = New Padding(4)
        X.Name = "X"
        X.Size = New Size(40, 43)
        X.TabIndex = 21
        X.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.DarkGray
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.MediumSlateBlue
        btnLogout.Location = New Point(34, 638)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 33)
        btnLogout.TabIndex = 19
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' ProductsDGV
        ' 
        ProductsDGV.BackgroundColor = Color.Silver
        ProductsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ProductsDGV.Location = New Point(444, 96)
        ProductsDGV.Name = "ProductsDGV"
        ProductsDGV.RowHeadersWidth = 51
        ProductsDGV.Size = New Size(526, 461)
        ProductsDGV.TabIndex = 23
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.MediumSlateBlue
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(15, 470)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(398, 33)
        btnUpdate.TabIndex = 22
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.MediumSlateBlue
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(15, 524)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(398, 33)
        btnDelete.TabIndex = 21
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.MediumSlateBlue
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(15, 418)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(398, 33)
        btnAdd.TabIndex = 20
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtProductName
        ' 
        txtProductName.BackColor = Color.MediumSlateBlue
        txtProductName.ForeColor = Color.White
        txtProductName.Location = New Point(145, 156)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(268, 32)
        txtProductName.TabIndex = 19
        ' 
        ' txtProductQuantity
        ' 
        txtProductQuantity.BackColor = Color.MediumSlateBlue
        txtProductQuantity.ForeColor = Color.White
        txtProductQuantity.Location = New Point(145, 221)
        txtProductQuantity.Name = "txtProductQuantity"
        txtProductQuantity.Size = New Size(268, 32)
        txtProductQuantity.TabIndex = 18
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.AutoSize = True
        txtCategoryName.BackColor = Color.LightCyan
        txtCategoryName.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryName.ForeColor = Color.MediumSlateBlue
        txtCategoryName.Location = New Point(14, 159)
        txtCategoryName.Margin = New Padding(4, 0, 4, 0)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(70, 23)
        txtCategoryName.TabIndex = 16
        txtCategoryName.Text = "Name"
        ' 
        ' txtCategoryQuantity
        ' 
        txtCategoryQuantity.AutoSize = True
        txtCategoryQuantity.BackColor = Color.LightCyan
        txtCategoryQuantity.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryQuantity.ForeColor = Color.MediumSlateBlue
        txtCategoryQuantity.Location = New Point(15, 224)
        txtCategoryQuantity.Margin = New Padding(4, 0, 4, 0)
        txtCategoryQuantity.Name = "txtCategoryQuantity"
        txtCategoryQuantity.Size = New Size(93, 23)
        txtCategoryQuantity.TabIndex = 15
        txtCategoryQuantity.Text = "Quantity"
        ' 
        ' txtProductID
        ' 
        txtProductID.BackColor = Color.MediumSlateBlue
        txtProductID.ForeColor = Color.White
        txtProductID.Location = New Point(145, 96)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(268, 32)
        txtProductID.TabIndex = 13
        ' 
        ' txtCategoryID
        ' 
        txtCategoryID.AutoSize = True
        txtCategoryID.BackColor = Color.LightCyan
        txtCategoryID.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryID.ForeColor = Color.MediumSlateBlue
        txtCategoryID.Location = New Point(14, 96)
        txtCategoryID.Margin = New Padding(4, 0, 4, 0)
        txtCategoryID.Name = "txtCategoryID"
        txtCategoryID.Size = New Size(30, 23)
        txtCategoryID.TabIndex = 4
        txtCategoryID.Text = "ID"
        ' 
        ' btnLogo
        ' 
        btnLogo.BackColor = Color.Transparent
        btnLogo.Image = CType(resources.GetObject("btnLogo.Image"), Image)
        btnLogo.Location = New Point(34, 31)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(108, 93)
        btnLogo.SizeMode = PictureBoxSizeMode.Zoom
        btnLogo.TabIndex = 20
        btnLogo.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(cbSearchCategory)
        Panel1.Controls.Add(cbSelectCategory)
        Panel1.Controls.Add(txtCategory)
        Panel1.Controls.Add(txtProductPrice)
        Panel1.Controls.Add(txtCategoryPrice)
        Panel1.Controls.Add(ProductsDGV)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(txtProductName)
        Panel1.Controls.Add(txtProductQuantity)
        Panel1.Controls.Add(txtCategoryName)
        Panel1.Controls.Add(txtCategoryQuantity)
        Panel1.Controls.Add(txtProductID)
        Panel1.Controls.Add(txtCategoryID)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(148, 94)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1018, 601)
        Panel1.TabIndex = 15
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.MediumSlateBlue
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(876, 55)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(94, 35)
        btnRefresh.TabIndex = 30
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' cbSearchCategory
        ' 
        cbSearchCategory.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbSearchCategory.ForeColor = Color.MediumSlateBlue
        cbSearchCategory.FormattingEnabled = True
        cbSearchCategory.Location = New Point(585, 54)
        cbSearchCategory.Name = "cbSearchCategory"
        cbSearchCategory.Size = New Size(273, 35)
        cbSearchCategory.TabIndex = 29
        cbSearchCategory.Text = "Select Category"
        ' 
        ' cbSelectCategory
        ' 
        cbSelectCategory.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbSelectCategory.ForeColor = Color.MediumSlateBlue
        cbSelectCategory.FormattingEnabled = True
        cbSelectCategory.Location = New Point(140, 350)
        cbSelectCategory.Name = "cbSelectCategory"
        cbSelectCategory.Size = New Size(273, 35)
        cbSelectCategory.TabIndex = 28
        cbSelectCategory.Text = "Select Category"
        ' 
        ' txtCategory
        ' 
        txtCategory.AutoSize = True
        txtCategory.BackColor = Color.LightCyan
        txtCategory.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategory.ForeColor = Color.MediumSlateBlue
        txtCategory.Location = New Point(15, 356)
        txtCategory.Margin = New Padding(4, 0, 4, 0)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(102, 23)
        txtCategory.TabIndex = 27
        txtCategory.Text = "Category"
        ' 
        ' txtProductPrice
        ' 
        txtProductPrice.BackColor = Color.MediumSlateBlue
        txtProductPrice.ForeColor = Color.White
        txtProductPrice.Location = New Point(145, 285)
        txtProductPrice.Name = "txtProductPrice"
        txtProductPrice.Size = New Size(268, 32)
        txtProductPrice.TabIndex = 25
        ' 
        ' txtCategoryPrice
        ' 
        txtCategoryPrice.AutoSize = True
        txtCategoryPrice.BackColor = Color.LightCyan
        txtCategoryPrice.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryPrice.ForeColor = Color.MediumSlateBlue
        txtCategoryPrice.Location = New Point(15, 288)
        txtCategoryPrice.Margin = New Padding(4, 0, 4, 0)
        txtCategoryPrice.Name = "txtCategoryPrice"
        txtCategoryPrice.Size = New Size(58, 23)
        txtCategoryPrice.TabIndex = 24
        txtCategoryPrice.Text = "Price"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MediumSlateBlue
        Label1.Location = New Point(354, 15)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(253, 34)
        Label1.TabIndex = 3
        Label1.Text = "Manage Products"
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.DarkGray
        btnReturn.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.ForeColor = Color.MediumSlateBlue
        btnReturn.Location = New Point(34, 585)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(94, 35)
        btnReturn.TabIndex = 31
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gray
        Label2.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(404, 22)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(431, 34)
        Label2.TabIndex = 32
        Label2.Text = "Toy Shop Management System"
        ' 
        ' Product_Form
        ' 
        AutoScaleDimensions = New SizeF(12F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1201, 724)
        Controls.Add(Label2)
        Controls.Add(btnReturn)
        Controls.Add(X)
        Controls.Add(btnLogout)
        Controls.Add(btnLogo)
        Controls.Add(Panel1)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Product_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Product_Form"
        CType(ProductsDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(btnLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents X As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents ProductsDGV As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductQuantity As TextBox
    Friend WithEvents txtCategoryName As Label
    Friend WithEvents txtCategoryQuantity As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtCategoryID As Label
    Friend WithEvents btnLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtCategoryPrice As Label
    Friend WithEvents txtCategory As Label
    Friend WithEvents cbSelectCategory As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents cbSearchCategory As ComboBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label2 As Label
End Class
