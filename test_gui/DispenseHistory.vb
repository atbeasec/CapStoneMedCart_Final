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

    Sub DispenseHistorySpecificPatient(ByRef intPatientID As Integer)
        Dim Strdatacommand As String = "SELECT trim(Drug_Name,' '), Strength, PatientMedication.Type, Amount_Dispensed,User.User_Last_Name,User.User_First_Name, DateTime_Dispensed   
          FROM Dispensing 
          INNER JOIN PatientMedication
          On PatientMedication.PatientMedication_ID = Dispensing.PatientMedication_TUID
          INNER JOIN Patient
          On PatientMedication.Patient_TUID = Patient.Patient_ID
          INNER JOIN Medication
          On Medication.Medication_ID = PatientMedication.Medication_TUID
          INNER JOIN User
		  ON User.User_ID = Dispensing.Primary_User_TUID
          WHERE Patient.Patient_ID = '" & intPatientID & "' ORDER BY DateTime_Dispensed ASC;"

        Dim dsmydataset As DataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsmydataset.Tables(0).Rows
            frmPatientInfo.CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), dr(1), dr(2), dr(3), dr(4) & " " & dr(5), dr(6), "")
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:DispenseHistoryByDrugName  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/14/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: The purpose of this subroutine is to gather
    '/*     and display the entire dispense history of a single patient
    '/*     sorted by the medication name
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
    '/*  Alexander Beasecker  03/14/21	  Initial creation of the code      */
    '/*********************************************************************/
    Public Sub DispenseHistoryByDrugName(ByRef intPatientID As Integer)
        Dim Strdatacommand As String = "SELECT trim(Drug_Name,' '), Strength, PatientMedication.Type, Amount_Dispensed,User.User_Last_Name,User.User_First_Name, DateTime_Dispensed   
          FROM Dispensing 
          INNER JOIN PatientMedication
          On PatientMedication.PatientMedication_ID = Dispensing.PatientMedication_TUID
          INNER JOIN Patient
          On PatientMedication.Patient_TUID = Patient.Patient_ID
          INNER JOIN Medication
          On Medication.Medication_ID = PatientMedication.Medication_TUID
          INNER JOIN User
		  ON User.User_ID = Dispensing.Primary_User_TUID
          WHERE Patient.Patient_ID = '" & intPatientID & "' ORDER BY Trim(Drug_Name,' ') ASC;"

        Dim dsmydataset As DataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsmydataset.Tables(0).Rows
            frmPatientInfo.CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), dr(1), dr(2), dr(3), dr(4) & " " & dr(5), dr(6), "")
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:DispenseHistoryByStrength  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/14/21								  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: The purpose of this subroutine is to gather
    '/*     and display the entire dispense history of a single patient
    '/*     sorted by the medication strength
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
    '/*  Alexander Beasecker  03/14/21	  Initial creation of the code      */
    '/*********************************************************************/
    Public Sub DispenseHistoryByStrength(ByRef intPatientID As Integer)
        Dim Strdatacommand As String = "SELECT trim(Drug_Name,' '), Strength, PatientMedication.Type, Amount_Dispensed,User.User_Last_Name,User.User_First_Name, DateTime_Dispensed   
          FROM Dispensing 
          INNER JOIN PatientMedication
          On PatientMedication.PatientMedication_ID = Dispensing.PatientMedication_TUID
          INNER JOIN Patient
          On PatientMedication.Patient_TUID = Patient.Patient_ID
          INNER JOIN Medication
          On Medication.Medication_ID = PatientMedication.Medication_TUID
          INNER JOIN User
		  ON User.User_ID = Dispensing.Primary_User_TUID
          WHERE Patient.Patient_ID = '" & intPatientID & "' ORDER BY CAST(Strength as INTEGER);"

        Dim dsmydataset As DataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsmydataset.Tables(0).Rows
            frmPatientInfo.CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), dr(1), dr(2), dr(3), dr(4) & " " & dr(5), dr(6), "")
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:DispenseHistoryByType  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   03/14/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: The purpose of this subroutine is to gather
    '/*     and display the entire dispense history of a single patient
    '/*     sorted by the type of the dispensed med
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
    '/*  Alexander Beasecker  03/14/21	 Initial creation of the code      */
    '/*********************************************************************/
    Public Sub DispenseHistoryByType(ByRef intPatientID As Integer)
        Dim Strdatacommand As String = "SELECT trim(Drug_Name,' '), Strength, PatientMedication.Type, Amount_Dispensed,User.User_Last_Name,User.User_First_Name, DateTime_Dispensed   
          FROM Dispensing 
          INNER JOIN PatientMedication
          On PatientMedication.PatientMedication_ID = Dispensing.PatientMedication_TUID
          INNER JOIN Patient
          On PatientMedication.Patient_TUID = Patient.Patient_ID
          INNER JOIN Medication
          On Medication.Medication_ID = PatientMedication.Medication_TUID
          INNER JOIN User
		  ON User.User_ID = Dispensing.Primary_User_TUID
          WHERE Patient.Patient_ID = '" & intPatientID & "' ORDER BY PatientMedication.Type;"

        Dim dsmydataset As DataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsmydataset.Tables(0).Rows
            frmPatientInfo.CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), dr(1), dr(2), dr(3), dr(4) & " " & dr(5), dr(6), "")
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:DispenseHistoryByQuantity  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	  03/14/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: The purpose of this subroutine is to gather
    '/*     and display the entire dispense history of a single patient
    '/*     sorted by the quantity that was dispensed 
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
    '/*  Alexander Beasecker  03/14/21	 Initial creation of the code      */
    '/*********************************************************************/
    Public Sub DispenseHistoryByQuantity(ByRef intPatientID As Integer)
        Dim Strdatacommand As String = "SELECT trim(Drug_Name,' '), Strength, PatientMedication.Type, Amount_Dispensed,User.User_Last_Name,User.User_First_Name, DateTime_Dispensed   
          FROM Dispensing 
          INNER JOIN PatientMedication
          On PatientMedication.PatientMedication_ID = Dispensing.PatientMedication_TUID
          INNER JOIN Patient
          On PatientMedication.Patient_TUID = Patient.Patient_ID
          INNER JOIN Medication
          On Medication.Medication_ID = PatientMedication.Medication_TUID
          INNER JOIN User
		  ON User.User_ID = Dispensing.Primary_User_TUID
          WHERE Patient.Patient_ID = '" & intPatientID & "' ORDER BY CAST(Amount_Dispensed as INTEGER);"

        Dim dsmydataset As DataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsmydataset.Tables(0).Rows
            frmPatientInfo.CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), dr(1), dr(2), dr(3), dr(4) & " " & dr(5), dr(6), "")
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:DispenseHistoryByDispensingUser  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	 03/14/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: The purpose of this subroutine is to gather
    '/*     and display the entire dispense history of a single patient
    '/*     sorted by the user who dispensed the medication by last name
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
    '/*  Alexander Beasecker  03/14/21	 Initial creation of the code      */
    '/*********************************************************************/
    Public Sub DispenseHistoryByDispensingUser(ByRef intPatientID As Integer)
        Dim Strdatacommand As String = "SELECT trim(Drug_Name,' '), Strength, PatientMedication.Type, Amount_Dispensed,User.User_Last_Name,User.User_First_Name, DateTime_Dispensed   
          FROM Dispensing 
          INNER JOIN PatientMedication
          On PatientMedication.PatientMedication_ID = Dispensing.PatientMedication_TUID
          INNER JOIN Patient
          On PatientMedication.Patient_TUID = Patient.Patient_ID
          INNER JOIN Medication
          On Medication.Medication_ID = PatientMedication.Medication_TUID
          INNER JOIN User
		  ON User.User_ID = Dispensing.Primary_User_TUID
          WHERE Patient.Patient_ID = '" & intPatientID & "' ORDER BY User.User_Last_Name, User.User_First_Name;"

        Dim dsmydataset As DataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsmydataset.Tables(0).Rows
            frmPatientInfo.CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), dr(1), dr(2), dr(3), dr(4) & " " & dr(5), dr(6), "")
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:DispenseHistoryByDispenseDateAndTime  */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	  03/14/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: The purpose of this subroutine is to gather
    '/*     and display the entire dispense history of a single patient 
    '/*     sorted by date and time
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
    '/*  Alexander Beasecker 03/14/21	  Initial creation of the code      */
    '/*********************************************************************/
    Public Sub DispenseHistoryByDispenseDateAndTime(ByRef intPatientID As Integer)
        Dim Strdatacommand As String = "SELECT trim(Drug_Name,' '), Strength, PatientMedication.Type, Amount_Dispensed,User.User_Last_Name,User.User_First_Name, DateTime_Dispensed   
          FROM Dispensing 
          INNER JOIN PatientMedication
          On PatientMedication.PatientMedication_ID = Dispensing.PatientMedication_TUID
          INNER JOIN Patient
          On PatientMedication.Patient_TUID = Patient.Patient_ID
          INNER JOIN Medication
          On Medication.Medication_ID = PatientMedication.Medication_TUID
          INNER JOIN User
		  ON User.User_ID = Dispensing.Primary_User_TUID
          WHERE Patient.Patient_ID = '" & intPatientID & "' ORDER BY DateTime_Dispensed ASC;"

        Dim dsmydataset As DataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsmydataset.Tables(0).Rows
            frmPatientInfo.CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), dr(1), dr(2), dr(3), dr(4) & " " & dr(5), dr(6), "")
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
        frmDispense.cmbMedications.Items.Clear()
        Dim Strdatacommand As String
        ' Currently the medication display is appending the RXCUI Number on too the medication
        ' name, as searching by name alone could cause problems if medication names can repeat
        Strdatacommand = "SELECT Drug_Name,RXCUI_ID FROM PatientMedication " &
        "INNER JOIN Medication on Medication.Medication_ID = PatientMedication.Medication_TUID " &
        "INNER JOIN Patient on Patient.Patient_ID = PatientMedication.Patient_TUID " &
        "WHERE Patient.Patient_ID = '" & intPatientMRN & "' AND PatientMedication.Active_Flag = '1'"

        Dim dsMedicationDataSet As DataSet = New DataSet
        dsMedicationDataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)
        'add medication name and RXCUI to listbox
        For Each dr As DataRow In dsMedicationDataSet.Tables(0).Rows
            frmDispense.cmbMedications.Items.Add(dr(0) & "--" & dr(1))
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
        frmDispense.cmbMethod.Items.Clear()
        frmDispense.cmbDosage.Items.Clear()

        'get selected medication
        Dim strMedicationRXCUI As String = frmDispense.cmbMedications.SelectedItem
        'split out the RXCUI and name
        Dim strArray() As String
        strArray = strMedicationRXCUI.Split("--")
        strMedicationRXCUI = strArray(2)
        'select medication type and strength for the selected medication using rxcui 
        Dim Strdatacommand As String
        Strdatacommand = "SELECT PatientMedication.Type, Strength FROM PatientMedication " &
            "INNER JOIN Medication on Medication.Medication_ID = PatientMedication.Medication_TUID " &
            "WHERE RXCUI_ID = '" & strMedicationRXCUI & "' AND PatientMedication.Active_Flag = '1'"

        'make dataset and call the sql method
        Dim dsMedicationInformation As DataSet = New DataSet
        dsMedicationInformation = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        'insert the method and dosage into comboboxes
        frmDispense.cmbMethod.Items.Add(dsMedicationInformation.Tables(0).Rows(0)(0))
        frmDispense.cmbMethod.SelectedItem = dsMedicationInformation.Tables(0).Rows(0)(0)

        frmDispense.cmbDosage.Items.Add(dsMedicationInformation.Tables(0).Rows(0)(1))
        frmDispense.cmbDosage.SelectedItem = dsMedicationInformation.Tables(0).Rows(0)(1)
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME:SplitMedicationString  */
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
        Dim intPatientMedicationDatabaseID As Integer
        Dim intDrawerMedicationID As Integer
        Dim intDrawerNumber As Integer
        Dim intDrawerTUID As Integer
        Dim dtmAdhocTime As String = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")

        'using RXCUI get database ID for medication
        strbSQLcommand.Append("SELECT Medication_ID FROM Medication WHERE RXCUI_ID = '" & strMedicationID & "'")
        intMedID = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)

        intPatientID = intPatientMRN

        'clear string builder using medID and PatientID get the quantity of the prescribed medication
        strbSQLcommand.Clear()
        strbSQLcommand.Append("SELECT Quantity FROM PatientMedication WHERE Medication_TUID = '" & intMedID & "' AND Patient_TUID = '" & intPatientID & "' AND PatientMedication.Active_Flag = '1'")
        intPrescribedQuantity = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)


        'clear string builder and set up sql to get the patientMedication_ID primary key from patient medication table to use in
        'the dispensing table as a foreign key
        strbSQLcommand.Clear()
        strbSQLcommand.Append("SELECT PatientMedication_ID FROM PatientMedication WHERE Medication_TUID = '" & intMedID & "' AND Patient_TUID = '" & intPatientID & "' AND PatientMedication.Active_Flag = '1'")
        intPatientMedicationDatabaseID = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)

        'clear string builder and set up sql statement to decrease drawer amount
        strbSQLcommand.Clear()
        strbSQLcommand.Append("SELECT Quantity FROM DrawerMedication WHERE Medication_TUID  = '" & intMedID & "' AND DrawerMedication.Active_Flag = '1'")
        intPrescribedQuantity = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)
        intPrescribedQuantity = intPrescribedQuantity - frmDispense.txtQuantity.Text
        strbSQLcommand.Clear()
        strbSQLcommand.Append("UPDATE DrawerMedication SET Quantity = '" & intPrescribedQuantity & "' WHERE Medication_TUID = '" & intMedID & "' AND DrawerMedication.Active_Flag = '1'")
        CreateDatabase.ExecuteInsertQuery(strbSQLcommand.ToString)

        'clear string builder and set up sql statement to insert into dispense history
        strbSQLcommand.Clear()
        strbSQLcommand.Append("SELECT DrawerMedication_ID From DrawerMedication WHERE Medication_TUID = '" & intMedID & "' AND DrawerMedication.Active_Flag = '1'")
        intDrawerMedicationID = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)
        strbSQLcommand.Clear()
        strbSQLcommand.Append("INSERT INTO Dispensing(PatientMedication_TUID, Primary_User_TUID, Approving_User_TUID, DateTime_Dispensed, Amount_Dispensed, DrawerMedication_TUID) ")
        strbSQLcommand.Append("VALUES('" & intPatientMedicationDatabaseID & "','1','1','" & dtmAdhocTime & "','" & frmDispense.txtQuantity.Text & "','" & intDrawerMedicationID & "')")
        CreateDatabase.ExecuteInsertQuery(strbSQLcommand.ToString)


        strbSQLcommand.Clear()
        strbSQLcommand.Append("SELECT Drawers_TUID FROM DrawerMedication WHERE Medication_TUID = '" & intMedID & "' AND DrawerMedication.Active_Flag = '1'")
        intDrawerTUID = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)
        strbSQLcommand.Clear()
        strbSQLcommand.Append("SELECT Drawer_Number FROM Drawers WHERE Drawers_ID = '" & intDrawerTUID & "' AND Drawers.Active_Flag = '1'")
        intDrawerNumber = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)
        CartInterfaceCode.OpenOneDrawer(intDrawerNumber)
    End Sub

End Module

