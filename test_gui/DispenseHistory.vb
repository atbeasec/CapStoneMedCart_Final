Imports System.Data.SQLite
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
    '/* This module is responsible for populating dispensed medicaitons*/
    '/* in both the patient charts and in the dispensed history form.   */
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
        Dim Strdatacommand As String = "SELECT Drug_Name, Synonym, Amount_Dispensed, Dosage,Primary_User_TUID, DateTime_Dispensed   
          FROM Dispensing 
          INNER JOIN PatientMedication
          On PatientMedication.PatientMedication_ID = Dispensing.PatientMedication_TUID
          INNER JOIN Patient
          On PatientMedication.Patient_TUID = Patient.Patient_ID
          INNER JOIN Medication
          On Medication.Medication_ID = PatientMedication.Medication_TUID
          WHERE Patient.MRN_Number = '" & intPatientMRN & "';"

        Dim dsmydataset As DataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsmydataset.Tables(0).Rows
            frmPatientInfo.CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), "9:30")
        Next

    End Sub

End Module

