<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnFilm = New System.Windows.Forms.Button()
        Me.btnMemReg = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(579, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "G4 Assignment"
        '
        'btnMembers
        '
        Me.btnMembers.Location = New System.Drawing.Point(84, 336)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(75, 23)
        Me.btnMembers.TabIndex = 2
        Me.btnMembers.Text = "Members"
        Me.btnMembers.UseVisualStyleBackColor = True
        '
        'btnFilm
        '
        Me.btnFilm.Location = New System.Drawing.Point(84, 265)
        Me.btnFilm.Name = "btnFilm"
        Me.btnFilm.Size = New System.Drawing.Size(151, 31)
        Me.btnFilm.TabIndex = 3
        Me.btnFilm.Text = "Choose your film"
        Me.btnFilm.UseVisualStyleBackColor = True
        '
        'btnMemReg
        '
        Me.btnMemReg.Location = New System.Drawing.Point(612, 29)
        Me.btnMemReg.Name = "btnMemReg"
        Me.btnMemReg.Size = New System.Drawing.Size(148, 28)
        Me.btnMemReg.TabIndex = 4
        Me.btnMemReg.Text = "Member Registration"
        Me.btnMemReg.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(350, 336)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnMemReg)
        Me.Controls.Add(Me.btnFilm)
        Me.Controls.Add(Me.btnMembers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmHome"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMembers As Button
    Friend WithEvents btnFilm As Button
    Friend WithEvents btnMemReg As Button
    Friend WithEvents btnLogin As Button
End Class
