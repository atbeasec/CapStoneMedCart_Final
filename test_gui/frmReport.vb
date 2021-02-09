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

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        If cmbReports.SelectedIndex < 0 Then
            MessageBox.Show("Please select a report from the drop down menu", "No Selected Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Print.Main()
        End If

    End Sub

End Class