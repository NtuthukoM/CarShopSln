<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewClientForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblClientNumber = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.txtPassportNumber = New System.Windows.Forms.TextBox()
        Me.lblPassportNumber = New System.Windows.Forms.Label()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.lblIdNumber = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CarShop.My.Resources.Resources.client
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 200)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Client Number"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(277, 75)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblClientNumber
        '
        Me.lblClientNumber.AutoSize = True
        Me.lblClientNumber.Location = New System.Drawing.Point(476, 29)
        Me.lblClientNumber.Name = "lblClientNumber"
        Me.lblClientNumber.Size = New System.Drawing.Size(15, 16)
        Me.lblClientNumber.TabIndex = 3
        Me.lblClientNumber.Text = "[]"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(479, 75)
        Me.txtName.MaxLength = 300
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(225, 22)
        Me.txtName.TabIndex = 20
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(479, 303)
        Me.txtContactNumber.MaxLength = 15
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(225, 22)
        Me.txtContactNumber.TabIndex = 26
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(277, 303)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(100, 16)
        Me.lblContactNumber.TabIndex = 5
        Me.lblContactNumber.Text = "Contact number"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(479, 266)
        Me.txtEmail.MaxLength = 200
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(225, 22)
        Me.txtEmail.TabIndex = 25
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(277, 266)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email"
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Location = New System.Drawing.Point(479, 227)
        Me.txtDateOfBirth.MaxLength = 20
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(225, 22)
        Me.txtDateOfBirth.TabIndex = 24
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Location = New System.Drawing.Point(277, 227)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(78, 16)
        Me.lblDateOfBirth.TabIndex = 9
        Me.lblDateOfBirth.Text = "Date of birth"
        '
        'txtPassportNumber
        '
        Me.txtPassportNumber.Location = New System.Drawing.Point(479, 190)
        Me.txtPassportNumber.MaxLength = 20
        Me.txtPassportNumber.Name = "txtPassportNumber"
        Me.txtPassportNumber.Size = New System.Drawing.Size(225, 22)
        Me.txtPassportNumber.TabIndex = 23
        '
        'lblPassportNumber
        '
        Me.lblPassportNumber.AutoSize = True
        Me.lblPassportNumber.Location = New System.Drawing.Point(277, 190)
        Me.lblPassportNumber.Name = "lblPassportNumber"
        Me.lblPassportNumber.Size = New System.Drawing.Size(61, 16)
        Me.lblPassportNumber.TabIndex = 11
        Me.lblPassportNumber.Text = "Passport"
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(479, 152)
        Me.txtIdNumber.MaxLength = 13
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(225, 22)
        Me.txtIdNumber.TabIndex = 22
        '
        'lblIdNumber
        '
        Me.lblIdNumber.AutoSize = True
        Me.lblIdNumber.Location = New System.Drawing.Point(277, 152)
        Me.lblIdNumber.Name = "lblIdNumber"
        Me.lblIdNumber.Size = New System.Drawing.Size(92, 16)
        Me.lblIdNumber.TabIndex = 13
        Me.lblIdNumber.Text = "SA ID Number"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(479, 113)
        Me.txtSurname.MaxLength = 300
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(225, 22)
        Me.txtSurname.TabIndex = 21
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(277, 113)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(61, 16)
        Me.lblSurname.TabIndex = 15
        Me.lblSurname.Text = "Surname"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(479, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 29)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Add new Client"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 603)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtIdNumber)
        Me.Controls.Add(Me.lblIdNumber)
        Me.Controls.Add(Me.txtPassportNumber)
        Me.Controls.Add(Me.lblPassportNumber)
        Me.Controls.Add(Me.txtDateOfBirth)
        Me.Controls.Add(Me.lblDateOfBirth)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblClientNumber)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "NewClientForm"
        Me.Text = "New Client"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblClientNumber As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents txtPassportNumber As TextBox
    Friend WithEvents lblPassportNumber As Label
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents lblIdNumber As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents Button1 As Button
End Class
