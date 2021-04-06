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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMedications = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lstboxAllergies = New System.Windows.Forms.ListBox()
        Me.cmbPatientName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDispense = New System.Windows.Forms.Button()
        Me.txtStrength = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDrawerBin = New System.Windows.Forms.TextBox()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.txtRoomBed = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(707, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 21)
        Me.Label13.TabIndex = 210
        Me.Label13.Text = "Patient Allergies:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(707, 40)
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
        Me.cmbMedications.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMedications.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedications.BackColor = System.Drawing.Color.White
        Me.cmbMedications.DropDownHeight = 300
        Me.cmbMedications.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedications.FormattingEnabled = True
        Me.cmbMedications.IntegralHeight = False
        Me.cmbMedications.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbMedications.Location = New System.Drawing.Point(35, 64)
        Me.cmbMedications.Name = "cmbMedications"
        Me.cmbMedications.Size = New System.Drawing.Size(579, 29)
        Me.cmbMedications.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 192)
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
        'lstboxAllergies
        '
        Me.lstboxAllergies.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lstboxAllergies.FormattingEnabled = True
        Me.lstboxAllergies.ItemHeight = 21
        Me.lstboxAllergies.Location = New System.Drawing.Point(711, 293)
        Me.lstboxAllergies.Name = "lstboxAllergies"
        Me.lstboxAllergies.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstboxAllergies.Size = New System.Drawing.Size(321, 193)
        Me.lstboxAllergies.TabIndex = 7
        Me.lstboxAllergies.TabStop = False
        '
        'cmbPatientName
        '
        Me.cmbPatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPatientName.BackColor = System.Drawing.Color.White
        Me.cmbPatientName.DropDownHeight = 300
        Me.cmbPatientName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientName.FormattingEnabled = True
        Me.cmbPatientName.IntegralHeight = False
        Me.cmbPatientName.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbPatientName.Location = New System.Drawing.Point(35, 292)
        Me.cmbPatientName.Name = "cmbPatientName"
        Me.cmbPatientName.Size = New System.Drawing.Size(579, 29)
        Me.cmbPatientName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 212
        Me.Label1.Text = "Select Patient:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(707, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 21)
        Me.Label8.TabIndex = 214
        Me.Label8.Text = "Patient DOB:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 344)
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
        Me.btnDispense.Location = New System.Drawing.Point(353, 530)
        Me.btnDispense.Name = "btnDispense"
        Me.btnDispense.Size = New System.Drawing.Size(229, 38)
        Me.btnDispense.TabIndex = 3
        Me.btnDispense.Text = "      Dispense Medication"
        Me.btnDispense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDispense.UseVisualStyleBackColor = False
        '
        'txtStrength
        '
        Me.txtStrength.BackColor = System.Drawing.Color.White
        Me.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStrength.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtStrength.Location = New System.Drawing.Point(36, 221)
        Me.txtStrength.MaxLength = 9
        Me.txtStrength.Name = "txtStrength"
        Me.txtStrength.ReadOnly = True
        Me.txtStrength.ShortcutsEnabled = False
        Me.txtStrength.Size = New System.Drawing.Size(293, 29)
        Me.txtStrength.TabIndex = 5
        Me.txtStrength.TabStop = False
        '
        'txtType
        '
        Me.txtType.BackColor = System.Drawing.Color.White
        Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtType.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtType.Location = New System.Drawing.Point(711, 68)
        Me.txtType.MaxLength = 9
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.ShortcutsEnabled = False
        Me.txtType.Size = New System.Drawing.Size(321, 29)
        Me.txtType.TabIndex = 1
        Me.txtType.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 21)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Drawer and Bin number:"
        '
        'txtDrawerBin
        '
        Me.txtDrawerBin.BackColor = System.Drawing.Color.White
        Me.txtDrawerBin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrawerBin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDrawerBin.Location = New System.Drawing.Point(35, 145)
        Me.txtDrawerBin.MaxLength = 9
        Me.txtDrawerBin.Name = "txtDrawerBin"
        Me.txtDrawerBin.ReadOnly = True
        Me.txtDrawerBin.ShortcutsEnabled = False
        Me.txtDrawerBin.Size = New System.Drawing.Size(293, 29)
        Me.txtDrawerBin.TabIndex = 2
        Me.txtDrawerBin.TabStop = False
        '
        'txtMRN
        '
        Me.txtMRN.BackColor = System.Drawing.Color.White
        Me.txtMRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMRN.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtMRN.Location = New System.Drawing.Point(34, 372)
        Me.txtMRN.MaxLength = 9
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.ReadOnly = True
        Me.txtMRN.ShortcutsEnabled = False
        Me.txtMRN.Size = New System.Drawing.Size(294, 29)
        Me.txtMRN.TabIndex = 8
        Me.txtMRN.TabStop = False
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.BackColor = System.Drawing.Color.White
        Me.txtDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDateOfBirth.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDateOfBirth.Location = New System.Drawing.Point(710, 216)
        Me.txtDateOfBirth.MaxLength = 9
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.ReadOnly = True
        Me.txtDateOfBirth.ShortcutsEnabled = False
        Me.txtDateOfBirth.Size = New System.Drawing.Size(322, 29)
        Me.txtDateOfBirth.TabIndex = 6
        Me.txtDateOfBirth.TabStop = False
        '
        'txtRoomBed
        '
        Me.txtRoomBed.BackColor = System.Drawing.Color.White
        Me.txtRoomBed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoomBed.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtRoomBed.Location = New System.Drawing.Point(33, 443)
        Me.txtRoomBed.MaxLength = 9
        Me.txtRoomBed.Name = "txtRoomBed"
        Me.txtRoomBed.ReadOnly = True
        Me.txtRoomBed.ShortcutsEnabled = False
        Me.txtRoomBed.Size = New System.Drawing.Size(294, 29)
        Me.txtRoomBed.TabIndex = 6
        Me.txtRoomBed.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 21)
        Me.Label6.TabIndex = 224
        Me.Label6.Text = "Patient Room and Bed:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(892, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 21)
        Me.Label5.TabIndex = 229
        Me.Label5.Text = "Unit:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(706, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 21)
        Me.Label7.TabIndex = 228
        Me.Label7.Text = "Ordered Amount:"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAmount.Location = New System.Drawing.Point(710, 148)
        Me.txtAmount.MaxLength = 5
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ShortcutsEnabled = False
        Me.txtAmount.Size = New System.Drawing.Size(172, 29)
        Me.txtAmount.TabIndex = 2
        '
        'txtUnit
        '
        Me.txtUnit.BackColor = System.Drawing.Color.White
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUnit.Location = New System.Drawing.Point(896, 148)
        Me.txtUnit.MaxLength = 5
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.ShortcutsEnabled = False
        Me.txtUnit.Size = New System.Drawing.Size(150, 29)
        Me.txtUnit.TabIndex = 4
        Me.txtUnit.TabStop = False
        '
        'frmAdHockDispense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1203, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRoomBed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDateOfBirth)
        Me.Controls.Add(Me.txtMRN)
        Me.Controls.Add(Me.txtDrawerBin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtStrength)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbPatientName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnDispense)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbMedications)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lstboxAllergies)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmAdHockDispense"
        Me.Text = "frmAdHockDispense"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As Label
    Friend WithEvents btnDispense As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMedications As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lstboxAllergies As ListBox
    Friend WithEvents cmbPatientName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStrength As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDrawerBin As TextBox
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents txtRoomBed As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtUnit As TextBox
End Class
