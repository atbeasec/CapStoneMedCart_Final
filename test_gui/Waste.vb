Public Class Waste
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If sender.checked = True Then

            TextBox1.Visible = True

        Else
            TextBox1.Visible = False

        End If
    End Sub

    Private Sub Waste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
    End Sub
End Class