Module Inventory
    '/*******************************************************************/
    '/*                   FILE NAME: Inventory.vb                       */
    '/*******************************************************************/
    '/*                 PART OF PROJECT: Med_Cart				        */
    '/*******************************************************************/
    '/*              WRITTEN BY:  Alexander Beasecker   		        */
    '/*		         DATE CREATED: January 25, 2021			            */
    '/*******************************************************************/
    '/*  MODULE PURPOSE:								                  */
    '/*											                          */
    '/* The purpse of this module is to handle the medication inventory   */
    '/* tracking. It tracks the medications in each drawer and the amount */
    '/* still left in each drawer. It will also comunicate with the       */
    '/* inventory maintinance screen to display each medication and amount*/ 
    '/* in each drawer.                                                   */
    '/*                                                                   */
    '/*******************************************************************/
    '/*  COMMAND LINE PARAMETER LIST (In Parameter Order):			    */
    '/*                         (NONE)	                                */
    '/*******************************************************************/
    '/*  ENVIRONMENTAL RETURNS:							                */
    '/*                        (NOTHING)					            */
    '/*******************************************************************/
    '/* SAMPLE INVOCATION:								                */
    '/*											                        */
    '/* The program will invoke this module at many different places,   */
    '/* at any point the medication in a drawer changes this module would*/
    '/* be invoked update the medication in the drawer. At any point that the*/
    '/* medication amount in a drawer would change this module will be */
    '/* invoked to update the medication amount and the drawer status. */
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
    '/*                   Function NAME:GetDrawerDrugs                    */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/01/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: The purpose of this function is to 
    '/* return a dataset holding all the current medications that are 
    '/* assigned to a specific drawer
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  CreateDatabase.ExecuteSelectQuery()
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order): intDrawerID				   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	 dataset = GetDrawerDrugs("1")										                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*	Strdatacommand as string
    '/* dsDataset as dataset
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/05/2021  Initial creation of the code    */
    '/*********************************************************************/
    Public Function GetDrawerDrugs(ByRef intDrawerID As Integer)
        'create dataset to hold selected values
        Dim dsDataset As New DataSet
        'create select to send to select function
        Dim Strdatacommand As String = ("SELECT Drug_Name, Strength, Divider_Bin FROM DrawerMedication " &
            "INNER JOIN Medication ON Medication.Medication_ID = DrawerMedication.Medication_TUID " &
            "WHERE DrawerMedication.Drawers_TUID =" & intDrawerID & ";")

        'set dataset = to returned dataset from select function from createdatabase file
        dsDataset = CreateDatabase.ExecuteSelectQuery(Strdatacommand)
        Debug.WriteLine("")
        'return dataset that holds drawer medications
        Return dsDataset
    End Function

    '/*********************************************************************/
    '/*                   Function NAME:PopulateWasteComboBoxMedication   */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: 
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):			   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	 									                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/10/21	  Initial creation of the code    */
    '/*********************************************************************/
    Public Sub PopulateWasteComboBoxMedication()

        Dim Strdatacommand As String
        ' Currently the medication display is appending the RXCUI Number on too the medication
        ' name, as searching by name alone could cause problems if medication names can repeat
        Strdatacommand = "Select Drug_Name, RXCUI_ID FROM Medication INNER JOIN DrawerMedication ON DrawerMedication.Medication_TUID = Medication.Medication_ID WHERE Active_Flag = 1"

        Dim dsMedicationDataSet As DataSet = New DataSet
        dsMedicationDataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)
        'add medication name and RXCUI to listbox
        For Each dr As DataRow In dsMedicationDataSet.Tables(0).Rows
            Waste.ComboBox1.Items.Add(dr(0) & "--" & dr(1))
        Next

    End Sub

    '/*********************************************************************/
    '/*                   Function NAME:WasteMedication                    */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: 
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):			   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	 									                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/10/21	  Initial creation of the code    */
    '/*********************************************************************/
    Public Sub WasteMedication()
        If Not IsNothing(Waste.ComboBox1.SelectedItem) Then
            Dim strSqlCommand As String
            Dim strArray() As String
            Dim strMedication As String = Waste.ComboBox1.SelectedItem
            Dim intDrawerMedID As Integer
            Dim strWasteReason As String = " "

            If Waste.rbtnOther.Checked Then
                strWasteReason = Waste.TextBox1.Text
            ElseIf Waste.rbtnDispenseDevice.Checked Then
                strWasteReason = Waste.rbtnDispenseDevice.Text
            ElseIf Waste.RadioButton2.Checked Then
                strWasteReason = Waste.RadioButton2.Text
            ElseIf Waste.RadioButton3.Checked Then
                strWasteReason = Waste.RadioButton3.Text
            ElseIf Waste.RadioButton4.Checked Then
                strWasteReason = Waste.RadioButton4.Text
            ElseIf Waste.rbtnPatientUnavilable.Checked Then
                strWasteReason = Waste.rbtnPatientUnavilable.Text
            End If

            Dim dtmAdhocTime As String = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
            strArray = strMedication.Split("--")
            strMedication = strArray(2)
            strSqlCommand = "SELECT DrawerMedication_ID FROM DrawerMedication INNER JOIN Medication on Medication.Medication_ID = DrawerMedication.Medication_TUID WHERE Medication.RXCUI_ID = '" & strMedication & "'"
            intDrawerMedID = CreateDatabase.ExecuteScalarQuery(strSqlCommand)

            strSqlCommand = "INSERT INTO Wastes(Primary_User_TUID,Secondary_User_TUID,DrawerMedication_TUID,DateTime,Reason) VALUES('1','1','" & intDrawerMedID & "','" & dtmAdhocTime & "','" & strWasteReason & "')"
            CreateDatabase.ExecuteInsertQuery(strSqlCommand)

            'Debug message used to let you know it worked, will be removed
            MessageBox.Show("Waste recorded")
        End If

    End Sub


    '/*********************************************************************/
    '/*                   Function NAME:EndofShiftAllMedications                    */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: 
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):			   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	 									                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/10/21	  Initial creation of the code    */
    '/*********************************************************************/
    Public Sub EndofShiftAllMedications()

        Dim strSqlCommand As String
        Dim dsMedicationDataset As DataSet

        strSqlCommand = "SELECT Medication_TUID, Drug_Name, Drawer_Number, Divider_Bin, Quantity FROM DrawerMedication " &
            "INNER JOIN Medication on Medication.Medication_ID = DrawerMedication.Medication_TUID " &
            "INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID"
        dsMedicationDataset = CreateDatabase.ExecuteSelectQuery(strSqlCommand)

        For Each dr As DataRow In dsMedicationDataset.Tables(0).Rows
            frmEndOfShift.CreatePanel(frmEndOfShift.flpEndOfShiftCount, dr(0), dr(1), dr(2), dr(3), dr(4))
        Next

    End Sub

    '/*********************************************************************/
    '/*                   Function NAME:NonControlledMedsEndofShift      */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: 
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):			   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	 									                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/10/21	  Initial creation of the code    */
    '/*********************************************************************/
    Public Sub ControlledNonNarcoticMedsEndofShift()
        Dim strSqlCommand As String
        Dim dsMedicationDataset As DataSet
        strSqlCommand = "SELECT Medication_TUID, Drug_Name, Drawer_Number, Divider_Bin, Quantity FROM DrawerMedication " &
            "INNER JOIN Medication on Medication.Medication_ID = DrawerMedication.Medication_TUID " &
            "INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID WHERE Medication.Controlled_Flag = '1' AND Medication.NarcoticControlled_Flag = '0'"
        dsMedicationDataset = CreateDatabase.ExecuteSelectQuery(strSqlCommand)
        For Each dr As DataRow In dsMedicationDataset.Tables(0).Rows
            frmEndOfShift.CreatePanel(frmEndOfShift.flpEndOfShiftCount, dr(0), dr(1), dr(2), dr(3), dr(4))
        Next
    End Sub

    '/*********************************************************************/
    '/*                   Function NAME:ControlledMedsEndofShift           */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: 
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):			   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	 									                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/10/21	  Initial creation of the code    */
    '/*********************************************************************/
    Public Sub ControlledMedsEndofShift()
        Dim strSqlCommand As String
        Dim dsMedicationDataset As DataSet
        strSqlCommand = "SELECT Medication_TUID, Drug_Name, Drawer_Number, Divider_Bin, Quantity FROM DrawerMedication " &
            "INNER JOIN Medication on Medication.Medication_ID = DrawerMedication.Medication_TUID " &
            "INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID WHERE Medication.Controlled_Flag = '1'"
        dsMedicationDataset = CreateDatabase.ExecuteSelectQuery(strSqlCommand)
        For Each dr As DataRow In dsMedicationDataset.Tables(0).Rows
            frmEndOfShift.CreatePanel(frmEndOfShift.flpEndOfShiftCount, dr(0), dr(1), dr(2), dr(3), dr(4))
        Next
    End Sub

    '/*********************************************************************/
    '/*                   Function NAME:NarcoticEndOfShift           */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: 
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):			   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	 									                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/10/21	  Initial creation of the code    */
    '/*********************************************************************/
    Public Sub NarcoticEndOfShift()
        Dim strSqlCommand As String
        Dim dsMedicationDataset As DataSet
        strSqlCommand = "SELECT Medication_TUID, Drug_Name, Drawer_Number, Divider_Bin, Quantity FROM DrawerMedication " &
            "INNER JOIN Medication on Medication.Medication_ID = DrawerMedication.Medication_TUID " &
            "INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID WHERE Medication.NarcoticControlled_Flag = '1'"
        dsMedicationDataset = CreateDatabase.ExecuteSelectQuery(strSqlCommand)
        For Each dr As DataRow In dsMedicationDataset.Tables(0).Rows
            frmEndOfShift.CreatePanel(frmEndOfShift.flpEndOfShiftCount, dr(0), dr(1), dr(2), dr(3), dr(4))
        Next
    End Sub

    '/*********************************************************************/
    '/*                   Function NAME:NonNarcoticEndOfShift           */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: 
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  (None)								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):			   		   
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	 									                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/10/21	  Initial creation of the code    */
    '/*********************************************************************/
    Public Sub NonNarcoticEndOfShift()
        Dim strSqlCommand As String
        Dim dsMedicationDataset As DataSet
        strSqlCommand = "SELECT Medication_TUID, Drug_Name, Drawer_Number, Divider_Bin, Quantity FROM DrawerMedication " &
            "INNER JOIN Medication on Medication.Medication_ID = DrawerMedication.Medication_TUID " &
            "INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID WHERE Medication.Controlled_Flag = '0'"
        dsMedicationDataset = CreateDatabase.ExecuteSelectQuery(strSqlCommand)
        For Each dr As DataRow In dsMedicationDataset.Tables(0).Rows
            frmEndOfShift.CreatePanel(frmEndOfShift.flpEndOfShiftCount, dr(0), dr(1), dr(2), dr(3), dr(4))
        Next
    End Sub
End Module

