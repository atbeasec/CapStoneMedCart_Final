Public Class frmPharmacy

    Dim currentContactPanel As String = Nothing

    Dim dsPhysicians As DataSet
    Dim dsPatients As DataSet

    Private Sub frmPharmacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtQuantity.Text = 0

        dsPhysicians = ExecuteSelectQuery("Select * From Physician WHERE Active_Flag = '1' ORDER BY Physician_Last_Name, Physician_First_Name;")
        dsPatients = ExecuteSelectQuery("Select * From Patient WHERE Active_Flag = '1' ORDER BY Patient_Last_Name, Patient_First_Name;")
        populatePhysicianComboBox(cmbOrderedBy, dsPhysicians)
        populatePatientNameComboBox(cmbPatientName, dsPatients)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnORder.Click
        Dim dtmOrderTime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")


    End Sub

    Private Sub btnIncrement_Click(sender As Object, e As EventArgs) Handles btnIncrement.Click
        ButtonIncrement(1000, txtQuantity)

    End Sub

    Private Sub btnDecrement_Click(sender As Object, e As EventArgs) Handles btnDecrement.Click
        ButtonDecrement(txtQuantity)
    End Sub

End Class