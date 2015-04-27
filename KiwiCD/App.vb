Imports System.Xml
Imports System.Windows.Forms.ListView

Public Class App

#Region "Variable Declarations"

#Region "Local"
    Dim library As New Library() 'The CD database
    Dim listContents As New List(Of ListViewItem) 'Content that is currently being listed
    Dim selectFormat As String 'The string format for the selection button in the listing view
    Dim currentListing As Integer 'The category currently being listed
    Dim activeCD As CDROM = Nothing 'The CD that is currently being viewed
    Dim backtrack As New List(Of Panel) 'Every panel the user has seen so far (used to traverse backwards through screens)
    Dim username As String = "Guest" 'The user's username. The default is the guest account.
    Dim wishlistContents As New Library 'The user's wishlist
#End Region

#Region "Constant"
    Private Const listingFormat As String = "Showing All {0}" 'Format for the title of the listing view
    Private Const defaultSelectTag As String = "Click an item to select it" 'Default text for a disable selection button
    Private Const addWishlistDefaultText As String = "Add to Wishlist" 'Default text for add to wishlist button
    Private Const removeWishlistDefaultText As String = "Remove from Wishlist" 'Default text for remove from wishlist button

    'Categories
    Private Const GENRE As Integer = 0
    Private Const ARTIST As Integer = 1
    Private Const TITLE As Integer = 2
#End Region

#End Region

#Region "Methods"

#Region "Generic"

    'Loads CD library from XML file
    Private Sub LoadXML()
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

#End Region

