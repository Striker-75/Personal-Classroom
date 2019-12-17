Public Class addBookWindow
    'temp book to add to inventory list if add book is pressed
    Dim temp As New Book("title", "author", "isbn")
    'set values on load
    Private Sub addBookWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titleBox.Text = temp.getTitle()
        authorBox.Text = temp.getAuthor()
        isbnBox.Text = temp.getISBN()
    End Sub
    'makes sure that all fields are filled out and creates a book then adds it to the inventory list
    Private Sub addBookButton_Click(sender As Object, e As EventArgs) Handles addBookButton.Click
        If String.IsNullOrEmpty(titleBox.Text) Then
            MsgBox("Missing Title")
        ElseIf String.IsNullOrEmpty(authorBox.Text) Then
            MsgBox("Missing Author")
        ElseIf String.IsNullOrEmpty(isbnBox.Text) Then
            MsgBox("Missing ISBN")
        Else
            temp.setTitle(titleBox.Text)
            temp.setAuthor(authorBox.Text)
            temp.setISBN(isbnBox.Text)
            mainWindow.inventoryList.Items.Add(temp)
            mainWindow.currentAvaliable.Items.Add(temp)
            Me.Close()
        End If
    End Sub
    'clears out everything and closes the form
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

End Class