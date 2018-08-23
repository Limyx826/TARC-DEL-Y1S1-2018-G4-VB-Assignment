Public Class members
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim strConString As String
        strConString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\COMPLETE\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"
        Dim conBooking As OleDb.OleDbConnection
        Dim key As Boolean = False
        conBooking = New OleDb.OleDbConnection
        conBooking.ConnectionString = strConString
        conBooking.Open()

        If TextBox2.Text = "" Then
            MessageBox.Show("Please enter name", "ERROR", MessageBoxButtons.OK)
        Else

            Dim username As String
            Dim cmdSelectmember As OleDb.OleDbCommand
            cmdSelectmember = New OleDb.OleDbCommand("SELECT MemberID FROM Members", conBooking)
            cmdSelectmember.ExecuteNonQuery()

            Dim dsmember As New DataSet
            Dim damember As New OleDb.OleDbDataAdapter(cmdSelectmember)
            damember.Fill(dsmember, "Members")

            username = TextBox1.Text

            Dim t2 As DataTable = dsmember.Tables("Members")
            Dim row As DataRow
            For Each row In t2.Rows
                If row(0).Equals(username) Then
                    key = True

                End If
            Next

            If key = False Then
                MessageBox.Show("Guest Login")
                frmMovie.Show()
                Me.Hide()
            Else
                MessageBox.Show("Member Login")
                frmMovie.Show()
                Me.Hide()

            End If
            frmSeatings.TextBox3.Text = TextBox2.Text
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmHome.Show()
        Me.Close()

    End Sub

    Private Sub members_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim strConString As String
        strConString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\COMPLETE\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"
        Dim conBooking As OleDb.OleDbConnection
        Dim found As Boolean = False
        Dim memberID As String = ""

        conBooking = New OleDb.OleDbConnection
        conBooking.ConnectionString = strConString
        conBooking.Open()



        Dim cmdSelectmember As OleDb.OleDbCommand
        cmdSelectmember = New OleDb.OleDbCommand("SELECT * FROM Members where MemberName = '" & TextBox2.Text & "' ", conBooking)
        cmdSelectmember.ExecuteNonQuery()

        Dim dsmember As New DataSet
        Dim damember As New OleDb.OleDbDataAdapter(cmdSelectmember)
        damember.Fill(dsmember, "Members")
        Dim t2 As DataTable = dsmember.Tables("Members")
        Dim row As DataRow
        For Each row In t2.Rows
            If row(2).Equals(TextBox2.Text) Then
                found = True
                memberID = row(1)
            End If
        Next

        If found = True Then
            TextBox1.Text = memberID
        Else
            TextBox1.Text = ""
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim strConString As String
        strConString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\COMPLETE\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"
        Dim conBooking As OleDb.OleDbConnection
        Dim memberID As String = ""

        conBooking = New OleDb.OleDbConnection
        conBooking.ConnectionString = strConString
        conBooking.Open()



        Dim cmdSelectmember As OleDb.OleDbCommand
        cmdSelectmember = New OleDb.OleDbCommand("SELECT MemberID FROM Members where MemberName = '" & TextBox1.Text & "' ", conBooking)
        cmdSelectmember.ExecuteNonQuery()

        Dim dsmember As New DataSet
        Dim damember As New OleDb.OleDbDataAdapter(cmdSelectmember)
        damember.Fill(dsmember, "Members")
        Dim t2 As DataTable = dsmember.Tables("Members")
        Dim row As DataRow
        For Each row In t2.Rows
            TextBox1.Text = row(0)
        Next

    End Sub
End Class