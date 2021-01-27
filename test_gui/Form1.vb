Public Class frmMain

    Dim frmCurrentChildForm As Form
    Dim frmPreviousChildForm As Form
    Dim intContactPanelsAddedCount As Integer = 0

    Private Sub btnPatientRecords_Click(sender As Object, e As EventArgs) Handles btnPatientRecords.Click, btnReport.Click, btnInventory.Click, btnDescrepancies.Click, btnMaintenance.Click, btnLogout.Click, btnPharmacy.Click, btnConfiguration.Click
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
            Case 2
                frmCurrentChildForm = frmInventory
                OpenChildForm(frmConfigureInventory)
            Case 3
                frmCurrentChildForm = frmReport
                OpenChildForm(frmReport)
            Case 4
                frmCurrentChildForm = frmDiscrepancies
                OpenChildForm(frmDiscrepancies)
            Case 5
                frmCurrentChildForm = frmMaintenance
                OpenChildForm(frmMaintenance)
            Case 6
                frmCurrentChildForm = frmPharmacy
                OpenChildForm(frmPharmacy)
            Case 7
                frmCurrentChildForm = frmConfiguration
                OpenChildForm(frmConfiguration)
               ' frmWitness.Show()
            Case 8
                'call method here to ask if we are sure that we really want to log out of the system
                Me.Hide()
                frmLoginScan.Show()
        End Select




    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Runs the database creation module to determine if the database was created
        DatabaseCreation.Main()
    End Sub

    Private Sub btnConfiguration_Click(sender As Object, e As EventArgs) Handles btnConfiguration.Click

    End Sub

    Private Sub pnlDockLocation_Paint(sender As Object, e As PaintEventArgs) Handles pnlDockLocation.Paint

    End Sub
End Class
