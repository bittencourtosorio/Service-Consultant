<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUser))
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.Userlabel = New System.Windows.Forms.Label()
        Me.Alterbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Refreshbtn = New System.Windows.Forms.Button()
        Me.usernamelbl = New System.Windows.Forms.Label()
        Me.userlevel = New System.Windows.Forms.Label()
        Me.userpwdlbl = New System.Windows.Forms.Label()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.userpwdtxt = New System.Windows.Forms.TextBox()
        Me.userlvlcbx = New System.Windows.Forms.ComboBox()
        Me.levellbl = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.Transparent
        Me.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deletebtn.FlatAppearance.BorderSize = 0
        Me.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deletebtn.ForeColor = System.Drawing.Color.Transparent
        Me.deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), System.Drawing.Image)
        Me.deletebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.deletebtn.Location = New System.Drawing.Point(30, 59)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(75, 79)
        Me.deletebtn.TabIndex = 10
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'Userlabel
        '
        Me.Userlabel.AutoSize = True
        Me.Userlabel.BackColor = System.Drawing.Color.Transparent
        Me.Userlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userlabel.ForeColor = System.Drawing.SystemColors.Control
        Me.Userlabel.Location = New System.Drawing.Point(309, 11)
        Me.Userlabel.Name = "Userlabel"
        Me.Userlabel.Size = New System.Drawing.Size(146, 31)
        Me.Userlabel.TabIndex = 11
        Me.Userlabel.Text = "User Data"
        '
        'Alterbtn
        '
        Me.Alterbtn.BackColor = System.Drawing.Color.Transparent
        Me.Alterbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Alterbtn.FlatAppearance.BorderSize = 0
        Me.Alterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Alterbtn.ForeColor = System.Drawing.Color.Transparent
        Me.Alterbtn.Image = CType(resources.GetObject("Alterbtn.Image"), System.Drawing.Image)
        Me.Alterbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Alterbtn.Location = New System.Drawing.Point(30, 167)
        Me.Alterbtn.Name = "Alterbtn"
        Me.Alterbtn.Size = New System.Drawing.Size(75, 79)
        Me.Alterbtn.TabIndex = 12
        Me.Alterbtn.Text = "Alter"
        Me.Alterbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Alterbtn.UseVisualStyleBackColor = False
        '
        'Exitbtn
        '
        Me.Exitbtn.BackColor = System.Drawing.Color.Transparent
        Me.Exitbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exitbtn.FlatAppearance.BorderSize = 0
        Me.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exitbtn.ForeColor = System.Drawing.Color.Transparent
        Me.Exitbtn.Image = CType(resources.GetObject("Exitbtn.Image"), System.Drawing.Image)
        Me.Exitbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Exitbtn.Location = New System.Drawing.Point(23, 383)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(75, 79)
        Me.Exitbtn.TabIndex = 13
        Me.Exitbtn.Text = "   Back"
        Me.Exitbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Exitbtn.UseVisualStyleBackColor = False
        '
        'dgvData
        '
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(142, 227)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersWidth = 51
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(452, 269)
        Me.dgvData.TabIndex = 14
        '
        'Refreshbtn
        '
        Me.Refreshbtn.BackColor = System.Drawing.Color.Transparent
        Me.Refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Refreshbtn.FlatAppearance.BorderSize = 0
        Me.Refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Refreshbtn.ForeColor = System.Drawing.Color.Transparent
        Me.Refreshbtn.Image = CType(resources.GetObject("Refreshbtn.Image"), System.Drawing.Image)
        Me.Refreshbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Refreshbtn.Location = New System.Drawing.Point(30, 275)
        Me.Refreshbtn.Name = "Refreshbtn"
        Me.Refreshbtn.Size = New System.Drawing.Size(75, 79)
        Me.Refreshbtn.TabIndex = 15
        Me.Refreshbtn.Text = "Refresh"
        Me.Refreshbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Refreshbtn.UseVisualStyleBackColor = False
        '
        'usernamelbl
        '
        Me.usernamelbl.AutoSize = True
        Me.usernamelbl.BackColor = System.Drawing.Color.Transparent
        Me.usernamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelbl.ForeColor = System.Drawing.SystemColors.Control
        Me.usernamelbl.Location = New System.Drawing.Point(245, 68)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(119, 25)
        Me.usernamelbl.TabIndex = 16
        Me.usernamelbl.Text = "User Name"
        '
        'userlevel
        '
        Me.userlevel.AutoSize = True
        Me.userlevel.BackColor = System.Drawing.Color.Transparent
        Me.userlevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlevel.ForeColor = System.Drawing.SystemColors.Control
        Me.userlevel.Location = New System.Drawing.Point(249, 116)
        Me.userlevel.Name = "userlevel"
        Me.userlevel.Size = New System.Drawing.Size(115, 25)
        Me.userlevel.TabIndex = 17
        Me.userlevel.Text = "User Level"
        '
        'userpwdlbl
        '
        Me.userpwdlbl.AutoSize = True
        Me.userpwdlbl.BackColor = System.Drawing.Color.Transparent
        Me.userpwdlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userpwdlbl.ForeColor = System.Drawing.SystemColors.Control
        Me.userpwdlbl.Location = New System.Drawing.Point(207, 164)
        Me.userpwdlbl.Name = "userpwdlbl"
        Me.userpwdlbl.Size = New System.Drawing.Size(157, 25)
        Me.userpwdlbl.TabIndex = 18
        Me.userpwdlbl.Text = "User Password"
        '
        'usernametxt
        '
        Me.usernametxt.Location = New System.Drawing.Point(389, 71)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.ReadOnly = True
        Me.usernametxt.Size = New System.Drawing.Size(140, 22)
        Me.usernametxt.TabIndex = 19
        '
        'userpwdtxt
        '
        Me.userpwdtxt.Location = New System.Drawing.Point(389, 167)
        Me.userpwdtxt.Name = "userpwdtxt"
        Me.userpwdtxt.Size = New System.Drawing.Size(140, 22)
        Me.userpwdtxt.TabIndex = 21
        '
        'userlvlcbx
        '
        Me.userlvlcbx.FormattingEnabled = True
        Me.userlvlcbx.Items.AddRange(New Object() {"Owner", "User", "Guest"})
        Me.userlvlcbx.Location = New System.Drawing.Point(389, 119)
        Me.userlvlcbx.Name = "userlvlcbx"
        Me.userlvlcbx.Size = New System.Drawing.Size(140, 24)
        Me.userlvlcbx.TabIndex = 22
        '
        'levellbl
        '
        Me.levellbl.AutoSize = True
        Me.levellbl.Location = New System.Drawing.Point(617, 463)
        Me.levellbl.Name = "levellbl"
        Me.levellbl.Size = New System.Drawing.Size(0, 17)
        Me.levellbl.TabIndex = 23
        Me.levellbl.Visible = False
        '
        'ManageUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(667, 528)
        Me.Controls.Add(Me.levellbl)
        Me.Controls.Add(Me.userlvlcbx)
        Me.Controls.Add(Me.userpwdtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.userpwdlbl)
        Me.Controls.Add(Me.userlevel)
        Me.Controls.Add(Me.usernamelbl)
        Me.Controls.Add(Me.Refreshbtn)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Alterbtn)
        Me.Controls.Add(Me.Userlabel)
        Me.Controls.Add(Me.deletebtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManageUser"
        Me.Text = "Manage Users"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deletebtn As Button
    Friend WithEvents Userlabel As Label
    Friend WithEvents Alterbtn As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Refreshbtn As Button
    Friend WithEvents usernamelbl As Label
    Friend WithEvents userlevel As Label
    Friend WithEvents userpwdlbl As Label
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents userpwdtxt As TextBox
    Friend WithEvents userlvlcbx As ComboBox
    Friend WithEvents levellbl As Label
End Class
