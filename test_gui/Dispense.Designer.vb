<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dispense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dispense))
        Me.lstboxAllergies = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.flpMedications = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbMedications = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbDosage = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMethod = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDispense = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPatientLastName = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtPatientFirstName = New System.Windows.Forms.TextBox()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstboxAllergies
        '
        Me.lstboxAllergies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxAllergies.FormattingEnabled = True
        Me.lstboxAllergies.ItemHeight = 20
        Me.lstboxAllergies.Location = New System.Drawing.Point(905, 172)
        Me.lstboxAllergies.Name = "lstboxAllergies"
        Me.lstboxAllergies.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstboxAllergies.Size = New System.Drawing.Size(191, 104)
        Me.lstboxAllergies.TabIndex = 5
        Me.lstboxAllergies.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 21)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Active Perscriptions:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Location = New System.Drawing.Point(18, 292)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1080, 47)
        Me.Panel3.TabIndex = 52
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label31.Location = New System.Drawing.Point(312, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(86, 21)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "Frequency"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label28.Location = New System.Drawing.Point(674, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(126, 21)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "Date Prescribed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(559, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(840, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prescribed By"
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
        Me.Label26.Location = New System.Drawing.Point(440, 16)
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
        Me.Label27.Location = New System.Drawing.Point(193, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 21)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "Strength"
        '
        'flpMedications
        '
        Me.flpMedications.AutoScroll = True
        Me.flpMedications.BackColor = System.Drawing.Color.White
        Me.flpMedications.Location = New System.Drawing.Point(18, 339)
        Me.flpMedications.Name = "flpMedications"
        Me.flpMedications.Size = New System.Drawing.Size(1080, 186)
        Me.flpMedications.TabIndex = 53
        '
        'cmbMedications
        '
        Me.cmbMedications.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedications.FormattingEnabled = True
        Me.cmbMedications.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbMedications.Location = New System.Drawing.Point(18, 172)
        Me.cmbMedications.Name = "cmbMedications"
        Me.cmbMedications.Size = New System.Drawing.Size(239, 29)
        Me.cmbMedications.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(633, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 21)
        Me.Label14.TabIndex = 177
        Me.Label14.Text = "Dosage:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 148)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 21)
        Me.Label17.TabIndex = 176
        Me.Label17.Text = "Medication:"
        '
        'cmbDosage
        '
        Me.cmbDosage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDosage.FormattingEnabled = True
        Me.cmbDosage.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbDosage.Location = New System.Drawing.Point(637, 172)
        Me.cmbDosage.Name = "cmbDosage"
        Me.cmbDosage.Size = New System.Drawing.Size(193, 29)
        Me.cmbDosage.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 21)
        Me.Label3.TabIndex = 179
        Me.Label3.Text = "Select Medication to Dispense:"
        '
        'cmbMethod
        '
        Me.cmbMethod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMethod.FormattingEnabled = True
        Me.cmbMethod.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbMethod.Location = New System.Drawing.Point(333, 172)
        Me.cmbMethod.Name = "cmbMethod"
        Me.cmbMethod.Size = New System.Drawing.Size(229, 29)
        Me.cmbMethod.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(329, 148)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 21)
        Me.Label15.TabIndex = 183
        Me.Label15.Text = "Method:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(329, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 21)
        Me.Label8.TabIndex = 190
        Me.Label8.Text = "DOB:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(901, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 21)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Last Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(632, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 21)
        Me.Label6.TabIndex = 188
        Me.Label6.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 21)
        Me.Label4.TabIndex = 187
        Me.Label4.Text = "MRN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(634, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 185
        Me.Label5.Text = "Quantity:"
        '
        'btnDispense
        '
        Me.btnDispense.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDispense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispense.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispense.ForeColor = System.Drawing.Color.White
        Me.btnDispense.Image = CType(resources.GetObject("btnDispense.Image"), System.Drawing.Image)
        Me.btnDispense.Location = New System.Drawing.Point(433, 541)
        Me.btnDispense.Name = "btnDispense"
        Me.btnDispense.Size = New System.Drawing.Size(229, 38)
        Me.btnDispense.TabIndex = 7
        Me.btnDispense.Text = "      Dispense Medication"
        Me.btnDispense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDispense.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(901, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 21)
        Me.Label13.TabIndex = 197
        Me.Label13.Text = "Medication Allergies:"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.DarkGray
        Me.Panel14.Controls.Add(Me.txtMRN)
        Me.Panel14.Location = New System.Drawing.Point(17, 104)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel14.Size = New System.Drawing.Size(241, 24)
        Me.Panel14.TabIndex = 198
        '
        'txtMRN
        '
        Me.txtMRN.BackColor = System.Drawing.Color.White
        Me.txtMRN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMRN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMRN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRN.Location = New System.Drawing.Point(1, 1)
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.ReadOnly = True
        Me.txtMRN.Size = New System.Drawing.Size(239, 22)
        Me.txtMRN.TabIndex = 6
        Me.txtMRN.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.txtDOB)
        Me.Panel1.Location = New System.Drawing.Point(333, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(229, 24)
        Me.Panel1.TabIndex = 199
        '
        'txtDOB
        '
        Me.txtDOB.BackColor = System.Drawing.Color.White
        Me.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDOB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDOB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(1, 1)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.ReadOnly = True
        Me.txtDOB.Size = New System.Drawing.Size(227, 22)
        Me.txtDOB.TabIndex = 6
        Me.txtDOB.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.txtPatientLastName)
        Me.Panel2.Location = New System.Drawing.Point(905, 103)

        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(190, 24)
        Me.Panel2.TabIndex = 200
        '
        'txtPatientLastName
        '
        Me.txtPatientLastName.BackColor = System.Drawing.Color.White
        Me.txtPatientLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientLastName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPatientLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientLastName.Location = New System.Drawing.Point(1, 1)
        Me.txtPatientLastName.Name = "txtPatientLastName"
        Me.txtPatientLastName.ReadOnly = True
        Me.txtPatientLastName.Size = New System.Drawing.Size(188, 22)
        Me.txtPatientLastName.TabIndex = 6
        Me.txtPatientLastName.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray

        Me.Panel4.Controls.Add(Me.txtPatientFirstName)
        Me.Panel4.Location = New System.Drawing.Point(636, 104)


        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel4.Size = New System.Drawing.Size(194, 24)
        Me.Panel4.TabIndex = 199
        '
        'txtPatientFirstName
        '
        Me.txtPatientFirstName.BackColor = System.Drawing.Color.White
        Me.txtPatientFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientFirstName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPatientFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientFirstName.Location = New System.Drawing.Point(1, 1)
        Me.txtPatientFirstName.Name = "txtPatientFirstName"
        Me.txtPatientFirstName.ReadOnly = True
        Me.txtPatientFirstName.Size = New System.Drawing.Size(192, 22)
        Me.txtPatientFirstName.TabIndex = 6
        Me.txtPatientFirstName.TabStop = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDown.FlatAppearance.BorderSize = 0
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.ForeColor = System.Drawing.Color.White
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(730, 244)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(28, 28)
        Me.btnDown.TabIndex = 6
        Me.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnUp.FlatAppearance.BorderSize = 0
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.ForeColor = System.Drawing.Color.White
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(696, 244)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(28, 28)
        Me.btnUp.TabIndex = 5
        Me.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.txtQuantity)
        Me.Panel5.Location = New System.Drawing.Point(637, 244)
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
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(51, 26)
        Me.txtQuantity.TabIndex = 38
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1116, 46)
        Me.pnlHeader.TabIndex = 201
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
        'Dispense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1116, 599)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDispense)
        Me.Controls.Add(Me.cmbMethod)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbMedications)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbDosage)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.flpMedications)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lstboxAllergies)
        Me.Name = "Dispense"
        Me.Text = "    Dispense"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstboxAllergies As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents flpMedications As FlowLayoutPanel
    Friend WithEvents cmbMedications As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbDosage As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbMethod As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDispense As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPatientLastName As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtPatientFirstName As TextBox
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnBack As Button
End Class
