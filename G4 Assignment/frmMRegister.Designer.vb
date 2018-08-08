<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMRegister
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
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.GpbGender = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.txtCon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picno7 = New System.Windows.Forms.PictureBox()
        Me.picno6 = New System.Windows.Forms.PictureBox()
        Me.picno1 = New System.Windows.Forms.PictureBox()
        Me.picno2 = New System.Windows.Forms.PictureBox()
        Me.picno3 = New System.Windows.Forms.PictureBox()
        Me.picno5 = New System.Windows.Forms.PictureBox()
        Me.picyes7 = New System.Windows.Forms.PictureBox()
        Me.picyes6 = New System.Windows.Forms.PictureBox()
        Me.picyes5 = New System.Windows.Forms.PictureBox()
        Me.picyes3 = New System.Windows.Forms.PictureBox()
        Me.picyes2 = New System.Windows.Forms.PictureBox()
        Me.picyes1 = New System.Windows.Forms.PictureBox()
        Me.MskIC = New System.Windows.Forms.MaskedTextBox()
        Me.MksBirth = New System.Windows.Forms.MaskedTextBox()
        Me.lblb = New System.Windows.Forms.Label()
        Me.lbla = New System.Windows.Forms.Label()
        Me.lblc = New System.Windows.Forms.Label()
        Me.GpbGender.SuspendLayout()
        CType(Me.picno7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picno6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picno1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picno2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picno3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picno5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picyes7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picyes6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picyes5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picyes3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picyes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picyes1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblName.Location = New System.Drawing.Point(38, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name :"
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirth.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblBirth.Location = New System.Drawing.Point(38, 66)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(42, 15)
        Me.lblBirth.TabIndex = 1
        Me.lblBirth.Text = "Birth :"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblUsername.Location = New System.Drawing.Point(34, 207)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(83, 15)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username ID :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblPassword.Location = New System.Drawing.Point(38, 260)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(62, 15)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password :"
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblIC.Location = New System.Drawing.Point(34, 97)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(73, 15)
        Me.lblIC.TabIndex = 5
        Me.lblIC.Text = "IC Number :"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(131, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(179, 20)
        Me.txtName.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtID.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(127, 207)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(179, 20)
        Me.txtID.TabIndex = 5
        '
        'TxtPass
        '
        Me.TxtPass.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TxtPass.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.HideSelection = False
        Me.TxtPass.Location = New System.Drawing.Point(127, 260)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.ShortcutsEnabled = False
        Me.TxtPass.Size = New System.Drawing.Size(179, 20)
        Me.TxtPass.TabIndex = 6
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblGender.Location = New System.Drawing.Point(38, 145)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(53, 15)
        Me.lblGender.TabIndex = 12
        Me.lblGender.Text = "Gender :"
        '
        'GpbGender
        '
        Me.GpbGender.Controls.Add(Me.radFemale)
        Me.GpbGender.Controls.Add(Me.radMale)
        Me.GpbGender.Location = New System.Drawing.Point(127, 125)
        Me.GpbGender.Name = "GpbGender"
        Me.GpbGender.Size = New System.Drawing.Size(184, 56)
        Me.GpbGender.TabIndex = 3
        Me.GpbGender.TabStop = False
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.ForeColor = System.Drawing.Color.Fuchsia
        Me.radFemale.Location = New System.Drawing.Point(109, 22)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(64, 19)
        Me.radFemale.TabIndex = 1
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Checked = True
        Me.radMale.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.ForeColor = System.Drawing.Color.DodgerBlue
        Me.radMale.Location = New System.Drawing.Point(18, 22)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(52, 19)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblConfirm.Location = New System.Drawing.Point(33, 317)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(85, 15)
        Me.lblConfirm.TabIndex = 15
        Me.lblConfirm.Text = "Confirm Pass :"
        '
        'txtCon
        '
        Me.txtCon.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCon.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCon.Location = New System.Drawing.Point(127, 314)
        Me.txtCon.Name = "txtCon"
        Me.txtCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCon.Size = New System.Drawing.Size(179, 20)
        Me.txtCon.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(33, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Pay RM20 for member registration ."
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 407)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(123, 34)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(302, 407)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(123, 34)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Location = New System.Drawing.Point(281, 369)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(0, 13)
        Me.lblCheck.TabIndex = 19
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'picno7
        '
        Me.picno7.Image = Global.G4_Assignment.My.Resources.Resources.download
        Me.picno7.Location = New System.Drawing.Point(340, 314)
        Me.picno7.Name = "picno7"
        Me.picno7.Size = New System.Drawing.Size(29, 18)
        Me.picno7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picno7.TabIndex = 33
        Me.picno7.TabStop = False
        Me.picno7.Visible = False
        '
        'picno6
        '
        Me.picno6.Image = Global.G4_Assignment.My.Resources.Resources.download
        Me.picno6.Location = New System.Drawing.Point(340, 262)
        Me.picno6.Name = "picno6"
        Me.picno6.Size = New System.Drawing.Size(29, 18)
        Me.picno6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picno6.TabIndex = 32
        Me.picno6.TabStop = False
        Me.picno6.Visible = False
        '
        'picno1
        '
        Me.picno1.Image = Global.G4_Assignment.My.Resources.Resources.download
        Me.picno1.Location = New System.Drawing.Point(341, 25)
        Me.picno1.Name = "picno1"
        Me.picno1.Size = New System.Drawing.Size(29, 18)
        Me.picno1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picno1.TabIndex = 31
        Me.picno1.TabStop = False
        Me.picno1.Visible = False
        '
        'picno2
        '
        Me.picno2.Image = Global.G4_Assignment.My.Resources.Resources.download
        Me.picno2.Location = New System.Drawing.Point(340, 61)
        Me.picno2.Name = "picno2"
        Me.picno2.Size = New System.Drawing.Size(29, 18)
        Me.picno2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picno2.TabIndex = 30
        Me.picno2.TabStop = False
        Me.picno2.Visible = False
        '
        'picno3
        '
        Me.picno3.Image = Global.G4_Assignment.My.Resources.Resources.download
        Me.picno3.Location = New System.Drawing.Point(340, 97)
        Me.picno3.Name = "picno3"
        Me.picno3.Size = New System.Drawing.Size(29, 18)
        Me.picno3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picno3.TabIndex = 29
        Me.picno3.TabStop = False
        Me.picno3.Visible = False
        '
        'picno5
        '
        Me.picno5.Image = Global.G4_Assignment.My.Resources.Resources.download
        Me.picno5.Location = New System.Drawing.Point(340, 209)
        Me.picno5.Name = "picno5"
        Me.picno5.Size = New System.Drawing.Size(29, 18)
        Me.picno5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picno5.TabIndex = 27
        Me.picno5.TabStop = False
        Me.picno5.Visible = False
        '
        'picyes7
        '
        Me.picyes7.Image = Global.G4_Assignment.My.Resources.Resources.Ok_check_yes_tick_accept_success_green_correct
        Me.picyes7.Location = New System.Drawing.Point(340, 315)
        Me.picyes7.Name = "picyes7"
        Me.picyes7.Size = New System.Drawing.Size(29, 18)
        Me.picyes7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picyes7.TabIndex = 26
        Me.picyes7.TabStop = False
        Me.picyes7.Visible = False
        '
        'picyes6
        '
        Me.picyes6.Image = Global.G4_Assignment.My.Resources.Resources.Ok_check_yes_tick_accept_success_green_correct
        Me.picyes6.Location = New System.Drawing.Point(340, 262)
        Me.picyes6.Name = "picyes6"
        Me.picyes6.Size = New System.Drawing.Size(29, 18)
        Me.picyes6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picyes6.TabIndex = 25
        Me.picyes6.TabStop = False
        Me.picyes6.Visible = False
        '
        'picyes5
        '
        Me.picyes5.Image = Global.G4_Assignment.My.Resources.Resources.Ok_check_yes_tick_accept_success_green_correct
        Me.picyes5.Location = New System.Drawing.Point(340, 209)
        Me.picyes5.Name = "picyes5"
        Me.picyes5.Size = New System.Drawing.Size(29, 18)
        Me.picyes5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picyes5.TabIndex = 24
        Me.picyes5.TabStop = False
        Me.picyes5.Visible = False
        '
        'picyes3
        '
        Me.picyes3.Image = Global.G4_Assignment.My.Resources.Resources.Ok_check_yes_tick_accept_success_green_correct
        Me.picyes3.Location = New System.Drawing.Point(340, 97)
        Me.picyes3.Name = "picyes3"
        Me.picyes3.Size = New System.Drawing.Size(29, 18)
        Me.picyes3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picyes3.TabIndex = 22
        Me.picyes3.TabStop = False
        Me.picyes3.Visible = False
        '
        'picyes2
        '
        Me.picyes2.Image = Global.G4_Assignment.My.Resources.Resources.Ok_check_yes_tick_accept_success_green_correct
        Me.picyes2.Location = New System.Drawing.Point(340, 61)
        Me.picyes2.Name = "picyes2"
        Me.picyes2.Size = New System.Drawing.Size(29, 18)
        Me.picyes2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picyes2.TabIndex = 21
        Me.picyes2.TabStop = False
        Me.picyes2.Visible = False
        '
        'picyes1
        '
        Me.picyes1.Image = Global.G4_Assignment.My.Resources.Resources.Ok_check_yes_tick_accept_success_green_correct
        Me.picyes1.Location = New System.Drawing.Point(340, 25)
        Me.picyes1.Name = "picyes1"
        Me.picyes1.Size = New System.Drawing.Size(29, 18)
        Me.picyes1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picyes1.TabIndex = 20
        Me.picyes1.TabStop = False
        Me.picyes1.Visible = False
        '
        'MskIC
        '
        Me.MskIC.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MskIC.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskIC.Location = New System.Drawing.Point(131, 94)
        Me.MskIC.Mask = "000000-00-0000"
        Me.MskIC.Name = "MskIC"
        Me.MskIC.Size = New System.Drawing.Size(177, 20)
        Me.MskIC.TabIndex = 2
        '
        'MksBirth
        '
        Me.MksBirth.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MksBirth.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MksBirth.Location = New System.Drawing.Point(131, 59)
        Me.MksBirth.Mask = "00/00/0000"
        Me.MksBirth.Name = "MksBirth"
        Me.MksBirth.Size = New System.Drawing.Size(177, 20)
        Me.MksBirth.TabIndex = 1
        Me.MksBirth.ValidatingType = GetType(Date)
        '
        'lblb
        '
        Me.lblb.AutoSize = True
        Me.lblb.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblb.ForeColor = System.Drawing.Color.Red
        Me.lblb.Location = New System.Drawing.Point(142, 244)
        Me.lblb.Name = "lblb"
        Me.lblb.Size = New System.Drawing.Size(0, 13)
        Me.lblb.TabIndex = 36
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbla.ForeColor = System.Drawing.Color.Red
        Me.lbla.Location = New System.Drawing.Point(142, 191)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(0, 13)
        Me.lbla.TabIndex = 37
        '
        'lblc
        '
        Me.lblc.AutoSize = True
        Me.lblc.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc.ForeColor = System.Drawing.Color.Red
        Me.lblc.Location = New System.Drawing.Point(155, 9)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(0, 13)
        Me.lblc.TabIndex = 38
        '
        'frmMRegister
        '
        Me.AcceptButton = Me.btnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(452, 453)
        Me.Controls.Add(Me.lblc)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.lblb)
        Me.Controls.Add(Me.picno7)
        Me.Controls.Add(Me.picno6)
        Me.Controls.Add(Me.picno1)
        Me.Controls.Add(Me.picno2)
        Me.Controls.Add(Me.picno3)
        Me.Controls.Add(Me.picno5)
        Me.Controls.Add(Me.picyes7)
        Me.Controls.Add(Me.picyes6)
        Me.Controls.Add(Me.picyes5)
        Me.Controls.Add(Me.picyes3)
        Me.Controls.Add(Me.picyes2)
        Me.Controls.Add(Me.picyes1)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCon)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.GpbGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.MskIC)
        Me.Controls.Add(Me.MksBirth)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblIC)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblBirth)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmMRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Registration"
        Me.GpbGender.ResumeLayout(False)
        Me.GpbGender.PerformLayout()
        CType(Me.picno7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picno6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picno1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picno2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picno3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picno5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picyes7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picyes6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picyes5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picyes3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picyes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picyes1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblBirth As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents GpbGender As GroupBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents lblConfirm As Label
    Friend WithEvents txtCon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblCheck As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picyes1 As PictureBox
    Friend WithEvents picyes2 As PictureBox
    Friend WithEvents picyes3 As PictureBox
    Friend WithEvents picyes5 As PictureBox
    Friend WithEvents picyes6 As PictureBox
    Friend WithEvents picyes7 As PictureBox
    Friend WithEvents picno5 As PictureBox
    Friend WithEvents picno3 As PictureBox
    Friend WithEvents picno2 As PictureBox
    Friend WithEvents picno1 As PictureBox
    Friend WithEvents picno6 As PictureBox
    Friend WithEvents picno7 As PictureBox
    Friend WithEvents MskIC As MaskedTextBox
    Friend WithEvents MksBirth As MaskedTextBox
    Friend WithEvents lblb As Label
    Friend WithEvents lbla As Label
    Friend WithEvents lblc As Label
End Class
