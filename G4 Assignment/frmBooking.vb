Public Class frmBooking
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox1.Items.Count > 0 Then
            ComboBox1.SelectedIndex = 0
        End If
        If ComboBox2.Items.Count > 0 Then
            ComboBox2.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSeatings.TextBox1.Text = ComboBox2.SelectedIndex
        frmSeatings.TextBox2.Text = ComboBox1.SelectedIndex


        If ComboBox1.SelectedIndex = 0 Then
            MessageBox.Show("Please Select a Time", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        If ComboBox2.SelectedIndex = 0 Then
            MessageBox.Show("Please Select a Theatre number", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If
        If ComboBox1.SelectedIndex > 0 Then
            If ComboBox2.SelectedIndex > 0 Then
                Me.Close()

                frmCalcTest.Show()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub btnCalcDebug_Click(sender As Object, e As EventArgs)

        frmCalcTest.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class