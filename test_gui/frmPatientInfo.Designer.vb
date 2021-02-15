<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientInfo))
        Me.LblPatientName = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPhysician = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlPersonalInformation = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtBed = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.flpDispenseHistory = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.flpMedications = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lstBoxAllergies = New System.Windows.Forms.ListBox()
        Me.btnWaste = New System.Windows.Forms.Button()
        Me.btnDispenseMedication = New System.Windows.Forms.Button()
        Me.btnEditPatient = New System.Windows.Forms.Button()
        Me.btnAddAllergies = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlPersonalInformation.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblPatientName
        '
        Me.LblPatientName.AutoSize = True
        Me.LblPatientName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPatientName.ForeColor = System.Drawing.Color.Black
        Me.LblPatientName.Location = New System.Drawing.Point(6, 5)
        Me.LblPatientName.Name = "LblPatientName"
        Me.LblPatientName.Size = New System.Drawing.Size(140, 25)
        Me.LblPatientName.TabIndex = 0
        Me.LblPatientName.Text = "Fill Name Here"
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.White
        Me.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(13, 127)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(150, 29)
        Me.txtGender.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label19.Location = New System.Drawing.Point(13, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 21)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Sex:"
        '
        'txtPhysician
        '
        Me.txtPhysician.BackColor = System.Drawing.Color.White
        Me.txtPhysician.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhysician.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysician.Location = New System.Drawing.Point(207, 253)
        Me.txtPhysician.Name = "txtPhysician"
        Me.txtPhysician.ReadOnly = True
        Me.txtPhysician.Size = New System.Drawing.Size(151, 29)
        Me.txtPhysician.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(204, 229)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 21)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Primary Physician"
        '
        'pnlPersonalInformation
        '
        Me.pnlPersonalInformation.BackColor = System.Drawing.Color.White
        Me.pnlPersonalInformation.Controls.Add(Me.Label15)
        Me.pnlPersonalInformation.Controls.Add(Me.Label14)
        Me.pnlPersonalInformation.Controls.Add(Me.txtPhone)
        Me.pnlPersonalInformation.Controls.Add(Me.Label13)
        Me.pnlPersonalInformation.Controls.Add(Me.txtEmail)
        Me.pnlPersonalInformation.Controls.Add(Me.txtAddress)
        Me.pnlPersonalInformation.Controls.Add(Me.txtMRN)
        Me.pnlPersonalInformation.Controls.Add(Me.Label12)
        Me.pnlPersonalInformation.Controls.Add(Me.Label21)
        Me.pnlPersonalInformation.Controls.Add(Me.txtBed)
        Me.pnlPersonalInformation.Controls.Add(Me.Label17)
        Me.pnlPersonalInformation.Controls.Add(Me.txtRoom)
        Me.pnlPersonalInformation.Controls.Add(Me.Label10)
        Me.pnlPersonalInformation.Controls.Add(Me.txtWeight)
        Me.pnlPersonalInformation.Controls.Add(Me.Label8)
        Me.pnlPersonalInformation.Controls.Add(Me.txtHeight)
        Me.pnlPersonalInformation.Controls.Add(Me.Label3)
        Me.pnlPersonalInformation.Controls.Add(Me.txtGender)
        Me.pnlPersonalInformation.Controls.Add(Me.LblPatientName)
        Me.pnlPersonalInformation.Controls.Add(Me.Label19)
        Me.pnlPersonalInformation.Controls.Add(Me.txtBirthday)
        Me.pnlPersonalInformation.Controls.Add(Me.txtPhysician)
        Me.pnlPersonalInformation.Controls.Add(Me.Label16)
        Me.pnlPersonalInformation.Controls.Add(Me.Label11)
        Me.pnlPersonalInformation.ForeColor = System.Drawing.Color.Gainsboro
        Me.pnlPersonalInformation.Location = New System.Drawing.Point(12, 44)
        Me.pnlPersonalInformation.Name = "pnlPersonalInformation"
        Me.pnlPersonalInformation.Size = New System.Drawing.Size(364, 428)
        Me.pnlPersonalInformation.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(205, 355)
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
        Me.Label14.Location = New System.Drawing.Point(9, 355)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 21)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Email:"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(207, 379)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(151, 29)
        Me.txtPhone.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(9, 289)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 21)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Address:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(12, 379)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(151, 29)
        Me.txtEmail.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(12, 313)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(346, 29)
        Me.txtAddress.TabIndex = 8
        '
        'txtMRN
        '
        Me.txtMRN.BackColor = System.Drawing.Color.White
        Me.txtMRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMRN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRN.Location = New System.Drawing.Point(13, 67)
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.ReadOnly = True
        Me.txtMRN.Size = New System.Drawing.Size(150, 29)
        Me.txtMRN.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(8, 44)
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
        Me.Label21.Location = New System.Drawing.Point(9, 229)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 21)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Bed:"
        '
        'txtBed
        '
        Me.txtBed.BackColor = System.Drawing.Color.White
        Me.txtBed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBed.Location = New System.Drawing.Point(13, 253)
        Me.txtBed.Name = "txtBed"
        Me.txtBed.ReadOnly = True
        Me.txtBed.Size = New System.Drawing.Size(150, 29)
        Me.txtBed.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(203, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 21)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Room:"
        '
        'txtRoom
        '
        Me.txtRoom.BackColor = System.Drawing.Color.White
        Me.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom.Location = New System.Drawing.Point(207, 191)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.ReadOnly = True
        Me.txtRoom.Size = New System.Drawing.Size(151, 29)
        Me.txtRoom.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(280, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 21)
        Me.Label10.TabIndex = 43
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.White
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(13, 191)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(150, 29)
        Me.txtWeight.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(9, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 21)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Weight:"
        '
        'txtHeight
        '
        Me.txtHeight.BackColor = System.Drawing.Color.White
        Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(207, 127)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.Size = New System.Drawing.Size(151, 29)
        Me.txtHeight.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(203, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Height:"
        '
        'txtBirthday
        '
        Me.txtBirthday.BackColor = System.Drawing.Color.White
        Me.txtBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBirthday.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthday.Location = New System.Drawing.Point(208, 67)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.ReadOnly = True
        Me.txtBirthday.Size = New System.Drawing.Size(150, 29)
        Me.txtBirthday.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(203, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 21)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "DOB:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 25)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Allergies"
        '
        'flpDispenseHistory
        '
        Me.flpDispenseHistory.AutoScroll = True
        Me.flpDispenseHistory.BackColor = System.Drawing.Color.White
        Me.flpDispenseHistory.Location = New System.Drawing.Point(385, 138)
        Me.flpDispenseHistory.Name = "flpDispenseHistory"
        Me.flpDispenseHistory.Size = New System.Drawing.Size(846, 317)
        Me.flpDispenseHistory.TabIndex = 48
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Location = New System.Drawing.Point(385, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(846, 47)
        Me.Panel2.TabIndex = 47
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label24.Location = New System.Drawing.Point(441, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 21)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Quantity"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(11, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(140, 21)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Medication Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(323, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Method"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label23.Location = New System.Drawing.Point(564, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(108, 21)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Dispensed By"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label25.Location = New System.Drawing.Point(731, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(87, 21)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Date/Time"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label29.Location = New System.Drawing.Point(212, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 21)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Strength"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(385, 50)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(157, 25)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "Dispense History"
        '
        'flpMedications
        '
        Me.flpMedications.AutoScroll = True
        Me.flpMedications.BackColor = System.Drawing.Color.White
        Me.flpMedications.Location = New System.Drawing.Point(231, 541)
        Me.flpMedications.Name = "flpMedications"
        Me.flpMedications.Size = New System.Drawing.Size(1037, 180)
        Me.flpMedications.TabIndex = 51
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(226, 465)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 25)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Prescriptions"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Location = New System.Drawing.Point(231, 494)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1037, 47)
        Me.Panel3.TabIndex = 48
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(849, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(110, 21)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "Prescribed By"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label28.Location = New System.Drawing.Point(685, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(126, 21)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "Date Prescribed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(568, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(5, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 21)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Medication Name"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label26.Location = New System.Drawing.Point(462, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 21)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "Method"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label27.Location = New System.Drawing.Point(202, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 21)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "Strength"
        '
        'lstBoxAllergies
        '
        Me.lstBoxAllergies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstBoxAllergies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxAllergies.FormattingEnabled = True
        Me.lstBoxAllergies.ItemHeight = 20
        Me.lstBoxAllergies.Location = New System.Drawing.Point(12, 538)
        Me.lstBoxAllergies.Name = "lstBoxAllergies"
        Me.lstBoxAllergies.Size = New System.Drawing.Size(201, 182)
        Me.lstBoxAllergies.TabIndex = 58
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
        Me.btnWaste.Location = New System.Drawing.Point(638, 0)
        Me.btnWaste.Name = "btnWaste"
        Me.btnWaste.Size = New System.Drawing.Size(107, 37)
        Me.btnWaste.TabIndex = 11
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
        Me.btnDispenseMedication.Location = New System.Drawing.Point(762, 0)
        Me.btnDispenseMedication.Name = "btnDispenseMedication"
        Me.btnDispenseMedication.Size = New System.Drawing.Size(236, 37)
        Me.btnDispenseMedication.TabIndex = 12
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
        Me.btnEditPatient.Location = New System.Drawing.Point(1015, 0)
        Me.btnEditPatient.Name = "btnEditPatient"
        Me.btnEditPatient.Size = New System.Drawing.Size(173, 37)
        Me.btnEditPatient.TabIndex = 13
        Me.btnEditPatient.Text = "  Edit Patient"
        Me.btnEditPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditPatient.UseVisualStyleBackColor = False
        '
        'btnAddAllergies
        '
        Me.btnAddAllergies.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAddAllergies.FlatAppearance.BorderSize = 0
        Me.btnAddAllergies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAllergies.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAllergies.ForeColor = System.Drawing.Color.White
        Me.btnAddAllergies.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddAllergies.Location = New System.Drawing.Point(12, 494)
        Me.btnAddAllergies.Name = "btnAddAllergies"
        Me.btnAddAllergies.Size = New System.Drawing.Size(201, 37)
        Me.btnAddAllergies.TabIndex = 59
        Me.btnAddAllergies.Text = "  Add Allergies"
        Me.btnAddAllergies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddAllergies.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(344, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Frequency"
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
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnWaste)
        Me.Panel1.Controls.Add(Me.btnEditPatient)
        Me.Panel1.Controls.Add(Me.btnDispenseMedication)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1274, 46)
        Me.Panel1.TabIndex = 60
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
        Me.btnBack.Location = New System.Drawing.Point(17, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 37)
        Me.btnBack.TabIndex = 61
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmPatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1274, 730)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAddAllergies)
        Me.Controls.Add(Me.lstBoxAllergies)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.flpMedications)
        Me.Controls.Add(Me.flpDispenseHistory)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnlPersonalInformation)
        Me.Controls.Add(Me.Label18)
        Me.Name = "frmPatientInfo"
        Me.Text = "frmPatientInfo"
        Me.pnlPersonalInformation.ResumeLayout(False)
        Me.pnlPersonalInformation.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtBed As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents flpDispenseHistory As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnDispenseMedication As Button
    Friend WithEvents btnWaste As Button
    Friend WithEvents flpMedications As FlowLayoutPanel
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lstBoxAllergies As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents btnAddAllergies As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
End Class
