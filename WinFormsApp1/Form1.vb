Imports NorthWindLibrary.Classes

Public Class Form1
    Private customersBindingSource As New BindingSource
    Private Async Sub AllCustomersButton_Click(sender As Object, e As EventArgs) Handles AllCustomersButton.Click

        Dim customers = Await CustomerOperations.AllAsync()
        customersBindingSource.DataSource = customers
        DataGridView1.DataSource = customersBindingSource
        Try
            CustomerIdTextBox.DataBindings.Add("Text", customersBindingSource, "CustomerIdentifier", True, DataSourceUpdateMode.OnPropertyChanged)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Async Sub CustomerByIdentifierButton_Click(sender As Object, e As EventArgs) Handles CustomerByIdentifierButton.Click

        Dim id = 24
        Dim customer = Await CustomerOperations.ByCustomerIdentifierAsync(id)

        MessageBox.Show($"{customer.CompanyName}")
    End Sub

    Private Sub DataGridView1_Scroll(sender As Object, e As ScrollEventArgs) Handles DataGridView1.Scroll
        customersBindingSource.Position = e.NewValue
    End Sub
End Class
