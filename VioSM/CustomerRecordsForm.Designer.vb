<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerRecordsForm
    Inherits System.Windows.Forms.Form

    ' Designer code
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvCustomerRecords = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvCustomerRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' dgvCustomerRecords
        '
        Me.dgvCustomerRecords.AllowUserToAddRows = False
        Me.dgvCustomerRecords.AllowUserToDeleteRows = False
        Me.dgvCustomerRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomerRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvCustomerRecords.Location = New System.Drawing.Point(0, 0)
        Me.dgvCustomerRecords.Name = "dgvCustomerRecords"
        Me.dgvCustomerRecords.ReadOnly = True
        Me.dgvCustomerRecords.RowHeadersWidth = 51
        Me.dgvCustomerRecords.RowTemplate.Height = 24
        Me.dgvCustomerRecords.Size = New System.Drawing.Size(800, 450)
        Me.dgvCustomerRecords.TabIndex = 0
        '
        ' btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnClose.Location = New System.Drawing.Point(0, 460)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(800, 40)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        ' CustomerRecordsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.dgvCustomerRecords)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "CustomerRecordsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Records"
        CType(Me.dgvCustomerRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
End Class
