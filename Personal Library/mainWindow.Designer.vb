<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.circulationPage = New System.Windows.Forms.TabPage()
        Me.barcodeCheckOut = New System.Windows.Forms.Button()
        Me.barcodeSearch = New System.Windows.Forms.Button()
        Me.barcodeBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchCheckOut = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.currentlyAvailableLabel = New System.Windows.Forms.Label()
        Me.currentAvaliable = New System.Windows.Forms.ListBox()
        Me.adminPage = New System.Windows.Forms.TabPage()
        Me.editStudent = New System.Windows.Forms.Button()
        Me.addStudent = New System.Windows.Forms.Button()
        Me.studentListLabel = New System.Windows.Forms.Label()
        Me.studentList = New System.Windows.Forms.ListBox()
        Me.adminCheckOutList = New System.Windows.Forms.ListView()
        Me.editBook = New System.Windows.Forms.Button()
        Me.incorrectLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.userField = New System.Windows.Forms.TextBox()
        Me.passwordField = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.adminCheckedOutLabel = New System.Windows.Forms.Label()
        Me.addBook = New System.Windows.Forms.Button()
        Me.adminInventoryLabel = New System.Windows.Forms.Label()
        Me.inventoryList = New System.Windows.Forms.ListBox()
        Me.setUserPass = New System.Windows.Forms.Button()
        Me.notAvaliable = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkIn = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.circulationPage.SuspendLayout()
        Me.adminPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.circulationPage)
        Me.TabControl1.Controls.Add(Me.adminPage)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1277, 814)
        Me.TabControl1.TabIndex = 0
        '
        'circulationPage
        '
        Me.circulationPage.Controls.Add(Me.checkIn)
        Me.circulationPage.Controls.Add(Me.Label3)
        Me.circulationPage.Controls.Add(Me.notAvaliable)
        Me.circulationPage.Controls.Add(Me.barcodeCheckOut)
        Me.circulationPage.Controls.Add(Me.barcodeSearch)
        Me.circulationPage.Controls.Add(Me.barcodeBox)
        Me.circulationPage.Controls.Add(Me.Label2)
        Me.circulationPage.Controls.Add(Me.Label1)
        Me.circulationPage.Controls.Add(Me.searchCheckOut)
        Me.circulationPage.Controls.Add(Me.searchButton)
        Me.circulationPage.Controls.Add(Me.searchBox)
        Me.circulationPage.Controls.Add(Me.currentlyAvailableLabel)
        Me.circulationPage.Controls.Add(Me.currentAvaliable)
        Me.circulationPage.Location = New System.Drawing.Point(4, 29)
        Me.circulationPage.Name = "circulationPage"
        Me.circulationPage.Padding = New System.Windows.Forms.Padding(3)
        Me.circulationPage.Size = New System.Drawing.Size(1269, 781)
        Me.circulationPage.TabIndex = 1
        Me.circulationPage.Text = "Circulation"
        Me.circulationPage.UseVisualStyleBackColor = True
        '
        'barcodeCheckOut
        '
        Me.barcodeCheckOut.Location = New System.Drawing.Point(668, 263)
        Me.barcodeCheckOut.Name = "barcodeCheckOut"
        Me.barcodeCheckOut.Size = New System.Drawing.Size(113, 29)
        Me.barcodeCheckOut.TabIndex = 9
        Me.barcodeCheckOut.Text = "Check Out"
        Me.barcodeCheckOut.UseVisualStyleBackColor = True
        '
        'barcodeSearch
        '
        Me.barcodeSearch.Location = New System.Drawing.Point(489, 263)
        Me.barcodeSearch.Name = "barcodeSearch"
        Me.barcodeSearch.Size = New System.Drawing.Size(111, 29)
        Me.barcodeSearch.TabIndex = 8
        Me.barcodeSearch.Text = "Search"
        Me.barcodeSearch.UseVisualStyleBackColor = True
        '
        'barcodeBox
        '
        Me.barcodeBox.Location = New System.Drawing.Point(489, 231)
        Me.barcodeBox.Name = "barcodeBox"
        Me.barcodeBox.Size = New System.Drawing.Size(292, 26)
        Me.barcodeBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(568, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Barcode Lookup"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(581, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search by Title"
        '
        'searchCheckOut
        '
        Me.searchCheckOut.Location = New System.Drawing.Point(668, 142)
        Me.searchCheckOut.Name = "searchCheckOut"
        Me.searchCheckOut.Size = New System.Drawing.Size(113, 31)
        Me.searchCheckOut.TabIndex = 4
        Me.searchCheckOut.Text = "Check Out"
        Me.searchCheckOut.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(489, 143)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(111, 30)
        Me.searchButton.TabIndex = 3
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchBox
        '
        Me.searchBox.Location = New System.Drawing.Point(489, 91)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(292, 26)
        Me.searchBox.TabIndex = 2
        '
        'currentlyAvailableLabel
        '
        Me.currentlyAvailableLabel.AutoSize = True
        Me.currentlyAvailableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentlyAvailableLabel.Location = New System.Drawing.Point(129, 22)
        Me.currentlyAvailableLabel.Name = "currentlyAvailableLabel"
        Me.currentlyAvailableLabel.Size = New System.Drawing.Size(188, 20)
        Me.currentlyAvailableLabel.TabIndex = 1
        Me.currentlyAvailableLabel.Text = "Books Currently Available"
        '
        'currentAvaliable
        '
        Me.currentAvaliable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentAvaliable.FormattingEnabled = True
        Me.currentAvaliable.ItemHeight = 20
        Me.currentAvaliable.Location = New System.Drawing.Point(64, 61)
        Me.currentAvaliable.Name = "currentAvaliable"
        Me.currentAvaliable.Size = New System.Drawing.Size(325, 704)
        Me.currentAvaliable.TabIndex = 0
        '
        'adminPage
        '
        Me.adminPage.Controls.Add(Me.editStudent)
        Me.adminPage.Controls.Add(Me.addStudent)
        Me.adminPage.Controls.Add(Me.studentListLabel)
        Me.adminPage.Controls.Add(Me.studentList)
        Me.adminPage.Controls.Add(Me.adminCheckOutList)
        Me.adminPage.Controls.Add(Me.editBook)
        Me.adminPage.Controls.Add(Me.incorrectLabel)
        Me.adminPage.Controls.Add(Me.passwordLabel)
        Me.adminPage.Controls.Add(Me.userLabel)
        Me.adminPage.Controls.Add(Me.userField)
        Me.adminPage.Controls.Add(Me.passwordField)
        Me.adminPage.Controls.Add(Me.loginButton)
        Me.adminPage.Controls.Add(Me.adminCheckedOutLabel)
        Me.adminPage.Controls.Add(Me.addBook)
        Me.adminPage.Controls.Add(Me.adminInventoryLabel)
        Me.adminPage.Controls.Add(Me.inventoryList)
        Me.adminPage.Controls.Add(Me.setUserPass)
        Me.adminPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminPage.Location = New System.Drawing.Point(4, 29)
        Me.adminPage.Name = "adminPage"
        Me.adminPage.Size = New System.Drawing.Size(1269, 781)
        Me.adminPage.TabIndex = 2
        Me.adminPage.Text = "Admin"
        Me.adminPage.UseVisualStyleBackColor = True
        '
        'editStudent
        '
        Me.editStudent.Location = New System.Drawing.Point(598, 83)
        Me.editStudent.Name = "editStudent"
        Me.editStudent.Size = New System.Drawing.Size(111, 28)
        Me.editStudent.TabIndex = 19
        Me.editStudent.Text = "Edit Student"
        Me.editStudent.UseVisualStyleBackColor = True
        '
        'addStudent
        '
        Me.addStudent.Location = New System.Drawing.Point(598, 38)
        Me.addStudent.Name = "addStudent"
        Me.addStudent.Size = New System.Drawing.Size(111, 33)
        Me.addStudent.TabIndex = 18
        Me.addStudent.Text = "Add Student"
        Me.addStudent.UseVisualStyleBackColor = True
        '
        'studentListLabel
        '
        Me.studentListLabel.AutoSize = True
        Me.studentListLabel.Location = New System.Drawing.Point(438, 13)
        Me.studentListLabel.Name = "studentListLabel"
        Me.studentListLabel.Size = New System.Drawing.Size(74, 20)
        Me.studentListLabel.TabIndex = 17
        Me.studentListLabel.Text = "Students"
        '
        'studentList
        '
        Me.studentList.FormattingEnabled = True
        Me.studentList.ItemHeight = 20
        Me.studentList.Location = New System.Drawing.Point(399, 38)
        Me.studentList.Name = "studentList"
        Me.studentList.Size = New System.Drawing.Size(161, 724)
        Me.studentList.TabIndex = 16
        '
        'adminCheckOutList
        '
        Me.adminCheckOutList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminCheckOutList.Location = New System.Drawing.Point(814, 65)
        Me.adminCheckOutList.Name = "adminCheckOutList"
        Me.adminCheckOutList.Size = New System.Drawing.Size(425, 697)
        Me.adminCheckOutList.TabIndex = 15
        Me.adminCheckOutList.UseCompatibleStateImageBehavior = False
        '
        'editBook
        '
        Me.editBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBook.Location = New System.Drawing.Point(196, 77)
        Me.editBook.Name = "editBook"
        Me.editBook.Size = New System.Drawing.Size(123, 34)
        Me.editBook.TabIndex = 14
        Me.editBook.Text = "Edit Book"
        Me.editBook.UseVisualStyleBackColor = True
        '
        'incorrectLabel
        '
        Me.incorrectLabel.AutoSize = True
        Me.incorrectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incorrectLabel.Location = New System.Drawing.Point(395, 382)
        Me.incorrectLabel.Name = "incorrectLabel"
        Me.incorrectLabel.Size = New System.Drawing.Size(237, 20)
        Me.incorrectLabel.TabIndex = 13
        Me.incorrectLabel.Text = "Incorrect username or password"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLabel.Location = New System.Drawing.Point(473, 289)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(82, 20)
        Me.passwordLabel.TabIndex = 12
        Me.passwordLabel.Text = "Password:"
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLabel.Location = New System.Drawing.Point(473, 232)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(87, 20)
        Me.userLabel.TabIndex = 11
        Me.userLabel.Text = "Username:"
        '
        'userField
        '
        Me.userField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userField.Location = New System.Drawing.Point(452, 255)
        Me.userField.Name = "userField"
        Me.userField.Size = New System.Drawing.Size(125, 26)
        Me.userField.TabIndex = 10
        '
        'passwordField
        '
        Me.passwordField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordField.Location = New System.Drawing.Point(452, 312)
        Me.passwordField.Name = "passwordField"
        Me.passwordField.Size = New System.Drawing.Size(125, 26)
        Me.passwordField.TabIndex = 9
        '
        'loginButton
        '
        Me.loginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.Location = New System.Drawing.Point(477, 347)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(75, 32)
        Me.loginButton.TabIndex = 8
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'adminCheckedOutLabel
        '
        Me.adminCheckedOutLabel.AutoSize = True
        Me.adminCheckedOutLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminCheckedOutLabel.Location = New System.Drawing.Point(837, 40)
        Me.adminCheckedOutLabel.Name = "adminCheckedOutLabel"
        Me.adminCheckedOutLabel.Size = New System.Drawing.Size(169, 20)
        Me.adminCheckedOutLabel.TabIndex = 7
        Me.adminCheckedOutLabel.Text = "Currently Checked Out"
        '
        'addBook
        '
        Me.addBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBook.Location = New System.Drawing.Point(196, 38)
        Me.addBook.Name = "addBook"
        Me.addBook.Size = New System.Drawing.Size(123, 33)
        Me.addBook.TabIndex = 4
        Me.addBook.Text = "Add Book"
        Me.addBook.UseVisualStyleBackColor = True
        '
        'adminInventoryLabel
        '
        Me.adminInventoryLabel.AutoSize = True
        Me.adminInventoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminInventoryLabel.Location = New System.Drawing.Point(50, 13)
        Me.adminInventoryLabel.Name = "adminInventoryLabel"
        Me.adminInventoryLabel.Size = New System.Drawing.Size(75, 20)
        Me.adminInventoryLabel.TabIndex = 3
        Me.adminInventoryLabel.Text = "Book List"
        '
        'inventoryList
        '
        Me.inventoryList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryList.FormattingEnabled = True
        Me.inventoryList.ItemHeight = 20
        Me.inventoryList.Location = New System.Drawing.Point(18, 38)
        Me.inventoryList.Name = "inventoryList"
        Me.inventoryList.Size = New System.Drawing.Size(145, 724)
        Me.inventoryList.TabIndex = 2
        '
        'setUserPass
        '
        Me.setUserPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setUserPass.Location = New System.Drawing.Point(974, 4)
        Me.setUserPass.Name = "setUserPass"
        Me.setUserPass.Size = New System.Drawing.Size(265, 29)
        Me.setUserPass.TabIndex = 0
        Me.setUserPass.Text = "Reset Username and Password"
        Me.setUserPass.UseVisualStyleBackColor = True
        '
        'notAvaliable
        '
        Me.notAvaliable.FormattingEnabled = True
        Me.notAvaliable.ItemHeight = 20
        Me.notAvaliable.Location = New System.Drawing.Point(883, 61)
        Me.notAvaliable.Name = "notAvaliable"
        Me.notAvaliable.Size = New System.Drawing.Size(325, 704)
        Me.notAvaliable.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(944, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Books That Are Not Avaliable"
        '
        'checkIn
        '
        Me.checkIn.Location = New System.Drawing.Point(489, 360)
        Me.checkIn.Name = "checkIn"
        Me.checkIn.Size = New System.Drawing.Size(292, 33)
        Me.checkIn.TabIndex = 12
        Me.checkIn.Text = "Check In Books"
        Me.checkIn.UseVisualStyleBackColor = True
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
    Friend WithEvents adminCheckOutList As ListView
    Friend WithEvents editStudent As Button
    Friend WithEvents addStudent As Button
    Friend WithEvents studentListLabel As Label
    Friend WithEvents studentList As ListBox
    Friend WithEvents searchButton As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents searchCheckOut As Button
    Friend WithEvents barcodeCheckOut As Button
    Friend WithEvents barcodeSearch As Button
    Friend WithEvents barcodeBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents notAvaliable As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents checkIn As Button
End Class
