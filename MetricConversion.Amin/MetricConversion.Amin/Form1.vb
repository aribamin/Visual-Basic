Public Class frmMetricConversion

    'defining variables
    Dim dblNumIn As Double
    Dim dblNumOut As Double

    Private Sub cmdInchesToCm_Click(sender As Object, e As EventArgs) Handles cmdInchesToCm.Click

        'getting user number
        dblNumIn = txtNumber.Text
        'converting inches to centimeters
        dblNumOut = InchesToCm(dblNumIn)
        'displaying conversion to two decimal places
        lblAnswer.Text = Math.Round(dblNumOut, 2)

    End Sub

    Private Sub cmdCmToInches_Click(sender As Object, e As EventArgs) Handles cmdCmToInches.Click

        'getting user number
        dblNumIn = txtNumber.Text
        'converting centimeters to inches
        dblNumOut = CmToInches(dblNumIn)
        'displaying conversion to two decimal places
        lblAnswer.Text = Math.Round(dblNumOut, 2)

    End Sub

    Private Sub cmdFeetToCm_Click(sender As Object, e As EventArgs) Handles cmdFeetToCm.Click

        'getting user number
        dblNumIn = txtNumber.Text
        'converting feet to centiemeters
        dblNumOut = FeetToCm(dblNumIn)
        'displaying conversion to two decimal places
        lblAnswer.Text = Math.Round(dblNumOut, 2)

    End Sub

    Private Sub cmdCmToFeet_Click(sender As Object, e As EventArgs) Handles cmdCmToFeet.Click

        'getting user number
        dblNumIn = txtNumber.Text
        'converting centimeters to feet
        dblNumOut = CmToFeet(dblNumIn)
        'displaying conversion to two decimal places
        lblAnswer.Text = Math.Round(dblNumOut, 2)

    End Sub

    Private Sub cmdYardsToMeters_Click(sender As Object, e As EventArgs) Handles cmdYardsToMeters.Click

        'getting user number
        dblNumIn = txtNumber.Text
        'converting yards to meters
        dblNumOut = YardsToMeters(dblNumIn)
        'displaying conversion to two decimal places
        lblAnswer.Text = Math.Round(dblNumOut, 2)

    End Sub

    Private Sub cmdMetersToYards_Click(sender As Object, e As EventArgs) Handles cmdMetersToYards.Click

        'getting user number
        dblNumIn = txtNumber.Text
        'converting meters to yards
        dblNumOut = MetersToYards(dblNumIn)
        'displaying conversion to two decimal places
        lblAnswer.Text = Math.Round(dblNumOut, 2)

    End Sub

    Private Sub cmdMilesToKm_Click(sender As Object, e As EventArgs) Handles cmdMilesToKm.Click

        'getting user number
        dblNumIn = txtNumber.Text
        'converting miles to kilometers
        dblNumOut = MilesToKm(dblNumIn)
        'displaying conversion to two decimal places
        lblAnswer.Text = Math.Round(dblNumOut, 2)

    End Sub

    Private Sub cmdKmToMiles_Click(sender As Object, e As EventArgs) Handles cmdKmToMiles.Click

        'getting user number
        dblNumIn = txtNumber.Text
        'converting kilometers to miles
        dblNumOut = KmToMiles(dblNumIn)
        'displaying conversion to two decimal places
        lblAnswer.Text = Math.Round(dblNumOut, 2)

    End Sub

    Function InchesToCm(ByVal dblInchesToCm As Double) As Double

        'converting inches to centimeters
        InchesToCm = dblInchesToCm * 2.54

    End Function

    Function CmToInches(ByVal dblCmToInches As Double) As Double

        'converting centimeters to inches
        CmToInches = dblCmToInches / 2.54

    End Function

    Function FeetToCm(ByVal dblFeetToCm As Double) As Double

        'converting feet to centimeters
        FeetToCm = dblFeetToCm * 30

    End Function

    Function CmToFeet(ByVal dblCmToFeet As Double) As Double

        'converting centimeters to feet
        CmToFeet = dblCmToFeet / 30

    End Function

    Function YardsToMeters(ByVal dblYardsToMeters As Double) As Double

        'coverting yards to meters
        YardsToMeters = dblYardsToMeters * 0.9144

    End Function

    Function MetersToYards(ByVal dblMetersToYards As Double) As Double

        'convertig meters to yards
        MetersToYards = dblMetersToYards / 0.9144

    End Function

    Function MilesToKm(ByVal dblMilesToKm As Double) As Double

        'converting miles to kilometers
        MilesToKm = dblMilesToKm * 1.6

    End Function

    Function KmToMiles(ByVal dblKmToMiles As Double) As Double

        'converting kilometers to miles
        KmToMiles = dblKmToMiles / 1.6

    End Function

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click

        'ending program
        End

    End Sub
End Class
