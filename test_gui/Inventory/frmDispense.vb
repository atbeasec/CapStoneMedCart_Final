Public Class frmDispense
    Public blnSignedOff As Boolean = False
    Public blnOverride As Boolean = False
    Private intPatientID As Integer
    Private intPatientMRN As Integer

    Dim contactPanelsAddedCount As Integer = 0
    Dim currentContactPanelName As String = Nothing

    Public Sub SetPatientID(ByVal ID As Integer)
        intPatientID = ID
        intPatientMRN = ExecuteScalarQuery("SELECT MRN_Number from Patient WHERE Patient_ID =" & intPatientID & ";")
    End Sub

    Public Sub SetPatientMrn(ByVal mrn As Integer)
        intPatientMRN = mrn
    End Sub

    Private Sub btnDispense_Click(sender As Object, e As EventArgs)

        MessageBox.Show("CAUTION: This drug interacts with (insert drug name here) that the patient is currently taking. Or the patient is allergic to this drug")

        'frmWitnessSignOff.Show()
        ' call emthod to open serial port connection and open drawer

    End Sub

    Public Sub CreateDispenseHistoryPanels(ByVal flpPannel As FlowLayoutPanel, ByVal strMedicationName As String, ByVal strStrength As String, ByVal strType As String, ByVal strQuantity As String, ByVal strDispenseBy As String, ByVal strDispenseDate As String, ByVal strDispenseTime As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel

        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(1040, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(1040, 45)
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
        ' call database info here to populate
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Dim lblID6 As New Label

        CreateIDLabelWithToolTip(pnlMainPanel, lblID, "lblMedicationName", lblMedication.Location.X, 20, strMedicationName, getPanelCount(flpPannel), tpToolTip, TruncateString(25, strMedicationName))
        CreateIDLabel(pnlMainPanel, lblID2, "lblStrength", lblStrength.Location.X, 20, strStrength, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblType", lblType.Location.X, 20, strType, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblQuantity", lblQuantity.Location.X, 20, strQuantity, getPanelCount(flpPannel))
        CreateIDLabelWithToolTip(pnlMainPanel, lblID5, "lblDispensedBy", lblDispensedBy.Location.X, 20, strDispenseBy, getPanelCount(flpPannel), tpToolTip, TruncateString(30, strDispenseBy))
        CreateIDLabel(pnlMainPanel, lblID6, "lblDispenseTimeAndDate", lblDateTime.Location.X, 20, strDispenseDate.Substring(0, 19), getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub


    Private Sub Dispense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDirections.Text = "Select Amount To Dispense:"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)

        pnlAmountInDrawer.Visible = False
        pnlAmountAdministered.Visible = False
        pnlSelector.Visible = False

    End Sub


    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        ButtonIncrement(1000, txtQuantityToDispense)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        ButtonDecrement(txtQuantityToDispense)
    End Sub

    Private Sub btnDispense_Click_1(sender As Object, e As EventArgs) Handles btnDispense.Click


        'If Not IsNothing(cmbMedications.SelectedItem) Then
        '    For Each allergy In lstboxAllergies.Items
        '        If cmbMedications.SelectedItem.ToString.ToLower.Contains(allergy.ToString.ToLower) Then
        '            'show witness sign off
        '            frmWitnessSignOff.Label1.Text = cmbMedications.SelectedItem.ToString
        '            frmWitnessSignOff.referringForm = Me
        '            frmWitnessSignOff.ShowDialog()
        '            'if authentication from witness sign off form comes back then
        '            If blnOverride Then
        '                Dim intMaxAllergyID
        '                ' pull the information to insert
        '                If ExecuteScalarQuery("Select AllergyOverride_ID from AllergyOverride") = Nothing Then
        '                    intMaxAllergyID = 0
        '                Else
        '                    intMaxAllergyID = ExecuteScalarQuery("SELECT MAX(AllergyOverride_ID) from AllergyOverride")
        '                    intMaxAllergyID += 1
        '                End If

        '                ExecuteInsertQuery("INSERT INTO AllergyOverride(AllergyOverride_ID, Patient_TUID, User_TUID, Allergy_Name, DateTime) " &
        '                                   "Values(" & intMaxAllergyID & ", " & intPatientID & ", " & LoggedInID & ", '" & allergy & "', '" & DateTime.Now & "')")
        '            Else
        '                MessageBox.Show("Dispense canceled by user.")
        '                Exit Sub
        '            End If
        '            blnOverride = False
        '        Else
        '            ' do nothing as there is no allergy
        '        End If
        '    Next
        '    'If blnSignedOff = True Then
        '    DispenseHistory.DispenseMedication(DispenseHistory.SplitMedicationString(cmbMedications.SelectedItem), intPatientID)
        '    MessageBox.Show("Order Successfully placed")
        '    '   blnSignedOff = False
        '    ' End If

        'End If





        ' check if the medication is a narcotic

        ' IsNarcotic()

        'else

        'IsNotNarcotic()




    End Sub


    Private Sub IsNarcotic()
        ' if it is narcotic we need to do the following

        ' pop open drawer here()
        lblDirections.Text = "Select Amount To Dispense"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)
        pnlAmountToRemove.Visible = True

        'hide other panels
        pnlAmountAdministered.Visible = False
        pnlAmountInDrawer.Visible = False

        'amount to dispense is stored in this variable
        'txtQuantityToDispense.Text


        lblDirections.Text = "Enter the Quantity in the Cart"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)
        btnDispense.Text = "Submit Count"
        pnlAmountInDrawer.Visible = True

        'hide other panels
        pnlAmountAdministered.Visible = False
        pnlAmountToRemove.Visible = False

        ' we will need to get the data typed in the textfield here and dump to the db. That is stored in
        ' txtCountInDrawer.Text

        If btnDispense.Text = "Submit Count" Then

            lblDirections.Text = "Enter the Amount Administered"
            lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)
            ' show approiate panels
            pnlAmountAdministered.Visible = True
            pnlAmountToRemove.Visible = False
            pnlAmountInDrawer.Visible = False

            ' we will need to get the data typed in textfields here and dump to db. That is stored in
            'txtAmountDispensed.Text



            ' here we call the waste form...
            frmMain.OpenChildForm(frmWaste)

        End If


    End Sub

    Private Sub IsNotNarcotic()

        ' if it is narcotic we need to do the following

        ' pop open drawer here()
        lblDirections.Text = "Select Amount To Dispense"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)
        pnlAmountToRemove.Visible = True

        'hide other panels
        pnlAmountAdministered.Visible = False
        pnlAmountInDrawer.Visible = False

        'amount to dispense is stored in this variable
        'txtQuantityToDispense.Text


        lblDirections.Text = "Enter the Amount Administered"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)

        ' show approiate panels
        pnlAmountAdministered.Visible = True
        pnlAmountToRemove.Visible = False
        pnlAmountInDrawer.Visible = False
        btnDispense.Text = "Submit Count"

        ' we will need to get the data typed in textfields here and dump to db. That is stored in
        'txtAmountDispensed.Text

        ' here we call the waste form...
        frmMain.OpenChildForm(frmWaste)

    End Sub

    Private Sub cmbMedications_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMedications.SelectedIndexChanged
        DispenseHistory.SetMedicationProperties()
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityToDispense.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")
        GraphicalUserInterfaceReusableMethods.MaxValue(CInt(sender.Text), 1000, txtQuantityToDispense)
    End Sub
    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantityToDispense.TextChanged
        If IsNumeric(sender.Text) Then
            GraphicalUserInterfaceReusableMethods.MaxValue(CInt(sender.Text), 1000, txtQuantityToDispense)
        Else
            MessageBox.Show("Please make sure you enter a positive number 1-1000")
            sender.Text = "1"
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmPatientInfo.setPatientID(intPatientID)
        frmMain.OpenChildForm(frmPatientInfo)

    End Sub


End Class