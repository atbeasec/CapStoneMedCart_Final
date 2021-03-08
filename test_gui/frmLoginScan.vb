﻿Imports System.Data.SQLite

Public Class frmLoginScan


    Private Sub lblBadge_Click(sender As Object, e As EventArgs) Handles lblBadge.Click
        'close current form and open frmLogin to login with username and password
        Me.Close()
        frmLogin.Show()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'set textbox text to string variable strBarcode
        Dim strBarcode = txtBarcode.Text
        If strBarcode = "" Then
            MsgBox("           WARNING" & vbCrLf & "Barcode Field is Blank")
            txtBarcode.Focus()
            'send strBarcode to LogIn Module and recive responce
        ElseIf LogIn.ScanLogIn(strBarcode) = "True" Then
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

    Private Sub Barcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        'if the user hits enter in txtBarcode then try to log them in
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
            'set textbox text to string variable strBarcode
            Dim strBarcode = txtBarcode.Text
            If strBarcode = "" Then
                MsgBox("           WARNING" & vbCrLf & "Barcode Field is Blank")
                txtBarcode.Focus()
                'send strBarcode to LogIn Module and recive responce
            ElseIf LogIn.ScanLogIn(strBarcode) = "True" Then
                'If users barcode is in the User table in the database then close current form and open frmMain
                Me.Close()
                    frmMain.Show()
                Else
                    'If users barcode is not in the User table then inform the user
                    MsgBox("No User With That Barcode")
                End If
            End If
    End Sub
End Class