Public Class frmAllergies
    Private Sub frmAllergies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsAllergies = CreateDatabase.ExecuteSelectQuery("Select * From Allergy ORDER BY Allergy_Type, Allergy_Name;")
        populateAllergiesComboBox(cmbAllergies, dsAllergies)
        Dim strSeverity As String = " "
        Dim intPatientTuid As Integer = GetPatientTuid()
        'get the allergy information from the patient allergy tables
        Dim dtsPatientAllergy As DataSet = CreateDatabase.ExecuteSelectQuery("Select Allergy.Allergy_Name, PatientAllergy.Allergy_Severity," &
                                                                             "Allergy.Allergy_Type, Allergy.Medication_TUID From PatientAllergy " &
                                                                             "INNER JOIN Allergy on PatientAllergy.Allergy_Name=Allergy.Allergy_Name" &
                            " Where Active_Flag =1 And Patient_TUID =" & (intPatientTuid).ToString & ";")
        ' insert the select statement here and send the results to the createAllergiesPanel
        For Each dr As DataRow In dtsPatientAllergy.Tables(0).Rows


            If dr(2) = "Drug" Then
                txtMedicationName.Text = dr(0)
                cmbAllergies.Text = "N/A"
            Else
                cmbAllergies.Text = dr(0)
                txtMedicationName.Text = "N/A"

                Debug.WriteLine("")
            End If

            strSeverity = CheckSeverity(dr)
            txtAllergyType.Text = dr(2)
            CreateAllergiesPanels(flpAllergies, cmbAllergies.Text, txtMedicationName.Text, txtAllergyType.Text, strSeverity)
        Next
        'CreateAllergiesPanels()


    End Sub

    Private Shared Function GetPatientTuid() As Integer
        Dim intPatientInformationMRN = CInt(frmPatientInfo.txtMRN.Text)
        ' on form load we need to select all allergies from the database and show them here:
        Dim intPatientTuid As Integer = CInt(CreateDatabase.ExecuteScalarQuery("select patient.Patient_ID From Patient " &
                        "where Patient.MRN_Number=" & (intPatientInformationMRN).ToString & ";"))
        Return intPatientTuid
    End Function

    Private Shared Function CheckSeverity(dr As DataRow) As String
        Dim strSeverity As String

        If dr(1).Equals(DBNull.Value) Then
            strSeverity = "N/A"
        Else
            strSeverity = dr(1).ToString
        End If

        Return strSeverity
    End Function

    '/********************************************************************/
    '/*                   SUB NAME: CreatePanel            	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/10/21			                     */                             
    '/********************************************************************/
    '/*  SUB PURPOSE: contains the logic and mechanics to display db data*/
    '/*   to the front end in the form of panels.                        */
    '/********************************************************************/
    '/*  CALLED BY:                                      	      		 */				            
    '/*                                              			         */         
    '/********************************************************************/
    '/*  CALLS:							                            	 */		                  
    '/*            CreateIDLabel        					             */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/* flpPannel- A flow panel that contains subpanels which contain    */
    '/*    the rest of the controls.                                     */
    '/* strAllergyName- the allergy that will be added to the UI         */
    '/* strMedicationName- the medication name                           */
    '/* strAllergyType- the classification of the allergy and the cause  */
    '/* strSeverity- how sever of a reaction a patient has to an allergen*/
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	CreateAllergiesPanels(flpPannel,strAllergyName,strMedicationName,strAllergyType, strSeverity)			                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 pnl- an object of type panel that will be created at run time   */
    '/*	 pnlMain- an object of type panel that will be created at run time/
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									                                 */		                   
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		        2/10/21		    initial creation                 */
    '/********************************************************************/ 
    Public Sub CreateAllergiesPanels(ByVal flpPannel As FlowLayoutPanel, ByVal strAllergyName As String, ByVal strMedicationName As String, ByVal strAllergyType As String, ByVal strSeverity As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct

        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(flpAllergies.Width - 7, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(flpAllergies.Width - 7, 45)
            .Name = "pnlIndividualPatientRecord" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)

        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault


        ' find a method of assigning a handler to this control on this page that can delete the item from the database when
        ' when the trash can is Selected. This method will be exploited on a few other forms too such as frmConfiguration
        ' when we need to delete users

        CreateDeleteBtn(pnlMainPanel, getPanelCount(flpPannel), lblActions.Location.X + 50, 5)
        CreateEditButton(pnlMainPanel, getPanelCount(flpPannel), lblActions.Location.X + 5, 5)

        ' add controls to this panel
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblName", lblAllergyName.Location.X, 20, strAllergyName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblSeverity", lblSeverity.Location.X, 20, strSeverity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblAllergyType", lblAllergyType.Location.X, 20, strAllergyType, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblMedication", lblMedication.Location.X, 20, strMedicationName, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub


    Private Sub btnAddAllergy_Click(sender As Object, e As EventArgs) Handles btnAddAllergy.Click
        Dim strAllergyName = " "
        Dim strSeverity = " "
        ' at some point error handling will be added here and if all data is valid 2 things will occur:
        '   1. first we will take the items from all the textfields and insert it into the database.
        '   2. We will just take those same fields and call the create panel method to throw the items on the UI
        '   to save another database call and complexity of removing all the panels from the UI and repopulating them

        If cmbAllergies.SelectedIndex = -1 Then
            strAllergyName = cmbAllergies.Text
        Else
            strAllergyName = cmbAllergies.Text
        End If
        Dim intMEdicationTUID = "NUll" 'for now but medication tuid will need to be looked up
        Dim strAllergyType = txtAllergyType.Text
        Dim intPatientTuid = GetPatientTuid()

        ' insert into database statement/method goes here
        CreateDatabase.ExecuteInsertQuery("INSERT INTO PatientAllergy (Patient_TUID, Allergy_Name, Allergy_Severity, Active_Flag) VALUES (" & intPatientTuid & ",'" & strAllergyName & "','" & strAllergyType & "',1);")
        ' populate the screen from a manually added allergy.

        'probably going to need a select query to get the medication name from the TUID
        If cmbSeverity.SelectedIndex = -1 Then
            strSeverity = "N/A"
        Else
            strSeverity = cmbSeverity.SelectedItem.ToString
        End If

        CreateAllergiesPanels(flpAllergies, strAllergyName, txtMedicationName.Text, strAllergyType, strSeverity)

    End Sub


    Private Sub cmbAllergies_TextChanged(sender As Object, e As EventArgs) Handles cmbAllergies.TextChanged

        If cmbAllergies.FindStringExact(cmbAllergies.Text) = -1 Then
            'do nothing until the user types in a value that matches an item in the box
        Else

            cmbAllergies.SelectedIndex = cmbAllergies.FindString(cmbAllergies.Text)

        End If
    End Sub

    Private Sub cmbAllergies_LostFocus(sender As Object, e As EventArgs) Handles cmbAllergies.LostFocus
        cmbAllergies.DroppedDown = False
    End Sub

    Private Sub cmbAllergies_Click(sender As Object, e As EventArgs) Handles cmbAllergies.Click
        cmbAllergies.DroppedDown = True

    End Sub

End Class