Public Class frmAdHockDispense
    Private Sub frmAdHockDispense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'set ad efault quantity to the quantity textbox
        Dim intDefaultQuantity As Integer = 1
        txtQuantity.Text = intDefaultQuantity

        cmbMedications.Items.Clear()
        AdHoc.GetAllMedicationsForListbox()
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
End Class