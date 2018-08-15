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
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnFilm = New System.Windows.Forms.Button()
        Me.btnMemReg = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Info
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(30, 334)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 52)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnMembers
        '
        Me.btnMembers.BackColor = System.Drawing.SystemColors.Info
        Me.btnMembers.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.Location = New System.Drawing.Point(640, 328)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(109, 52)
        Me.btnMembers.TabIndex = 2
        Me.btnMembers.Text = "Members"
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'btnFilm
        '
        Me.btnFilm.BackColor = System.Drawing.SystemColors.Info
        Me.btnFilm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilm.Location = New System.Drawing.Point(333, 221)
        Me.btnFilm.Name = "btnFilm"
        Me.btnFilm.Size = New System.Drawing.Size(109, 52)
        Me.btnFilm.TabIndex = 3
        Me.btnFilm.Text = "Choose your film"
        Me.btnFilm.UseVisualStyleBackColor = False
        '
        'btnMemReg
        '
        Me.btnMemReg.BackColor = System.Drawing.SystemColors.Info
        Me.btnMemReg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemReg.Location = New System.Drawing.Point(454, 104)
        Me.btnMemReg.Name = "btnMemReg"
        Me.btnMemReg.Size = New System.Drawing.Size(154, 69)
        Me.btnMemReg.TabIndex = 4
        Me.btnMemReg.Text = "Member Registration"
        Me.btnMemReg.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.SystemColors.Info
        Me.btnStaff.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.Location = New System.Drawing.Point(202, 105)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(154, 69)
        Me.btnStaff.TabIndex = 6
        Me.btnStaff.Text = "Staff Login"
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Welcome"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.G4_Assignment.My.Resources.Resources.cinema_background_theme_white_blank_screen_33747814
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnMemReg)
        Me.Controls.Add(Me.btnFilm)
        Me.Controls.Add(Me.btnMembers)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnMembers As Button
    Friend WithEvents btnFilm As Button
    Friend WithEvents btnMemReg As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
