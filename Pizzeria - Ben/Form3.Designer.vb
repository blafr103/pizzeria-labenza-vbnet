<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.CON = New System.Windows.Forms.Label()
        Me.tk = New System.Windows.Forms.Label()
        Me.tks = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.Label()
        Me.b = New System.Windows.Forms.Label()
        Me.c = New System.Windows.Forms.Label()
        Me.postt = New System.Windows.Forms.TextBox()
        Me.cityt = New System.Windows.Forms.TextBox()
        Me.addresst = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.confirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CON
        '
        Me.CON.AutoSize = True
        Me.CON.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CON.Location = New System.Drawing.Point(13, 13)
        Me.CON.Name = "CON"
        Me.CON.Size = New System.Drawing.Size(312, 32)
        Me.CON.TabIndex = 0
        Me.CON.Text = "ORDER CONFIRMATION"
        '
        'tk
        '
        Me.tk.AutoSize = True
        Me.tk.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tk.Location = New System.Drawing.Point(12, 63)
        Me.tk.Name = "tk"
        Me.tk.Size = New System.Drawing.Size(295, 18)
        Me.tk.TabIndex = 1
        Me.tk.Text = "Thank you for ordering with Pizza LaBenza. "
        '
        'tks
        '
        Me.tks.AutoSize = True
        Me.tks.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tks.Location = New System.Drawing.Point(12, 81)
        Me.tks.Name = "tks"
        Me.tks.Size = New System.Drawing.Size(424, 18)
        Me.tks.TabIndex = 2
        Me.tks.Text = "Your order has been placed and will be sent to your address at:"
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.Location = New System.Drawing.Point(5, 148)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(99, 18)
        Me.a.TabIndex = 28
        Me.a.Text = "Street + house#"
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(72, 177)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(32, 18)
        Me.b.TabIndex = 27
        Me.b.Text = "City"
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.Location = New System.Drawing.Point(27, 204)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(77, 18)
        Me.c.TabIndex = 26
        Me.c.Text = "Postal code"
        '
        'postt
        '
        Me.postt.Location = New System.Drawing.Point(110, 202)
        Me.postt.Name = "postt"
        Me.postt.Size = New System.Drawing.Size(100, 20)
        Me.postt.TabIndex = 25
        '
        'cityt
        '
        Me.cityt.Location = New System.Drawing.Point(110, 175)
        Me.cityt.Name = "cityt"
        Me.cityt.Size = New System.Drawing.Size(100, 20)
        Me.cityt.TabIndex = 24
        '
        'addresst
        '
        Me.addresst.Location = New System.Drawing.Point(110, 148)
        Me.addresst.Name = "addresst"
        Me.addresst.Size = New System.Drawing.Size(129, 20)
        Me.addresst.TabIndex = 23
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(107, 120)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(121, 18)
        Me.lbl.TabIndex = 22
        Me.lbl.Text = "Enter your address"
        '
        'confirm
        '
        Me.confirm.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm.Location = New System.Drawing.Point(294, 177)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(130, 99)
        Me.confirm.TabIndex = 29
        Me.confirm.Text = "Confirm"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 310)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.postt)
        Me.Controls.Add(Me.cityt)
        Me.Controls.Add(Me.addresst)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.tks)
        Me.Controls.Add(Me.tk)
        Me.Controls.Add(Me.CON)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CON As Label
    Friend WithEvents tk As Label
    Friend WithEvents tks As Label
    Friend WithEvents a As Label
    Friend WithEvents b As Label
    Friend WithEvents c As Label
    Friend WithEvents postt As TextBox
    Friend WithEvents cityt As TextBox
    Friend WithEvents addresst As TextBox
    Friend WithEvents lbl As Label
    Friend WithEvents confirm As Button
End Class
