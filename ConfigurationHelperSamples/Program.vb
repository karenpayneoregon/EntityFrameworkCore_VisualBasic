Imports System
Imports ConfigurationHelper
Imports ConfigurationHelper.Classes

Module Program
    Sub Main(args As String())

        WriteSection("Data connection string")
        Console.WriteLine($"Connection string: {GeneralSettings().DatabaseSettings.ConnectionString}")

        Console.WriteLine()

        WriteSection("Email")
        Console.WriteLine($"PickupDirectoryLocation: {GeneralSettings().EmailSettings.PickupDirectoryLocation}")
        Console.WriteLine($"                   Host: {GeneralSettings().EmailSettings.Host}")
        Console.WriteLine($"                   Port: {GeneralSettings().EmailSettings.Port}")
        Console.WriteLine($"              EnableSsl: {GeneralSettings().EmailSettings.EnableSsl}")


        Console.ReadLine()
    End Sub
    Public Function GeneralSettings() As GeneralSettings
        Return Helper.Configuration()
    End Function
    Public Sub WriteSection(message As String)
        Dim originalForeColor = Console.ForegroundColor

        Console.ForegroundColor = ConsoleColor.Yellow

        Console.WriteLine(message)
        
        Console.ForegroundColor = originalForeColor
    End Sub

End Module
