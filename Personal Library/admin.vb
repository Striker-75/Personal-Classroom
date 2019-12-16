Public Class admin
    'strings to hold class data
    Private username As String
    Private password As String
    'constructor
    Public Sub New(ByVal user As String, ByVal pass As String)
        username = user
        password = pass
    End Sub
    'default constructor
    Public Sub New()
        username = "username"
        password = "password"
    End Sub
    'username setter
    Public Sub setUsername(ByVal user As String)
        username = user
    End Sub
    'password setter
    Public Sub setPassword(ByVal pass As String)
        password = pass
    End Sub
    'username getter
    Public Function getUsername() As String
        Return username
    End Function
    'password getter
    Public Function getPassword() As String
        Return password
    End Function
    'prints login credinetials
    Public Overrides Function ToString() As String
        Return String.Format("{0},{1}", username, password)
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
        Dim userPass As String()
        Dim readFile As System.IO.TextReader = New IO.StreamReader(fileName)
        line = readFile.ReadLine()
        If Not line Is Nothing Then
            userPass = line.Split(",")
            Me.setUsername(userPass(0))
            Me.setPassword(userPass(1))
        End If
        readFile.Close()
    End Sub
End Class
