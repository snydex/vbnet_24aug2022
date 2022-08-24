Public Class BookSalesForm
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PriceLabel_Click(sender As Object, e As EventArgs) Handles priceLabel.Click

    End Sub

    Private Sub PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles priceTextBox.TextChanged

    End Sub

    Private Sub QtyLabel_Click(sender As Object, e As EventArgs) Handles qtyLabel.Click

    End Sub

    Private Sub QtyTextBox_TextChanged(sender As Object, e As EventArgs) Handles qtyTextBox.TextChanged

    End Sub

    Private Sub calc_Click(sender As Object, e As EventArgs) Handles calc.Click

        'declare summary variable
        'Dim noOfCustomerInteger
        'declare variable
        Dim priceDouble, amtdueDouble, discDouble As Double
        Dim qtyInteger As Integer

        priceDouble = Double.Parse(priceTextBox.Text)
        qtyInteger = Integer.Parse(qtyTextBox.Text)
        discDouble = Double.Parse(discTextBox.Text)

        amtdueDouble = priceDouble * qtyInteger

        amtTextBox.Text = amtdueDouble.ToString("RM ")

    End Sub

    Private Sub AmtLabel_Click(sender As Object, e As EventArgs) Handles amtLabel.Click

    End Sub

    Private Sub AmtTextBox_TextChanged(sender As Object, e As EventArgs) Handles amtTextBox.TextChanged

    End Sub

    Private Sub BookSalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        priceTextBox.Clear()
        qtyTextBox.Clear()
        discTextBox.Clear()
        amtLabel.Text = ""
    End Sub
End Class
