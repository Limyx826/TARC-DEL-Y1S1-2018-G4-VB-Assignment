Public Class frmCalcTest
    Public Shared Property APrdQty As Integer
    Public Shared Property APrdKQty As Integer
    Public Shared Property AStdQty As Integer
    Public Shared Property AStdKQty As Integer
    Public Shared Property APrdTT As Integer
    Public Shared Property AStdTT As Integer
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            APrdQty = Integer.Parse(TextBox1.Text)
            Try
                APrdKQty = Integer.Parse(TextBox2.Text)
                Try
                    AStdQty = Integer.Parse(TextBox3.Text)
                    Try
                        AStdKQty = Integer.Parse(TextBox4.Text)
                    Catch ex As Exception
                        MessageBox.Show("Enter correct input", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        TextBox4.Focus()
                        TextBox4.SelectAll()
                        Exit Sub
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Enter correct input", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    TextBox3.Focus()
                    TextBox3.SelectAll()
                    Exit Sub
                End Try
            Catch ex As Exception
                MessageBox.Show("Enter correct input", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TextBox2.Focus()
                TextBox2.SelectAll()
                Exit Sub
            End Try

        Catch ex As Exception
            MessageBox.Show("Enter correct input", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End Try

        APrdTT = APrdQty + APrdKQty
        AStdTT = AStdQty + AStdKQty

        frmSeatings.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub btTT_Click(sender As Object, e As EventArgs) Handles btTT.Click
        Try
            APrdQty = Integer.Parse(TextBox1.Text)
            Try
                APrdKQty = Integer.Parse(TextBox2.Text)
                Try
                    AStdQty = Integer.Parse(TextBox3.Text)
                    Try
                        AStdKQty = Integer.Parse(TextBox4.Text)
                    Catch ex As Exception
                        MessageBox.Show("Enter correct input", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        TextBox4.Focus()
                        TextBox4.SelectAll()
                        Exit Sub
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Enter correct input", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    TextBox3.Focus()
                    TextBox3.SelectAll()
                    Exit Sub
                End Try
            Catch ex As Exception
                MessageBox.Show("Enter correct input", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                TextBox2.Focus()
                TextBox2.SelectAll()
                Exit Sub
            End Try

        Catch ex As Exception
            MessageBox.Show("Enter correct input", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End Try

        'To calculate total
        Dim TT As Integer
        TT = APrdQty + APrdKQty + AStdQty + AStdKQty
        btTT.Text = TT
    End Sub
End Class