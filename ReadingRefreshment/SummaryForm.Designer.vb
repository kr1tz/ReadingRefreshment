﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.TotalSalesTextBox = New System.Windows.Forms.TextBox()
        Me.AverageSalesTextBox = New System.Windows.Forms.TextBox()
        Me.NumberCustomersTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "R 'n R for Reading and Refreshment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Sales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Average Sales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of Customers"
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(220, 254)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'TotalSalesTextBox
        '
        Me.TotalSalesTextBox.Location = New System.Drawing.Point(206, 95)
        Me.TotalSalesTextBox.Name = "TotalSalesTextBox"
        Me.TotalSalesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalSalesTextBox.TabIndex = 5
        '
        'AverageSalesTextBox
        '
        Me.AverageSalesTextBox.Location = New System.Drawing.Point(206, 144)
        Me.AverageSalesTextBox.Name = "AverageSalesTextBox"
        Me.AverageSalesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AverageSalesTextBox.TabIndex = 6
        '
        'NumberCustomersTextBox
        '
        Me.NumberCustomersTextBox.Location = New System.Drawing.Point(206, 194)
        Me.NumberCustomersTextBox.Name = "NumberCustomersTextBox"
        Me.NumberCustomersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumberCustomersTextBox.TabIndex = 7
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 311)
        Me.Controls.Add(Me.NumberCustomersTextBox)
        Me.Controls.Add(Me.AverageSalesTextBox)
        Me.Controls.Add(Me.TotalSalesTextBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SummaryForm"
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents TotalSalesTextBox As TextBox
    Friend WithEvents AverageSalesTextBox As TextBox
    Friend WithEvents NumberCustomersTextBox As TextBox
End Class
