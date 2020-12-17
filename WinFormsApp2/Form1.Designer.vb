<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CollectButton = New System.Windows.Forms.Button()
        Me.GetByFormNameButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SerializeButton = New System.Windows.Forms.Button()
        Me.DeserializeFromFileButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CollectButton
        '
        Me.CollectButton.Location = New System.Drawing.Point(27, 12)
        Me.CollectButton.Name = "CollectButton"
        Me.CollectButton.Size = New System.Drawing.Size(259, 23)
        Me.CollectButton.TabIndex = 0
        Me.CollectButton.Text = "Collect controls"
        Me.CollectButton.UseVisualStyleBackColor = True
        '
        'GetByFormNameButton
        '
        Me.GetByFormNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GetByFormNameButton.Location = New System.Drawing.Point(28, 46)
        Me.GetByFormNameButton.Name = "GetByFormNameButton"
        Me.GetByFormNameButton.Size = New System.Drawing.Size(259, 23)
        Me.GetByFormNameButton.TabIndex = 1
        Me.GetByFormNameButton.Text = "Get by Form name"
        Me.GetByFormNameButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"One", "Two", "Three"})
        Me.ComboBox1.Location = New System.Drawing.Point(28, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(28, 186)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 19)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(28, 220)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(85, 19)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'SerializeButton
        '
        Me.SerializeButton.Location = New System.Drawing.Point(27, 80)
        Me.SerializeButton.Name = "SerializeButton"
        Me.SerializeButton.Size = New System.Drawing.Size(259, 23)
        Me.SerializeButton.TabIndex = 5
        Me.SerializeButton.Text = "Serialize to file"
        Me.SerializeButton.UseVisualStyleBackColor = True
        '
        'DeserializeFromFileButton
        '
        Me.DeserializeFromFileButton.Location = New System.Drawing.Point(27, 109)
        Me.DeserializeFromFileButton.Name = "DeserializeFromFileButton"
        Me.DeserializeFromFileButton.Size = New System.Drawing.Size(259, 23)
        Me.DeserializeFromFileButton.TabIndex = 6
        Me.DeserializeFromFileButton.Text = "Deserialize from file"
        Me.DeserializeFromFileButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 388)
        Me.Controls.Add(Me.DeserializeFromFileButton)
        Me.Controls.Add(Me.SerializeButton)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GetByFormNameButton)
        Me.Controls.Add(Me.CollectButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CollectButton As Button
    Friend WithEvents GetByFormNameButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents SerializeButton As Button
    Friend WithEvents DeserializeFromFileButton As Button
End Class
