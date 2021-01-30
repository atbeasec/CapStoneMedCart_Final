Public Class frmDischarge
    Private Sub btnAdmit_Click(sender As Object, e As EventArgs) Handles btnAdmit.Click

        ' the admit combo box will show all patients in the database that are saved
        ' these patiens wil be added to the patient records tab/ section of th UI 
        ' and there status in the database will be changed



    End Sub

    Private Sub btnDischarge_Click(sender As Object, e As EventArgs) Handles btnDischarge.Click

        ' the discharge button will show all patients that are currently admitted in our system
        ' these patiens wil be added to the patient records tab/ section of th UI 
        ' and there status in the database will be changed
        ' any room assignments regarding these patients will be deleted and they will not be occupying a room anymore


    End Sub
End Class