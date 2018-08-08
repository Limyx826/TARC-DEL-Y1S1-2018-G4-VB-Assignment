Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtId.Text = ""
        txtPw.Text = ""
        txtId.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtId.Text = "Lyxuan" And txtPw.Text = "pnk6035" Then
            Me.Hide()
            Form2.Show()
        Else
            ElseIf txtId.Text = "Lyxuan" Then
            MessageBox.Show("WRONG PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPw.Focus()
            txtPw.SelectAll()
        ElseIf txtPw.Text = "pnk6035" Then
            MessageBox.Show("WRONG STAFF ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId.Focus()
            txtId.SelectAll()
        Else
            MessageBox.Show("WRONG STAFF ID AND PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId.Focus()
            txtId.SelectAll()
        End If

    End Sub
End Class
