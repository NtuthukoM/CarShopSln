<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuotesForm
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgQuotes = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.QuoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchasePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepositDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentTermDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalloonPaymentPercDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestRatePercDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalloonPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgQuotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CarShop.My.Resources.Resources.file
        Me.PictureBox1.Location = New System.Drawing.Point(1171, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 195)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'dgQuotes
        '
        Me.dgQuotes.AutoGenerateColumns = False
        Me.dgQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgQuotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientNumberDataGridViewTextBoxColumn, Me.PurchasePriceDataGridViewTextBoxColumn, Me.DepositDataGridViewTextBoxColumn, Me.PaymentTermDataGridViewTextBoxColumn, Me.BalloonPaymentPercDataGridViewTextBoxColumn, Me.InterestRatePercDataGridViewTextBoxColumn, Me.MonthlyPaymentDataGridViewTextBoxColumn, Me.BalloonPaymentDataGridViewTextBoxColumn})
        Me.dgQuotes.DataSource = Me.QuoteBindingSource
        Me.dgQuotes.Location = New System.Drawing.Point(12, 205)
        Me.dgQuotes.Name = "dgQuotes"
        Me.dgQuotes.RowHeadersWidth = 51
        Me.dgQuotes.RowTemplate.Height = 24
        Me.dgQuotes.Size = New System.Drawing.Size(1377, 473)
        Me.dgQuotes.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Display all quotes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'QuoteBindingSource
        '
        Me.QuoteBindingSource.DataSource = GetType(CarShop.Quote)
        '
        'ClientNumberDataGridViewTextBoxColumn
        '
        Me.ClientNumberDataGridViewTextBoxColumn.DataPropertyName = "ClientNumber"
        Me.ClientNumberDataGridViewTextBoxColumn.HeaderText = "Client Number"
        Me.ClientNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ClientNumberDataGridViewTextBoxColumn.Name = "ClientNumberDataGridViewTextBoxColumn"
        Me.ClientNumberDataGridViewTextBoxColumn.Width = 125
        '
        'PurchasePriceDataGridViewTextBoxColumn
        '
        Me.PurchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice"
        Me.PurchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price"
        Me.PurchasePriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PurchasePriceDataGridViewTextBoxColumn.Name = "PurchasePriceDataGridViewTextBoxColumn"
        Me.PurchasePriceDataGridViewTextBoxColumn.Width = 125
        '
        'DepositDataGridViewTextBoxColumn
        '
        Me.DepositDataGridViewTextBoxColumn.DataPropertyName = "Deposit"
        Me.DepositDataGridViewTextBoxColumn.HeaderText = "Deposit"
        Me.DepositDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DepositDataGridViewTextBoxColumn.Name = "DepositDataGridViewTextBoxColumn"
        Me.DepositDataGridViewTextBoxColumn.Width = 125
        '
        'PaymentTermDataGridViewTextBoxColumn
        '
        Me.PaymentTermDataGridViewTextBoxColumn.DataPropertyName = "PaymentTerm"
        Me.PaymentTermDataGridViewTextBoxColumn.HeaderText = "Payment Term"
        Me.PaymentTermDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PaymentTermDataGridViewTextBoxColumn.Name = "PaymentTermDataGridViewTextBoxColumn"
        Me.PaymentTermDataGridViewTextBoxColumn.Width = 125
        '
        'BalloonPaymentPercDataGridViewTextBoxColumn
        '
        Me.BalloonPaymentPercDataGridViewTextBoxColumn.DataPropertyName = "BalloonPaymentPerc"
        Me.BalloonPaymentPercDataGridViewTextBoxColumn.HeaderText = "Balloon Payment %"
        Me.BalloonPaymentPercDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BalloonPaymentPercDataGridViewTextBoxColumn.Name = "BalloonPaymentPercDataGridViewTextBoxColumn"
        Me.BalloonPaymentPercDataGridViewTextBoxColumn.Width = 125
        '
        'InterestRatePercDataGridViewTextBoxColumn
        '
        Me.InterestRatePercDataGridViewTextBoxColumn.DataPropertyName = "InterestRatePerc"
        Me.InterestRatePercDataGridViewTextBoxColumn.HeaderText = "Interest Rate %"
        Me.InterestRatePercDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InterestRatePercDataGridViewTextBoxColumn.Name = "InterestRatePercDataGridViewTextBoxColumn"
        Me.InterestRatePercDataGridViewTextBoxColumn.Width = 125
        '
        'MonthlyPaymentDataGridViewTextBoxColumn
        '
        Me.MonthlyPaymentDataGridViewTextBoxColumn.DataPropertyName = "MonthlyPayment"
        Me.MonthlyPaymentDataGridViewTextBoxColumn.HeaderText = "Monthly Payment"
        Me.MonthlyPaymentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MonthlyPaymentDataGridViewTextBoxColumn.Name = "MonthlyPaymentDataGridViewTextBoxColumn"
        Me.MonthlyPaymentDataGridViewTextBoxColumn.Width = 125
        '
        'BalloonPaymentDataGridViewTextBoxColumn
        '
        Me.BalloonPaymentDataGridViewTextBoxColumn.DataPropertyName = "BalloonPayment"
        Me.BalloonPaymentDataGridViewTextBoxColumn.HeaderText = "Balloon Payment Value"
        Me.BalloonPaymentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BalloonPaymentDataGridViewTextBoxColumn.Name = "BalloonPaymentDataGridViewTextBoxColumn"
        Me.BalloonPaymentDataGridViewTextBoxColumn.Width = 125
        '
        'QuotesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1414, 690)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgQuotes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "QuotesForm"
        Me.Text = "Quotes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgQuotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents QuoteBindingSource As BindingSource
    Friend WithEvents dgQuotes As DataGridView
    Friend WithEvents ClientNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepositDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentTermDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalloonPaymentPercDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InterestRatePercDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyPaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalloonPaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
