<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkOutWindow
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
        Me.bookLabel = New System.Windows.Forms.Label()
        Me.bookTitle = New System.Windows.Forms.Label()
        Me.authorLabel = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.studentSearch = New System.Windows.Forms.TextBox()
        Me.lastnameSearchButton = New System.Windows.Forms.Button()
        Me.firstnameSearch = New System.Windows.Forms.Button()
        Me.checkOutButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.studentSearchResults = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'bookLabel
        '
        Me.bookLabel.AutoSize = True
        Me.bookLabel.Location = New System.Drawing.Point(141, 20)
        Me.bookLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bookLabel.Name = "bookLabel"
        Me.bookLabel.Size = New System.Drawing.Size(50, 20)
        Me.bookLabel.TabIndex = 0
        Me.bookLabel.Text = "Book:"
        '
        'bookTitle
        '
        Me.bookTitle.AutoSize = True
        Me.bookTitle.ForeColor = System.Drawing.Color.OrangeRed
        Me.bookTitle.Location = New System.Drawing.Point(127, 56)
        Me.bookTitle.Name = "bookTitle"
        Me.bookTitle.Size = New System.Drawing.Size(79, 20)
        Me.bookTitle.TabIndex = 1
        Me.bookTitle.Text = "Book Title"
        Me.bookTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'authorLabel
        '
        Me.authorLabel.AutoSize = True
        Me.authorLabel.Location = New System.Drawing.Point(137, 91)
        Me.authorLabel.Name = "authorLabel"
        Me.authorLabel.Size = New System.Drawing.Size(61, 20)
        Me.authorLabel.TabIndex = 2
        Me.authorLabel.Text = "Author:"
        '
        'author
        '
        Me.author.AutoSize = True
        Me.author.ForeColor = System.Drawing.Color.OrangeRed
        Me.author.Location = New System.Drawing.Point(137, 126)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(57, 20)
        Me.author.TabIndex = 3
        Me.author.Text = "Author"
        Me.author.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Check Out to"
        '
        'studentSearch
        '
        Me.studentSearch.Location = New System.Drawing.Point(69, 184)
        Me.studentSearch.Name = "studentSearch"
        Me.studentSearch.Size = New System.Drawing.Size(197, 26)
        Me.studentSearch.TabIndex = 5
        '
        'lastnameSearchButton
        '
        Me.lastnameSearchButton.Location = New System.Drawing.Point(69, 216)
        Me.lastnameSearchButton.Name = "lastnameSearchButton"
        Me.lastnameSearchButton.Size = New System.Drawing.Size(197, 31)
        Me.lastnameSearchButton.TabIndex = 6
        Me.lastnameSearchButton.Text = "Search by Lastname"
        Me.lastnameSearchButton.UseVisualStyleBackColor = True
        '
        'firstnameSearch
        '
        Me.firstnameSearch.Location = New System.Drawing.Point(69, 253)
        Me.firstnameSearch.Name = "firstnameSearch"
        Me.firstnameSearch.Size = New System.Drawing.Size(197, 26)
        Me.firstnameSearch.TabIndex = 7
        Me.firstnameSearch.Text = "Search by Firstname"
        Me.firstnameSearch.UseVisualStyleBackColor = True
        '
        'checkOutButton
        '
        Me.checkOutButton.Location = New System.Drawing.Point(12, 382)
        Me.checkOutButton.Name = "checkOutButton"
        Me.checkOutButton.Size = New System.Drawing.Size(104, 33)
        Me.checkOutButton.TabIndex = 8
        Me.checkOutButton.Text = "Check Out"
        Me.checkOutButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(267, 382)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 33)
        Me.cancelButton.TabIndex = 9
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Search Students"
        '
        'studentSearchResults
        '
        Me.studentSearchResults.FormattingEnabled = True
        Me.studentSearchResults.Location = New System.Drawing.Point(69, 318)
        Me.studentSearchResults.Name = "studentSearchResults"
        Me.studentSearchResults.Size = New System.Drawing.Size(197, 28)
        Me.studentSearchResults.TabIndex = 11
        '
        'checkOutWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 427)
        Me.Controls.Add(Me.studentSearchResults)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.checkOutButton)
        Me.Controls.Add(Me.firstnameSearch)
        Me.Controls.Add(Me.lastnameSearchButton)
        Me.Controls.Add(Me.studentSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.authorLabel)
        Me.Controls.Add(Me.bookTitle)
        Me.Controls.Add(Me.bookLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "checkOutWindow"
        Me.Text = "checkOutWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bookLabel As Label
    Friend WithEvents bookTitle As Label
    Friend WithEvents authorLabel As Label
    Friend WithEvents author As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents studentSearch As TextBox
    Friend WithEvents lastnameSearchButton As Button
    Friend WithEvents firstnameSearch As Button
    Friend WithEvents checkOutButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents studentSearchResults As ComboBox
End Class
