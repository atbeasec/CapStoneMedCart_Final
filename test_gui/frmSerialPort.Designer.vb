<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerialPort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSerialPort))
        Me.cmbBaudrate = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbComPort = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkSimulation = New System.Windows.Forms.CheckBox()
        Me.btnExportDatabase = New System.Windows.Forms.Button()
        Me.btnImportDatabase = New System.Windows.Forms.Button()
        Me.btnImportAsCopy = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbBaudrate
        '
        Me.cmbBaudrate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBaudrate.FormattingEnabled = True
        Me.cmbBaudrate.Location = New System.Drawing.Point(27, 131)
        Me.cmbBaudrate.Name = "cmbBaudrate"
        Me.cmbBaudrate.Size = New System.Drawing.Size(242, 29)
        Me.cmbBaudrate.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 21)
        Me.Label12.TabIndex = 175
        Me.Label12.Text = "Baudrate:"
        '
        'cmbComPort
        '
        Me.cmbComPort.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbComPort.FormattingEnabled = True
        Me.cmbComPort.Location = New System.Drawing.Point(26, 207)
        Me.cmbComPort.Name = "cmbComPort"
        Me.cmbComPort.Size = New System.Drawing.Size(243, 29)
        Me.cmbComPort.TabIndex = 174
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 183)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 21)
        Me.Label17.TabIndex = 173
        Me.Label17.Text = "Com Port:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(202, 25)
        Me.Label18.TabIndex = 172
        Me.Label18.Text = "Medication Cart Info:"
        '
        'chkSimulation
        '
        Me.chkSimulation.AutoSize = True
        Me.chkSimulation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.chkSimulation.Location = New System.Drawing.Point(26, 264)
        Me.chkSimulation.Name = "chkSimulation"
        Me.chkSimulation.Size = New System.Drawing.Size(148, 25)
        Me.chkSimulation.TabIndex = 178
        Me.chkSimulation.Text = "Simulation Mode"
        Me.chkSimulation.UseVisualStyleBackColor = True
        '
        'btnExportDatabase
        '
        Me.btnExportDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnExportDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportDatabase.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportDatabase.ForeColor = System.Drawing.Color.White
        Me.btnExportDatabase.Image = CType(resources.GetObject("btnExportDatabase.Image"), System.Drawing.Image)
        Me.btnExportDatabase.Location = New System.Drawing.Point(560, 7)
        Me.btnExportDatabase.Name = "btnExportDatabase"
        Me.btnExportDatabase.Size = New System.Drawing.Size(197, 38)
        Me.btnExportDatabase.TabIndex = 181
        Me.btnExportDatabase.Text = "EXPORT DATABASE"
        Me.btnExportDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportDatabase.UseVisualStyleBackColor = False
        '
        'btnImportDatabase
        '
        Me.btnImportDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnImportDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportDatabase.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportDatabase.ForeColor = System.Drawing.Color.White
        Me.btnImportDatabase.Image = CType(resources.GetObject("btnImportDatabase.Image"), System.Drawing.Image)
        Me.btnImportDatabase.Location = New System.Drawing.Point(17, 7)
        Me.btnImportDatabase.Name = "btnImportDatabase"
        Me.btnImportDatabase.Size = New System.Drawing.Size(197, 38)
        Me.btnImportDatabase.TabIndex = 180
        Me.btnImportDatabase.Text = "IMPORT DATABASE"
        Me.btnImportDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportDatabase.UseVisualStyleBackColor = False
        '
        'btnImportAsCopy
        '
        Me.btnImportAsCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnImportAsCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportAsCopy.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportAsCopy.ForeColor = System.Drawing.Color.White
        Me.btnImportAsCopy.Image = CType(resources.GetObject("btnImportAsCopy.Image"), System.Drawing.Image)
        Me.btnImportAsCopy.Location = New System.Drawing.Point(255, 7)
        Me.btnImportAsCopy.Name = "btnImportAsCopy"
        Me.btnImportAsCopy.Size = New System.Drawing.Size(264, 38)
        Me.btnImportAsCopy.TabIndex = 179
        Me.btnImportAsCopy.Text = "IMPORT DATABASE AS COPY"
        Me.btnImportAsCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImportAsCopy.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.test_gui.My.Resources.Resources.resolve
        Me.btnSave.Location = New System.Drawing.Point(71, 311)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 38)
        Me.btnSave.TabIndex = 177
        Me.btnSave.Text = "   SAVE "
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmSerialPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(828, 496)
        Me.Controls.Add(Me.btnExportDatabase)
        Me.Controls.Add(Me.btnImportDatabase)
        Me.Controls.Add(Me.btnImportAsCopy)
        Me.Controls.Add(Me.chkSimulation)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbBaudrate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbComPort)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Name = "frmSerialPort"
        Me.Text = "frmSerialPort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbBaudrate As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbComPort As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents chkSimulation As CheckBox
    Friend WithEvents btnImportAsCopy As Button
    Friend WithEvents btnImportDatabase As Button
    Friend WithEvents btnExportDatabase As Button
End Class
