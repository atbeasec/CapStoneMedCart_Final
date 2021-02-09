Public Class frmPatientInfo

    Dim intPatientMRN As Integer = frmPatientRecords.intSelectedPatientMRN
    Dim ContactPanelsAddedCount As Integer = 0
    Dim CurrentContactPanelName As String = Nothing

    Dim CurrentChartPanelName As String = Nothing
    Dim ChartPanelsAddedCount As Integer = 0

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dispense.Show()
    End Sub

    'Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel)

    '    Dim pnl As Panel
    '    pnl = New Panel

    '    Dim pnlMainPanel As Panel
    '    pnlMainPanel = New Panel
    '    ' call method here to get the count from the database and update the panel number so the next item is correct


    '    'Set panel properties
    '    With pnl
    '        .BackColor = Color.Gainsboro
    '        .Size = New Size(515, 47)
    '        .Name = "pnlIndividualPatientRecordPadding" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Padding = New Padding(0, 0, 0, 3)
    '        ' .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    With pnlMainPanel

    '        .BackColor = Color.White
    '        .Size = New Size(515, 45)
    '        .Name = "pnlIndividualPatientRecord" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    'put the boarder panel inside the main panel
    '    pnl.Controls.Add(pnlMainPanel)



    '    ' add controls to this panel

    '    CreateContactDeleteBtn(pnlMainPanel, 445, 5)
    '    '   CreateEditButton(pnlMainPanel)


    '    ' call database info here to populate
    '    Dim lblID As New Label
    '    Dim lblID2 As New Label
    '    Dim lblID3 As New Label
    '    Dim lblID4 As New Label
    '    Dim lblID5 As New Label
    '    Dim lblID6 As New Label

    '    Dim location As New Point(10, 20)
    '    Dim location2 As New Point(95, 20)
    '    Dim location3 As New Point(220, 20)
    '    Dim location4 As New Point(320, 20)
    '    Dim location5 As New Point(395, 20)
    '    Dim location6 As New Point(500, 20)

    '    CreateIDLabel(pnlMainPanel, lblID, "lblID", 10, 20, "Oxycontin")
    '    CreateIDLabel(pnlMainPanel, lblID2, "lblGenericName", 190, 20, "1")
    '    CreateIDLabel(pnlMainPanel, lblID3, "lblBrandName", 330, 20, "2 MG")
    '    'CreateIDLabel(pnlMainPanel, lblID4, "lblQuantity", 455, 20, "21")
    '    'CreateIDLabel(pnlMainPanel, lblID5, "lblMeasure", 560, 20, "250 MG")
    '    'CreateIDLabel(pnlMainPanel, lblID6, "lblLastRefil", 680, 20, "11/3/2020")

    '    'Add panel to flow layout panel
    '    flpMedications.Controls.Add(pnl)
    '    'flpCamera.Controls.Add(contactPanel)
    '    'Update panel variables

    '    AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClick
    '    AddHandler pnlMainPanel.MouseEnter, AddressOf DynamicMouseHoverEnter
    '    AddHandler pnlMainPanel.MouseLeave, AddressOf DynamicMouseHoverLeave


    '    CurrentContactPanelName = pnl.Name
    '    ContactPanelsAddedCount += 1

    'End Sub

    ''Add new  delete button to contact panel
    'Private Sub CreateContactDeleteBtn(ByVal panelName As Panel, x As Integer, y As Integer)

    '    Dim btnDeleteButton As Button
    '    btnDeleteButton = New Button
    '    'declare our image and point at the resource
    '    Dim imageTrash As New Bitmap(New Bitmap(My.Resources.icons8_delete_trash), 25, 25)

    '    'Set button properties
    '    With btnDeleteButton
    '        .AutoSize = True
    '        .Size = New Size(30, 30)

    '        .FlatStyle = FlatStyle.Flat
    '        .FlatAppearance.BorderSize = 0
    '        .ForeColor = Color.Transparent
    '        ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
    '        .Location = New Point(x, y)
    '        .Name = "btnDeleteMedicine" + (ContactPanelsAddedCount).ToString
    '        .Image = imageTrash
    '        .ImageAlign = ContentAlignment.MiddleCenter
    '        .Tag = ContactPanelsAddedCount + 1
    '    End With


    '    panelName.Controls.Add(btnDeleteButton)
    '    ' MessageBox.Show("again")
    '    'Add handler for click events
    '    AddHandler btnDeleteButton.Click, AddressOf DynamicButton_Click

    'End Sub

    'Private Sub CreateEditButton(ByVal panelName As Panel)

    '    Dim btnEditButton As Button
    '    btnEditButton = New Button
    '    'declare our image and point at the resource
    '    Dim imagePencil As New Bitmap(New Bitmap(My.Resources.icons8_pencil), 25, 25)

    '    'Set button properties
    '    With btnEditButton
    '        .AutoSize = True
    '        .Size = New Size(30, 30)

    '        .FlatStyle = FlatStyle.Flat
    '        .FlatAppearance.BorderSize = 0
    '        .ForeColor = Color.Transparent
    '        ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
    '        .Location = New Point(825, 5)
    '        .Name = "btnEditMedicine" + (ContactPanelsAddedCount).ToString
    '        .Image = imagePencil
    '        .ImageAlign = ContentAlignment.MiddleCenter
    '        .Tag = ContactPanelsAddedCount + 1
    '    End With


    '    panelName.Controls.Add(btnEditButton)
    '    ' MessageBox.Show("again")
    '    'Add handler for click events
    '    AddHandler btnEditButton.Click, AddressOf DynamicButtonEditRecord_Click

    'End Sub
    'Remove handlers and contact panel 
    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        'the parent of the button will be the panel the control is located on.
        'we want to get one step removed so we need to next take the parent of the control
        ' to get the name of flowpanel which the button is laid out on
        Dim control As Control = sender.Parent
        Dim parents As Control = control.Parent



        Dim parentFlowPanel As Control = control.Parent
        'Dim strFlowPanelName As String = control.Parent.Name

        ' Debug.Print(control.Parent.Name)

        Dim parentPanelName As String

        parentPanelName = Nothing

        'Remove handler from sender
        For Each controlObj As Control In parentFlowPanel.Controls
            For Each childControlObj As Control In controlObj.Controls
                If childControlObj.Name = sender.name Then

                    RemoveHandler childControlObj.Click, AddressOf DynamicButton_Click

                    parentPanelName = childControlObj.Parent.Name
                End If
            Next
        Next



        'Remove contact panel
        For Each controlObj As Control In parentFlowPanel.Controls
            If controlObj.Name = parentPanelName Then

                ' prompt user if they are sure they want to delete the record


                ' remove the record from the database

                'remove the padding panel from the flow panel
                '  flpMedications.Controls.Remove(controlObj.Parent)
                controlObj.Parent.Dispose()

                'remove the panel from the flow panel
                '  flpMedications.Controls.Remove(controlObj)
                controlObj.Dispose()


            End If
        Next

        'parents.Name
        ' Dim connn As Control = parentFlowPanel.Parent
        'Debug.Print(connn.Name)
        'Debug.Print(parentFlowPanel.Name)
        'UpdateCamerasSubtotalLabel(parentFlowPanel)

    End Sub

    Public Sub DynamicButtonEditRecord_Click(ByVal sender As Object, ByVal e As EventArgs)

        'show the add new patient form filled in with the patients infromation
        'frmNewPatient.Show()

        'we call our  edit medication form

    End Sub

    'Private Sub CreateIDLabel(ByVal panelName As Panel, lblName As Label, strLabelName As String, x As Integer, y As Integer, labelText As String)

    '    ' Dim lblID As Label
    '    'lblName = New Label
    '    'location = New Point
    '    'declare our image and point at the resource

    '    'Set button properties
    '    With lblName
    '        .AutoSize = True
    '        '.Size = New Size(30, 30)

    '        .FlatStyle = FlatStyle.Flat
    '        ' .FlatAppearance.BorderSize = 0
    '        .ForeColor = Color.Black
    '        .Font = New Font(New FontFamily("Segoe UI"), 11, FontStyle.Regular)
    '        .Location = New Point(x, y) 'new Point(600, 5)
    '        .Name = strLabelName + (ContactPanelsAddedCount).ToString
    '        .Text = labelText
    '        .Tag = ContactPanelsAddedCount + 1
    '    End With


    '    panelName.Controls.Add(lblName)

    'End Sub

    '/*********************************************************************/
    '/*                   FUNCTION NAME: GetAllergies                       */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:Adam kott                             */   
    '/*                 DATE CREATED:2/8/2021                                 */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:    receive a MRN number and push the              */             
    '/* allergy information into the allergies list                       */                     
    '/*                                                                   */
    '/*********************************************************************/
    '/*  CALLED BY:                                                           */           
    '/*                                                                   */         
    '/*********************************************************************/
    '/*  CALLS:                                                              */                 
    '/*             (ExecuteScalar),(ExectueSelectQuery)                  */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):                              */         
    '/*        intPatientInformationMRN                                      */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:                                                          */                   
    '/*            (NOTHING)                                              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:                                   */             
    '/*                                               */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*           dtsPatientAllergy:                                         */
    '/*        intPatientAllergyId:                                       */
    '/*        intPatientInformationMRN:                                  */


    '/*    */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:                                 */               
    '/*                                               */                     
    '/*  WHO   WHEN     WHAT                                   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*  AK   2/8/2021 Created the SQL statements to pull back the       */
    '/*                 information needed for Patient allergies list     */
    '/*********************************************************************/
    Public Sub GetAllergies(ByRef intPatientInformationMRN As Integer)

        'default value for an mrn number so allergies are shown
        'intPatientInformationMRN = 949764144

        'get the patient id assiociated with the MRN Nummber
        Dim intPatientAllergyId As Integer = CInt(CreateDatabase.ExecuteScalarQuery("select patient.Patient_ID From Patient " &
                         "where Patient.MRN_Number=" & (intPatientInformationMRN).ToString & ";"))
        'get the allergy information from the patient allergy tables
        Dim dtsPatientAllergy As DataSet = CreateDatabase.ExecuteSelectQuery("Select Allergy_Name From PatientAllergy " &
                            "Where Active_Flag =1 AND Patient_TUID =" & (intPatientAllergyId).ToString & ";")

        'push each row from the
        For Each item As DataRow In dtsPatientAllergy.Tables(0).Rows
            With dtsPatientAllergy.Tables(0)
                lstBoxAllergies.Items.Add(item(0))
            End With
        Next
        'get select from patient allergy inner join on patient table where tuid is the same
        'join patients meds table and medications table
    End Sub


    Private Sub frmPatientInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        intPatientMRN = frmPatientRecords.intSelectedPatientMRN
        PopulateDispenseHistory()
        PopulateCurrentMedications()
        'PopulateAllergies()
        PopulateNotes()
        PatientInformation.GetPatientInformation(intPatientMRN)
        'CreateDispenseHistoryPanel(flpDispenseHistory)
        'CreateDispenseHistoryPanel(flpDispenseHistory)
        'CreateDispenseHistoryPanel(flpDispenseHistory)
        'CreateDispenseHistoryPanel(flpDispenseHistory)
        'CreateDispenseHistoryPanel(flpDispenseHistory)

        'CreateCurrentMedications(flpMedications)
        'CreateCurrentMedications(flpMedications)
        'CreateCurrentMedications(flpMedications)
        'CreateCurrentMedications(flpMedications)


        ''    CreateAllergiesPanel(flpAllergies, "Carbamazepine ")
        ''    CreateAllergiesPanel(flpAllergies, "Penicillin")
        ''   CreateAllergiesPanel(flpAllergies, "Latex")

        'CreateNotesPanel(flpNotes)
        ''CreateAllergiesPanel(flpAllergies, "")



    End Sub

    Private Sub PopulateDispenseHistory()

        Dim genName1 As String = "benzhydrocodone "
        Dim genName2 As String = "hydrocodone bitartrate"
        Dim genName3 As String = "phenylephrine"
        Dim genName4 As String = "Morphine"
        Dim genName5 As String = "Codeine"

        Dim brandName1 As String = "Apadaz "
        Dim brandName2 As String = "Flowtuss "
        Dim brandName3 As String = "Histinex HC"
        Dim brandName4 As String = "Duramorph "
        Dim brandName5 As String = "Robitussin Ac"

        Dim quantity1 As String = "1"
        Dim quantity2 As String = "1"
        Dim quantity3 As String = "2"
        Dim quantity4 As String = "1"
        Dim quantity5 As String = "3"

        Dim measure1 As String = "10 mg"
        Dim measure2 As String = "10 mg"
        Dim measure3 As String = "50 mg"
        Dim measure4 As String = "10 mg"
        Dim measure5 As String = "10 mg"

        Dim dispensedBy1 As String = "Kathryn Bonner"
        Dim dispensedBy2 As String = "Lola Stanley"
        Dim dispensedBy3 As String = "Kathryn Bonner"
        Dim dispensedBy4 As String = "Kathryn Bonner"
        Dim dispensedBy5 As String = "Lola Stanley"

        Dim dispenseDate1 As String = "11/11/2020"
        Dim dispenseDate2 As String = "11/5/2020"
        Dim dispenseDate3 As String = "11/4/2020"
        Dim dispenseDate4 As String = "11/1/2020"
        Dim dispenseDate5 As String = "10/28/2020"

        Dim dispenseTime1 As String = "8:05 AM"
        Dim dispenseTime2 As String = "9:13 AM"
        Dim dispenseTime3 As String = "8:34 AM"
        Dim dispenseTime4 As String = "1:05 PM"
        Dim dispenseTime5 As String = "5:04 AM"



        'CreateDispenseHistoryPanels(flpDispenseHistory, genName1, brandName1, quantity1, measure1, dispensedBy1, dispenseDate1, dispenseTime1)
        'CreateDispenseHistoryPanels(flpDispenseHistory, genName2, brandName2, quantity2, measure2, dispensedBy2, dispenseDate2, dispenseTime2)
        'CreateDispenseHistoryPanels(flpDispenseHistory, genName3, brandName3, quantity3, measure3, dispensedBy3, dispenseDate3, dispenseTime3)
        'CreateDispenseHistoryPanels(flpDispenseHistory, genName4, brandName4, quantity4, measure4, dispensedBy4, dispenseDate4, dispenseTime4)
        'CreateDispenseHistoryPanels(flpDispenseHistory, genName5, brandName5, quantity5, measure5, dispensedBy5, dispenseDate5, dispenseTime5)

    End Sub

    Public Sub CreateDispenseHistoryPanels(ByVal flpPannel As FlowLayoutPanel, ByVal genericName As String, ByVal brandName As String, ByVal quantity As String, ByVal measure As String, ByVal dispenseBy As String, ByVal dispenseDate As String, ByVal dispenseTime As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(880, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(880, 45)
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
        CreateIDLabel(pnlMainPanel, lblID, "lblMedicationName", 10, 20, genericName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblDosage", 230, 20, measure, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblType", 350, 20, quantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblDispensedBy", 450, 20, dispenseBy, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblDispenseDate", 630, 20, dispenseDate, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblDispenseTime", 730, 20, dispenseTime, getPanelCount(flpPannel))
        ' CreateIDLabel(pnlMainPanel, lblID7, "lblDispenseTime", 865, 20, dispenseTime, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)
        'flpCamera.Controls.Add(contactPanel)
        'Update panel variables

        'currentContactPanel = pnl.Name

    End Sub
    Private Sub PopulateCurrentMedications()

        ' replace all of the hardcoded with database calls to the retreieve this data.
        Dim genName1 As String = "benzhydrocodone "
        Dim genName2 As String = "hydrocodone bitartrate"
        Dim genName3 As String = "phenylephrine"
        Dim genName4 As String = "Morphine"
        Dim genName5 As String = "Codeine"

        Dim brandName1 As String = "Apadaz "
        Dim brandName2 As String = "Flowtuss "
        Dim brandName3 As String = "Histinex HC"
        Dim brandName4 As String = "Duramorph "
        Dim brandName5 As String = "Robitussin Ac"

        Dim quantity1 As String = "1"
        Dim quantity2 As String = "1"
        Dim quantity3 As String = "2"
        Dim quantity4 As String = "1"
        Dim quantity5 As String = "3"

        Dim measure1 As String = "10 mg"
        Dim measure2 As String = "10 mg"
        Dim measure3 As String = "50 mg"
        Dim measure4 As String = "10 mg"
        Dim measure5 As String = "10 mg"


        Dim frequency1 As String = "once every 12 hr"
        Dim frequency2 As String = "once a day"

        Dim method1 As String = "oral"
        Dim method2 As String = "transdermal"

        Dim specialNotes1 As String = "N/A"
        Dim specialNotes2 As String = "Take with food and water"


        CreateCurrentMedicationsPanels(flpMedications, genName1, brandName1, quantity1, measure1, frequency1, method1, specialNotes1)
        CreateCurrentMedicationsPanels(flpMedications, genName2, brandName2, quantity2, measure2, frequency2, method2, specialNotes2)



    End Sub

    Private Sub CreateCurrentMedicationsPanels(ByVal flpPannel As FlowLayoutPanel, ByVal genericName As String, ByVal brandName As String, ByVal quantity As String, ByVal measure As String, ByVal frequency As String, ByVal method As String, ByVal specialNotes As String)
        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(1110, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(1110, 45)
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
        CreateIDLabel(pnlMainPanel, lblID, "lblMedicationName", 5, 20, genericName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblDosage", 228, 20, measure, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblMethod", 339, 20, quantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblQuantity", 449, 20, quantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblDate", 549, 20, frequency, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblPrescribedBy", 626, 20, method, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID7, "lblSchedule", 729, 20, frequency, getPanelCount(flpPannel))


        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)
        'flpCamera.Controls.Add(contactPanel)
        'Update panel variables

        'currentContactPanel = pnl.Name

    End Sub
    Private Sub PopulateNotes()

        ' CreateNotesPanels(flpNotes, "Customer had an allergic reaction to the phenylephrine")
        'CreateNotesPanels(flpNotes,)
        'CreateNotesPanels(flpNotes,)


    End Sub

    Private Sub CreateNotesPanels(ByVal flpPannel As FlowLayoutPanel, ByVal newNote As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(396, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(396, 45)
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
        CreateIDLabel(pnlMainPanel, lblID, "lblNotes", 10, 20, newNote, getPanelCount(flpPannel))


        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)
        'flpCamera.Controls.Add(contactPanel)
        'Update panel variables

        'currentContactPanel = pnl.Name

    End Sub



    'Public Sub CreateDocumentsPanel(ByVal flpPannel As FlowLayoutPanel)

    '    Dim pnlDocument As Panel
    '    pnlDocument = New Panel

    '    Dim pnlMainDocumentPanel As Panel
    '    pnlMainDocumentPanel = New Panel
    '    ' call method here to get the count from the database and update the panel number so the next item is correct


    '    'Set panel properties
    '    With pnlDocument
    '        .BackColor = Color.Gainsboro
    '        .Size = New Size(340, 47)
    '        .Name = "pnlIndividualDocumentPadding" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Padding = New Padding(0, 0, 0, 3)
    '        ' .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    With pnlMainDocumentPanel

    '        .BackColor = Color.White
    '        .Size = New Size(340, 45)
    '        .Name = "pnlIndividualDocumentRecord" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    'put the boarder panel inside the main panel
    '    pnlDocument.Controls.Add(pnlMainDocumentPanel)


    '    'flpCamera.Controls.Add(contactPanel)
    '    'Update panel variables
    '    CreateDocumentDeleteBtn(pnlMainDocumentPanel)
    '    CreateDownloadButton(pnlMainDocumentPanel)


    '    Dim lblID As New Label

    '    Dim location As New Point(10, 20)



    '    CreateIDLabel(pnlMainDocumentPanel, lblID, "lblDocument", 10, 20, "BloodPressure.PDF")

    '    'flpPatientCharts.Controls.Add(pnlDocument)
    '    CurrentChartPanelName = pnlDocument.Name
    '    ChartPanelsAddedCount += 1

    'End Sub


    'Private Sub CreateDocumentDeleteBtn(ByVal panelName As Panel)

    '    Dim btnDeleteChartButton As Button
    '    btnDeleteChartButton = New Button
    '    'declare our image and point at the resource
    '    Dim imageTrash As New Bitmap(New Bitmap(My.Resources.icons8_delete_trash), 25, 25)

    '    'Set button properties
    '    With btnDeleteChartButton
    '        .AutoSize = True
    '        .Size = New Size(30, 30)

    '        .FlatStyle = FlatStyle.Flat
    '        .FlatAppearance.BorderSize = 0
    '        .ForeColor = Color.Transparent
    '        ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
    '        .Location = New Point(300, 5)
    '        .Name = "btnDeleteChartButton" + (ContactPanelsAddedCount).ToString
    '        .Image = imageTrash
    '        .ImageAlign = ContentAlignment.MiddleCenter
    '        .Tag = ContactPanelsAddedCount + 1
    '    End With


    '    panelName.Controls.Add(btnDeleteChartButton)
    '    ' MessageBox.Show("again")
    '    'Add handler for click events
    '    AddHandler btnDeleteChartButton.Click, AddressOf DynamicDocumentDeleteButton_Click

    'End Sub



    Private Sub DynamicDownloadButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DynamicDocumentDeleteButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnEditPatient_Click(sender As Object, e As EventArgs) Handles btnEditPatient.Click

        Dim ctl As Control

        Dim arrPnl As Panel() = {pnlPersonalInformation}

        If Not btnEditPatient.Text = "Save Changes" Then

            For Each ctl In pnlPersonalInformation.Controls

                If TypeName(ctl) = "TextBox" Then
                    Dim txtbox As TextBox = CType(ctl, TextBox)

                    txtbox.ReadOnly = False
                    txtbox.BorderStyle = BorderStyle.FixedSingle
                    txtbox.BackColor = Color.White

                End If
            Next

            btnEditPatient.Text = "Save Changes"

        Else

            ' we want to save the data here..


            For Each ctl In pnlPersonalInformation.Controls

                If TypeName(ctl) = "TextBox" Then
                    Dim txtbox As TextBox = CType(ctl, TextBox)

                    txtbox.ReadOnly = True
                    txtbox.BorderStyle = BorderStyle.None
                    txtbox.BackColor = Color.White

                End If

            Next


            btnEditPatient.Text = "Edit Patient"

            ' call update database method here because we made changes to patient information.
            '
        End If


    End Sub


    'Private Sub DynamicMouseHoverLeave(sender As Object, e As EventArgs)

    '    If sender.backColor = Color.Gainsboro Then
    '        sender.backColor = Color.White

    '    Else

    '        sender.backcolor = Color.Gainsboro
    '    End If


    'End Sub

    'Private Sub DynamicMouseHoverEnter(sender As Object, e As EventArgs)
    '    'changes the background color when the mouse is hovered over the panel

    '    If sender.backColor = Color.White Then
    '        sender.backColor = Color.Gainsboro

    '    Else

    '        sender.backcolor = Color.White
    '    End If

    'End Sub

    'Private Sub DynamicDoubleClick(sender As Object, e As EventArgs)

    '    Dispense.Show()

    'End Sub

    'Private Sub btnAddMedicine_Click_1(sender As Object, e As EventArgs)

    '    '  CreatePanel(flpMedications)

    'End Sub





    'Public Sub CreateDispenseHistoryPanel(ByVal flpPannel As FlowLayoutPanel)

    '    Dim pnl As Panel
    '    pnl = New Panel

    '    Dim pnlMainPanel As Panel
    '    pnlMainPanel = New Panel
    '    ' call method here to get the count from the database and update the panel number so the next item is correct


    '    'Set panel properties
    '    With pnl
    '        .BackColor = Color.Gainsboro
    '        .Size = New Size(955, 47)
    '        .Name = "pnlIndividualPatientRecordPadding" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Padding = New Padding(0, 0, 0, 3)
    '        ' .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    With pnlMainPanel

    '        .BackColor = Color.White
    '        .Size = New Size(955, 45)
    '        .Name = "pnlIndividualPatientRecord" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    'put the boarder panel inside the main panel
    '    pnl.Controls.Add(pnlMainPanel)



    '    ' add controls to this panel

    '    'CreateContactDeleteBtn(pnlMainPanel)
    '    'CreateEditButton(pnlMainPanel)


    '    ' call database info here to populate
    '    Dim lblID As New Label
    '    Dim lblID2 As New Label
    '    Dim lblID3 As New Label
    '    Dim lblID4 As New Label
    '    Dim lblID5 As New Label
    '    Dim lblID6 As New Label
    '    Dim lblID7 As New Label

    '    CreateIDLabel(pnlMainPanel, lblID, "lblGenericName", 10, 20, "Oxycontin")
    '    CreateIDLabel(pnlMainPanel, lblID2, "lblBrandName", 170, 20, "Norco")
    '    CreateIDLabel(pnlMainPanel, lblID3, "lblQuantity", 335, 20, "1")
    '    CreateIDLabel(pnlMainPanel, lblID4, "lblMeasure", 430, 20, "250 MG")
    '    CreateIDLabel(pnlMainPanel, lblID5, "lblDispensedBy", 555, 20, "John Smith")
    '    CreateIDLabel(pnlMainPanel, lblID6, "lblDispenseDate", 700, 20, "11/3/2020")
    '    CreateIDLabel(pnlMainPanel, lblID7, "lblDispenseTime", 865, 20, "7:05 PM")


    '    'Add panel to flow layout panel
    '    flpPannel.Controls.Add(pnl)
    '    'flpCamera.Controls.Add(contactPanel)
    '    'Update panel variables

    '    ' AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClick
    '    ' AddHandler pnlMainPanel.MouseEnter, AddressOf DynamicMouseHoverEnter
    '    ' AddHandler pnlMainPanel.MouseLeave, AddressOf DynamicMouseHoverLeave


    '    CurrentContactPanelName = pnl.Name
    '    ContactPanelsAddedCount += 1

    'End Sub

    'Public Sub CreateCurrentMedications(ByVal flpPannel As FlowLayoutPanel)

    '    Dim pnl As Panel
    '    pnl = New Panel

    '    Dim pnlMainPanel As Panel
    '    pnlMainPanel = New Panel
    '    ' call method here to get the count from the database and update the panel number so the next item is correct


    '    'Set panel properties
    '    With pnl
    '        .BackColor = Color.Gainsboro
    '        .Size = New Size(955, 47)
    '        .Name = "pnlIndividualPatientRecordPadding" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Padding = New Padding(0, 0, 0, 3)
    '        ' .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    With pnlMainPanel

    '        .BackColor = Color.White
    '        .Size = New Size(955, 45)
    '        .Name = "pnlIndividualPatientRecord" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    'put the boarder panel inside the main panel
    '    pnl.Controls.Add(pnlMainPanel)



    '    ' add controls to this panel

    '    'CreateContactDeleteBtn(pnlMainPanel)
    '    'CreateEditButton(pnlMainPanel)


    '    ' call database info here to populate
    '    Dim lblID As New Label
    '    Dim lblID2 As New Label
    '    Dim lblID3 As New Label
    '    Dim lblID4 As New Label
    '    Dim lblID5 As New Label
    '    Dim lblID6 As New Label
    '    Dim lblID7 As New Label

    '    CreateIDLabel(pnlMainPanel, lblID, "lblGenericName", 10, 20, "Oxycontin")
    '    CreateIDLabel(pnlMainPanel, lblID2, "lblBrandName", 170, 20, "Norco")
    '    CreateIDLabel(pnlMainPanel, lblID3, "lblQuantity", 335, 20, "1")
    '    CreateIDLabel(pnlMainPanel, lblID4, "lblMeasure", 430, 20, "250 MG")
    '    CreateIDLabel(pnlMainPanel, lblID5, "lblDispenseNotes", 555, 20, "Once Every 4 hours")
    '    'CreateIDLabel(pnlMainPanel, lblID6, "lblDispenseDate", 700, 20, "11/3/2020")
    '    CreateIDLabel(pnlMainPanel, lblID7, "lblDispenseTime", 865, 20, "7:05 PM")


    '    'Add panel to flow layout panel
    '    flpPannel.Controls.Add(pnl)
    '    'flpCamera.Controls.Add(contactPanel)
    '    'Update panel variables

    '    ' AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClick
    '    ' AddHandler pnlMainPanel.MouseEnter, AddressOf DynamicMouseHoverEnter
    '    ' AddHandler pnlMainPanel.MouseLeave, AddressOf DynamicMouseHoverLeave


    '    CurrentContactPanelName = pnl.Name
    '    ContactPanelsAddedCount += 1

    'End Sub
    'Public Sub CreateAllergiesPanel(ByVal flpPannel As FlowLayoutPanel, lblDrugName As String)

    '    Dim pnlDocument As Panel
    '    pnlDocument = New Panel

    '    Dim pnlMainDocumentPanel As Panel
    '    pnlMainDocumentPanel = New Panel
    '    ' call method here to get the count from the database and update the panel number so the next item is correct


    '    'Set panel properties
    '    With pnlDocument
    '        .BackColor = Color.Gainsboro
    '        .Size = New Size(340, 47)
    '        .Name = "pnlIndividualDocumentPadding" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Padding = New Padding(0, 0, 0, 3)
    '        ' .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    With pnlMainDocumentPanel

    '        .BackColor = Color.White
    '        .Size = New Size(340, 45)
    '        .Name = "pnlIndividualDocumentRecord" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    'put the boarder panel inside the main panel
    '    pnlDocument.Controls.Add(pnlMainDocumentPanel)


    '    'flpCamera.Controls.Add(contactPanel)
    '    'Update panel variables
    '    'CreateDocumentDeleteBtn(pnlMainDocumentPanel)
    '    'CreateDownloadButton(pnlMainDocumentPanel)


    '    Dim lblID As New Label
    '    Dim lblID2 As New Label
    '    Dim location As New Point(10, 20)



    '    CreateIDLabel(pnlMainDocumentPanel, lblID, "lblDrug1", 10, 20, lblDrugName)
    '    ' C 'reateIDLabel(pnlMainDocumentPanel, lblID2, "lblDrug2", 10, 20, "Carbamazepine")
    '    CreateContactDeleteBtn(pnlMainDocumentPanel, 300, 5)

    '    'flpAllergies.Controls.Add(pnlDocument)
    '    CurrentChartPanelName = pnlDocument.Name
    '    ChartPanelsAddedCount += 1

    'End Sub

    'Public Sub CreateNotesPanel(ByVal flpPannel As FlowLayoutPanel)

    '    Dim pnlDocument As Panel
    '    pnlDocument = New Panel

    '    Dim pnlMainDocumentPanel As Panel
    '    pnlMainDocumentPanel = New Panel
    '    ' call method here to get the count from the database and update the panel number so the next item is correct


    '    'Set panel properties
    '    With pnlDocument
    '        .BackColor = Color.Gainsboro
    '        .Size = New Size(950, 77)
    '        .Name = "pnlIndividualDocumentPadding" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Padding = New Padding(0, 0, 0, 3)
    '        ' .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    With pnlMainDocumentPanel

    '        .BackColor = Color.White
    '        .Size = New Size(950, 75)
    '        .Name = "pnlIndividualDocumentRecord" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    'put the boarder panel inside the main panel
    '    pnlDocument.Controls.Add(pnlMainDocumentPanel)


    '    'flpCamera.Controls.Add(contactPanel)
    '    'Update panel variables
    '    'CreateDocumentDeleteBtn(pnlMainDocumentPanel)
    '    'CreateDownloadButton(pnlMainDocumentPanel)


    '    Dim lblID As New Label
    '    Dim lblID2 As New Label
    '    Dim location As New Point(10, 20)



    '    'CreateIDLabel(pnlMainDocumentPanel, lblID, "lblDrug1", 10, 20, "11/12/2020")
    '    ' make this control a multiline textbox and not
    '    CreateIDLabel(pnlMainDocumentPanel, lblID2, "lblDrug2", 10, 20, "No allergic reactionsfrom ibuprofen. Patient is feeling better. All signs indicate the patient is improving.")
    '    ' C 'reateIDLabel(pnlMainDocumentPanel, lblID2, "lblDrug2", 10, 20, "Carbamazepine")
    '    CreateContactDeleteBtn(pnlMainDocumentPanel, 900, 5)

    '    flpNotes.Controls.Add(pnlDocument)
    '    CurrentChartPanelName = pnlDocument.Name
    '    ChartPanelsAddedCount += 1

    'End Sub

    Private Sub btnDispenseMedication_Click(sender As Object, e As EventArgs) Handles btnDispenseMedication.Click

        Dispense.Show()

    End Sub

    ' Private Sub Button1_Click(sender As Object, e As EventArgs)
    '     Returns.Show()
    '  End Sub

    Private Sub btnWaste_Click(sender As Object, e As EventArgs) Handles btnWaste.Click
        Waste.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        '  CreatePanel(flpMedications)
    End Sub

    Private Sub btnAddAllergy_Click(sender As Object, e As EventArgs)

        '  lstBoxAllergies.Items.Add(txtAllergy.Text)

    End Sub

    Private Sub btnAddNewNote_Click(sender As Object, e As EventArgs)

    End Sub

End Class