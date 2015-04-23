Imports System.Xml
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim xml_doc As XmlDocument
        Dim xml_nodes As XmlNodeList

        xml_doc = New XmlDocument()
        xml_doc.Load("content.xml")
        xml_nodes = xml_doc.SelectNodes("/catalog/cd")

        Dim xnode As XmlNode
        Dim counter = 0
        For Each xnode In xml_nodes
            Console.Write("CD-ROM #" & counter & vbCrLf &
                          "----------" & vbCrLf)
            Dim title = xnode.ChildNodes.Item(0).InnerText
            Dim artist = xnode.ChildNodes.Item(1).InnerText
            Dim genre = xnode.ChildNodes.Item(2).InnerText

            Console.Write("Title: " & title & vbCrLf &
                          "Artist: " & artist & vbCrLf &
                          "Genre: " & genre & vbCrLf & vbCrLf)
            counter += 1
        Next

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
End Class
