Public Class Book
    'Strings to hold book data
    Private name As String
    Private author As String
    Private isbn As String
    'constructor
    Public Sub New(ByVal name As String, ByVal author As String, ByVal isbn As String)
        Me.name = name
        Me.author = author
        Me.isbn = isbn
    End Sub
    'name setter
    Public Sub setName(ByVal name As String)
        Me.name = name
    End Sub
    'name getter
    Public Function getName() As String
        Return name
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
End Class
