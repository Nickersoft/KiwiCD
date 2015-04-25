Imports System.Xml
Public Class App

    Dim library As New Library()
    Dim listContents As New List(Of String)
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
        Dim counter = 0
        For Each xnode In xml_nodes
            Dim title = xnode.ChildNodes.Item(0).InnerText
            Dim artist = xnode.ChildNodes.Item(1).InnerText
            Dim genre = xnode.ChildNodes.Item(2).InnerText

            Dim cd As New CDROM(title, artist, genre)
            library.Add(cd)
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

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        StatusStrip1.Hide()
        showPane(Welcome)
    End Sub

    Private Sub GuestButton_Click(sender As Object, e As EventArgs) Handles GuestButton.Click
        showPane(Main)
        StatusStrip1.Show()
    End Sub

    Private Sub ShowListing(ByVal category As Integer)
        listingBox.Items.Clear()
        listContents.Clear()

        Dim listing As New List(Of String)
        Dim listingTitle As String = ""
        Select Case category
            Case GENRE
                listing = library.GetGenres()
                selectFormat = "View all {0} tracks"
                listingTitle = "Genres"

            Case ARTIST
                listing = library.GetArtists()
                selectFormat = "View all tracks by {0}"
                listingTitle = "Artists"

            Case TITLE
                listing = library.GetTitles()
                selectFormat = "View {0}"
                listingTitle = "Titles"
        End Select

        listingLabel.Text = String.Format(listingFormat, listingTitle)

        For Each item As String In listing
            listingBox.Items.Add(item)
            listContents.Add(item)
        Next

        currentListing = category
        showPane(Listings)
    End Sub

    Private Sub GenreButton_Click(sender As Object, e As EventArgs) Handles GenreButton.Click
        ShowListing(GENRE)
    End Sub

    Private Sub listingBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listingBox.SelectedIndexChanged
        If listingBox.SelectedItem IsNot Nothing Then
            selectionButton.Tag = String.Format(selectFormat, listingBox.SelectedItem.ToString())
            selectionButton.Enabled = True
            selectionButton.Refresh()
        End If
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        If searchBox.Text.Trim().Length = 0 Then
            listingBox.Items.Clear()
            listingBox.Items.AddRange(listContents.ToArray())
        Else
            Dim relevanceList As New List(Of String)
            For Each item In listingBox.Items
                If (item.ToString().ToLower().Trim().Contains(searchBox.Text.ToLower().Trim())) Then
                    relevanceList.Add(item.ToString())
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
        ShowListing(ARTIST)
    End Sub

    Private Sub selectionButton_Click(sender As Object, e As EventArgs) Handles selectionButton.Click
        If (listingBox.SelectedItem IsNot Nothing) Then
            Dim newListing As New Library
            Select Case currentListing
                Case GENRE
                    newListing = library.GetByGenre(listingBox.SelectedItem.ToString())
                Case ARTIST
                    newListing = library.GetByArtist(listingBox.SelectedItem.ToString())
            End Select
            listingBox.Items.Clear()
            selectFormat = "View {0}"
            selectionButton.Tag = defaultSelectTag
            selectionButton.Enabled = False
            selectionButton.Refresh()
            For Each cd As CDROM In newListing.All()
                listingBox.Items.Add(cd.getTitle())
            Next
        End If
    End Sub

    Private Sub TitleButton_Click(sender As Object, e As EventArgs) Handles TitleButton.Click
        ShowListing(TITLE)
    End Sub
End Class
