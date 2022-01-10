<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayingScreen
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SCORE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TIMER = New System.Windows.Forms.Label()
        Me.target_box = New System.Windows.Forms.PictureBox()
        CType(Me.target_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(-2, -1)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 453)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(738, -1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(62, 453)
        Me.TextBox1.TabIndex = 10
        '
        'SCORE
        '
        Me.SCORE.AutoSize = True
        Me.SCORE.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SCORE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.SCORE.Location = New System.Drawing.Point(183, 9)
        Me.SCORE.Name = "SCORE"
        Me.SCORE.Size = New System.Drawing.Size(102, 51)
        Me.SCORE.TabIndex = 6
        Me.SCORE.Text = "     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    (SCORE)     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(514, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 51)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  (ACCURACY)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TIMER
        '
        Me.TIMER.AutoSize = True
        Me.TIMER.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TIMER.Location = New System.Drawing.Point(293, 10)
        Me.TIMER.Name = "TIMER"
        Me.TIMER.Size = New System.Drawing.Size(204, 51)
        Me.TIMER.TabIndex = 14
        Me.TIMER.Text = "                 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                (TIMER)                    " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 " &
    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TIMER.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'target_box
        '
        Me.target_box.Location = New System.Drawing.Point(66, 91)
        Me.target_box.Name = "target_box"
        Me.target_box.Size = New System.Drawing.Size(666, 347)
        Me.target_box.TabIndex = 15
        Me.target_box.TabStop = False
        '
        'PlayingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TIMER)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.target_box)
        Me.Controls.Add(Me.SCORE)
        Me.Name = "PlayingScreen"
        Me.Text = "PlayingScreen"
        CType(Me.target_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SCORE As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TIMER As Label
    Friend WithEvents target_box As PictureBox
End Class
