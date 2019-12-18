<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudentWindow
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
        Me.confirmStudent = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.lastBox = New System.Windows.Forms.TextBox()
        Me.firstBox = New System.Windows.Forms.TextBox()
        Me.lastLabel = New System.Windows.Forms.Label()
        Me.firstLabel = New System.Windows.Forms.Label()
        Me.hourBox = New System.Windows.Forms.ComboBox()
        Me.hourLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'confirmStudent
        '
        Me.confirmStudent.Location = New System.Drawing.Point(12, 254)
        Me.confirmStudent.Name = "confirmStudent"
        Me.confirmStudent.Size = New System.Drawing.Size(75, 35)
        Me.confirmStudent.TabIndex = 0
        Me.confirmStudent.Text = "Confirm"
        Me.confirmStudent.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(229, 254)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 35)
        Me.cancelButton.TabIndex = 1
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'lastBox
        '
        Me.lastBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastBox.Location = New System.Drawing.Point(12, 108)
        Me.lastBox.Name = "lastBox"
        Me.lastBox.Size = New System.Drawing.Size(286, 26)
        Me.lastBox.TabIndex = 12
        '
        'firstBox
        '
        Me.firstBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstBox.Location = New System.Drawing.Point(12, 33)
        Me.firstBox.Name = "firstBox"
        Me.firstBox.Size = New System.Drawing.Size(286, 26)
        Me.firstBox.TabIndex = 11
        '
        'lastLabel
        '
        Me.lastLabel.AutoSize = True
        Me.lastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastLabel.Location = New System.Drawing.Point(115, 75)
        Me.lastLabel.Name = "lastLabel"
        Me.lastLabel.Size = New System.Drawing.Size(80, 20)
        Me.lastLabel.TabIndex = 9
        Me.lastLabel.Text = "Lastname"
        '
        'firstLabel
        '
        Me.firstLabel.AutoSize = True
        Me.firstLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstLabel.Location = New System.Drawing.Point(115, 9)
        Me.firstLabel.Name = "firstLabel"
        Me.firstLabel.Size = New System.Drawing.Size(80, 20)
        Me.firstLabel.TabIndex = 8
        Me.firstLabel.Text = "Firstname"
        '
        'hourBox
        '
        Me.hourBox.FormattingEnabled = True
        Me.hourBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.hourBox.Location = New System.Drawing.Point(92, 199)
        Me.hourBox.Name = "hourBox"
        Me.hourBox.Size = New System.Drawing.Size(121, 28)
        Me.hourBox.TabIndex = 13
        '
        'hourLabel
        '
        Me.hourLabel.AutoSize = True
        Me.hourLabel.Location = New System.Drawing.Point(134, 167)
        Me.hourLabel.Name = "hourLabel"
        Me.hourLabel.Size = New System.Drawing.Size(44, 20)
        Me.hourLabel.TabIndex = 14
        Me.hourLabel.Text = "Hour"
        '
        'addStudentWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 301)
        Me.Controls.Add(Me.hourLabel)
        Me.Controls.Add(Me.hourBox)
        Me.Controls.Add(Me.lastBox)
        Me.Controls.Add(Me.firstBox)
        Me.Controls.Add(Me.lastLabel)
        Me.Controls.Add(Me.firstLabel)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.confirmStudent)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "addStudentWindow"
        Me.Text = "addStudentWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents confirmStudent As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents lastBox As TextBox
    Friend WithEvents firstBox As TextBox
    Friend WithEvents lastLabel As Label
    Friend WithEvents firstLabel As Label
    Friend WithEvents hourBox As ComboBox
    Friend WithEvents hourLabel As Label
End Class
