Public Class Delete
    Dim conBooking As OleDb.OleDbConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strconstring As String
        strconstring = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\COMPLETE\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"
        conBooking = New OleDb.OleDbConnection
        conBooking.ConnectionString = strconstring
        conBooking.Open()

        Dim cmddeleteBooking As OleDb.OleDbCommand
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("Please enter Data", "ERROR", MessageBoxButtons.OK)
        Else
            cmddeleteBooking = New OleDb.OleDbCommand("delete Seats from Booking where customers = '" & TextBox2.Text & "' and Movies= '" & TextBox1.Text & "'  ", conBooking)
            cmddeleteBooking.ExecuteNonQuery()
            Label1.Text = "Records successfully deleted"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim count = 0
        Dim records = ""

        Dim cmdSelectBooking As OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            cmdSelectBooking = New OleDb.OleDbCommand("SELECT * From Booking where Customers = '" & TextBox2.Text & "' and Movies = '" & TextBox1.Text & "'", conBooking)
            cmdSelectBooking.ExecuteNonQuery()
            Dim dsBooking As New DataSet
            Dim daBooking As New OleDb.OleDbDataAdapter(cmdSelectBooking)
            daBooking.Fill(dsBooking, "Booking")
            Dim t1 As DataTable = dsBooking.Tables("Booking")
            Dim row As DataRow


            For Each row In t1.Rows
                records += "'" & row(1) & "','" & row(2) & "'," & row(3) & ",'" & row(4) & "','" & row(5) & "'" & vbCrLf
                count += 1
            Next

            TextBox3.Text = records
            Label1.Text = count & " records founded."
        ElseIf TextBox2.Text <> "" Then
            cmdSelectBooking = New OleDb.OleDbCommand("SELECT * From Booking where Customers = '" & TextBox2.Text & "'", conBooking)
            cmdSelectBooking.ExecuteNonQuery()
            Dim dsBooking As New DataSet
            Dim daBooking As New OleDb.OleDbDataAdapter(cmdSelectBooking)
            daBooking.Fill(dsBooking, "Booking")
            Dim t1 As DataTable = dsBooking.Tables("Booking")
            Dim row As DataRow


            For Each row In t1.Rows
                records += "'" & row(1) & "','" & row(2) & "'," & row(3) & ",'" & row(4) & "','" & row(5) & "'" & vbCrLf
                count += 1
            Next

            TextBox3.Text = records
            Label1.Text = count & " records founded."
        ElseIf TextBox1.Text <> "" Then
            cmdSelectBooking = New OleDb.OleDbCommand("SELECT * From Booking where Movies = '" & TextBox1.Text & "'", conBooking)
            cmdSelectBooking.ExecuteNonQuery()
            Dim dsBooking As New DataSet
            Dim daBooking As New OleDb.OleDbDataAdapter(cmdSelectBooking)
            daBooking.Fill(dsBooking, "Booking")
            Dim t1 As DataTable = dsBooking.Tables("Booking")
            Dim row As DataRow


            For Each row In t1.Rows
                records += "" & row(1) & "," & row(2) & "," & row(3) & "," & row(4) & "," & row(5) & "" & vbCrLf
                count += 1
            Next

            TextBox3.Text = records
            Label1.Text = count & " records founded."
        Else
            MessageBox.Show("PLEASE FILL IN THE TEXTBOX", "ERROR", MessageBoxButtons.OK)
        End If






    End Sub

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strconstring As String

        strconstring = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\COMPLETE\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"


        conBooking = New OleDb.OleDbConnection
        conBooking.ConnectionString = strconstring
        conBooking.Open()
        TextBox2.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class