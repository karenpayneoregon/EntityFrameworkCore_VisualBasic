Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata.Builders

Imports Models

Imports Newtonsoft.Json

Namespace Context
	Public Class PersonConfiguration
		Implements IEntityTypeConfiguration(Of Person)

		Private Sub IEntityTypeConfiguration_Configure(builder As EntityTypeBuilder(Of Person)) _
			Implements IEntityTypeConfiguration(Of Person).Configure

			builder.ToTable("Person")

			builder.Property(Function(e) e.Addresses).HasConversion(Function(list) _
				JsonConvert.SerializeObject(list, New JsonSerializerSettings With {
											   .NullValueHandling = NullValueHandling.Ignore}
											), Function(list) _
						JsonConvert.DeserializeObject(Of IList(Of Address))(list,
						New JsonSerializerSettings With {.NullValueHandling = NullValueHandling.Ignore}))
		End Sub
	End Class
End Namespace
