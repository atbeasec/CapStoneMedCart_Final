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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddAllergy = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbAllergies = New System.Windows.Forms.ComboBox()
        Me.cmbMedicationName = New System.Windows.Forms.ComboBox()
        Me.cmbAllergiesType = New System.Windows.Forms.ComboBox()
        Me.btnAllergyCancel = New System.Windows.Forms.Button()
        Me.btnAllergySave = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
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
        Me.cmbSeverity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSeverity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSeverity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeverity.FormattingEnabled = True
        Me.cmbSeverity.Items.AddRange(New Object() {"Class 1", "Class 2", "Class 3", "Class 4", "Class 5"})
        Me.cmbSeverity.Location = New System.Drawing.Point(10, 134)
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
        Me.cmbAllergies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAllergies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAllergies.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAllergies.FormattingEnabled = True
        Me.cmbAllergies.Items.AddRange(New Object() {"Class 1", "Class 2", "Class 3", "Class 4", "Class 5"})
        Me.cmbAllergies.Location = New System.Drawing.Point(10, 66)
        Me.cmbAllergies.Name = "cmbAllergies"
        Me.cmbAllergies.Size = New System.Drawing.Size(286, 29)
        Me.cmbAllergies.TabIndex = 188
        '
        'cmbMedicationName
        '
        Me.cmbMedicationName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMedicationName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedicationName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedicationName.FormattingEnabled = True
        Me.cmbMedicationName.Items.AddRange(New Object() {"Class 1", "Class 2", "Class 3", "Class 4", "Class 5"})
        Me.cmbMedicationName.Location = New System.Drawing.Point(364, 138)
        Me.cmbMedicationName.Name = "cmbMedicationName"
        Me.cmbMedicationName.Size = New System.Drawing.Size(286, 29)
        Me.cmbMedicationName.TabIndex = 189
        '
        'cmbAllergiesType
        '
        Me.cmbAllergiesType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAllergiesType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAllergiesType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAllergiesType.FormattingEnabled = True
        Me.cmbAllergiesType.Items.AddRange(New Object() {"Class 1", "Class 2", "Class 3", "Class 4", "Class 5"})
        Me.cmbAllergiesType.Location = New System.Drawing.Point(364, 67)
        Me.cmbAllergiesType.Name = "cmbAllergiesType"
        Me.cmbAllergiesType.Size = New System.Drawing.Size(286, 29)
        Me.cmbAllergiesType.TabIndex = 190
        '
        'btnAllergyCancel
        '
        Me.btnAllergyCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAllergyCancel.FlatAppearance.BorderSize = 0
        Me.btnAllergyCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllergyCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllergyCancel.ForeColor = System.Drawing.Color.White
        Me.btnAllergyCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAllergyCancel.Location = New System.Drawing.Point(739, 86)
        Me.btnAllergyCancel.Name = "btnAllergyCancel"
        Me.btnAllergyCancel.Size = New System.Drawing.Size(146, 37)
        Me.btnAllergyCancel.TabIndex = 191
        Me.btnAllergyCancel.Text = "Cancel"
        Me.btnAllergyCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAllergyCancel.UseVisualStyleBackColor = False
        '
        'btnAllergySave
        '
        Me.btnAllergySave.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAllergySave.FlatAppearance.BorderSize = 0
        Me.btnAllergySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllergySave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllergySave.ForeColor = System.Drawing.Color.White
        Me.btnAllergySave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAllergySave.Location = New System.Drawing.Point(739, 34)
        Me.btnAllergySave.Name = "btnAllergySave"
        Me.btnAllergySave.Size = New System.Drawing.Size(146, 37)
        Me.btnAllergySave.TabIndex = 192
        Me.btnAllergySave.Text = "Save"
        Me.btnAllergySave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAllergySave.UseVisualStyleBackColor = False
        '
        'frmAllergies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(926, 478)
        Me.Controls.Add(Me.btnAllergySave)
        Me.Controls.Add(Me.btnAllergyCancel)
        Me.Controls.Add(Me.cmbAllergiesType)
        Me.Controls.Add(Me.cmbMedicationName)
        Me.Controls.Add(Me.cmbAllergies)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAddAllergy)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbSeverity)
        Me.Controls.Add(Me.flpAllergies)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmAllergies"
        Me.Text = "frmAllergies"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddAllergy As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblActions As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbAllergies As ComboBox
    Friend WithEvents cmbMedicationName As ComboBox
    Friend WithEvents cmbAllergiesType As ComboBox
    Friend WithEvents btnAllergyCancel As Button
    Friend WithEvents btnAllergySave As Button
End Class
