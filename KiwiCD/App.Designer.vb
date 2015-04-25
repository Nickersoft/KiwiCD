<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Welcome = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GuestButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Main = New System.Windows.Forms.Panel()
        Me.TitleButton = New System.Windows.Forms.Button()
        Me.ArtistButton = New System.Windows.Forms.Button()
        Me.GenreButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Listings = New System.Windows.Forms.Panel()
        Me.selectionButton = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.listingBox = New System.Windows.Forms.ListBox()
        Me.listingLabel = New System.Windows.Forms.Label()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Welcome.SuspendLayout()
        Me.Main.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Listings.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Welcome
        '
        Me.Welcome.Controls.Add(Me.Label1)
        Me.Welcome.Controls.Add(Me.GuestButton)
        Me.Welcome.Controls.Add(Me.LoginButton)
        Me.Welcome.Controls.Add(Me.RegisterButton)
        Me.Welcome.Controls.Add(Me.TextBox4)
        Me.Welcome.Controls.Add(Me.TextBox3)
        Me.Welcome.Location = New System.Drawing.Point(12, 12)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(276, 219)
        Me.Welcome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(15, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 52)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GuestButton
        '
        Me.GuestButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GuestButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.GuestButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GuestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.GuestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuestButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestButton.ForeColor = System.Drawing.Color.White
        Me.GuestButton.Location = New System.Drawing.Point(15, 177)
        Me.GuestButton.Name = "GuestButton"
        Me.GuestButton.Size = New System.Drawing.Size(248, 34)
        Me.GuestButton.TabIndex = 4
        Me.GuestButton.Text = "Continue As Guest"
        Me.GuestButton.UseVisualStyleBackColor = False
        '
        'LoginButton
        '
        Me.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.Location = New System.Drawing.Point(142, 137)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(121, 34)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'RegisterButton
        '
        Me.RegisterButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RegisterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.ForeColor = System.Drawing.Color.White
        Me.RegisterButton.Location = New System.Drawing.Point(15, 137)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(121, 34)
        Me.RegisterButton.TabIndex = 2
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(15, 97)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(248, 29)
        Me.TextBox4.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(15, 62)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(248, 29)
        Me.TextBox3.TabIndex = 0
        '
        'Main
        '
        Me.Main.Controls.Add(Me.TitleButton)
        Me.Main.Controls.Add(Me.ArtistButton)
        Me.Main.Controls.Add(Me.GenreButton)
        Me.Main.Controls.Add(Me.Label2)
        Me.Main.Controls.Add(Me.PictureBox2)
        Me.Main.Location = New System.Drawing.Point(12, 237)
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(442, 251)
        Me.Main.TabIndex = 1
        '
        'TitleButton
        '
        Me.TitleButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TitleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.TitleButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TitleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.TitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TitleButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleButton.ForeColor = System.Drawing.Color.White
        Me.TitleButton.Location = New System.Drawing.Point(292, 188)
        Me.TitleButton.Name = "TitleButton"
        Me.TitleButton.Size = New System.Drawing.Size(121, 34)
        Me.TitleButton.TabIndex = 8
        Me.TitleButton.Text = "By Title"
        Me.TitleButton.UseVisualStyleBackColor = False
        '
        'ArtistButton
        '
        Me.ArtistButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ArtistButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ArtistButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ArtistButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ArtistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArtistButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtistButton.ForeColor = System.Drawing.Color.White
        Me.ArtistButton.Location = New System.Drawing.Point(165, 188)
        Me.ArtistButton.Name = "ArtistButton"
        Me.ArtistButton.Size = New System.Drawing.Size(121, 34)
        Me.ArtistButton.TabIndex = 7
        Me.ArtistButton.Text = "By Artist"
        Me.ArtistButton.UseVisualStyleBackColor = False
        '
        'GenreButton
        '
        Me.GenreButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GenreButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.GenreButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.GenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenreButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenreButton.ForeColor = System.Drawing.Color.White
        Me.GenreButton.Location = New System.Drawing.Point(38, 188)
        Me.GenreButton.Name = "GenreButton"
        Me.GenreButton.Size = New System.Drawing.Size(121, 34)
        Me.GenreButton.TabIndex = 6
        Me.GenreButton.Text = "By Genre"
        Me.GenreButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(38, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(375, 33)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "How would you like to browse?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.KiwiCD.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(38, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(375, 112)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 819)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1047, 46)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.ToolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(10, 3, 0, 2)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(157, 28)
        Me.ToolStripStatusLabel2.Text = "Welcome back, Guest"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(769, 28)
        Me.ToolStripStatusLabel3.Spring = True
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(10, 3, 10, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(91, 28)
        Me.ToolStripStatusLabel1.Text = "My Wishlist"
        '
        'Listings
        '
        Me.Listings.Controls.Add(Me.selectionButton)
        Me.Listings.Controls.Add(Me.searchBox)
        Me.Listings.Controls.Add(Me.listingBox)
        Me.Listings.Controls.Add(Me.listingLabel)
        Me.Listings.Location = New System.Drawing.Point(12, 494)
        Me.Listings.Name = "Listings"
        Me.Listings.Size = New System.Drawing.Size(548, 474)
        Me.Listings.TabIndex = 3
        '
        'selectionButton
        '
        Me.selectionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.selectionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.selectionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectionButton.Enabled = False
        Me.selectionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.selectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectionButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectionButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.selectionButton.Location = New System.Drawing.Point(14, 411)
        Me.selectionButton.Margin = New System.Windows.Forms.Padding(0)
        Me.selectionButton.Name = "selectionButton"
        Me.selectionButton.Size = New System.Drawing.Size(516, 34)
        Me.selectionButton.TabIndex = 6
        Me.selectionButton.Tag = "Click an item to select it"
        Me.selectionButton.Text = "Click an item to select it"
        Me.selectionButton.UseVisualStyleBackColor = False
        '
        'searchBox
        '
        Me.searchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.searchBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(14, 54)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(516, 29)
        Me.searchBox.TabIndex = 6
        '
        'listingBox
        '
        Me.listingBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listingBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listingBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.listingBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listingBox.FormattingEnabled = True
        Me.listingBox.ItemHeight = 21
        Me.listingBox.Location = New System.Drawing.Point(14, 89)
        Me.listingBox.Margin = New System.Windows.Forms.Padding(0)
        Me.listingBox.Name = "listingBox"
        Me.listingBox.ScrollAlwaysVisible = True
        Me.listingBox.Size = New System.Drawing.Size(516, 317)
        Me.listingBox.Sorted = True
        Me.listingBox.TabIndex = 10
        '
        'listingLabel
        '
        Me.listingLabel.AutoSize = True
        Me.listingLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listingLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.listingLabel.Location = New System.Drawing.Point(7, 6)
        Me.listingLabel.Name = "listingLabel"
        Me.listingLabel.Size = New System.Drawing.Size(224, 37)
        Me.listingLabel.TabIndex = 9
        Me.listingLabel.Text = "Showing All Artists"
        Me.listingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(460, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 476)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(432, 51)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "{CD Title}"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(10, 78)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(164, 164)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(197, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Artist:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(192, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Genre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(180, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "In Stock:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1047, 865)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Listings)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Main)
        Me.Controls.Add(Me.Welcome)
        Me.DoubleBuffered = True
        Me.Name = "App"
        Me.Text = "KiwiCD"
        Me.Welcome.ResumeLayout(False)
        Me.Welcome.PerformLayout()
        Me.Main.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Listings.ResumeLayout(False)
        Me.Listings.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Welcome As System.Windows.Forms.Panel
    Friend WithEvents GuestButton As System.Windows.Forms.Button
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Main As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TitleButton As System.Windows.Forms.Button
    Friend WithEvents ArtistButton As System.Windows.Forms.Button
    Friend WithEvents GenreButton As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Listings As System.Windows.Forms.Panel
    Friend WithEvents listingLabel As System.Windows.Forms.Label
    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController
    Friend WithEvents listingBox As System.Windows.Forms.ListBox
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
    Friend WithEvents selectionButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
