Public Class frmDischarge

    Dim intDischargePatientID As New ArrayList
    Dim intAdmitPatientID As New ArrayList

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/18/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/18/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub btnAdmit_Click(sender As Object, e As EventArgs) Handles btnAdmit.Click
        Dim intPatientID As Integer = intAdmitPatientID(cmbAdmitPatients.SelectedIndex)
        CreateDatabase.ExecuteInsertQuery("Update Patient SET Active_Flag = 1 WHERE Patient_ID = '" & intPatientID & "'")
        Loadcmb()
        clearPatientTextBoxes()

    End Sub
    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/18/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/18/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub btnDischarge_Click(sender As Object, e As EventArgs) Handles btnDischarge.Click
        If Not cmbDischargePatients.SelectedIndex = -1 Then
            Dim intPatientID As Integer = intDischargePatientID(cmbDischargePatients.SelectedIndex)
            CreateDatabase.ExecuteInsertQuery("Update Patient SET Active_Flag = 0 WHERE Patient_ID = '" & intPatientID & "'")
            Dim dsRoomandBed As DataSet = CreateDatabase.ExecuteSelectQuery("SELECT Room_TUID,Bed_Name from PatientRoom where Patient_TUID = '" & intPatientID & "' AND Active_Flag = '1'")
            CreateDatabase.ExecuteInsertQuery("UPDATE PatientRoom SET Active_Flag = '0' WHERE Patient_TUID = '" & intPatientID & "' AND Room_TUID = '" & dsRoomandBed.Tables(0).Rows(0)(0) & "' AND Bed_Name = '" & dsRoomandBed.Tables(0).Rows(0)(1) & "'")
            Loadcmb()
            clearPatientTextBoxes()
        Else
            MessageBox.Show("Please select a patient to discharge")
        End If

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/18/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/18/21  Initial creation of the code    */
    '/*********************************************************************/
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

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/18/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/18/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub frmDischarge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadcmb()
        PopulateAdmitRooms()
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/18/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/18/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub radAdmitPatient_CheckedChanged(sender As Object, e As EventArgs) Handles radAdmitPatient.CheckedChanged, radDischarge.CheckedChanged
        pnlAdmit.Visible = False
        pnlDischarge.Visible = False
        pnlInformation.Visible = False

        If radAdmitPatient.Checked = True Then
            pnlAdmit.Visible = True
            pnlDischarge.Visible = False
            pnlInformation.Visible = True
            pnlAdmitRoomBed.Visible = True
            pnlDischargeRoomBed.Visible = False
            cmbAdmitPatients.SelectedIndex = -1
            cmbDischargePatients.SelectedIndex = -1
            clearPatientTextBoxes()
            cboRoomandBed.Items.Clear()
            PopulateAdmitRooms()
        ElseIf radDischarge.Checked = True Then
            pnlAdmit.Visible = False
            pnlDischarge.Visible = True
            pnlInformation.Visible = True
            pnlAdmitRoomBed.Visible = False
            pnlDischargeRoomBed.Visible = True
            cmbAdmitPatients.SelectedIndex = -1
            cmbDischargePatients.SelectedIndex = -1
            clearPatientTextBoxes()
            cboRoomandBed.Items.Clear()
        End If
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/18/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/18/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub cmbAdmitPatients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAdmitPatients.SelectedIndexChanged
        If Not cmbAdmitPatients.SelectedIndex = -1 Then
            clearPatientTextBoxes()
            Dim intPatientID As Integer = intAdmitPatientID(cmbAdmitPatients.SelectedIndex)
            Dim dsPatientAdmit As DataSet = CreateDatabase.ExecuteSelectQuery("Select * From Patient WHERE Patient_ID = '" & intPatientID & "'")
            Dim dsPrimaryDoctor As DataSet = CreateDatabase.ExecuteSelectQuery("Select * from Physician where Physician_ID = '" & dsPatientAdmit.Tables(0).Rows(0)(EnumList.Patient.PhysicianID) & "'")
            Dim strPrimaryDoctor As String = "Dr " & dsPrimaryDoctor.Tables(0).Rows(0)(EnumList.Physician.FirstName) & " " & dsPrimaryDoctor.Tables(0).Rows(0)(EnumList.Physician.LastName)

            For Each dr As DataRow In dsPatientAdmit.Tables(0).Rows
                populatePatientTextBoxes(dr(1), dr(6), dr(7), dr(8), dr(9), strPrimaryDoctor, dr(15), dr(10), dr(11), dr(12), dr(14), dr(13))
            Next
        End If
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/18/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/18/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub cmbDischargePatients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDischargePatients.SelectedIndexChanged
        If Not cmbDischargePatients.SelectedIndex = -1 Then
            clearPatientTextBoxes()
            Dim intPatientID As Integer = intDischargePatientID(cmbDischargePatients.SelectedIndex)
            Dim dsPatientDischarge As DataSet = CreateDatabase.ExecuteSelectQuery("Select * From Patient WHERE Patient_ID = '" & intPatientID & "'")
            Dim dsPrimaryDoctor As DataSet = CreateDatabase.ExecuteSelectQuery("Select * from Physician where Physician_ID = '" & dsPatientDischarge.Tables(0).Rows(0)(EnumList.Patient.PhysicianID) & "'")
            Dim strPrimaryDoctor As String = "Dr " & dsPrimaryDoctor.Tables(0).Rows(0)(EnumList.Physician.FirstName) & " " & dsPrimaryDoctor.Tables(0).Rows(0)(EnumList.Physician.LastName)
            Dim dsPatientRoom As DataSet = CreateDatabase.ExecuteSelectQuery("SELECT * FROM PatientRoom where Patient_TUID = '" & intPatientID & "'")

            For Each dr As DataRow In dsPatientDischarge.Tables(0).Rows
                populatePatientTextBoxes(dr(1), dr(6), dr(7), dr(8), dr(9), strPrimaryDoctor, dr(15), dr(10), dr(11), dr(12), dr(14), dr(13))
            Next
        End If
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/18/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/18/21  Initial creation of the code    */
    '/*********************************************************************/
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

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/18/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/18/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub populatePatientTextBoxes(ByRef intMRN As String, ByRef strDOB As String, ByRef strGender As String, ByRef intHeight As Integer, ByRef intWeight As Integer,
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

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:       */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/18/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   						                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  03/18/21  Initial creation of the code    */
    '/*********************************************************************/
    Private Sub PopulateAdmitRooms()
        cboRoomandBed.Items.Clear()
        Dim dsRoomsandBeds As DataSet = CreateDatabase.ExecuteSelectQuery("Select Room_ID,Bed_Name from Rooms WHERE Active_Flag = '1' EXCEPT Select Room_TUID,Bed_Name from PatientRoom where PatientRoom.Active_Flag = '1'")
        For Each dr As DataRow In dsRoomsandBeds.Tables(0).Rows
            cboRoomandBed.Items.Add(dr(0) & " " & dr(1))
        Next
    End Sub
End Class