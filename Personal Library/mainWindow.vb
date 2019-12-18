﻿Public Class mainWindow
    'create a new admin
    Friend teacher As New admin
    'Admin page functionality, hide everything until valid login
    Private Sub TabControl1_Selected(sender As Object, e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        userField.Text = "a"
        passwordField.Text = "a"

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
            editStudent.Enabled = True

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
            avaliable.Write(stuData, 0, stuData.Length)
            stuData = System.Text.Encoding.ASCII.GetBytes(Environment.NewLine)
            avaliable.Write(stuData, 0, stuData.Length)
        Next
        people.Close()
    End Sub
    'initilize data on from data on start
    Private Sub mainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initilize checkedout list
        With adminCheckOutList
            .Columns.Add("Book")
            .Columns.Add("Student")
        End With
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
        'read in current students
        Dim studentData As String()
        Dim people As System.IO.TextReader = New IO.StreamReader("students.txt")
        While True
            line = people.ReadLine()
            If Not line Is Nothing Then
                studentData = line.Split(",")
                currentAvaliable.Items.Add(New Student(studentData(0), studentData(1), studentData(2)))
            Else
                Exit While
            End If
        End While
        people.Close()
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
End Class
