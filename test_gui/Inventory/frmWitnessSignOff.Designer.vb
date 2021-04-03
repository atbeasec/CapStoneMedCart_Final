<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWitnessSignOff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWitnessSignOff))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.pnlInteractions = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConfigureInventory = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlInteractions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Override Sign-off Required"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(38, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ShortcutsEnabled = False
        Me.TextBox2.Size = New System.Drawing.Size(285, 27)
        Me.TextBox2.TabIndex = 30
        '
        'pnlInteractions
        '
        Me.pnlInteractions.Controls.Add(Me.Label6)
        Me.pnlInteractions.Controls.Add(Me.Label5)
        Me.pnlInteractions.Controls.Add(Me.Label4)
        Me.pnlInteractions.Controls.Add(Me.btnConfigureInventory)
        Me.pnlInteractions.Controls.Add(Me.Label2)
        Me.pnlInteractions.Controls.Add(Me.Label1)
        Me.pnlInteractions.Controls.Add(Me.lblReason)
        Me.pnlInteractions.Location = New System.Drawing.Point(38, 91)
        Me.pnlInteractions.Name = "pnlInteractions"
        Me.pnlInteractions.Size = New System.Drawing.Size(285, 221)
        Me.pnlInteractions.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Location = New System.Drawing.Point(27, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 17)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Get sign off to continue or cancel to exit"
        '
        'btnConfigureInventory
        '
        Me.btnConfigureInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnConfigureInventory.FlatAppearance.BorderSize = 0
        Me.btnConfigureInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigureInventory.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfigureInventory.ForeColor = System.Drawing.Color.White
        Me.btnConfigureInventory.Image = CType(resources.GetObject("btnConfigureInventory.Image"), System.Drawing.Image)
        Me.btnConfigureInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConfigureInventory.Location = New System.Drawing.Point(45, 182)
        Me.btnConfigureInventory.Name = "btnConfigureInventory"
        Me.btnConfigureInventory.Size = New System.Drawing.Size(204, 32)
        Me.btnConfigureInventory.TabIndex = 36
        Me.btnConfigureInventory.Text = "Cancel Dispensing"
        Me.btnConfigureInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfigureInventory.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Causes Allergic Reaction to Patient"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Benzhydrocodone"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.Location = New System.Drawing.Point(105, 4)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(74, 21)
        Me.lblReason.TabIndex = 33
        Me.lblReason.Text = "Warning!"
        Me.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(248, 21)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Causes Allergic Reaction to Patient"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 21)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Causes Allergic Reaction to Patient"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmWitnessSignOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlInteractions)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "frmWitnessSignOff"
        Me.Text = "frmWitnessSignOff"
        Me.pnlInteractions.ResumeLayout(False)
        Me.pnlInteractions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents pnlInteractions As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblReason As Label
    Friend WithEvents btnConfigureInventory As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
