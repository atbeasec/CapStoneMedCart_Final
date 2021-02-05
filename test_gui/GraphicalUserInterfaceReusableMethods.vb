Module GraphicalUserInterfaceReusableMethods

    'Method that allows for highlighting when hovering over panels. has two parts
    'part 1

    Public Sub MouseEnterPanelSetBackGroundColor(Sender As Object, e As EventArgs)

        'changes the background color when the mouse is hovered over the panel
        If Not Sender.backcolor = Color.Red Then

            If Sender.backColor = Color.White Then
                Sender.backColor = Color.Gainsboro

            Else

                Sender.backcolor = Color.White
            End If

        End If



    End Sub

    'part 2
    Public Sub MouseLeavePanelSetBackGroundColorToDefault(sender As Object, e As EventArgs)

        ' checking if the background color is set to the highlighted color
        'if it is not then we will set it.
        If Not sender.backcolor = Color.Red Then
            If sender.backColor = Color.Gainsboro Then

                sender.backColor = Color.White

            Else

                sender.backcolor = Color.Gainsboro
            End If
        End If


    End Sub

    'Add new  delete button to contact panel
    Public Sub RestDefaultButtons(ByVal sender As Object, ByVal e As EventArgs)

        Dim intTemp As Integer = 1

        Dim ctlControl As Control

        For Each ctlControl In sender.Parent.Controls

            If TypeName(ctlControl) = "Button" Then

                If Not ctlControl.Name.Contains("Cancel") Or ctlControl.Name.Contains("Check") Then
                    ' for any controls that are not the check mark or red x, we will make them visible

                    ctlControl.Visible = True

                Else
                    'even though we hide the other controls, once we select the delete button once, we are hiding all of the other icons
                    ' there fore we do not need to recreate them we can simply hide or unhide them
                    ' in this case we will set the visibility to false because they are controls that we need to hide.

                    ctlControl.Visible = False

                End If
            End If
        Next



    End Sub


    Public Sub ShowConfirmationButtons(ByVal sender As Object, ByVal e As EventArgs)

        'call methods here to show the checkmark buttons when the item is clicked


        ' hide the sender which is the trash can icon
        sender.Visible = False

        Debug.Print(sender.Location.X.ToString)
        Debug.Print(sender.Location.Y.ToString)

        'put the check mark where the trash can icon was
        ' CreateCheckMarkBtn(sender.parent, New Point(sender.Location.X, sender.Location.Y))

        CreateXMarkBtn(sender.parent, New Point(sender.Location.X, sender.Location.Y))

        'put the x icon where the edit button was. We need to find the location of the edit Button.
        Dim ctlControl As Control

        For Each ctlControl In sender.Parent.Controls

            If TypeName(ctlControl) = "Button" Then
                If ctlControl.Name.Contains("Edit") Then

                    Debug.Print(ctlControl.Name)

                    'hide the control
                    ctlControl.Visible = False

                    ' get the location and put the x in that location
                    ' CreateXMarkBtn(sender.Parent, New Point(ctlControl.Location.X, ctlControl.Location.Y))
                    CreateCheckMarkBtn(sender.Parent, New Point(ctlControl.Location.X, ctlControl.Location.Y))
                End If
            End If
        Next



    End Sub

    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        'the parent of the button will be the panel the control is located on.
        'we want to get one step removed so we need to next take the parent of the control
        ' to get the name of flowpanel which the button is laid out on
        Dim ctlControl As Control = sender.Parent
        Dim ctlParents As Control = ctlControl.Parent



        Dim ctlParentFlowPanel As Control = ctlControl.Parent
        Dim strParentPanelName As String
        strParentPanelName = Nothing

        'Remove handler from sender
        For Each ctlObject As Control In ctlParentFlowPanel.Controls
            For Each ctlChildControlObj As Control In ctlObject.Controls
                If ctlChildControlObj.Name = sender.name Then

                    RemoveHandler ctlChildControlObj.Click, AddressOf DynamicButton_Click

                    strParentPanelName = ctlChildControlObj.Parent.Name
                End If
            Next
        Next



        'Remove  panel
        For Each ctlObject As Control In ctlParentFlowPanel.Controls
            If ctlObject.Name = strParentPanelName Then

                ' prompt user if they are sure they want to delete the record
                ' remove the record from the database
                'remove the padding panel from the flow panel
                ctlParentFlowPanel.Controls.Remove(ctlObject.Parent)
                ctlObject.Parent.Dispose()

                'remove the panel from the flow panel
                ctlParentFlowPanel.Controls.Remove(ctlObject)
                ctlObject.Dispose()

            End If
        Next

        'parents.Name
        ' Dim connn As Control = parentFlowPanel.Parent
        'Debug.Print(connn.Name)
        'Debug.Print(parentFlowPanel.Name)
        'UpdateCamerasSubtotalLabel(parentFlowPanel)

    End Sub

    Public Sub DynamicButtonEditRecord_Click(ByVal sender As Object, ByVal e As EventArgs)

        'show the add new patient form filled in with the patients infromation
        'frmUpdatePatient.Show()
        ' frmPatientInfo.Show()
    End Sub


    Public Sub CreateIDLabel(ByVal pnlName As Panel, lblName As Label, strLabelName As String, x As Integer, y As Integer, strLabelText As String, ByVal intPanelsAddedCount As Integer)

        ' Dim lblID As Label
        'lblName = New Label
        'location = New Point
        'declare our image and point at the resource

        'Set button properties
        With lblName
            .AutoSize = True
            '.Size = New Size(30, 30)

            .FlatStyle = FlatStyle.Flat
            ' .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Black
            .Font = New Font(New FontFamily("Segoe UI"), 11, FontStyle.Regular)
            .Location = New Point(x, y) 'new Point(600, 5)
            .Name = strLabelName + (intPanelsAddedCount).ToString
            .Text = strLabelText
            .Tag = intPanelsAddedCount + 1
        End With


        pnlName.Controls.Add(lblName)

    End Sub

    Public Sub DynamicRemoveHandlerFromSender(ByVal sender As Object, ByVal e As EventArgs)

        'the parent of the button will be the panel the control is located on.
        'we want to get one step removed so we need to next take the parent of the control
        ' to get the name of flowpanel which the button is laid out on
        Dim ctlControl As Control = sender.Parent
        Dim ctlParents As Control = ctlControl.Parent
        Dim ctlParentFlowPanel As Control = ctlControl.Parent
        Dim strParentPanelName As String
        strParentPanelName = Nothing

        'Remove handler from sender
        For Each ctlControlObj As Control In ctlParentFlowPanel.Controls
            For Each ctlChildControlObj As Control In ctlControlObj.Controls
                If ctlChildControlObj.Name = sender.name Then

                    RemoveHandler ctlChildControlObj.Click, AddressOf DynamicButton_Click
                    strParentPanelName = ctlChildControlObj.Parent.Name

                End If
            Next
        Next

    End Sub

    'Add new  delete button to contact panel
    Public Sub CreateDeleteBtn(ByVal pnlPanelName As Panel, ByVal intPanelsAddedCount As Integer, ByVal intX As Integer, ByVal intY As Integer)

        Dim btnDeleteButton As Button
        btnDeleteButton = New Button
        'declare our image and point at the resource
        Dim mapImageTrash As New Bitmap(New Bitmap(My.Resources.icons8_delete_trash), 25, 25)

        'Set button properties
        With btnDeleteButton
            .AutoSize = True
            .Size = New Size(30, 30)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(intX, intY)
            .Name = "btnDeletePatientRecord" + (intPanelsAddedCount).ToString
            .Image = mapImageTrash
            .ImageAlign = ContentAlignment.MiddleCenter
            .Tag = intPanelsAddedCount + 1
        End With

        pnlPanelName.Controls.Add(btnDeleteButton)

        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnDeleteButton.Click, AddressOf ShowConfirmationButtons

    End Sub

    Public Sub CreateFlagBtn(ByVal pnlPanelName As Panel, ByVal intPanelsAddedCount As Integer, ByVal intX As Integer, ByVal intY As Integer)

        Dim btnFlagMedication As Button
        btnFlagMedication = New Button
        'declare our image and point at the resource
        Dim mapImageTrash As New Bitmap(New Bitmap(My.Resources.flag_black_25px), 25, 25)

        'Set button properties
        With btnFlagMedication
            .AutoSize = True
            .Size = New Size(30, 30)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(intX, intY)
            .Name = "btnFlagMedication" + (intPanelsAddedCount).ToString
            .Image = mapImageTrash
            .ImageAlign = ContentAlignment.MiddleCenter
            .Tag = intPanelsAddedCount + 1
            .TabStop = False
        End With

        pnlPanelName.Controls.Add(btnFlagMedication)

        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnFlagMedication.Click, AddressOf DynamicFlagMedicationButton

    End Sub
    Public Sub DynamicFlagMedicationButton(sender As Object, ByVal e As EventArgs)

        Dim pnlFlaggedPannel As Panel
        pnlFlaggedPannel = CType(sender.parent, Panel)
        Debug.Print(pnlFlaggedPannel.Name)

        If Not pnlFlaggedPannel.BackColor = Color.Red Then
            pnlFlaggedPannel.BackColor = Color.Red
        Else
            pnlFlaggedPannel.BackColor = Color.White
        End If
        'functionality will be assigned here

        ' take the panel which this button lives on and highlight it differently



    End Sub

    Public Sub CreateTextBox(ByVal pnlPanelName As Panel, ByVal intPanelsAddedCount As Integer, ByVal intX As Integer, ByVal intY As Integer)

        Dim txtCount As TextBox
        txtCount = New TextBox

        'Set button properties
        With txtCount
            .AutoSize = True
            .BorderStyle = BorderStyle.FixedSingle
            .Size = New Size(45, 30)
            .ForeColor = Color.Black
            .Font = New Font(New FontFamily("Segoe UI"), 11)
            ' .Location = New Point(  )
            .Location = New Point(intX, intY)
            .Name = "txtCount" + (intPanelsAddedCount).ToString
            .Tag = intPanelsAddedCount + 1
            .MaxLength = 2
            ' .Dock = DockStyle.Fill

        End With

        pnlPanelName.Controls.Add(txtCount)

        ' MessageBox.Show("again")
        'Add handler for click events
        'assing functionality here

        'AddHandler btnFlagMedication.Click, AddressOf DynamicFlagMedicationButton

    End Sub


    Public Sub CreateEditButton(ByVal pnlPanelName As Panel, ByVal pnlPanelsAddedCount As Integer, ByVal intX As Integer, ByVal intY As Integer)

        Dim btnEditButton As Button
        btnEditButton = New Button
        'declare our image and point at the resource
        Dim mapImagePencil As New Bitmap(New Bitmap(My.Resources.icons8_pencil), 25, 25)

        'Set button properties
        With btnEditButton
            .AutoSize = True
            .Size = New Size(30, 30)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            '.Location = New Point(825, 5)
            .Location = New Point(intX, intY)
            .Name = "btnEditPatientRecord" + (pnlPanelsAddedCount).ToString
            .Image = mapImagePencil
            .ImageAlign = ContentAlignment.MiddleCenter
            .Tag = pnlPanelsAddedCount + 1
        End With

        Debug.Print(pnlPanelName.Name)
        pnlPanelName.Controls.Add(btnEditButton)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnEditButton.Click, AddressOf DynamicButtonEditRecord_Click

    End Sub

    Public Sub CreateCheckMarkBtn(ByVal pnlPanelName As Panel, ByVal pntLocation As Point)

        Dim btnCheckMark As Button
        btnCheckMark = New Button
        'declare our image and point at the resource
        Dim mapImageTrash As New Bitmap(New Bitmap(My.Resources.checkmark), 25, 25)

        'Set button properties
        With btnCheckMark
            .AutoSize = True
            .Size = New Size(30, 30)

            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(pntLocation)
            .Name = "btnDeletePatientRecord"
            .Image = mapImageTrash
            .ImageAlign = ContentAlignment.MiddleCenter

        End With

        pnlPanelName.Controls.Add(btnCheckMark)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnCheckMark.Click, AddressOf DynamicButton_Click

    End Sub

    Public Sub CreateXMarkBtn(ByVal pnlPanelName As Panel, ByVal pntLocation As Point)

        Dim btnCancel As Button
        btnCancel = New Button
        'declare our image and point at the resource
        Dim mapImageTrash As New Bitmap(New Bitmap(My.Resources.xmark), 25, 25)

        'Set button properties
        With btnCancel
            .AutoSize = True
            .Size = New Size(30, 30)

            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(pntLocation)
            .Name = "btnCancel"
            .Image = mapImageTrash
            .ImageAlign = ContentAlignment.MiddleCenter

        End With


        pnlPanelName.Controls.Add(btnCancel)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnCancel.Click, AddressOf RestDefaultButtons

    End Sub
    Public Function getCurrentPanel(ByVal flpPanel As FlowLayoutPanel, ByVal intPanelsAddedCount As Integer) As Panel

        Dim ctlName As String = "pnlIndividualPatientRecord"
        Dim pnl As Panel
        pnl = New Panel

        For Each ctlControl In flpPanel.Controls

            If ctlControl.Name = ctlName & intPanelsAddedCount.ToString Then

                pnl = CType(ctlControl, Panel)

            End If

        Next

        Debug.Print("Panel Name: " & pnl.Name)

        Return pnl

    End Function

    ' method keeps track of the panel count by checking how many panels are on the main flowPanel.
    ' this is necessary because with the generic methods global counting variables would need to be
    ' defined in too many classes to keep track of what number of panel has been created.
    Public Function getPanelCount(flpPanel As FlowLayoutPanel) As Integer

        Dim ctlControl As Control
        Dim intCount As Integer

        For Each ctlControl In flpPanel.Controls

            If TypeName(ctlControl) = "Panel" Then

                intCount += 1

            End If

        Next

        'Debug.Print(count)

        Return intCount

    End Function

    Public Sub DynamicSingleClick(sender As Object, ByVal e As EventArgs)


        If sender.backColor = Color.White Then
            sender.backColor = Color.Gainsboro
        Else
            sender.backcolor = Color.White
        End If
    End Sub

End Module
