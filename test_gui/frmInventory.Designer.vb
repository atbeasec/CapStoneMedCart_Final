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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlMainLocation = New System.Windows.Forms.Panel()
        Me.pnlMainFormFields = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.pnlPatientName = New System.Windows.Forms.Panel()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.pnlPatientNamePadding = New System.Windows.Forms.Panel()
        Me.cmbPatientNames = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pnlMainLocation.SuspendLayout()
        Me.pnlMainFormFields.SuspendLayout()
        Me.pnlPatientName.SuspendLayout()
        Me.pnlPatientNamePadding.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(353, 223)
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
        Me.Label6.Location = New System.Drawing.Point(8, 301)
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
        Me.Label5.Location = New System.Drawing.Point(6, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 21)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Select from List:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.cmbBin)
        Me.Panel4.Location = New System.Drawing.Point(356, 251)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel4.Size = New System.Drawing.Size(118, 28)
        Me.Panel4.TabIndex = 10
        '
        'cmbBin
        '
        Me.cmbBin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBin.FormattingEnabled = True
        Me.cmbBin.Location = New System.Drawing.Point(1, 1)
        Me.cmbBin.Name = "cmbBin"
        Me.cmbBin.Size = New System.Drawing.Size(116, 25)
        Me.cmbBin.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.cmbMedicationName)
        Me.Panel3.Location = New System.Drawing.Point(10, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(464, 28)
        Me.Panel3.TabIndex = 1
        '
        'cmbMedicationName
        '
        Me.cmbMedicationName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMedicationName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMedicationName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedicationName.FormattingEnabled = True
        Me.cmbMedicationName.Location = New System.Drawing.Point(1, 1)
        Me.cmbMedicationName.Name = "cmbMedicationName"
        Me.cmbMedicationName.Size = New System.Drawing.Size(462, 25)
        Me.cmbMedicationName.TabIndex = 5
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.DarkGray
        Me.Panel14.Controls.Add(Me.txtExpirationDate)
        Me.Panel14.Location = New System.Drawing.Point(10, 327)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel14.Size = New System.Drawing.Size(190, 28)
        Me.Panel14.TabIndex = 11
        '
        'txtExpirationDate
        '
        Me.txtExpirationDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExpirationDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExpirationDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpirationDate.Location = New System.Drawing.Point(1, 1)
        Me.txtExpirationDate.Multiline = True
        Me.txtExpirationDate.Name = "txtExpirationDate"
        Me.txtExpirationDate.Size = New System.Drawing.Size(188, 26)
        Me.txtExpirationDate.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 223)
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
        Me.Label17.Location = New System.Drawing.Point(12, 20)
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
        Me.Label1.Location = New System.Drawing.Point(269, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 21)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Patient Personal Medication:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.cmbPatientPersonalMedication)
        Me.Panel1.Location = New System.Drawing.Point(272, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(202, 28)
        Me.Panel1.TabIndex = 12
        '
        'cmbPatientPersonalMedication
        '
        Me.cmbPatientPersonalMedication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPatientPersonalMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPatientPersonalMedication.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientPersonalMedication.FormattingEnabled = True
        Me.cmbPatientPersonalMedication.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbPatientPersonalMedication.Location = New System.Drawing.Point(1, 1)
        Me.cmbPatientPersonalMedication.Name = "cmbPatientPersonalMedication"
        Me.cmbPatientPersonalMedication.Size = New System.Drawing.Size(200, 25)
        Me.cmbPatientPersonalMedication.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.test_gui.My.Resources.Resources.resolve
        Me.btnSave.Location = New System.Drawing.Point(170, 82)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 38)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "   SAVE "
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.txtDrawerNumber)
        Me.Panel2.Location = New System.Drawing.Point(11, 249)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(53, 28)
        Me.Panel2.TabIndex = 4
        '
        'txtDrawerNumber
        '
        Me.txtDrawerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDrawerNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDrawerNumber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrawerNumber.Location = New System.Drawing.Point(1, 1)
        Me.txtDrawerNumber.Multiline = True
        Me.txtDrawerNumber.Name = "txtDrawerNumber"
        Me.txtDrawerNumber.Size = New System.Drawing.Size(51, 26)
        Me.txtDrawerNumber.TabIndex = 38
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnUp.FlatAppearance.BorderSize = 0
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.ForeColor = System.Drawing.Color.White
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(70, 249)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(28, 28)
        Me.btnUp.TabIndex = 5
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
        Me.Button1.Location = New System.Drawing.Point(104, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 28)
        Me.Button1.TabIndex = 6
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
        Me.Button2.Location = New System.Drawing.Point(279, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 28)
        Me.Button2.TabIndex = 9
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
        Me.Button3.Location = New System.Drawing.Point(245, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 28)
        Me.Button3.TabIndex = 8
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.txtQuantity)
        Me.Panel5.Location = New System.Drawing.Point(186, 249)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(53, 28)
        Me.Panel5.TabIndex = 7
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(1, 1)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(51, 26)
        Me.txtQuantity.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(269, 153)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 21)
        Me.Label15.TabIndex = 186
        Me.Label15.Text = "Type:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkGray
        Me.Panel7.Controls.Add(Me.ComboBox3)
        Me.Panel7.Location = New System.Drawing.Point(11, 176)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel7.Size = New System.Drawing.Size(202, 28)
        Me.Panel7.TabIndex = 2
        '
        'ComboBox3
        '
        Me.ComboBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(1, 1)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(200, 25)
        Me.ComboBox3.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 152)
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
        Me.pnlMainLocation.Location = New System.Drawing.Point(17, 48)
        Me.pnlMainLocation.Name = "pnlMainLocation"
        Me.pnlMainLocation.Size = New System.Drawing.Size(496, 491)
        Me.pnlMainLocation.TabIndex = 189
        '
        'pnlMainFormFields
        '
        Me.pnlMainFormFields.Controls.Add(Me.btnSearch)
        Me.pnlMainFormFields.Controls.Add(Me.txtSearch)
        Me.pnlMainFormFields.Controls.Add(Me.lblSearch)
        Me.pnlMainFormFields.Controls.Add(Me.Panel3)
        Me.pnlMainFormFields.Controls.Add(Me.Button3)
        Me.pnlMainFormFields.Controls.Add(Me.Label9)
        Me.pnlMainFormFields.Controls.Add(Me.Panel7)
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
        Me.pnlMainFormFields.Controls.Add(Me.Panel6)
        Me.pnlMainFormFields.Controls.Add(Me.Panel1)
        Me.pnlMainFormFields.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMainFormFields.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainFormFields.Name = "pnlMainFormFields"
        Me.pnlMainFormFields.Size = New System.Drawing.Size(496, 361)
        Me.pnlMainFormFields.TabIndex = 191
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(437, 45)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(36, 22)
        Me.btnSearch.TabIndex = 190
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 45)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(426, 23)
        Me.txtSearch.TabIndex = 190
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(8, 20)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(208, 21)
        Me.lblSearch.TabIndex = 189
        Me.lblSearch.Text = "Search by Medication Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(7, 223)
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
        Me.pnlPatientName.Location = New System.Drawing.Point(0, 367)
        Me.pnlPatientName.Name = "pnlPatientName"
        Me.pnlPatientName.Size = New System.Drawing.Size(496, 124)
        Me.pnlPatientName.TabIndex = 189
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(4, 4)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(106, 21)
        Me.lblPatientName.TabIndex = 191
        Me.lblPatientName.Text = "Patient Name:"
        '
        'pnlPatientNamePadding
        '
        Me.pnlPatientNamePadding.BackColor = System.Drawing.Color.DarkGray
        Me.pnlPatientNamePadding.Controls.Add(Me.cmbPatientNames)
        Me.pnlPatientNamePadding.Location = New System.Drawing.Point(9, 28)
        Me.pnlPatientNamePadding.Name = "pnlPatientNamePadding"
        Me.pnlPatientNamePadding.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlPatientNamePadding.Size = New System.Drawing.Size(465, 28)
        Me.pnlPatientNamePadding.TabIndex = 190
        '
        'cmbPatientNames
        '
        Me.cmbPatientNames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPatientNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPatientNames.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientNames.FormattingEnabled = True
        Me.cmbPatientNames.Location = New System.Drawing.Point(1, 1)
        Me.cmbPatientNames.Name = "cmbPatientNames"
        Me.cmbPatientNames.Size = New System.Drawing.Size(463, 25)
        Me.cmbPatientNames.TabIndex = 10
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGray
        Me.Panel6.Controls.Add(Me.ComboBox2)
        Me.Panel6.Location = New System.Drawing.Point(272, 176)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel6.Size = New System.Drawing.Size(202, 28)
        Me.Panel6.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(1, 1)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 25)
        Me.ComboBox2.TabIndex = 10
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1005, 602)
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
        Me.Panel7.ResumeLayout(False)
        Me.pnlMainLocation.ResumeLayout(False)
        Me.pnlMainFormFields.ResumeLayout(False)
        Me.pnlMainFormFields.PerformLayout()
        Me.pnlPatientName.ResumeLayout(False)
        Me.pnlPatientName.PerformLayout()
        Me.pnlPatientNamePadding.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
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
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlMainLocation As Panel
    Friend WithEvents pnlPatientName As Panel
    Friend WithEvents pnlPatientNamePadding As Panel
    Friend WithEvents cmbPatientNames As ComboBox
    Friend WithEvents lblPatientName As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents pnlMainFormFields As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ComboBox2 As ComboBox
End Class
