<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.usernameTextbox = New System.Windows.Forms.TextBox()
        Me.passwordTextbox = New System.Windows.Forms.TextBox()
        Me.repasswordTextbox = New System.Windows.Forms.TextBox()
        Me.listingLabel = New System.Windows.Forms.Label()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'usernameTextbox
        '
        Me.usernameTextbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.usernameTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextbox.Location = New System.Drawing.Point(12, 60)
        Me.usernameTextbox.Name = "usernameTextbox"
        Me.usernameTextbox.Size = New System.Drawing.Size(284, 29)
        Me.usernameTextbox.TabIndex = 8
        Me.usernameTextbox.Tag = "Username"
        '
        'passwordTextbox
        '
        Me.passwordTextbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.passwordTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextbox.Location = New System.Drawing.Point(12, 95)
        Me.passwordTextbox.Name = "passwordTextbox"
        Me.passwordTextbox.Size = New System.Drawing.Size(284, 29)
        Me.passwordTextbox.TabIndex = 9
        Me.passwordTextbox.Tag = "Password"
        '
        'repasswordTextbox
        '
        Me.repasswordTextbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.repasswordTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repasswordTextbox.Location = New System.Drawing.Point(12, 130)
        Me.repasswordTextbox.Name = "repasswordTextbox"
        Me.repasswordTextbox.Size = New System.Drawing.Size(284, 29)
        Me.repasswordTextbox.TabIndex = 10
        Me.repasswordTextbox.Tag = "Retype Password"
        '
        'listingLabel
        '
        Me.listingLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listingLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.listingLabel.Location = New System.Drawing.Point(12, 9)
        Me.listingLabel.Name = "listingLabel"
        Me.listingLabel.Size = New System.Drawing.Size(284, 37)
        Me.listingLabel.TabIndex = 11
        Me.listingLabel.Text = "Create An Account"
        Me.listingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegisterButton
        '
        Me.RegisterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.ForeColor = System.Drawing.Color.White
        Me.RegisterButton.Location = New System.Drawing.Point(95, 175)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(121, 34)
        Me.RegisterButton.TabIndex = 0
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(308, 227)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.listingLabel)
        Me.Controls.Add(Me.repasswordTextbox)
        Me.Controls.Add(Me.passwordTextbox)
        Me.Controls.Add(Me.usernameTextbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usernameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents passwordTextbox As System.Windows.Forms.TextBox
    Friend WithEvents repasswordTextbox As System.Windows.Forms.TextBox
    Friend WithEvents listingLabel As System.Windows.Forms.Label
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
End Class
