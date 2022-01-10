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
        Me.return_to_menu = New System.Windows.Forms.Button()
        Me.Titlelabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'return_to_menu
        '
        Me.return_to_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.return_to_menu.ForeColor = System.Drawing.Color.DarkRed
        Me.return_to_menu.Location = New System.Drawing.Point(532, 390)
        Me.return_to_menu.Name = "return_to_menu"
        Me.return_to_menu.Size = New System.Drawing.Size(262, 54)
        Me.return_to_menu.TabIndex = 15
        Me.return_to_menu.Text = "Reurn To Menu "
        Me.return_to_menu.UseVisualStyleBackColor = True
        '
        'Titlelabel
        '
        Me.Titlelabel.AutoSize = True
        Me.Titlelabel.Font = New System.Drawing.Font("Comic Sans MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titlelabel.ForeColor = System.Drawing.Color.DarkRed
        Me.Titlelabel.Location = New System.Drawing.Point(1, 0)
        Me.Titlelabel.Name = "Titlelabel"
        Me.Titlelabel.Size = New System.Drawing.Size(260, 45)
        Me.Titlelabel.TabIndex = 17
        Me.Titlelabel.Text = "AIM TRAINER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 34)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "How To Play:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(625, 102)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "The aim of this game is to shoot at the targets that " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "appear on screen in order " &
    "to gain as much points as " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "possible within a set time limit. "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(669, 102)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "You must also avoid shooting the background or allowing " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the targets to disappea" &
    "r after a time limit as this " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will cause you to lose points"
        '
        'HowToPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Titlelabel)
        Me.Controls.Add(Me.return_to_menu)
        Me.Name = "HowToPlay"
        Me.Text = "HowToPlay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents return_to_menu As Button
    Friend WithEvents Titlelabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
