<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachineDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MachineDB))
        Me.brand_cb = New System.Windows.Forms.ComboBox()
        Me.macnumlbl = New System.Windows.Forms.Label()
        Me.macnumtxt = New System.Windows.Forms.TextBox()
        Me.mactype_cb = New System.Windows.Forms.ComboBox()
        Me.mactype_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.control_cb = New System.Windows.Forms.ComboBox()
        Me.control_btn = New System.Windows.Forms.Button()
        Me.macyear_lbl = New System.Windows.Forms.Label()
        Me.erosion_gb = New System.Windows.Forms.GroupBox()
        Me.erosion_rb2 = New System.Windows.Forms.RadioButton()
        Me.erosion_rb1 = New System.Windows.Forms.RadioButton()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.Alterbtn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.create_btn = New System.Windows.Forms.Button()
        Me.Refreshbtn = New System.Windows.Forms.Button()
        Me.macyear_cb = New System.Windows.Forms.ComboBox()
        Me.brand_btn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.erosion_gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'brand_cb
        '
        Me.brand_cb.FormattingEnabled = True
        Me.brand_cb.Items.AddRange(New Object() {"WALTER", "Studer", "EWAG"})
        Me.brand_cb.Location = New System.Drawing.Point(214, 59)
        Me.brand_cb.Name = "brand_cb"
        Me.brand_cb.Size = New System.Drawing.Size(121, 24)
        Me.brand_cb.TabIndex = 0
        '
        'macnumlbl
        '
        Me.macnumlbl.AutoSize = True
        Me.macnumlbl.Location = New System.Drawing.Point(404, 34)
        Me.macnumlbl.Name = "macnumlbl"
        Me.macnumlbl.Size = New System.Drawing.Size(115, 17)
        Me.macnumlbl.TabIndex = 2
        Me.macnumlbl.Text = "Machine Number"
        '
        'macnumtxt
        '
        Me.macnumtxt.Location = New System.Drawing.Point(377, 59)
        Me.macnumtxt.Name = "macnumtxt"
        Me.macnumtxt.Size = New System.Drawing.Size(162, 22)
        Me.macnumtxt.TabIndex = 3
        '
        'mactype_cb
        '
        Me.mactype_cb.FormattingEnabled = True
        Me.mactype_cb.Location = New System.Drawing.Point(592, 59)
        Me.mactype_cb.Name = "mactype_cb"
        Me.mactype_cb.Size = New System.Drawing.Size(121, 24)
        Me.mactype_cb.TabIndex = 5
        '
        'mactype_btn
        '
        Me.mactype_btn.BackColor = System.Drawing.Color.Transparent
        Me.mactype_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.mactype_btn.FlatAppearance.BorderSize = 0
        Me.mactype_btn.Location = New System.Drawing.Point(592, 28)
        Me.mactype_btn.Name = "mactype_btn"
        Me.mactype_btn.Size = New System.Drawing.Size(121, 29)
        Me.mactype_btn.TabIndex = 6
        Me.mactype_btn.Text = "Machine Type"
        Me.mactype_btn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(214, 174)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(499, 332)
        Me.DataGridView1.TabIndex = 7
        '
        'control_cb
        '
        Me.control_cb.FormattingEnabled = True
        Me.control_cb.Items.AddRange(New Object() {"Walter", "Studer", "Hermle"})
        Me.control_cb.Location = New System.Drawing.Point(214, 133)
        Me.control_cb.Name = "control_cb"
        Me.control_cb.Size = New System.Drawing.Size(121, 24)
        Me.control_cb.TabIndex = 9
        '
        'control_btn
        '
        Me.control_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.control_btn.FlatAppearance.BorderSize = 0
        Me.control_btn.Location = New System.Drawing.Point(214, 98)
        Me.control_btn.Name = "control_btn"
        Me.control_btn.Size = New System.Drawing.Size(121, 29)
        Me.control_btn.TabIndex = 10
        Me.control_btn.Text = "Control"
        Me.control_btn.UseVisualStyleBackColor = True
        '
        'macyear_lbl
        '
        Me.macyear_lbl.AutoSize = True
        Me.macyear_lbl.Location = New System.Drawing.Point(412, 110)
        Me.macyear_lbl.Name = "macyear_lbl"
        Me.macyear_lbl.Size = New System.Drawing.Size(95, 17)
        Me.macyear_lbl.TabIndex = 11
        Me.macyear_lbl.Text = "Machine Year"
        '
        'erosion_gb
        '
        Me.erosion_gb.Controls.Add(Me.erosion_rb2)
        Me.erosion_gb.Controls.Add(Me.erosion_rb1)
        Me.erosion_gb.Location = New System.Drawing.Point(592, 110)
        Me.erosion_gb.Name = "erosion_gb"
        Me.erosion_gb.Size = New System.Drawing.Size(121, 47)
        Me.erosion_gb.TabIndex = 13
        Me.erosion_gb.TabStop = False
        Me.erosion_gb.Text = "Erosion"
        '
        'erosion_rb2
        '
        Me.erosion_rb2.AutoSize = True
        Me.erosion_rb2.Location = New System.Drawing.Point(68, 23)
        Me.erosion_rb2.Name = "erosion_rb2"
        Me.erosion_rb2.Size = New System.Drawing.Size(47, 21)
        Me.erosion_rb2.TabIndex = 1
        Me.erosion_rb2.TabStop = True
        Me.erosion_rb2.Text = "No"
        Me.erosion_rb2.UseVisualStyleBackColor = True
        '
        'erosion_rb1
        '
        Me.erosion_rb1.AutoSize = True
        Me.erosion_rb1.Location = New System.Drawing.Point(6, 23)
        Me.erosion_rb1.Name = "erosion_rb1"
        Me.erosion_rb1.Size = New System.Drawing.Size(53, 21)
        Me.erosion_rb1.TabIndex = 0
        Me.erosion_rb1.TabStop = True
        Me.erosion_rb1.Text = "Yes"
        Me.erosion_rb1.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.BackColor = System.Drawing.Color.Transparent
        Me.Exitbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exitbtn.FlatAppearance.BorderSize = 0
        Me.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exitbtn.ForeColor = System.Drawing.Color.Black
        Me.Exitbtn.Image = CType(resources.GetObject("Exitbtn.Image"), System.Drawing.Image)
        Me.Exitbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Exitbtn.Location = New System.Drawing.Point(35, 444)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(75, 79)
        Me.Exitbtn.TabIndex = 18
        Me.Exitbtn.Text = "   Back"
        Me.Exitbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Exitbtn.UseVisualStyleBackColor = False
        '
        'Alterbtn
        '
        Me.Alterbtn.BackColor = System.Drawing.Color.Transparent
        Me.Alterbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Alterbtn.FlatAppearance.BorderSize = 0
        Me.Alterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Alterbtn.ForeColor = System.Drawing.Color.Black
        Me.Alterbtn.Image = CType(resources.GetObject("Alterbtn.Image"), System.Drawing.Image)
        Me.Alterbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Alterbtn.Location = New System.Drawing.Point(35, 147)
        Me.Alterbtn.Name = "Alterbtn"
        Me.Alterbtn.Size = New System.Drawing.Size(75, 79)
        Me.Alterbtn.TabIndex = 17
        Me.Alterbtn.Text = "Alter"
        Me.Alterbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Alterbtn.UseVisualStyleBackColor = False
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.Transparent
        Me.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete_btn.FlatAppearance.BorderSize = 0
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_btn.ForeColor = System.Drawing.Color.Black
        Me.delete_btn.Image = CType(resources.GetObject("delete_btn.Image"), System.Drawing.Image)
        Me.delete_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.delete_btn.Location = New System.Drawing.Point(35, 39)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 79)
        Me.delete_btn.TabIndex = 16
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'create_btn
        '
        Me.create_btn.BackColor = System.Drawing.Color.Transparent
        Me.create_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.create_btn.FlatAppearance.BorderSize = 0
        Me.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.create_btn.ForeColor = System.Drawing.Color.Black
        Me.create_btn.Image = CType(resources.GetObject("create_btn.Image"), System.Drawing.Image)
        Me.create_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.create_btn.Location = New System.Drawing.Point(35, 249)
        Me.create_btn.Name = "create_btn"
        Me.create_btn.Size = New System.Drawing.Size(75, 79)
        Me.create_btn.TabIndex = 19
        Me.create_btn.Text = "Create"
        Me.create_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.create_btn.UseVisualStyleBackColor = False
        '
        'Refreshbtn
        '
        Me.Refreshbtn.BackColor = System.Drawing.Color.Transparent
        Me.Refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Refreshbtn.FlatAppearance.BorderSize = 0
        Me.Refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Refreshbtn.ForeColor = System.Drawing.Color.Black
        Me.Refreshbtn.Image = CType(resources.GetObject("Refreshbtn.Image"), System.Drawing.Image)
        Me.Refreshbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Refreshbtn.Location = New System.Drawing.Point(35, 345)
        Me.Refreshbtn.Name = "Refreshbtn"
        Me.Refreshbtn.Size = New System.Drawing.Size(75, 79)
        Me.Refreshbtn.TabIndex = 20
        Me.Refreshbtn.Text = "Refresh"
        Me.Refreshbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Refreshbtn.UseVisualStyleBackColor = False
        '
        'macyear_cb
        '
        Me.macyear_cb.FormattingEnabled = True
        Me.macyear_cb.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022"})
        Me.macyear_cb.Location = New System.Drawing.Point(398, 130)
        Me.macyear_cb.Name = "macyear_cb"
        Me.macyear_cb.Size = New System.Drawing.Size(121, 24)
        Me.macyear_cb.TabIndex = 21
        '
        'brand_btn
        '
        Me.brand_btn.BackColor = System.Drawing.Color.Transparent
        Me.brand_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.brand_btn.FlatAppearance.BorderSize = 0
        Me.brand_btn.Location = New System.Drawing.Point(214, 28)
        Me.brand_btn.Name = "brand_btn"
        Me.brand_btn.Size = New System.Drawing.Size(121, 29)
        Me.brand_btn.TabIndex = 22
        Me.brand_btn.Text = "Brand"
        Me.brand_btn.UseVisualStyleBackColor = False
        '
        'MachineDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 570)
        Me.Controls.Add(Me.brand_btn)
        Me.Controls.Add(Me.macyear_cb)
        Me.Controls.Add(Me.Refreshbtn)
        Me.Controls.Add(Me.create_btn)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Alterbtn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.erosion_gb)
        Me.Controls.Add(Me.macyear_lbl)
        Me.Controls.Add(Me.control_btn)
        Me.Controls.Add(Me.control_cb)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.mactype_btn)
        Me.Controls.Add(Me.mactype_cb)
        Me.Controls.Add(Me.macnumtxt)
        Me.Controls.Add(Me.macnumlbl)
        Me.Controls.Add(Me.brand_cb)
        Me.Name = "MachineDB"
        Me.Text = "Machine DB"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.erosion_gb.ResumeLayout(False)
        Me.erosion_gb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents brand_cb As ComboBox
    Friend WithEvents macnumlbl As Label
    Friend WithEvents macnumtxt As TextBox
    Friend WithEvents mactype_cb As ComboBox
    Friend WithEvents mactype_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents control_cb As ComboBox
    Friend WithEvents control_btn As Button
    Friend WithEvents macyear_lbl As Label
    Friend WithEvents erosion_gb As GroupBox
    Friend WithEvents erosion_rb2 As RadioButton
    Friend WithEvents erosion_rb1 As RadioButton
    Friend WithEvents Exitbtn As Button
    Friend WithEvents Alterbtn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents create_btn As Button
    Friend WithEvents Refreshbtn As Button
    Friend WithEvents macyear_cb As ComboBox
    Friend WithEvents brand_btn As Button
End Class
