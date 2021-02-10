Public Class frmAdHockDispense
    Private Sub frmAdHockDispense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'set ad efault quantity to the quantity textbox
        Dim intDefaultQuantity As Integer = 1
        txtQuantity.Text = intDefaultQuantity

        cmbMedications.Items.Clear()
        AdHoc.GetAllMedicationsForListbox()
        AdHoc.PopulatePatientsAdhoc()
    End Sub

    Private Sub btnIncrementQuantity_Click(sender As Object, e As EventArgs) Handles btnIncrementQuantity.Click
        ButtonIncrement(txtQuantity)
    End Sub

    Private Sub btnDecrementQuantity_Click(sender As Object, e As EventArgs) Handles btnDecrementQuantity.Click
        ButtonDecrement(txtQuantity)
    End Sub

    Private Sub cmbMedications_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMedications.SelectedIndexChanged
        AdHoc.SetMedicationProperties()
    End Sub

    Private Sub cmbPatientName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatientName.SelectedIndexChanged
        AdHoc.PopulatePatientInformation()
    End Sub

    Private Sub btnDispense_Click(sender As Object, e As EventArgs) Handles btnDispense.Click
        AdHoc.InsertAdHoc(txtMRN.Text, "1", txtQuantity.Text)
    End Sub
End Class