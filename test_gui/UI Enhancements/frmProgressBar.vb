Public Class frmProgressBar
    Private Sub frmProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

        Me.CenterToScreen()
    End Sub

    'Method to update the label 
    Public Sub UpdateLabel(lbltext As String)
        Debug.WriteLine($"i am here {Now}: {lbltext}")
        If lblMessageUpdate.InvokeRequired Then
            lblMessageUpdate.Invoke(Sub() UpdateLabel(lbltext))
        Else
            lblMessageUpdate.Text = lbltext
            Application.DoEvents()
        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class

