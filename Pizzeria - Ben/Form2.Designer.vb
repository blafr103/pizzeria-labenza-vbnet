<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.finale = New System.Windows.Forms.Button()
        Me.totaltax = New System.Windows.Forms.Label()
        Me.texttax = New System.Windows.Forms.Label()
        Me.itemlab = New System.Windows.Forms.Label()
        Me.ord = New System.Windows.Forms.Label()
        Me.finla = New System.Windows.Forms.Label()
        Me.tp2 = New System.Windows.Forms.Label()
        Me.tp1 = New System.Windows.Forms.Label()
        Me.tp3 = New System.Windows.Forms.Label()
        Me.tp4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'finale
        '
        Me.finale.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finale.Location = New System.Drawing.Point(469, 220)
        Me.finale.Name = "finale"
        Me.finale.Size = New System.Drawing.Size(75, 73)
        Me.finale.TabIndex = 7
        Me.finale.Text = "Place Order"
        Me.finale.UseVisualStyleBackColor = True
        '
        'totaltax
        '
        Me.totaltax.AutoSize = True
        Me.totaltax.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.totaltax.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaltax.Location = New System.Drawing.Point(313, 265)
        Me.totaltax.Name = "totaltax"
        Me.totaltax.Size = New System.Drawing.Size(144, 28)
        Me.totaltax.TabIndex = 6
        Me.totaltax.Text = "                      "
        '
        'texttax
        '
        Me.texttax.AutoSize = True
        Me.texttax.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texttax.Location = New System.Drawing.Point(133, 269)
        Me.texttax.Name = "texttax"
        Me.texttax.Size = New System.Drawing.Size(165, 20)
        Me.texttax.TabIndex = 5
        Me.texttax.Text = "Total (after tax):"
        '
        'itemlab
        '
        Me.itemlab.AutoSize = True
        Me.itemlab.Font = New System.Drawing.Font("SWTOR Trajan", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemlab.Location = New System.Drawing.Point(12, 9)
        Me.itemlab.Name = "itemlab"
        Me.itemlab.Size = New System.Drawing.Size(199, 21)
        Me.itemlab.TabIndex = 8
        Me.itemlab.Text = "Order Number:"
        '
        'ord
        '
        Me.ord.AutoSize = True
        Me.ord.Font = New System.Drawing.Font("Trajan Pro", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ord.Location = New System.Drawing.Point(218, 9)
        Me.ord.Name = "ord"
        Me.ord.Size = New System.Drawing.Size(70, 24)
        Me.ord.TabIndex = 9
        Me.ord.Text = "          "
        '
        'finla
        '
        Me.finla.AutoSize = True
        Me.finla.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finla.Location = New System.Drawing.Point(16, 62)
        Me.finla.Name = "finla"
        Me.finla.Size = New System.Drawing.Size(0, 26)
        Me.finla.TabIndex = 10
        '
        'tp2
        '
        Me.tp2.AutoSize = True
        Me.tp2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp2.Location = New System.Drawing.Point(16, 114)
        Me.tp2.Name = "tp2"
        Me.tp2.Size = New System.Drawing.Size(0, 26)
        Me.tp2.TabIndex = 11
        '
        'tp1
        '
        Me.tp1.AutoSize = True
        Me.tp1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp1.Location = New System.Drawing.Point(16, 88)
        Me.tp1.Name = "tp1"
        Me.tp1.Size = New System.Drawing.Size(0, 26)
        Me.tp1.TabIndex = 12
        '
        'tp3
        '
        Me.tp3.AutoSize = True
        Me.tp3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp3.Location = New System.Drawing.Point(16, 140)
        Me.tp3.Name = "tp3"
        Me.tp3.Size = New System.Drawing.Size(0, 26)
        Me.tp3.TabIndex = 13
        '
        'tp4
        '
        Me.tp4.AutoSize = True
        Me.tp4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp4.Location = New System.Drawing.Point(16, 167)
        Me.tp4.Name = "tp4"
        Me.tp4.Size = New System.Drawing.Size(0, 26)
        Me.tp4.TabIndex = 14
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 305)
        Me.Controls.Add(Me.tp4)
        Me.Controls.Add(Me.tp3)
        Me.Controls.Add(Me.tp1)
        Me.Controls.Add(Me.tp2)
        Me.Controls.Add(Me.finla)
        Me.Controls.Add(Me.ord)
        Me.Controls.Add(Me.itemlab)
        Me.Controls.Add(Me.finale)
        Me.Controls.Add(Me.totaltax)
        Me.Controls.Add(Me.texttax)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents finale As Button
    Friend WithEvents totaltax As Label
    Friend WithEvents texttax As Label
    Friend WithEvents itemlab As Label
    Friend WithEvents ord As Label
    Friend WithEvents finla As Label
    Friend WithEvents tp2 As Label
    Friend WithEvents tp1 As Label
    Friend WithEvents tp3 As Label
    Friend WithEvents tp4 As Label
End Class
