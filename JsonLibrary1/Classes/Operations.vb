Imports Context

Imports Models

Namespace Classes
	Public Class Operations
		Public Shared Function GetPersons() As List(Of Person)
			Using context = New SampleContext()
				Return context.People.ToList()
			End Using
		End Function

		Public Shared Function Add() As Boolean
			Dim person As New Person With {
				.FirstName = "Karen",
				.LastName = "Payne",
				.DateOfBirth = New DateTime(1956, 9, 24),
				.Addresses = New List(Of Address)() From {
					New Address() With {
						.Type = "Business",
						.City = "Salem",
						.Company = "ABC",
						.Number = "1",
						.Street = "111 Orange Way"
					},
					New Address() With {
						.Type = "Home",
						.City = "Salem",
						.Company = "ABC",
						.Number = "2",
						.Street = "123 Green Ave"
					}
				}
			}

			Using context = New SampleContext()
				context.People.Add(person)
				Return context.SaveChanges() = 1
			End Using

		End Function
	End Class
End Namespace
