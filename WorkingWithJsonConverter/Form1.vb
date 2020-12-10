Imports Classes

Public Class Form1
    Private Sub ReadPerson_Click(sender As Object, e As EventArgs) Handles ReadPerson.Click
        Dim person = Operations.GetPersons().FirstOrDefault()

        Console.WriteLine()

    End Sub
End Class
