Public Class frmMyPatients
    Private Sub frmMyPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rdbShowAll.Checked = True
        LoadPanel()

    End Sub
    Private Sub LoadPanel()
        Dim UserID As Integer = 9
        Dim strUserFirst As String = ""
        Dim strUserLast As String = ""
        Dim strVisitDate As String = ""
        Dim dsPatientUser As DataSet
        Dim dsUser As DataSet
        Dim dsPatient As DataSet
        Dim intPhysicianID As Integer = 0
        Dim intPatientID As Integer = 0
        Dim intPatientMRN As Integer = 0
        Dim strPatientFirst As String = ""
        Dim strPatientLast As String = ""
        Dim StrDOB As String = ""
        Dim strRoom As String = ""
        Dim strBed As String = ""
        Dim intActive_Flag As String = ""

        dsUser = CreateDatabase.ExecuteSelectQuery("Select User_First_Name, User_Last_Name From User Where User_ID =" & UserID.ToString & " ;")
        For Each row As DataRow In dsUser.Tables(0).Rows
            strUserFirst = row(0)

            strUserLast = row(1)
            Next
        '  txtPhysician.Text = (strUserFirst + " " + strUserLast + ", " + UserID.ToString())
        '  If rdbShowAll.Checked = True Then
        dsPatientUser = CreateDatabase.ExecuteSelectQuery("Select * From PatientUser Where User_TUID =" & UserID.ToString & ";")
            For Each row As DataRow In dsPatientUser.Tables(0).Rows
                intPatientID = row(0)
                strVisitDate = row(2)
                dsPatient = CreateDatabase.ExecuteSelectQuery("Select MRN_Number, Patient_First_Name, Patient_Last_Name, Date_of_Birth, Primary_Physician_ID, Patient.Patient_ID, PatientRoom.Patient_TUID, Room_TUID, Bed_Name FROM Patient LEFT JOIN PatientRoom ON PatientRoom.Patient_TUID = Patient.Patient_ID Where Patient_ID =" & intPatientID.ToString() & ";")
                For Each Patient As DataRow In dsPatient.Tables(0).Rows
                    intPatientMRN = Patient(0)
                    strPatientFirst = Patient(1)
                    strPatientLast = Patient(2)
                    StrDOB = Patient(3)
                    intPhysicianID = Patient(4)
                    strRoom = Patient(7)
                    strBed = Patient(8)
                    'StrDOB = StrDOB.Substring(0, 9)
                    Debug.WriteLine("")
                    frmPatientRecords.CreatePanel(flpMyPatientRecords, intPatientMRN.ToString, strPatientFirst, strPatientLast, StrDOB, strRoom, strBed, intPatientID)
                Next

                Debug.WriteLine("")

            Next
            '  ElseIf rdbOnlyActive.Checked = True Then
            dsPatientUser = CreateDatabase.ExecuteSelectQuery("Select * From PatientUser Where User_TUID =" & UserID.ToString & " AND Active_Flag = 1 ;")
            For Each row As DataRow In dsPatientUser.Tables(0).Rows
                intPatientID = row(0)
                strVisitDate = row(2)
                dsPatient = CreateDatabase.ExecuteSelectQuery("Select MRN_Number, Patient_First_Name, Patient_Last_Name, Date_of_Birth, Primary_Physician_ID, Patient.Patient_ID, PatientRoom.Patient_TUID, Room_TUID, Bed_Name FROM Patient LEFT JOIN PatientRoom ON PatientRoom.Patient_TUID = Patient.Patient_ID Where Patient_ID =" & intPatientID.ToString() & ";")
                For Each Patient As DataRow In dsPatient.Tables(0).Rows
                    intPatientMRN = Patient(0)
                    strPatientFirst = Patient(1)
                    strPatientLast = Patient(2)
                    StrDOB = Patient(3)
                    intPhysicianID = Patient(4)
                    strRoom = Patient(7)
                    strBed = Patient(8)
                    'StrDOB = StrDOB.Substring(0, 9)
                    Debug.WriteLine("")
                    frmPatientRecords.CreatePanel(flpMyPatientRecords, intPatientMRN.ToString, strPatientFirst, strPatientLast, StrDOB, strRoom, strBed, intPatientID)
                Next

                Debug.WriteLine("")

            Next
        '  End If


    End Sub

    Private Sub rdbOnlyActive_CheckedChanged(sender As Object, e As EventArgs)
        flpMyPatientRecords.Controls.Clear()
        '  LoadPanel()
    End Sub


End Class