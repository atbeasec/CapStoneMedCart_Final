﻿Imports System.Text

Public Class frmDispense
    Public blnSignedOff As Boolean = True
    Public blnOverride As Boolean = False
    Private intPatientID As Integer
    Private intPatientMRN As Integer
    Private intMedicationID As Integer
    Private intPatientMedID As Integer

    Private intDispenseAmount As Integer
    Private intCountedAmount As Integer
    Private dblDispensedPatientAmount As Integer
    Private dblWastedAmount As Integer

    Dim contactPanelsAddedCount As Integer = 0
    Dim currentContactPanelName As String = Nothing

    Private intEnteredFromAdhoc As Integer = 0

    'variables here are only used if adhoc is the form that initiated dispensing
    Public strAmountAdhoc As String
    Public strUnitAdhoc As String
    Public intDrawerMEDAdhoc As Integer
    Private intAdhocDrawerNumber As Integer
    Private intAdhocBin As Integer

    Public Sub setintEntered(ByRef ID As Integer)
        intEnteredFromAdhoc = ID
    End Sub

    Public Function getIntEntered()
        Return intEnteredFromAdhoc
    End Function

    Public Sub SetPatientID(ByVal ID As Integer)
        intPatientID = ID
        intPatientMRN = ExecuteScalarQuery("SELECT MRN_Number from Patient WHERE Patient_ID =" & intPatientID & ";")
    End Sub

    Public Sub SetintMedicationID(ByVal ID As Integer)
        intMedicationID = ID
    End Sub

    Public Sub setPatientMedID(ByRef ID As Integer)
        intPatientMedID = ID
    End Sub

    Public Sub SetPatientMrn(ByVal mrn As Integer)
        intPatientMRN = mrn
    End Sub


    Public Function getPattientMedID()
        Return intPatientMedID
    End Function


    Private Sub btnDispense_Click(sender As Object, e As EventArgs)

        'MessageBox.Show("CAUTION: This drug interacts with (insert drug name here) that the patient is currently taking. Or the patient is allergic to this drug")

        'frmWitnessSignOff.Show()
        ' call emthod to open serial port connection and open drawer

    End Sub

    Public Sub CreateDispenseHistoryPanels(ByVal flpPannel As FlowLayoutPanel, ByVal strMedicationName As String, ByVal strStrength As String, ByVal strType As String, ByVal strQuantity As String, ByVal strDispenseBy As String, ByVal strDispenseDate As String, ByVal strDispenseTime As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel

        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(1040, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(1040, 45)
            .Name = "pnlIndividualPatientRecord" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)

        'AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClickNewOrder
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        ' add controls to this panel
        ' call database info here to populate
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Dim lblID6 As New Label

        CreateIDLabelWithToolTip(pnlMainPanel, lblID, "lblMedicationName", lblMedication.Location.X, 20, strMedicationName, getPanelCount(flpPannel), tpToolTip, TruncateString(25, strMedicationName))
        CreateIDLabel(pnlMainPanel, lblID2, "lblStrength", lblStrength.Location.X, 20, strStrength, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblType", lblType.Location.X, 20, strType, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblQuantity", lblQuantity.Location.X, 20, strQuantity, getPanelCount(flpPannel))
        CreateIDLabelWithToolTip(pnlMainPanel, lblID5, "lblDispensedBy", lblDispensedBy.Location.X, 20, strDispenseBy, getPanelCount(flpPannel), tpToolTip, TruncateString(30, strDispenseBy))
        CreateIDLabel(pnlMainPanel, lblID6, "lblDispenseTimeAndDate", lblDateTime.Location.X, 20, strDispenseDate.Substring(0, 19), getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub


    Private Sub Dispense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDirections.Text = "Insert Amount to Remove:"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)

        pnlAmountInDrawer.Visible = False
        pnlAmountAdministered.Visible = False
        pnlSelector.Visible = False
        btnReopenDrawer.Visible = False
    End Sub


    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        ButtonIncrement(1000, txtQuantityToDispense)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        ButtonDecrement(txtQuantityToDispense)
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: btnDispense_Click_1               */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker        		          */   
    '/*		         DATE CREATED: 		 3/20/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	  this is called and handles the button click methods
    '/* the way the dispense screen is written is it reuses the same
    '/* controls multiple times for multiple parts in the dispensing flow
    '/* first it checks if the drug being dispensed is a narcotic. it will ask the amount to be removed from the drawer.
    '/* after that it opens the drawer. if it is a
    '/* narcotic then it changes to require the narcotic count.
    '/* after the narcotoc count if it is not correct to the system amount, then it
    '/* will alert the user to a discrepancy. after this it will ask for the 
    '/* amount that was given to the patient, and after that it will move to
    '/* the waste input requireing the waste input.
    '/*
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */                 
    '/*********************************************************************/
    '/*  CALLS:                                        				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     sender
    '/*      e                                                             */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                                                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */  
    '/*
    '/* NarcoticFlag -- flag that is either zero or one based on if the drug is a narcotic or not
    '/* intdrawerNumber -- the number drawer the medication is in
    '/* intAmountinCart  -- the amount the cart system registers in the cart
    '/* strAmountDispensed -- the amount being removed from the cart
    '/* intdrawerMEDTUID
    '/*
    '/*
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  AB    3/20/2021     Initial creation/rework of dispensing
    '/*********************************************************************/
    Private Sub btnDispense_Click_1(sender As Object, e As EventArgs) Handles btnDispense.Click
        'get if the drug is a narcotic and get the drawer the medication selected is in 
        Dim NarcoticFlag As Integer = CreateDatabase.ExecuteScalarQuery("Select Controlled_Flag from Medication where Medication_ID = '" & intMedicationID & "' and Active_Flag = '1'")
        Dim intdrawerNumber As Integer = CreateDatabase.ExecuteScalarQuery("Select Drawers_TUID from DrawerMedication where Medication_TUID = '" & intMedicationID & "' and Active_Flag = '1'")
        btnReopenDrawer.Visible = True
        If intEnteredFromAdhoc = 1 Then
            intdrawerNumber = intAdhocDrawerNumber
        End If
        'check for what set in the process the dispense is in.
        If lblDirections.Text.Equals("Insert Amount to Remove:") Then
            'check to see if the amount is a numeric
            If IsNumeric(txtQuantityToDispense.Text) Then
                If txtQuantityToDispense.Text > 0 Then
                    'check to see if the drug is a narcotic
                    If NarcoticFlag = 1 Then
                        'Is a narcotic
                        OpenOneDrawer(intdrawerNumber)
                        intDispenseAmount = txtQuantityToDispense.Text
                        changebuttonForCounting()
                        frmMain.LockSideMenu()
                        btnBack.Visible = False
                    Else
                        'Is not a narcotic
                        OpenOneDrawer(intdrawerNumber)
                        intDispenseAmount = txtQuantityToDispense.Text
                        Dim intquantity As Integer = CreateDatabase.ExecuteScalarQuery("Select Quantity from DrawerMedication where Medication_TUID = '" & intMedicationID & "' AND Active_Flag = '1' AND Drawers_TUID = '" & intdrawerNumber & "'")
                        UpdateDrawerCount(intDispenseAmount, intquantity, intdrawerNumber, intMedicationID)
                        changeButtonforDispensing()
                        frmMain.LockSideMenu()
                        btnBack.Visible = False
                    End If
                Else
                    MessageBox.Show("Please enter a quantity value greater than 0")
                End If
            End If
            'step after narcotic amount entered
        ElseIf lblDirections.Text.Equals("Enter the Quantity in the Cart") Then
            If IsNumeric(txtQuantityToDispense.Text) Then
                Dim intAmountinCart As Integer = txtCountInDrawer.Text
                UpdateSystemCountForDiscrepancy(intMedicationID, intdrawerNumber, intAmountinCart)
                Dim intquantity As Integer = CreateDatabase.ExecuteScalarQuery("Select Quantity from DrawerMedication where Medication_TUID = '" & intMedicationID & "' AND Active_Flag = '1' AND Drawers_TUID = '" & intdrawerNumber & "'")
                UpdateDrawerCount(intDispenseAmount, intquantity, intdrawerNumber, intMedicationID)
                changeButtonforDispensing()
            End If
            'step after administered drugs, enter wasting
        ElseIf lblDirections.Text.Equals("Enter the Amount Administered") Then
            If IsNumeric(txtAmountDispensed.Text) Then
                If intEnteredFromAdhoc = 0 Then
                    Dim strAmountDispensed As String = txtAmountDispensed.Text & " " & txtUnits.Text
                    Dim intdrawerMEDTUID As Integer = CreateDatabase.ExecuteScalarQuery("Select DrawerMedication_ID from DrawerMedication where Medication_TUID = '" & intMedicationID & "' and Active_Flag = '1'")
                        DispensingDrug(intMedicationID, CInt(LoggedInID), strAmountDispensed)
                    frmWaste.SetPatientID(intPatientID)
                    frmWaste.setDrawer(intdrawerNumber)
                    frmWaste.setMedID(intMedicationID)
                    frmWaste.setDrawerMEDTUID(intdrawerMEDTUID)
                    frmMain.OpenChildForm(frmWaste)
                    'used to check if the form that entered this dispense was adhoc or not
                ElseIf intEnteredFromAdhoc = 1 Then
                    Dim strAmountDispensed As String = txtAmountDispensed.Text & " " & txtUnits.Text
                    DispensingDrugAdhoc(intMedicationID, intPatientID, CInt(LoggedInID), strAmountDispensed, intDrawerMEDAdhoc)
                    frmWaste.SetPatientID(intPatientID)
                    frmWaste.setDrawer(intdrawerNumber)
                    frmWaste.setMedID(intMedicationID)
                    frmWaste.setDrawerMEDTUID(intDrawerMEDAdhoc)
                    frmWaste.setEnteredFromAdhoc(1)
                    frmMain.OpenChildForm(frmWaste)
                End If

            Else
                MessageBox.Show("Please enter a numeric number greater than 0")
            End If

        End If
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: changebuttonForCounting               */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker        		          */   
    '/*		         DATE CREATED: 		 3/20/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	  This method will swap the frmDispense labels to the narcotic counting
    '/* visuals
    '/*
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */                 
    '/*********************************************************************/
    '/*  CALLS:	                                                              */            
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     sender
    '/*      e                                                             */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                                                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  AB    3/20/2021     Initial creation/rework of dispensing
    '/*********************************************************************/
    Private Sub changebuttonForCounting()
        lblDirections.Text = "Enter the Quantity in the Cart"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)
        btnDispense.Text = "Submit Count"
        pnlAmountInDrawer.Visible = True
        pnlAmountToRemove.Visible = False
    End Sub


    '/*********************************************************************/
    '/*                   SubProgram NAME: changeButtonforDispensing               */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker        		          */   
    '/*		         DATE CREATED: 		 3/20/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 this program will swap the GUI to the labels and visuals for dispensing 
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */                 
    '/*********************************************************************/
    '/*  CALLS:	                                                              */            
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     sender
    '/*      e                                                             */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                                                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */ 
    '/*
    '/* strAmountUnit -- gets the unit count from the database for the medication
    '/*
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  AB    3/20/2021     Initial creation/rework of dispensing
    '/*********************************************************************/
    Private Sub changeButtonforDispensing()
        lblDirections.Text = "Enter the Amount Administered"
        btnDispense.Text = "Submit Amount"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)
        ' show approiate panels
        pnlAmountAdministered.Visible = True
        pnlAmountToRemove.Visible = False
        pnlAmountInDrawer.Visible = False
        Dim strAmountUnit As String = CreateDatabase.ExecuteScalarQuery("Select Amount_Per_Container_Unit from DrawerMedication where Medication_TUID = '" & intMedicationID & "' and Active_Flag = '1'")
        txtUnits.Text = strAmountUnit
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: DispensingDrug               */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker        		          */   
    '/*		         DATE CREATED: 		 3/20/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	  this method handles the sql statements to insert the dispense into the database
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */                 
    '/*********************************************************************/
    '/*  CALLS:	                                      */            
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     intMedID -- Integer -- holds medication database id
    '/*      intPrimaryID -- Integer -- holds patient database id
    '/*      strAmountDispensed -- Integer -- holds amount dispensed
    '/*
    '/**/ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                                                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */ 
    '/* dtmAdhocTime
    '/* strbSQLcommand
    '/* intdrawerNumber
    '/* intPatientMedicationDatabaseID
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  AB    3/20/2021     Initial creation/rework of dispensing
    '/*********************************************************************/
    Private Sub DispensingDrug(ByRef intMedID As Integer, ByRef intPrimaryID As Integer, ByRef strAmountDispensed As String)
        Dim strbSQLcommand As New StringBuilder()
        Dim dtmAdhocTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim intdrawerNumber As Integer = CreateDatabase.ExecuteScalarQuery("Select DrawerMedication_ID from DrawerMedication where Medication_TUID = '" & intMedicationID & "' and Active_Flag = '1'")
        strbSQLcommand.Clear()
        strbSQLcommand.Append("SELECT PatientMedication_ID FROM PatientMedication WHERE Medication_TUID = '" & intMedID & "' AND Patient_TUID = '" & intPatientID & "' AND PatientMedication.Active_Flag = '1'")
        Dim intPatientMedicationDatabaseID As Integer = getPattientMedID()
        strbSQLcommand.Clear()
        strbSQLcommand.Append("INSERT INTO Dispensing(PatientMedication_TUID, Primary_User_TUID, Approving_User_TUID, DateTime_Dispensed, Amount_Dispensed, DrawerMedication_TUID) ")
        strbSQLcommand.Append("VALUES('" & intPatientMedicationDatabaseID & "','" & intPrimaryID & "','" & intPrimaryID & "','" & dtmAdhocTime & "','" & strAmountDispensed & "','" & intdrawerNumber & "')")
        CreateDatabase.ExecuteInsertQuery(strbSQLcommand.ToString)
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: DispensingDrugAdhoc               */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker        		          */   
    '/*		         DATE CREATED: 		 3/20/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	  this method handles the dispensing insert database sql for adhoc orders
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */                 
    '/*********************************************************************/
    '/*  CALLS:                             */            
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */             
    '/* intMedID As Integer- database med tuid
    '/* intPatientID As Integer -- patient database tuid
    '/* intUserID As Integer -- logged in user tuid
    '/* stramount As String -- amount dispensed
    '/* intDrawerID As Integer -- drawer id to be opened
    '/* 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                                                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */ 
    '/*
    '/* strbSQLcommand -- sql command
    '/* dtmAdhocTime -- date time object
    '/*
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  AB    3/20/2021     Initial creation/rework of dispensing
    '/*********************************************************************/
    Private Sub DispensingDrugAdhoc(ByRef intMedID As Integer, ByRef intPatientID As Integer, ByRef intUserID As Integer, ByRef stramount As String, ByRef intDrawerID As Integer)
        Dim strbSQLcommand As New StringBuilder()
        Dim dtmAdhocTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        strbSQLcommand.Clear()
        strbSQLcommand.Append("INSERT INTO AdHocOrder(Medication_TUID,Patient_TUID,User_TUID,Amount,DrawerMedication_TUID,DateTime) ")
        strbSQLcommand.Append("VALUES('" & intMedID & "','" & intPatientID & "','" & intUserID & "','" & stramount & "','" & intDrawerID & "','" & dtmAdhocTime & "')")
        CreateDatabase.ExecuteInsertQuery(strbSQLcommand.ToString)
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: UpdateSystemCountForDiscrepancy               */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker        		          */   
    '/*		         DATE CREATED: 		 3/20/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 this method handles the updating of the drawer amount to the counted amount
    '/* and calls the insert discrepancy method.
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */                 
    '/*********************************************************************/
    '/*  CALLS:	                                 */            
    '/*      CreateDatabase.ExecuteInsertQuery 
    '/*      Discrepancies.CreateDiscrepancy                                        				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*     intMedID As Integer- database med tuid
    '/*      intDrawerCount           
    '/*      intEnteredAmount   */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                                                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  AB    3/20/2021     Initial creation/rework of dispensing
    '/*********************************************************************/
    Private Sub UpdateSystemCountForDiscrepancy(ByRef intMedID As Integer, ByRef intDrawerCount As Integer, ByRef intEnteredAmount As Integer)
        Dim intCurrentSystemCount As Integer = CreateDatabase.ExecuteScalarQuery("Select Quantity from DrawerMedication where Medication_TUID = '" & intMedID & "' and Active_Flag = '1' AND Drawers_TUID = '" & intDrawerCount & "'")
        Dim intdrawerNumber As Integer = CreateDatabase.ExecuteScalarQuery("Select Drawers_TUID from DrawerMedication where Medication_TUID = '" & intMedID & "' and Active_Flag = '1'")
        Dim intBinNumber As Integer = CreateDatabase.ExecuteScalarQuery("Select Divider_Bin from DrawerMedication where Medication_TUID = '" & intMedID & "' and Active_Flag = '1'")
        If Not intCurrentSystemCount = intEnteredAmount Then
            CreateDatabase.ExecuteInsertQuery("Update DrawerMedication SET Quantity = '" & intEnteredAmount & "' WHERE Medication_TUID = '" & intMedID & "' AND Active_Flag = '1'")
            Discrepancies.CreateDiscrepancy(intdrawerNumber, intBinNumber, intCurrentSystemCount, intEnteredAmount, CInt(LoggedInID), CInt(LoggedInID), intMedID)

            ' MessageBox.Show("Discrepancy detected and recorded")
        End If
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: txtQuantity_KeyPress               */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker        		          */   
    '/*		         DATE CREATED: 		 3/20/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	   this handles the limiting of dispensed mediaction quantity text
    '/*  box to not go above 1000 or below 1
    '/*********************************************************************/
    '/*  CALLED BY:  txtQuantityToDispense.KeyPress 	      			            
    '/*********************************************************************/          
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     sender
    '/*      e                                                             */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                                                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  AB    3/20/2021     Initial creation/rework of dispensing
    '/*********************************************************************/
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityToDispense.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")

        If IsNumeric(txtQuantityToDispense.Text) Then
            GraphicalUserInterfaceReusableMethods.MaxValue(CInt(sender.Text), 1000, txtQuantityToDispense)
        End If
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: txtQuantity_TextChanged               */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker        		          */   
    '/*		         DATE CREATED: 		 3/20/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	  this handles the limiting of dispensed mediaction quantity text
    '/*  box to not go above 1000 or below 1
    '/*********************************************************************/
    '/*  CALLED BY:   txtQuantityToDispense.Validated	      		         */                 
    '/*********************************************************************/
    '/*  CALLS:                               */            
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     sender
    '/*      e                                                             */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                                                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  AB    3/20/2021     Initial creation/rework of dispensing
    '/*********************************************************************/
    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantityToDispense.Validated
        If IsNumeric(sender.Text) Then
            GraphicalUserInterfaceReusableMethods.MaxValue(CInt(sender.Text), 1000, txtQuantityToDispense)
        Else
            MessageBox.Show("Please make sure you enter a positive number 1-1000")
            sender.Text = "1"
        End If
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: btnBack_Click               */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker        		          */   
    '/*		         DATE CREATED: 		 3/20/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	  this method handles the back button on the form, it will determine
    '/* if patientInfo or adhoc is the one who entered the dispensing flow 
    '/* then return to the correct one
    '/*********************************************************************/
    '/*  CALLED BY:   back button clicked     						                      */                            
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     sender
    '/*      e                                                             */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                                                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  AB    3/20/2021     Initial creation/rework of dispensing
    '/*********************************************************************/
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'check variable too see if adhoc or patientinfromation was the one who opened the form
        If intEnteredFromAdhoc = 0 Then
            frmPatientInfo.setPatientID(intPatientID)
            frmMain.OpenChildForm(frmPatientInfo)
        Else
            setintEntered(0)
            frmMain.OpenChildForm(frmAdHockDispense)
        End If
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: AdhocDispenseSetInformation               */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Alexander Beasecker        		          */   
    '/*		         DATE CREATED: 		 3/20/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	  this method will set the global variables that are only used in adhoc
    '/* dispensing
    '/*********************************************************************/
    '/*  CALLED BY:   adhocSetinformation	      						                      */                 
    '/*********************************************************************/                                        				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     amount As String
    '/* unit As String
    '/* intDrawerMedA As Integer
    '/*      e                                                             */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                                                  */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  AB    3/20/2021     Initial creation/rework of dispensing
    '/*********************************************************************/
    Public Sub AdhocDispenseSetInformation(ByRef amount As String, ByRef unit As String, ByRef intDrawerMedA As Integer, ByRef intDrawerNumber As Integer, ByRef intBin As Integer)
        strAmountAdhoc = amount
        strUnitAdhoc = unit
        intDrawerMEDAdhoc = intDrawerMedA
        intAdhocDrawerNumber = intDrawerNumber
        intAdhocBin = intBin
    End Sub

    Private Sub btnReopenDrawer_Click(sender As Object, e As EventArgs) Handles btnReopenDrawer.Click
        Dim intdrawerNumber As Integer = CreateDatabase.ExecuteScalarQuery("Select Drawers_TUID from DrawerMedication where Medication_TUID = '" & intMedicationID & "' and Active_Flag = '1'")
        OpenOneDrawer(intdrawerNumber)
    End Sub

    Private Sub UpdateDrawerCount(ByRef intAmountDispense As Integer, ByRef intAmountInDrawer As Integer, ByRef intDrawerNumber As Integer, ByRef intMedID As Integer)
        Dim intLeftover As Integer = intAmountInDrawer - intAmountDispense
        Dim intUpdateNumber As Integer = 0
        If intLeftover <= 0 Then
            intUpdateNumber = 0
        Else
            intUpdateNumber = intLeftover
        End If

        CreateDatabase.ExecuteInsertQuery("UPDATE DrawerMedication set Quantity = '" & intUpdateNumber & "' where Drawers_TUID = '" & intDrawerNumber & "' and Medication_TUID = '" & intMedID & "'")
    End Sub
End Class