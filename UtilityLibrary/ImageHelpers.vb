Imports System.Drawing

Public Class ImageHelpers
    ''' <summary>
    ''' Converts a byte array to an image
    ''' </summary>
    ''' <param name="byteArray">byte array to convert</param>
    ''' <returns>Image from byte array</returns>
    Public Shared Function ByteArrayToImage(ByVal byteArray() As Byte) As Image
        
        Dim converter = New ImageConverter()
        Dim image As Image = DirectCast(converter.ConvertFrom(byteArray), Image)

        Return image

    End Function
End Class
