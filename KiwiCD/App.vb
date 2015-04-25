Imports System.Xml
Imports System.Windows.Forms.ListView

Public Class App

    Dim library As New Library()
    Dim listContents As New List(Of ListViewItem)
    Dim selectFormat As String
    Dim currentListing As Integer

    Private Const listingFormat As String = "Showing All {0}"
    Private Const defaultSelectTag As String = "Click an item to select it"

    Private Const GENRE As Integer = 0
    Private Const ARTIST As Integer = 1
    Private Const TITLE As Integer = 2

    Private Sub loadXML()
        Dim xml_doc As XmlDocument
        Dim xml_nodes As XmlNodeList

        xml_doc = New XmlDocument()
        xml_doc.Load("content.xml")
        xml_nodes = xml_doc.SelectNodes("/catalog/cd")

        Dim xnode As XmlNode
        Dim counter As Integer = 0
        For Each xnode In xml_nodes
            Dim title = xnode.ChildNodes.Item(0).InnerText
            Dim artist = xnode.ChildNodes.Item(1).InnerText
            Dim genre = xnode.ChildNodes.Item(2).InnerText

            Dim cd As New CDROM(counter, title, artist, genre, 10.0)

            Randomize()
            cd.SetCount(Int(98 * Rnd()) & " ")

            library.Add(cd)
            counter += 1
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadXML()
        Me.Size = New Size(800, 600)
    End Sub

    Private Sub showPane(p As Panel)
        For Each c As Control In Me.Controls
            If TypeOf c Is Panel Then
                c.Hide()
            End If
        Next
        p.Dock = DockStyle.Fill
        p.Show()
    End Sub

    Private Sub resetHeaders()
        listingBox.Columns.Clear()
        listingBox.Columns.Insert(0, "title", "Title", 200)
        listingBox.Columns.Insert(1, "artist", "Artist", 200)
        listingBox.Columns.Insert(2, "genre", "Genre", 200)
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        StatusStrip1.Hide()
        showPane(Welcome)



    End Sub

    Private Sub GuestButton_Click(sender As Object, e As EventArgs) Handles GuestButton.Click
        showPane(Main)
        StatusStrip1.Show()
    End Sub

    Private Sub ShowAlbumDetails(ByVal cd As CDROM)
        listingBox.Hide()
        Label3.Text = cd.GetTitle()
        artistLabel.Text = cd.GetArtist()
        genreLabel.Text = cd.GetGenre()
        stockLabel.Text = cd.GetCount()
        artworkBox.Image = cd.GetArtwork()
        showPane(Details)
    End Sub

    Private Sub ShowAlbums(ByVal listing As List(Of CDROM))
        listingBox.Items.Clear()
        listContents.Clear()
        resetHeaders()
        selectFormat = "View {0}"
        selectionButton.Tag = defaultSelectTag
        selectionButton.Enabled = False
        selectionButton.Refresh()
        For Each cd As CDROM In listing
            Dim item As New ListViewItem(cd.GetTitle())
            item.SubItems.Add(cd.GetArtist())
            item.SubItems.Add(cd.GetGenre())
            item.Tag = cd.GetKey()
            listingBox.Items.Add(item)
            listContents.Add(item)
        Next
        currentListing = TITLE
        showPane(Listings)
    End Sub

    Private Sub ShowCategory(ByVal category As Integer)
        listingBox.Items.Clear()
        listContents.Clear()
        resetHeaders()
        Dim listing As New List(Of String)
        Dim listingTitle As String = ""
        Select Case category
            Case GENRE
                listing = library.GetGenres()
                selectFormat = "View all {0} tracks"
                listingTitle = "Genres"
                listingBox.Columns.RemoveByKey("title")
                listingBox.Columns.RemoveByKey("artist")

            Case ARTIST
                listing = library.GetArtists()
                selectFormat = "View all albums by {0}"
                listingTitle = "Artists"
                listingBox.Columns.RemoveByKey("title")
                listingBox.Columns.RemoveByKey("genre")
        End Select

        listingLabel.Text = String.Format(listingFormat, listingTitle)

        For Each element As String In listing
            Dim item As New ListViewItem(element)
            listingBox.Items.Add(item)
            listContents.Add(item)
        Next

        currentListing = category
        showPane(Listings)
    End Sub

    Private Sub GenreButton_Click(sender As Object, e As EventArgs) Handles GenreButton.Click
        ShowCategory(GENRE)
    End Sub

    Private Sub listingBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listingBox.SelectedIndexChanged
        If listingBox.SelectedItems.Count > 0 Then
            selectionButton.Tag = String.Format(selectFormat, listingBox.SelectedItems(0).Text)
            selectionButton.Enabled = True
            selectionButton.Refresh()
        End If
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        If searchBox.Text.Trim().Length = 0 Then
            listingBox.Items.Clear()
            listingBox.Items.AddRange(listContents.ToArray())
        Else
            Dim relevanceList As New List(Of ListViewItem)
            For Each item As ListViewItem In listingBox.Items
                Dim keyword As String = searchBox.Text.ToLower().Trim()
                Dim title As String = item.Text.ToLower().Trim()
                Dim condition As Boolean = title.Contains(keyword)
                If (item.SubItems.Count > 1) Then
                    Dim artist = item.SubItems(0).Text.ToLower().Trim()
                    Dim genre = item.SubItems(1).Text.ToLower().Trim()
                    condition = title.Contains(keyword) Or artist.Contains(keyword) Or genre.Contains(keyword)
                End If
                If condition Then
                    relevanceList.Add(item)
                End If
            Next
            listingBox.Items.Clear()
            listingBox.Items.AddRange(relevanceList.ToArray())
        End If
    End Sub

    Private Sub selectionButton_Paint(sender As Object, e As PaintEventArgs) Handles selectionButton.Paint
        Dim btn As Button = CType(sender, Button)
        Dim brush As New SolidBrush(btn.ForeColor)
        Dim sf As New StringFormat() With
            { _
                .Alignment = StringAlignment.Center, _
                .LineAlignment = StringAlignment.Center _
            }

        selectionButton.Text = String.Empty
        e.Graphics.DrawString(selectionButton.Tag, btn.Font, brush, e.ClipRectangle, sf)
        brush.Dispose()
        sf.Dispose()
    End Sub

    Private Sub selectionButton_EnabledChanged(sender As Object, e As EventArgs) Handles selectionButton.EnabledChanged
        Dim btn = CType(sender, Button)
        If btn.Enabled Then
            btn.ForeColor = Color.White
        Else
            btn.ForeColor = Color.FromArgb(29, 129, 71)
        End If
    End Sub

    Private Sub ArtistButton_Click(sender As Object, e As EventArgs) Handles ArtistButton.Click
        ShowCategory(ARTIST)
    End Sub

    Private Sub selectionButton_Click(sender As Object, e As EventArgs) Handles selectionButton.Click
        If (listingBox.SelectedItems(0) IsNot Nothing) Then
            Dim newListing As New Library
            Dim selectedCD = False
            Select Case currentListing
                Case GENRE
                    newListing = library.GetByGenre(listingBox.SelectedItems(0).Text)
                Case ARTIST
                    newListing = library.GetByArtist(listingBox.SelectedItems(0).Text)
                Case TITLE
                    selectedCD = True
            End Select

            If Not selectedCD Then
                ShowAlbums(newListing.All())
            Else
                Dim key = listingBox.SelectedItems(0).Tag.ToString()
                Dim cd As CDROM = library.GetCD(key)
                ShowAlbumDetails(cd)
            End If
        End If
    End Sub

    Private Sub TitleButton_Click(sender As Object, e As EventArgs) Handles TitleButton.Click
        ShowAlbums(library.All())
    End Sub
End Class
