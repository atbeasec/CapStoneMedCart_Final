<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResolve
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblDiscrepancyHeader = New System.Windows.Forms.Label()
        Me.btnResolve = New System.Windows.Forms.Button()
        Me.lblDiscrepancyID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(11, 67)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(358, 119)
        Me.TextBox1.TabIndex = 0
        '
        'lblDiscrepancyHeader
        '
        Me.lblDiscrepancyHeader.AutoSize = True
        Me.lblDiscrepancyHeader.BackColor = System.Drawing.Color.White
        Me.lblDiscrepancyHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscrepancyHeader.Location = New System.Drawing.Point(114, 36)
        Me.lblDiscrepancyHeader.Name = "lblDiscrepancyHeader"
        Me.lblDiscrepancyHeader.Size = New System.Drawing.Size(153, 21)
        Me.lblDiscrepancyHeader.TabIndex = 92
        Me.lblDiscrepancyHeader.Text = "Reason For Closing "
        '
        'btnResolve
        '
        Me.btnResolve.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnResolve.FlatAppearance.BorderSize = 0
        Me.btnResolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResolve.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResolve.ForeColor = System.Drawing.Color.White
        Me.btnResolve.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnResolve.Location = New System.Drawing.Point(126, 201)
        Me.btnResolve.Name = "btnResolve"
        Me.btnResolve.Size = New System.Drawing.Size(129, 39)
        Me.btnResolve.TabIndex = 93
        Me.btnResolve.Text = "Resolve"
        Me.btnResolve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResolve.UseVisualStyleBackColor = False
        '
        'lblDiscrepancyID
        '
        Me.lblDiscrepancyID.AutoSize = True
        Me.lblDiscrepancyID.BackColor = System.Drawing.Color.White
        Me.lblDiscrepancyID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscrepancyID.Location = New System.Drawing.Point(118, 11)
        Me.lblDiscrepancyID.Name = "lblDiscrepancyID"
        Me.lblDiscrepancyID.Size = New System.Drawing.Size(124, 21)
        Me.lblDiscrepancyID.TabIndex = 94
        Me.lblDiscrepancyID.Text = "Discrepancy ID"
        '
        'frmResolve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(382, 253)
        Me.Controls.Add(Me.lblDiscrepancyID)
        Me.Controls.Add(Me.btnResolve)
        Me.Controls.Add(Me.lblDiscrepancyHeader)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmResolve"
        Me.Text = "frmResolve"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblDiscrepancyHeader As Label
    Friend WithEvents btnResolve As Button
    Friend WithEvents lblDiscrepancyID As Label
End Class
