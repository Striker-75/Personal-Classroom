Public Class Form1
    'create a new admin
    Friend teacher As New admin
    'list for keeping track of books, includes total inventory, avaliable books and checked out books
    Friend bookInventory As List(Of Book)
    Dim bookOut As List(Of Book)
    Dim bookIn As List(Of Book)

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
        removeBook.Visible = False
        removeBook.Enabled = False
        adminCheckedOutLabel.Visible = False
        adminCheckedOutLabel.Enabled = False
        adminCheckOutList.Visible = False
        adminCheckOutList.Enabled = False

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
            editBook.Enabled = True
            removeBook.Visible = True
            removeBook.Enabled = True
            adminCheckedOutLabel.Visible = True
            adminCheckedOutLabel.Enabled = True
            adminCheckOutList.Visible = True
            adminCheckOutList.Enabled = True

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
        userSet = New Form2
        userSet.Show()
    End Sub
    'What happens on form close
    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
        teacher.saveData("login.txt")
    End Sub
    'initilize data on start
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teacher.loadData("login.txt")
    End Sub
End Class
