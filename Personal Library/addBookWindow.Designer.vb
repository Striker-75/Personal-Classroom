<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addBookWindow
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
        Me.addBookButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.authorLabel = New System.Windows.Forms.Label()
        Me.isbnLabel = New System.Windows.Forms.Label()
        Me.titleBox = New System.Windows.Forms.TextBox()
        Me.authorBox = New System.Windows.Forms.TextBox()
        Me.isbnBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'addBookButton
        '
        Me.addBookButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBookButton.Location = New System.Drawing.Point(12, 247)
        Me.addBookButton.Name = "addBookButton"
        Me.addBookButton.Size = New System.Drawing.Size(90, 28)
        Me.addBookButton.TabIndex = 0
        Me.addBookButton.Text = "Add Book"
        Me.addBookButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(223, 247)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 28)
        Me.cancelButton.TabIndex = 1
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(106, 35)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(79, 20)
        Me.titleLabel.TabIndex = 2
        Me.titleLabel.Text = "Book Title"
        '
        'authorLabel
        '
        Me.authorLabel.AutoSize = True
        Me.authorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorLabel.Location = New System.Drawing.Point(114, 110)
        Me.authorLabel.Name = "authorLabel"
        Me.authorLabel.Size = New System.Drawing.Size(57, 20)
        Me.authorLabel.TabIndex = 3
        Me.authorLabel.Text = "Author"
        '
        'isbnLabel
        '
        Me.isbnLabel.AutoSize = True
        Me.isbnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnLabel.Location = New System.Drawing.Point(118, 172)
        Me.isbnLabel.Name = "isbnLabel"
        Me.isbnLabel.Size = New System.Drawing.Size(47, 20)
        Me.isbnLabel.TabIndex = 4
        Me.isbnLabel.Text = "ISBN"
        '
        'titleBox
        '
        Me.titleBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleBox.Location = New System.Drawing.Point(12, 58)
        Me.titleBox.Name = "titleBox"
        Me.titleBox.Size = New System.Drawing.Size(286, 26)
        Me.titleBox.TabIndex = 5
        '
        'authorBox
        '
        Me.authorBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorBox.Location = New System.Drawing.Point(12, 133)
        Me.authorBox.Name = "authorBox"
        Me.authorBox.Size = New System.Drawing.Size(286, 26)
        Me.authorBox.TabIndex = 6
        '
        'isbnBox
        '
        Me.isbnBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnBox.Location = New System.Drawing.Point(13, 195)
        Me.isbnBox.Name = "isbnBox"
        Me.isbnBox.Size = New System.Drawing.Size(285, 26)
        Me.isbnBox.TabIndex = 7
        '
        'addBookWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 287)
        Me.Controls.Add(Me.isbnBox)
        Me.Controls.Add(Me.authorBox)
        Me.Controls.Add(Me.titleBox)
        Me.Controls.Add(Me.isbnLabel)
        Me.Controls.Add(Me.authorLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.addBookButton)
        Me.Name = "addBookWindow"
        Me.Text = "addBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addBookButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents titleLabel As Label
    Friend WithEvents authorLabel As Label
    Friend WithEvents isbnLabel As Label
    Friend WithEvents titleBox As TextBox
    Friend WithEvents authorBox As TextBox
    Friend WithEvents isbnBox As TextBox
End Class
