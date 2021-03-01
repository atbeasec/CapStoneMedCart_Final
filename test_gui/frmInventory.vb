Imports System.Text.RegularExpressions
Public Class frmInventory
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' setdefault text to the search box
        txtSearch.Text = txtSearch.Tag
        txtSearch.ForeColor = Color.Silver

        'Set the focus
        txtSearch.Select()

        DefaultSaveButtonLocation()
        txtQuantity.Text = 1

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
    Private Sub cmbPatientPersonalMedication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatientPersonalMedication.SelectedIndexChanged

        Const YES As String = "Yes"

        If cmbPatientPersonalMedication.Text.Contains(YES) Then
            MoveControlsIfPatientMedication()
        Else
            DefaultSaveButtonLocation()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intControlled As Integer
        Dim intNarcotic As Integer

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
        If txtSchedule.Text <> Nothing And txtType.Text <> Nothing And txtStrength.Text <> Nothing Then
            CompareMedications(strName.Substring(0, strName.Length), strRXCUI, intControlled, intNarcotic, generateSampleBarcode(), txtType.Text, txtStrength.Text, CInt(txtSchedule.Text), 1)
        Else
            MessageBox.Show("Please enter data in all fields before saving.")
        End If



        ' search the information from the allproperties API call
        ' double-check if the drug is in the database already
        ' if yes, then update if there's differences
        ' if no, then save those items
        ' and pass it to the function to find interactions
        Dim myPropertyNameList As New List(Of String)({"severity", "description", "rxcui"})
        Dim outputList As New List(Of (PropertyName As String, PropertyValue As String))
        outputList = getInteractionsByName("153008", myPropertyNameList)
        ' double-check if the interactions with the matching pair of RXCUI's exist
        ' if yes, then update if there's differences
        ' or insert the new lines
        ' and save those items
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
        txtDrawerNumber.Text = ""
        cmbBin.Items.Clear()
        txtQuantity.Text = ""
        txtExpirationDate.Text = ""
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
            SearchResults()





            'set the focus to the next control because it should be populated 
            cmbMedicationName.Select()

        End If

    End Sub

    Private Sub SearchResults()

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

    Private Sub cboSuggestedNames_SelectedItemChanged(sender As Object, e As EventArgs) Handles cboSuggestedNames.Leave
        Dim strTrimmedSelection As String = cboSuggestedNames.SelectedItem.ToString
        ' if we'd have to trim it the logic would be here

        'send the item into the search box
        txtSearch.Text = strTrimmedSelection
        ' change the visibility of the comboboxes and clear them out
        cboSuggestedNames.Visible = False
        'cboSuggestedNames.Items.Clear()
        cmbMedicationName.Visible = True
        'cmbMedicationName.Items.Clear()
        pnlSearch.Select()
    End Sub

End Class