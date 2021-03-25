


Public Class frmReport

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
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateReportsList()


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
    '/*  WHO        WHEN        WHAT								      */             
    '/*  ---        ----        ------------------------------------------*/
    '/*  Eric L.    03/16/21    Initial creation of code                  */  
    '/*  BRH        03/21/21    Add narcotics wasted, add all wasted meds,
    '/*                         narcotic ad hoc orders, 
    '/*********************************************************************/
    Private Sub PopulateReportsList()

        Const STRDISCREPANCIES As String = "Discrepancies"
        Const STRDISPENSINGHISTORY As String = "Dispensed Medications"
        Const STRADHOCORDERS As String = "Ad Hoc Orders"
        Const STRNARCADHOCORDERS As String = "Narcotic Ad Hoc Orders"
        Const STRNARCOTICSDISPENSED As String = "Narcotics Dispensed"
        Const STRNARCOTICSWASTED As String = "Narcotics Wasted"
        Const STROVERRIDES As String = "Overrides"
        Const STRWASTES As String = "Wasted Medication"

        cmbReports.Items.Add(STRDISCREPANCIES)
        cmbReports.Items.Add(STRDISPENSINGHISTORY)
        cmbReports.Items.Add(STRADHOCORDERS)
        cmbReports.Items.Add(STRNARCADHOCORDERS)
        cmbReports.Items.Add(STRNARCOTICSDISPENSED)
        cmbReports.Items.Add(STRNARCOTICSWASTED)
        cmbReports.Items.Add(STROVERRIDES)
        cmbReports.Items.Add(STRWASTES)

    End Sub
    '/*******************************************************************/
    '/*          SUBROUTINE NAME:     btnGenerateReport_Click		    */
    '/*******************************************************************/
    '/*                   WRITTEN BY:  	Eric Lavoie					    */
    '/*		         DATE CREATED: 	   03/16/21							*/
    '/*******************************************************************/
    '/*  SUBROUTINE PURPOSE:											*/
    '/*	 The purpose of this subroutine is to generate the data for the */
    '/*  selected report into the datatable. If the user doesn't select */
    '/*  a report, the program will notify them and won't go on until a */
    '/*  report is created. Once a report is selected, it will call     */
    '/* getSelectedReport to get the data from the tables that were specified
    '/* from the user's selection. Then, the data is populated into the */
    '/* data table and made visible to the user.                        */
    '/*******************************************************************/
    '/*  CALLED BY:   	      											*/
    '/*  (None)								           					*/
    '/*******************************************************************/
    '/*  CALLS:															*/
    '/*  getSelectedReport()										    */
    '/*  PrintItemsToDataGrid()                                         */
    '/*******************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):							*/
    '/*																	*/
    '/*	 sender- object representing a control                          */
    '/*  e- eventargs indicating there is an event handle assigned      */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:												*/
    '/*																	*/
    '/*  btnGenerateReport_Click										*/
    '/*******************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):							*/
    '/*																	*/
    '/*  lstOfDataValues - Stores the list of items returned from the   */
    '/*                    tables relating to the user's report selection/
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:											*/
    '/*																	*/
    '/*  WHO	    WHEN        WHAT									*/
    '/*  ---        ----        ----------------------------------------*/
    '/*  Eric L.    03/16/21    Initial creation of code                */
    '/*  BRH        03/18/21    Added functionality for displaying the  */
    '/*                         Dispensed Narcotics on the form.        */
    '/*******************************************************************/
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Dim lstOfDataValues As List(Of String) = New List(Of String)



        dgvReport.Columns.Clear()
        dgvReport.Rows.Clear()

        If cmbReports.SelectedIndex < 0 Then
            MessageBox.Show("Please select a report from the drop down menu", "No Selected Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            lstOfDataValues = getSelectedReport(cmbReports.SelectedIndex)

            If lstOfDataValues.Count = 0 Then
                MessageBox.Show("There is nothing to report.")
            Else
                PrintItemsToDataGrid(lstOfDataValues)
            End If

            'this Is used only if the user wants to save the report
            'GenerateReportToWord(strReport, intColumnCount, intRowCount, lstOfDataValues)

            'dgvReport.Columns.Count.Equals(2)



            ' dgvReport.DataSource = lstOfDataValues

            ' Select Case cmbReports.SelectedItem
            'Case Reports.Adhoc : strReport = "Ad hoc Orders"

            'Case Reports.Discrepancies : strReport = "Discrepancies"

            'Case Reports.DispensedMeds : strReport = "Dispensed Meds"

            'Case cmbReports.SelectedItem.Equals("Narcotics Dispensed") 'Reports.DispensedNarc : strReport = "Dispensed Narcotics"
            'If cmbReports.SelectedItem.Equals("Narcotics Dispensed") Then
            '    dgvReport.Columns.Add(1, "Drug Name")
            '    dgvReport.Columns.Add(2, "Drug Type")
            '    dgvReport.Columns.Add(3, "Drug Strength")
            '    dgvReport.Columns.Add(4, "Amount Dispensed")
            '    dgvReport.Columns.Add(5, "Amount Remaining in Drawer")
            '    dgvReport.Columns.Add(6, "Date / Time Dispensed")
            '    dgvReport.Columns.Add(7, "Expiration Date")

            '    For i As Integer = 0 To lstOfDataValues.Count - 7 Step 7
            '        dgvReport.Rows.Add(lstOfDataValues.Item(i), lstOfDataValues.Item(i + 1), lstOfDataValues.Item(i + 2), lstOfDataValues.Item(i + 3), lstOfDataValues.Item(i + 4), lstOfDataValues.Item(i + 5), lstOfDataValues.Item(i + 6))
            '    Next
            'End If


            ' intColumnCount = ExecuteScalarQuery("Select Count(name) from PRAGMA_TABLE_INFO('Dispensing INNER JOIN ');")

            ' Case Reports.Override : strReport = "Overrides"

            ' End Select

            'For i As Integer = 0 To lstOfDataValues.Count - 3 Step 3
            '    dgvReport.Rows.Add(lstOfDataValues.Item(i), lstOfDataValues.Item(i + 1))
            'Next

            dgvReport.Visible = True

        End If

    End Sub

    '/*******************************************************************/
    '/*          SUBROUTINE NAME:     btnExportToExcel_Click		    */
    '/*******************************************************************/
    '/*                   WRITTEN BY:  	Eric Lavoie					    */
    '/*		         DATE CREATED: 	   03/24/21							*/
    '/*******************************************************************/
    '/*  SUBROUTINE PURPOSE:											*/
    '/*	 The purpose of this subroutine is to generate the data for the */
    '/*  selected report into Excel. Once the user generates the report */
    '/*  on the form, the user can click the Export Report To Excel     */
    '/*  button, opening the data in Excel.                             */
    '/*******************************************************************/
    '/*  CALLED BY:   	      											*/
    '/*  (None)								           					*/
    '/*******************************************************************/
    '/*  CALLS:															*/
    '/*  ExportToExcel()										        */
    '/*******************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):							*/
    '/*																	*/
    '/*	 sender- object representing a control                          */
    '/*  e- eventargs indicating there is an event handle assigned      */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:												*/
    '/*																	*/
    '/*  btnExporttoExcel_Click										    */
    '/*******************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):							*/
    '/*																	*/
    '/*  (None)                                                         */
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:											*/
    '/*																	*/
    '/*  WHO	    WHEN        WHAT									*/
    '/*  ---        ----        ----------------------------------------*/
    '/*  BRH        03/23/21    Initial creation of code                */
    '/*******************************************************************/
    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        ExportToExcel(strReport)
    End Sub
End Class
