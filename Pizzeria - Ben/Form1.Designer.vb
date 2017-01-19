<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nom = New System.Windows.Forms.Label()
        Me.cart = New System.Windows.Forms.Button()
        Me.liste = New System.Windows.Forms.Label()
        Me.add = New System.Windows.Forms.Button()
        Me.prilab = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.smal = New System.Windows.Forms.RadioButton()
        Me.med = New System.Windows.Forms.RadioButton()
        Me.larg = New System.Windows.Forms.RadioButton()
        Me.pepe = New System.Windows.Forms.CheckBox()
        Me.bac = New System.Windows.Forms.CheckBox()
        Me.ana = New System.Windows.Forms.CheckBox()
        Me.ppp = New System.Windows.Forms.CheckBox()
        Me.dwwwwwww = New System.Windows.Forms.Label()
        Me.newo = New System.Windows.Forms.Button()
        Me.ches = New System.Windows.Forms.PictureBox()
        Me.eroni = New System.Windows.Forms.PictureBox()
        Me.bacc = New System.Windows.Forms.PictureBox()
        Me.annn = New System.Windows.Forms.PictureBox()
        Me.prpr = New System.Windows.Forms.PictureBox()
        CType(Me.ches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eroni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bacc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.annn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prpr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nom
        '
        Me.nom.AutoSize = True
        Me.nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(0, -2)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(548, 73)
        Me.nom.TabIndex = 0
        Me.nom.Text = "Pizzeria LaBenza"
        '
        'cart
        '
        Me.cart.BackColor = System.Drawing.SystemColors.Info
        Me.cart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cart.Location = New System.Drawing.Point(605, 12)
        Me.cart.Name = "cart"
        Me.cart.Size = New System.Drawing.Size(130, 59)
        Me.cart.TabIndex = 2
        Me.cart.Text = "Shopping Cart"
        Me.cart.UseVisualStyleBackColor = False
        '
        'liste
        '
        Me.liste.AutoSize = True
        Me.liste.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.liste.Location = New System.Drawing.Point(553, 111)
        Me.liste.Name = "liste"
        Me.liste.Size = New System.Drawing.Size(149, 31)
        Me.liste.TabIndex = 3
        Me.liste.Text = "Ingredients"
        '
        'add
        '
        Me.add.BackColor = System.Drawing.SystemColors.Info
        Me.add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.add.Location = New System.Drawing.Point(650, 344)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(85, 70)
        Me.add.TabIndex = 4
        Me.add.Text = "Calculate Price + Add"
        Me.add.UseVisualStyleBackColor = False
        '
        'prilab
        '
        Me.prilab.AutoSize = True
        Me.prilab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prilab.Location = New System.Drawing.Point(437, 365)
        Me.prilab.Name = "prilab"
        Me.prilab.Size = New System.Drawing.Size(67, 25)
        Me.prilab.TabIndex = 5
        Me.prilab.Text = "Price:"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.BackColor = System.Drawing.SystemColors.Info
        Me.price.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.Location = New System.Drawing.Point(503, 365)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(127, 29)
        Me.price.TabIndex = 10
        Me.price.Text = "                   "
        '
        'smal
        '
        Me.smal.AutoSize = True
        Me.smal.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smal.Location = New System.Drawing.Point(58, 373)
        Me.smal.Name = "smal"
        Me.smal.Size = New System.Drawing.Size(71, 26)
        Me.smal.TabIndex = 14
        Me.smal.TabStop = True
        Me.smal.Text = "Small"
        Me.smal.UseVisualStyleBackColor = True
        '
        'med
        '
        Me.med.AutoSize = True
        Me.med.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.med.Location = New System.Drawing.Point(183, 373)
        Me.med.Name = "med"
        Me.med.Size = New System.Drawing.Size(92, 26)
        Me.med.TabIndex = 15
        Me.med.TabStop = True
        Me.med.Text = "Medium"
        Me.med.UseVisualStyleBackColor = True
        '
        'larg
        '
        Me.larg.AutoSize = True
        Me.larg.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.larg.Location = New System.Drawing.Point(318, 373)
        Me.larg.Name = "larg"
        Me.larg.Size = New System.Drawing.Size(70, 26)
        Me.larg.TabIndex = 16
        Me.larg.TabStop = True
        Me.larg.Text = "Large"
        Me.larg.UseVisualStyleBackColor = True
        '
        'pepe
        '
        Me.pepe.AutoSize = True
        Me.pepe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pepe.Location = New System.Drawing.Point(559, 160)
        Me.pepe.Name = "pepe"
        Me.pepe.Size = New System.Drawing.Size(103, 20)
        Me.pepe.TabIndex = 17
        Me.pepe.Text = "Pepperoni "
        Me.pepe.UseVisualStyleBackColor = True
        '
        'bac
        '
        Me.bac.AutoSize = True
        Me.bac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bac.Location = New System.Drawing.Point(559, 184)
        Me.bac.Name = "bac"
        Me.bac.Size = New System.Drawing.Size(71, 20)
        Me.bac.TabIndex = 18
        Me.bac.Text = "Bacon"
        Me.bac.UseVisualStyleBackColor = True
        '
        'ana
        '
        Me.ana.AutoSize = True
        Me.ana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ana.Location = New System.Drawing.Point(559, 208)
        Me.ana.Name = "ana"
        Me.ana.Size = New System.Drawing.Size(83, 20)
        Me.ana.TabIndex = 19
        Me.ana.Text = "Ananas "
        Me.ana.UseVisualStyleBackColor = True
        '
        'ppp
        '
        Me.ppp.AutoSize = True
        Me.ppp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ppp.Location = New System.Drawing.Point(559, 232)
        Me.ppp.Name = "ppp"
        Me.ppp.Size = New System.Drawing.Size(86, 20)
        Me.ppp.TabIndex = 20
        Me.ppp.Text = "Peppers"
        Me.ppp.UseVisualStyleBackColor = True
        '
        'dwwwwwww
        '
        Me.dwwwwwww.AutoSize = True
        Me.dwwwwwww.Location = New System.Drawing.Point(538, 265)
        Me.dwwwwwww.Name = "dwwwwwww"
        Me.dwwwwwww.Size = New System.Drawing.Size(197, 13)
        Me.dwwwwwww.TabIndex = 21
        Me.dwwwwwww.Text = "First topping is 2 $, every other is 0.50 $."
        '
        'newo
        '
        Me.newo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newo.Location = New System.Drawing.Point(570, 293)
        Me.newo.Name = "newo"
        Me.newo.Size = New System.Drawing.Size(150, 36)
        Me.newo.TabIndex = 22
        Me.newo.Text = "New Order"
        Me.newo.UseVisualStyleBackColor = True
        '
        'ches
        '
        Me.ches.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ches.Image = CType(resources.GetObject("ches.Image"), System.Drawing.Image)
        Me.ches.Location = New System.Drawing.Point(89, 111)
        Me.ches.Name = "ches"
        Me.ches.Size = New System.Drawing.Size(362, 218)
        Me.ches.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ches.TabIndex = 23
        Me.ches.TabStop = False
        '
        'eroni
        '
        Me.eroni.BackColor = System.Drawing.Color.Transparent
        Me.eroni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.eroni.Image = CType(resources.GetObject("eroni.Image"), System.Drawing.Image)
        Me.eroni.Location = New System.Drawing.Point(0, 111)
        Me.eroni.Name = "eroni"
        Me.eroni.Size = New System.Drawing.Size(104, 93)
        Me.eroni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.eroni.TabIndex = 24
        Me.eroni.TabStop = False
        Me.eroni.Visible = False
        '
        'bacc
        '
        Me.bacc.BackColor = System.Drawing.Color.Transparent
        Me.bacc.Image = CType(resources.GetObject("bacc.Image"), System.Drawing.Image)
        Me.bacc.InitialImage = CType(resources.GetObject("bacc.InitialImage"), System.Drawing.Image)
        Me.bacc.Location = New System.Drawing.Point(432, 213)
        Me.bacc.Name = "bacc"
        Me.bacc.Size = New System.Drawing.Size(116, 80)
        Me.bacc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bacc.TabIndex = 25
        Me.bacc.TabStop = False
        Me.bacc.Visible = False
        '
        'annn
        '
        Me.annn.BackColor = System.Drawing.Color.Transparent
        Me.annn.Cursor = System.Windows.Forms.Cursors.Default
        Me.annn.Image = CType(resources.GetObject("annn.Image"), System.Drawing.Image)
        Me.annn.Location = New System.Drawing.Point(0, 208)
        Me.annn.Name = "annn"
        Me.annn.Size = New System.Drawing.Size(114, 106)
        Me.annn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.annn.TabIndex = 26
        Me.annn.TabStop = False
        Me.annn.Visible = False
        '
        'prpr
        '
        Me.prpr.BackColor = System.Drawing.Color.Black
        Me.prpr.Image = CType(resources.GetObject("prpr.Image"), System.Drawing.Image)
        Me.prpr.Location = New System.Drawing.Point(442, 111)
        Me.prpr.Name = "prpr"
        Me.prpr.Size = New System.Drawing.Size(83, 96)
        Me.prpr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.prpr.TabIndex = 27
        Me.prpr.TabStop = False
        Me.prpr.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(747, 443)
        Me.Controls.Add(Me.prpr)
        Me.Controls.Add(Me.annn)
        Me.Controls.Add(Me.eroni)
        Me.Controls.Add(Me.ches)
        Me.Controls.Add(Me.newo)
        Me.Controls.Add(Me.dwwwwwww)
        Me.Controls.Add(Me.ppp)
        Me.Controls.Add(Me.ana)
        Me.Controls.Add(Me.bac)
        Me.Controls.Add(Me.pepe)
        Me.Controls.Add(Me.larg)
        Me.Controls.Add(Me.med)
        Me.Controls.Add(Me.smal)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.prilab)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.liste)
        Me.Controls.Add(Me.cart)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.bacc)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ches, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eroni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bacc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.annn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prpr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nom As Label
    Friend WithEvents cart As Button
    Friend WithEvents liste As Label
    Friend WithEvents add As Button
    Friend WithEvents prilab As Label
    Friend WithEvents price As Label
    Friend WithEvents smal As RadioButton
    Friend WithEvents med As RadioButton
    Friend WithEvents larg As RadioButton
    Friend WithEvents pepe As CheckBox
    Friend WithEvents bac As CheckBox
    Friend WithEvents ana As CheckBox
    Friend WithEvents ppp As CheckBox
    Friend WithEvents dwwwwwww As Label
    Friend WithEvents newo As Button
    Friend WithEvents ches As PictureBox
    Friend WithEvents eroni As PictureBox
    Friend WithEvents bacc As PictureBox
    Friend WithEvents annn As PictureBox
    Friend WithEvents prpr As PictureBox
End Class
