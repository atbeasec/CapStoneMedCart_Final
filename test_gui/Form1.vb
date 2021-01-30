Public Class frmMain

    Dim frmCurrentChildForm As Form
    Dim frmPreviousChildForm As Form
    '  Dim intContactPanelsAddedCount As Integer = 0


    Private Sub btnPatientRecords_Click(sender As Object, e As EventArgs) Handles btnPatientRecords.Click, btnReport.Click, btnInventory.Click, btnDescrepancies.Click, btnMaintenance.Click, btnLogout.Click, btnPharmacy.Click, btnSettings.Click, btnUsers.Click, btnSerialPort.Click, btnEditRooms.Click, btnDischargePatient.Click

        ' ensure that the colors of the buttons change accordingly. We need to know which button is clicked,
        ' and then change the backgroud tot he correct blue color. When this happens we need to change the other buttons
        ' color back to the default RGB blue of 0,0,64

        DetermineFormToOpen(CInt(sender.tag))

        Dim CtlControl As Control

        For Each CtlControl In pnlSideMenu.Controls

            If TypeName(CtlControl) = "Button" Then

                If sender.Name = CtlControl.Name Then

                    If sender.backColor = Color.FromArgb(71, 103, 216) Then

                        sender.backColor = Color.FromArgb(38, 61, 147)

                    End If
                Else
                    CtlControl.BackColor = Color.FromArgb(71, 103, 216)
                End If
            End If
        Next

    End Sub


    Private Sub OpenChildForm(ByVal frmChild As Form)

        ' this is where we dock the form as a frmChild form onto the panel
        ' if there is currently a form here we need to close it

        If Not frmPreviousChildForm Is Nothing Then
            If Not frmPreviousChildForm Is frmChild Then
                frmPreviousChildForm.Close()
                Debug.Print("We should be closing the frmChild form now")
            End If

        End If
        'do nothing the correct form is open
        'Else
        '
        'frmCurrentChildForm.Close()
        'Debug.Print("closed the form")
        '
        'End If
        ' then we ned to open a new one and set the following properties..

        frmPreviousChildForm = frmChild
        'frmChild.TopMost = False

        frmChild.TopLevel = False

        ' removes boarder on form which is where someone can close the form. We will close it on button clicks instead
        frmChild.FormBorderStyle = FormBorderStyle.None

        'add form to panel
        Me.pnlDockLocation.Controls.Add(frmChild)

        'make form visible
        frmChild.Show()


    End Sub

    Private Sub DetermineFormToOpen(ByVal intTagNum As Integer)

        ' based on the button that is clicked this is where we decide
        ' which form we need to open
        Dim intValue As Integer = intTagNum
        Debug.Print(intValue)
        Select Case intValue

            Case 1
                frmCurrentChildForm = frmPatientRecords
                OpenChildForm(frmPatientRecords)
                HideSubMenu()
            Case 2
                frmCurrentChildForm = frmInventory
                OpenChildForm(frmConfigureInventory)
                HideSubMenu()
            Case 3
                frmCurrentChildForm = frmReport
                OpenChildForm(frmReport)
                HideSubMenu()
            Case 4
                frmCurrentChildForm = frmDiscrepancies
                OpenChildForm(frmDiscrepancies)
                HideSubMenu()
            Case 5
                frmCurrentChildForm = frmMaintenance
                OpenChildForm(frmMaintenance)
                HideSubMenu()
            Case 6
                frmCurrentChildForm = frmPharmacy
                OpenChildForm(frmPharmacy)
                HideSubMenu()
            Case 7

                'nothing will happen here because we have a submenu that needs to be displayed to show more buttons
                'more buttons will be shown and we will take the tag num of those to determine which form to dock
                ' frmCurrentChildForm = frmConfiguration
                ' OpenChildForm(frmConfiguration)

            Case 8
                frmCurrentChildForm = frmConfiguration
                OpenChildForm(frmConfiguration)

            Case 9
                frmCurrentChildForm = frmDischarge
                OpenChildForm(frmDischarge)
            Case 10
                frmCurrentChildForm = frmConfigureRooms
                OpenChildForm(frmConfigureRooms)
            Case 11
                frmCurrentChildForm = frmSerialPort
                OpenChildForm(frmSerialPort)
            Case 12
                'call method here to ask if we are sure that we really want to log out of the system
                Me.Hide()
                frmLoginScan.Show()
        End Select




    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Runs the database creation module to determine if the database was created
        DatabaseCreation.Main()
        'CheckUserPermissions()

        'set submenu to be invisible on form load
        pnlSubMenuSettings.Visible = False



    End Sub

    Private Sub SetBackgroundColorOfButton(sender As Object, e As EventArgs)




    End Sub



    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        ShowOrHideSubMenu()

    End Sub

    Private Sub pnlDockLocation_Paint(sender As Object, e As PaintEventArgs) Handles pnlDockLocation.Paint

    End Sub


    Private Sub ShowOrHideSubMenu()

        If pnlSubMenuSettings.Visible = False Then

            pnlSubMenuSettings.Visible = True
        Else
            pnlSubMenuSettings.Visible = False

        End If

    End Sub
    Private Sub HideSubMenu()

        If pnlSubMenuSettings.Visible = True Then
            pnlSubMenuSettings.Visible = False
        End If

    End Sub

    Private Sub CheckUserPermissions()

        ' do database query to check user permission level
        ' select from case statement to determine which level the user is
        ' have 3 methods, one for each permission level, iterating over the controls that are needed to be
        ' removed from the control based on what the user should see

        'need to remove these for everyone on form load






    End Sub


End Class
