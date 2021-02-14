<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDB))
        Me.control_lbl = New System.Windows.Forms.Label()
        Me.control_txt = New System.Windows.Forms.TextBox()
        Me.create_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.control_dgv = New System.Windows.Forms.DataGridView()
        Me.back_btn = New System.Windows.Forms.Button()
        CType(Me.control_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'control_lbl
        '
        Me.control_lbl.AutoSize = True
        Me.control_lbl.Location = New System.Drawing.Point(126, 24)
        Me.control_lbl.Name = "control_lbl"
        Me.control_lbl.Size = New System.Drawing.Size(53, 17)
        Me.control_lbl.TabIndex = 35
        Me.control_lbl.Text = "Control"
        '
        'control_txt
        '
        Me.control_txt.Location = New System.Drawing.Point(198, 21)
        Me.control_txt.Name = "control_txt"
        Me.control_txt.Size = New System.Drawing.Size(100, 22)
        Me.control_txt.TabIndex = 34
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
        Me.create_btn.Location = New System.Drawing.Point(26, 64)
        Me.create_btn.Name = "create_btn"
        Me.create_btn.Size = New System.Drawing.Size(75, 79)
        Me.create_btn.TabIndex = 33
        Me.create_btn.Text = "Create"
        Me.create_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.create_btn.UseVisualStyleBackColor = False
        '
        'refresh_btn
        '
        Me.refresh_btn.BackColor = System.Drawing.Color.Transparent
        Me.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refresh_btn.FlatAppearance.BorderSize = 0
        Me.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refresh_btn.ForeColor = System.Drawing.Color.Black
        Me.refresh_btn.Image = CType(resources.GetObject("refresh_btn.Image"), System.Drawing.Image)
        Me.refresh_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.refresh_btn.Location = New System.Drawing.Point(26, 194)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 79)
        Me.refresh_btn.TabIndex = 32
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.refresh_btn.UseVisualStyleBackColor = False
        '
        'control_dgv
        '
        Me.control_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.control_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.control_dgv.Location = New System.Drawing.Point(129, 64)
        Me.control_dgv.Name = "control_dgv"
        Me.control_dgv.RowHeadersWidth = 51
        Me.control_dgv.RowTemplate.Height = 24
        Me.control_dgv.Size = New System.Drawing.Size(277, 329)
        Me.control_dgv.TabIndex = 31
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Transparent
        Me.back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_btn.FlatAppearance.BorderSize = 0
        Me.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_btn.ForeColor = System.Drawing.Color.Black
        Me.back_btn.Image = CType(resources.GetObject("back_btn.Image"), System.Drawing.Image)
        Me.back_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.back_btn.Location = New System.Drawing.Point(17, 314)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(75, 79)
        Me.back_btn.TabIndex = 30
        Me.back_btn.Text = "   Back"
        Me.back_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'ControlDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 450)
        Me.Controls.Add(Me.control_lbl)
        Me.Controls.Add(Me.control_txt)
        Me.Controls.Add(Me.create_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.control_dgv)
        Me.Controls.Add(Me.back_btn)
        Me.Name = "ControlDB"
        Me.Text = "Control DB"
        CType(Me.control_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents control_lbl As Label
    Friend WithEvents control_txt As TextBox
    Friend WithEvents create_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents control_dgv As DataGridView
    Friend WithEvents back_btn As Button
End Class
