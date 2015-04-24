Public Class CDROM
    Dim title, artist, genre As String

    Sub New(title As String, artist As String, genre As String)
        Me.title = title
        Me.artist = artist
        Me.genre = genre
    End Sub

    Public Function getGenre() As String
        Return genre
    End Function

    Public Function getArtist() As String
        Return artist
    End Function

    Public Function getTitle() As String
        Return title
    End Function

End Class
