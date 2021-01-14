Public Class frmDiscrepancies
    Dim currentContactPanelName As String = Nothing
    Dim ContactPanelsAddedCount As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal genericName As String, ByVal brandName As String, ByVal measure As String, ByVal quantityOff As String, ByVal dispensedBy As String, ByVal patientName As String, ByVal dte As String, ByVal time As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(1115, 47)
            .Name = "pnlIndividualPatientRecordPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(1115, 45)
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
        Dim lblID8 As New Label

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblGenericName", lblGenericName.Location.X, Y, genericName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblDispenseDate", lblBrandName.Location.X, Y, brandName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblMeasure", lblMeasure.Location.X, Y, measure, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblQuantity", (lblQuantityOff.Location.X + 4), Y, quantityOff, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblDispensedBy", lblNurseDispensing.Location.X, Y, dispensedBy, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblPatientID", lblPatient.Location.X, Y, patientName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID7, "lblPatientName", lblDate.Location.X, Y, dte, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID8, "lblTimeofEvent", lblTime.Location.X, Y, time, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub
    Private Sub frmDiscrepancies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim genName1 As String = "Benzhydrocodone "
        Dim genName2 As String = "hydrocodone bitartrate"
        Dim genName3 As String = "phenylephrine"
        Dim genName4 As String = "Morphine"
        Dim genName5 As String = "Codeine"

        Dim brandName1 As String = "Apadaz "
        Dim brandName2 As String = "Flowtuss "
        Dim brandName3 As String = "Histinex HC"
        Dim brandName4 As String = "Duramorph "
        Dim brandName5 As String = "Robitussin Ac"

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

        Dim dispenseTime1 As String = "8:05 AM"
        Dim dispenseTime2 As String = "9:13 AM"
        Dim dispenseTime3 As String = "8:34 AM"
        Dim dispenseTime4 As String = "1:05 PM"
        Dim dispenseTime5 As String = "5:04 AM"


        CreatePanel(flpDiscrepancies, genName1, brandName1, measure1, quantity1, dispensedBy1, dispensedBy2, dispenseDate1, dispenseTime1)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmResolve.Show()
    End Sub


    ' discreoanices will have the problem record the transaction before the flagged one.
End Class