﻿Public Class frmAdHockDispense
    Private Sub frmAdHockDispense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'set ad efault quantity to the quantity textbox
        Dim intDefaultQuantity As Integer = 1
        txtQuantity.Text = intDefaultQuantity

    End Sub

    Private Sub btnIncrementQuantity_Click(sender As Object, e As EventArgs) Handles btnIncrementQuantity.Click
        ButtonIncrement(txtQuantity)
    End Sub

    Private Sub btnDecrementQuantity_Click(sender As Object, e As EventArgs) Handles btnDecrementQuantity.Click
        ButtonDecrement(txtQuantity)
    End Sub
End Class