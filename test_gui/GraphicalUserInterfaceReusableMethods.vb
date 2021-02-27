Module GraphicalUserInterfaceReusableMethods

    'Method that allows for highlighting when hovering over panels. has two parts
    'part 1

    Public Sub MouseEnterPanelSetBackGroundColor(Sender As Object, e As EventArgs)

        'changes the background color when the mouse is hovered over the panel
        If Not Sender.backcolor = Color.Red And Not Sender.backcolor = Color.FromArgb(71, 103, 216) Then

            If Sender.backColor = Color.White Then
                Sender.backColor = Color.Gainsboro

            Else

                Sender.backcolor = Color.White
            End If

        End If



    End Sub

    'part 2
    Public Sub MouseLeavePanelSetBackGroundColorToDefault(sender As Object, e As EventArgs)

        ' checking if the background color is set to the highlighted color
        'if it is not then we will set it.
        If Not sender.backcolor = Color.Red And Not sender.backcolor = Color.FromArgb(71, 103, 216) Then
            If sender.backColor = Color.Gainsboro Then

                sender.backColor = Color.White

            Else

                sender.backcolor = Color.Gainsboro
            End If
        End If


    End Sub

    'Add new  delete button to contact panel
    Public Sub RestDefaultButtons(ByVal sender As Object, ByVal e As EventArgs)

        Dim intTemp As Integer = 1

        Dim ctlControl As Control

        For Each ctlControl In sender.Parent.Controls

            If TypeName(ctlControl) = "Button" Then

                If Not ctlControl.Name.Contains("Cancel") Or ctlControl.Name.Contains("Check") Then
                    ' for any controls that are not the check mark or red x, we will make them visible

                    ctlControl.Visible = True

                Else
                    'even though we hide the other controls, once we select the delete button once, we are hiding all of the other icons
                    ' there fore we do not need to recreate them we can simply hide or unhide them
                    ' in this case we will set the visibility to false because they are controls that we need to hide.

                    ctlControl.Visible = False

                End If
            End If
        Next



    End Sub


    Public Sub ShowConfirmationButtons(ByVal sender As Object, ByVal e As EventArgs)

        'call methods here to show the checkmark buttons when the item is clicked


        ' hide the sender which is the trash can icon
        sender.Visible = False

        Debug.Print(sender.Location.X.ToString)
        Debug.Print(sender.Location.Y.ToString)

        'put the check mark where the trash can icon was
        ' CreateCheckMarkBtn(sender.parent, New Point(sender.Location.X, sender.Location.Y))

        CreateXMarkBtn(sender.parent, New Point(sender.Location.X, sender.Location.Y))

        'put the x icon where the edit button was. We need to find the location of the edit Button.
        Dim ctlControl As Control

        For Each ctlControl In sender.Parent.Controls

            If TypeName(ctlControl) = "Button" Then
                If ctlControl.Name.Contains("Edit") Then

                    Debug.Print(ctlControl.Name)

                    'hide the control
                    ctlControl.Visible = False

                    ' get the location and put the x in that location
                    ' CreateXMarkBtn(sender.Parent, New Point(ctlControl.Location.X, ctlControl.Location.Y))
                    CreateCheckMarkBtn(sender.Parent, New Point(ctlControl.Location.X, ctlControl.Location.Y))
                End If
            End If
        Next



    End Sub

    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        'the parent of the button will be the panel the control is located on.
        'we want to get one step removed so we need to next take the parent of the control
        ' to get the name of flowpanel which the button is laid out on
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

        'parents.Name
        ' Dim connn As Control = parentFlowPanel.Parent
        'Debug.Print(connn.Name)
        'Debug.Print(parentFlowPanel.Name)
        'UpdateCamerasSubtotalLabel(parentFlowPanel)

    End Sub




    Public Sub CreateIDLabel(ByVal pnlName As Panel, lblName As Label, strLabelName As String, x As Integer, y As Integer, strLabelText As String, ByVal intPanelsAddedCount As Integer)

        ' Dim lblID As Label
        'lblName = New Label
        'location = New Point
        'declare our image and point at the resource

        'Set button properties
        With lblName
            .AutoSize = True
            '.Size = New Size(30, 30)

            .FlatStyle = FlatStyle.Flat
            ' .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Black
            .Font = New Font(New FontFamily("Segoe UI"), 11, FontStyle.Regular)
            .Location = New Point(x, y) 'new Point(600, 5)
            .Name = strLabelName + (intPanelsAddedCount).ToString
            .Text = strLabelText
            .Tag = intPanelsAddedCount + 1
        End With


        pnlName.Controls.Add(lblName)

    End Sub

    Public Sub DynamicRemoveHandlerFromSender(ByVal sender As Object, ByVal e As EventArgs)

        'the parent of the button will be the panel the control is located on.
        'we want to get one step removed so we need to next take the parent of the control
        ' to get the name of flowpanel which the button is laid out on
        Dim ctlControl As Control = sender.Parent
        Dim ctlParents As Control = ctlControl.Parent
        Dim ctlParentFlowPanel As Control = ctlControl.Parent
        Dim strParentPanelName As String
        strParentPanelName = Nothing

        'Remove handler from sender
        For Each ctlControlObj As Control In ctlParentFlowPanel.Controls
            For Each ctlChildControlObj As Control In ctlControlObj.Controls
                If ctlChildControlObj.Name = sender.name Then

                    RemoveHandler ctlChildControlObj.Click, AddressOf DynamicButton_Click
                    strParentPanelName = ctlChildControlObj.Parent.Name

                End If
            Next
        Next

    End Sub

    'Add new  delete button to contact panel
    Public Sub CreateDeleteBtn(ByVal pnlPanelName As Panel, ByVal intPanelsAddedCount As Integer, ByVal intX As Integer, ByVal intY As Integer)

        Dim btnDeleteButton As Button
        btnDeleteButton = New Button
        'declare our image and point at the resource
        Dim mapImageTrash As New Bitmap(New Bitmap(My.Resources.icons8_delete_trash), 25, 25)

        'Set button properties
        With btnDeleteButton
            .AutoSize = True
            .Size = New Size(30, 30)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(intX, intY)
            .Name = "btnDeletePatientRecord" + (intPanelsAddedCount).ToString
            .Image = mapImageTrash
            .ImageAlign = ContentAlignment.MiddleCenter
            .Tag = intPanelsAddedCount + 1
        End With

        pnlPanelName.Controls.Add(btnDeleteButton)

        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnDeleteButton.Click, AddressOf ShowConfirmationButtons

    End Sub

    Public Sub CreateFlagBtn(ByVal pnlPanelName As Panel, ByVal intPanelsAddedCount As Integer, ByVal intX As Integer, ByVal intY As Integer)

        Dim btnFlagMedication As Button
        btnFlagMedication = New Button
        'declare our image and point at the resource
        Dim mapImageTrash As New Bitmap(New Bitmap(My.Resources.flag_black_25px), 25, 25)

        'Set button properties
        With btnFlagMedication
            .AutoSize = True
            .Size = New Size(30, 30)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(intX, intY)
            .Name = "btnFlagMedication" + (intPanelsAddedCount).ToString
            .Image = mapImageTrash
            .ImageAlign = ContentAlignment.MiddleCenter
            .Tag = intPanelsAddedCount + 1
            .TabStop = False
        End With

        pnlPanelName.Controls.Add(btnFlagMedication)

        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnFlagMedication.Click, AddressOf DynamicFlagMedicationButton

    End Sub
    Public Sub DynamicFlagMedicationButton(sender As Object, ByVal e As EventArgs)


        ' Dim pnlFlaggedPannel As Panel
        ' Dim txtBoxOnFlaggedPanel As TextBox = Nothing

        Dim pnlFlaggedPannel As Panel = CType(sender.parent, Panel)
        Dim txtBoxOnFlaggedPanel As TextBox = FindTextBoxOnPanel(pnlFlaggedPannel)

        Dim systemCount As Integer = CInt(FindLabelOnPanel(pnlFlaggedPannel).Text)


        ' when using the flag, we need to check that the system count is not the same as the user count
        ' if it is, then there is nothing to flag and we need to let the user know that incase they
        ' typed something wrong. If the user tries to flag a medication without typing a value in, they should not
        ' be able to flag anything so the button will not respond.

        If Not String.IsNullOrEmpty(txtBoxOnFlaggedPanel.Text) Then

            If systemCount = CInt(txtBoxOnFlaggedPanel.Text) Then

                MessageBox.Show("The system count matches the entered count. This will not be flagged as a descrepancy.")

            Else

                ' at this point there is a valid difference and we will want to lock the textbox and change
                ' the color of the panel so it is clear a discrepancy is being marked.

                If Not pnlFlaggedPannel.BackColor = Color.Red Then

                    'find the textbox and set the field to be read only
                    'txtBoxOnFlaggedPanel.ReadOnly = True
                    'txtBoxOnFlaggedPanel.AcceptsTab = False

                    txtBoxOnFlaggedPanel.Enabled = False

                    ' change the panel color to be red
                    pnlFlaggedPannel.BackColor = Color.Red

                Else

                    'find the textbox and set the field to be editable
                    'txtBoxOnFlaggedPanel.ReadOnly = False
                    'txtBoxOnFlaggedPanel.AcceptsTab = True
                    txtBoxOnFlaggedPanel.Enabled = True

                    ' change the panel color to be white
                    pnlFlaggedPannel.BackColor = Color.White

                End If

            End If


        End If



        ' Debug.Print(pnlFlaggedPannel.Name)

    End Sub

    Public Function FindTextBoxOnPanel(ByVal pnlFlagged As Panel) As TextBox

        ' search for control with the name txtCount
        ' this control will be the textbox on the selected panel
        Const TEXTBOXNAME As String = "txtCount"
        Dim ctlControl As Control
        Dim txtBox As TextBox = Nothing

        ' looking at each control on the panel
        For Each ctlControl In pnlFlagged.Controls
            ' if the current control is the textbox, then asign the textbox variable to this 
            If ctlControl.Name.Contains(TEXTBOXNAME) Then
                txtBox = CType(ctlControl, TextBox)
            End If
        Next

        Return txtBox

    End Function

    Public Function FindLabelOnPanel(ByVal pnlFlagged As Panel) As Label

        ' search for control with the name txtCount
        ' this control will be the textbox on the selected panel
        Const lblName As String = "lblSystemCount"
        Dim ctlControl As Control
        Dim lblLabel As Label = Nothing

        ' looking at each control on the panel
        For Each ctlControl In pnlFlagged.Controls
            ' if the current control is the textbox, then asign the textbox variable to this 
            If ctlControl.Name.Contains(lblName) Then
                lblLabel = CType(ctlControl, Label)
            End If
        Next

        Return lblLabel

    End Function


    Public Sub CreateTextBox(ByVal pnlPanelName As Panel, ByVal intPanelsAddedCount As Integer, ByVal intX As Integer, ByVal intY As Integer)

        Dim txtCount As TextBox
        txtCount = New TextBox

        'Set button properties
        With txtCount
            .AutoSize = True
            .BorderStyle = BorderStyle.FixedSingle
            .Size = New Size(45, 30)
            .ForeColor = Color.Black
            .Font = New Font(New FontFamily("Segoe UI"), 11)
            ' .Location = New Point(  )
            .Location = New Point(intX, intY)
            .Name = "txtCount" + (intPanelsAddedCount).ToString
            .Tag = intPanelsAddedCount + 1
            .MaxLength = 2
            ' .Dock = DockStyle.Fill

        End With

        pnlPanelName.Controls.Add(txtCount)

        ' MessageBox.Show("again")
        'Add handler for click events
        'assing functionality here

        'AddHandler btnFlagMedication.Click, AddressOf DynamicFlagMedicationButton

    End Sub


    Public Sub CreateEditButton(ByVal pnlPanelName As Panel, ByVal pnlPanelsAddedCount As Integer, ByVal intX As Integer, ByVal intY As Integer)

        Dim btnEditButton As Button
        btnEditButton = New Button
        'declare our image and point at the resource
        Dim mapImagePencil As New Bitmap(New Bitmap(My.Resources.icons8_pencil), 25, 25)

        'Set button properties
        With btnEditButton
            .AutoSize = True
            .Size = New Size(30, 30)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            '.Location = New Point(825, 5)
            .Location = New Point(intX, intY)
            .Name = "btnEditPatientRecord" + (pnlPanelsAddedCount).ToString
            .Image = mapImagePencil
            .ImageAlign = ContentAlignment.MiddleCenter
            .Tag = pnlPanelsAddedCount + 1
        End With

        Debug.Print(pnlPanelName.Name)
        pnlPanelName.Controls.Add(btnEditButton)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnEditButton.Click, AddressOf DynamicButtonEditRecord_Click

    End Sub

    Public Sub CreateCheckMarkBtn(ByVal pnlPanelName As Panel, ByVal pntLocation As Point)

        Dim btnCheckMark As Button
        btnCheckMark = New Button
        'declare our image and point at the resource
        Dim mapImageTrash As New Bitmap(New Bitmap(My.Resources.checkmark), 25, 25)

        'Set button properties
        With btnCheckMark
            .AutoSize = True
            .Size = New Size(30, 30)

            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(pntLocation)
            .Name = "btnDeletePatientRecord"
            .Image = mapImageTrash
            .ImageAlign = ContentAlignment.MiddleCenter

        End With

        pnlPanelName.Controls.Add(btnCheckMark)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnCheckMark.Click, AddressOf DetermineQueryDelete_Click
        AddHandler btnCheckMark.Click, AddressOf DynamicButton_Click

    End Sub

    Public Sub CreateXMarkBtn(ByVal pnlPanelName As Panel, ByVal pntLocation As Point)

        Dim btnCancel As Button
        btnCancel = New Button
        'declare our image and point at the resource
        Dim mapImageTrash As New Bitmap(New Bitmap(My.Resources.xmark), 25, 25)

        'Set button properties
        With btnCancel
            .AutoSize = True
            .Size = New Size(30, 30)

            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(pntLocation)
            .Name = "btnCancel"
            .Image = mapImageTrash
            .ImageAlign = ContentAlignment.MiddleCenter

        End With


        pnlPanelName.Controls.Add(btnCancel)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnCancel.Click, AddressOf RestDefaultButtons

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: DetermineQueryDelete_Click     */         
    '/*********************************************************************/
    '/*              WRITTEN BY:  Collin Krygier          		          */   
    '/*		         DATE CREATED: 		 2/15/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to compare two instances of forms and see if they  */
    '/*  are the same form or not. From here, the necessary method will be*/
    '/* called based upon the functionality of the button based on that form
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  CreateCheckMarkBtn, it is working as a handler                   */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             none                                                  */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	None                                                              */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	None                                 							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	None                                                              */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/15/2021    Initial creation                    */
    '/*********************************************************************/
    Public Sub DetermineQueryDelete_Click(sender As Object, ByVal e As EventArgs)

        ' determine the form that is currently opened in the application because this
        ' will influence the SQL query called to update the database

        ' use reflection to determine if the form opened is the same as another form
        ' because the functionality of the delete button varies depending on the form
        ' that is currently opened.

        If getOpenedForm().GetType() Is frmConfiguration.GetType() Then

            ' call SQL method to set the user flag to inactive or delete the user from the DB

            Dim intID As Integer = GetSelectedInformation(sender.parent, "lblID")
            Dim strStatement As String = "SELECT Active_Flag FROM User WHERE User_ID = '" & intID & "'"
            If ExecuteScalarQuery(strStatement) = 1 Then
                strStatement = "UPDATE USER SET Active_Flag='0' WHERE User_ID='" & intID & "';"
                ExecuteInsertQuery(strStatement)
            Else
                strStatement = "UPDATE USER SET Active_Flag='1' WHERE User_ID='" & intID & "';"
                ExecuteInsertQuery(strStatement)
            End If

        ElseIf getOpenedForm().GetType() Is frmPatientRecords.GetType() Then

            ' call SQL method to set the Patient Record flag to inactive or delete the user from the DB
            '    Debug.Print("patient records")

        ElseIf getOpenedForm().GetType() Is frmConfigureInventory.GetType() Then

            ' call SQL method to remove the item from the list of currently stocked items in the med cart
            '  Debug.Print("removing this inventory piece")

        ElseIf frmAllergies.Visible = True Then
            Dim intPatientTUID As Integer = frmAllergies.GetPatientTuid()
            Dim strAllergyName As String = GetSelectedInformation(sender.parent, "lblAllergyName")
            Dim strSqlStatment As String = ("Select Active_Flag FROM PatientAllergy WHERE Allergy_Name='" & strAllergyName & "' and Patient_TUID= " & intPatientTUID & ";")
            Dim value = ExecuteScalarQuery(strSqlStatment)
            If value = 1 Then
                ExecuteScalarQuery("UPDATE PatientAllergy SET Active_Flag='0' WHERE Allergy_Name='" & strAllergyName & "' and Patient_TUID =" & intPatientTUID & ";")
            Else
                ExecuteScalarQuery("UPDATE PatientAllergy SET Active_Flag='1' WHERE Allergy_Name='" & strAllergyName & "' and Patient_TUID =" & intPatientTUID & ";")
            End If
            frmPatientInfo.lstBoxAllergies.Items.Clear()
            GetAllergies(CInt(frmPatientInfo.txtMRN.Text))
            Debug.Print("remove allergy assigned to patient")

        End If

    End Sub

    '/*********************************************************************/
    '/*                   SubProgram NAME: DynamicButtonEditRecord_Click  */         
    '/*********************************************************************/
    '/*              WRITTEN BY:  Collin Krygier          		          */   
    '/*		         DATE CREATED: 		 2/15/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to compare two instances of forms and see if they  */
    '/*  are the same form or not. From here, the necessary method will be*/
    '/* called based upon the functionality of the button based on that form
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  CreateEditButton, it is working as a handler                     */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             none                                                  */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	None                                                              */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	None                                 							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	None                                                              */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/15/2021    Initial creation                    */
    '/*********************************************************************/

    Public Sub DynamicButtonEditRecord_Click(ByVal sender As Object, ByVal e As EventArgs)

        ' determine the form that is currently opened in the application because this
        ' will influence the SQL query called to update the database

        ' use reflection to determine if the form opened is the same as another form
        ' because the functionality of the delete button varies depending on the form
        ' that is currently opened.

        If getOpenedForm().GetType() Is frmConfiguration.GetType() Then

            'call GetSelectedInformation to get the selected username and ID
            frmConfiguration.txtUsername.Text = GetSelectedInformation(sender.parent, "lblUsername")
            frmConfiguration.txtID.Text = GetSelectedInformation(sender.parent, "lblID")

            'calls to fill the other textboxes for editing the user
            Dim strStatement = "SELECT User_First_Name FROM User WHERE User_ID = '" & frmConfiguration.txtID.Text & "';"
            frmConfiguration.txtFirstName.Text = ExecuteScalarQuery(strStatement)
            strStatement = "SELECT User_Last_Name FROM User WHERE User_ID = '" & frmConfiguration.txtID.Text & "';"
            frmConfiguration.txtLastName.Text = ExecuteScalarQuery(strStatement)
            'strStatement = "SELECT Barcode FROM User WHERE User_ID = '" & frmConfiguration.txtID.Text & "';"
            frmConfiguration.txtBarcode.Text = ""
            strStatement = "SELECT Admin_Flag FROM User WHERE User_ID = '" & frmConfiguration.txtID.Text & "';"
            Dim strSupervisor = "SELECT Supervisor_Flag FROM User WHERE User_ID = '" & frmConfiguration.txtID.Text & "';"

            'look at the users permissions on the user table and see what radio button should be selected
            If ExecuteScalarQuery(strStatement) = 1 Then
                frmConfiguration.rbtnAdministrator.Checked = True
            ElseIf ExecuteScalarQuery(strSupervisor) = 1 Then
                frmConfiguration.rbtnSupervisor.Checked = True
            Else frmConfiguration.rbtnNurse.Checked = True
            End If

            'make the save and cancel button visible and hide button1
            frmConfiguration.btnSaveChanges.Visible = True
            frmConfiguration.btnCancel.Visible = True
            frmConfiguration.btnSaveUser.Visible = False

        ElseIf getOpenedForm().GetType() Is frmPatientRecords.GetType() Then
            'this will set up the functions for the editing pencil. 
            Dim PatientInfo = New frmPatientInfo


            ' call SQL method to set edit functionality
            Debug.Print("patient records")

        ElseIf getOpenedForm().GetType() Is frmConfigureInventory.GetType() Then

            ' call SQL method to set edit functionality
            '  Debug.Print("removing this inventory piece")

        ElseIf frmAllergies.btnAddAllergy.Visible = True Then
            Dim selectedAllergyName = GetSelectedInformation(sender.parent, "lblAllergyName")
            Dim selectedAllergySeverity = GetSelectedInformation(sender.parent, "lblSeverity")
            Dim selectedAllergyType = GetSelectedInformation(sender.parent, "lblAllergyType")
            Dim selectedMedication = GetSelectedInformation(sender.parent, "lblMedication")

            With frmAllergies
                .cmbAllergies.Text = selectedAllergyName
                .cmbAllergiesType.Text = selectedAllergyType
                .cmbSeverity.Text = selectedAllergySeverity
                .cmbMedicationName.Text = selectedMedication
                .cmbAllergies.Enabled = False
                .cmbAllergiesType.Enabled = False
                .cmbMedicationName.Enabled = False
                .btnAllergySave.Visible = True
                .btnAllergyCancel.Visible = True
                .btnAddAllergy.Visible = False
            End With


            ' call SQL method to set edit functionality
            ' Debug.Print("remove allergy assigned to patient")
            Debug.WriteLine("")
        End If

    End Sub



    '/*********************************************************************/
    '/*                   Function NAME: getOpenedForm()                  */         
    '/*********************************************************************/
    '/*              WRITTEN BY:  Collin Krygier          		          */   
    '/*		         DATE CREATED: 		 2/15/2021                        */                             
    '/*********************************************************************/
    '/*  Function PURPOSE:								                  */             
    '/*	 This function simply retrieves the form that is currently on the */
    '/*  pnlDockLocation panel.                                           */
    '/*********************************************************************/
    '/*  Function Return Value:					                          */         
    '/*	 A form object representing the form that is opened on the screen */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  DynamicButtonEditRecord_Click                                    */ 
    '/*  DetermineQueryDelete_Click                                       */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/* None                                                              */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	None                                                              */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	None                                 							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	None                                                              */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/15/2021    Initial creation                    */
    '/*********************************************************************/
    Public Function getOpenedForm() As Form

        ' on frmMain, the panel called pnlDockedLocation is where we are shoving all of our forms into.
        ' we arent really interested in the location, we are interested in the control that is inside
        ' the pnlDockLocation. 
        ' the GetChildAtPoint() requires point as a parameter and we will use 1,1 to get that.

        Dim ptPoint As Point = New Point(1, 1)
        Dim frmOpenedControl As Control = frmMain.pnlDockLocation.GetChildAtPoint(ptPoint)
        Dim frmOpenedForm As Form = CType(frmOpenedControl, Form)

        Return frmOpenedForm

    End Function

    '/*********************************************************************/
    '/*                   Function NAME: GetSelectedInformation()         */         
    '/*********************************************************************/
    '/*              WRITTEN BY:  Dylan Walter          		          */   
    '/*		         DATE CREATED: 		 2/16/2021                        */                             
    '/*********************************************************************/
    '/*  Function PURPOSE:								                  */             
    '/*	 This function simply retrieves the requested information from    */
    '/*  the selected form.                                               */
    '/*********************************************************************/
    '/*  Function Return Value:					                          */         
    '/*	 strSelected- a string that contains the requested selection      */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  DynamicButtonEditRecord_Click                                    */ 
    '/*  DetermineQueryDelete_Click                                       */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/* None                                                              */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	sender                                                            */ 
    '/* strLable                                                          */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	None                                 							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	ctl                                                               */
    '/*	Selected                                                          */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  DW  2/16/2021    Initial creation                                */
    '/*********************************************************************/
    Function GetSelectedInformation(ByVal sender As Object, ByVal strLabel As String) As String
        Dim strSelected = Nothing
        Dim ctl As Control

        ' iterating over the list of controls in the panel
        For Each ctl In sender.Controls

            ' the label containing the wanted information is stored in strLabel and is sent by the user
            ' to represent what number panel it is in the row of created panels.
            If ctl.Name.Contains(strLabel) Then

                Debug.Print(ctl.Text)
                strSelected = (ctl.Text)
            End If
        Next
        'returning the Requested information from the selected record
        Return strSelected
    End Function



    Public Function getCurrentPanel(ByVal flpPanel As FlowLayoutPanel, ByVal intPanelsAddedCount As Integer) As Panel

        Dim ctlName As String = "pnlIndividualPatientRecord"
        Dim pnl As Panel
        pnl = New Panel

        For Each ctlControl In flpPanel.Controls

            If ctlControl.Name = ctlName & intPanelsAddedCount.ToString Then

                pnl = CType(ctlControl, Panel)

            End If

        Next

        Debug.Print("Panel Name: " & pnl.Name)

        Return pnl

    End Function

    ' method keeps track of the panel count by checking how many panels are on the main flowPanel.
    ' this is necessary because with the generic methods global counting variables would need to be
    ' defined in too many classes to keep track of what number of panel has been created.
    Public Function getPanelCount(flpPanel As FlowLayoutPanel) As Integer

        Dim ctlControl As Control
        Dim intCount As Integer

        For Each ctlControl In flpPanel.Controls

            If TypeName(ctlControl) = "Panel" Then

                intCount += 1

            End If

        Next

        'Debug.Print(count)

        Return intCount

    End Function

    Public Sub DynamicSingleClick(sender As Object, ByVal e As EventArgs)


        If sender.backColor = Color.White Then
            sender.backColor = Color.Gainsboro
        Else
            sender.backcolor = Color.White
        End If
    End Sub

    Public Sub ButtonIncrement(ByVal txtBox As TextBox)

        txtBox.Text = CInt(txtBox.Text) + 1

    End Sub

    Public Sub ButtonDecrement(ByVal txtBox As TextBox)

        If Not CInt(txtBox.Text) = 0 Then
            txtBox.Text = Int(txtBox.Text) - 1
        End If

    End Sub


End Module
