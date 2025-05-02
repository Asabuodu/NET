Public Class TemperatureConverter
    Private Sub Button2_Click(Sender As Object, e As EventArgs) Handles Calculation.Click
        Dim Fahrenheit As Double
        Dim result As Double
        
        Fahrenheit = Val(FahrenheitInt.Text)
        result = (Fahrenheit - 32) * 5 / 9
        
        CResult.Text = Format(Round(result, 2)) & "°C"
    End Sub

    Private Function Round(result As Double, v As Integer) As Object
        Return Math.Round(result, 2)
    End Function

    Private Sub Button2_Click_1(Sender As Object, e As EventArgs) Handles Button2.Click
        FahrenheitInt.Text = ""
        CResult.Text = ""
    End Sub

    Private Sub Button3_Click(Sender As Object, e As EventArgs) Handles Button3.Click
        ' Edit functionality would go here
    End Sub
End Class