﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiscrepancies
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
        Me.flpDiscrepancies = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblActualCount = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblExpectedCount = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblDrawer = New System.Windows.Forms.Label()
        Me.pnlHeaderPatientRecords = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlHeaderPatientRecords.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpDiscrepancies
        '
        Me.flpDiscrepancies.AutoScroll = True
        Me.flpDiscrepancies.BackColor = System.Drawing.Color.White
        Me.flpDiscrepancies.Location = New System.Drawing.Point(12, 118)
        Me.flpDiscrepancies.Name = "flpDiscrepancies"
        Me.flpDiscrepancies.Size = New System.Drawing.Size(837, 430)
        Me.flpDiscrepancies.TabIndex = 43
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblActualCount)
        Me.pnlHeader.Controls.Add(Me.lblTime)
        Me.pnlHeader.Controls.Add(Me.lblDate)
        Me.pnlHeader.Controls.Add(Me.lblExpectedCount)
        Me.pnlHeader.Controls.Add(Me.lblMedication)
        Me.pnlHeader.Controls.Add(Me.lblDrawer)
        Me.pnlHeader.Location = New System.Drawing.Point(12, 67)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(837, 47)
        Me.pnlHeader.TabIndex = 42
        '
        'lblActualCount
        '
        Me.lblActualCount.AutoSize = True
        Me.lblActualCount.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblActualCount.Location = New System.Drawing.Point(476, 16)
        Me.lblActualCount.Name = "lblActualCount"
        Me.lblActualCount.Size = New System.Drawing.Size(104, 21)
        Me.lblActualCount.TabIndex = 10
        Me.lblActualCount.Text = "Actual Count"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTime.Location = New System.Drawing.Point(729, 16)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(46, 21)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDate.Location = New System.Drawing.Point(622, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 21)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date"
        '
        'lblExpectedCount
        '
        Me.lblExpectedCount.AutoSize = True
        Me.lblExpectedCount.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpectedCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblExpectedCount.Location = New System.Drawing.Point(297, 16)
        Me.lblExpectedCount.Name = "lblExpectedCount"
        Me.lblExpectedCount.Size = New System.Drawing.Size(126, 21)
        Me.lblExpectedCount.TabIndex = 2
        Me.lblExpectedCount.Text = "Expected Count"
        '
        'lblMedication
        '
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedication.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMedication.Location = New System.Drawing.Point(8, 16)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(93, 21)
        Me.lblMedication.TabIndex = 8
        Me.lblMedication.Text = "Medication"
        '
        'lblDrawer
        '
        Me.lblDrawer.AutoSize = True
        Me.lblDrawer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrawer.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDrawer.Location = New System.Drawing.Point(184, 16)
        Me.lblDrawer.Name = "lblDrawer"
        Me.lblDrawer.Size = New System.Drawing.Size(62, 21)
        Me.lblDrawer.TabIndex = 9
        Me.lblDrawer.Text = "Drawer"
        '
        'pnlHeaderPatientRecords
        '
        Me.pnlHeaderPatientRecords.BackColor = System.Drawing.Color.White
        Me.pnlHeaderPatientRecords.Controls.Add(Me.Button1)
        Me.pnlHeaderPatientRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderPatientRecords.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderPatientRecords.Name = "pnlHeaderPatientRecords"
        Me.pnlHeaderPatientRecords.Size = New System.Drawing.Size(869, 61)
        Me.pnlHeaderPatientRecords.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.test_gui.My.Resources.Resources.resolve
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(729, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 35)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "  Resolve"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmDiscrepancies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(869, 561)
        Me.Controls.Add(Me.flpDiscrepancies)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlHeaderPatientRecords)
        Me.Name = "frmDiscrepancies"
        Me.Text = "frmDiscrepancies"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlHeaderPatientRecords.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flpDiscrepancies As FlowLayoutPanel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblExpectedCount As Label
    Friend WithEvents pnlHeaderPatientRecords As Panel
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblDrawer As Label
    Friend WithEvents lblActualCount As Label
    Friend WithEvents Button1 As Button
End Class