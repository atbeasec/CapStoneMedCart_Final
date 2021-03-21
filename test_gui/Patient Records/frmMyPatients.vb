Public Class frmMyPatients
    Private Sub frmMyPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rdbShowAll.Checked = True
        ' LoadPanel()

        'CreatePanelMyPatients(flpMyPatientRecords, "test", "test", "test", "11/11/1998", "test", "test", 12)
        'CreatePanelMyPatients(flpMyPatientRecords, "test", "test", "test", "11/11/1998", "test", "test", 12)
        'CreatePanelMyPatients(flpMyPatientRecords, "test", "test", "test", "11/11/1998", "test", "test", 12)


        ' select the my patients item from the cbobox by default
        cboFilter.SelectedIndex = 0
        'HideButtonOnPanels()

    End Sub
    Private Sub LoadPanel()
        Dim UserID As Integer = 9
        Dim strUserFirst As String = ""
        Dim strUserLast As String = ""
        Dim strVisitDate As String = ""
        Dim dsPatientUser As DataSet
        Dim dsUser As DataSet
        Dim dsPatient As DataSet
        Dim intPhysicianID As Integer = 0
        Dim intPatientID As Integer = 0
        Dim intPatientMRN As Integer = 0
        Dim strPatientFirst As String = ""
        Dim strPatientLast As String = ""
        Dim StrDOB As String = ""
        Dim strRoom As String = ""
        Dim strBed As String = ""
        Dim intActive_Flag As String = ""

        dsUser = CreateDatabase.ExecuteSelectQuery("Select User_First_Name, User_Last_Name From User Where User_ID =" & UserID.ToString & " ;")
        For Each row As DataRow In dsUser.Tables(0).Rows
            strUserFirst = row(0)

            strUserLast = row(1)
            Next
        '  txtPhysician.Text = (strUserFirst + " " + strUserLast + ", " + UserID.ToString())
        '  If rdbShowAll.Checked = True Then
        dsPatientUser = CreateDatabase.ExecuteSelectQuery("Select * From PatientUser Where User_TUID =" & UserID.ToString & ";")
            For Each row As DataRow In dsPatientUser.Tables(0).Rows
                intPatientID = row(0)
                strVisitDate = row(2)
                dsPatient = CreateDatabase.ExecuteSelectQuery("Select MRN_Number, Patient_First_Name, Patient_Last_Name, Date_of_Birth, Primary_Physician_ID, Patient.Patient_ID, PatientRoom.Patient_TUID, Room_TUID, Bed_Name FROM Patient LEFT JOIN PatientRoom ON PatientRoom.Patient_TUID = Patient.Patient_ID Where Patient_ID =" & intPatientID.ToString() & ";")
                For Each Patient As DataRow In dsPatient.Tables(0).Rows
                    intPatientMRN = Patient(0)
                    strPatientFirst = Patient(1)
                    strPatientLast = Patient(2)
                    StrDOB = Patient(3)
                    intPhysicianID = Patient(4)
                    strRoom = Patient(7)
                    strBed = Patient(8)
                    'StrDOB = StrDOB.Substring(0, 9)
                    Debug.WriteLine("")
                    frmPatientRecords.CreatePanel(flpMyPatientRecords, intPatientMRN.ToString, strPatientFirst, strPatientLast, StrDOB, strRoom, strBed, intPatientID)
                Next

                Debug.WriteLine("")

            Next
            '  ElseIf rdbOnlyActive.Checked = True Then
            dsPatientUser = CreateDatabase.ExecuteSelectQuery("Select * From PatientUser Where User_TUID =" & UserID.ToString & " AND Active_Flag = 1 ;")
            For Each row As DataRow In dsPatientUser.Tables(0).Rows
                intPatientID = row(0)
                strVisitDate = row(2)
                dsPatient = CreateDatabase.ExecuteSelectQuery("Select MRN_Number, Patient_First_Name, Patient_Last_Name, Date_of_Birth, Primary_Physician_ID, Patient.Patient_ID, PatientRoom.Patient_TUID, Room_TUID, Bed_Name FROM Patient LEFT JOIN PatientRoom ON PatientRoom.Patient_TUID = Patient.Patient_ID Where Patient_ID =" & intPatientID.ToString() & ";")
                For Each Patient As DataRow In dsPatient.Tables(0).Rows
                    intPatientMRN = Patient(0)
                    strPatientFirst = Patient(1)
                    strPatientLast = Patient(2)
                    StrDOB = Patient(3)
                    intPhysicianID = Patient(4)
                    strRoom = Patient(7)
                    strBed = Patient(8)
                    'StrDOB = StrDOB.Substring(0, 9)
                    Debug.WriteLine("")
                    frmPatientRecords.CreatePanel(flpMyPatientRecords, intPatientMRN.ToString, strPatientFirst, strPatientLast, StrDOB, strRoom, strBed, intPatientID)
                Next

                Debug.WriteLine("")

            Next
        '  End If


    End Sub

    Private Sub rdbOnlyActive_CheckedChanged(sender As Object, e As EventArgs)
        flpMyPatientRecords.Controls.Clear()
        '  LoadPanel()
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: CreatePanel()                  */         
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
    '/* strMRN- value from the database we will display                   */
    '/* strFirstName- Name of the user in the database                    */
    '/* strLastName- Last Name of the user in the database                */
    '/* strBirthday- DOB of the user in the database                      */
    '/* strRoom- room of the user in the database                         */
    '/* strBed- bed of the user in the database                           */
    '/* intPatietnID- the ID of the patient that is being added           */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	   CreatePanel(flpUserInfo, strID9, strFirstName9, strAccess9)    */
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
    Public Sub CreatePanelMyPatients(ByVal flpPannel As FlowLayoutPanel, ByVal strMRN As String, ByVal strFirstName As String, ByVal strLastName As String, ByVal strBirthday As String, ByVal strRoom As String, ByVal strBed As String, ByRef intPatientID As Integer)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel

        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(1030, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(1050, 45)
            .Name = "pnlIndividualPatientRecord" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)

        AddHandler pnlMainPanel.Click, AddressOf frmPatientRecords.DynamicSingleClickOpenPatient
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        ' add controls to this panel

        Dim lblID1 As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Dim lblID6 As New Label

        Const YCOORDINATE As Integer = 20
        ' CreateCheckBox(pnlMainPanel, getPanelCount(flpPannel), lblMRN.Location.X - 45, 5)
        CreateAddButton(pnlMainPanel, getPanelCount(flpPannel), lblAssignment.Location.X + 15, 5)
        CreateRemoveButton(pnlMainPanel, getPanelCount(flpPannel), lblAssignment.Location.X + 15, 5)
        CreateIDLabelWithToolTip(pnlMainPanel, lblID1, "lblMRN", lblMRN.Location.X, YCOORDINATE, strMRN, getPanelCount(flpPannel), tpToolTip, TruncateString(15, strMRN))
        CreateIDLabelWithToolTip(pnlMainPanel, lblID2, "lblFirstName", lblFirstName.Location.X, YCOORDINATE, strFirstName, getPanelCount(flpPannel), tpToolTip, TruncateString(25, strFirstName))
        CreateIDLabelWithToolTip(pnlMainPanel, lblID3, "lblLastName", lblLastName.Location.X, YCOORDINATE, strLastName, getPanelCount(flpPannel), tpToolTip, TruncateString(25, strLastName))
        CreateIDLabel(pnlMainPanel, lblID4, "lblBirthday", lblDOB.Location.X, YCOORDINATE, strBirthday.Substring(0, 10), getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblRoom", lblRoom.Location.X, YCOORDINATE, strRoom, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblBed", lblBed.Location.X, YCOORDINATE, strBed, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)
        pnlMainPanel.Tag = intPatientID

    End Sub


    '/********************************************************************/
    '/*                   SUB NAME: CreateAddButton             	     */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/6/21			                     */                             
    '/********************************************************************/
    '/*  SUB Purpose:This sub creates a button at run time to be aded to  /
    '/*  the form.                                                       */
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY: (none)                             	      		     */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 pnlpanelName- name of the panel to add the control to           */	 
    '/*  intPanelsAddedCount- current number of panels added on the form */	 
    '/*  intX- x coordinate of where to place the control                */	 
    '/*  intY- Y coordinate of where to place the control                */	 
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	DynamicSingleClickOpenPatient()					                 */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 none                           				                 */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                                 
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		2/6/21		 initial creation                            */
    '/********************************************************************/ 

    Private Sub CreateAddButton(ByVal pnlPanelName As Panel, ByVal intPanelsAddedCount As Integer, ByVal intX As Integer, ByVal intY As Integer)

        Dim btnAddButton As Button
        btnAddButton = New Button
        'declare our image and point at the resource
        Dim mapImagePencil As New Bitmap(New Bitmap(My.Resources.add_icon1), 20, 20)

        'Set button properties
        With btnAddButton
            .AutoSize = True
            .Size = New Size(30, 30)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            '.Location = New Point(825, 5)
            .Location = New Point(intX, intY)
            .Name = "btnAddButton" + (intPanelsAddedCount).ToString
            .Image = mapImagePencil
            .ImageAlign = ContentAlignment.MiddleCenter
            .Tag = intPanelsAddedCount + 1
            '   .Visible = False

        End With

        Debug.Print(pnlPanelName.Name)
        pnlPanelName.Controls.Add(btnAddButton)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnAddButton.Click, AddressOf btnAddAssignment_Click

    End Sub

    '/********************************************************************/
    '/*                   SUB NAME: CreateRemoveButton             	     */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/6/21			                     */                             
    '/********************************************************************/
    '/*  SUB Purpose:This sub creates a button at run time to be aded to  /
    '/*  the form.                                                       */
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY: (none)                             	      		     */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 pnlpanelName- name of the panel to add the control to           */	 
    '/*  intPanelsAddedCount- current number of panels added on the form */	 
    '/*  intX- x coordinate of where to place the control                */	 
    '/*  intY- Y coordinate of where to place the control                */	 
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	DynamicSingleClickOpenPatient()					                 */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 none                           				                 */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                                 
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		2/6/21		 initial creation                            */
    '/********************************************************************/ 
    Private Sub CreateRemoveButton(ByVal pnlPanelName As Panel, ByVal pnlPanelsAddedCount As Integer, ByVal intX As Integer, ByVal intY As Integer)

        Dim btnRemove As Button
        btnRemove = New Button
        'declare our image and point at the resource
        Dim mapImagePencil As New Bitmap(New Bitmap(My.Resources.minus_icon1), 20, 20)

        'Set button properties
        With btnRemove
            .AutoSize = True
            .Size = New Size(30, 30)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            '.Location = New Point(825, 5)
            .Location = New Point(intX, intY)
            .Name = "btnRemove" + (pnlPanelsAddedCount).ToString
            .Image = mapImagePencil
            .ImageAlign = ContentAlignment.MiddleCenter
            .Tag = pnlPanelsAddedCount + 1
            '  .Visible = False
        End With

        Debug.Print(pnlPanelName.Name)
        pnlPanelName.Controls.Add(btnRemove)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnRemove.Click, AddressOf RemoveAssignment_Click

    End Sub

    '/********************************************************************/
    '/*                   SUB NAME: RemoveAssignment_Click      	     */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/6/21			                     */                             
    '/********************************************************************/
    '/*  SUB Purpose:This sub is the handler that is called when the remove
    '/*  button is clicked                                               */
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY:    	      		     */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 sender- object representing a control                           */
    '/*  e- eventargs indicating there is an event handle assigned       */
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*				                 */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 none                           				                 */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                                 
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		2/6/21		 initial creation                            */
    '/********************************************************************/ 
    Private Sub RemoveAssignment_Click(ByVal sender As Object, e As EventArgs)

        Dim patientIDFromSelectedRecord As Integer = CInt(sender.parent.tag)
        RemoveOnScreenPanel(sender)
        MessageBox.Show("Patient unassigned to you")



        '*******************
        ' ADAM if a patient was removed from the assingment, take the patient ID and indicate in the DB they are no longer assiged to the logged in user.



        '*******************
        ' ADAM recall the create panel method if necessary. For example, if the patient was removed from my patients, we should remove that patient on the screen.



    End Sub

    '/********************************************************************/
    '/*                   SUB NAME: btnAddAssignment_Click      	     */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/6/21			                     */                             
    '/********************************************************************/
    '/*  SUB Purpose:This sub is the handler that is called when the remove
    '/*  button is clicked                                               */
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY:    	      		     */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 sender- object representing a control                           */
    '/*  e- eventargs indicating there is an event handle assigned       */
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*				                 */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 none                           				                 */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                                 
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		2/6/21		 initial creation                            */
    '/********************************************************************/ 
    Private Sub btnAddAssignment_Click(ByVal sender As Object, e As EventArgs)

        Dim patientIDFromSelectedRecord As Integer = CInt(sender.parent.tag)
        RemoveOnScreenPanel(sender)

        MessageBox.Show("Patient assigned to you")



    End Sub

    '/********************************************************************/
    '/*                   SUB NAME: cboFilter_SelectedIndexChanged       */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/6/21			                     */                             
    '/********************************************************************/
    '/*  SUB Purpose:This sub determines the current item selected       */
    '/* in the combobox and then calls the necessary method accordingly. */
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY:    	      		     */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 sender- object representing a control                           */
    '/*  e- eventargs indicating there is an event handle assigned       */
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*				                                                      */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 none                           				                 */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                                 
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		2/6/21		 initial creation                            */
    '/********************************************************************/ 
    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged

        'my patients
        If cboFilter.SelectedIndex = 0 Then
            '******************* 
            ' flpMyPatientRecords.Controls.Clear()
            ' ADAM call this before calling a create panel method to show the new items



            ShowAllControlsOnPanels()
            HideControlOnPanels("btnAdd")
            lblAssignment.Text = "Remove Assignment"

        ElseIf cboFilter.SelectedIndex = 1 Then
            '******************* 
            ' flpMyPatientRecords.Controls.Clear()
            ' ADAM call this before calling a create panel method to show the new items


            ShowAllControlsOnPanels()
            HideControlOnPanels("btnRemove")
            lblAssignment.Text = "Assign Patient To Me"

        ElseIf cboFilter.SelectedIndex = 2 Then


            '******************* 
            ' flpMyPatientRecords.Controls.Clear()
            ' ADAM call this before calling a create panel method to show the new items


            ShowAllControlsOnPanels()
            HideControlOnPanels("btnRemove")
            lblAssignment.Text = "Assign Patient To Me"

        ElseIf cboFilter.SelectedIndex = 3 Then
            '******************* 
            ' flpMyPatientRecords.Controls.Clear()
            ' ADAM call this before calling a create panel method to show the new items


            ShowAllControlsOnPanels()
            HideControlOnPanels("btnRemove")
            lblAssignment.Text = "Assign Patient To Me"

            'ElseIf cboFilter.SelectedIndex = 2 Then

        End If

    End Sub

    '/********************************************************************/
    '/*                   SUB NAME: HideControlOnPanels                  */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/6/21			                     */                             
    '/********************************************************************/
    '/*  SUB Purpose:This sub iterates over the flow panel and modifies  */
    '/*  controls within. It hides the button containing the name passed in
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY:    	      		     */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 nameOfControlToHide- string of the control name we want to hide.*/
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*				                                                      */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 paddingPanel- represents the padding panel                      */
    '/*	 panelWithControls- represents the panel containing the buttons  */
    '/*	 controlOnPanel- represents the single control on the panel      */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                                 
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		2/6/21		 initial creation                            */
    '/********************************************************************/ 
    Private Sub HideControlOnPanels(ByVal nameOfControlToHide As String)

        Dim paddingPanel As Control
        Dim panelWithControls As Control
        Dim controlOnPanel As Control
        ' Dim control As Control

        For Each paddingPanel In flpMyPatientRecords.Controls
            For Each panelWithControls In paddingPanel.Controls
                For Each controlOnPanel In panelWithControls.Controls

                    ' hide the specific control we need to
                    If controlOnPanel.Name.Contains(nameOfControlToHide) Then

                        controlOnPanel.Visible = False

                    End If
                    ' Debug.Print(controlOnPanel.Name)
                Next
            Next
        Next

    End Sub

    '/********************************************************************/
    '/*                   SUB NAME: ShowAllControlsOnPanels              */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/6/21			                     */                             
    '/********************************************************************/
    '/*  SUB Purpose:This sub iterates over the flow panel and modifies  */
    '/*  controls within. It hides the button containing the name passed in
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY:    	      		     */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 (NONE)                                                          */
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*				                                                      */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 paddingPanel- represents the padding panel                      */
    '/*	 panelWithControls- represents the panel containing the buttons  */
    '/*	 controlOnPanel- represents the single control on the panel      */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                                 
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		2/6/21		 initial creation                            */
    '/********************************************************************/ 
    Private Sub ShowAllControlsOnPanels()

        Dim paddingPanel As Control
        Dim panelWithControls As Control
        Dim controlOnPanel As Control
        ' Dim control As Control

        For Each paddingPanel In flpMyPatientRecords.Controls
            For Each panelWithControls In paddingPanel.Controls
                For Each controlOnPanel In panelWithControls.Controls

                    ' hide the specific control we need to

                    controlOnPanel.Visible = True


                    ' Debug.Print(controlOnPanel.Name)


                Next
            Next
        Next

    End Sub


    '/********************************************************************/
    '/*                   SUB NAME: RemoveOnScreenPanel                  */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/6/21			                     */                             
    '/********************************************************************/
    '/*  SUB Purpose:This destroys the panel that sender (a control) lives
    '/*  within                                                          */
    '/********************************************************************/
    '/*  CALLED BY:    	      		     */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 (NONE)                                                          */
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*				                                                      */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */

    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                                 
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		2/6/21		 initial creation                            */
    '/********************************************************************/ 
    Public Sub RemoveOnScreenPanel(ByVal sender As Object)
        Dim ctlControl As Control = sender.Parent
        Dim ctlParents As Control = ctlControl.Parent

        Dim ctlParentFlowPanel As Control = ctlControl.Parent
        Dim strParentPanelName As String
        strParentPanelName = Nothing

        'Remove handler from sender
        For Each ctlObject As Control In ctlParentFlowPanel.Controls
            For Each ctlChildControlObj As Control In ctlObject.Controls
                If ctlChildControlObj.Name = sender.name Then

                    RemoveHandler ctlChildControlObj.Click, AddressOf DynamicButton_Click

                    strParentPanelName = ctlChildControlObj.Parent.Name
                End If
            Next
        Next

        'Remove  panel
        For Each ctlObject As Control In ctlParentFlowPanel.Controls
            If ctlObject.Name = strParentPanelName Then

                ' prompt user if they are sure they want to delete the record
                ' remove the record from the database
                'remove the padding panel from the flow panel
                ctlParentFlowPanel.Controls.Remove(ctlObject.Parent)
                ctlObject.Parent.Dispose()

                'remove the panel from the flow panel
                ctlParentFlowPanel.Controls.Remove(ctlObject)
                ctlObject.Dispose()

            End If
        Next
    End Sub

End Class