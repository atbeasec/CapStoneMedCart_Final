Imports Microsoft.Office.Interop
Module Print
    '/*******************************************************************/
    '/*                   FILE NAME:  Print.vb                          */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*                   WRITTEN BY:  Eric R. LaVoie   		        */
    '/*		         DATE CREATED: January 25, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                */
    '/*											                        */
    '/* This module will send information to MS OFFICE in order to      */
    '/* br printed or be saved.                                         */
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
    '/*  Jordan Roberts 2/09/2021   Basic functionality implemented; 
    '/**    module can tell which combo box item from frmreport was selected
    '/*     and sub routines can create a document and table in word and
    '/*     open for viewing. Module is not wired to the database yet.
    '/*******************************************************************/

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
    Sub GenerateReportToWord(ByVal strItem As String, ByRef intColumnCount As Integer, ByRef intRowCount As Integer, ByRef lstOfDataValues As List(Of String))
        Dim aWordApplication As Word.Application
        Dim aWordDocument As Word.Document
        aWordApplication = New Word.Application
        'Open up the aWordApplication variable and modify some of the style preferences
        With aWordApplication
            .Visible = True
            aWordDocument = .Documents.Add()
            .Selection.Font.Size = 8
            .Selection.Font.Name = "Calibri"
            .ActiveWindow.View.TableGridlines = False
        End With

        CreateAndAddTableToWordForFormatting(aWordDocument, intColumnCount, intRowCount)
        Dim intToKeepTrackOfDataInList As Integer = 0

        'this loop will iterate through the lstOfDataValues list that holds each item of the database table
        'and send the data to the table in the Word document.
        For intRow As Integer = 1 To intRowCount
            For intColumn As Integer = 1 To intColumnCount
                aWordApplication.Selection.Tables.Item(1).Cell(intRow, intColumn).Range.Text = lstOfDataValues.Item(intToKeepTrackOfDataInList)
                intToKeepTrackOfDataInList += 1
            Next
        Next

    End Sub

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
    Sub CreateAndAddTableToWordForFormatting(ByRef aWordDoc As Word.Document, ByVal intColumnCount As Integer, ByVal intRowCount As Integer)
        Dim aTableWordDoc As Word.Table
        aTableWordDoc = aWordDoc.Tables.Add(aWordDoc.Range, intRowCount, intColumnCount)
        With aTableWordDoc
            .Range.ParagraphFormat.SpaceAfter = 6
            .Title = "Test Title"
            .AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow)
            .Style = "Plain Table 4"
            With .Borders
                .InsideLineStyle = Word.WdLineStyle.wdLineStyleNone
                .OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone
            End With
        End With
    End Sub
End Module
