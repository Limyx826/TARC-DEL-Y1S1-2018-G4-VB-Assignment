Public Class frmCalcTest
    Public Shared Property APrdQty As Integer
    Public Shared Property APrdKQty As Integer
    Public Shared Property AStdQty As Integer
    Public Shared Property AStdKQty As Integer
    Public Shared Property APrdTT As Integer
    Public Shared Property AStdTT As Integer

    Dim lbl5, lbl6, lbl7, lbl8 As Integer
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        APrdQty = Integer.Parse(Label5.Text)
        APrdKQty = Integer.Parse(Label6.Text)
        AStdQty = Integer.Parse(Label7.Text)
        AStdKQty = Integer.Parse(Label8.Text)

        APrdTT = APrdQty + APrdKQty
        AStdTT = AStdQty + AStdKQty

        frmSeatings.TextBox4.Text = lblFilmTitle.Text
        frmSeatings.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub btTT_Click(sender As Object, e As EventArgs) Handles btTT.Click
        APrdQty = Integer.Parse(Label5.Text)
        APrdKQty = Integer.Parse(Label6.Text)
        AStdQty = Integer.Parse(Label7.Text)
        AStdKQty = Integer.Parse(Label8.Text)

        'To calculate total
        Dim TT As Integer
        TT = APrdQty + APrdKQty + AStdQty + AStdKQty
        btTT.Text = TT
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        lbl5 += 1
        Label5.Text = lbl5
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        lbl7 += 1
        Label7.Text = lbl7
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lbl6 += 1
        Label6.Text = lbl6
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        lbl8 += 1
        Label8.Text = lbl8
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        lbl5 -= 1
        Label5.Text = lbl5
        If Label5.Text < 0 Then
            Label5.Text = 0
            lbl5 = 0
            MessageBox.Show("Input error!", "input error", MessageBoxButtons.OK)


        End If
    End Sub



    Private Sub frmCalcTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = members.TextBox1.Text
        If TextBox1.Text = "" Then
            btn4.Visible = False
            btn1.Visible = False
            btn2.Visible = False
            btn3.Visible = False
        Else
            btn5.Visible = False
            btn6.Visible = False
            btn7.Visible = False
            btn8.Visible = False
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        lbl7 -= 1
        Label7.Text = lbl7
        If Label7.Text < 0 Then
            Label7.Text = 0
            lbl7 = 0
            MessageBox.Show("Input error!", "input error", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lbl6 -= 1
        Label6.Text = lbl6
        If Label6.Text < 0 Then
            Label6.Text = 0
            lbl6 = 0
            MessageBox.Show("Input error!", "input error", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        lbl8 -= 1
        Label8.Text = lbl8
        If Label8.Text < 0 Then
            Label8.Text = 0
            lbl8 = 0
            MessageBox.Show("Input error!", "input error", MessageBoxButtons.OK)

        End If
    End Sub
End Class