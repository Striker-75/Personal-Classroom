Public Class addStudentWindow
    'temp student to add to student list if confirmed is pressed
    Dim temp As New Student("firstname", "lastname", "0")
    'set values on load
    Private Sub addStudentWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firstBox.Text = temp.getFirstName()
        lastBox.Text = temp.getLastName()
    End Sub
    'makes sure that all fields are filled out and creates a student then adds it to the student list
    Private Sub confrimStudent_Click(sender As Object, e As EventArgs) Handles confirmStudent.Click
        If String.IsNullOrEmpty(firstBox.Text) Then
            MsgBox("Missing Firstname")
        ElseIf String.IsNullOrEmpty(lastBox.Text) Then
            MsgBox("Missing Lastname")
        ElseIf String.IsNullOrEmpty(hourBox.Text) Then
            MsgBox("Missing Hour")
        Else
            temp.setFirstName(firstBox.Text)
            temp.setLastName(lastBox.Text)
            temp.setHour(hourBox.Text)
            mainWindow.studentList.Items.Add(temp)
            Me.Close()
        End If
    End Sub
    'clears out everything and closes the form
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub
End Class