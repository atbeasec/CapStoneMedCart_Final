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
    '/*  Alexander Beasecker  02/01/2021  Initial creation of the code     */
    '/*********************************************************************/

    Public Sub InsertAdHoc(ByRef intMedicationID As Integer, ByRef intPatientID As Integer, ByRef intUserID As Integer,
                           ByRef intAmount As Integer)

        Dim Strdatacommand As String
        Dim StrMedicationDrawerID As String


        Strdatacommand = "SELECT DrawerMedication_ID FROM DrawerMedication 
                            INNER JOIN AdHocOrder
                            ON AdHocOrder.Medication_TUID = DrawerMedication.Medication_TUID
                            WHERE DrawerMedication.Medication_TUID = '" & intMedicationID & "'"


        StrMedicationDrawerID = ExecuteScalarQuery(Strdatacommand)

        Dim dtmAdhocTime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

        Strdatacommand = "INSERT INTO AdHocOrder(Medication_TUID, Patient_TUID, 
                            User_TUID, Amount, DrawerMedication_TUID, DateTime)
                            VALUES('" & intMedicationID & "','" & intPatientID & "','" &
                            intUserID & "','" & intAmount & "','" & StrMedicationDrawerID & "','" & dtmAdhocTime & "')"


        CreateDatabase.ExecuteInsertQuery(Strdatacommand)

    End Sub

    Public Sub GetAllMedicationsForListbox()
        Dim Strdatacommand As String
        Strdatacommand = "SELECT Drug_Name from Medication"

        Dim dsMedicationDataSet As DataSet = New DataSet
        dsMedicationDataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsMedicationDataSet.Tables(0).Rows
            frmAdHockDispense.cmbMedications.Items.Add(dr(0))
        Next
    End Sub

    Public Sub SetMedicationProperties()

        frmAdHockDispense.cmbMethod.Items.Clear()
        frmAdHockDispense.cmbDosage.Items.Clear()

        Dim strMedicationName As String = frmAdHockDispense.cmbMedications.SelectedItem

        Dim Strdatacommand As String
        Strdatacommand = "SELECT Type, Strength From Medication WHERE Drug_Name = '" & strMedicationName & "'"

        Dim dsMedicationInformation As DataSet = New DataSet
        dsMedicationInformation = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        frmAdHockDispense.cmbMethod.Items.Add(dsMedicationInformation.Tables(0).Rows(0)(0))
        frmAdHockDispense.cmbMethod.SelectedItem = dsMedicationInformation.Tables(0).Rows(0)(0)

        frmAdHockDispense.cmbDosage.Items.Add(dsMedicationInformation.Tables(0).Rows(0)(1))
        frmAdHockDispense.cmbDosage.SelectedItem = dsMedicationInformation.Tables(0).Rows(0)(1)

    End Sub

    Public Sub PopulatePatientsAdhoc()
        frmAdHockDispense.cmbPatientName.Items.Clear()

        Dim Strdatacommand As String
        Strdatacommand = "SELECT Patient_First_Name, Patient_Last_Name from Patient Order By Patient_Last_Name, Patient_First_Name"


        Dim dsPatientRecords As DataSet = New DataSet
        dsPatientRecords = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        For Each dr As DataRow In dsPatientRecords.Tables(0).Rows
            frmAdHockDispense.cmbPatientName.Items.Add(dr(0) & " " & dr(1))
        Next

    End Sub
End Module
