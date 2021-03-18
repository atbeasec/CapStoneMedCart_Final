Public Class frmDischarge

    Dim intDischargePatientID As New ArrayList
    Dim intAdmitPatientID As New ArrayList
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

    Private Sub Loadcmb()
        intDischargePatientID.Clear()
        intAdmitPatientID.Clear()
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


        End If
    End Sub

    Private Sub cmbDischargePatients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDischargePatients.SelectedIndexChanged
        If Not cmbDischargePatients.SelectedIndex = -1 Then
            clearPatientTextBoxes()
            Dim intPatientID As Integer = intDischargePatientID(cmbDischargePatients.SelectedIndex)
            Dim dsPatientDischarge As DataSet = CreateDatabase.ExecuteSelectQuery("Select * From Patient WHERE Patient_ID = '" & intPatientID & "'")
            populatePatientTextBoxes(dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.MRN_Number), dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.DoB), dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.Sex), dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.Height),
                                     dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.Weight), "", "", "", dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.Email), dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.address),
                                        dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.City), dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.state), dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.Phone), dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.zip))
        End If
    End Sub

    Private Sub clearPatientTextBoxes()
        txtMRN.Text = ""
        txtBirthday.Text = ""
        txtGender.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        txtroom.Text = ""
        txtBed.Text = ""
        txtPhysician.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        txtPhone.Text = ""
        txtZipCode.Text = ""
    End Sub

    Private Sub populatePatientTextBoxes(ByRef intMRN As Integer, ByRef strDOB As String, ByRef strGender As String, ByRef intHeight As Integer, ByRef intWeight As Integer, ByRef strRoom As String, ByRef strBed As String,
                                         ByRef strPhysician As String, ByRef strEmail As String, ByRef strAddress As String, ByRef strCity As String, ByRef strState As String, ByRef intPhone As Integer, ByRef intZip As Integer)
        txtMRN.Text = intMRN
        txtBirthday.Text = strDOB
        txtGender.Text = strGender
        txtHeight.Text = intHeight
        txtWeight.Text = intWeight
        txtroom.Text = strRoom
        txtBed.Text = strBed
        txtPhysician.Text = strPhysician
        txtEmail.Text = strEmail
        txtAddress.Text = strAddress
        txtCity.Text = strCity
        txtState.Text = strState
        txtPhone.Text = intPhone
        txtZipCode.Text = intZip

    End Sub
End Class