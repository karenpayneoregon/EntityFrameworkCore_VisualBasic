Imports System.IO
Imports Newtonsoft.Json

Public Class FormOperations
    ''' <summary>
    ''' Container for controls taken from executing Collect method
    ''' </summary>
    Public Shared Container As New List(Of ControlContainer)
    ''' <summary>
    ''' File name to read and write too
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property FileName() As String
    ''' <summary>
    ''' Determines if there are controls in the Container
    ''' </summary>
    ''' <returns>True if Container is populated</returns>
    Public Shared ReadOnly Property HasControls() As Boolean
        Get
            Return Container.Count > 0
        End Get
    End Property
    ''' <summary>
    ''' Determines if the json file exists or not
    ''' </summary>
    ''' <returns>FileName exists</returns>
    Public Shared ReadOnly Property FileExists() As Boolean
        Get
            Return File.Exists(FileName)
        End Get
    End Property
    ''' <summary>
    ''' Serialize Container items to json file
    ''' </summary>
    Public Shared Sub SerializeToFile()
        If HasControls Then
            Dim output As String = JsonConvert.SerializeObject(Container, Formatting.Indented)
            File.WriteAllText(FileName, output)
        End If
    End Sub
    ''' <summary>
    ''' Read controls in json file to the Container
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function DeserializeFromFile() As Boolean
        If FileExists Then
            Dim json = File.ReadAllText(FileName)
            Container = JsonConvert.DeserializeObject(Of List(Of ControlContainer))(json)
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Sub Collect(sender As Form)

        Container.Clear()

        Dim itemList As New List(Of ControlContainer)

        sender.ButtonList.ForEach(Sub(button)
                                      itemList.Add(New ControlContainer() With {
                                        .Type = GetType(Button),
                                        .Text = button.Text,
                                        .Anchor = button.Anchor,
                                        .Location = button.Location,
                                        .TabIndex = button.TabIndex,
                                        .Name = button.Name,
                                        .FormName = sender.Name
                            }
                         )
                                  End Sub)

        sender.CheckBoxList.ForEach(Sub(checkBox)
                                        itemList.Add(New ControlContainer() With {
                                            .Type = GetType(CheckBox),
                                            .Anchor = checkBox.Anchor,
                                            .Location = checkBox.Location,
                                            .TabIndex = checkBox.TabIndex,
                                            .Name = checkBox.Name,
                                            .Checked = checkBox.Checked,
                                            .FormName = sender.Name, .Text = checkBox.Text
                            }
                         )
                                    End Sub)

        Dim buttons = itemList.Where(Function(item) item.Type Is GetType(Button)).ToList()
        Dim checkBoxes = itemList.Where(Function(item) item.Type Is GetType(CheckBox)).ToList()

        Container.AddRange(buttons)
        Container.AddRange(checkBoxes)
    End Sub

    Public Shared Function GetByForm(sender As String) As List(Of ControlContainer)
        If HasControls Then
            Return Container.Where(Function(item) item.FormName = sender).ToList()
        Else
            Return Nothing
        End If

    End Function


End Class
