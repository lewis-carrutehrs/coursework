<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.menubox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ExitGame = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.Button()
        Me.HTP = New System.Windows.Forms.Button()
        Me.PLAY = New System.Windows.Forms.Button()
        Me.TITLE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'menubox
        '
        Me.menubox.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.menubox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.menubox.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menubox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.menubox.Location = New System.Drawing.Point(250, 118)
        Me.menubox.Name = "menubox"
        Me.menubox.Size = New System.Drawing.Size(369, 35)
        Me.menubox.TabIndex = 15
        Me.menubox.Text = "Main Menu"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(624, 313)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(164, 116)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Text = "game mode 2 scoreboard"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(624, 159)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 116)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "game mode 1 scoreboard"
        '
        'ExitGame
        '
        Me.ExitGame.ForeColor = System.Drawing.Color.DarkRed
        Me.ExitGame.Location = New System.Drawing.Point(250, 384)
        Me.ExitGame.Name = "ExitGame"
        Me.ExitGame.Size = New System.Drawing.Size(262, 54)
        Me.ExitGame.TabIndex = 12
        Me.ExitGame.Text = "EXIT GAME"
        Me.ExitGame.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.ForeColor = System.Drawing.Color.DarkRed
        Me.Settings.Location = New System.Drawing.Point(250, 313)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(262, 54)
        Me.Settings.TabIndex = 11
        Me.Settings.Text = "SETTINGS"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'HTP
        '
        Me.HTP.ForeColor = System.Drawing.Color.DarkRed
        Me.HTP.Location = New System.Drawing.Point(250, 232)
        Me.HTP.Name = "HTP"
        Me.HTP.Size = New System.Drawing.Size(262, 54)
        Me.HTP.TabIndex = 10
        Me.HTP.Text = "HOW TO PLAY"
        Me.HTP.UseVisualStyleBackColor = True
        '
        'PLAY
        '
        Me.PLAY.ForeColor = System.Drawing.Color.DarkRed
        Me.PLAY.Location = New System.Drawing.Point(250, 159)
        Me.PLAY.Name = "PLAY"
        Me.PLAY.Size = New System.Drawing.Size(262, 54)
        Me.PLAY.TabIndex = 9
        Me.PLAY.Text = "PLAY"
        Me.PLAY.UseVisualStyleBackColor = True
        '
        'TITLE
        '
        Me.TITLE.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TITLE.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITLE.ForeColor = System.Drawing.Color.DarkRed
        Me.TITLE.Location = New System.Drawing.Point(250, 14)
        Me.TITLE.Name = "TITLE"
        Me.TITLE.Size = New System.Drawing.Size(369, 47)
        Me.TITLE.TabIndex = 8
        Me.TITLE.Text = "AIM TRAINER"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 517)
        Me.Controls.Add(Me.menubox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ExitGame)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.HTP)
        Me.Controls.Add(Me.PLAY)
        Me.Controls.Add(Me.TITLE)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menubox As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ExitGame As Button
    Friend WithEvents Settings As Button
    Friend WithEvents HTP As Button
    Friend WithEvents PLAY As Button
    Friend WithEvents TITLE As TextBox
End Class
