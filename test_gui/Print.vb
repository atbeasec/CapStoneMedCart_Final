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
        Dim lstOfDataValues As List(Of String) = New List(Of String)
        'Determine which combo box index was selected
        Dim intSelectedIndex As Integer = test_gui.frmReport.cmbReports.SelectedIndex
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

        ' this is used only if the user wants to save the report
        'GenerateReportToWord(strReport, intColumnCount, intRowCount, lstOfDataValues)
    End Sub

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
