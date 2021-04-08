Public Class frmWaste

    Private intPatientID As Integer
    Private intDrawerMedTUID As Integer
    Private intMedID As Integer
    Private intDrawerID As Integer
    Private intNarcoticFlagGlobal As Integer
    Private intSignoffID As Integer
    Private strReason As String
    Private intEnteredFromAdhoc As Integer = 0

    'this function should set patient ID
    Public Sub SetPatientID(ByVal id As Integer)

        intPatientID = id

    End Sub
    Public Function getEnteredFromAdhoc()
        Return intEnteredFromAdhoc
    End Function

    Public Sub setEnteredFromAdhoc(ByRef intEntered As Integer)
        intEnteredFromAdhoc = intEntered
    End Sub

    Public Sub setMedID(ByRef id As Integer)
        intMedID = id
    End Sub

    Public Sub setDrawer(ByRef id As Integer)
        intDrawerID = id
    End Sub

    Public Sub setDrawerMEDTUID(ByRef id As Integer)
        intDrawerMedTUID = id
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOther.CheckedChanged

        MovePanelOnScreen()

    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: Waste_Load	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/7/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This sub is the form loading event
    '/********************************************************************/
    '/*  CALLED BY: checkchanged events                    	      		 */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	            (NONE)	                                             */								                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	MovePanelOnScreen()				                                 */					                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/* dsWitness -- dataset that holds all users usernames for combobox
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		        2/7/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub Waste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox1.Visible = False
        Dim dsPatientInfo As DataSet = CreateDatabase.ExecuteSelectQuery("SELECT * from Patient where Patient_ID = '" & intPatientID & "'")
        lblPatientInfo.Text = "Patient: "
        lblPatientInfo.Text &= dsPatientInfo.Tables(0).Rows(0)(EnumList.Patient.LastName) & ", "
        lblPatientInfo.Text &= dsPatientInfo.Tables(0).Rows(0)(EnumList.Patient.FristName) & "         "
        lblPatientInfo.Text &= "MRN: "
        lblPatientInfo.Text &= dsPatientInfo.Tables(0).Rows(0)(EnumList.Patient.MRN_Number) & "         "
        lblPatientInfo.Text &= "DOB: "
        lblPatientInfo.Text &= dsPatientInfo.Tables(0).Rows(0)(EnumList.Patient.DoB) & "         "
        lblPatientInfo.Text &= "Height: "
        lblPatientInfo.Text &= dsPatientInfo.Tables(0).Rows(0)(EnumList.Patient.Height) & "         "
        lblPatientInfo.Text &= "Weight: "
        lblPatientInfo.Text &= dsPatientInfo.Tables(0).Rows(0)(EnumList.Patient.Weight) & "         "

        Dim dsMedication As DataSet = CreateDatabase.ExecuteSelectQuery("Select * from Medication INNER JOIN DrawerMedication on DrawerMedication.Medication_TUID = Medication.Medication_ID where Medication_ID = '" & intMedID & "' and Medication.Active_Flag = '1' and DrawerMedication.Active_Flag = '1'")
        txtMedication.Text = dsMedication.Tables(0).Rows(0)(1)
        txtUnit.Text = dsMedication.Tables(0).Rows(0)(15)

        Dim dsDrawer As DataSet = CreateDatabase.ExecuteSelectQuery("Select * from DrawerMedication INNER JOIN Drawers on Drawers.Drawers_ID = DrawerMedication.Drawers_TUID WHERE DrawerMedication.Medication_TUID = '" & intMedID & "' and DrawerMedication.Active_Flag = '1' and Drawers.Active_Flag = '1'")
        txtDrawer.Text = "Drawer number:  " & dsDrawer.Tables(0).Rows(0)(12) & " Bin: " & dsDrawer.Tables(0).Rows(0)(6)

        Dim intNarcoticFlag As Integer = CreateDatabase.ExecuteScalarQuery("Select Controlled_Flag from Medication where Medication_ID = '" & intMedID & "' and Active_Flag = '1'")
        intNarcoticFlagGlobal = intNarcoticFlag

        If intNarcoticFlagGlobal = 1 Then
            lblSignoff.Visible = True
            txtBarcode.Visible = True
            pnlCredentials.Visible = False
        Else
            pnlSignOff.Visible = False
            lblSignoff.Visible = False
            txtBarcode.Visible = False
        End If


    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: MovePanelOnScreen	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/7/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This sub makes the form dynamic by moving the*/					                       
    '/*  witness sign off down when the radio button is selected         */
    '/********************************************************************/
    '/*  CALLED BY: checkchanged events                    	      		 */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	            (NONE)	                                             */								                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	MovePanelOnScreen()				                                 */					                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 ctl- a control object that is used to hold all of the controls  */
    '/*  that will be iterated over.					                 */
    '/*  rbtn- a radio button control that the control will be casted to */
    '/*  for the purpose of accessing the radio button methods.          */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		        2/7/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub MovePanelOnScreen()

        Dim ctl As Control
        Dim rbtn As RadioButton = Nothing

        For Each ctl In pnlRadioButtons.Controls
            If TypeName(ctl) = "RadioButton" Then
                If ctl.Name = "rbtnOther" Then
                    rbtn = CType(ctl, RadioButton)
                    If rbtn.Checked = True Then
                        pnlSignOff.Dock = DockStyle.Bottom
                    Else
                        pnlSignOff.Dock = False
                    End If
                End If
            End If
        Next

    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmPatientInfo.setPatientID(intPatientID)
        frmMain.OpenChildForm(frmPatientInfo)
    End Sub
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789.")
    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: btnWaste_Click	             */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Alexander Beasecker  		             */   
    '/*		         DATE CREATED: 	2/10/21			                     */                             
    '/********************************************************************/
    '/*  SUBROUTINE PURPOSE:This handles the beginning of the wasting logic
    '/*         it has the validation checks to make sure all the data is selected
    '/*         and valid. it will then pass along to the waste sub
    '/*
    '/*
    '/********************************************************************/
    '/*  CALLED BY: btnwaste.click                    	      		 */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*  		Inventory.WasteMedication				                         */	
    '/*  		Inventory.PopulateWasteComboBoxMedication()				                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*sender As Object, 
    '/*e As EventArgs    							                        							             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	btnWaste_Click()				                                 */					                       
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 intWasteAmount
    '/*  intMedID
    '/*
    '/*
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									 */		                         */
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  AB		        2/10/21		    initial creation                 */
    '/********************************************************************/ 
    Private Sub btnWaste_Click(sender As Object, e As EventArgs) Handles btnWasteWithBarcode.Click, Button1.Click
        If intNarcoticFlagGlobal = 1 Then
            If IsNumeric(txtQuantity.Text) Then
                Dim strBarcode As String = txtBarcode.Text
                CheckBarcode(strBarcode)
            Else
                MessageBox.Show("Please enter a numeric value to waste")
            End If
        Else
            If IsNumeric(txtQuantity.Text) Then
                InsertWasteNonNarcotic()
                frmMain.UnlockSideMenu()

                If intEnteredFromAdhoc = 0 Then
                    frmPatientInfo.setPatientID(intPatientID)
                    frmMain.OpenChildForm(frmPatientInfo)
                ElseIf intEnteredFromAdhoc = 1 Then
                    frmDispense.setintEntered(0)
                    setEnteredFromAdhoc(0)
                    frmMain.OpenChildForm(frmAdHockDispense)
                End If
            End If

        End If
    End Sub

    Private Sub InsertWasteNonNarcotic()
        Dim dtmWasteTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        If radIncorrect.Checked = True Then
            strReason = radIncorrect.Text

        ElseIf radCancel.Checked = True Then
            strReason = radCancel.Text

        ElseIf radRefused.Checked = True Then
            strReason = radRefused.Text

        ElseIf radPatientUnavilable.Checked = True Then
            strReason = radPatientUnavilable.Text

        ElseIf rbtnOther.Checked = True Then
            strReason = txtOther.Text
        End If
        insertWaste(CInt(LoggedInID), CInt(LoggedInID), intDrawerMedTUID, intMedID, intPatientID, strReason, txtQuantity.Text, dtmWasteTime)
    End Sub

    Private Sub InsertWasteNarcotic(ByRef intApprovingID As Integer)
        Dim dtmWasteTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        If radIncorrect.Checked = True Then
            strReason = radIncorrect.Text

        ElseIf radCancel.Checked = True Then
            strReason = radCancel.Text

        ElseIf radRefused.Checked = True Then
            strReason = radRefused.Text

        ElseIf radPatientUnavilable.Checked = True Then
            strReason = radPatientUnavilable.Text

        ElseIf rbtnOther.Checked = True Then
            strReason = txtOther.Text
        End If
        insertWaste(CInt(LoggedInID), intApprovingID, intDrawerMedTUID, intMedID, intPatientID, strReason, txtQuantity.Text, dtmWasteTime)
    End Sub

    Public Sub insertWaste(ByRef intPrimaryUser As Integer, ByRef intSecondaryUser As Integer, ByRef intDrawerMEDID As Integer, ByRef intMedicationID As Integer, ByRef intpatientTUID As Integer, ByRef strReason As String, dblQuantity As Double, ByRef dtmDate As String)
        CreateDatabase.ExecuteInsertQuery("INSERT INTO Wastes(Primary_User_TUID,Secondary_User_TUID,DrawerMedication_TUID,Medication_TUID, Patient_TUID,DateTime,Reason,Quantity) VALUES('" & intPrimaryUser & "','" & intSecondaryUser & "','" & intDrawerMEDID & "','" & intMedicationID & "','" & intpatientTUID & "','" & dtmDate & "','" & strReason & "','" & dblQuantity & "')")
    End Sub
    Private Sub CheckBarcode(ByRef strBarcode As String)
        If strBarcode = "" Then
            MsgBox("           WARNING" & vbCrLf & "Barcode Field is Blank")
            txtBarcode.Focus()

        ElseIf scanBarcode(strBarcode) = "True" Then
            InsertWasteNarcotic(intSignoffID)

            frmMain.UnlockSideMenu()
            If intEnteredFromAdhoc = 0 Then
                frmPatientInfo.setPatientID(intPatientID)
                frmMain.OpenChildForm(frmPatientInfo)
            ElseIf intEnteredFromAdhoc = 1 Then
                frmDispense.setintEntered(0)
                setEnteredFromAdhoc(0)
                frmMain.OpenChildForm(frmAdHockDispense)
            End If
        ElseIf scanBarcode(strBarcode) = "SameBarcode" Then
            MessageBox.Show("Can not sign-off for yourself.")
            txtBarcode.Text = ""
            txtBarcode.Focus()
        Else
            MsgBox("No User With That Barcode")
            txtBarcode.Focus()
        End If
    End Sub

    Private Function scanBarcode(ByRef strBarcode As String)
        Dim strHashedBarcode = ConvertBarcodePepperAndHash(strBarcode)
        If strHashedBarcode = ExecuteScalarQuery("SELECT Barcode FROM User WHERE User_ID = '" & LoggedInID & "'") Then
            Return "SameBarcode"
        ElseIf ExecuteScalarQuery("SELECT COUNT(*) FROM User WHERE Barcode = '" & strHashedBarcode & "'" & " AND Active_Flag = '1'") <> 0 Then
            intSignoffID = ExecuteScalarQuery("SELECT User_ID FROM User WHERE Barcode = '" & strHashedBarcode & "'")
            Return "True"
        Else
            Return "False"
        End If
    End Function


    Private Sub lblBadge_Click(sender As Object, e As EventArgs) Handles lblBadge.Click

        If pnlBarcode.Visible = True Then
            pnlBarcode.Visible = False
            txtBarcode.Text = Nothing
            pnlCredentials.Visible = True
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblUseBarcode.Click

        If pnlCredentials.Visible = True Then

            pnlCredentials.Visible = False
            txtUsername.Text = Nothing
            txtPassword.Text = Nothing
            pnlBarcode.Visible = True

        End If

    End Sub

    Private Sub btnWasteWithCredentials_Click(sender As Object, e As EventArgs) Handles btnWasteWithCredentials.Click
        If intNarcoticFlagGlobal = 1 Then
            If IsNumeric(txtQuantity.Text) Then
                CheckUsername(txtUsername.Text, txtPassword.Text)
            Else
                MessageBox.Show("Please enter a numeric value to waste")
            End If
        Else
            If IsNumeric(txtQuantity.Text) Then
                InsertWasteNonNarcotic()
                frmMain.UnlockSideMenu()

                If intEnteredFromAdhoc = 0 Then
                    frmPatientInfo.setPatientID(intPatientID)
                    frmMain.OpenChildForm(frmPatientInfo)
                ElseIf intEnteredFromAdhoc = 1 Then
                    frmDispense.setintEntered(0)
                    setEnteredFromAdhoc(0)
                    frmMain.OpenChildForm(frmAdHockDispense)
                End If
            End If

        End If
    End Sub

    Private Sub CheckUsername(ByRef strUsername As String, ByRef strPassword As String)
        If strUsername = "" Then
            MsgBox("           WARNING" & vbCrLf & "Username Field is Blank")
            txtUsername.Focus()
        ElseIf strPassword = "" Then
            MsgBox("           WARNING" & vbCrLf & "Password Field is Blank")
            txtPassword.Focus()

        ElseIf scanUserName(strUsername, strPassword) = "True" Then
            InsertWasteNarcotic(intSignoffID)

            frmMain.UnlockSideMenu()
            If intEnteredFromAdhoc = 0 Then
                frmPatientInfo.setPatientID(intPatientID)
                frmMain.OpenChildForm(frmPatientInfo)
            ElseIf intEnteredFromAdhoc = 1 Then
                frmDispense.setintEntered(0)
                setEnteredFromAdhoc(0)
                frmMain.OpenChildForm(frmAdHockDispense)
            End If
        ElseIf scanUserName(strUsername, strPassword) = "SameUser" Then
            MessageBox.Show("Can not sign-off for yourself.")
            txtUsername.Text = ""
            txtUsername.Focus()
        Else
            MsgBox("No User With That Username")
            txtUsername.Focus()
        End If
    End Sub

    Private Function scanUserName(ByRef strUsername As String, ByRef strPassword As String)
        strPassword = AddSaltPepperAndHash(strPassword, strUsername)
        If strUsername = LoggedInUsername Then
            Return "SameUser"
        ElseIf ExecuteScalarQuery("SELECT COUNT(*) FROM User WHERE Username = '" & strUsername & "'" & " AND Password = '" & strPassword & "'" & " AND Active_Flag = '1'") <> 0 Then
            intSignoffID = ExecuteScalarQuery("SELECT User_ID FROM User WHERE Username = '" & strUsername & "'")
            Return "True"
        Else
            Return "False"
        End If
    End Function
End Class