﻿Imports System.Text.RegularExpressions
Public Class frmInventory
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        ' make sure the proper information is selected or entered
        'Dim strTrimmedString As String
        ' take the split of the combobox selected item
        'strTrimmedString = (cmbMedicationName.Text.Split(","))(0)
        ' then trim off everything that's not a number
        'strTrimmedString = Regex.Replace(strTrimmedString, "(", "")


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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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
        ComboBox3.Items.Clear()
        ComboBox2.Items.Clear()
        ' then populate the form and pass the results on 
        For Each result In lstResults
            Select Case result.strPropertyName
                Case "AVAILABLE_STRENGTH"
                    ComboBox3.Items.Add(result.strPropertyValue)
                Case "STRENGTH"
                    ComboBox3.Items.Add(result.strPropertyValue)
                Case "SCHEDULE"
                    If result.strPropertyValue Is Nothing Then
                        ' do nothing
                    ElseIf result.strPropertyValue = "1" Or "2" Or "3" Then
                        ' insert logic here to check the controlled and narcotic
                    ElseIf result.strPropertyValue = "2N" Or "3N" Or "4" Or "5" Then
                        ' insert logic here to check controlled only
                    Else
                        ' if the value isn't in these then it must be 0 or invalid - do nothing
                    End If
                    ' insert logic here to populate the schedule box.
            End Select
        Next
    End Sub

    '/*********************************************************************/
    '/*                   SUBROUTINE NAME: AddItemsToForm	              */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Eric LaVoie           		      */   
    '/*		         DATE CREATED: 2/25/2021		                      */                             
    '/*********************************************************************/
    '/*  SUBROUTINE PURPOSE:								              */             
    '/*	 This function will take the items returned by the API calls and  */                     
    '/*  populate the form accoringly.                                    */
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*                                         				   */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*             (NONE)								   */             
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*											   */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*											   */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*											                          */                     
    '/*                                                                   */ 
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  Eric LaVoie 2/25/2021  Initial creation                          */
    '/*                                                                   */                                                                   
    '/*********************************************************************/

    Sub AddItemsToForm(lstItems As List(Of (ParameterName As String, ParameterValue As String)))
        ' turn off the search group box, turn on the drug input group box and turn on the save/cancel buttons
        ' take the items for the list and add them to the appropriate boxes
        ' add the rxcui
        ' add the description
        ' add the type
        ' add the checkboxes for schedule
        ' Case 1 - this will be a narcotic and controlled
        ' Case 2 - this will be a narcotic and controlled
        ' Case 2N - this will controlled and non-narcotic
        ' Case 3 - this will be a narcotic and controlled
        ' Case 3N - this will controlled and non-narcotic
        ' Case 4 - this will controlled and non-narcotic
        ' Case 5 - this will controlled and non-narcotic
        ' Case 0 - this is not controlled nor is it a narcotic
        ' Case Else - anything else treat as non-controlled and non-narcotic
        ' add the strengths
        ' use an if statement for if strength is not nothing
        ' add if else available_strength is not nothing
        ' add an else which means neither has a value

        'Dim strTrimmedString As String
        ' take the split of the combobox selected item
        ' strTrimmedString = (cmbMedicationName.Text.Split(","))(0)
        ' then trim off everything that's not a number
        ' strTrimmedString = Regex.Replace(strTrimmedString, "(", "")
        'strTrimmedString = Regex.Replace(strTrimmedString, ")", "")
        ' and pass it to the function to find better names
    End Sub

End Class