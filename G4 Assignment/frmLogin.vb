Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtId.Text = ""
        txtPw.Text = ""
        txtId.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Welcome back, ", "Hi", MessageBoxButtons.OK, MessageBoxIcon.None)

        Me.Hide()
        frmHome.Show()
    End Sub
End Class
