<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDischarge
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbAdmitPatients = New System.Windows.Forms.ComboBox()
        Me.btnAdmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbDischargePatients = New System.Windows.Forms.ComboBox()
        Me.btnDischarge = New System.Windows.Forms.Button()
        Me.pnlDischarge = New System.Windows.Forms.Panel()
        Me.pnlAdmit = New System.Windows.Forms.Panel()
        Me.pnlRadioButtons = New System.Windows.Forms.Panel()
        Me.radDischarge = New System.Windows.Forms.RadioButton()
        Me.radAdmitPatient = New System.Windows.Forms.RadioButton()
        Me.pnlInformation = New System.Windows.Forms.Panel()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.txtPhysician = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboRoomandBed = New System.Windows.Forms.ComboBox()
        Me.pnlAdmitRoomBed = New System.Windows.Forms.Panel()
        Me.pnlDischargeRoomBed = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBed = New System.Windows.Forms.TextBox()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlDischarge.SuspendLayout()
        Me.pnlAdmit.SuspendLayout()
        Me.pnlRadioButtons.SuspendLayout()
        Me.pnlInformation.SuspendLayout()
        Me.pnlAdmitRoomBed.SuspendLayout()
        Me.pnlDischargeRoomBed.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 21)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Select Patient to Admit:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.cmbAdmitPatients)
        Me.Panel3.Location = New System.Drawing.Point(6, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(437, 28)
        Me.Panel3.TabIndex = 1
        Me.Panel3.TabStop = True
        '
        'cmbAdmitPatients
        '
        Me.cmbAdmitPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAdmitPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdmitPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAdmitPatients.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAdmitPatients.FormattingEnabled = True
        Me.cmbAdmitPatients.Location = New System.Drawing.Point(1, 1)
        Me.cmbAdmitPatients.Name = "cmbAdmitPatients"
        Me.cmbAdmitPatients.Size = New System.Drawing.Size(435, 25)
        Me.cmbAdmitPatients.TabIndex = 5
        '
        'btnAdmit
        '
        Me.btnAdmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAdmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmit.ForeColor = System.Drawing.Color.White
        Me.btnAdmit.Image = Global.test_gui.My.Resources.Resources.resolve
        Me.btnAdmit.Location = New System.Drawing.Point(6, 91)
        Me.btnAdmit.Name = "btnAdmit"
        Me.btnAdmit.Size = New System.Drawing.Size(120, 38)
        Me.btnAdmit.TabIndex = 2
        Me.btnAdmit.Text = "  Admit"
        Me.btnAdmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdmit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 21)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Select Patient to Discharge:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.cmbDischargePatients)
        Me.Panel1.Location = New System.Drawing.Point(5, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(437, 28)
        Me.Panel1.TabIndex = 3
        Me.Panel1.TabStop = True
        '
        'cmbDischargePatients
        '
        Me.cmbDischargePatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDischargePatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDischargePatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDischargePatients.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDischargePatients.FormattingEnabled = True
        Me.cmbDischargePatients.Location = New System.Drawing.Point(1, 1)
        Me.cmbDischargePatients.Name = "cmbDischargePatients"
        Me.cmbDischargePatients.Size = New System.Drawing.Size(435, 25)
        Me.cmbDischargePatients.TabIndex = 5
        '
        'btnDischarge
        '
        Me.btnDischarge.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDischarge.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDischarge.ForeColor = System.Drawing.Color.White
        Me.btnDischarge.Image = Global.test_gui.My.Resources.Resources.resolve
        Me.btnDischarge.Location = New System.Drawing.Point(5, 87)
        Me.btnDischarge.Name = "btnDischarge"
        Me.btnDischarge.Size = New System.Drawing.Size(132, 38)
        Me.btnDischarge.TabIndex = 4
        Me.btnDischarge.Text = "  Discharge"
        Me.btnDischarge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDischarge.UseVisualStyleBackColor = False
        '
        'pnlDischarge
        '
        Me.pnlDischarge.Controls.Add(Me.Label1)
        Me.pnlDischarge.Controls.Add(Me.btnDischarge)
        Me.pnlDischarge.Controls.Add(Me.Panel1)
        Me.pnlDischarge.Location = New System.Drawing.Point(12, 64)
        Me.pnlDischarge.Name = "pnlDischarge"
        Me.pnlDischarge.Size = New System.Drawing.Size(469, 143)
        Me.pnlDischarge.TabIndex = 113
        Me.pnlDischarge.Visible = False
        '
        'pnlAdmit
        '
        Me.pnlAdmit.Controls.Add(Me.Label8)
        Me.pnlAdmit.Controls.Add(Me.btnAdmit)
        Me.pnlAdmit.Controls.Add(Me.Panel3)
        Me.pnlAdmit.Location = New System.Drawing.Point(12, 61)
        Me.pnlAdmit.Name = "pnlAdmit"
        Me.pnlAdmit.Size = New System.Drawing.Size(483, 146)
        Me.pnlAdmit.TabIndex = 114
        '
        'pnlRadioButtons
        '
        Me.pnlRadioButtons.Controls.Add(Me.radDischarge)
        Me.pnlRadioButtons.Controls.Add(Me.radAdmitPatient)
        Me.pnlRadioButtons.Location = New System.Drawing.Point(12, 12)
        Me.pnlRadioButtons.Name = "pnlRadioButtons"
        Me.pnlRadioButtons.Size = New System.Drawing.Size(317, 40)
        Me.pnlRadioButtons.TabIndex = 115
        '
        'radDischarge
        '
        Me.radDischarge.AutoSize = True
        Me.radDischarge.Location = New System.Drawing.Point(128, 11)
        Me.radDischarge.Name = "radDischarge"
        Me.radDischarge.Size = New System.Drawing.Size(109, 17)
        Me.radDischarge.TabIndex = 1
        Me.radDischarge.TabStop = True
        Me.radDischarge.Text = "Discharge Patient"
        Me.radDischarge.UseVisualStyleBackColor = True
        '
        'radAdmitPatient
        '
        Me.radAdmitPatient.AutoSize = True
        Me.radAdmitPatient.Checked = True
        Me.radAdmitPatient.Location = New System.Drawing.Point(3, 11)
        Me.radAdmitPatient.Name = "radAdmitPatient"
        Me.radAdmitPatient.Size = New System.Drawing.Size(87, 17)
        Me.radAdmitPatient.TabIndex = 0
        Me.radAdmitPatient.TabStop = True
        Me.radAdmitPatient.Text = "Admit Patient"
        Me.radAdmitPatient.UseVisualStyleBackColor = True
        '
        'pnlInformation
        '
        Me.pnlInformation.Controls.Add(Me.pnlAdmitRoomBed)
        Me.pnlInformation.Controls.Add(Me.pnlDischargeRoomBed)
        Me.pnlInformation.Controls.Add(Me.txtState)
        Me.pnlInformation.Controls.Add(Me.Label2)
        Me.pnlInformation.Controls.Add(Me.txtZipCode)
        Me.pnlInformation.Controls.Add(Me.Label3)
        Me.pnlInformation.Controls.Add(Me.txtCity)
        Me.pnlInformation.Controls.Add(Me.Label15)
        Me.pnlInformation.Controls.Add(Me.Label14)
        Me.pnlInformation.Controls.Add(Me.txtPhone)
        Me.pnlInformation.Controls.Add(Me.Label13)
        Me.pnlInformation.Controls.Add(Me.txtEmail)
        Me.pnlInformation.Controls.Add(Me.txtAddress)
        Me.pnlInformation.Controls.Add(Me.txtMRN)
        Me.pnlInformation.Controls.Add(Me.Label12)
        Me.pnlInformation.Controls.Add(Me.Label10)
        Me.pnlInformation.Controls.Add(Me.txtWeight)
        Me.pnlInformation.Controls.Add(Me.Label4)
        Me.pnlInformation.Controls.Add(Me.txtHeight)
        Me.pnlInformation.Controls.Add(Me.Label5)
        Me.pnlInformation.Controls.Add(Me.txtGender)
        Me.pnlInformation.Controls.Add(Me.Label19)
        Me.pnlInformation.Controls.Add(Me.txtBirthday)
        Me.pnlInformation.Controls.Add(Me.txtPhysician)
        Me.pnlInformation.Controls.Add(Me.Label16)
        Me.pnlInformation.Controls.Add(Me.Label11)
        Me.pnlInformation.Location = New System.Drawing.Point(12, 213)
        Me.pnlInformation.Name = "pnlInformation"
        Me.pnlInformation.Size = New System.Drawing.Size(958, 259)
        Me.pnlInformation.TabIndex = 116
        '
        'txtState
        '
        Me.txtState.BackColor = System.Drawing.Color.White
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(561, 167)
        Me.txtState.MaxLength = 9
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(151, 25)
        Me.txtState.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(558, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "State:"
        '
        'txtZipCode
        '
        Me.txtZipCode.BackColor = System.Drawing.Color.White
        Me.txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZipCode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(746, 166)
        Me.txtZipCode.MaxLength = 9
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.ReadOnly = True
        Me.txtZipCode.Size = New System.Drawing.Size(151, 25)
        Me.txtZipCode.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(374, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 21)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(378, 166)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(151, 25)
        Me.txtCity.TabIndex = 75
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(744, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 21)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "Phone:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(557, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 21)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Email:"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(748, 106)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(149, 25)
        Me.txtPhone.TabIndex = 72
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(4, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 21)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Street Address:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(562, 105)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(151, 25)
        Me.txtEmail.TabIndex = 71
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(8, 166)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(337, 25)
        Me.txtAddress.TabIndex = 73
        '
        'txtMRN
        '
        Me.txtMRN.BackColor = System.Drawing.Color.White
        Me.txtMRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMRN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRN.Location = New System.Drawing.Point(8, 46)
        Me.txtMRN.MaxLength = 9
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.ReadOnly = True
        Me.txtMRN.Size = New System.Drawing.Size(150, 25)
        Me.txtMRN.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(3, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 21)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "MRN:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(3, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 21)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Room and Bed:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(742, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 21)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Zip Code:"
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.White
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(749, 47)
        Me.txtWeight.MaxLength = 5
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(148, 25)
        Me.txtWeight.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(745, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Weight:"
        '
        'txtHeight
        '
        Me.txtHeight.BackColor = System.Drawing.Color.White
        Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(563, 46)
        Me.txtHeight.MaxLength = 5
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.Size = New System.Drawing.Size(150, 25)
        Me.txtHeight.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(559, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 21)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Height:"
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.White
        Me.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(378, 46)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(151, 25)
        Me.txtGender.TabIndex = 64
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label19.Location = New System.Drawing.Point(374, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 21)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Sex:"
        '
        'txtBirthday
        '
        Me.txtBirthday.BackColor = System.Drawing.Color.White
        Me.txtBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBirthday.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthday.Location = New System.Drawing.Point(193, 46)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.ReadOnly = True
        Me.txtBirthday.Size = New System.Drawing.Size(152, 25)
        Me.txtBirthday.TabIndex = 63
        '
        'txtPhysician
        '
        Me.txtPhysician.BackColor = System.Drawing.Color.White
        Me.txtPhysician.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhysician.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysician.Location = New System.Drawing.Point(378, 107)
        Me.txtPhysician.Name = "txtPhysician"
        Me.txtPhysician.ReadOnly = True
        Me.txtPhysician.Size = New System.Drawing.Size(151, 25)
        Me.txtPhysician.TabIndex = 70
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(375, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(140, 21)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Primary Physician:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(189, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 21)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "DOB:"
        '
        'cboRoomandBed
        '
        Me.cboRoomandBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoomandBed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoomandBed.FormattingEnabled = True
        Me.cboRoomandBed.Location = New System.Drawing.Point(5, 31)
        Me.cboRoomandBed.Name = "cboRoomandBed"
        Me.cboRoomandBed.Size = New System.Drawing.Size(333, 25)
        Me.cboRoomandBed.TabIndex = 118
        '
        'pnlAdmitRoomBed
        '
        Me.pnlAdmitRoomBed.Controls.Add(Me.Label17)
        Me.pnlAdmitRoomBed.Controls.Add(Me.cboRoomandBed)
        Me.pnlAdmitRoomBed.Location = New System.Drawing.Point(6, 77)
        Me.pnlAdmitRoomBed.Name = "pnlAdmitRoomBed"
        Me.pnlAdmitRoomBed.Size = New System.Drawing.Size(352, 66)
        Me.pnlAdmitRoomBed.TabIndex = 119
        '
        'pnlDischargeRoomBed
        '
        Me.pnlDischargeRoomBed.Controls.Add(Me.txtRoom)
        Me.pnlDischargeRoomBed.Controls.Add(Me.txtBed)
        Me.pnlDischargeRoomBed.Controls.Add(Me.Label7)
        Me.pnlDischargeRoomBed.Controls.Add(Me.Label6)
        Me.pnlDischargeRoomBed.Location = New System.Drawing.Point(8, 77)
        Me.pnlDischargeRoomBed.Name = "pnlDischargeRoomBed"
        Me.pnlDischargeRoomBed.Size = New System.Drawing.Size(352, 66)
        Me.pnlDischargeRoomBed.TabIndex = 120
        Me.pnlDischargeRoomBed.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 21)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Room:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(183, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 21)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Bed:"
        '
        'txtBed
        '
        Me.txtBed.BackColor = System.Drawing.Color.White
        Me.txtBed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBed.Location = New System.Drawing.Point(187, 24)
        Me.txtBed.MaxLength = 9
        Me.txtBed.Name = "txtBed"
        Me.txtBed.ReadOnly = True
        Me.txtBed.Size = New System.Drawing.Size(150, 25)
        Me.txtBed.TabIndex = 84
        '
        'txtRoom
        '
        Me.txtRoom.BackColor = System.Drawing.Color.White
        Me.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom.Location = New System.Drawing.Point(3, 24)
        Me.txtRoom.MaxLength = 9
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.ReadOnly = True
        Me.txtRoom.Size = New System.Drawing.Size(150, 25)
        Me.txtRoom.TabIndex = 85
        '
        'frmDischarge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 580)
        Me.Controls.Add(Me.pnlInformation)
        Me.Controls.Add(Me.pnlRadioButtons)
        Me.Controls.Add(Me.pnlAdmit)
        Me.Controls.Add(Me.pnlDischarge)
        Me.Name = "frmDischarge"
        Me.Text = "frmDischarge"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlDischarge.ResumeLayout(False)
        Me.pnlDischarge.PerformLayout()
        Me.pnlAdmit.ResumeLayout(False)
        Me.pnlAdmit.PerformLayout()
        Me.pnlRadioButtons.ResumeLayout(False)
        Me.pnlRadioButtons.PerformLayout()
        Me.pnlInformation.ResumeLayout(False)
        Me.pnlInformation.PerformLayout()
        Me.pnlAdmitRoomBed.ResumeLayout(False)
        Me.pnlAdmitRoomBed.PerformLayout()
        Me.pnlDischargeRoomBed.ResumeLayout(False)
        Me.pnlDischargeRoomBed.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbAdmitPatients As ComboBox
    Friend WithEvents btnAdmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbDischargePatients As ComboBox
    Friend WithEvents btnDischarge As Button
    Friend WithEvents pnlDischarge As Panel
    Friend WithEvents pnlAdmit As Panel
    Friend WithEvents pnlRadioButtons As Panel
    Friend WithEvents radDischarge As RadioButton
    Friend WithEvents radAdmitPatient As RadioButton
    Friend WithEvents pnlInformation As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents txtPhysician As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents cboRoomandBed As ComboBox
    Friend WithEvents pnlAdmitRoomBed As Panel
    Friend WithEvents pnlDischargeRoomBed As Panel
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents txtBed As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
