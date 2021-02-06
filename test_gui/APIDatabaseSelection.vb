'Import necessary libraries to connect to the SQLite database
Imports System.Data.SQLite
Imports System.IO

'/*******************************************************************/
'/*                   FILE NAME: APIDatabaseSelection.vb            */
'/*******************************************************************/
'/*                 PART OF PROJECT: Med_Cart				        */
'/*******************************************************************/
'/*                   WRITTEN BY: Cody Russell       		        */
'/*		         DATE CREATED: February 3, 2021			            */
'/*******************************************************************/
'/*  MODULE PURPOSE:								                */
'/*											                        */
'/* This module will allow the application to pull information      */
'/* from the database and input the information into the necessary  */  
'/* form textboxes.                                                 */
'/*******************************************************************/
'/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			    */
'/*                                                    (NONE)	    */
'/*******************************************************************/
'/*  ENVIRONMENTAL RETURNS:							                */
'/*                          (NOTHING)					            */
'/*******************************************************************/
'/* SAMPLE INVOCATION:								                */
'/*											                        */
'/*                                                                 */
'/*******************************************************************/
'/*  GLOBAL VARIABLE LIST (Alphabetically):			                */
'/*DBCmd - Stores the SQL commands 									*/
'/*DBCONNECTIon - Stores the information to connect to the database,*/
'/*strSQLCmd - stores  string as a sql command                      */
'/*strDBNAME - Stores the database name							    */
'/*strDBPath - Stores the database path						        */
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
'/*  WHO            WHEN        WHAT								*/
'/*  Cody Russell    02/3/21   Initial creation                     */
'/*******************************************************************/
Module APIDatabaseSelection

	Dim DBCONNECTION As SQLiteConnection
	Dim DBCmd As SQLiteCommand
	Const strDBName As String = "Medication_Cart_System"
	Dim strSQLCmd As String
	Dim strDBPATH As String = My.Application.Info.DirectoryPath & "\" & strDBName & ".db"

	'/*******************************************************************/
	'/*                   FUNCTION NAME:        GetDrugRXCUI		    */
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 5, 2021		            */
	'/*******************************************************************/
	'/*  FUNCTION PURPOSE:									      		*/
	'/*	The purpose of this function is to get the medication rxcui     */ 
	'/* number from the database.                                       */
	'/*******************************************************************/
	'/*  CALLED BY:   	      											*/
	'/*  (NONE)															*/
	'/*******************************************************************/
	'/*  CALLS:															*/
	'/*  (NONE)															*/
	'/*******************************************************************/
	'/*  PARAMETER LIST (In Parameter Order):							*/
	'/*																	*/
	'/*  (None)															*/
	'/*******************************************************************/
	'/* SAMPLE INVOCATION:												*/
	'/*																	*/
	'/* GetDrugRXCUI()							        			    */
	'/*******************************************************************/
	'/*  LOCAL VARIABLE LIST (Alphabetically):							*/
	'/*																	*/
	'/*  (None)															*/
	'/*******************************************************************/
	'/* MODIFICATION HISTORY:											*/
	'/*																	*/
	'/*  WHO   WHEN     WHAT											*/
	'/*  ---   ----     ------------------------------------------------*/
	'/*  Cody Russell 02/5/21  Initial creation of the code	        	*/
	'/*******************************************************************/
	Function getDrugRXCUI()
		DBCONNECTION = New SQLiteConnection(strDBPATH)
		DBCONNECTION.Open()

		strSQLCmd = "SELECT Drug_Name, Dosage, Type FROM Drug_Interactions"
        Dim reader As SQLiteDataReader
        DBCmd.CommandText = strSQLCmd

        DBCONNECTION.Close()

    End Function

	'/*******************************************************************/
	'/*                   FUNCTION NAME:        GetMedication		    */
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 3, 2021		            */
	'/*******************************************************************/
	'/*  FUNCTION PURPOSE:									      		*/
	'/*	The purpose of this function is to get the medication detail from  */ 
	'/* the database.                                                   */
	'/*******************************************************************/
	'/*  CALLED BY:   	      											*/
	'/*  (NONE)															*/
	'/*******************************************************************/
	'/*  CALLS:															*/
	'/*  (NONE)															*/
	'/*******************************************************************/
	'/*  PARAMETER LIST (In Parameter Order):							*/
	'/*																	*/
	'/*  (None)															*/
	'/*******************************************************************/
	'/* SAMPLE INVOCATION:												*/
	'/*																	*/
	'/* GetMedication()							        			    */
	'/*******************************************************************/
	'/*  LOCAL VARIABLE LIST (Alphabetically):							*/
	'/*																	*/
	'/*  (None)															*/
	'/*******************************************************************/
	'/* MODIFICATION HISTORY:											*/
	'/*																	*/
	'/*  WHO   WHEN     WHAT											*/
	'/*  ---   ----     ------------------------------------------------*/
	'/*  Cody Russell 02/3/21  Initial creation of the code	        	*/
	'/*******************************************************************/
	Function getMedication()
		DBCONNECTION = New SQLiteConnection(strDBPATH)
		DBCONNECTION.Open()

		strSQLCmd = "SELECT Drug_Name, Dosage, Type FROM Medication"

		DBCmd.CommandText = strSQLCmd

		DBCONNECTION.Close()
	End Function

	Function GetMedicationInteraction()

	End Function
End Module
