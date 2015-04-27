Public Class Register

#Region "Methods"

    'Registers a user with the system 
    Private Sub Register()
        Dim cont As Boolean = True
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                If c.Text.Trim().Count = 0 Then
                    cont = False
                End If
            End If
        Next

        If passwordTextbox.Text() <> repasswordTextbox.Text() Then
            cont = False
        End If

        If cont Then
            My.Settings.username = usernameTextbox.Text().Trim()
            My.Settings.password = passwordTextbox.Text()
            Me.Close()
        Else
            MessageBox.Show("Please enter all fields and make sure your passwords match before continuing.", "Could Not Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#End Region

#Region "Event Listeners"

#Region "Register"

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Register()
    End Sub

    Private Sub Register_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                c.Text = c.Tag.ToString()
                c.ForeColor = Color.DarkGray
            End If
        Next
    End Sub

    Private Sub repasswordTextbox_KeyUp(sender As Object, e As KeyEventArgs) Handles usernameTextbox.KeyUp, repasswordTextbox.KeyUp, passwordTextbox.KeyUp
        If e.KeyCode = Keys.Enter Then
            Register()
        End If
    End Sub

#End Region

#Region "Custom"

#Region "Textbox Placeholders"

    Private Sub EnterTextbox(sender As Object, e As EventArgs) Handles usernameTextbox.Enter, repasswordTextbox.Enter, passwordTextbox.Enter
        Dim txt As TextBox = CType(sender, TextBox)
        If txt.ForeColor = Color.DarkGray Then
            txt.Clear()
            txt.ForeColor = Color.Black
            If txt.Tag.ToString().ToLower().Trim().Contains("password") Then
                txt.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    Private Sub LeaveTextbox(sender As Object, e As EventArgs) Handles usernameTextbox.Leave, repasswordTextbox.Leave, passwordTextbox.Leave
        Dim txt As TextBox = CType(sender, TextBox)
        If txt.Text.Trim().Count = 0 Then
            txt.Text = txt.Tag.ToString()
            txt.ForeColor = Color.DarkGray
            txt.UseSystemPasswordChar = False
        End If
    End Sub

#End Region

#End Region

#End Region

End Class