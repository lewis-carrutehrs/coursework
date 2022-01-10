<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectGameMode
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
        Me.return_to_menu = New System.Windows.Forms.Button()
        Me.GM2 = New System.Windows.Forms.Button()
        Me.GM1 = New System.Windows.Forms.Button()
        Me.Titlelabel = New System.Windows.Forms.Label()
        Me.DESC1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'return_to_menu
        '
        Me.return_to_menu.ForeColor = System.Drawing.Color.DarkRed
        Me.return_to_menu.Location = New System.Drawing.Point(537, 384)
        Me.return_to_menu.Name = "return_to_menu"
        Me.return_to_menu.Size = New System.Drawing.Size(262, 54)
        Me.return_to_menu.TabIndex = 18
        Me.return_to_menu.Text = "Reurn to main menu "
        Me.return_to_menu.UseVisualStyleBackColor = True
        '
        'GM2
        '
        Me.GM2.ForeColor = System.Drawing.Color.DarkRed
        Me.GM2.Location = New System.Drawing.Point(273, 305)
        Me.GM2.Name = "GM2"
        Me.GM2.Size = New System.Drawing.Size(262, 54)
        Me.GM2.TabIndex = 15
        Me.GM2.Text = "GAMEMODE 2"
        Me.GM2.UseVisualStyleBackColor = True
        '
        'GM1
        '
        Me.GM1.ForeColor = System.Drawing.Color.DarkRed
        Me.GM1.Location = New System.Drawing.Point(271, 198)
        Me.GM1.Name = "GM1"
        Me.GM1.Size = New System.Drawing.Size(262, 54)
        Me.GM1.TabIndex = 14
        Me.GM1.Text = "GAMEMODE 1"
        Me.GM1.UseVisualStyleBackColor = True
        '
        'Titlelabel
        '
        Me.Titlelabel.AutoSize = True
        Me.Titlelabel.Font = New System.Drawing.Font("Comic Sans MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titlelabel.ForeColor = System.Drawing.Color.DarkRed
        Me.Titlelabel.Location = New System.Drawing.Point(265, 49)
        Me.Titlelabel.Name = "Titlelabel"
        Me.Titlelabel.Size = New System.Drawing.Size(260, 45)
        Me.Titlelabel.TabIndex = 19
        Me.Titlelabel.Text = "AIM TRAINER"
        '
        'DESC1
        '
        Me.DESC1.AutoSize = True
        Me.DESC1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESC1.Location = New System.Drawing.Point(131, 112)
        Me.DESC1.Name = "DESC1"
        Me.DESC1.Size = New System.Drawing.Size(573, 35)
        Me.DESC1.TabIndex = 20
        Me.DESC1.Text = "Please select the gamemode you wish to play:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(267, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Static Targets"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(269, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Moving Targets"
        '
        'SelectGameMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DESC1)
        Me.Controls.Add(Me.Titlelabel)
        Me.Controls.Add(Me.return_to_menu)
        Me.Controls.Add(Me.GM2)
        Me.Controls.Add(Me.GM1)
        Me.Name = "SelectGameMode"
        Me.Text = "SelectGameMode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents return_to_menu As Button
    Friend WithEvents GM2 As Button
    Friend WithEvents GM1 As Button
    Friend WithEvents Titlelabel As Label
    Friend WithEvents DESC1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
