﻿Public Class frmPharmacy

    Dim currentContactPanel As String = Nothing

    Dim dsPhysicians As DataSet
    Dim dsPatients As DataSet
    Dim dsMedications As DataSet
    Dim intPatientID As New ArrayList
    Dim intPatientIDfromArray As Integer = 0

    Private Sub frmPharmacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPatientName.Items.Clear()
        cmbOrderedBy.Items.Clear()
        cmbMedication.Items.Clear()
        txtQuantity.Text = 1
        Dim intCounter As Integer = 0
        dsMedications = ExecuteSelectQuery("SELECT * From Medication Inner Join DrawerMedication ON DrawerMedication.Medication_TUID = Medication.Medication_ID WHERE DrawerMedication.Active_Flag = '1' ORDER BY Medication.Medication_ID")
        dsPhysicians = ExecuteSelectQuery("Select * From Physician WHERE Active_Flag = '1' ORDER BY Physician_Last_Name, Physician_First_Name;")
        dsPatients = ExecuteSelectQuery("Select * From Patient WHERE Active_Flag = '1' ORDER BY Patient_Last_Name, Patient_First_Name;")

        For Each dr As DataRow In dsPatients.Tables(0).Rows
            cmbPatientName.Items.Add(dr(EnumList.Patient.LastName) & ", " & dr(EnumList.Patient.FristName) &
                                     "   MRN: " & dr(EnumList.Patient.MRN_Number))
            intPatientID.Add(dr(EnumList.Patient.ID))
        Next

        For Each dr As DataRow In dsPhysicians.Tables(0).Rows
            cmbOrderedBy.Items.Add(dr(EnumList.Physician.LastName) & ", " & dr(EnumList.Physician.FirstName) &
                                    "   ID: " & dr(EnumList.Physician.Id))
        Next

        For Each dr As DataRow In dsMedications.Tables(0).Rows
            cmbMedication.Items.Add(dr(EnumList.Medication.Name) &
                                    "   ID: " & dr(EnumList.Medication.ID))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnORder.Click
        Dim dtmOrderTime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        'PharmacyOrder()

    End Sub

    Private Sub btnIncrement_Click(sender As Object, e As EventArgs) Handles btnIncrement.Click
        ButtonIncrement(1000, txtQuantity)

    End Sub

    Private Sub btnDecrement_Click(sender As Object, e As EventArgs) Handles btnDecrement.Click
        ButtonDecrement(txtQuantity)
    End Sub

    Private Sub cmbPatientName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatientName.SelectedIndexChanged
        intPatientIDfromArray = intPatientID(cmbPatientName.SelectedIndex)
        txtPatientDOB.Text = ExecuteScalarQuery("select Date_of_Birth from Patient where Patient_ID = '" & intPatientIDfromArray & "'")
    End Sub
End Class