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

    Public Sub CreatePrescriptionsPanels(ByVal flpPannel As FlowLayoutPanel, ByVal medicationName As String, ByVal strength As String, ByVal frequency As String, ByVal type As String, ByVal quantity As String, ByVal datePrescribed As String, ByVal PrescribedBy As String)
        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


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
        Dim lblID7 As New Label

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        ' to ensure all of the text being added to the panel is inline with the  headers, we will use the label location of the
        ' header as the reference point for the X axis when creating these labels at run time.
        CreateIDLabelWithToolTip(pnlMainPanel, lblID, "lblMedicationPrescription", lblMedicationName.Location.X, 20, medicationName, getPanelCount(flpPannel), tpToolTip, TruncateString(15, medicationName))
        ' CreateIDLabel(pnlMainPanel, lblID, "lblMedicationPrescription", lblMedicationName.Location.X, 20, medicationName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblStrengthPrescription", lblStrength.Location.X, 20, strength, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblFrequencyPrescription", lblFrequency.Location.X, 20, frequency, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblTypePrescription", lblType.Location.X, 20, type, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblQuantityPrescription", lblQuantity.Location.X, 20, quantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblDatePrescribed", lblDatePrescribed.Location.X, 20, datePrescribed.Substring(0, 10), getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID7, "lblPrescribedBy", lblPrescribedBy.Location.X, 20, PrescribedBy, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

        'currentContactPanel = pnl.Name

    End Sub


    Private Sub Dispense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDirections.Text = "Select Amount To Dispense:"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)

        pnlAmountInDrawer.Visible = False

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







        'Logic here to check if the medication is narcotic or controlled
        ' if this is true we will update the label on the screen

        If btnDispense.Text = "Dispense Medication" Then

            ' first thing that always has to happen is we need to find out how much they want to dispense
            lblDirections.Text = "Select Amount To Dispense"
            lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)
            pnlAmountToRemove.Visible = True

            'hide other panels
            pnlAmountAdministered.Visible = False
            pnlAmountInDrawer.Visible = False


            'check here with an if statement to see if the medication is narcotic/controlled




            ' wait for drawer to close

            '  ElseIf btnDispense.Text = "Submit Count" Then

            ' check if the medication count is going to cause a descrepancy with what is in db here
            ' CInt(txtQuantity.Text)




        End If



    End Sub


    Private Sub IsNarcotic()
        ' if it is narcotic we need to do the following

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


        End If





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