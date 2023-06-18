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
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBalloon = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRepayment = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CarShop.My.Resources.Resources.calculator
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 130)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Client ID:"
        '
        'lblClientID
        '
        Me.lblClientID.AutoSize = True
        Me.lblClientID.Location = New System.Drawing.Point(295, 47)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(19, 20)
        Me.lblClientID.TabIndex = 2
        Me.lblClientID.Text = "[]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Vehicle purchase price"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(229, 165)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 22)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(229, 206)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(160, 22)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Deposit amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Pay term (months)"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(229, 253)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 8
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(35, 344)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(354, 56)
        Me.TrackBar1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Balloon %"
        '
        'lblBalloon
        '
        Me.lblBalloon.AutoSize = True
        Me.lblBalloon.Location = New System.Drawing.Point(226, 307)
        Me.lblBalloon.Name = "lblBalloon"
        Me.lblBalloon.Size = New System.Drawing.Size(18, 20)
        Me.lblBalloon.TabIndex = 11
        Me.lblBalloon.Text = "0"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Location = New System.Drawing.Point(226, 415)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(14, 16)
        Me.lblInterestRate.TabIndex = 14
        Me.lblInterestRate.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Interest rate %"
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(35, 452)
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(354, 56)
        Me.TrackBar2.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(35, 580)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(354, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Write to file"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(552, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Estimated monthly repayment"
        '
        'lblRepayment
        '
        Me.lblRepayment.AutoSize = True
        Me.lblRepayment.Location = New System.Drawing.Point(552, 206)
        Me.lblRepayment.Name = "lblRepayment"
        Me.lblRepayment.Size = New System.Drawing.Size(19, 20)
        Me.lblRepayment.TabIndex = 18
        Me.lblRepayment.Text = "[]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(552, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Amount to finance:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(552, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Interest amount:"
        '
        'FinanceCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 706)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblRepayment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.lblBalloon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblClientID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FinanceCalculatorForm"
        Me.Text = "Finance Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClientID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label5 As Label
    Friend WithEvents lblBalloon As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRepayment As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
