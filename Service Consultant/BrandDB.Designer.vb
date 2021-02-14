<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrandDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrandDB))
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.brand_dgv = New System.Windows.Forms.DataGridView()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.create_btn = New System.Windows.Forms.Button()
        Me.brand_txt = New System.Windows.Forms.TextBox()
        Me.brand_lbl = New System.Windows.Forms.Label()
        CType(Me.brand_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.refresh_btn.Location = New System.Drawing.Point(29, 195)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 79)
        Me.refresh_btn.TabIndex = 20
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.refresh_btn.UseVisualStyleBackColor = False
        '
        'brand_dgv
        '
        Me.brand_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.brand_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.brand_dgv.Location = New System.Drawing.Point(132, 65)
        Me.brand_dgv.Name = "brand_dgv"
        Me.brand_dgv.RowHeadersWidth = 51
        Me.brand_dgv.RowTemplate.Height = 24
        Me.brand_dgv.Size = New System.Drawing.Size(277, 329)
        Me.brand_dgv.TabIndex = 19
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
        Me.back_btn.Location = New System.Drawing.Point(20, 315)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(75, 79)
        Me.back_btn.TabIndex = 18
        Me.back_btn.Text = "   Back"
        Me.back_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.back_btn.UseVisualStyleBackColor = False
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
        Me.create_btn.Location = New System.Drawing.Point(29, 65)
        Me.create_btn.Name = "create_btn"
        Me.create_btn.Size = New System.Drawing.Size(75, 79)
        Me.create_btn.TabIndex = 21
        Me.create_btn.Text = "Create"
        Me.create_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.create_btn.UseVisualStyleBackColor = False
        '
        'brand_txt
        '
        Me.brand_txt.Location = New System.Drawing.Point(201, 22)
        Me.brand_txt.Name = "brand_txt"
        Me.brand_txt.Size = New System.Drawing.Size(100, 22)
        Me.brand_txt.TabIndex = 22
        '
        'brand_lbl
        '
        Me.brand_lbl.AutoSize = True
        Me.brand_lbl.Location = New System.Drawing.Point(129, 25)
        Me.brand_lbl.Name = "brand_lbl"
        Me.brand_lbl.Size = New System.Drawing.Size(46, 17)
        Me.brand_lbl.TabIndex = 23
        Me.brand_lbl.Text = "Brand"
        '
        'BrandDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 415)
        Me.Controls.Add(Me.brand_lbl)
        Me.Controls.Add(Me.brand_txt)
        Me.Controls.Add(Me.create_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.brand_dgv)
        Me.Controls.Add(Me.back_btn)
        Me.Name = "BrandDB"
        Me.Text = "Brand DB"
        CType(Me.brand_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents refresh_btn As Button
    Friend WithEvents brand_dgv As DataGridView
    Friend WithEvents back_btn As Button
    Friend WithEvents create_btn As Button
    Friend WithEvents brand_txt As TextBox
    Friend WithEvents brand_lbl As Label
End Class
