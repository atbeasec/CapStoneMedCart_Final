Public Class frmLoginScan
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblForgotID.Click
        MessageBox.Show("Please Enter your SVSU ID number into the textfield and Select Enter")
        btnLogin.Visible = True
        lblForgotID.Visible = False
        lblBadge.Visible = True

    End Sub

    Private Sub frmLoginScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnLogin.Visible = True
        lblBadge.Visible = False


    End Sub

    Private Sub lblBadge_Click(sender As Object, e As EventArgs) Handles lblBadge.Click
        lblBadge.Visible = False
        btnLogin.Visible = False
        lblForgotID.Visible = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Barcode As Integer = TextBox1.Text
        ScanLogIn(Barcode)
    End Sub
    Private Sub Only_Numbers_Barcode(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'stop the user from entering anything but numbers into the Text boxes
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar))) Then
            e.Handled = True
        End If
    End Sub
End Class