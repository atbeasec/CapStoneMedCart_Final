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
'/*(none)                                                          	*/
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

	'/*******************************************************************/
	'/*                   Subroutine NAME:        GetDrugRXCUI		    */
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 3, 2021		            */
	'/*******************************************************************/
	'/*  SUBROUTINE PURPOSE:									      	*/
	'/*	The purpose of this subroutine is to get the medication rxcui   */ 
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
	Sub getDrugRXCUI()

		ExecuteSelectQuery("SELECT RXCUI_ID, Drug_Name, Dosage, Type FROM Medication ORDER BY ASCEND")

	End Sub

	'/*******************************************************************/
	'/*                  Subroutine NAME:        GetMedication		    */
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 3, 2021		            */
	'/*******************************************************************/
	'/*  SUBROUTINE PURPOSE:									      	*/
	'/*	The purpose of this subroutine is to get the medication detail from */ 
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
	Sub getMedication()

		ExecuteSelectQuery("SELECT * FROM Medication")

	End Sub

	'/*******************************************************************/
	'/*                   Subroutine NAME:        GetDrugInteractions	*/
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 5, 2021		            */
	'/*******************************************************************/
	'/*  Subroutine PURPOSE:									      	*/
	'/*	The purpose of this subroutine is to get the drug interaction   */ 
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
	Sub GetDrugInteraction()
		ExecuteSelectQuery("SELECT * FROM Drug_Interactions")
	End Sub


	'/*******************************************************************/
	'/*                  Subroutine NAME:     CompareDrugInteractions	*/
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 5, 2021		            */
	'/*******************************************************************/
	'/*  Subroutine PURPOSE:									        */
	'/*	The purpose of this subroutine is to get the drug interaction   */ 
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
	'/*  Drug1 - Integer that holds the first medication numebr,		*/
	'/* Drug2 - Integer that holds the second medication number,        */
	'/* Severity - String that holds the severity in the database,      */
	'/* Description - String that holds the description information from*/
	'/* the database, ActiveFlag - holds the integer value of the       */
	'/* Active_Flag column.                                             */
	'/*******************************************************************/
	'/* SAMPLE INVOCATION:												*/
	'/*																	*/
	'/* CompareDrugInteractions()							            */
	'/*******************************************************************/
	'/*  LOCAL VARIABLE LIST (Alphabetically):							*/
	'/*																	*/
	'/*  dtCompareDrugInteractions - dataset that holds the information */
	'/* in each parameter in the subroutine.                            */
	'/*******************************************************************/
	'/* MODIFICATION HISTORY:											*/
	'/*																	*/
	'/*  WHO   WHEN     WHAT											*/
	'/*  ---   ----     ------------------------------------------------*/
	'/*  Cody Russell 02/5/21  Initial creation of the code	        	*/
	'/* Cody Russell  02/6/21  Altered this function so that it will    */
	'/* hold data in a reader than compare from the database it pulls.  */
	'/* Cody Russell  02/8/21 Altered the subroutine more to make it more*/
	'/* simple and easier to read and understand.                       */
	'/*******************************************************************/
	Sub CompareDrugInteractions(Drug1 As Integer, Drug2 As Integer, Severity As String, Description As String,
																		ActiveFlag As Integer)
		'Create a dataset to hold database data
		Dim dtCompareDrugInteractions As DataSet

		'Select the specific table and the data in each column, filling a dataset through the different parameters
		dtCompareDrugInteractions = ExecuteSelectQuery("SELECT Medication_One_ID, Medication_Two_ID, Severity, Description,
                                            Active_Flag FROM Drug_Interactions WHERE Medication_One_ID ='" & Drug1 & "'
										    AND Medication_Two_ID = '" & Drug2 & "' AND Severity = '" & Severity &
											"'AND Description = '" & Description & "' AND Active_Flag = '" & ActiveFlag & "'")


		If (dtCompareDrugInteractions Is Nothing) Then

			'Send an insert sql statement to the database
			ExecuteInsertQuery("INSERT INTO Drug_Interactions(Medication_One_ID, Medication_Two_ID, 
                            Severity, Description, Active_Flag)
                            VALUES('" & Drug1 & "','" & Drug2 & "','" &
								Severity & "','" & Description & "','" & ActiveFlag & "')")

		Else
			'Send an update sql statement to the database
			ExecuteScalarQuery("UPDATE Drug_Interactions SET Severity = '" & Severity & "', Description = '" & Description & "', Active_Flag = '" & ActiveFlag &
						   "'WHERE Medication_One_ID = '" & Drug1 & "' AND Medication_Two_ID = '" & Drug2 & "';")

			'Clear the dataset after it is sent to the database
			dtCompareDrugInteractions.Clear()
		End If
	End Sub

	'/*******************************************************************/
	'/*                  Subroutine NAME:     CompareMedications    	*/
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 9, 2021		            */
	'/*******************************************************************/
	'/*  Subroutine PURPOSE:									        */
	'/*	The purpose of this subroutine is to get the medication         */ 
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
	'/*																	*/
	'/*																	*/
	'/*																	*/
	'/*																	*/
	'/*																	*/
	'/*******************************************************************/
	'/* SAMPLE INVOCATION:												*/
	'/*																	*/
	'/* CompareMedications()	     						            */
	'/*******************************************************************/
	'/*  LOCAL VARIABLE LIST (Alphabetically):							*/
	'/*																	*/
	'/*  dtCompareDrugInteractions - dataset that holds the information */
	'/* in each parameter in the subroutine.                            */
	'/*******************************************************************/
	'/* MODIFICATION HISTORY:											*/
	'/*																	*/
	'/*  WHO   WHEN     WHAT											*/
	'/*  ---   ----     ------------------------------------------------*/
	'/*  Cody Russell 02/9/21  Initial creation of the code	        	*/
	'/*******************************************************************/
	Sub CompareMedications(DrugName As String, RXCUID As Integer, ControlledFlag As Integer, NarcoticFlag As Integer,
								 Barcode As Integer, Type As String, Strength As Integer, ActiveFlag As Integer)

		'Create a dataset to hold database data
		Dim dtMedications As DataSet

		'Select the specific table and the data in each column, filling a dataset through the different parameters
		ExecuteSelectQuery("SELECT Drug_Name, RXCUI_ID, Controlled_Flag, Narcotic_Flag, Barcode, Type, Strength, Active_Flag
                           Active_Flag FROM Drug_Interactions WHERE Drug_Name ='" & DrugName & "'
						   AND RXCUI_ID = '" & RXCUID & "' AND Controlled_Flag = '" & ControlledFlag &
						  "'AND Narcotic_Flag = '" & NarcoticFlag & "' AND Barcode = '" & Barcode & "' AND Type = '" & Type &
						  "'AND Strength = '" & Strength & "'AND Active_Flag = '" & ActiveFlag & "'")

		If (dtMedications Is Nothing) Then

			'Send an insert sql statement to the database
			ExecuteInsertQuery("INSERT INTO Medications(DrugName, RXCUI_ID, Controlled_Flag, Narcotic_Flag, Barcode, Type, 
                            Strength, Active_Flag) VALUES('" & DrugName & "','" & RXCUID & "','" & ControlledFlag & "','" & NarcoticFlag &
							"','" & Barcode & "','" & Type & "','" & Strength & "','" & ActiveFlag & "')")

		Else

			'Send an update sql statement to the database
			ExecuteScalarQuery("UPDATE Medications SET Controlled_Flag = '" & ControlledFlag & "', Narcotic_Flag = '" & NarcoticFlag &
							   "', Barcode = '" & Barcode & "', Type = '" & Type & "', Strength = '" & Strength &
							   "', Active_Flag = '" & ActiveFlag & "'WHERE RXCUI_ID = '" & RXCUID & "';")

			'Clear the dataset after it is sent to the database
			dtMedications.Clear()
		End If

	End Sub
End Module
