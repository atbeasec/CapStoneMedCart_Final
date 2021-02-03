<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpenedDrawer
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
        Me.lblDrawersOpen = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDrawersOpen
        '
        Me.lblDrawersOpen.AutoSize = True
        Me.lblDrawersOpen.Location = New System.Drawing.Point(176, 9)
        Me.lblDrawersOpen.Name = "lblDrawersOpen"
        Me.lblDrawersOpen.Size = New System.Drawing.Size(39, 13)
        Me.lblDrawersOpen.TabIndex = 0
        Me.lblDrawersOpen.Text = "Label1"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(135, 51)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(127, 53)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close a Drawer"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmOpenedDrawer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 156)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDrawersOpen)
        Me.Name = "frmOpenedDrawer"
        Me.Text = "frmOpenedDrawer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDrawersOpen As Label
    Friend WithEvents btnClose As Button
End Class
