Public Class frmCalc
    'Declare the price of tickets


    Private Sub frmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim A As Double = frmCalcTest.TextBox1.Text
        Dim B As Double = frmCalcTest.TextBox2.Text
        Dim C As Double = frmCalcTest.TextBox3.Text
        Dim D As Double = frmCalcTest.TextBox4.Text
        Dim PrdP As Integer
        Dim PrdKP As Integer
        Dim StdP As Integer
        Dim StdKP As Integer
        Dim totalqty As Integer
        Label2.Text = A
        Label3.Text = B
        Label4.Text = C
        Label5.Text = D
        totalqty = A + B + C + D

        Label6.Text = (totalqty)


        PrdP = A * 8
        TextBox1.Text = (PrdP)
        TextBox1.Text = PrdP.ToString("C")
        PrdKP = B * 6

        TextBox2.Text = (PrdKP)
        TextBox2.Text = PrdKP.ToString("C")
        StdP = C * 10

        TextBox3.Text = (StdP)
        TextBox3.Text = StdP.ToString("C")
        StdKP = D * 8
        TextBox4.Text = (StdKP)
        TextBox4.Text = StdKP.ToString("C")

        Dim Total As Double

        Total = PrdP + PrdKP + StdP + StdKP
        TextBox5.Text = (Total)
        TextBox5.Text = Total.ToString("C")
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblEaster.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub lblPrdP_Click(sender As Object, e As EventArgs) Handles lblPrdP.Click

    End Sub
End Class