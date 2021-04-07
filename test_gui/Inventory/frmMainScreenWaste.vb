Public Class frmMainScreenWaste
    Public intPatientIDArray As New ArrayList
    Private intNarcoticFlagGlobal As Integer
    Private intMedID As Integer
    Private intSignoffID As Integer

    Private Sub frmMainScreenWaste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'clear patientname listbox
        cmbPatientName.Items.Clear()
        intPatientIDArray.Clear()
        'get patient name, first, last, and MRN number
        'MRN is appended on too the end currently because search just based on name will not work
        ' if system has multiple patients with the same name
        Dim Strdatacommand As String
        Strdatacommand = "SELECT Patient_First_Name, Patient_Last_Name, MRN_Number, Patient_ID FROM Patient WHERE Active_Flag = 1 Order By Patient_Last_Name COLLATE NOCASE, Patient_First_Name COLLATE NOCASE"

        'call sql method
        Dim dsPatientRecords As DataSet = New DataSet
        dsPatientRecords = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

        'place all patients into list box
        For Each dr As DataRow In dsPatientRecords.Tables(0).Rows
            If IsDBNull(dr(0)) Then

            Else
                cmbPatientName.Items.Add(dr(1) & ", " & dr(0) & "  MRN:" & dr(2))
                intPatientIDArray.Add(dr(3))
            End If

        Next
        Dim Strdatacommand2 As String
        intMedIDArray.Clear()
        ' Currently the medication display is appending the RXCUI Number on too the medication
        ' name, as searching by name alone could cause problems if medication names can repeat
        Strdatacommand2 = "Select trim(Drug_Name,' '), RXCUI_ID, Medication_ID,DrawerMedication_ID FROM Medication INNER JOIN DrawerMedication ON DrawerMedication.Medication_TUID = Medication.Medication_ID WHERE DrawerMedication.Active_Flag = 1 ORDER BY Medication.Drug_Name COLLATE NOCASE ASC"

        Dim dsMedicationDataSet As DataSet = New DataSet
        dsMedicationDataSet = CreateDatabase.ExecuteSelectQuery(Strdatacommand2)
        'add medication name and RXCUI to listbox
        For Each dr As DataRow In dsMedicationDataSet.Tables(0).Rows
            cmbMedications.Items.Add(dr(0) & " RXCUI: " & dr(1))
            intMedIDArray.Add(dr(2))
            intDrawerMedArray.Add(dr(3))
        Next

        pnlCredentials.Visible = False
    End Sub

    Private Sub cmbPatientName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPatientName.SelectedIndexChanged
        If Not cmbPatientName.SelectedIndex = -1 Then
            'local variables for splitting array and holding patient ID
            Dim intPatientID As Integer

            'clear textboxes so no overlapping data
            txtDateOfBirth.Clear()
            txtMRN.Clear()

            intPatientID = intPatientIDArray(cmbPatientName.SelectedIndex)
            'create sql command string
            Dim Strdatacommand As String
            Strdatacommand = "SELECT Date_of_Birth, MRN_Number from Patient Where Patient_ID = '" & intPatientID & "'"

            'create dataset and call sql method
            Dim dsPatientRecords As DataSet = New DataSet
            dsPatientRecords = CreateDatabase.ExecuteSelectQuery(Strdatacommand)
            'set patient properties in textboxes
            txtDateOfBirth.Text = dsPatientRecords.Tables(0).Rows(0)(0)
            txtMRN.Text = dsPatientRecords.Tables(0).Rows(0)(1)
            'get patient allergies
            Strdatacommand = "SELECT Allergy_Name From PatientAllergy Where Patient_TUID = '" & intPatientID & "'"
            dsPatientRecords = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

            Dim dsRoomBed As DataSet = CreateDatabase.ExecuteSelectQuery("Select * from PatientRoom where Patient_TUID = '" & intPatientID & "'")
            txtRoomBed.Text = "Room: " & dsRoomBed.Tables(0).Rows(0)(1) & "  Bed: " & dsRoomBed.Tables(0).Rows(0)(2)
        End If
    End Sub

    Private Sub cmbMedications_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMedications.SelectedIndexChanged
        If Not cmbMedications.SelectedIndex = -1 Then
            'clear the textboxes
            sender.text = ""
            txtDrawerBin.Clear()

            'get selected medication ID using the selected index and get the same index from medID array
            Dim intMedID As Integer = intMedIDArray(cmbMedications.SelectedIndex)
            Dim intDrawerMEDID As Integer = intDrawerMedArray(cmbMedications.SelectedIndex)
            'select medication type and strength for the selected medication using MEDid 
            Dim Strdatacommand As String
            Strdatacommand = "SELECT Medication.Type,Medication.Strength,Drawers.Drawer_Number,DrawerMedication.Divider_Bin, DrawerMedication.Amount_Per_Container_Unit From Medication
                                Inner Join DrawerMedication ON DrawerMedication.Medication_TUID = Medication.Medication_ID
                                INNER JOIN Drawers ON Drawers.Drawers_ID = DrawerMedication.Drawers_TUID
                                WHERE Medication.Medication_ID = '" & intMedID & "' AND DrawerMedication.DrawerMedication_ID = '" & intDrawerMEDID & "' AND Medication.Active_Flag = '1' and DrawerMedication.Active_Flag = '1'"

            'make dataset and call the sql method
            Dim dsMedicationInformation As DataSet = New DataSet
            dsMedicationInformation = CreateDatabase.ExecuteSelectQuery(Strdatacommand)

            txtDrawerBin.Text = "Drawer number: " & (dsMedicationInformation.Tables(0).Rows(0)(2)) & " Bin number: " & (dsMedicationInformation.Tables(0).Rows(0)(3))
            txtUnit.Text = dsMedicationInformation.Tables(0).Rows(0)(4)

            Strdatacommand = "Select Controlled_Flag from Medication where Medication_ID = '" & intMedID & "' and Active_Flag = '1'"
            Dim intNarcoticFlag As Integer = CreateDatabase.ExecuteScalarQuery(Strdatacommand)
            intNarcoticFlagGlobal = intNarcoticFlag
            If intNarcoticFlag = 1 Then
                txtBarcode.Visible = True
                pnlSignOff.Visible = True
            ElseIf intNarcoticFlag = 0 Then
                txtBarcode.Visible = False
                pnlSignOff.Visible = False
            End If
        End If
    End Sub

    Private Sub rbtnOther_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOther.CheckedChanged
        pnlSignOff.Location = New Point(3, 286)
    End Sub

    Private Sub radPatientUnavilable_CheckedChanged(sender As Object, e As EventArgs) Handles radPatientUnavilable.CheckedChanged
        pnlSignOff.Location = New Point(3, 158)
    End Sub

    Private Sub radRefused_CheckedChanged(sender As Object, e As EventArgs) Handles radRefused.CheckedChanged
        pnlSignOff.Location = New Point(3, 158)
    End Sub

    Private Sub radCancel_CheckedChanged(sender As Object, e As EventArgs) Handles radCancel.CheckedChanged
        pnlSignOff.Location = New Point(3, 158)
    End Sub

    Private Sub radIncorrect_CheckedChanged(sender As Object, e As EventArgs) Handles radIncorrect.CheckedChanged
        pnlSignOff.Location = New Point(3, 158)
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789.")
    End Sub

    Private Sub txtUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnit.KeyPress
        DataVaildationMethods.KeyPressCheck(e, "0123456789.abcdefghijklmnopqrstuvwxyz /-")
    End Sub

    Private Sub btnWaste_Click(sender As Object, e As EventArgs) Handles btnWaste.Click
        If txtQuantity.Text = Nothing Or txtQuantity.Text.Trim.Length = 0 Or cmbMedications.SelectedIndex = -1 Or cmbPatientName.SelectedIndex = -1 Then
            MessageBox.Show("Please select a medication and patient, then fill out the amount wasted.")
        Else
            If intNarcoticFlagGlobal = 0 Then
                Dim strReason As String = " "
                Dim dtmWasteTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                If radIncorrect.Checked = True Then
                    strReason = radIncorrect.Text

                ElseIf radCancel.Checked = True Then
                    strReason = radCancel.Text

                ElseIf radRefused.Checked = True Then
                    strReason = radRefused.Text

                ElseIf radPatientUnavilable.Checked = True Then
                    strReason = radPatientUnavilable.Text

                ElseIf rbtnOther.Checked = True Then
                    strReason = txtOther.Text
                End If
                frmWaste.insertWaste(CInt(LoggedInID), CInt(LoggedInID), intDrawerMedArray(cmbMedications.SelectedIndex), intMedIDArray(cmbMedications.SelectedIndex), intPatientIDArray(cmbPatientName.SelectedIndex), strReason, txtQuantity.Text, dtmWasteTime)
                MessageBox.Show("Waste information saved.")
                ClearWaste()
            ElseIf intNarcoticFlagGlobal = 1 Then
                CheckBarcode(txtBarcode.Text)
            End If
        End If
    End Sub

    Private Sub CheckBarcode(ByRef strBarcode As String)
        If strBarcode = "" Then
            MessageBox.Show("           WARNING" & vbCrLf & "Barcode Field is Blank")
            txtBarcode.Focus()

        ElseIf scanBarcode(strBarcode) = "True" Then
            Dim strReason As String = " "
            Dim dtmWasteTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            If radIncorrect.Checked = True Then
                strReason = radIncorrect.Text

            ElseIf radCancel.Checked = True Then
                strReason = radCancel.Text

            ElseIf radRefused.Checked = True Then
                strReason = radRefused.Text

            ElseIf radPatientUnavilable.Checked = True Then
                strReason = radPatientUnavilable.Text

            ElseIf rbtnOther.Checked = True Then
                strReason = txtOther.Text
            End If
            frmWaste.insertWaste(CInt(LoggedInID), intSignoffID, intDrawerMedArray(cmbMedications.SelectedIndex), intMedIDArray(cmbMedications.SelectedIndex), intPatientIDArray(cmbPatientName.SelectedIndex), strReason, txtQuantity.Text, dtmWasteTime)
            MessageBox.Show("Waste information saved.")
            ClearWaste()
        Else
            MessageBox.Show("The barcode does not match any users.")
            txtBarcode.Focus()
        End If
    End Sub


    Private Function scanBarcode(ByRef strBarcode As String)
        Dim strHashedBarcode = ConvertBarcodePepperAndHash(strBarcode)
        If ExecuteScalarQuery("SELECT COUNT(*) FROM User WHERE Barcode = '" & strHashedBarcode & "'" & " AND Active_Flag = '1'") <> 0 Then
            intSignoffID = ExecuteScalarQuery("SELECT User_ID FROM User WHERE Barcode = '" & strHashedBarcode & "'")
            Return "True"
        Else
            Return "False"
        End If
    End Function


    Private Sub ClearWaste()
        cmbMedications.SelectedIndex = -1
        cmbPatientName.SelectedIndex = -1
        txtQuantity.Text = Nothing
        txtDateOfBirth.Text = Nothing
        txtBarcode.Text = Nothing
        txtDateOfBirth.Text = Nothing
        txtMRN.Text = Nothing
        txtUnit.Text = Nothing
        txtRoomBed.Text = Nothing
        txtDrawerBin.Text = Nothing
        txtOther.Text = Nothing
    End Sub

    Private Sub lblBadge_Click(sender As Object, e As EventArgs) Handles lblBadge.Click

        If pnlBarcode.Visible = True Then
            pnlBarcode.Visible = False
            txtBarcode.Text = Nothing
            pnlCredentials.Visible = True
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblUseBarcode.Click

        If pnlCredentials.Visible = True Then

            pnlCredentials.Visible = False
            txtUsername.Text = Nothing
            txtPassword.Text = Nothing
            pnlBarcode.Visible = True

        End If

    End Sub
End Class