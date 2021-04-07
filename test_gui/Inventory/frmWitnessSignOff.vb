Public Class frmWitnessSignOff
    Public referringForm As Object

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        Dim strHashedBarcode = ConvertBarcodePepperAndHash(txtBarcode.Text)
        If ExecuteScalarQuery("SELECT COUNT(*) FROM User WHERE User_ID = '" & LoggedInID & "' AND Barcode = '" & strHashedBarcode & "'" & " AND Active_Flag = '1'") <> 0 Then
            ' add the allergy override
            referringForm.blnOverride = True
            referringForm.blnSignedOff = True
            ' clear the entry
            txtBarcode.Clear()
            Me.Close()
        Else
            MessageBox.Show("Error, barcode entered does not match logged in user. Please try again or cancel dispense.")
        End If

        ' after text validation then we can actually dispense the medication

        ' close this form and the dispense form at the same time

        ' the patient record gets updated here on the patient information page with the new dispense history


        ' dispensing medications methods from here where we open the drawers


    End Sub

    Private Sub pnlInteractions_Paint(sender As Object, e As PaintEventArgs) Handles pnlInteractions.Paint

        ' pannel is hidden unless these two conditions are true:

        '   1. the patient is alergic to the drug so we need to check the charts
        '   2. There is a drug interaction with a drug the patient is currently taking.


        '   regardless of warning we need to let a sign off happen


    End Sub

    Private Sub btnConfigureInventory_Click(sender As Object, e As EventArgs) Handles btnConfigureInventory.Click
        referringForm.blnSignedOff = False
        referringForm.blnOverride = False
        Me.Close()
    End Sub

    Private Sub TextBox2_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            TextBox2_TextChanged(sender, e)
        Else
            KeyPressCheck(e, "abcdefghijklmnopqrstuvwxyz-1234567890!@#$%^&*.,<>=+")
        End If
    End Sub

    Private Sub frmWitnessSignOff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlCredentials.Visible = False
    End Sub

    Private Sub lblBadge_Click_1(sender As Object, e As EventArgs) Handles lblBadge.Click
        If pnlBarcode.Visible = True Then
            pnlBarcode.Visible = False
            txtBarcode.Text = Nothing
            pnlCredentials.Visible = True
        End If

    End Sub

    Private Sub lblUseBarcode_Click(sender As Object, e As EventArgs) Handles lblUseBarcode.Click

        If pnlCredentials.Visible = True Then

            pnlCredentials.Visible = False
            txtUsername.Text = Nothing
            txtPassword.Text = Nothing
            pnlBarcode.Visible = True

        End If
    End Sub
End Class