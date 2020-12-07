Imports System.IO
Imports ConfigurationHelper
Imports Microsoft.EntityFrameworkCore
Imports NorthWindLibrary.Models

Namespace Context
    ''' <summary>
    ''' Code sample for logging to a file
    ''' </summary>
    Public Class NorthWindContextLogging
        Inherits DbContext

        Public Sub New()

        End Sub
        Public Sub New(options As DbContextOptions(Of NorthWindContext))
            MyBase.New(options)
        End Sub
        Public Overridable Property Customers() As DbSet(Of Customer)

        Private ReadOnly _logStream As New StreamWriter("ef-log.txt", append:= True)

        Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
            If Not optionsBuilder.IsConfigured Then

                optionsBuilder.UseSqlServer(Helper.ConnectionString()).
                    EnableSensitiveDataLogging().
                    EnableDetailedErrors().
                    LogTo(Sub(x) _logStream.WriteLine(x))
            End If
        End Sub
        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
            modelBuilder.ApplyConfiguration(New CustomerConfiguration())

            OnModelCreatingPartial(modelBuilder)
        End Sub
        Partial Private Sub OnModelCreatingPartial(modelBuilder As ModelBuilder)
        End Sub
        Public Overrides Sub Dispose()
            MyBase.Dispose()
            _logStream.Dispose()
        End Sub

        Public Overrides Function DisposeAsync() As ValueTask
            _logStream.DisposeAsync()
            Return MyBase.DisposeAsync()
        End Function
    End Class
End NameSpace