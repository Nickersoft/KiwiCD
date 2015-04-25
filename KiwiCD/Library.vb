Public Class Library
    Dim contents As New List(Of CDROM)
    Dim genres, artists, titles As New List(Of String)

    Public Sub Add(ByVal cd As CDROM)
        contents.Add(cd)

        Dim genre = cd.getGenre()
        Dim artist = cd.getArtist()
        Dim title = cd.getTitle()

        If Not genres.Contains(genre) Then
            genres.Add(genre)
        End If

        If Not artists.Contains(artist) Then
            artists.Add(artist)
        End If

        If Not titles.Contains(title) Then
            titles.Add(title & " by " & artist)
        End If

    End Sub

    Public Sub Remove(ByVal index As Integer)
        If index > contents.Count - 1 Or index < 0 Then
            Throw New IndexOutOfRangeException
        Else
            contents.RemoveAt(index)
        End If
    End Sub

    Public Function All() As List(Of CDROM)
        Return contents
    End Function

    Public Function Count() As Integer
        Return contents.Count
    End Function

    Public Function GetByArtist(ByVal artist As String) As Library
        Dim artistList As New Library()
        For Each cd In contents
            If cd.getArtist().ToLower().Trim() = artist.ToLower().Trim() Then
                artistList.Add(cd)
            End If
        Next
        Return artistList
    End Function

    Public Function GetByGenre(ByVal genre As String) As Library
        Dim genreList As New Library()
        For Each cd In contents
            If cd.getGenre().ToLower().Trim() = genre.ToLower().Trim() Then
                genreList.Add(cd)
            End If
        Next
        Return genreList
    End Function

    Public Function GetGenres() As List(Of String)
        Return genres
    End Function

    Public Function GetArtists() As List(Of String)
        Return artists
    End Function

    Public Function GetTitles() As List(Of String)
        Return titles
    End Function
End Class
