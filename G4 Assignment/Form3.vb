﻿Option Strict Off
Public Class frmMRegister
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TxtPass.Text = txtCon.Text Then
            picno7.Visible = False
            picyes7.Visible = True
        Else
            picno7.Visible = True
            picyes7.Visible = False
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmHome.Show()
    End Sub
    Private Sub btnCheck_Click(sender As Object, e As EventArgs)
        TxtPass.Copy()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim a As Boolean = False
        If picno1.Visible = True Then
            a = False
        End If
        If picno2.Visible = True Then
            a = False
        End If
        If picno3.Visible = True Then
            a = False
        End If
        If picno5.Visible = True Then
            a = False
        End If
        If picno6.Visible = True Then
            a = False
        End If
        If a = False Then
            MessageBox.Show("Please fill all empty space !!!")
        Else
            MessageBox.Show("Thank you for register !!!")
            Me.Close()
            frmHome.Show()
        End If
    End Sub

    Private Sub btnCheck_Click_1(sender As Object, e As EventArgs) Handles btnCheck.Click
        If txtName.Text = "" Then
            picno1.Visible = True
            picyes1.Visible = False
            txtName.Focus()
        Else
            picyes1.Visible = True
            picno1.Visible = False
        End If
        If TxtPass.Text = "" Then
            picno6.Visible = True
            picyes6.Visible = False
            TxtPass.Focus()
        Else
            picno6.Visible = False
            picyes6.Visible = True
        End If
        If txtID.Text = "" Then
            picyes5.Visible = False
            picno5.Visible = True
            txtID.Focus()
        Else
            picyes5.Visible = True
            picno5.Visible = False

        End If
        If Not MskIC.MaskFull Then
            picno3.Visible = True
            picyes3.Visible = False
            MskIC.Focus()
        Else
            picyes3.Visible = True
            picno3.Visible = False
        End If
        If Not MksBirth.MaskFull Then
            picno2.Visible = True
            picyes2.Visible = False
            MksBirth.Focus()
        Else
            picno2.Visible = False
            picyes2.Visible = True
        End If


    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            picno1.Visible = True
            picyes1.Visible = False
        End If
    End Sub
End Class