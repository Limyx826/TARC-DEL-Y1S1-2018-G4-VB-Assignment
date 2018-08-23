Public Class frmMovie
    Private Sub frmMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label18.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub Book()
        frmBooking.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub btnCine1_Click(sender As Object, e As EventArgs) Handles btnCine1.Click
        frmCalcTest.lblFilmTitle.Text = Label8.Text
        Book()
    End Sub

    Private Sub btnCine2_Click(sender As Object, e As EventArgs) Handles btnCine2.Click
        frmCalcTest.lblFilmTitle.Text = Label9.Text
        Book()
    End Sub

    Private Sub btnCine3_Click(sender As Object, e As EventArgs) Handles btnCine3.Click
        frmCalcTest.lblFilmTitle.Text = Label6.Text
        Book()
    End Sub

    Private Sub btnCine4_Click(sender As Object, e As EventArgs) Handles btnCine4.Click
        frmCalcTest.lblFilmTitle.Text = Label7.Text
        Book()
    End Sub

    Private Sub btnCine5_Click(sender As Object, e As EventArgs) Handles btnCine5.Click
        frmCalcTest.lblFilmTitle.Text = Label10.Text
        Book()
    End Sub

    Private Sub btnCine6_Click(sender As Object, e As EventArgs) Handles btnCine6.Click
        frmCalcTest.lblFilmTitle.Text = Label13.Text
        Book()
    End Sub

    Private Sub btnCine7_Click(sender As Object, e As EventArgs) Handles btnCine7.Click
        frmCalcTest.lblFilmTitle.Text = Label2.Text
        Book()
    End Sub

    Private Sub btnCine8_Click(sender As Object, e As EventArgs) Handles btnCine8.Click
        frmCalcTest.lblFilmTitle.Text = Label3.Text
        Book()
    End Sub


End Class