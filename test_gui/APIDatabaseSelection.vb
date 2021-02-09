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
'/*DBCmd - Stores the SQL commands for either creating the database or	*/
'/*	 or altering tables         									*/
'/*DBConn - Stores the information to connect to the database       */
'/*strCONNECTION - string that opens a connection to the database   */
'/*strDBPath - string that stores the database path					*/
'/*strApplicationPath - string that links to the path of the application */
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

	Dim strDBPath As String
	Public DBConn As SQLiteConnection
	Public DBCmd As SQLiteCommand
	Dim strCONNECTION As String
	Dim strApplicationPath As String = Application.StartupPath & "\config.app"

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

		ExecuteSelectQuery("SELECT RXCUI_ID, Drug_Name, Dosage, Type FROM Medication ORDER BY ASCEND")

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
	'/*                  Subroutine NAME:        GetDrugInteractions	*/
	'/*******************************************************************/
	'/*              WRITTEN BY:  	Cody Russell					    */
	'/*		         DATE CREATED: 	   February 5, 2021		            */
	'/*******************************************************************/
	'/*  Subroutine PURPOSE:									        */
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
	Sub CompareDrugInteractions(Drug1 As Integer, Drug2 As Integer, Severity As String, Description As String,
																		ActiveFlag As Integer)

		Dim dtCompareDrugInteractions As DataSet
		Dim strStatement As String

		dtCompareDrugInteractions = ExecuteSelectQuery("SELECT Medication_One_ID, Medication_Two_ID, Severity, Description,
                                            Active_Flag FROM Drug_Interactions WHERE Medication_One_ID ='" & Drug1 & "'
										    AND Medication_Two_ID = '" & Drug2 & "' AND Severity = '" & Severity &
											"'AND Description = '" & Description & "' AND Active_Flag = '" & ActiveFlag & "'")


		If (dtCompareDrugInteractions Is Nothing) Then

			ExecuteInsertQuery("INSERT INTO Drug_Interactions(Medication_One_ID, Medication_Two_ID, 
                            Severity, Description, Active_Flag)
                            VALUES('" & Drug1 & "','" & Drug2 & "','" &
								Severity & "','" & Description & "','" & ActiveFlag & "')")

		Else
			ExecuteScalarQuery("UPDATE Drug_Interactions SET Severity = '" & Severity & "', Description = '" & Description & "', Active_Flag = '" & ActiveFlag &
						   "'WHERE Medication_One_ID = '" & Drug1 & "' AND Medication_Two_ID = '" & Drug2 & "';")
			'Using reader As StreamReader = New StreamReader(strApplicationPath)
			'	strDBPath = reader.ReadLine
			'End Using
			'strCONNECTION = String.Format("Data Source = {0}", strDBPath)
			'DBConn = New SQLiteConnection(strCONNECTION)
			'strStatement = "UPDATE Drug_Interactions SET Severity = '" & Severity & "', Description = '" & Description & "', Active_Flag = '" & ActiveFlag &
			'			   "'WHERE Medication_One_ID = '" & Drug1 & "' AND Medication_Two_ID = '" & Drug2 & "';"

			'DBConn.Open()
			'DBCmd = New SQLiteCommand(strStatement, DBConn)
			'DBConn.Close()
			dtCompareDrugInteractions.Clear()
		End If
	End Sub
End Module
