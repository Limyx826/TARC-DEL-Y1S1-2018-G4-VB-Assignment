'TARUC DEL 2018 Year 1 Semester 1
'Group 4
'Members: Lim Yang Xuan, Seow Zhi Hung, Tan Lin Ee, Tan Wei Hang
'Project: Cinema Booking System
'Date: 19/06/2018

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close Form1
        Close()
    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click

        Label1.Text = "Lim Yang Xuan, Seow Zhi Hung, Tan Lin Ee, Tan Wei Hang"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2.Show()
        Me.Hide()

    End Sub
End Class
