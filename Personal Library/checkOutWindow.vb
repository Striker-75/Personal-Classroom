Public Class checkOutWindow
    'initilizes the book data
    Private Sub checkOutWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOutButton.Enabled = False
        bookTitle.Text = mainWindow.currentAvaliable.SelectedItem.getTitle()
        author.Text = mainWindow.currentAvaliable.SelectedItem.getAuthor()
    End Sub
    'searches the students by last name
    Private Sub lastnameSearchButton_Click(sender As Object, e As EventArgs) Handles lastnameSearchButton.Click
        If String.IsNullOrEmpty(studentSearch.Text) Then
            MsgBox("Must input a first or last name")
        Else
            For x As Integer = 0 To mainWindow.studentList.Items.Count - 1
                If mainWindow.studentList.Items(x).getLastName().ToUpper = studentSearch.Text.ToUpper Then
                    studentSearchResults.Items.Add(mainWindow.studentList.Items(x))
                End If
            Next
        End If
        If studentSearchResults.Items.Count = 0 Then
            MsgBox("That student dosen't exist")
        End If
    End Sub
    'enable checkout when a student is enabled
    Private Sub studentSearchResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentSearchResults.SelectedIndexChanged
        checkOutButton.Enabled = True
    End Sub
    'searches student by firstname
    Private Sub firstnameSearch_Click(sender As Object, e As EventArgs) Handles firstnameSearch.Click
        If String.IsNullOrEmpty(studentSearch.Text) Then
            MsgBox("Must input a first or last name")
        Else
            For x As Integer = 0 To mainWindow.studentList.Items.Count - 1
                If mainWindow.studentList.Items(x).getFirstName().ToUpper = studentSearch.Text.ToUpper Then
                    studentSearchResults.Items.Add(mainWindow.studentList.Items(x))
                End If
            Next
        End If
        If studentSearchResults.Items.Count = 0 Then
            MsgBox("That student dosen't exist")
        End If
    End Sub
    'closes form on cancel
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        mainWindow.currentAvaliable.ClearSelected()
        mainWindow.studentList.ClearSelected()
        mainWindow.searchBox.Clear()
        mainWindow.barcodeBox.Clear()
        mainWindow.searchCheckOut.Enabled = False
        mainWindow.barcodeCheckOut.Enabled = False
        Me.Close()
    End Sub
    'when the check out list is clicked, avaliable book gets removed and student and book get added to the check out list
    Private Sub checkOutButton_Click(sender As Object, e As EventArgs) Handles checkOutButton.Click
        Dim value As Integer = -1
        For x As Integer = 0 To mainWindow.studentList.Items.Count - 1
            If mainWindow.studentList.Items(x).getFirstName() = studentSearchResults.SelectedItem.getFirstName() And mainWindow.studentList.Items(x).getLastName() = studentSearchResults.SelectedItem.getLastName() Then
                value = x
            End If
        Next
        If Not value = -1 Then
            mainWindow.adminCheckOutList.Items.Add(New ListViewItem({mainWindow.studentList.Items(value).ToString(), mainWindow.currentAvaliable.SelectedItem.ToString()}))
            mainWindow.notAvaliable.Items.Add(mainWindow.currentAvaliable.SelectedItem)
            mainWindow.currentAvaliable.Items.Remove(mainWindow.currentAvaliable.SelectedItem)
        Else
            MsgBox("error checking out")
        End If
        mainWindow.currentAvaliable.ClearSelected()
        mainWindow.studentList.ClearSelected()
        mainWindow.searchBox.Clear()
        mainWindow.barcodeBox.Clear()
        mainWindow.searchCheckOut.Enabled = False
        mainWindow.barcodeCheckOut.Enabled = False
        Me.Close()
    End Sub
End Class