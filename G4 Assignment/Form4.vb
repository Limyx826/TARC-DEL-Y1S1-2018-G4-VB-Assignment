Public Class frmMovie
    Private Sub frmMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label18.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        frmHome.Show()
    End Sub
End Class