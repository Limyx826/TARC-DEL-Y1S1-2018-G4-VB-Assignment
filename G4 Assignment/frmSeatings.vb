'Imports System.Data.OleDb

'Public Class frmSeatings

'    Dim availableicon As New System.Drawing.Bitmap(My.Resources.Available)
'    Dim provisionalicon As New System.Drawing.Bitmap(My.Resources.provisional)
'    Dim bookedIcon As New System.Drawing.Bitmap(My.Resources.Booked)
'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Dim c As Control

'        For Each c In Me.Controls
'            If TypeOf (c) Is PictureBox Then
'                CType(c, PictureBox).Image = availableicon
'            End If
'        Next

'        Dim strSQL As String
'        strSQL = " SELECT BookingID, Seat FROM Booking"
'        Dim strConString As String
'        strConString = "Provider= Microsoft.JET.OLEDB.4.0;Data Source=C:\Users\limyx\source\repos\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMovie1.mdb"
'        Dim conBooking As OleDbConnection

'        conBooking = New OleDbConnection
'        conBooking.ConnectionString = strConString
'        conBooking.Open()

'        Dim cmdSelectBooking As OleDbCommand
'        cmdSelectBooking = New OleDbCommand
'        cmdSelectBooking.CommandText = strSQL
'        cmdSelectBooking.Connection = conBooking

'        'Dim cmdselectbooking As New OleDbCommand(strSQL, conBooking)

'        'Dim dsBooking As New DataSet
'        'Dim daBooking As New OleDbDataAdapter(cmdSelectBooking)
'        'daBooking.Fill(dsBooking, "Booking")
'        'conBooking.Close()

'        'Dim strOut As String
'        'Dim t1 As DataTable = dsBooking.Tables("Booking")
'        'Dim row As DataRow

'        'For Each row In t1.Rows

'        '    CType(Controls("pic" & row(1)), PictureBox).Image = bookedIcon

'        'Next
'    End Sub



'    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic85.Click, pic86.Click, pic87.Click, pic88.Click, pic89.Click, pic90.Click, pic91.Click, pic92.Click, pic93.Click, pic95.Click, pic96.Click, pic73.Click, pic74.Click, pic75.Click, pic76.Click, pic77.Click, pic78.Click, pic84.Click, pic82.Click, pic81.Click, pic80.Click, pic79.Click, pic61.Click, pic62.Click, pic63.Click, pic64.Click, pic65.Click, pic67.Click, pic68.Click, pic69.Click, pic70.Click, pic71.Click, pic72.Click, pic49.Click, pic50.Click, pic51.Click, pic53.Click, pic54.Click, pic55.Click, pic56.Click, pic57.Click, pic58.Click, pic59.Click, pic60.Click, pic37.Click, pic39.Click, pic40.Click, pic41.Click, pic42.Click, pic43.Click, pic44.Click, pic45.Click, pic46.Click, pic47.Click, pic25.Click, pic26.Click, pic27.Click, pic28.Click, pic29.Click, pic30.Click, pic31.Click, pic32.Click, pic33.Click, pic35.Click, pic36.Click, pic13.Click, pic14.Click, pic15.Click, pic16.Click, pic17.Click, pic18.Click, pic19.Click, pic21.Click, pic22.Click, pic23.Click, pic24.Click, pic1.Click, pic2.Click, pic3.Click, pic4.Click, pic5.Click, pic7.Click, pic8.Click, pic9.Click, pic10.Click, pic11.Click, pic12.Click, pic34.Click, pic20.Click, pic6.Click, pic94.Click, pic83.Click, pic66.Click, pic52.Click, pic38.Click, pic48.Click
'        If CType(sender, PictureBox).Image Is availableicon Then
'            CType(sender, PictureBox).Image = provisionalicon
'        ElseIf CType(sender, PictureBox).Image Is provisionalicon Then
'            CType(sender, PictureBox).Image = availableicon
'        End If
'    End Sub

'    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
'        If CType(sender, PictureBox).Image Is availableicon Then
'            CType(sender, PictureBox).Image = provisionalicon
'        ElseIf CType(sender, PictureBox).Image Is provisionalicon Then
'            CType(sender, PictureBox).Image = availableicon
'        End If
'    End Sub


'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        'Dim photo As Object

'        'Dim num As Integer = 1
'        'Do While num <= 6
'        '    photo = "pic" & num
'        '    Update num
'        '    num += 1
'        'Loop

'        frmCalc.Show()
'        Me.Close()
'    End Sub
'End Class

Imports System.Data.OleDb

