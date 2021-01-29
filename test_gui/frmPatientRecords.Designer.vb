<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatientRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientRecords))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHeaderPatientRecords = New System.Windows.Forms.Panel()
        Me.btnNewPatient = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.flpPatientRecords = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlHeaderPatientRecords.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.Label7)
        Me.pnlHeader.Controls.Add(Me.Label6)
        Me.pnlHeader.Controls.Add(Me.Label5)
        Me.pnlHeader.Controls.Add(Me.Label4)
        Me.pnlHeader.Controls.Add(Me.Label3)
        Me.pnlHeader.Controls.Add(Me.Label2)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Location = New System.Drawing.Point(12, 67)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(950, 47)
        Me.pnlHeader.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(431, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DOB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(268, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(803, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Actions"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(672, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(546, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Room"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(10, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MRN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(124, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'pnlHeaderPatientRecords
        '
        Me.pnlHeaderPatientRecords.BackColor = System.Drawing.Color.White
        Me.pnlHeaderPatientRecords.Controls.Add(Me.btnNewPatient)
        Me.pnlHeaderPatientRecords.Controls.Add(Me.Panel2)
        Me.pnlHeaderPatientRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderPatientRecords.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderPatientRecords.Name = "pnlHeaderPatientRecords"
        Me.pnlHeaderPatientRecords.Size = New System.Drawing.Size(986, 61)
        Me.pnlHeaderPatientRecords.TabIndex = 16
        '
        'btnNewPatient
        '
        Me.btnNewPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnNewPatient.FlatAppearance.BorderSize = 0
        Me.btnNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewPatient.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewPatient.ForeColor = System.Drawing.Color.White
        Me.btnNewPatient.Image = CType(resources.GetObject("btnNewPatient.Image"), System.Drawing.Image)
        Me.btnNewPatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNewPatient.Location = New System.Drawing.Point(771, 15)
        Me.btnNewPatient.Name = "btnNewPatient"
        Me.btnNewPatient.Size = New System.Drawing.Size(166, 37)
        Me.btnNewPatient.TabIndex = 18
        Me.btnNewPatient.Text = "ADD PATIENT"
        Me.btnNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewPatient.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(53, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Panel2.Size = New System.Drawing.Size(273, 35)
        Me.Panel2.TabIndex = 16
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.BackgroundImage = CType(resources.GetObject("Panel11.BackgroundImage"), System.Drawing.Image)
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(32, 33)
        Me.Panel11.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.Location = New System.Drawing.Point(32, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 33)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Tag = "Search Patient"
        Me.TextBox1.Text = "Search Patient"
        '
        'flpPatientRecords
        '
        Me.flpPatientRecords.AutoScroll = True
        Me.flpPatientRecords.BackColor = System.Drawing.Color.White
        Me.flpPatientRecords.Location = New System.Drawing.Point(12, 118)
        Me.flpPatientRecords.Name = "flpPatientRecords"
        Me.flpPatientRecords.Size = New System.Drawing.Size(950, 533)
        Me.flpPatientRecords.TabIndex = 17
        '
        'frmPatientRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(986, 663)
        Me.Controls.Add(Me.flpPatientRecords)
        Me.Controls.Add(Me.pnlHeaderPatientRecords)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "frmPatientRecords"
        Me.Text = "frmPatientRecords"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlHeaderPatientRecords.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlHeaderPatientRecords As Panel
    Friend WithEvents btnNewPatient As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents flpPatientRecords As FlowLayoutPanel
End Class
