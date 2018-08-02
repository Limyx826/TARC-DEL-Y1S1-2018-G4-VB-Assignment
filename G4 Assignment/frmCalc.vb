Public Class frmCalc
    'Private 
    Private Sub frmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEaster.Visible = True
        Timer1.Interval = 5000
        Timer1.Start()
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