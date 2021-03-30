Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'set textbox text to string variable strUsername and strPassword
        Dim strUsername = txtUserName.Text
        Dim strPassword = txtPassword.Text
        If strUsername = "" Then
            MsgBox("            WARNING" & vbCrLf & "User Name Field is Blank")
            txtUserName.Focus()
        ElseIf strPassword = "" Then
            MsgBox("            WARNING" & vbCrLf & "Password Field is Blank")
            txtPassword.Focus()
            'send strUsername and strPassword to LogIn Module and recive responce
        ElseIf CheckSQL() <> "safe" Then
        ElseIf LogIn.UsernameLogIn(strUsername, strPassword) = "True" Then
            'If users Username and Password is in the User table in the database then close current form and open frmMain
            Me.Close()
            'call to set what sub form should be open
            frmMain.DetermineFormToOpen(2)
            'set the header for main to show who is logged in
            frmMain.Text = "Medical Dispence - " & LogIn.LoggedInFullName
            frmMain.Show()
            'make btnPatientRecords have focus
            frmMain.btnPatientRecords.PerformClick()
        Else
            'If users Username and Password is not in the User table then inform the user
            MsgBox("No User With That Username and Password")
        End If


    End Sub

    Private Sub lblBadge_Click(sender As Object, e As EventArgs) Handles lblBadge.Click
        'close current form and open frmLoginScan to login with username and password
        Me.Close()
        frmLoginScan.Show()
    End Sub

    Private Sub btnEye_Click(sender As Object, e As EventArgs) Handles btnEye.Click

        'If checked then password is visible as plain text
        If txtPassword.UseSystemPasswordChar = False Then

            txtPassword.UseSystemPasswordChar = True
            'If unchecked then password is visible as *
        Else
            txtPassword.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    '    If MessageBox.Show("Are you sure you want to close the application?",
    '                       "Medication Dispense",
    '                       MessageBoxButtons.YesNo) = DialogResult.No Then
    '        e.Cancel = True

    '    End If

    'End Sub
    Private Sub Password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        'if the user hits enter in txtPassword then try to log them in
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            'set textbox text to string variable strUsername and strPassword
            Dim strUsername = txtUserName.Text
            Dim strPassword = txtPassword.Text
            If strUsername = "" Then
                MsgBox("            WARNING" & vbCrLf & "Username Field is Blank")
                txtUserName.Focus()
            ElseIf strPassword = "" Then
                MsgBox("            WARNING" & vbCrLf & "Password Field is Blank")
                txtPassword.Focus()
                'send strUsername and strPassword to LogIn Module and recive responce
            ElseIf CheckSQL() <> "safe" Then
            ElseIf LogIn.UsernameLogIn(strUsername, strPassword) = "True" Then
                'If users Username and Password is in the User table in the database then close current form and open frmMain
                Me.Close()
                'call to set what sub form should be open
                frmMain.DetermineFormToOpen(2)
                'set the header for main to show who is logged in
                frmMain.Text = "Medical Dispense - " & LogIn.LoggedInFullName

                frmMain.Show()
                'make btnPatientRecords have focus
                frmMain.btnPatientRecords.PerformClick()
            Else
                'If users Username and Password is not in the User table then inform the user
                MsgBox("No User with that Username or Password")
            End If
        End If
    End Sub

    Private Sub Username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        'if the user hits enter in txtusername then set focus to txtPassword
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmLoginScan.setBlnFlagToClose(vbTrue)
        frmLoginScan.Visible = True
        Me.Close()
    End Sub

    Private Sub txtFirst_Last_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress, txtUserName.KeyPress
        KeyPressCheck(e, "abcdefghijklmnopqrstuvwxyz '-1234567890!@#$%^&*/.,<>=+")
    End Sub

    Public Function CheckSQL()
        Dim Answer As String
        If txtUserName.Text.Contains("""") Or txtUserName.Text.Contains("'") Or txtUserName.Text.Contains(" ") Or txtUserName.Text.Contains(";") Or txtUserName.Text.Contains("(") Or txtUserName.Text.Contains(")") Then
            MsgBox("No User with that Username or Password")
            Answer = "NotSafe"
            txtUserName.Focus()
        ElseIf txtPassword.Text.Contains("""") Or txtPassword.Text.Contains("'") Or txtPassword.Text.Contains(" ") Or txtPassword.Text.Contains(";") Or txtPassword.Text.Contains("(") Or txtPassword.Text.Contains(")") Then
            MsgBox("No User with that Username or Password")
            Answer = "NotSafe"
            txtPassword.Focus()
        Else
            Answer = "safe"
        End If
        Return Answer
    End Function
End Class