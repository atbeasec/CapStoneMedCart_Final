Public Class frmInventory
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DefaultSaveButtonLocation()

    End Sub


    Public Sub MoveControlsIfPatientMedication()
        btnSave.Location = New Point(184, 75)
        pnlPatientNamePadding.Visible = True
        lblPatientName.Visible = True
    End Sub

    Public Sub DefaultSaveButtonLocation()
        btnSave.Location = New Point(184, 18)
        pnlPatientNamePadding.Visible = False
        lblPatientName.Visible = False
    End Sub

    Private Sub cmbPatientPersonalMedication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatientPersonalMedication.SelectedIndexChanged

        Const YES As String = "Yes"


        If cmbPatientPersonalMedication.Text.Contains(YES) Then

            MoveControlsIfPatientMedication()

        Else

            DefaultSaveButtonLocation()

        End If

    End Sub



    'Dim CurrentContactPanelName As String = Nothing
    'Dim ContactPanelsAddedCount As Integer = 0

    'Private Sub btnNewPatient_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    PopulateInventory()
    '    AddToolTipToPanel()
    '    UpdateLabel()

    'End Sub

    'Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal genericName As String, ByVal brandName As String, ByVal quantity As String, ByVal measure As String)

    '    Dim pnl As Panel
    '    pnl = New Panel

    '    Dim pnlMainPanel As Panel
    '    pnlMainPanel = New Panel
    '    ' call method here to get the count from the database and update the panel number so the next item is correct


    '    'Set panel properties
    '    With pnl
    '        .BackColor = Color.Gainsboro
    '        .Size = New Size(790, 47)
    '        .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
    '        .Tag = getPanelCount(flpPannel).ToString
    '        .Padding = New Padding(0, 0, 0, 3)
    '        ' .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    With pnlMainPanel

    '        .BackColor = Color.White
    '        .Size = New Size(790, 45)
    '        .Name = "pnlIndividualPatientRecord" + getPanelCount(flpPannel).ToString
    '        .Tag = getPanelCount(flpPannel).ToString
    '        .Dock = System.Windows.Forms.DockStyle.Top
    '    End With

    '    'put the boarder panel inside the main panel
    '    pnl.Controls.Add(pnlMainPanel)


    '    'AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClickNewOrder
    '    AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
    '    AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault


    '    ' add controls to this panel
    '    CreateEditButton(pnlMainPanel, getPanelCount(flpPannel), 660, 5)
    '    CreateDeleteBtn(pnlMainPanel, getPanelCount(flpPannel), 740, 5)

    '    ' add controls to this panel
    '    ' call database info here to populate
    '    Dim lblID As New Label
    '    Dim lblID2 As New Label
    '    Dim lblID3 As New Label
    '    Dim lblID4 As New Label
    '    Dim lblID5 As New Label
    '    Dim lblID6 As New Label
    '    Dim lblID7 As New Label

    '    ' anywhere we have quotes except for the label names, we can call our Database and get method
    '    CreateIDLabel(pnlMainPanel, lblID, "lblGenericName", 10, 20, genericName, getPanelCount(flpPannel))
    '    CreateIDLabel(pnlMainPanel, lblID2, "lblBrandName", 210, 20, brandName, getPanelCount(flpPannel))
    '    CreateIDLabel(pnlMainPanel, lblID3, "lblQuantity", 420, 20, quantity, getPanelCount(flpPannel))
    '    CreateIDLabel(pnlMainPanel, lblID4, "lblMeasure", 530, 20, measure, getPanelCount(flpPannel))

    '    'Add panel to flow layout panel
    '    flpPannel.Controls.Add(pnl)

    'End Sub


    'Private Sub PopulateInventory()

    '    Dim genName1 As String = "benzhydrocodone "
    '    Dim genName2 As String = "hydrocodone bitartrate"
    '    Dim genName3 As String = "phenylephrine"
    '    Dim genName4 As String = "Morphine"
    '    Dim genName5 As String = "Codeine"

    '    Dim brandName1 As String = "Apadaz "
    '    Dim brandName2 As String = "Flowtuss "
    '    Dim brandName3 As String = "Histinex HC"
    '    Dim brandName4 As String = "Duramorph "
    '    Dim brandName5 As String = "Robitussin Ac"

    '    Dim quantity1 As String = "1"
    '    Dim quantity2 As String = "1"
    '    Dim quantity3 As String = "2"
    '    Dim quantity4 As String = "1"
    '    Dim quantity5 As String = "3"

    '    Dim measure1 As String = "10 mg"
    '    Dim measure2 As String = "10 mg"
    '    Dim measure3 As String = "50 mg"
    '    Dim measure4 As String = "10 mg"
    '    Dim measure5 As String = "10 mg"

    '    Dim dispensedBy1 As String = "Kathryn Bonner"
    '    Dim dispensedBy2 As String = "Lola Stanley"
    '    Dim dispensedBy3 As String = "Kathryn Bonner"
    '    Dim dispensedBy4 As String = "Kathryn Bonner"
    '    Dim dispensedBy5 As String = "Lola Stanley"

    '    Dim dispenseDate1 As String = "11/11/2020"
    '    Dim dispenseDate2 As String = "11/5/2020"
    '    Dim dispenseDate3 As String = "11/4/2020"
    '    Dim dispenseDate4 As String = "11/1/2020"
    '    Dim dispenseDate5 As String = "10/28/2020"

    '    Dim dispenseTime1 As String = "8:05 AM"
    '    Dim dispenseTime2 As String = "9:13 AM"
    '    Dim dispenseTime3 As String = "8:34 AM"
    '    Dim dispenseTime4 As String = "1:05 PM"
    '    Dim dispenseTime5 As String = "5:04 AM"

    '    CreatePanel(flpInventory, genName1, brandName1, quantity1, measure1)
    '    CreatePanel(flpInventory, genName2, brandName2, quantity2, measure2)
    '    CreatePanel(flpInventory, genName3, brandName3, quantity3, measure3)
    '    CreatePanel(flpInventory, genName4, brandName4, quantity4, measure4)
    '    CreatePanel(flpInventory, genName5, brandName5, quantity5, measure5)


    'End Sub




    'Public Sub DynamicButtonEditRecord_Click(ByVal sender As Object, ByVal e As EventArgs)

    '    'show the add new patient form filled in with the patients infromation
    '    'frmNewPatient.Show()

    '    'we call our  edit medication form

    'End Sub

    'Private Sub AddToolTipToPanel()

    '    Dim tp As New ToolTip

    '    For Each ctl In flpInventory.Controls

    '        If TypeName(ctl) = "Panel" Then


    '            tp.SetToolTip(ctl, "Double click to add item to drawer.")

    '        End If


    '    Next


    'End Sub


    'Private Sub btnConfigureInventory_Click(sender As Object, e As EventArgs)

    '    ' could make more generic by having a method search the form for a flow panel, take the name of that and then pass it into the create panel
    '    ' method
    '    ' CreatePanel(flpInventory)
    '    frmNewInventory.Show()

    '    frmConfigureInventory.Show()
    'End Sub

    'Private Sub UpdateLabel()

    '    Dim drawerNumber As String = frmConfigureInventory.lblDrawerNumber.Text

    '    Debug.Print(drawerNumber)



    '    lblDrawerNum.Text = "Add Items to Drawer " & drawerNumber

    'End Sub

    'Private Sub pnl_Click(sender As Object, e As EventArgs)

    '    MessageBox.Show("Added to form")

    'End Sub
    'Private Sub btnNewMedicine_Click(sender As Object, e As EventArgs)




    'End Sub


End Class