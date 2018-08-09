<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalc
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lbl_Item = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lblPfd = New System.Windows.Forms.Label()
        Me.lblPfdKids = New System.Windows.Forms.Label()
        Me.lbl_Subtotal = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblStd = New System.Windows.Forms.Label()
        Me.lblPrdST = New System.Windows.Forms.Label()
        Me.lblPrdKST = New System.Windows.Forms.Label()
        Me.lblStdST = New System.Windows.Forms.Label()
        Me.lblEaster = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblStdKids = New System.Windows.Forms.Label()
        Me.lblStdKST = New System.Windows.Forms.Label()
        Me.lblStdKP = New System.Windows.Forms.Label()
        Me.lblStdP = New System.Windows.Forms.Label()
        Me.lblPrdKP = New System.Windows.Forms.Label()
        Me.lblPrdP = New System.Windows.Forms.Label()
        Me.lbl_Price = New System.Windows.Forms.Label()
        Me.lblStdKQ = New System.Windows.Forms.Label()
        Me.lblStdQ = New System.Windows.Forms.Label()
        Me.lblPrdKQ = New System.Windows.Forms.Label()
        Me.lblPrdQ = New System.Windows.Forms.Label()
        Me.lbl_Qty = New System.Windows.Forms.Label()
        Me.lblYourOrder = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalP = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(24, 396)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lbl_Item
        '
        Me.lbl_Item.AutoSize = True
        Me.lbl_Item.Location = New System.Drawing.Point(99, 66)
        Me.lbl_Item.Name = "lbl_Item"
        Me.lbl_Item.Size = New System.Drawing.Size(27, 13)
        Me.lbl_Item.TabIndex = 1
        Me.lbl_Item.Text = "Item"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(298, 287)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 71)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(122, 32)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lblPfd
        '
        Me.lblPfd.AutoSize = True
        Me.lblPfd.Location = New System.Drawing.Point(99, 102)
        Me.lblPfd.Name = "lblPfd"
        Me.lblPfd.Size = New System.Drawing.Size(50, 13)
        Me.lblPfd.TabIndex = 4
        Me.lblPfd.Text = "Perferred"
        '
        'lblPfdKids
        '
        Me.lblPfdKids.AutoSize = True
        Me.lblPfdKids.Location = New System.Drawing.Point(99, 138)
        Me.lblPfdKids.Name = "lblPfdKids"
        Me.lblPfdKids.Size = New System.Drawing.Size(73, 13)
        Me.lblPfdKids.TabIndex = 5
        Me.lblPfdKids.Text = "Perferred Kids"
        '
        'lbl_Subtotal
        '
        Me.lbl_Subtotal.AutoSize = True
        Me.lbl_Subtotal.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_Subtotal.Location = New System.Drawing.Point(623, 66)
        Me.lbl_Subtotal.Name = "lbl_Subtotal"
        Me.lbl_Subtotal.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Subtotal.TabIndex = 8
        Me.lbl_Subtotal.Text = "Subtotal"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(643, 319)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblStd
        '
        Me.lblStd.AutoSize = True
        Me.lblStd.Location = New System.Drawing.Point(99, 174)
        Me.lblStd.Name = "lblStd"
        Me.lblStd.Size = New System.Drawing.Size(50, 13)
        Me.lblStd.TabIndex = 10
        Me.lblStd.Text = "Standard"
        '
        'lblPrdST
        '
        Me.lblPrdST.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrdST.Location = New System.Drawing.Point(623, 102)
        Me.lblPrdST.Name = "lblPrdST"
        Me.lblPrdST.Size = New System.Drawing.Size(100, 13)
        Me.lblPrdST.TabIndex = 12
        '
        'lblPrdKST
        '
        Me.lblPrdKST.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrdKST.Location = New System.Drawing.Point(623, 139)
        Me.lblPrdKST.Name = "lblPrdKST"
        Me.lblPrdKST.Size = New System.Drawing.Size(100, 13)
        Me.lblPrdKST.TabIndex = 13
        '
        'lblStdST
        '
        Me.lblStdST.BackColor = System.Drawing.SystemColors.Control
        Me.lblStdST.Location = New System.Drawing.Point(623, 176)
        Me.lblStdST.Name = "lblStdST"
        Me.lblStdST.Size = New System.Drawing.Size(100, 13)
        Me.lblStdST.TabIndex = 14
        '
        'lblEaster
        '
        Me.lblEaster.AutoSize = True
        Me.lblEaster.Location = New System.Drawing.Point(12, 9)
        Me.lblEaster.Name = "lblEaster"
        Me.lblEaster.Size = New System.Drawing.Size(75, 13)
        Me.lblEaster.TabIndex = 16
        Me.lblEaster.Text = "This is frmCalc"
        Me.lblEaster.Visible = False
        '
        'Timer1
        '
        '
        'lblStdKids
        '
        Me.lblStdKids.AutoSize = True
        Me.lblStdKids.Location = New System.Drawing.Point(99, 210)
        Me.lblStdKids.Name = "lblStdKids"
        Me.lblStdKids.Size = New System.Drawing.Size(73, 13)
        Me.lblStdKids.TabIndex = 11
        Me.lblStdKids.Text = "Standard Kids"
        '
        'lblStdKST
        '
        Me.lblStdKST.BackColor = System.Drawing.SystemColors.Control
        Me.lblStdKST.Location = New System.Drawing.Point(623, 213)
        Me.lblStdKST.Name = "lblStdKST"
        Me.lblStdKST.Size = New System.Drawing.Size(100, 13)
        Me.lblStdKST.TabIndex = 15
        '
        'lblStdKP
        '
        Me.lblStdKP.AutoSize = True
        Me.lblStdKP.Location = New System.Drawing.Point(291, 210)
        Me.lblStdKP.Name = "lblStdKP"
        Me.lblStdKP.Size = New System.Drawing.Size(45, 13)
        Me.lblStdKP.TabIndex = 21
        Me.lblStdKP.Text = "RM8.00"
        '
        'lblStdP
        '
        Me.lblStdP.AutoSize = True
        Me.lblStdP.Location = New System.Drawing.Point(285, 174)
        Me.lblStdP.Name = "lblStdP"
        Me.lblStdP.Size = New System.Drawing.Size(51, 13)
        Me.lblStdP.TabIndex = 20
        Me.lblStdP.Text = "RM14.00"
        '
        'lblPrdKP
        '
        Me.lblPrdKP.AutoSize = True
        Me.lblPrdKP.Location = New System.Drawing.Point(291, 138)
        Me.lblPrdKP.Name = "lblPrdKP"
        Me.lblPrdKP.Size = New System.Drawing.Size(45, 13)
        Me.lblPrdKP.TabIndex = 19
        Me.lblPrdKP.Text = "RM8.00"
        '
        'lblPrdP
        '
        Me.lblPrdP.AutoSize = True
        Me.lblPrdP.Location = New System.Drawing.Point(285, 102)
        Me.lblPrdP.Name = "lblPrdP"
        Me.lblPrdP.Size = New System.Drawing.Size(51, 13)
        Me.lblPrdP.TabIndex = 18
        Me.lblPrdP.Text = "RM16.00"
        '
        'lbl_Price
        '
        Me.lbl_Price.AutoSize = True
        Me.lbl_Price.Location = New System.Drawing.Point(285, 66)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Price.TabIndex = 17
        Me.lbl_Price.Text = "Price"
        '
        'lblStdKQ
        '
        Me.lblStdKQ.Location = New System.Drawing.Point(464, 210)
        Me.lblStdKQ.Name = "lblStdKQ"
        Me.lblStdKQ.Size = New System.Drawing.Size(60, 13)
        Me.lblStdKQ.TabIndex = 26
        '
        'lblStdQ
        '
        Me.lblStdQ.Location = New System.Drawing.Point(464, 174)
        Me.lblStdQ.Name = "lblStdQ"
        Me.lblStdQ.Size = New System.Drawing.Size(60, 13)
        Me.lblStdQ.TabIndex = 25
        '
        'lblPrdKQ
        '
        Me.lblPrdKQ.Location = New System.Drawing.Point(464, 138)
        Me.lblPrdKQ.Name = "lblPrdKQ"
        Me.lblPrdKQ.Size = New System.Drawing.Size(60, 13)
        Me.lblPrdKQ.TabIndex = 24
        '
        'lblPrdQ
        '
        Me.lblPrdQ.Location = New System.Drawing.Point(464, 102)
        Me.lblPrdQ.Name = "lblPrdQ"
        Me.lblPrdQ.Size = New System.Drawing.Size(60, 13)
        Me.lblPrdQ.TabIndex = 23
        '
        'lbl_Qty
        '
        Me.lbl_Qty.AutoSize = True
        Me.lbl_Qty.Location = New System.Drawing.Point(464, 66)
        Me.lbl_Qty.Name = "lbl_Qty"
        Me.lbl_Qty.Size = New System.Drawing.Size(23, 13)
        Me.lbl_Qty.TabIndex = 22
        Me.lbl_Qty.Text = "Qty"
        '
        'lblYourOrder
        '
        Me.lblYourOrder.AutoSize = True
        Me.lblYourOrder.Location = New System.Drawing.Point(370, 26)
        Me.lblYourOrder.Name = "lblYourOrder"
        Me.lblYourOrder.Size = New System.Drawing.Size(58, 13)
        Me.lblYourOrder.TabIndex = 27
        Me.lblYourOrder.Text = "Your Order"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(99, 253)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 28
        Me.lblTotal.Text = "Total"
        '
        'lblTotalP
        '
        Me.lblTotalP.Location = New System.Drawing.Point(623, 253)
        Me.lblTotalP.Name = "lblTotalP"
        Me.lblTotalP.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalP.TabIndex = 29
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(21, 139)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(39, 13)
        Me.lbl1.TabIndex = 30
        Me.lbl1.Text = "Label1"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(21, 210)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(39, 13)
        Me.lbl2.TabIndex = 31
        Me.lbl2.Text = "Label2"
        '
        'frmCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblTotalP)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblYourOrder)
        Me.Controls.Add(Me.lblStdKQ)
        Me.Controls.Add(Me.lblStdQ)
        Me.Controls.Add(Me.lblPrdKQ)
        Me.Controls.Add(Me.lblPrdQ)
        Me.Controls.Add(Me.lbl_Qty)
        Me.Controls.Add(Me.lblStdKP)
        Me.Controls.Add(Me.lblStdP)
        Me.Controls.Add(Me.lblPrdKP)
        Me.Controls.Add(Me.lblPrdP)
        Me.Controls.Add(Me.lbl_Price)
        Me.Controls.Add(Me.lblEaster)
        Me.Controls.Add(Me.lblStdKST)
        Me.Controls.Add(Me.lblStdST)
        Me.Controls.Add(Me.lblPrdKST)
        Me.Controls.Add(Me.lblPrdST)
        Me.Controls.Add(Me.lblStdKids)
        Me.Controls.Add(Me.lblStd)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lbl_Subtotal)
        Me.Controls.Add(Me.lblPfdKids)
        Me.Controls.Add(Me.lblPfd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Item)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lbl_Item As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lblPfd As Label
    Friend WithEvents lblPfdKids As Label
    Friend WithEvents lbl_Subtotal As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblStd As Label
    Friend WithEvents lblPrdST As Label
    Friend WithEvents lblPrdKST As Label
    Friend WithEvents lblStdST As Label
    Friend WithEvents lblEaster As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblStdKids As Label
    Friend WithEvents lblStdKST As Label
    Friend WithEvents lblStdKP As Label
    Friend WithEvents lblStdP As Label
    Friend WithEvents lblPrdKP As Label
    Friend WithEvents lblPrdP As Label
    Friend WithEvents lbl_Price As Label
    Friend WithEvents lblStdKQ As Label
    Friend WithEvents lblStdQ As Label
    Friend WithEvents lblPrdKQ As Label
    Friend WithEvents lblPrdQ As Label
    Friend WithEvents lbl_Qty As Label
    Friend WithEvents lblYourOrder As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalP As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
End Class
