<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.TITLE = New System.Windows.Forms.TextBox()
        Me.CLOSE = New System.Windows.Forms.Button()
        Me.HTP = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PLAY = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.menubox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TITLE
        '
        Me.TITLE.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TITLE.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITLE.ForeColor = System.Drawing.Color.DarkRed
        Me.TITLE.Location = New System.Drawing.Point(250, 12)
        Me.TITLE.Name = "TITLE"
        Me.TITLE.Size = New System.Drawing.Size(369, 47)
        Me.TITLE.TabIndex = 0
        Me.TITLE.Text = "AIM TRAINER"
        '
        'CLOSE
        '
        Me.CLOSE.ForeColor = System.Drawing.Color.DarkRed
        Me.CLOSE.Location = New System.Drawing.Point(250, 382)
        Me.CLOSE.Name = "CLOSE"
        Me.CLOSE.Size = New System.Drawing.Size(262, 54)
        Me.CLOSE.TabIndex = 4
        Me.CLOSE.Text = "EXIT GAME"
        Me.CLOSE.UseVisualStyleBackColor = True
        '
        'HTP
        '
        Me.HTP.ForeColor = System.Drawing.Color.DarkRed
        Me.HTP.Location = New System.Drawing.Point(250, 230)
        Me.HTP.Name = "HTP"
        Me.HTP.Size = New System.Drawing.Size(262, 54)
        Me.HTP.TabIndex = 2
        Me.HTP.Text = "HOW TO PLAY"
        Me.HTP.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.DarkRed
        Me.Button2.Location = New System.Drawing.Point(250, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(262, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "SETTINGS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PLAY
        '
        Me.PLAY.ForeColor = System.Drawing.Color.DarkRed
        Me.PLAY.Location = New System.Drawing.Point(250, 157)
        Me.PLAY.Name = "PLAY"
        Me.PLAY.Size = New System.Drawing.Size(262, 54)
        Me.PLAY.TabIndex = 1
        Me.PLAY.Text = "PLAY"
        Me.PLAY.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(624, 157)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 116)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "game mode 1 scoreboard"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(624, 311)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(164, 116)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "game mode 2 scoreboard"
        '
        'menubox
        '
        Me.menubox.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.menubox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.menubox.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menubox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.menubox.Location = New System.Drawing.Point(250, 116)
        Me.menubox.Name = "menubox"
        Me.menubox.Size = New System.Drawing.Size(369, 35)
        Me.menubox.TabIndex = 7
        Me.menubox.Text = "Main Menu"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 506)
        Me.Controls.Add(Me.menubox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CLOSE)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.HTP)
        Me.Controls.Add(Me.PLAY)
        Me.Controls.Add(Me.TITLE)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainMenu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TITLE As TextBox
    Friend WithEvents CLOSE As Button
    Friend WithEvents HTP As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PLAY As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents menubox As TextBox
End Class
