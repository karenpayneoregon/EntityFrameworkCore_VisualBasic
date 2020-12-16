Imports System.Data.OleDb
Namespace My

    Partial Friend Class MyApplication
        Private Shared ConnectionString As String =
                    "Provider=Microsoft.ACE.OLEDB.12.0;" &
                    "Data Source=C:\Users\DR\Desktop\LoginDatabase.mdb"

        Private Shared _connection As OleDbConnection

        Public Shared ReadOnly Property AccessConnection() As OleDbConnection
            Get
                If _connection Is Nothing Then
                    _connection = New OleDbConnection(ConnectionString)
                End If

                Return _connection
            End Get
        End Property

    End Class

End Namespace
