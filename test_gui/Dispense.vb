Public Class Dispense

    Dim contactPanelsAddedCount As Integer = 0
    Dim currentContactPanelName As String = Nothing

    Private Sub btnDispense_Click(sender As Object, e As EventArgs)

        MessageBox.Show("CAUTION: This drug interacts with (insert drug name here) that the patient is currently taking. Or the patient is allergic to this drug")
        frmWitnessSignOff.Show()
        ' call emthod to open serial port connection and open drawer

    End Sub

    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal genericName As String, ByVal brandName As String, ByVal quantity As String, ByVal lastRefill As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(665, 47)
            .Name = "pnlIndividualPatientRecordPadding" + (contactPanelsAddedCount + 1).ToString
            .Tag = contactPanelsAddedCount + 1
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(665, 45)
            .Name = "pnlIndividualPatientRecord" + (contactPanelsAddedCount + 1).ToString
            .Tag = contactPanelsAddedCount + 1
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)

        ' add controls to this panel

        '  CreateContactDeleteBtn(pnlMainPanel)
        ' CreateEditButton(pnlMainPanel)

        ' call database info here to populate
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Dim lblID6 As New Label

        Dim location As New Point(10, 20)
        Dim location2 As New Point(95, 20)
        Dim location3 As New Point(220, 20)
        Dim location4 As New Point(320, 20)
        Dim location5 As New Point(395, 20)
        Dim location6 As New Point(500, 20)

        CreateIDLabel(pnlMainPanel, lblID, "lblGenericName", 10, 20, genericName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblBrandName", 230, 20, brandName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblQuantity", 440, 20, quantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblMeasure", 560, 20, lastRefill, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)
        'flpCamera.Controls.Add(contactPanel)
        'Update panel variables
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        currentContactPanelName = pnl.Name
        contactPanelsAddedCount += 1

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

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub flpAssignedMedications_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub AllergiesExist()

        'If allergies exist show the allergies panel and move the other panel over to specific location

    End Sub

    Private Sub lstboxAllergies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxAllergies.SelectedIndexChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

        Dim strAnswer As MsgBoxResult = MsgBox(" Are you sure you want to close this form? ", MsgBoxStyle.YesNo, "Confirm ")


        If strAnswer = MsgBoxResult.Yes Then
            Me.Close()
        Else

        End If

    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        ButtonIncrement(txtQuantity)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        ButtonDecrement(txtQuantity)
    End Sub

    Private Sub btnDispense_Click_1(sender As Object, e As EventArgs) Handles btnDispense.Click
        MessageBox.Show("Drawer Has Opened")
    End Sub
End Class