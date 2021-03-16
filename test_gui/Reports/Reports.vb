Module Reports
    '/*******************************************************************/
    '/*                   FILE NAME:  Reports.vb                        */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*                   WRITTEN BY:  Eric R. LaVoie   		        */
    '/*		         DATE CREATED: January 25, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                */
    '/*											                        */
    '/* This module will                                                */
    '/*******************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			    */
    '/*                                                    (NONE)	    */
    '/*******************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                */
    '/*                          (NOTHING)					            */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:								                */
    '/*											                        */
    '/* the program will invoke this module on load. Individual         */
    '/* functions will be invoked separately by the forms that allow    */
    '/* items to be printed. From there, the appropriate office interop */
    '/* application will be invoked.                                    */
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
    '/*  WHO            WHEN        WHAT								*/
    '/*  Eric LaVoie    1/25/2021   Initial creation                    */
    '/*******************************************************************/
    Enum Reports
        Adhoc = 0
        Discrepancies = 1
        DispensedMeds = 2
        DispensedNarc = 3
        Override = 4
    End Enum

    '/*********************************************************************/
    '/*                   FUNCTION NAME:  					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Eric LaVoie           		         */   
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
    '/*                                                                     
    '/*********************************************************************/
    Function getSelectedReport(intSelectedIndex As Integer) As List(Of String)
        Dim arrData As ArrayList = New ArrayList
        Dim lstOfDataValues As List(Of String) = New List(Of String)
        'Determine which combo box index was selected
        Dim strReport As String = ""
        'select statement that evaluates the selected index with the report that 
        'the user requested to be generated
        'this select case will be updated in the future to provide more
        'assignments, (e.g. strReport may be changed to strSQLCommand and assign
        'the necessary sql statement to query the needed table)
        Select Case intSelectedIndex
            Case Reports.Adhoc : strReport = "Ad hoc Orders"

            Case Reports.Discrepancies : strReport = "Discrepancies"

            Case Reports.DispensedMeds : strReport = "Dispensed Meds"

            Case Reports.DispensedNarc : strReport = "Dispensed Narcotics"

            Case Reports.Override : strReport = "Overrides"

        End Select
        Dim intColumnCount As Integer = 0
        Dim intRowCount As Integer = 0
        GatherDataFromDatabaseTable(intColumnCount, intRowCount, lstOfDataValues)
        Return lstOfDataValues
        ' this is used only if the user wants to save the report
        'GenerateReportToWord(strReport, intColumnCount, intRowCount, lstOfDataValues)
        'Return arrData
    End Function

    '/*********************************************************************/
    '/*                   FUNCTION NAME:  					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Eric LaVoie           		         */   
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
    '/*                                                                     
    '/*********************************************************************/
    Sub GatherDataFromDatabaseTable(ByRef intColumnCount As Integer, ByRef intRowCount As Integer, ByRef lstOfDataValues As List(Of String))
        'call the execute scalar query function with a sql command that determines the number of fields in the table
        intColumnCount = CreateDatabase.ExecuteScalarQuery("Select Count(name) from PRAGMA_TABLE_INFO('Rooms');")
        'call the execute scalar query function with a sql command that determines the number of records in the table
        intRowCount = CreateDatabase.ExecuteScalarQuery("Select Count(*) From Rooms;")

        Dim dsDataset As DataSet
        dsDataset = CreateDatabase.ExecuteSelectQuery("Select * from Rooms;")
        For Each row As DataRow In dsDataset.Tables(0).Rows
            For Each item As Object In row.ItemArray
                If IsDBNull(item) Then
                    lstOfDataValues.Add("")
                Else
                    lstOfDataValues.Add(item.ToString)
                End If

            Next
        Next
        ' here we have to add in the data to a datagridview
    End Sub

End Module
