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
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.cboBed = New System.Windows.Forms.ComboBox()
        Me.cboRoom = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
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
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.flpMedications = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblFrequencyPrescription = New System.Windows.Forms.Label()
        Me.lblPrescribedBy = New System.Windows.Forms.Label()
        Me.lblDatePrescribed = New System.Windows.Forms.Label()
        Me.lblQuantityPrescription = New System.Windows.Forms.Label()
        Me.lblMedicationPrescription = New System.Windows.Forms.Label()
        Me.lblTypePrescription = New System.Windows.Forms.Label()
        Me.lblStrengthPrescription = New System.Windows.Forms.Label()
        Me.lstBoxAllergies = New System.Windows.Forms.ListBox()
        Me.btnWaste = New System.Windows.Forms.Button()
        Me.btnDispenseMedication = New System.Windows.Forms.Button()
        Me.btnEditPatient = New System.Windows.Forms.Button()
        Me.btnAddAllergies = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlPersonalInformation.SuspendLayout()
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
        Me.txtGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(383, 61)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(151, 25)
        Me.txtGender.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label19.Location = New System.Drawing.Point(379, 37)
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
        Me.txtPhysician.Location = New System.Drawing.Point(383, 123)
        Me.txtPhysician.Name = "txtPhysician"
        Me.txtPhysician.ReadOnly = True
        Me.txtPhysician.Size = New System.Drawing.Size(151, 25)
        Me.txtPhysician.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(381, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(140, 21)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Primary Physician:"
        '
        'pnlPersonalInformation
        '
        Me.pnlPersonalInformation.BackColor = System.Drawing.Color.White
        Me.pnlPersonalInformation.Controls.Add(Me.cboState)
        Me.pnlPersonalInformation.Controls.Add(Me.btnAddAllergies)
        Me.pnlPersonalInformation.Controls.Add(Me.Label2)
        Me.pnlPersonalInformation.Controls.Add(Me.lstBoxAllergies)
        Me.pnlPersonalInformation.Controls.Add(Me.TextBox1)
        Me.pnlPersonalInformation.Controls.Add(Me.Label1)
        Me.pnlPersonalInformation.Controls.Add(Me.txtCity)
        Me.pnlPersonalInformation.Controls.Add(Me.cboBed)
        Me.pnlPersonalInformation.Controls.Add(Me.cboRoom)
        Me.pnlPersonalInformation.Controls.Add(Me.Label15)
        Me.pnlPersonalInformation.Controls.Add(Me.Label14)
        Me.pnlPersonalInformation.Controls.Add(Me.txtPhone)
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
        Me.pnlPersonalInformation.Controls.Add(Me.LblPatientName)
        Me.pnlPersonalInformation.Controls.Add(Me.Label19)
        Me.pnlPersonalInformation.Controls.Add(Me.txtBirthday)
        Me.pnlPersonalInformation.Controls.Add(Me.txtPhysician)
        Me.pnlPersonalInformation.Controls.Add(Me.Label16)
        Me.pnlPersonalInformation.Controls.Add(Me.Label11)
        Me.pnlPersonalInformation.ForeColor = System.Drawing.Color.Gainsboro
        Me.pnlPersonalInformation.Location = New System.Drawing.Point(12, 44)
        Me.pnlPersonalInformation.Name = "pnlPersonalInformation"
        Me.pnlPersonalInformation.Size = New System.Drawing.Size(1132, 234)
        Me.pnlPersonalInformation.TabIndex = 17
        '
        'cboState
        '
        Me.cboState.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(567, 185)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(151, 25)
        Me.cboState.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(563, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "State:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(751, 185)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(151, 25)
        Me.TextBox1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(379, 162)
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
        Me.txtCity.Location = New System.Drawing.Point(383, 185)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(151, 25)
        Me.txtCity.TabIndex = 12
        '
        'cboBed
        '
        Me.cboBed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBed.FormattingEnabled = True
        Me.cboBed.Location = New System.Drawing.Point(198, 123)
        Me.cboBed.Name = "cboBed"
        Me.cboBed.Size = New System.Drawing.Size(152, 25)
        Me.cboBed.TabIndex = 7
        '
        'cboRoom
        '
        Me.cboRoom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoom.FormattingEnabled = True
        Me.cboRoom.Location = New System.Drawing.Point(14, 123)
        Me.cboRoom.Name = "cboRoom"
        Me.cboRoom.Size = New System.Drawing.Size(151, 25)
        Me.cboRoom.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(750, 94)
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
        Me.Label14.Location = New System.Drawing.Point(564, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 21)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Email:"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(753, 122)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(149, 25)
        Me.txtPhone.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(9, 162)
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
        Me.txtEmail.Location = New System.Drawing.Point(567, 121)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(151, 25)
        Me.txtEmail.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(13, 185)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(337, 25)
        Me.txtAddress.TabIndex = 11
        '
        'txtMRN
        '
        Me.txtMRN.BackColor = System.Drawing.Color.White
        Me.txtMRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMRN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRN.Location = New System.Drawing.Point(13, 61)
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.ReadOnly = True
        Me.txtMRN.Size = New System.Drawing.Size(150, 25)
        Me.txtMRN.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(8, 38)
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
        Me.Label21.Location = New System.Drawing.Point(198, 97)
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
        Me.Label17.Location = New System.Drawing.Point(11, 97)
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
        Me.Label10.Location = New System.Drawing.Point(747, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 21)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Zip Code:"
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.White
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(754, 62)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(148, 25)
        Me.txtWeight.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(750, 38)
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
        Me.txtHeight.Location = New System.Drawing.Point(568, 61)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.Size = New System.Drawing.Size(150, 25)
        Me.txtHeight.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(564, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Height:"
        '
        'txtBirthday
        '
        Me.txtBirthday.BackColor = System.Drawing.Color.White
        Me.txtBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBirthday.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthday.Location = New System.Drawing.Point(198, 61)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.ReadOnly = True
        Me.txtBirthday.Size = New System.Drawing.Size(152, 25)
        Me.txtBirthday.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(194, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 21)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "DOB:"
        '
        'flpMedications
        '
        Me.flpMedications.AutoScroll = True
        Me.flpMedications.BackColor = System.Drawing.Color.White
        Me.flpMedications.Location = New System.Drawing.Point(12, 371)
        Me.flpMedications.Name = "flpMedications"
        Me.flpMedications.Size = New System.Drawing.Size(1132, 199)
        Me.flpMedications.TabIndex = 51
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 295)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 25)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Prescriptions"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lblFrequencyPrescription)
        Me.Panel3.Controls.Add(Me.lblPrescribedBy)
        Me.Panel3.Controls.Add(Me.lblDatePrescribed)
        Me.Panel3.Controls.Add(Me.lblQuantityPrescription)
        Me.Panel3.Controls.Add(Me.lblMedicationPrescription)
        Me.Panel3.Controls.Add(Me.lblTypePrescription)
        Me.Panel3.Controls.Add(Me.lblStrengthPrescription)
        Me.Panel3.Location = New System.Drawing.Point(12, 324)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1132, 47)
        Me.Panel3.TabIndex = 48
        '
        'lblFrequencyPrescription
        '
        Me.lblFrequencyPrescription.AutoSize = True
        Me.lblFrequencyPrescription.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrequencyPrescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFrequencyPrescription.Location = New System.Drawing.Point(908, 16)
        Me.lblFrequencyPrescription.Name = "lblFrequencyPrescription"
        Me.lblFrequencyPrescription.Size = New System.Drawing.Size(86, 21)
        Me.lblFrequencyPrescription.TabIndex = 16
        Me.lblFrequencyPrescription.Text = "Frequency"
        '
        'lblPrescribedBy
        '
        Me.lblPrescribedBy.AutoSize = True
        Me.lblPrescribedBy.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrescribedBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPrescribedBy.Location = New System.Drawing.Point(732, 16)
        Me.lblPrescribedBy.Name = "lblPrescribedBy"
        Me.lblPrescribedBy.Size = New System.Drawing.Size(110, 21)
        Me.lblPrescribedBy.TabIndex = 15
        Me.lblPrescribedBy.Text = "Prescribed By"
        '
        'lblDatePrescribed
        '
        Me.lblDatePrescribed.AutoSize = True
        Me.lblDatePrescribed.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatePrescribed.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDatePrescribed.Location = New System.Drawing.Point(540, 16)
        Me.lblDatePrescribed.Name = "lblDatePrescribed"
        Me.lblDatePrescribed.Size = New System.Drawing.Size(126, 21)
        Me.lblDatePrescribed.TabIndex = 14
        Me.lblDatePrescribed.Text = "Date Prescribed"
        '
        'lblQuantityPrescription
        '
        Me.lblQuantityPrescription.AutoSize = True
        Me.lblQuantityPrescription.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityPrescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblQuantityPrescription.Location = New System.Drawing.Point(422, 16)
        Me.lblQuantityPrescription.Name = "lblQuantityPrescription"
        Me.lblQuantityPrescription.Size = New System.Drawing.Size(72, 21)
        Me.lblQuantityPrescription.TabIndex = 12
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
        Me.lblMedicationPrescription.TabIndex = 11
        Me.lblMedicationPrescription.Text = "Medication Name"
        '
        'lblTypePrescription
        '
        Me.lblTypePrescription.AutoSize = True
        Me.lblTypePrescription.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypePrescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTypePrescription.Location = New System.Drawing.Point(323, 16)
        Me.lblTypePrescription.Name = "lblTypePrescription"
        Me.lblTypePrescription.Size = New System.Drawing.Size(45, 21)
        Me.lblTypePrescription.TabIndex = 13
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
        Me.lblStrengthPrescription.TabIndex = 10
        Me.lblStrengthPrescription.Text = "Strength"
        '
        'lstBoxAllergies
        '
        Me.lstBoxAllergies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstBoxAllergies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxAllergies.FormattingEnabled = True
        Me.lstBoxAllergies.ItemHeight = 20
        Me.lstBoxAllergies.Location = New System.Drawing.Point(952, 89)
        Me.lstBoxAllergies.Name = "lstBoxAllergies"
        Me.lstBoxAllergies.Size = New System.Drawing.Size(173, 122)
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
        Me.btnWaste.Location = New System.Drawing.Point(587, 5)
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
        Me.btnDispenseMedication.Location = New System.Drawing.Point(711, 5)
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
        Me.btnEditPatient.Location = New System.Drawing.Point(964, 5)
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
        Me.btnAddAllergies.Location = New System.Drawing.Point(952, 46)
        Me.btnAddAllergies.Name = "btnAddAllergies"
        Me.btnAddAllergies.Size = New System.Drawing.Size(173, 37)
        Me.btnAddAllergies.TabIndex = 15
        Me.btnAddAllergies.Text = "  Add Allergies"
        Me.btnAddAllergies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddAllergies.UseVisualStyleBackColor = False
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
        Me.Panel1.Size = New System.Drawing.Size(1157, 46)
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
        Me.btnBack.Location = New System.Drawing.Point(23, 9)
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
        Me.ClientSize = New System.Drawing.Size(1157, 596)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.flpMedications)
        Me.Controls.Add(Me.pnlPersonalInformation)
        Me.Controls.Add(Me.Label18)
        Me.Name = "frmPatientInfo"
        Me.Text = "frmPatientInfo"
        Me.pnlPersonalInformation.ResumeLayout(False)
        Me.pnlPersonalInformation.PerformLayout()
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lstBoxAllergies As ListBox
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPhone As TextBox
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCity As TextBox
End Class
