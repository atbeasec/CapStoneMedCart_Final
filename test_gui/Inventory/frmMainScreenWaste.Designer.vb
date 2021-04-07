<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainScreenWaste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainScreenWaste))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlRadioButtons = New System.Windows.Forms.Panel()
        Me.pnlSignOff = New System.Windows.Forms.Panel()
        Me.pnlCredentials = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblUseBarcode = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnWasteWithCredentials = New System.Windows.Forms.Button()
        Me.pnlBarcode = New System.Windows.Forms.Panel()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblBadge = New System.Windows.Forms.Label()
        Me.btnWaste = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.rbtnOther = New System.Windows.Forms.RadioButton()
        Me.radPatientUnavilable = New System.Windows.Forms.RadioButton()
        Me.radRefused = New System.Windows.Forms.RadioButton()
        Me.radCancel = New System.Windows.Forms.RadioButton()
        Me.radIncorrect = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbMedications = New System.Windows.Forms.ComboBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtDrawerBin = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtRoomBed = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtMRN = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbPatientName = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlRadioButtons.SuspendLayout()
        Me.pnlSignOff.SuspendLayout()
        Me.pnlCredentials.SuspendLayout()
        Me.pnlBarcode.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1203, 10)
        Me.pnlHeader.TabIndex = 222
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
        Me.btnBack.Location = New System.Drawing.Point(14, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 37)
        Me.btnBack.TabIndex = 61
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(666, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 25)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "Reason For Waste"
        '
        'pnlRadioButtons
        '
        Me.pnlRadioButtons.Controls.Add(Me.pnlSignOff)
        Me.pnlRadioButtons.Controls.Add(Me.txtOther)
        Me.pnlRadioButtons.Controls.Add(Me.rbtnOther)
        Me.pnlRadioButtons.Controls.Add(Me.radPatientUnavilable)
        Me.pnlRadioButtons.Controls.Add(Me.radRefused)
        Me.pnlRadioButtons.Controls.Add(Me.radCancel)
        Me.pnlRadioButtons.Controls.Add(Me.radIncorrect)
        Me.pnlRadioButtons.Location = New System.Drawing.Point(670, 148)
        Me.pnlRadioButtons.Name = "pnlRadioButtons"
        Me.pnlRadioButtons.Size = New System.Drawing.Size(497, 438)
        Me.pnlRadioButtons.TabIndex = 218
        '
        'pnlSignOff
        '
        Me.pnlSignOff.Controls.Add(Me.pnlCredentials)
        Me.pnlSignOff.Controls.Add(Me.pnlBarcode)
        Me.pnlSignOff.Location = New System.Drawing.Point(3, 157)
        Me.pnlSignOff.Name = "pnlSignOff"
        Me.pnlSignOff.Size = New System.Drawing.Size(491, 253)
        Me.pnlSignOff.TabIndex = 24
        '
        'pnlCredentials
        '
        Me.pnlCredentials.Controls.Add(Me.txtPassword)
        Me.pnlCredentials.Controls.Add(Me.Label5)
        Me.pnlCredentials.Controls.Add(Me.lblFirstName)
        Me.pnlCredentials.Controls.Add(Me.lblUseBarcode)
        Me.pnlCredentials.Controls.Add(Me.txtUsername)
        Me.pnlCredentials.Controls.Add(Me.Label11)
        Me.pnlCredentials.Controls.Add(Me.btnWasteWithCredentials)
        Me.pnlCredentials.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlCredentials.Location = New System.Drawing.Point(245, 0)
        Me.pnlCredentials.Name = "pnlCredentials"
        Me.pnlCredentials.Size = New System.Drawing.Size(242, 253)
        Me.pnlCredentials.TabIndex = 221
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(8, 122)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ShortcutsEnabled = False
        Me.txtPassword.Size = New System.Drawing.Size(220, 25)
        Me.txtPassword.TabIndex = 223
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 222
        Me.Label5.Text = "Password:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(3, 38)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(84, 21)
        Me.lblFirstName.TabIndex = 221
        Me.lblFirstName.Text = "Username:"
        '
        'lblUseBarcode
        '
        Me.lblUseBarcode.AutoSize = True
        Me.lblUseBarcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUseBarcode.ForeColor = System.Drawing.Color.Black
        Me.lblUseBarcode.Location = New System.Drawing.Point(56, 199)
        Me.lblUseBarcode.Name = "lblUseBarcode"
        Me.lblUseBarcode.Size = New System.Drawing.Size(133, 17)
        Me.lblUseBarcode.TabIndex = 220
        Me.lblUseBarcode.Text = "Scan Barcode Instead"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(8, 61)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ShortcutsEnabled = False
        Me.txtUsername.Size = New System.Drawing.Size(220, 25)
        Me.txtUsername.TabIndex = 217
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(235, 25)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Witness Sign-off Required"
        '
        'btnWasteWithCredentials
        '
        Me.btnWasteWithCredentials.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnWasteWithCredentials.FlatAppearance.BorderSize = 0
        Me.btnWasteWithCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWasteWithCredentials.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWasteWithCredentials.ForeColor = System.Drawing.Color.White
        Me.btnWasteWithCredentials.Image = CType(resources.GetObject("btnWasteWithCredentials.Image"), System.Drawing.Image)
        Me.btnWasteWithCredentials.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnWasteWithCredentials.Location = New System.Drawing.Point(47, 159)
        Me.btnWasteWithCredentials.Name = "btnWasteWithCredentials"
        Me.btnWasteWithCredentials.Size = New System.Drawing.Size(150, 37)
        Me.btnWasteWithCredentials.TabIndex = 31
        Me.btnWasteWithCredentials.Text = "   SUBMIT"
        Me.btnWasteWithCredentials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWasteWithCredentials.UseVisualStyleBackColor = False
        '
        'pnlBarcode
        '
        Me.pnlBarcode.Controls.Add(Me.txtBarcode)
        Me.pnlBarcode.Controls.Add(Me.Label12)
        Me.pnlBarcode.Controls.Add(Me.lblBadge)
        Me.pnlBarcode.Controls.Add(Me.btnWaste)
        Me.pnlBarcode.Controls.Add(Me.Label13)
        Me.pnlBarcode.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlBarcode.Location = New System.Drawing.Point(0, 0)
        Me.pnlBarcode.Name = "pnlBarcode"
        Me.pnlBarcode.Size = New System.Drawing.Size(245, 253)
        Me.pnlBarcode.TabIndex = 220
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.White
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(4, 61)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ShortcutsEnabled = False
        Me.txtBarcode.Size = New System.Drawing.Size(230, 25)
        Me.txtBarcode.TabIndex = 217
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(74, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 17)
        Me.Label12.TabIndex = 219
        Me.Label12.Text = "Scan barcode"
        '
        'lblBadge
        '
        Me.lblBadge.AutoSize = True
        Me.lblBadge.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBadge.ForeColor = System.Drawing.Color.Black
        Me.lblBadge.Location = New System.Drawing.Point(46, 141)
        Me.lblBadge.Name = "lblBadge"
        Me.lblBadge.Size = New System.Drawing.Size(144, 17)
        Me.lblBadge.TabIndex = 218
        Me.lblBadge.Text = "Enter Password Instead"
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
        Me.btnWaste.Location = New System.Drawing.Point(40, 101)
        Me.btnWaste.Name = "btnWaste"
        Me.btnWaste.Size = New System.Drawing.Size(150, 37)
        Me.btnWaste.TabIndex = 31
        Me.btnWaste.Text = "   SUBMIT"
        Me.btnWaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWaste.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(4, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(235, 25)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Witness Sign-off Required"
        '
        'txtOther
        '
        Me.txtOther.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOther.Location = New System.Drawing.Point(21, 158)
        Me.txtOther.Multiline = True
        Me.txtOther.Name = "txtOther"
        Me.txtOther.ShortcutsEnabled = False
        Me.txtOther.Size = New System.Drawing.Size(329, 124)
        Me.txtOther.TabIndex = 6
        '
        'rbtnOther
        '
        Me.rbtnOther.AutoSize = True
        Me.rbtnOther.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnOther.Location = New System.Drawing.Point(3, 127)
        Me.rbtnOther.Name = "rbtnOther"
        Me.rbtnOther.Size = New System.Drawing.Size(219, 25)
        Me.rbtnOther.TabIndex = 5
        Me.rbtnOther.Text = "Other (Provide Explanation)"
        Me.rbtnOther.UseVisualStyleBackColor = True
        '
        'radPatientUnavilable
        '
        Me.radPatientUnavilable.AutoSize = True
        Me.radPatientUnavilable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPatientUnavilable.Location = New System.Drawing.Point(3, 96)
        Me.radPatientUnavilable.Name = "radPatientUnavilable"
        Me.radPatientUnavilable.Size = New System.Drawing.Size(130, 25)
        Me.radPatientUnavilable.TabIndex = 4
        Me.radPatientUnavilable.Text = "Excess amount"
        Me.radPatientUnavilable.UseVisualStyleBackColor = True
        '
        'radRefused
        '
        Me.radRefused.AutoSize = True
        Me.radRefused.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRefused.Location = New System.Drawing.Point(3, 65)
        Me.radRefused.Name = "radRefused"
        Me.radRefused.Size = New System.Drawing.Size(135, 25)
        Me.radRefused.TabIndex = 3
        Me.radRefused.Text = "Patient Refused"
        Me.radRefused.UseVisualStyleBackColor = True
        '
        'radCancel
        '
        Me.radCancel.AutoSize = True
        Me.radCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCancel.Location = New System.Drawing.Point(3, 34)
        Me.radCancel.Name = "radCancel"
        Me.radCancel.Size = New System.Drawing.Size(208, 25)
        Me.radCancel.TabIndex = 2
        Me.radCancel.Text = "Order Canceled / On Hold"
        Me.radCancel.UseVisualStyleBackColor = True
        '
        'radIncorrect
        '
        Me.radIncorrect.AutoSize = True
        Me.radIncorrect.Checked = True
        Me.radIncorrect.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radIncorrect.Location = New System.Drawing.Point(3, 3)
        Me.radIncorrect.Name = "radIncorrect"
        Me.radIncorrect.Size = New System.Drawing.Size(170, 25)
        Me.radIncorrect.TabIndex = 1
        Me.radIncorrect.TabStop = True
        Me.radIncorrect.Text = "Incorrect Medication"
        Me.radIncorrect.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(237, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 21)
        Me.Label6.TabIndex = 235
        Me.Label6.Text = "Patient Room and Bed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 21)
        Me.Label3.TabIndex = 232
        Me.Label3.Text = "Patient MRN:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(492, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 21)
        Me.Label8.TabIndex = 231
        Me.Label8.Text = "Patient DOB:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 21)
        Me.Label7.TabIndex = 230
        Me.Label7.Text = "Select Patient:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 21)
        Me.Label9.TabIndex = 239
        Me.Label9.Text = "Drawer and Bin number:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 210)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 21)
        Me.Label17.TabIndex = 238
        Me.Label17.Text = "Medication:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.cmbMedications)
        Me.Panel1.Location = New System.Drawing.Point(14, 234)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(604, 31)
        Me.Panel1.TabIndex = 2
        '
        'cmbMedications
        '
        Me.cmbMedications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMedications.DropDownHeight = 200
        Me.cmbMedications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMedications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMedications.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedications.FormattingEnabled = True
        Me.cmbMedications.IntegralHeight = False
        Me.cmbMedications.Location = New System.Drawing.Point(1, 1)
        Me.cmbMedications.Name = "cmbMedications"
        Me.cmbMedications.Size = New System.Drawing.Size(602, 29)
        Me.cmbMedications.TabIndex = 2
        Me.cmbMedications.Tag = "cmbFrequencyNumber"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.DarkGray
        Me.Panel12.Controls.Add(Me.txtDateOfBirth)
        Me.Panel12.Location = New System.Drawing.Point(496, 158)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel12.Size = New System.Drawing.Size(122, 28)
        Me.Panel12.TabIndex = 249
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.BackColor = System.Drawing.Color.White
        Me.txtDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDateOfBirth.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateOfBirth.Location = New System.Drawing.Point(1, 1)
        Me.txtDateOfBirth.Multiline = True
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.ReadOnly = True
        Me.txtDateOfBirth.ShortcutsEnabled = False
        Me.txtDateOfBirth.Size = New System.Drawing.Size(120, 26)
        Me.txtDateOfBirth.TabIndex = 38
        Me.txtDateOfBirth.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.DarkGray
        Me.Panel11.Controls.Add(Me.txtDrawerBin)
        Me.Panel11.Location = New System.Drawing.Point(14, 314)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel11.Size = New System.Drawing.Size(296, 28)
        Me.Panel11.TabIndex = 248
        '
        'txtDrawerBin
        '
        Me.txtDrawerBin.BackColor = System.Drawing.Color.White
        Me.txtDrawerBin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDrawerBin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDrawerBin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrawerBin.Location = New System.Drawing.Point(1, 1)
        Me.txtDrawerBin.Multiline = True
        Me.txtDrawerBin.Name = "txtDrawerBin"
        Me.txtDrawerBin.ReadOnly = True
        Me.txtDrawerBin.ShortcutsEnabled = False
        Me.txtDrawerBin.Size = New System.Drawing.Size(294, 26)
        Me.txtDrawerBin.TabIndex = 38
        Me.txtDrawerBin.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGray
        Me.Panel6.Controls.Add(Me.txtRoomBed)
        Me.Panel6.Location = New System.Drawing.Point(241, 158)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel6.Size = New System.Drawing.Size(209, 28)
        Me.Panel6.TabIndex = 242
        '
        'txtRoomBed
        '
        Me.txtRoomBed.BackColor = System.Drawing.Color.White
        Me.txtRoomBed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRoomBed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRoomBed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomBed.Location = New System.Drawing.Point(1, 1)
        Me.txtRoomBed.Multiline = True
        Me.txtRoomBed.Name = "txtRoomBed"
        Me.txtRoomBed.ReadOnly = True
        Me.txtRoomBed.ShortcutsEnabled = False
        Me.txtRoomBed.Size = New System.Drawing.Size(207, 26)
        Me.txtRoomBed.TabIndex = 38
        Me.txtRoomBed.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.txtMRN)
        Me.Panel4.Location = New System.Drawing.Point(14, 158)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel4.Size = New System.Drawing.Size(175, 28)
        Me.Panel4.TabIndex = 243
        '
        'txtMRN
        '
        Me.txtMRN.BackColor = System.Drawing.Color.White
        Me.txtMRN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMRN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMRN.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRN.Location = New System.Drawing.Point(1, 1)
        Me.txtMRN.Multiline = True
        Me.txtMRN.Name = "txtMRN"
        Me.txtMRN.ReadOnly = True
        Me.txtMRN.ShortcutsEnabled = False
        Me.txtMRN.Size = New System.Drawing.Size(173, 26)
        Me.txtMRN.TabIndex = 38
        Me.txtMRN.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.cmbPatientName)
        Me.Panel2.Location = New System.Drawing.Point(15, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(602, 31)
        Me.Panel2.TabIndex = 1
        '
        'cmbPatientName
        '
        Me.cmbPatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPatientName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPatientName.DropDownHeight = 200
        Me.cmbPatientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPatientName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientName.FormattingEnabled = True
        Me.cmbPatientName.IntegralHeight = False
        Me.cmbPatientName.Location = New System.Drawing.Point(1, 1)
        Me.cmbPatientName.Name = "cmbPatientName"
        Me.cmbPatientName.Size = New System.Drawing.Size(600, 29)
        Me.cmbPatientName.TabIndex = 1
        Me.cmbPatientName.Tag = "cmbFrequencyNumber"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.txtQuantity)
        Me.Panel3.Location = New System.Drawing.Point(670, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(158, 31)
        Me.Panel3.TabIndex = 3
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(1, 1)
        Me.txtQuantity.MaxLength = 5
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ShortcutsEnabled = False
        Me.txtQuantity.Size = New System.Drawing.Size(156, 29)
        Me.txtQuantity.TabIndex = 38
        Me.txtQuantity.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.txtUnit)
        Me.Panel5.Location = New System.Drawing.Point(844, 79)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(64, 31)
        Me.Panel5.TabIndex = 4
        '
        'txtUnit
        '
        Me.txtUnit.BackColor = System.Drawing.Color.White
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(1, 1)
        Me.txtUnit.MaxLength = 8
        Me.txtUnit.Multiline = True
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.ShortcutsEnabled = False
        Me.txtUnit.Size = New System.Drawing.Size(62, 29)
        Me.txtUnit.TabIndex = 38
        Me.txtUnit.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 251
        Me.Label1.Text = "Waste Form"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(667, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 21)
        Me.Label4.TabIndex = 252
        Me.Label4.Text = "Amount Wasted:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(840, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 21)
        Me.Label10.TabIndex = 253
        Me.Label10.Text = "Units:"
        '
        'frmMainScreenWaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1203, 593)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlRadioButtons)
        Me.Name = "frmMainScreenWaste"
        Me.Text = "frmMainScreenWaste"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlRadioButtons.ResumeLayout(False)
        Me.pnlRadioButtons.PerformLayout()
        Me.pnlSignOff.ResumeLayout(False)
        Me.pnlCredentials.ResumeLayout(False)
        Me.pnlCredentials.PerformLayout()
        Me.pnlBarcode.ResumeLayout(False)
        Me.pnlBarcode.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlRadioButtons As Panel
    Friend WithEvents pnlSignOff As Panel
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents btnWaste As Button
    Friend WithEvents txtOther As TextBox
    Friend WithEvents rbtnOther As RadioButton
    Friend WithEvents radPatientUnavilable As RadioButton
    Friend WithEvents radRefused As RadioButton
    Friend WithEvents radCancel As RadioButton
    Friend WithEvents radIncorrect As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbMedications As ComboBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtDrawerBin As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtRoomBed As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtMRN As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbPatientName As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pnlCredentials As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblUseBarcode As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnWasteWithCredentials As Button
    Friend WithEvents pnlBarcode As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblBadge As Label
    Friend WithEvents Label13 As Label
End Class
