Imports System.Text

Public Class frmDispense
    Public blnSignedOff As Boolean = True
    Public blnOverride As Boolean = False
    Private intPatientID As Integer
    Private intPatientMRN As Integer
    Private intMedicationID As Integer

    Private intDispenseAmount As Integer
    Private intCountedAmount As Integer
    Private dblDispensedPatientAmount As Integer
    Private dblWastedAmount As Integer

    Dim contactPanelsAddedCount As Integer = 0
    Dim currentContactPanelName As String = Nothing

    Private intEnteredFromAdhoc As Integer = 0

    'variables here are only used if adhoc is the form that initiated dispensing
    Public strAmountAdhoc As String
    Public strUnitAdhoc As String
    Public intDrawerMEDAdhoc As Integer

    Public Sub setintEntered(ByRef ID As Integer)
        intEnteredFromAdhoc = ID
    End Sub

    Public Function getIntEntered()
        Return intEnteredFromAdhoc
    End Function

    Public Sub SetPatientID(ByVal ID As Integer)
        intPatientID = ID
        intPatientMRN = ExecuteScalarQuery("SELECT MRN_Number from Patient WHERE Patient_ID =" & intPatientID & ";")
    End Sub

    Public Sub SetintMedicationID(ByVal ID As Integer)
        intMedicationID = ID
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
        Dim NarcoticFlag As Integer = CreateDatabase.ExecuteScalarQuery("Select Controlled_Flag from Medication where Medication_ID = '" & intMedicationID & "' and Active_Flag = '1'")
        Dim intdrawerNumber As Integer = CreateDatabase.ExecuteScalarQuery("Select Drawers_TUID from DrawerMedication where Medication_TUID = '" & intMedicationID & "' and Active_Flag = '1'")
        If lblDirections.Text.Equals("Select Amount To Dispense:") Then
            If IsNumeric(txtQuantityToDispense.Text) Then
                If txtQuantityToDispense.Text > 0 Then
                    If NarcoticFlag = 1 Then
                        'Is a narcotic
                        OpenOneDrawer(intdrawerNumber)
                        intDispenseAmount = txtQuantityToDispense.Text
                        changebuttonForCounting()
                        frmMain.LockSideMenu()
                        btnBack.Visible = False
                    Else
                        'Is not a narcotic
                        OpenOneDrawer(intdrawerNumber)
                        intDispenseAmount = txtQuantityToDispense.Text
                        changeButtonforDispensing()
                        frmMain.LockSideMenu()
                        btnBack.Visible = False
                    End If
                Else
                    MessageBox.Show("Please enter a quantity value greater than 0")
                End If
            End If

        ElseIf lblDirections.Text.Equals("Enter the Quantity in the Cart") Then
            If IsNumeric(txtQuantityToDispense.Text) Then
                Dim intAmountinCart As Integer = txtCountInDrawer.Text
                UpdateSystemCountForDiscrepancy(intMedicationID, intdrawerNumber, intAmountinCart)
                changeButtonforDispensing()
            End If
        ElseIf lblDirections.Text.Equals("Enter the Amount Administered") Then
            If IsNumeric(txtAmountDispensed.Text) Then
                If intEnteredFromAdhoc = 0 Then
                    Dim strAmountDispensed As String = txtAmountDispensed.Text & " " & txtUnits.Text
                    Dim intdrawerMEDTUID As Integer = CreateDatabase.ExecuteScalarQuery("Select DrawerMedication_ID from DrawerMedication where Medication_TUID = '" & intMedicationID & "' and Active_Flag = '1'")
                    DispensingDrug(intMedicationID, CInt(LoggedInID), strAmountDispensed)
                    frmWaste.SetPatientID(intPatientID)
                    frmWaste.setDrawer(intdrawerNumber)
                    frmWaste.setMedID(intMedicationID)
                    frmWaste.setDrawerMEDTUID(intdrawerMEDTUID)
                    frmMain.OpenChildForm(frmWaste)

                ElseIf intEnteredFromAdhoc = 1 Then
                    Dim strAmountDispensed As String = txtAmountDispensed.Text & " " & txtUnits.Text
                    DispensingDrugAdhoc(intMedicationID, intPatientID, CInt(LoggedInID), strAmountDispensed, intDrawerMEDAdhoc)
                    frmWaste.SetPatientID(intPatientID)
                    frmWaste.setDrawer(intDrawerMEDAdhoc)
                    frmWaste.setMedID(intMedicationID)
                    frmWaste.setDrawerMEDTUID(intDrawerMEDAdhoc)
                    frmWaste.setEnteredFromAdhoc(1)
                    frmMain.OpenChildForm(frmWaste)
                End If

            Else
                MessageBox.Show("Please enter a numeric number greater than 0")
            End If

        End If
    End Sub

    Private Sub changebuttonForCounting()
        lblDirections.Text = "Enter the Quantity in the Cart"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)
        btnDispense.Text = "Submit Count"
        pnlAmountInDrawer.Visible = True
        pnlAmountToRemove.Visible = False
    End Sub
    Private Sub changeButtonforDispensing()
        lblDirections.Text = "Enter the Amount Administered"
        lblDirections.Left = (pnlSelector.Width \ 2) - (pnlSelector.Width \ 2)
        ' show approiate panels
        pnlAmountAdministered.Visible = True
        pnlAmountToRemove.Visible = False
        pnlAmountInDrawer.Visible = False
        Dim strAmountUnit As String = CreateDatabase.ExecuteScalarQuery("Select Amount_Per_Container_Unit from DrawerMedication where Medication_TUID = '" & intMedicationID & "' and Active_Flag = '1'")
        txtUnits.Text = strAmountUnit
    End Sub


    Private Sub DispensingDrug(ByRef intMedID As Integer, ByRef intPrimaryID As Integer, ByRef strAmountDispensed As String)
        Dim strbSQLcommand As New StringBuilder()
        Dim dtmAdhocTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim intdrawerNumber As Integer = CreateDatabase.ExecuteScalarQuery("Select DrawerMedication_ID from DrawerMedication where Medication_TUID = '" & intMedicationID & "' and Active_Flag = '1'")
        strbSQLcommand.Clear()
        strbSQLcommand.Append("SELECT PatientMedication_ID FROM PatientMedication WHERE Medication_TUID = '" & intMedID & "' AND Patient_TUID = '" & intPatientID & "' AND PatientMedication.Active_Flag = '1'")
        Dim intPatientMedicationDatabaseID As Integer = CreateDatabase.ExecuteScalarQuery(strbSQLcommand.ToString)
        strbSQLcommand.Clear()
        strbSQLcommand.Append("INSERT INTO Dispensing(PatientMedication_TUID, Primary_User_TUID, Approving_User_TUID, DateTime_Dispensed, Amount_Dispensed, DrawerMedication_TUID) ")
        strbSQLcommand.Append("VALUES('" & intPatientMedicationDatabaseID & "','" & intPrimaryID & "','" & intPrimaryID & "','" & dtmAdhocTime & "','" & strAmountDispensed & "','" & intdrawerNumber & "')")
        CreateDatabase.ExecuteInsertQuery(strbSQLcommand.ToString)
    End Sub

    Private Sub DispensingDrugAdhoc(ByRef intMedID As Integer, ByRef intPatientID As Integer, ByRef intUserID As Integer, ByRef stramount As String, ByRef intDrawerID As Integer)
        Dim strbSQLcommand As New StringBuilder()
        Dim dtmAdhocTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        strbSQLcommand.Clear()
        strbSQLcommand.Append("INSERT INTO AdHocOrder(Medication_TUID,Patient_TUID,User_TUID,Amount,DrawerMedication_TUID,DateTime) ")
        strbSQLcommand.Append("VALUES('" & intMedID & "','" & intPatientID & "','" & intUserID & "','" & stramount & "','" & intDrawerID & "','" & dtmAdhocTime & "')")
        CreateDatabase.ExecuteInsertQuery(strbSQLcommand.ToString)
    End Sub

    Private Sub UpdateSystemCountForDiscrepancy(ByRef intMedID As Integer, ByRef intDrawerCount As Integer, ByRef intEnteredAmount As Integer)
        Dim intCurrentSystemCount As Integer = CreateDatabase.ExecuteScalarQuery("Select Quantity from DrawerMedication where Medication_TUID = '" & intMedID & "' and Active_Flag = '1' AND Drawers_TUID = '" & intDrawerCount & "'")
        Dim intdrawerNumber As Integer = CreateDatabase.ExecuteScalarQuery("Select Drawers_TUID from DrawerMedication where Medication_TUID = '" & intMedID & "' and Active_Flag = '1'")
        Dim intBinNumber As Integer = CreateDatabase.ExecuteScalarQuery("Select Divider_Bin from DrawerMedication where Medication_TUID = '" & intMedID & "' and Active_Flag = '1'")
        If Not intCurrentSystemCount = intEnteredAmount Then
            CreateDatabase.ExecuteInsertQuery("Update DrawerMedication SET Quantity = '" & intEnteredAmount & "' WHERE Medication_TUID = '" & intMedID & "' AND Active_Flag = '1'")
            Discrepancies.CreateDiscrepancy(intdrawerNumber, intBinNumber, intCurrentSystemCount, intEnteredAmount, CInt(LoggedInID), CInt(LoggedInID), intMedID)

            ' MessageBox.Show("Discrepancy detected and recorded")
        End If
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityToDispense.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789")

        If IsNumeric(txtQuantityToDispense.Text) Then
            GraphicalUserInterfaceReusableMethods.MaxValue(CInt(sender.Text), 1000, txtQuantityToDispense)
        End If
    End Sub
    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantityToDispense.Validated
        If IsNumeric(sender.Text) Then
            GraphicalUserInterfaceReusableMethods.MaxValue(CInt(sender.Text), 1000, txtQuantityToDispense)
        Else
            MessageBox.Show("Please make sure you enter a positive number 1-1000")
            sender.Text = "1"
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If intEnteredFromAdhoc = 0 Then
            frmPatientInfo.setPatientID(intPatientID)
            frmMain.OpenChildForm(frmPatientInfo)
        Else
            setintEntered(0)
            frmMain.OpenChildForm(frmAdHockDispense)
        End If





    End Sub

    Public Sub AdhocDispenseSetInformation(ByRef amount As String, ByRef unit As String, ByRef intDrawerMedA As Integer)
        strAmountAdhoc = amount
        strUnitAdhoc = unit
        intDrawerMEDAdhoc = intDrawerMedA
    End Sub
End Class