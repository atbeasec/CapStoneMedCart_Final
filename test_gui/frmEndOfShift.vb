Public Class frmEndOfShift
    Dim ContactPanelsAddedCount As Integer = 0
    Dim CurrentContactPanelName As String = Nothing

    Private Sub frmEndOfShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'end of shift count count will work by the following logic:
        'query will be done to bring in all of the medications that are currently in the cart.
        'each item in the cart will appear on the created panels on the GUI, a textbox field will be provided
        'for the user to type in the count they have. There will also be a button where they can flag a particular medication


        Dim intNum1 As String = 1
        Dim intNum2 As String = 2
        Dim intNum3 As String = 3

        Dim medTUID1 As Integer = 2
        Dim medTUID2 As Integer = 3
        Dim medTUID3 As Integer = 4

        Dim intNum5 As String = 30
        Dim intNum6 As String = 40
        Dim intNum7 As String = 25

        Dim genName1 As String = "benzhydrocodone "
        Dim genName2 As String = "hydrocodone bitartrate"
        Dim genName3 As String = "phenylephrine"
        Dim genName4 As String = "Morphine"
        Dim genName5 As String = "Codeine"

        CreatePanel(flpEndOfShiftCount, genName1, intNum1, intNum3, intNum5)
        CreatePanel(flpEndOfShiftCount, genName2, intNum2, intNum3, intNum7)
        CreatePanel(flpEndOfShiftCount, genName3, intNum3, intNum2, intNum7)


    End Sub




    Public Sub CreatePanel(ByVal flpPannel As FlowLayoutPanel,, ByVal intMedicationTUID As Integer, ByVal strMedicationName As String, ByVal strDrawerNumber As String, ByVal strSection As String, ByVal strSystemCount As String)

        Dim pnl As Panel
        pnl = New Panel

        Dim pnlMainPanel As Panel
        pnlMainPanel = New Panel
        ' call method here to get the count from the database and update the panel number so the next item is correct

        'Set panel properties
        With pnl
            .BackColor = Color.Gainsboro
            .Size = New Size(flpEndOfShiftCount.Size.Width - 5, 47)
            .Name = "pnlMedicationFlaggedPadding" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Padding = New Padding(0, 0, 0, 3)
            ' .Dock = System.Windows.Forms.DockStyle.Top
        End With

        With pnlMainPanel

            .BackColor = Color.White
            .Size = New Size(flpEndOfShiftCount.Size.Width - 5, 45)
            .Name = "pnlMedicationFlagged" + getPanelCount(flpPannel).ToString
            .Tag = getPanelCount(flpPannel).ToString
            .Dock = System.Windows.Forms.DockStyle.Top
            .Tag = intMedicationTUID
        End With

        'put the border panel inside the main panel
        pnl.Controls.Add(pnlMainPanel)

        'AddHandler pnlMainPanel.Click, AddressOf DynamicSingleClickOpenPatient
        AddHandler pnlMainPanel.MouseEnter, AddressOf MouseEnterPanelSetBackGroundColor
        AddHandler pnlMainPanel.MouseLeave, AddressOf MouseLeavePanelSetBackGroundColorToDefault

        ' add controls to this panel
        CreateFlagBtn(pnlMainPanel, getPanelCount(flpPannel), lblActions.Location.X + 8, 5)
        CreateTextBox(pnlMainPanel, getPanelCount(flpPannel), lblCount.Location.X, 6)

        Dim lblID As New Label
        Dim lblID2 As New Label
        Dim lblID3 As New Label
        Dim lblID4 As New Label
        Dim lblID5 As New Label
        Dim lblID6 As New Label

        Dim location As New Point(10, 20)
        Dim location2 As New Point(100, 20)
        Dim location3 As New Point(200, 20)
        Dim location4 As New Point(300, 20)
        Dim location5 As New Point(400, 20)
        Dim location6 As New Point(500, 20)

        ' anywhere we have quotes except for the label names, we can call our Database and get method
        CreateIDLabel(pnlMainPanel, lblID, "lblMedication", lblMedication.Location.X, 20, strMedicationName, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID2, "lblDrawerNumber", lblDrawerNum.Location.X, 20, strDrawerNumber, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID3, "lblSection", lblSection.Location.X, 20, strSection, getPanelCount(flpPannel))
        CreateIDLabel(pnlMainPanel, lblID4, "lblSystemCount", lblSystemCount.Location.X, 20, strSystemCount, getPanelCount(flpPannel))


        'Add panel to flow layout panel
        flpPannel.Controls.Add(pnl)


    End Sub
End Class