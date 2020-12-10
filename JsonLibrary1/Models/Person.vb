Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations.Schema

Imports Newtonsoft.Json

Namespace Models
	Partial Public Class Person
		Private _addressJson As String
		Public Property Id() As Integer
		Public Property FirstName() As String
		Public Property LastName() As String
		Public Property DateOfBirth() As DateTime?
		Public Property Addresses() As IList(Of Address)

		<NotMapped>
		Public ReadOnly Property AddressJson() As String
			Get
				Return JsonConvert.SerializeObject(Addresses)
			End Get
		End Property
	End Class
End Namespace