Public Class checkInWindow
    'disable button until text is inputted
    Private Sub checkInWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkIn.Enabled = False
    End Sub
    'enable button
    Private Sub barcode_TextChanged(sender As Object, e As EventArgs) Handles barcode.TextChanged
        checkIn.Enabled = True
    End Sub
    'Close form when close
    Private Sub close_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    'move book when checked in
    Private Sub checkIn_Click(sender As Object, e As EventArgs) Handles checkIn.Click
        Dim value As Integer
        For x As Integer = 0 To mainWindow.notAvaliable.Items.Count - 1
            If mainWindow.notAvaliable.Items(x).getISBN() = barcode.Text Then
                mainWindow.currentAvaliable.Items.Add(mainWindow.notAvaliable.Items(x))
                value = x
            End If
        Next
        For Each item As ListViewItem In mainWindow.adminCheckOutList.Items
            If item.SubItems(1).Text = mainWindow.notAvaliable.Items(value).ToString Then
                item.Remove()
                mainWindow.notAvaliable.Items.Remove(mainWindow.notAvaliable.Items(value))
                barcode.Clear()
            End If
        Next
        If Not String.IsNullOrEmpty(barcode.Text) Then
            MsgBox("Book is already checked in or invalid barcode")
        End If
    End Sub
End Class