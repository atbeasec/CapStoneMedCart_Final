<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.pnlHeaderPatientRecords = New System.Windows.Forms.Panel()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.lblDispenseDate = New System.Windows.Forms.Label()
        Me.lblDispensedBy = New System.Windows.Forms.Label()
        Me.lblGenericName = New System.Windows.Forms.Label()
        Me.lblMeasure = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.flpReport = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeaderPatientRecords.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeaderPatientRecords
        '
        Me.pnlHeaderPatientRecords.BackColor = System.Drawing.Color.White
        Me.pnlHeaderPatientRecords.Controls.Add(Me.Button26)
        Me.pnlHeaderPatientRecords.Controls.Add(Me.Panel3)
        Me.pnlHeaderPatientRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderPatientRecords.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderPatientRecords.Name = "pnlHeaderPatientRecords"
        Me.pnlHeaderPatientRecords.Size = New System.Drawing.Size(1251, 61)
        Me.pnlHeaderPatientRecords.TabIndex = 39
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
        Me.Button26.Location = New System.Drawing.Point(1093, 12)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(154, 35)
        Me.Button26.TabIndex = 47
        Me.Button26.Text = "Save As PDF"
        Me.Button26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Location = New System.Drawing.Point(53, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Panel3.Size = New System.Drawing.Size(273, 35)
        Me.Panel3.TabIndex = 19
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.BackgroundImage = CType(resources.GetObject("Panel11.BackgroundImage"), System.Drawing.Image)
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(32, 33)
        Me.Panel11.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.Location = New System.Drawing.Point(32, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 33)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Tag = "Search Patient"
        Me.TextBox1.Text = "Search History"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblPatientID)
        Me.pnlHeader.Controls.Add(Me.lblPatientName)
        Me.pnlHeader.Controls.Add(Me.lblDispenseDate)
        Me.pnlHeader.Controls.Add(Me.lblDispensedBy)
        Me.pnlHeader.Controls.Add(Me.lblGenericName)
        Me.pnlHeader.Controls.Add(Me.lblMeasure)
        Me.pnlHeader.Controls.Add(Me.lblQuantity)
        Me.pnlHeader.Location = New System.Drawing.Point(4, 67)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1243, 47)
        Me.pnlHeader.TabIndex = 40
        '
        'lblPatientID
        '
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPatientID.Location = New System.Drawing.Point(873, 19)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(81, 21)
        Me.lblPatientID.TabIndex = 8
        Me.lblPatientID.Text = "Patient ID"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPatientName.Location = New System.Drawing.Point(1061, 19)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(108, 21)
        Me.lblPatientName.TabIndex = 7
        Me.lblPatientName.Text = "Patient Name"
        '
        'lblDispenseDate
        '
        Me.lblDispenseDate.AutoSize = True
        Me.lblDispenseDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispenseDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDispenseDate.Location = New System.Drawing.Point(217, 19)
        Me.lblDispenseDate.Name = "lblDispenseDate"
        Me.lblDispenseDate.Size = New System.Drawing.Size(114, 21)
        Me.lblDispenseDate.TabIndex = 1
        Me.lblDispenseDate.Text = "Dispense Date"
        '
        'lblDispensedBy
        '
        Me.lblDispensedBy.AutoSize = True
        Me.lblDispensedBy.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispensedBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDispensedBy.Location = New System.Drawing.Point(667, 19)
        Me.lblDispensedBy.Name = "lblDispensedBy"
        Me.lblDispensedBy.Size = New System.Drawing.Size(108, 21)
        Me.lblDispensedBy.TabIndex = 6
        Me.lblDispensedBy.Text = "Dispensed By"
        '
        'lblGenericName
        '
        Me.lblGenericName.AutoSize = True
        Me.lblGenericName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenericName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblGenericName.Location = New System.Drawing.Point(11, 19)
        Me.lblGenericName.Name = "lblGenericName"
        Me.lblGenericName.Size = New System.Drawing.Size(113, 21)
        Me.lblGenericName.TabIndex = 5
        Me.lblGenericName.Text = "Generic Name"
        '
        'lblMeasure
        '
        Me.lblMeasure.AutoSize = True
        Me.lblMeasure.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeasure.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMeasure.Location = New System.Drawing.Point(404, 19)
        Me.lblMeasure.Name = "lblMeasure"
        Me.lblMeasure.Size = New System.Drawing.Size(73, 21)
        Me.lblMeasure.TabIndex = 3
        Me.lblMeasure.Text = "Measure"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblQuantity.Location = New System.Drawing.Point(527, 19)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(72, 21)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity"
        '
        'flpReport
        '
        Me.flpReport.AutoScroll = True
        Me.flpReport.BackColor = System.Drawing.Color.White
        Me.flpReport.Location = New System.Drawing.Point(4, 110)
        Me.flpReport.Name = "flpReport"
        Me.flpReport.Size = New System.Drawing.Size(1243, 430)
        Me.flpReport.TabIndex = 41
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1251, 549)
        Me.Controls.Add(Me.flpReport)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlHeaderPatientRecords)
        Me.Name = "frmReport"
        Me.Text = "frmReport"
        Me.pnlHeaderPatientRecords.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeaderPatientRecords As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblDispenseDate As Label
    Friend WithEvents lblDispensedBy As Label
    Friend WithEvents lblGenericName As Label
    Friend WithEvents lblMeasure As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents flpReport As FlowLayoutPanel
    Friend WithEvents Button26 As Button
    Friend WithEvents lblPatientID As Label
    Friend WithEvents lblPatientName As Label
End Class
