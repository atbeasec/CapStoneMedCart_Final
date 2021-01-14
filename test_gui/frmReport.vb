Public Class frmReport

    Dim ContactPanelsAddedCount As Integer = 0
    Dim CurrentContactPanelName As String = Nothing

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateTransactionHistory()

    End Sub



    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal genericName As String, ByVal dispenseDate As String, ByVal measure As String, ByVal quantity As String, ByVal dispensedBy As String, ByVal patientID As String, ByVal patientName As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(1235, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(1235, 45)
            .Name = "pnlIndividualPatientRecord" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)


        'AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClickNewOrder
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        ' add controls to this panel
        ' call database info here to populate
        Const Y As Integer = 20
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Dim lblID6 As New Label
        Dim lblID7 As New Label

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblGenericName", lblGenericName.Location.X, Y, genericName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblDispenseDate", lblDispenseDate.Location.X, Y, dispenseDate, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblMeasure", lblMeasure.Location.X, Y, measure, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblQuantity", (lblQuantity.Location.X + 4), Y, quantity, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblDispensedBy", lblDispensedBy.Location.X, Y, dispensedBy, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblPatientID", lblPatientID.Location.X, Y, patientID, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID7, "lblPatientName", lblPatientName.Location.X, Y, patientName, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub

    Private Sub PopulateTransactionHistory()



        Dim genName1 As String = "benzhydrocodone "
        Dim genName2 As String = "hydrocodone bitartrate"
        Dim genName3 As String = "phenylephrine"
        Dim genName4 As String = "Morphine"
        Dim genName5 As String = "Codeine"

        Dim patientName1 As String = "John Smith "
        Dim patientName2 As String = "Viola Bouvet "
        Dim patientName3 As String = "Nora Holder"
        Dim patientName4 As String = "Sky Sinclair "
        Dim patientName5 As String = "Sky Sinclair"

        Dim quantity1 As String = "1"
        Dim quantity2 As String = "1"
        Dim quantity3 As String = "2"
        Dim quantity4 As String = "1"
        Dim quantity5 As String = "3"

        Dim measure1 As String = "10 mg"
        Dim measure2 As String = "10 mg"
        Dim measure3 As String = "50 mg"
        Dim measure4 As String = "10 mg"
        Dim measure5 As String = "10 mg"

        Dim dispensedBy1 As String = "Kathryn Bonner"
        Dim dispensedBy2 As String = "Lola Stanley"
        Dim dispensedBy3 As String = "Kathryn Bonner"
        Dim dispensedBy4 As String = "Kathryn Bonner"
        Dim dispensedBy5 As String = "Lola Stanley"

        Dim dispenseDate1 As String = "11/11/2020"
        Dim dispenseDate2 As String = "11/5/2020"
        Dim dispenseDate3 As String = "11/4/2020"
        Dim dispenseDate4 As String = "11/1/2020"
        Dim dispenseDate5 As String = "10/28/2020"

        Dim patientID1 As String = "123456"
        Dim patientID2 As String = "123457"
        Dim patientID3 As String = "123458"
        Dim patientID4 As String = "123459"


        CreatePanel(flpReport, genName1, dispenseDate1, measure1, quantity1, dispensedBy1, patientID1, patientName1)
        CreatePanel(flpReport, genName2, dispenseDate2, measure2, quantity2, dispensedBy2, patientID2, patientName2)
        CreatePanel(flpReport, genName3, dispenseDate3, measure3, quantity3, dispensedBy3, patientID3, patientName3)
        CreatePanel(flpReport, genName4, dispenseDate4, measure4, quantity4, dispensedBy4, patientID4, patientName4)



    End Sub
End Class