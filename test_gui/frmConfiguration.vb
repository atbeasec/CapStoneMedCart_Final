﻿Imports System.Text
Imports System.Text.RegularExpressions

Public Class frmConfiguration

    '/*********************************************************************/
    '/*                   SubProgram NAME: frmConfiguration_Load          */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Dylan Walter        		          */   
    '/*		         DATE CREATED: 		 2/10/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This  sub program is used to populate the flpUserInfo Flow       */
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
    Private Sub frmConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pull  the dataset from the user table in sqlite
        Dim dsUserInfo As DataSet = CreateDatabase.ExecuteSelectQuery("select User.User_ID, User.Username, User.User_First_Name, User.User_Last_Name, User.Admin_Flag, " &
                                                   "User.Supervisor_Flag, User.Active_Flag From User;")



        For Each item As DataRow In dsUserInfo.Tables(0).Rows()
            With dsUserInfo.Tables(0)
                'grab first name and last name and merge into one string
                Dim strFirst As String = item.Item(2)
                Dim strLast As String = item.Item(3)
                Dim strName = strFirst & " " & strLast
                Dim strActive As String = ""

                If (item.Item(6)) = 1 Then
                    strActive = "Yes"
                Else strActive = "No"
                End If
                'check what role the person has, if adminis 1 then it does not matter what Supervisor is 
                'if admin is 0 then check supervisor. If both admin and supervidor are 0 then the 
                'user is a nurse
                Dim strRole As String
                If (item.Item(4)) = 1 Then
                    strRole = "Admin"
                ElseIf (item.Item(5)) = 1 Then
                    strRole = "Supervisor"
                Else strRole = "Nurse"
                End If

                'populate data into panels
                CreatePanel(flpUserInfo, item.Item(0), strName, item.Item(1),
                           strRole, strActive)

            End With
        Next

        'have new users assigned as Nurses by default
        rbtnNurse.Checked = True
        btnSaveChanges.Visible = False
        btnCancel.Visible = False


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
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  Collin Krygier  2/6/2021    Initial creation                     */
    '/*********************************************************************/
    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal strID As String, ByVal strName As String, ByVal strUsername As String, ByVal strAccess As String, ByVal strActive As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct

        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(600, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(600, 45)
            .Name = "pnlIndividualPatientRecord" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)

        'AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClickNewOrder
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault
        'AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        CreateEditButton(pnlMainPanel, getPanelCount(flpPannel), 500, 5)


        CreateDeleteBtn(pnlMainPanel, getPanelCount(flpPannel), 550, 5)

        'CreateDeleteBtn(pnlMainPanel)
        'CreateEditButton(pnlMainPanel)

        ' call database info here to populate
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Const INTTWENTY As Integer = 20

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblID", lblID.Location.X, INTTWENTY, strID, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblNames", lblName.Location.X, INTTWENTY, strName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblUsername", lblIDNumber.Location.X, INTTWENTY, strUsername, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblAccessLevel", lblAccess.Location.X, INTTWENTY, strAccess, getPanelCount(flpPannel))
        'CreateIDLabel(pnlMainPanel, lblID5, "lblActive", lblActive.Location.X, INTTWENTY, strActive, getPanelCount(flpPannel))

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
    '/*	   CreatePanel(flpUserInfo, strID9, strFirstName9, strAccess9)    */
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
    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        'String to be sent to CreateDatabase Module to exicute search to check if Username is already in the User Table
        Dim strStatement = "SELECT COUNT(*) FROM User WHERE Username = '" & txtUsername.Text & "'"
        If ExecuteScalarQuery(strStatement) <> 0 Then
            MsgBox("A User already has that Username")
            txtUsername.Focus()
            txtUsername.Text = ""
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
    Private Sub txtBarcode_LostFocus(sender As Object, e As EventArgs) Handles txtBarcode.LostFocus
        'String to be sent to CreateDatabase Module to exicute search to check if Barcode is already in the User Table
        Dim strStatement = "SELECT COUNT(*) FROM User WHERE Barcode = '" & txtBarcode.Text & "'"
        If ExecuteScalarQuery(strStatement) <> 0 Then
            MsgBox("A User already has that Barcode")
            txtBarcode.Focus()
            txtBarcode.Text = ""
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
    '/*		strLastName- text from txtLastName								*/
    '/*		strPassword- text from txtPassword								*/
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
    '/*********************************************************************/


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intSupervisor As Integer = 0
        Dim intAdmin As Integer = 0
        Dim intActiveFlag As Integer = 1
        Dim strPassword As String = txtPassword.Text
        Dim strLastName As String = txtLastName.Text
        Dim strFirstName As String = txtFirstName.Text
        Dim strSalt As String = Nothing
        Dim strResults() As String = Nothing ' this will hold the salted, peppered, hashed password and the salt
        strFirstName = Regex.Replace(strFirstName, "'", "''")
        strLastName = Regex.Replace(strLastName, "'", "''")

        'check what Role the user will have
        If rbtnAdministrator.Checked = True Then
            intAdmin = 1
        ElseIf rbtnSupervisor.Checked = True Then
            intSupervisor = 1
        End If

        'call CheckPassword Function to see if password mets security standards
        If CheckPassword(strPassword) = False Then
            MsgBox("Password must contain at least 8 characters, 1 uppercase, 1 lowercase, 1 number, 1 special characters !@#$%^&* ")
            txtPassword.Focus()
            ' make sure password and Confirm Password Match
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("Confirm Password must match Password")
            txtConfirmPassword.Focus()
            'Make Sure all fields are filled
        ElseIf txtFirstName.Text = "" Or txtLastName.Text = "" Or txtUsername.Text = "" Or txtBarcode.Text = "" Then
            MsgBox("All Fields must be filled")
        Else
            ' get the peppered hash of the password
            strResults = LogIn.MakeSaltPepperAndHash(strPassword)
            strPassword = strResults(0)
            strSalt = strResults(1)

            'Insert data into table by calling ExecuteInsertQuery in CreateDatabase Module

            Dim strStatement = "INSERT INTO USER(Username,Salt,Password,User_First_Name, User_Last_Name, Barcode, Admin_Flag, Supervisor_Flag, Active_Flag)" &
            "VALUES('" & txtUsername.Text & "','" & strSalt & "','" & strPassword & "','" & strFirstName & "','" & strLastName & "','" & txtBarcode.Text & "','" & intAdmin & "','" & intSupervisor & "','" & intActiveFlag & "')"
            ExecuteInsertQuery(strStatement)

            'clear all text boxes
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtUsername.Text = ""
            txtBarcode.Text = ""
            txtPassword.Text = ""
            txtConfirmPassword.Text = ""
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

    Private Sub txtFirstName_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress

        If Not (Asc(e.KeyChar) = 8) Then
            'string of allowed characters
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz '-1234567890!@#$%^&*()/.,<>=+"
            'converts letter to lowercase to compare to allowedChars string to check if it is allowed in the text box
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtLastName_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            'string of allowed characters
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz '-1234567890!@#$%^&*()/.,<>=+"
            'converts letter to lowercase to compare to allowedChars string to check if it is allowed in the text box
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtUserID_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            'string of allowed characters
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*()/.,<>=+"
            'converts letter to lowercase to compare to allowedChars string to check if it is allowed in the text box
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtBarcode_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            'string of allowed characters
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz123456789!@#$%^&*()/.,<>=+"
            'converts letter to lowercase to compare to allowedChars string to check if it is allowed in the text box
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPassword_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress, txtConfirmPassword.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            'string of allowed characters
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz123456789!@#$%^&*()/.,<>=+"
            'converts letter to lowercase to compare to allowedChars string to check if it is allowed in the text box
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Dim intID As Integer = txtID.Text
        Dim strStatement = "SELECT COUNT(*) FROM User WHERE Username = '" & txtUsername.Text & "'" & " OR User_ID = '" & intID & "'"
        Dim intSupervisor As Integer = 0
        Dim intAdmin As Integer = 0
        Dim strPassword As String = txtPassword.Text
        Dim strLastName As String = txtLastName.Text
        Dim strFirstName As String = txtFirstName.Text
        Dim strSalt As String = Nothing
        Dim strResults() As String = Nothing ' this will hold the salted, peppered, hashed password and the salt
        strFirstName = Regex.Replace(strFirstName, "'", "''")
        strLastName = Regex.Replace(strLastName, "'", "''")

        'check what Role the user will have
        If rbtnAdministrator.Checked = True Then
            intAdmin = 1
        ElseIf rbtnSupervisor.Checked = True Then
            intSupervisor = 1
        End If

        'if it returns 2 then the username was changed to something already in the database 
        If ExecuteScalarQuery(strStatement) = 2 Then
            MsgBox("A User already has that Username")
            'call CheckPassword Function to see if password mets security standards
        ElseIf CheckPassword(strPassword) = False Then
            MsgBox("Password must contain at least 8 characters, 1 uppercase, 1 lowercase, 1 number, 1 special characters !@#$%^&* ")
            txtPassword.Focus()
            ' make sure password and Confirm Password Match
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("Confirm Password must match Password")
            txtConfirmPassword.Focus()
            'Make Sure all fields are filled
        ElseIf txtFirstName.Text = "" Or txtLastName.Text = "" Or txtUsername.Text = "" Or txtBarcode.Text = "" Then
            MsgBox("All Fields must be filled")
        Else
            ' get the peppered hash of the password
            strResults = LogIn.MakeSaltPepperAndHash(strPassword)
            strPassword = strResults(0)
            strSalt = strResults(1)

            'Insert data into table by calling ExecuteInsertQuery in CreateDatabase Module
            strStatement = "UPDATE USER SET Username='" & txtUsername.Text & "',Salt='" & strSalt & "',Password='" & strPassword & "',User_First_Name='" & strFirstName & "',User_Last_Name='" & strLastName & "',Barcode='" & txtBarcode.Text & "',Admin_Flag='" & intAdmin & "',Supervisor_Flag='" & intSupervisor & "' WHERE User_ID='" & txtID.Text & "';"
            ExecuteInsertQuery(strStatement)

            'clear all text boxes and change button visibility back to default 
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtUsername.Text = ""
            txtBarcode.Text = ""
            txtPassword.Text = ""
            txtConfirmPassword.Text = ""
            btnCancel.Visible = False
            btnSaveChanges.Visible = False
            Button1.Visible = True
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'clear all text boxes and change button visibility back to default 
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtUsername.Text = ""
        txtBarcode.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        btnCancel.Visible = False
        btnSaveChanges.Visible = False
        Button1.Visible = True
    End Sub
End Class
