Public Class frmProgressBar
    Private Sub frmProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

        Dim pt As New Point((frmMain.Width - Me.Width) + frmMain.DesktopLocation.X, (frmMain.Height - Me.Height) + frmMain.DesktopLocation.Y)
        Me.Location = pt


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

    Private Sub lblPleaseWait_Click(sender As Object, e As EventArgs) Handles lblPleaseWait.Click

    End Sub
End Class

