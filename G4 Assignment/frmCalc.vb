Public Class frmCalc
    'Declare the price of tickets
    Const PrdP As Decimal = 16.0
    Const PrdKP As Decimal = 8.0
    Const StdP As Decimal = 14.0
    Const StdKP As Decimal = 8.0
    Private Total As Decimal

    Private Sub frmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl1.Text = frmCalcTest.APrdTT
        lbl2.Text = frmCalcTest.AStdTT

        lbl1.Visible = True
        lbl2.Visible = True
        lblEaster.Visible = True
        Timer1.Interval = 1500
        Timer1.Start()

        'declare the variables
        Dim PrdST As Decimal
        Dim PrdKST As Decimal
        Dim StdST As Decimal
        Dim StdKST As Decimal

        'Bring in the variable from frmCalcTest
        lblPrdQ.Text = frmCalcTest.APrdQty
        lblPrdKQ.Text = frmCalcTest.APrdKQty
        lblStdQ.Text = frmCalcTest.AStdQty
        lblStdKQ.Text = frmCalcTest.AStdKQty

        'calculation
        PrdST = frmCalcTest.APrdQty * PrdP
        PrdKST = PrdKP * frmCalcTest.APrdKQty
        StdST = StdP * frmCalcTest.AStdQty
        StdKST = StdKP * frmCalcTest.AStdKQty

        'display on the labels
        lblPrdST.Text = PrdST.ToString("C")
        lblPrdKST.Text = PrdKST.ToString("C")
        lblStdST.Text = StdST.ToString("C")
        lblStdKST.Text = StdKST.ToString("C")

        'Total up the sum of prices
        Total = PrdST + PrdKST + StdST + StdKST

        lblTotalP.Text = Total.ToString("C")

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl1.Visible = False
        lbl2.Visible = False
        lblEaster.Visible = False
        Timer1.Stop()
    End Sub
End Class