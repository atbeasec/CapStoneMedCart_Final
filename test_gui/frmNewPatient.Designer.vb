﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewPatient))
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.mtbDoB = New System.Windows.Forms.MaskedTextBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbSex = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbBed = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmbRoom = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmbPhysician = New System.Windows.Forms.ComboBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(1, 1)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(250, 26)
        Me.txtFirstName.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Location = New System.Drawing.Point(46, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(252, 28)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Patient Information"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkGray
        Me.Panel9.Controls.Add(Me.txtMiddleName)
        Me.Panel9.Location = New System.Drawing.Point(46, 151)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel9.Size = New System.Drawing.Size(252, 28)
        Me.Panel9.TabIndex = 3
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMiddleName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(1, 1)
        Me.txtMiddleName.Multiline = True
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(250, 26)
        Me.txtMiddleName.TabIndex = 3
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DarkGray
        Me.Panel10.Controls.Add(Me.txtAddress)
        Me.Panel10.Location = New System.Drawing.Point(46, 361)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel10.Size = New System.Drawing.Size(562, 28)
        Me.Panel10.TabIndex = 11
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(1, 1)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(560, 26)
        Me.txtAddress.TabIndex = 11
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.DarkGray
        Me.Panel11.Controls.Add(Me.txtLastName)
        Me.Panel11.Location = New System.Drawing.Point(349, 80)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel11.Size = New System.Drawing.Size(259, 28)
        Me.Panel11.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(1, 1)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(257, 26)
        Me.txtLastName.TabIndex = 2
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.DarkGray
        Me.Panel12.Controls.Add(Me.txtEmail)
        Me.Panel12.Location = New System.Drawing.Point(350, 150)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel12.Size = New System.Drawing.Size(258, 28)
        Me.Panel12.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(1, 1)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(256, 26)
        Me.txtEmail.TabIndex = 4
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.DarkGray
        Me.Panel14.Controls.Add(Me.mtbDoB)
        Me.Panel14.Location = New System.Drawing.Point(198, 220)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel14.Size = New System.Drawing.Size(100, 29)
        Me.Panel14.TabIndex = 6
        '
        'mtbDoB
        '
        Me.mtbDoB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mtbDoB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mtbDoB.Location = New System.Drawing.Point(1, 1)
        Me.mtbDoB.Mask = "00/00/0000"
        Me.mtbDoB.Name = "mtbDoB"
        Me.mtbDoB.Size = New System.Drawing.Size(98, 29)
        Me.mtbDoB.TabIndex = 0
        Me.mtbDoB.ValidatingType = GetType(Date)
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.DarkGray
        Me.Panel15.Controls.Add(Me.mtbPhone)
        Me.Panel15.Location = New System.Drawing.Point(46, 501)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel15.Size = New System.Drawing.Size(252, 28)
        Me.Panel15.TabIndex = 15
        '
        'mtbPhone
        '
        Me.mtbPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mtbPhone.Location = New System.Drawing.Point(0, 0)
        Me.mtbPhone.Mask = "(999) 000-0000"
        Me.mtbPhone.Name = "mtbPhone"
        Me.mtbPhone.Size = New System.Drawing.Size(252, 29)
        Me.mtbPhone.TabIndex = 0
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.DarkGray
        Me.Panel16.Controls.Add(Me.txtCity)
        Me.Panel16.Location = New System.Drawing.Point(46, 431)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel16.Size = New System.Drawing.Size(251, 28)
        Me.Panel16.TabIndex = 12
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(1, 1)
        Me.txtCity.Multiline = True
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(249, 26)
        Me.txtCity.TabIndex = 12
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.DarkGray
        Me.Panel17.Controls.Add(Me.txtZipCode)
        Me.Panel17.Location = New System.Drawing.Point(500, 431)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel17.Size = New System.Drawing.Size(108, 28)
        Me.Panel17.TabIndex = 14
        '
        'txtZipCode
        '
        Me.txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtZipCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtZipCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(1, 1)
        Me.txtZipCode.MaxLength = 5
        Me.txtZipCode.Multiline = True
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(106, 26)
        Me.txtZipCode.TabIndex = 14
        '
        'cmbState
        '
        Me.cmbState.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbState.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Location = New System.Drawing.Point(1, 1)
        Me.cmbState.MaxLength = 2
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(78, 25)
        Me.cmbState.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.cmbState)
        Me.Panel2.Location = New System.Drawing.Point(348, 432)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(80, 28)
        Me.Panel2.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.cmbSex)
        Me.Panel3.Location = New System.Drawing.Point(46, 221)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(124, 28)
        Me.Panel3.TabIndex = 5
        '
        'cmbSex
        '
        Me.cmbSex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSex.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Location = New System.Drawing.Point(1, 1)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(122, 25)
        Me.cmbSex.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.cmbBed)
        Me.Panel4.Location = New System.Drawing.Point(401, 291)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel4.Size = New System.Drawing.Size(207, 28)
        Me.Panel4.TabIndex = 10
        '
        'cmbBed
        '
        Me.cmbBed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbBed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBed.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBed.FormattingEnabled = True
        Me.cmbBed.Location = New System.Drawing.Point(1, 1)
        Me.cmbBed.Name = "cmbBed"
        Me.cmbBed.Size = New System.Drawing.Size(205, 25)
        Me.cmbBed.TabIndex = 10
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.cmbRoom)
        Me.Panel5.Location = New System.Drawing.Point(46, 291)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(202, 28)
        Me.Panel5.TabIndex = 9
        '
        'cmbRoom
        '
        Me.cmbRoom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRoom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoom.FormattingEnabled = True
        Me.cmbRoom.Location = New System.Drawing.Point(1, 1)
        Me.cmbRoom.Name = "cmbRoom"
        Me.cmbRoom.Size = New System.Drawing.Size(200, 25)
        Me.cmbRoom.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.test_gui.My.Resources.Resources.resolve
        Me.btnSave.Location = New System.Drawing.Point(348, 562)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 38)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "   SAVE "
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGray
        Me.Panel6.Controls.Add(Me.txtHeight)
        Me.Panel6.Location = New System.Drawing.Point(349, 220)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel6.Size = New System.Drawing.Size(103, 28)
        Me.Panel6.TabIndex = 7
        '
        'txtHeight
        '
        Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(1, 1)
        Me.txtHeight.MaxLength = 4
        Me.txtHeight.Multiline = True
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(101, 26)
        Me.txtHeight.TabIndex = 7
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkGray
        Me.Panel7.Controls.Add(Me.txtWeight)
        Me.Panel7.Location = New System.Drawing.Point(495, 221)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel7.Size = New System.Drawing.Size(112, 28)
        Me.Panel7.TabIndex = 8
        '
        'txtWeight
        '
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(1, 1)
        Me.txtWeight.MaxLength = 4
        Me.txtWeight.Multiline = True
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(110, 26)
        Me.txtWeight.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkGray
        Me.Panel8.Controls.Add(Me.cmbPhysician)
        Me.Panel8.Location = New System.Drawing.Point(348, 502)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel8.Size = New System.Drawing.Size(279, 28)
        Me.Panel8.TabIndex = 16
        '
        'cmbPhysician
        '
        Me.cmbPhysician.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPhysician.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPhysician.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPhysician.FormattingEnabled = True
        Me.cmbPhysician.Location = New System.Drawing.Point(1, 1)
        Me.cmbPhysician.Name = "cmbPhysician"
        Me.cmbPhysician.Size = New System.Drawing.Size(277, 25)
        Me.cmbPhysician.TabIndex = 85
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(43, 53)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(89, 21)
        Me.lblFirstName.TabIndex = 68
        Me.lblFirstName.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(345, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(42, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 21)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Middle Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(346, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(43, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 21)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Sex:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(195, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "DOB:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(347, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 21)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Height:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(492, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 21)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Weight:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(44, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 21)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Room:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(398, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 21)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Bed:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(44, 335)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 21)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Street Address:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(43, 407)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 21)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "City:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(345, 407)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 21)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "State:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(497, 407)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 21)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Zip Code:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(44, 478)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 21)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Phone:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(347, 478)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 21)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Primary Physician"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(177, 562)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 38)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "   CANCEL"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmNewPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(656, 634)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmNewPatient"
        Me.Text = "frmNewPatient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Panel17 As Panel
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbSex As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cmbBed As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cmbRoom As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblFirstName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents cmbPhysician As ComboBox
    Friend WithEvents mtbDoB As MaskedTextBox
    Friend WithEvents mtbPhone As MaskedTextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
