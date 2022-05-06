<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemperatureConverter
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
        Me.lblTempFahrenheit = New System.Windows.Forms.Label()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.lblTempCelcius = New System.Windows.Forms.Label()
        Me.lblConvertedTemp = New System.Windows.Forms.Label()
        Me.radCalculate = New System.Windows.Forms.Button()
        Me.radClear = New System.Windows.Forms.Button()
        Me.radDone = New System.Windows.Forms.Button()
        Me.picThermometer = New System.Windows.Forms.PictureBox()
        CType(Me.picThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTempFahrenheit
        '
        Me.lblTempFahrenheit.AutoSize = True
        Me.lblTempFahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempFahrenheit.Location = New System.Drawing.Point(124, 54)
        Me.lblTempFahrenheit.Name = "lblTempFahrenheit"
        Me.lblTempFahrenheit.Size = New System.Drawing.Size(352, 25)
        Me.lblTempFahrenheit.TabIndex = 0
        Me.lblTempFahrenheit.Text = "Enter the temperature in Fahrenheit"
        '
        'txtTemperature
        '
        Me.txtTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperature.Location = New System.Drawing.Point(482, 51)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(100, 31)
        Me.txtTemperature.TabIndex = 1
        '
        'lblTempCelcius
        '
        Me.lblTempCelcius.AutoSize = True
        Me.lblTempCelcius.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempCelcius.Location = New System.Drawing.Point(182, 154)
        Me.lblTempCelcius.Name = "lblTempCelcius"
        Me.lblTempCelcius.Size = New System.Drawing.Size(0, 25)
        Me.lblTempCelcius.TabIndex = 2
        '
        'lblConvertedTemp
        '
        Me.lblConvertedTemp.AutoSize = True
        Me.lblConvertedTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedTemp.Location = New System.Drawing.Point(482, 154)
        Me.lblConvertedTemp.Name = "lblConvertedTemp"
        Me.lblConvertedTemp.Size = New System.Drawing.Size(0, 25)
        Me.lblConvertedTemp.TabIndex = 3
        '
        'radCalculate
        '
        Me.radCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radCalculate.Location = New System.Drawing.Point(129, 285)
        Me.radCalculate.Name = "radCalculate"
        Me.radCalculate.Size = New System.Drawing.Size(75, 23)
        Me.radCalculate.TabIndex = 4
        Me.radCalculate.Text = "Calculate"
        Me.radCalculate.UseVisualStyleBackColor = True
        '
        'radClear
        '
        Me.radClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radClear.Location = New System.Drawing.Point(309, 285)
        Me.radClear.Name = "radClear"
        Me.radClear.Size = New System.Drawing.Size(75, 23)
        Me.radClear.TabIndex = 5
        Me.radClear.Text = "Clear"
        Me.radClear.UseVisualStyleBackColor = True
        '
        'radDone
        '
        Me.radDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radDone.Location = New System.Drawing.Point(487, 285)
        Me.radDone.Name = "radDone"
        Me.radDone.Size = New System.Drawing.Size(75, 23)
        Me.radDone.TabIndex = 6
        Me.radDone.Text = "Done"
        Me.radDone.UseVisualStyleBackColor = True
        '
        'picThermometer
        '
        Me.picThermometer.Location = New System.Drawing.Point(12, 51)
        Me.picThermometer.Name = "picThermometer"
        Me.picThermometer.Size = New System.Drawing.Size(106, 257)
        Me.picThermometer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThermometer.TabIndex = 7
        Me.picThermometer.TabStop = False
        '
        'frmTemperatureConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 333)
        Me.Controls.Add(Me.picThermometer)
        Me.Controls.Add(Me.radDone)
        Me.Controls.Add(Me.radClear)
        Me.Controls.Add(Me.radCalculate)
        Me.Controls.Add(Me.lblConvertedTemp)
        Me.Controls.Add(Me.lblTempCelcius)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.lblTempFahrenheit)
        Me.Name = "frmTemperatureConverter"
        Me.Text = "Temperature Converter"
        CType(Me.picThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTempFahrenheit As System.Windows.Forms.Label
    Friend WithEvents txtTemperature As System.Windows.Forms.TextBox
    Friend WithEvents lblTempCelcius As System.Windows.Forms.Label
    Friend WithEvents lblConvertedTemp As System.Windows.Forms.Label
    Friend WithEvents radCalculate As System.Windows.Forms.Button
    Friend WithEvents radClear As System.Windows.Forms.Button
    Friend WithEvents radDone As System.Windows.Forms.Button
    Friend WithEvents picThermometer As System.Windows.Forms.PictureBox

End Class
