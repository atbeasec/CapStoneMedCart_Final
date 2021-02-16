<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigureRooms
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.lstRooms = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeleteRoom = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lstBeds = New System.Windows.Forms.ListBox()
        Me.btnAddBed = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtBed = New System.Windows.Forms.TextBox()
        Me.btnDeleteBed = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 181)
        Me.Label12.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 54)
        Me.Label12.TabIndex = 173
        Me.Label12.Text = "Rooms:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(837, 181)
        Me.Label13.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 54)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = "Beds:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.txtRoom)
        Me.Panel5.Location = New System.Drawing.Point(43, 83)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Size = New System.Drawing.Size(467, 67)
        Me.Panel5.TabIndex = 1
        '
        'txtRoom
        '
        Me.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRoom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRoom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom.Location = New System.Drawing.Point(3, 2)
        Me.txtRoom.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtRoom.Multiline = True
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(461, 63)
        Me.txtRoom.TabIndex = 1
        '
        'lstRooms
        '
        Me.lstRooms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstRooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstRooms.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRooms.FormattingEnabled = True
        Me.lstRooms.ItemHeight = 50
        Me.lstRooms.Location = New System.Drawing.Point(3, 2)
        Me.lstRooms.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.lstRooms.Name = "lstRooms"
        Me.lstRooms.Size = New System.Drawing.Size(461, 502)
        Me.lstRooms.TabIndex = 174
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.lstRooms)
        Me.Panel1.Location = New System.Drawing.Point(45, 236)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Size = New System.Drawing.Size(467, 506)
        Me.Panel1.TabIndex = 3
        '
        'btnDeleteRoom
        '
        Me.btnDeleteRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteRoom.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRoom.ForeColor = System.Drawing.Color.White
        Me.btnDeleteRoom.Location = New System.Drawing.Point(552, 181)
        Me.btnDeleteRoom.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnDeleteRoom.Name = "btnDeleteRoom"
        Me.btnDeleteRoom.Size = New System.Drawing.Size(232, 79)
        Me.btnDeleteRoom.TabIndex = 4
        Me.btnDeleteRoom.Text = "Delete"
        Me.btnDeleteRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteRoom.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.lstBeds)
        Me.Panel2.Location = New System.Drawing.Point(848, 236)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Size = New System.Drawing.Size(467, 506)
        Me.Panel2.TabIndex = 7
        '
        'lstBeds
        '
        Me.lstBeds.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstBeds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstBeds.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBeds.FormattingEnabled = True
        Me.lstBeds.ItemHeight = 50
        Me.lstBeds.Location = New System.Drawing.Point(3, 2)
        Me.lstBeds.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.lstBeds.Name = "lstBeds"
        Me.lstBeds.Size = New System.Drawing.Size(461, 502)
        Me.lstBeds.TabIndex = 174
        '
        'btnAddBed
        '
        Me.btnAddBed.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAddBed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBed.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBed.ForeColor = System.Drawing.Color.White
        Me.btnAddBed.Location = New System.Drawing.Point(1360, 74)
        Me.btnAddBed.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnAddBed.Name = "btnAddBed"
        Me.btnAddBed.Size = New System.Drawing.Size(232, 79)
        Me.btnAddBed.TabIndex = 6
        Me.btnAddBed.Text = "Add"
        Me.btnAddBed.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddBed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddBed.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.txtBed)
        Me.Panel3.Location = New System.Drawing.Point(851, 83)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Size = New System.Drawing.Size(467, 67)
        Me.Panel3.TabIndex = 5
        '
        'txtBed
        '
        Me.txtBed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBed.Location = New System.Drawing.Point(3, 2)
        Me.txtBed.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtBed.Multiline = True
        Me.txtBed.Name = "txtBed"
        Me.txtBed.Size = New System.Drawing.Size(461, 63)
        Me.txtBed.TabIndex = 38
        '
        'btnDeleteBed
        '
        Me.btnDeleteBed.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDeleteBed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteBed.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBed.ForeColor = System.Drawing.Color.White
        Me.btnDeleteBed.Location = New System.Drawing.Point(1360, 181)
        Me.btnDeleteBed.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnDeleteBed.Name = "btnDeleteBed"
        Me.btnDeleteBed.Size = New System.Drawing.Size(232, 79)
        Me.btnDeleteBed.TabIndex = 8
        Me.btnDeleteBed.Text = "Delete"
        Me.btnDeleteBed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteBed.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 54)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Add New Room:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(843, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 54)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "Add New Bed:"
        '
        'frmConfigureRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1677, 863)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteBed)
        Me.Controls.Add(Me.btnAddBed)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnDeleteRoom)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel5)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmConfigureRooms"
        Me.Text = "frmConfigureRooms"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents lstRooms As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDeleteRoom As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lstBeds As ListBox
    Friend WithEvents btnAddBed As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtBed As TextBox
    Friend WithEvents btnDeleteBed As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
