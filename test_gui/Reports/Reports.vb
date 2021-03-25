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
    '/*  BRH            03/21/21    Add narcotics wasted,
    '/*******************************************************************/
    Public intColumnCount As Integer = 0
    Public intRowCount As Integer = 0
    'Determine which combo box index was selected
    Public strReport As String = ""

    Enum Reports
        Adhoc = 0
        Discrepancies = 1
        DispensedMeds = 2
        NarcAdhoc = 3
        DispensedNarc = 4
        WastedNarc = 5
        Override = 6
        Wastes = 7
    End Enum

    '/*********************************************************************/
    '/*                   FUNCTION NAME:  		getSelectedReport   	  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Eric LaVoie           		      */   
    '/*		         DATE CREATED: 		 03/16/21                         */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */             
    '/*											                          */                     
    '/*  The purpose of this function is to get data from the database,   */
    '/*  depending on which report is selected from the drop down. When a */
    '/*  report is selected, a different SQL command will be saved in the */
    '/*  strSQLCmd commmand. Then it will call the corresponding function */
    '/*  to get the data from the database and pass a list to save the values
    '/*  returned. Finally, the list will be passed to the routine that   */
    '/*  called this function.                                            */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  btnGenerateReport_Click                           				  */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*  GatherDataFromDatabaseTable							          */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											                          */                     
    '/*  intSelectedIndex - Stores the index of the selected report from  */
    '/*                     drop down list.                               */
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*  lstOfDataValues As a List(Of String)                             */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											                          */                     
    '/* getSelectedReport(intSelectedIndex)                               */                                                                    
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											   */                     
    '/*  lstOfDataValues - Created to store values grabbed from the database
    '/*   strSQLCmd - Stores the SQL command depending on what report is desired
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN        WHAT								      */             
    '/*  ---        ----        ------------------------------------------*/
    '/*  Eric L.    3/16/2021   Initial creation of code                  */ 
    '/*  BRH        3/18/2021   Created functionality for dispensed narcotic
    '/*                         reports.                                  */
    '/*	 BRH	    03/21/21	Fixed to remove an unnecessary column, added
    '/*                         narcotics wasted, all dispensed medication,
    '/*                         all wasted medication, all ad hoc orders,
    '/*  BRH        03/24/21    Add column counts to each section         */
    '/*********************************************************************/
    Function getSelectedReport(intSelectedIndex As Integer) As List(Of String)
        'Dim arrData As ArrayList = New ArrayList
        Dim lstOfDataValues As List(Of String) = New List(Of String)
        Dim strSQLCmd As String = ""



        'select statement that evaluates the selected index with the report that 
        'the user requested to be generated
        'this select case will be updated in the future to provide more
        'assignments, (e.g. strReport may be changed to strSQLCommand and assign
        'the necessary sql statement to query the needed table)
        Select Case intSelectedIndex
            Case Reports.Adhoc
                strReport = "Ad Hoc Orders"
                strSQLCmd = "SELECT Medication.Drug_Name, Drawers.Drawer_Number, DrawerMedication.Divider_Bin, Patient.Patient_First_Name, Patient.Patient_Middle_Name, 
                            Patient.Patient_Last_Name, User.Username, AdHocOrder.Amount FROM AdHocOrder 
                            INNER JOIN Medication ON AdHocOrder.Medication_TUID = Medication_ID
                            INNER JOIN Patient ON Patient_TUID = Patient_ID
                            INNER JOIN User ON User_TUID = User_ID
                            INNER JOIN DrawerMedication ON DrawerMedication_TUID = DrawerMedication_ID
                            INNER JOIN Drawers ON DrawerMedication.Drawers_TUID = Drawers.Drawers_ID"
                'intRowCount = ExecuteScalarQuery("Select Count(Medication.Drug_Name) FROM AdHocOrder 
                '            INNER JOIN Medication ON AdHocOrder.Medication_TUID = Medication_ID
                '            INNER JOIN Patient ON Patient_TUID = Patient_ID
                '            INNER JOIN User ON User_TUID = User_ID
                '            INNER JOIN DrawerMedication ON DrawerMedication_TUID = DrawerMedication_ID
                '            INNER JOIN Drawers ON DrawerMedication.Drawers_TUID = Drawers.Drawers_ID")



            Case Reports.Discrepancies
                strReport = "Discrepancies"
                strSQLCmd = "SELECT * FROM Discrepancies"

            'If the dispensed medication report is selected
            Case Reports.DispensedMeds ' 
                strReport = "Dispensed Meds"
                'Select all drugs and store their dispensing information
                strSQLCmd = "SELECT Drug_Name, Type, Strength, Amount_Dispensed, DateTime_Dispensed, Expiration_Date FROM DrawerMedication INNER JOIN 
                            Medication INNER JOIN Dispensing WHERE DrawerMedication.Medication_TUID = Medication_ID AND DrawerMedication_TUID = DrawerMedication_ID"

            Case Reports.NarcAdhoc
                strReport = "Narcotic Ad Hoc Orders"
                strSQLCmd = "SELECT Medication.Drug_Name, Drawers.Drawer_Number, DrawerMedication.Divider_Bin, Patient.Patient_First_Name, Patient.Patient_Middle_Name, 
                            Patient.Patient_Last_Name, User.Username, AdHocOrder.Amount FROM AdHocOrder 
                            INNER JOIN Medication ON AdHocOrder.Medication_TUID = Medication_ID
                            INNER JOIN Patient ON Patient_TUID = Patient_ID
                            INNER JOIN User ON User_TUID = User_ID
                            INNER JOIN DrawerMedication ON DrawerMedication_TUID = DrawerMedication_ID
                            INNER JOIN Drawers ON DrawerMedication.Drawers_TUID = Drawers.Drawers_ID
                            WHERE NarcoticControlled_Flag = 1"

            'If the dispensed narcotics report is selected
            Case Reports.DispensedNarc  '
                strReport = "Dispensed Narcotics"
                'Select the narcotic drugs and store their dispensing information
                strSQLCmd = "SELECT Drug_Name, Type, Strength, Amount_Dispensed, DateTime_Dispensed, Expiration_Date FROM DrawerMedication INNER JOIN 
                            Medication INNER JOIN Dispensing WHERE DrawerMedication.Medication_TUID = Medication_ID AND 
                            NarcoticControlled_Flag = 1 AND DrawerMedication_TUID = DrawerMedication_ID"

                'call the execute scalar query function with a sql command that determines the number of records in the table
                'intRowCount = ExecuteScalarQuery("Select Count(*) FROM DrawerMedication INNER JOIN 
                 '           Medication INNER JOIN Dispensing WHERE DrawerMedication.Medication_TUID = Medication_ID AND 
                  '          NarcoticControlled_Flag = 1 AND DrawerMedication_TUID = DrawerMedication_ID;")
               ' intColumnCount = ExecuteScalarQuery("Select Count(name) from PRAGMA_TABLE_INFO('Dispensing INNER JOIN ');")

            Case Reports.WastedNarc
                strReport = "Narcotics Wasted"
                strSQLCmd = "SELECT u1.Username, u2.Username, Medication.Drug_Name, Drawers.Drawer_Number, 
                            DrawerMedication.Divider_Bin, Wastes.DateTime, Wastes.Reason, Wastes.Quantity From User As u1, User As u2 
                            INNER JOIN Wastes ON u1.User_ID = Wastes.Primary_User_TUID AND  u2.User_ID = Wastes.Secondary_User_TUID 
                            INNER JOIN Medication ON Wastes.Medication_TUID = Medication_ID 
                            INNER JOIN DrawerMedication ON Wastes.DrawerMedication_TUID = DrawerMedication_ID 
                            INNER JOIN Drawers ON DrawerMedication.Drawers_TUID = Drawers_ID WHERE Medication.NarcoticControlled_Flag = 1"

            Case Reports.Override
                strReport = "Overrides"
                'Placeholder SQL so selecting Override won't break the program
                strSQLCmd = "SELECT * FROM AllergyOverride"

            Case Reports.Wastes
                strReport = "Wasted Medication"
                strSQLCmd = "SELECT u1.Username, u2.Username, Medication.Drug_Name, Drawers.Drawer_Number, 
                            DrawerMedication.Divider_Bin, Wastes.DateTime, Wastes.Reason, Wastes.Quantity From User As u1, User As u2 
                            INNER JOIN Wastes ON u1.User_ID = Wastes.Primary_User_TUID AND  u2.User_ID = Wastes.Secondary_User_TUID 
                            INNER JOIN Medication ON Wastes.Medication_TUID = Medication_ID 
                            INNER JOIN DrawerMedication ON Wastes.DrawerMedication_TUID = DrawerMedication_ID 
                            INNER JOIN Drawers ON DrawerMedication.Drawers_TUID = Drawers_ID"

        End Select


        GatherDataFromDatabaseTable(lstOfDataValues, strSQLCmd) 'intColumnCount, intRowCount, lstOfDataValues, strSQLCmd)
        Return lstOfDataValues

        'this Is used only if the user wants to save the report
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
    Sub GatherDataFromDatabaseTable(ByRef lstOfDataValues As List(Of String), ByRef strSQLCmd As String) 'ByRef intColumnCount As Integer, ByRef intRowCount As Integer, ByRef lstOfDataValues As List(Of String), ByRef strSQLCmd As String)
        'call the execute scalar query function with a sql command that determines the number of fields in the table
        'intColumnCount = ExecuteScalarQuery("Select Count(*) FROM (SELECT Drug_Name, Type, Strength, (DrawerMedication.Quantity - Amount_Dispensed), DateTime_Dispensed, Expiration_Date FROM DrawerMedication INNER JOIN 
        '                    Medication INNER JOIN Dispensing WHERE DrawerMedication.Medication_TUID = Medication_ID AND 
        '                    NarcoticControlled_Flag = 1 AND DrawerMedication_TUID = DrawerMedication_ID);")



        Dim dsDataset As DataSet
        'dsDataset = CreateDatabase.ExecuteSelectQuery("Select * from Rooms;")
        dsDataset = ExecuteSelectQuery(strSQLCmd)
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

    '/*******************************************************************/
    '/*                   SUBROUTINE NAME:      PrintItemsToDataGrid    */
    '/*******************************************************************/
    '/*                   WRITTEN BY:  	Breanna Howey					*/
    '/*					DATE CREATED: 	   03/18/21						*/
    '/*******************************************************************/
    '/*  SUBROUTINE PURPOSE:											*/
    '/*	The purpose of this subroutine is to print items to the data grid/
    '/* on the form depending on what report the user determines they want
    '/* to view.                                                        */
    '/*******************************************************************/
    '/*  CALLED BY:   	      											*/
    '/*	btnGenerateReport_Click											*/
    '/*******************************************************************/
    '/*  CALLS:															*/
    '/*  (None)															*/
    '/*******************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):							*/
    '/*																	*/
    '/*  lstOfDataValues - Stores the values brought back from the database
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:												*/
    '/*																	*/
    '/*	PrintItemsToDataGrid(lstOfDataValues)   						*/
    '/*******************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):							*/
    '/*																	*/
    '/*  (None)															*/
    '/*******************************************************************/
    '/* MODIFICATION HISTORY:											*/
    '/*																	*/
    '/* WHO   WHEN     WHAT											    */
    '/*  ---   ----     ------------------------------------------------*/
    '/*	BRH	 03/18/21	Initial creation of code                        */
    '/*	BRH	 03/21/21	Fixed to remove an unnecessary column, added    */
    '/*                 narcotics wasted, all dispensed medication,
    '/*                 all wasted medication, all ad hoc orders, 
    '/*  BRH        03/24/21    Add column counts to each section         */
    '/*******************************************************************/
    Sub PrintItemsToDataGrid(ByRef lstOfDataValues As List(Of String))

        'If the user selects the Narcotics Dispensed report,
        If frmReport.cmbReports.SelectedItem.Equals("Narcotics Dispensed") Or frmReport.cmbReports.SelectedItem.Equals("Dispensed Medications") Then
            'Add the following column names
            frmReport.dgvReport.Columns.Add(1, "Drug Name")
            frmReport.dgvReport.Columns.Add(2, "Drug Type")
            frmReport.dgvReport.Columns.Add(3, "Drug Strength")
            frmReport.dgvReport.Columns.Add(4, "Amount Dispensed")
            frmReport.dgvReport.Columns.Add(5, "Date / Time Dispensed")
            frmReport.dgvReport.Columns.Add(6, "Expiration Date")

            'Add the following data into data grid on the form
            For i As Integer = 0 To lstOfDataValues.Count - 6 Step 6
                frmReport.dgvReport.Rows.Add(lstOfDataValues.Item(i), lstOfDataValues.Item(i + 1), lstOfDataValues.Item(i + 2),
                                             lstOfDataValues.Item(i + 3), lstOfDataValues.Item(i + 4), lstOfDataValues.Item(i + 5))
            Next

            intColumnCount = 6
        ElseIf frmReport.cmbReports.SelectedItem.Equals("Narcotics Wasted") Or frmReport.cmbReports.SelectedItem.Equals("Wasted Medication") Then
            'Add the following column names
            frmReport.dgvReport.Columns.Add(1, "Primary User's Username")
            frmReport.dgvReport.Columns.Add(2, "Sign-off User's Username")
            frmReport.dgvReport.Columns.Add(3, "Drug Name")
            frmReport.dgvReport.Columns.Add(4, "Drawer Number")
            frmReport.dgvReport.Columns.Add(5, "Drawer Bin")
            frmReport.dgvReport.Columns.Add(6, "Date / Time Dispensed")
            frmReport.dgvReport.Columns.Add(7, "Reason for Wasting")
            frmReport.dgvReport.Columns.Add(8, "Amount Wasted")

            'Add the following data into data grid on the form
            For i As Integer = 0 To lstOfDataValues.Count - 8 Step 8
                frmReport.dgvReport.Rows.Add(lstOfDataValues.Item(i), lstOfDataValues.Item(i + 1), lstOfDataValues.Item(i + 2), lstOfDataValues.Item(i + 3),
                                             lstOfDataValues.Item(i + 4), lstOfDataValues.Item(i + 5), lstOfDataValues.Item(i + 6), lstOfDataValues.Item(i + 7))
            Next

            intColumnCount = 8
        ElseIf frmReport.cmbReports.SelectedItem.Equals("Ad Hoc Orders") Or frmReport.cmbReports.SelectedItem.Equals("Narcotic Ad Hoc Orders") Then
            frmReport.dgvReport.Columns.Add(1, "Drug Name")
            frmReport.dgvReport.Columns.Add(2, "Drawer Number")
            frmReport.dgvReport.Columns.Add(3, "Drawer Bin")
            frmReport.dgvReport.Columns.Add(4, "Patient's Name")
            frmReport.dgvReport.Columns.Add(5, "Username of Ordering User")
            frmReport.dgvReport.Columns.Add(6, "Amount Dispensed")

            'Add the following data into data grid on the form
            For i As Integer = 0 To lstOfDataValues.Count - 8 Step 8
                frmReport.dgvReport.Rows.Add(lstOfDataValues.Item(i), lstOfDataValues.Item(i + 1), lstOfDataValues.Item(i + 2), lstOfDataValues.Item(i + 3) & " " &
                                             lstOfDataValues.Item(i + 4) & " " & lstOfDataValues.Item(i + 5), lstOfDataValues.Item(i + 6), lstOfDataValues.Item(i + 7))
            Next

            intColumnCount = 6
        End If

    End Sub

End Module
