Public Class frmDischarge

    Dim intDischargePatientID As New ArrayList
    Dim intAdmitPatientID As New ArrayList
    Private Sub btnAdmit_Click(sender As Object, e As EventArgs) Handles btnAdmit.Click
        Dim intPatientID As Integer = intAdmitPatientID(cmbAdmitPatients.SelectedIndex)
        CreateDatabase.ExecuteInsertQuery("Update Patient SET Active_Flag = 1 WHERE Patient_ID = '" & intPatientID & "'")
        Loadcmb()
        clearPatientTextBoxes()

    End Sub

    Private Sub btnDischarge_Click(sender As Object, e As EventArgs) Handles btnDischarge.Click
        If Not cmbDischargePatients.SelectedIndex = -1 Then
            Dim intPatientID As Integer = intDischargePatientID(cmbDischargePatients.SelectedIndex)
            CreateDatabase.ExecuteInsertQuery("Update Patient SET Active_Flag = 0 WHERE Patient_ID = '" & intPatientID & "'")
            Loadcmb()
            clearPatientTextBoxes()
        Else
            MessageBox.Show("Please select a patient to discharge")
        End If

    End Sub

    Private Sub Loadcmb()
        intDischargePatientID.Clear()
        intAdmitPatientID.Clear()
        cmbAdmitPatients.Items.Clear()
        cmbDischargePatients.Items.Clear()
        Dim dsInactivePatients As DataSet = CreateDatabase.ExecuteSelectQuery("Select * From Patient WHERE Active_Flag = 0 ;")

        For Each dr As DataRow In dsInactivePatients.Tables(0).Rows
            cmbAdmitPatients.Items.Add(dr(EnumList.Patient.LastName) & ", " & dr(EnumList.Patient.FristName) & "   MRN: " & dr(EnumList.Patient.MRN_Number))
            intAdmitPatientID.Add(dr(EnumList.Patient.ID))
        Next

        Dim dsactivePatients As DataSet = CreateDatabase.ExecuteSelectQuery("Select * From Patient WHERE Active_Flag = 1 ;")
        For Each dr As DataRow In dsactivePatients.Tables(0).Rows
            cmbDischargePatients.Items.Add(dr(EnumList.Patient.LastName) & ", " & dr(EnumList.Patient.FristName) & "   MRN: " & dr(EnumList.Patient.MRN_Number))
            intDischargePatientID.Add(dr(EnumList.Patient.ID))
        Next
    End Sub

    Private Sub frmDischarge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadcmb()
    End Sub

    Private Sub radAdmitPatient_CheckedChanged(sender As Object, e As EventArgs) Handles radAdmitPatient.CheckedChanged, radDischarge.CheckedChanged
        pnlAdmit.Visible = False
        pnlDischarge.Visible = False
        pnlInformation.Visible = False

        If radAdmitPatient.Checked = True Then
            pnlAdmit.Visible = True
            pnlDischarge.Visible = False
            pnlInformation.Visible = True
            cmbAdmitPatients.SelectedIndex = -1
            cmbDischargePatients.SelectedIndex = -1
            clearPatientTextBoxes()
        ElseIf radDischarge.Checked = True Then
            pnlAdmit.Visible = False
            pnlDischarge.Visible = True
            pnlInformation.Visible = True
            cmbAdmitPatients.SelectedIndex = -1
            cmbDischargePatients.SelectedIndex = -1
            clearPatientTextBoxes()
        End If
    End Sub

    Private Sub cmbAdmitPatients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAdmitPatients.SelectedIndexChanged
        If Not cmbAdmitPatients.SelectedIndex = -1 Then
            clearPatientTextBoxes()
            Dim intPatientID As Integer = intAdmitPatientID(cmbAdmitPatients.SelectedIndex)
            Dim dsPatientAdmit As DataSet = CreateDatabase.ExecuteSelectQuery("Select * From Patient WHERE Patient_ID = '" & intPatientID & "'")
            Dim dsPrimaryDoctor As DataSet = CreateDatabase.ExecuteSelectQuery("Select * from Physician where Physician_ID = '" & dsPatientAdmit.Tables(0).Rows(0)(EnumList.Patient.PhysicianID) & "'")
            Dim strPrimaryDoctor As String = "Dr " & dsPrimaryDoctor.Tables(0).Rows(0)(EnumList.Physician.FirstName) & " " & dsPrimaryDoctor.Tables(0).Rows(0)(EnumList.Physician.LastName)

            For Each dr As DataRow In dsPatientAdmit.Tables(0).Rows
                populatePatientTextBoxes(dr(1), dr(6), dr(7), dr(8), dr(9), "N/A", "N/A", strPrimaryDoctor, dr(15), dr(10), dr(11), dr(12), dr(14), dr(13))
            Next
        End If
    End Sub

    Private Sub cmbDischargePatients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDischargePatients.SelectedIndexChanged
        If Not cmbDischargePatients.SelectedIndex = -1 Then
            clearPatientTextBoxes()
            Dim intPatientID As Integer = intDischargePatientID(cmbDischargePatients.SelectedIndex)
            Dim dsPatientDischarge As DataSet = CreateDatabase.ExecuteSelectQuery("Select * From Patient WHERE Patient_ID = '" & intPatientID & "'")
            Dim dsPrimaryDoctor As DataSet = CreateDatabase.ExecuteSelectQuery("Select * from Physician where Physician_ID = '" & dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.PhysicianID) & "'")
            Dim strPrimaryDoctor As String = "Dr " & dsPrimaryDoctor.Tables(0).Rows(0)(EnumList.Physician.FirstName) & " " & dsPrimaryDoctor.Tables(0).Rows(0)(EnumList.Physician.LastName)
            Dim dsPatientRoom As DataSet = CreateDatabase.ExecuteSelectQuery("SELECT * FROM PatientRoom where Patient_TUID = '" & intPatientID & "'")

            For Each dr As DataRow In dsPatientDischarge.Tables(0).Rows
                populatePatientTextBoxes(dr(1), dr(6), dr(7), dr(8), dr(9), dsPatientRoom.Tables(0).Rows(0)(1), dsPatientRoom.Tables(0).Rows(0)(2), strPrimaryDoctor, dr(15), dr(10), dr(11), dr(12), dr(14), dr(13))
            Next
        End If
    End Sub

    Private Sub clearPatientTextBoxes()
        txtMRN.Text = ""
        txtBirthday.Text = ""
        txtGender.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        txtPhysician.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtPhone.Text = ""
        txtZipCode.Text = ""
    End Sub

    Private Sub populatePatientTextBoxes(ByRef intMRN As String, ByRef strDOB As String, ByRef strGender As String, ByRef intHeight As Integer, ByRef intWeight As Integer, ByRef strRoom As String, ByRef strBed As String,
                                         ByRef strPhysician As String, ByRef strEmail As String, ByRef strAddress As String, ByRef strCity As String, ByRef strState As String, ByRef intPhone As String, ByRef intZip As Integer)
        txtMRN.Text = intMRN
        txtBirthday.Text = strDOB
        txtGender.Text = strGender
        txtHeight.Text = intHeight
        txtWeight.Text = intWeight
        txtPhysician.Text = strPhysician
        txtEmail.Text = strEmail
        txtAddress.Text = strAddress
        txtCity.Text = strCity
        txtState.Text = strState
        txtPhone.Text = intPhone
        txtZipCode.Text = intZip

    End Sub
End Class