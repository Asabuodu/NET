Public Class Form1
    Private Sub btnCalculate_Click(Sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim arrayInput As String = txtArray.Text
        Dim k As Integer = CInt(txtk.Text)
        Dim arr() As Integer = Array.ConvertAll(arrayInput.Split(","c), Function(str) CInt(str.Trim()))
        Dim count As Integer = CountDivisiblePairs(arr, k)
        
        txtResult.Text = "Number of divisible pairs: " & count
    End Sub

    Private Function CountDivisiblePairs(ByVal arr() As Integer, ByVal k As Integer) As Integer
        Dim count As Integer = 0
        
        ' Loop through all pairs (i, j) where i < j
        For i As Integer = 0 To arr.Length - 1
            For j As Integer = i + 1 To arr.Length - 1
                ' Check if the sum is divisible by k
                If (arr(i) + arr(j)) Mod k = 0 Then
                    count += 1
                End If
            Next
        Next
        
        Return count
    End Function
End Class