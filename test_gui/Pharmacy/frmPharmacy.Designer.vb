<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPharmacy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPharmacy))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtPatientDOB = New System.Windows.Forms.TextBox()
        Me.btnORder = New System.Windows.Forms.Button()
        Me.btnDecrement = New System.Windows.Forms.Button()
        Me.btnIncrement = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbStrength = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbFrequencyNumber = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmbMedication = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmbOrderedBy = New System.Windows.Forms.ComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmbPatientName = New System.Windows.Forms.ComboBox()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(483, 288)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 21)
        Me.Label10.TabIndex = 175
        Me.Label10.Text = "Frequency:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 283)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 21)
        Me.Label11.TabIndex = 172
        Me.Label11.Text = "Ordered By:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 21)
        Me.Label12.TabIndex = 169
        Me.Label12.Text = "Patient Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(483, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 21)
        Me.Label13.TabIndex = 167
        Me.Label13.Text = "Patient DOB:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(374, 204)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 21)
        Me.Label14.TabIndex = 166
        Me.Label14.Text = "Strength:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(34, 204)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 21)
        Me.Label15.TabIndex = 165
        Me.Label15.Text = "Type:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(482, 132)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 21)
        Me.Label16.TabIndex = 164
        Me.Label16.Text = "Quantity:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(34, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 21)
        Me.Label17.TabIndex = 163
        Me.Label17.Text = "Medication:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(23, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(165, 25)
        Me.Label18.TabIndex = 158
        Me.Label18.Text = "New Prescription"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.txtPatientDOB)
        Me.Panel5.Location = New System.Drawing.Point(486, 80)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(119, 28)
        Me.Panel5.TabIndex = 2
        '
        'txtPatientDOB
        '
        Me.txtPatientDOB.BackColor = System.Drawing.Color.White
        Me.txtPatientDOB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientDOB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPatientDOB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientDOB.Location = New System.Drawing.Point(1, 1)
        Me.txtPatientDOB.Multiline = True
        Me.txtPatientDOB.Name = "txtPatientDOB"
        Me.txtPatientDOB.ReadOnly = True
        Me.txtPatientDOB.ShortcutsEnabled = False
        Me.txtPatientDOB.Size = New System.Drawing.Size(117, 26)
        Me.txtPatientDOB.TabIndex = 38
        Me.txtPatientDOB.TabStop = False
        '
        'btnORder
        '
        Me.btnORder.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnORder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnORder.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnORder.ForeColor = System.Drawing.Color.White
        Me.btnORder.Image = CType(resources.GetObject("btnORder.Image"), System.Drawing.Image)
        Me.btnORder.Location = New System.Drawing.Point(249, 390)
        Me.btnORder.Name = "btnORder"
        Me.btnORder.Size = New System.Drawing.Size(201, 38)
        Me.btnORder.TabIndex = 9
        Me.btnORder.Text = "   Order Prescription"
        Me.btnORder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnORder.UseVisualStyleBackColor = False
        '
        'btnDecrement
        '
        Me.btnDecrement.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDecrement.FlatAppearance.BorderSize = 0
        Me.btnDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecrement.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrement.ForeColor = System.Drawing.Color.White
        Me.btnDecrement.Image = CType(resources.GetObject("btnDecrement.Image"), System.Drawing.Image)
        Me.btnDecrement.Location = New System.Drawing.Point(579, 159)
        Me.btnDecrement.Name = "btnDecrement"
        Me.btnDecrement.Size = New System.Drawing.Size(28, 28)
        Me.btnDecrement.TabIndex = 5
        Me.btnDecrement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDecrement.UseVisualStyleBackColor = False
        '
        'btnIncrement
        '
        Me.btnIncrement.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnIncrement.FlatAppearance.BorderSize = 0
        Me.btnIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncrement.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncrement.ForeColor = System.Drawing.Color.White
        Me.btnIncrement.Image = CType(resources.GetObject("btnIncrement.Image"), System.Drawing.Image)
        Me.btnIncrement.Location = New System.Drawing.Point(545, 158)
        Me.btnIncrement.Name = "btnIncrement"
        Me.btnIncrement.Size = New System.Drawing.Size(28, 28)
        Me.btnIncrement.TabIndex = 4
        Me.btnIncrement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIncrement.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Location = New System.Drawing.Point(486, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(53, 28)
        Me.Panel2.TabIndex = 4
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(1, 1)
        Me.txtQuantity.MaxLength = 4
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ShortcutsEnabled = False
        Me.txtQuantity.Size = New System.Drawing.Size(51, 26)
        Me.txtQuantity.TabIndex = 38
        Me.txtQuantity.Text = "1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.txtType)
        Me.Panel3.Location = New System.Drawing.Point(38, 232)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(299, 28)
        Me.Panel3.TabIndex = 5
        '
        'txtType
        '
        Me.txtType.BackColor = System.Drawing.Color.White
        Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(1, 1)
        Me.txtType.Multiline = True
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.ShortcutsEnabled = False
        Me.txtType.Size = New System.Drawing.Size(297, 26)
        Me.txtType.TabIndex = 38
        Me.txtType.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.cmbStrength)
        Me.Panel1.Location = New System.Drawing.Point(377, 229)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(228, 31)
        Me.Panel1.TabIndex = 6
        '
        'cmbStrength
        '
        Me.cmbStrength.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbStrength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStrength.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStrength.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStrength.FormattingEnabled = True
        Me.cmbStrength.Location = New System.Drawing.Point(1, 1)
        Me.cmbStrength.Name = "cmbStrength"
        Me.cmbStrength.Size = New System.Drawing.Size(226, 29)
        Me.cmbStrength.TabIndex = 0
        Me.cmbStrength.Tag = "cmbFrequencyNumber"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.cmbFrequencyNumber)
        Me.Panel4.Location = New System.Drawing.Point(486, 312)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel4.Size = New System.Drawing.Size(119, 31)
        Me.Panel4.TabIndex = 8
        '
        'cmbFrequencyNumber
        '
        Me.cmbFrequencyNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbFrequencyNumber.DropDownHeight = 25
        Me.cmbFrequencyNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrequencyNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFrequencyNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrequencyNumber.FormattingEnabled = True
        Me.cmbFrequencyNumber.IntegralHeight = False
        Me.cmbFrequencyNumber.Location = New System.Drawing.Point(1, 1)
        Me.cmbFrequencyNumber.Name = "cmbFrequencyNumber"
        Me.cmbFrequencyNumber.Size = New System.Drawing.Size(117, 29)
        Me.cmbFrequencyNumber.TabIndex = 0
        Me.cmbFrequencyNumber.Tag = "cmbFrequencyNumber"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGray
        Me.Panel6.Controls.Add(Me.cmbMedication)
        Me.Panel6.Location = New System.Drawing.Point(38, 154)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel6.Size = New System.Drawing.Size(412, 31)
        Me.Panel6.TabIndex = 3
        '
        'cmbMedication
        '
        Me.cmbMedication.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbMedication.DropDownHeight = 250
        Me.cmbMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMedication.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedication.FormattingEnabled = True
        Me.cmbMedication.IntegralHeight = False
        Me.cmbMedication.ItemHeight = 21
        Me.cmbMedication.Location = New System.Drawing.Point(1, 1)
        Me.cmbMedication.Name = "cmbMedication"
        Me.cmbMedication.Size = New System.Drawing.Size(410, 29)
        Me.cmbMedication.TabIndex = 0
        Me.cmbMedication.Tag = ""
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkGray
        Me.Panel7.Controls.Add(Me.cmbOrderedBy)
        Me.Panel7.Location = New System.Drawing.Point(39, 312)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel7.Size = New System.Drawing.Size(410, 31)
        Me.Panel7.TabIndex = 7
        '
        'cmbOrderedBy
        '
        Me.cmbOrderedBy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbOrderedBy.DropDownHeight = 200
        Me.cmbOrderedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOrderedBy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderedBy.FormattingEnabled = True
        Me.cmbOrderedBy.IntegralHeight = False
        Me.cmbOrderedBy.Location = New System.Drawing.Point(1, 1)
        Me.cmbOrderedBy.Name = "cmbOrderedBy"
        Me.cmbOrderedBy.Size = New System.Drawing.Size(408, 29)
        Me.cmbOrderedBy.TabIndex = 0
        Me.cmbOrderedBy.Tag = ""
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkGray
        Me.Panel8.Controls.Add(Me.cmbPatientName)
        Me.Panel8.Location = New System.Drawing.Point(38, 76)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel8.Size = New System.Drawing.Size(412, 31)
        Me.Panel8.TabIndex = 1
        '
        'cmbPatientName
        '
        Me.cmbPatientName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPatientName.DropDownHeight = 250
        Me.cmbPatientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPatientName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientName.FormattingEnabled = True
        Me.cmbPatientName.IntegralHeight = False
        Me.cmbPatientName.ItemHeight = 21
        Me.cmbPatientName.Location = New System.Drawing.Point(1, 1)
        Me.cmbPatientName.Name = "cmbPatientName"
        Me.cmbPatientName.Size = New System.Drawing.Size(410, 29)
        Me.cmbPatientName.TabIndex = 0
        Me.cmbPatientName.Tag = ""
        '
        'frmPharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(902, 494)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnDecrement)
        Me.Controls.Add(Me.btnIncrement)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnORder)
        Me.Name = "frmPharmacy"
        Me.Tag = "6"
        Me.Text = "frmPharmacy"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDispense As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtPatientDOB As TextBox
    Friend WithEvents btnORder As Button
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents btnDecrement As Button
    Friend WithEvents btnIncrement As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtType As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbStrength As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cmbMedication As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cmbFrequencyNumber As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cmbOrderedBy As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cmbPatientName As ComboBox
End Class
