Public Class Student
    'Strings to hold student data
    Private firstname As String
    Private lastname As String
    Private hour As String
    'constructor
    Public Sub New(ByVal firstname As String, ByVal lastname As String, ByVal hour As String)
        Me.firstname = firstname
        Me.lastname = lastname
        Me.hour = hour
    End Sub
    'firstname setter
    Public Sub setFirstName(ByVal firstname As String)
        Me.firstname = firstname
    End Sub
    'firstname getter
    Public Function getFirstName() As String
        Return firstname
    End Function
    'lastname setter
    Public Sub setLastName(ByVal lastname As String)
        Me.lastname = lastname
    End Sub
    'lastname getter
    Public Function getLastName() As String
        Return lastname
    End Function
    'hour setter
    Public Sub setHour(ByVal hour As String)
        Me.hour = hour
    End Sub
    'hour getter
    Public Function getHour() As String
        Return hour
    End Function
    'used to print data to file
    Public Function outputData() As String
        Return String.Format("{0},{1},{2}", firstname, lastname, hour)
    End Function
    'this is what is displayed in the listbox's
    Public Overrides Function ToString() As String
        Return String.Format("{0},{1}", lastname, firstname)
    End Function
    'used to write out data
    Public Sub saveData(fileName As String)
        Dim wFile As System.IO.FileStream
        Dim byteData() As Byte
        byteData = System.Text.Encoding.ASCII.GetBytes(Me.ToString())
        wFile = New IO.FileStream(fileName, IO.FileMode.Create)
        wFile.Write(byteData, 0, byteData.Length)
        wFile.Close()
    End Sub
    'used to read in data
    Public Sub loadData(fileName As String)
        Dim line As String
        Dim bookData As String()
        Dim readFile As System.IO.TextReader = New IO.StreamReader(fileName)
        line = readFile.ReadLine()
        If Not line Is Nothing Then
            bookData = line.Split(",")
            Me.setFirstName(bookData(0))
            Me.setLastName(bookData(1))
            Me.setHour(bookData(2))
        End If
        readFile.Close()
    End Sub
End Class
