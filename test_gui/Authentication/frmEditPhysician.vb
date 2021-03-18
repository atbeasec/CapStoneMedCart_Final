Imports System.Text
Imports System.Text.RegularExpressions

Public Class frmEditPhysician

    Public Enum AddAndRemovePhysicianEnum

        name = 1
        username = 2
        permissions = 3
        active = 4

    End Enum

    '/*********************************************************************/
    '/*                   SubProgram NAME: frmEditPhysician_Load          */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Dylan Walter        		          */   
    '/*		         DATE CREATED: 		 2/10/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This  sub program is used to populate the flpPhysicianInfo Flow       */
    '/* Layout Panel from the User Table and set the default radio button */ 
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */                 
    '/*********************************************************************/
    '/*  CALLS:	CreateDatabase.ExecuteSelectQuery                         */ 
    '/*         Create Panel                                              */                 
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     sender                                                      */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	  Launched on load                                               */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */   
    '/*strFirst- User first name pulled from User Table                     */
    '/*strLast- User last name pulled from User Table                     */
    '/*strName- Combined first and last name                              */
    '/*strRole- Permission level given by flags in the User Table          */
    '/*dsUserInfo- data table to store data brought in from database      */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  Dylan W    2/10/2021    Initial creation and pull data from DB   */
    '/*********************************************************************/
    Private Sub frmEditPhysician_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strFillSQL As String = "select Physician.Physician_ID, Physician.Physician_First_Name, Physician.Physician_Middle_Name," &
                                    "Physician.Physician_Last_Name, Physician.Physician_Credentials, Physician.Physician_Phone_Number," &
                                    "Physician.Physician_Fax_Number, Physician.Physician_Address, Physician.Physician_City," &
                                    "Physician.Physician_State, Physician.Physician_Zip_Code, Physician.Active_Flag From Physician;"
        Fill_Table(strFillSQL)

        cmbCredentials.Items.AddRange({"Advisor", "Diagnose", "Prescribe"})
        'btnSaveChanges.Visible = False
        btnCancel.Visible = False

        'CreateToolTips(pnlPhysicianHeader, tpLabelHover)
        AddHandlerToLabelClick(pnlPhysicianHeader, AddressOf SortBySelectedLabel)

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
    '/*	field- an integer equal to the tag value of the selected label
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  3/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub SortBySelectedLabel(sender As Object, e As EventArgs)

        Dim parent As Panel = sender.parent
        Dim field As Integer = CInt(sender.tag)

        BoldLabelToSortBy(sender, parent)

        'check If the user Is selecting a dispense history field to sort by
        If parent.Name = pnlPhysicianHeader.Name Then

            EditPhysicianSelectedFields(field)

        End If


    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: EditPhysicianSelectedFields   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		  */   
    '/*		         DATE CREATED: 		 2/14/2021                 */                             
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
    '/*	 EditPhysicianSelectedFields(Cint(Label1.Tag))   	              */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	none                                                              */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  3/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub EditPhysicianSelectedFields(ByVal field As Integer)

        ' clear the controls as they will need to be rebuilt when sorting
        'flpPatientRecords.Controls.Clear()

        Select Case field

            Case AddAndRemovePhysicianEnum.name

            Case AddAndRemovePhysicianEnum.username

            Case AddAndRemovePhysicianEnum.permissions

            Case AddAndRemovePhysicianEnum.active

        End Select

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
    '/*  CALLED BY: frmEditPhysician_Load  	      						  */           
    '/*                                                                     */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 NONE                                                             */ 
    '/* flpPannel- the flow panel which the user wants to create the      */
    '/*     create the single panel.                                      */
    '/* strID- value from the database we will display                    */
    '/* strName- Name of the user in the database                         */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	   CreatePanel(flpPhysicianInfo, strID9, strFirstName9, strAccess9)    */
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
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  Collin Krygier  2/6/2021    Initial creation                     */
    '/*********************************************************************/
    Public Sub CreatePanel_Physician(ByVal flpPannel As FlowLayoutPanel, ByVal strID As String, ByVal strName As String, ByVal strAccess As String, ByVal strActive As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct

        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(flpPhysicianInfo.Size.Width - 25, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(flpPhysicianInfo.Size.Width - 25, 45)
            .Name = "pnlIndividualPatientRecord" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)

        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        CreateEditButton(pnlMainPanel, getPanelCount(flpPannel), lblActions.Location.X - 15, 5)
        CreateDeleteBtn(pnlMainPanel, getPanelCount(flpPannel), lblActions.Location.X + 30, 5)

        ' create labels at run time and pass them to the create label method to format how the labels will look and their
        ' properties
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        lblID.Visible = False
        Const INTTWENTY As Integer = 20

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblID", lblName.Location.X - 15, INTTWENTY, strID, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblNames", lblName.Location.X, INTTWENTY, strName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblPermissions", lblPermissions.Location.X, INTTWENTY, strAccess, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblStatus", lblStatus.Location.X, INTTWENTY, strActive, getPanelCount(flpPannel))


        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub

    '/*********************************************************************/
    '/*                   Function NAME: RadioButtonSelection()           */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/6/2021                         */                             
    '/*********************************************************************/
    '/*  Function   PURPOSE:								              */             
    '/*	 This is function is intended to take the selected radio button   */
    '/*  and return a string representation of the selection.             */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*             */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  RETURNS ():					                                  */         
    '/*	 function returns a string that will be sent to the database    - */
    '/*  representing the user permission.                                */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 NONE                                                             */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	   CreatePanel(flpPhysicianInfo, strID9, strFirstName9, strAccess9)    */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	strPrivilege- a string which will be returned by the function that*/
    '/* contains the selected radio button string.                        */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  Collin Krygier  2/6/2021    Initial creation                     */
    '/*  Dylan Walter    2/7/2021    commented out, using flags in DB now */
    '/*********************************************************************/
    'Function RadioButtonSelection() As String

    '    Dim strPrivilege As String = Nothing

    '    Const NURSE As String = "nurse"
    '    Const ADMIN As String = "administrator"
    '    Const SUPERVISOR As String = "supervisor"

    '    If rbtnNurse.Checked = True Then

    '        strPrivilege = NURSE
    '    ElseIf rbtnAdministrator.Checked = True Then

    '        strPrivilege = ADMIN
    '    ElseIf rbtnSupervisor.Checked = True Then
    '        strPrivilege = SUPERVISOR
    '    End If

    '    Return strPrivilege
    'End Function


    '/*********************************************************************/
    '/*                   SubProgram NAME: txtUsername_LostFocus          */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Dylan Walter        		          */   
    '/*		         DATE CREATED: 		 2/10/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This  sub program is used to check if the Username already exist */ 
    '/*  in the User table when you leave txtUsername  				      */   
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */                 
    '/*********************************************************************/
    '/*  CALLS:	CreateDatabase.ExecuteScalarQuery                        */            
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     sender                                                      */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	  "dwwalter"                                                       */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */   
    '/*strStatement- SQL String passed to ExecuteScalarQuery to check     */
    '/* User table for a duplicate Username                              */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  Dylan W    2/10/2021    Initial creation and check data in DB   */
    '/*********************************************************************/
    Private Sub mtbPhone_LostFocus(sender As Object, e As EventArgs) Handles mtbPhone.LostFocus
        'String to be sent to CreateDatabase Module to exicute search to check if Username is already in the User Table
        Dim strStatement = "SELECT COUNT(*) FROM Physician WHERE Physician_Phone_Number = '" & mtbPhone.Text & "'"
        If ExecuteScalarQuery(strStatement) <> 0 Then
            MsgBox("A User already has that Username")
            mtbPhone.Focus()
            'txtUsername.Text = ""
        End If
    End Sub


    '/*********************************************************************/
    '/*                   SubProgram NAME: txtBarcode_LostFocus          */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Dylan Walter        		          */   
    '/*		         DATE CREATED: 		 2/10/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This  sub program is used to check if the Barcode already exist */ 
    '/*  in the User table when you leave txtBarcode  				      */   
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */                 
    '/*********************************************************************/
    '/*  CALLS:	CreateDatabase.ExecuteScalarQuery                        */            
    '/*                                             				      */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	     sender                                                      */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	  "6gGMRK7bIKlWkNEp4mT71hAU"                                       */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */   
    '/*strStatement- SQL String passed to ExecuteScalarQuery to check     */
    '/* User table for a duplicate Bqarcode                              */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO        WHEN            WHAT					               */             
    '/*  Dylan W    2/10/2021    Initial creation and check data in DB   */
    '/*********************************************************************/
    Private Sub txtBarcode_LostFocus(sender As Object, e As EventArgs) Handles mtbFax.LostFocus
        ' Convert the barcode to the peppered hash
        Dim strStatement = "SELECT COUNT(*) FROM Physician WHERE Physician_Fax_Number = '" & mtbFax.Text & "'"
        'String to be sent to CreateDatabase Module to exicute search to check if Barcode is already in the User Table
        If ExecuteScalarQuery(strStatement) <> 0 Then
            MsgBox("A User already has that Barcode")
            mtbFax.Focus()
        End If
    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: Button1_Click 		    	   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY: Dylan Walter    		            */   
    '/*		         DATE CREATED: 2/6/2021                      		   */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE: when button1 is clicked check if data in all 	*/             
    '/*	text boxes is valid and insert into the User table in SQL 			*/                     
    '/*  database                                                                 */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						         */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:	CheckPassword						        			   */                 
    '/*         CreateDatabase.ExecuteInsertQuery   					   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					   */         
    '/*											   */                     
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*											   */                     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*		intActiveFlag- used to assign 1 to the active flag      	   */                     
    '/*      intAdmin- 1 if admin radio button is checked                   */
    '/*		strFirstName- text from txtFirstName 							*/
    '/*     strHashedBarcode - hashed barcode
    '/*		strLastName- text from txtLastName								*/
    '/*		strPassword- text from txtPassword								*/
    '/*     strResults() - the results of the salt and the hashed password  */
    '/*     strSalt - the salt of the password                              */
    '/*		strSpecialChar-	list of allowed special characters				*/
    '/*     strStatement- SQL String passed to ExecuteScalarQuery to check */
    '/*		intSupervisor- 1 if supervisor radio button is checked		    */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO        WHEN     WHAT								   */             
    '/*  ---        ----     ------------------------------------------------- */
    '/*	Dylan W	    2/3/2021  Users can now be added to the User Table		*/ 
    '/*  NP         2/10/2021 Changed the first and last name to accept '-@ */  
    '/*	Dylan W     2/10/2021 checked first and last for multiple ' 	   */ 
    '/* Eric L.     2/17/2021 Added methods to salt, pepper and hash        */
    '/*********************************************************************/


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim intSupervisor As Integer = 0
        Dim intAdmin As Integer = 0
        Dim intActiveFlag As Integer = 1
        Dim strLastName As String = txtLastName.Text
        Dim strFirstName As String = txtFirstName.Text
        Dim strMiddleName As String = txtMiddleName.Text
        Dim strSalt As String = Nothing
        Dim strResults() As String = Nothing ' this will hold the salted, peppered, hashed password and the salt
        strFirstName = Regex.Replace(strFirstName, "'", "''")
        strLastName = Regex.Replace(strLastName, "'", "''")
        strMiddleName = Regex.Replace(strMiddleName, "'", "''")



        'call CheckPassword Function to see if password mets security standards
        'Make Sure all fields are filled
        If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtMiddleName.Text = "" Or mtbPhone.Text = "" Or mtbFax.Text = "" Then
            MsgBox("All Fields must be filled")
        Else

            'Insert data into table by calling ExecuteInsertQuery in CreateDatabase Module

            Dim strStatement = "INSERT INTO Physician(Physician_First_Name, Physician_Middle_Name, Physician_Last_Name, Physician_Credentials, Physician_Phone_Number, Physician_Fax_Number, Physician_Address, Physician_City, Physician_State, Physician_Zip_Code, Active_Flag)" &
            "VALUES('" & strFirstName & "','" & strMiddleName & "','" & strLastName & "','" & cmbCredentials.SelectedItem & "','" & mtbPhone.Text & "','" & mtbFax.Text & "','" & txtAddress.Text & "','" & txtCity.Text & "','" & cmbState.SelectedItem & "','" & txtZipCode.Text & "','" & intActiveFlag & "')"
            ExecuteInsertQuery(strStatement)



            strStatement = "SELECT User_ID FROM User ORDER BY User_ID DESC LIMIT 1;"
            Dim strNewID As String = ExecuteScalarQuery(strStatement)
            Dim strFullName As String = strFirstName & " " & strLastName

            ' do query to return the record that was just created and return the result into the create panel method below
            CreatePanel_Physician(flpPhysicianInfo, strNewID, strFullName, cmbCredentials.SelectedItem, "Yes")





            'clear all text boxes
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtMiddleName.Text = ""
        End If


    End Sub

    '/*********************************************************************/
    '/*                   SUBPROGRAM NAME:  CheckPassword			   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Dylan Walter   						 */   
    '/*		         DATE CREATED: 	2/7/2021							   */                             
    '/*********************************************************************/
    '/*  SUBPROGRAM PURPOSE:											   */             
    '/*  Will check if the password being entered meets security          */
    '/*  requierments                                                     */
    '/*********************************************************************/
    '/*  CALLED BY: Button1_Click        	      						  */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										   */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):								*/         
    '/*	 strPassword - this is the password being tested                  */ 
    '/*					    `   										  */
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								         */                   
    '/*            Secure								   */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								   */             
    '/*											   */                     
    '/*
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*		regLower- Regex of all lowercase letters						*/                     
    '/*		intMinLength- number of needed characters					*/ 
    '/*		regNumber- Regex of all numbers 								*/ 
    '/*		intNumLower- number of needed lowercase letters 				*/ 
    '/*		intNumNumbers- number of needed numbers							*/ 
    '/*		intNumUpper- number of needed uppercase letters					*/ 
    '/*		intNumSpecial- number of needed special characters 				*/ 
    '/*		bolSecure- returned boolean, true if requirements are met	    */    
    '/*     regSpecial- Regex of all other characters                       */
    '/*     regUpper- Regex of all uppercase letters                        */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                        */               
    '/*											                            */                     
    '/*  WHO            WHEN        WHAT								   */             
    '/*  ---            ----        ------------------------------------- */
    '/*  Dylan Walter   2/7/2021    Initial Creation                      */
    '/*  Nathan Premo   2/10/2021   adding the ability for first and last */
    '/*                             name to have ' - @                    */
    '/*********************************************************************/
    Function CheckPassword(strPassword)
        'Security Requierments 
        Dim intMinLength As Integer = 8
        Dim intNumUpper As Integer = 1
        Dim intNumLower As Integer = 1
        Dim intNumNumbers As Integer = 1
        Dim intNumSpecial As Integer = 1
        Dim bolSecure As Boolean = True

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim regUpper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim regLower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim regNumber As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim regSpecial As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(strPassword) < intMinLength Then bolSecure = False
        ' Check for minimum number of occurrences.
        If regUpper.Matches(strPassword).Count < intNumUpper Then bolSecure = False
        If regLower.Matches(strPassword).Count < intNumLower Then bolSecure = False
        If regNumber.Matches(strPassword).Count < intNumNumbers Then bolSecure = False
        If regSpecial.Matches(strPassword).Count < intNumSpecial Then bolSecure = False

        ' Passed all checks.
        Return bolSecure
    End Function

    Private Sub txtFirst_Last_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiddleName.KeyPress, txtLastName.KeyPress, txtFirstName.KeyPress
        KeyPressCheck(e, "abcdefghijklmnopqrstuvwxyz '-1234567890!@#$%^&*()/.,<>=+")
    End Sub

    'Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
    '    Dim intID As Integer = txtID.Text
    '    Dim strStatement = "SELECT COUNT(*) FROM User WHERE Username = '" & txtUsername.Text & "'" & " OR User_ID = '" & intID & "'"
    '    Dim intSupervisor As Integer = 0
    '    Dim intAdmin As Integer = 0
    '    Dim strPassword As String = txtPassword.Text
    '    Dim strLastName As String = txtLastName.Text
    '    Dim strFirstName As String = txtFirstName.Text
    '    Dim strSalt As String = Nothing
    '    Dim strResults() As String = Nothing ' this will hold the salted, peppered, hashed password and the salt
    '    Dim strHashedBarcode As String
    '    strFirstName = Regex.Replace(strFirstName, "'", "''")
    '    strLastName = Regex.Replace(strLastName, "'", "''")

    '    'check what Role the user will have
    '    If rbtnAdministrator.Checked = True Then
    '        intAdmin = 1
    '    ElseIf rbtnSupervisor.Checked = True Then
    '        intSupervisor = 1
    '    End If

    '    'check if the user is changing the password and ran if yes

    '    If txtConfirmPassword.Text <> "" And txtPassword.Text <> "" Then
    '        'if it returns 2 then the username was changed to something already in the database 
    '        If ExecuteScalarQuery(strStatement) = 2 Then
    '            MsgBox("A User already has that Username")
    '            'call CheckPassword Function to see if password mets security standards
    '        ElseIf CheckPassword(strPassword) = False Then
    '            MsgBox("Password must contain at least 8 characters, 1 uppercase, 1 lowercase, 1 number, 1 special characters !@#$%^&* ")
    '            txtPassword.Focus()
    '            ' make sure password and Confirm Password Match
    '        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
    '            MsgBox("Confirm Password must match Password")
    '            txtConfirmPassword.Focus()
    '            'Make Sure all fields are filled
    '        ElseIf txtFirstName.Text = "" Or txtLastName.Text = "" Or txtUsername.Text = "" Then
    '            MsgBox("All Fields must be filled12")
    '        Else
    '            ' get the peppered hash of the password
    '            strResults = LogIn.MakeSaltPepperAndHash(strPassword)
    '            strPassword = strResults(0)
    '            strSalt = strResults(1)

    '            If txtBarcode.Text = "" Then
    '                'Insert data into table by calling ExecuteInsertQuery in CreateDatabase Module
    '                strStatement = "UPDATE USER SET Username='" & txtUsername.Text & "',Salt='" & strSalt & "',Password='" & strPassword & "',User_First_Name='" & strFirstName & "',User_Last_Name='" & strLastName & "',Admin_Flag='" & intAdmin & "',Supervisor_Flag='" & intSupervisor & "',Active_Flag=1 WHERE User_ID='" & txtID.Text & "';"
    '                ExecuteInsertQuery(strStatement)
    '            Else
    '                ' Convert the barcode to the peppered hash
    '                strHashedBarcode = ConvertBarcodePepperAndHash(txtBarcode.Text)
    '                'Insert data into table by calling ExecuteInsertQuery in CreateDatabase Module
    '                strStatement = "UPDATE USER SET Username='" & txtUsername.Text & "',Salt='" & strSalt & "',Password='" & strPassword & "',User_First_Name='" & strFirstName & "',User_Last_Name='" & strLastName & "',Barcode='" & strHashedBarcode & "',Admin_Flag='" & intAdmin & "',Supervisor_Flag='" & intSupervisor & "',Active_Flag=1 WHERE User_ID='" & txtID.Text & "';"
    '                ExecuteInsertQuery(strStatement)
    '            End If



    '            'clear all text boxes and change button visibility back to default 
    '            txtFirstName.Text = ""
    '            txtLastName.Text = ""
    '            txtUsername.Text = ""
    '            txtBarcode.Text = ""
    '            txtPassword.Text = ""
    '            txtConfirmPassword.Text = ""
    '            txtID.Text = ""
    '            btnCancel.Visible = False
    '            btnSaveChanges.Visible = False
    '            btnSaveUser.Visible = True
    '        End If
    '    End If



    '    'check if the user is changing the password and ran if no
    '    If txtConfirmPassword.Text = "" And txtPassword.Text = "" And txtID.Text <> "" Then
    '        'if it returns 2 then the username was changed to something already in the database 
    '        If ExecuteScalarQuery(strStatement) = 2 Then
    '            MsgBox("A User already has that Username")
    '            'call CheckPassword Function to see if password mets security standards
    '            ' make sure password and Confirm Password Match
    '        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
    '            MsgBox("Confirm Password must match Password")
    '            txtConfirmPassword.Focus()
    '            'Make Sure all fields are filled
    '        ElseIf txtFirstName.Text = "" Or txtLastName.Text = "" Or txtUsername.Text = "" Then
    '            MsgBox("All Fields must be filled56")
    '        Else
    '            If txtBarcode.Text = "" Then
    '                'Insert data into table by calling ExecuteInsertQuery in CreateDatabase Module
    '                strStatement = "UPDATE USER SET Username='" & txtUsername.Text & "',User_First_Name='" & strFirstName & "',User_Last_Name='" & strLastName & "',Admin_Flag='" & intAdmin & "',Supervisor_Flag='" & intSupervisor & "',Active_Flag=1  WHERE User_ID='" & txtID.Text & "';"
    '                ExecuteInsertQuery(strStatement)
    '            Else
    '                ' Convert the barcode to the peppered hash
    '                strHashedBarcode = ConvertBarcodePepperAndHash(txtBarcode.Text)
    '                'Insert data into table by calling ExecuteInsertQuery in CreateDatabase Module
    '                strStatement = "UPDATE USER SET Username='" & txtUsername.Text & "',User_First_Name='" & strFirstName & "',User_Last_Name='" & strLastName & "',Barcode='" & strHashedBarcode & "',Admin_Flag='" & intAdmin & "',Supervisor_Flag='" & intSupervisor & "',Active_Flag=1  WHERE User_ID='" & txtID.Text & "';"
    '                ExecuteInsertQuery(strStatement)
    '            End If



    '            'clear all text boxes and change button visibility back to default 
    '            txtFirstName.Text = ""
    '            txtLastName.Text = ""
    '            txtUsername.Text = ""
    '            txtBarcode.Text = ""
    '            txtPassword.Text = ""
    '            txtConfirmPassword.Text = ""
    '            btnCancel.Visible = False
    '            btnSaveChanges.Visible = False
    '            btnSaveUser.Visible = True
    '        End If
    '    End If

    '    Dim strFillSQL As String = "select User.User_ID, User.Username, User.User_First_Name, User.User_Last_Name, User.Admin_Flag, " &
    '                                  "User.Supervisor_Flag, User.Active_Flag From User;"
    '    Fill_Table(strFillSQL)
    'End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    'Private Sub SearchIcon_Click(sender As Object, e As EventArgs) Handles pnlSearch.Click
    '    Dim strFillSQL As String
    '    strFillSQL = "select User.User_ID, User.Username, User.User_First_Name, User.User_Last_Name, User.Admin_Flag, " &
    '                                                   "User.Supervisor_Flag, User.Active_Flag From User WHERE Username LIKE '" & txtSearchBox.Text & "%' Or User_First_Name LIKE '" & txtSearchBox.Text & "%' Or User_Last_Name LIKE '" & txtSearchBox.Text & "%';"
    '    Fill_Table(strFillSQL)

    'End Sub
    'End Sub

    Public Sub Fill_Table(ByVal strFillSQL As String)
        flpPhysicianInfo.Controls.Clear()
        Dim dsPhysicianInfo As DataSet = CreateDatabase.ExecuteSelectQuery(strFillSQL)



        For Each item As DataRow In dsPhysicianInfo.Tables(0).Rows()
            With dsPhysicianInfo.Tables(0)
                'grab first name and last name and merge into one string
                Dim strFirst As String = item.Item(1)
                Dim strLast As String = item.Item(3)
                Dim strName = strFirst & " " & strLast
                Dim strActive As String = ""

                If (item.Item(11)) = 1 Then
                    strActive = "Yes"
                Else strActive = "No"
                End If
                'check what role the person has, if adminis 1 then it does not matter what Supervisor is 
                'if admin is 0 then check supervisor. If both admin and supervidor are 0 then the 
                'user is a nurse
                Dim strRole As String = item.Item(4)

                'populate data into panels
                CreatePanel_Physician(flpPhysicianInfo, item.Item(0), strName,
                               strRole, strActive)

            End With
        Next
    End Sub


    'Private Sub Search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchBox.KeyPress
    '    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
    '        e.KeyChar = ChrW(0)
    '        e.Handled = True
    '        Dim strFillSQL = "select User.User_ID, User.Username, User.User_First_Name, User.User_Last_Name, User.Admin_Flag, " &
    '                                                   "User.Supervisor_Flag, User.Active_Flag From User WHERE Username LIKE '" & txtSearchBox.Text & "%' Or User_First_Name LIKE '" & txtSearchBox.Text & "%' Or User_Last_Name LIKE '" & txtSearchBox.Text & "%';"
    '        Fill_Table(strFillSQL)
    '    End If
    'End Sub

End Class
