<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.flpDiscrepancies = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.lblGenericName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpDiscrepancies
        '
        Me.flpDiscrepancies.AutoScroll = True
        Me.flpDiscrepancies.BackColor = System.Drawing.Color.White
        Me.flpDiscrepancies.Location = New System.Drawing.Point(34, 123)
        Me.flpDiscrepancies.Name = "flpDiscrepancies"
        Me.flpDiscrepancies.Size = New System.Drawing.Size(469, 430)
        Me.flpDiscrepancies.TabIndex = 45
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.lblGenericName)
        Me.pnlHeader.Controls.Add(Me.lblBrandName)
        Me.pnlHeader.Location = New System.Drawing.Point(34, 72)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(469, 47)
        Me.pnlHeader.TabIndex = 44
        '
        'lblBrandName
        '
        Me.lblBrandName.AutoSize = True
        Me.lblBrandName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBrandName.Location = New System.Drawing.Point(156, 16)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(90, 21)
        Me.lblBrandName.TabIndex = 7
        Me.lblBrandName.Text = "ID Number"
        '
        'lblGenericName
        '
        Me.lblGenericName.AutoSize = True
        Me.lblGenericName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenericName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblGenericName.Location = New System.Drawing.Point(8, 16)
        Me.lblGenericName.Name = "lblGenericName"
        Me.lblGenericName.Size = New System.Drawing.Size(53, 21)
        Me.lblGenericName.TabIndex = 8
        Me.lblGenericName.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(322, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Access"
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(570, 625)
        Me.Controls.Add(Me.flpDiscrepancies)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "frmChangePassword"
        Me.Text = "frmChangePassword"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpDiscrepancies As FlowLayoutPanel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblGenericName As Label
    Friend WithEvents lblBrandName As Label
    Friend WithEvents Label1 As Label
End Class
