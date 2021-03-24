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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReOpen = New System.Windows.Forms.Button()
        Me.pnlDrawer = New System.Windows.Forms.Panel()
        Me.lblDrawersOpen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(102, 87)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(127, 53)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close Drawer"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReOpen
        '
        Me.btnReOpen.Location = New System.Drawing.Point(102, 155)
        Me.btnReOpen.Name = "btnReOpen"
        Me.btnReOpen.Size = New System.Drawing.Size(127, 53)
        Me.btnReOpen.TabIndex = 2
        Me.btnReOpen.Text = "Reopen Drawer"
        Me.btnReOpen.UseVisualStyleBackColor = True
        '
        'pnlDrawer
        '
        Me.pnlDrawer.Location = New System.Drawing.Point(-2, 0)
        Me.pnlDrawer.Name = "pnlDrawer"
        Me.pnlDrawer.Size = New System.Drawing.Size(333, 34)
        Me.pnlDrawer.TabIndex = 3
        '
        'lblDrawersOpen
        '
        Me.lblDrawersOpen.AutoSize = True
        Me.lblDrawersOpen.Location = New System.Drawing.Point(12, 37)
        Me.lblDrawersOpen.Name = "lblDrawersOpen"
        Me.lblDrawersOpen.Size = New System.Drawing.Size(39, 13)
        Me.lblDrawersOpen.TabIndex = 0
        Me.lblDrawersOpen.Text = "Label1"
        '
        'frmOpenedDrawer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 234)
        Me.Controls.Add(Me.pnlDrawer)
        Me.Controls.Add(Me.btnReOpen)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDrawersOpen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOpenedDrawer"
        Me.Text = "frmOpenedDrawer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReOpen As Button
    Friend WithEvents pnlDrawer As Panel
    Friend WithEvents lblDrawersOpen As Label
End Class
