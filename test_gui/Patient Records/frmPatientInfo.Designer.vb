﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatientInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientInfo))
        Me.LblPatientName = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPhysician = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlPersonalInformation = New System.Windows.Forms.Panel()
        Me.mtbBirthday = New System.Windows.Forms.MaskedTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.btnAddAllergies = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstBoxAllergies = New System.Windows.Forms.ListBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.cboBed = New System.Windows.Forms.ComboBox()
        Me.cboRoom = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.flpMedications = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.pnlPrescriptionsHeader = New System.Windows.Forms.Panel()
        Me.lblFrequencyPrescription = New System.Windows.Forms.Label()
        Me.lblPrescribedBy = New System.Windows.Forms.Label()
        Me.lblDatePrescribed = New System.Windows.Forms.Label()
        Me.lblQuantityPrescription = New System.Windows.Forms.Label()
        Me.lblMedicationPrescription = New System.Windows.Forms.Label()
        Me.lblTypePrescription = New System.Windows.Forms.Label()
        Me.lblStrengthPrescription = New System.Windows.Forms.Label()
        Me.btnWaste = New System.Windows.Forms.Button()
        Me.btnDispenseMedication = New System.Windows.Forms.Button()
        Me.btnEditPatient = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlNameBarcode = New System.Windows.Forms.Panel()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlDispenseHistoryHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblDispensedBy = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.flpDispenseHistory = New System.Windows.Forms.FlowLayoutPanel()
        Me.tpLabelDirections = New System.Windows.Forms.ToolTip(Me.components)
        Me.tpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlPersonalInformation.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlPrescriptionsHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlNameBarcode.SuspendLayout()
        Me.pnlDispenseHistoryHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblPatientName
        '
        Me.LblPatientName.AutoSize = True
        Me.LblPatientName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPatientName.ForeColor = System.Drawing.Color.Black
        Me.LblPatientName.Location = New System.Drawing.Point(213, 12)
        Me.LblPatientName.Name = "LblPatientName"
        Me.LblPatientName.Size = New System.Drawing.Size(140, 25)
        Me.LblPatientName.TabIndex = 1
        Me.LblPatientName.Text = "Fill Name Here"
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.White
        Me.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(383, 30)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.ShortcutsEnabled = False
        Me.txtGender.Size = New System.Drawing.Size(151, 25)
        Me.txtGender.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label19.Location = New System.Drawing.Point(379, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 21)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Sex:"
        '
        'txtPhysician
        '
        Me.txtPhysician.BackColor = System.Drawing.Color.White
        Me.txtPhysician.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhysician.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysician.Location = New System.Drawing.Point(383, 91)
        Me.txtPhysician.Name = "txtPhysician"
        Me.txtPhysician.ReadOnly = True
        Me.txtPhysician.ShortcutsEnabled = False
        Me.txtPhysician.Size = New System.Drawing.Size(151, 25)
        Me.txtPhysician.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(380, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(140, 21)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Primary Physician:"
        '
        'pnlPersonalInformation
        '
        Me.pnlPersonalInformation.BackColor = System.Drawing.Color.White
        Me.pnlPersonalInformation.Controls.Add(Me.mtbBirthday)
        Me.pnlPersonalInformation.Controls.Add(Me.Panel2)
        Me.pnlPersonalInformation.Controls.Add(Me.cboState)
        Me.pnlPersonalInformation.Controls.Add(Me.btnAddAllergies)
        Me.pnlPersonalInformation.Controls.Add(Me.Label2)
        Me.pnlPersonalInformation.Controls.Add(Me.lstBoxAllergies)
        Me.pnlPersonalInformation.Controls.Add(Me.txtZipCode)
        Me.pnlPersonalInformation.Controls.Add(Me.Label1)
        Me.pnlPersonalInformation.Controls.Add(Me.txtCity)
        Me.pnlPersonalInformation.Controls.Add(Me.cboBed)
        Me.pnlPersonalInformation.Controls.Add(Me.cboRoom)
        Me.pnlPersonalInformation.Controls.Add(Me.Label15)
        Me.pnlPersonalInformation.Controls.Add(Me.Label14)
        Me.pnlPersonalInformation.Controls.Add(Me.Label13)
        Me.pnlPersonalInformation.Controls.Add(Me.txtEmail)
        Me.pnlPersonalInformation.Controls.Add(Me.txtAddress)
        Me.pnlPersonalInformation.Controls.Add(Me.txtMRN)
        Me.pnlPersonalInformation.Controls.Add(Me.Label12)
        Me.pnlPersonalInformation.Controls.Add(Me.Label21)
        Me.pnlPersonalInformation.Controls.Add(Me.Label17)
        Me.pnlPersonalInformation.Controls.Add(Me.Label10)
        Me.pnlPersonalInformation.Controls.Add(Me.txtWeight)
        Me.pnlPersonalInformation.Controls.Add(Me.Label8)
        Me.pnlPersonalInformation.Controls.Add(Me.txtHeight)
        Me.pnlPersonalInformation.Controls.Add(Me.Label3)
        Me.pnlPersonalInformation.Controls.Add(Me.txtGender)
        Me.pnlPersonalInformation.Controls.Add(Me.Label19)
        Me.pnlPersonalInformation.Controls.Add(Me.txtPhysician)
        Me.pnlPersonalInformation.Controls.Add(Me.Label16)
        Me.pnlPersonalInformation.Controls.Add(Me.Label11)
        Me.pnlPersonalInformation.ForeColor = System.Drawing.Color.Gainsboro
        Me.pnlPersonalInformation.Location = New System.Drawing.Point(-1, 44)
        Me.pnlPersonalInformation.Name = "pnlPersonalInformation"
        Me.pnlPersonalInformation.Size = New System.Drawing.Size(1092, 184)
        Me.pnlPersonalInformation.TabIndex = 17
        '
        'mtbBirthday
        '
        Me.mtbBirthday.Location = New System.Drawing.Point(199, 33)
        Me.mtbBirthday.Mask = "00/00/0000"
        Me.mtbBirthday.Name = "mtbBirthday"
        Me.mtbBirthday.ReadOnly = True
        Me.mtbBirthday.Size = New System.Drawing.Size(151, 20)
        Me.mtbBirthday.TabIndex = 1
        Me.mtbBirthday.ValidatingType = GetType(Date)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtPhone)
        Me.Panel2.ForeColor = System.Drawing.Color.DarkGray
        Me.Panel2.Location = New System.Drawing.Point(754, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(148, 25)
        Me.Panel2.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPhone.Location = New System.Drawing.Point(1, 1)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ShortcutsEnabled = False
        Me.txtPhone.Size = New System.Drawing.Size(144, 22)
        Me.txtPhone.TabIndex = 0
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(567, 150)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(151, 25)
        Me.cboState.TabIndex = 14
        '
        'btnAddAllergies
        '
        Me.btnAddAllergies.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAddAllergies.FlatAppearance.BorderSize = 0
        Me.btnAddAllergies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAllergies.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAllergies.ForeColor = System.Drawing.Color.White
        Me.btnAddAllergies.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddAllergies.Location = New System.Drawing.Point(919, 8)
        Me.btnAddAllergies.Name = "btnAddAllergies"
        Me.btnAddAllergies.Size = New System.Drawing.Size(161, 37)
        Me.btnAddAllergies.TabIndex = 10
        Me.btnAddAllergies.Text = "  Add Allergies"
        Me.btnAddAllergies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddAllergies.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(563, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "State:"
        '
        'lstBoxAllergies
        '
        Me.lstBoxAllergies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstBoxAllergies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxAllergies.FormattingEnabled = True
        Me.lstBoxAllergies.ItemHeight = 20
        Me.lstBoxAllergies.Location = New System.Drawing.Point(919, 51)
        Me.lstBoxAllergies.Name = "lstBoxAllergies"
        Me.lstBoxAllergies.Size = New System.Drawing.Size(161, 122)
        Me.lstBoxAllergies.TabIndex = 11
        '
        'txtZipCode
        '
        Me.txtZipCode.BackColor = System.Drawing.Color.White
        Me.txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZipCode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(751, 150)
        Me.txtZipCode.MaxLength = 9
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.ReadOnly = True
        Me.txtZipCode.ShortcutsEnabled = False
        Me.txtZipCode.Size = New System.Drawing.Size(151, 25)
        Me.txtZipCode.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(379, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 21)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(383, 150)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.ShortcutsEnabled = False
        Me.txtCity.Size = New System.Drawing.Size(151, 25)
        Me.txtCity.TabIndex = 13
        '
        'cboBed
        '
        Me.cboBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBed.FormattingEnabled = True
        Me.cboBed.Location = New System.Drawing.Point(198, 91)
        Me.cboBed.Name = "cboBed"
        Me.cboBed.Size = New System.Drawing.Size(152, 25)
        Me.cboBed.TabIndex = 6
        '
        'cboRoom
        '
        Me.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoom.FormattingEnabled = True
        Me.cboRoom.Location = New System.Drawing.Point(14, 91)
        Me.cboRoom.Name = "cboRoom"
        Me.cboRoom.Size = New System.Drawing.Size(151, 25)
        Me.cboRoom.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(749, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 21)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Phone:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(562, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 21)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Email:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(9, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 21)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Street Address:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(567, 89)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.ShortcutsEnabled = False
        Me.txtEmail.Size = New System.Drawing.Size(151, 25)
        Me.txtEmail.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(13, 150)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.ShortcutsEnabled = False
        Me.txtAddress.Size = New System.Drawing.Size(337, 25)
        Me.txtAddress.TabIndex = 12
        '
        'txtMRN
        '
        Me.txtMRN.BackColor = System.Drawing.Color.White
        Me.txtMRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMRN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRN.Location = New System.Drawing.Point(13, 30)
        Me.txtMRN.MaxLength = 9
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.ReadOnly = True
        Me.txtMRN.ShortcutsEnabled = False
        Me.txtMRN.Size = New System.Drawing.Size(150, 25)
        Me.txtMRN.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(8, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 21)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "MRN:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label21.Location = New System.Drawing.Point(195, 67)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 21)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Bed:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(10, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 21)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Room:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(747, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 21)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Zip Code:"
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.White
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeight.CausesValidation = False
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(754, 31)
        Me.txtWeight.MaxLength = 5
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.ShortcutsEnabled = False
        Me.txtWeight.Size = New System.Drawing.Size(148, 25)
        Me.txtWeight.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(750, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 21)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Weight:"
        '
        'txtHeight
        '
        Me.txtHeight.BackColor = System.Drawing.Color.White
        Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(568, 30)
        Me.txtHeight.MaxLength = 5
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.ShortcutsEnabled = False
        Me.txtHeight.Size = New System.Drawing.Size(150, 25)
        Me.txtHeight.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(564, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Height:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(194, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 21)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "DOB:"
        '
        'flpMedications
        '
        Me.flpMedications.AutoScroll = True
        Me.flpMedications.BackColor = System.Drawing.Color.White
        Me.flpMedications.Location = New System.Drawing.Point(12, 307)
        Me.flpMedications.Name = "flpMedications"
        Me.flpMedications.Size = New System.Drawing.Size(1067, 140)
        Me.flpMedications.TabIndex = 51
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 231)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 25)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Prescriptions"
        '
        'pnlPrescriptionsHeader
        '
        Me.pnlPrescriptionsHeader.BackColor = System.Drawing.Color.White
        Me.pnlPrescriptionsHeader.Controls.Add(Me.lblFrequencyPrescription)
        Me.pnlPrescriptionsHeader.Controls.Add(Me.lblPrescribedBy)
        Me.pnlPrescriptionsHeader.Controls.Add(Me.lblDatePrescribed)
        Me.pnlPrescriptionsHeader.Controls.Add(Me.lblQuantityPrescription)
        Me.pnlPrescriptionsHeader.Controls.Add(Me.lblMedicationPrescription)
        Me.pnlPrescriptionsHeader.Controls.Add(Me.lblTypePrescription)
        Me.pnlPrescriptionsHeader.Controls.Add(Me.lblStrengthPrescription)
        Me.pnlPrescriptionsHeader.Location = New System.Drawing.Point(12, 260)
        Me.pnlPrescriptionsHeader.Name = "pnlPrescriptionsHeader"
        Me.pnlPrescriptionsHeader.Size = New System.Drawing.Size(1067, 47)
        Me.pnlPrescriptionsHeader.TabIndex = 48
        '
        'lblFrequencyPrescription
        '
        Me.lblFrequencyPrescription.AutoSize = True
        Me.lblFrequencyPrescription.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrequencyPrescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFrequencyPrescription.Location = New System.Drawing.Point(917, 16)
        Me.lblFrequencyPrescription.Name = "lblFrequencyPrescription"
        Me.lblFrequencyPrescription.Size = New System.Drawing.Size(86, 21)
        Me.lblFrequencyPrescription.TabIndex = 6
        Me.lblFrequencyPrescription.Tag = "7"
        Me.lblFrequencyPrescription.Text = "Frequency"
        '
        'lblPrescribedBy
        '
        Me.lblPrescribedBy.AutoSize = True
        Me.lblPrescribedBy.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrescribedBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPrescribedBy.Location = New System.Drawing.Point(741, 16)
        Me.lblPrescribedBy.Name = "lblPrescribedBy"
        Me.lblPrescribedBy.Size = New System.Drawing.Size(110, 21)
        Me.lblPrescribedBy.TabIndex = 5
        Me.lblPrescribedBy.Tag = "6"
        Me.lblPrescribedBy.Text = "Prescribed By"
        '
        'lblDatePrescribed
        '
        Me.lblDatePrescribed.AutoSize = True
        Me.lblDatePrescribed.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatePrescribed.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDatePrescribed.Location = New System.Drawing.Point(545, 16)
        Me.lblDatePrescribed.Name = "lblDatePrescribed"
        Me.lblDatePrescribed.Size = New System.Drawing.Size(126, 21)
        Me.lblDatePrescribed.TabIndex = 4
        Me.lblDatePrescribed.Tag = "5"
        Me.lblDatePrescribed.Text = "Date Prescribed"
        '
        'lblQuantityPrescription
        '
        Me.lblQuantityPrescription.AutoSize = True
        Me.lblQuantityPrescription.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityPrescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblQuantityPrescription.Location = New System.Drawing.Point(453, 16)
        Me.lblQuantityPrescription.Name = "lblQuantityPrescription"
        Me.lblQuantityPrescription.Size = New System.Drawing.Size(72, 21)
        Me.lblQuantityPrescription.TabIndex = 3
        Me.lblQuantityPrescription.Tag = "4"
        Me.lblQuantityPrescription.Text = "Quantity"
        '
        'lblMedicationPrescription
        '
        Me.lblMedicationPrescription.AutoSize = True
        Me.lblMedicationPrescription.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicationPrescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMedicationPrescription.Location = New System.Drawing.Point(5, 16)
        Me.lblMedicationPrescription.Name = "lblMedicationPrescription"
        Me.lblMedicationPrescription.Size = New System.Drawing.Size(140, 21)
        Me.lblMedicationPrescription.TabIndex = 0
        Me.lblMedicationPrescription.Tag = "1"
        Me.lblMedicationPrescription.Text = "Medication Name"
        '
        'lblTypePrescription
        '
        Me.lblTypePrescription.AutoSize = True
        Me.lblTypePrescription.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypePrescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTypePrescription.Location = New System.Drawing.Point(332, 16)
        Me.lblTypePrescription.Name = "lblTypePrescription"
        Me.lblTypePrescription.Size = New System.Drawing.Size(45, 21)
        Me.lblTypePrescription.TabIndex = 2
        Me.lblTypePrescription.Tag = "3"
        Me.lblTypePrescription.Text = "Type"
        '
        'lblStrengthPrescription
        '
        Me.lblStrengthPrescription.AutoSize = True
        Me.lblStrengthPrescription.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrengthPrescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblStrengthPrescription.Location = New System.Drawing.Point(202, 16)
        Me.lblStrengthPrescription.Name = "lblStrengthPrescription"
        Me.lblStrengthPrescription.Size = New System.Drawing.Size(74, 21)
        Me.lblStrengthPrescription.TabIndex = 1
        Me.lblStrengthPrescription.Tag = "2"
        Me.lblStrengthPrescription.Text = "Strength"
        '
        'btnWaste
        '
        Me.btnWaste.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnWaste.FlatAppearance.BorderSize = 0
        Me.btnWaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWaste.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaste.ForeColor = System.Drawing.Color.White
        Me.btnWaste.Image = CType(resources.GetObject("btnWaste.Image"), System.Drawing.Image)
        Me.btnWaste.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnWaste.Location = New System.Drawing.Point(561, 6)
        Me.btnWaste.Name = "btnWaste"
        Me.btnWaste.Size = New System.Drawing.Size(107, 37)
        Me.btnWaste.TabIndex = 2
        Me.btnWaste.Text = "  Waste"
        Me.btnWaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWaste.UseVisualStyleBackColor = False
        '
        'btnDispenseMedication
        '
        Me.btnDispenseMedication.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDispenseMedication.FlatAppearance.BorderSize = 0
        Me.btnDispenseMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispenseMedication.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispenseMedication.ForeColor = System.Drawing.Color.White
        Me.btnDispenseMedication.Image = CType(resources.GetObject("btnDispenseMedication.Image"), System.Drawing.Image)
        Me.btnDispenseMedication.Location = New System.Drawing.Point(677, 6)
        Me.btnDispenseMedication.Name = "btnDispenseMedication"
        Me.btnDispenseMedication.Size = New System.Drawing.Size(235, 37)
        Me.btnDispenseMedication.TabIndex = 3
        Me.btnDispenseMedication.Text = "  Dispense Medication"
        Me.btnDispenseMedication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDispenseMedication.UseVisualStyleBackColor = False
        '
        'btnEditPatient
        '
        Me.btnEditPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnEditPatient.FlatAppearance.BorderSize = 0
        Me.btnEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPatient.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPatient.ForeColor = System.Drawing.Color.White
        Me.btnEditPatient.Image = CType(resources.GetObject("btnEditPatient.Image"), System.Drawing.Image)
        Me.btnEditPatient.Location = New System.Drawing.Point(918, 6)
        Me.btnEditPatient.Name = "btnEditPatient"
        Me.btnEditPatient.Size = New System.Drawing.Size(170, 37)
        Me.btnEditPatient.TabIndex = 4
        Me.btnEditPatient.Text = "  Edit Patient"
        Me.btnEditPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditPatient.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(118, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 21)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Charts/Documents"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pnlNameBarcode)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnWaste)
        Me.Panel1.Controls.Add(Me.btnEditPatient)
        Me.Panel1.Controls.Add(Me.btnDispenseMedication)
        Me.Panel1.Controls.Add(Me.LblPatientName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1091, 46)
        Me.Panel1.TabIndex = 60
        '
        'pnlNameBarcode
        '
        Me.pnlNameBarcode.BackColor = System.Drawing.Color.White
        Me.pnlNameBarcode.Controls.Add(Me.txtBarcode)
        Me.pnlNameBarcode.Controls.Add(Me.txtLast)
        Me.pnlNameBarcode.Controls.Add(Me.txtMiddle)
        Me.pnlNameBarcode.Controls.Add(Me.txtFirstName)
        Me.pnlNameBarcode.Controls.Add(Me.Label7)
        Me.pnlNameBarcode.Controls.Add(Me.Label6)
        Me.pnlNameBarcode.Controls.Add(Me.Label5)
        Me.pnlNameBarcode.Controls.Add(Me.Label4)
        Me.pnlNameBarcode.Location = New System.Drawing.Point(-1, 0)
        Me.pnlNameBarcode.Name = "pnlNameBarcode"
        Me.pnlNameBarcode.Size = New System.Drawing.Size(914, 48)
        Me.pnlNameBarcode.TabIndex = 64
        Me.pnlNameBarcode.Visible = False
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.White
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.CausesValidation = False
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(693, 12)
        Me.txtBarcode.MaxLength = 5
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.ShortcutsEnabled = False
        Me.txtBarcode.Size = New System.Drawing.Size(207, 25)
        Me.txtBarcode.TabIndex = 30
        '
        'txtLast
        '
        Me.txtLast.BackColor = System.Drawing.Color.White
        Me.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLast.CausesValidation = False
        Me.txtLast.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.Location = New System.Drawing.Point(466, 11)
        Me.txtLast.MaxLength = 5
        Me.txtLast.Name = "txtLast"
        Me.txtLast.ReadOnly = True
        Me.txtLast.ShortcutsEnabled = False
        Me.txtLast.Size = New System.Drawing.Size(148, 25)
        Me.txtLast.TabIndex = 29
        '
        'txtMiddle
        '
        Me.txtMiddle.BackColor = System.Drawing.Color.White
        Me.txtMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddle.CausesValidation = False
        Me.txtMiddle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddle.Location = New System.Drawing.Point(273, 11)
        Me.txtMiddle.MaxLength = 5
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.ReadOnly = True
        Me.txtMiddle.ShortcutsEnabled = False
        Me.txtMiddle.Size = New System.Drawing.Size(148, 25)
        Me.txtMiddle.TabIndex = 28
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.White
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.CausesValidation = False
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(52, 11)
        Me.txtFirstName.MaxLength = 5
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.ShortcutsEnabled = False
        Me.txtFirstName.Size = New System.Drawing.Size(148, 25)
        Me.txtFirstName.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(620, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 21)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Barcode: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(427, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Last:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(206, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Middle:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "First:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBack.Location = New System.Drawing.Point(23, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 37)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'pnlDispenseHistoryHeader
        '
        Me.pnlDispenseHistoryHeader.BackColor = System.Drawing.Color.White
        Me.pnlDispenseHistoryHeader.Controls.Add(Me.lblDateTime)
        Me.pnlDispenseHistoryHeader.Controls.Add(Me.lblDispensedBy)
        Me.pnlDispenseHistoryHeader.Controls.Add(Me.lblQuantity)
        Me.pnlDispenseHistoryHeader.Controls.Add(Me.lblMedication)
        Me.pnlDispenseHistoryHeader.Controls.Add(Me.lblType)
        Me.pnlDispenseHistoryHeader.Controls.Add(Me.lblStrength)
        Me.pnlDispenseHistoryHeader.Location = New System.Drawing.Point(12, 476)
        Me.pnlDispenseHistoryHeader.Name = "pnlDispenseHistoryHeader"
        Me.pnlDispenseHistoryHeader.Size = New System.Drawing.Size(1067, 47)
        Me.pnlDispenseHistoryHeader.TabIndex = 0
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDateTime.Location = New System.Drawing.Point(578, 16)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(157, 21)
        Me.lblDateTime.TabIndex = 4
        Me.lblDateTime.Tag = "6"
        Me.lblDateTime.Text = "Dispense Date/Time"
        '
        'lblDispensedBy
        '
        Me.lblDispensedBy.AutoSize = True
        Me.lblDispensedBy.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispensedBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDispensedBy.Location = New System.Drawing.Point(809, 16)
        Me.lblDispensedBy.Name = "lblDispensedBy"
        Me.lblDispensedBy.Size = New System.Drawing.Size(108, 21)
        Me.lblDispensedBy.TabIndex = 5
        Me.lblDispensedBy.Tag = "5"
        Me.lblDispensedBy.Text = "Dispensed By"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblQuantity.Location = New System.Drawing.Point(453, 16)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(72, 21)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Tag = "4"
        Me.lblQuantity.Text = "Quantity"
        '
        'lblMedication
        '
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedication.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblMedication.Location = New System.Drawing.Point(5, 16)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(140, 21)
        Me.lblMedication.TabIndex = 0
        Me.lblMedication.Tag = "1"
        Me.lblMedication.Text = "Medication Name"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblType.Location = New System.Drawing.Point(332, 16)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(45, 21)
        Me.lblType.TabIndex = 2
        Me.lblType.Tag = "3"
        Me.lblType.Text = "Type"
        '
        'lblStrength
        '
        Me.lblStrength.AutoSize = True
        Me.lblStrength.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrength.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblStrength.Location = New System.Drawing.Point(202, 16)
        Me.lblStrength.Name = "lblStrength"
        Me.lblStrength.Size = New System.Drawing.Size(74, 21)
        Me.lblStrength.TabIndex = 1
        Me.lblStrength.Tag = "2"
        Me.lblStrength.Text = "Strength"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 448)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(162, 25)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Dispense History:"
        '
        'flpDispenseHistory
        '
        Me.flpDispenseHistory.AutoScroll = True
        Me.flpDispenseHistory.BackColor = System.Drawing.Color.White
        Me.flpDispenseHistory.Location = New System.Drawing.Point(12, 523)
        Me.flpDispenseHistory.Name = "flpDispenseHistory"
        Me.flpDispenseHistory.Size = New System.Drawing.Size(1067, 140)
        Me.flpDispenseHistory.TabIndex = 1
        '
        'frmPatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1091, 672)
        Me.Controls.Add(Me.pnlDispenseHistoryHeader)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.flpDispenseHistory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlPrescriptionsHeader)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.flpMedications)
        Me.Controls.Add(Me.pnlPersonalInformation)
        Me.Controls.Add(Me.Label18)
        Me.Name = "frmPatientInfo"
        Me.Text = "frmPatientInfo"
        Me.pnlPersonalInformation.ResumeLayout(False)
        Me.pnlPersonalInformation.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlPrescriptionsHeader.ResumeLayout(False)
        Me.pnlPrescriptionsHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlNameBarcode.ResumeLayout(False)
        Me.pnlNameBarcode.PerformLayout()
        Me.pnlDispenseHistoryHeader.ResumeLayout(False)
        Me.pnlDispenseHistoryHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPatientName As Label
    Friend WithEvents pnlPersonalInformation As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEditPatient As Button
    Friend WithEvents txtPhysician As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDispenseMedication As Button
    Friend WithEvents btnWaste As Button
    Friend WithEvents flpMedications As FlowLayoutPanel
    Friend WithEvents Label20 As Label
    Friend WithEvents pnlPrescriptionsHeader As Panel
    Friend WithEvents lstBoxAllergies As ListBox
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblPrescribedBy As Label
    Friend WithEvents lblDatePrescribed As Label
    Friend WithEvents lblQuantityPrescription As Label
    Friend WithEvents lblMedicationPrescription As Label
    Friend WithEvents lblTypePrescription As Label
    Friend WithEvents lblStrengthPrescription As Label
    Friend WithEvents btnAddAllergies As Button
    Friend WithEvents lblFrequencyPrescription As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents cboBed As ComboBox
    Friend WithEvents cboRoom As ComboBox
    Friend WithEvents cboState As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents pnlDispenseHistoryHeader As Panel
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblDispensedBy As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblStrength As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents flpDispenseHistory As FlowLayoutPanel
    Friend WithEvents tpLabelDirections As ToolTip
    Friend WithEvents tpToolTip As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents mtbBirthday As MaskedTextBox
    Friend WithEvents pnlNameBarcode As Panel
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
