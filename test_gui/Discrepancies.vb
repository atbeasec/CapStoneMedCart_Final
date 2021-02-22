Imports System.Text

Module Discrepancies
    '/*******************************************************************/
    '/*                   FILE NAME: Discrepancies.vb                   */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*              WRITTEN BY:  Alexander Beasecker   		        */
    '/*		         DATE CREATED: January 25, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                */
    '/*											                        */
    '/* This module is responsible the handling of the discrepancies in */
    '/* in the medications that are stored in the drawers. It handles   */
    '/* the recording of all information for the discrepancy table in   */
    '/* the database, medication generic and brand name, the dosage of  */
    '/* the medication, the amount that is missing, the name of the     */
    '/* nurse who dispensed the medication, the patient name who was to */
    '/* recieve the dispenced medication, the date and the time of the  */
    '/* discrepancy.                                                    */
    '/* It populates the discrepancies table with all current           */
    '/* discrepancies. and it handles the resolving of discrepancies.   */
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
    '/* the program will invoke this module in three differnet ways.    */
    '/* The first method of this module to be invoked is when the       */
    '/* dispensed medicaiton is returned to the drawer and the current  */
    '/* amount is recorded. If the expected value and the reported value are */ 
    '/* not correct this module will be invoked and it will record a    */
    '/* discrepancy.                                                    */
    '/* the second method this is invoked is when the user wants to view*/
    '/* and display all current discrepancies, it will call this module to */
    '/* display the information.                                        */
    '/* the last way this can be invoked is when the user chooses to    */
    '/* resolve a discrepancy, this module will be invoked to clear     */
    '/* the discrepancy.                                                */
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
    '/*                   FUNCTION NAME: CheckSystemCountVSActualCount    */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		         */   
    '/*		         DATE CREATED: 		   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								   */             
    '/*											   */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*											   */                     
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
    '/*  AB    2/22/2021 Initial creation
    '/*********************************************************************/

    Public Function CheckSystemCountVSActualCount(ByRef intSystemCount As Integer, ByRef intActualCount As Integer)
        Dim blnCountsEqual As Boolean = False

        If intSystemCount = intActualCount Then
            blnCountsEqual = True
        Else
            blnCountsEqual = False
        End If

        Return blnCountsEqual
    End Function


    Private Sub CreateDiscrepancy(ByRef intDrawerNumber As Integer, ByRef intBinNumber As Integer, ByRef strMedicationName As String,
                                  ByRef intExpectedCount As Integer, ByRef intActualCount As Integer, ByRef intPrimaryUserID As Integer,
                                  ByRef intApprovingUserID As Integer)
        Dim intDrawerTUID As Integer
        Dim intMedicationTUID As Integer

        If CheckSystemCountVSActualCount(intExpectedCount, intActualCount).Equals(False) Then

            Dim dtmAdhocTime As String = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
            InsertDiscrepancy(intDrawerTUID, intMedicationTUID, intExpectedCount, intActualCount, intPrimaryUserID, intApprovingUserID, dtmAdhocTime)
        Else
            MessageBox.Show("No Discrepancy recorded, counts are equal")
        End If
    End Sub


    Private Sub InsertDiscrepancy(ByRef intDrawerTUID As Integer, ByRef intBinNumber As Integer, ByRef intMedicationID As Integer,
                                  ByRef intExpectedCount As Integer, ByRef intActualCount As Integer, ByRef intPrimaryUserID As Integer,
                                  ByRef intApprovingUserID As Integer, ByRef dtmDateTimeEntered As String)

        Dim strbSQL As StringBuilder = New StringBuilder
        strbSQL.Append("INSERT INTO Discrepancies(Drawer_TUID, Medication_TUID, Expected_Count, Actual_Count, Primary_User_TUID, Approving_User_TUID, DateTime_Entered) ")
        strbSQL.Append("VALUES(")
    End Sub
End Module
