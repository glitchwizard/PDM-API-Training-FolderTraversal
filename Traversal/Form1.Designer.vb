<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraversalForm
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
        Me.TraversFilesButton = New System.Windows.Forms.Button()
        Me.VaultsComboBox = New System.Windows.Forms.ComboBox()
        Me.VaultsLabel = New System.Windows.Forms.Label()
        Me.TraverseFoldersButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TraversFilesButton
        '
        Me.TraversFilesButton.Location = New System.Drawing.Point(34, 72)
        Me.TraversFilesButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TraversFilesButton.Name = "TraversFilesButton"
        Me.TraversFilesButton.Size = New System.Drawing.Size(101, 41)
        Me.TraversFilesButton.TabIndex = 18
        Me.TraversFilesButton.Text = "Traverse Files"
        Me.TraversFilesButton.UseVisualStyleBackColor = True
        '
        'VaultsComboBox
        '
        Me.VaultsComboBox.FormattingEnabled = True
        Me.VaultsComboBox.Location = New System.Drawing.Point(15, 36)
        Me.VaultsComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.VaultsComboBox.Name = "VaultsComboBox"
        Me.VaultsComboBox.Size = New System.Drawing.Size(136, 21)
        Me.VaultsComboBox.TabIndex = 16
        '
        'VaultsLabel
        '
        Me.VaultsLabel.AutoSize = True
        Me.VaultsLabel.Location = New System.Drawing.Point(15, 20)
        Me.VaultsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VaultsLabel.Name = "VaultsLabel"
        Me.VaultsLabel.Size = New System.Drawing.Size(136, 13)
        Me.VaultsLabel.TabIndex = 17
        Me.VaultsLabel.Text = "Select Preferred Vault View"
        '
        'TraverseFoldersButton
        '
        Me.TraverseFoldersButton.Location = New System.Drawing.Point(25, 131)
        Me.TraverseFoldersButton.Name = "TraverseFoldersButton"
        Me.TraverseFoldersButton.Size = New System.Drawing.Size(117, 21)
        Me.TraverseFoldersButton.TabIndex = 19
        Me.TraverseFoldersButton.Text = "Traverse Folders"
        Me.TraverseFoldersButton.UseVisualStyleBackColor = True
        '
        'TraversalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 164)
        Me.Controls.Add(Me.TraverseFoldersButton)
        Me.Controls.Add(Me.TraversFilesButton)
        Me.Controls.Add(Me.VaultsComboBox)
        Me.Controls.Add(Me.VaultsLabel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "TraversalForm"
        Me.Text = "Traversal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TraversFilesButton As System.Windows.Forms.Button
	Friend WithEvents VaultsComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents VaultsLabel As System.Windows.Forms.Label
	Friend WithEvents TraverseFoldersButton As Button
End Class
