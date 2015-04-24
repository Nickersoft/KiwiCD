Imports System.Xml
Public Class Form1

    Dim library As New Library()
    Dim listContents As New List(Of String)
    Dim selectFormat As String

    Private Const listingFormat As String = "Showing All {0}"

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

    Private Sub showGenres()
        listingBox.Items.Clear()
        listContents.Clear()
        For Each genre As String In library.GetGenres()
            listingBox.Items.Add(genre)
            listContents.Add(genre)
        Next
        selectFormat = "View all {0} tracks"
        listingLabel.Text = String.Format(listingFormat, "Genres")
        showPane(Listings)
    End Sub

    Private Sub GenreButton_Click(sender As Object, e As EventArgs) Handles GenreButton.Click
        showGenres()
    End Sub

    Private Sub listingBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        For Each lvi As ListViewItem In listingBox.SelectedItems
            lvi.Selected = False
        Next
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

    Private Sub listingBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles listingBox.SelectedIndexChanged
        If listingBox.SelectedItem IsNot Nothing Then
            selectionButton.Tag = String.Format(selectFormat, listingBox.SelectedItem.ToString().ToLower())
            selectionButton.Enabled = True
            selectionButton.Refresh()
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

    Private Sub listingBox_EnabledChanged(sender As Object, e As EventArgs) Handles listingBox.EnabledChanged
        If listingBox.Enabled Then

        End If
    End Sub
End Class
