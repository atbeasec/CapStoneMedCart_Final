Public Class frmPatientRecords

    Dim currentContactPanel As String = Nothing

    Private Sub btnNewPatient_Click_1(sender As Object, e As EventArgs) Handles btnNewPatient.Click

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
    '/*											                          */                     
    '/*                                                                     
    '/*********************************************************************/
    '/*  RETURNS:								                          */                   
    '/*            (NOTHING)								              */             
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:							                      */             
    '/*											                          */                     
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
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
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
    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal strMRN As String, ByVal strFirstName As String, ByVal strLastName As String, ByVal strBirthday As String, ByVal strRoom As String, ByVal strBed As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel

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

        Dim lblID1 As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Dim lblID6 As New Label

        Const YCOORDINATE As Integer = 20

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID1, "lblMRN", lblMRN.Location.X, YCOORDINATE, strMRN, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblFirstName", lblFirstName.Location.X, YCOORDINATE, strFirstName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblLastName", lblLastName.Location.X, YCOORDINATE, strLastName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblBirthday", lblDOB.Location.X, YCOORDINATE, strBirthday.Substring(0, 10), getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblRoom", lblRoom.Location.X, YCOORDINATE, strRoom, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblBed", lblBed.Location.X, YCOORDINATE, strBed, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

        currentContactPanel = pnl.Name
    End Sub

    '/********************************************************************/
    '/*                   SUB NAME: DynamicSingleClickOpenPatient	     */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/6/21			                     */                             
    '/********************************************************************/
    '/*  SUB Purpose:This sub creates the handler for when a panel is    */	
    '/* is clicked on by the user.
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY: DynamicSingleClickOpenPatient   	      		     */				            
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
    Private Sub DynamicSingleClickOpenPatient(sender As Object, e As EventArgs)

        ' frmPatientInfo.txtMRN.Text = GetSelectedPatientMRN(sender)
        frmPatientInfo.setPatientMrn(GetSelectedPatientMRN(sender))
        ' open the patient record form of the matching patient
        frmMain.OpenChildForm(frmPatientInfo)

    End Sub

    '/********************************************************************/
    '/*                   FUNCTION NAME: GetSelectedPatientMRN	         */         
    '/********************************************************************/
    '/*                   WRITTEN BY: Collin Krygier  		             */   
    '/*		         DATE CREATED: 	2/6/21			                     */                             
    '/********************************************************************/
    '/*  FUNCTION PURPOSE: this function retrieves the the MRN of the	 */					            
    '/*	 patient selected by the user.					                 */					                       
    '/*                                                                  */
    '/********************************************************************/
    '/*  CALLED BY: DynamicSingleClickOpenPatient   	      		     */				            
    '/*                                        				             */         
    '/********************************************************************/
    '/*  CALLS:								                             */		                  
    '/*             (NONE)						                         */		               
    '/********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):				             */	           
    '/*	 sender- an object representing the control that was selected    */								                        
    '/*                                                                  */  
    '/********************************************************************/
    '/*  RETURNS:							                             */	                          
    '/*  intMRN- an integer that is the MRN number of the selected patient/								             
    '/********************************************************************/
    '/* SAMPLE INVOCATION:						                         */		             
    '/*	GetSelectedPatientMRN(sender)					                 */					                       
    '/*                                                                  */   
    '/********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):   */
    '/*	 ctl- a control object that is used to hold all of the controls  */
    '/*  that will be iterated over.					                 */
    '/********************************************************************/
    '/* MODIFICATION HISTORY:						                     */		                 
    '/*									                                 */		                   
    '/*  WHO            WHEN             WHAT				             */		            
    '/*  ---            ----             ----				             */
    '/*  CK		       2/6/21		 initial creation                    */
    '/*  DP            3/9/21        updated to return Patient_ID        */
    '/********************************************************************/ 
    Function GetSelectedPatientMRN(sender As Object) As Integer

        Dim intPatientID As Integer = Nothing
        Dim ctl As Control

        ' iterating over the list of controls in the panel
        For Each ctl In sender.Controls

            ' the label containing the MRN number will always be called "lblMRN" with a number tacked on
            ' to represent what number panel it is in the row of created panels.
            ' simplying searching for the control that contains MRN will always yield the correct label.
            If ctl.Name.Contains("MRN") Then

                Debug.Print(ctl.Text)
                intPatientID = CInt(ctl.Text)
            End If
        Next
        'Get Patient ID using MRN where Active_Flag is = 1

        'SELECT Patient_ID from Patient WHERE MRN_Number = 247413140 AND Active_Flag = 1
        intPatientID = (ExecuteScalarQuery("SELECT Patient_ID from Patient WHERE MRN_Number = " & intPatientID & " AND Active_Flag = 1"))
        'returning the PatientID of the patient from the selected record
        Return intPatientID
    End Function

    '/*********************************************************************/
    '/* SubProgram NAME:txtSearchGotFocusEvent                            */         
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
    '/*           txtSearchGotFocusEvent                                  */
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

        SearchLogic.txtSearchGotFocusEvent(txtSearch)

    End Sub

    '/*********************************************************************/
    '/* SubProgram NAME:txtSearchLostFocusEvent                           */         
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
    '/*  txtSearchLostFocusEvent                                          */
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 sender- object representing a control                            */
    '/*  e- eventargs indicating there is an event handle assigned        */
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*                                                                   */     
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

        SearchLogic.txtSearchLostFocusEvent(txtSearch)

    End Sub

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



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strFillSQL As String = "select Patient.MRN_Number, Patient.Patient_First_Name, " &
                                           "Patient.Patient_Last_Name, Patient.Date_of_Birth, patientroom.Room_TUID, patientroom.Bed_Name from Patient LEFT JOIN " &
                                           "PatientRoom on Patient.Patient_ID = PatientRoom.Patient_TUID where Patient.Active_Flag =1 AND " &
                                           "(Patient_First_Name Like '" & txtSearch.Text & "%' OR Patient_Last_Name Like '" & txtSearch.Text & "%'" &
                                           "OR MRN_Number like '" & txtSearch.Text & "%') ORDER BY Patient.Patient_Last_Name ASC;"
        Fill_Patient_Table(strFillSQL)
    End Sub

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
End Class