Public Class frmReport

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateReportsList()

    End Sub


    Private Sub PopulateReportsList()

        Const STRDISCREPANCIES As String = "Discrepancies"
        Const STRDISPENSINGHISTORY As String = "Dispensed Medications"
        Const STRADHOCORDERS As String = "Ad Hoc Orders"
        Const STRNARCOTICSDISPENSED As String = "Narcotics Dispensed"
        Const STROVERRIDES As String = "Overrides"

        cmbReports.Items.Add(STRDISCREPANCIES)
        cmbReports.Items.Add(STRDISPENSINGHISTORY)
        cmbReports.Items.Add(STRADHOCORDERS)
        cmbReports.Items.Add(STRNARCOTICSDISPENSED)
        cmbReports.Items.Add(STROVERRIDES)

    End Sub



End Class