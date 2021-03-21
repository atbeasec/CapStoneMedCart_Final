﻿Public Class frmMain

    Private frmCurrentChildForm As Form
    Private frmPreviousChildForm As Form

    Public Enum SelectedForm As Integer
        PatientRecordsDropDown = 1
        AllPatients = 2
        MyPatients = 3
        InventoryDropDown = 4
        AdHocDispense = 5
        EndOfShiftCount = 6
        Inventory = 7
        Waste = 8
        Report = 9
        Discrepancies = 10
        Maintenance = 11
        Pharmacy = 12
        SettingsDropDown = 13
        ConfigureUserPermissions = 14
        Discharge = 15
        ConfigureRooms = 16
        SerialPortSettings = 17
        EditPhysician = 18
        LogOut = 19
    End Enum

    '/*********************************************************************/
    '/*                   SubProgram NAME: btnMenu_Click                  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to iterate over the  panel on the side menu which  */
    '/*  contains buttons that are docked. The purpose of this method is to/
    '/*  determine which button is selected and indicate to the user it is*/
    '/*  selected by setting the control color to indicate it is selected */
    '/*  or is not selected.                                              */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*       all buttons listed as having a handle assignment to it      */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*              DetermineFormToOpen()                                */  
    '/*              
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender object, e event args                                      */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	ExtractFormDataForDatabase()        							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	ctlControl- a control representing all of the controls in the side*/
    '/* the side menu.                                                    */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnAllPatients.Click, btnMyPatients.Click, btnAdhockDispense.Click, btnEndOfShiftCount.Click, btnConfigureInventory.Click, btnWaste.Click, btnReport.Click, btnDescrepancies.Click, btnMaintenance.Click, btnPharmacy.Click, btnUsers.Click, btnDischargePatient.Click, btnEditRooms.Click, btnSerialPort.Click, btnEditPhysician.Click



        ' ensure that the colors of the buttons change accordingly. We need to know which button is clicked,
        ' and then change the backgroud tot he correct blue color. When this happens we need to change the other buttons
        ' color back to the default RGB blue of 0,0,64

        DetermineFormToOpen(CInt(sender.tag))

        Dim ctlControl As Control

        For Each ctlControl In pnlSideMenu.Controls

            If TypeName(ctlControl) = "Button" Then

                If sender.Name = ctlControl.Name Then
                    ' set the color of the control to indicate it is selected
                    If sender.backColor = Color.FromArgb(71, 103, 216) Then

                        sender.backColor = Color.FromArgb(38, 61, 147)

                    End If
                Else
                    ' set the color of the control to indicate it is not selected, so we reset the color back to the default RGB specified
                    ctlControl.BackColor = Color.FromArgb(71, 103, 216)
                End If
            End If
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: OpenChildForm                  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to allow for a form to placed inside of a flow panel/
    '/*  changing the form hierarchy to be equivelent to that of a control./
    '/*  with that established, it allows for a form to be placed into any*/
    '/*  control object that we choose.                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*       DetermineFormToOpen()                                       */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             none                                                  */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 frmChil- a form that needs to become placed inside of the panel  */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	OpenChildForm(frmMainForm)            							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	    none                                                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/

    Sub OpenChildForm(ByVal frmChild As Form)

        ' this is where we dock the form as a frmChild form onto the panel
        ' if there is currently a form here we need to close it


        If Not frmPreviousChildForm Is Nothing Then
            If Not frmPreviousChildForm Is frmChild Then
                frmPreviousChildForm.Close()
                Debug.Print("We should be closing the frmChild form now")
            End If

        End If

        frmPreviousChildForm = frmChild
        'frmChild.TopMost = False
        frmChild.TopLevel = False
        ' removes boarder on form which is where someone can close the form. We will close it on button clicks instead
        frmChild.FormBorderStyle = FormBorderStyle.None

        frmChild.Parent = Me

        'add form to panel
        Me.pnlDockLocation.Controls.Add(frmChild)

        'make form visible
        frmChild.Show()

        For Each ctl In frmChild.Controls
            Debug.Print(ctl.name)
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: DetermineFormToOpen            */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This identifies what to do with the button the user has selected */
    '/* specifically, there selection indicates which form they want to see/
    '/* next. The select case statement maps the buttons to the proper forms
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*      btnMenu_Click                                                */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*      HideSettingsSubMenu()                                        */  
    '/*      HideInventorySubMenu()                                       */  
    '/*      OpenChildForm()                                              */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 intTagNum- a number placed in the tag field of all buttons in the*/ 
    '/*  left menu. This index allows us to identify exactly which button */
    '/*  sender is and what we need to do next with that information.     */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	DetermineFormToOpen(tagNum)            							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	    intValue- integer value from the button tag field             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/

    Public Sub DetermineFormToOpen(ByVal intTagNum As Integer)

        ' based on the button that is clicked this is where we decide
        ' which form we need to open
        Dim intValue As Integer = intTagNum
        Debug.Print(intValue)

        Select Case intValue

            Case SelectedForm.PatientRecordsDropDown

                'nothing will happen here because we have a submenu that needs to be displayed to show more buttons
                'more buttons will be shown and we will take the tag num of those to determine which form to dock

            Case SelectedForm.AllPatients

                frmCurrentChildForm = frmPatientRecords
                OpenChildForm(frmPatientRecords)

            Case SelectedForm.MyPatients

                frmCurrentChildForm = frmMyPatients
                OpenChildForm(frmMyPatients)

            Case SelectedForm.InventoryDropDown

                'nothing will happen here because we have a submenu that needs to be displayed to show more buttons
                'more buttons will be shown and we will take the tag num of those to determine which form to dock

            Case SelectedForm.AdHocDispense

                frmCurrentChildForm = frmAdHockDispense
                OpenChildForm(frmAdHockDispense)

            Case SelectedForm.EndOfShiftCount

                frmCurrentChildForm = frmEndOfShift
                OpenChildForm(frmEndOfShift)

            Case SelectedForm.Inventory

                frmCurrentChildForm = frmInventory
                OpenChildForm(frmConfigureInventory)

            Case SelectedForm.Waste

                frmCurrentChildForm = frmWaste
                OpenChildForm(frmWaste)

            Case SelectedForm.Report

                frmCurrentChildForm = frmReport
                OpenChildForm(frmReport)
                HideSubMenu(pnlSubMenuSettings)
                HideSubMenu(pnlSubMenuPatientRecords)
                HideSubMenu(pnlSubMenuInventory)

            Case SelectedForm.Discrepancies

                frmCurrentChildForm = frmDiscrepancies
                OpenChildForm(frmDiscrepancies)
                HideSubMenu(pnlSubMenuSettings)
                HideSubMenu(pnlSubMenuPatientRecords)
                HideSubMenu(pnlSubMenuInventory)

            Case SelectedForm.Maintenance

                frmCurrentChildForm = frmMaintenance
                OpenChildForm(frmMaintenance)
                HideSubMenu(pnlSubMenuSettings)
                HideSubMenu(pnlSubMenuPatientRecords)
                HideSubMenu(pnlSubMenuInventory)

            Case SelectedForm.Pharmacy

                frmCurrentChildForm = frmPharmacy
                OpenChildForm(frmPharmacy)
                HideSubMenu(pnlSubMenuSettings)
                HideSubMenu(pnlSubMenuPatientRecords)
                HideSubMenu(pnlSubMenuInventory)

            Case SelectedForm.SettingsDropDown

                'nothing will happen here because we have a submenu that needs to be displayed to show more buttons
                'more buttons will be shown and we will take the tag num of those to determine which form to dock

            Case SelectedForm.ConfigureUserPermissions

                frmCurrentChildForm = frmConfiguration
                OpenChildForm(frmConfiguration)

            Case SelectedForm.Discharge

                frmCurrentChildForm = frmDischarge
                OpenChildForm(frmDischarge)

            Case SelectedForm.ConfigureRooms

                frmCurrentChildForm = frmConfigureRooms
                OpenChildForm(frmConfigureRooms)

            Case SelectedForm.SerialPortSettings

                frmCurrentChildForm = frmSerialPort
                OpenChildForm(frmSerialPort)

            Case SelectedForm.EditPhysician

                frmCurrentChildForm = frmEditPhysician
                OpenChildForm(frmEditPhysician)

            Case SelectedForm.LogOut

                'call method here to ask if we are sure that we really want to log out of the system
                Me.Hide()
                frmLoginScan.Show()
                '   Case 9
                '      frmCurrentChildForm = frmAdminSettings
                '     OpenChildForm(frmAdminSettings)
        End Select

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: frmMain_Load                   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This identifies what to do when the form loads for the first time*/
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                                                   */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*       CreateDatabase.Main()                                       */  
    '/*       AssignHandlersToSubMenuItems()                              */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                     							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	    none                                                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Runs the database creation module to determine if the database was created
        CreateDatabase.Main()

        'CheckUserPermissions()

        'set submenu to be invisible on form load
        pnlSubMenuSettings.Visible = False
        pnlSubMenuInventory.Visible = False

        AssignHandlersToSubMenuButtons(pnlSubMenuInventory)
        AssignHandlersToSubMenuButtons(pnlSubMenuSettings)
        AssignHandlersToSubMenuButtons(pnlSubMenuPatientRecords)

        'set the patient records form to be selected on default application startup
        btnAllPatients.PerformClick()
        Me.Text = "Medical Dispense"

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: btnSettings_Click              */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This identifies what to do when the settings button is clicked   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*          none                                                     */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*      ShowOrHideSubMenu                                            */ 
    '/*      HideSubMenu                                                  */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                     							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	    none                                                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        HideSubMenu(pnlSubMenuInventory)
        HideSubMenu(pnlSubMenuPatientRecords)
        ShowOrHideSubMenu(pnlSubMenuSettings)

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: btnSettings_Click              */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This identifies what to do when the inventory button is clicked  */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*          none                                                     */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*      ShowOrHideSubMenu                                            */ 
    '/*      HideSubMenu                                                  */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                     							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	    none                                                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click

        HideSubMenu(pnlSubMenuSettings)
        HideSubMenu(pnlSubMenuPatientRecords)
        ShowOrHideSubMenu(pnlSubMenuInventory)

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: btnPatientRecords_Click        */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This identifies what to do when the patient records button is    */
    '/*  clicked                                                          */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*          none                                                     */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*      ShowOrHideSubMenu                                            */ 
    '/*      HideSubMenu                                                  */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                                     							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	    none                                                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub btnPatientRecords_Click(sender As Object, e As EventArgs) Handles btnPatientRecords.Click

        HideSubMenu(pnlSubMenuSettings)
        HideSubMenu(pnlSubMenuInventory)
        ShowOrHideSubMenu(pnlSubMenuPatientRecords)

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: HideSubMenu                    */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This forces the submenu to be hidden                             */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*       determine form to open                                      */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*      ResetButtonColorsAfterClosingTab                             */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	none                                                              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	      ShowOrHideSettingsSubMenu                     			  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	    none                                                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Public Sub HideSubMenu(ByVal PanelToHide As Panel)

        If PanelToHide.Visible = True Then
            PanelToHide.Visible = False
            ResetButtonColorsAfterClosingTab(PanelToHide)
        End If

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: ShowOrHideSettingsSubMenu      */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This identifies whether the sub menu needs to be shown           */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*          btnInventory_Click                                       */  
    '/*          btnPatientRecords_Click                                  */ 
    '/*          btnSettings_Click                                        */ 
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*      ResetButtonColorsAfterClosingTab                             */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	none                                                              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	      ShowOrHideInventorySubMenu                     			  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	    none                                                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub ShowOrHideSubMenu(ByVal PanelToShowOrHide As Panel)

        If PanelToShowOrHide.Visible = False Then

            PanelToShowOrHide.Visible = True
        Else
            PanelToShowOrHide.Visible = False
            ResetButtonColorsAfterClosingTab(PanelToShowOrHide)

        End If

    End Sub


    Private Sub CheckUserPermissions()

        ' do database query to check user permission level
        ' select from case statement to determine which level the user is
        ' have 3 methods, one for each permission level, iterating over the controls that are needed to be
        ' removed from the control based on what the user should see

        'need to remove these for everyone on form load

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: AssignHandlersToSubMenuButtons */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This identifies all of the buttons in a submenu on the menu      */
    '/*  system and assigns it to be a a different back color than the rest/
    '/*  of the  menu items. It also assigns the click event dynamically to/
    '/*  so as new sub menu buttons are added, there colors are automatically
    '/*  handled here and their functionality is correct.                 */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*          frmMain_Load                                             */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*    none                                                           */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	PanelSubMenu which is a panel object on the form                  */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	      AssignHandlersToSubMenuItems()                   			  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/* btnButton- a control object that will be casted to contain a button/
    '/* ctlControl- a control object that will represent buttons          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub AssignHandlersToSubMenuButtons(ByVal PanelSubMenu As Panel)

        Dim ctlControl As Control
        Dim btnButton As Button

        ' iterating over all of the submenu panels
        For Each ctlControl In PanelSubMenu.Controls
            If TypeName(ctlControl) = "Button" Then

                'cast to a button allowing access to button properties
                btnButton = CType(ctlControl, Button)

                AddHandler btnButton.Click, AddressOf SubMenu_Click

            End If
        Next

    End Sub


    '/*********************************************************************/
    '/*                   SubProgram NAME: SubMenu_Click                  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is called everytime a button in the submenu is clicked.     */
    '/* when this happens, the back color needs to be updated depending if*/
    '/* if the user is selecting the button or selecting a new one        */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*          AssignHandlersToSubMenuItems                             */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*    none                                                           */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	none                                                              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	      AssignHandlersToSubMenuItems()                   			  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/* btnButton- a control object that will be casted to contain a button/
    '/* ctlControl- a control object that will represent buttons          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub SubMenu_Click(sender As Object, e As EventArgs)

        'changes the background color when the mouse clicks the submenu buttons

        Dim arrPanels As Panel() = {pnlSubMenuSettings, pnlSubMenuPatientRecords, pnlSubMenuInventory}
        ' arrPanels = 

        Dim ctlControl As Control
        Dim btnButton As Button

        ' iterating over all of the submenu panels
        For Each pnl In arrPanels

            For Each ctlControl In pnl.Controls
                If TypeName(ctlControl) = "Button" Then

                    ' cast to a button
                    btnButton = CType(ctlControl, Button)

                    ' set the backcolor of the control depending on the current back color of it
                    If sender.Name = ctlControl.Name Then

                        If sender.backColor = Color.FromArgb(60, 80, 150) Then
                            sender.ForeColor = Color.Black
                            sender.BackColor = Color.White
                            sender.FlatAppearance.BorderSize = 0
                        End If
                    Else
                        btnButton.BackColor = Color.FromArgb(60, 80, 150)
                        btnButton.ForeColor = Color.White
                        btnButton.FlatAppearance.BorderSize = 1
                    End If

                End If
            Next
        Next

    End Sub

    '/*********************************************************************/
    '/*           SubProgram NAME: ResetButtonColorsAfterClosingTab       */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is called everytime a button in the submenu is clicked.     */
    '/* when this happens, the back color needs to be updated depending if*/
    '/* if the user is selecting the button or selecting a new one        */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */
    '/*          ShowOrHideSettingsSubMenu                                */     
    '/*          HideSettingsSubMenu                                      */   
    '/*          ShowOrHideInventorySubMenu                               */     
    '/*          HideInventorySubMenu                                     */  
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*    none                                                           */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	none                                                              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	      AssignHandlersToSubMenuItems()                   			  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/* ctlControl- a control object that will represent buttons          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub ResetButtonColorsAfterClosingTab(pnl As Panel)

        Dim ctlControl As Control

        For Each ctlControl In pnl.Controls
            ctlControl.BackColor = Color.FromArgb(60, 80, 150)
            ctlControl.ForeColor = Color.White
        Next

    End Sub


    '/*********************************************************************/
    '/*           SubProgram NAME: btnLogout_Click                         */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */
    '*/  
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*    none                                                           */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	none                                                              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	                      			  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*        */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        ' not commenting because functionality will change as the form that the program starts up with is going to
        ' to change and this functionality will too.

        Me.Hide()
        frmLoginScan.Show()

    End Sub


End Class
