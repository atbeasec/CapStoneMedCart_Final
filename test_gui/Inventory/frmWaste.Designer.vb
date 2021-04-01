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
        Me.pnlRadioButtons = New System.Windows.Forms.Panel()
        Me.pnlSignOff = New System.Windows.Forms.Panel()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnWaste = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rbtnOther = New System.Windows.Forms.RadioButton()
        Me.rbtnPatientUnavilable = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblPatientInfo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.pnlRadioButtons.SuspendLayout()
        Me.pnlSignOff.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Medication:"
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
        Me.pnlSignOff.Controls.Add(Me.txtBarcode)
        Me.pnlSignOff.Controls.Add(Me.Label3)
        Me.pnlSignOff.Controls.Add(Me.btnWaste)
        Me.pnlSignOff.Location = New System.Drawing.Point(4, 158)
        Me.pnlSignOff.Name = "pnlSignOff"
        Me.pnlSignOff.Size = New System.Drawing.Size(458, 135)
        Me.pnlSignOff.TabIndex = 24
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.White
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(42, 38)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ShortcutsEnabled = False
        Me.txtBarcode.Size = New System.Drawing.Size(220, 25)
        Me.txtBarcode.TabIndex = 217
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
        Me.btnWaste.Location = New System.Drawing.Point(80, 69)
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
        Me.pnlHeader.Controls.Add(Me.lblPatientInfo)
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(771, 46)
        Me.pnlHeader.TabIndex = 202
        '
        'lblPatientInfo
        '
        Me.lblPatientInfo.AutoSize = True
        Me.lblPatientInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblPatientInfo.Location = New System.Drawing.Point(109, 15)
        Me.lblPatientInfo.Name = "lblPatientInfo"
        Me.lblPatientInfo.Size = New System.Drawing.Size(56, 21)
        Me.lblPatientInfo.TabIndex = 200
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
        Me.btnBack.Location = New System.Drawing.Point(14, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 37)
        Me.btnBack.TabIndex = 61
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "Drawer:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(238, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 25)
        Me.Label5.TabIndex = 213
        Me.Label5.Text = "Amount wasted:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtUnit
        '
        Me.txtUnit.BackColor = System.Drawing.Color.White
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(412, 99)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.ShortcutsEnabled = False
        Me.txtUnit.Size = New System.Drawing.Size(77, 25)
        Me.txtUnit.TabIndex = 214
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(243, 99)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ShortcutsEnabled = False
        Me.txtQuantity.Size = New System.Drawing.Size(163, 25)
        Me.txtQuantity.TabIndex = 215
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(17, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ShortcutsEnabled = False
        Me.TextBox2.Size = New System.Drawing.Size(220, 25)
        Me.TextBox2.TabIndex = 216
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(18, 155)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ShortcutsEnabled = False
        Me.TextBox3.Size = New System.Drawing.Size(163, 25)
        Me.TextBox3.TabIndex = 217
        '
        'frmWaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(771, 733)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlRadioButtons)
        Me.Name = "frmWaste"
        Me.Text = "Waste"
        Me.pnlRadioButtons.ResumeLayout(False)
        Me.pnlRadioButtons.PerformLayout()
        Me.pnlSignOff.ResumeLayout(False)
        Me.pnlSignOff.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents lblPatientInfo As Label
End Class
