<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seller_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seller_Form))
        txtCategoryPassword = New Label()
        txtSellerMobileNO = New TextBox()
        txtCategoryMobileNO = New Label()
        SellersDGV = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnAdd = New Button()
        txtSellerName = New TextBox()
        txtSellerAge = New TextBox()
        txtCategoryName = New Label()
        Panel1 = New Panel()
        txtSellerPassword = New TextBox()
        txtCategoryAge = New Label()
        txtSellerID = New TextBox()
        txtCategoryID = New Label()
        Label1 = New Label()
        X = New Button()
        btnLogout = New Button()
        btnLogo = New PictureBox()
        btnReturn = New Button()
        Label2 = New Label()
        CType(SellersDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCategoryPassword
        ' 
        txtCategoryPassword.AutoSize = True
        txtCategoryPassword.BackColor = Color.LightGray
        txtCategoryPassword.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryPassword.ForeColor = Color.MediumSlateBlue
        txtCategoryPassword.Location = New Point(15, 354)
        txtCategoryPassword.Margin = New Padding(4, 0, 4, 0)
        txtCategoryPassword.Name = "txtCategoryPassword"
        txtCategoryPassword.Size = New Size(100, 23)
        txtCategoryPassword.TabIndex = 27
        txtCategoryPassword.Text = "Password"
        ' 
        ' txtSellerMobileNO
        ' 
        txtSellerMobileNO.BackColor = Color.MediumSlateBlue
        txtSellerMobileNO.ForeColor = Color.White
        txtSellerMobileNO.Location = New Point(145, 285)
        txtSellerMobileNO.Name = "txtSellerMobileNO"
        txtSellerMobileNO.Size = New Size(268, 32)
        txtSellerMobileNO.TabIndex = 25
        ' 
        ' txtCategoryMobileNO
        ' 
        txtCategoryMobileNO.AutoSize = True
        txtCategoryMobileNO.BackColor = Color.LightGray
        txtCategoryMobileNO.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryMobileNO.ForeColor = Color.MediumSlateBlue
        txtCategoryMobileNO.Location = New Point(15, 288)
        txtCategoryMobileNO.Margin = New Padding(4, 0, 4, 0)
        txtCategoryMobileNO.Name = "txtCategoryMobileNO"
        txtCategoryMobileNO.Size = New Size(98, 23)
        txtCategoryMobileNO.TabIndex = 24
        txtCategoryMobileNO.Text = "Phon No."
        ' 
        ' SellersDGV
        ' 
        SellersDGV.BackgroundColor = Color.Silver
        SellersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SellersDGV.Location = New Point(434, 96)
        SellersDGV.Name = "SellersDGV"
        SellersDGV.RowHeadersWidth = 51
        SellersDGV.Size = New Size(458, 429)
        SellersDGV.TabIndex = 23
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.MediumSlateBlue
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(23, 449)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(390, 33)
        btnUpdate.TabIndex = 22
        btnUpdate.Text = "Update Data"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.MediumSlateBlue
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(23, 492)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(390, 33)
        btnDelete.TabIndex = 21
        btnDelete.Text = "Delete Seller"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.MediumSlateBlue
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(23, 407)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(390, 33)
        btnAdd.TabIndex = 20
        btnAdd.Text = "Add Seller"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtSellerName
        ' 
        txtSellerName.BackColor = Color.MediumSlateBlue
        txtSellerName.ForeColor = Color.White
        txtSellerName.Location = New Point(145, 156)
        txtSellerName.Name = "txtSellerName"
        txtSellerName.Size = New Size(268, 32)
        txtSellerName.TabIndex = 19
        ' 
        ' txtSellerAge
        ' 
        txtSellerAge.BackColor = Color.MediumSlateBlue
        txtSellerAge.ForeColor = Color.White
        txtSellerAge.Location = New Point(145, 221)
        txtSellerAge.Name = "txtSellerAge"
        txtSellerAge.Size = New Size(268, 32)
        txtSellerAge.TabIndex = 18
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.AutoSize = True
        txtCategoryName.BackColor = Color.LightGray
        txtCategoryName.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryName.ForeColor = Color.MediumSlateBlue
        txtCategoryName.Location = New Point(14, 159)
        txtCategoryName.Margin = New Padding(4, 0, 4, 0)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(70, 23)
        txtCategoryName.TabIndex = 16
        txtCategoryName.Text = "Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(txtSellerPassword)
        Panel1.Controls.Add(txtCategoryPassword)
        Panel1.Controls.Add(txtSellerMobileNO)
        Panel1.Controls.Add(txtCategoryMobileNO)
        Panel1.Controls.Add(SellersDGV)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(txtSellerName)
        Panel1.Controls.Add(txtSellerAge)
        Panel1.Controls.Add(txtCategoryName)
        Panel1.Controls.Add(txtCategoryAge)
        Panel1.Controls.Add(txtSellerID)
        Panel1.Controls.Add(txtCategoryID)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(147, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(937, 568)
        Panel1.TabIndex = 23
        ' 
        ' txtSellerPassword
        ' 
        txtSellerPassword.BackColor = Color.MediumSlateBlue
        txtSellerPassword.ForeColor = Color.White
        txtSellerPassword.Location = New Point(145, 347)
        txtSellerPassword.Name = "txtSellerPassword"
        txtSellerPassword.Size = New Size(268, 32)
        txtSellerPassword.TabIndex = 28
        ' 
        ' txtCategoryAge
        ' 
        txtCategoryAge.AutoSize = True
        txtCategoryAge.BackColor = Color.LightGray
        txtCategoryAge.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryAge.ForeColor = Color.MediumSlateBlue
        txtCategoryAge.Location = New Point(15, 224)
        txtCategoryAge.Margin = New Padding(4, 0, 4, 0)
        txtCategoryAge.Name = "txtCategoryAge"
        txtCategoryAge.Size = New Size(51, 23)
        txtCategoryAge.TabIndex = 15
        txtCategoryAge.Text = "Age"
        ' 
        ' txtSellerID
        ' 
        txtSellerID.BackColor = Color.MediumSlateBlue
        txtSellerID.ForeColor = Color.White
        txtSellerID.Location = New Point(145, 96)
        txtSellerID.Name = "txtSellerID"
        txtSellerID.Size = New Size(268, 32)
        txtSellerID.TabIndex = 13
        ' 
        ' txtCategoryID
        ' 
        txtCategoryID.AutoSize = True
        txtCategoryID.BackColor = Color.LightGray
        txtCategoryID.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCategoryID.ForeColor = Color.MediumSlateBlue
        txtCategoryID.Location = New Point(14, 96)
        txtCategoryID.Margin = New Padding(4, 0, 4, 0)
        txtCategoryID.Name = "txtCategoryID"
        txtCategoryID.Size = New Size(30, 23)
        txtCategoryID.TabIndex = 4
        txtCategoryID.Text = "ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MediumSlateBlue
        Label1.Location = New Point(322, 28)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 34)
        Label1.TabIndex = 3
        Label1.Text = "Manage Seller Account"
        ' 
        ' X
        ' 
        X.ForeColor = Color.Transparent
        X.Image = CType(resources.GetObject("X.Image"), Image)
        X.Location = New Point(1241, 0)
        X.Margin = New Padding(4)
        X.Name = "X"
        X.Size = New Size(40, 43)
        X.TabIndex = 29
        X.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Silver
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.MediumSlateBlue
        btnLogout.Location = New Point(22, 591)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 33)
        btnLogout.TabIndex = 27
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnLogo
        ' 
        btnLogo.BackColor = Color.Transparent
        btnLogo.Image = CType(resources.GetObject("btnLogo.Image"), Image)
        btnLogo.Location = New Point(22, 22)
        btnLogo.Name = "btnLogo"
        btnLogo.Size = New Size(82, 81)
        btnLogo.SizeMode = PictureBoxSizeMode.Zoom
        btnLogo.TabIndex = 28
        btnLogo.TabStop = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Silver
        btnReturn.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.ForeColor = Color.MediumSlateBlue
        btnReturn.Location = New Point(22, 527)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(94, 35)
        btnReturn.TabIndex = 30
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gray
        Label2.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(383, 22)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(431, 34)
        Label2.TabIndex = 31
        Label2.Text = "Toy Shop Management System"
        ' 
        ' Seller_Form
        ' 
        AutoScaleDimensions = New SizeF(12F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1171, 658)
        Controls.Add(Label2)
        Controls.Add(btnReturn)
        Controls.Add(Panel1)
        Controls.Add(X)
        Controls.Add(btnLogout)
        Controls.Add(btnLogo)
        Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Seller_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Seller_Form"
        CType(SellersDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(btnLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtCategoryPassword As Label
    Friend WithEvents txtSellerMobileNO As TextBox
    Friend WithEvents txtCategoryMobileNO As Label
    Friend WithEvents SellersDGV As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSellerName As TextBox
    Friend WithEvents txtSellerAge As TextBox
    Friend WithEvents txtCategoryName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCategoryAge As Label
    Friend WithEvents txtSellerID As TextBox
    Friend WithEvents txtCategoryID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents X As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLogo As PictureBox
    Friend WithEvents txtSellerPassword As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label2 As Label
End Class
