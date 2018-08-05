Public Class frmCalcTest
    Public Shared Property PrdQty As Integer
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        PrdQty = Integer.Parse(TextBox1.Text)

        frmCalc.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Hide()
    End Sub
End Class