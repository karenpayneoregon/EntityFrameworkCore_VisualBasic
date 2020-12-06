Imports NorthWindLibrary.Classes

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customers = Await CustomerOperations.AllAsync()
        MessageBox.Show(customers.Count)
    End Sub
End Class
