Imports Microsoft.EntityFrameworkCore
Imports NorthWindLibrary.Models

Namespace Classes

    Public Class CustomerOperations
        ''' <summary>
        ''' Read in all customers
        ''' </summary>
        ''' <returns></returns>
        Public Shared Async Function AllAsync() As Task(Of List(Of Customer))
            Return Await Task.Run(Async Function()
                Using context = New Context.NorthWindContext()
                    Return Await context.Customers.ToListAsync()
                End Using
            End Function)
        End Function
    End Class
End NameSpace