<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndOfShift
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
        Me.flpEndOfShiftCount = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblActions = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblDrawerNum = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblSystemCount = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.btnControlled = New System.Windows.Forms.Button()
        Me.btnNonControlled = New System.Windows.Forms.Button()
        Me.btnAllMedications = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpEndOfShiftCount
        '
        Me.flpEndOfShiftCount.AutoScroll = True
        Me.flpEndOfShiftCount.BackColor = System.Drawing.Color.White
        Me.flpEndOfShiftCount.Location = New System.Drawing.Point(12, 117)
        Me.flpEndOfShiftCount.Name = "flpEndOfShiftCount"
        Me.flpEndOfShiftCount.Size = New System.Drawing.Size(955, 533)
        Me.flpEndOfShiftCount.TabIndex = 19
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblSection)
        Me.pnlHeader.Controls.Add(Me.lblSystemCount)
        Me.pnlHeader.Controls.Add(Me.lblCount)
        Me.pnlHeader.Controls.Add(Me.lblActions)
        Me.pnlHeader.Controls.Add(Me.lblMedication)
        Me.pnlHeader.Controls.Add(Me.lblDrawerNum)
        Me.pnlHeader.Location = New System.Drawing.Point(12, 66)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(955, 47)
        Me.pnlHeader.TabIndex = 18
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblCount.Location = New System.Drawing.Point(730, 19)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(54, 21)
        Me.lblCount.TabIndex = 6
        Me.lblCount.Text = "Count"
        '
        'lblActions
        '
        Me.lblActions.AutoSize = True
        Me.lblActions.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActions.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblActions.Location = New System.Drawing.Point(844, 19)
        Me.lblActions.Name = "lblActions"
        Me.lblActions.Size = New System.Drawing.Size(65, 21)
        Me.lblActions.TabIndex = 2
        Me.lblActions.Text = "Actions"
        '
        'lblMedication
        '
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedication.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMedication.Location = New System.Drawing.Point(10, 19)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(93, 21)
        Me.lblMedication.TabIndex = 1
        Me.lblMedication.Text = "Medication"
        '
        'lblDrawerNum
        '
        Me.lblDrawerNum.AutoSize = True
        Me.lblDrawerNum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrawerNum.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDrawerNum.Location = New System.Drawing.Point(244, 19)
        Me.lblDrawerNum.Name = "lblDrawerNum"
        Me.lblDrawerNum.Size = New System.Drawing.Size(126, 21)
        Me.lblDrawerNum.TabIndex = 0
        Me.lblDrawerNum.Text = "Drawer Number"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(801, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(166, 37)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "SAVE REPORT"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblSystemCount
        '
        Me.lblSystemCount.AutoSize = True
        Me.lblSystemCount.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSystemCount.Location = New System.Drawing.Point(574, 19)
        Me.lblSystemCount.Name = "lblSystemCount"
        Me.lblSystemCount.Size = New System.Drawing.Size(111, 21)
        Me.lblSystemCount.TabIndex = 7
        Me.lblSystemCount.Text = "System Count"
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSection.Location = New System.Drawing.Point(435, 19)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(65, 21)
        Me.lblSection.TabIndex = 8
        Me.lblSection.Text = "Section"
        '
        'btnControlled
        '
        Me.btnControlled.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnControlled.FlatAppearance.BorderSize = 0
        Me.btnControlled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControlled.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlled.ForeColor = System.Drawing.Color.White
        Me.btnControlled.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnControlled.Location = New System.Drawing.Point(12, 12)
        Me.btnControlled.Name = "btnControlled"
        Me.btnControlled.Size = New System.Drawing.Size(166, 37)
        Me.btnControlled.TabIndex = 21
        Me.btnControlled.Text = "CONTROLLED"
        Me.btnControlled.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnControlled.UseVisualStyleBackColor = False
        '
        'btnNonControlled
        '
        Me.btnNonControlled.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnNonControlled.FlatAppearance.BorderSize = 0
        Me.btnNonControlled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNonControlled.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNonControlled.ForeColor = System.Drawing.Color.White
        Me.btnNonControlled.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNonControlled.Location = New System.Drawing.Point(203, 12)
        Me.btnNonControlled.Name = "btnNonControlled"
        Me.btnNonControlled.Size = New System.Drawing.Size(192, 37)
        Me.btnNonControlled.TabIndex = 22
        Me.btnNonControlled.Text = "NON-CONTROLLED"
        Me.btnNonControlled.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNonControlled.UseVisualStyleBackColor = False
        '
        'btnAllMedications
        '
        Me.btnAllMedications.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAllMedications.FlatAppearance.BorderSize = 0
        Me.btnAllMedications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllMedications.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllMedications.ForeColor = System.Drawing.Color.White
        Me.btnAllMedications.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAllMedications.Location = New System.Drawing.Point(417, 12)
        Me.btnAllMedications.Name = "btnAllMedications"
        Me.btnAllMedications.Size = New System.Drawing.Size(208, 37)
        Me.btnAllMedications.TabIndex = 23
        Me.btnAllMedications.Text = "ALL MEDICATIONS"
        Me.btnAllMedications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAllMedications.UseVisualStyleBackColor = False
        '
        'frmEndOfShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1009, 663)
        Me.Controls.Add(Me.btnAllMedications)
        Me.Controls.Add(Me.btnNonControlled)
        Me.Controls.Add(Me.btnControlled)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.flpEndOfShiftCount)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "frmEndOfShift"
        Me.Text = "frmEndOfShift"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpEndOfShiftCount As FlowLayoutPanel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblCount As Label
    Friend WithEvents lblActions As Label
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblDrawerNum As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblSection As Label
    Friend WithEvents lblSystemCount As Label
    Friend WithEvents btnControlled As Button
    Friend WithEvents btnNonControlled As Button
    Friend WithEvents btnAllMedications As Button
End Class
