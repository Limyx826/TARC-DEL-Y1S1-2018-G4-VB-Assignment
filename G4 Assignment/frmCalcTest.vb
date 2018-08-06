Public Class frmCalcTest
    Public Shared Property APrdQty As Integer
    Public Shared Property APrdKQty As Integer
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        APrdQty = Integer.Parse(TextBox1.Text)
        APrdKQty = Integer.Parse(Label2.Text)

        frmCalc.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Hide()
    End Sub
End Class