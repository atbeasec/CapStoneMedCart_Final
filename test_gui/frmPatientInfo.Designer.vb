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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPhysician = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlPersonalInformation = New System.Windows.Forms.Panel()
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.flpDispenseHistory = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.flpMedications = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lstBoxAllergies = New System.Windows.Forms.ListBox()
        Me.btnAddAllergy = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDispenseMedication = New System.Windows.Forms.Button()
        Me.btnNewMedicine = New System.Windows.Forms.Button()
        Me.btnDispense = New System.Windows.Forms.Button()
        Me.btnEditPatient = New System.Windows.Forms.Button()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.pnlPersonalInformation.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "John M Smith"
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
        Me.txtGender.TabIndex = 23
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
        Me.txtPhysician.TabIndex = 21
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
        Me.pnlPersonalInformation.Controls.Add(Me.Label1)
        Me.pnlPersonalInformation.Controls.Add(Me.Label19)
        Me.pnlPersonalInformation.Controls.Add(Me.txtBirthday)
        Me.pnlPersonalInformation.Controls.Add(Me.txtPhysician)
        Me.pnlPersonalInformation.Controls.Add(Me.Label16)
        Me.pnlPersonalInformation.Controls.Add(Me.Label11)
        Me.pnlPersonalInformation.ForeColor = System.Drawing.Color.Gainsboro
        Me.pnlPersonalInformation.Location = New System.Drawing.Point(12, 34)
        Me.pnlPersonalInformation.Name = "pnlPersonalInformation"
        Me.pnlPersonalInformation.Size = New System.Drawing.Size(404, 421)
        Me.pnlPersonalInformation.TabIndex = 17
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
        Me.txtBed.TabIndex = 46
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
        Me.txtRoom.TabIndex = 44
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
        Me.txtWeight.TabIndex = 40
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
        Me.txtHeight.TabIndex = 38
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
        Me.txtBirthday.TabIndex = 30
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Patient Medical Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 665)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 25)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Allergies"
        '
        'flpDispenseHistory
        '
        Me.flpDispenseHistory.AutoScroll = True
        Me.flpDispenseHistory.BackColor = System.Drawing.Color.White
        Me.flpDispenseHistory.Location = New System.Drawing.Point(422, 128)
        Me.flpDispenseHistory.Name = "flpDispenseHistory"
        Me.flpDispenseHistory.Size = New System.Drawing.Size(1006, 317)
        Me.flpDispenseHistory.TabIndex = 48
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Location = New System.Drawing.Point(422, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1006, 47)
        Me.Panel2.TabIndex = 47
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label24.Location = New System.Drawing.Point(856, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(116, 21)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Dispense Time"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(11, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(113, 21)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Generic Name"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label23.Location = New System.Drawing.Point(549, 16)
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
        Me.Label25.Location = New System.Drawing.Point(702, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 21)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Dispense Date"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label26.Location = New System.Drawing.Point(431, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(73, 21)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Measure"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label27.Location = New System.Drawing.Point(314, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 21)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Quantity"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label29.Location = New System.Drawing.Point(185, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(100, 21)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Brand Name"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(422, 40)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(157, 25)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "Dispense History"
        '
        'flpMedications
        '
        Me.flpMedications.AutoScroll = True
        Me.flpMedications.BackColor = System.Drawing.Color.White
        Me.flpMedications.Location = New System.Drawing.Point(310, 541)
        Me.flpMedications.Name = "flpMedications"
        Me.flpMedications.Size = New System.Drawing.Size(1118, 255)
        Me.flpMedications.TabIndex = 51
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(308, 459)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(187, 25)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "Current Medications"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Controls.Add(Me.Label36)
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Location = New System.Drawing.Point(310, 494)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1118, 47)
        Me.Panel3.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(707, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Method"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(543, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Frequency"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(191, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Brand Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(821, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Special Notes"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label33.Location = New System.Drawing.Point(11, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(113, 21)
        Me.Label33.TabIndex = 1
        Me.Label33.Text = "Generic Name"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label36.Location = New System.Drawing.Point(439, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(73, 21)
        Me.Label36.TabIndex = 3
        Me.Label36.Text = "Measure"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label37.Location = New System.Drawing.Point(339, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 21)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Quantity"
        '
        'lstBoxAllergies
        '
        Me.lstBoxAllergies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstBoxAllergies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxAllergies.FormattingEnabled = True
        Me.lstBoxAllergies.ItemHeight = 20
        Me.lstBoxAllergies.Location = New System.Drawing.Point(12, 693)
        Me.lstBoxAllergies.Name = "lstBoxAllergies"
        Me.lstBoxAllergies.Size = New System.Drawing.Size(291, 102)
        Me.lstBoxAllergies.TabIndex = 58
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
        Me.btnAddAllergy.Location = New System.Drawing.Point(152, 650)
        Me.btnAddAllergy.Name = "btnAddAllergy"
        Me.btnAddAllergy.Size = New System.Drawing.Size(151, 37)
        Me.btnAddAllergy.TabIndex = 57
        Me.btnAddAllergy.Text = " Add Allergy"
        Me.btnAddAllergy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddAllergy.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(878, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 37)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "  Waste"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnDispenseMedication
        '
        Me.btnDispenseMedication.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDispenseMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispenseMedication.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispenseMedication.ForeColor = System.Drawing.Color.White
        Me.btnDispenseMedication.Image = CType(resources.GetObject("btnDispenseMedication.Image"), System.Drawing.Image)
        Me.btnDispenseMedication.Location = New System.Drawing.Point(991, 27)
        Me.btnDispenseMedication.Name = "btnDispenseMedication"
        Me.btnDispenseMedication.Size = New System.Drawing.Size(236, 37)
        Me.btnDispenseMedication.TabIndex = 52
        Me.btnDispenseMedication.Text = "  Dispense Medication"
        Me.btnDispenseMedication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDispenseMedication.UseVisualStyleBackColor = False
        '
        'btnNewMedicine
        '
        Me.btnNewMedicine.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnNewMedicine.FlatAppearance.BorderSize = 0
        Me.btnNewMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewMedicine.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewMedicine.ForeColor = System.Drawing.Color.White
        Me.btnNewMedicine.Image = CType(resources.GetObject("btnNewMedicine.Image"), System.Drawing.Image)
        Me.btnNewMedicine.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNewMedicine.Location = New System.Drawing.Point(1898, 434)
        Me.btnNewMedicine.Name = "btnNewMedicine"
        Me.btnNewMedicine.Size = New System.Drawing.Size(182, 37)
        Me.btnNewMedicine.TabIndex = 43
        Me.btnNewMedicine.Text = "Add Medicine"
        Me.btnNewMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewMedicine.UseVisualStyleBackColor = False
        '
        'btnDispense
        '
        Me.btnDispense.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDispense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispense.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispense.ForeColor = System.Drawing.Color.White
        Me.btnDispense.Image = CType(resources.GetObject("btnDispense.Image"), System.Drawing.Image)
        Me.btnDispense.Location = New System.Drawing.Point(1599, 433)
        Me.btnDispense.Name = "btnDispense"
        Me.btnDispense.Size = New System.Drawing.Size(263, 37)
        Me.btnDispense.TabIndex = 29
        Me.btnDispense.Text = "   Dispense Medication"
        Me.btnDispense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDispense.UseVisualStyleBackColor = False
        '
        'btnEditPatient
        '
        Me.btnEditPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnEditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPatient.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPatient.ForeColor = System.Drawing.Color.White
        Me.btnEditPatient.Image = CType(resources.GetObject("btnEditPatient.Image"), System.Drawing.Image)
        Me.btnEditPatient.Location = New System.Drawing.Point(1244, 27)
        Me.btnEditPatient.Name = "btnEditPatient"
        Me.btnEditPatient.Size = New System.Drawing.Size(184, 37)
        Me.btnEditPatient.TabIndex = 28
        Me.btnEditPatient.Text = "  Edit Patient"
        Me.btnEditPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditPatient.UseVisualStyleBackColor = False
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
        Me.txtMRN.TabIndex = 49
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
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(12, 313)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(346, 29)
        Me.txtAddress.TabIndex = 50
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
        Me.txtEmail.TabIndex = 51
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
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(207, 379)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(151, 29)
        Me.txtPhone.TabIndex = 53
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
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 532)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(291, 102)
        Me.ListBox1.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(152, 489)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 37)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = " Add Note"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(12, 504)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(63, 25)
        Me.Label28.TabIndex = 59
        Me.Label28.Text = "Notes"
        '
        'frmPatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1444, 802)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.lstBoxAllergies)
        Me.Controls.Add(Me.btnAddAllergy)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.flpMedications)
        Me.Controls.Add(Me.btnDispenseMedication)
        Me.Controls.Add(Me.flpDispenseHistory)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnNewMedicine)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDispense)
        Me.Controls.Add(Me.btnEditPatient)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlPersonalInformation As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnEditPatient As Button
    Friend WithEvents btnDispense As Button
    Friend WithEvents txtPhysician As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNewMedicine As Button
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
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents btnDispenseMedication As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents flpMedications As FlowLayoutPanel
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents btnAddAllergy As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstBoxAllergies As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label28 As Label
End Class
