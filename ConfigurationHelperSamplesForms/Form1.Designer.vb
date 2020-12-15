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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HostTextBox = New System.Windows.Forms.TextBox()
        Me.EnableSslCheckBox = New System.Windows.Forms.CheckBox()
        Me.DefaultCredentialsCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host"
        '
        'HostTextBox
        '
        Me.HostTextBox.Location = New System.Drawing.Point(12, 33)
        Me.HostTextBox.Name = "HostTextBox"
        Me.HostTextBox.Size = New System.Drawing.Size(152, 23)
        Me.HostTextBox.TabIndex = 1
        '
        'EnableSslCheckBox
        '
        Me.EnableSslCheckBox.AutoSize = True
        Me.EnableSslCheckBox.Location = New System.Drawing.Point(12, 74)
        Me.EnableSslCheckBox.Name = "EnableSslCheckBox"
        Me.EnableSslCheckBox.Size = New System.Drawing.Size(78, 19)
        Me.EnableSslCheckBox.TabIndex = 2
        Me.EnableSslCheckBox.Text = "Enable Ssl"
        Me.EnableSslCheckBox.UseVisualStyleBackColor = True
        '
        'DefaultCredentialsCheckBox
        '
        Me.DefaultCredentialsCheckBox.AutoSize = True
        Me.DefaultCredentialsCheckBox.Location = New System.Drawing.Point(11, 99)
        Me.DefaultCredentialsCheckBox.Name = "DefaultCredentialsCheckBox"
        Me.DefaultCredentialsCheckBox.Size = New System.Drawing.Size(124, 19)
        Me.DefaultCredentialsCheckBox.TabIndex = 3
        Me.DefaultCredentialsCheckBox.Text = "Default credentials"
        Me.DefaultCredentialsCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 148)
        Me.Controls.Add(Me.DefaultCredentialsCheckBox)
        Me.Controls.Add(Me.EnableSslCheckBox)
        Me.Controls.Add(Me.HostTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents HostTextBox As TextBox
    Friend WithEvents EnableSslCheckBox As CheckBox
    Friend WithEvents DefaultCredentialsCheckBox As CheckBox
End Class
