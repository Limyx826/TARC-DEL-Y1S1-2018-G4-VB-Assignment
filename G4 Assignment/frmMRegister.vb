Option Strict Off
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
        If txtCon.Text = TxtPass.Text Then
            picno7.Visible = False
            picyes7.Visible = True

            If TxtPass.TextLength < 7 Then
                picno6.Visible = True
                picyes6.Visible = False
                TxtPass.Focus()
                TxtPass.SelectAll()
                LabelC.Text = "At Least 7 Characters"
                If txtID.TextLength < 6 Then
                    picyes5.Visible = False
                    picno5.Visible = True
                    txtID.Focus()
                    txtID.SelectAll()
                    LabelB.Text = "At Least 6 Characters"
                    If Not MskIC.MaskFull Then
                        picno3.Visible = True
                        picyes3.Visible = False
                        MskIC.Focus()

                        If Not MksBirth.MaskFull Then
                            picno2.Visible = True
                            picyes2.Visible = False
                            MksBirth.Focus()
                            If txtName.TextLength < 3 Then
                                picno1.Visible = True
                                picyes1.Visible = False
                                txtName.Focus()
                                txtName.SelectAll()
                                LabelA.Text = "At Least 3 Characters"
                            Else
                                picyes1.Visible = True
                                picno1.Visible = False
                            End If
                        Else
                            picno2.Visible = False
                            picyes2.Visible = True
                        End If
                    Else
                        picyes3.Visible = True
                        picno3.Visible = False
                    End If
                Else
                    picyes5.Visible = True
                    picno5.Visible = False

                End If
            Else
                picno6.Visible = False
                picyes6.Visible = True
            End If
        End If
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
            MessageBox.Show("Check Your Information")
        Else
            MessageBox.Show("Thank you for register !!!")
            Me.Close()
            frmHome.Show()
        End If
    End Sub

    Private Sub btnCheck_Click_1(sender As Object, e As EventArgs) Handles btnCheck.Click






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