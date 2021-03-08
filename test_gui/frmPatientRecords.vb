Public Class frmPatientRecords

    'Dim ContactPanelsAddedCount As Integer = 0
    'Private CurrentContactPanelName As String = Nothing

    Dim currentContactPanel As String = Nothing

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmPatientInfo.Show()

    End Sub

    Private Sub btnNewPatient_Click_1(sender As Object, e As EventArgs) Handles btnNewPatient.Click

        ' CreatePanel(flpPatientRecords)
        ' frmNewPatient.Show()
        frmMain.OpenChildForm(frmNewPatient)

    End Sub
    '/*********************************************************************/
    '/*                   FUNCTION NAME:  					   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:   		         */   
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
    '/*	 strBed	- this is going to hold the bed name if there is a value  */
    '/*     in the patientRoom database. If there isn't it will display as*/
    '/*     N/A
    '/*  strRoom - this is going to hold the room number if there is a value*/
    '/*     in the patientRomm database. If tehre isn't it will display as */
    '/*     N/A
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO   WHEN     WHAT								   */             
    '/*  ---   ----     ------------------------------------------------- */
    '/*  NP    2/4/2021 Created the SQL statements to pull back the       */
    '/*                 information needed for Patient Records Form.      */
    '/*                 Created variables strRoom and strBed              */
    '/* AB     2/8/2021 Changed looping code as there was a bug 
    '/*                 that it would only display the first patient multiple
    '/*                 times
    '/*********************************************************************/


    Private Sub frmPatientRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strFillSQL As String = ("select Patient.MRN_Number, Patient.Patient_First_Name, " &
                                           "Patient.Patient_Last_Name, Patient.Date_of_Birth, patientroom.Room_TUID, patientroom.Bed_Name from Patient LEFT JOIN " &
                                           "PatientRoom on Patient.Patient_ID = PatientRoom.Patient_TUID where Patient.Active_Flag =1 ORDER BY Patient.Patient_Last_Name ASC;")
        Fill_Patient_Table(strFillSQL)

        txtSearch.Text = txtSearch.Tag
        txtSearch.ForeColor = Color.Silver
    End Sub

    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal strID As String, ByVal strFirstName As String, ByVal strLastName As String, ByVal strBirthday As String, ByVal strRoom As String, ByVal strBed As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(920, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(920, 45)
            .Name = "pnlIndividualPatientRecord" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)


        AddHandler pnlMainPanel.Click, AddressOf DynamicSingleClickOpenPatient
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        ' add controls to this panel
        CreateEditButton(pnlMainPanel, getPanelCount(flpPannel), 810, 5)
        ' CreateDeleteBtn(pnlMainPanel, getPanelCount(flpPannel), 830, 5)

        'CreateDeleteBtn(pnlMainPanel)
        'CreateEditButton(pnlMainPanel)


        ' call database info here to populate
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Dim lblID6 As New Label

        Dim location As New Point(10, 20)
        Dim location2 As New Point(100, 20)
        Dim location3 As New Point(200, 20)
        Dim location4 As New Point(300, 20)
        Dim location5 As New Point(400, 20)
        Dim location6 As New Point(500, 20)

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblMRN", 10, 20, strID, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblFirstName", 125, 20, strFirstName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblLastName", 270, 20, strLastName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblBirthday", 430, 20, strBirthday, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblRoom", 545, 20, strRoom, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblBed", 670, 20, strBed, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)
        'flpCamera.Controls.Add(contactPanel)
        'Update panel variables

        currentContactPanel = pnl.Name


    End Sub

    Private Sub DynamicSingleClickOpenPatient(sender As Object, e As EventArgs)

        ' frmPatientInfo.txtMRN.Text = GetSelectedPatientMRN(sender)
        frmPatientInfo.setPatientMrn(GetSelectedPatientMRN(sender))
        ' going to need to send this value to every form that could open from this selected patient record.

        ' open the form first. then pass this integer to the next form.


        ' allows panel to have double click functionality to open it
        ' frmPatientInfo.Show()

        frmMain.OpenChildForm(frmPatientInfo)
        'Form1.OpenChildForm()
    End Sub

    'Private Sub DynamicMouseHoverLeave(sender As Object, e As EventArgs)

    '    If sender.backColor = Color.Gainsboro Then
    '        sender.backColor = Color.White

    '    Else

    '        sender.backcolor = Color.Gainsboro
    '    End If


    'End Sub

    'Private Sub DynamicMouseHoverEnter(sender As Object, e As EventArgs)
    '    'changes the background color when the mouse is hovered over the panel

    '    If sender.backColor = Color.White Then
    '        sender.backColor = Color.Gainsboro

    '    Else

    '        sender.backcolor = Color.White
    '    End If

    'End Sub


    'Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel)

    '    Dim pnl As Panel
    '    pnl = New Panel

    '    Dim pnlMainPanel As Panel
    '    pnlMainPanel = New Panel
    '    ' call method here to get the count from the database and update the panel number so the next item is correct


    '    'Set panel properties
    '    With pnl
    '        .BackColor = Color.Gainsboro
    '        .Size = New Size(955, 47)
    '        .Name = "pnlIndividualPatientRecordPadding" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Padding = New Padding(0, 0, 0, 3)
    '        ' .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    With pnlMainPanel

    '        .BackColor = Color.White
    '        .Size = New Size(955, 45)
    '        .Name = "pnlIndividualPatientRecord" + (ContactPanelsAddedCount + 1).ToString
    '        .Tag = ContactPanelsAddedCount + 1
    '        .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    'put the boarder panel inside the main panel
    '    pnl.Controls.Add(pnlMainPanel)
    '    AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClick
    '    AddHandler pnlMainPanel.MouseEnter, AddressOf DynamicMouseHoverEnter
    '    AddHandler pnlMainPanel.MouseLeave, AddressOf DynamicMouseHoverLeave

    '    ' add controls to this panel

    '    CreateContactDeleteBtn(pnlMainPanel)
    '    CreateEditButton(pnlMainPanel)


    '    ' call database info here to populate
    '    Dim lblID As New Label
    '    Dim lblID2 As New Label
    '    Dim lblID3 As New Label
    '    Dim lblID4 As New Label
    '    Dim lblID5 As New Label
    '    Dim lblID6 As New Label

    '    Dim location As New Point(10, 20)
    '    Dim location2 As New Point(100, 20)
    '    Dim location3 As New Point(200, 20)
    '    Dim location4 As New Point(300, 20)
    '    Dim location5 As New Point(400, 20)
    '    Dim location6 As New Point(500, 20)

    '    CreateIDLabel(pnlMainPanel, lblID, "lblID", 10, 20, "123456")
    '    CreateIDLabel(pnlMainPanel, lblID2, "lblFirstName", 135, 20, "John")
    '    CreateIDLabel(pnlMainPanel, lblID3, "lblLastName", 275, 20, "Smith")
    '    CreateIDLabel(pnlMainPanel, lblID4, "lblRoomLocation", 430, 20, "B-21")
    '    CreateIDLabel(pnlMainPanel, lblID5, "lblStatus", 565, 20, "Admited")
    '    CreateIDLabel(pnlMainPanel, lblID6, "lblAdmitDate", 680, 20, "11/3/2020")

    '    'Add panel to flow layout panel
    '    flpPatientRecords.Controls.Add(pnl)
    '    'flpCamera.Controls.Add(contactPanel)
    '    'Update panel variables

    '    CurrentContactPanelName = pnl.Name
    '    ContactPanelsAddedCount += 1

    'End Sub

    'Add new  delete button to contact panel
    'Private Sub CreateContactDeleteBtn(ByVal panelName As Panel)

    '    Dim btnDeleteButton As Button
    '    btnDeleteButton = New Button
    '    'declare our image and point at the resource
    '    Dim imageTrash As New Bitmap(New Bitmap(My.Resources.icons8_delete_trash), 25, 25)

    '    'Set button properties
    '    With btnDeleteButton
    '        .AutoSize = True
    '        .Size = New Size(30, 30)

    '        .FlatStyle = FlatStyle.Flat
    '        .FlatAppearance.BorderSize = 0
    '        .ForeColor = Color.Transparent
    '        ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
    '        .Location = New Point(890, 5)
    '        .Name = "btnDeletePatientRecord" + (ContactPanelsAddedCount).ToString
    '        .Image = imageTrash
    '        .ImageAlign = ContentAlignment.MiddleCenter
    '        .Tag = ContactPanelsAddedCount + 1
    '    End With


    '    panelName.Controls.Add(btnDeleteButton)
    '    ' MessageBox.Show("again")
    '    'Add handler for click events
    '    AddHandler btnDeleteButton.Click, AddressOf DynamicButton_Click

    'End Sub

    'Private Sub CreateEditButton(ByVal panelName As Panel)

    '    Dim btnEditButton As Button
    '    btnEditButton = New Button
    '    'declare our image and point at the resource
    '    Dim imagePencil As New Bitmap(New Bitmap(My.Resources.icons8_pencil), 25, 25)

    '    'Set button properties
    '    With btnEditButton
    '        .AutoSize = True
    '        .Size = New Size(30, 30)

    '        .FlatStyle = FlatStyle.Flat
    '        .FlatAppearance.BorderSize = 0
    '        .ForeColor = Color.Transparent
    '        ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
    '        .Location = New Point(825, 5)
    '        .Name = "btnEditPatientRecord" + (ContactPanelsAddedCount).ToString
    '        .Image = imagePencil
    '        .ImageAlign = ContentAlignment.MiddleCenter
    '        .Tag = ContactPanelsAddedCount + 1
    '    End With


    '    panelName.Controls.Add(btnEditButton)
    '    ' MessageBox.Show("again")
    '    'Add handler for click events
    '    AddHandler btnEditButton.Click, AddressOf DynamicButtonEditRecord_Click

    'End Sub
    ''Remove handlers and contact panel 
    'Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)

    '    'the parent of the button will be the panel the control is located on.
    '    'we want to get one step removed so we need to next take the parent of the control
    '    ' to get the name of flowpanel which the button is laid out on
    '    Dim control As Control = sender.Parent
    '    Dim parents As Control = control.Parent



    '    Dim parentFlowPanel As Control = control.Parent
    '    'Dim strFlowPanelName As String = control.Parent.Name

    '    ' Debug.Print(control.Parent.Name)

    '    Dim parentPanelName As String

    '    parentPanelName = Nothing

    '    'Remove handler from sender
    '    For Each controlObj As Control In parentFlowPanel.Controls
    '        For Each childControlObj As Control In controlObj.Controls
    '            If childControlObj.Name = sender.name Then

    '                RemoveHandler childControlObj.Click, AddressOf DynamicButton_Click

    '                parentPanelName = childControlObj.Parent.Name
    '            End If
    '        Next
    '    Next



    '    'Remove contact panel
    '    For Each controlObj As Control In parentFlowPanel.Controls
    '        If controlObj.Name = parentPanelName Then

    '            ' prompt user if they are sure they want to delete the record


    '            ' remove the record from the database

    '            'remove the padding panel from the flow panel
    '            flpPatientRecords.Controls.Remove(controlObj.Parent)
    '            controlObj.Parent.Dispose()

    '            'remove the panel from the flow panel
    '            flpPatientRecords.Controls.Remove(controlObj)
    '            controlObj.Dispose()


    '        End If
    '    Next

    '    'parents.Name
    '    ' Dim connn As Control = parentFlowPanel.Parent
    '    'Debug.Print(connn.Name)
    '    'Debug.Print(parentFlowPanel.Name)
    '    'UpdateCamerasSubtotalLabel(parentFlowPanel)

    'End Sub

    'Public Sub DynamicButtonEditRecord_Click(ByVal sender As Object, ByVal e As EventArgs)

    '    'show the add new patient form filled in with the patients infromation
    '    'frmUpdatePatient.Show()
    '    frmPatientInfo.Show()
    'End Sub

    'Private Sub CreateIDLabel(ByVal panelName As Panel, lblName As Label, strLabelName As String, x As Integer, y As Integer, labelText As String)

    '    ' Dim lblID As Label
    '    'lblName = New Label
    '    'location = New Point
    '    'declare our image and point at the resource

    '    'Set button properties
    '    With lblName
    '        .AutoSize = True
    '        '.Size = New Size(30, 30)

    '        .FlatStyle = FlatStyle.Flat
    '        ' .FlatAppearance.BorderSize = 0
    '        .ForeColor = Color.Black
    '        .Font = New Font(New FontFamily("Segoe UI"), 11, FontStyle.Regular)
    '        .Location = New Point(x, y) 'new Point(600, 5)
    '        .Name = strLabelName + (ContactPanelsAddedCount).ToString
    '        .Text = labelText
    '        .Tag = ContactPanelsAddedCount + 1
    '    End With


    '    panelName.Controls.Add(lblName)

    'End Sub


    '/********************************************************************/
    '/*                   FUNCTION NAME: GetSelectedPatientMRN	         */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		         */   
    '/*		         DATE CREATED: 	2/6/21			         */                             
    '/********************************************************************/
    '/*  FUNCTION PURPOSE: this function retrieves the the MRN of the	 */					            
    '/*	 patient selected by the user.					 */					                       
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY: DynamicSingleClickOpenPatient   	      		 */				            
    '/*                                        				 */         
    '/********************************************************************/
    '/*  CALLS:								 */		                  
    '/*             (NONE)						 */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				 */	           
    '/*	 sender- an object representing the control that was selected    */								                        
    '/*                                                                  */  
    '/********************************************************************/
    '/*  RETURNS:							 */	                          
    '/*  intMRN- an integer that is the MRN number of the selected patient/								             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						 */		             
    '/*	GetSelectedPatientMRN(sender)					 */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 ctl- a control object that is used to hold all of the controls  */
    '/*  that will be iterated over.					 */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						 */		                 
    '/*									 */		                   
    '/*  WHO            WHEN             WHAT				 */		            
    '/*  ---            ----             ----				 */
    '/*  CK		2/6/21		 initial creation                */
    '/********************************************************************/ 
    Function GetSelectedPatientMRN(sender As Object) As Integer

        Dim intMRN As Integer = Nothing
        Dim ctl As Control

        ' iterating over the list of controls in the panel
        For Each ctl In sender.Controls

            ' the label containing the MRN number will always be called "lblMRN" with a number tacked on
            ' to represent what number panel it is in the row of created panels.
            ' simplying searching for the control that contains MRN will always yield the correct label.
            If ctl.Name.Contains("MRN") Then

                Debug.Print(ctl.Text)
                intMRN = CInt(ctl.Text)
            End If
        Next
        'returning the MRN of the patient from the selected record
        Return intMRN
    End Function

    'Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    '' detects if there has been another line added to the textbox
    '' indicating the user has selected the "enter" key
    'If txtSearch.Lines.Length > 1 Then

    '    ' since we know the user selected enter and we are using a multiline textbox,
    '    ' the text input will be equal to whatever the user typed + a CRLF character
    '    ' we will replace that character with an empty string as if it was never typed.
    '    Dim singleLine = txtSearch.Text.Replace(vbCrLf, "")

    '    ' reset the textbox to be empty because it currently contains the user types string + CRLF
    '    txtSearch.Text = ""

    '    ' set the textbox to contain the searched word on a single line
    '    txtSearch.Text = singleLine

    '    ' by default VB will move the text cursor position to be at the first character after adding
    '    ' a new string to the textbox. This looks weird and seems like a bug to the user when the
    '    ' cursor position moves from the last character to the first. We will set to be the last 
    '    ' with the code below.
    '    txtSearch.Select(txtSearch.Text.Length, 0)

    '    ' this information will be called when the user selects enter and the search event detects this being done.
    '    Dim strFillSQL As String
    '    If txtSearch.Text = "" Then

    '        strFillSQL = "select Patient.MRN_Number, Patient.Patient_First_Name, " &
    '                                       "Patient.Patient_Last_Name, Patient.Date_of_Birth, patientroom.Room_TUID, patientroom.Bed_Name from Patient LEFT JOIN " &
    '                                       "PatientRoom on Patient.Patient_ID = PatientRoom.Patient_TUID where Patient.Active_Flag =1 ORDER BY Patient.Patient_Last_Name ASC;"
    '        Fill_Patient_Table(strFillSQL)
    '    End If

    'End If

    'End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            Dim strFillSQL As String = "select Patient.MRN_Number, Patient.Patient_First_Name, " &
                                   "Patient.Patient_Last_Name, Patient.Date_of_Birth, patientroom.Room_TUID, patientroom.Bed_Name from Patient LEFT JOIN " &
                                   "PatientRoom on Patient.Patient_ID = PatientRoom.Patient_TUID where Patient.Active_Flag =1 AND " &
                                   "(Patient_First_Name Like '" & txtSearch.Text & "%' OR Patient_Last_Name Like '" & txtSearch.Text & "%'" &
                                   "OR MRN_Number like '" & txtSearch.Text & "%') ORDER BY Patient.Patient_Last_Name ASC;"
            Fill_Patient_Table(strFillSQL)
        End If

    End Sub


    Private Sub Fill_Patient_Table(ByVal strFillSQL As String)
        flpPatientRecords.Controls.Clear()

        Dim dsPatientInfo As DataSet = CreateDatabase.ExecuteSelectQuery(strFillSQL)
        Dim strRoom As String
        Dim strBed As String


        For Each item As DataRow In dsPatientInfo.Tables(0).Rows()
            With dsPatientInfo.Tables(0)


                If IsDBNull(item.Item(4)) Then
                    strRoom = "N/A"
                Else
                    strRoom = item.Item(4).ToString
                End If

                If IsDBNull(item.Item(5)) Then
                    strBed = "N/A"
                Else
                    strBed = item.Item(5).ToString

                End If
                CreatePanel(flpPatientRecords, item.Item(0), item.Item(1),
                           item.Item(2), item.Item(3), strRoom, strBed)

            End With
        Next
    End Sub

    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus

        SearchLogic.txtSearchGotFocusEvent(txtSearch)

    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus

        SearchLogic.txtSearchLostFocusEvent(txtSearch)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFillSQL As String = "select Patient.MRN_Number, Patient.Patient_First_Name, " &
                                           "Patient.Patient_Last_Name, Patient.Date_of_Birth, patientroom.Room_TUID, patientroom.Bed_Name from Patient LEFT JOIN " &
                                           "PatientRoom on Patient.Patient_ID = PatientRoom.Patient_TUID where Patient.Active_Flag =1 AND " &
                                           "(Patient_First_Name Like '" & txtSearch.Text & "%' OR Patient_Last_Name Like '" & txtSearch.Text & "%'" &
                                           "OR MRN_Number like '" & txtSearch.Text & "%') ORDER BY Patient.Patient_Last_Name ASC;"
        Fill_Patient_Table(strFillSQL)
    End Sub
End Class