Public Class frmTemperatureConverter

    Private Sub radCalculate_Click(sender As Object, e As EventArgs) Handles radCalculate.Click
        'declaring variable for fahrenheit
        Dim dblFahrenheit As Double
        'declaring variable for celcius
        Dim dblCelcius As Double

        'recieving temperature in fahrenheit from user
        dblFahrenheit = txtTemperature.Text
        'converting tmeperautre from fahrenheit to celcius
        dblCelcius = 5 / 9 * (dblFahrenheit - 32)
        'displaying converted temperature in celcius to one decimal
        lblConvertedTemp.Text = Math.Round(dblCelcius, 1)
        'didsplaying label for temperature in celcius
        lblTempCelcius.Text = "The temperature in celcius is:"

        'making picturebox and image visible
        picThermometer.Visible = True
        'displaying image of thermometer
        picThermometer.Image = My.Resources.thermometer
    End Sub

    Private Sub radClear_Click(sender As Object, e As EventArgs) Handles radClear.Click
        'clearing label for temperature in celius
        lblTempCelcius.Text = ""
        'clearing label for converted temperature
        lblConvertedTemp.Text = ""
        'clearing fahrenheit temperature from user
        txtTemperature.Text = ""
        'removing image of thermometer
        picThermometer.Visible = False
    End Sub

    Private Sub radDone_Click(sender As Object, e As EventArgs) Handles radDone.Click
        'ending application
        End
    End Sub
End Class
