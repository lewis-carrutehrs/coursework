<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HowToPlay
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
        Me.desc2 = New System.Windows.Forms.TextBox()
        Me.return_to_menu = New System.Windows.Forms.Button()
        Me.HTPDESC = New System.Windows.Forms.TextBox()
        Me.HowTo = New System.Windows.Forms.TextBox()
        Me.TITLE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'desc2
        '
        Me.desc2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.desc2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desc2.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.desc2.Location = New System.Drawing.Point(93, 239)
        Me.desc2.Multiline = True
        Me.desc2.Name = "desc2"
        Me.desc2.Size = New System.Drawing.Size(701, 111)
        Me.desc2.TabIndex = 16
        Me.desc2.Text = "You must also avoid shooting the background or allowing the targets to disappear " &
    "after a time limit as this will cause you to lose points"
        '
        'return_to_menu
        '
        Me.return_to_menu.ForeColor = System.Drawing.Color.DarkRed
        Me.return_to_menu.Location = New System.Drawing.Point(532, 390)
        Me.return_to_menu.Name = "return_to_menu"
        Me.return_to_menu.Size = New System.Drawing.Size(262, 54)
        Me.return_to_menu.TabIndex = 15
        Me.return_to_menu.Text = "Reurn to main menu "
        Me.return_to_menu.UseVisualStyleBackColor = True
        '
        'HTPDESC
        '
        Me.HTPDESC.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.HTPDESC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HTPDESC.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HTPDESC.ForeColor = System.Drawing.SystemColors.MenuText
        Me.HTPDESC.Location = New System.Drawing.Point(93, 122)
        Me.HTPDESC.Multiline = True
        Me.HTPDESC.Name = "HTPDESC"
        Me.HTPDESC.Size = New System.Drawing.Size(701, 111)
        Me.HTPDESC.TabIndex = 14
        Me.HTPDESC.Text = "The aim of this game is to shoot at the targets that appear on screen in order to" &
    " gain as much points as possible within a set time limit. "
        '
        'HowTo
        '
        Me.HowTo.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.HowTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HowTo.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HowTo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.HowTo.Location = New System.Drawing.Point(102, 81)
        Me.HowTo.Name = "HowTo"
        Me.HowTo.Size = New System.Drawing.Size(369, 35)
        Me.HowTo.TabIndex = 13
        Me.HowTo.Text = "How To Play: "
        '
        'TITLE
        '
        Me.TITLE.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TITLE.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITLE.ForeColor = System.Drawing.Color.DarkRed
        Me.TITLE.Location = New System.Drawing.Point(6, 7)
        Me.TITLE.Name = "TITLE"
        Me.TITLE.Size = New System.Drawing.Size(369, 47)
        Me.TITLE.TabIndex = 12
        Me.TITLE.Text = "AIM TRAINER"
        '
        'HowToPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.desc2)
        Me.Controls.Add(Me.return_to_menu)
        Me.Controls.Add(Me.HTPDESC)
        Me.Controls.Add(Me.HowTo)
        Me.Controls.Add(Me.TITLE)
        Me.Name = "HowToPlay"
        Me.Text = "HowToPlay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents desc2 As TextBox
    Friend WithEvents return_to_menu As Button
    Friend WithEvents HTPDESC As TextBox
    Friend WithEvents HowTo As TextBox
    Friend WithEvents TITLE As TextBox
End Class
