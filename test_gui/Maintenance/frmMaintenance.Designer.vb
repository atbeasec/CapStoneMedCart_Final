<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenance))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radUser = New System.Windows.Forms.RadioButton()
        Me.radPhysician = New System.Windows.Forms.RadioButton()
        Me.radRoom = New System.Windows.Forms.RadioButton()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radPatient = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radUser)
        Me.Panel1.Controls.Add(Me.radPhysician)
        Me.Panel1.Controls.Add(Me.radRoom)
        Me.Panel1.Controls.Add(Me.btnUpload)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.radPatient)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 409)
        Me.Panel1.TabIndex = 0
        '
        'radUser
        '
        Me.radUser.AutoSize = True
        Me.radUser.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUser.Location = New System.Drawing.Point(107, 218)
        Me.radUser.Name = "radUser"
        Me.radUser.Size = New System.Drawing.Size(118, 25)
        Me.radUser.TabIndex = 57
        Me.radUser.TabStop = True
        Me.radUser.Text = "User Record"
        Me.radUser.UseVisualStyleBackColor = True
        '
        'radPhysician
        '
        Me.radPhysician.AutoSize = True
        Me.radPhysician.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPhysician.Location = New System.Drawing.Point(107, 123)
        Me.radPhysician.Name = "radPhysician"
        Me.radPhysician.Size = New System.Drawing.Size(151, 25)
        Me.radPhysician.TabIndex = 56
        Me.radPhysician.TabStop = True
        Me.radPhysician.Text = "Physician Record"
        Me.radPhysician.UseVisualStyleBackColor = True
        '
        'radRoom
        '
        Me.radRoom.AutoSize = True
        Me.radRoom.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRoom.Location = New System.Drawing.Point(107, 171)
        Me.radRoom.Name = "radRoom"
        Me.radRoom.Size = New System.Drawing.Size(79, 25)
        Me.radRoom.TabIndex = 55
        Me.radRoom.TabStop = True
        Me.radRoom.Text = "Rooms"
        Me.radRoom.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnUpload.FlatAppearance.BorderSize = 0
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Image = CType(resources.GetObject("btnUpload.Image"), System.Drawing.Image)
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUpload.Location = New System.Drawing.Point(107, 269)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(158, 39)
        Me.btnUpload.TabIndex = 53
        Me.btnUpload.Text = "   Select File"
        Me.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 25)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Select Type Of Record to Import"
        '
        'radPatient
        '
        Me.radPatient.AutoSize = True
        Me.radPatient.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPatient.Location = New System.Drawing.Point(107, 72)
        Me.radPatient.Name = "radPatient"
        Me.radPatient.Size = New System.Drawing.Size(136, 25)
        Me.radPatient.TabIndex = 51
        Me.radPatient.TabStop = True
        Me.radPatient.Text = "Patient Record"
        Me.radPatient.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 577)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMaintenance"
        Me.Text = "frmMaintenance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents radRoom As RadioButton
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents radPatient As RadioButton
    Friend WithEvents radUser As RadioButton
    Friend WithEvents radPhysician As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
