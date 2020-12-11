Imports System.Linq

Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.Configuration

Imports Models

Namespace Contexts
	Partial Public Class SchoolContext
		Inherits DbContext

		Public Sub New()
		End Sub

		Public Sub New(ByVal options As DbContextOptions(Of SchoolContext))
			MyBase.New(options)
		End Sub

		Public Overridable Property People() As DbSet(Of Person)

		Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)
			If Not optionsBuilder.IsConfigured Then
				optionsBuilder.UseSqlServer(BuildConnection())
			End If
		End Sub
		''' <summary>
		''' Build connection string from appsettings.json in section database
		''' </summary>
		''' <returns>Connection string</returns>
		Private Shared Function BuildConnection() As String

			Dim configuration = (New ConfigurationBuilder()).AddJsonFile("appsettings.json", True, True).Build()

			Dim sections = configuration.GetSection("database").GetChildren().ToList()

			Dim connectionString =
					$"Data Source={sections(1).Value};" &
					$"Initial Catalog={sections(0).Value};" &
					$"Integrated Security={sections(2).Value}"


			Return connectionString

		End Function

		Protected Overrides Sub OnModelCreating(ByVal modelBuilder As ModelBuilder)
			modelBuilder.Entity(Of Person)(
				Sub(entity)
					entity.ToTable("Person")

					entity.Property(Function(e) e.PersonId).
											  HasColumnName("PersonID")

					entity.Property(Function(e) e.Discriminator).
											  IsRequired().
											  HasMaxLength(50)

					entity.Property(Function(e) e.EnrollmentDate).HasColumnType("datetime").
											  HasAnnotation("Relational:ColumnType", "datetime")

					entity.Property(Function(e) e.FirstName).
											  IsRequired().
											  HasMaxLength(50)

					entity.Property(Function(e) e.HireDate).
											  HasColumnType("datetime").
											  HasAnnotation("Relational:ColumnType", "datetime")

					entity.Property(Function(e) e.LastName).
											  IsRequired().HasMaxLength(50)
				End Sub)

			OnModelCreatingPartial(modelBuilder)

		End Sub

		Partial Private Sub OnModelCreatingPartial(ByVal modelBuilder As ModelBuilder)
		End Sub
	End Class
End Namespace