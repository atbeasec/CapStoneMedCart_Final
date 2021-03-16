<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgressBar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbrProbgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'pbrProbgressBar
        '
        Me.pbrProbgressBar.Location = New System.Drawing.Point(12, 87)
        Me.pbrProbgressBar.Name = "pbrProbgressBar"
        Me.pbrProbgressBar.Size = New System.Drawing.Size(482, 23)
        Me.pbrProbgressBar.TabIndex = 0
        '
        'frmProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 150)
        Me.Controls.Add(Me.pbrProbgressBar)
        Me.Name = "frmProgressBar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbrProbgressBar As Windows.Forms.ProgressBar
End Class
