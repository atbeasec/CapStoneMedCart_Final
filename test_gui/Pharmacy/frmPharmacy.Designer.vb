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
        Me.cmbOrderedBy = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbPatientName = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbMedication = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbStrength = New System.Windows.Forms.ComboBox()
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
        Me.cmbFrequencyNumber = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(393, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 21)
        Me.Label10.TabIndex = 175
        Me.Label10.Text = "Frequency:"
        '
        'cmbOrderedBy
        '
        Me.cmbOrderedBy.DropDownHeight = 250
        Me.cmbOrderedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrderedBy.DropDownWidth = 100
        Me.cmbOrderedBy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderedBy.FormattingEnabled = True
        Me.cmbOrderedBy.IntegralHeight = False
        Me.cmbOrderedBy.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbOrderedBy.Location = New System.Drawing.Point(38, 311)
        Me.cmbOrderedBy.MaxDropDownItems = 25
        Me.cmbOrderedBy.Name = "cmbOrderedBy"
        Me.cmbOrderedBy.Size = New System.Drawing.Size(330, 29)
        Me.cmbOrderedBy.TabIndex = 7
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
        'cmbPatientName
        '
        Me.cmbPatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPatientName.DropDownHeight = 250
        Me.cmbPatientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPatientName.DropDownWidth = 100
        Me.cmbPatientName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientName.FormattingEnabled = True
        Me.cmbPatientName.IntegralHeight = False
        Me.cmbPatientName.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbPatientName.Location = New System.Drawing.Point(38, 79)
        Me.cmbPatientName.MaxDropDownItems = 25
        Me.cmbPatientName.Name = "cmbPatientName"
        Me.cmbPatientName.Size = New System.Drawing.Size(330, 29)
        Me.cmbPatientName.TabIndex = 1
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
        'cmbMedication
        '
        Me.cmbMedication.DropDownHeight = 250
        Me.cmbMedication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMedication.DropDownWidth = 100
        Me.cmbMedication.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedication.FormattingEnabled = True
        Me.cmbMedication.IntegralHeight = False
        Me.cmbMedication.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbMedication.Location = New System.Drawing.Point(38, 156)
        Me.cmbMedication.MaxDropDownItems = 25
        Me.cmbMedication.Name = "cmbMedication"
        Me.cmbMedication.Size = New System.Drawing.Size(330, 29)
        Me.cmbMedication.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(393, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 21)
        Me.Label13.TabIndex = 167
        Me.Label13.Text = "Patient DOB:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(392, 204)
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
        Me.Label16.Location = New System.Drawing.Point(392, 132)
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
        'cmbStrength
        '
        Me.cmbStrength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStrength.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStrength.FormattingEnabled = True
        Me.cmbStrength.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbStrength.Location = New System.Drawing.Point(397, 230)
        Me.cmbStrength.Name = "cmbStrength"
        Me.cmbStrength.Size = New System.Drawing.Size(241, 29)
        Me.cmbStrength.TabIndex = 6
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
        Me.Panel5.Location = New System.Drawing.Point(396, 80)
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
        Me.btnORder.Location = New System.Drawing.Point(214, 395)
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
        Me.btnDecrement.Location = New System.Drawing.Point(489, 158)
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
        Me.btnIncrement.Location = New System.Drawing.Point(455, 158)
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
        Me.Panel2.Location = New System.Drawing.Point(396, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel2.Size = New System.Drawing.Size(53, 28)
        Me.Panel2.TabIndex = 3
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(1, 1)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
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
        Me.Panel3.Size = New System.Drawing.Size(242, 28)
        Me.Panel3.TabIndex = 39
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
        Me.txtType.Size = New System.Drawing.Size(240, 26)
        Me.txtType.TabIndex = 38
        Me.txtType.TabStop = False
        '
        'cmbFrequencyNumber
        '
        Me.cmbFrequencyNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFrequencyNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFrequencyNumber.DropDownHeight = 250
        Me.cmbFrequencyNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrequencyNumber.DropDownWidth = 100
        Me.cmbFrequencyNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrequencyNumber.FormattingEnabled = True
        Me.cmbFrequencyNumber.IntegralHeight = False
        Me.cmbFrequencyNumber.Items.AddRange(New Object() {"", "hs", "noct", "prn", "q 10am", "q 10pm", "q 11am", "q 11pm", "q 12pm", "q 1am", "q 1pm", "q 2am", "q 2pm", "q 3am", "q 3pm", "q 4am", "q 4pm", "q 5am", "q 5pm", "q 6am", "q 6pm", "q 7am", "q 7pm", "q 8am", "q 8pm", "q 9am", "q 9pm", "q am", "q12h", "q2-3h", "q2-4h", "q24h", "q4-6h", "q4h", "q6h", "qd", "qd pm", "qh", "qhs", "qid", "qod", "qpm", "qw", "tat", "tiw", "tud", "uat", "ud"})
        Me.cmbFrequencyNumber.Location = New System.Drawing.Point(397, 311)
        Me.cmbFrequencyNumber.MaxDropDownItems = 25
        Me.cmbFrequencyNumber.Name = "cmbFrequencyNumber"
        Me.cmbFrequencyNumber.Size = New System.Drawing.Size(121, 29)
        Me.cmbFrequencyNumber.Sorted = True
        Me.cmbFrequencyNumber.TabIndex = 8
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmPharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(717, 494)
        Me.Controls.Add(Me.cmbFrequencyNumber)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnDecrement)
        Me.Controls.Add(Me.btnIncrement)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbOrderedBy)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbPatientName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbMedication)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbStrength)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDispense As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbOrderedBy As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbPatientName As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbMedication As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbStrength As ComboBox
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
    Friend WithEvents cmbFrequencyNumber As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
