Public Class frmMyPatients
    Private Sub frmMyPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PhysicianID As Integer = 2
        Dim strPhysicianFirst As String = ""
        Dim strPhysicianLast As String = ""
        Dim dsPatientPhysician As DataSet
        Dim dsPhysician As DataSet
        Dim intPatientID As Integer = 0
        dsPhysician = CreateDatabase.ExecuteSelectQuery("Select Physician_First_Name, Physician_Last_Name From Physician Where Physician_ID =" & PhysicianID.ToString & " ;")
        For Each row As DataRow In dsPhysician.Tables(0).Rows
            strPhysicianFirst = row(0)
            strPhysicianLast = row(1)
        Next
        txtPhysician.Text = (strPhysicianFirst + " " + strPhysicianLast + ", " + PhysicianID.ToString())
        If rdbShowAll.Checked = True Then
            dsPatientPhysician = CreateDatabase.ExecuteSelectQuery("Select * From PatientPhysician Where Physician_ID =" & PhysicianID.ToString & ";")
        ElseIf rdbOnlyActive.Checked = True Then
            dsPatientPhysician = CreateDatabase.ExecuteSelectQuery("Select * From PatientPhysician Where Physician_ID =" & PhysicianID.ToString & " AND Active_Flag = 1 ;")
        End If

        For Each row As DataRow In dsPatientPhysician.Tables(0).Rows
            intPatientID = row(0)
        Next

    End Sub
End Class