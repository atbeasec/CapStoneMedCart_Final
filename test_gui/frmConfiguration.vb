Public Class frmConfiguration
    Private Sub frmConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rbtnNurse.Checked = True
        PopulateUserInfo()


    End Sub

    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal strID As String, ByVal strName As String, ByVal strAccess As String)

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

        ' add controls to this panel
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
        Dim lblID6 As New Label

        Dim location As New Point(10, 20)
        Dim location2 As New Point(100, 20)
        Dim location3 As New Point(200, 20)
        Dim location4 As New Point(300, 20)
        Dim location5 As New Point(400, 20)
        Dim location6 As New Point(500, 20)

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblID", lblName.Location.X, 20, strName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblNames", lblIDNumber.Location.X, 20, strID, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblAccessLevel", lblAccess.Location.X, 20, strAccess, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub


    Private Sub PopulateUserInfo()

        Dim strID1 As String = "123456"
        Dim strID2 As String = "123457"
        Dim strID3 As String = "123458"
        Dim strID4 As String = "123459"
        Dim strID5 As String = "123460"
        Dim strID6 As String = "123461"
        Dim strID7 As String = "123462"
        Dim strID8 As String = "123463"
        Dim strID9 As String = "123464"

        Dim strFirstName1 As String = "John Smith"
        Dim strFirstName2 As String = "Sally Jones"
        Dim strFirstName3 As String = "Abigail Montilla"
        Dim strFirstName4 As String = "Oren Herndon"
        Dim strFirstName5 As String = "Birgit Horner"
        Dim strFirstName6 As String = "Roslyn Chiaramonte"
        Dim strFirstName7 As String = "Hae Fix"
        Dim strFirstName8 As String = "Fairy Johnson"
        Dim strFirstName9 As String = "Raymundo Yurick"

        Dim strAccess1 As String = "Nurse"
        Dim strAccess2 As String = "Nurse"
        Dim strAccess3 As String = "Charge Nurse"
        Dim strAccess4 As String = "Administrator"
        Dim strAccess5 As String = "Nurse"
        Dim strAccess6 As String = "Nurse"
        Dim strAccess7 As String = "Nurse"
        Dim strAccess8 As String = "Nurse"
        Dim strAccess9 As String = "Nurse"

        CreatePanel(flpUserInfo, strID1, strFirstName1, strAccess1)
        CreatePanel(flpUserInfo, strID2, strFirstName2, strAccess2)
        CreatePanel(flpUserInfo, strID3, strFirstName3, strAccess3)
        CreatePanel(flpUserInfo, strID4, strFirstName4, strAccess4)
        CreatePanel(flpUserInfo, strID5, strFirstName5, strAccess5)
        CreatePanel(flpUserInfo, strID6, strFirstName6, strAccess6)
        CreatePanel(flpUserInfo, strID7, strFirstName7, strAccess7)
        CreatePanel(flpUserInfo, strID8, strFirstName8, strAccess8)
        CreatePanel(flpUserInfo, strID9, strFirstName9, strAccess9)

    End Sub

    Private Sub txtUserID_LostFocus(sender As Object, e As EventArgs) Handles txtUserID.LostFocus
        'String to be sent to CreateDatabase Module to exicute search to check if Username is already in the User Table
        Dim strStatement = "SELECT COUNT(*) FROM User WHERE Username = '" & txtUserID.Text & "'"
        If ExecuteScalarQuery(strStatement) <> 0 Then
            MsgBox("A User already has that Username")
            txtUserID.Focus()
            txtUserID.Text = ""
        End If
    End Sub

    Private Sub txtBarcode_LostFocus(sender As Object, e As EventArgs) Handles txtBarcode.LostFocus
        'String to be sent to CreateDatabase Module to exicute search to check if Barcode is already in the User Table
        Dim strStatement = "SELECT COUNT(*) FROM User WHERE Barcode = '" & txtBarcode.Text & "'"
        If ExecuteScalarQuery(strStatement) <> 0 Then
            MsgBox("A User already has that Barcode")
            txtBarcode.Focus()
            txtBarcode.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intSupervisor As Integer = 0
        Dim intAdmin As Integer = 0
        Dim intActiveFlag As Integer = 1
        Dim strPassword As String = txtPassword.Text
        'call CheckPassword Function to see if password mets security standards
        If CheckPassword(strPassword) = False Then
            MsgBox("Password must contain at least 8 characters, 1 uppercase, 1 lowercase, 1 number, 1 special characters ")
            txtPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtPassword.Focus()
            ' make sure password and Confirm Password Match
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("Confirm Password must match Password")
            txtConfirmPassword.Text = ""
            txtConfirmPassword.Focus()
            'Make Sure all fields are filled
        ElseIf txtFirstName.Text = "" Or txtLastName.Text = "" Or txtUserID.Text = "" Or txtBarcode.Text = "" Then
            MsgBox("All Fields must be filled")
        Else
            'Insert data into table by calling ExecuteScalarQuery in CreateDatabase Module
            Dim strStatement = "INSERT INTO USER(Username,Password,User_First_Name, User_Last_Name, Barcode, Admin_Flag, Supervisor_Flag, Active_Flag)" &
            "VALUES('" & txtUserID.Text & "','" & strPassword & "','" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtBarcode.Text & "','" & intAdmin & "','" & intSupervisor & "','" & intActiveFlag & "')"
            ExecuteScalarQuery(strStatement)

            'clear all text boxes
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtUserID.Text = ""
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
    '/*											   */                     
    '/*                                                                     
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						         */               
    '/*											   */                     
    '/*  WHO            WHEN        WHAT								   */             
    '/*  ---            ----        ------------------------------------- */
    '/*  Dylan Walter   2/7/2021    Initial Creation                      */                                                                   
    '/*********************************************************************/
    Function CheckPassword(strPassword)
        'Security Requierments 
        Dim minLength As Integer = 8
        Dim numUpper As Integer = 1
        Dim numLower As Integer = 1
        Dim numNumbers As Integer = 1
        Dim numSpecial As Integer = 1
        Dim Secure As Boolean = True

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(strPassword) < minLength Then Secure = False
        ' Check for minimum number of occurrences.
        If upper.Matches(strPassword).Count < numUpper Then Secure = False
        If lower.Matches(strPassword).Count < numLower Then Secure = False
        If number.Matches(strPassword).Count < numNumbers Then Secure = False
        If special.Matches(strPassword).Count < numSpecial Then Secure = False

        ' Passed all checks.
        Return Secure
    End Function
End Class