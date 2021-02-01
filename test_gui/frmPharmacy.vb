Public Class frmPharmacy

    Dim currentContactPanel As String = Nothing

    Private Sub frmPharmacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Jonie Nicolas
        'Mauricio Adkisson

        Dim strID1 As String = "123456"
        Dim strID2 As String = "123457"
        Dim strID3 As String = "123458"
        Dim strID4 As String = "123459"
        Dim strID5 As String = "123460"
        Dim strID6 As String = "123461"
        Dim strID7 As String = "123462"
        Dim strID8 As String = "123463"
        Dim strID9 As String = "123464"

        Dim strFirstName1 As String = "John"
        Dim strFirstName2 As String = "Sally"
        Dim strFirstName3 As String = "Abigail"
        Dim strFirstName4 As String = "Oren"
        Dim strFirstName5 As String = "Birgit"
        Dim strFirstName6 As String = "Roslyn"
        Dim strFirstName7 As String = "Hae"
        Dim strFirstName8 As String = "Fairy"
        Dim strFirstName9 As String = "Raymundo"

        Dim strLastName1 As String = "Smith"
        Dim strLastName2 As String = "Jones"
        Dim strLastName3 As String = "Montilla"
        Dim strLastName4 As String = "Herndon"
        Dim strLastName5 As String = "Horner"
        Dim strLastName6 As String = "Chiaramonte"
        Dim strLastName7 As String = "Fix"
        Dim strLastName8 As String = "Johnson"
        Dim strLastName9 As String = "Yurick"

        Dim strRoomNumber1 As String = "B-21"
        Dim strRoomNumber2 As String = "B-22"
        Dim strRoomNumber3 As String = "B-23"
        Dim strRoomNumber4 As String = "B-24"
        Dim strRoomNumber5 As String = "B-25"
        Dim strRoomNumber6 As String = "B-26"
        Dim strRoomNumber7 As String = "B-27"
        Dim strRoomNumber8 As String = "B-28"
        Dim strRoomNumber9 As String = "B-29"

        Dim strStatus1 As String = "Admitted"
        Dim strStatus2 As String = "Admitted"
        Dim strStatus3 As String = "Admitted"
        Dim strStatus4 As String = "Admitted"
        Dim strStatus5 As String = "Admitted"
        Dim strStatus6 As String = "Admitted"
        Dim strStatus7 As String = "Admitted"
        Dim strStatus8 As String = "Admitted"
        Dim strStatus9 As String = "Admitted"

        Dim strAdmitDate1 As String = "11/3/2020"
        Dim strAdmitDate2 As String = "10/1/2020"
        Dim strAdmitDate3 As String = "12/2/2020"
        Dim strAdmitDate4 As String = "11/12/2020"
        Dim strAdmitDate5 As String = "11/1/2020"
        Dim strAdmitDate6 As String = "11/16/2020"
        Dim strAdmitDate7 As String = "11/12/2020"
        Dim strAdmitDate8 As String = "11/1/2020"
        Dim strAdmitDate9 As String = "11/16/2020"

        'CreatePanel(flpPatients, strID1, strFirstName1, strLastName1, strRoomNumber1, strStatus1, strAdmitDate1)
        'CreatePanel(flpPatients, strID2, strFirstName2, strLastName2, strRoomNumber2, strStatus2, strAdmitDate2)
        'CreatePanel(flpPatients, strID3, strFirstName3, strLastName3, strRoomNumber3, strStatus3, strAdmitDate3)
        'CreatePanel(flpPatients, strID4, strFirstName4, strLastName4, strRoomNumber4, strStatus4, strAdmitDate4)
        'CreatePanel(flpPatients, strID5, strFirstName5, strLastName5, strRoomNumber5, strStatus5, strAdmitDate5)
        'CreatePanel(flpPatients, strID6, strFirstName6, strLastName6, strRoomNumber6, strStatus6, strAdmitDate6)
        'CreatePanel(flpPatients, strID7, strFirstName7, strLastName7, strRoomNumber7, strStatus7, strAdmitDate7)
        'CreatePanel(flpPatients, strID8, strFirstName8, strLastName8, strRoomNumber8, strStatus8, strAdmitDate8)
        'CreatePanel(flpPatients, strID9, strFirstName9, strLastName9, strRoomNumber9, strStatus9, strAdmitDate9)

    End Sub





    'Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal strID As String, ByVal strFirstName As String, ByVal strLastName As String, ByVal strRoomNumber As String, ByVal strStatus As String, ByVal strAdmitDate As String)

    '    Dim pnl As Panel
    '    pnl = New Panel

    '    Dim pnlMainPanel As Panel
    '    pnlMainPanel = New Panel
    '    ' call method here to get the count from the database and update the panel number so the next item is correct


    '    'Set panel properties
    '    With pnl
    '        .BackColor = Color.Gainsboro
    '        .Size = New Size(955, 47)
    '        .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPatients).ToString
    '        .Tag = getPanelCount(flpPatients).ToString
    '        .Padding = New Padding(0, 0, 0, 3)
    '        ' .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    With pnlMainPanel

    '        .BackColor = Color.White
    '        .Size = New Size(955, 45)
    '        .Name = "pnlIndividualPatientRecord" + getPanelCount(flpPatients).ToString
    '        .Tag = getPanelCount(flpPatients).ToString
    '        .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    'put the boarder panel inside the main panel
    '    pnl.Controls.Add(pnlMainPanel)


    '    AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClickNewOrder
    '    AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
    '    AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

    '    ' add controls to this panel
    '    CreateEditButton(pnlMainPanel, getPanelCount(flpPatients), 830, 5)
    '    CreateDeleteBtn(pnlMainPanel, getPanelCount(flpPatients), 890, 5)

    '    'CreateDeleteBtn(pnlMainPanel)
    '    'CreateEditButton(pnlMainPanel)


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

    '    ' anywhere we have quotes except for the label names, we can call our Database and get method
    '    CreateIDLabel(pnlMainPanel, lblID, "lblID", 10, 20, strID, getPanelCount(flpPatients))
    '    CreateIDLabel(pnlMainPanel, lblID2, "lblFirstName", 135, 20, strFirstName, getPanelCount(flpPatients))
    '    CreateIDLabel(pnlMainPanel, lblID3, "lblLastName", 275, 20, strLastName, getPanelCount(flpPatients))
    '    CreateIDLabel(pnlMainPanel, lblID4, "lblRoomLocation", 430, 20, strRoomNumber, getPanelCount(flpPatients))
    '    CreateIDLabel(pnlMainPanel, lblID5, "lblStatus", 565, 20, strStatus, getPanelCount(flpPatients))
    '    CreateIDLabel(pnlMainPanel, lblID6, "lblAdmitDate", 680, 20, strAdmitDate, getPanelCount(flpPatients))

    '    'Add panel to flow layout panel
    '    flpPannel.Controls.Add(pnl)
    '    'flpCamera.Controls.Add(contactPanel)
    '    'Update panel variables

    '    currentContactPanel = pnl.Name


    'End Sub

    'Public Sub DynamicDoubleClickNewOrder(ByVal sender As Object, ByVal e As EventArgs)


    '    frmNewOrder.Show()
    '    'show the add new patient form filled in with the patients infromation
    '    'frmUpdatePatient.Show()
    '    ' frmPatientInfo.Show()
    'End Sub
End Class