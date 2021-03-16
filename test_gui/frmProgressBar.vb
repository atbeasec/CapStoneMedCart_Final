Public Class frmProgressBar
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles pbrProbgressBar.Click

    End Sub

    Private Sub frmProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmTimer.Start()
        lblMessageUpdate.Text = "Loading Files"

    End Sub

    Private Sub tmTimer_Tick(sender As Object, e As EventArgs) Handles tmTimer.Tick
        pbrProbgressBar.Increment(10)


        If pbrProbgressBar.Value = 100 Then
            tmTimer.Stop()
            lblMessageUpdate.Text = "Finished"

        End If
    End Sub



End Class

