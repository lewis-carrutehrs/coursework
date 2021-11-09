<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ENDINGSCREEN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.paused = New System.Windows.Forms.TextBox()
        Me.res = New System.Windows.Forms.Button()
        Me.MainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(-1, -1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(62, 453)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.MenuText
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(740, -1)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 453)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(494, 12)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(106, 49)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.Text = "              (ACCURACY) "
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(282, 12)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(206, 49)
        Me.TextBox5.TabIndex = 6
        Me.TextBox5.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                      (TIMER)"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(176, 12)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 49)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      (SCORE)"
        '
        'paused
        '
        Me.paused.BackColor = System.Drawing.Color.DarkRed
        Me.paused.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.paused.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.paused.Location = New System.Drawing.Point(280, 130)
        Me.paused.Multiline = True
        Me.paused.Name = "paused"
        Me.paused.Size = New System.Drawing.Size(206, 187)
        Me.paused.TabIndex = 8
        Me.paused.Text = "         PAUSED"
        '
        'res
        '
        Me.res.Location = New System.Drawing.Point(329, 181)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(104, 41)
        Me.res.TabIndex = 9
        Me.res.Text = "Resume "
        Me.res.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.MainMenu.Location = New System.Drawing.Point(329, 242)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(104, 41)
        Me.MainMenu.TabIndex = 11
        Me.MainMenu.Text = "Main Menu"
        Me.MainMenu.UseVisualStyleBackColor = True
        '
        'ENDINGSCREEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.paused)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ENDINGSCREEN"
        Me.Text = "Ending screen "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents paused As TextBox
    Friend WithEvents res As Button
    Friend WithEvents MainMenu As Button
End Class
