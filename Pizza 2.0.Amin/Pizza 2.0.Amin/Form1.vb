Public Class frmIncrediBullPizza

    'defining variables and constants
    Const dblPepperoni As Double = 1.0
    Const dblBacon As Double = 1.0
    Const dblGroundBeef As Double = 1.0
    Const dblMushroom As Double = 0.75
    Const dblOnions As Double = 0.75
    Const dblGreenPeppers As Double = 0.75
    Const dblSmallPizza As Double = 8.0
    Const dblMediumPizza As Double = 10.0
    Const dblLargePizza As Double = 13.0
    Dim dblPizzaSize As Double
    Dim dblCost As Double
    Dim dblToppings As Double

    Private Sub frmIncrediBullPizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub radSmall_CheckedChanged(sender As Object, e As EventArgs) Handles radSmall.CheckedChanged

        'getting size of pizza
        dblPizzaSize = dblSmallPizza
        'adding size of pizza and toppings
        dblCost = dblPizzaSize + dblToppings
        'displaying cost of pizza
        lblCost.Text = "$" & dblCost.ToString("N2")

    End Sub

    Private Sub lblCost_Click(sender As Object, e As EventArgs) Handles lblCost.Click

    End Sub

    Private Sub chkPepperoni_CheckedChanged(sender As Object, e As EventArgs) Handles chkPepperoni.CheckedChanged

        'if peperoni is checked then
        If chkPepperoni.Checked = True Then
            'adding cost of topping
            dblToppings = dblToppings + dblPepperoni
            'if peperoni is not checked then
        ElseIf chkPepperoni.Checked = False Then
            'subtracting cost of topping
            dblToppings = dblToppings - dblPepperoni
        End If

        'calculating total cost
        dblCost = dblPizzaSize + dblToppings
        'displaying total cost
        lblCost.Text = "$" & dblCost.ToString("N2")

    End Sub

    Private Sub chkBacon_CheckedChanged(sender As Object, e As EventArgs) Handles chkBacon.CheckedChanged

        'if bacon is checked then
        If chkBacon.Checked = True Then
            'adding cost of topping
            dblToppings = dblToppings + dblBacon
            'if bacon is not checked then
        ElseIf chkBacon.Checked = False Then
            'subtracting cost of topping
            dblToppings = dblToppings - dblBacon
        End If

        'calculating total cost
        dblCost = dblPizzaSize + dblToppings
        'displaying total cost
        lblCost.Text = "$" & dblCost.ToString("N2")

    End Sub

    Private Sub chkGroundBeef_CheckedChanged(sender As Object, e As EventArgs) Handles chkGroundBeef.CheckedChanged

        'if ground beef is checked then
        If chkGroundBeef.Checked = True Then
            'adding cost of topping
            dblToppings = dblToppings + dblGroundBeef
            'if ground beef is not checked then
        ElseIf chkGroundBeef.Checked = False Then
            'subtracting cost of topping
            dblToppings = dblToppings - dblGroundBeef
        End If

        'calculating total cost
        dblCost = dblPizzaSize + dblToppings
        'displaying total cost
        lblCost.Text = "$" & dblCost.ToString("N2")

    End Sub

    Private Sub chkMushrooms_CheckedChanged(sender As Object, e As EventArgs) Handles chkMushrooms.CheckedChanged

        'if mushrooms is checked then
        If chkMushrooms.Checked = True Then
            'adding cost of topping
            dblToppings = dblToppings + dblMushroom
            'if mushrooms is not checked then
        ElseIf chkMushrooms.Checked = False Then
            'subtracting cost of topping
            dblToppings = dblToppings - dblMushroom
        End If

        'calculating total cost
        dblCost = dblPizzaSize + dblToppings
        'displaying total cost
        lblCost.Text = "$" & dblCost.ToString("N2")

    End Sub

    Private Sub chkOnions_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnions.CheckedChanged

        'if onions is checked then
        If chkOnions.Checked = True Then
            'adding cost of topping
            dblToppings = dblToppings + dblOnions
            'if onions is not checked then
        ElseIf chkOnions.Checked = False Then
            'subtracting cost of topping
            dblToppings = dblToppings - dblOnions
        End If

        'calculating total cost
        dblCost = dblPizzaSize + dblToppings
        'displaying total cost
        lblCost.Text = "$" & dblCost.ToString("N2")

    End Sub

    Private Sub chkGreenPeppers_CheckedChanged(sender As Object, e As EventArgs) Handles chkGreenPeppers.CheckedChanged

        'if green peppers is checked then
        If chkGreenPeppers.Checked = True Then
            'adding cost of topping
            dblToppings = dblToppings + dblGreenPeppers
            'if green peppers is not checked then
        ElseIf chkGreenPeppers.Checked = False Then
            'subtracting cost of topping
            dblToppings = dblToppings - dblGreenPeppers
        End If

        'calculating total cost
        dblCost = dblPizzaSize + dblToppings
        'displaying total cost
        lblCost.Text = "$" & dblCost.ToString("N2")

    End Sub

    Private Sub radMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radMedium.CheckedChanged

        'getting size of pizza
        dblPizzaSize = dblMediumPizza
        'adding size of pizza and toppings
        dblCost = dblPizzaSize + dblToppings
        'displaying cost of pizza
        lblCost.Text = "$" & dblCost.ToString("N2")

    End Sub

    Private Sub radLarge_CheckedChanged(sender As Object, e As EventArgs) Handles radLarge.CheckedChanged

        'getting size of pizza
        dblPizzaSize = dblLargePizza
        'adding size of pizza and toppings
        dblCost = dblPizzaSize + dblToppings
        'displaying cost of pizza
        lblCost.Text = "$" & dblCost.ToString("N2")

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click

        'clearing radio buttons
        radSmall.Checked = False
        radMedium.Checked = False
        radLarge.Checked = False
        'clearing checkboxes
        chkPepperoni.Checked = False
        chkBacon.Checked = False
        chkGroundBeef.Checked = False
        chkMushrooms.Checked = False
        chkOnions.Checked = False
        chkGreenPeppers.Checked = False
        'clearing total cost
        lblCost.Text = ""

        'clearing pizza size variable
        dblPizzaSize = 0
        'clearing toppings vriable
        dblToppings = 0

    End Sub

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click

        'ending application
        End

    End Sub
End Class
