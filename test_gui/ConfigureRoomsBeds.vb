Module ConfigureRoomsBeds

    Dim strSQLCmd As String

    Public Sub AddRoomsBeds(ByVal strRoom As String, ByVal strBed As String, ByVal intActiveFlag As Integer)
        If strRoom <> Nothing Or strBed <> Nothing Then

            strSQLCmd = "INSERT INTO Rooms(Room_ID,Bed_Name,Active_Flag) " &
                    "VALUES('" & strRoom & "', '" & strBed & "', '" & intActiveFlag & "')"

            ExecuteInsertQuery(strSQLCmd)

            MessageBox.Show("The room and bed has been inserted")

        Else
            MessageBox.Show("Please make sure a room and a bed are entered before adding")
        End If

        ShowRooms()
    End Sub

    Public Sub ShowRooms()
        Dim dsValues As DataSet = New DataSet
        strSQLCmd = "SELECT DISTINCT Room_ID FROM Rooms"

        dsValues = ExecuteSelectQuery(strSQLCmd)

        For Each value As DataRow In dsValues.Tables(0).Rows
            frmConfigureRooms.lstRooms.Items.Add(value(0))
        Next
    End Sub
End Module
