Public Class BillingForm
    'Declaring projectwide variables
    Friend GrandTotalDecimal, AverageDecimal As Decimal
    Friend CustomerCountInteger As Integer

    'Declare module-level variables
    Private SubTotalDecimal, TotalDecimal As Decimal

    'Declare constants
    Const TAX_RATE_Decimal As Decimal = 0.08D
    Const CAPPUCCINO_PRICE_Decimal As Decimal = 2D
    Const ESPRESSO_PRICE_Decimal As Decimal = 2.25D
    Const LATTE_PRICE_Decimal As Decimal = 1.75D
    Const ICED_PRICE_Decimal As Decimal = 2.5D



    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateSelectionToolStripMenuItem.Click
        'Calculate and display the current amounts and add to totals.
        Dim PriceDecimal, TaxDecimal, ItemAmountDecimal As Decimal
        Dim QuantityInteger As Integer

        'Find the price.
        If CappuccinoRadioButton.Checked Then
            PriceDecimal = CAPPUCCINO_PRICE_Decimal
        ElseIf EspressoRadioButton.Checked Then
            PriceDecimal = ESPRESSO_PRICE_Decimal
        ElseIf LatteRadioButton.Checked Then
            PriceDecimal = LATTE_PRICE_Decimal
        ElseIf IcedCappuccinoRadioButton.Checked Or
                IcedLatteRadioButton.Checked Then
            PriceDecimal = ICED_PRICE_Decimal
        End If

        'Calculate the extended price and add to order total.
        Try
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)
            ItemAmountDecimal = PriceDecimal * QuantityInteger
            SubTotalDecimal += ItemAmountDecimal
            If TaxCheckBox.Checked Then
                'Call a function procedure
                TaxDecimal = FindTax(SubTotalDecimal)
            Else
                TaxDecimal = 0
            End If

            TotalDecimal = SubTotalDecimal + TaxDecimal

            ItemAmountTextBox.Text = ItemAmountDecimal.ToString("C")

            SubTotalTextBox.Text = SubTotalDecimal.ToString("N")

            TaxTextBox.Text = TaxDecimal.ToString("N")

            TotalTextBox.Text = TotalDecimal.ToString("C")

            'Allow change for new order only.

            TaxCheckBox.Enabled = False

            'Allow Clear after an order has begun.
            ClearButton.Enabled = True
            ClearItemToolStripMenuItem.Enabled = True
            NewOrderToolStripMenuItem.Enabled = True

        Catch QuantityException As FormatException
            MessageBox.Show("Quantity must be numberic.", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub



    Private Function FindTax(ByVal AmountDecimal As Decimal) As Decimal
        'Calculate the sales tax.
        Return AmountDecimal * TAX_RATE_Decimal

    End Function



    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearItemToolStripMenuItem.Click

        'Clear the appropriate controls.
        CappuccinoRadioButton.Checked = True
        ItemAmountTextBox.Clear()
        With QuantityTextBox
            .Clear()
            .Focus()
        End With

    End Sub



    Private Sub NewOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewOrderToolStripMenuItem.Click
        'Clear the current order and add to the totals.
        Dim ResponseDialogResult As DialogResult
        Dim MessageString As String

        MessageString = "Clear the current order figures?"
        ResponseDialogResult = MessageBox.Show(MessageString, "Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If ResponseDialogResult = DialogResult.Yes Then
            'User said Yes; clear the screen fields.
            ClearButton_Click(sender, e)
            SubTotalTextBox.Text = ""
            TaxTextBox.Text = ""
            TotalTextBox.Text = ""

            'Add to the totals only if not a new order/customer.
            If SubTotalDecimal <> 0 Then
                GrandTotalDecimal += TotalDecimal
                CustomerCountInteger += 1

                'Reset totals for the next customer.
                SubTotalDecimal = 0
                TotalDecimal = 0

            End If

            'Clear the appropriate display items and enable the check box.
            With TaxCheckBox
                .Enabled = True
                .Checked = False
            End With

            ClearButton.Enabled = False
            ClearItemToolStripMenuItem.Enabled = False
            NewOrderToolStripMenuItem.Enabled = False


        End If
    End Sub


    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        'Calculate the average and display the totals.

        Dim MessageString As String

        If TotalDecimal <> 0 Then
            'Make sure the last order is counted.
            NewOrderToolStripMenuItem_Click(sender, e)
            'Pass incoming arguments to the called procedure.
        End If

        If CustomerCountInteger > 0 Then
            'Calculate the average.
            AverageDecimal = GrandTotalDecimal / CustomerCountInteger
            SummaryForm.ShowDialog()
        Else
            MessageString = "No sales data to summarize."
            MessageBox.Show(MessageString, "Coffee Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Terminates the project.
        Me.Close()
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Display the About Box Form
        AboutBox.ShowDialog()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        'Allow the user to select a new font for the summary totals
        With FontDialog1
            .Font = Me.SubTotalTextBox.Font
            .ShowDialog
            SubTotalTextBox.Font = .Font
            TaxTextBox.Font = .Font
            TotalTextBox.Font = .Font

        End With
    End Sub



    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        'Allow the user to select a new color for the summary totals.
        With ColorDialog1
            .Color = SubTotalTextBox.ForeColor
            .ShowDialog()
            SubTotalTextBox.ForeColor = .Color
            TaxTextBox.ForeColor = .Color
            TotalTextBox.ForeColor = .Color
        End With
    End Sub


End Class
