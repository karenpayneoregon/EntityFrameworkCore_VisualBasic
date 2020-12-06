Imports Microsoft.EntityFrameworkCore

Namespace Context
    Public Class EmptyContext
        Inherits DbContext

        Public Sub New()

        End Sub
        Public Sub New(options As DbContextOptions(Of EmptyContext))
            MyBase.New(options)
        End Sub

        Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
            If Not optionsBuilder.IsConfigured Then
                optionsBuilder.UseSqlServer("Data Source=.\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True")
            End If
        End Sub
        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)

            OnModelCreatingPartial(modelBuilder)
        End Sub
        Partial Private Sub OnModelCreatingPartial(ByVal modelBuilder As ModelBuilder)
        End Sub
    End Class
End Namespace