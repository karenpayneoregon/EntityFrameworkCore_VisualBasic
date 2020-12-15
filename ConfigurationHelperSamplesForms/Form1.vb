Imports ConfigurationHelper
Imports ConfigurationHelper.Classes
Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim emailSettings = GeneralSettings().GeneralSettings.EmailSettings

        HostTextBox.Text = emailSettings.Host
        EnableSslCheckBox.Checked = emailSettings.EnableSsl
        DefaultCredentialsCheckBox.Checked = emailSettings.DefaultCredentials
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim current = GeneralSettings()
        current.GeneralSettings.EmailSettings.Host = HostTextBox.Text
        current.GeneralSettings.EmailSettings.EnableSsl = EnableSslCheckBox.Checked
        current.GeneralSettings.EmailSettings.DefaultCredentials = DefaultCredentialsCheckBox.Checked
        Helper.Update(current)

    End Sub

    Private Function GeneralSettings() As GeneralSettingsRoot
        Return Helper.AllSettings()
    End Function

End Class

