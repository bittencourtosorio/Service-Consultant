<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Usertext = New System.Windows.Forms.TextBox()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.Passtext = New System.Windows.Forms.TextBox()
        Me.Userlabel = New System.Windows.Forms.Label()
        Me.passlabel = New System.Windows.Forms.Label()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.Loginlabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Usertext
        '
        Me.Usertext.Location = New System.Drawing.Point(142, 63)
        Me.Usertext.Name = "Usertext"
        Me.Usertext.Size = New System.Drawing.Size(141, 22)
        Me.Usertext.TabIndex = 0
        '
        'exitbtn
        '
        Me.exitbtn.BackColor = System.Drawing.Color.Transparent
        Me.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitbtn.FlatAppearance.BorderSize = 0
        Me.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbtn.ForeColor = System.Drawing.Color.Transparent
        Me.exitbtn.Image = CType(resources.GetObject("exitbtn.Image"), System.Drawing.Image)
        Me.exitbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.exitbtn.Location = New System.Drawing.Point(208, 157)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(75, 93)
        Me.exitbtn.TabIndex = 3
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.exitbtn.UseVisualStyleBackColor = False
        '
        'Passtext
        '
        Me.Passtext.Location = New System.Drawing.Point(142, 108)
        Me.Passtext.Name = "Passtext"
        Me.Passtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtext.Size = New System.Drawing.Size(141, 22)
        Me.Passtext.TabIndex = 1
        '
        'Userlabel
        '
        Me.Userlabel.AutoSize = True
        Me.Userlabel.BackColor = System.Drawing.Color.Transparent
        Me.Userlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userlabel.ForeColor = System.Drawing.SystemColors.Control
        Me.Userlabel.Location = New System.Drawing.Point(79, 63)
        Me.Userlabel.Name = "Userlabel"
        Me.Userlabel.Size = New System.Drawing.Size(57, 25)
        Me.Userlabel.TabIndex = 4
        Me.Userlabel.Text = "User"
        '
        'passlabel
        '
        Me.passlabel.AutoSize = True
        Me.passlabel.BackColor = System.Drawing.Color.Transparent
        Me.passlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passlabel.ForeColor = System.Drawing.SystemColors.Control
        Me.passlabel.Location = New System.Drawing.Point(30, 108)
        Me.passlabel.Name = "passlabel"
        Me.passlabel.Size = New System.Drawing.Size(106, 25)
        Me.passlabel.TabIndex = 5
        Me.passlabel.Text = "Password"
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.Transparent
        Me.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginbtn.FlatAppearance.BorderSize = 0
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.ForeColor = System.Drawing.Color.Transparent
        Me.loginbtn.Image = CType(resources.GetObject("loginbtn.Image"), System.Drawing.Image)
        Me.loginbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.loginbtn.Location = New System.Drawing.Point(111, 157)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(75, 93)
        Me.loginbtn.TabIndex = 2
        Me.loginbtn.Text = "Login"
        Me.loginbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'Loginlabel
        '
        Me.Loginlabel.AutoSize = True
        Me.Loginlabel.BackColor = System.Drawing.Color.Transparent
        Me.Loginlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginlabel.ForeColor = System.Drawing.SystemColors.Control
        Me.Loginlabel.Location = New System.Drawing.Point(169, 21)
        Me.Loginlabel.Name = "Loginlabel"
        Me.Loginlabel.Size = New System.Drawing.Size(78, 25)
        Me.Loginlabel.TabIndex = 7
        Me.Loginlabel.Text = "LOGIN"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(380, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.Loginlabel)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.passlabel)
        Me.Controls.Add(Me.Userlabel)
        Me.Controls.Add(Me.Passtext)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.Usertext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Usertext As TextBox
    Friend WithEvents exitbtn As Button
    Friend WithEvents Passtext As TextBox
    Friend WithEvents Userlabel As Label
    Friend WithEvents passlabel As Label
    Friend WithEvents loginbtn As Button
    Friend WithEvents Loginlabel As Label
End Class
