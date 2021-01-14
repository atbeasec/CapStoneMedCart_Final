Public Class frmLoginScan
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblForgotID.Click
        MessageBox.Show("Please Enter your SVSU ID number into the textfield and Select Enter")
        btnLogin.Visible = True
        lblForgotID.Visible = False
        lblBadge.Visible = True

    End Sub

    Private Sub frmLoginScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnLogin.Visible = False
        lblBadge.Visible = False


    End Sub

    Private Sub lblBadge_Click(sender As Object, e As EventArgs) Handles lblBadge.Click
        lblBadge.Visible = False
        btnLogin.Visible = False
        lblForgotID.Visible = True
    End Sub
End Class