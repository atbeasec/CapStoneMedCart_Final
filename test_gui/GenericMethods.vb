Module GenericMethods

    'Method that allows for highlighting when hovering over panels. has two parts
    'part 1

    Public Sub MouseEnterPanelSetBackGroundColor(Sender As Object, e As EventArgs)

        'changes the background color when the mouse is hovered over the panel

        If Sender.backColor = Color.White Then
            Sender.backColor = Color.Gainsboro

        Else

            Sender.backcolor = Color.White
        End If

    End Sub

    'part 2
    Public Sub MouseLeavePanelSetBackGroundColorToDefault(sender As Object, e As EventArgs)

        ' checking if the background color is set to the highlighted color
        'if it is not then we will set it.
        If sender.backColor = Color.Gainsboro Then

            sender.backColor = Color.White

        Else

            sender.backcolor = Color.Gainsboro
        End If

    End Sub

    'Add new  delete button to contact panel
    Public Sub RestDefaultButtons(ByVal sender As Object, ByVal e As EventArgs)

        Dim temp As Integer = 1

        Dim ctl As Control

        For Each ctl In sender.Parent.Controls

            If TypeName(ctl) = "Button" Then

                If Not ctl.Name.Contains("Cancel") Or ctl.Name.Contains("Check") Then
                    ' for any controls that are not the check mark or red x, we will make them visible

                    ctl.Visible = True

                Else
                    'even though we hide the other controls, once we select the delete button once, we are hiding all of the other icons
                    ' there fore we do not need to recreate them we can simply hide or unhide them
                    ' in this case we will set the visibility to false because they are controls that we need to hide.

                    ctl.Visible = False

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
        Dim ctl As Control

        For Each ctl In sender.Parent.Controls

            If TypeName(ctl) = "Button" Then
                If ctl.Name.Contains("Edit") Then

                    Debug.Print(ctl.Name)

                    'hide the control
                    ctl.Visible = False

                    ' get the location and put the x in that location
                    ' CreateXMarkBtn(sender.Parent, New Point(ctl.Location.X, ctl.Location.Y))
                    CreateCheckMarkBtn(sender.Parent, New Point(ctl.Location.X, ctl.Location.Y))
                End If
            End If
        Next



    End Sub

    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        'the parent of the button will be the panel the control is located on.
        'we want to get one step removed so we need to next take the parent of the control
        ' to get the name of flowpanel which the button is laid out on
        Dim control As Control = sender.Parent
        Dim parents As Control = control.Parent



        Dim parentFlowPanel As Control = control.Parent
        'Dim strFlowPanelName As String = control.Parent.Name

        ' Debug.Print(control.Parent.Name)

        Dim parentPanelName As String

        parentPanelName = Nothing

        'Remove handler from sender
        For Each controlObj As Control In parentFlowPanel.Controls
            For Each childControlObj As Control In controlObj.Controls
                If childControlObj.Name = sender.name Then

                    RemoveHandler childControlObj.Click, AddressOf DynamicButton_Click

                    parentPanelName = childControlObj.Parent.Name
                End If
            Next
        Next



        'Remove  panel
        For Each controlObj As Control In parentFlowPanel.Controls
            If controlObj.Name = parentPanelName Then

                ' prompt user if they are sure they want to delete the record


                ' remove the record from the database

                'remove the padding panel from the flow panel

                parentFlowPanel.Controls.Remove(controlObj.Parent)
                controlObj.Parent.Dispose()

                'remove the panel from the flow panel
                parentFlowPanel.Controls.Remove(controlObj)
                controlObj.Dispose()

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


    Public Sub CreateIDLabel(ByVal panelName As Panel, lblName As Label, strLabelName As String, x As Integer, y As Integer, labelText As String, ByVal ContactPanelsAddedCount As Integer)

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
            .Name = strLabelName + (ContactPanelsAddedCount).ToString
            .Text = labelText
            .Tag = ContactPanelsAddedCount + 1
        End With


        panelName.Controls.Add(lblName)

    End Sub

    Public Sub DynamicRemoveHandlerFromSender(ByVal sender As Object, ByVal e As EventArgs)

        'the parent of the button will be the panel the control is located on.
        'we want to get one step removed so we need to next take the parent of the control
        ' to get the name of flowpanel which the button is laid out on
        Dim control As Control = sender.Parent
        Dim parents As Control = control.Parent



        Dim parentFlowPanel As Control = control.Parent
        'Dim strFlowPanelName As String = control.Parent.Name

        ' Debug.Print(control.Parent.Name)

        Dim parentPanelName As String

        parentPanelName = Nothing

        'Remove handler from sender
        For Each controlObj As Control In parentFlowPanel.Controls
            For Each childControlObj As Control In controlObj.Controls
                If childControlObj.Name = sender.name Then

                    RemoveHandler childControlObj.Click, AddressOf DynamicButton_Click

                    parentPanelName = childControlObj.Parent.Name
                End If
            Next
        Next

    End Sub

    'Add new  delete button to contact panel
    Public Sub CreateDeleteBtn(ByVal panelName As Panel, ByVal ContactPanelsAddedCount As Integer, ByVal x As Integer, ByVal y As Integer)

        Dim btnDeleteButton As Button
        btnDeleteButton = New Button
        'declare our image and point at the resource
        Dim imageTrash As New Bitmap(New Bitmap(My.Resources.icons8_delete_trash), 25, 25)

        'Set button properties
        With btnDeleteButton
            .AutoSize = True
            .Size = New Size(30, 30)

            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(x, y)
            .Name = "btnDeletePatientRecord" + (ContactPanelsAddedCount).ToString
            .Image = imageTrash
            .ImageAlign = ContentAlignment.MiddleCenter
            .Tag = ContactPanelsAddedCount + 1
        End With


        panelName.Controls.Add(btnDeleteButton)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnDeleteButton.Click, AddressOf ShowConfirmationButtons

    End Sub

    Public Sub CreateEditButton(ByVal panelName As Panel, ByVal ContactPanelsAddedCount As Integer, ByVal x As Integer, ByVal y As Integer)

        Dim btnEditButton As Button
        btnEditButton = New Button
        'declare our image and point at the resource
        Dim imagePencil As New Bitmap(New Bitmap(My.Resources.icons8_pencil), 25, 25)

        'Set button properties
        With btnEditButton
            .AutoSize = True
            .Size = New Size(30, 30)

            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            '.Location = New Point(825, 5)
            .Location = New Point(x, y)
            .Name = "btnEditPatientRecord" + (ContactPanelsAddedCount).ToString
            .Image = imagePencil
            .ImageAlign = ContentAlignment.MiddleCenter
            .Tag = ContactPanelsAddedCount + 1
        End With

        Debug.Print(panelName.Name)
        panelName.Controls.Add(btnEditButton)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnEditButton.Click, AddressOf DynamicButtonEditRecord_Click

    End Sub

    Public Sub CreateCheckMarkBtn(ByVal panelName As Panel, ByVal location As Point)

        Dim btnCheckMark As Button
        btnCheckMark = New Button
        'declare our image and point at the resource
        Dim imageTrash As New Bitmap(New Bitmap(My.Resources.checkmark), 25, 25)

        'Set button properties
        With btnCheckMark
            .AutoSize = True
            .Size = New Size(30, 30)

            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(location)
            .Name = "btnDeletePatientRecord"
            .Image = imageTrash
            .ImageAlign = ContentAlignment.MiddleCenter

        End With


        panelName.Controls.Add(btnCheckMark)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnCheckMark.Click, AddressOf DynamicButton_Click

    End Sub

    Public Sub CreateXMarkBtn(ByVal panelName As Panel, ByVal location As Point)

        Dim btnCancel As Button
        btnCancel = New Button
        'declare our image and point at the resource
        Dim imageTrash As New Bitmap(New Bitmap(My.Resources.xmark), 25, 25)

        'Set button properties
        With btnCancel
            .AutoSize = True
            .Size = New Size(30, 30)

            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.Transparent
            ' .Font = New Font(New FontFamily("Microsoft Sans Serif"), 11)
            ' .Location = New Point(  )
            .Location = New Point(location)
            .Name = "btnCancel"
            .Image = imageTrash
            .ImageAlign = ContentAlignment.MiddleCenter

        End With


        panelName.Controls.Add(btnCancel)
        ' MessageBox.Show("again")
        'Add handler for click events
        AddHandler btnCancel.Click, AddressOf RestDefaultButtons

    End Sub
    Public Function getCurrentPanel(ByVal flpPanel As FlowLayoutPanel, ByVal ContactPanelsAddedCount As Integer) As panel

        Dim ctlName As String = "pnlIndividualPatientRecord"
        Dim pnl As Panel
        pnl = New Panel

        For Each ctl In flpPanel.Controls

            If ctl.Name = ctlName & ContactPanelsAddedCount.ToString Then

                pnl = CType(ctl, Panel)

            End If

        Next

        Debug.Print("Panel Name: " & pnl.Name)

        Return pnl

    End Function

    ' method keeps track of the panel count by checking how many panels are on the main flowPanel.
    ' this is necessary because with the generic methods global counting variables would need to be
    ' defined in too many classes to keep track of what number of panel has been created.
    Public Function getPanelCount(flpPanel As FlowLayoutPanel) As Integer

        Dim ctl As Control
        Dim count As Integer

        For Each ctl In flpPanel.Controls

            If TypeName(ctl) = "Panel" Then

                count += 1

            End If

        Next

        'Debug.Print(count)

        Return count

    End Function

    Public Sub DynamicSingleClick(sender As Object, ByVal e As EventArgs)


        If sender.backColor = Color.White Then
            sender.backColor = Color.Gainsboro

        Else
            sender.backcolor = Color.White

        End If




    End Sub



End Module
