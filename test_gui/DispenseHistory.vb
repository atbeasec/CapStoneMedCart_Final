Imports System.Data.SQLite
Imports System.Text

Module DispenseHistory
    '/*******************************************************************/
    '/*                   FILE NAME: DispenseHistory.vb                 */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*              WRITTEN BY:  Alexander Beasecker   		        */
    '/*		         DATE CREATED: January 25, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                */
    '/*											                        */
    '/* This module is responsible for handling all dispensing medication
    '/* related modules
    '/*******************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			    */
    '/*                         (NONE)	                                */
    '/*******************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                */
    '/*                        (NOTHING)					            */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:								                */
    '/*											                        */
    '/* the program will invoke this module in two different ways. One  */ 
    '/* is when the user selects a patient to view there patient        */
    '/* information. The program will invoke this module to populate the*/
    '/* patient's medication history.                                   */
    '/* The second method of invokation is when the user clicks the     */
    '/* dispensed medication form on the main program screen. The       */
    '/* program will invoke the module to populate the dispensed history*/
    '/* table with all medications that have been dispensed.            */
    '/*                                                                 */
    '/*                                                                 */
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



    ' Dim strDEFAULTFOLDER As String = ""
    ' Dim strDBNAME As String = "Medication_Cart_System"
    ' Dim strDBPath As String = strDEFAULTFOLDER & strDBNAME & ".db"
    ' Public DBConn As SQLiteConnection
    ' Public DBCmd As SQLiteCommand
    ' Public strCONNECTION As String = String.Format("Data Source = {0}", strDBPath)
    ' Dim strCreateTable As String


    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:dispenseHistoryAllPatients      */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   01/27/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: This subroutine is used for gathering and 
    '/*    displaying the entire dispense history accross the entire system.
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  CreateDispenseHistoryPanels()
    '/*  DBadapter.Fill()
    '/*  DBConn.Open()
    '/*  
    '/*
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   
    '/*											   
    '/*  (None)			   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*											                           
    '/*   DispenseHistorySpecificPatient()
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*	
    '/* DBadapter
    '/* Strdatacommand
    '/* mydataset
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  01/27/21  Initial creation of the code      */
    '/*********************************************************************/

    'Sub dispenseHistoryAllPatients()

    '    Dim Strdatacommand As String

    '    Strdatacommand = "SELECT Drug_Name, DateTime_Dispensed, Dosage, Amount_Dispensed, 
    ' Primary_User_TUID, Patient_ID, Patient_First_Name || ' '|| Patient_Last_Name as 'Patient Name'
    ' FROM Dispensing 
    ' INNER JOIN PatientMedication
    ' On PatientMedication.PatientMedication_ID = Dispensing.PatientMedication_TUID
    ' INNER JOIN Patient
    ' On PatientMedication.Patient_TUID = Patient.Patient_ID
    ' INNER JOIN Medication
    ' On Medication.Medication_ID = PatientMedication.Medication_TUID;"


    '    DBConn = New SQLiteConnection(strCONNECTION)
    '    DBCmd = New SQLiteCommand(DBConn)
    '    DBConn.Open()
    '    Dim DSmydataset As New DataSet
    '    Dim DBadapter As New SQLiteDataAdapter
    '    DBCmd.CommandText = Strdatacommand
    '    DBadapter = New SQLiteDataAdapter(Strdatacommand, DBConn)
    '    DBadapter.Fill(DSmydataset, "PATIENT")

    '    For Each dr As DataRow In DSmydataset.Tables("PATIENT").Rows
    '        frmReport.CreatePanel(frmReport.flpReport, dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6))
    '    Next
    'End Sub


    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:DispenseHistorySpecificPatient  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   01/27/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: The purpose of this subroutine is to gather
    '/*     and display the entire dispense history of a single patient.
    '/*     It takes in the patient ID, runs the sql command to retreieve 
    '/*     the patient dispense history and then calls the cratedispenseHistory
    '/*     module from frmPatientInfo to display them to the GUI
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  CreateDispenseHistoryPanels()
    '/*  DBadapter.Fill()
    '/*  DBConn.Open()
    '/*  
    '/*
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   
    '/*											   
    '/*  ***PATIENT ID***			   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*											                           
    '/*   DispenseHistorySpecificPatient()
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*	
    '/* DBadapter
    '/* Strdatacommand
    '/* mydataset
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  01/27/21  Initial creation of the code      */
    '/*********************************************************************/

    Sub DispenseHistorySpecificPatient(ByRef intPatientMRN As Integer)
        Dim Strdatacommand As String = "SELECT Drug_Name, PatientMedication.Method, Amount_Dispensed,User.User_Last_Name,User.User_First_Name, DateTime_Dispensed   
          FROM Dispensing 
          INNER JOIN PatientMedication
          On PatientMedication.PatientMedication_ID = Dispensing.PatientMedication_TUID
          INNER JOIN Patient
          On PatientMedication.Patient_TUID = Patient.Patient_ID
          INNER JOIN Medication
          On Medication.Medication_ID = PatientMedication.Medication_TUID
          INNER JOIN User
		  ON User.User_ID = Dispensing.Primary_User_TUID
          WHERE Patient.MRN_Number = '" & intPatientMRN & "' ORDER BY DateTime_Dispensed DESC;"

        Dim dsmydataset As DataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsmydataset.Tables(0).Rows
            frmPatientInfo.CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), "    ", dr(1), dr(2), dr(4) & " " & dr(3), dr(5), " ")
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:DispensemedicationPopulate  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
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
    '/*  Alexander Beasecker  02/10/21  Initial creation of the code      */
    '/*********************************************************************/
    Public Sub DispensemedicationPopulate(ByRef intPatientMRN As Integer)
        Dispense.cmbMedications.Items.Clear()
        Dim Strdatacommand As String
        ' Currently the medication display is appending the RXCUI Number on too the medication
        ' name, as searching by name alone could cause problems if medication names can repeat
        Strdatacommand = "SELECT Drug_Name,RXCUI_ID FROM PatientMedication " &
        "INNER JOIN Medication on Medication.Medication_ID = PatientMedication.Medication_TUID " &
        "INNER JOIN Patient on Patient.Patient_ID = PatientMedication.Patient_TUID " &
        "WHERE MRN_Number = '" & intPatientMRN & "'"

        Dim dsMedicationDataSet As DataSet = New DataSet
        dsMedicationDataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)
        'add medication name and RXCUI to listbox
        For Each dr As DataRow In dsMedicationDataSet.Tables(0).Rows
            Dispense.cmbMedications.Items.Add(dr(0) & "--" & dr(1))
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:SetMedicationProperties  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
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
    '/*  Alexander Beasecker  02/10/21  Initial creation of the code      */
    '/*********************************************************************/
    Public Sub SetMedicationProperties()
        Dispense.cmbMethod.Items.Clear()
        Dispense.cmbDosage.Items.Clear()

        'get selected medication
        Dim strMedicationRXCUI As String = Dispense.cmbMedications.SelectedItem
        'split out the RXCUI and name
        Dim strArray() As String
        strArray = strMedicationRXCUI.Split("--")
        strMedicationRXCUI = strArray(2)
        'select medication type and strength for the selected medication using rxcui 
        Dim Strdatacommand As String
        Strdatacommand = "SELECT Method, Strength FROM PatientMedication " &
            "INNER JOIN Medication on Medication.Medication_ID = PatientMedication.Medication_TUID " &
            "WHERE RXCUI_ID = '" & strMedicationRXCUI & "'"

        'make dataset and call the sql method
        Dim dsMedicationInformation As DataSet = New DataSet
        dsMedicationInformation = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        'insert the method and dosage into comboboxes
        Dispense.cmbMethod.Items.Add(dsMedicationInformation.Tables(0).Rows(0)(0))
        Dispense.cmbMethod.SelectedItem = dsMedicationInformation.Tables(0).Rows(0)(0)

        Dispense.cmbDosage.Items.Add(dsMedicationInformation.Tables(0).Rows(0)(1))
        Dispense.cmbDosage.SelectedItem = dsMedicationInformation.Tables(0).Rows(0)(1)
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:DispenseMedication  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/15/21							  */
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
    '/*  Alexander Beasecker  02/15/21  Initial creation of the code      */
    '/*********************************************************************/
    Function SplitMedicationString(ByRef strMedicationString As String)
        ''split string to get the RXCUI for the medication selected on form
        Dim strArray() As String
        strArray = strMedicationString.Split("--")

        Return strArray(2)
    End Function

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:DispenseMedication  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/15/21							  */
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
    '/*  Alexander Beasecker  02/15/21  Initial creation of the code      */
    '/*********************************************************************/
    Public Sub DispenseMedication(ByRef strMedicationID As String, ByRef intPatientMRN As Integer)
        'create variables
        Dim strbSQLcommand As New StringBuilder()
        Dim intMedID As Integer
        Dim intPatientID As Integer
        Dim intPrescribedQuantity As Integer

        'using RXCUI get database ID for medication
        strbSQLcommand.Append("SELECT Medication_ID FROM Medication WHERE RXCUI_ID = '" & strMedicationID & "'")
        intMedID = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)

        'clear string builder and using MRN get database patient ID
        strbSQLcommand.Clear()
        strbSQLcommand.Append("SELECT Patient_ID FROM Patient WHERE MRN_Number = '" & intPatientMRN & "'")
        intPatientID = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)

        'clear string builder using medID and PatientID get the quantity of the prescribed medication
        strbSQLcommand.Clear()
        strbSQLcommand.Append("SELECT Quantity FROM PatientMedication WHERE Medication_TUID = '" & intMedID & "' AND Patient_TUID = '" & intPatientID & "'")
        intPrescribedQuantity = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)

        'update quantity to new amount
        intPrescribedQuantity = intPrescribedQuantity - Dispense.txtQuantity.Text
        strbSQLcommand.Clear()
        strbSQLcommand.Append("UPDATE PatientMedication SET Quantity = " & intPrescribedQuantity & " WHERE Medication_TUID = '" & intMedID & "' AND Patient_TUID = '" & intPatientID & "'")
        CreateDatabase.ExecuteInsertQuery(strbSQLcommand.ToString)
        strbSQLcommand.Clear()
    End Sub
End Module

