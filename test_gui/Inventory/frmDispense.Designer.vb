<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDispense
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDispense))
        Me.lstboxAllergies = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.flpMedications = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtQuantityToDispense = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblPatientInfo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlSelector = New System.Windows.Forms.Panel()
        Me.btnDrawer13 = New System.Windows.Forms.Button()
        Me.btnDrawer12 = New System.Windows.Forms.Button()
        Me.btnDrawer23 = New System.Windows.Forms.Button()
        Me.btnDrawer22 = New System.Windows.Forms.Button()
        Me.btnDrawer9 = New System.Windows.Forms.Button()
        Me.btnDrawer24 = New System.Windows.Forms.Button()
        Me.btnDrawer8 = New System.Windows.Forms.Button()
        Me.btnDrawer7 = New System.Windows.Forms.Button()
        Me.btnDrawer19 = New System.Windows.Forms.Button()
        Me.btnDrawer18 = New System.Windows.Forms.Button()
        Me.btnDrawer17 = New System.Windows.Forms.Button()
        Me.btnDrawer14 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnDispense = New System.Windows.Forms.Button()
        Me.pnlAmountAdministered = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAmountDispensed = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.pnlAmountInDrawer = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtCountInDrawer = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.pnlAmountToRemove = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.pnlDispenseHistoryHeader = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblDispensedBy = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.txtMedication = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtContainer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrescribedAmount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFrequency = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSelector.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.pnlAmountAdministered.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlAmountInDrawer.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.pnlAmountToRemove.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pnlDispenseHistoryHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstboxAllergies
        '
        Me.lstboxAllergies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxAllergies.FormattingEnabled = True
        Me.lstboxAllergies.ItemHeight = 20
        Me.lstboxAllergies.Location = New System.Drawing.Point(21, 148)
        Me.lstboxAllergies.Name = "lstboxAllergies"
        Me.lstboxAllergies.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstboxAllergies.Size = New System.Drawing.Size(182, 204)
        Me.lstboxAllergies.TabIndex = 5
        Me.lstboxAllergies.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 381)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 21)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Dispense History"
        '
        'flpMedications
        '
        Me.flpMedications.AutoScroll = True
        Me.flpMedications.BackColor = System.Drawing.Color.White
        Me.flpMedications.Location = New System.Drawing.Point(18, 461)
        Me.flpMedications.Name = "flpMedications"
        Me.flpMedications.Size = New System.Drawing.Size(1066, 186)
        Me.flpMedications.TabIndex = 53
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 21)
        Me.Label17.TabIndex = 176
        Me.Label17.Text = "Medication:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(450, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 21)
        Me.Label15.TabIndex = 183
        Me.Label15.Text = "Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 187
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 21)
        Me.Label13.TabIndex = 197
        Me.Label13.Text = "Medication Allergies:"
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDown.FlatAppearance.BorderSize = 0
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.ForeColor = System.Drawing.Color.White
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(227, 15)
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
        Me.btnUp.Location = New System.Drawing.Point(193, 15)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(28, 28)
        Me.btnUp.TabIndex = 5
        Me.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.txtQuantityToDispense)
        Me.Panel5.Location = New System.Drawing.Point(80, 16)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(90, 28)
        Me.Panel5.TabIndex = 4
        '
        'txtQuantityToDispense
        '
        Me.txtQuantityToDispense.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantityToDispense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuantityToDispense.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantityToDispense.Location = New System.Drawing.Point(1, 1)
        Me.txtQuantityToDispense.Multiline = True
        Me.txtQuantityToDispense.Name = "txtQuantityToDispense"
        Me.txtQuantityToDispense.ShortcutsEnabled = False
        Me.txtQuantityToDispense.Size = New System.Drawing.Size(88, 26)
        Me.txtQuantityToDispense.TabIndex = 38
        Me.txtQuantityToDispense.Text = "1"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblPatientInfo)
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.Label4)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1116, 49)
        Me.pnlHeader.TabIndex = 201
        '
        'lblPatientInfo
        '
        Me.lblPatientInfo.AutoSize = True
        Me.lblPatientInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblPatientInfo.Location = New System.Drawing.Point(117, 9)
        Me.lblPatientInfo.Name = "lblPatientInfo"
        Me.lblPatientInfo.Size = New System.Drawing.Size(56, 21)
        Me.lblPatientInfo.TabIndex = 199
        Me.lblPatientInfo.Text = "Label1"
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
        'pnlSelector
        '
        Me.pnlSelector.Controls.Add(Me.btnDrawer13)
        Me.pnlSelector.Controls.Add(Me.btnDrawer12)
        Me.pnlSelector.Controls.Add(Me.btnDrawer23)
        Me.pnlSelector.Controls.Add(Me.btnDrawer22)
        Me.pnlSelector.Controls.Add(Me.btnDrawer9)
        Me.pnlSelector.Controls.Add(Me.btnDrawer24)
        Me.pnlSelector.Controls.Add(Me.btnDrawer8)
        Me.pnlSelector.Controls.Add(Me.btnDrawer7)
        Me.pnlSelector.Controls.Add(Me.btnDrawer19)
        Me.pnlSelector.Controls.Add(Me.btnDrawer18)
        Me.pnlSelector.Controls.Add(Me.btnDrawer17)
        Me.pnlSelector.Controls.Add(Me.btnDrawer14)
        Me.pnlSelector.Location = New System.Drawing.Point(1104, 227)
        Me.pnlSelector.Name = "pnlSelector"
        Me.pnlSelector.Size = New System.Drawing.Size(255, 327)
        Me.pnlSelector.TabIndex = 202
        '
        'btnDrawer13
        '
        Me.btnDrawer13.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer13.FlatAppearance.BorderSize = 0
        Me.btnDrawer13.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer13.Location = New System.Drawing.Point(93, 92)
        Me.btnDrawer13.Name = "btnDrawer13"
        Me.btnDrawer13.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer13.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer13.TabIndex = 13
        Me.btnDrawer13.Text = "5"
        Me.btnDrawer13.UseVisualStyleBackColor = False
        '
        'btnDrawer12
        '
        Me.btnDrawer12.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer12.FlatAppearance.BorderSize = 0
        Me.btnDrawer12.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer12.Location = New System.Drawing.Point(17, 92)
        Me.btnDrawer12.Name = "btnDrawer12"
        Me.btnDrawer12.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer12.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer12.TabIndex = 12
        Me.btnDrawer12.Text = "4"
        Me.btnDrawer12.UseVisualStyleBackColor = False
        '
        'btnDrawer23
        '
        Me.btnDrawer23.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer23.FlatAppearance.BorderSize = 0
        Me.btnDrawer23.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer23.Location = New System.Drawing.Point(93, 243)
        Me.btnDrawer23.Name = "btnDrawer23"
        Me.btnDrawer23.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer23.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer23.TabIndex = 23
        Me.btnDrawer23.Text = "0"
        Me.btnDrawer23.UseVisualStyleBackColor = False
        '
        'btnDrawer22
        '
        Me.btnDrawer22.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer22.FlatAppearance.BorderSize = 0
        Me.btnDrawer22.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer22.Location = New System.Drawing.Point(17, 242)
        Me.btnDrawer22.Name = "btnDrawer22"
        Me.btnDrawer22.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer22.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer22.TabIndex = 22
        Me.btnDrawer22.Text = "Clear"
        Me.btnDrawer22.UseVisualStyleBackColor = False
        '
        'btnDrawer9
        '
        Me.btnDrawer9.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer9.FlatAppearance.BorderSize = 0
        Me.btnDrawer9.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer9.Location = New System.Drawing.Point(169, 19)
        Me.btnDrawer9.Name = "btnDrawer9"
        Me.btnDrawer9.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer9.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer9.TabIndex = 9
        Me.btnDrawer9.Text = "3"
        Me.btnDrawer9.UseVisualStyleBackColor = False
        '
        'btnDrawer24
        '
        Me.btnDrawer24.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer24.FlatAppearance.BorderSize = 0
        Me.btnDrawer24.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer24.Location = New System.Drawing.Point(169, 242)
        Me.btnDrawer24.Name = "btnDrawer24"
        Me.btnDrawer24.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer24.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer24.TabIndex = 24
        Me.btnDrawer24.Text = "Enter"
        Me.btnDrawer24.UseVisualStyleBackColor = False
        '
        'btnDrawer8
        '
        Me.btnDrawer8.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer8.FlatAppearance.BorderSize = 0
        Me.btnDrawer8.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer8.Location = New System.Drawing.Point(93, 18)
        Me.btnDrawer8.Name = "btnDrawer8"
        Me.btnDrawer8.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer8.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer8.TabIndex = 8
        Me.btnDrawer8.Text = "2"
        Me.btnDrawer8.UseVisualStyleBackColor = False
        '
        'btnDrawer7
        '
        Me.btnDrawer7.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer7.FlatAppearance.BorderSize = 0
        Me.btnDrawer7.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer7.Location = New System.Drawing.Point(17, 17)
        Me.btnDrawer7.Name = "btnDrawer7"
        Me.btnDrawer7.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer7.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer7.TabIndex = 7
        Me.btnDrawer7.Text = "1"
        Me.btnDrawer7.UseVisualStyleBackColor = False
        '
        'btnDrawer19
        '
        Me.btnDrawer19.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer19.FlatAppearance.BorderSize = 0
        Me.btnDrawer19.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer19.Location = New System.Drawing.Point(169, 169)
        Me.btnDrawer19.Name = "btnDrawer19"
        Me.btnDrawer19.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer19.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer19.TabIndex = 19
        Me.btnDrawer19.Tag = "9"
        Me.btnDrawer19.Text = "9"
        Me.btnDrawer19.UseVisualStyleBackColor = False
        '
        'btnDrawer18
        '
        Me.btnDrawer18.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer18.FlatAppearance.BorderSize = 0
        Me.btnDrawer18.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer18.Location = New System.Drawing.Point(93, 168)
        Me.btnDrawer18.Name = "btnDrawer18"
        Me.btnDrawer18.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer18.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer18.TabIndex = 18
        Me.btnDrawer18.Tag = "8"
        Me.btnDrawer18.Text = "8"
        Me.btnDrawer18.UseVisualStyleBackColor = False
        '
        'btnDrawer17
        '
        Me.btnDrawer17.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer17.FlatAppearance.BorderSize = 0
        Me.btnDrawer17.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer17.Location = New System.Drawing.Point(17, 167)
        Me.btnDrawer17.Name = "btnDrawer17"
        Me.btnDrawer17.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer17.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer17.TabIndex = 17
        Me.btnDrawer17.Text = "7"
        Me.btnDrawer17.UseVisualStyleBackColor = False
        '
        'btnDrawer14
        '
        Me.btnDrawer14.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDrawer14.FlatAppearance.BorderSize = 0
        Me.btnDrawer14.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrawer14.Location = New System.Drawing.Point(169, 92)
        Me.btnDrawer14.Name = "btnDrawer14"
        Me.btnDrawer14.Padding = New System.Windows.Forms.Padding(1)
        Me.btnDrawer14.Size = New System.Drawing.Size(70, 70)
        Me.btnDrawer14.TabIndex = 14
        Me.btnDrawer14.Text = "6"
        Me.btnDrawer14.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.pnlAmountAdministered)
        Me.Panel1.Controls.Add(Me.pnlAmountInDrawer)
        Me.Panel1.Controls.Add(Me.pnlAmountToRemove)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Location = New System.Drawing.Point(383, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 367)
        Me.Panel1.TabIndex = 203
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnDispense)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 223)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(326, 99)
        Me.Panel8.TabIndex = 208
        '
        'btnDispense
        '
        Me.btnDispense.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDispense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispense.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispense.ForeColor = System.Drawing.Color.White
        Me.btnDispense.Image = CType(resources.GetObject("btnDispense.Image"), System.Drawing.Image)
        Me.btnDispense.Location = New System.Drawing.Point(45, 42)
        Me.btnDispense.Name = "btnDispense"
        Me.btnDispense.Size = New System.Drawing.Size(229, 38)
        Me.btnDispense.TabIndex = 7
        Me.btnDispense.Text = "      Dispense Medication"
        Me.btnDispense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDispense.UseVisualStyleBackColor = False
        '
        'pnlAmountAdministered
        '
        Me.pnlAmountAdministered.Controls.Add(Me.Panel2)
        Me.pnlAmountAdministered.Controls.Add(Me.Panel4)
        Me.pnlAmountAdministered.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAmountAdministered.Location = New System.Drawing.Point(0, 166)
        Me.pnlAmountAdministered.Name = "pnlAmountAdministered"
        Me.pnlAmountAdministered.Size = New System.Drawing.Size(326, 57)
        Me.pnlAmountAdministered.TabIndex = 207
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.txtAmountDispensed)
        Me.Panel2.Location = New System.Drawing.Point(77, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(92, 28)
        Me.Panel2.TabIndex = 41
        '
        'txtAmountDispensed
        '
        Me.txtAmountDispensed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmountDispensed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAmountDispensed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountDispensed.Location = New System.Drawing.Point(1, 1)
        Me.txtAmountDispensed.Multiline = True
        Me.txtAmountDispensed.Name = "txtAmountDispensed"
        Me.txtAmountDispensed.ShortcutsEnabled = False
        Me.txtAmountDispensed.Size = New System.Drawing.Size(90, 26)
        Me.txtAmountDispensed.TabIndex = 38
        Me.txtAmountDispensed.Text = "1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.txtUnits)
        Me.Panel4.Location = New System.Drawing.Point(191, 13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel4.Size = New System.Drawing.Size(63, 28)
        Me.Panel4.TabIndex = 42
        '
        'txtUnits
        '
        Me.txtUnits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUnits.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnits.Location = New System.Drawing.Point(1, 1)
        Me.txtUnits.Multiline = True
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.ShortcutsEnabled = False
        Me.txtUnits.Size = New System.Drawing.Size(61, 26)
        Me.txtUnits.TabIndex = 38
        Me.txtUnits.Text = "1"
        '
        'pnlAmountInDrawer
        '
        Me.pnlAmountInDrawer.Controls.Add(Me.Panel9)
        Me.pnlAmountInDrawer.Controls.Add(Me.Button2)
        Me.pnlAmountInDrawer.Controls.Add(Me.Button3)
        Me.pnlAmountInDrawer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAmountInDrawer.Location = New System.Drawing.Point(0, 101)
        Me.pnlAmountInDrawer.Name = "pnlAmountInDrawer"
        Me.pnlAmountInDrawer.Size = New System.Drawing.Size(326, 65)
        Me.pnlAmountInDrawer.TabIndex = 206
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkGray
        Me.Panel9.Controls.Add(Me.txtCountInDrawer)
        Me.Panel9.Location = New System.Drawing.Point(81, 19)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel9.Size = New System.Drawing.Size(90, 28)
        Me.Panel9.TabIndex = 7
        '
        'txtCountInDrawer
        '
        Me.txtCountInDrawer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCountInDrawer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCountInDrawer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountInDrawer.Location = New System.Drawing.Point(1, 1)
        Me.txtCountInDrawer.Multiline = True
        Me.txtCountInDrawer.Name = "txtCountInDrawer"
        Me.txtCountInDrawer.ShortcutsEnabled = False
        Me.txtCountInDrawer.Size = New System.Drawing.Size(88, 26)
        Me.txtCountInDrawer.TabIndex = 38
        Me.txtCountInDrawer.Text = "1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(194, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 28)
        Me.Button2.TabIndex = 8
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
        Me.Button3.Location = New System.Drawing.Point(228, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 28)
        Me.Button3.TabIndex = 9
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'pnlAmountToRemove
        '
        Me.pnlAmountToRemove.Controls.Add(Me.Panel5)
        Me.pnlAmountToRemove.Controls.Add(Me.btnUp)
        Me.pnlAmountToRemove.Controls.Add(Me.btnDown)
        Me.pnlAmountToRemove.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAmountToRemove.Location = New System.Drawing.Point(0, 45)
        Me.pnlAmountToRemove.Name = "pnlAmountToRemove"
        Me.pnlAmountToRemove.Size = New System.Drawing.Size(326, 56)
        Me.pnlAmountToRemove.TabIndex = 205
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lblDirections)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(326, 45)
        Me.Panel7.TabIndex = 205
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirections.Location = New System.Drawing.Point(38, 10)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(257, 25)
        Me.lblDirections.TabIndex = 204
        Me.lblDirections.Text = "Select Amount To Dispense:"
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
        Me.pnlDispenseHistoryHeader.Location = New System.Drawing.Point(18, 417)
        Me.pnlDispenseHistoryHeader.Name = "pnlDispenseHistoryHeader"
        Me.pnlDispenseHistoryHeader.Size = New System.Drawing.Size(1067, 47)
        Me.pnlDispenseHistoryHeader.TabIndex = 204
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
        'txtMedication
        '
        Me.txtMedication.BackColor = System.Drawing.Color.White
        Me.txtMedication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMedication.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedication.Location = New System.Drawing.Point(17, 76)
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.ReadOnly = True
        Me.txtMedication.ShortcutsEnabled = False
        Me.txtMedication.Size = New System.Drawing.Size(431, 25)
        Me.txtMedication.TabIndex = 205
        '
        'txtType
        '
        Me.txtType.BackColor = System.Drawing.Color.White
        Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(454, 76)
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.ShortcutsEnabled = False
        Me.txtType.Size = New System.Drawing.Size(151, 25)
        Me.txtType.TabIndex = 206
        '
        'txtContainer
        '
        Me.txtContainer.BackColor = System.Drawing.Color.White
        Me.txtContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContainer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContainer.Location = New System.Drawing.Point(935, 76)
        Me.txtContainer.Name = "txtContainer"
        Me.txtContainer.ReadOnly = True
        Me.txtContainer.ShortcutsEnabled = False
        Me.txtContainer.Size = New System.Drawing.Size(169, 25)
        Me.txtContainer.TabIndex = 208
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(935, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 21)
        Me.Label1.TabIndex = 209
        Me.Label1.Text = "Amount per container: "
        '
        'txtPrescribedAmount
        '
        Me.txtPrescribedAmount.BackColor = System.Drawing.Color.White
        Me.txtPrescribedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrescribedAmount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrescribedAmount.Location = New System.Drawing.Point(611, 76)
        Me.txtPrescribedAmount.Name = "txtPrescribedAmount"
        Me.txtPrescribedAmount.ReadOnly = True
        Me.txtPrescribedAmount.ShortcutsEnabled = False
        Me.txtPrescribedAmount.Size = New System.Drawing.Size(163, 25)
        Me.txtPrescribedAmount.TabIndex = 207
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(607, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 21)
        Me.Label14.TabIndex = 177
        Me.Label14.Text = "Prescribed Amount: "
        '
        'txtFrequency
        '
        Me.txtFrequency.BackColor = System.Drawing.Color.White
        Me.txtFrequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrequency.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrequency.Location = New System.Drawing.Point(780, 76)
        Me.txtFrequency.Name = "txtFrequency"
        Me.txtFrequency.ReadOnly = True
        Me.txtFrequency.ShortcutsEnabled = False
        Me.txtFrequency.Size = New System.Drawing.Size(144, 25)
        Me.txtFrequency.TabIndex = 211
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(776, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 210
        Me.Label2.Text = "Frequency:"
        '
        'frmDispense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1116, 650)
        Me.Controls.Add(Me.txtFrequency)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContainer)
        Me.Controls.Add(Me.txtPrescribedAmount)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtMedication)
        Me.Controls.Add(Me.pnlDispenseHistoryHeader)
        Me.Controls.Add(Me.pnlSelector)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.flpMedications)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lstboxAllergies)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDispense"
        Me.Text = "    Dispense"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSelector.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.pnlAmountAdministered.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.pnlAmountInDrawer.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnlAmountToRemove.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.pnlDispenseHistoryHeader.ResumeLayout(False)
        Me.pnlDispenseHistoryHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstboxAllergies As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents flpMedications As FlowLayoutPanel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtQuantityToDispense As TextBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents tpToolTip As ToolTip
    Friend WithEvents pnlSelector As Panel
    Friend WithEvents btnDrawer13 As Button
    Friend WithEvents btnDrawer12 As Button
    Friend WithEvents btnDrawer23 As Button
    Friend WithEvents btnDrawer22 As Button
    Friend WithEvents btnDrawer9 As Button
    Friend WithEvents btnDrawer24 As Button
    Friend WithEvents btnDrawer8 As Button
    Friend WithEvents btnDrawer7 As Button
    Friend WithEvents btnDrawer19 As Button
    Friend WithEvents btnDrawer18 As Button
    Friend WithEvents btnDrawer17 As Button
    Friend WithEvents btnDrawer14 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDirections As Label
    Friend WithEvents pnlAmountAdministered As Panel
    Friend WithEvents pnlAmountInDrawer As Panel
    Friend WithEvents pnlAmountToRemove As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnDispense As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtAmountDispensed As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtCountInDrawer As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents pnlDispenseHistoryHeader As Panel
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblDispensedBy As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblStrength As Label
    Friend WithEvents txtMedication As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents lblPatientInfo As Label
    Friend WithEvents txtContainer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrescribedAmount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFrequency As TextBox
    Friend WithEvents Label2 As Label
End Class
