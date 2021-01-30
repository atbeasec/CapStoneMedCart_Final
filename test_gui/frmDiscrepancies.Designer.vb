<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiscrepancies))
        Me.flpDiscrepancies = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblPatient = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblNurseDispensing = New System.Windows.Forms.Label()
        Me.lblGenericName = New System.Windows.Forms.Label()
        Me.lblMeasure = New System.Windows.Forms.Label()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.lblQuantityOff = New System.Windows.Forms.Label()
        Me.pnlHeaderPatientRecords = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
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
        Me.flpDiscrepancies.Size = New System.Drawing.Size(1123, 430)
        Me.flpDiscrepancies.TabIndex = 43
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblPatient)
        Me.pnlHeader.Controls.Add(Me.lblTime)
        Me.pnlHeader.Controls.Add(Me.lblDate)
        Me.pnlHeader.Controls.Add(Me.lblNurseDispensing)
        Me.pnlHeader.Controls.Add(Me.lblGenericName)
        Me.pnlHeader.Controls.Add(Me.lblMeasure)
        Me.pnlHeader.Controls.Add(Me.lblBrandName)
        Me.pnlHeader.Controls.Add(Me.lblQuantityOff)
        Me.pnlHeader.Location = New System.Drawing.Point(12, 67)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1123, 47)
        Me.pnlHeader.TabIndex = 42
        '
        'lblPatient
        '
        Me.lblPatient.AutoSize = True
        Me.lblPatient.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatient.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPatient.Location = New System.Drawing.Point(763, 16)
        Me.lblPatient.Name = "lblPatient"
        Me.lblPatient.Size = New System.Drawing.Size(108, 21)
        Me.lblPatient.TabIndex = 10
        Me.lblPatient.Text = "Patient Name"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTime.Location = New System.Drawing.Point(1039, 16)
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
        Me.lblDate.Location = New System.Drawing.Point(940, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 21)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date"
        '
        'lblNurseDispensing
        '
        Me.lblNurseDispensing.AutoSize = True
        Me.lblNurseDispensing.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNurseDispensing.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNurseDispensing.Location = New System.Drawing.Point(576, 16)
        Me.lblNurseDispensing.Name = "lblNurseDispensing"
        Me.lblNurseDispensing.Size = New System.Drawing.Size(137, 21)
        Me.lblNurseDispensing.TabIndex = 2
        Me.lblNurseDispensing.Text = "Nurse Dispensing"
        '
        'lblGenericName
        '
        Me.lblGenericName.AutoSize = True
        Me.lblGenericName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenericName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblGenericName.Location = New System.Drawing.Point(8, 16)
        Me.lblGenericName.Name = "lblGenericName"
        Me.lblGenericName.Size = New System.Drawing.Size(113, 21)
        Me.lblGenericName.TabIndex = 8
        Me.lblGenericName.Text = "Generic Name"
        '
        'lblMeasure
        '
        Me.lblMeasure.AutoSize = True
        Me.lblMeasure.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeasure.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMeasure.Location = New System.Drawing.Point(339, 16)
        Me.lblMeasure.Name = "lblMeasure"
        Me.lblMeasure.Size = New System.Drawing.Size(73, 21)
        Me.lblMeasure.TabIndex = 9
        Me.lblMeasure.Text = "Measure"
        '
        'lblBrandName
        '
        Me.lblBrandName.AutoSize = True
        Me.lblBrandName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBrandName.Location = New System.Drawing.Point(180, 16)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(100, 21)
        Me.lblBrandName.TabIndex = 7
        Me.lblBrandName.Text = "Brand Name"
        '
        'lblQuantityOff
        '
        Me.lblQuantityOff.AutoSize = True
        Me.lblQuantityOff.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityOff.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblQuantityOff.Location = New System.Drawing.Point(445, 16)
        Me.lblQuantityOff.Name = "lblQuantityOff"
        Me.lblQuantityOff.Size = New System.Drawing.Size(100, 21)
        Me.lblQuantityOff.TabIndex = 6
        Me.lblQuantityOff.Text = "Quantity Off"
        '
        'pnlHeaderPatientRecords
        '
        Me.pnlHeaderPatientRecords.BackColor = System.Drawing.Color.White
        Me.pnlHeaderPatientRecords.Controls.Add(Me.Button1)
        Me.pnlHeaderPatientRecords.Controls.Add(Me.Button26)
        Me.pnlHeaderPatientRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderPatientRecords.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderPatientRecords.Name = "pnlHeaderPatientRecords"
        Me.pnlHeaderPatientRecords.Size = New System.Drawing.Size(1167, 61)
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
        Me.Button1.Location = New System.Drawing.Point(836, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 35)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "  Resolve"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button26.FlatAppearance.BorderSize = 0
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.ForeColor = System.Drawing.Color.White
        Me.Button26.Image = CType(resources.GetObject("Button26.Image"), System.Drawing.Image)
        Me.Button26.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button26.Location = New System.Drawing.Point(981, 17)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(154, 35)
        Me.Button26.TabIndex = 48
        Me.Button26.Text = "Save As PDF"
        Me.Button26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button26.UseVisualStyleBackColor = False
        '
        'frmDiscrepancies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1167, 561)
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
    Friend WithEvents lblQuantityOff As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblNurseDispensing As Label
    Friend WithEvents pnlHeaderPatientRecords As Panel
    Friend WithEvents Button26 As Button
    Friend WithEvents lblGenericName As Label
    Friend WithEvents lblMeasure As Label
    Friend WithEvents lblBrandName As Label
    Friend WithEvents lblPatient As Label
    Friend WithEvents Button1 As Button
End Class
