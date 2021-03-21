﻿Module Inventory
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
        Dim Strdatacommand As String = ("SELECT Drug_Name, Strength, Quantity, Divider_Bin, Medication_TUID FROM DrawerMedication " &
            "INNER JOIN Medication ON Medication.Medication_ID = DrawerMedication.Medication_TUID " &
            "WHERE DrawerMedication.Drawers_TUID =" & intDrawerID & " AND DrawerMedication.Active_Flag = '1';")

        'set dataset = to returned dataset from select function from createdatabase file
        dsDataset = CreateDatabase.ExecuteSelectQuery(Strdatacommand)
        'return dataset that holds drawer medications
        Return dsDataset
    End Function

    '/*********************************************************************/
    '/*                   Function NAME:PopulateWasteComboBoxMedication   */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: this subroutine populates the medication combobox
    '/* on frmWaste. it also populates the parallel ID array at the same time
    '/*
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  FrmWaste.btnWaste_Click
    '/*  FrmWaste.load
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  CreateDatabase.ExecuteSelectQuery
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):	
    '/*  none
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	 		PopulateWasteComboBoxMedication()							                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/* Strdatacommand -- sql string
    '/* dsMedicationDataSet - dataset that holds returned sql medications
    '/*
    '/*
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/10/21	  Initial creation of the code    */
    '/*********************************************************************/
    Public Sub PopulateWasteComboBoxMedication()
        frmWaste.cboMedication.Items.Clear()
        frmWaste.intMedicationID.Clear()
        Dim Strdatacommand As String
        ' Currently the medication display is appending the RXCUI Number on too the medication
        ' name, as searching by name alone could cause problems if medication names can repeat
        Strdatacommand = "Select DISTINCT Medication_ID, Drug_Name,RXCUI_ID FROM Medication INNER JOIN DrawerMedication ON DrawerMedication.Medication_TUID = Medication.Medication_ID WHERE DrawerMedication.Active_Flag = 1"

        Dim dsMedicationDataSet As DataSet = New DataSet
        dsMedicationDataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand)
        'add medication name and RXCUI to listbox
        For Each dr As DataRow In dsMedicationDataSet.Tables(0).Rows
            frmWaste.cboMedication.Items.Add(dr(1) & "  RXCUI: " & dr(2))
            frmWaste.intMedicationID.Add(dr(0))
        Next

    End Sub

    '/*********************************************************************/
    '/*                   Function NAME:WasteMedication                    */
    '/*********************************************************************/
    '/*                   WRITTEN BY:  	Alexander Beasecker			      */
    '/*		         DATE CREATED: 	   02/10/21							  */
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE: this subroutine handles the logic for wasting
    '/*  a medication. It will insert the waste record into the database
    '/* it will update the amount left of the medication after the waste
    '/* if the quantity left is zero it will deactivate the medication
    '/* and finally it calls the open drawer method so they can remove the medication
    '/*
    '/*********************************************************************/
    '/*  CALLED BY:   	      									          
    '/*  FrmWaste.btnWaste_Click								           					  
    '/*********************************************************************/
    '/*  CALLS:														    	
    '/*  CartInterfaceCode.OpenOneDrawer(intDrawerNumber)
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):	
    '/* intdrawerID -- hold the TUID for the drawer the medication being wasted 
    '/*                 is held in
    '/* Quantity -- the quantity that the user wants wasted
    '/* intMedID -- the database TUID for the medication being wasted
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                   
    '/*	 		WasteMedication('1','100','2')							                           
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically):	
    '/* intDrawerNumber -- hold the TUID for the drawer the medication being wasted 
    '/*                 is held in
    '/* strWasteReason -- the string that holds the reason for the waste
    '/* dtmAdhocTime -- the current time 
    '/* intDrawerAmount -- the amount that is currently in the drawer before wasting
    '/* intDrawerMedID -- the database TUID for the medication being wasted
    '/* intDrawerTUID -- the Database TUID for the drawer
    '/* intQuantityLeft -- the amount left after wasting, used to see if zero for removing the medication
    '/* intSelectedIndex -- the selected index in the medication combo box, used to get the item in the same index
    '/*                      from the parallel array 
    '/* strSqlCommand -- holds the sql command
    '/* userID -- the user id of the user who is logged in
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */
    '/*											                          */
    '/*  WHO                   WHEN     WHAT							  */
    '/*  ---                   ----     ----------------------------------*/
    '/*  Alexander Beasecker  02/10/21	  Initial creation of the code    */
    '/*********************************************************************/
    Public Sub WasteMedication(ByRef intdrawerID As Integer, ByRef Quantity As Integer, ByRef intMedID As Integer)
        If Not IsNothing(frmWaste.cboMedication.SelectedItem) Then
            Dim strSqlCommand As String
            Dim intDrawerMedID As Integer
            Dim strWasteReason As String = " "
            Dim intSelectedIndex As Integer = frmWaste.cboMedication.SelectedIndex
            Dim userID As Integer
            intSelectedIndex = frmWaste.intMedicationID(intSelectedIndex)

            If frmWaste.rbtnOther.Checked Then
                strWasteReason = frmWaste.TextBox1.Text
            ElseIf frmWaste.RadioButton2.Checked Then
                strWasteReason = frmWaste.RadioButton2.Text
            ElseIf frmWaste.RadioButton3.Checked Then
                strWasteReason = frmWaste.RadioButton3.Text
            ElseIf frmWaste.RadioButton4.Checked Then
                strWasteReason = frmWaste.RadioButton4.Text
            ElseIf frmWaste.rbtnPatientUnavilable.Checked Then
                strWasteReason = frmWaste.rbtnPatientUnavilable.Text
            End If

            Dim dtmAdhocTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            intDrawerMedID = intdrawerID

            strSqlCommand = "select User_ID from User where Username = '" & frmWaste.cboWitness.SelectedItem & "'"
            userID = CreateDatabase.ExecuteScalarQuery(strSqlCommand)
            strSqlCommand = "INSERT INTO Wastes(Primary_User_TUID,Secondary_User_TUID,DrawerMedication_TUID,Medication_TUID,DateTime,Reason,Quantity) VALUES('1','" & userID & "','" & intDrawerMedID & "','" & intMedID & "','" & dtmAdhocTime & "','" & strWasteReason & "','" & Quantity & "')"
            CreateDatabase.ExecuteInsertQuery(strSqlCommand)

            'Update medication amount in drawer
            Dim intDrawerAmount As Integer = CreateDatabase.ExecuteScalarQuery("SELECT Quantity from DrawerMedication where DrawerMedication_ID = '" & intDrawerMedID & "'")
            intDrawerAmount = intDrawerAmount - Quantity
            CreateDatabase.ExecuteInsertQuery("UPDATE DrawerMedication SET Quantity = '" & intDrawerAmount & "' WHere DrawerMedication_ID = '" & intDrawerMedID & "'")

            'if amount left after waste is zero then update record to be inactive
            Dim intDrawerTUID As Integer = CreateDatabase.ExecuteScalarQuery("Select Drawers_TUID from DrawerMedication where DrawerMedication_ID = '" & intDrawerMedID & "'")
            Dim intDrawerNumber As Integer = CreateDatabase.ExecuteScalarQuery("Select Drawer_Number from Drawers where Drawers_ID = '" & intDrawerTUID & "'")
            Dim intQuantityLeft As Integer = CreateDatabase.ExecuteScalarQuery("SELECT Quantity from DrawerMedication where DrawerMedication_ID = '" & intDrawerMedID & "'")
            If intQuantityLeft <= 0 Then
                MessageBox.Show("Waste recorded, Medication quantity is now zero, Please remove medication from the drawer")
                CreateDatabase.ExecuteInsertQuery("UPDATE DrawerMedication SET Active_Flag = '0' WHere DrawerMedication_ID = '" & intDrawerMedID & "'")
                CartInterfaceCode.OpenOneDrawer(intDrawerNumber)
            Else
                MessageBox.Show("Waste recorded and quantity updated")
                CartInterfaceCode.OpenOneDrawer(intDrawerNumber)

            End If
            'Debug message used to let you know it worked, will be removed

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
            "INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID WHERE DrawerMedication.Active_Flag = '1'"
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
            "INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID WHERE Medication.Controlled_Flag = '1' AND Medication.NarcoticControlled_Flag = '0' AND DrawerMedication.Active_Flag = '1'"
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
            "INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID WHERE Medication.Controlled_Flag = '1' AND DrawerMedication.Active_Flag = '1'"
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
            "INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID WHERE Medication.NarcoticControlled_Flag = '1' AND DrawerMedication.Active_Flag = '1'"
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
            "INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID WHERE Medication.Controlled_Flag = '0' AND DrawerMedication.Active_Flag = '1'"
        dsMedicationDataset = CreateDatabase.ExecuteSelectQuery(strSqlCommand)
        For Each dr As DataRow In dsMedicationDataset.Tables(0).Rows
            frmEndOfShift.CreatePanel(frmEndOfShift.flpEndOfShiftCount, dr(0), dr(1), dr(2), dr(3), dr(4))
        Next
    End Sub

    Public Sub GetAmountInsideDrawer()

    End Sub

    Public Sub RemoveDrugfromDrawer(ByRef intDrawerID As Integer, ByRef intDivider As Integer, ByRef intMedTUID As Integer)
        CreateDatabase.ExecuteInsertQuery("UPDATE DrawerMedication SET Active_Flag = '0' WHERE Drawers_TUID = '" & intDrawerID & "'  AND Divider_Bin = '" & intDivider & "' AND Medication_TUID = '" & intMedTUID & "' AND Active_Flag = '1'")

    End Sub
End Module

