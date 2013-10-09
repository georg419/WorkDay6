Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim pop As Double = 7000000000.0
        Dim year As Integer = 2012
        Do While pop > 6000000.0
            pop = pop / 2
            year = year - 50

        Loop


        MessageBox.Show(CStr(year))

    End Sub
End Class
