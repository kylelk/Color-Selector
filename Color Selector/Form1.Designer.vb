<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colorSelectForm
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
        Me.rBar = New System.Windows.Forms.TrackBar()
        Me.rNum = New System.Windows.Forms.NumericUpDown()
        Me.gNum = New System.Windows.Forms.NumericUpDown()
        Me.gBar = New System.Windows.Forms.TrackBar()
        Me.bNum = New System.Windows.Forms.NumericUpDown()
        Me.bBar = New System.Windows.Forms.TrackBar()
        Me.captionTxt = New System.Windows.Forms.Label()
        Me.colorInfo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hexColor = New System.Windows.Forms.Label()
        CType(Me.rBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.colorInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'rBar
        '
        Me.rBar.BackColor = System.Drawing.Color.Red
        Me.rBar.LargeChange = 8
        Me.rBar.Location = New System.Drawing.Point(13, 78)
        Me.rBar.Maximum = 255
        Me.rBar.Name = "rBar"
        Me.rBar.Size = New System.Drawing.Size(359, 45)
        Me.rBar.TabIndex = 0
        '
        'rNum
        '
        Me.rNum.Location = New System.Drawing.Point(378, 88)
        Me.rNum.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.rNum.Name = "rNum"
        Me.rNum.Size = New System.Drawing.Size(44, 20)
        Me.rNum.TabIndex = 1
        '
        'gNum
        '
        Me.gNum.Location = New System.Drawing.Point(378, 124)
        Me.gNum.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.gNum.Name = "gNum"
        Me.gNum.Size = New System.Drawing.Size(44, 20)
        Me.gNum.TabIndex = 3
        '
        'gBar
        '
        Me.gBar.BackColor = System.Drawing.Color.Green
        Me.gBar.LargeChange = 8
        Me.gBar.Location = New System.Drawing.Point(13, 114)
        Me.gBar.Maximum = 255
        Me.gBar.Name = "gBar"
        Me.gBar.Size = New System.Drawing.Size(359, 45)
        Me.gBar.TabIndex = 2
        '
        'bNum
        '
        Me.bNum.Location = New System.Drawing.Point(378, 162)
        Me.bNum.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.bNum.Name = "bNum"
        Me.bNum.Size = New System.Drawing.Size(44, 20)
        Me.bNum.TabIndex = 5
        '
        'bBar
        '
        Me.bBar.BackColor = System.Drawing.Color.Blue
        Me.bBar.LargeChange = 8
        Me.bBar.Location = New System.Drawing.Point(13, 151)
        Me.bBar.Maximum = 255
        Me.bBar.Name = "bBar"
        Me.bBar.Size = New System.Drawing.Size(359, 45)
        Me.bBar.TabIndex = 4
        '
        'captionTxt
        '
        Me.captionTxt.AutoSize = True
        Me.captionTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.captionTxt.Location = New System.Drawing.Point(117, 9)
        Me.captionTxt.Name = "captionTxt"
        Me.captionTxt.Size = New System.Drawing.Size(200, 31)
        Me.captionTxt.TabIndex = 6
        Me.captionTxt.Text = "Color Selector"
        '
        'colorInfo
        '
        Me.colorInfo.Controls.Add(Me.hexColor)
        Me.colorInfo.Controls.Add(Me.Label1)
        Me.colorInfo.Location = New System.Drawing.Point(13, 202)
        Me.colorInfo.Name = "colorInfo"
        Me.colorInfo.Size = New System.Drawing.Size(359, 48)
        Me.colorInfo.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hex color:"
        '
        'hexColor
        '
        Me.hexColor.AutoSize = True
        Me.hexColor.Location = New System.Drawing.Point(95, 18)
        Me.hexColor.Name = "hexColor"
        Me.hexColor.Size = New System.Drawing.Size(50, 13)
        Me.hexColor.TabIndex = 1
        Me.hexColor.Text = "#000000"
        '
        'colorSelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 262)
        Me.Controls.Add(Me.colorInfo)
        Me.Controls.Add(Me.captionTxt)
        Me.Controls.Add(Me.bNum)
        Me.Controls.Add(Me.bBar)
        Me.Controls.Add(Me.gNum)
        Me.Controls.Add(Me.gBar)
        Me.Controls.Add(Me.rNum)
        Me.Controls.Add(Me.rBar)
        Me.Name = "colorSelectForm"
        Me.Text = "Color Selector"
        CType(Me.rBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.colorInfo.ResumeLayout(False)
        Me.colorInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rBar As System.Windows.Forms.TrackBar
    Friend WithEvents rNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents gNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents gBar As System.Windows.Forms.TrackBar
    Friend WithEvents bNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents bBar As System.Windows.Forms.TrackBar
    Friend WithEvents captionTxt As System.Windows.Forms.Label
    Friend WithEvents colorInfo As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents hexColor As System.Windows.Forms.Label

End Class
