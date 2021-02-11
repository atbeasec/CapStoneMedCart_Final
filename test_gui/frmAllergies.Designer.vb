<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAllergies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllergies))
        Me.flpAllergies = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblActions = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblAllergyName = New System.Windows.Forms.Label()
        Me.lblAllergyType = New System.Windows.Forms.Label()
        Me.lblSeverity = New System.Windows.Forms.Label()
        Me.cmbSeverity = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtAllergyType = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAllergyName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtMedicationName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddAllergy = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbAllergies = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'flpAllergies
        '
        Me.flpAllergies.AutoScroll = True
        Me.flpAllergies.BackColor = System.Drawing.Color.White
        Me.flpAllergies.Location = New System.Drawing.Point(12, 246)
        Me.flpAllergies.Name = "flpAllergies"
        Me.flpAllergies.Size = New System.Drawing.Size(873, 220)
        Me.flpAllergies.TabIndex = 50
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblActions)
        Me.Panel2.Controls.Add(Me.lblMedication)
        Me.Panel2.Controls.Add(Me.lblAllergyName)
        Me.Panel2.Controls.Add(Me.lblAllergyType)
        Me.Panel2.Controls.Add(Me.lblSeverity)
        Me.Panel2.Location = New System.Drawing.Point(12, 196)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(873, 47)
        Me.Panel2.TabIndex = 49
        '
        'lblActions
        '
        Me.lblActions.AutoSize = True
        Me.lblActions.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActions.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblActions.Location = New System.Drawing.Point(711, 16)
        Me.lblActions.Name = "lblActions"
        Me.lblActions.Size = New System.Drawing.Size(65, 21)
        Me.lblActions.TabIndex = 10
        Me.lblActions.Text = "Actions"
        '
        'lblMedication
        '
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedication.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMedication.Location = New System.Drawing.Point(490, 16)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(93, 21)
        Me.lblMedication.TabIndex = 7
        Me.lblMedication.Text = "Medication"
        '
        'lblAllergyName
        '
        Me.lblAllergyName.AutoSize = True
        Me.lblAllergyName.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllergyName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAllergyName.Location = New System.Drawing.Point(11, 16)
        Me.lblAllergyName.Name = "lblAllergyName"
        Me.lblAllergyName.Size = New System.Drawing.Size(66, 21)
        Me.lblAllergyName.TabIndex = 1
        Me.lblAllergyName.Text = "Allergy "
        '
        'lblAllergyType
        '
        Me.lblAllergyType.AutoSize = True
        Me.lblAllergyType.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllergyType.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAllergyType.Location = New System.Drawing.Point(350, 16)
        Me.lblAllergyType.Name = "lblAllergyType"
        Me.lblAllergyType.Size = New System.Drawing.Size(45, 21)
        Me.lblAllergyType.TabIndex = 9
        Me.lblAllergyType.Text = "Type"
        '
        'lblSeverity
        '
        Me.lblSeverity.AutoSize = True
        Me.lblSeverity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeverity.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSeverity.Location = New System.Drawing.Point(175, 16)
        Me.lblSeverity.Name = "lblSeverity"
        Me.lblSeverity.Size = New System.Drawing.Size(69, 21)
        Me.lblSeverity.TabIndex = 0
        Me.lblSeverity.Text = "Severity"
        '
        'cmbSeverity
        '
        Me.cmbSeverity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeverity.FormattingEnabled = True
        Me.cmbSeverity.Items.AddRange(New Object() {"Class 1", "Class 2", "Class 3", "Class 4", "Class 5"})
        Me.cmbSeverity.Location = New System.Drawing.Point(11, 137)
        Me.cmbSeverity.Name = "cmbSeverity"
        Me.cmbSeverity.Size = New System.Drawing.Size(286, 29)
        Me.cmbSeverity.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 21)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Allergy Severity"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 21)
        Me.Label12.TabIndex = 180
        Me.Label12.Text = "Allergy Name:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkGray
        Me.Panel9.Controls.Add(Me.txtAllergyType)
        Me.Panel9.Location = New System.Drawing.Point(364, 67)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel9.Size = New System.Drawing.Size(286, 28)
        Me.Panel9.TabIndex = 2
        '
        'txtAllergyType
        '
        Me.txtAllergyType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAllergyType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAllergyType.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllergyType.Location = New System.Drawing.Point(1, 1)
        Me.txtAllergyType.Multiline = True
        Me.txtAllergyType.Name = "txtAllergyType"
        Me.txtAllergyType.Size = New System.Drawing.Size(284, 26)
        Me.txtAllergyType.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.txtAllergyName)
        Me.Panel1.Location = New System.Drawing.Point(11, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(286, 28)
        Me.Panel1.TabIndex = 1
        '
        'txtAllergyName
        '
        Me.txtAllergyName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAllergyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAllergyName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllergyName.Location = New System.Drawing.Point(1, 1)
        Me.txtAllergyName.Multiline = True
        Me.txtAllergyName.Name = "txtAllergyName"
        Me.txtAllergyName.Size = New System.Drawing.Size(284, 26)
        Me.txtAllergyName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(361, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 182
        Me.Label2.Text = "Allergy Type:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.txtMedicationName)
        Me.Panel3.Location = New System.Drawing.Point(365, 137)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(286, 28)
        Me.Panel3.TabIndex = 4
        '
        'txtMedicationName
        '
        Me.txtMedicationName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMedicationName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMedicationName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedicationName.Location = New System.Drawing.Point(1, 1)
        Me.txtMedicationName.Multiline = True
        Me.txtMedicationName.Name = "txtMedicationName"
        Me.txtMedicationName.Size = New System.Drawing.Size(284, 26)
        Me.txtMedicationName.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(362, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "Medication Name:"
        '
        'btnAddAllergy
        '
        Me.btnAddAllergy.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAddAllergy.FlatAppearance.BorderSize = 0
        Me.btnAddAllergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAllergy.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAllergy.ForeColor = System.Drawing.Color.White
        Me.btnAddAllergy.Image = CType(resources.GetObject("btnAddAllergy.Image"), System.Drawing.Image)
        Me.btnAddAllergy.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddAllergy.Location = New System.Drawing.Point(739, 138)
        Me.btnAddAllergy.Name = "btnAddAllergy"
        Me.btnAddAllergy.Size = New System.Drawing.Size(146, 37)
        Me.btnAddAllergy.TabIndex = 5
        Me.btnAddAllergy.Text = "Add Allergy"
        Me.btnAddAllergy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddAllergy.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 185
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 25)
        Me.Label5.TabIndex = 186
        Me.Label5.Text = "Patient Allergy Information"
        '
        'cmbAllergies
        '
        Me.cmbAllergies.FormattingEnabled = True
        Me.cmbAllergies.Location = New System.Drawing.Point(732, 74)
        Me.cmbAllergies.Name = "cmbAllergies"
        Me.cmbAllergies.Size = New System.Drawing.Size(121, 21)
        Me.cmbAllergies.TabIndex = 187
        '
        'frmAllergies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(926, 478)
        Me.Controls.Add(Me.cmbAllergies)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAddAllergy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbSeverity)
        Me.Controls.Add(Me.flpAllergies)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmAllergies"
        Me.Text = "frmAllergies"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents flpAllergies As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblAllergyName As Label
    Friend WithEvents lblAllergyType As Label
    Friend WithEvents lblSeverity As Label
    Friend WithEvents cmbSeverity As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtAllergyType As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAllergyName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtMedicationName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddAllergy As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblActions As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbAllergies As ComboBox
End Class
