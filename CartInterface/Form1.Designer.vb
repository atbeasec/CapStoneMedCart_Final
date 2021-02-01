<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCart
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
        Me.LblDrawer = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblDrawer
        '
        Me.LblDrawer.AutoSize = True
        Me.LblDrawer.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDrawer.Location = New System.Drawing.Point(63, 9)
        Me.LblDrawer.Name = "LblDrawer"
        Me.LblDrawer.Size = New System.Drawing.Size(68, 18)
        Me.LblDrawer.TabIndex = 0
        Me.LblDrawer.Text = "Label1"
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(100, 58)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(207, 109)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Close Drawer"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 234)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblDrawer)
        Me.Name = "FrmCart"
        Me.Text = "Cart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDrawer As Label
    Friend WithEvents BtnClose As Button
End Class
