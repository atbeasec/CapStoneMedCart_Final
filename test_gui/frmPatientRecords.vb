Public Class frmPatientRecords

    'Dim ContactPanelsAddedCount As Integer = 0
    'Private CurrentContactPanelName As String = Nothing

    Dim currentContactPanel As String = Nothing
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        frmPatientInfo.Show()

    End Sub

    Private Sub btnNewPatient_Click_1(sender As Object, e As EventArgs) Handles btnNewPatient.Click

        ' CreatePanel(flpPatientRecords)
        frmNewPatient.Show()

    End Sub

    Private Sub frmPatientRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        CreatePanel(flpPatientRecords, strID1, strFirstName1, strLastName1, strRoomNumber1, strStatus1, strAdmitDate1)
        CreatePanel(flpPatientRecords, strID2, strFirstName2, strLastName2, strRoomNumber2, strStatus2, strAdmitDate2)
        CreatePanel(flpPatientRecords, strID3, strFirstName3, strLastName3, strRoomNumber3, strStatus3, strAdmitDate3)
        CreatePanel(flpPatientRecords, strID4, strFirstName4, strLastName4, strRoomNumber4, strStatus4, strAdmitDate4)
        CreatePanel(flpPatientRecords, strID5, strFirstName5, strLastName5, strRoomNumber5, strStatus5, strAdmitDate5)
        CreatePanel(flpPatientRecords, strID6, strFirstName6, strLastName6, strRoomNumber6, strStatus6, strAdmitDate6)
        CreatePanel(flpPatientRecords, strID7, strFirstName7, strLastName7, strRoomNumber7, strStatus7, strAdmitDate7)
        CreatePanel(flpPatientRecords, strID8, strFirstName8, strLastName8, strRoomNumber8, strStatus8, strAdmitDate8)
        CreatePanel(flpPatientRecords, strID9, strFirstName9, strLastName9, strRoomNumber9, strStatus9, strAdmitDate9)

    End Sub

    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal strID As String, ByVal strFirstName As String, ByVal strLastName As String, ByVal strRoomNumber As String, ByVal strStatus As String, ByVal strAdmitDate As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(955, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(955, 45)
            .Name = "pnlIndividualPatientRecord" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)


        AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClickOpenPatient
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        ' add controls to this panel
        CreateEditButton(pnlMainPanel, getPanelCount(flpPannel), 830, 5)
        CreateDeleteBtn(pnlMainPanel, getPanelCount(flpPannel), 890, 5)

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
        CreateIDLabel(pnlMainPanel, lblID, "lblID", 10, 20, strID, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblFirstName", 135, 20, strFirstName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblLastName", 275, 20, strLastName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblRoomLocation", 430, 20, strRoomNumber, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblStatus", 565, 20, strStatus, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblAdmitDate", 680, 20, strAdmitDate, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)
        'flpCamera.Controls.Add(contactPanel)
        'Update panel variables

        currentContactPanel = pnl.Name


    End Sub

    Private Sub DynamicDoubleClickOpenPatient(sender As Object, e As EventArgs)

        ' allows panel to have double click functionality to open it
        frmPatientInfo.Show()

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


End Class