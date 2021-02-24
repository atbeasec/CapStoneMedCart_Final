Public Class frmAllergies
    Private Sub frmAllergies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAllergyCancel.Visible = False
        btnAllergySave.Visible = False
        'cmbAllergiesLocked()

        Dim dsAllergies = CreateDatabase.ExecuteSelectQuery("Select * From Allergy ORDER BY Allergy_Type, Allergy_Name ;")
        Dim dsDrugAllergies = CreateDatabase.ExecuteSelectQuery("Select * From Allergy WHERE Allergy_Type = 'Drug' ORDER BY Allergy_Type, Allergy_Name ;")
        Dim dsAllergyType = CreateDatabase.ExecuteSelectQuery("Select DISTINCT Allergy_Type from Allergy;")

        populateAllergiesComboBox(cmbAllergies, dsAllergies)
        populateMedicationComboBox(cmbMedicationName, dsDrugAllergies)
        populateAllergyTypeComboBox(cmbAllergiesType, dsAllergyType)
        Dim strSeverity As String = " "
        Dim intPatientTuid As Integer = GetPatientTuid()
        'get the allergy information from the patient allergy tables
        Dim dtsPatientAllergy As DataSet = CreateDatabase.ExecuteSelectQuery("Select Allergy.Allergy_Name, PatientAllergy.Allergy_Severity," &
                                                                             "Allergy.Allergy_Type, Allergy.Medication_TUID From PatientAllergy " &
                                                                             "INNER JOIN Allergy on PatientAllergy.Allergy_Name=Allergy.Allergy_Name" &
                            " Where Active_Flag =1 And Patient_TUID =" & (intPatientTuid).ToString & ";")
        ' insert the select statement here and send the results to the createAllergiesPanel
        cmbAllergies.SelectedIndex = -1
        For Each dr As DataRow In dtsPatientAllergy.Tables(0).Rows

            If dr(2) = "Drug" Then
                cmbMedicationName.Text = dr(0)
                cmbAllergies.Text = "N/A"
            Else
                cmbAllergies.Text = dr(0)
                cmbMedicationName.Text = "N/A"

                Debug.WriteLine("")
            End If

            strSeverity = CheckSeverity(dr)
            CreateAllergiesPanels(flpAllergies, cmbAllergies.Text, cmbMedicationName.Text, cmbAllergiesType.Text, strSeverity)
            cmbAllergiesLocked()
        Next
        'CreateAllergiesPanels()


    End Sub

    Public Function GetPatientTuid() As Integer
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
            .Name = "pnlAllergiesPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(flpAllergies.Width - 7, 45)
            .Name = "pnlAllergiestRecord" + getPanelCount(flpPannel).ToString
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
        CreateIDLabel(pnlMainPanel, lblID, "lblAllergyName", lblAllergyName.Location.X, 20, strAllergyName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblSeverity", lblSeverity.Location.X, 20, strSeverity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblAllergyType", lblAllergyType.Location.X, 20, strAllergyType, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblMedication", lblMedication.Location.X, 20, strMedicationName, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub


    Private Sub btnAddAllergy_Click(sender As Object, e As EventArgs) Handles btnAddAllergy.Click
        Dim strAllergyName = " "
        Dim strSeverity = " "
        Dim intPatientTuid = GetPatientTuid()
        ' at some point error handling will be added here and if all data is valid 2 things will occur:
        '   1. first we will take the items from all the textfields and insert it into the database.
        '   2. We will just take those same fields and call the create panel method to throw the items on the UI
        '   to save another database call and complexity of removing all the panels from the UI and repopulating them
        If cmbAllergies.SelectedIndex = -1 Then
            strAllergyName = cmbAllergies.Text
        Else
            strAllergyName = cmbAllergies.Text
        End If
        If cmbSeverity.SelectedIndex = -1 Then
            strSeverity = "N/A"
        Else
            strSeverity = cmbSeverity.SelectedItem.ToString
        End If
        Dim intMedicationTUID = "NUll" 'for now but medication tuid will need to be looked up
        Dim strSqlStatment As String = ("Select Active_Flag FROM PatientAllergy WHERE Allergy_Name='" & strAllergyName & "' and Patient_TUID= " & intPatientTuid & ";")
        Dim value = ExecuteScalarQuery(strSqlStatment)
        If value = 0 Then
            ExecuteScalarQuery("UPDATE PatientAllergy SET Active_Flag='1' WHERE Allergy_Name='" & strAllergyName & "' and Patient_TUID =" & intPatientTuid & ";")

        ElseIf value = 1 Then

            'do nothing for now but combo box should not contain the values
        Else
            If cmbAllergies.FindStringExact(cmbAllergies.Text) = -1 Then
                CreateDatabase.ExecuteInsertQuery("INSERT INTO Allergy(Allergy_Name,Medication_TUID,Allergy_Type) VALUES('" & strAllergyName & "'," & intMedicationTUID & ",'" & cmbAllergiesType.Text & "');")
            End If
            ' insert into database statement/method goes here
            CreateDatabase.ExecuteInsertQuery("INSERT INTO PatientAllergy (Patient_TUID, Allergy_Name, Allergy_Severity, Active_Flag) VALUES (" & intPatientTuid & ",'" & strAllergyName & "','" & cmbAllergiesType.Text & "',1);")
            ' populate the screen from a manually added allergy.
            'probably going to need a select query to get the medication name from the TUID
            Debug.WriteLine("Value must already be in the table")
        End If

        CreateAllergiesPanels(flpAllergies, strAllergyName, cmbMedicationName.Text, cmbAllergiesType.Text, strSeverity)
    End Sub

    Private Sub cmbAllergies_LostFocus(sender As Object, e As EventArgs) Handles cmbAllergies.SelectedValueChanged
        cmbAllergies.DroppedDown = False
        If cmbAllergies.FindStringExact(cmbAllergies.Text) = -1 Then
            cmbAllergiesType.SelectedIndex = -1
            cmbSeverity.SelectedIndex = -1

        Else
            Dim objAllergyType = CreateDatabase.ExecuteScalarQuery("Select Allergy_Type From Allergy Where Allergy_Name = '" & cmbAllergies.Text & "';")

            cmbAllergiesType.SelectedItem = objAllergyType.ToString
            If cmbAllergiesType.SelectedItem = "Drug" Then
                cmbMedicationName.SelectedItem = cmbAllergies.SelectedItem
                cmbSeverity.SelectedIndex = 1
            End If
        End If
    End Sub

    'Private Sub cmbAllergies_Click(sender As Object, e As EventArgs) Handles cmbAllergies.Click

    '    cmbAllergies.DroppedDown = True
    '    txtAllergyType.Text = ""

    'End Sub

    Private Sub cmbMedicationName_Click(sender As Object, e As EventArgs) Handles cmbMedicationName.Click
        cmbMedicationName.DroppedDown = True

    End Sub

    Private Sub cmbMedicationName_LostFocus(sender As Object, e As EventArgs) Handles cmbMedicationName.LostFocus
        cmbMedicationName.DroppedDown = False

    End Sub

    Private Sub cmbMedicationName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbMedicationName.SelectedValueChanged
        cmbAllergies.Text = cmbMedicationName.Text
    End Sub

    Private Sub cmbAllergiesLocked()
        If cmbMedicationName.Text = "N/A" Or cmbMedicationName.SelectedIndex = -1 Then
            'cmbAllergies.Enabled = True
            cmbAllergies.SelectedIndex = -1
        Else
            'cmbAllergies.Enabled = False

        End If
    End Sub

    Private Sub cmbAllergies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAllergies.SelectedIndexChanged
        If cmbAllergiesType.Text = "Drug" Then
            cmbAllergiesType.Enabled = False
            If cmbAllergies.SelectedIndex = 0 Then

                Dim strMedTUID = CreateDatabase.ExecuteScalarQuery("Select Medication_TUID from Allergy WHERE Allergy_Name='" & cmbAllergies.Text & "';")
                Dim MedAllergies = CreateDatabase.ExecuteScalarQuery("Select Drug_Name from Medication WHERE Medication_ID=" & CInt(strMedTUID) & ";")
                cmbMedicationName.Text = MedAllergies.ToString()
            Else
                cmbMedicationName.Text = cmbAllergies.Text

                Debug.WriteLine("")
            End If
        Else
            cmbAllergiesType.Enabled = True
            cmbMedicationName.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnAllergySave_Click(sender As Object, e As EventArgs) Handles btnAllergySave.Click
        DisableEditButtons()
    End Sub

    Private Sub DisableEditButtons()
        btnAddAllergy.Visible = True
        btnAllergyCancel.Visible = False
        btnAllergySave.Visible = False
    End Sub

    Private Sub btnAllergyCancel_Click(sender As Object, e As EventArgs) Handles btnAllergyCancel.Click
        btnAddAllergy.Visible = True
    End Sub
End Class