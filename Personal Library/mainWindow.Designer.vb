<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainWindow
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.circulationPage = New System.Windows.Forms.TabPage()
        Me.currentlyAvailableLabel = New System.Windows.Forms.Label()
        Me.currentAvaliable = New System.Windows.Forms.ListBox()
        Me.adminPage = New System.Windows.Forms.TabPage()
        Me.editBook = New System.Windows.Forms.Button()
        Me.incorrectLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.userField = New System.Windows.Forms.TextBox()
        Me.passwordField = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.adminCheckedOutLabel = New System.Windows.Forms.Label()
        Me.adminCheckOutList = New System.Windows.Forms.ListBox()
        Me.removeBook = New System.Windows.Forms.Button()
        Me.addBook = New System.Windows.Forms.Button()
        Me.adminInventoryLabel = New System.Windows.Forms.Label()
        Me.inventoryList = New System.Windows.Forms.ListBox()
        Me.setUserPass = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.circulationPage.SuspendLayout()
        Me.adminPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.circulationPage)
        Me.TabControl1.Controls.Add(Me.adminPage)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1277, 814)
        Me.TabControl1.TabIndex = 0
        '
        'circulationPage
        '
        Me.circulationPage.Controls.Add(Me.currentlyAvailableLabel)
        Me.circulationPage.Controls.Add(Me.currentAvaliable)
        Me.circulationPage.Location = New System.Drawing.Point(4, 22)
        Me.circulationPage.Name = "circulationPage"
        Me.circulationPage.Padding = New System.Windows.Forms.Padding(3)
        Me.circulationPage.Size = New System.Drawing.Size(1269, 788)
        Me.circulationPage.TabIndex = 1
        Me.circulationPage.Text = "Circulation"
        Me.circulationPage.UseVisualStyleBackColor = True
        '
        'currentlyAvailableLabel
        '
        Me.currentlyAvailableLabel.AutoSize = True
        Me.currentlyAvailableLabel.Location = New System.Drawing.Point(161, 32)
        Me.currentlyAvailableLabel.Name = "currentlyAvailableLabel"
        Me.currentlyAvailableLabel.Size = New System.Drawing.Size(127, 13)
        Me.currentlyAvailableLabel.TabIndex = 1
        Me.currentlyAvailableLabel.Text = "Books Currently Available"
        '
        'currentAvaliable
        '
        Me.currentAvaliable.FormattingEnabled = True
        Me.currentAvaliable.Location = New System.Drawing.Point(64, 61)
        Me.currentAvaliable.Name = "currentAvaliable"
        Me.currentAvaliable.Size = New System.Drawing.Size(325, 719)
        Me.currentAvaliable.TabIndex = 0
        '
        'adminPage
        '
        Me.adminPage.Controls.Add(Me.editBook)
        Me.adminPage.Controls.Add(Me.incorrectLabel)
        Me.adminPage.Controls.Add(Me.passwordLabel)
        Me.adminPage.Controls.Add(Me.userLabel)
        Me.adminPage.Controls.Add(Me.userField)
        Me.adminPage.Controls.Add(Me.passwordField)
        Me.adminPage.Controls.Add(Me.loginButton)
        Me.adminPage.Controls.Add(Me.adminCheckedOutLabel)
        Me.adminPage.Controls.Add(Me.adminCheckOutList)
        Me.adminPage.Controls.Add(Me.removeBook)
        Me.adminPage.Controls.Add(Me.addBook)
        Me.adminPage.Controls.Add(Me.adminInventoryLabel)
        Me.adminPage.Controls.Add(Me.inventoryList)
        Me.adminPage.Controls.Add(Me.setUserPass)
        Me.adminPage.Location = New System.Drawing.Point(4, 22)
        Me.adminPage.Name = "adminPage"
        Me.adminPage.Size = New System.Drawing.Size(1269, 788)
        Me.adminPage.TabIndex = 2
        Me.adminPage.Text = "Admin"
        Me.adminPage.UseVisualStyleBackColor = True
        '
        'editBook
        '
        Me.editBook.Location = New System.Drawing.Point(196, 67)
        Me.editBook.Name = "editBook"
        Me.editBook.Size = New System.Drawing.Size(123, 23)
        Me.editBook.TabIndex = 14
        Me.editBook.Text = "Edit Book"
        Me.editBook.UseVisualStyleBackColor = True
        '
        'incorrectLabel
        '
        Me.incorrectLabel.AutoSize = True
        Me.incorrectLabel.Location = New System.Drawing.Point(438, 382)
        Me.incorrectLabel.Name = "incorrectLabel"
        Me.incorrectLabel.Size = New System.Drawing.Size(158, 13)
        Me.incorrectLabel.TabIndex = 13
        Me.incorrectLabel.Text = "Incorrect username or password"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(490, 293)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(56, 13)
        Me.passwordLabel.TabIndex = 12
        Me.passwordLabel.Text = "Password:"
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.Location = New System.Drawing.Point(490, 250)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(58, 13)
        Me.userLabel.TabIndex = 11
        Me.userLabel.Text = "Username:"
        '
        'userField
        '
        Me.userField.Location = New System.Drawing.Point(452, 266)
        Me.userField.Name = "userField"
        Me.userField.Size = New System.Drawing.Size(125, 20)
        Me.userField.TabIndex = 10
        '
        'passwordField
        '
        Me.passwordField.Location = New System.Drawing.Point(452, 312)
        Me.passwordField.Name = "passwordField"
        Me.passwordField.Size = New System.Drawing.Size(125, 20)
        Me.passwordField.TabIndex = 9
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(477, 347)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(75, 23)
        Me.loginButton.TabIndex = 8
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'adminCheckedOutLabel
        '
        Me.adminCheckedOutLabel.AutoSize = True
        Me.adminCheckedOutLabel.Location = New System.Drawing.Point(449, 13)
        Me.adminCheckedOutLabel.Name = "adminCheckedOutLabel"
        Me.adminCheckedOutLabel.Size = New System.Drawing.Size(114, 13)
        Me.adminCheckedOutLabel.TabIndex = 7
        Me.adminCheckedOutLabel.Text = "Currently Checked Out"
        '
        'adminCheckOutList
        '
        Me.adminCheckOutList.FormattingEnabled = True
        Me.adminCheckOutList.Location = New System.Drawing.Point(356, 38)
        Me.adminCheckOutList.Name = "adminCheckOutList"
        Me.adminCheckOutList.Size = New System.Drawing.Size(310, 524)
        Me.adminCheckOutList.TabIndex = 6
        '
        'removeBook
        '
        Me.removeBook.Location = New System.Drawing.Point(196, 96)
        Me.removeBook.Name = "removeBook"
        Me.removeBook.Size = New System.Drawing.Size(123, 23)
        Me.removeBook.TabIndex = 5
        Me.removeBook.Text = "Remove Book"
        Me.removeBook.UseVisualStyleBackColor = True
        '
        'addBook
        '
        Me.addBook.Location = New System.Drawing.Point(196, 38)
        Me.addBook.Name = "addBook"
        Me.addBook.Size = New System.Drawing.Size(123, 23)
        Me.addBook.TabIndex = 4
        Me.addBook.Text = "Add Book"
        Me.addBook.UseVisualStyleBackColor = True
        '
        'adminInventoryLabel
        '
        Me.adminInventoryLabel.AutoSize = True
        Me.adminInventoryLabel.Location = New System.Drawing.Point(63, 9)
        Me.adminInventoryLabel.Name = "adminInventoryLabel"
        Me.adminInventoryLabel.Size = New System.Drawing.Size(51, 13)
        Me.adminInventoryLabel.TabIndex = 3
        Me.adminInventoryLabel.Text = "Book List"
        '
        'inventoryList
        '
        Me.inventoryList.FormattingEnabled = True
        Me.inventoryList.Location = New System.Drawing.Point(18, 38)
        Me.inventoryList.Name = "inventoryList"
        Me.inventoryList.Size = New System.Drawing.Size(145, 524)
        Me.inventoryList.TabIndex = 2
        '
        'setUserPass
        '
        Me.setUserPass.Location = New System.Drawing.Point(1060, 4)
        Me.setUserPass.Name = "setUserPass"
        Me.setUserPass.Size = New System.Drawing.Size(179, 23)
        Me.setUserPass.TabIndex = 0
        Me.setUserPass.Text = "Reset Username and Password"
        Me.setUserPass.UseVisualStyleBackColor = True
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 811)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "mainWindow"
        Me.Text = "Moseley Classroom"
        Me.TabControl1.ResumeLayout(False)
        Me.circulationPage.ResumeLayout(False)
        Me.circulationPage.PerformLayout()
        Me.adminPage.ResumeLayout(False)
        Me.adminPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents circulationPage As TabPage
    Friend WithEvents adminPage As TabPage
    Friend WithEvents inventoryList As ListBox
    Friend WithEvents setUserPass As Button
    Friend WithEvents adminInventoryLabel As Label
    Friend WithEvents addBook As Button
    Friend WithEvents removeBook As Button
    Friend WithEvents adminCheckOutList As ListBox
    Friend WithEvents adminCheckedOutLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents userLabel As Label
    Friend WithEvents userField As TextBox
    Friend WithEvents passwordField As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents incorrectLabel As Label
    Friend WithEvents editBook As Button
    Friend WithEvents currentlyAvailableLabel As Label
    Friend WithEvents currentAvaliable As ListBox
End Class
