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
        Me.AllCustomersButton = New System.Windows.Forms.Button()
        Me.CustomerByIdentifierButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIdTextBox = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AllCustomersButton
        '
        Me.AllCustomersButton.Location = New System.Drawing.Point(16, 30)
        Me.AllCustomersButton.Name = "AllCustomersButton"
        Me.AllCustomersButton.Size = New System.Drawing.Size(146, 23)
        Me.AllCustomersButton.TabIndex = 0
        Me.AllCustomersButton.Text = "All customers"
        Me.AllCustomersButton.UseVisualStyleBackColor = True
        '
        'CustomerByIdentifierButton
        '
        Me.CustomerByIdentifierButton.Location = New System.Drawing.Point(16, 59)
        Me.CustomerByIdentifierButton.Name = "CustomerByIdentifierButton"
        Me.CustomerByIdentifierButton.Size = New System.Drawing.Size(146, 23)
        Me.CustomerByIdentifierButton.TabIndex = 1
        Me.CustomerByIdentifierButton.Text = "Customer by Id"
        Me.CustomerByIdentifierButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(772, 200)
        Me.DataGridView1.TabIndex = 2
        '
        'CustomerIdTextBox
        '
        Me.CustomerIdTextBox.Location = New System.Drawing.Point(22, 321)
        Me.CustomerIdTextBox.Name = "CustomerIdTextBox"
        Me.CustomerIdTextBox.Size = New System.Drawing.Size(100, 23)
        Me.CustomerIdTextBox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 437)
        Me.Controls.Add(Me.CustomerIdTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CustomerByIdentifierButton)
        Me.Controls.Add(Me.AllCustomersButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AllCustomersButton As Button
    Friend WithEvents CustomerByIdentifierButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomerIdTextBox As TextBox
End Class
