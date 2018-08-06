Public Class frmLogin
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

        If txtId.Text.ToUpper() = "ISISKO" And txtPw.Text.ToUpper() = "PNK6035" Then
            MessageBox.Show("Welcome Back", "Hello", MessageBoxButtons.OK, MessageBoxIcon.None)
            Me.Hide()
            frmHome.Show()
        ElseIf txtId.Text.ToUpper() = "ISISKO" Then
            MessageBox.Show("Wrong Password", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPw.Focus()
            txtPw.SelectAll()
        ElseIf txtPw.Text.ToUpper() = "PNK6035" Then
            MessageBox.Show("Wrong ID", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId.Focus()
            txtId.SelectAll()
        Else
            MessageBox.Show("Wrong ID And Password", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId.Focus()
            txtId.SelectAll()
            Exit Sub
        End If
    End Sub
End Class
