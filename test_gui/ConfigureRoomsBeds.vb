Module ConfigureRoomsBeds
    Public Sub AddRoomsBeds(ByVal strRoom As String, ByVal strBed As String)
        If strRoom <> Nothing Or strBed <> Nothing Then
            'skdlfj
        Else
            MessageBox.Show("Please make sure a room and a bed are entered before adding")
        End If
    End Sub
End Module
