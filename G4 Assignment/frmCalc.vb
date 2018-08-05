Public Class frmCalc
    Const PrdP As Integer = 16
    Const PrdKP As Integer = 8
    Const StdP As Integer = 14
    Const StdKP As Integer = 8
    Private Total As Decimal

    Private Sub frmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEaster.Visible = True
        Timer1.Interval = 5000
        Timer1.Start()

        lblPrdQ.Text = frmCalcTest.PrdQty

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblEaster.Visible = False
        Timer1.Stop()
    End Sub
End Class