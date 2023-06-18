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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgQuotes = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ClientNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgQuotes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgQuotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientNumber})
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
        'ClientNumber
        '
        Me.ClientNumber.HeaderText = "Client Number"
        Me.ClientNumber.MinimumWidth = 6
        Me.ClientNumber.Name = "ClientNumber"
        Me.ClientNumber.Width = 125
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgQuotes As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents ClientNumber As DataGridViewTextBoxColumn
End Class
