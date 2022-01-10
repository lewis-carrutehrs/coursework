<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settingsscreen
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
        Me.crosshair = New System.Windows.Forms.Button()
        Me.backcolour = New System.Windows.Forms.Button()
        Me.HowTo = New System.Windows.Forms.TextBox()
        Me.Titlelabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'return_to_menu
        '
        Me.return_to_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.return_to_menu.ForeColor = System.Drawing.Color.DarkRed
        Me.return_to_menu.Location = New System.Drawing.Point(242, 307)
        Me.return_to_menu.Name = "return_to_menu"
        Me.return_to_menu.Size = New System.Drawing.Size(322, 74)
        Me.return_to_menu.TabIndex = 17
        Me.return_to_menu.Text = "Reurn To Main Menu "
        Me.return_to_menu.UseVisualStyleBackColor = True
        '
        'crosshair
        '
        Me.crosshair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.crosshair.ForeColor = System.Drawing.Color.DarkRed
        Me.crosshair.Location = New System.Drawing.Point(242, 229)
        Me.crosshair.Name = "crosshair"
        Me.crosshair.Size = New System.Drawing.Size(322, 72)
        Me.crosshair.TabIndex = 16
        Me.crosshair.Text = "Change Reticle"
        Me.crosshair.UseVisualStyleBackColor = True
        '
        'backcolour
        '
        Me.backcolour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.backcolour.ForeColor = System.Drawing.Color.DarkRed
        Me.backcolour.Location = New System.Drawing.Point(242, 153)
        Me.backcolour.Name = "backcolour"
        Me.backcolour.Size = New System.Drawing.Size(322, 70)
        Me.backcolour.TabIndex = 15
        Me.backcolour.Text = "Change Background colour"
        Me.backcolour.UseVisualStyleBackColor = True
        '
        'HowTo
        '
        Me.HowTo.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.HowTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HowTo.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HowTo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.HowTo.Location = New System.Drawing.Point(242, 76)
        Me.HowTo.Name = "HowTo"
        Me.HowTo.Size = New System.Drawing.Size(369, 35)
        Me.HowTo.TabIndex = 14
        Me.HowTo.Text = "Settings"
        '
        'Titlelabel
        '
        Me.Titlelabel.AutoSize = True
        Me.Titlelabel.Font = New System.Drawing.Font("Comic Sans MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titlelabel.ForeColor = System.Drawing.Color.DarkRed
        Me.Titlelabel.Location = New System.Drawing.Point(-2, 9)
        Me.Titlelabel.Name = "Titlelabel"
        Me.Titlelabel.Size = New System.Drawing.Size(270, 48)
        Me.Titlelabel.TabIndex = 18
        Me.Titlelabel.Text = "AIM TRAINER"
        '
        'Settingsscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Titlelabel)
        Me.Controls.Add(Me.return_to_menu)
        Me.Controls.Add(Me.crosshair)
        Me.Controls.Add(Me.backcolour)
        Me.Controls.Add(Me.HowTo)
        Me.Name = "Settingsscreen"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents return_to_menu As Button
    Friend WithEvents crosshair As Button
    Friend WithEvents backcolour As Button
    Friend WithEvents HowTo As TextBox
    Friend WithEvents Titlelabel As Label
End Class
