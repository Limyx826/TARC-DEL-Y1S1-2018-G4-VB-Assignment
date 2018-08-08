Option Strict Off
Public Class frmMRegister
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Close()
    End Sub
    Private Sub btnCheck_Click(sender As Object, e As EventArgs)
        TxtPass.Copy()
    End Sub



    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
            And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            picno1.Visible = True
            picyes1.Visible = False
        End If
    End Sub

    Private Sub btnCheck_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtCon.Text.ToUpper() = TxtPass.Text.ToUpper() Then
            picyes7.Visible = True
            picno7.Visible = False
        Else
            picyes7.Visible = False
            picno7.Visible = True
            txtCon.Focus()
            txtCon.SelectAll()

        End If
        If TxtPass.TextLength < 7 Then
            picno6.Visible = True
            picyes6.Visible = False
            TxtPass.Focus()
            TxtPass.SelectAll()
            lblb.Text = "At Least 7 Charaters"
        Else
            picno6.Visible = False
            picyes6.Visible = True
            lblb.Text = ""
        End If

        If txtID.TextLength < 6 Then
            picyes5.Visible = False
            picno5.Visible = True
            txtID.Focus()
            txtID.SelectAll()
            lbla.Text = "At Least 6 Charaters"

        Else
            picyes5.Visible = True
            picno5.Visible = False
            lbla.Text = ""
        End If
        If Not MskIC.MaskFull Then
            picno3.Visible = True
            picyes3.Visible = False
            MskIC.Focus()
            MskIC.SelectAll()
        Else
            picyes3.Visible = True
            picno3.Visible = False

        End If

        If Not MksBirth.MaskFull Then
            picno2.Visible = True
            picyes2.Visible = False
            MksBirth.Focus()
            MksBirth.SelectAll()
        Else
            picno2.Visible = False
            picyes2.Visible = True

        End If
        If txtName.TextLength < 3 Then
            picno1.Visible = True
            picyes1.Visible = False
            txtName.Focus()
            txtName.SelectAll()
            lblc.Text = "At Least 3 Charaters"
        Else
            picyes1.Visible = True
            picno1.Visible = False
            lblc.Text = ""
        End If
        Dim a As Boolean = False Or True
        If picno1.Visible = True Then
            a = False
        ElseIf picno2.Visible = True Then
            a = False
        ElseIf picno3.Visible = True Then
            a = False
        ElseIf picno5.Visible = True Then
            a = False
        ElseIf picno6.Visible = True Then
            a = False
        ElseIf picno7.Visible = True Then
            a = False
        End If
        If a = False Then
            MessageBox.Show("Somethings Error !!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Thank you for register !!!", "Member Registration", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            frmHome.Show()
            Me.Close()
        End If
    End Sub
End Class