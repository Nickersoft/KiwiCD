Imports System.IO
Imports System.Net

Public Class CDROM

    Dim title, artist, genre, count As String
    Dim price As Double
    Dim artwork As Image
    Dim key As Integer

    'Modified code from FreeVBCode
    'http://www.freevbcode.com/ShowCode.asp?ID=5360
    Private Function ImageFromURL(ByVal imageURL As String) As Image
        Dim memStrm As MemoryStream
        Dim wc As WebClient
        Dim url = imageURL.Trim()
        Dim returnImage As Image = Nothing
        Try
            If Not url.ToLower().StartsWith("http://") Then
                url = "http://" & url
            End If

            wc = New WebClient()
            memStrm = New MemoryStream(wc.DownloadData(url))
            returnImage = Image.FromStream(memStrm)
        Catch ex As Exception
            Console.Error.Write("Error reading artwork from URL")
        End Try

        Return returnImage
    End Function

    Sub New(ByVal key As Integer, ByVal title As String, ByVal artist As String, ByVal genre As String, ByVal price As Double)
        Me.title = title
        Me.artist = artist
        Me.genre = genre
        Me.key = key
        Me.price = price
        Me.artwork = My.Resources.cddvd_1196951_m
    End Sub

    Public Function GetPrice() As String
        Return price
    End Function

    Public Function GetGenre() As String
        Return genre
    End Function

    Public Function GetArtist() As String
        Return artist
    End Function

    Public Function GetTitle() As String
        Return title
    End Function

    Public Sub SetCount(ByVal count As Integer)
        Me.count = count
    End Sub

    Public Function GetKey() As Integer
        Return key
    End Function

    Public Function GetCount() As Integer
        Return count
    End Function

    Public Sub SetArtworkFromURL(ByVal url As String)
        Me.artwork = ImageFromURL(url)
    End Sub

    Public Function GetArtwork() As Image
        Return artwork
    End Function

End Class
