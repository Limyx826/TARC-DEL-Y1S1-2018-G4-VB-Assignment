Public Class Seatings

    Dim availableicon As New System.Drawing.Bitmap(My.Resources.Available)
    Dim provisionalicon As New System.Drawing.Bitmap(My.Resources.provisional)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = availableicon
            End If
        Next

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click, PictureBox11.Click, PictureBox12.Click, PictureBox13.Click, PictureBox14.Click, PictureBox15.Click, PictureBox16.Click, PictureBox17.Click, PictureBox18.Click, PictureBox19.Click, PictureBox21.Click, PictureBox22.Click, PictureBox23.Click, PictureBox24.Click, PictureBox25.Click, PictureBox26.Click, PictureBox27.Click, PictureBox28.Click, PictureBox29.Click, PictureBox31.Click, PictureBox32.Click, PictureBox33.Click, PictureBox34.Click, PictureBox35.Click, PictureBox36.Click, PictureBox37.Click, PictureBox38.Click, PictureBox39.Click, PictureBox41.Click, PictureBox42.Click, PictureBox43.Click, PictureBox44.Click, PictureBox45.Click, PictureBox46.Click, PictureBox47.Click, PictureBox48.Click, PictureBox49.Click, PictureBox51.Click, PictureBox52.Click, PictureBox53.Click, PictureBox54.Click, PictureBox55.Click, PictureBox56.Click, PictureBox57.Click, PictureBox58.Click, PictureBox59.Click, PictureBox61.Click, PictureBox62.Click, PictureBox63.Click, PictureBox64.Click, PictureBox65.Click, PictureBox66.Click, PictureBox67.Click, PictureBox68.Click, PictureBox69.Click, PictureBox71.Click, PictureBox72.Click, PictureBox73.Click, PictureBox74.Click, PictureBox75.Click, PictureBox76.Click, PictureBox77.Click, PictureBox78.Click, PictureBox79.Click, PictureBox81.Click, PictureBox82.Click, PictureBox83.Click, PictureBox84.Click, pic1.Click, pic2.Click, pic3.Click, pic4.Click, pic5.Click, PictureBox91.Click, PictureBox92.Click, PictureBox93.Click, PictureBox94.Click, PictureBox95.Click, PictureBox96.Click, PictureBox70.Click, PictureBox80.Click, pic6.Click, PictureBox10.Click, PictureBox20.Click, PictureBox30.Click, PictureBox40.Click, PictureBox50.Click, PictureBox60.Click

        If CType(sender, PictureBox).Image Is availableicon Then
            CType(sender, PictureBox).Image = provisionalicon
        ElseIf CType(sender, PictureBox).Image Is provisionalicon Then
            CType(sender, PictureBox).Image = availableicon
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        If CType(sender, PictureBox).Image Is availableicon Then
            CType(sender, PictureBox).Image = provisionalicon
        ElseIf CType(sender, PictureBox).Image Is provisionalicon Then
            CType(sender, PictureBox).Image = availableicon
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim photo As Object

        Dim num As Integer = 1
        Do While num <= 6
            photo = "pic" & num
            If photo.Image = My.Resources.provisional Then
                frmConfirm.lstSeat.Items.Add("Seat " & num)
            End If
            'update num
            num += 1
        Loop

        frmConfirm.Show()
    End Sub
End Class
