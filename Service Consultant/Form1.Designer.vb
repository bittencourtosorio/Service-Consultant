<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.carregabtn = New System.Windows.Forms.Button()
        Me.userbtn = New System.Windows.Forms.Button()
        Me.Sairbtn = New System.Windows.Forms.Button()
        Me.Filtroslabel = New System.Windows.Forms.Label()
        Me.Clientelabel = New System.Windows.Forms.Label()
        Me.Maquinalabel = New System.Windows.Forms.Label()
        Me.Datalabel = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Clientetext = New System.Windows.Forms.TextBox()
        Me.maquinatext = New System.Windows.Forms.TextBox()
        Me.Limpabtn = New System.Windows.Forms.Button()
        Me.abertoradio = New System.Windows.Forms.RadioButton()
        Me.fechadoradio = New System.Windows.Forms.RadioButton()
        Me.todosradio = New System.Windows.Forms.RadioButton()
        Me.graficobtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBoxconnect = New System.Windows.Forms.PictureBox()
        Me.PictureBoxdisconnect = New System.Windows.Forms.PictureBox()
        Me.disconnectbtn = New System.Windows.Forms.Button()
        Me.Filterbtn = New System.Windows.Forms.Button()
        Me.Createbtn = New System.Windows.Forms.Button()
        Me.deletabtn = New System.Windows.Forms.Button()
        Me.Err_db_btn = New System.Windows.Forms.Button()
        Me.Mac_db_btn = New System.Windows.Forms.Button()
        Me.Cust_db_btn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxconnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxdisconnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'carregabtn
        '
        Me.carregabtn.AutoSize = True
        Me.carregabtn.BackColor = System.Drawing.Color.Transparent
        Me.carregabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.carregabtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.carregabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.carregabtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carregabtn.ForeColor = System.Drawing.SystemColors.Control
        Me.carregabtn.Image = CType(resources.GetObject("carregabtn.Image"), System.Drawing.Image)
        Me.carregabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.carregabtn.Location = New System.Drawing.Point(1137, 10)
        Me.carregabtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.carregabtn.Name = "carregabtn"
        Me.carregabtn.Size = New System.Drawing.Size(105, 40)
        Me.carregabtn.TabIndex = 2
        Me.carregabtn.Text = "Connect"
        Me.carregabtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.carregabtn.UseVisualStyleBackColor = False
        '
        'userbtn
        '
        Me.userbtn.AutoSize = True
        Me.userbtn.BackColor = System.Drawing.Color.Transparent
        Me.userbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.userbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.userbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.userbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.userbtn.Image = CType(resources.GetObject("userbtn.Image"), System.Drawing.Image)
        Me.userbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.userbtn.Location = New System.Drawing.Point(22, 167)
        Me.userbtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.userbtn.Name = "userbtn"
        Me.userbtn.Size = New System.Drawing.Size(82, 40)
        Me.userbtn.TabIndex = 3
        Me.userbtn.Text = "User"
        Me.userbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userbtn.UseVisualStyleBackColor = False
        '
        'Sairbtn
        '
        Me.Sairbtn.AutoSize = True
        Me.Sairbtn.BackColor = System.Drawing.Color.Transparent
        Me.Sairbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Sairbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sairbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sairbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sairbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Sairbtn.Image = CType(resources.GetObject("Sairbtn.Image"), System.Drawing.Image)
        Me.Sairbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sairbtn.Location = New System.Drawing.Point(22, 731)
        Me.Sairbtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Sairbtn.Name = "Sairbtn"
        Me.Sairbtn.Size = New System.Drawing.Size(82, 40)
        Me.Sairbtn.TabIndex = 4
        Me.Sairbtn.Text = "Exit"
        Me.Sairbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Sairbtn.UseVisualStyleBackColor = False
        '
        'Filtroslabel
        '
        Me.Filtroslabel.AutoSize = True
        Me.Filtroslabel.BackColor = System.Drawing.Color.Transparent
        Me.Filtroslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtroslabel.ForeColor = System.Drawing.SystemColors.Control
        Me.Filtroslabel.Location = New System.Drawing.Point(764, 7)
        Me.Filtroslabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Filtroslabel.Name = "Filtroslabel"
        Me.Filtroslabel.Size = New System.Drawing.Size(78, 26)
        Me.Filtroslabel.TabIndex = 6
        Me.Filtroslabel.Text = "Filters"
        '
        'Clientelabel
        '
        Me.Clientelabel.AutoSize = True
        Me.Clientelabel.BackColor = System.Drawing.Color.Transparent
        Me.Clientelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clientelabel.ForeColor = System.Drawing.SystemColors.Control
        Me.Clientelabel.Location = New System.Drawing.Point(356, 55)
        Me.Clientelabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Clientelabel.Name = "Clientelabel"
        Me.Clientelabel.Size = New System.Drawing.Size(86, 20)
        Me.Clientelabel.TabIndex = 7
        Me.Clientelabel.Text = "Customer"
        '
        'Maquinalabel
        '
        Me.Maquinalabel.AutoSize = True
        Me.Maquinalabel.BackColor = System.Drawing.Color.Transparent
        Me.Maquinalabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maquinalabel.ForeColor = System.Drawing.SystemColors.Control
        Me.Maquinalabel.Location = New System.Drawing.Point(728, 54)
        Me.Maquinalabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Maquinalabel.Name = "Maquinalabel"
        Me.Maquinalabel.Size = New System.Drawing.Size(76, 20)
        Me.Maquinalabel.TabIndex = 8
        Me.Maquinalabel.Text = "Machine"
        '
        'Datalabel
        '
        Me.Datalabel.AutoSize = True
        Me.Datalabel.BackColor = System.Drawing.Color.Transparent
        Me.Datalabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datalabel.ForeColor = System.Drawing.SystemColors.Control
        Me.Datalabel.Location = New System.Drawing.Point(989, 55)
        Me.Datalabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Datalabel.Name = "Datalabel"
        Me.Datalabel.Size = New System.Drawing.Size(48, 20)
        Me.Datalabel.TabIndex = 9
        Me.Datalabel.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1048, 56)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Clientetext
        '
        Me.Clientetext.Location = New System.Drawing.Point(442, 56)
        Me.Clientetext.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Clientetext.Name = "Clientetext"
        Me.Clientetext.Size = New System.Drawing.Size(186, 20)
        Me.Clientetext.TabIndex = 11
        '
        'maquinatext
        '
        Me.maquinatext.Location = New System.Drawing.Point(803, 55)
        Me.maquinatext.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.maquinatext.Name = "maquinatext"
        Me.maquinatext.Size = New System.Drawing.Size(84, 20)
        Me.maquinatext.TabIndex = 12
        '
        'Limpabtn
        '
        Me.Limpabtn.AutoSize = True
        Me.Limpabtn.BackColor = System.Drawing.Color.Transparent
        Me.Limpabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Limpabtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Limpabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Limpabtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpabtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Limpabtn.Image = CType(resources.GetObject("Limpabtn.Image"), System.Drawing.Image)
        Me.Limpabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Limpabtn.Location = New System.Drawing.Point(1020, 93)
        Me.Limpabtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Limpabtn.Name = "Limpabtn"
        Me.Limpabtn.Size = New System.Drawing.Size(82, 40)
        Me.Limpabtn.TabIndex = 13
        Me.Limpabtn.Text = "Clear"
        Me.Limpabtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Limpabtn.UseVisualStyleBackColor = False
        '
        'abertoradio
        '
        Me.abertoradio.AutoSize = True
        Me.abertoradio.BackColor = System.Drawing.Color.Transparent
        Me.abertoradio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abertoradio.ForeColor = System.Drawing.SystemColors.Control
        Me.abertoradio.Location = New System.Drawing.Point(442, 95)
        Me.abertoradio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.abertoradio.Name = "abertoradio"
        Me.abertoradio.Size = New System.Drawing.Size(66, 24)
        Me.abertoradio.TabIndex = 14
        Me.abertoradio.TabStop = True
        Me.abertoradio.Text = "Open"
        Me.abertoradio.UseVisualStyleBackColor = False
        '
        'fechadoradio
        '
        Me.fechadoradio.AutoSize = True
        Me.fechadoradio.BackColor = System.Drawing.Color.Transparent
        Me.fechadoradio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechadoradio.ForeColor = System.Drawing.SystemColors.Control
        Me.fechadoradio.Location = New System.Drawing.Point(615, 95)
        Me.fechadoradio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.fechadoradio.Name = "fechadoradio"
        Me.fechadoradio.Size = New System.Drawing.Size(76, 24)
        Me.fechadoradio.TabIndex = 15
        Me.fechadoradio.TabStop = True
        Me.fechadoradio.Text = "Closed"
        Me.fechadoradio.UseVisualStyleBackColor = False
        '
        'todosradio
        '
        Me.todosradio.AutoSize = True
        Me.todosradio.BackColor = System.Drawing.Color.Transparent
        Me.todosradio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todosradio.ForeColor = System.Drawing.SystemColors.Control
        Me.todosradio.Location = New System.Drawing.Point(788, 95)
        Me.todosradio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.todosradio.Name = "todosradio"
        Me.todosradio.Size = New System.Drawing.Size(44, 24)
        Me.todosradio.TabIndex = 16
        Me.todosradio.TabStop = True
        Me.todosradio.Text = "All"
        Me.todosradio.UseVisualStyleBackColor = False
        '
        'graficobtn
        '
        Me.graficobtn.AutoSize = True
        Me.graficobtn.BackColor = System.Drawing.Color.Transparent
        Me.graficobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.graficobtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.graficobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.graficobtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.graficobtn.ForeColor = System.Drawing.SystemColors.Control
        Me.graficobtn.Image = CType(resources.GetObject("graficobtn.Image"), System.Drawing.Image)
        Me.graficobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.graficobtn.Location = New System.Drawing.Point(22, 225)
        Me.graficobtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.graficobtn.Name = "graficobtn"
        Me.graficobtn.Size = New System.Drawing.Size(82, 40)
        Me.graficobtn.TabIndex = 17
        Me.graficobtn.Text = "Graphic"
        Me.graficobtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.graficobtn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(408, 140)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(794, 207)
        Me.DataGridView1.TabIndex = 18
        '
        'PictureBoxconnect
        '
        Me.PictureBoxconnect.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxconnect.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxconnect.Image = CType(resources.GetObject("PictureBoxconnect.Image"), System.Drawing.Image)
        Me.PictureBoxconnect.Location = New System.Drawing.Point(1161, 0)
        Me.PictureBoxconnect.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxconnect.Name = "PictureBoxconnect"
        Me.PictureBoxconnect.Size = New System.Drawing.Size(55, 54)
        Me.PictureBoxconnect.TabIndex = 19
        Me.PictureBoxconnect.TabStop = False
        '
        'PictureBoxdisconnect
        '
        Me.PictureBoxdisconnect.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxdisconnect.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxdisconnect.Image = CType(resources.GetObject("PictureBoxdisconnect.Image"), System.Drawing.Image)
        Me.PictureBoxdisconnect.Location = New System.Drawing.Point(1161, 0)
        Me.PictureBoxdisconnect.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxdisconnect.Name = "PictureBoxdisconnect"
        Me.PictureBoxdisconnect.Size = New System.Drawing.Size(57, 51)
        Me.PictureBoxdisconnect.TabIndex = 20
        Me.PictureBoxdisconnect.TabStop = False
        '
        'disconnectbtn
        '
        Me.disconnectbtn.AutoSize = True
        Me.disconnectbtn.BackColor = System.Drawing.Color.Transparent
        Me.disconnectbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.disconnectbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.disconnectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.disconnectbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disconnectbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.disconnectbtn.Image = CType(resources.GetObject("disconnectbtn.Image"), System.Drawing.Image)
        Me.disconnectbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.disconnectbtn.Location = New System.Drawing.Point(1137, 10)
        Me.disconnectbtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.disconnectbtn.Name = "disconnectbtn"
        Me.disconnectbtn.Size = New System.Drawing.Size(105, 40)
        Me.disconnectbtn.TabIndex = 21
        Me.disconnectbtn.Text = "Disconnect"
        Me.disconnectbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.disconnectbtn.UseVisualStyleBackColor = False
        '
        'Filterbtn
        '
        Me.Filterbtn.AutoSize = True
        Me.Filterbtn.BackColor = System.Drawing.Color.Transparent
        Me.Filterbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Filterbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Filterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Filterbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filterbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Filterbtn.Image = CType(resources.GetObject("Filterbtn.Image"), System.Drawing.Image)
        Me.Filterbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Filterbtn.Location = New System.Drawing.Point(896, 93)
        Me.Filterbtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Filterbtn.Name = "Filterbtn"
        Me.Filterbtn.Size = New System.Drawing.Size(82, 40)
        Me.Filterbtn.TabIndex = 23
        Me.Filterbtn.Text = "Apply"
        Me.Filterbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Filterbtn.UseVisualStyleBackColor = False
        '
        'Createbtn
        '
        Me.Createbtn.AutoSize = True
        Me.Createbtn.BackColor = System.Drawing.Color.Transparent
        Me.Createbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Createbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Createbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Createbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Createbtn.Image = CType(resources.GetObject("Createbtn.Image"), System.Drawing.Image)
        Me.Createbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Createbtn.Location = New System.Drawing.Point(22, 79)
        Me.Createbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Createbtn.Name = "Createbtn"
        Me.Createbtn.Size = New System.Drawing.Size(82, 40)
        Me.Createbtn.TabIndex = 22
        Me.Createbtn.Text = "Create"
        Me.Createbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Createbtn.UseVisualStyleBackColor = False
        '
        'deletabtn
        '
        Me.deletabtn.AutoSize = True
        Me.deletabtn.BackColor = System.Drawing.Color.Transparent
        Me.deletabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.deletabtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deletabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deletabtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletabtn.ForeColor = System.Drawing.SystemColors.Control
        Me.deletabtn.Image = CType(resources.GetObject("deletabtn.Image"), System.Drawing.Image)
        Me.deletabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.deletabtn.Location = New System.Drawing.Point(22, 23)
        Me.deletabtn.Margin = New System.Windows.Forms.Padding(2)
        Me.deletabtn.Name = "deletabtn"
        Me.deletabtn.Size = New System.Drawing.Size(82, 40)
        Me.deletabtn.TabIndex = 1
        Me.deletabtn.Text = "Delete"
        Me.deletabtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deletabtn.UseVisualStyleBackColor = False
        '
        'Err_db_btn
        '
        Me.Err_db_btn.AutoSize = True
        Me.Err_db_btn.BackColor = System.Drawing.Color.Transparent
        Me.Err_db_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Err_db_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Err_db_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Err_db_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Err_db_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.Err_db_btn.Image = CType(resources.GetObject("Err_db_btn.Image"), System.Drawing.Image)
        Me.Err_db_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Err_db_btn.Location = New System.Drawing.Point(22, 307)
        Me.Err_db_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Err_db_btn.Name = "Err_db_btn"
        Me.Err_db_btn.Size = New System.Drawing.Size(120, 40)
        Me.Err_db_btn.TabIndex = 24
        Me.Err_db_btn.Text = "Error DB"
        Me.Err_db_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Err_db_btn.UseVisualStyleBackColor = False
        '
        'Mac_db_btn
        '
        Me.Mac_db_btn.AutoSize = True
        Me.Mac_db_btn.BackColor = System.Drawing.Color.Transparent
        Me.Mac_db_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Mac_db_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Mac_db_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mac_db_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac_db_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.Mac_db_btn.Image = CType(resources.GetObject("Mac_db_btn.Image"), System.Drawing.Image)
        Me.Mac_db_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Mac_db_btn.Location = New System.Drawing.Point(22, 365)
        Me.Mac_db_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Mac_db_btn.Name = "Mac_db_btn"
        Me.Mac_db_btn.Size = New System.Drawing.Size(120, 40)
        Me.Mac_db_btn.TabIndex = 25
        Me.Mac_db_btn.Text = "Machine DB"
        Me.Mac_db_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Mac_db_btn.UseVisualStyleBackColor = False
        '
        'Cust_db_btn
        '
        Me.Cust_db_btn.AutoSize = True
        Me.Cust_db_btn.BackColor = System.Drawing.Color.Transparent
        Me.Cust_db_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cust_db_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cust_db_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cust_db_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cust_db_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.Cust_db_btn.Image = CType(resources.GetObject("Cust_db_btn.Image"), System.Drawing.Image)
        Me.Cust_db_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cust_db_btn.Location = New System.Drawing.Point(22, 420)
        Me.Cust_db_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Cust_db_btn.Name = "Cust_db_btn"
        Me.Cust_db_btn.Size = New System.Drawing.Size(120, 40)
        Me.Cust_db_btn.TabIndex = 26
        Me.Cust_db_btn.Text = "Customer DB"
        Me.Cust_db_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cust_db_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1155, 687)
        Me.Controls.Add(Me.Cust_db_btn)
        Me.Controls.Add(Me.Mac_db_btn)
        Me.Controls.Add(Me.Err_db_btn)
        Me.Controls.Add(Me.Createbtn)
        Me.Controls.Add(Me.deletabtn)
        Me.Controls.Add(Me.Filterbtn)
        Me.Controls.Add(Me.disconnectbtn)
        Me.Controls.Add(Me.PictureBoxdisconnect)
        Me.Controls.Add(Me.PictureBoxconnect)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.graficobtn)
        Me.Controls.Add(Me.todosradio)
        Me.Controls.Add(Me.fechadoradio)
        Me.Controls.Add(Me.abertoradio)
        Me.Controls.Add(Me.Limpabtn)
        Me.Controls.Add(Me.maquinatext)
        Me.Controls.Add(Me.Clientetext)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Datalabel)
        Me.Controls.Add(Me.Maquinalabel)
        Me.Controls.Add(Me.Clientelabel)
        Me.Controls.Add(Me.Filtroslabel)
        Me.Controls.Add(Me.Sairbtn)
        Me.Controls.Add(Me.userbtn)
        Me.Controls.Add(Me.carregabtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Service Consultant"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxconnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxdisconnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents carregabtn As Button
    Friend WithEvents userbtn As Button
    Friend WithEvents Sairbtn As Button
    Friend WithEvents Filtroslabel As Label
    Friend WithEvents Clientelabel As Label
    Friend WithEvents Maquinalabel As Label
    Friend WithEvents Datalabel As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Clientetext As TextBox
    Friend WithEvents maquinatext As TextBox
    Friend WithEvents Limpabtn As Button
    Friend WithEvents abertoradio As RadioButton
    Friend WithEvents fechadoradio As RadioButton
    Friend WithEvents todosradio As RadioButton
    Friend WithEvents graficobtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBoxconnect As PictureBox
    Friend WithEvents PictureBoxdisconnect As PictureBox
    Friend WithEvents disconnectbtn As Button
    Friend WithEvents Filterbtn As Button
    Friend WithEvents Createbtn As Button
    Friend WithEvents deletabtn As Button
    Friend WithEvents Err_db_btn As Button
    Friend WithEvents Mac_db_btn As Button
    Friend WithEvents Cust_db_btn As Button
End Class
