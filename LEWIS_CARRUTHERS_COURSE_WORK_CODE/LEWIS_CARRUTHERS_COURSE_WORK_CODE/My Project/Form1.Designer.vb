<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SETTINGS
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
        Me.TITLE = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HowTo = New System.Windows.Forms.TextBox()
        Me.backcolour = New System.Windows.Forms.Button()
        Me.crosshair = New System.Windows.Forms.Button()
        Me.return_to_menu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TITLE
        '
        Me.TITLE.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TITLE.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITLE.ForeColor = System.Drawing.Color.DarkRed
        Me.TITLE.Location = New System.Drawing.Point(1, 2)
        Me.TITLE.Name = "TITLE"
        Me.TITLE.Size = New System.Drawing.Size(369, 47)
        Me.TITLE.TabIndex = 2
        Me.TITLE.Text = "AIM TRAINER"
        '
        'HowTo
        '
        Me.HowTo.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.HowTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HowTo.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HowTo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.HowTo.Location = New System.Drawing.Point(230, 64)
        Me.HowTo.Name = "HowTo"
        Me.HowTo.Size = New System.Drawing.Size(369, 35)
        Me.HowTo.TabIndex = 9
        Me.HowTo.Text = "Settings"
        '
        'backcolour
        '
        Me.backcolour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backcolour.ForeColor = System.Drawing.Color.DarkRed
        Me.backcolour.Location = New System.Drawing.Point(230, 141)
        Me.backcolour.Name = "backcolour"
        Me.backcolour.Size = New System.Drawing.Size(322, 70)
        Me.backcolour.TabIndex = 10
        Me.backcolour.Text = "Change Background colour"
        Me.backcolour.UseVisualStyleBackColor = True
        '
        'crosshair
        '
        Me.crosshair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crosshair.ForeColor = System.Drawing.Color.DarkRed
        Me.crosshair.Location = New System.Drawing.Point(230, 217)
        Me.crosshair.Name = "crosshair"
        Me.crosshair.Size = New System.Drawing.Size(322, 72)
        Me.crosshair.TabIndex = 11
        Me.crosshair.Text = "Change Reticle"
        Me.crosshair.UseVisualStyleBackColor = True
        '
        'return_to_menu
        '
        Me.return_to_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.return_to_menu.ForeColor = System.Drawing.Color.DarkRed
        Me.return_to_menu.Location = New System.Drawing.Point(230, 295)
        Me.return_to_menu.Name = "return_to_menu"
        Me.return_to_menu.Size = New System.Drawing.Size(322, 93)
        Me.return_to_menu.TabIndex = 12
        Me.return_to_menu.Text = "Reurn To Main Menu "
        Me.return_to_menu.UseVisualStyleBackColor = True
        '
        'SETTINGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.return_to_menu)
        Me.Controls.Add(Me.crosshair)
        Me.Controls.Add(Me.backcolour)
        Me.Controls.Add(Me.HowTo)
        Me.Controls.Add(Me.TITLE)
        Me.Name = "SETTINGS"
        Me.Text = "settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TITLE As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HowTo As TextBox
    Friend WithEvents backcolour As Button
    Friend WithEvents crosshair As Button
    Friend WithEvents return_to_menu As Button
End Class
