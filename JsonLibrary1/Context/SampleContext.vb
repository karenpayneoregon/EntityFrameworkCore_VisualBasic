Imports Microsoft.EntityFrameworkCore

Imports Models

Namespace Context
	Partial Public Class SampleContext
		Inherits DbContext

		Public Sub New()
		End Sub

		Public Sub New(ByVal options As DbContextOptions(Of SampleContext))
			MyBase.New(options)
		End Sub

		Public Overridable Property People() As DbSet(Of Person)

		Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)
			If Not optionsBuilder.IsConfigured Then
				optionsBuilder.UseSqlServer(
					"Data Source=.\SQLEXPRESS;Initial Catalog=EntityFrameworkCoreSamples;" &
					"Integrated Security=True")
			End If
		End Sub

		Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)
			modelBuilder.ApplyConfiguration(New PersonConfiguration())

			OnModelCreatingPartial(modelBuilder)

		End Sub
		Partial Private Sub OnModelCreatingPartial(ByVal modelBuilder As ModelBuilder)
		End Sub
	End Class
End Namespace
