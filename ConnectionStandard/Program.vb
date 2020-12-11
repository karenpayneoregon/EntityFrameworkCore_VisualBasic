Imports System
Imports System.Linq

Imports Contexts

Friend Class Program
    Public Shared Sub Main(ByVal args() As String)

        Example1()

        Example2()

        Console.ReadLine()
    End Sub

    ''' <summary>
    ''' Read connection string in SchoolContext
    ''' </summary>
    Private Shared Sub Example1()
        Using context = New SchoolContext()
            Dim people = context.People.ToList()
            Console.WriteLine(people.Count)
        End Using
    End Sub
    ''' <summary>
    ''' Create SchoolContext in factory class
    ''' </summary>
    Private Shared Sub Example2()
        Using context = ContextFactory.CreateDbContext()
            Dim people = context.People.ToList()
            Console.WriteLine(people.Count)
        End Using
    End Sub
End Class