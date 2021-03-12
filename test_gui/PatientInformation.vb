Imports System.Data.SQLite
Imports System.Text
Module PatientInformation
    '/*******************************************************************/
    '/*                   FILE NAME: PatientInformation.vb              */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*              WRITTEN BY:  Alexander Beasecker   		        */
    '/*		         DATE CREATED: January 25, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                */
    '/*											                        */
    '/* This module is  reponsible for populating the patient           */
    '/* information boxes, patient first, and last name, patient MRN,   */
    '/* DOB, sex, height, weight, room number, bed number, the patient's*/
    '/* primary physician, and the patients address email and           */
    '/* phone number into the patient information form.                 */
    '/* it is also responsible for displaying the current and past      */
    '/* medication history of the patient, along with displaying patient*/
    '/* allergies and patient chart notes.                              */
    '/*ALL patient information will be imported from the database into a*/ 
    '/*list which will Then populate the tables Of data On the patient  */ 
    '/*information view                                                 */
    '/*                                                                 */
    '/*******************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			    */
    '/*                         (NONE)	                                */
    '/*******************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                */
    '/*                        (NOTHING)					            */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:								                */
    '/*											                        */
    '/* the program will invoke this module when a patient chart is     */
    '/* loaded to populate the selected patients information fields.     */
    '/*******************************************************************/
    '/*  GLOBAL VARIABLE LIST (Alphabetically):			                */
    '/*						  	 (NONE)			                        */
    '/*******************************************************************/
    '/* COMPILATION NOTES:								                */
    '/* 											                    */
    '/* This project compiles normally under Microsoft Visual Basic.    */
    '/* All one needs to do Is open up the Solver project And compile.  */
    '/* No special compile options Or optimizations were used.  No      */
    '/* unresolved warnings Or errors exist under these compilation     */
    '/* conditions.									                    */
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:						                    */
    '/*											                        */
    '/*  WHO                     WHEN        WHAT						*/
    '/*  Alexander Beasecker    1/25/2021   Initial creation            */
    '/*  Adam Kott              1/27/2021   added plans for module      */
    '/*  Adam Kott              1/28/2021   added database connection   */
    '/*  Nathan Premo           2/16/2021   added getRoom method to     */
    '/*                                     connect the room combo box  */
    '/*                                     to the database.            */
    '/*******************************************************************/


    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:GetPatientInformation           */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/09/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: The purpose of this subroutine is designed to handle
    '/* the population of the patient information in the patient inforamtion
    '/* screen.
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/* ExecuteSelectQuery()
    '/* IsDBNull()
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   
    '/*											   
    '/*  intPatientMRN			   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*											                           
    '/*   GetPatientInformation("233987")
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*	
    '/* dsPatientDataSet
    '/* intPhysicianID
    '/* strSQLiteCommand
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/09/21  Initial creation of the code      */
    '/*  NP                   02/9/2021 Changed intPhysicianID to be nothing*/
    '/*                                 When first made to remove the used*/
    '/*                                 before declared warning.          */
    '/*********************************************************************/
    Public Sub GetPatientInformation(ByRef intPatient_ID As Integer)
        PopulateStateComboBox(frmPatientInfo.cboState)
        Dim dsPatientDataSet As DataSet = New DataSet
        'changed be nothing when made to clear up used before declared warning. 
        Dim intPhysicianID As String = Nothing
        'sql taktement to get patient information
        Dim strSQLiteCommand As String = "SELECT * FROM Patient WHERE Patient_ID = '" & intPatient_ID & "'"

        dsPatientDataSet = CreateDatabase.ExecuteSelectQuery(strSQLiteCommand)
        ''check each piece of dataset for null, if not null set it, set to N/A if null
        For Each dr As DataRow In dsPatientDataSet.Tables(0).Rows

            If IsDBNull(dr(0)) Then
                frmPatientInfo.txtMRN.Text = "N/A"
            Else
                frmPatientInfo.txtMRN.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.MRN_Number)
            End If

            If IsDBNull(dr(4)) Then
                frmPatientInfo.txtBirthday.Text = "N/A"
            Else
                frmPatientInfo.txtBirthday.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.DoB)
            End If

            If IsDBNull(dr(5)) Then
                frmPatientInfo.txtGender.Text = "N/A"
            Else
                frmPatientInfo.txtGender.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.Sex)
            End If

            If IsDBNull(dr(6)) Then
                frmPatientInfo.txtHeight.Text = "N/A"
            Else
                frmPatientInfo.txtHeight.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.Height)
            End If

            If IsDBNull(dr(7)) Then
                frmPatientInfo.txtWeight.Text = "N/A"
            Else
                frmPatientInfo.txtWeight.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.Weight)
            End If

            If IsDBNull(dr(8)) Then
                frmPatientInfo.txtAddress.Text = "N/A"
            Else
                frmPatientInfo.txtAddress.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.address)
            End If

            If IsDBNull(dr(8)) Then
                frmPatientInfo.txtCity.Text = "N/A"
            Else
                frmPatientInfo.txtCity.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.City)
            End If

            If IsDBNull(dr(8)) Then
                frmPatientInfo.cboState.SelectedItem = "N/A"
            Else
                frmPatientInfo.cboState.SelectedItem = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.state)
            End If

            If IsDBNull(dr(8)) Then
                frmPatientInfo.txtZipCode.Text = "N/A"
            Else
                frmPatientInfo.txtZipCode.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.zip)
            End If

            If IsDBNull(dr(11)) Then
                frmPatientInfo.txtEmail.Text = "N/A"
            Else
                frmPatientInfo.txtEmail.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.Email)
            End If

            If IsDBNull(dr(12)) Then
                frmPatientInfo.txtPhone.Text = "N/A"
            Else
                frmPatientInfo.txtPhone.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.Phone)
            End If

            If IsDBNull(dr(1)) Then
                frmPatientInfo.LblPatientName.Text = "N/A"
            Else
                frmPatientInfo.LblPatientName.Text = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.FristName) &
                    " " & dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.MiddleName) &
                    " " & dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.LastName)
            End If

            intPhysicianID = dsPatientDataSet.Tables(0).Rows(0)(EnumList.Patient.PhysicianID)
        Next
        'get name of physician that is assigned to patient
        strSQLiteCommand = "SELECT Physician_First_Name,Physician_Last_Name" &
            " FROM Physician WHERE Physician_ID = '" & intPhysicianID & "'"

        dsPatientDataSet = CreateDatabase.ExecuteSelectQuery(strSQLiteCommand)
        'check if physician fields are null
        For Each dr As DataRow In dsPatientDataSet.Tables(0).Rows
            If IsDBNull(dr(1)) Then
                frmPatientInfo.txtPhysician.Text = "N/A"
            Else
                frmPatientInfo.txtPhysician.Text = "Dr. " & dr(0) & " " & dr(1)
            End If
        Next
        'call dispense history to get dispensed history of the patient
        DispenseHistory.DispenseHistorySpecificPatient(intPatient_ID)
    End Sub

    '/*********************************************************************/
    '/*                   FUNCTION NAME: GetAllergies                       */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:Adam kott                             */   
    '/*                 DATE CREATED:2/8/2021                                 */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:    receive a MRN number and push the              */             
    '/* allergy information into the allergies list                       */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:                                                           */           
    '/*                                                                   */         
    '/*********************************************************************/
    '/*  CALLS:                                                              */                 
    '/*             (ExecuteScalar),(ExectueSelectQuery)                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):                              */         
    '/*        intPatientInformationMRN                                      */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:                                                          */                   
    '/*            (NOTHING)                                              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:                                   */             
    '/*                                               */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*           dtsPatientAllergy:                                         */
    '/*        intPatientAllergyId:                                       */
    '/*        intPatientInformationMRN:                                  */


    '/*    */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:                                 */               
    '/*                                               */                     
    '/*  WHO   WHEN     WHAT                                   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*  AK   2/8/2021 Created the SQL statements to pull back the       */
    '/*                 information needed for Patient allergies list     */
    '/*********************************************************************/
    Public Sub GetAllergies(ByRef intPatient_ID As Integer)
        frmPatientInfo.lstBoxAllergies.Items.Clear()
        'default value for an mrn number so allergies are shown
        'intPatientInformationMRN = 949764144

        'get the patient id assiociated with the MRN Nummber
        Dim intPatientAllergyId As Integer = intPatient_ID ' CInt(CreateDatabase.ExecuteScalarQuery("select patient.Patient_ID From Patient " &
        '"where Patient.Patient_ID=" & (intPatient_ID).ToString & ";"))
        'get the allergy information from the patient allergy tables
        Dim dtsPatientAllergy As DataSet = CreateDatabase.ExecuteSelectQuery("Select Allergy_Name From PatientAllergy " &
                            "Where Active_Flag =1 AND Patient_TUID =" & (intPatientAllergyId).ToString & ";")

        'push each row from the
        For Each item As DataRow In dtsPatientAllergy.Tables(0).Rows
            With dtsPatientAllergy.Tables(0)
                frmPatientInfo.lstBoxAllergies.Items.Add(item(0))
            End With
        Next
        'get select from patient allergy inner join on patient table where tuid is the same
        'join patients meds table and medications table
    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: PopulatePatientDispenseInfo 	  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		                          */   
    '/*		              DATE CREATED: 	                              */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */             
    '/*											                          */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             (NONE)								                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											                          */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                   */
    '/*********************************************************************/
    Public Sub PopulatePatientDispenseInfo(ByRef intPatient_ID As Integer)

        'get patient information using sql generic method
        Dim dsPatientInfo As DataSet = CreateDatabase.ExecuteSelectQuery("SELECT Date_of_Birth,Patient_First_Name,Patient_Last_Name FROM Patient WHERE Patient_ID = '" & intPatient_ID & "'")
        'set all patient information into dispense textboxes
        frmDispense.txtMRN.Text = intPatient_ID
        frmDispense.txtDOB.Text = dsPatientInfo.Tables(0).Rows(0)(0)
        frmDispense.txtPatientFirstName.Text = dsPatientInfo.Tables(0).Rows(0)(1)
        frmDispense.txtPatientLastName.Text = dsPatientInfo.Tables(0).Rows(0)(2)
    End Sub

    '/*********************************************************************/
    '/*                   FUNCTION NAME: PopulatePatientAllergiesDispenseInfo   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:Adam kott                             */   
    '/*                 DATE CREATED:2/10/2021                           */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:                                                      */                    
    '/*********************************************************************/
    '/*  CALLS:                                                         */                            
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):                              */         
    '/*********************************************************************/
    '/*  RETURNS:                                                          */                   
    '/*            (NOTHING)                                              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:                                   */             
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:                                 */               
    '/*                                               */                     
    '/*  WHO   WHEN     WHAT                                   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*  ATB   2/10/2021 initial code creation
    '/*********************************************************************/
    Public Sub PopulatePatientAllergiesDispenseInfo(ByRef intPatient_ID As Integer)
        Dim dsPatientInfo As DataSet = CreateDatabase.ExecuteSelectQuery("SELECT Allergy_Name From PatientAllergy " &
                                                                         "INNER JOIN Patient on Patient.Patient_ID = PatientAllergy.Patient_TUID " &
                                                                         "WHERE Patient_ID = '" & intPatient_ID & "'")
        For Each dr As DataRow In dsPatientInfo.Tables(0).Rows
            frmDispense.lstboxAllergies.Items.Add(dr(0))
        Next
    End Sub
    '/*********************************************************************/
    '/*                   FUNCTION NAME: getPrescriptions                  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:Adam kott                             */   
    '/*                 DATE CREATED:2/10/2021                           */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:
    '/*********************************************************************/
    '/*  CALLED BY:                                                      */                    
    '/*********************************************************************/
    '/*  CALLS:                                                         */                            
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):                              */         
    '/*********************************************************************/
    '/*  RETURNS:                                                          */                   
    '/*            (NOTHING)                                              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:                                   */             
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:                                 */               
    '/*                                               */                     
    '/*  WHO   WHEN     WHAT                                   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*  ATB   2/10/2021 initial code creation
    '/*********************************************************************/
    Public Sub getPrescriptions(ByRef intPatient_ID As Integer)
        Dim strSQLiteCommand As String
        Dim dsPatientPrescription As DataSet
        strSQLiteCommand = "SELECT Drug_Name, Strength, Frequency, PatientMedication.Type, Quantity ,Date_Presrcibed, Physician_First_Name, Physician_Last_Name FROM PatientMedication " &
            "INNER JOIN Medication on Medication.Medication_ID = PatientMedication.Medication_TUID " &
            "INNER JOIN Patient ON Patient.Patient_ID = PatientMedication.Patient_TUID " &
            "INNER JOIN Physician on Physician.Physician_ID = PatientMedication.Ordering_Physician_ID " &
            "WHERE Patient.Patient_ID = '" & intPatient_ID & "' AND PatientMedication.Active_Flag = '1'"

        dsPatientPrescription = CreateDatabase.ExecuteSelectQuery(strSQLiteCommand)
        For Each dr As DataRow In dsPatientPrescription.Tables(0).Rows
            frmPatientInfo.CreatePrescriptionsPanels(frmPatientInfo.flpMedications, dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), "Dr. " & dr(6) & " " & dr(7))
        Next
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: getRoom   					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 2/16/2021                    		   */                             
    '/*********************************************************************/
    '/*  SUBPROHRAM PURPOSE:								               */             
    '/*	 This is going to populate the room combo box as well as select the*/
    '/*  select the room the patient is in. It is also going to populate   */
    '/*  the room combo box using the populateRoomComboboxMethod           */
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 intPatientMRN - this is the patient medical record we are going to*/                     
    '/*                  be using for the SQL statements.                  */
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            (NOTHING)								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/


    Public Sub getRoom(intPatient_ID As Integer, cboRoom As ComboBox, cboBed As ComboBox)

        Dim strbSQL As StringBuilder = New StringBuilder
        Dim dsPatient As DataSet
        Dim dsPatientRoom As DataSet
        Dim intPatient_TUID As Integer
        Dim strbed As String = ""
        Dim strroom As String = ""

        dsPatient = CreateDatabase.ExecuteSelectQuery("Select * from Patient where Patient_ID = '" & intPatient_ID & "';")
        strbSQL.Append("Select * from Rooms;")
        PopulateRoomsCombBoxesMethods.PopulateRoomComboBox(cboRoom, CreateDatabase.ExecuteSelectQuery(strbSQL.ToString))
        'calling that function will populate the room combobox for us. 

        strbSQL.Clear()
        For Each row As DataRow In dsPatient.Tables(0).Rows
            intPatient_TUID = row(0)
        Next
        dsPatientRoom = CreateDatabase.ExecuteSelectQuery("Select * from PatientRoom where Patient_TUID ='" & intPatient_TUID & "';")
        For Each row As DataRow In dsPatientRoom.Tables(0).Rows
            strbed = row(2)
            strroom = row(1)
            Debug.WriteLine(" ")
        Next
        PopulateRoomsCombBoxesMethods.UpdateBedComboBox(cboBed, cboRoom)
        cboRoom.SelectedItem = strroom
        cboBed.SelectedItem = strbed
    End Sub


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: DisplayPatientPrescriptionsDispense    */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker  		       */   
    '/*		         DATE CREATED: 2/28/2021                    		   */                             
    '/*********************************************************************/
    '/*  SUBPROHRAM PURPOSE:								               */             
    '/*	 This sub will populate the patient prescription panels on the 
    '/*  patient dispense form
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*	 intPatientMRN - this is the patient medical record we are going to*/                     
    '/*                  be using for the SQL statements.                  */
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            (NOTHING)								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*   AB    2/28/2021   Initial creation                                                                  
    '/*********************************************************************/
    Public Sub DisplayPatientPrescriptionsDispense(ByRef intPatient_ID As Integer)
        Dim intPatientID As Integer = intPatient_ID ' CreateDatabase.ExecuteScalarQuery("SELECT Patient_ID from Patient WHERE Patient_ID = '" & intPatient_ID & "'")
        Dim dsPatientInfo As DataSet
        Dim strbSqlCommand As StringBuilder = New StringBuilder

        'set up sql command inner joining the medication, patientMedicaiton and physician table
        ' this is done to get the drug name, strength, type and frequency of the medication the specific patient
        ' is prescribed, it then joins the patient medicaiton table to get the quantity, date prescribed and 
        ' the physician ID who prescribed it, inner joining the physician table with the ID to get the name of the physician
        strbSqlCommand.Append("SELECT Drug_Name, Strength, Frequency, Medication.Type, PatientMedication.Quantity, ")
        strbSqlCommand.Append("PatientMedication.Date_Presrcibed, Physician.Physician_First_Name, Physician.Physician_Last_Name ")
        strbSqlCommand.Append("FROM Medication Inner Join PatientMedication ON PatientMedication.Medication_TUID = Medication.Medication_ID ")
        strbSqlCommand.Append("Inner Join Physician ON Physician.Physician_ID = PatientMedication.Ordering_Physician_ID ")
        strbSqlCommand.Append("WHERE PatientMedication.Patient_TUID = '" & intPatientID & "' AND PatientMedication.Active_Flag = '1'")
        dsPatientInfo = CreateDatabase.ExecuteSelectQuery(strbSqlCommand.ToString)
        'look create panel method for each prescription the patient has
        For Each dr As DataRow In dsPatientInfo.Tables(0).Rows
            frmDispense.CreatePrescriptionsPanels(frmDispense.flpMedications, dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), "Dr. " & dr(6) & " " & dr(7))
        Next

    End Sub

    Public Sub PatinetInfoSortedByFrequency(ByRef intPatient_ID As Integer)
        Dim intPatientID As Integer = intPatient_ID ' CreateDatabase.ExecuteScalarQuery("SELECT Patient_ID from Patient WHERE Patient_ID = '" & intPatient_ID & "'")
        Dim dsPatientInfo As DataSet
        Dim strbSqlCommand As StringBuilder = New StringBuilder

        'set up sql command inner joining the medication, patientMedicaiton and physician table
        ' this is done to get the drug name, strength, type and frequency of the medication the specific patient
        ' is prescribed, it then joins the patient medicaiton table to get the quantity, date prescribed and 
        ' the physician ID who prescribed it, inner joining the physician table with the ID to get the name of the physician
        strbSqlCommand.Append("SELECT Drug_Name, Strength, Frequency, Medication.Type, PatientMedication.Quantity, ")
        strbSqlCommand.Append("PatientMedication.Date_Presrcibed, Physician.Physician_First_Name, Physician.Physician_Last_Name ")
        strbSqlCommand.Append("FROM Medication Inner Join PatientMedication ON PatientMedication.Medication_TUID = Medication.Medication_ID ")
        strbSqlCommand.Append("Inner Join Physician ON Physician.Physician_ID = PatientMedication.Ordering_Physician_ID ")
        strbSqlCommand.Append("WHERE PatientMedication.Patient_TUID = '" & intPatientID & "' AND PatientMedication.Active_Flag = '1' ORDER BY CAST(PatientMedication.Frequency as INTEGER)")
        dsPatientInfo = CreateDatabase.ExecuteSelectQuery(strbSqlCommand.ToString)
        'look create panel method for each prescription the patient has
        For Each dr As DataRow In dsPatientInfo.Tables(0).Rows
            frmPatientInfo.CreatePrescriptionsPanels(frmPatientInfo.flpMedications, dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), "Dr. " & dr(6) & " " & dr(7))
        Next

    End Sub
End Module