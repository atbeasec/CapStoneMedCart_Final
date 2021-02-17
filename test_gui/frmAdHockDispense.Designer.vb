<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdHockDispense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdHockDispense))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbMethod = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMedications = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbDosage = New System.Windows.Forms.ComboBox()
        Me.lstboxAllergies = New System.Windows.Forms.ListBox()
        Me.cmbPatientName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDispense = New System.Windows.Forms.Button()
        Me.btnDecrementQuantity = New System.Windows.Forms.Button()
        Me.btnIncrementQuantity = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Panel14.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(397, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 21)
        Me.Label13.TabIndex = 210
        Me.Label13.Text = "Patient Allergies:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 209
        Me.Label5.Text = "Quantity:"
        '
        'cmbMethod
        '
        Me.cmbMethod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMethod.FormattingEnabled = True
        Me.cmbMethod.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbMethod.Location = New System.Drawing.Point(401, 64)
        Me.cmbMethod.Name = "cmbMethod"
        Me.cmbMethod.Size = New System.Drawing.Size(322, 29)
        Me.cmbMethod.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(397, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 21)
        Me.Label15.TabIndex = 208
        Me.Label15.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 21)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "Ad Hoc Dispense:"
        '
        'cmbMedications
        '
        Me.cmbMedications.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedications.FormattingEnabled = True
        Me.cmbMedications.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbMedications.Location = New System.Drawing.Point(35, 64)
        Me.cmbMedications.Name = "cmbMedications"
        Me.cmbMedications.Size = New System.Drawing.Size(294, 29)
        Me.cmbMedications.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 21)
        Me.Label14.TabIndex = 206
        Me.Label14.Text = "Strength:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(32, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 21)
        Me.Label17.TabIndex = 205
        Me.Label17.Text = "Medication:"
        '
        'cmbDosage
        '
        Me.cmbDosage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDosage.FormattingEnabled = True
        Me.cmbDosage.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbDosage.Location = New System.Drawing.Point(35, 140)
        Me.cmbDosage.Name = "cmbDosage"
        Me.cmbDosage.Size = New System.Drawing.Size(294, 29)
        Me.cmbDosage.TabIndex = 3
        '
        'lstboxAllergies
        '
        Me.lstboxAllergies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxAllergies.FormattingEnabled = True
        Me.lstboxAllergies.ItemHeight = 20
        Me.lstboxAllergies.Location = New System.Drawing.Point(401, 293)
        Me.lstboxAllergies.Name = "lstboxAllergies"
        Me.lstboxAllergies.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstboxAllergies.Size = New System.Drawing.Size(321, 104)
        Me.lstboxAllergies.TabIndex = 203
        Me.lstboxAllergies.TabStop = False
        '
        'cmbPatientName
        '
        Me.cmbPatientName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientName.FormattingEnabled = True
        Me.cmbPatientName.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbPatientName.Location = New System.Drawing.Point(35, 216)
        Me.cmbPatientName.Name = "cmbPatientName"
        Me.cmbPatientName.Size = New System.Drawing.Size(294, 29)
        Me.cmbPatientName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "Select Patient:"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.DarkGray
        Me.Panel14.Controls.Add(Me.txtDateOfBirth)
        Me.Panel14.Location = New System.Drawing.Point(402, 216)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel14.Size = New System.Drawing.Size(321, 24)
        Me.Panel14.TabIndex = 6
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.BackColor = System.Drawing.Color.White
        Me.txtDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDateOfBirth.Enabled = False
        Me.txtDateOfBirth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateOfBirth.Location = New System.Drawing.Point(1, 1)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.ReadOnly = True
        Me.txtDateOfBirth.Size = New System.Drawing.Size(319, 22)
        Me.txtDateOfBirth.TabIndex = 6
        Me.txtDateOfBirth.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(397, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 21)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "Patient DOB:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.txtMRN)
        Me.Panel2.Location = New System.Drawing.Point(35, 292)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(294, 24)
        Me.Panel2.TabIndex = 6
        '
        'txtMRN
        '
        Me.txtMRN.BackColor = System.Drawing.Color.White
        Me.txtMRN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMRN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMRN.Enabled = False
        Me.txtMRN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRN.Location = New System.Drawing.Point(1, 1)
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.ReadOnly = True
        Me.txtMRN.Size = New System.Drawing.Size(292, 22)
        Me.txtMRN.TabIndex = 6
        Me.txtMRN.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "Patient MRN:"
        '
        'btnDispense
        '
        Me.btnDispense.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDispense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispense.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispense.ForeColor = System.Drawing.Color.White
        Me.btnDispense.Image = CType(resources.GetObject("btnDispense.Image"), System.Drawing.Image)
        Me.btnDispense.Location = New System.Drawing.Point(256, 419)
        Me.btnDispense.Name = "btnDispense"
        Me.btnDispense.Size = New System.Drawing.Size(229, 38)
        Me.btnDispense.TabIndex = 7
        Me.btnDispense.Text = "      Dispense Medication"
        Me.btnDispense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDispense.UseVisualStyleBackColor = False
        '
        'btnDecrementQuantity
        '
        Me.btnDecrementQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDecrementQuantity.FlatAppearance.BorderSize = 0
        Me.btnDecrementQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecrementQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrementQuantity.ForeColor = System.Drawing.Color.White
        Me.btnDecrementQuantity.Image = CType(resources.GetObject("btnDecrementQuantity.Image"), System.Drawing.Image)
        Me.btnDecrementQuantity.Location = New System.Drawing.Point(495, 140)
        Me.btnDecrementQuantity.Name = "btnDecrementQuantity"
        Me.btnDecrementQuantity.Size = New System.Drawing.Size(28, 28)
        Me.btnDecrementQuantity.TabIndex = 6
        Me.btnDecrementQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDecrementQuantity.UseVisualStyleBackColor = False
        '
        'btnIncrementQuantity
        '
        Me.btnIncrementQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnIncrementQuantity.FlatAppearance.BorderSize = 0
        Me.btnIncrementQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncrementQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncrementQuantity.ForeColor = System.Drawing.Color.White
        Me.btnIncrementQuantity.Image = CType(resources.GetObject("btnIncrementQuantity.Image"), System.Drawing.Image)
        Me.btnIncrementQuantity.Location = New System.Drawing.Point(461, 140)
        Me.btnIncrementQuantity.Name = "btnIncrementQuantity"
        Me.btnIncrementQuantity.Size = New System.Drawing.Size(28, 28)
        Me.btnIncrementQuantity.TabIndex = 5
        Me.btnIncrementQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIncrementQuantity.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.txtQuantity)
        Me.Panel5.Location = New System.Drawing.Point(402, 140)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(53, 28)
        Me.Panel5.TabIndex = 4
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(1, 1)
        Me.txtQuantity.MaxLength = 3
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(51, 26)
        Me.txtQuantity.TabIndex = 38
        '
        'frmAdHockDispense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(774, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDecrementQuantity)
        Me.Controls.Add(Me.btnIncrementQuantity)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbPatientName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDispense)
        Me.Controls.Add(Me.cmbMethod)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbMedications)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbDosage)
        Me.Controls.Add(Me.lstboxAllergies)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmAdHockDispense"
        Me.Text = "frmAdHockDispense"
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDispense As Button
    Friend WithEvents cmbMethod As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMedications As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbDosage As ComboBox
    Friend WithEvents lstboxAllergies As ListBox
    Friend WithEvents cmbPatientName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDecrementQuantity As Button
    Friend WithEvents btnIncrementQuantity As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtQuantity As TextBox
End Class
