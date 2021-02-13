<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Create_btn = New System.Windows.Forms.Button()
        Me.Err_numb_lbl = New System.Windows.Forms.Label()
        Me.Err_typ_lbl = New System.Windows.Forms.Label()
        Me.Err_desc_lbl = New System.Windows.Forms.Label()
        Me.Radio_elec = New System.Windows.Forms.RadioButton()
        Me.Radio_mec = New System.Windows.Forms.RadioButton()
        Me.Radio_soft = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Create_btn
        '
        Me.Create_btn.Location = New System.Drawing.Point(12, 57)
        Me.Create_btn.Name = "Create_btn"
        Me.Create_btn.Size = New System.Drawing.Size(75, 23)
        Me.Create_btn.TabIndex = 0
        Me.Create_btn.Text = "Create"
        Me.Create_btn.UseVisualStyleBackColor = True
        '
        'Err_numb_lbl
        '
        Me.Err_numb_lbl.AutoSize = True
        Me.Err_numb_lbl.Location = New System.Drawing.Point(108, 32)
        Me.Err_numb_lbl.Name = "Err_numb_lbl"
        Me.Err_numb_lbl.Size = New System.Drawing.Size(69, 13)
        Me.Err_numb_lbl.TabIndex = 1
        Me.Err_numb_lbl.Text = "Error Number"
        '
        'Err_typ_lbl
        '
        Me.Err_typ_lbl.AutoSize = True
        Me.Err_typ_lbl.Location = New System.Drawing.Point(108, 104)
        Me.Err_typ_lbl.Name = "Err_typ_lbl"
        Me.Err_typ_lbl.Size = New System.Drawing.Size(56, 13)
        Me.Err_typ_lbl.TabIndex = 2
        Me.Err_typ_lbl.Text = "Error Type"
        '
        'Err_desc_lbl
        '
        Me.Err_desc_lbl.AutoSize = True
        Me.Err_desc_lbl.Location = New System.Drawing.Point(108, 175)
        Me.Err_desc_lbl.Name = "Err_desc_lbl"
        Me.Err_desc_lbl.Size = New System.Drawing.Size(85, 13)
        Me.Err_desc_lbl.TabIndex = 3
        Me.Err_desc_lbl.Text = "Error Description"
        '
        'Radio_elec
        '
        Me.Radio_elec.AutoSize = True
        Me.Radio_elec.Location = New System.Drawing.Point(111, 136)
        Me.Radio_elec.Name = "Radio_elec"
        Me.Radio_elec.Size = New System.Drawing.Size(60, 17)
        Me.Radio_elec.TabIndex = 4
        Me.Radio_elec.TabStop = True
        Me.Radio_elec.Text = "Electric"
        Me.Radio_elec.UseVisualStyleBackColor = True
        '
        'Radio_mec
        '
        Me.Radio_mec.AutoSize = True
        Me.Radio_mec.Location = New System.Drawing.Point(227, 136)
        Me.Radio_mec.Name = "Radio_mec"
        Me.Radio_mec.Size = New System.Drawing.Size(72, 17)
        Me.Radio_mec.TabIndex = 5
        Me.Radio_mec.TabStop = True
        Me.Radio_mec.Text = "Mechanic"
        Me.Radio_mec.UseVisualStyleBackColor = True
        '
        'Radio_soft
        '
        Me.Radio_soft.AutoSize = True
        Me.Radio_soft.Location = New System.Drawing.Point(341, 136)
        Me.Radio_soft.Name = "Radio_soft"
        Me.Radio_soft.Size = New System.Drawing.Size(67, 17)
        Me.Radio_soft.TabIndex = 6
        Me.Radio_soft.TabStop = True
        Me.Radio_soft.Text = "Software"
        Me.Radio_soft.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(111, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(111, 200)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(298, 128)
        Me.TextBox2.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 374)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Radio_soft)
        Me.Controls.Add(Me.Radio_mec)
        Me.Controls.Add(Me.Radio_elec)
        Me.Controls.Add(Me.Err_desc_lbl)
        Me.Controls.Add(Me.Err_typ_lbl)
        Me.Controls.Add(Me.Err_numb_lbl)
        Me.Controls.Add(Me.Create_btn)
        Me.Name = "Form2"
        Me.Text = "Error Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Create_btn As Button
    Friend WithEvents Err_numb_lbl As Label
    Friend WithEvents Err_typ_lbl As Label
    Friend WithEvents Err_desc_lbl As Label
    Friend WithEvents Radio_elec As RadioButton
    Friend WithEvents Radio_mec As RadioButton
    Friend WithEvents Radio_soft As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
