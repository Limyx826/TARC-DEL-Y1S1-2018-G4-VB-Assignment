Imports System.Data.OleDb

Public Class frmSeatings
    Dim strConString As String = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\COMPLETE\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"
    Dim availableicon As New System.Drawing.Bitmap(My.Resources.Available)
    Dim provisionalicon As New System.Drawing.Bitmap(My.Resources.provisional)
    Dim bookedIcon As New System.Drawing.Bitmap(My.Resources.Booked)

    Dim count As Integer = 0
    Dim total As Double
    Dim bookcount As Double
    Dim txt1 As Double
    Dim txt2 As Double
    Dim txt3 As Double
    Dim txt4 As Double
    Dim F As Double


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = availableicon
            End If
        Next



        strConString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\COMPLETE\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"
        Dim conBooking As OleDbConnection

        conBooking = New OleDbConnection
        conBooking.ConnectionString = strConString
        conBooking.Open()



        Dim cmdSelectBooking As OleDbCommand
        Dim dr As OleDbDataReader
        cmdSelectBooking = New OleDbCommand("SELECT * From Booking", conBooking)


        cmdSelectBooking.ExecuteNonQuery()

        Dim dsBooking As New DataSet
        Dim daBooking As New OleDbDataAdapter(cmdSelectBooking)
        daBooking.Fill(dsBooking, "Booking")



        Dim t1 As DataTable = dsBooking.Tables("Booking")
        Dim row As DataRow

        Dim MovieType As String = TextBox4.Text
        Dim MovieTime As Integer = TextBox2.Text
        Dim theatreNo As Integer = TextBox1.Text
        For Each row In t1.Rows
            If row(3) = MovieType Then
                If row(4) = MovieTime Then
                    If row(5) = theatreNo Then

                        CType(Controls("pic" & row(1)), PictureBox).Image = bookedIcon
                    End If

                End If
            End If

        Next

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic85.Click, pic86.Click, pic87.Click, pic88.Click, pic89.Click, pic90.Click, pic91.Click, pic92.Click, pic93.Click, pic95.Click, pic96.Click, pic73.Click, pic74.Click, pic75.Click, pic76.Click, pic77.Click, pic78.Click, pic84.Click, pic82.Click, pic81.Click, pic80.Click, pic79.Click, pic61.Click, pic62.Click, pic63.Click, pic64.Click, pic65.Click, pic67.Click, pic68.Click, pic69.Click, pic70.Click, pic71.Click, pic72.Click, pic49.Click, pic50.Click, pic51.Click, pic53.Click, pic54.Click, pic55.Click, pic56.Click, pic57.Click, pic58.Click, pic59.Click, pic60.Click, pic37.Click, pic39.Click, pic40.Click, pic41.Click, pic42.Click, pic43.Click, pic44.Click, pic45.Click, pic46.Click, pic47.Click, pic25.Click, pic26.Click, pic27.Click, pic28.Click, pic29.Click, pic30.Click, pic31.Click, pic32.Click, pic33.Click, pic35.Click, pic36.Click, pic13.Click, pic14.Click, pic15.Click, pic16.Click, pic17.Click, pic18.Click, pic19.Click, pic21.Click, pic22.Click, pic23.Click, pic24.Click, pic1.Click, pic2.Click, pic3.Click, pic4.Click, pic5.Click, pic7.Click, pic8.Click, pic9.Click, pic10.Click, pic11.Click, pic12.Click, pic34.Click, pic20.Click, pic6.Click, pic94.Click, pic83.Click, pic66.Click, pic52.Click, pic38.Click, pic48.Click

        Dim A = frmCalcTest.APrdQty
        Dim B = frmCalcTest.APrdKQty
        Dim C = frmCalcTest.AStdQty
        Dim D = frmCalcTest.AStdKQty
        Dim totalqty As Integer



        totalqty = A + B + C + D
        Label31.Text = (totalqty)


        If F >= totalqty Then
            F = F + 0
            If CType(sender, PictureBox).Image Is provisionalicon Then
                CType(sender, PictureBox).Image = availableicon
                F = F - 1
                Label30.Text = (F)

            End If
        ElseIf F <= totalqty Then

            If CType(sender, PictureBox).Image Is availableicon Then
                F = F + 1
                Label30.Text = (F)

                CType(sender, PictureBox).Image = provisionalicon
            ElseIf CType(sender, PictureBox).Image Is provisionalicon Then
                CType(sender, PictureBox).Image = availableicon
                F = F - 1
                Label30.Text = (F)


            End If

            'ElseIf CType(sender, PictureBox).Image Is provisionalicon Then


            If CType(sender, PictureBox).Image Is availableicon Then
            End If

        End If
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim c As Control

        ' Dim count As Integer = 0

        'Dim bSelected As Boolean
        'If bSelected = False Then
        ' MsgBox(" Please Select at least 1 seat")
        'Else
        Dim MovieType As String = TextBox4.Text
        Dim name As String = TextBox3.Text
        Dim MovieTime As Integer = TextBox2.Text
        Dim theatreNo As Integer = TextBox1.Text
        Dim i As Integer
        For i = 1 To 96
            If CType(Controls("pic" & i), PictureBox).Image Is provisionalicon Then

                Dim cmdMakeBooking As OleDbCommand
                Dim conBooking As OleDbConnection
                conBooking = New OleDbConnection
                cmdMakeBooking = New OleDbCommand


                conBooking.ConnectionString = strConString
                conBooking.Open()
                cmdMakeBooking = New OleDbCommand("INSERT INTO Booking (Customers, Seats, Movies, MovieTime, TheatreNo) VALUES( '" & name & "', '" & i & "','" & MovieType & "','" & MovieTime & "','" & theatreNo & "' )", conBooking)


                cmdMakeBooking.ExecuteNonQuery()
                ' count = count + 1

            End If

        Next
        Dim A = frmCalcTest.APrdQty
        Dim B = frmCalcTest.APrdKQty
        Dim C = frmCalcTest.AStdQty
        Dim D = frmCalcTest.AStdKQty
        Dim totalqty As Integer

        totalqty = A + B + C + D
        If F < totalqty Then
            MessageBox.Show("Please choose exactly '" & totalqty & "' seats")
        Else

            frmCalc.Show()
            Me.Close()

        End If


    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        frmHome.Show()
        Me.Close()
    End Sub


End Class
