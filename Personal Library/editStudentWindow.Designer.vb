<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editStudentWindow
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
        Me.lastBox = New System.Windows.Forms.TextBox()
        Me.firstBox = New System.Windows.Forms.TextBox()
        Me.hourLabel = New System.Windows.Forms.Label()
        Me.lastLabel = New System.Windows.Forms.Label()
        Me.firstLabel = New System.Windows.Forms.Label()
        Me.cancel = New System.Windows.Forms.Button()
        Me.removeStudent = New System.Windows.Forms.Button()
        Me.saveChanges = New System.Windows.Forms.Button()
        Me.hourBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lastBox
        '
        Me.lastBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastBox.Location = New System.Drawing.Point(23, 106)
        Me.lastBox.Name = "lastBox"
        Me.lastBox.Size = New System.Drawing.Size(327, 26)
        Me.lastBox.TabIndex = 21
        '
        'firstBox
        '
        Me.firstBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstBox.Location = New System.Drawing.Point(23, 31)
        Me.firstBox.Name = "firstBox"
        Me.firstBox.Size = New System.Drawing.Size(327, 26)
        Me.firstBox.TabIndex = 20
        '
        'hourLabel
        '
        Me.hourLabel.AutoSize = True
        Me.hourLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourLabel.Location = New System.Drawing.Point(170, 145)
        Me.hourLabel.Name = "hourLabel"
        Me.hourLabel.Size = New System.Drawing.Size(44, 20)
        Me.hourLabel.TabIndex = 19
        Me.hourLabel.Text = "Hour"
        '
        'lastLabel
        '
        Me.lastLabel.AutoSize = True
        Me.lastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastLabel.Location = New System.Drawing.Point(158, 72)
        Me.lastLabel.Name = "lastLabel"
        Me.lastLabel.Size = New System.Drawing.Size(80, 20)
        Me.lastLabel.TabIndex = 18
        Me.lastLabel.Text = "Lastname"
        '
        'firstLabel
        '
        Me.firstLabel.AutoSize = True
        Me.firstLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstLabel.Location = New System.Drawing.Point(158, 3)
        Me.firstLabel.Name = "firstLabel"
        Me.firstLabel.Size = New System.Drawing.Size(80, 20)
        Me.firstLabel.TabIndex = 17
        Me.firstLabel.Text = "Firstname"
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Location = New System.Drawing.Point(284, 226)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 28)
        Me.cancel.TabIndex = 16
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'removeStudent
        '
        Me.removeStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeStudent.Location = New System.Drawing.Point(131, 226)
        Me.removeStudent.Name = "removeStudent"
        Me.removeStudent.Size = New System.Drawing.Size(147, 28)
        Me.removeStudent.TabIndex = 15
        Me.removeStudent.Text = "Remove Student"
        Me.removeStudent.UseVisualStyleBackColor = True
        '
        'saveChanges
        '
        Me.saveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveChanges.Location = New System.Drawing.Point(3, 226)
        Me.saveChanges.Name = "saveChanges"
        Me.saveChanges.Size = New System.Drawing.Size(122, 28)
        Me.saveChanges.TabIndex = 14
        Me.saveChanges.Text = "Save Changes"
        Me.saveChanges.UseVisualStyleBackColor = True
        '
        'hourBox
        '
        Me.hourBox.FormattingEnabled = True
        Me.hourBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.hourBox.Location = New System.Drawing.Point(126, 168)
        Me.hourBox.Name = "hourBox"
        Me.hourBox.Size = New System.Drawing.Size(121, 21)
        Me.hourBox.TabIndex = 22
        '
        'editStudentWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 261)
        Me.Controls.Add(Me.hourBox)
        Me.Controls.Add(Me.lastBox)
        Me.Controls.Add(Me.firstBox)
        Me.Controls.Add(Me.hourLabel)
        Me.Controls.Add(Me.lastLabel)
        Me.Controls.Add(Me.firstLabel)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.removeStudent)
        Me.Controls.Add(Me.saveChanges)
        Me.Name = "editStudentWindow"
        Me.Text = "editStudentWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lastBox As TextBox
    Friend WithEvents firstBox As TextBox
    Friend WithEvents hourLabel As Label
    Friend WithEvents lastLabel As Label
    Friend WithEvents firstLabel As Label
    Friend WithEvents cancel As Button
    Friend WithEvents removeStudent As Button
    Friend WithEvents saveChanges As Button
    Friend WithEvents hourBox As ComboBox
End Class
