Imports NorthWindLibrary.Classes

Public Class Form1
    Private Async Sub AllCustomersButton_Click(sender As Object, e As EventArgs) Handles AllCustomersButton.Click

        Dim customers = Await CustomerOperations.AllAsync()
        MessageBox.Show(customers.Count)

    End Sub

    Private Async Sub CustomerByIdentifierButton_Click(sender As Object, e As EventArgs) Handles CustomerByIdentifierButton.Click

        Dim id = 24
        Dim customer = Await CustomerOperations.ByCustomerIdentifierAsync(id)

        MessageBox.Show($"{customer.CompanyName}")
    End Sub
End Class
