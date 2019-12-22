Public Class editStudentWindow
    'closes window on cancel press
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    'remove student if selected
    Private Sub removeStudent_Click(sender As Object, e As EventArgs) Handles removeStudent.Click
        Dim temp As Student = mainWindow.studentList.SelectedItem
        mainWindow.studentList.Items.Remove(mainWindow.studentList.SelectedItem)
        mainWindow.studentList.ClearSelected()
        Me.Close()
    End Sub
    'save the changes of the eddited studnet back into the data
    Private Sub saveChanges_Click(sender As Object, e As EventArgs) Handles saveChanges.Click
        Dim temp As Student = mainWindow.studentList.SelectedItem
        If String.IsNullOrEmpty(firstBox.Text) Then
            MsgBox("Missing Fistname")
        ElseIf String.IsNullOrEmpty(lastBox.Text) Then
            MsgBox("Missing Lastname")
        ElseIf String.IsNullOrEmpty(hourBox.Text) Then
            MsgBox("Missing Hour")
        Else
            temp.setFirstName(firstBox.Text)
            temp.setLastName(lastBox.Text)
            temp.setHour(hourBox.Text)
            mainWindow.studentList.Items.Insert(mainWindow.studentList.SelectedIndex + 1, temp)
            mainWindow.studentList.Items.Remove(mainWindow.studentList.SelectedItem)
            mainWindow.studentList.ClearSelected()
            Me.Close()
        End If
    End Sub
    'initialize data based on the selected index
    Private Sub editBookWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firstBox.Text = mainWindow.studentList.SelectedItem.getFirstName()
        lastBox.Text = mainWindow.studentList.SelectedItem.getLastName()
        hourBox.Text = mainWindow.studentList.SelectedItem.getHour()
    End Sub
End Class