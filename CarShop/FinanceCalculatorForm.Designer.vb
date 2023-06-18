<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinanceCalculatorForm
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
        Me.lblPurchasePrice = New System.Windows.Forms.Label()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPaymentTerm = New System.Windows.Forms.ComboBox()
        Me.tbBalloon = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBalloon = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbInterestRate = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnWriteFile = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRepayment = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBalloonAmount = New System.Windows.Forms.Label()
        Me.lblAmountToFinance = New System.Windows.Forms.Label()
        Me.lblInterestAmt = New System.Windows.Forms.Label()
        Me.cbClientId = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBalloon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbInterestRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CarShop.My.Resources.Resources.calculator
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 221)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Client ID:"
        '
        'lblPurchasePrice
        '
        Me.lblPurchasePrice.AutoSize = True
        Me.lblPurchasePrice.Location = New System.Drawing.Point(93, 252)
        Me.lblPurchasePrice.Name = "lblPurchasePrice"
        Me.lblPurchasePrice.Size = New System.Drawing.Size(144, 16)
        Me.lblPurchasePrice.TabIndex = 3
        Me.lblPurchasePrice.Text = "Vehicle purchase price"
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.Location = New System.Drawing.Point(290, 246)
        Me.txtPurchasePrice.MaxLength = 100
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(160, 22)
        Me.txtPurchasePrice.TabIndex = 4
        Me.txtPurchasePrice.Text = "0"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(290, 287)
        Me.txtDeposit.MaxLength = 100
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(160, 22)
        Me.txtDeposit.TabIndex = 6
        Me.txtDeposit.Text = "0"
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(93, 293)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(101, 16)
        Me.lblDeposit.TabIndex = 5
        Me.lblDeposit.Text = "Deposit amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Pay term (months)"
        '
        'cbPaymentTerm
        '
        Me.cbPaymentTerm.FormattingEnabled = True
        Me.cbPaymentTerm.Items.AddRange(New Object() {"12", "24", "36", "48", "54", "60", "72", "84", "96"})
        Me.cbPaymentTerm.Location = New System.Drawing.Point(290, 334)
        Me.cbPaymentTerm.Name = "cbPaymentTerm"
        Me.cbPaymentTerm.Size = New System.Drawing.Size(160, 24)
        Me.cbPaymentTerm.TabIndex = 8
        '
        'tbBalloon
        '
        Me.tbBalloon.Location = New System.Drawing.Point(96, 425)
        Me.tbBalloon.Maximum = 30
        Me.tbBalloon.Name = "tbBalloon"
        Me.tbBalloon.Size = New System.Drawing.Size(354, 56)
        Me.tbBalloon.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 384)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Balloon %"
        '
        'lblBalloon
        '
        Me.lblBalloon.AutoSize = True
        Me.lblBalloon.Location = New System.Drawing.Point(287, 388)
        Me.lblBalloon.Name = "lblBalloon"
        Me.lblBalloon.Size = New System.Drawing.Size(14, 16)
        Me.lblBalloon.TabIndex = 11
        Me.lblBalloon.Text = "0"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Location = New System.Drawing.Point(287, 496)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(14, 16)
        Me.lblInterestRate.TabIndex = 14
        Me.lblInterestRate.Text = "7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 492)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Interest rate %"
        '
        'tbInterestRate
        '
        Me.tbInterestRate.Location = New System.Drawing.Point(96, 533)
        Me.tbInterestRate.Maximum = 25
        Me.tbInterestRate.Minimum = 7
        Me.tbInterestRate.Name = "tbInterestRate"
        Me.tbInterestRate.Size = New System.Drawing.Size(354, 56)
        Me.tbInterestRate.TabIndex = 12
        Me.tbInterestRate.Value = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 607)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 30)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnWriteFile
        '
        Me.btnWriteFile.Enabled = False
        Me.btnWriteFile.Location = New System.Drawing.Point(96, 661)
        Me.btnWriteFile.Name = "btnWriteFile"
        Me.btnWriteFile.Size = New System.Drawing.Size(354, 28)
        Me.btnWriteFile.TabIndex = 16
        Me.btnWriteFile.Text = "Write to file"
        Me.btnWriteFile.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(538, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Estimated monthly repayment"
        '
        'lblRepayment
        '
        Me.lblRepayment.AutoSize = True
        Me.lblRepayment.Location = New System.Drawing.Point(538, 287)
        Me.lblRepayment.Name = "lblRepayment"
        Me.lblRepayment.Size = New System.Drawing.Size(15, 16)
        Me.lblRepayment.TabIndex = 18
        Me.lblRepayment.Text = "[]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(538, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Amount to finance:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(538, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Interest amount:"
        '
        'lblBalloonAmount
        '
        Me.lblBalloonAmount.AutoSize = True
        Me.lblBalloonAmount.Location = New System.Drawing.Point(208, 610)
        Me.lblBalloonAmount.Name = "lblBalloonAmount"
        Me.lblBalloonAmount.Size = New System.Drawing.Size(19, 20)
        Me.lblBalloonAmount.TabIndex = 21
        Me.lblBalloonAmount.Text = "[]"
        '
        'lblAmountToFinance
        '
        Me.lblAmountToFinance.AutoSize = True
        Me.lblAmountToFinance.Location = New System.Drawing.Point(671, 337)
        Me.lblAmountToFinance.Name = "lblAmountToFinance"
        Me.lblAmountToFinance.Size = New System.Drawing.Size(15, 16)
        Me.lblAmountToFinance.TabIndex = 22
        Me.lblAmountToFinance.Text = "[]"
        '
        'lblInterestAmt
        '
        Me.lblInterestAmt.AutoSize = True
        Me.lblInterestAmt.Location = New System.Drawing.Point(671, 384)
        Me.lblInterestAmt.Name = "lblInterestAmt"
        Me.lblInterestAmt.Size = New System.Drawing.Size(15, 16)
        Me.lblInterestAmt.TabIndex = 23
        Me.lblInterestAmt.Text = "[]"
        '
        'cbClientId
        '
        Me.cbClientId.FormattingEnabled = True
        Me.cbClientId.Items.AddRange(New Object() {"12", "24", "36", "48", "54", "60", "72", "84", "96"})
        Me.cbClientId.Location = New System.Drawing.Point(350, 128)
        Me.cbClientId.Name = "cbClientId"
        Me.cbClientId.Size = New System.Drawing.Size(160, 24)
        Me.cbClientId.TabIndex = 24
        '
        'FinanceCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 774)
        Me.Controls.Add(Me.cbClientId)
        Me.Controls.Add(Me.lblInterestAmt)
        Me.Controls.Add(Me.lblAmountToFinance)
        Me.Controls.Add(Me.lblBalloonAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblRepayment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnWriteFile)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbInterestRate)
        Me.Controls.Add(Me.lblBalloon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbBalloon)
        Me.Controls.Add(Me.cbPaymentTerm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.txtPurchasePrice)
        Me.Controls.Add(Me.lblPurchasePrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FinanceCalculatorForm"
        Me.Text = "Finance Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBalloon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbInterestRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPurchasePrice As Label
    Friend WithEvents txtPurchasePrice As TextBox
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents lblDeposit As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbPaymentTerm As ComboBox
    Friend WithEvents tbBalloon As TrackBar
    Friend WithEvents Label5 As Label
    Friend WithEvents lblBalloon As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbInterestRate As TrackBar
    Friend WithEvents Button1 As Button
    Friend WithEvents btnWriteFile As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRepayment As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblBalloonAmount As Label
    Friend WithEvents lblAmountToFinance As Label
    Friend WithEvents lblInterestAmt As Label
    Friend WithEvents cbClientId As ComboBox
End Class
