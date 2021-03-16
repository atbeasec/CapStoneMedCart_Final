Public Class frmDischarge
    Private Sub btnAdmit_Click(sender As Object, e As EventArgs) Handles btnAdmit.Click
        CreateDatabase.ExecuteInsertQuery("Update Patient SET Active_Flag = 1 WHERE MRN_Number = " & CInt(cmbAdmitPatients.Text) & ";")
        Loadcmb()
        cmbAdmitPatients.Text = ""
        ' the admit combo box will show all patients in the database that are saved
        ' these patiens wil be added to the patient records tab/ section of th UI 
        ' and there status in the database will be changed



    End Sub

    Private Sub btnDischarge_Click(sender As Object, e As EventArgs) Handles btnDischarge.Click
        CreateDatabase.ExecuteInsertQuery("Update Patient SET Active_Flag = 0 WHERE MRN_Number = " & CInt(cmbDischargePatients.Text) & ";")
        Loadcmb()
        cmbDischargePatients.Text = ""
        ' the discharge button will show all patients that are currently admitted in our system
        ' these patiens wil be added to the patient records tab/ section of th UI 
        ' and there status in the database will be changed
        ' any room assignments regarding these patients will be deleted and they will not be occupying a room anymore


    End Sub

    Private Sub cmbAdmitPatients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAdmitPatients.SelectedIndexChanged

    End Sub

    Private Sub Loadcmb()
        Dim dsInactivePatients = CreateDatabase.ExecuteSelectQuery("Select MRN_Number From Patient WHERE Active_Flag = 0 ;")
        Dim dsactivePatients = CreateDatabase.ExecuteSelectQuery("Select MRN_Number From Patient WHERE Active_Flag = 1 ;")
        populateGenericComboBox(cmbAdmitPatients, dsInactivePatients)
        populateGenericComboBox(cmbDischargePatients, dsactivePatients)
    End Sub

    Private Sub frmDischarge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadcmb()
    End Sub
End Class