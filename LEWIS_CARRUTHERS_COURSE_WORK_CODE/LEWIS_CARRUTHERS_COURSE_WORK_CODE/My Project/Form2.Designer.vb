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
        Me.TITLE = New System.Windows.Forms.TextBox()
        Me.HowTo = New System.Windows.Forms.TextBox()
        Me.HTPDESC = New System.Windows.Forms.TextBox()
        Me.return_to_menu = New System.Windows.Forms.Button()
        Me.desc2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TITLE
        '
        Me.TITLE.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TITLE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TITLE.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITLE.ForeColor = System.Drawing.Color.DarkRed
        Me.TITLE.Location = New System.Drawing.Point(0, 1)
        Me.TITLE.Name = "TITLE"
        Me.TITLE.Size = New System.Drawing.Size(369, 47)
        Me.TITLE.TabIndex = 1
        Me.TITLE.Text = "AIM TRAINER"
        '
        'HowTo
        '
        Me.HowTo.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.HowTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HowTo.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HowTo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.HowTo.Location = New System.Drawing.Point(96, 75)
        Me.HowTo.Name = "HowTo"
        Me.HowTo.Size = New System.Drawing.Size(369, 35)
        Me.HowTo.TabIndex = 8
        Me.HowTo.Text = "How To Play: "
        '
        'HTPDESC
        '
        Me.HTPDESC.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.HTPDESC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HTPDESC.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HTPDESC.ForeColor = System.Drawing.SystemColors.MenuText
        Me.HTPDESC.Location = New System.Drawing.Point(87, 116)
        Me.HTPDESC.Multiline = True
        Me.HTPDESC.Name = "HTPDESC"
        Me.HTPDESC.Size = New System.Drawing.Size(701, 111)
        Me.HTPDESC.TabIndex = 9
        Me.HTPDESC.Text = "The aim of this game is to shoot at the targets that appear on screen in order to" &
    " gain as much points as possible within a set time limit. "
        '
        'return_to_menu
        '
        Me.return_to_menu.ForeColor = System.Drawing.Color.DarkRed
        Me.return_to_menu.Location = New System.Drawing.Point(526, 384)
        Me.return_to_menu.Name = "return_to_menu"
        Me.return_to_menu.Size = New System.Drawing.Size(262, 54)
        Me.return_to_menu.TabIndex = 10
        Me.return_to_menu.Text = "Reurn to main menu "
        Me.return_to_menu.UseVisualStyleBackColor = True
        '
        'desc2
        '
        Me.desc2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.desc2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desc2.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.desc2.Location = New System.Drawing.Point(87, 233)
        Me.desc2.Multiline = True
        Me.desc2.Name = "desc2"
        Me.desc2.Size = New System.Drawing.Size(701, 111)
        Me.desc2.TabIndex = 11
        Me.desc2.Text = "You must also avoid shooting the background or allowing the targets to disappear " &
    "after a time limit as this will cause you to lose points"
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
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TITLE As TextBox
    Friend WithEvents HowTo As TextBox
    Friend WithEvents HTPDESC As TextBox
    Friend WithEvents return_to_menu As Button
    Friend WithEvents desc2 As TextBox
End Class
