<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDischarge
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbAdmitPatients = New System.Windows.Forms.ComboBox()
        Me.btnAdmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbDischargePatients = New System.Windows.Forms.ComboBox()
        Me.btnDischarge = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(12, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 21)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Select Patient to Admit:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.cmbAdmitPatients)
        Me.Panel3.Location = New System.Drawing.Point(12, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel3.Size = New System.Drawing.Size(437, 28)
        Me.Panel3.TabIndex = 1
        Me.Panel3.TabStop = True
        '
        'cmbAdmitPatients
        '
        Me.cmbAdmitPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbAdmitPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAdmitPatients.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAdmitPatients.FormattingEnabled = True
        Me.cmbAdmitPatients.Location = New System.Drawing.Point(1, 1)
        Me.cmbAdmitPatients.Name = "cmbAdmitPatients"
        Me.cmbAdmitPatients.Size = New System.Drawing.Size(435, 25)
        Me.cmbAdmitPatients.TabIndex = 5
        '
        'btnAdmit
        '
        Me.btnAdmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAdmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmit.ForeColor = System.Drawing.Color.White
        Me.btnAdmit.Image = Global.test_gui.My.Resources.Resources.resolve
        Me.btnAdmit.Location = New System.Drawing.Point(12, 93)
        Me.btnAdmit.Name = "btnAdmit"
        Me.btnAdmit.Size = New System.Drawing.Size(120, 38)
        Me.btnAdmit.TabIndex = 2
        Me.btnAdmit.Text = "  Admit"
        Me.btnAdmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdmit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 21)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Select Patient to Discharge:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.cmbDischargePatients)
        Me.Panel1.Location = New System.Drawing.Point(12, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(437, 28)
        Me.Panel1.TabIndex = 3
        Me.Panel1.TabStop = True
        '
        'cmbDischargePatients
        '
        Me.cmbDischargePatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDischargePatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDischargePatients.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDischargePatients.FormattingEnabled = True
        Me.cmbDischargePatients.Location = New System.Drawing.Point(1, 1)
        Me.cmbDischargePatients.Name = "cmbDischargePatients"
        Me.cmbDischargePatients.Size = New System.Drawing.Size(435, 25)
        Me.cmbDischargePatients.TabIndex = 5
        '
        'btnDischarge
        '
        Me.btnDischarge.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDischarge.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDischarge.ForeColor = System.Drawing.Color.White
        Me.btnDischarge.Image = Global.test_gui.My.Resources.Resources.resolve
        Me.btnDischarge.Location = New System.Drawing.Point(12, 228)
        Me.btnDischarge.Name = "btnDischarge"
        Me.btnDischarge.Size = New System.Drawing.Size(132, 38)
        Me.btnDischarge.TabIndex = 4
        Me.btnDischarge.Text = "  Discharge"
        Me.btnDischarge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDischarge.UseVisualStyleBackColor = False
        '
        'frmDischarge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 580)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDischarge)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnAdmit)
        Me.Name = "frmDischarge"
        Me.Text = "frmDischarge"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmbAdmitPatients As ComboBox
    Friend WithEvents btnAdmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbDischargePatients As ComboBox
    Friend WithEvents btnDischarge As Button
End Class
