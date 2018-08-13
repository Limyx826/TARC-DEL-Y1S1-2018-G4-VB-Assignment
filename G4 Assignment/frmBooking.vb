Public Class frmBooking
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnProceed.Click
        frmCalcTest.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub btnCalcDebug_Click(sender As Object, e As EventArgs) Handles btnCalcDebug.Click

        frmCalcTest.Show()
        Me.Close()
    End Sub
End Class