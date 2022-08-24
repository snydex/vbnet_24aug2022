<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookSalesForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.discTextBox = New System.Windows.Forms.TextBox()
        Me.discLabel = New System.Windows.Forms.Label()
        Me.amtTextBox = New System.Windows.Forms.TextBox()
        Me.amtLabel = New System.Windows.Forms.Label()
        Me.calc = New System.Windows.Forms.Button()
        Me.qtyTextBox = New System.Windows.Forms.TextBox()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.qtyLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ClearBtn)
        Me.GroupBox1.Controls.Add(Me.discTextBox)
        Me.GroupBox1.Controls.Add(Me.discLabel)
        Me.GroupBox1.Controls.Add(Me.amtTextBox)
        Me.GroupBox1.Controls.Add(Me.amtLabel)
        Me.GroupBox1.Controls.Add(Me.calc)
        Me.GroupBox1.Controls.Add(Me.qtyTextBox)
        Me.GroupBox1.Controls.Add(Me.priceTextBox)
        Me.GroupBox1.Controls.Add(Me.qtyLabel)
        Me.GroupBox1.Controls.Add(Me.priceLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(206, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 440)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Sales"
        '
        'discTextBox
        '
        Me.discTextBox.Location = New System.Drawing.Point(182, 180)
        Me.discTextBox.Name = "discTextBox"
        Me.discTextBox.Size = New System.Drawing.Size(148, 27)
        Me.discTextBox.TabIndex = 8
        '
        'discLabel
        '
        Me.discLabel.AutoSize = True
        Me.discLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.discLabel.Location = New System.Drawing.Point(46, 179)
        Me.discLabel.Name = "discLabel"
        Me.discLabel.Size = New System.Drawing.Size(88, 25)
        Me.discLabel.TabIndex = 7
        Me.discLabel.Text = "Discount"
        '
        'amtTextBox
        '
        Me.amtTextBox.Location = New System.Drawing.Point(182, 346)
        Me.amtTextBox.Name = "amtTextBox"
        Me.amtTextBox.Size = New System.Drawing.Size(148, 27)
        Me.amtTextBox.TabIndex = 6
        '
        'amtLabel
        '
        Me.amtLabel.AutoSize = True
        Me.amtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.amtLabel.Location = New System.Drawing.Point(46, 345)
        Me.amtLabel.Name = "amtLabel"
        Me.amtLabel.Size = New System.Drawing.Size(121, 25)
        Me.amtLabel.TabIndex = 5
        Me.amtLabel.Text = "Amount Due"
        '
        'calc
        '
        Me.calc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.calc.Location = New System.Drawing.Point(51, 259)
        Me.calc.Name = "calc"
        Me.calc.Size = New System.Drawing.Size(125, 41)
        Me.calc.TabIndex = 4
        Me.calc.Text = "Calculate"
        Me.calc.UseVisualStyleBackColor = True
        '
        'qtyTextBox
        '
        Me.qtyTextBox.Location = New System.Drawing.Point(182, 120)
        Me.qtyTextBox.Name = "qtyTextBox"
        Me.qtyTextBox.Size = New System.Drawing.Size(148, 27)
        Me.qtyTextBox.TabIndex = 3
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(182, 61)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(148, 27)
        Me.priceTextBox.TabIndex = 2
        '
        'qtyLabel
        '
        Me.qtyLabel.AutoSize = True
        Me.qtyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.qtyLabel.Location = New System.Drawing.Point(46, 119)
        Me.qtyLabel.Name = "qtyLabel"
        Me.qtyLabel.Size = New System.Drawing.Size(85, 25)
        Me.qtyLabel.TabIndex = 1
        Me.qtyLabel.Text = "Quantity"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.priceLabel.Location = New System.Drawing.Point(46, 60)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(56, 25)
        Me.priceLabel.TabIndex = 0
        Me.priceLabel.Text = "Price"
        '
        'ClearBtn
        '
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ClearBtn.Location = New System.Drawing.Point(205, 259)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(125, 41)
        Me.ClearBtn.TabIndex = 9
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'BookSalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 529)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BookSalesForm"
        Me.Text = "Book Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents amtTextBox As TextBox
    Friend WithEvents amtLabel As Label
    Friend WithEvents calc As Button
    Friend WithEvents qtyTextBox As TextBox
    Friend WithEvents priceTextBox As TextBox
    Friend WithEvents qtyLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents discTextBox As TextBox
    Friend WithEvents discLabel As Label
    Friend WithEvents ClearBtn As Button
End Class
