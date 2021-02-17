Public Class frmConfigureRooms
    Private Sub frmConfigureRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowRooms()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddBed_Click(sender As Object, e As EventArgs) Handles btnAddBed.Click
        AddRoomsBeds(txtRoom.Text, txtBed.Text, 1)
        txtRoom.Clear()
        txtBed.Clear()

    End Sub
End Class