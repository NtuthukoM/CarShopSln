<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanceCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayPreviousQuotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "Copyright (C) 2023"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewClientToolStripMenuItem, Me.FinanceCalculatorToolStripMenuItem, Me.DisplayPreviousQuotesToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'NewClientToolStripMenuItem
        '
        Me.NewClientToolStripMenuItem.Name = "NewClientToolStripMenuItem"
        Me.NewClientToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.NewClientToolStripMenuItem.Text = "New Client"
        '
        'FinanceCalculatorToolStripMenuItem
        '
        Me.FinanceCalculatorToolStripMenuItem.Name = "FinanceCalculatorToolStripMenuItem"
        Me.FinanceCalculatorToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.FinanceCalculatorToolStripMenuItem.Text = "Finance Calculator"
        '
        'DisplayPreviousQuotesToolStripMenuItem
        '
        Me.DisplayPreviousQuotesToolStripMenuItem.Name = "DisplayPreviousQuotesToolStripMenuItem"
        Me.DisplayPreviousQuotesToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.DisplayPreviousQuotesToolStripMenuItem.Text = "Display Previous Quotes"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CarShop.My.Resources.Resources.car
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Bobby's Car Shop"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinanceCalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayPreviousQuotesToolStripMenuItem As ToolStripMenuItem
End Class
