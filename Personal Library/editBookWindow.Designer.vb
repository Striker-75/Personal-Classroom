<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editBookWindow
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
        Me.saveChanges = New System.Windows.Forms.Button()
        Me.removeBook = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.isbnBox = New System.Windows.Forms.TextBox()
        Me.authorBox = New System.Windows.Forms.TextBox()
        Me.titleBox = New System.Windows.Forms.TextBox()
        Me.isbnLabel = New System.Windows.Forms.Label()
        Me.authorLabel = New System.Windows.Forms.Label()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'saveChanges
        '
        Me.saveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveChanges.Location = New System.Drawing.Point(10, 232)
        Me.saveChanges.Name = "saveChanges"
        Me.saveChanges.Size = New System.Drawing.Size(122, 28)
        Me.saveChanges.TabIndex = 0
        Me.saveChanges.Text = "Save Changes"
        Me.saveChanges.UseVisualStyleBackColor = True
        '
        'removeBook
        '
        Me.removeBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeBook.Location = New System.Drawing.Point(138, 232)
        Me.removeBook.Name = "removeBook"
        Me.removeBook.Size = New System.Drawing.Size(118, 28)
        Me.removeBook.TabIndex = 1
        Me.removeBook.Text = "Remove Book"
        Me.removeBook.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Location = New System.Drawing.Point(262, 232)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 28)
        Me.cancel.TabIndex = 2
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'isbnBox
        '
        Me.isbnBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnBox.Location = New System.Drawing.Point(11, 174)
        Me.isbnBox.Name = "isbnBox"
        Me.isbnBox.Size = New System.Drawing.Size(326, 26)
        Me.isbnBox.TabIndex = 13
        '
        'authorBox
        '
        Me.authorBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorBox.Location = New System.Drawing.Point(10, 112)
        Me.authorBox.Name = "authorBox"
        Me.authorBox.Size = New System.Drawing.Size(327, 26)
        Me.authorBox.TabIndex = 12
        '
        'titleBox
        '
        Me.titleBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleBox.Location = New System.Drawing.Point(10, 37)
        Me.titleBox.Name = "titleBox"
        Me.titleBox.Size = New System.Drawing.Size(327, 26)
        Me.titleBox.TabIndex = 11
        '
        'isbnLabel
        '
        Me.isbnLabel.AutoSize = True
        Me.isbnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnLabel.Location = New System.Drawing.Point(157, 151)
        Me.isbnLabel.Name = "isbnLabel"
        Me.isbnLabel.Size = New System.Drawing.Size(47, 20)
        Me.isbnLabel.TabIndex = 10
        Me.isbnLabel.Text = "ISBN"
        '
        'authorLabel
        '
        Me.authorLabel.AutoSize = True
        Me.authorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorLabel.Location = New System.Drawing.Point(157, 79)
        Me.authorLabel.Name = "authorLabel"
        Me.authorLabel.Size = New System.Drawing.Size(57, 20)
        Me.authorLabel.TabIndex = 9
        Me.authorLabel.Text = "Author"
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(145, 9)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(79, 20)
        Me.titleLabel.TabIndex = 8
        Me.titleLabel.Text = "Book Title"
        '
        'editBookWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 272)
        Me.Controls.Add(Me.isbnBox)
        Me.Controls.Add(Me.authorBox)
        Me.Controls.Add(Me.titleBox)
        Me.Controls.Add(Me.isbnLabel)
        Me.Controls.Add(Me.authorLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.removeBook)
        Me.Controls.Add(Me.saveChanges)
        Me.Name = "editBookWindow"
        Me.Text = "editBookWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents saveChanges As Button
    Friend WithEvents removeBook As Button
    Friend WithEvents cancel As Button
    Friend WithEvents isbnBox As TextBox
    Friend WithEvents authorBox As TextBox
    Friend WithEvents titleBox As TextBox
    Friend WithEvents isbnLabel As Label
    Friend WithEvents authorLabel As Label
    Friend WithEvents titleLabel As Label
End Class
