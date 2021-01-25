Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim sngPizza As Single
        Dim sngPeople As Single
        Dim sngTopping As Single
        Const DELIVERY As Integer = 2

        sngPeople = 4.35 * Val(txtPeople.Text)
        sngTopping = 0.75 * Val(txtTopping.Text)

        sngPizza = sngPeople + sngTopping + DELIVERY

        lblPrice.Text = "Price: $" & sngPizza

    End Sub
End Class
