Public Class frmConfigureInventory

    Dim ContactPanelsAddedCount As Integer = 0
    Dim CurrentContactPanelName As String = Nothing


    Private Sub frmConfigureInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtCapacity.Enabled = False
        txtDividers.Enabled = False

        UpdateButtonsOnScreen()
        AddHandlerToDrawerButtons()
        PopulateInventory()

        btnDrawer1.PerformClick()

        ' method is going to be needed to load the capacity from the database and the number of dividers in the selected drawer
        ' we will take that data and put it into the textbox for capacity and divider.
        ' Everytime we increment that data we will send and update statement to the database
    End Sub

    Private Sub CreateDrawers(sender As Object, e As EventArgs)

    End Sub


    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal strDrugName As String, ByVal strDividerBin As String, ByVal strStrength As String, ByVal strQuantity As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(670, 47)
            .Name = "pnlMedicationRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(670, 45)
            .Name = "pnlMedicationRecord" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)


        'AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClickNewOrder
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        ' add controls to this panel
        CreateEditButton(pnlMainPanel, getPanelCount(flpPannel), lblActions.Location.X, 5)
        CreateDeleteBtn(pnlMainPanel, getPanelCount(flpPannel), lblActions.Location.X + 40, 5)

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
        CreateIDLabel(pnlMainPanel, lblID, "lblDrugName", lblDrugName.Location.X, 20, strDrugName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblDivider", lblDivider.Location.X, 20, strDividerBin, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblStrength", lblStrength.Location.X, 20, strStrength, getPanelCount(flpPannel))
        'CreateIDLabel(pnlMainPanel, lblID3, "lblType", 220, 20, strType, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblQuantity", lblQuantity.Location.X, 20, strQuantity, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub


    ' Private Sub btnMedications_Click(sender As Object, e As EventArgs) Handles btnMedications.Click
    '   frmNewInventory.Show()
    'CreatePanel(flpMedication)

    ' End Sub

    Private Sub UpdateDrawerLabel(sender As Object, e As EventArgs)

        lblDrawerNumber.Text = CStr(sender.tabIndex)

    End Sub

    Private Sub UpdateButtonsOnScreen()

        'aray used to throw temporary data here for dumping. only for prototype purposes
        Dim arrQuantity As Integer() = {6, 7, 5, 78, 7, 8, 8, 9, 12, 144, 34, 55, 23, 67, 8, 67, 12, 34, 5, 65, 87, 43, 65, 21, 59}

        Dim tp As New ToolTip

        Dim count As Integer = 0



        For Each ctl In pnlLayoutButtons.Controls

            'Dim lbl As New Label

            'With lbl
            '    .Name = "lblStatus" & count
            'End With


            'Dim lblItemQuantity As New Label

            'With lblItemQuantity
            '    .Name = "lblItemQuantity" & count
            'End With


            If TypeName(ctl) = "Button" Then

                Dim btn As Button = CType(ctl, Button)


                ' this would be concated with a search on the database looking at the drawer number
                btn.Text = CStr("#" & ctl.tabIndex)

                ' here we need to check if any of the medications in the drawer are close to being empty.
                ' if so, then we will make the drawer appear red. Remember that each drawer can hold
                ' multiple medications.

                If arrQuantity(count) < 5 Then

                    btn.BackColor = Color.Red
                    tp.SetToolTip(btn, "Less than 5 items remain in this drawer")
                    'add btn tool tip when hover


                    'With lbl
                    '    ' location for all the full labels based on the current buttonsize we can dynmaically create labels... why?
                    '    ' well since we are putting labels on the button it is possible if the user selects the label they will not be selecting the button
                    '    ' obviuosly we want the label to function like an extension of the button so we may need to assign button handlers to the labels to ensure
                    '    ' the function properly so there is no difference between clicking the button, and clicking the label on top of the button.

                    '    .Location = New Point(btn.Location.X + 19, btn.Location.Y + 62)
                    '    .Text = "Empty"
                    '    .Font = New Font(New FontFamily("Segoe UI"), 9, FontStyle.Regular)
                    '    .BackColor = Color.Gainsboro

                    'End With

                    'With lblItemQuantity

                    '    .Location = New Point(btn.Location.X + 32, btn.Location.Y + 36)
                    '    .Text = CStr(arrQuantity(count))
                    '    .Font = New Font(New FontFamily("Segoe UI"), 9, FontStyle.Regular)
                    '    .BackColor = Color.Gainsboro
                    '    .ForeColor = Color.Black
                    '    .BringToFront()

                    'End With
                    'pnlLayoutButtons.Controls.Add(lbl)
                    'pnlLayoutButtons.Controls.Add(lblItemQuantity)

                Else


                    'With lbl
                    '    ' location for all the full labels based on the current buttonsize we can dynmaically create labels... why?
                    '    ' well since we are putting labels on the button it is possible if the user selects the label they will not be selecting the button
                    '    ' obviuosly we want the label to function like an extension of the button so we may need to assign button handlers to the labels to ensure
                    '    ' the function properly so there is no difference between clicking the button, and clicking the label on top of the button.

                    '    .Location = New Point(btn.Location.X + 26, btn.Location.Y + 62)
                    '    .Text = "Full"
                    '    .Font = New Font(New FontFamily("Segoe UI"), 9, FontStyle.Regular)
                    '    .BackColor = Color.Gainsboro

                    'End With


                    'With lblItemQuantity

                    '    .Location = New Point(btn.Location.X + 32, btn.Location.Y + 36)
                    '    .Text = CStr(arrQuantity(count))
                    '    .Font = New Font(New FontFamily("Segoe UI"), 9, FontStyle.Regular)
                    '    .BackColor = Color.Gainsboro

                    'End With

                End If

                ' adding the handle to allow the drawer label to update based on the drawer we select

                AddHandler btn.Click, AddressOf UpdateDrawerLabel
                AddHandler btn.Click, AddressOf UpdateScreenWithMedicationsInSelectedDrawer

                count += 1

            End If



        Next
    End Sub

    Private Sub AddHandlerToDrawerButtons()

        Dim btnSingle As Button

        For Each ctlControl In pnlLayoutButtons.Controls

            If TypeName(ctlControl) = "Button" Then

                btnSingle = CType(ctlControl, Button)

                AddHandler btnSingle.Click, AddressOf HighlightSelectedDrawer

            End If
        Next


    End Sub


    Private Sub HighlightSelectedDrawer(sender As Object, e As EventArgs)

        Dim btn As Control

        For Each btn In pnlLayoutButtons.Controls

            If sender.Name = btn.Name Then

                If sender.backColor = Color.Gainsboro Then

                    sender.ForeColor = Color.White
                    sender.backColor = Color.FromArgb(71, 103, 216)

                End If
            Else

                btn.BackColor = Color.Gainsboro
                btn.ForeColor = Color.Black

            End If

        Next

    End Sub

    Private Sub UpdateScreenWithMedicationsInSelectedDrawer(sender As Button, e As EventArgs) Handles btnDrawer1.Click
        flpMedication.Controls.Clear()
        Dim strDrugName As String = ""
        Dim intStrength As String = ""
        Dim intDividerBin As Integer = 0
        Dim intDrawerSize As Integer = 0
        Dim intDrugQuantity As Integer = 0
        Dim dsDrawerContents As DataSet = GetDrawerDrugs(sender.TabIndex)
        For Each dr As DataRow In dsDrawerContents.Tables(0).Rows
            strDrugName = dr(0)
            intStrength = dr(1)
            intDrugQuantity = CInt(dr(2))
            intDividerBin = dr(3)

        Next
        Dim size As Integer = CreateDatabase.ExecuteScalarQuery("SELECT Size FROM Drawers where Drawers_ID = " & sender.TabIndex.ToString() & ";")
        txtCapacity.Text = size
        Dim dividers As Integer = CreateDatabase.ExecuteScalarQuery("SELECT Number_of_Dividers FROM Drawers where Drawers_ID = " & sender.TabIndex.ToString() & ";")
        txtDividers.Text = dividers
        If intDrugQuantity = 0 Then
            ' the drawer is empty. Do nothing
        Else
            'based on the selected drawer we will need to call the database to see what medications are in the drawers
            CreatePanel(flpMedication, strDrugName, intDividerBin, intStrength.ToString(), intDrugQuantity.ToString())
        End If
        'MessageBox.Show(strDrugName + " " + intStrength.ToString() + "   " + intDividerBin.ToString() + " In drawer number: " + sender.TabIndex.ToString())


        ' We will next need to use the method to create a panel and populate the labels with text from the database returned items



    End Sub
    Private Sub btnAddtoDrawer_Click(sender As Object, e As EventArgs) Handles btnAddToDrawer.Click

        'call new form to show inventory. already coded somewhere
        frmMain.OpenChildForm(frmInventory)
        'frmInventory.Show()
        ' NewNurse.Show()
        'frmImport.Show()
        'frmChangePassword.Show()


    End Sub

    Private Sub btnIncrementCapacity_Click(sender As Object, e As EventArgs) Handles btnIncrementCapacity.Click

        ButtonIncrement(txtCapacity)

    End Sub

    Private Sub btnIncrementDividers_Click(sender As Object, e As EventArgs) Handles btnIncrementDividers.Click

        ButtonIncrement(txtDividers)

    End Sub

    Private Sub btnDecrementCapacity_Click(sender As Object, e As EventArgs) Handles btnDecrementCapacity.Click

        ButtonDecrement(txtCapacity)

    End Sub

    Private Sub btnDecrementDividers_Click(sender As Object, e As EventArgs) Handles btnDecrementDividers.Click

        ButtonDecrement(txtDividers)

    End Sub

    Private Sub Label38_Click(sender As Object, e As EventArgs) Handles lblStrength.Click

    End Sub

End Class