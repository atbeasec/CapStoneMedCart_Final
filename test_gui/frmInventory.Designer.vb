<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbBin = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbMedicationName = New System.Windows.Forms.ComboBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtExpirationDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbPatientPersonalMedication = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDrawerNumber = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlMainLocation = New System.Windows.Forms.Panel()
        Me.pnlMainFormFields = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.cboSuggestedNames = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtSchedule = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtStrength = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkControlled = New System.Windows.Forms.CheckBox()
        Me.chkNarcotic = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.pnlPatientName = New System.Windows.Forms.Panel()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.pnlPatientNamePadding = New System.Windows.Forms.Panel()
        Me.cmbPatientNames = New System.Windows.Forms.ComboBox()
        Me.eprError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlMainLocation.SuspendLayout()
        Me.pnlMainFormFields.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.pnlPatientName.SuspendLayout()
        Me.pnlPatientNamePadding.SuspendLayout()
        CType(Me.eprError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(352, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 21)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Divider Bin:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 21)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Expiration Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(11, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 21)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Select from List:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.cmbBin)
        Me.Panel4.Location = New System.Drawing.Point(356, 356)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel4.Size = New System.Drawing.Size(118, 31)
        Me.Panel4.TabIndex = 15
        '
        'cmbBin
        '
        Me.cmbBin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBin.FormattingEnabled = True
        Me.cmbBin.Location = New System.Drawing.Point(1, 1)
        Me.cmbBin.Name = "cmbBin"
        Me.cmbBin.Size = New System.Drawing.Size(116, 29)
        Me.cmbBin.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.cmbMedicationName)
        Me.Panel3.Location = New System.Drawing.Point(10, 88)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel3.Size = New System.Drawing.Size(464, 31)
        Me.Panel3.TabIndex = 3
        '
        'cmbMedicationName
        '
        Me.cmbMedicationName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMedicationName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMedicationName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedicationName.FormattingEnabled = True
        Me.cmbMedicationName.Location = New System.Drawing.Point(1, 1)
        Me.cmbMedicationName.Name = "cmbMedicationName"
        Me.cmbMedicationName.Size = New System.Drawing.Size(462, 29)
        Me.cmbMedicationName.TabIndex = 10
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.DarkGray
        Me.Panel14.Controls.Add(Me.txtExpirationDate)
        Me.Panel14.Location = New System.Drawing.Point(10, 424)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel14.Size = New System.Drawing.Size(190, 31)
        Me.Panel14.TabIndex = 16
        '
        'txtExpirationDate
        '
        Me.txtExpirationDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExpirationDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExpirationDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpirationDate.Location = New System.Drawing.Point(1, 1)
        Me.txtExpirationDate.Multiline = True
        Me.txtExpirationDate.Name = "txtExpirationDate"
        Me.txtExpirationDate.Size = New System.Drawing.Size(188, 29)
        Me.txtExpirationDate.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "Quantity:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(208, 25)
        Me.Label17.TabIndex = 168
        Me.Label17.Text = "Drawer Configuration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(269, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 21)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Patient Personal Medication:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.cmbPatientPersonalMedication)
        Me.Panel1.Location = New System.Drawing.Point(272, 424)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel1.Size = New System.Drawing.Size(202, 31)
        Me.Panel1.TabIndex = 17
        '
        'cmbPatientPersonalMedication
        '
        Me.cmbPatientPersonalMedication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPatientPersonalMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPatientPersonalMedication.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientPersonalMedication.FormattingEnabled = True
        Me.cmbPatientPersonalMedication.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbPatientPersonalMedication.Location = New System.Drawing.Point(1, 1)
        Me.cmbPatientPersonalMedication.Name = "cmbPatientPersonalMedication"
        Me.cmbPatientPersonalMedication.Size = New System.Drawing.Size(200, 29)
        Me.cmbPatientPersonalMedication.TabIndex = 60
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.test_gui.My.Resources.Resources.resolve
        Me.btnSave.Location = New System.Drawing.Point(177, 81)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 38)
        Me.btnSave.TabIndex = 70
        Me.btnSave.Text = "   SAVE "
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.txtDrawerNumber)
        Me.Panel2.Location = New System.Drawing.Point(10, 354)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel2.Size = New System.Drawing.Size(53, 33)
        Me.Panel2.TabIndex = 9
        '
        'txtDrawerNumber
        '
        Me.txtDrawerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDrawerNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDrawerNumber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrawerNumber.Location = New System.Drawing.Point(1, 1)
        Me.txtDrawerNumber.Multiline = True
        Me.txtDrawerNumber.Name = "txtDrawerNumber"
        Me.txtDrawerNumber.Size = New System.Drawing.Size(51, 31)
        Me.txtDrawerNumber.TabIndex = 40
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnUp.FlatAppearance.BorderSize = 0
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.ForeColor = System.Drawing.Color.White
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(70, 354)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(33, 33)
        Me.btnUp.TabIndex = 41
        Me.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(109, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 33)
        Me.Button1.TabIndex = 42
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(285, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 33)
        Me.Button2.TabIndex = 47
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(244, 354)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 33)
        Me.Button3.TabIndex = 46
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.txtQuantity)
        Me.Panel5.Location = New System.Drawing.Point(186, 354)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel5.Size = New System.Drawing.Size(53, 33)
        Me.Panel5.TabIndex = 12
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(1, 1)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(51, 31)
        Me.txtQuantity.TabIndex = 45
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(274, 198)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 21)
        Me.Label15.TabIndex = 186
        Me.Label15.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 188
        Me.Label3.Text = "Strength:"
        '
        'pnlMainLocation
        '
        Me.pnlMainLocation.Controls.Add(Me.pnlMainFormFields)
        Me.pnlMainLocation.Controls.Add(Me.Panel11)
        Me.pnlMainLocation.Controls.Add(Me.pnlPatientName)
        Me.pnlMainLocation.Location = New System.Drawing.Point(17, 77)
        Me.pnlMainLocation.Name = "pnlMainLocation"
        Me.pnlMainLocation.Size = New System.Drawing.Size(570, 603)
        Me.pnlMainLocation.TabIndex = 189
        '
        'pnlMainFormFields
        '
        Me.pnlMainFormFields.Controls.Add(Me.Panel8)
        Me.pnlMainFormFields.Controls.Add(Me.lblBarcode)
        Me.pnlMainFormFields.Controls.Add(Me.cboSuggestedNames)
        Me.pnlMainFormFields.Controls.Add(Me.Panel7)
        Me.pnlMainFormFields.Controls.Add(Me.Label7)
        Me.pnlMainFormFields.Controls.Add(Me.Panel6)
        Me.pnlMainFormFields.Controls.Add(Me.Panel10)
        Me.pnlMainFormFields.Controls.Add(Me.Panel9)
        Me.pnlMainFormFields.Controls.Add(Me.Label4)
        Me.pnlMainFormFields.Controls.Add(Me.chkControlled)
        Me.pnlMainFormFields.Controls.Add(Me.chkNarcotic)
        Me.pnlMainFormFields.Controls.Add(Me.Panel3)
        Me.pnlMainFormFields.Controls.Add(Me.Button3)
        Me.pnlMainFormFields.Controls.Add(Me.Label9)
        Me.pnlMainFormFields.Controls.Add(Me.Label10)
        Me.pnlMainFormFields.Controls.Add(Me.Button2)
        Me.pnlMainFormFields.Controls.Add(Me.Panel14)
        Me.pnlMainFormFields.Controls.Add(Me.Panel5)
        Me.pnlMainFormFields.Controls.Add(Me.Panel2)
        Me.pnlMainFormFields.Controls.Add(Me.Label6)
        Me.pnlMainFormFields.Controls.Add(Me.Label3)
        Me.pnlMainFormFields.Controls.Add(Me.Label2)
        Me.pnlMainFormFields.Controls.Add(Me.Label1)
        Me.pnlMainFormFields.Controls.Add(Me.Label15)
        Me.pnlMainFormFields.Controls.Add(Me.Panel4)
        Me.pnlMainFormFields.Controls.Add(Me.Button1)
        Me.pnlMainFormFields.Controls.Add(Me.btnUp)
        Me.pnlMainFormFields.Controls.Add(Me.Label5)
        Me.pnlMainFormFields.Controls.Add(Me.Panel1)
        Me.pnlMainFormFields.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMainFormFields.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainFormFields.Name = "pnlMainFormFields"
        Me.pnlMainFormFields.Size = New System.Drawing.Size(570, 462)
        Me.pnlMainFormFields.TabIndex = 189
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkGray
        Me.Panel8.Controls.Add(Me.txtBarcode)
        Me.Panel8.Location = New System.Drawing.Point(12, 286)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel8.Size = New System.Drawing.Size(190, 31)
        Me.Panel8.TabIndex = 196
        '
        'txtBarcode
        '
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(1, 1)
        Me.txtBarcode.Multiline = True
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(188, 29)
        Me.txtBarcode.TabIndex = 30
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcode.Location = New System.Drawing.Point(8, 262)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(69, 21)
        Me.lblBarcode.TabIndex = 197
        Me.lblBarcode.Text = "Barcode:"
        '
        'cboSuggestedNames
        '
        Me.cboSuggestedNames.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSuggestedNames.FormattingEnabled = True
        Me.cboSuggestedNames.Location = New System.Drawing.Point(185, 50)
        Me.cboSuggestedNames.Name = "cboSuggestedNames"
        Me.cboSuggestedNames.Size = New System.Drawing.Size(289, 29)
        Me.cboSuggestedNames.TabIndex = 5
        Me.cboSuggestedNames.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkGray
        Me.Panel7.Controls.Add(Me.txtType)
        Me.Panel7.Location = New System.Drawing.Point(275, 221)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel7.Size = New System.Drawing.Size(202, 31)
        Me.Panel7.TabIndex = 8
        '
        'txtType
        '
        Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(1, 1)
        Me.txtType.Multiline = True
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(200, 29)
        Me.txtType.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(271, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 21)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "Schedule:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGray
        Me.Panel6.Controls.Add(Me.txtSchedule)
        Me.Panel6.Location = New System.Drawing.Point(274, 157)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel6.Size = New System.Drawing.Size(202, 28)
        Me.Panel6.TabIndex = 6
        '
        'txtSchedule
        '
        Me.txtSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSchedule.Enabled = False
        Me.txtSchedule.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchedule.Location = New System.Drawing.Point(1, 1)
        Me.txtSchedule.Multiline = True
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.Size = New System.Drawing.Size(200, 26)
        Me.txtSchedule.TabIndex = 25
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DarkGray
        Me.Panel10.Controls.Add(Me.txtStrength)
        Me.Panel10.Location = New System.Drawing.Point(12, 221)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel10.Size = New System.Drawing.Size(190, 31)
        Me.Panel10.TabIndex = 7
        '
        'txtStrength
        '
        Me.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStrength.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStrength.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStrength.Location = New System.Drawing.Point(1, 1)
        Me.txtStrength.Multiline = True
        Me.txtStrength.Name = "txtStrength"
        Me.txtStrength.Size = New System.Drawing.Size(188, 29)
        Me.txtStrength.TabIndex = 30
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkGray
        Me.Panel9.Controls.Add(Me.pnlSearch)
        Me.Panel9.Controls.Add(Me.txtSearch)
        Me.Panel9.Location = New System.Drawing.Point(9, 14)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Panel9.Size = New System.Drawing.Size(466, 31)
        Me.Panel9.TabIndex = 1
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.White
        Me.pnlSearch.BackgroundImage = CType(resources.GetObject("pnlSearch.BackgroundImage"), System.Drawing.Image)
        Me.pnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSearch.ForeColor = System.Drawing.Color.White
        Me.pnlSearch.Location = New System.Drawing.Point(432, 1)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(33, 29)
        Me.pnlSearch.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1, 1)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(431, 29)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Tag = "Search Medication by Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 21)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Medication Flag:"
        '
        'chkControlled
        '
        Me.chkControlled.AutoSize = True
        Me.chkControlled.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkControlled.Location = New System.Drawing.Point(138, 166)
        Me.chkControlled.Name = "chkControlled"
        Me.chkControlled.Size = New System.Drawing.Size(102, 25)
        Me.chkControlled.TabIndex = 20
        Me.chkControlled.Text = "Controlled"
        Me.chkControlled.UseVisualStyleBackColor = True
        '
        'chkNarcotic
        '
        Me.chkNarcotic.AutoSize = True
        Me.chkNarcotic.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNarcotic.Location = New System.Drawing.Point(24, 166)
        Me.chkNarcotic.Name = "chkNarcotic"
        Me.chkNarcotic.Size = New System.Drawing.Size(87, 25)
        Me.chkNarcotic.TabIndex = 15
        Me.chkNarcotic.Text = "Narcotic"
        Me.chkNarcotic.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(7, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 21)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Drawer Number:"
        '
        'Panel11
        '
        Me.Panel11.Location = New System.Drawing.Point(622, 113)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(367, 100)
        Me.Panel11.TabIndex = 190
        '
        'pnlPatientName
        '
        Me.pnlPatientName.Controls.Add(Me.lblPatientName)
        Me.pnlPatientName.Controls.Add(Me.btnSave)
        Me.pnlPatientName.Controls.Add(Me.pnlPatientNamePadding)
        Me.pnlPatientName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPatientName.Location = New System.Drawing.Point(0, 468)
        Me.pnlPatientName.Name = "pnlPatientName"
        Me.pnlPatientName.Size = New System.Drawing.Size(570, 135)
        Me.pnlPatientName.TabIndex = 191
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(4, 4)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(60, 21)
        Me.lblPatientName.TabIndex = 191
        Me.lblPatientName.Text = "Patient:"
        '
        'pnlPatientNamePadding
        '
        Me.pnlPatientNamePadding.BackColor = System.Drawing.Color.DarkGray
        Me.pnlPatientNamePadding.Controls.Add(Me.cmbPatientNames)
        Me.pnlPatientNamePadding.Location = New System.Drawing.Point(9, 28)
        Me.pnlPatientNamePadding.Name = "pnlPatientNamePadding"
        Me.pnlPatientNamePadding.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pnlPatientNamePadding.Size = New System.Drawing.Size(465, 31)
        Me.pnlPatientNamePadding.TabIndex = 18
        '
        'cmbPatientNames
        '
        Me.cmbPatientNames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPatientNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPatientNames.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientNames.FormattingEnabled = True
        Me.cmbPatientNames.Location = New System.Drawing.Point(1, 1)
        Me.cmbPatientNames.Name = "cmbPatientNames"
        Me.cmbPatientNames.Size = New System.Drawing.Size(463, 29)
        Me.cmbPatientNames.TabIndex = 65
        '
        'eprError
        '
        Me.eprError.ContainerControl = Me
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(570, 46)
        Me.pnlHeader.TabIndex = 203
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
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(570, 679)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlMainLocation)
        Me.Controls.Add(Me.Label17)
        Me.Name = "frmInventory"
        Me.Text = "frmInventory"
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlMainLocation.ResumeLayout(False)
        Me.pnlMainFormFields.ResumeLayout(False)
        Me.pnlMainFormFields.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnlPatientName.ResumeLayout(False)
        Me.pnlPatientName.PerformLayout()
        Me.pnlPatientNamePadding.ResumeLayout(False)
        CType(Me.eprError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cmbBin As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbMedicationName As ComboBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents txtExpirationDate As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbPatientPersonalMedication As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDrawerNumber As TextBox
    Friend WithEvents btnUp As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlMainLocation As Panel
    Friend WithEvents pnlPatientName As Panel
    Friend WithEvents pnlPatientNamePadding As Panel
    Friend WithEvents cmbPatientNames As ComboBox
    Friend WithEvents lblPatientName As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents pnlMainFormFields As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkControlled As CheckBox
    Friend WithEvents chkNarcotic As CheckBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtSchedule As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtStrength As TextBox
    Friend WithEvents cboSuggestedNames As ComboBox
    Friend WithEvents eprError As ErrorProvider
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents lblBarcode As Label
End Class
