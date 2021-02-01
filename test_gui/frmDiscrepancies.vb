Public Class frmDiscrepancies
    Dim currentContactPanelName As String = Nothing
    Dim ContactPanelsAddedCount As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel, ByVal strMedication As String, ByVal strDrawerNumber As String, ByVal strExpectedCount As String, ByVal strActualCount As String, ByVal strDTE As String, ByVal strTime As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct


        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(830, 47)
            .Name = "pnlIndividualDiscrepancyPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(830, 45)
            .Name = "pnlIndividualDiscrepancy" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
        End With

        'put the boarder panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)


        'AddHandler pnlMainPanel.DoubleClick, AddressOf DynamicDoubleClickNewOrder
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        ' add handler to allow for resolving here?

        ' add controls to this panel
        ' call database info here to populate
        Const Y As Integer = 20
        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Dim lblID6 As New Label


        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblMedication", lblMedication.Location.X, Y, strMedication, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblDrawer", lblDrawer.Location.X, Y, strDrawerNumber, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblExpectedCount", lblExpectedCount.Location.X, Y, strExpectedCount, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblActualCount", lblActualCount.Location.X, Y, strActualCount, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID5, "lblDate", lblDate.Location.X, Y, strDTE, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID6, "lblTime", lblTime.Location.X, Y, strTime, getPanelCount(flpPannel))

        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)

    End Sub
    Private Sub frmDiscrepancies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim genName1 As String = "Benzhydrocodone "
        Dim genName2 As String = "hydrocodone bitartrate"
        Dim genName3 As String = "phenylephrine"
        Dim genName4 As String = "Morphine"
        Dim genName5 As String = "Codeine"



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

        Dim dispensedBy1 As String = "3"
        Dim dispensedBy2 As String = "5 "
        Dim dispensedBy3 As String = "6"
        Dim dispensedBy4 As String = "1"
        Dim dispensedBy5 As String = "2"

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


        CreatePanel(flpDiscrepancies, genName1, quantity2, dispensedBy5, quantity1, dispenseDate1, dispenseTime1)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmResolve.Show()
    End Sub


    ' discreoanices will have the problem record the transaction before the flagged one.
End Class