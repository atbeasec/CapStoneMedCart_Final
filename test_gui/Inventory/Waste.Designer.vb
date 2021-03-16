<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Waste
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Waste))
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
        Me.pnlRadioButtons.SuspendLayout()
        Me.pnlSignOff.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Reason For Waste"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Select Wasted Medication"
        '
        'cboMedication
        '
        Me.cboMedication.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedication.FormattingEnabled = True
        Me.cboMedication.Location = New System.Drawing.Point(29, 102)
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
        Me.pnlRadioButtons.Location = New System.Drawing.Point(29, 183)
        Me.pnlRadioButtons.Name = "pnlRadioButtons"
        Me.pnlRadioButtons.Size = New System.Drawing.Size(464, 477)
        Me.pnlRadioButtons.TabIndex = 23
        '
        'pnlSignOff
        '
        Me.pnlSignOff.Controls.Add(Me.cboWitness)
        Me.pnlSignOff.Controls.Add(Me.Label3)
        Me.pnlSignOff.Controls.Add(Me.btnWaste)
        Me.pnlSignOff.Location = New System.Drawing.Point(6, 198)
        Me.pnlSignOff.Name = "pnlSignOff"
        Me.pnlSignOff.Size = New System.Drawing.Size(458, 135)
        Me.pnlSignOff.TabIndex = 24
        '
        'cboWitness
        '
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
        Me.TextBox1.Location = New System.Drawing.Point(21, 198)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(329, 124)
        Me.TextBox1.TabIndex = 6
        '
        'rbtnOther
        '
        Me.rbtnOther.AutoSize = True
        Me.rbtnOther.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnOther.Location = New System.Drawing.Point(3, 167)
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
        Me.rbtnPatientUnavilable.Location = New System.Drawing.Point(3, 126)
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
        Me.RadioButton4.Location = New System.Drawing.Point(3, 85)
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
        Me.RadioButton3.Location = New System.Drawing.Point(3, 44)
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
        Me.btnBack.Location = New System.Drawing.Point(17, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 37)
        Me.btnBack.TabIndex = 61
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Waste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(771, 698)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMedication)
        Me.Controls.Add(Me.pnlRadioButtons)
        Me.Name = "Waste"
        Me.Text = "Waste"
        Me.pnlRadioButtons.ResumeLayout(False)
        Me.pnlRadioButtons.PerformLayout()
        Me.pnlSignOff.ResumeLayout(False)
        Me.pnlSignOff.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
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
End Class
