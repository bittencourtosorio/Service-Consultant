<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypeDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TypeDB))
        Me.type_lbl = New System.Windows.Forms.Label()
        Me.type_txt = New System.Windows.Forms.TextBox()
        Me.create_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.type_dgv = New System.Windows.Forms.DataGridView()
        Me.back_btn = New System.Windows.Forms.Button()
        CType(Me.type_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'type_lbl
        '
        Me.type_lbl.AutoSize = True
        Me.type_lbl.Location = New System.Drawing.Point(123, 18)
        Me.type_lbl.Name = "type_lbl"
        Me.type_lbl.Size = New System.Drawing.Size(40, 17)
        Me.type_lbl.TabIndex = 29
        Me.type_lbl.Text = "Type"
        '
        'type_txt
        '
        Me.type_txt.Location = New System.Drawing.Point(195, 15)
        Me.type_txt.Name = "type_txt"
        Me.type_txt.Size = New System.Drawing.Size(100, 22)
        Me.type_txt.TabIndex = 28
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
        Me.create_btn.Location = New System.Drawing.Point(23, 58)
        Me.create_btn.Name = "create_btn"
        Me.create_btn.Size = New System.Drawing.Size(75, 79)
        Me.create_btn.TabIndex = 27
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
        Me.refresh_btn.Location = New System.Drawing.Point(23, 188)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 79)
        Me.refresh_btn.TabIndex = 26
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.refresh_btn.UseVisualStyleBackColor = False
        '
        'type_dgv
        '
        Me.type_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.type_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.type_dgv.Location = New System.Drawing.Point(126, 58)
        Me.type_dgv.Name = "type_dgv"
        Me.type_dgv.RowHeadersWidth = 51
        Me.type_dgv.RowTemplate.Height = 24
        Me.type_dgv.Size = New System.Drawing.Size(277, 329)
        Me.type_dgv.TabIndex = 25
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
        Me.back_btn.Location = New System.Drawing.Point(14, 308)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(75, 79)
        Me.back_btn.TabIndex = 24
        Me.back_btn.Text = "   Back"
        Me.back_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'TypeDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 450)
        Me.Controls.Add(Me.type_lbl)
        Me.Controls.Add(Me.type_txt)
        Me.Controls.Add(Me.create_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.type_dgv)
        Me.Controls.Add(Me.back_btn)
        Me.Name = "TypeDB"
        Me.Text = "Type DB"
        CType(Me.type_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents type_lbl As Label
    Friend WithEvents type_txt As TextBox
    Friend WithEvents create_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents type_dgv As DataGridView
    Friend WithEvents back_btn As Button
End Class
