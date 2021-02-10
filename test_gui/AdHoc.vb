Imports System.Data.SQLite
Module AdHoc
    '/*******************************************************************/
    '/*                   FILE NAME: AdHoc.vb                           */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*              WRITTEN BY:  Alexander Beasecker   		        */
    '/*		         DATE CREATED: January 25, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                */
    '/*											                        */
    '/* the purpse of this module is to handle adHoc medication orders. */
    '/* it will interact with the database to insert the adHoc order and*/ 
    '/* update the patient order history to reflect the new adHoc order */
    '/*******************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			    */
    '/*                         (NONE)	                                */
    '/*******************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                */
    '/*                        (NOTHING)					            */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:								                */
    '/*											                        */
    '/* The program will invoke the AdHoc module when the user places an
    '/* AdHoc order. It will take the information that is placed in the 
    '/* AdHoc section and insert the information into the patient orders 
    '/* database table.
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
    '/*******************************************************************/

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:InsertAdHoc                     */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/01/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: This subroutines purpose is to take the 
    '/* information that is selected on the AdHoc order screen and insert it into the
    '/* patient Adhoc order table.
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  frmPatientRecords -- btnDispense_Click()							           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/* String.Split()
    '/* ExecuteScalarQuery()
    '/* IsDBNull()
    '/* ExecuteInsertQuery()
    '/*
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):
    '/* intPatientMRN As Integer, intUserID As Integer
    '/* intAmount As Integer
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	InsertAdHoc('876523','10','100')										                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/* dtmAdhocTime
    '/* strArray()
    '/*	Strdatacommand
    '/* intMedicationDrawerID
    '/* intMedicationID
    '/* intMedRXCUI
    '/* intPatientID
    '/* StrSelectedMedication
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/01/2021  Initial creation of the code    */
    '/*********************************************************************/

    Public Sub InsertAdHoc(ByRef intPatientMRN As Integer, ByRef intUserID As Integer,
                           ByRef intAmount As Integer)
        'create variables used for insert order
        Dim intMedicationID As Integer
        Dim intPatientID As Integer
        Dim Strdatacommand As String
        Dim intMedRXCUI As Integer
        Dim intMedicationDrawerID As Integer
        Dim StrSelectedMedication As String

        StrSelectedMedication = frmAdHockDispense.cmbMedications.SelectedItem

        'Split selected medication to get RXCUI number
        Dim strArray() As String = StrSelectedMedication.Split("--")
        intMedRXCUI = strArray(2)

        'Get medication TUID
        Strdatacommand = "SELECT Medication_ID FROM Medication WHERE RXCUI_ID = '" & intMedRXCUI & "'"
        intMedicationID = ExecuteScalarQuery(Strdatacommand)

        'Get Drawer Medication TUID
        Strdatacommand = "SELECT DrawerMedication_ID FROM DrawerMedication WHERE Medication_TUID = '" & intMedicationID & "'"
        intMedicationDrawerID = ExecuteScalarQuery(Strdatacommand)

        'Get patient TUID
        Strdatacommand = "SELECT Patient_ID FROM Patient WHERE MRN_Number = '" & intPatientMRN & "'"
        intPatientID = ExecuteScalarQuery(Strdatacommand)


        If Not IsDBNull(intMedicationDrawerID) Then
            'get current time for dateTime in table
            Dim dtmAdhocTime As String = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
            Strdatacommand = "INSERT INTO AdHocOrder(Medication_TUID,Patient_TUID,User_TUID,Amount,DrawerMedication_TUID,DateTime) " &
                "VALUES('" & intMedicationID & "', '" & intPatientID & "', '" & intUserID & "', '" & intAmount & "', '" & intMedicationDrawerID & "', '" & dtmAdhocTime & "')"

            'insert AdHoc
            CreateDatabase.ExecuteInsertQuery(Strdatacommand)
        End If

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:GetAllMedicationsForListbox                     */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/09/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: the purpose of this subroutine is too
    '/*  populate the medications listbox with all the current Active medications
    '/*  that are currently on the drawer
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*											                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker 02/09/21	  Initial creation of the code     */
    '/*********************************************************************/
    Public Sub GetAllMedicationsForListbox()
        Dim Strdatacommand As String
        Strdatacommand = "Select Drug_Name, RXCUI_ID FROM Medication INNER JOIN DrawerMedication ON DrawerMedication.Medication_TUID = Medication.Medication_ID WHERE Active_Flag = 1"

        Dim dsMedicationDataSet As DataSet = New DataSet
        dsMedicationDataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsMedicationDataSet.Tables(0).Rows
            frmAdHockDispense.cmbMedications.Items.Add(dr(0) & "--" & dr(1))
        Next
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:SetMedicationProperties                     */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/09/21								  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: 
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*											                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/09/21	  Initial creation of the code     */
    '/*********************************************************************/
    Public Sub SetMedicationProperties()

        frmAdHockDispense.cmbMethod.Items.Clear()
        frmAdHockDispense.cmbDosage.Items.Clear()

        Dim strMedicationName As String = frmAdHockDispense.cmbMedications.SelectedItem

        Dim strArray() As String
        strArray = strMedicationName.Split("--")
        strMedicationName = strArray(0)

        Dim Strdatacommand As String
        Strdatacommand = "SELECT Type, Strength From Medication WHERE Drug_Name = '" & strMedicationName & "'"


        Dim dsMedicationInformation As DataSet = New DataSet
        dsMedicationInformation = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        frmAdHockDispense.cmbMethod.Items.Add(dsMedicationInformation.Tables(0).Rows(0)(0))
        frmAdHockDispense.cmbMethod.SelectedItem = dsMedicationInformation.Tables(0).Rows(0)(0)

        frmAdHockDispense.cmbDosage.Items.Add(dsMedicationInformation.Tables(0).Rows(0)(1))
        frmAdHockDispense.cmbDosage.SelectedItem = dsMedicationInformation.Tables(0).Rows(0)(1)

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:PopulatePatientsAdhoc                     */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/09/21								  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: 
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*											                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/09/21	  Initial creation of the code     */
    '/*********************************************************************/
    Public Sub PopulatePatientsAdhoc()
        frmAdHockDispense.cmbPatientName.Items.Clear()

        Dim Strdatacommand As String
        Strdatacommand = "SELECT Patient_First_Name, Patient_Last_Name, MRN_Number FROM Patient WHERE Active_Flag = 1 Order By Patient_Last_Name, Patient_First_Name"


        Dim dsPatientRecords As DataSet = New DataSet
        dsPatientRecords = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsPatientRecords.Tables(0).Rows
            If IsDBNull(dr(0)) Then
                frmAdHockDispense.cmbPatientName.Items.Add("No medications in drawers")
            Else
                frmAdHockDispense.cmbPatientName.Items.Add(dr(0) & " " & dr(1) & "--" & dr(2))
            End If

        Next

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:PopulatePatientInformation                     */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/09/21								  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: 
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*											                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/09/21	  Initial creation of the code     */
    '/*********************************************************************/
    Public Sub PopulatePatientInformation()
        Dim strArray() As String
        Dim intPatientID As Integer
        frmAdHockDispense.txtDateOfBirth.Clear()
        frmAdHockDispense.txtMRN.Clear()

        Dim strPatientSelected As String = frmAdHockDispense.cmbPatientName.SelectedItem
        strArray = strPatientSelected.Split("--")
        Dim Strdatacommand As String

        frmAdHockDispense.txtMRN.Text = strArray(2)
        Strdatacommand = "SELECT Date_of_Birth, Patient_ID from Patient Where MRN_Number = '" & frmAdHockDispense.txtMRN.Text & "'"

        Dim dsPatientRecords As DataSet = New DataSet
        dsPatientRecords = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        frmAdHockDispense.txtDateOfBirth.Text = dsPatientRecords.Tables(0).Rows(0)(0)
        intPatientID = dsPatientRecords.Tables(0).Rows(0)(1)

        Strdatacommand = "SELECT Allergy_Name From PatientAllergy Where Patient_TUID = '" & intPatientID & "'"
        dsPatientRecords = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsPatientRecords.Tables(0).Rows
            frmAdHockDispense.lstboxAllergies.Items.Add(dr(0))
        Next
    End Sub

End Module
