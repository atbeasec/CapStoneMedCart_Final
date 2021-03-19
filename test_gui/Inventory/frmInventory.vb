﻿Imports System.Text.RegularExpressions
Public Class frmInventory

    Private btnSelectedDrawer As Button

    Public Sub SetSelectedDrawer(ByVal btnDrawer As Button)

        btnSelectedDrawer = btnDrawer

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDrawerNumber.SelectedIndex = 0
        cmbDividerBin.SelectedIndex = 0
        txtQuantity.Text = "1"
        ' setdefault text to the search box
        txtSearch.Text = txtSearch.Tag
        txtSearch.ForeColor = Color.Silver

        'Set the focus
        txtSearch.Select()

        DefaultSaveButtonLocation()
        txtQuantity.Text = 1

        ' the button's tab index from the previous screen will allow us to know what drawer that is
        cmbDrawerNumber.SelectedIndex = btnSelectedDrawer.TabIndex - 1
        cmbPatientNames.Items.Clear()
        Dim dsactivePatients As DataSet = CreateDatabase.ExecuteSelectQuery("Select * From Patient WHERE Active_Flag = 1 ;")
        For Each dr As DataRow In dsactivePatients.Tables(0).Rows
            cmbPatientNames.Items.Add(dr(EnumList.Patient.LastName) & ", " & dr(EnumList.Patient.FristName) & "   MRN: " & dr(EnumList.Patient.MRN_Number))
        Next

    End Sub

    '/*********************************************************************/
    '/*               SubProgram NAME: MoveControlsIfPatientMedication    */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/16/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This moves the save button to a specific location and makes the  */
    '/*  patient selection label and combobox visible.                    */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  cmbPatientPersonalMedication_SelectedIndexChanged                */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*  None                                                             */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	None                                                              */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/* MoveControlsIfPatientMedication()                                 */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 None                                                             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/16/2021    Initial creation                    */
    '/*********************************************************************/
    Public Sub MoveControlsIfPatientMedication()
        btnSave.Location = New Point(184, 75)
        pnlPatientNamePadding.Visible = True
        lblPatientName.Visible = True
    End Sub

    '/*********************************************************************/
    '/*               SubProgram NAME: DefaultSaveButtonLocation          */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/16/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This moves the save button to a specific location and makes the  */
    '/*  patient selection label and combobox invisible.                  */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  cmbPatientPersonalMedication_SelectedIndexChanged                */
    '/*  frmInventory_Load                                                */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*  None                                                             */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 None                                                             */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*  DefaultSaveButtonLocation()                                      */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 None                                                             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/16/2021    Initial creation                    */
    '/*********************************************************************/
    Public Sub DefaultSaveButtonLocation()
        btnSave.Location = New Point(184, 18)
        pnlPatientNamePadding.Visible = False
        lblPatientName.Visible = False
    End Sub

    '/*********************************************************************/
    '/* SubProgram NAME: cmbPatientPersonalMedication_SelectedIndexChanged*/         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/16/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This assess what item is selected in the combobox and then calls */
    '/*  the correct method to show additional fields as necessary.       */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  None                                                             */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*  MoveControlsIfPatientMedication                                  */  
    '/*  DefaultSaveButtonLocation                                        */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*  DefaultSaveButtonLocation()                                      */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 None                                                             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/16/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub cmbPatientPersonalMedication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPersonalMedication.SelectedIndexChanged

        Const YES As String = "Yes"

        If cboPersonalMedication.SelectedItem.Contains(YES) Then
            MoveControlsIfPatientMedication()
        Else
            DefaultSaveButtonLocation()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intControlled As Integer
        Dim intNarcotic As Integer
        Dim intDrawerMedication_ID As Integer = 0
        Dim Drawers_Tuid As Integer = 0
        Dim intMedicationTuid As Integer = 0
        Dim intMedQuanitiy As Integer = 0
        Dim intDividerBin As Integer = 0
        Dim intDiscrepancies As Integer = 0
        Dim strBarcode As String
        Dim strMessage As String

        If chkControlled.Checked Then
            intControlled = 1
        Else
            intControlled = 0
        End If

        If chkNarcotic.Checked Then
            intNarcotic = 1
        Else
            intNarcotic = 0
        End If
        ' make sure the proper information is selected or entered
        'Dim strTrimmedString As String
        ' take the split of the combobox selected item
        'strTrimmedString = (cmbMedicationName.Text.Split(","))(0)
        ' then trim off everything that's not a number
        'strTrimmedString = Regex.Replace(strTrimmedString, "(", "")

        'Check if all necessary textboxes for a new medication are full
        'If yes, then compare the medications in the database and either insert
        'the record or update records in the database
        If txtSchedule.Text <> "" And txtType.Text <> "" And txtStrength.Text <> "" Then
            'Check if a barcode is entered
            'If no, generate a sample
            'If yes, pass that to the barcode variable
            If txtBarcode.Text = Nothing Then
                strBarcode = generateSampleBarcode()
            Else
                strBarcode = txtBarcode.Text
            End If
            CompareMedications(strName.Substring(0, strName.Length), strRXCUI, intControlled, intNarcotic, strBarcode, txtType.Text, txtStrength.Text, CInt(txtSchedule.Text), 1)
        ElseIf txtSchedule.Text = "" Then
            MessageBox.Show("Please enter data in all fields before saving.")
            Exit Sub
        End If

        Try
            If CInt(cmbDrawerNumber.SelectedItem) > 25 Or CInt(cmbDrawerNumber.SelectedItem) < 0 Then
                MessageBox.Show("Please select an appropriate drawer number")
            Else

                Drawers_Tuid = CInt(cmbDrawerNumber.SelectedItem)

            End If

        Catch ex As Exception
            eprError.SetError(cmbDrawerNumber, "please enter an integer for drawer number between 1-25")

        End Try

        Try
            intMedQuanitiy = CInt(txtQuantity.Text)
        Catch ex As Exception
            eprError.SetError(cmbDrawerNumber, "please enter an amount that is a positive whole number")
        End Try



        ' search the information from the allproperties API call
        ' double-check if the drug is in the database already
        ' if yes, then update if there's differences
        ' if no, then save those items
        ' and pass it to the function to find interactions

        Dim myPropertyNameList As New List(Of String)({"severity", "description", "rxcui"})
        Dim outputList As New List(Of (PropertyName As String, PropertyValue As String))
        strMessage = "Retrieving drug interactions from the NIH website"
        Dim thdThread1 As New Threading.Thread(AddressOf ThreadedMessageBox)
        thdThread1.Name = strMessage
        thdThread1.Start()
        outputList = getInteractionsByName(strRXCUI, myPropertyNameList)

        'Double-check if the interactions with the matching pair of RXCUI's exist
        'If yes, Then update If there's differences
        ' Or insert the New lines
        ' And save those items

        Try
            strMessage = "Please wait while the interactions are saved to the database"
            Dim thdThread2 As New Threading.Thread(AddressOf ThreadedMessageBox)
            thdThread2.Name = strMessage
            thdThread2.Start()
            'There are four items returned from the API
            'Therefore, we step over 4 items every time 
            'we run the call
            'For i = 0 To outputList.Count - 4 Step 4
            'In the fourth item passed, we want to remove the ' character because it breaks SQL inserts
            CompareDrugInteractions(CInt(strRXCUI), outputList) 'CInt(outputList.Item(i + 3).PropertyValue), outputList.Item(i).PropertyValue, outputList.Item(i + 1).PropertyValue.Replace("'", ""), 1)
            'Next

            strMessage = "All interaction records have been added"
            Dim thdThread3 As New Threading.Thread(AddressOf ThreadedMessageBox)
            thdThread3.Name = strMessage
            thdThread3.Start()
        Catch ex As Exception
            MessageBox.Show("Interactions could not be recorded")
        End Try

        intDrawerMedication_ID = ExecuteScalarQuery("SELECT COUNT(DISTINCT DrawerMedication_ID) FROM DrawerMedication;")


        intMedicationTuid = ExecuteScalarQuery("Select Medication_ID From Medication WHERE Drug_Name ='" & strName & "';")
        'because we are adding a new drawermedication for now
        intDrawerMedication_ID += 1


        intDividerBin = CInt(cmbDividerBin.SelectedItem)

        ExecuteInsertQuery("INSERT INTO DrawerMedication (DrawerMedication_ID,Drawers_TUID,Medication_TUID,Quantity,Divider_Bin,Expiration_Date,Discrepancy_Flag, Active_Flag) VALUES (" & intDrawerMedication_ID & ", " & Drawers_Tuid & ", " & intMedicationTuid & ", " & intMedQuanitiy & "," & intDividerBin & " , '" & mtbExpirationDate.Text & "'," & intDiscrepancies & ",1);")
        MessageBox.Show("Medication has been added to the drawer")
        Debug.WriteLine("")

        eprError.Clear()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles pnlSearch.Click
        Dim myPropertyNameList As New List(Of String)({"rxcui"})
        Dim outputList As New List(Of (PropertyName As String, PropertyValue As String))
        Dim suggestedList As New List(Of String)

        outputList = GetRxcuiByName(txtSearch.Text, myPropertyNameList)
        ' check to see if anything comes back
        If outputList.Count = 0 Then
            ' if nothing, then ask to suggest names
            cboSuggestedNames.Visible = True
            suggestedList = GetSuggestionList(txtSearch.Text)
            ' then populate the combobox
            cboSuggestedNames.DataSource = suggestedList
        Else
            ' otherwise populate the medication name comboBox
            cmbMedicationName.DataSource = outputList
        End If
    End Sub

    Private Sub cmbMedicationName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMedicationName.SelectedIndexChanged
        Dim strTrimmedString As String
        Dim strSplitString() As String
        Dim lstProperties As List(Of String) = New List(Of String)
        Dim lstResults As List(Of (strPropertyName As String, strPropertyValue As String))
        ' take the split of the combobox selected item
        strTrimmedString = cmbMedicationName.Text.ToString '.Split(","))
        ' take off the parens
        Dim intOpenParens = InStr(strTrimmedString, "(")
        Dim intClosedParens = InStr(strTrimmedString, ")")
        If intOpenParens > 0 And intClosedParens > 0 Then
            strTrimmedString = strTrimmedString.Remove(intOpenParens - 1, 1)
            strTrimmedString = strTrimmedString.Remove(intClosedParens - 2, 1) ' remove 2 because of 0 is beginning and because the open parens is gone now too
        End If
        strSplitString = strTrimmedString.Split(",")
        'Dim strParens() As String = {"(", ")"}
        ' then trim off every space that's not necessary
        For Each strItem In strSplitString
            strItem = strItem.Trim
        Next
        ' and pass it to the function to get the atrributes
        lstProperties.Add("AVAILABLE_STRENGTH")
        lstProperties.Add("STRENGTH")
        lstProperties.Add("SCHEDULE")
        lstResults = getRxcuiProperty(strSplitString(0), lstProperties)
        ' add the original items to the lstResults
        lstResults.Add(("RXCUI", strSplitString(0)))
        lstResults.Add(("NAME", strSplitString(1)))

        ' first clear the fields
        txtStrength.Text = ""
        txtSchedule.Text = ""
        txtType.Text = ""
        chkControlled.Checked = False
        chkNarcotic.Checked = False
        cmbDrawerNumber.Text = ""
        cmbBin.Items.Clear()
        txtQuantity.Text = ""
        mtbExpirationDate.Text = ""
        cmbPatientPersonalMedication.SelectedItem = ""

        ' then populate the form and pass the results on 
        For Each result In lstResults
            Select Case result.strPropertyName
                Case "AVAILABLE_STRENGTH"
                    txtStrength.Text = result.strPropertyValue
                Case "STRENGTH"
                    txtStrength.Text = result.strPropertyValue
                Case "SCHEDULE"
                    If result.strPropertyValue Is Nothing Then
                        ' do nothing
                    ElseIf result.strPropertyValue = "1" Or result.strPropertyValue = "2" Or result.strPropertyValue = "3" Then
                        ' check the controlled and narcotic
                        chkControlled.Checked = True
                        chkNarcotic.Checked = True
                    ElseIf result.strPropertyValue = "2N" Or result.strPropertyValue = "3N" Or result.strPropertyValue = "4" Or result.strPropertyValue = "5" Then
                        ' check controlled only
                        chkControlled.Checked = True
                    Else
                        ' if the value isn't in these then it must be 0 or invalid - do nothing
                    End If
                    txtSchedule.Text = result.strPropertyValue
            End Select
        Next

        getDrugNameRxcui(lstResults)

        ' if the combo box text exceeds the box, there will be a tooltip that is provided on hover over the box with the full medication
        ' name 
        tpSelectedItem.SetToolTip(cmbMedicationName, cmbMedicationName.SelectedItem.ToString)
    End Sub

    '/*********************************************************************/
    '/* SubProgram NAME:txtSearch_GotFocus                                */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/26/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This sets the behavior of when this control gets focus. We are   */
    '/*  trying to remove the dummy text when the user enters the field   */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  None                                                             */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                    */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*                                       */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 None                                                             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/16/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus

        ' when the search box gains focus, we will remove the default text only if the user has not typed in it yet
        If txtSearch.ForeColor = Color.Silver Then

            txtSearch.Text = Nothing
            ' update the color of the search text to be black
            txtSearch.ForeColor = Color.Black

        End If

    End Sub

    '/*********************************************************************/
    '/* SubProgram NAME:txtSearch_GotFocus                                */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/26/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This sets the behavior of when this control loses focus. We will */
    '/* reset the text to the dummy text if it is empty, otherwise keep txt/
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  None                                                             */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                          */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*                                     */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 None                                                             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/16/2021    Initial creation                    */
    '/*********************************************************************/

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus

        ' when the search box loses focus, we will check and see if they put any text in it
        ' if they didnt, we will reset it to the default text.
        If txtSearch.Text = "" Then
            'reset the text to the default and set the font color to be black
            txtSearch.Text = txtSearch.Tag
            txtSearch.ForeColor = Color.Silver
        End If

    End Sub


    '/*********************************************************************/
    '/* SubProgram NAME:txtSearch_TextChanged                             */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/26/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This method ensures that when the user selects the enter key the */
    '/* the textbox does not go to the nextline, and that it searches.    */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  None                                                             */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                          */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*                                     */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 None                                                             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/16/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        ' detects if there has been another line added to the textbox
        ' indicating the user has selected the "enter" key
        If txtSearch.Lines.Length > 1 Then

            ' since we know the user selected enter and we are using a multiline textbox,
            ' the text input will be equal to whatever the user typed + a CRLF character
            ' we will replace that character with an empty string as if it was never typed.
            Dim singleLine = txtSearch.Text.Replace(vbCrLf, "")

            ' reset the textbox to be empty because it currently contains the user types string + CRLF
            txtSearch.Text = ""

            ' set the textbox to contain the searched word on a single line
            txtSearch.Text = singleLine

            ' by default VB will move the text cursor position to be at the first character after adding
            ' a new string to the textbox. This looks weird and seems like a bug to the user when the
            ' cursor position moves from the last character to the first. We will set to be the last 
            ' with the code below.
            txtSearch.Select(txtSearch.Text.Length, 0)


            '*********************************
            'Call method here to do the search
            '*********************************
            btnSearch_Click(sender, e)





            'set the focus to the next control because it should be populated 
            cmbMedicationName.Select()

        End If

    End Sub

    Private Sub SearchResults()
        frmProgressBar.Show()
        Dim myPropertyNameList As New List(Of String)({"rxcui"})
        Dim outputList As New List(Of (PropertyName As String, PropertyValue As String))

        outputList = GetRxcuiByName(txtSearch.Text, myPropertyNameList)
        If outputList.Count = 0 Then
            'outputList = GetSuggestionList(txtSearch.Text)
            ' then populate the combobox
            ' and if they click again on an item put it into the search box and search
            ' recursion 'til the cows come home
        End If
        cmbMedicationName.DataSource = outputList
    End Sub

    '/*********************************************************************/
    '/*                   FUNCTION NAME:  					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Eric LaVoie           		         */   
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
    '/*                                                                     
    '/*********************************************************************/

    Private Sub cboSuggestedNames_SelectedItemChanged(sender As Object, e As EventArgs) Handles cboSuggestedNames.DropDownClosed
        Dim strTrimmedSelection As String = cboSuggestedNames.SelectedItem.ToString
        ' if we'd have to trim it the logic would be here

        'send the item into the search box
        txtSearch.Text = strTrimmedSelection
        ' change the visibility of the comboboxes and clear them out
        cboSuggestedNames.Visible = False
        'cboSuggestedNames.Items.Clear()
        'cmbMedicationName.Visible = True
        'cmbMedicationName.Items.Clear()
        btnSearch_Click(sender, e)
    End Sub

    Private Sub cmbDrawerNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDrawerNumber.SelectedIndexChanged
        cmbDividerBin.Items.Clear()
        Dim intDrawerSize As Integer = 0
        Dim intNumDividers As Integer = 0
        Dim intDrawerNumber As Integer = CInt(cmbDrawerNumber.Text)
        Try
            intDrawerSize = ExecuteScalarQuery("SELECT Size FROM Drawers where Drawers_ID = " & intDrawerNumber.ToString & ";")
            intNumDividers = ExecuteScalarQuery("SELECT Number_of_Dividers FROM Drawers where Drawers_ID = " & intDrawerNumber.ToString & ";")
        Catch ex As Exception
            ' do nothing because there are empty values in the database
        End Try
        'txtQuantity.Text = intDrawerSize.ToString
        Dim dividerspopulation As New ArrayList(intNumDividers + 1)
        Dim intCounter As Integer = 1
        Do Until intCounter > (intNumDividers + 1)
            cmbDividerBin.Items.Add(intCounter)
            intCounter += 1
        Loop
        cmbDividerBin.SelectedIndex = 0
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmConfigureInventory.PreviouslySelectedDrawer(btnSelectedDrawer)
        frmMain.OpenChildForm(frmConfigureInventory)

    End Sub

    '/*********************************************************************/
    '/* SubProgram NAME:        txtStrength_KeyPress                      */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Breanna Howey       		          */   
    '/*		         DATE CREATED: 		3/01/2021                         */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This assess what key is pressed and restricts the keys to the string
    '/* passed to the KeyPressCheck function.                             */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  None                                                             */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*  KeyPressCheck                                                    */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*  txtStrength_KeyPress()                                           */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 None                                                             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  BRH  3/01/21    Initial creation                                 */
    Private Sub txtStrength_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStrength.KeyPress
        KeyPressCheck(e, "abcdefghijklmnopqrstuvwxyz1234567890/")
    End Sub

    '/*********************************************************************/
    '/* SubProgram NAME:        txtType_KeyPress                          */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Breanna Howey       		          */   
    '/*		         DATE CREATED: 		3/01/2021                         */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This assess what key is pressed and restricts the keys to the string
    '/* passed to the KeyPressCheck function.                             */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  None                                                             */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*  KeyPressCheck                                                    */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*  txtType_KeyPress()                                               */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 None                                                             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  BRH  3/01/21    Initial creation                                 */
    Private Sub txtType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtType.KeyPress
        KeyPressCheck(e, "abcdefghijklmnopqrstuvwxyz1234567890/")
    End Sub

    '/*********************************************************************/
    '/* SubProgram NAME:        txtBarcode_KeyPress                       */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Breanna Howey       		          */   
    '/*		         DATE CREATED: 		3/01/2021                         */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This assess what key is pressed and restricts the keys to the string
    '/* passed to the KeyPressCheck function.                             */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*  None                                                             */
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*  KeyPressCheck                                                    */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*  txtBarcode_KeyPress                                              */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	 None                                                             */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    Private Sub txtBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarcode.KeyPress
        KeyPressCheck(e, "abcdefghijklmnopqrstuvwxyz1234567890/")
    End Sub

    Private Sub btnDrawerUp_Click(sender As Object, e As EventArgs) Handles btnDrawerUp.Click
        IndexButtonIncrement(cmbDrawerNumber.SelectedIndex, cmbDrawerNumber.Items.Count - 1, cmbDrawerNumber)
    End Sub

    Private Sub btnDrawerDown_Click(sender As Object, e As EventArgs) Handles btnDrawerDown.Click
        IndexButtonDecrement(cmbDrawerNumber.SelectedIndex, cmbDrawerNumber)
    End Sub
    Private Sub btnQuantityUp_Click(sender As Object, e As EventArgs) Handles btnQuantityUp.Click
        ButtonIncrement(1000, txtQuantity)
    End Sub

    Private Sub btnQuantityDown_Click(sender As Object, e As EventArgs) Handles btnQuantityDown.Click
        ButtonDecrement(txtQuantity)
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")
        If txtQuantity.Text IsNot "" Then
            GraphicalUserInterfaceReusableMethods.MaxValue(sender.Text.ToString, 1000, txtQuantity)
        Else
            MessageBox.Show("The quantity must be at least 1")
            txtQuantity.Text = "1"
        End If
    End Sub

    Private Sub txtQuantity_Validated(sender As Object, e As EventArgs) Handles txtQuantity.Validated
        If txtQuantity.Text IsNot "" Then
            GraphicalUserInterfaceReusableMethods.MaxValue(sender.Text.ToString, 1000, txtQuantity)
        Else
            MessageBox.Show("The quantity must be at least 1")
            txtQuantity.Text = "1"
        End If
    End Sub

End Class