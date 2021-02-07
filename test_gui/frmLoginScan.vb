Imports System.Data.SQLite

Public Class frmLoginScan


    Private Sub lblBadge_Click(sender As Object, e As EventArgs) Handles lblBadge.Click
        'close current form and open frmLogin to login with username and password
        Me.Close()
        frmLogin.Show()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'set textbox text to string variable strBarcode
        Dim strBarcode = TextBox1.Text
        'send strBarcode to LogIn Module and recive responce
        If LogIn.ScanLogIn(strBarcode) = "True" Then
            'If users barcode is in the User table in the database then close current form and open frmMain
            Me.Close()
            frmMain.Show()
        Else
            'If users barcode is not in the User table then inform the user
            MsgBox("No User With That Barcode")
        End If

    End Sub

    Private Sub frmLoginScan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class