<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkInWindow
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
        Me.checkIn = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.barcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'checkIn
        '
        Me.checkIn.Location = New System.Drawing.Point(18, 148)
        Me.checkIn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.checkIn.Name = "checkIn"
        Me.checkIn.Size = New System.Drawing.Size(112, 35)
        Me.checkIn.TabIndex = 0
        Me.checkIn.Text = "Check In"
        Me.checkIn.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(223, 144)
        Me.cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(112, 35)
        Me.cancel.TabIndex = 1
        Me.cancel.Text = "Close"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'barcode
        '
        Me.barcode.Location = New System.Drawing.Point(18, 108)
        Me.barcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barcode.Name = "barcode"
        Me.barcode.Size = New System.Drawing.Size(317, 26)
        Me.barcode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Barcode"
        '
        'checkInWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 218)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barcode)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.checkIn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "checkInWindow"
        Me.Text = "checkInWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkIn As Button
    Friend WithEvents cancel As Button
    Friend WithEvents barcode As TextBox
    Friend WithEvents Label1 As Label
End Class
