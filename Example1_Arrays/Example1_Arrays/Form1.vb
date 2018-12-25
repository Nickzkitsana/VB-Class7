Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rand As Random = New Random
        Dim numList As String = ""
        Dim number(9) As Integer

        For i = 0 To UBound(number)
            number(i) = rand.Next(0, 2)
            'numList &= number(i) & " "
            numList &= $"{number(i)} "
        Next
        TextBox1.Text = numList

        Dim zero As Integer = 0, one As Integer = 0

        For Each num In number
            If num = 0 Then
                zero = zero + 1
            Else
                one = one + 1
            End If
        Next
        TextBox2.Text = zero
        TextBox3.Text = one

    End Sub
End Class
