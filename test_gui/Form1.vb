Public Class frmMain

    Dim currentChildForm As Form
    Dim previousChildForm As Form
    Dim _ContactPanelsAddedCount As Integer = 0

    Private Sub btnPatientRecords_Click(sender As Object, e As EventArgs) Handles btnPatientRecords.Click, btnReport.Click, btnInventory.Click, btnDescrepancies.Click, btnMaintenance.Click, btnLogout.Click, btnPharmacy.Click, btnConfiguration.Click
        ' ensure that the colors of the buttons change accordingly. We need to know which button is clicked,
        ' and then change the backgroud tot he correct blue color. When this happens we need to change the other buttons
        ' color back to the default RGB blue of 0,0,64

        DetermineFormToOpen(CInt(sender.tag))

        Dim ctl As Control

        For Each ctl In pnlSideMenu.Controls

            If TypeName(ctl) = "Button" Then

                If sender.Name = ctl.Name Then

                    If sender.backColor = Color.FromArgb(71, 103, 216) Then

                        sender.backColor = Color.FromArgb(38, 61, 147)

                    End If
                Else
                    ctl.BackColor = Color.FromArgb(71, 103, 216)
                End If
            End If
        Next

    End Sub


    Private Sub OpenChildForm(ByVal child As Form)
        ' this is where we dock the form as a child form onto the panel



        ' if there is currently a form here we need to close it
        If Not previousChildForm Is Nothing Then
            If Not previousChildForm Is child Then
                previousChildForm.Close()
                Debug.Print("We should be closing the child form now")
            End If

        End If
        'do nothing the correct form is open
        'Else
        '
        'currentChildForm.Close()
        'Debug.Print("closed the form")
        '
        'End If
        ' then we ned to open a new one and set the following properties..
        previousChildForm = child
        'child.TopMost = False
        child.TopLevel = False
        ' removes boarder on form which is where someone can close the form. We will close it on button clicks instead
        child.FormBorderStyle = FormBorderStyle.None
        'add form to panel
        Me.pnlDockLocation.Controls.Add(child)
        'make form visible
        child.Show()


    End Sub

    Private Sub DetermineFormToOpen(ByVal tagNum As Integer)

        ' based on the button that is clicked this is where we decide
        ' which form we need to open
        Dim value As Integer = tagNum
        Debug.Print(value)
        Select Case value

            Case 1
                currentChildForm = frmPatientRecords
                OpenChildForm(frmPatientRecords)
            Case 2
                currentChildForm = frmInventory
                OpenChildForm(frmConfigureInventory)
            Case 3
                currentChildForm = frmReport
                OpenChildForm(frmReport)
            Case 4
                currentChildForm = frmDiscrepancies
                OpenChildForm(frmDiscrepancies)
            Case 5
                currentChildForm = frmMaintenance
                OpenChildForm(frmMaintenance)
            Case 6
                currentChildForm = frmPharmacy
                OpenChildForm(frmPharmacy)
            Case 7
                currentChildForm = frmConfiguration
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
        mDatabaseCreation.Main()
    End Sub

    Private Sub btnConfiguration_Click(sender As Object, e As EventArgs) Handles btnConfiguration.Click

    End Sub

    Private Sub pnlDockLocation_Paint(sender As Object, e As PaintEventArgs) Handles pnlDockLocation.Paint

    End Sub
End Class
