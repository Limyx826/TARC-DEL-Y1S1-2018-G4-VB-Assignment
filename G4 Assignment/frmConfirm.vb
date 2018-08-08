Public Class frmConfirm
    Dim bookedicon As New System.Drawing.Bitmap(My.Resources.booked)
    Dim seats As Integer = 0
    Dim availableicon As New System.Drawing.Bitmap(My.Resources.Available)
    Dim provisionalicon As New System.Drawing.Bitmap(My.Resources.provisional)
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If frmSeatings.pic85.Image Is My.Resources.provisional Then

            seats = seats + 1
        End If
        Label6.Text = seats
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If frmSeatings.pic85.Image Is provisionalicon Then
            frmSeatings.pic85.Image = bookedicon
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        lstSeat.Items.Add(ComboBox1.Text)
    End Sub
End Class