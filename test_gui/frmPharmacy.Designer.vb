<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPharmacy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPharmacy))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbMethod = New System.Windows.Forms.ComboBox()
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
        Me.cmbDosage = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtPatientDOB = New System.Windows.Forms.TextBox()
        Me.btnORder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSchedule = New System.Windows.Forms.TextBox()
        Me.Panel4.SuspendLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(339, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 21)
        Me.Label10.TabIndex = 175
        Me.Label10.Text = "Schedule:"
        '
        'cmbMethod
        '
        Me.cmbMethod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMethod.FormattingEnabled = True
        Me.cmbMethod.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbMethod.Location = New System.Drawing.Point(342, 154)
        Me.cmbMethod.Name = "cmbMethod"
        Me.cmbMethod.Size = New System.Drawing.Size(243, 29)
        Me.cmbMethod.TabIndex = 3
        '
        'cmbOrderedBy
        '
        Me.cmbOrderedBy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrderedBy.FormattingEnabled = True
        Me.cmbOrderedBy.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbOrderedBy.Location = New System.Drawing.Point(40, 305)
        Me.cmbOrderedBy.Name = "cmbOrderedBy"
        Me.cmbOrderedBy.Size = New System.Drawing.Size(240, 29)
        Me.cmbOrderedBy.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 21)
        Me.Label11.TabIndex = 172
        Me.Label11.Text = "Orderd By:"
        '
        'cmbPatientName
        '
        Me.cmbPatientName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPatientName.FormattingEnabled = True
        Me.cmbPatientName.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbPatientName.Location = New System.Drawing.Point(38, 79)
        Me.cmbPatientName.Name = "cmbPatientName"
        Me.cmbPatientName.Size = New System.Drawing.Size(242, 29)
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
        Me.cmbMedication.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedication.FormattingEnabled = True
        Me.cmbMedication.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbMedication.Location = New System.Drawing.Point(37, 155)
        Me.cmbMedication.Name = "cmbMedication"
        Me.cmbMedication.Size = New System.Drawing.Size(243, 29)
        Me.cmbMedication.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(335, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 21)
        Me.Label13.TabIndex = 167
        Me.Label13.Text = "Patient DOB:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(35, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 21)
        Me.Label14.TabIndex = 166
        Me.Label14.Text = "Dosage:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(338, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 21)
        Me.Label15.TabIndex = 165
        Me.Label15.Text = "Method:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(339, 205)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 21)
        Me.Label16.TabIndex = 164
        Me.Label16.Text = "Quantity:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 131)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 21)
        Me.Label17.TabIndex = 163
        Me.Label17.Text = "Medication:"
        '
        'cmbDosage
        '
        Me.cmbDosage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDosage.FormattingEnabled = True
        Me.cmbDosage.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbDosage.Location = New System.Drawing.Point(40, 234)
        Me.cmbDosage.Name = "cmbDosage"
        Me.cmbDosage.Size = New System.Drawing.Size(240, 29)
        Me.cmbDosage.TabIndex = 4
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.numQuantity)
        Me.Panel4.Location = New System.Drawing.Point(342, 234)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel4.Size = New System.Drawing.Size(58, 29)
        Me.Panel4.TabIndex = 5
        '
        'numQuantity
        '
        Me.numQuantity.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numQuantity.Location = New System.Drawing.Point(1, 1)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(56, 27)
        Me.numQuantity.TabIndex = 176
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.txtPatientDOB)
        Me.Panel5.Location = New System.Drawing.Point(342, 79)
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
        Me.btnORder.Location = New System.Drawing.Point(210, 416)
        Me.btnORder.Name = "btnORder"
        Me.btnORder.Size = New System.Drawing.Size(201, 38)
        Me.btnORder.TabIndex = 9
        Me.btnORder.Text = "   Order Prescription"
        Me.btnORder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnORder.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.txtSchedule)
        Me.Panel1.Location = New System.Drawing.Point(343, 305)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(242, 91)
        Me.Panel1.TabIndex = 7
        '
        'txtSchedule
        '
        Me.txtSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSchedule.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchedule.Location = New System.Drawing.Point(1, 1)
        Me.txtSchedule.Multiline = True
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.Size = New System.Drawing.Size(240, 89)
        Me.txtSchedule.TabIndex = 7
        '
        'frmPharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(621, 470)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbMethod)
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
        Me.Controls.Add(Me.cmbDosage)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnORder)
        Me.Name = "frmPharmacy"
        Me.Tag = "6"
        Me.Text = "frmPharmacy"
        Me.Panel4.ResumeLayout(False)
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDispense As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbMethod As ComboBox
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
    Friend WithEvents cmbDosage As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtPatientDOB As TextBox
    Friend WithEvents btnORder As Button
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSchedule As TextBox
End Class
