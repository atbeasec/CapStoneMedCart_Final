﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.pnlSubMenuInventory = New System.Windows.Forms.Panel()
        Me.btnConfigureInventory = New System.Windows.Forms.Button()
        Me.btnEndOfShiftCount = New System.Windows.Forms.Button()
        Me.btnAdhockDispense = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnPatientRecords = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.btnWaste = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnPharmacy = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.btnDescrepancies = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.pnlDockLocation = New System.Windows.Forms.Panel()
        Me.pnlSubMenuSettings = New System.Windows.Forms.Panel()
        Me.btnSerialPort = New System.Windows.Forms.Button()
        Me.btnEditRooms = New System.Windows.Forms.Button()
        Me.btnDischargePatient = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.pnlSideMenu.SuspendLayout()
        Me.pnlSubMenuInventory.SuspendLayout()
        Me.pnlSubMenuSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSideMenu
        '
        Me.pnlSideMenu.AutoScroll = True
        Me.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.pnlSideMenu.Controls.Add(Me.pnlSubMenuSettings)
        Me.pnlSideMenu.Controls.Add(Me.btnSettings)
        Me.pnlSideMenu.Controls.Add(Me.btnPharmacy)
        Me.pnlSideMenu.Controls.Add(Me.btnMaintenance)
        Me.pnlSideMenu.Controls.Add(Me.btnDescrepancies)
        Me.pnlSideMenu.Controls.Add(Me.btnReport)
        Me.pnlSideMenu.Controls.Add(Me.pnlSubMenuInventory)
        Me.pnlSideMenu.Controls.Add(Me.btnLogout)
        Me.pnlSideMenu.Controls.Add(Me.btnInventory)
        Me.pnlSideMenu.Controls.Add(Me.btnPatientRecords)
        Me.pnlSideMenu.Controls.Add(Me.pnlLogo)
        Me.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlSideMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSideMenu.Name = "pnlSideMenu"
        Me.pnlSideMenu.Size = New System.Drawing.Size(227, 692)
        Me.pnlSideMenu.TabIndex = 0
        '
        'pnlSubMenuInventory
        '
        Me.pnlSubMenuInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.pnlSubMenuInventory.Controls.Add(Me.btnWaste)
        Me.pnlSubMenuInventory.Controls.Add(Me.btnConfigureInventory)
        Me.pnlSubMenuInventory.Controls.Add(Me.btnEndOfShiftCount)
        Me.pnlSubMenuInventory.Controls.Add(Me.btnAdhockDispense)
        Me.pnlSubMenuInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSubMenuInventory.Location = New System.Drawing.Point(0, 164)
        Me.pnlSubMenuInventory.Name = "pnlSubMenuInventory"
        Me.pnlSubMenuInventory.Size = New System.Drawing.Size(210, 179)
        Me.pnlSubMenuInventory.TabIndex = 24
        '
        'btnConfigureInventory
        '
        Me.btnConfigureInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnConfigureInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfigureInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnConfigureInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigureInventory.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfigureInventory.ForeColor = System.Drawing.Color.White
        Me.btnConfigureInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfigureInventory.Location = New System.Drawing.Point(0, 86)
        Me.btnConfigureInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfigureInventory.Name = "btnConfigureInventory"
        Me.btnConfigureInventory.Padding = New System.Windows.Forms.Padding(35, 5, 5, 5)
        Me.btnConfigureInventory.Size = New System.Drawing.Size(210, 44)
        Me.btnConfigureInventory.TabIndex = 27
        Me.btnConfigureInventory.Tag = "5"
        Me.btnConfigureInventory.Text = "Configure Inventory"
        Me.btnConfigureInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfigureInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfigureInventory.UseVisualStyleBackColor = False
        '
        'btnEndOfShiftCount
        '
        Me.btnEndOfShiftCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnEndOfShiftCount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEndOfShiftCount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnEndOfShiftCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEndOfShiftCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndOfShiftCount.ForeColor = System.Drawing.Color.White
        Me.btnEndOfShiftCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEndOfShiftCount.Location = New System.Drawing.Point(0, 42)
        Me.btnEndOfShiftCount.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEndOfShiftCount.Name = "btnEndOfShiftCount"
        Me.btnEndOfShiftCount.Padding = New System.Windows.Forms.Padding(35, 5, 5, 5)
        Me.btnEndOfShiftCount.Size = New System.Drawing.Size(210, 44)
        Me.btnEndOfShiftCount.TabIndex = 26
        Me.btnEndOfShiftCount.Tag = "4"
        Me.btnEndOfShiftCount.Text = "End of Shift Count"
        Me.btnEndOfShiftCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEndOfShiftCount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEndOfShiftCount.UseVisualStyleBackColor = False
        '
        'btnAdhockDispense
        '
        Me.btnAdhockDispense.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnAdhockDispense.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdhockDispense.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAdhockDispense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdhockDispense.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdhockDispense.ForeColor = System.Drawing.Color.White
        Me.btnAdhockDispense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdhockDispense.Location = New System.Drawing.Point(0, 0)
        Me.btnAdhockDispense.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdhockDispense.Name = "btnAdhockDispense"
        Me.btnAdhockDispense.Padding = New System.Windows.Forms.Padding(35, 5, 5, 5)
        Me.btnAdhockDispense.Size = New System.Drawing.Size(210, 42)
        Me.btnAdhockDispense.TabIndex = 25
        Me.btnAdhockDispense.Tag = "3"
        Me.btnAdhockDispense.Text = "Ad Hock Dispense"
        Me.btnAdhockDispense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdhockDispense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdhockDispense.UseVisualStyleBackColor = False
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
        Me.btnLogout.Location = New System.Drawing.Point(0, 785)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnLogout.Size = New System.Drawing.Size(210, 50)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Tag = "15"
        Me.btnLogout.Text = "   Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
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
        Me.btnInventory.Location = New System.Drawing.Point(0, 114)
        Me.btnInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnInventory.Size = New System.Drawing.Size(210, 50)
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
        Me.btnPatientRecords.Location = New System.Drawing.Point(0, 64)
        Me.btnPatientRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPatientRecords.Name = "btnPatientRecords"
        Me.btnPatientRecords.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnPatientRecords.Size = New System.Drawing.Size(210, 50)
        Me.btnPatientRecords.TabIndex = 7
        Me.btnPatientRecords.Tag = "1"
        Me.btnPatientRecords.Text = "   Patient Records"
        Me.btnPatientRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPatientRecords.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(210, 64)
        Me.pnlLogo.TabIndex = 8
        '
        'btnWaste
        '
        Me.btnWaste.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnWaste.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnWaste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnWaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWaste.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWaste.ForeColor = System.Drawing.Color.White
        Me.btnWaste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWaste.Location = New System.Drawing.Point(0, 130)
        Me.btnWaste.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWaste.Name = "btnWaste"
        Me.btnWaste.Padding = New System.Windows.Forms.Padding(35, 5, 5, 5)
        Me.btnWaste.Size = New System.Drawing.Size(210, 44)
        Me.btnWaste.TabIndex = 28
        Me.btnWaste.Tag = "6"
        Me.btnWaste.Text = "Waste"
        Me.btnWaste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWaste.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(0, 551)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnSettings.Size = New System.Drawing.Size(210, 58)
        Me.btnSettings.TabIndex = 57
        Me.btnSettings.Tag = "11"
        Me.btnSettings.Text = "   Settings"
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = False
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
        Me.btnPharmacy.Location = New System.Drawing.Point(0, 493)
        Me.btnPharmacy.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPharmacy.Name = "btnPharmacy"
        Me.btnPharmacy.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnPharmacy.Size = New System.Drawing.Size(210, 58)
        Me.btnPharmacy.TabIndex = 56
        Me.btnPharmacy.Tag = "10"
        Me.btnPharmacy.Text = "   Pharmacy"
        Me.btnPharmacy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPharmacy.UseVisualStyleBackColor = False
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
        Me.btnMaintenance.Location = New System.Drawing.Point(0, 443)
        Me.btnMaintenance.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnMaintenance.Size = New System.Drawing.Size(210, 50)
        Me.btnMaintenance.TabIndex = 55
        Me.btnMaintenance.Tag = "9"
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
        Me.btnDescrepancies.Location = New System.Drawing.Point(0, 393)
        Me.btnDescrepancies.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDescrepancies.Name = "btnDescrepancies"
        Me.btnDescrepancies.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnDescrepancies.Size = New System.Drawing.Size(210, 50)
        Me.btnDescrepancies.TabIndex = 54
        Me.btnDescrepancies.Tag = "8"
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
        Me.btnReport.Location = New System.Drawing.Point(0, 343)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(10, 5, 5, 5)
        Me.btnReport.Size = New System.Drawing.Size(210, 50)
        Me.btnReport.TabIndex = 53
        Me.btnReport.Tag = "7"
        Me.btnReport.Text = "   Reports"
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'pnlDockLocation
        '
        Me.pnlDockLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDockLocation.Location = New System.Drawing.Point(227, 0)
        Me.pnlDockLocation.Name = "pnlDockLocation"
        Me.pnlDockLocation.Size = New System.Drawing.Size(998, 692)
        Me.pnlDockLocation.TabIndex = 1
        '
        'pnlSubMenuSettings
        '
        Me.pnlSubMenuSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.pnlSubMenuSettings.Controls.Add(Me.btnSerialPort)
        Me.pnlSubMenuSettings.Controls.Add(Me.btnEditRooms)
        Me.pnlSubMenuSettings.Controls.Add(Me.btnDischargePatient)
        Me.pnlSubMenuSettings.Controls.Add(Me.btnUsers)
        Me.pnlSubMenuSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSubMenuSettings.Location = New System.Drawing.Point(0, 609)
        Me.pnlSubMenuSettings.Name = "pnlSubMenuSettings"
        Me.pnlSubMenuSettings.Size = New System.Drawing.Size(210, 176)
        Me.pnlSubMenuSettings.TabIndex = 58
        '
        'btnSerialPort
        '
        Me.btnSerialPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnSerialPort.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSerialPort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSerialPort.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSerialPort.ForeColor = System.Drawing.Color.White
        Me.btnSerialPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSerialPort.Location = New System.Drawing.Point(0, 126)
        Me.btnSerialPort.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSerialPort.Name = "btnSerialPort"
        Me.btnSerialPort.Padding = New System.Windows.Forms.Padding(35, 5, 5, 5)
        Me.btnSerialPort.Size = New System.Drawing.Size(210, 42)
        Me.btnSerialPort.TabIndex = 28
        Me.btnSerialPort.Tag = "15"
        Me.btnSerialPort.Text = "Serial Port Info"
        Me.btnSerialPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSerialPort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSerialPort.UseVisualStyleBackColor = False
        '
        'btnEditRooms
        '
        Me.btnEditRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnEditRooms.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditRooms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnEditRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditRooms.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditRooms.ForeColor = System.Drawing.Color.White
        Me.btnEditRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditRooms.Location = New System.Drawing.Point(0, 84)
        Me.btnEditRooms.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditRooms.Name = "btnEditRooms"
        Me.btnEditRooms.Padding = New System.Windows.Forms.Padding(35, 5, 5, 5)
        Me.btnEditRooms.Size = New System.Drawing.Size(210, 42)
        Me.btnEditRooms.TabIndex = 27
        Me.btnEditRooms.Tag = "14"
        Me.btnEditRooms.Text = "Edit Rooms / Beds"
        Me.btnEditRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditRooms.UseVisualStyleBackColor = False
        '
        'btnDischargePatient
        '
        Me.btnDischargePatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnDischargePatient.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDischargePatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDischargePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDischargePatient.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDischargePatient.ForeColor = System.Drawing.Color.White
        Me.btnDischargePatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDischargePatient.Location = New System.Drawing.Point(0, 42)
        Me.btnDischargePatient.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDischargePatient.Name = "btnDischargePatient"
        Me.btnDischargePatient.Padding = New System.Windows.Forms.Padding(35, 5, 5, 5)
        Me.btnDischargePatient.Size = New System.Drawing.Size(210, 42)
        Me.btnDischargePatient.TabIndex = 26
        Me.btnDischargePatient.Tag = "13"
        Me.btnDischargePatient.Text = "Discharge / Admit"
        Me.btnDischargePatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDischargePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDischargePatient.UseVisualStyleBackColor = False
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(0, 0)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Padding = New System.Windows.Forms.Padding(35, 5, 5, 5)
        Me.btnUsers.Size = New System.Drawing.Size(210, 42)
        Me.btnUsers.TabIndex = 25
        Me.btnUsers.Tag = "12"
        Me.btnUsers.Text = "Add / Remove User"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1225, 692)
        Me.Controls.Add(Me.pnlDockLocation)
        Me.Controls.Add(Me.pnlSideMenu)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "Medical Dispense"
        Me.pnlSideMenu.ResumeLayout(False)
        Me.pnlSubMenuInventory.ResumeLayout(False)
        Me.pnlSubMenuSettings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSideMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnPatientRecords As Button
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents pnlSubMenuInventory As Panel
    Friend WithEvents btnEndOfShiftCount As Button
    Friend WithEvents btnAdhockDispense As Button
    Friend WithEvents btnConfigureInventory As Button
    Friend WithEvents pnlSubMenuSettings As Panel
    Friend WithEvents btnSerialPort As Button
    Friend WithEvents btnEditRooms As Button
    Friend WithEvents btnDischargePatient As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnPharmacy As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents btnDescrepancies As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnWaste As Button
    Friend WithEvents pnlDockLocation As Panel
End Class