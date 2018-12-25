Public Class Form1
    Private Sub btnnum_Click(sender As Object, e As EventArgs) Handles btnnum.Click
        Dim text As String = TextBox1.Text
        Dim Num() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim NumThai() As String = {"๐", "๑", "๒", "๓", "๔", "๕", "๖", "๗", "๘", "๙"}
        Dim label As String = ""

        For Each w In text
            For Each v In Num
                If w = v Then
                    label &= $"{NumThai(v)} "
                    Exit For
                End If
            Next
        Next

        Label1.Text = label


    End Sub

    Private Sub btntext_Click(sender As Object, e As EventArgs) Handles btntext.Click
        Dim text As String = TextBox1.Text
        Dim Num() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim TextThai() As String = {"ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า"}
        Dim label As String = ""

        For Each w In text
            For Each v In Num
                If w = v Then
                    label &= $"{TextThai(v)} "
                    Exit For
                End If
            Next
        Next

        Label1.Text = label



    End Sub

    Private Sub btntext_TextChanged(sender As Object, e As EventArgs) Handles btntext.TextChanged, btnnum.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim text As String = TextBox1.Text


        btnnum.Enabled = True
        btntext.Enabled = True

        If text.Length = 0 Then
            btnnum.Enabled = False
            btntext.Enabled = False
            Label1.Text = ""
        End If

    End Sub
End Class
