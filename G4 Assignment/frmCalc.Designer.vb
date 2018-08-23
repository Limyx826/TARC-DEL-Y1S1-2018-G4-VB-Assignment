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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalc))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lbl_Item = New System.Windows.Forms.Label()
        Me.lblPfd = New System.Windows.Forms.Label()
        Me.lblPfdKids = New System.Windows.Forms.Label()
        Me.lbl_Subtotal = New System.Windows.Forms.Label()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Info
        Me.btnBack.Location = New System.Drawing.Point(32, 372)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 28)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lbl_Item
        '
        Me.lbl_Item.AutoSize = True
        Me.lbl_Item.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Item.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_Item.Location = New System.Drawing.Point(132, 81)
        Me.lbl_Item.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Item.Name = "lbl_Item"
        Me.lbl_Item.Size = New System.Drawing.Size(37, 16)
        Me.lbl_Item.TabIndex = 1
        Me.lbl_Item.Text = "Item"
        '
        'lblPfd
        '
        Me.lblPfd.AutoSize = True
        Me.lblPfd.BackColor = System.Drawing.Color.Transparent
        Me.lblPfd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPfd.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPfd.Location = New System.Drawing.Point(132, 126)
        Me.lblPfd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPfd.Name = "lblPfd"
        Me.lblPfd.Size = New System.Drawing.Size(72, 16)
        Me.lblPfd.TabIndex = 4
        Me.lblPfd.Text = "Members"
        '
        'lblPfdKids
        '
        Me.lblPfdKids.AutoSize = True
        Me.lblPfdKids.BackColor = System.Drawing.Color.Transparent
        Me.lblPfdKids.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPfdKids.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPfdKids.Location = New System.Drawing.Point(132, 170)
        Me.lblPfdKids.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPfdKids.Name = "lblPfdKids"
        Me.lblPfdKids.Size = New System.Drawing.Size(98, 16)
        Me.lblPfdKids.TabIndex = 5
        Me.lblPfdKids.Text = "Member Kids"
        '
        'lbl_Subtotal
        '
        Me.lbl_Subtotal.AutoSize = True
        Me.lbl_Subtotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Subtotal.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_Subtotal.Location = New System.Drawing.Point(831, 81)
        Me.lbl_Subtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Subtotal.Name = "lbl_Subtotal"
        Me.lbl_Subtotal.Size = New System.Drawing.Size(65, 16)
        Me.lbl_Subtotal.TabIndex = 8
        Me.lbl_Subtotal.Text = "Subtotal"
        '
        'lblStd
        '
        Me.lblStd.AutoSize = True
        Me.lblStd.BackColor = System.Drawing.Color.Transparent
        Me.lblStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStd.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStd.Location = New System.Drawing.Point(132, 214)
        Me.lblStd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStd.Name = "lblStd"
        Me.lblStd.Size = New System.Drawing.Size(71, 16)
        Me.lblStd.TabIndex = 10
        Me.lblStd.Text = "Standard"
        '
        'lblPrdST
        '
        Me.lblPrdST.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrdST.Location = New System.Drawing.Point(831, 126)
        Me.lblPrdST.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrdST.Name = "lblPrdST"
        Me.lblPrdST.Size = New System.Drawing.Size(133, 16)
        Me.lblPrdST.TabIndex = 12
        '
        'lblPrdKST
        '
        Me.lblPrdKST.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrdKST.Location = New System.Drawing.Point(831, 171)
        Me.lblPrdKST.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrdKST.Name = "lblPrdKST"
        Me.lblPrdKST.Size = New System.Drawing.Size(133, 16)
        Me.lblPrdKST.TabIndex = 13
        '
        'lblStdST
        '
        Me.lblStdST.BackColor = System.Drawing.SystemColors.Control
        Me.lblStdST.Location = New System.Drawing.Point(831, 217)
        Me.lblStdST.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStdST.Name = "lblStdST"
        Me.lblStdST.Size = New System.Drawing.Size(133, 16)
        Me.lblStdST.TabIndex = 14
        '
        'lblEaster
        '
        Me.lblEaster.AutoSize = True
        Me.lblEaster.BackColor = System.Drawing.Color.Transparent
        Me.lblEaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEaster.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEaster.Location = New System.Drawing.Point(114, 14)
        Me.lblEaster.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEaster.Name = "lblEaster"
        Me.lblEaster.Size = New System.Drawing.Size(116, 16)
        Me.lblEaster.TabIndex = 16
        Me.lblEaster.Text = "Staff in Serving:"
        '
        'Timer1
        '
        '
        'lblStdKids
        '
        Me.lblStdKids.AutoSize = True
        Me.lblStdKids.BackColor = System.Drawing.Color.Transparent
        Me.lblStdKids.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdKids.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStdKids.Location = New System.Drawing.Point(132, 258)
        Me.lblStdKids.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStdKids.Name = "lblStdKids"
        Me.lblStdKids.Size = New System.Drawing.Size(105, 16)
        Me.lblStdKids.TabIndex = 11
        Me.lblStdKids.Text = "Standard Kids"
        '
        'lblStdKST
        '
        Me.lblStdKST.BackColor = System.Drawing.SystemColors.Control
        Me.lblStdKST.Location = New System.Drawing.Point(831, 262)
        Me.lblStdKST.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStdKST.Name = "lblStdKST"
        Me.lblStdKST.Size = New System.Drawing.Size(133, 16)
        Me.lblStdKST.TabIndex = 15
        '
        'lblStdKP
        '
        Me.lblStdKP.AutoSize = True
        Me.lblStdKP.BackColor = System.Drawing.Color.Transparent
        Me.lblStdKP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdKP.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStdKP.Location = New System.Drawing.Point(380, 260)
        Me.lblStdKP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStdKP.Name = "lblStdKP"
        Me.lblStdKP.Size = New System.Drawing.Size(67, 16)
        Me.lblStdKP.TabIndex = 21
        Me.lblStdKP.Text = "RM10.00"
        '
        'lblStdP
        '
        Me.lblStdP.AutoSize = True
        Me.lblStdP.BackColor = System.Drawing.Color.Transparent
        Me.lblStdP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStdP.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStdP.Location = New System.Drawing.Point(380, 214)
        Me.lblStdP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStdP.Name = "lblStdP"
        Me.lblStdP.Size = New System.Drawing.Size(67, 16)
        Me.lblStdP.TabIndex = 20
        Me.lblStdP.Text = "RM14.00"
        '
        'lblPrdKP
        '
        Me.lblPrdKP.AutoSize = True
        Me.lblPrdKP.BackColor = System.Drawing.Color.Transparent
        Me.lblPrdKP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrdKP.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPrdKP.Location = New System.Drawing.Point(380, 170)
        Me.lblPrdKP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrdKP.Name = "lblPrdKP"
        Me.lblPrdKP.Size = New System.Drawing.Size(59, 16)
        Me.lblPrdKP.TabIndex = 19
        Me.lblPrdKP.Text = "RM8.00"
        '
        'lblPrdP
        '
        Me.lblPrdP.AutoSize = True
        Me.lblPrdP.BackColor = System.Drawing.Color.Transparent
        Me.lblPrdP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrdP.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPrdP.Location = New System.Drawing.Point(380, 126)
        Me.lblPrdP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrdP.Name = "lblPrdP"
        Me.lblPrdP.Size = New System.Drawing.Size(67, 16)
        Me.lblPrdP.TabIndex = 18
        Me.lblPrdP.Text = "RM12.00"
        '
        'lbl_Price
        '
        Me.lbl_Price.AutoSize = True
        Me.lbl_Price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Price.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_Price.Location = New System.Drawing.Point(380, 81)
        Me.lbl_Price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(44, 16)
        Me.lbl_Price.TabIndex = 17
        Me.lbl_Price.Text = "Price"
        '
        'lblStdKQ
        '
        Me.lblStdKQ.Location = New System.Drawing.Point(619, 258)
        Me.lblStdKQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStdKQ.Name = "lblStdKQ"
        Me.lblStdKQ.Size = New System.Drawing.Size(80, 16)
        Me.lblStdKQ.TabIndex = 26
        '
        'lblStdQ
        '
        Me.lblStdQ.Location = New System.Drawing.Point(619, 214)
        Me.lblStdQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStdQ.Name = "lblStdQ"
        Me.lblStdQ.Size = New System.Drawing.Size(80, 16)
        Me.lblStdQ.TabIndex = 25
        '
        'lblPrdKQ
        '
        Me.lblPrdKQ.Location = New System.Drawing.Point(619, 170)
        Me.lblPrdKQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrdKQ.Name = "lblPrdKQ"
        Me.lblPrdKQ.Size = New System.Drawing.Size(80, 16)
        Me.lblPrdKQ.TabIndex = 24
        '
        'lblPrdQ
        '
        Me.lblPrdQ.Location = New System.Drawing.Point(619, 126)
        Me.lblPrdQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrdQ.Name = "lblPrdQ"
        Me.lblPrdQ.Size = New System.Drawing.Size(80, 16)
        Me.lblPrdQ.TabIndex = 23
        '
        'lbl_Qty
        '
        Me.lbl_Qty.AutoSize = True
        Me.lbl_Qty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Qty.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_Qty.Location = New System.Drawing.Point(619, 81)
        Me.lbl_Qty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Qty.Name = "lbl_Qty"
        Me.lbl_Qty.Size = New System.Drawing.Size(31, 16)
        Me.lbl_Qty.TabIndex = 22
        Me.lbl_Qty.Text = "Qty"
        '
        'lblYourOrder
        '
        Me.lblYourOrder.AutoSize = True
        Me.lblYourOrder.BackColor = System.Drawing.Color.Transparent
        Me.lblYourOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourOrder.ForeColor = System.Drawing.SystemColors.Control
        Me.lblYourOrder.Location = New System.Drawing.Point(493, 32)
        Me.lblYourOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYourOrder.Name = "lblYourOrder"
        Me.lblYourOrder.Size = New System.Drawing.Size(83, 16)
        Me.lblYourOrder.TabIndex = 27
        Me.lblYourOrder.Text = "Your Order"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTotal.Location = New System.Drawing.Point(132, 311)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 16)
        Me.lblTotal.TabIndex = 28
        Me.lblTotal.Text = "Total"
        '
        'lblTotalP
        '
        Me.lblTotalP.Location = New System.Drawing.Point(831, 311)
        Me.lblTotalP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalP.Name = "lblTotalP"
        Me.lblTotalP.Size = New System.Drawing.Size(133, 28)
        Me.lblTotalP.TabIndex = 29
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl1.Location = New System.Drawing.Point(28, 171)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(55, 16)
        Me.lbl1.TabIndex = 30
        Me.lbl1.Text = "Label1"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl2.Location = New System.Drawing.Point(28, 258)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(55, 16)
        Me.lbl2.TabIndex = 31
        Me.lbl2.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(504, 372)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(263, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 33
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmCalc
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.G4_Assignment.My.Resources.Resources._17945597_vintage_film_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 463)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.lbl_Subtotal)
        Me.Controls.Add(Me.lblPfdKids)
        Me.Controls.Add(Me.lblPfd)
        Me.Controls.Add(Me.lbl_Item)
        Me.Controls.Add(Me.btnBack)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lbl_Item As Label
    Friend WithEvents lblPfd As Label
    Friend WithEvents lblPfdKids As Label
    Friend WithEvents lbl_Subtotal As Label
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
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
