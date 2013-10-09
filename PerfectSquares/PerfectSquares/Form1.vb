Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        Dim n As Integer = 1

        Do While (n <= 10)


            lstResult.Items.Add(n ^ 2)
            n += 1
        Loop
        'lstResult.Items.Clear()
        'lstResult.Items.Add("Not implemented yet")

    End Sub
End Class
