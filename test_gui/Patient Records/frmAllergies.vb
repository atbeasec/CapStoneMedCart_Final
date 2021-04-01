Public Class frmAllergies

    Private intPatientInformationMRN As Integer
    Private Sub btnAddAllergy_Click(sender As Object, e As EventArgs) Handles btnAddAllergy.Click
        'If cmbAllergies.Text = "" Then
        '    MessageBox.Show("please Enter a real allergy")
        'Else
        If cmbAllergiesType.Text = "" And cmbAllergies.Text = "" Then
            MessageBox.Show("Could not add this allergy - Please pick a type and an allergy from the drop-down or enter a new one if it isn't on the current list of options.")
        ElseIf cmbAllergiesType.Text = "" Then
            MessageBox.Show("Could not add this allergy - Please pick a type from the drop-down.")
        ElseIf cmbAllergies.Text = "" Then
            MessageBox.Show("Could not add this allergy - Please pick an allergy from the drop-down or enter a new one if it isn't on the current list of options.")
        Else


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
                cmbSeverity.SelectedIndex = 5
                strSeverity = cmbSeverity.SelectedItem.ToString
            Else
                strSeverity = cmbSeverity.SelectedItem.ToString
            End If
            Dim intMedicationTUID = "NUll" 'for now but medication tuid will need to be looked up
            Dim strSqlStatment As String = ("Select Active_Flag FROM PatientAllergy WHERE Allergy_Name='" & strAllergyName & "' and Patient_TUID= " & intPatientTuid & ";")
            Dim value = ExecuteScalarQuery(strSqlStatment)
            If value = Nothing Then
                value = 2
            End If
            If value = 0 Then
                ExecuteScalarQuery("UPDATE PatientAllergy SET Active_Flag='1' WHERE Allergy_Name='" & strAllergyName & "' and Patient_TUID =" & intPatientTuid & ";")

            ElseIf value = 1 Then

                'do nothing for now but combo box should not contain the values
            Else
                If cmbAllergies.FindStringExact(cmbAllergies.Text) = -1 Then
                    CreateDatabase.ExecuteInsertQuery("INSERT INTO Allergy(Allergy_Name,Allergy_Type) VALUES('" & strAllergyName & "','" & cmbAllergiesType.Text & "');")
                End If
                ' insert into database statement/method goes here
                CreateDatabase.ExecuteInsertQuery("INSERT INTO PatientAllergy (Patient_TUID, Allergy_Name, Allergy_Severity, Active_Flag) VALUES (" & intPatientTuid & ",'" & strAllergyName & "','" & cmbAllergiesType.SelectedIndex & "',1);")
                ' populate the screen from a manually added allergy.
                'probably going to need a select query to get the medication name from the TUID
                Debug.WriteLine("Value must already be in the table")


                'cant update the allergies list box this way because the form is not opened and cannot be referenced.
                'frmPatientInfo.lstBoxAllergies.Items.Clear()

                '************************
                ' update the allergies table in the database instead for the patient. When the form loads, the patient's new allergies will be visible.
                '************************

                GetAllergies(intPatientInformationMRN)
            End If

            CreateAllergiesPanels(flpAllergies, strAllergyName, cmbAllergiesType.Text, strSeverity)
        End If
        'End If
    End Sub
    Private Sub btnAllergyCancel_Click(sender As Object, e As EventArgs) Handles btnAllergyCancel.Click
        DisableEditButtons()
        ' check to make sure the item didn't get deleted from the list
        Dim strAllergyName = cmbAllergies.Text
        Dim intPatientTuid = GetPatientTuid()
        Dim strNewSeverity = cmbSeverity.SelectedIndex.ToString

        If ExecuteScalarQuery("Select count FROM PatientAllergy WHERE Allergy_Severity='" & cmbSeverity.SelectedIndex & "' WHERE Allergy_Name='" & strAllergyName &
                           "' AND Patient_TUID =" & intPatientTuid & " AND Active_Flag = 0 ;") = 1 Then
            btnAllergySave_Click(sender, e)
        End If

    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: btnAllergySave_Click           */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:Adam Kott            		          */   
    '/*		         DATE CREATED:2/24/2021                     		   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:	When the user clicks the save button the      */             
    '/* database needs to be updated and then form needs to be reset and  */                     
    '/*  locked                                                            */
    '/*********************************************************************/
    '/*  CALLED BY: user clicking save button					         */           
    '/*                                                    				   */         
    '/*********************************************************************/
    '/*  CALLS: DisableEditButtons
    '/* ExecuteScalarQuery						                           */                 
    '/* GetPatientTuid                  								   */             
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
    '/*                                         */
    '/*                                                   */
    '/*                                                  */
    '/*   
    '/*********************************************************************/
    Private Sub btnAllergySave_Click(sender As Object, e As EventArgs) Handles btnAllergySave.Click

        Dim strAllergyName = cmbAllergies.Text
        Dim intPatientTuid = GetPatientTuid()
        Dim strNewSeverity = cmbSeverity.SelectedIndex.ToString
        ExecuteScalarQuery("UPDATE PatientAllergy SET Allergy_Severity='" & strNewSeverity & "', Active_Flag = 1 WHERE Allergy_Name='" & strAllergyName & "' and Patient_TUID =" & intPatientTuid & " ;")
        DisableEditButtons()
        flpAllergies.Controls.Clear()
        LoadAllergiesPanel(strNewSeverity, intPatientTuid)
    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: cmbMedicationName_Click           */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:Adam Kott            		          */   
    '/*		         DATE CREATED:2/24/2021                     		   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:	When the user clicks the save button the      */             
    '/* database needs to be updated and then form needs to be reset and  */                     
    '/*  locked                                                            */
    '/*********************************************************************/
    '/*  CALLED BY: user clicking save button					         */           
    '/*                                                    				   */         
    '/*********************************************************************/
    '/*  CALLS: DisableEditButtons
    '/* ExecuteScalarQuery						                           */                 
    '/* GetPatientTuid                  								   */             
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
    '/*                                         */
    '/*                                                   */
    '/*                                                  */
    '/*   
    '/*********************************************************************/
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmPatientInfo.setPatientMrn(intPatientInformationMRN)
        frmMain.OpenChildForm(frmPatientInfo)
        GetAllergies(GetPatientTuid())


    End Sub
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: cmbMedicationName_Click           */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:Adam Kott            		          */   
    '/*		         DATE CREATED:2/24/2021                     		   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:	When the user clicks the save button the      */             
    '/* database needs to be updated and then form needs to be reset and  */                     
    '/*  locked                                                            */
    '/*********************************************************************/
    '/*  CALLED BY: user clicking save button					         */           
    '/*                                                    				   */         
    '/*********************************************************************/
    '/*  CALLS: DisableEditButtons
    '/* ExecuteScalarQuery						                           */                 
    '/* GetPatientTuid                  								   */             
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
    '/*                                         */
    '/*                                                   */
    '/*                                                  */
    '/*   
    '/*********************************************************************/
    Private Shared Function CheckSeverity(dr As DataRow) As String
        Dim strSeverity As String

        If dr(1).Equals(DBNull.Value) Then
            strSeverity = "N/A"
        Else
            strSeverity = dr(1).ToString
        End If

        Return strSeverity
    End Function

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: cmbMedicationName_Click           */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:Adam Kott            		          */   
    '/*		         DATE CREATED:2/24/2021                     		   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:	When the user clicks the save button the      */             
    '/* database needs to be updated and then form needs to be reset and  */                     
    '/*  locked                                                            */
    '/*********************************************************************/
    '/*  CALLED BY: user clicking save button					         */           
    '/*                                                    				   */         
    '/*********************************************************************/
    '/*  CALLS: DisableEditButtons
    '/* ExecuteScalarQuery						                           */                 
    '/* GetPatientTuid                  								   */             
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
    '/*                                         */
    '/*                                                   */
    '/*                                                  */
    '/*   
    '/*********************************************************************/
    Private Sub cmbAllergies_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbAllergies.SelectedValueChanged
        cmbAllergies.DroppedDown = False
        If cmbAllergies.FindStringExact(cmbAllergies.Text) = -1 Then
            cmbAllergiesType.SelectedIndex = -1
            cmbSeverity.SelectedIndex = 0

        Else
            Dim objAllergyType = CreateDatabase.ExecuteScalarQuery("Select Allergy_Type From Allergy Where Allergy_Name = '" & cmbAllergies.Text & "';")

            cmbAllergiesType.SelectedItem = objAllergyType.ToString
            If cmbAllergiesType.SelectedItem = "Drug" Then
                'cmbMedicationName.SelectedItem = cmbAllergies.SelectedItem
                cmbSeverity.SelectedIndex = 0
            End If
        End If
    End Sub
    '/*********************************************************************/
    '/*                SUBPROGRAM NAME: cmbAllergies_SelectedIndexChanged */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:Adam Kott            		          */   
    '/*		         DATE CREATED:2/24/2021                     		   */                             
    '/*********************************************************************/
    '/*  FUNCTION PURPOSE:	When the user clicks the save button the      */             
    '/* database needs to be updated and then form needs to be reset and  */                     
    '/*  locked                                                            */
    '/*********************************************************************/
    '/*  CALLED BY: user clicking save button					         */           
    '/*                                                    				   */         
    '/*********************************************************************/
    '/*  CALLS: DisableEditButtons
    '/* ExecuteScalarQuery						                           */                 
    '/* GetPatientTuid                  								   */             
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
    '/*                                         */
    '/*                                                   */
    '/*                                                  */
    '/*   
    '/*********************************************************************/
    Private Sub cmbAllergies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAllergies.SelectedIndexChanged
        cmbSeverity.SelectedIndex = 0

        If cmbAllergiesType.Text = "Drug" Then
            cmbAllergiesType.Enabled = False

        Else
            cmbAllergiesType.Enabled = True
            'cmbMedicationName.SelectedIndex = -1
        End If
    End Sub

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
    Public Sub CreateAllergiesPanels(ByVal flpPannel As FlowLayoutPanel, ByVal strAllergyName As String, ByVal strAllergyType As String, ByVal strSeverity As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct

        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(850, 47)
            .Name = "pnlAllergiesPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(850, 45)
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
        lblID.Tag = strAllergyName
        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabelWithToolTip(pnlMainPanel, lblID, "lblAllergyName", lblAllergyName.Location.X, 20, strAllergyName, getPanelCount(flpPannel), tpToolTip, TruncateString(15, strAllergyName))
        ' CreateIDLabel(pnlMainPanel, lblID, "lblAllergyName", lblAllergyName.Location.X, 20, strAllergyName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblSeverity", lblSeverity.Location.X, 20, strSeverity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblAllergyType", lblAllergyType.Location.X, 20, strAllergyType, getPanelCount(flpPannel))
        '  CreateIDLabelWithToolTip(pnlMainPanel, lblID4, "lblMedication", lblMedication.Location.X, 20, strMedicationName, getPanelCount(flpPannel), tpToolTip, TruncateString(15, strMedicationName))
        '  CreateIDLabel(pnlMainPanel, lblID4, "lblMedication", lblMedication.Location.X, 20, strMedicationName, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        pnlMainPanel.Tag = strAllergyName
        flpPannel.Controls.Add(pnl)

    End Sub
    Private Sub DisableEditButtons()
        btnAddAllergy.Visible = True
        btnAllergyCancel.Visible = False
        btnAllergySave.Visible = False
        cmbAllergies.Enabled = True
        cmbAllergiesType.Enabled = True
        'cmbMedicationName.Enabled = True
    End Sub
    Private Sub frmAllergies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAllergyCancel.Visible = False
        btnAllergySave.Visible = False
        'cmbAllergiesLocked()

        Dim dsAllergies = CreateDatabase.ExecuteSelectQuery("Select * From Allergy ORDER BY Allergy_Type, Allergy_Name ;")
        Dim dsDrugAllergies = CreateDatabase.ExecuteSelectQuery("Select * From Allergy WHERE Allergy_Type = 'Drug' ORDER BY Allergy_Type, Allergy_Name ;")
        Dim dsAllergyType = CreateDatabase.ExecuteSelectQuery("Select DISTINCT Allergy_Type from Allergy;")

        populateAllergiesComboBox(cmbAllergies, dsAllergies)
        'populateMedicationComboBox(cmbMedicationName, dsDrugAllergies)
        populateAllergyTypeComboBox(cmbAllergiesType, dsAllergyType)
        Dim strSeverity As String = " "
        Dim intPatientTuid As Integer = GetPatientTuid()
        LoadAllergiesPanel(strSeverity, intPatientTuid)
    End Sub

    Private Sub LoadAllergiesPanel(strSeverity As String, intPatientTuid As Integer)
        'get the allergy information from the patient allergy tables
        Dim allergy As String = ""
        Dim intSeverity As Integer = 0
        Dim dtsPatientAllergy As DataSet = CreateDatabase.ExecuteSelectQuery("Select Allergy.Allergy_Name, PatientAllergy.Allergy_Severity," &
                                                                             "Allergy.Allergy_Type From PatientAllergy " &
                                                                             "INNER JOIN Allergy on PatientAllergy.Allergy_Name=Allergy.Allergy_Name" &
                            " Where Active_Flag =1 And Patient_TUID =" & (intPatientTuid).ToString & ";")
        ' insert the select statement here and send the results to the createAllergiesPanel
        cmbAllergies.SelectedIndex = -1
        For Each dr As DataRow In dtsPatientAllergy.Tables(0).Rows


            allergy = dr(0)
                cmbAllergies.Text = allergy
                'mbMedicationName.Text = "N/A"
                cmbAllergiesType.Text = dr(2)
            Debug.WriteLine("")

            intSeverity = CInt(CheckSeverity(dr))
            strSeverity = cmbSeverity.Items.Item(intSeverity)
            CreateAllergiesPanels(flpAllergies, allergy, cmbAllergiesType.Text, strSeverity)
            'cmbAllergiesLocked()
        Next
        'CreateAllergiesPanels()

        ClearComboBoxes()
        cmbAllergies.SelectedIndex = 0
    End Sub

    Public Function GetPatientMrn() As Integer

        Return intPatientInformationMRN

    End Function
    Public Function GetPatientTuid() As Integer
        ' Dim intPatientInformationMRN = CInt(frmPatientInfo.txtMRN.Text)
        ' on form load we need to select all allergies from the database and show them here:
        Dim intPatientTuid As Integer = CInt(CreateDatabase.ExecuteScalarQuery("select patient.Patient_ID From Patient " &
                        "where Patient.MRN_Number=" & (intPatientInformationMRN).ToString & ";"))
        Return intPatientTuid
    End Function
    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME: SetPatientMrn          		   */         
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
    Public Sub SetPatientMrn(ByVal mrn As Integer)

        intPatientInformationMRN = mrn

    End Sub

    Private Sub cmbAllergies_LostFocus(sender As Object, e As EventArgs) Handles cmbAllergies.MouseLeave
        If cmbAllergies.Text = "" Then
            cmbAllergiesType.Enabled = True
        End If
    End Sub
    Private Sub ClearComboBoxes()
        cmbAllergies.SelectedIndex = -1
        cmbAllergiesType.SelectedIndex = -1
        cmbSeverity.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearComboBoxes()
    End Sub
End Class