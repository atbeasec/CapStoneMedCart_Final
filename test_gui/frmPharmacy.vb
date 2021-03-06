Public Class frmPharmacy

    Dim currentContactPanel As String = Nothing

    Dim dsPhysicians As DataSet
    Dim dsPatients As DataSet

    Private Sub frmPharmacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtQuantity.Text = 0

        dsPhysicians = ExecuteSelectQuery("Select * From Physician ORDER BY Physician_Last_Name, Physician_First_Name;")
        dsPatients = ExecuteSelectQuery("Select * From Patient ORDER BY Patient_Last_Name, Patient_First_Name;")
        populatePhysicianComboBox(cmbOrderedBy, dsPhysicians)
        populatePatientNameComboBox(cmbPatientName, dsPatients)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnORder.Click
        Dim dtmOrderTime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")


    End Sub

    Private Sub btnIncrement_Click(sender As Object, e As EventArgs) Handles btnIncrement.Click
        ButtonIncrement(1000, txtQuantity)

    End Sub

    Private Sub btnDecrement_Click(sender As Object, e As EventArgs) Handles btnDecrement.Click
        ButtonDecrement(txtQuantity)
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