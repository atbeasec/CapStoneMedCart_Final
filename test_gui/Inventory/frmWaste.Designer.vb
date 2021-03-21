<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWaste))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMedication = New System.Windows.Forms.ComboBox()
        Me.pnlRadioButtons = New System.Windows.Forms.Panel()
        Me.pnlSignOff = New System.Windows.Forms.Panel()
        Me.cboWitness = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnWaste = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rbtnOther = New System.Windows.Forms.RadioButton()
        Me.rbtnPatientUnavilable = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cboDrawers = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDecrementQuantity = New System.Windows.Forms.Button()
        Me.btnIncrementQuantity = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlQuantity = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.radWasteSpecific = New System.Windows.Forms.RadioButton()
        Me.radAllMed = New System.Windows.Forms.RadioButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlRadioButtons.SuspendLayout()
        Me.pnlSignOff.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlQuantity.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Reason For Waste"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Select Wasted Medication"
        '
        'cboMedication
        '
        Me.cboMedication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedication.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedication.FormattingEnabled = True
        Me.cboMedication.Location = New System.Drawing.Point(17, 88)
        Me.cboMedication.Name = "cboMedication"
        Me.cboMedication.Size = New System.Drawing.Size(447, 29)
        Me.cboMedication.TabIndex = 24
        '
        'pnlRadioButtons
        '
        Me.pnlRadioButtons.Controls.Add(Me.pnlSignOff)
        Me.pnlRadioButtons.Controls.Add(Me.TextBox1)
        Me.pnlRadioButtons.Controls.Add(Me.rbtnOther)
        Me.pnlRadioButtons.Controls.Add(Me.rbtnPatientUnavilable)
        Me.pnlRadioButtons.Controls.Add(Me.RadioButton4)
        Me.pnlRadioButtons.Controls.Add(Me.RadioButton3)
        Me.pnlRadioButtons.Controls.Add(Me.RadioButton2)
        Me.pnlRadioButtons.Location = New System.Drawing.Point(17, 252)
        Me.pnlRadioButtons.Name = "pnlRadioButtons"
        Me.pnlRadioButtons.Size = New System.Drawing.Size(488, 441)
        Me.pnlRadioButtons.TabIndex = 23
        '
        'pnlSignOff
        '
        Me.pnlSignOff.Controls.Add(Me.cboWitness)
        Me.pnlSignOff.Controls.Add(Me.Label3)
        Me.pnlSignOff.Controls.Add(Me.btnWaste)
        Me.pnlSignOff.Location = New System.Drawing.Point(4, 158)
        Me.pnlSignOff.Name = "pnlSignOff"
        Me.pnlSignOff.Size = New System.Drawing.Size(458, 135)
        Me.pnlSignOff.TabIndex = 24
        '
        'cboWitness
        '
        Me.cboWitness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWitness.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboWitness.FormattingEnabled = True
        Me.cboWitness.Location = New System.Drawing.Point(3, 38)
        Me.cboWitness.Name = "cboWitness"
        Me.cboWitness.Size = New System.Drawing.Size(441, 29)
        Me.cboWitness.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Witness Sign-off Required"
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
        Me.btnWaste.Location = New System.Drawing.Point(122, 82)
        Me.btnWaste.Name = "btnWaste"
        Me.btnWaste.Size = New System.Drawing.Size(150, 37)
        Me.btnWaste.TabIndex = 31
        Me.btnWaste.Text = "   SUBMIT"
        Me.btnWaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWaste.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 158)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(329, 124)
        Me.TextBox1.TabIndex = 6
        '
        'rbtnOther
        '
        Me.rbtnOther.AutoSize = True
        Me.rbtnOther.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnOther.Location = New System.Drawing.Point(1, 127)
        Me.rbtnOther.Name = "rbtnOther"
        Me.rbtnOther.Size = New System.Drawing.Size(219, 25)
        Me.rbtnOther.TabIndex = 5
        Me.rbtnOther.Text = "Other (Provide Explanation)"
        Me.rbtnOther.UseVisualStyleBackColor = True
        '
        'rbtnPatientUnavilable
        '
        Me.rbtnPatientUnavilable.AutoSize = True
        Me.rbtnPatientUnavilable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnPatientUnavilable.Location = New System.Drawing.Point(1, 96)
        Me.rbtnPatientUnavilable.Name = "rbtnPatientUnavilable"
        Me.rbtnPatientUnavilable.Size = New System.Drawing.Size(160, 25)
        Me.rbtnPatientUnavilable.TabIndex = 4
        Me.rbtnPatientUnavilable.Text = "Patient Unavailable"
        Me.rbtnPatientUnavilable.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(3, 65)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(135, 25)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Patient Refused"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(3, 34)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(208, 25)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Order Canceled / On Hold"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(170, 25)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Incorrect Medication"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(771, 46)
        Me.pnlHeader.TabIndex = 202
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
        '
        'cboDrawers
        '
        Me.cboDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDrawers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDrawers.FormattingEnabled = True
        Me.cboDrawers.Location = New System.Drawing.Point(18, 168)
        Me.cboDrawers.Name = "cboDrawers"
        Me.cboDrawers.Size = New System.Drawing.Size(447, 29)
        Me.cboDrawers.TabIndex = 203
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "Drawers:"
        '
        'btnDecrementQuantity
        '
        Me.btnDecrementQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDecrementQuantity.FlatAppearance.BorderSize = 0
        Me.btnDecrementQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecrementQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrementQuantity.ForeColor = System.Drawing.Color.White
        Me.btnDecrementQuantity.Image = CType(resources.GetObject("btnDecrementQuantity.Image"), System.Drawing.Image)
        Me.btnDecrementQuantity.Location = New System.Drawing.Point(115, 54)
        Me.btnDecrementQuantity.Name = "btnDecrementQuantity"
        Me.btnDecrementQuantity.Size = New System.Drawing.Size(28, 28)
        Me.btnDecrementQuantity.TabIndex = 212
        Me.btnDecrementQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDecrementQuantity.UseVisualStyleBackColor = False
        '
        'btnIncrementQuantity
        '
        Me.btnIncrementQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnIncrementQuantity.FlatAppearance.BorderSize = 0
        Me.btnIncrementQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncrementQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncrementQuantity.ForeColor = System.Drawing.Color.White
        Me.btnIncrementQuantity.Image = CType(resources.GetObject("btnIncrementQuantity.Image"), System.Drawing.Image)
        Me.btnIncrementQuantity.Location = New System.Drawing.Point(81, 54)
        Me.btnIncrementQuantity.Name = "btnIncrementQuantity"
        Me.btnIncrementQuantity.Size = New System.Drawing.Size(28, 28)
        Me.btnIncrementQuantity.TabIndex = 211
        Me.btnIncrementQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIncrementQuantity.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.txtQuantity)
        Me.Panel5.Location = New System.Drawing.Point(8, 54)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(67, 28)
        Me.Panel5.TabIndex = 210
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(1, 1)
        Me.txtQuantity.MaxLength = 4
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ShortcutsEnabled = False
        Me.txtQuantity.Size = New System.Drawing.Size(65, 26)
        Me.txtQuantity.TabIndex = 38
        Me.txtQuantity.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 213
        Me.Label5.Text = "Quantity:"
        '
        'pnlQuantity
        '
        Me.pnlQuantity.Controls.Add(Me.Label5)
        Me.pnlQuantity.Controls.Add(Me.Panel5)
        Me.pnlQuantity.Controls.Add(Me.btnDecrementQuantity)
        Me.pnlQuantity.Controls.Add(Me.btnIncrementQuantity)
        Me.pnlQuantity.Location = New System.Drawing.Point(470, 138)
        Me.pnlQuantity.Name = "pnlQuantity"
        Me.pnlQuantity.Size = New System.Drawing.Size(149, 94)
        Me.pnlQuantity.TabIndex = 214
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.radWasteSpecific)
        Me.Panel2.Controls.Add(Me.radAllMed)
        Me.Panel2.Location = New System.Drawing.Point(470, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 71)
        Me.Panel2.TabIndex = 215
        '
        'radWasteSpecific
        '
        Me.radWasteSpecific.AutoSize = True
        Me.radWasteSpecific.Checked = True
        Me.radWasteSpecific.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.radWasteSpecific.Location = New System.Drawing.Point(3, 3)
        Me.radWasteSpecific.Name = "radWasteSpecific"
        Me.radWasteSpecific.Size = New System.Drawing.Size(185, 25)
        Me.radWasteSpecific.TabIndex = 1
        Me.radWasteSpecific.TabStop = True
        Me.radWasteSpecific.Text = "Waste Specific amount"
        Me.radWasteSpecific.UseVisualStyleBackColor = True
        '
        'radAllMed
        '
        Me.radAllMed.AutoSize = True
        Me.radAllMed.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.radAllMed.Location = New System.Drawing.Point(3, 29)
        Me.radAllMed.Name = "radAllMed"
        Me.radAllMed.Size = New System.Drawing.Size(241, 25)
        Me.radAllMed.TabIndex = 0
        Me.radAllMed.Text = "Waste all medication in drawer"
        Me.radAllMed.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmWaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(771, 733)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlQuantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboDrawers)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMedication)
        Me.Controls.Add(Me.pnlRadioButtons)
        Me.Name = "frmWaste"
        Me.Text = "Waste"
        Me.pnlRadioButtons.ResumeLayout(False)
        Me.pnlRadioButtons.PerformLayout()
        Me.pnlSignOff.ResumeLayout(False)
        Me.pnlSignOff.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlQuantity.ResumeLayout(False)
        Me.pnlQuantity.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMedication As ComboBox
    Friend WithEvents pnlRadioButtons As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents rbtnOther As RadioButton
    Friend WithEvents rbtnPatientUnavilable As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents pnlSignOff As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnWaste As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents cboWitness As ComboBox
    Friend WithEvents cboDrawers As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDecrementQuantity As Button
    Friend WithEvents btnIncrementQuantity As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlQuantity As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents radWasteSpecific As RadioButton
    Friend WithEvents radAllMed As RadioButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
