<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.Usertext1 = New System.Windows.Forms.TextBox()
        Me.Passtext = New System.Windows.Forms.TextBox()
        Me.Confirmtxt = New System.Windows.Forms.TextBox()
        Me.Userlabel1 = New System.Windows.Forms.Label()
        Me.passwordlabel1 = New System.Windows.Forms.Label()
        Me.passconfirmlabel1 = New System.Windows.Forms.Label()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.Managebtn = New System.Windows.Forms.Button()
        Me.Levellbl = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Usertext1
        '
        Me.Usertext1.Location = New System.Drawing.Point(243, 78)
        Me.Usertext1.Name = "Usertext1"
        Me.Usertext1.Size = New System.Drawing.Size(141, 22)
        Me.Usertext1.TabIndex = 0
        '
        'Passtext
        '
        Me.Passtext.Location = New System.Drawing.Point(243, 141)
        Me.Passtext.Name = "Passtext"
        Me.Passtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Passtext.Size = New System.Drawing.Size(141, 22)
        Me.Passtext.TabIndex = 1
        '
        'Confirmtxt
        '
        Me.Confirmtxt.Location = New System.Drawing.Point(243, 204)
        Me.Confirmtxt.Name = "Confirmtxt"
        Me.Confirmtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Confirmtxt.Size = New System.Drawing.Size(141, 22)
        Me.Confirmtxt.TabIndex = 2
        '
        'Userlabel1
        '
        Me.Userlabel1.AutoSize = True
        Me.Userlabel1.BackColor = System.Drawing.Color.Transparent
        Me.Userlabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userlabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Userlabel1.Location = New System.Drawing.Point(158, 78)
        Me.Userlabel1.Name = "Userlabel1"
        Me.Userlabel1.Size = New System.Drawing.Size(57, 25)
        Me.Userlabel1.TabIndex = 7
        Me.Userlabel1.Text = "User"
        '
        'passwordlabel1
        '
        Me.passwordlabel1.AutoSize = True
        Me.passwordlabel1.BackColor = System.Drawing.Color.Transparent
        Me.passwordlabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordlabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.passwordlabel1.Location = New System.Drawing.Point(112, 138)
        Me.passwordlabel1.Name = "passwordlabel1"
        Me.passwordlabel1.Size = New System.Drawing.Size(106, 25)
        Me.passwordlabel1.TabIndex = 8
        Me.passwordlabel1.Text = "Password"
        '
        'passconfirmlabel1
        '
        Me.passconfirmlabel1.AutoSize = True
        Me.passconfirmlabel1.BackColor = System.Drawing.Color.Transparent
        Me.passconfirmlabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passconfirmlabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.passconfirmlabel1.Location = New System.Drawing.Point(131, 201)
        Me.passconfirmlabel1.Name = "passconfirmlabel1"
        Me.passconfirmlabel1.Size = New System.Drawing.Size(87, 25)
        Me.passconfirmlabel1.TabIndex = 9
        Me.passconfirmlabel1.Text = "Confirm"
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
        Me.loginbtn.Location = New System.Drawing.Point(140, 321)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(75, 93)
        Me.loginbtn.TabIndex = 4
        Me.loginbtn.Text = "Create"
        Me.loginbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.loginbtn.UseVisualStyleBackColor = False
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
        Me.exitbtn.Location = New System.Drawing.Point(237, 321)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(75, 93)
        Me.exitbtn.TabIndex = 6
        Me.exitbtn.Text = "   Back"
        Me.exitbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.exitbtn.UseVisualStyleBackColor = False
        '
        'Managebtn
        '
        Me.Managebtn.BackColor = System.Drawing.Color.Transparent
        Me.Managebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Managebtn.FlatAppearance.BorderSize = 0
        Me.Managebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Managebtn.ForeColor = System.Drawing.Color.Transparent
        Me.Managebtn.Image = CType(resources.GetObject("Managebtn.Image"), System.Drawing.Image)
        Me.Managebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Managebtn.Location = New System.Drawing.Point(334, 321)
        Me.Managebtn.Name = "Managebtn"
        Me.Managebtn.Size = New System.Drawing.Size(75, 93)
        Me.Managebtn.TabIndex = 5
        Me.Managebtn.Text = "Manage"
        Me.Managebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Managebtn.UseVisualStyleBackColor = False
        '
        'Levellbl
        '
        Me.Levellbl.AutoSize = True
        Me.Levellbl.BackColor = System.Drawing.Color.Transparent
        Me.Levellbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Levellbl.ForeColor = System.Drawing.SystemColors.Control
        Me.Levellbl.Location = New System.Drawing.Point(151, 267)
        Me.Levellbl.Name = "Levellbl"
        Me.Levellbl.Size = New System.Drawing.Size(64, 25)
        Me.Levellbl.TabIndex = 10
        Me.Levellbl.Text = "Level"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Owner", "User", "Guest"})
        Me.ComboBox1.Location = New System.Drawing.Point(243, 267)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(141, 24)
        Me.ComboBox1.TabIndex = 3
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(582, 474)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Levellbl)
        Me.Controls.Add(Me.Managebtn)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.passconfirmlabel1)
        Me.Controls.Add(Me.passwordlabel1)
        Me.Controls.Add(Me.Userlabel1)
        Me.Controls.Add(Me.Confirmtxt)
        Me.Controls.Add(Me.Passtext)
        Me.Controls.Add(Me.Usertext1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Users"
        Me.Text = "Create User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Usertext1 As TextBox
    Friend WithEvents Passtext As TextBox
    Friend WithEvents Confirmtxt As TextBox
    Friend WithEvents Userlabel1 As Label
    Friend WithEvents passwordlabel1 As Label
    Friend WithEvents passconfirmlabel1 As Label
    Friend WithEvents loginbtn As Button
    Friend WithEvents exitbtn As Button
    Friend WithEvents Managebtn As Button
    Friend WithEvents Levellbl As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
