Public Class editBookWindow
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    'remove book if selected
    Private Sub removeBook_Click(sender As Object, e As EventArgs) Handles removeBook.Click
        Dim temp As Book = mainWindow.inventoryList.SelectedItem
        For x As Integer = 0 To mainWindow.currentAvaliable.Items.Count - 1
            If mainWindow.currentAvaliable.Items(x).ToString() = temp.ToString() Then
                mainWindow.currentAvaliable.SelectedItem = mainWindow.currentAvaliable.Items(x)
            End If
        Next
        mainWindow.inventoryList.Items.Remove(mainWindow.inventoryList.SelectedItem)
        mainWindow.currentAvaliable.Items.Remove(mainWindow.currentAvaliable.SelectedItem)
        mainWindow.inventoryList.ClearSelected()
        mainWindow.currentAvaliable.ClearSelected()
        Me.Close()
    End Sub
    'save the changes of the eddited book back into the data
    Private Sub saveChanges_Click(sender As Object, e As EventArgs) Handles saveChanges.Click
        Dim temp As Book = mainWindow.inventoryList.SelectedItem
        For x As Integer = 0 To mainWindow.currentAvaliable.Items.Count - 1
            If mainWindow.currentAvaliable.Items(x).ToString() = temp.ToString() Then
                mainWindow.currentAvaliable.SelectedItem = mainWindow.currentAvaliable.Items(x)
            End If
        Next
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
            mainWindow.inventoryList.Items.Insert(mainWindow.inventoryList.SelectedIndex + 1, temp)
            mainWindow.inventoryList.Items.Remove(mainWindow.inventoryList.SelectedItem)
            mainWindow.currentAvaliable.Items.Insert(mainWindow.currentAvaliable.SelectedIndex + 1, temp)
            mainWindow.currentAvaliable.Items.Remove(mainWindow.currentAvaliable.SelectedItem)
            mainWindow.inventoryList.ClearSelected()
            mainWindow.currentAvaliable.ClearSelected()
            Me.Close()
        End If
    End Sub
    'initialize data based on the selected index
    Private Sub editBookWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titleBox.Text = mainWindow.inventoryList.SelectedItem.getTitle()
        authorBox.Text = mainWindow.inventoryList.SelectedItem.getAuthor()
        isbnBox.Text = mainWindow.inventoryList.SelectedItem.getISBN()
    End Sub
End Class