﻿Public Class frmNewPatient
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SavePatientDataToDatabase()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Dim strAnswer As MsgBoxResult = MsgBox(" Are you sure you want to close this form? ", MsgBoxStyle.YesNo, "Confirm ")


        If strAnswer = MsgBoxResult.Yes Then
            Me.Close()
        Else

        End If


    End Sub


    Private Sub SavePatientDataToDatabase()

        'grab data from all textfields and send it to the database


        'send message saying it was a success or error

        'if error say what the error was and return to the form with the filled out info

        ' Else

        ' success message that the data was saved to the database successfully
    End Sub


End Class