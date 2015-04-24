Imports System.Xml
Public Class Form1
    Dim library As New Library()

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
        For Each genre As String In library.GetGenres()
            listingBox.Items.Add(genre)
        Next
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

End Class
