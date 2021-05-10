Public Class Form1
    Private Sub CollectButton_Click(sender As Object, e As EventArgs) Handles CollectButton.Click
        FormOperations.Collect(Me)
    End Sub

    Private Sub GetByFormName_Click(sender As Object, e As EventArgs) Handles GetByFormNameButton.Click

        Dim controls = FormOperations.GetByForm(Name)

        If controls IsNot Nothing Then
            MessageBox.Show(controls.Count.ToString())
        Else
            MessageBox.Show("No controls located")
        End If

    End Sub
    Private Sub SerializeButton_Click(sender As Object, e As EventArgs) Handles SerializeButton.Click

        FormOperations.SerializeToFile()

    End Sub
    ''' <summary>
    ''' Set file name to work with in FormOperations
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        FormOperations.FileName = "Forms.json"

    End Sub
    Private Sub DeserializeFromFile_Click(sender As Object, e As EventArgs) Handles DeserializeFromFileButton.Click

        If FormOperations.DeserializeFromFile() Then
            For Each controlContainer As ControlContainer In FormOperations.Container
                Debug.WriteLine($"{controlContainer.FormName}.{controlContainer.Name} is {controlContainer.Type}")
            Next
        End If

    End Sub
End Class
