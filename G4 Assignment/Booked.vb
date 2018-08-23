Public Class Booked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strconstring As String
        strconstring = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\COMPLETE\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"
        Dim conBooking As OleDb.OleDbConnection
        Dim count = 0
        Dim records = ""
        conBooking = New OleDb.OleDbConnection
        conBooking.ConnectionString = strconstring
        conBooking.Open()



        Dim cmdSelectBooking As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        cmdSelectBooking = New OleDb.OleDbCommand("SELECT * From Booking where Customers = '" & TextBox1.Text & "'", conBooking)


        cmdSelectBooking.ExecuteNonQuery()

        Dim dsBooking As New DataSet
        Dim daBooking As New OleDb.OleDbDataAdapter(cmdSelectBooking)
        daBooking.Fill(dsBooking, "Booking")
        Dim t1 As DataTable = dsBooking.Tables("Booking")
        Dim row As DataRow
        Dim name As String = TextBox1.Text

        For Each row In t1.Rows
            records += "'" & row(1) & "','" & row(2) & "'," & row(3) & ",'" & row(4) & "','" & row(5) & "'" & vbCrLf
            count += 1
        Next

        TextBox2.Text = records
        Label1.Text = count & " records founded."

    End Sub

    Private Sub Manage_Seats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class