Public Class frmSeatings
    Dim strConString As String = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"
    Dim availableicon As New System.Drawing.Bitmap(My.Resources.Available)
    Dim provisionalicon As New System.Drawing.Bitmap(My.Resources.provisional)
    Dim bookedIcon As New System.Drawing.Bitmap(My.Resources.Booked)
    Dim MovieType As String = frmCalcTest.lblFilmTitle.Text
    Dim count As Integer = 0
    Dim total As Double
    Dim bookcount As Double
    Dim txt1 As Double
    Dim txt2 As Double
    Dim txt3 As Double
    Dim txt4 As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Control

        For Each c In Me.Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = availableicon
            End If
        Next



        strConString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"
        Dim conBooking As OleDbConnection

        conBooking = New OleDbConnection
        conBooking.ConnectionString = strConString
        conBooking.Open()



        Dim cmdSelectBooking As OleDbCommand
        Dim dr As OleDbDataReader
        cmdSelectBooking = New OleDbCommand("SELECT * From Booking", conBooking)


        cmdSelectBooking.ExecuteNonQuery()
        'dr = cmdSelectBooking.ExecuteReader

        ' If dr.Read = True Then
        'MessageBox.Show("+dr(0) +""+ dr(1)+", "Data")

        'End If

        'Dim cmdselectbooking As New OleDbCommand(strSQL, conBooking)

        Dim dsBooking As New DataSet
        Dim daBooking As New OleDbDataAdapter(cmdSelectBooking)
        daBooking.Fill(dsBooking, "Booking")



        Dim t1 As DataTable = dsBooking.Tables("Booking")
        Dim row As DataRow

        For Each row In t1.Rows
            If row(3) = MovieType Then

                CType(Controls("pic" & row(1)), PictureBox).Image = bookedIcon
            End If

        Next

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic85.Click, pic86.Click, pic87.Click, pic88.Click, pic89.Click, pic90.Click, pic91.Click, pic92.Click, pic93.Click, pic95.Click, pic96.Click, pic73.Click, pic74.Click, pic75.Click, pic76.Click, pic77.Click, pic78.Click, pic84.Click, pic82.Click, pic81.Click, pic80.Click, pic79.Click, pic61.Click, pic62.Click, pic63.Click, pic64.Click, pic65.Click, pic67.Click, pic68.Click, pic69.Click, pic70.Click, pic71.Click, pic72.Click, pic49.Click, pic50.Click, pic51.Click, pic53.Click, pic54.Click, pic55.Click, pic56.Click, pic57.Click, pic58.Click, pic59.Click, pic60.Click, pic37.Click, pic39.Click, pic40.Click, pic41.Click, pic42.Click, pic43.Click, pic44.Click, pic45.Click, pic46.Click, pic47.Click, pic25.Click, pic26.Click, pic27.Click, pic28.Click, pic29.Click, pic30.Click, pic31.Click, pic32.Click, pic33.Click, pic35.Click, pic36.Click, pic13.Click, pic14.Click, pic15.Click, pic16.Click, pic17.Click, pic18.Click, pic19.Click, pic21.Click, pic22.Click, pic23.Click, pic24.Click, pic1.Click, pic2.Click, pic3.Click, pic4.Click, pic5.Click, pic7.Click, pic8.Click, pic9.Click, pic10.Click, pic11.Click, pic12.Click, pic34.Click, pic20.Click, pic6.Click, pic94.Click, pic83.Click, pic66.Click, pic52.Click, pic38.Click, pic48.Click
        If CType(sender, PictureBox).Image Is availableicon Then
            CType(sender, PictureBox).Image = provisionalicon

        ElseIf CType(sender, PictureBox).Image Is provisionalicon Then
            CType(sender, PictureBox).Image = availableicon

        End If

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As Control

        Dim count As Integer = 0

        Dim bSelected As Boolean
        If bSelected = False Then
            MsgBox(" Please Select at least 1 seat")
        Else


            For i As Integer = 1 To 96
                If CType(Controls("pic" & i), PictureBox).Image Is provisionalicon Then

                    Dim cmdMakeBooking As OleDbCommand
                    Dim conBooking As OleDbConnection
                    conBooking = New OleDbConnection
                    cmdMakeBooking = New OleDbCommand


                    conBooking.ConnectionString = strConString
                    conBooking.Open()
                    cmdMakeBooking = New OleDbCommand("INSERT INTO Booking (Customers, Seats, Movies) VALUES( 'AB001', '" & i & "','" & MovieType & "' )", conBooking)


                    cmdMakeBooking.ExecuteNonQuery()
                    ' count = count + 1

                End If




                txt1 = frmCalcTest.Label5.Text
                txt2 = frmCalcTest.Label6.Text
                txt3 = frmCalcTest.Label7.Text
                txt4 = frmCalcTest.Label8.Text
                total = txt1 + txt2 + txt3 + txt4


                If CType(Controls("pic" & i), PictureBox).Image Is provisionalicon Then
                    bookcount = bookcount + 1
                    If bookcount <> total Then
                        MessageBox.Show("Please choose exactly '" & total & "' seats")
                    Else
                        frmCalc.Show()
                        Me.Close()
                    End If
                End If

            Next

        End If
        'frmCalc.Show()
        'Me.Close()

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        frmMovie.Show()
        Me.Close()
    End Sub

End Class
