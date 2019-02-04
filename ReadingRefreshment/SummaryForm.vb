Public Class SummaryForm
    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the data.
        TotalSalesTextBox.Text = BillingForm.GrandTotalDecimal.ToString("C")
        AverageSalesTextBox.Text = BillingForm.AverageDecimal.ToString("C")
        NumberCustomersTextBox.Text = BillingForm.CustomerCountInteger.ToString()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
    End Sub
End Class