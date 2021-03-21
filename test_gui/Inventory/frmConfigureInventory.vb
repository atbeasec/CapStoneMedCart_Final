Public Class frmConfigureInventory

    Dim ContactPanelsAddedCount As Integer = 0
    Dim CurrentContactPanelName As String = Nothing
    Private intCurrentDrawer As Integer

    Private btnDrawerToSelectOnLoad As Button

    Public Enum InventoryEnum

        medication = 1
        divider = 2
        strength = 3
        quantity = 4

    End Enum

    Private Sub frmConfigureInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtCapacity.Enabled = False
        txtDividers.Enabled = False

        UpdateButtonsOnScreen()
        AddHandlerToDrawerButtons()

        SelectDrawer(btnDrawerToSelectOnLoad)
        'btnDrawer1.PerformClick()

        CreateToolTips(pnlHeader, tpSelectedLabelHover)
        AddHandlerToLabelClick(pnlHeader, AddressOf SortBySelectedLabel)

        ' method is going to be needed to load the capacity from the database and the number of dividers in the selected drawer
        ' we will take that data and put it into the textbox for capacity and divider.
        ' Everytime we increment that data we will send and update statement to the database
    End Sub


    '/*********************************************************************/
    '/*                   SubProgram NAME: SortBySelectedLabel            */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		          */   
    '/*		         DATE CREATED: 		 2/14/2021                        */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to be called as the click event for any label the  */
    '/*  user clicks on. Underline the label, and update the panel contents/
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*      frmPatientInfo_load                                          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 field- an integer equal to the tag value of the selected label   */ 
    '/*	 parent- a panel object that the label lives on                   */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	 BoldLabelToSortBy(sender, parent)     							  */     
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/* field- an integer equal to the tag value of the selected label
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub SortBySelectedLabel(sender As Object, e As EventArgs)

        Dim parent As Panel = sender.parent
        Dim field As Integer = CInt(sender.tag)

        BoldLabelToSortBy(sender, parent)

        'check If the user Is selecting a dispense history field to sort by
        If parent.Name = pnlHeader.Name Then

            InventorySelectedFields(field)

        End If


    End Sub


    '/*********************************************************************/
    '/*                   SubProgram NAME: InventorySelectedFields   */         
    '/*********************************************************************/
    '/*                   WRITTEN BY:  Collin Krygier   		  */   
    '/*		         DATE CREATED: 		 2/14/2021                 */                             
    '/*********************************************************************/
    '/*  Subprogram PURPOSE:								              */             
    '/*	 This is going to be called when a user selects a label to sort by*/
    '/*  the logic to re-create the panels in the order will be caled here*/
    '/*********************************************************************/
    '/*  CALLED BY:   	      						                      */           
    '/*      frmPatientInfo_load                                          */         
    '/*********************************************************************/
    '/*  CALLS:										                      */                 
    '/*                                                                   */  
    '/*********************************************************************/
    '/*  PARAMETER LIST (In Parameter Order):					          */         
    '/*	 field- an integer equal to the tag value of the selected label   */ 
    '/*********************************************************************/
    '/* SAMPLE INVOCATION:								                  */             
    '/*	 InventorySelectedFields(Cint(Label1.Tag))   	              */
    '/*********************************************************************/
    '/*  LOCAL VARIABLE LIST (Alphabetically without hungry notation):    */
    '/*	none                                                              */
    '/*********************************************************************/
    '/* MODIFICATION HISTORY:						                      */               
    '/*											                          */                     
    '/*  WHO   WHEN     WHAT								              */             
    '/*  ---   ----     ------------------------------------------------  */
    '/*  Collin Krygier  2/14/2021    Initial creation                    */
    '/*********************************************************************/
    Private Sub InventorySelectedFields(ByVal field As Integer)

        ' clear the controls as they will need to be rebuilt when sorting
        'flpPatientRecords.Controls.Clear()

        Select Case field

            Case InventoryEnum.medication

            Case InventoryEnum.divider

            Case InventoryEnum.strength

            Case InventoryEnum.quantity

        End Select

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
        Dim tpToolTip As New ToolTip

        Dim intLength As Integer = strDrugName.Length

        If intLength > 25 Then
            intLength = 25
        End If

        Dim strTuncated As String = strDrugName.Substring(0, intLength)
        ' anywhere we have quotes except for the label names, we can call our Database and get method
        'CreateIDLabel(pnlMainPanel, lblID, "lblDrugName", lblDrugName.Location.X, 20, strDrugName, getPanelCount(flpPannel))
        CreateIDLabelWithToolTip(pnlMainPanel, lblID, "lblDrugName", lblDrugName.Location.X, 20, strDrugName, getPanelCount(flpPannel), tpToolTip, strTuncated)
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

        lblDrawerNum.Text = "Drawer " & CStr(sender.tabIndex) & " Information"

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
        intCurrentDrawer = sender.TabIndex.ToString()
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

    Private Function GetSelectedDrawer() As Button

        Dim btnSelectedDrawer As Button = Nothing
        Dim ctl As Control = Nothing

        For Each ctl In pnlLayoutButtons.Controls

            If ctl.BackColor = Color.FromArgb(71, 103, 216) Then

                btnSelectedDrawer = CType(ctl, Button)

            End If

        Next

        Return btnSelectedDrawer

    End Function

    Public Sub PreviouslySelectedDrawer(ByVal btnUserSelectedDrawer As Button)

        btnDrawerToSelectOnLoad = btnUserSelectedDrawer

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

            If intDrugQuantity = 0 Then
                ' the drawer is empty. Do nothing
            Else
                'based on the selected drawer we will need to call the database to see what medications are in the drawers
                CreatePanel(flpMedication, strDrugName, intDividerBin, intStrength.ToString(), intDrugQuantity.ToString())
            End If
        Next
        Dim size As Integer = CreateDatabase.ExecuteScalarQuery("SELECT Size FROM Drawers where Drawers_ID = " & sender.TabIndex.ToString() & ";")
        txtCapacity.Text = size
        Dim dividers As Integer = CreateDatabase.ExecuteScalarQuery("SELECT Number_of_Dividers FROM Drawers where Drawers_ID = " & sender.TabIndex.ToString() & ";")
        txtDividers.Text = dividers

        'MessageBox.Show(strDrugName + " " + intStrength.ToString() + "   " + intDividerBin.ToString() + " In drawer number: " + sender.TabIndex.ToString())


        ' We will next need to use the method to create a panel and populate the labels with text from the database returned items



    End Sub
    Private Sub btnAddtoDrawer_Click(sender As Object, e As EventArgs) Handles btnAddToDrawer.Click

        ' pass the name of thecurrently selected drawer the user is looking at
        frmInventory.SetSelectedDrawer(GetSelectedDrawer)

        ' open the inventory form
        frmMain.OpenChildForm(frmInventory)


    End Sub

    Private Sub SelectDrawer(ByVal btnDrawerToSelect As Button)


        'check if there is an object to pass. If its null, then we know this is the first time the page is being loaded
        'there wouldnt be a previous button in that case
        If IsDBNull(btnDrawerToSelect) Or btnDrawerToSelect Is Nothing Then
            ' set Drawer 1 as the default Drawer to Select
            btnDrawer1.PerformClick()
        Else

            Dim ctl As Control
            Dim btnSelect As Button

            ' select the drawer that was previously selected by checking which button as that name,
            ' the performing a click event. Cant simply call btnDrawerToSelect.PerformClick() because the reference to this
            ' button was deleted when frmConfigureInventory was originally closed.

            For Each ctl In pnlLayoutButtons.Controls
                If ctl.Name = btnDrawerToSelect.Name Then
                    btnSelect = CType(ctl, Button)
                    btnSelect.PerformClick()
                End If
            Next
        End If

    End Sub

    Private Sub btnIncrementCapacity_Click(sender As Object, e As EventArgs) Handles btnIncrementCapacity.Click

        ButtonIncrement(8, txtCapacity)

    End Sub

    Private Sub btnIncrementDividers_Click(sender As Object, e As EventArgs) Handles btnIncrementDividers.Click

        ButtonIncrement(5, txtDividers)

    End Sub

    Private Sub btnDecrementCapacity_Click(sender As Object, e As EventArgs) Handles btnDecrementCapacity.Click

        ButtonDecrement(txtCapacity)

    End Sub

    Private Sub btnDecrementDividers_Click(sender As Object, e As EventArgs) Handles btnDecrementDividers.Click

        ButtonDecrement(txtDividers)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' call code here to update the database with the txtCapacity and txtDividers information about the drawer.
        ExecuteScalarQuery("UPDATE Drawers SET Number_of_Dividers = " & CInt(txtDividers.Text) & ", Size = " & CInt(txtCapacity.Text) & "  WHERE Drawers_ID  = " & intCurrentDrawer & ";")
        Me.Refresh()
    End Sub
End Class