<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlSideMenu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.pnlDockLocation = New System.Windows.Forms.Panel()
        Me.btnConfiguration = New System.Windows.Forms.Button()
        Me.btnPharmacy = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnDescrepancies = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnPatientRecords = New System.Windows.Forms.Button()
        Me.pnlSideMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSideMenu
        '
        Me.pnlSideMenu.AutoScroll = True
        Me.pnlSideMenu.Controls.Add(Me.Panel2)
        Me.pnlSideMenu.Controls.Add(Me.btnConfiguration)
        Me.pnlSideMenu.Controls.Add(Me.btnPharmacy)
        Me.pnlSideMenu.Controls.Add(Me.btnLogout)
        Me.pnlSideMenu.Controls.Add(Me.btnMaintenance)
        Me.pnlSideMenu.Controls.Add(Me.btnDescrepancies)
        Me.pnlSideMenu.Controls.Add(Me.btnReport)
        Me.pnlSideMenu.Controls.Add(Me.btnInventory)
        Me.pnlSideMenu.Controls.Add(Me.btnPatientRecords)
        Me.pnlSideMenu.Controls.Add(Me.pnlLogo)
        Me.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlSideMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSideMenu.Name = "pnlSideMenu"
        Me.pnlSideMenu.Size = New System.Drawing.Size(227, 591)
        Me.pnlSideMenu.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 438)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 103)
        Me.Panel2.TabIndex = 22
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(227, 72)
        Me.pnlLogo.TabIndex = 8
        '
        'pnlDockLocation
        '
        Me.pnlDockLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDockLocation.Location = New System.Drawing.Point(227, 0)
        Me.pnlDockLocation.Name = "pnlDockLocation"
        Me.pnlDockLocation.Size = New System.Drawing.Size(998, 591)
        Me.pnlDockLocation.TabIndex = 1
        '
        'btnConfiguration
        '
        Me.btnConfiguration.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnConfiguration.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfiguration.FlatAppearance.BorderSize = 0
        Me.btnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguration.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguration.ForeColor = System.Drawing.Color.White
        Me.btnConfiguration.Image = CType(resources.GetObject("btnConfiguration.Image"), System.Drawing.Image)
        Me.btnConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfiguration.Location = New System.Drawing.Point(0, 380)
        Me.btnConfiguration.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfiguration.Name = "btnConfiguration"
        Me.btnConfiguration.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnConfiguration.Size = New System.Drawing.Size(227, 58)
        Me.btnConfiguration.TabIndex = 21
        Me.btnConfiguration.Tag = "7"
        Me.btnConfiguration.Text = "   Configuration"
        Me.btnConfiguration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfiguration.UseVisualStyleBackColor = False
        '
        'btnPharmacy
        '
        Me.btnPharmacy.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnPharmacy.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPharmacy.FlatAppearance.BorderSize = 0
        Me.btnPharmacy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPharmacy.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPharmacy.ForeColor = System.Drawing.Color.White
        Me.btnPharmacy.Image = Global.test_gui.My.Resources.Resources.pharmacy
        Me.btnPharmacy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPharmacy.Location = New System.Drawing.Point(0, 322)
        Me.btnPharmacy.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPharmacy.Name = "btnPharmacy"
        Me.btnPharmacy.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnPharmacy.Size = New System.Drawing.Size(227, 58)
        Me.btnPharmacy.TabIndex = 20
        Me.btnPharmacy.Tag = "6"
        Me.btnPharmacy.Text = "   Pharmacy"
        Me.btnPharmacy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPharmacy.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 541)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnLogout.Size = New System.Drawing.Size(227, 50)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Tag = "8"
        Me.btnLogout.Text = "   Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnMaintenance
        '
        Me.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMaintenance.FlatAppearance.BorderSize = 0
        Me.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintenance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.ForeColor = System.Drawing.Color.White
        Me.btnMaintenance.Image = CType(resources.GetObject("btnMaintenance.Image"), System.Drawing.Image)
        Me.btnMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaintenance.Location = New System.Drawing.Point(0, 272)
        Me.btnMaintenance.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnMaintenance.Size = New System.Drawing.Size(227, 50)
        Me.btnMaintenance.TabIndex = 12
        Me.btnMaintenance.Tag = "5"
        Me.btnMaintenance.Text = "   Maintenance"
        Me.btnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaintenance.UseVisualStyleBackColor = False
        '
        'btnDescrepancies
        '
        Me.btnDescrepancies.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDescrepancies.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDescrepancies.FlatAppearance.BorderSize = 0
        Me.btnDescrepancies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescrepancies.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescrepancies.ForeColor = System.Drawing.Color.White
        Me.btnDescrepancies.Image = CType(resources.GetObject("btnDescrepancies.Image"), System.Drawing.Image)
        Me.btnDescrepancies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescrepancies.Location = New System.Drawing.Point(0, 222)
        Me.btnDescrepancies.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDescrepancies.Name = "btnDescrepancies"
        Me.btnDescrepancies.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnDescrepancies.Size = New System.Drawing.Size(227, 50)
        Me.btnDescrepancies.TabIndex = 11
        Me.btnDescrepancies.Tag = "4"
        Me.btnDescrepancies.Text = "   Discrepancies"
        Me.btnDescrepancies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDescrepancies.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(0, 172)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnReport.Size = New System.Drawing.Size(227, 50)
        Me.btnReport.TabIndex = 10
        Me.btnReport.Tag = "3"
        Me.btnReport.Text = "   Dispense History"
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), System.Drawing.Image)
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 122)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnInventory.Size = New System.Drawing.Size(227, 50)
        Me.btnInventory.TabIndex = 9
        Me.btnInventory.Tag = "2"
        Me.btnInventory.Text = "   Inventory"
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnPatientRecords
        '
        Me.btnPatientRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnPatientRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPatientRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPatientRecords.FlatAppearance.BorderSize = 0
        Me.btnPatientRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatientRecords.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientRecords.ForeColor = System.Drawing.Color.White
        Me.btnPatientRecords.Image = CType(resources.GetObject("btnPatientRecords.Image"), System.Drawing.Image)
        Me.btnPatientRecords.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPatientRecords.Location = New System.Drawing.Point(0, 72)
        Me.btnPatientRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPatientRecords.Name = "btnPatientRecords"
        Me.btnPatientRecords.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnPatientRecords.Size = New System.Drawing.Size(227, 50)
        Me.btnPatientRecords.TabIndex = 7
        Me.btnPatientRecords.Tag = "1"
        Me.btnPatientRecords.Text = "   Patient Records"
        Me.btnPatientRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPatientRecords.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1225, 591)
        Me.Controls.Add(Me.pnlDockLocation)
        Me.Controls.Add(Me.pnlSideMenu)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "Medical Dispense"
        Me.pnlSideMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSideMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents btnDescrepancies As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnPatientRecords As Button
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents pnlDockLocation As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnConfiguration As Button
    Friend WithEvents btnPharmacy As Button
End Class
