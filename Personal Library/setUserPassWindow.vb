Public Class setUserPassWindow
    'Setting the new username and password as long as its they new passwords arent null and close form
    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        If String.IsNullOrEmpty(userBox.Text) Then
            MsgBox("Missing Username")
        ElseIf String.IsNullOrEmpty(passbox.Text) Then
            MsgBox("Missing Password")
        Else
            mainWindow.teacher.setUsername(userBox.Text)
            mainWindow.teacher.setPassword(passbox.Text)
            Me.Close()
        End If
    End Sub
    'Close form on cancel press
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub
    'load current username and password
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userBox.Text = mainWindow.teacher.getUsername()
        passbox.Text = mainWindow.teacher.getPassword()
    End Sub
End Class