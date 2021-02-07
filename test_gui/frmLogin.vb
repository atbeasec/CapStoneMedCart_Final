Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'set textbox text to string variable strUsername and strPassword
        Dim strUsername = txtUserName.Text
        Dim strPassword = txtPassword.Text
        'send strUsername and strPassword to LogIn Module and recive responce
        If LogIn.UsernameLogIn(strUsername, strPassword) = "True" Then
            'If users Username and Password is in the User table in the database then close current form and open frmMain
            Me.Close()
            frmMain.Show()
        Else
            'If users Username and Password is not in the User table then inform the user
            MsgBox("No User With That Username or Password")
        End If
    End Sub

    Private Sub lblBadge_Click(sender As Object, e As EventArgs) Handles lblBadge.Click
        'close current form and open frmLoginScan to login with username and password
        Me.Close()
        frmLoginScan.Show()
    End Sub



    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs)

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

End Class