'TARUC DEL 2018 Year 1 Semester 1
'Group 4
'Members: Lim Yang Xuan, Seow Zhi Hung, Tan Lin Ee, Tan Wei Hang
'Project: Cinema Booking System
'Date: 19/06/2018

Public Class frmHome
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit application

        Application.Exit()
        End
    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        'Show names

        Label1.Text = "Lim Yang Xuan, Seow Zhi Hung, Tan Lin Ee, Tan Wei Hang"
    End Sub

    Private Sub btnFilm_Click(sender As Object, e As EventArgs) Handles btnFilm.Click
        'Show frmMovie

        frmMovie.Show()
        Me.Hide()

    End Sub

    Private Sub btnMemReg_Click(sender As Object, e As EventArgs) Handles btnMemReg.Click
        'show frmMRegister

        frmMRegister.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)

        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        frmLogin.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
