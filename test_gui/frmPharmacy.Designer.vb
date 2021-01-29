<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPharmacy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPharmacy))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.flpNotes = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(339, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 21)
        Me.Label10.TabIndex = 175
        Me.Label10.Text = "Schedule:"
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox5.Location = New System.Drawing.Point(342, 154)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(243, 29)
        Me.ComboBox5.TabIndex = 174
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox4.Location = New System.Drawing.Point(40, 305)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(240, 29)
        Me.ComboBox4.TabIndex = 173
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 21)
        Me.Label11.TabIndex = 172
        Me.Label11.Text = "Orderd By:"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox3.Location = New System.Drawing.Point(38, 79)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(242, 29)
        Me.ComboBox3.TabIndex = 171
        '
        'flpNotes
        '
        Me.flpNotes.AutoScroll = True
        Me.flpNotes.BackColor = System.Drawing.Color.White
        Me.flpNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.flpNotes.Location = New System.Drawing.Point(342, 304)
        Me.flpNotes.Name = "flpNotes"
        Me.flpNotes.Size = New System.Drawing.Size(243, 92)
        Me.flpNotes.TabIndex = 170
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 21)
        Me.Label12.TabIndex = 169
        Me.Label12.Text = "Patient Name:"
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox6.Location = New System.Drawing.Point(37, 155)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(243, 29)
        Me.ComboBox6.TabIndex = 168
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(335, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 21)
        Me.Label13.TabIndex = 167
        Me.Label13.Text = "Patient DOB:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(35, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 21)
        Me.Label14.TabIndex = 166
        Me.Label14.Text = "Dosage:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(338, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 21)
        Me.Label15.TabIndex = 165
        Me.Label15.Text = "Method:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(339, 205)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 21)
        Me.Label16.TabIndex = 164
        Me.Label16.Text = "Quantity:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 131)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 21)
        Me.Label17.TabIndex = 163
        Me.Label17.Text = "Medication:"
        '
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"Yes", "No"})
        Me.ComboBox7.Location = New System.Drawing.Point(40, 234)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(240, 29)
        Me.ComboBox7.TabIndex = 162
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(23, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(165, 25)
        Me.Label18.TabIndex = 158
        Me.Label18.Text = "New Prescription"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.numQuantity)
        Me.Panel4.Location = New System.Drawing.Point(342, 234)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel4.Size = New System.Drawing.Size(58, 29)
        Me.Panel4.TabIndex = 161
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Controls.Add(Me.TextBox4)
        Me.Panel5.Location = New System.Drawing.Point(342, 79)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(119, 28)
        Me.Panel5.TabIndex = 160
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(1, 1)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(117, 26)
        Me.TextBox4.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(210, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 38)
        Me.Button1.TabIndex = 159
        Me.Button1.Text = "   Order Prescription"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'numQuantity
        '
        Me.numQuantity.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numQuantity.Location = New System.Drawing.Point(1, 1)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(56, 27)
        Me.numQuantity.TabIndex = 176
        '
        'frmPharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(621, 470)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.flpNotes)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmPharmacy"
        Me.Tag = "6"
        Me.Text = "frmPharmacy"
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDispense As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents flpNotes As FlowLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents numQuantity As NumericUpDown
End Class
