Public Class Dispense

    Private intPatientMrn As Integer

    Dim contactPanelsAddedCount As Integer = 0
    Dim currentContactPanelName As String = Nothing

    Public Sub SetPatientMrn(ByVal mrn As Integer)
        intPatientMrn = mrn
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
        CreateIDLabel(pnlMainPanel, lblID, "lblMedicationPrescription", lblMedicationName.Location.X, 20, medicationName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblStrengthPrescription", lblStrength.Location.X, 20, strength, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblFrequencyPrescription", lblFrequency.Location.X, 20, frequency, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblTypePrescription", lblType.Location.X, 20, type, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblQuantityPrescription", lblQuantity.Location.X, 20, quantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblDatePrescribed", lblDatePrescribed.Location.X, 20, datePrescribed, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID7, "lblPrescribedBy", lblPrescribedBy.Location.X, 20, PrescribedBy, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

        'currentContactPanel = pnl.Name

    End Sub


    Private Sub Dispense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim genName1 As String = "benzhydrocodone "
        Dim genName2 As String = "hydrocodone bitartrate"
        Dim genName3 As String = "phenylephrine"
        Dim genName4 As String = "Morphine"
        Dim genName5 As String = "Codeine"

        Dim brandName1 As String = "Apadaz "
        Dim brandName2 As String = "Flowtuss "
        Dim brandName3 As String = "Histinex HC"
        Dim brandName4 As String = "Duramorph "
        Dim brandName5 As String = "Robitussin Ac"

        Dim measure1 As String = "10 mg"
        Dim measure2 As String = "10 mg"
        Dim measure3 As String = "50 mg"
        Dim measure4 As String = "10 mg"
        Dim measure5 As String = "10 mg"

        Dim dispenseDate1 As String = "11/11/2020"
        Dim dispenseDate2 As String = "11/5/2020"
        Dim dispenseDate3 As String = "11/4/2020"
        Dim dispenseDate4 As String = "11/1/2020"
        Dim dispenseDate5 As String = "10/28/2020"

        txtQuantity.Text = "1"

        ' CreatePanel(flpAssignedMedications, genName1, brandName1, measure1, dispenseDate1)
        ' CreatePanel(flpAssignedMedications, genName2, brandName2, measure2, dispenseDate2)
        ' CreatePanel(flpAssignedMedications, genName3, brandName3, measure3, dispenseDate3)
        ' CreatePanel(flpAssignedMedications, genName4, brandName4, measure4, dispenseDate4)

    End Sub


    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        ButtonIncrement(txtQuantity)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        ButtonDecrement(txtQuantity)
    End Sub

    Private Sub btnDispense_Click_1(sender As Object, e As EventArgs) Handles btnDispense.Click
        If Not IsNothing(cmbMedications.SelectedItem) Then
            MessageBox.Show("Drawer Has Opened")
            DispenseHistory.DispenseMedication(DispenseHistory.SplitMedicationString(cmbMedications.SelectedItem), txtMRN.Text)
        End If

    End Sub

    Private Sub cmbMedications_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMedications.SelectedIndexChanged
        DispenseHistory.SetMedicationProperties()
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

        'LimitQuantityToQuantityStocked(SQLreturnValue, sender)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmPatientInfo.setPatientMrn(intPatientMrn)
        frmMain.OpenChildForm(frmPatientInfo)

    End Sub
End Class