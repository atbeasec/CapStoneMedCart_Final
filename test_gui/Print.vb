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
    Enum Reports
        Adhoc = 0
        Discrepancies = 1
        DispensedMeds = 2
        DispensedNarc = 3
        Override = 4
    End Enum
    Sub Main()

        Dim intSelectedIndex As Integer = test_gui.frmReport.cmbReports.SelectedIndex
        Dim strReport As String = ""
        Select Case intSelectedIndex
            Case Reports.Adhoc : strReport = "Ad hoc Orders"

            Case Reports.Discrepancies : strReport = "Discrepancies"

            Case Reports.DispensedMeds : strReport = "Dispensed Meds"

            Case Reports.DispensedNarc : strReport = "Dispensed Narcotics"

            Case Reports.Override : strReport = "Overrides"

        End Select
        GenerateReportToWord(strReport)
    End Sub

    Sub GatherDataFromDatabaseTable()



    End Sub

    Sub GenerateReportToWord(ByVal strItem As String)
        Dim aWordApplication As Word.Application
        Dim aWordDocument As Word.Document
        aWordApplication = New Word.Application
        With aWordApplication
            .Visible = True
            aWordDocument = .Documents.Add()
            .Selection.Font.Size = 10
            .Selection.Font.Name = "Calibri"
        End With

        CreateAndAddTableToWordForFormatting(aWordDocument)
        '  Dim strSQLQuery As String = "SELECT name FROM PRAGMA_TABLE_INFO('AdHocOrder');"

        '  Dim dsDataSetReturnValues As DataSet = CreateDatabase.ExecuteSelectQuery(strSQLQuery)

        aWordApplication.Selection.TypeText(strItem)
    End Sub

    Sub CreateAndAddTableToWordForFormatting(ByRef aWordDoc As Word.Document)
        Dim aTableWordDoc As Word.Table

        aTableWordDoc = aWordDoc.Tables.Add(aWordDoc.Range, 10, 7)
        With aTableWordDoc
            .Range.ParagraphFormat.SpaceAfter = 6
            .Title = "Test Title"
            .AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow)
            .Style = "Plain Table 4"
        End With

    End Sub
End Module
