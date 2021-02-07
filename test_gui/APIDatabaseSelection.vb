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

	Dim myDataReader As SQLiteDataReader


	'/*******************************************************************/
	'/*                   FUNCTION NAME:        GetDrugRXCUI		    */
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 3, 2021		            */
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
	'/*  Cody Russell 02/3/21  Initial creation of the code	        	*/
	'/*  Cody Russell 02/5/21  Made altercations to make more readable code */
	'/*******************************************************************/
	Function getDrugRXCUI()

		ExecuteSelectQuery("SELECT RXCUI_ID, Drug_Name, Dosage, Type FROM Medication")

	End Function

	'/*******************************************************************/
	'/*                   FUNCTION NAME:        GetMedication		    */
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 3, 2021		            */
	'/*******************************************************************/
	'/*  FUNCTION PURPOSE:									      		*/
	'/*	The purpose of this function is to get the medication detail from */ 
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
	'/*  Cody Russell 02/5/21  Made altercations to make more readable code  */
	'/*******************************************************************/
	Function getMedication()

		ExecuteSelectQuery("SELECT * FROM Medication")

	End Function

	'/*******************************************************************/
	'/*                   FUNCTION NAME:        GetDrugInteractions	    */
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 5, 2021		            */
	'/*******************************************************************/
	'/*  FUNCTION PURPOSE:									      		*/
	'/*	The purpose of this function is to get the drug interaction     */ 
	'/* details from the database.                                      */
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
	'/* GetDrugInteractions()							                */
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
	Function GetDrugInteraction()
		ExecuteSelectQuery("SELECT * FROM Drug_Interactions")
	End Function

	'/*******************************************************************/
	'/*                   FUNCTION NAME:        GetDrugInteractions	    */
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 5, 2021		            */
	'/*******************************************************************/
	'/*  FUNCTION PURPOSE:									      		*/
	'/*	The purpose of this function is to get the drug interaction     */ 
	'/* details from the database and compare the data.                 */
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
	'/* CompareDrugInteractions()							            */
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
	'/* Cody Russell  02/6/21  Altered this function so that it will    */
	'/* hold data in a reader than compare from the database it pulls.  */
	'/*******************************************************************/
	Function CompareDrugInteractions(Drug1 As String, Drug2 As String, Severity As String, Description As String
																				) As Boolean

		myDataReader = ExecuteSelectQuery("SELECT Medication_One_ID, Medication_Two_ID, Severity, Description,
                                            Active_Flag FROM Drug_Interactions WHERE Medication_One_ID ='" & Drug1 & "'
										    AND Medication_Two_ID = '" & Drug2 & "' AND Severity = '" & Severity &
											"'AND Description = '" & Description)


		
	End Function
End Module
