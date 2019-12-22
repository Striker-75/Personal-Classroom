Public Class mainWindow
    'create a new admin
    Friend teacher As New admin
    'Admin page functionality, hide everything until valid login
    Private Sub TabControl1_Selected(sender As Object, e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        setUserPass.Visible = False
        setUserPass.Enabled = False
        inventoryList.Visible = False
        inventoryList.Enabled = False
        adminInventoryLabel.Visible = False
        adminInventoryLabel.Enabled = False
        addBook.Visible = False
        addBook.Enabled = False
        editBook.Visible = False
        editBook.Enabled = False
        adminCheckedOutLabel.Visible = False
        adminCheckedOutLabel.Enabled = False
        adminCheckOutList.Visible = False
        adminCheckOutList.Enabled = False
        studentListLabel.Visible = False
        studentListLabel.Enabled = False
        studentList.Visible = False
        studentList.Enabled = False
        addStudent.Visible = False
        addStudent.Enabled = False
        editStudent.Visible = False
        editStudent.Enabled = False
        inventoryList.ClearSelected()

        loginButton.Visible = True
        loginButton.Enabled = True
        userLabel.Visible = True
        userLabel.Enabled = True
        passwordLabel.Visible = True
        passwordLabel.Enabled = True
        userField.Visible = True
        userField.Enabled = True
        passwordField.Visible = True
        passwordField.Enabled = True
        passwordField.UseSystemPasswordChar = True
        incorrectLabel.Visible = False
        incorrectLabel.Enabled = False
    End Sub
    'show all assets upon valid login
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If Equals(userField.Text, teacher.getUsername()) And Equals(passwordField.Text, teacher.getPassword()) Then
            setUserPass.Visible = True
            setUserPass.Enabled = True
            inventoryList.Visible = True
            inventoryList.Enabled = True
            adminInventoryLabel.Visible = True
            adminInventoryLabel.Enabled = True
            addBook.Visible = True
            addBook.Enabled = True
            editBook.Visible = True
            adminCheckedOutLabel.Visible = True
            adminCheckedOutLabel.Enabled = True
            adminCheckOutList.Visible = True
            adminCheckOutList.Enabled = True
            studentList.Visible = True
            studentList.Enabled = True
            addStudent.Visible = True
            addStudent.Enabled = True
            editStudent.Visible = True
            studentListLabel.Visible = True
            studentListLabel.Enabled = True

            loginButton.Visible = False
            loginButton.Enabled = False
            userLabel.Visible = False
            userLabel.Enabled = False
            passwordLabel.Visible = False
            passwordLabel.Enabled = False
            userField.Visible = False
            userField.Enabled = False
            passwordField.Visible = False
            passwordField.Enabled = False
            incorrectLabel.Visible = False
            incorrectLabel.Enabled = False

            userField.Text = ""
            passwordField.Text = ""
        Else
            incorrectLabel.Visible = True
            incorrectLabel.Enabled = True
            passwordField.Text = ""
        End If
    End Sub
    'open up set new username and password window
    Private Sub setUserPass_Click(sender As Object, e As EventArgs) Handles setUserPass.Click
        Dim userSet As Form
        userSet = New setUserPassWindow
        userSet.Show()
    End Sub
    'What happens on form close
    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
        'output login
        teacher.saveData("login.txt")
        'output inventory data
        Dim inventory As System.IO.FileStream = New IO.FileStream("inventory.txt", IO.FileMode.Create)
        Dim inventData() As Byte
        For Each invent As Book In inventoryList.Items
            inventData = System.Text.Encoding.ASCII.GetBytes(invent.outputData())
            inventory.Write(inventData, 0, inventData.Length)
            inventData = System.Text.Encoding.ASCII.GetBytes(Environment.NewLine)
            inventory.Write(inventData, 0, inventData.Length)
        Next
        inventory.Close()
        'output avaliability data
        Dim avaliable As System.IO.FileStream = New IO.FileStream("avaliable.txt", IO.FileMode.Create)
        Dim avaData() As Byte
        For Each ava As Book In currentAvaliable.Items
            avaData = System.Text.Encoding.ASCII.GetBytes(ava.outputData())
            avaliable.Write(avaData, 0, avaData.Length)
            avaData = System.Text.Encoding.ASCII.GetBytes(Environment.NewLine)
            avaliable.Write(avaData, 0, avaData.Length)
        Next
        avaliable.Close()
        'output student data
        Dim people As System.IO.FileStream = New IO.FileStream("students.txt", IO.FileMode.Create)
        Dim stuData() As Byte
        For Each stu As Student In studentList.Items
            stuData = System.Text.Encoding.ASCII.GetBytes(stu.outputData())
            people.Write(stuData, 0, stuData.Length)
            stuData = System.Text.Encoding.ASCII.GetBytes(Environment.NewLine)
            people.Write(stuData, 0, stuData.Length)
        Next
        people.Close()
        'output not avaliable data
        Dim out As System.IO.FileStream = New IO.FileStream("out.txt", IO.FileMode.Create)
        Dim nonAva() As Byte
        For Each boo As Book In notAvaliable.Items
            nonAva = System.Text.Encoding.ASCII.GetBytes(boo.outputData())
            out.Write(nonAva, 0, nonAva.Length)
            nonAva = System.Text.Encoding.ASCII.GetBytes(Environment.NewLine)
            out.Write(nonAva, 0, nonAva.Length)
        Next
        out.Close()
        'output admin list
        Dim admin As System.IO.FileStream = New IO.FileStream("adminList.txt", IO.FileMode.Create)
        Dim adminData() As Byte
        For Each item As ListViewItem In adminCheckOutList.Items
            adminData = System.Text.Encoding.ASCII.GetBytes(item.SubItems(0).Text)
            admin.Write(adminData, 0, adminData.Length)
            adminData = System.Text.Encoding.ASCII.GetBytes(":")
            admin.Write(adminData, 0, adminData.Length)
            adminData = System.Text.Encoding.ASCII.GetBytes(item.SubItems(1).Text)
            admin.Write(adminData, 0, adminData.Length)
            adminData = System.Text.Encoding.ASCII.GetBytes(Environment.NewLine)
            admin.Write(adminData, 0, adminData.Length)
        Next
        admin.Close()
    End Sub
    'initilize data on from data on start
    Private Sub mainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initilize checkedout list
        With adminCheckOutList
            .Columns.Add("Student").Width = 200
            .Columns.Add("Book").Width = 200
        End With
        adminCheckOutList.View = View.Details
        'disable checkout buttons
        searchCheckOut.Enabled = False
        barcodeCheckOut.Enabled = False

        'initilize login data
        teacher.loadData("login.txt")
        'read in inventory list
        Dim line As String
        Dim bookData As String()
        Dim inventory As System.IO.TextReader = New IO.StreamReader("inventory.txt")
        While True
            line = inventory.ReadLine()
            If Not line Is Nothing Then
                bookData = line.Split(",")
                inventoryList.Items.Add(New Book(bookData(0), bookData(1), bookData(2)))
            Else
                Exit While
            End If
        End While
        inventory.Close()
        'read in current avaliable books
        Dim avaliable As System.IO.TextReader = New IO.StreamReader("avaliable.txt")
        While True
            line = avaliable.ReadLine()
            If Not line Is Nothing Then
                bookData = line.Split(",")
                currentAvaliable.Items.Add(New Book(bookData(0), bookData(1), bookData(2)))
            Else
                Exit While
            End If
        End While
        avaliable.Close()
        'read in not avaliable data
        Dim nonAva As System.IO.TextReader = New IO.StreamReader("out.txt")
        While True
            line = nonAva.ReadLine()
            If Not line Is Nothing Then
                bookData = line.Split(",")
                notAvaliable.Items.Add(New Book(bookData(0), bookData(1), bookData(2)))
            Else
                Exit While
            End If
        End While
        nonAva.Close()
        'read in current students
        Dim studentData As String()
        Dim people As System.IO.TextReader = New IO.StreamReader("students.txt")
        While True
            line = people.ReadLine()
            If Not line Is Nothing Then
                studentData = line.Split(",")
                studentList.Items.Add(New Student(studentData(0), studentData(1), studentData(2)))
            Else
                Exit While
            End If
        End While
        people.Close()
        'read in admin list
        Dim listData As String()
        Dim checked As System.IO.TextReader = New IO.StreamReader("adminList.txt")
        While True
            line = checked.ReadLine()
            If Not line Is Nothing Then
                listData = line.Split(":")
                adminCheckOutList.Items.Add(New ListViewItem({listData(0), listData(1)}))
            Else
                Exit While
            End If
        End While
        checked.Close()
    End Sub

    'opens a window to add a book
    Private Sub addBook_Click(sender As Object, e As EventArgs) Handles addBook.Click
        Dim addBookOption As Form
        addBookOption = New addBookWindow
        addBookOption.Show()
    End Sub
    'whenever a book is selected
    Private Sub inventoryList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles inventoryList.SelectedIndexChanged
        editBook.Enabled = True
    End Sub
    'open window to edit book
    Private Sub editBook_Click(sender As Object, e As EventArgs) Handles editBook.Click
        Dim editWindow As Form
        editWindow = New editBookWindow
        editWindow.Show()
    End Sub
    'open window to add a student
    Private Sub addStudent_Click(sender As Object, e As EventArgs) Handles addStudent.Click
        Dim addStudent As Form
        addStudent = New addStudentWindow
        addStudent.Show()
    End Sub
    'whenever a student is selected
    Private Sub studentList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentList.SelectedIndexChanged
        editStudent.Enabled = True
    End Sub
    'opens up window to edit student
    Private Sub editStudent_Click(sender As Object, e As EventArgs) Handles editStudent.Click
        Dim editStudent As Form
        editStudent = New editStudentWindow
        editStudent.Show()
    End Sub
    'search the avaliable titles for title
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If String.IsNullOrEmpty(searchBox.Text) Then
            MsgBox("Must input a title")
        Else
            For x As Integer = 0 To currentAvaliable.Items.Count - 1
                If currentAvaliable.Items(x).getTitle().ToUpper = searchBox.Text.ToUpper Then
                    currentAvaliable.SelectedItem = currentAvaliable.Items(x)
                End If
            Next
        End If
        If Not currentAvaliable.SelectedIndex = -1 Then
            searchCheckOut.Enabled = True
        Else
            MsgBox("That book is unavaliable or doesn't exist")
        End If
    End Sub
    'when a barcode is inputted it is searched for in the avaliable books
    Private Sub barcodeSearch_Click(sender As Object, e As EventArgs) Handles barcodeSearch.Click
        If String.IsNullOrEmpty(barcodeBox.Text) Then
            MsgBox("Invalid Barcode")
        Else
            For x As Integer = 0 To currentAvaliable.Items.Count - 1
                If currentAvaliable.Items(x).getISBN() = barcodeBox.Text Then
                    currentAvaliable.SelectedItem = currentAvaliable.Items(x)
                End If
            Next
        End If
        If Not currentAvaliable.SelectedIndex = -1 Then
            barcodeCheckOut.Enabled = True
        Else
            MsgBox("That book is unavaliable or doesn't exist")
        End If
    End Sub
    'handles both check out buttons and launches checkout window
    Private Sub searchCheckOut_Click(sender As Object, e As EventArgs) Handles searchCheckOut.Click, barcodeCheckOut.Click
        Dim checkOut As Form
        checkOut = New checkOutWindow
        checkOut.Show()
    End Sub
    'clear selected when cliking somewhere that isnt edittable
    Private Sub circulationPage_Click(sender As Object, e As EventArgs) Handles circulationPage.Click
        currentAvaliable.ClearSelected()
        barcodeCheckOut.Enabled = False
        barcodeBox.Clear()
        searchCheckOut.Enabled = False
        searchBox.Clear()
    End Sub
    'enable check out if a book is selected
    Private Sub currentAvaliable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles currentAvaliable.SelectedIndexChanged
        barcodeCheckOut.Enabled = True
        searchCheckOut.Enabled = True
    End Sub
    'launch check in book window
    Private Sub checkIn_Click(sender As Object, e As EventArgs) Handles checkIn.Click
        Dim checkIn As Form
        checkIn = New checkInWindow
        checkIn.Show()
    End Sub
    'cant select these items
    Private Sub notAvaliable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles notAvaliable.SelectedIndexChanged
        notAvaliable.ClearSelected()
    End Sub
    'clear selected
    Private Sub adminPage_Click(sender As Object, e As EventArgs) Handles adminPage.Click
        studentList.ClearSelected()
        inventoryList.ClearSelected()
        editBook.Enabled = False
        editStudent.Enabled = False
    End Sub
End Class
