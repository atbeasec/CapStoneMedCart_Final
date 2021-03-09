Public Class frmPharmacy

    Dim currentContactPanel As String = Nothing

    Dim dsPhysicians As DataSet
    Dim dsPatients As DataSet

    Private Sub frmPharmacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPatientName.Items.Clear()
        cmbOrderedBy.Items.Clear()
        txtQuantity.Text = 0

        dsPhysicians = ExecuteSelectQuery("Select * From Physician WHERE Active_Flag = '1' ORDER BY Physician_Last_Name, Physician_First_Name;")
        dsPatients = ExecuteSelectQuery("Select * From Patient WHERE Active_Flag = '1' ORDER BY Patient_Last_Name, Patient_First_Name;")

        For Each dr As DataRow In dsPatients.Tables(0).Rows
            cmbPatientName.Items.Add(dr(EnumList.Patient.LastName) & ", " & dr(EnumList.Patient.FristName) &
                                     "   ID: " & dr(EnumList.Patient.MRN_Number))
        Next

        For Each dr As DataRow In dsPhysicians.Tables(0).Rows
            cmbOrderedBy.Items.Add(dr(EnumList.Physician.LastName) & ", " & dr(EnumList.Physician.FirstName) &
                                    "   ID: " & dr(EnumList.Physician.Id))
        Next

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