Public Class frmLogin
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtId.Text = ""
        txtPw.Text = ""
        txtId.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Dim name = txtId.Text
        'If txtId.Text.ToUpper() = "SEOW" And txtPw.Text.ToUpper() = "12345" Then
        '    MessageBox.Show("Welcome Back," & name, "Hello", MessageBoxButtons.OK, MessageBoxIcon.None)
        '    Me.Hide()
        '    frmHome.Show()
        'ElseIf txtId.Text.ToUpper() = "SEOW" Then
        '    MessageBox.Show("Wrong Password", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtPw.Focus()
        '    txtPw.SelectAll()
        'ElseIf txtPw.Text.ToUpper() = "12345" Then
        '    MessageBox.Show("Wrong ID", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtId.Focus()
        '    txtId.SelectAll()
        'Else
        '    MessageBox.Show("Wrong ID And Password", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtId.Focus()
        '    txtId.SelectAll()
        '    Exit Sub
        'End If

        Dim strConString As String
        strConString = "Provider= Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\limyx\source\repos\COMPLETE\TARC-DEL-Y1S1-2018-G4-VB-Assignment\G4 Assignment\G4VBMOVIE.accdb"
        Dim conBooking As OleDb.OleDbConnection
        Dim key As Boolean = False
        conBooking = New OleDb.OleDbConnection
        conBooking.ConnectionString = strConString
        conBooking.Open()

        If txtId.Text = "" And txtPw.Text = "" Then
            MessageBox.Show("Please enter username and Password", "ERROR", MessageBoxButtons.OK)
        Else

            Dim username As String
            Dim cmdSelectStaff As OleDb.OleDbCommand
            cmdSelectStaff = New OleDb.OleDbCommand("SELECT * FROM Staffs", conBooking)
            cmdSelectStaff.ExecuteNonQuery()

            Dim dsStaff As New DataSet
            Dim daStaff As New OleDb.OleDbDataAdapter(cmdSelectStaff)
            daStaff.Fill(dsStaff, "Staffs")

            username = txtId.Text

            Dim t2 As DataTable = dsStaff.Tables("Staffs")
            Dim row As DataRow
            For Each row In t2.Rows
                If row(1).Equals(username) Then
                    If row(2).Equals(txtPw.Text) Then
                        key = True

                    End If
                End If
            Next

            If key = True Then
                MessageBox.Show("Welcome back, '" & username & "'")
                frmHome.Show()
                Me.Hide()
                frmCalc.TextBox1.Text = username

            Else
                MessageBox.Show("Error Login")


            End If
        End If

    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub
End Class
