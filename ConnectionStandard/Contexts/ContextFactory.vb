

Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Design
Imports Microsoft.Extensions.Configuration

Namespace Contexts
	Public Class ContextFactory
		Implements IDesignTimeDbContextFactory(Of SchoolContext)

		Private Shared _connectionString As String
		Private Const FileName As String = "appsettings.json"
		Private Shared _isProduction As Boolean
		''' <summary>
		''' Creates a SchoolContext for production or development environment
		''' </summary>
		''' <param name="production">true to use production, false or pass nothing for development environment</param>
		''' <returns>Ready to use SchoolContext</returns>
		Public Shared Function CreateDbContext(Optional production As Boolean = False) As SchoolContext
			_isProduction = production

			If String.IsNullOrWhiteSpace(_connectionString) Then
				If production Then
					LoadProductionConnectionString()
				Else
					LoadDevelopmentConnectionString()
				End If

			End If

			Dim builder = New DbContextOptionsBuilder(Of SchoolContext)()
			' ReSharper disable once AssignNullToNotNullAttribute
			builder.UseSqlServer(_connectionString)

			Return New SchoolContext(builder.Options)

		End Function

		Public Shared Function CreateDbContext(args() As String) As SchoolContext
			If String.IsNullOrWhiteSpace(_connectionString) Then
				If _isProduction Then
					LoadProductionConnectionString()
				Else
					LoadDevelopmentConnectionString()
				End If

			End If

			Dim builder = New DbContextOptionsBuilder(Of SchoolContext)()
			' ReSharper disable once AssignNullToNotNullAttribute
			builder.UseSqlServer(_connectionString)

			Return New SchoolContext(builder.Options)
		End Function

		Private Shared Sub LoadDevelopmentConnectionString()
			_connectionString = ConfigurationBuilderRoot().GetConnectionString("DevelopmentConnection")
		End Sub
		Private Shared Sub LoadProductionConnectionString()
			_connectionString = ConfigurationBuilderRoot().GetConnectionString("ProductionConnection")
		End Sub
		Private Shared Function ConfigurationBuilderRoot() As IConfigurationRoot
			Dim builder = New ConfigurationBuilder()
			builder.AddJsonFile(FileName, [optional]:=False)

			Dim configuration = builder.Build()
			Return configuration
		End Function

		Private Function IDesignTimeDbContextFactoryGeneric_CreateDbContext(ByVal args() As String) As SchoolContext Implements IDesignTimeDbContextFactory(Of SchoolContext).CreateDbContext
			Return CreateDbContext(args)
		End Function
	End Class
End Namespace
