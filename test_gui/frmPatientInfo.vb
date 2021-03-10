Public Class frmPatientInfo

    Private intPatientID As Integer

    Public Sub setPatientMrn(ByVal ID As Integer)

        intPatientID = ID

    End Sub

    'Dim ContactPanelsAddedCount As Integer = 0
    'Dim CurrentContactPanelName As String = Nothing


    'Dim CurrentChartPanelName As String = Nothing
    'Dim ChartPanelsAddedCount As Integer = 0


    'Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)

    '    'the parent of the button will be the panel the control is located on.
    '    'we want to get one step removed so we need to next take the parent of the control
    '    ' to get the name of flowpanel which the button is laid out on
    '    Dim control As Control = sender.Parent
    '    Dim parents As Control = control.Parent



    '    Dim parentFlowPanel As Control = control.Parent
    '    'Dim strFlowPanelName As String = control.Parent.Name

    '    ' Debug.Print(control.Parent.Name)

    '    Dim parentPanelName As String

    '    parentPanelName = Nothing

    '    'Remove handler from sender
    '    For Each controlObj As Control In parentFlowPanel.Controls
    '        For Each childControlObj As Control In controlObj.Controls
    '            If childControlObj.Name = sender.name Then

    '                RemoveHandler childControlObj.Click, AddressOf DynamicButton_Click

    '                parentPanelName = childControlObj.Parent.Name
    '            End If
    '        Next
    '    Next



    '    'Remove contact panel
    '    For Each controlObj As Control In parentFlowPanel.Controls
    '        If controlObj.Name = parentPanelName Then

    '            ' prompt user if they are sure they want to delete the record


    '            ' remove the record from the database

    '            'remove the padding panel from the flow panel
    '            '  flpMedications.Controls.Remove(controlObj.Parent)
    '            controlObj.Parent.Dispose()

    '            'remove the panel from the flow panel
    '            '  flpMedications.Controls.Remove(controlObj)
    '            controlObj.Dispose()


    '        End If
    '    Next

    'parents.Name
    ' Dim connn As Control = parentFlowPanel.Parent
    'Debug.Print(connn.Name)
    'Debug.Print(parentFlowPanel.Name)
    'UpdateCamerasSubtotalLabel(parentFlowPanel)

    'End Sub

    '  Public Sub New()


    ' This call is required by the designer.
    '     InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

    ' End Sub

    Public Sub DynamicButtonEditRecord_Click(ByVal sender As Object, ByVal e As EventArgs)

        'show the add new patient form filled in with the patients infromation
        'frmNewPatient.Show()

        'we call our  edit medication form

    End Sub


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: frmPatientInfo_Load  		   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		         */   
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
    '/*  NP    2/16/2021 Changed cboBed to be disabled by default until a */
    '/*                  selection in room is made.                       */
    '/*  NP   2/16/2021  added a call to the GetRoom method in            */
    '/*                  PatientInformation*/
    '/*********************************************************************/

    Private Sub frmPatientInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ctl As Control = Nothing

        'cboBed.Enabled = False 'this will stop the people from selecting a bed before they
        'select a room. 

        ' intPatientMRN = txtMRN.Text
        PatientInformation.GetAllergies(intPatientID)
        PatientInformation.GetPatientInformation(intPatientID)
        PatientInformation.getPrescriptions(intPatientID)
        PatientInformation.getRoom(intPatientID, cboRoom, cboBed)
        SetControlsToReadOnly(ctl)

        ' CreateDispenseHistoryPanels(flpDispenseHistory, "test", "test", "test", "test", "test", "test", "test")
    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  CreateDispenseHistoryPanels   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		                          */   
    '/*		              DATE CREATED: 	                              */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */             
    '/*											                          */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             (NONE)								                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											                          */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                   */
    '/*********************************************************************/
    Public Sub CreateDispenseHistoryPanels(ByVal flpPannel As FlowLayoutPanel, ByVal medicationName As String, ByVal strength As String, ByVal type As String, ByVal quantity As String, ByVal dispenseBy As String, ByVal dispenseDate As String, ByVal dispenseTime As String)

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

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblMedicationName", lblMedication.Location.X, 20, medicationName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblStrength", lblStrength.Location.X, 20, strength, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblType", lblType.Location.X, 20, type, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblQuantity", lblQuantity.Location.X, 20, quantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblDispensedBy", lblDispensedBy.Location.X, 20, dispenseBy, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblDispenseTimeAndDate", lblDateTime.Location.X, 20, dispenseDate, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

        'currentContactPanel = pnl.Name

    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: CreatePrescriptionsPanels 	  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		                          */   
    '/*		              DATE CREATED: 	                              */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */             
    '/*											                          */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             (NONE)								                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											                          */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                   */
    '/*********************************************************************/
    Public Sub CreatePrescriptionsPanels(ByVal flpPannel As FlowLayoutPanel, ByVal medicationName As String, ByVal strength As String, ByVal frequency As String, ByVal type As String, ByVal quantity As String, ByVal datePrescribed As String, ByVal PrescribedBy As String)
        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


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
        Dim lblID7 As New Label

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        ' to ensure all of the text being added to the panel is inline with the  headers, we will use the label location of the
        ' header as the reference point for the X axis when creating these labels at run time.
        CreateIDLabel(pnlMainPanel, lblID, "lblMedicationPrescription", lblMedicationPrescription.Location.X, 20, medicationName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblStrengthPrescription", lblStrengthPrescription.Location.X, 20, strength, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblFrequencyPrescription", lblFrequencyPrescription.Location.X, 20, frequency, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblTypePrescription", lblTypePrescription.Location.X, 20, type, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblQuantityPrescription", lblQuantityPrescription.Location.X, 20, quantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblDatePrescribed", lblDatePrescribed.Location.X, 20, datePrescribed, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID7, "lblPrescribedBy", lblPrescribedBy.Location.X, 20, PrescribedBy, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

        'currentContactPanel = pnl.Name

    End Sub
    Private Sub PopulateNotes()

        ' CreateNotesPanels(flpNotes, "Customer had an allergic reaction to the phenylephrine")
        'CreateNotesPanels(flpNotes,)
        'CreateNotesPanels(flpNotes,)


    End Sub




    Private Sub DynamicDownloadButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DynamicDocumentDeleteButton_Click(sender As Object, e As EventArgs)


    End Sub

    '/*********************************************************************/
    '/*                   FUNCTION NAME:  					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		         */   
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
    '/*  NP    2/18/2021 Changed it so that the combo boxes are enabled when*/
    '/*                  a user clikcs the edit button.                     */
    '/*  NP   2/18/2021  Made it so the comboboxes are enabled and disabled*/
    '/*                  based on the text of the edit button.             */
    '/*********************************************************************/


    Private Sub btnEditPatient_Click(sender As Object, e As EventArgs) Handles btnEditPatient.Click

        Dim ctl As Control = Nothing

        Dim arrPnl As Panel() = {pnlPersonalInformation}

        If Not btnEditPatient.Text = "Save Changes" Then

            SetControlsToAllowEdit(ctl)

            btnEditPatient.Text = "Save Changes"

        Else
            SetControlsToReadOnly(ctl)
            btnEditPatient.Text = "Edit Patient"
        End If

    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: CreatePrescriptionsPanels 	  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		                          */   
    '/*		              DATE CREATED: 	                              */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */             
    '/*											                          */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             (NONE)								                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											                          */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                   */
    '/*********************************************************************/
    Private Sub SetControlsToAllowEdit(ByVal ctl As Control)

        For Each ctl In pnlPersonalInformation.Controls

            If TypeName(ctl) = "TextBox" Then
                Dim txtbox As TextBox = CType(ctl, TextBox)

                txtbox.ReadOnly = False
                txtbox.BorderStyle = BorderStyle.FixedSingle
                txtbox.BackColor = Color.White

            ElseIf TypeName(ctl) = "ComboBox" Then

                Dim cmbBox As ComboBox = CType(ctl, ComboBox)
                cmbBox.Enabled = True

                'cboBed.Enabled = False
                'cboRoom.Enabled = False
            End If
        Next

    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: SetControlsToReadOnly     	  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		                          */   
    '/*		              DATE CREATED: 	                              */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */             
    '/*											                          */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             (NONE)								                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											                          */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                   */
    '/*********************************************************************/
    Private Sub SetControlsToReadOnly(ByVal ctl As Control)

        For Each ctl In pnlPersonalInformation.Controls

            If TypeName(ctl) = "TextBox" Then
                Dim txtbox As TextBox = CType(ctl, TextBox)

                txtbox.ReadOnly = True
                ' txtbox.BorderStyle = BorderStyle.None
                txtbox.BackColor = Color.White


            ElseIf TypeName(ctl) = "ComboBox" Then
                Dim cmbBox As ComboBox = CType(ctl, ComboBox)

                cmbBox.BackColor = Color.White
                cmbBox.Enabled = False

            End If
        Next
        cboBed.Enabled = False
        cboRoom.Enabled = False
    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: btnDispenseMedication_Click 	  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		                          */   
    '/*		              DATE CREATED: 	                              */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */             
    '/*											                          */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             (NONE)								                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											                          */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                   */
    '/*********************************************************************/
    Private Sub btnDispenseMedication_Click(sender As Object, e As EventArgs) Handles btnDispenseMedication.Click

        ' pass MRN to the dispense screen because it needs to be used to be sent back to the patient info screen if the user
        ' decides to go back a screen.

        frmDispense.SetPatientMrn(intPatientID)
        frmMain.OpenChildForm(frmDispense)
        DispenseHistory.DispensemedicationPopulate(intPatientID)
        PatientInformation.PopulatePatientDispenseInfo(intPatientID)
        PatientInformation.PopulatePatientAllergiesDispenseInfo(intPatientID)
        PatientInformation.DisplayPatientPrescriptionsDispense(intPatientID)
        '  Dim frmCurrentForm As Form = Me


    End Sub

    ' Private Sub Button1_Click(sender As Object, e As EventArgs)
    '     Returns.Show()
    '  End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: btnWaste_Click            	  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		                          */   
    '/*		              DATE CREATED: 	                              */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */             
    '/*											                          */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             (NONE)								                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											                          */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                   */
    '/*********************************************************************/
    Private Sub btnWaste_Click(sender As Object, e As EventArgs) Handles btnWaste.Click

        Waste.SetPatientMRN(intPatientID) 'this should set the patient MRN using the given patientID
        frmMain.OpenChildForm(Waste)

    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: btnAddAllergies_Click     	  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		                          */   
    '/*		              DATE CREATED: 	                              */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */             
    '/*											                          */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             (NONE)								                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											                          */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                   */
    '/*********************************************************************/
    Private Sub btnAddAllergies_Click(sender As Object, e As EventArgs) Handles btnAddAllergies.Click

        ' pass the MRN of the current patient to the next form
        frmAllergies.SetPatientMrn(CInt(txtMRN.Text))

        ' closing this form and making the main container open the allergies page
        frmMain.OpenChildForm(frmAllergies)
    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: btnBack_Click            	  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:     		                          */   
    '/*		              DATE CREATED: 	                              */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:								                  */             
    '/*											                          */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             (NONE)								                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											                          */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											                          */                     
    '/*                                                                   */  
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                   */
    '/*********************************************************************/
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmMain.OpenChildForm(frmPatientRecords)

    End Sub


    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  cboRoom_SelectedIndexChanged  */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Nathan Premo   		               */   
    '/*		         DATE CREATED: 	2/16/2021                       	   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:								   */             
    '/*	 This is going to update the cboBed list based on the selection in */
    '/*  cboRoom. It will also try to save the selection made in the bed if*/
    '/*  one is already made and try to re assign that. If it can't reassign*/
    '/*  the old value it will just leave the cboBed selectItem blank. This*/
    '/*  so when the form is first loaded if a person has a bed they won't */
    '/*  lose it when the form is loaded.                                  */
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
    '/*  strTemp - this is going to hold the old value that was selected in*/                     
    '/*            cboBed and try to reassign it later.                    */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*                                                                     
    '/*********************************************************************/

    Private Sub cboRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoom.SelectedIndexChanged
        cboBed.Enabled = True
        Dim strTemp As String = ""

        If Not cboBed.SelectedIndex = -1 Then
            strTemp = cboBed.SelectedItem
        End If
        cboBed.SelectedIndex = -1
        PopulateRoomsCombBoxesMethods.UpdateBedComboBox(cboBed, cboRoom)
        If cboBed.Items.Contains(strTemp) Then
            cboBed.SelectedItem = strTemp
        End If

    End Sub


End Class