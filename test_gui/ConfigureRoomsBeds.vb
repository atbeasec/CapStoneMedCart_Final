Module ConfigureRoomsBeds
    Dim strSQLCmd As String
    Public Sub AddRoomsBeds(ByVal strRoom As String, ByVal strBed As String, ByVal intActiveFlag As Integer)
        If strRoom <> Nothing Or strBed <> Nothing Then

            '   strSQLCmd = "INSERT INTO Rooms(Room_ID,Bed_Name,User_TUID,Amount,DrawerMedication_TUID,DateTime) " &
            '        "VALUES('" & intMedicationID & "', '" & intPatientID & "', '" & intUserID & "', '" & intAmount & "', '" & intMedicationDrawerID & "', '" & dtmAdhocTime & "')"
        Else
            MessageBox.Show("Please make sure a room and a bed are entered before adding")
        End If
    End Sub
End Module
