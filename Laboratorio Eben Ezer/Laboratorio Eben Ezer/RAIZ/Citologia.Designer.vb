<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citologia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAddClientes = New System.Windows.Forms.Button()
        Me.BtnAddMedico = New System.Windows.Forms.Button()
        Me.TxtMedico = New System.Windows.Forms.TextBox()
        Me.Medico = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.CmbGenero = New System.Windows.Forms.ComboBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdMedico = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpToma = New System.Windows.Forms.DateTimePicker()
        Me.DtpRecibo = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpInforme = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtEndo = New System.Windows.Forms.TextBox()
        Me.TxtInadecuada = New System.Windows.Forms.TextBox()
        Me.TxtAdecuada = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbNegativo = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmbOtro = New System.Windows.Forms.ComboBox()
        Me.CmbFlora = New System.Windows.Forms.ComboBox()
        Me.CmbReaccion = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.CmbSugerencia = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnQuimicaG = New System.Windows.Forms.Button()
        Me.TxtIdResultado = New System.Windows.Forms.TextBox()
        Me.TxtObservacionC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(121, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(922, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INFORME DE CITOLOGIA CERVICO UTERINO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAddClientes)
        Me.GroupBox1.Controls.Add(Me.BtnAddMedico)
        Me.GroupBox1.Controls.Add(Me.TxtMedico)
        Me.GroupBox1.Controls.Add(Me.Medico)
        Me.GroupBox1.Controls.Add(Me.TxtId)
        Me.GroupBox1.Controls.Add(Me.CmbGenero)
        Me.GroupBox1.Controls.Add(Me.TxtEdad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtIdMedico)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 108)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'BtnAddClientes
        '
        Me.BtnAddClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnAddClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnAddClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddClientes.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddClientes.ForeColor = System.Drawing.Color.White
        Me.BtnAddClientes.Location = New System.Drawing.Point(392, 28)
        Me.BtnAddClientes.Name = "BtnAddClientes"
        Me.BtnAddClientes.Size = New System.Drawing.Size(28, 25)
        Me.BtnAddClientes.TabIndex = 11
        Me.BtnAddClientes.Text = "..."
        Me.BtnAddClientes.UseVisualStyleBackColor = False
        '
        'BtnAddMedico
        '
        Me.BtnAddMedico.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnAddMedico.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnAddMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddMedico.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddMedico.ForeColor = System.Drawing.Color.White
        Me.BtnAddMedico.Location = New System.Drawing.Point(392, 65)
        Me.BtnAddMedico.Name = "BtnAddMedico"
        Me.BtnAddMedico.Size = New System.Drawing.Size(28, 25)
        Me.BtnAddMedico.TabIndex = 10
        Me.BtnAddMedico.Text = "..."
        Me.BtnAddMedico.UseVisualStyleBackColor = False
        '
        'TxtMedico
        '
        Me.TxtMedico.Location = New System.Drawing.Point(119, 68)
        Me.TxtMedico.Name = "TxtMedico"
        Me.TxtMedico.Size = New System.Drawing.Size(267, 22)
        Me.TxtMedico.TabIndex = 9
        '
        'Medico
        '
        Me.Medico.AutoSize = True
        Me.Medico.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Medico.Location = New System.Drawing.Point(32, 67)
        Me.Medico.Name = "Medico"
        Me.Medico.Size = New System.Drawing.Size(99, 23)
        Me.Medico.TabIndex = 8
        Me.Medico.Text = "MEDICO:"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(392, 31)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 22)
        Me.TxtId.TabIndex = 7
        Me.TxtId.Visible = False
        '
        'CmbGenero
        '
        Me.CmbGenero.FormattingEnabled = True
        Me.CmbGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.CmbGenero.Location = New System.Drawing.Point(650, 31)
        Me.CmbGenero.Name = "CmbGenero"
        Me.CmbGenero.Size = New System.Drawing.Size(121, 24)
        Me.CmbGenero.TabIndex = 6
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(650, 68)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(121, 22)
        Me.TxtEdad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(585, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "EDAD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(562, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "GENERO:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(119, 31)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(267, 22)
        Me.TxtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NOMBRE:"
        '
        'TxtIdMedico
        '
        Me.TxtIdMedico.Location = New System.Drawing.Point(392, 68)
        Me.TxtIdMedico.Name = "TxtIdMedico"
        Me.TxtIdMedico.Size = New System.Drawing.Size(100, 22)
        Me.TxtIdMedico.TabIndex = 14
        Me.TxtIdMedico.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(11, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "FECHA DE TOMA:"
        '
        'DtpToma
        '
        Me.DtpToma.CustomFormat = "dd/MMMM/yyyy"
        Me.DtpToma.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpToma.Location = New System.Drawing.Point(160, 237)
        Me.DtpToma.Name = "DtpToma"
        Me.DtpToma.Size = New System.Drawing.Size(110, 22)
        Me.DtpToma.TabIndex = 15
        Me.DtpToma.Value = New Date(2022, 7, 13, 0, 0, 0, 0)
        '
        'DtpRecibo
        '
        Me.DtpRecibo.CustomFormat = "dd/MMMM/yyyy"
        Me.DtpRecibo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpRecibo.Location = New System.Drawing.Point(514, 237)
        Me.DtpRecibo.Name = "DtpRecibo"
        Me.DtpRecibo.Size = New System.Drawing.Size(102, 22)
        Me.DtpRecibo.TabIndex = 17
        Me.DtpRecibo.Value = New Date(2022, 7, 13, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(336, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(218, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "FECHA DE RECIBIDO:"
        '
        'DtpInforme
        '
        Me.DtpInforme.CustomFormat = "dd/MMMM/yyyy"
        Me.DtpInforme.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpInforme.Location = New System.Drawing.Point(860, 237)
        Me.DtpInforme.Name = "DtpInforme"
        Me.DtpInforme.Size = New System.Drawing.Size(102, 22)
        Me.DtpInforme.TabIndex = 19
        Me.DtpInforme.Value = New Date(2022, 7, 13, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(680, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 23)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "FECHA DE INFORME:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(7, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(221, 23)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "CALIDAD DEL FROTIS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtEndo)
        Me.GroupBox2.Controls.Add(Me.TxtInadecuada)
        Me.GroupBox2.Controls.Add(Me.TxtAdecuada)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(966, 67)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'TxtEndo
        '
        Me.TxtEndo.Location = New System.Drawing.Point(835, 31)
        Me.TxtEndo.Name = "TxtEndo"
        Me.TxtEndo.Size = New System.Drawing.Size(100, 22)
        Me.TxtEndo.TabIndex = 24
        '
        'TxtInadecuada
        '
        Me.TxtInadecuada.Location = New System.Drawing.Point(555, 31)
        Me.TxtInadecuada.Name = "TxtInadecuada"
        Me.TxtInadecuada.Size = New System.Drawing.Size(100, 22)
        Me.TxtInadecuada.TabIndex = 23
        '
        'TxtAdecuada
        '
        Me.TxtAdecuada.Location = New System.Drawing.Point(315, 31)
        Me.TxtAdecuada.Name = "TxtAdecuada"
        Me.TxtAdecuada.Size = New System.Drawing.Size(100, 22)
        Me.TxtAdecuada.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(714, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 23)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Endocervicales:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(458, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 23)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Inadecuada:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(229, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Adecuada:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbNegativo)
        Me.GroupBox3.Location = New System.Drawing.Point(160, 348)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(818, 45)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'CmbNegativo
        '
        Me.CmbNegativo.FormattingEnabled = True
        Me.CmbNegativo.Items.AddRange(New Object() {"Negativo por Malignidad", "No Util", "Leer Comentarios", "ASCUS"})
        Me.CmbNegativo.Location = New System.Drawing.Point(153, 17)
        Me.CmbNegativo.Name = "CmbNegativo"
        Me.CmbNegativo.Size = New System.Drawing.Size(503, 24)
        Me.CmbNegativo.TabIndex = 14
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CmbOtro)
        Me.GroupBox4.Controls.Add(Me.CmbFlora)
        Me.GroupBox4.Controls.Add(Me.CmbReaccion)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 399)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(966, 67)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'CmbOtro
        '
        Me.CmbOtro.FormattingEnabled = True
        Me.CmbOtro.Items.AddRange(New Object() {"Candida A.", "Levaduras", "Trichomonas V", "Leptotrix", "Hifas", "Leucocitos"})
        Me.CmbOtro.Location = New System.Drawing.Point(704, 30)
        Me.CmbOtro.Name = "CmbOtro"
        Me.CmbOtro.Size = New System.Drawing.Size(142, 24)
        Me.CmbOtro.TabIndex = 27
        '
        'CmbFlora
        '
        Me.CmbFlora.FormattingEnabled = True
        Me.CmbFlora.Items.AddRange(New Object() {"Bacilar", "Cocoide", "Gardnerella V"})
        Me.CmbFlora.Location = New System.Drawing.Point(443, 29)
        Me.CmbFlora.Name = "CmbFlora"
        Me.CmbFlora.Size = New System.Drawing.Size(142, 24)
        Me.CmbFlora.TabIndex = 26
        '
        'CmbReaccion
        '
        Me.CmbReaccion.FormattingEnabled = True
        Me.CmbReaccion.Items.AddRange(New Object() {"Leve", "Moderada", "Severa"})
        Me.CmbReaccion.Location = New System.Drawing.Point(175, 29)
        Me.CmbReaccion.Name = "CmbReaccion"
        Me.CmbReaccion.Size = New System.Drawing.Size(142, 24)
        Me.CmbReaccion.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(646, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 23)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Otros:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(369, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 23)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "FLORA:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(7, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(203, 23)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Reacción Inflamatoria:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(75, 481)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 23)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Comentario:"
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(173, 481)
        Me.TxtNota.Multiline = True
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(744, 40)
        Me.TxtNota.TabIndex = 25
        '
        'CmbSugerencia
        '
        Me.CmbSugerencia.FormattingEnabled = True
        Me.CmbSugerencia.Items.AddRange(New Object() {"SE SUGIERE NUEVA VALORACIÓN A CRITERIO DEL MEDICO", "SUGIERE ESTUDIOS", "SUGIERE EVALUACIÓN COLPOSCOPICA"})
        Me.CmbSugerencia.Location = New System.Drawing.Point(15, 613)
        Me.CmbSugerencia.Name = "CmbSugerencia"
        Me.CmbSugerencia.Size = New System.Drawing.Size(334, 24)
        Me.CmbSugerencia.TabIndex = 28
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(969, 399)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(102, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(766, 322)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnQuimicaG
        '
        Me.BtnQuimicaG.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnQuimicaG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnQuimicaG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnQuimicaG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnQuimicaG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuimicaG.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuimicaG.ForeColor = System.Drawing.Color.White
        Me.BtnQuimicaG.Location = New System.Drawing.Point(847, 598)
        Me.BtnQuimicaG.Name = "BtnQuimicaG"
        Me.BtnQuimicaG.Size = New System.Drawing.Size(132, 65)
        Me.BtnQuimicaG.TabIndex = 23
        Me.BtnQuimicaG.Text = "GUARDAR"
        Me.BtnQuimicaG.UseVisualStyleBackColor = False
        '
        'TxtIdResultado
        '
        Me.TxtIdResultado.Location = New System.Drawing.Point(721, 633)
        Me.TxtIdResultado.Name = "TxtIdResultado"
        Me.TxtIdResultado.Size = New System.Drawing.Size(100, 22)
        Me.TxtIdResultado.TabIndex = 30
        Me.TxtIdResultado.Visible = False
        '
        'TxtObservacionC
        '
        Me.TxtObservacionC.Location = New System.Drawing.Point(173, 534)
        Me.TxtObservacionC.Multiline = True
        Me.TxtObservacionC.Name = "TxtObservacionC"
        Me.TxtObservacionC.Size = New System.Drawing.Size(744, 40)
        Me.TxtObservacionC.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(19, 534)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 23)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Observación Clinica:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(44, 363)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 29)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Diagnostico:"
        '
        'Citologia
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(990, 675)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtObservacionC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtIdResultado)
        Me.Controls.Add(Me.CmbSugerencia)
        Me.Controls.Add(Me.TxtNota)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtpInforme)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtpRecibo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DtpToma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnQuimicaG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Citologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Citologia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAddClientes As Button
    Friend WithEvents BtnAddMedico As Button
    Friend WithEvents TxtMedico As TextBox
    Friend WithEvents Medico As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents CmbGenero As ComboBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpToma As DateTimePicker
    Friend WithEvents DtpRecibo As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents DtpInforme As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtEndo As TextBox
    Friend WithEvents TxtInadecuada As TextBox
    Friend WithEvents TxtAdecuada As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbNegativo As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CmbOtro As ComboBox
    Friend WithEvents CmbFlora As ComboBox
    Friend WithEvents CmbReaccion As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents CmbSugerencia As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnQuimicaG As Button
    Friend WithEvents TxtIdResultado As TextBox
    Friend WithEvents TxtIdMedico As TextBox
    Friend WithEvents TxtObservacionC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
End Class
