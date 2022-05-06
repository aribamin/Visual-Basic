<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncrediBullPizza
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
        Me.lblPizzaSize = New System.Windows.Forms.Label()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.lblToppings = New System.Windows.Forms.Label()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.chkGroundBeef = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkGreenPeppers = New System.Windows.Forms.CheckBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.picIncrediBullPizza = New System.Windows.Forms.PictureBox()
        CType(Me.picIncrediBullPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPizzaSize
        '
        Me.lblPizzaSize.AutoSize = True
        Me.lblPizzaSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaSize.Location = New System.Drawing.Point(23, 24)
        Me.lblPizzaSize.Name = "lblPizzaSize"
        Me.lblPizzaSize.Size = New System.Drawing.Size(123, 29)
        Me.lblPizzaSize.TabIndex = 0
        Me.lblPizzaSize.Text = "Pizza Size"
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSmall.Location = New System.Drawing.Point(28, 56)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(74, 28)
        Me.radSmall.TabIndex = 1
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMedium.Location = New System.Drawing.Point(28, 90)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(97, 28)
        Me.radMedium.TabIndex = 2
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLarge.Location = New System.Drawing.Point(28, 124)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(76, 28)
        Me.radLarge.TabIndex = 3
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'lblToppings
        '
        Me.lblToppings.AutoSize = True
        Me.lblToppings.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToppings.Location = New System.Drawing.Point(23, 178)
        Me.lblToppings.Name = "lblToppings"
        Me.lblToppings.Size = New System.Drawing.Size(116, 29)
        Me.lblToppings.TabIndex = 4
        Me.lblToppings.Text = "Toppings"
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPepperoni.Location = New System.Drawing.Point(28, 210)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(117, 28)
        Me.chkPepperoni.TabIndex = 5
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBacon.Location = New System.Drawing.Point(28, 244)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(83, 28)
        Me.chkBacon.TabIndex = 6
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'chkGroundBeef
        '
        Me.chkGroundBeef.AutoSize = True
        Me.chkGroundBeef.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGroundBeef.Location = New System.Drawing.Point(28, 278)
        Me.chkGroundBeef.Name = "chkGroundBeef"
        Me.chkGroundBeef.Size = New System.Drawing.Size(136, 28)
        Me.chkGroundBeef.TabIndex = 7
        Me.chkGroundBeef.Text = "Ground Beef"
        Me.chkGroundBeef.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMushrooms.Location = New System.Drawing.Point(199, 210)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(129, 28)
        Me.chkMushrooms.TabIndex = 8
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOnions.Location = New System.Drawing.Point(199, 244)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(90, 28)
        Me.chkOnions.TabIndex = 9
        Me.chkOnions.Text = "Onions"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'chkGreenPeppers
        '
        Me.chkGreenPeppers.AutoSize = True
        Me.chkGreenPeppers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGreenPeppers.Location = New System.Drawing.Point(199, 278)
        Me.chkGreenPeppers.Name = "chkGreenPeppers"
        Me.chkGreenPeppers.Size = New System.Drawing.Size(158, 28)
        Me.chkGreenPeppers.TabIndex = 10
        Me.chkGreenPeppers.Text = "Green Peppers"
        Me.chkGreenPeppers.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(10, 333)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(129, 29)
        Me.lblTotalCost.TabIndex = 11
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(158, 333)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(0, 29)
        Me.lblCost.TabIndex = 12
        '
        'cmdClear
        '
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(396, 283)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(99, 40)
        Me.cmdClear.TabIndex = 13
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdDone
        '
        Me.cmdDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDone.Location = New System.Drawing.Point(396, 333)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(99, 40)
        Me.cmdDone.TabIndex = 14
        Me.cmdDone.Text = "Done"
        Me.cmdDone.UseVisualStyleBackColor = True
        '
        'picIncrediBullPizza
        '
        Me.picIncrediBullPizza.Image = Global.Pizza_2._0.Amin.My.Resources.Resources.incredibull_pizza
        Me.picIncrediBullPizza.Location = New System.Drawing.Point(304, 12)
        Me.picIncrediBullPizza.Name = "picIncrediBullPizza"
        Me.picIncrediBullPizza.Size = New System.Drawing.Size(191, 192)
        Me.picIncrediBullPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIncrediBullPizza.TabIndex = 15
        Me.picIncrediBullPizza.TabStop = False
        '
        'frmIncrediBullPizza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 383)
        Me.Controls.Add(Me.picIncrediBullPizza)
        Me.Controls.Add(Me.cmdDone)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.chkGreenPeppers)
        Me.Controls.Add(Me.chkOnions)
        Me.Controls.Add(Me.chkMushrooms)
        Me.Controls.Add(Me.chkGroundBeef)
        Me.Controls.Add(Me.chkBacon)
        Me.Controls.Add(Me.chkPepperoni)
        Me.Controls.Add(Me.lblToppings)
        Me.Controls.Add(Me.radLarge)
        Me.Controls.Add(Me.radMedium)
        Me.Controls.Add(Me.radSmall)
        Me.Controls.Add(Me.lblPizzaSize)
        Me.Name = "frmIncrediBullPizza"
        Me.Text = "IncrediBull Pizza"
        CType(Me.picIncrediBullPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPizzaSize As System.Windows.Forms.Label
    Friend WithEvents radSmall As System.Windows.Forms.RadioButton
    Friend WithEvents radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents lblToppings As System.Windows.Forms.Label
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chkBacon As System.Windows.Forms.CheckBox
    Friend WithEvents chkGroundBeef As System.Windows.Forms.CheckBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
    Friend WithEvents chkGreenPeppers As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdDone As System.Windows.Forms.Button
    Friend WithEvents picIncrediBullPizza As System.Windows.Forms.PictureBox

End Class
