''' <summary>
''' Collection of language extenstion methods for working with form controls.
''' </summary>
Public Module ControlExtensions

	''' <summary>
	''' Provides access to all controls on a form including
	''' controls within containers e.g. panel and group-box etc.
	''' </summary>
	''' <typeparam name="T"></typeparam>
	''' <param name="control"></param>
	''' <returns></returns>
	<Runtime.CompilerServices.Extension>
	Public Iterator Function Descendants(Of T As Class)(control As Control) As IEnumerable(Of T)
		For Each child As Control In control.Controls

			Dim currentChild = TryCast(child, T)
			If currentChild IsNot Nothing Then
				Yield currentChild
			End If

			If child.HasChildren Then
				For Each descendant As T In child.Descendants(Of T)()
					Yield descendant
				Next
			End If
		Next

	End Function
	''' <summary>
	''' Get all TextBox controls from specified control
	''' </summary>
	''' <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
	''' <returns>List of TextBoxes or an empty list if no TextBoxes on control</returns>
	<Runtime.CompilerServices.Extension>
	Public Function TextBoxList(control As Control) As List(Of TextBox)
		Return control.Descendants(Of TextBox)().ToList()
	End Function
	''' <summary>
	''' Get all TextBox controls from specified control
	''' </summary>
	''' <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
	''' <returns>List of TextBoxes or an empty list if no TextBoxes on control</returns>
	<Runtime.CompilerServices.Extension>
	Public Function ListViewViewList(control As Control) As List(Of ListView)
		Return control.Descendants(Of ListView)().ToList()
	End Function
	''' <summary>
	''' Get all CheckBox controls from specified control
	''' </summary>
	''' <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
	''' <returns>List of CheckBox or an empty list if no CheckBox on control</returns>
	<Runtime.CompilerServices.Extension>
	Public Function CheckBoxList(control As Control) As List(Of CheckBox)
		Return control.Descendants(Of CheckBox)().ToList()
	End Function
	''' <summary>
	''' Get all ComboBox controls from specified control
	''' </summary>
	''' <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
	''' <returns>List of ComboBox or an empty list if no ComboBox on control</returns>
	<Runtime.CompilerServices.Extension>
	Public Function ComboBoxList(control As Control) As List(Of ComboBox)
		Return control.Descendants(Of ComboBox)().ToList()
	End Function
	''' <summary>
	''' Get all ListBox controls from specified control
	''' </summary>
	''' <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
	''' <returns>List of ListBox or an empty list if no ListBox on control</returns>
	<Runtime.CompilerServices.Extension>
	Public Function ListBoxList(control As Control) As List(Of ListBox)
		Return control.Descendants(Of ListBox)().ToList()
	End Function
	''' <summary>
	''' Get all Panel controls from specified control
	''' </summary>
	''' <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
	''' <returns>List of Panel or an empty list if no Panel on control</returns>
	<Runtime.CompilerServices.Extension>
	Public Function PanelList(control As Control) As List(Of Panel)
		Return control.Descendants(Of Panel)().ToList()
	End Function
	''' <summary>
	''' Get all GroupBox controls from specified control
	''' </summary>
	''' <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
	''' <returns>List of GroupBox or an empty list if no GroupBox on control</returns>
	<Runtime.CompilerServices.Extension>
	Public Function GroupBoxList(control As Control) As List(Of GroupBox)
		Return control.Descendants(Of GroupBox)().ToList()
	End Function
	''' <summary>
	''' Get all Button controls from specified control
	''' </summary>
	''' <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
	''' <returns>List of Button or an empty list if no Button on control</returns>
	<Runtime.CompilerServices.Extension>
	Public Function ButtonList(control As Control) As List(Of Button)
		Return control.Descendants(Of Button)().ToList()
	End Function
	''' <summary>
	''' Get all RadioButton controls from specified control
	''' </summary>
	''' <param name="control">Desired control which can be a form or a control like a panel or GroupBox on a form</param>
	''' <returns>List of RadioButton or an empty list if no RadioButton on control</returns>
	<Runtime.CompilerServices.Extension>
	Public Function RadioButtonList(control As Control) As List(Of RadioButton)
		Return control.Descendants(Of RadioButton)().ToList()
	End Function
	''' <summary>
	''' Get selected/checked RadioButton for a control such as a panel, group box or form
	''' </summary>
	''' <param name="control">control, form, panel or group box</param>
	''' <param name="Checked">True false, defaults to true</param>
	''' <returns>One checked Radio button or a empty value</returns>
	<Runtime.CompilerServices.Extension>
	Public Function RadioButtonChecked(control As Control, Optional ByVal Checked As Boolean = True) As RadioButton
		Return control.Descendants(Of RadioButton)().ToList().FirstOrDefault(Function(radioButton) radioButton.Checked = Checked)
	End Function
	''' <summary>
	''' Control names for a control
	''' </summary>
	''' <param name="controls">Controls</param>
	''' <returns>names for controls</returns>
	<Runtime.CompilerServices.Extension>
	Public Function ControlNames(controls As IEnumerable(Of Control)) As String()
		Return controls.Select(Function(control) control.Name).ToArray()
	End Function
End Module