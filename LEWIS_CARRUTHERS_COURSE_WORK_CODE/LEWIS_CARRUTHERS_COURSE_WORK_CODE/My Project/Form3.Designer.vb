<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectGameMode
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GM1 = New System.Windows.Forms.Button()
        Me.GM2 = New System.Windows.Forms.Button()
        Me.GM1DESC = New System.Windows.Forms.TextBox()
        Me.TextGM2DESCBox2 = New System.Windows.Forms.TextBox()
        Me.return_to_menu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TITLE
        '
        Me.TITLE.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TITLE.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITLE.ForeColor = System.Drawing.Color.DarkRed
        Me.TITLE.Location = New System.Drawing.Point(271, 39)
        Me.TITLE.Name = "TITLE"
        Me.TITLE.Size = New System.Drawing.Size(369, 47)
        Me.TITLE.TabIndex = 1
        Me.TITLE.Text = "AIM TRAINER"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(135, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(558, 35)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Please select the gamemode you wish to play:"
        '
        'GM1
        '
        Me.GM1.ForeColor = System.Drawing.Color.DarkRed
        Me.GM1.Location = New System.Drawing.Point(269, 198)
        Me.GM1.Name = "GM1"
        Me.GM1.Size = New System.Drawing.Size(262, 54)
        Me.GM1.TabIndex = 3
        Me.GM1.Text = "GAMEMODE 1"
        Me.GM1.UseVisualStyleBackColor = True
        '
        'GM2
        '
        Me.GM2.ForeColor = System.Drawing.Color.DarkRed
        Me.GM2.Location = New System.Drawing.Point(271, 305)
        Me.GM2.Name = "GM2"
        Me.GM2.Size = New System.Drawing.Size(262, 54)
        Me.GM2.TabIndex = 4
        Me.GM2.Text = "GAMEMODE 2"
        Me.GM2.UseVisualStyleBackColor = True
        '
        'GM1DESC
        '
        Me.GM1DESC.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GM1DESC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GM1DESC.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GM1DESC.ForeColor = System.Drawing.Color.Black
        Me.GM1DESC.Location = New System.Drawing.Point(271, 168)
        Me.GM1DESC.Name = "GM1DESC"
        Me.GM1DESC.Size = New System.Drawing.Size(558, 24)
        Me.GM1DESC.TabIndex = 5
        Me.GM1DESC.Text = "Moving targets"
        '
        'TextGM2DESCBox2
        '
        Me.TextGM2DESCBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextGM2DESCBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextGM2DESCBox2.Font = New System.Drawing.Font("Comic Sans MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextGM2DESCBox2.ForeColor = System.Drawing.Color.Black
        Me.TextGM2DESCBox2.Location = New System.Drawing.Point(271, 275)
        Me.TextGM2DESCBox2.Name = "TextGM2DESCBox2"
        Me.TextGM2DESCBox2.Size = New System.Drawing.Size(558, 24)
        Me.TextGM2DESCBox2.TabIndex = 6
        Me.TextGM2DESCBox2.Text = "Static targets"
        '
        'return_to_menu
        '
        Me.return_to_menu.ForeColor = System.Drawing.Color.DarkRed
        Me.return_to_menu.Location = New System.Drawing.Point(535, 384)
        Me.return_to_menu.Name = "return_to_menu"
        Me.return_to_menu.Size = New System.Drawing.Size(262, 54)
        Me.return_to_menu.TabIndex = 11
        Me.return_to_menu.Text = "Reurn to main menu "
        Me.return_to_menu.UseVisualStyleBackColor = True
        '
        'SelectGameMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.return_to_menu)
        Me.Controls.Add(Me.TextGM2DESCBox2)
        Me.Controls.Add(Me.GM1DESC)
        Me.Controls.Add(Me.GM2)
        Me.Controls.Add(Me.GM1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TITLE)
        Me.Name = "SelectGameMode"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TITLE As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GM1 As Button
    Friend WithEvents GM2 As Button
    Friend WithEvents GM1DESC As TextBox
    Friend WithEvents TextGM2DESCBox2 As TextBox
    Friend WithEvents return_to_menu As Button
End Class
