Public Class FutureValueCalculator
    Private Const V As String = " €"
    
    Private Sub Button1_Click(Sender As Object, e As EventArgs) Handles Button1.Click
        Dim initial As Double
        Dim interestR As Double
        Dim period As Double
        Dim Value As Double
        
        initial = Val(TextBox1.Text)
        interestR = Val(TextBox2.Text)
        period = Val(TextBox3.Text)
        
        Value = initial * (1 + interestR / 100) ^ period
        TextBox4.Text = Format(Math.Round(Value, 2)) & V
    End Sub

    Private Sub Button2_Click(Sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(Sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class