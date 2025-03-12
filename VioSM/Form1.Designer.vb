<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        X = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' X
        ' 
        X.ForeColor = Color.Transparent
        X.Image = CType(resources.GetObject("X.Image"), Image)
        X.Location = New Point(860, 0)
        X.Margin = New Padding(4)
        X.Name = "X"
        X.Size = New Size(40, 43)
        X.TabIndex = 0
        X.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.PaleVioletRed
        Label1.ForeColor = Color.LightGray
        Label1.Location = New Point(247, 23)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(431, 34)
        Label1.TabIndex = 1
        Label1.Text = "Toy Shop Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(405, 74)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 23)
        Label2.TabIndex = 2
        Label2.Text = "Version 2.1.0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.PaleVioletRed
        Label3.ForeColor = Color.LightGray
        Label3.Location = New Point(317, 542)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(245, 34)
        Label3.TabIndex = 3
        Label3.Text = "Powered By XLR8"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(247, 145)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(418, 329)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = Color.Black
        ProgressBar1.Dock = DockStyle.Bottom
        ProgressBar1.Location = New Point(0, 610)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(900, 29)
        ProgressBar1.TabIndex = 5
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(16F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(900, 639)
        Controls.Add(ProgressBar1)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(X)
        Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ActiveCaption
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 6, 5, 6)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Splash"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents X As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer

End Class
