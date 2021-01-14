Public Class frmNewOrder


    Dim currentContactPanel As String = Nothing
    Private Sub frmNewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ID1 As String = "123456"
        Dim ID2 As String = "123457"
        Dim ID3 As String = "123458"
        Dim ID4 As String = "123459"

        Dim brandName1 As String = "Vicodin "
        Dim brandName2 As String = "Oxycontin"
        Dim brandName3 As String = "Dilaudid"
        Dim brandName4 As String = "Duragesic"

        Dim genericName1 As String = "Hydrocodone"
        Dim genericName2 As String = "Oxycodone"
        Dim genericName3 As String = "Hydromorphone"
        Dim genericName4 As String = "Fentanyl"

        Dim measure1 As String = "10 mg"
        Dim measure2 As String = "10 mg"
        Dim measure3 As String = "10 mg"
        Dim measure4 As String = "10 mg"


        CreatePanel(flpMedications, ID1, brandName1, genericName1, measure1)
        CreatePanel(flpMedications, ID2, brandName2, genericName2, measure2)
        CreatePanel(flpMedications, ID3, brandName3, genericName3, measure3)
        CreatePanel(flpMedications, ID4, brandName4, genericName4, measure4)
    End Sub

    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal strID As String, ByVal strBrandName As String, ByVal strGenericName As String, ByVal strMeasure As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(532, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpMedications).ToString
            .Tag = getPanelCount(flpMedications).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(532, 45)
            .Name = "pnlIndividualPatientRecord" + getPanelCount(flpMedications).ToString
            .Tag = getPanelCount(flpMedications).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)

        AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicClick
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault


        ' add controls to this panel
        'CreateEditButton(pnlMainPanel, getPanelCount(flpPatients), 830, 5)
        'CreateDeleteBtn(pnlMainPanel, getPanelCount(flpPatients), 890, 5)

        'CreateDeleteBtn(pnlMainPanel)
        'CreateEditButton(pnlMainPanel)


        ' call database info here to populate
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label

        Dim location As New Point(10, 20)
        Dim location2 As New Point(100, 20)
        Dim location3 As New Point(200, 20)
        Dim location4 As New Point(300, 20)

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblID", 10, 20, strID, getPanelCount(flpMedications))
        CreateIDLabel(pnlMainPanel, lblID2, "lblBrandName", 135, 20, strBrandName, getPanelCount(flpMedications))
        CreateIDLabel(pnlMainPanel, lblID3, "lblGenericName", 275, 20, strGenericName, getPanelCount(flpMedications))
        CreateIDLabel(pnlMainPanel, lblID4, "lblMeasure", 430, 20, strMeasure, getPanelCount(flpMedications))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)
        'flpCamera.Controls.Add(contactPanel)
        'Update panel variables

        currentContactPanel = pnl.Name

    End Sub

    Private Sub DynamicClick(sender As Object, e As EventArgs)

        Dim ctl As Control

        For Each ctl In sender.controls

            ' Debug.Print(ctl.Name)


            If TypeName(ctl) = "Label" Then


                If ctl.Name.Contains("Brand") Then


                    lblSelectedDrug.Text = ctl.Text

                End If
            End If
        Next


    End Sub

    Private Sub lblCustomerName_Click(sender As Object, e As EventArgs) Handles lblCustomerName.Click

    End Sub
End Class