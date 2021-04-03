﻿Public Class frmWitnessSignOff
    Public referringForm As Object

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.Validated
        Dim strHashedBarcode = ConvertBarcodePepperAndHash(TextBox2.Text)
        If ExecuteScalarQuery("SELECT COUNT(*) FROM User WHERE User_ID = '" & LoggedInID & "' AND Barcode = '" & strHashedBarcode & "'" & " AND Active_Flag = '1'") <> 0 Then
            ' add the allergy override
            referringForm.blnOverride = True
            referringForm.blnSignedOff = True
            ' clear the entry
            TextBox2.Clear()
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
        TextBox2.Clear()
        Me.Close()
    End Sub

End Class