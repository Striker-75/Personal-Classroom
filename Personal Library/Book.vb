Public Class Book
    'Strings to hold book data
    Private title As String
    Private author As String
    Private isbn As String
    'constructor
    Public Sub New(ByVal title As String, ByVal author As String, ByVal isbn As String)
        Me.title = title
        Me.author = author
        Me.isbn = isbn
    End Sub
    'name setter
    Public Sub setTitle(ByVal title As String)
        Me.title = title
    End Sub
    'name getter
    Public Function getTitle() As String
        Return title
    End Function
    'author setter
    Public Sub setAuthor(ByVal author As String)
        Me.author = author
    End Sub
    'author getter
    Public Function getAuthor() As String
        Return author
    End Function
    'isbn setter
    Public Sub setISBN(ByVal isbn As String)
        Me.isbn = isbn
    End Sub
    'isbn getter
    Public Function getISBN() As String
        Return isbn
    End Function
    'used to print data to file
    Public Function outputData() As String
        Return String.Format("{0},{1},{2}", title, author, isbn)
    End Function
    'this is what is displayed in the listbox's
    Public Overrides Function ToString() As String
        Return String.Format("{0},{1}", title, author)
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
            Me.setTitle(bookData(0))
            Me.setAuthor(bookData(1))
            Me.setISBN(bookData(2))
        End If
        readFile.Close()
    End Sub
End Class