#Region "UI Controllers"

    'Logs the user in
    Private Sub Login(ByVal username As String, ByVal password As String)
        If username.Trim().Length = 0 OrElse password.Trim().Length = 0 Then
            MessageBox.Show("Please enter a username and password to continue.", "Enter Your Credentials", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If username.Trim().ToLower() = My.Settings.username.Trim().ToLower() AndAlso _
               password = My.Settings.password Then
                Me.username = My.Settings.username
                ShowPane(Main)
                TopBar.Visible = True
                BottomBar.Visible = True
                addWishlistButton.Visible = True
            Else
                MessageBox.Show("Incorrect username or password. Either try again, register for an account, or continue as a guest.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
    End Sub

    'Logs the user out
    Private Sub Logout()
        ShowPane(Welcome)
        TopBar.Visible = False
        BottomBar.Visible = False
        backtrack.Clear()
    End Sub

    'Makes a specific screen (panel) the primary screen in the window
    Private Sub ShowPane(p As Panel)
        welcomeLabel.Text = "Welcome back, " & username
        For Each c As Control In Me.contentPanel.Controls
            If TypeOf c Is Panel Then
                c.Visible = False
            End If
        Next
        p.Dock = DockStyle.Fill
        p.Visible = True
        backtrack.Add(p)
        If backtrack.Count <= 2 Then
            backButton.Enabled = False
        Else
            backButton.Enabled = True
        End If
    End Sub

    'Resets the headers in the listings browser (listingBox) to its default
    Private Sub ResetHeaders()
        listingBox.Columns.Clear()
        wishlistBox.Columns.Clear()

        listingBox.Columns.Insert(0, "title", "Title", 200)
        listingBox.Columns.Insert(1, "artist", "Artist", 200)
        listingBox.Columns.Insert(2, "genre", "Genre", 200)

        wishlistBox.Columns.Insert(0, "title", "Title", 200)
        wishlistBox.Columns.Insert(1, "artist", "Artist", 200)
        wishlistBox.Columns.Insert(2, "genre", "Genre", 200)
    End Sub

    'Show a list of genres or artists
    Private Sub ShowCategory(ByVal category As Integer)
        listingBox.Items.Clear()
        listContents.Clear()
        ResetHeaders()
        selectionButton.Tag = defaultSelectTag
        selectionButton.Enabled = False
        selectionButton.Refresh()
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
        ShowPane(Listings)
    End Sub

    'Show a list of all titles released under a given category
    Private Sub ShowAlbums(ByVal listing As List(Of CDROM))
        listingBox.Items.Clear()
        listContents.Clear()
        ResetHeaders()
        listingLabel.Text = String.Format(listingFormat, "Titles")
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
        If Listings.Visible = False Then
            ShowPane(Listings)
        End If
    End Sub

    'Show the details of a given CD-ROM
    Private Sub ShowAlbumDetails(ByVal cd As CDROM)
        Listings.Hide()
        titleLabel.Text = cd.GetTitle()
        artistLabel.Text = cd.GetArtist()
        genreLabel.Text = cd.GetGenre()
        stockLabel.Text = cd.GetCount()
        artworkBox.Image = cd.GetArtwork()
        buyButton.Text = "Buy for $" & cd.GetPrice()
        buyButton.Tag = cd.GetPrice()
        activeCD = cd
        ReloadWishlist()
        ShowPane(Details)
    End Sub

    'Reload the contents of the wishlist and set the wishlist button's text accordingly
    Private Sub ReloadWishlist()
        wishlistBox.Items.Clear()
        For Each cd As CDROM In wishlistContents.All()
            Dim item As New ListViewItem(cd.GetTitle())
            item.SubItems.Add(cd.GetArtist())
            item.SubItems.Add(cd.GetGenre())
            item.Tag = cd.GetKey()
            wishlistBox.Items.Add(item)
        Next

        If wishlistContents.All().Contains(activeCD) Then
            addWishlistButton.Text = removeWishlistDefaultText
        Else
            addWishlistButton.Text = addWishlistDefaultText
        End If
    End Sub

#End Region

#End Region

#Region "Event Listeners"

#Region "Window"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadXML()
        Me.Size = New Size(800, 600)
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        For Each p As Control In contentPanel.Controls
            If TypeOf p Is Panel Then
                For Each c As Control In p.Controls
                    If TypeOf c Is TextBox Then
                        c.Text = c.Tag.ToString()
                        c.ForeColor = Color.DarkGray
                    End If
                Next
            End If
        Next
        BottomBar.Hide()
        ShowPane(Welcome)
    End Sub
#End Region

#Region "TopBar"

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Logout()
    End Sub

    Private Sub backButton_ButtonClick(sender As Object, e As EventArgs) Handles backButton.ButtonClick
        If backtrack.Count > 2 Then
            Dim lastPanel As Panel = backtrack(backtrack.Count - 2)
            backtrack.RemoveRange(backtrack.Count - 2, 2)
            ShowPane(lastPanel)
        End If
    End Sub

#End Region

#Region "BottomBar"

    Private Sub wishlistButton_Click(sender As Object, e As EventArgs) Handles wishlistButton.Click
        ShowPane(Wishlist)
    End Sub

#End Region

#Region "Login Screen"

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim r As New Register()
        r.ShowDialog()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Login(usernameTextbox.Text, passwordTextbox.Text)
    End Sub

    Private Sub GuestButton_Click(sender As Object, e As EventArgs) Handles GuestButton.Click
        ShowPane(Main)
        BottomBar.Visible = False
        TopBar.Visible = True
        addWishlistButton.Visible = False
    End Sub

    Private Sub usernameTextbox_KeyUp(sender As Object, e As KeyEventArgs) Handles usernameTextbox.KeyUp, passwordTextbox.KeyUp
        If e.KeyCode = Keys.Enter Then
            Login(usernameTextbox.Text, passwordTextbox.Text)
        End If
    End Sub

#End Region

#Region "Welcome"

    Private Sub GenreButton_Click(sender As Object, e As EventArgs) Handles GenreButton.Click
        ShowCategory(GENRE)
    End Sub

    Private Sub ArtistButton_Click(sender As Object, e As EventArgs) Handles ArtistButton.Click
        ShowCategory(ARTIST)
    End Sub

    Private Sub TitleButton_Click(sender As Object, e As EventArgs) Handles TitleButton.Click
        ShowAlbums(library.All())
    End Sub

#End Region

#Region "Listing & Wishlist"

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        If searchBox.ForeColor = Color.Black Then
            If searchBox.Text.Trim().Length = 0 Then
                If listContents.Count > 0 Then
                    listingBox.Items.Clear()
                    listingBox.Items.AddRange(listContents.ToArray())
                End If
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
        End If
    End Sub

    Private Sub listingBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listingBox.SelectedIndexChanged
        If listingBox.SelectedItems.Count > 0 Then
            selectionButton.Tag = String.Format(selectFormat, listingBox.SelectedItems(0).Text)
            selectionButton.Enabled = True
        Else
            selectionButton.Tag = defaultSelectTag
            selectionButton.Enabled = False
        End If

        selectionButton.Refresh()
    End Sub

    Private Sub selectionButton_Click(sender As Object, e As EventArgs) Handles selectionButton.Click
        If listingBox.SelectedItems.Count > 0 Then
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

    Private Sub selectionButton_Paint(sender As Object, e As PaintEventArgs) Handles selectionButton.Paint, wishlistSelectionButton.Paint
        Dim btn As Button = CType(sender, Button)
        Dim brush As New SolidBrush(btn.ForeColor)
        Dim sf As New StringFormat() With
            { _
                .Alignment = StringAlignment.Center, _
                .LineAlignment = StringAlignment.Center _
            }

        selectionButton.Text = String.Empty
        wishlistSelectionButton.Text = String.Empty
        e.Graphics.DrawString(btn.Tag, btn.Font, brush, e.ClipRectangle, sf)
        brush.Dispose()
        sf.Dispose()
    End Sub

    Private Sub selectionButton_EnabledChanged(sender As Object, e As EventArgs) Handles selectionButton.EnabledChanged, wishlistSelectionButton.EnabledChanged
        Dim btn = CType(sender, Button)
        If btn.Enabled Then
            btn.ForeColor = Color.White
        Else
            btn.ForeColor = Color.FromArgb(29, 129, 71)
        End If
    End Sub

    Private Sub wishlistSelectionButton_Click(sender As Object, e As EventArgs) Handles wishlistSelectionButton.Click
        If wishlistBox.SelectedItems.Count > 0 Then
            ShowAlbumDetails(library.GetCD(wishlistBox.SelectedItems(0).Tag.ToString()))
        End If
    End Sub

    Private Sub wishlistBox_KeyDown(sender As Object, e As KeyEventArgs) Handles wishlistBox.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If wishlistBox.SelectedItems(0) IsNot Nothing Then
                wishlistContents.Remove(wishlistBox.SelectedItems(0).Tag.ToString())
                ReloadWishlist()
                If wishlistBox.Items.Count = 0 Then
                    wishlistSelectionButton.Tag = defaultSelectTag
                    wishlistSelectionButton.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub wishlistBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles wishlistBox.SelectedIndexChanged
        If wishlistBox.SelectedItems.Count > 0 Then
            wishlistSelectionButton.Tag = String.Format(selectFormat, listingBox.SelectedItems(0).Text)
            wishlistSelectionButton.Enabled = True
        Else
            wishlistSelectionButton.Tag = defaultSelectTag
            wishlistSelectionButton.Enabled = False
        End If
        wishlistSelectionButton.Refresh()
    End Sub

#End Region

#Region "Details"

    Private Sub buyButton_Click(sender As Object, e As EventArgs) Handles buyButton.Click
        Dim result As DialogResult
        result = MessageBox.Show(String.Format("Are you sure you would like to reserve {0} for purchase? ", titleLabel.Text), "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = vbYes Then
            MessageBox.Show(String.Format("You have just requested {0} for purchase. Your total will be ${1}." & vbCrLf & vbCrLf & "Please see the front desk to pay.", titleLabel.Text, buyButton.Tag.ToString()), "Purchase Confirmed", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If
    End Sub

    Private Sub addWishlistButton_Click(sender As Object, e As EventArgs) Handles addWishlistButton.Click
        If Me.activeCD IsNot Nothing Then
            If wishlistContents.All().Contains(activeCD) Then
                wishlistContents.Remove(activeCD.GetKey())
                ReloadWishlist()
            Else
                wishlistContents.Add(Me.activeCD)
                ReloadWishlist()
            End If
        End If

    End Sub

#End Region

#Region "Custom"

#Region "Textbox Placeholders"
    Private Sub EnterTextbox(sender As Object, e As EventArgs) Handles usernameTextbox.Enter, searchBox.Enter, passwordTextbox.Enter
        Dim txt As TextBox = CType(sender, TextBox)
        If txt.ForeColor = Color.DarkGray Then
            txt.ForeColor = Color.Black
            txt.Clear()
            If txt.Tag.ToString().ToLower().Trim().Contains("password") Then
                txt.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    Private Sub LeaveTextbox(sender As Object, e As EventArgs) Handles usernameTextbox.Leave, searchBox.Leave, passwordTextbox.Leave
        Dim txt As TextBox = CType(sender, TextBox)
        If txt.Text.Trim().Length = 0 Then
            txt.ForeColor = Color.DarkGray
            txt.Text = txt.Tag.ToString()
            txt.UseSystemPasswordChar = False
        End If
    End Sub
#End Region

#End Region

#End Region

End Class
