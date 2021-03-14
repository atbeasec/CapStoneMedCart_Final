Public Class frmPatientInfo

    Private intPatientID As Integer
    Private intPatientMRN As Integer
    Public Enum DispenseHistoryEnum As Integer
        MedicationName = 1
        Strength = 2
        Type = 3
        Quantity = 4
        DispensedBy = 5
        DispenseDateAndTime = 6
    End Enum
    Public Enum PrescriptionsEnum As Integer
        MedicationName = 1
        Strength = 2
        Type = 3
        Quantity = 4
        DatePrescribed = 5
        PrescribedBy = 6
        Frequency = 7
    End Enum

    Public Sub setPatientID(ByVal ID As Integer)
        intPatientID = ID
        intPatientMRN = ExecuteScalarQuery("SELECT MRN_Number from Patient WHERE Patient_ID =" & intPatientID & ";")
        Debug.WriteLine("")
    End Sub
    Public Sub setPatientMrn(ByVal Mrn As Integer)
        intPatientMRN = Mrn
        intPatientID = ExecuteScalarQuery("SELECT Patient_ID from Patient WHERE MRN_Number =" & intPatientMRN & ";")
        Debug.WriteLine("")
    End Sub


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

        CreateToolTips(pnlPrescriptionsHeader, tpLabelDirections)
        CreateToolTips(pnlDispenseHistoryHeader, tpLabelDirections)

        AddHandlerToLabelClick(pnlDispenseHistoryHeader)
        AddHandlerToLabelClick(pnlPrescriptionsHeader)


        ' CreateDispenseHistoryPanels(flpDispenseHistory, "test", "test", "test", "test", "test", "test", "test")
    End Sub
    '/*********************************************************************/
    '/*            SubProgram NAME: CreateDispenseHistoryPanels()         */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/6/2021                         */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is routine is dynamically creates panels that are placed    */ 
    '/*	 inside of the flowpanel that is fixed on the form. The panels are*/
    '/*	 created here, assigned handlers, and the contents of the panels  */
    '/*	 are updated in this routine                                      */
    '/*********************************************************************/
    '/*  CALLED BY: frmConfiguration_Load  	      						  */           
    '/*                                                                   */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 NONE                                                             */ 
    '/* flpPannel- the flow panel which the user wants to create the      */
    '/*     create the single panel.                                      */
    '/* strMedicationName- medication name from the database we will display   
    '/* strStrength- strength value from the the database                 */
    '/* strType- type value from the database                             */
    '/* strQuantity- quantity value from the database                     */
    '/* strDispenseBy- dispensedby value from the database                */
    '/* strDispenseDate- dispense date from the database                  */
    '/* strDispenseTime=- dispense time from the database                 */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	 CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), dr(1), dr(2), dr(3), dr(4) & " " & dr(5), dr(6), "")   
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	pnl- is the pnl which we are creating for padding purposes        */
    '/* pnlMainPanel- is the pnl which we are going to add controls       */
    '/* lblID1 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID2 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID3 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID4 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID5 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID6 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  Collin Krygier  2/6/2021    Initial creation                     */
    '/*********************************************************************/
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

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblMedicationName", lblMedication.Location.X, 20, strMedicationName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblStrength", lblStrength.Location.X, 20, strStrength, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblType", lblType.Location.X, 20, strType, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblQuantity", lblQuantity.Location.X, 20, strQuantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblDispensedBy", lblDispensedBy.Location.X, 20, strDispenseBy, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblDispenseTimeAndDate", lblDateTime.Location.X, 20, strDispenseDate, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

        'currentContactPanel = pnl.Name

    End Sub
    '/*********************************************************************/
    '/*            SubProgram NAME: CreateDispenseHistoryPanels()         */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/6/2021                         */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is routine is dynamically creates panels that are placed    */ 
    '/*	 inside of the flowpanel that is fixed on the form. The panels are*/
    '/*	 created here, assigned handlers, and the contents of the panels  */
    '/*	 are updated in this routine                                      */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						  */           
    '/*                                                                   */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 NONE                                                             */ 
    '/* flpPannel- the flow panel which the user wants to create the      */
    '/*     create the single panel.                                      */
    '/* strMedicationName- medication name from the database we will display   
    '/* strStrength- strength value from the the database                 */
    '/* strFrequency - type frequency from the database                   */
    '/* strType- type value from the database                             */
    '/* strQuantity- quantity value from the database                     */
    '/* strDatePrescribed- dispense date from the database                */
    '/* strPrescribedBy- dispensedby value from the database              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	 CreateDispenseHistoryPanels(frmPatientInfo.flpDispenseHistory, dr(0), dr(1), dr(2), dr(3), dr(4) & " " & dr(5), dr(6), "")   
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	pnl- is the pnl which we are creating for padding purposes        */
    '/* pnlMainPanel- is the pnl which we are going to add controls       */
    '/* lblID1 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID2 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID3 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID4 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID5 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID6 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/* lblID7 - a new label that is used to contain the string passed in */
    '/*     to the sub routine.                                           */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  Collin Krygier  2/6/2021    Initial creation                     */
    '/*********************************************************************/
    Public Sub CreatePrescriptionsPanels(ByVal flpPannel As FlowLayoutPanel, ByVal strMedicationName As String, ByVal strStrength As String, ByVal strFrequency As String, ByVal strType As String, ByVal strQuantity As String, ByVal strDatePrescribed As String, ByVal strPrescribedBy As String)
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
        CreateIDLabel(pnlMainPanel, lblID, "lblMedicationPrescription", lblMedicationPrescription.Location.X, 20, strMedicationName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblStrengthPrescription", lblStrengthPrescription.Location.X, 20, strStrength, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblFrequencyPrescription", lblFrequencyPrescription.Location.X, 20, strFrequency, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblTypePrescription", lblTypePrescription.Location.X, 20, strType, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblQuantityPrescription", lblQuantityPrescription.Location.X, 20, strQuantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblDatePrescribed", lblDatePrescribed.Location.X, 20, strDatePrescribed, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID7, "lblPrescribedBy", lblPrescribedBy.Location.X, 20, strPrescribedBy, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: CreateToolTips                 */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to iterate over the  panel that contains labels and*/
    '/*  assign each label a tooltip
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*      frmPatientInfo_load      */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                           */  
    '/*              
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 PanelWithLabels- a panel which contains only labels              */ 
    '/*	 tp- a tooltip control                                            */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	CreateToolTips(Panel1, ToolTip1)     							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	directions- string to be appended                                 */
    '/*	newDirections- result of the appending of strings                 */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub CreateToolTips(ByVal PanelWithLabels As Panel, ByVal tp As ToolTip)

        'iterating over the header panel which will only contain labels within it
        'each label needs to have a tooltip added to it.

        Dim directions As String = "click to sort by "


        For Each ctl In PanelWithLabels.Controls

            Dim newDirections As String = Nothing
            newDirections = directions & CStr(ctl.Text)
            tp.SetToolTip(ctl, newDirections)

        Next

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: AddHandlerToLabelClick         */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to iterate over the  panel that contains labels and*/
    '/*  assign each label a a click event handler                        */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*      frmPatientInfo_load                                          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 PanelWithLabels- a panel which contains only labels              */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	AddHandlerToLabelClick(Panel1)     							      */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	lbl- label control*/
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub AddHandlerToLabelClick(ByVal PanelWithLabels As Panel)

        'assign a handler to each label in the header panels to allow for a reusable click event

        Dim lbl As Label

        For Each lbl In PanelWithLabels.Controls
            AddHandler lbl.Click, AddressOf SortBySelectedLabel
        Next

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: BoldLabelToSortBy              */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to iterate over the  panel that contains labels and*/
    '/*  check which one selected and change the font to be underlined    */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*      frmPatientInfo_load                                          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 clickedLabel- a label that was selected                          */ 
    '/*	 parent- a panel object that the label lives on                   */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	 BoldLabelToSortBy(sender, parent)     							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	lbl- label control*/
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub BoldLabelToSortBy(ByVal clickedLabel As Label, ByVal parent As Panel)

        Dim lbl As Label
        ' remove underlined font from all labels
        For Each lbl In parent.Controls
            lbl.Font = New Font(New FontFamily("Segoe UI Semibold"), 12, FontStyle.Regular)

        Next

        ' underline just the selected label
        clickedLabel.Font = New Font(New FontFamily("Segoe UI Semibold"), 12, FontStyle.Underline)

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: SortBySelectedLabel            */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to be called as the click event for any label the  */
    '/*  user clicks on. Underline the label, and update the panel contents/
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*      frmPatientInfo_load                                          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 field- an integer equal to the tag value of the selected label   */ 
    '/*	 parent- a panel object that the label lives on                   */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	 BoldLabelToSortBy(sender, parent)     							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	lbl- label control*/
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub SortBySelectedLabel(sender As Object, e As EventArgs)

        ' if we know the parent then we can determine if we need the prescription table
        ' or if we need the dispense history tables

        Dim parent As Panel = sender.parent
        Dim field As Integer = CInt(sender.tag)

        BoldLabelToSortBy(sender, parent)

        'check If the user Is selecting a dispense history field to sort by
        If parent.Name = pnlDispenseHistoryHeader.Name Then

            DispenseHistorySelectedField(field)
        Else
            PrescriptionsSelectedField(field)
        End If

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: DispenseHistorySelectedField   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to be called when a user selects a label to sort by*/
    '/*  the logic to re-create the panels in the order will be caled here*/
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*      frmPatientInfo_load                                          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 field- an integer equal to the tag value of the selected label   */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	 DispenseHistorySelectedField(Cint(Label1.Tag))   	              */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	none                                                              */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub DispenseHistorySelectedField(ByVal field As Integer)

        ' clear the controls as they will need to be rebuilt when sorting
        ' flpDispenseHistory.Controls.Clear()

        Select Case field

            Case DispenseHistoryEnum.MedicationName

            Case DispenseHistoryEnum.Strength

            Case DispenseHistoryEnum.Type

            Case DispenseHistoryEnum.Quantity

            Case DispenseHistoryEnum.DispensedBy

            Case DispenseHistoryEnum.DispenseDateAndTime

        End Select


    End Sub


    '/*********************************************************************/
    '/*                   SubProgram NAME: PrescriptionsSelectedField     */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to be called when a user selects a label to sort by*/
    '/*  the logic to re-create the panels in the order will be caled here*/
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*      frmPatientInfo_load                                          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*PatientInformation.PatinetInfoSortedByDrugName(intPatientID)
    '/*PatientInformation.PatinetInfoSortedByStrength(intPatientID)
    '/*PatientInformation.PatinetInfoSortedByType(intPatientID)
    '/*PatientInformation.PatinetInfoSortedByQuantity(intPatientID)
    '/*PatientInformation.PatinetInfoSortedByDate(intPatientID)
    '/*PatientInformation.PatinetInfoSortedByDoctor(intPatientID)
    '/*PatientInformation.PatinetInfoSortedByFrequency(intPatientID)      */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 field- an integer equal to the tag value of the selected label   */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	 PrescriptionsSelectedField(Cint(Label1.Tag))   				  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	none                                                              */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub PrescriptionsSelectedField(ByVal field As Integer)

        ' clear the controls as they will need to be rebuilt when sorting
        flpMedications.Controls.Clear()

        Select Case field
            Case PrescriptionsEnum.MedicationName
                PatientInformation.PatinetInfoSortedByDrugName(intPatientID)
            Case PrescriptionsEnum.Strength
                PatientInformation.PatinetInfoSortedByStrength(intPatientID)
            Case PrescriptionsEnum.Type
                PatientInformation.PatinetInfoSortedByType(intPatientID)
            Case PrescriptionsEnum.Quantity
                PatientInformation.PatinetInfoSortedByQuantity(intPatientID)
            Case PrescriptionsEnum.DatePrescribed
                PatientInformation.PatinetInfoSortedByDate(intPatientID)
            Case PrescriptionsEnum.PrescribedBy
                PatientInformation.PatinetInfoSortedByDoctor(intPatientID)
            Case PrescriptionsEnum.Frequency
                PatientInformation.PatinetInfoSortedByFrequency(intPatientID)
        End Select

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

        frmDispense.SetPatientID(intPatientID)
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