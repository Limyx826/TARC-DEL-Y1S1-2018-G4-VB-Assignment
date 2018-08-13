<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
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
        Me.BtnProceed = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcDebug = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnProceed
        '
        Me.BtnProceed.Location = New System.Drawing.Point(104, 462)
        Me.BtnProceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnProceed.Name = "BtnProceed"
        Me.BtnProceed.Size = New System.Drawing.Size(323, 137)
        Me.BtnProceed.TabIndex = 0
        Me.BtnProceed.Text = "Proceed"
        Me.BtnProceed.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(872, 462)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(323, 137)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Impact", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 174)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(777, 245)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Movie Booking"
        '
        'btnCalcDebug
        '
        Me.btnCalcDebug.Location = New System.Drawing.Point(17, 16)
        Me.btnCalcDebug.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalcDebug.Name = "btnCalcDebug"
        Me.btnCalcDebug.Size = New System.Drawing.Size(100, 28)
        Me.btnCalcDebug.TabIndex = 3
        Me.btnCalcDebug.Text = "CalcDeBug"
        Me.btnCalcDebug.UseVisualStyleBackColor = True
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 752)
        Me.Controls.Add(Me.btnCalcDebug)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.BtnProceed)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnProceed As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcDebug As Button
End Class
