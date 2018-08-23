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

    Private Sub btnMembers_Click(sender As Object, e As EventArgs)
        'Show names


    End Sub

    Private Sub btnFilm_Click(sender As Object, e As EventArgs) Handles btnFilm.Click

        members.Show()
        Me.Hide()




    End Sub

    Private Sub btnMemReg_Click(sender As Object, e As EventArgs) Handles btnMemReg.Click
        'show frmMRegister

        frmMRegister.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)

        members.Show()
        Me.Hide()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        Booked.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub ManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageToolStripMenuItem.Click
        Delete.Show()
    End Sub

    Private Sub ChooseFilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChooseFilmToolStripMenuItem.Click
        members.Show()
    End Sub

    Private Sub MemberRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberRegisterToolStripMenuItem.Click
        frmMRegister.Show()
    End Sub

    Private Sub ContactsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactsToolStripMenuItem.Click
        If ContactsToolStripMenuItem.Checked Then
            Label1.Text = "Creator" & ControlChars.NewLine _
                & "Lim Yang Xuan, Seow Zhi Hung, Tan Lin Ee, Tan Wei Hang"
        Else
            Label1.Text = "TARC Cinema"
        End If


    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        frmLogin.Show()
        frmLogin.txtId.Text = ""
        frmLogin.txtPw.Text = ""
    End Sub
End Class
