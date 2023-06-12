<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hemograma
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
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtIdResultado = New System.Windows.Forms.TextBox()
        Me.BtnQuimicaG = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtLinfocitos = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtGranulocitos = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtMonocitos = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtHemoglobina = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtRbc = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtHematocrito = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtMcv = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtMchc = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtMch = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtPlaquetas = New System.Windows.Forms.TextBox()
        Me.TxtWbc = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LblPlaquetas = New System.Windows.Forms.Label()
        Me.LblMonocitos = New System.Windows.Forms.Label()
        Me.LblMchc = New System.Windows.Forms.Label()
        Me.LblWbc = New System.Windows.Forms.Label()
        Me.LblMch = New System.Windows.Forms.Label()
        Me.LblLinfocitos = New System.Windows.Forms.Label()
        Me.LblMcv = New System.Windows.Forms.Label()
        Me.Lblgranulitos = New System.Windows.Forms.Label()
        Me.LblHematocrito = New System.Windows.Forms.Label()
        Me.LblHemoglobina = New System.Windows.Forms.Label()
        Me.LblRbc = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(347, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "HEMOGRAMA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtFecha)
        Me.GroupBox1.Controls.Add(Me.Label5)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 80)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'TxtFecha
        '
        Me.TxtFecha.Enabled = False
        Me.TxtFecha.Location = New System.Drawing.Point(598, 48)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(121, 20)
        Me.TxtFecha.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(533, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "FECHA:"
        '
        'BtnAddClientes
        '
        Me.BtnAddClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnAddClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnAddClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddClientes.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddClientes.ForeColor = System.Drawing.Color.White
        Me.BtnAddClientes.Location = New System.Drawing.Point(392, 13)
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
        Me.BtnAddMedico.Location = New System.Drawing.Point(392, 45)
        Me.BtnAddMedico.Name = "BtnAddMedico"
        Me.BtnAddMedico.Size = New System.Drawing.Size(28, 25)
        Me.BtnAddMedico.TabIndex = 10
        Me.BtnAddMedico.Text = "..."
        Me.BtnAddMedico.UseVisualStyleBackColor = False
        '
        'TxtMedico
        '
        Me.TxtMedico.Enabled = False
        Me.TxtMedico.Location = New System.Drawing.Point(119, 48)
        Me.TxtMedico.Name = "TxtMedico"
        Me.TxtMedico.Size = New System.Drawing.Size(267, 20)
        Me.TxtMedico.TabIndex = 9
        '
        'Medico
        '
        Me.Medico.AutoSize = True
        Me.Medico.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Medico.Location = New System.Drawing.Point(32, 47)
        Me.Medico.Name = "Medico"
        Me.Medico.Size = New System.Drawing.Size(81, 19)
        Me.Medico.TabIndex = 8
        Me.Medico.Text = "MEDICO:"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(392, 16)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 7
        Me.TxtId.Visible = False
        '
        'CmbGenero
        '
        Me.CmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGenero.FormattingEnabled = True
        Me.CmbGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.CmbGenero.Location = New System.Drawing.Point(598, 16)
        Me.CmbGenero.Name = "CmbGenero"
        Me.CmbGenero.Size = New System.Drawing.Size(121, 21)
        Me.CmbGenero.TabIndex = 6
        '
        'TxtEdad
        '
        Me.TxtEdad.Enabled = False
        Me.TxtEdad.Location = New System.Drawing.Point(820, 16)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(121, 20)
        Me.TxtEdad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(755, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "EDAD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(510, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "GENERO:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(119, 16)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(267, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NOMBRE:"
        '
        'TxtIdMedico
        '
        Me.TxtIdMedico.Location = New System.Drawing.Point(392, 48)
        Me.TxtIdMedico.Name = "TxtIdMedico"
        Me.TxtIdMedico.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdMedico.TabIndex = 12
        Me.TxtIdMedico.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 317)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(125, 278)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 19)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "PLAQUETAS:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(167, 252)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 19)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "MCHC:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(178, 226)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 19)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "MCH:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(180, 200)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 19)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "MCV:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(96, 174)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 19)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "HEMATOCRITO:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(183, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 19)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "RBC:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(93, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 19)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "HEMOGLOBINA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(117, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 19)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "MONOCITOS:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(89, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 19)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "GRANULOCITOS:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(120, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 19)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "LINFOCITOS:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(180, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "WBC:"
        '
        'TxtIdResultado
        '
        Me.TxtIdResultado.Location = New System.Drawing.Point(98, 622)
        Me.TxtIdResultado.Name = "TxtIdResultado"
        Me.TxtIdResultado.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdResultado.TabIndex = 23
        Me.TxtIdResultado.Visible = False
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
        Me.BtnQuimicaG.Location = New System.Drawing.Point(846, 598)
        Me.BtnQuimicaG.Name = "BtnQuimicaG"
        Me.BtnQuimicaG.Size = New System.Drawing.Size(132, 65)
        Me.BtnQuimicaG.TabIndex = 24
        Me.BtnQuimicaG.Text = "GUARDAR"
        Me.BtnQuimicaG.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(767, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 38)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "VALORES " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NOMINALES:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(445, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "RESULTADO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(127, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "PRUEBA:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.TxtLinfocitos)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.TxtGranulocitos)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.TxtMonocitos)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.TxtHemoglobina)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.TxtRbc)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.TxtHematocrito)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.TxtMcv)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.TxtMchc)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.TxtMch)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.TxtPlaquetas)
        Me.GroupBox3.Controls.Add(Me.TxtWbc)
        Me.GroupBox3.Location = New System.Drawing.Point(269, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(424, 317)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(357, 278)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 19)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "10*/1"
        '
        'TxtLinfocitos
        '
        Me.TxtLinfocitos.Location = New System.Drawing.Point(32, 45)
        Me.TxtLinfocitos.Name = "TxtLinfocitos"
        Me.TxtLinfocitos.Size = New System.Drawing.Size(311, 20)
        Me.TxtLinfocitos.TabIndex = 10
        Me.TxtLinfocitos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(357, 252)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 19)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "g/dl"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(357, 226)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 19)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "pg"
        '
        'TxtGranulocitos
        '
        Me.TxtGranulocitos.Location = New System.Drawing.Point(32, 71)
        Me.TxtGranulocitos.Name = "TxtGranulocitos"
        Me.TxtGranulocitos.Size = New System.Drawing.Size(311, 20)
        Me.TxtGranulocitos.TabIndex = 9
        Me.TxtGranulocitos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(357, 200)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(18, 19)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "fl"
        '
        'TxtMonocitos
        '
        Me.TxtMonocitos.Location = New System.Drawing.Point(32, 97)
        Me.TxtMonocitos.Name = "TxtMonocitos"
        Me.TxtMonocitos.Size = New System.Drawing.Size(311, 20)
        Me.TxtMonocitos.TabIndex = 8
        Me.TxtMonocitos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(357, 174)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 19)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "%"
        '
        'TxtHemoglobina
        '
        Me.TxtHemoglobina.Location = New System.Drawing.Point(32, 123)
        Me.TxtHemoglobina.Name = "TxtHemoglobina"
        Me.TxtHemoglobina.Size = New System.Drawing.Size(311, 20)
        Me.TxtHemoglobina.TabIndex = 7
        Me.TxtHemoglobina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(357, 148)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 19)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "10*/1"
        '
        'TxtRbc
        '
        Me.TxtRbc.Location = New System.Drawing.Point(32, 149)
        Me.TxtRbc.Name = "TxtRbc"
        Me.TxtRbc.Size = New System.Drawing.Size(311, 20)
        Me.TxtRbc.TabIndex = 6
        Me.TxtRbc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(357, 122)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(33, 19)
        Me.Label26.TabIndex = 30
        Me.Label26.Text = "g/dl"
        '
        'TxtHematocrito
        '
        Me.TxtHematocrito.Location = New System.Drawing.Point(32, 175)
        Me.TxtHematocrito.Name = "TxtHematocrito"
        Me.TxtHematocrito.Size = New System.Drawing.Size(311, 20)
        Me.TxtHematocrito.TabIndex = 5
        Me.TxtHematocrito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(357, 96)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(25, 19)
        Me.Label27.TabIndex = 29
        Me.Label27.Text = "%"
        '
        'TxtMcv
        '
        Me.TxtMcv.Location = New System.Drawing.Point(32, 201)
        Me.TxtMcv.Name = "TxtMcv"
        Me.TxtMcv.Size = New System.Drawing.Size(311, 20)
        Me.TxtMcv.TabIndex = 4
        Me.TxtMcv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(357, 70)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(25, 19)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "%"
        '
        'TxtMchc
        '
        Me.TxtMchc.Location = New System.Drawing.Point(32, 253)
        Me.TxtMchc.Name = "TxtMchc"
        Me.TxtMchc.Size = New System.Drawing.Size(311, 20)
        Me.TxtMchc.TabIndex = 3
        Me.TxtMchc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(357, 44)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(25, 19)
        Me.Label29.TabIndex = 27
        Me.Label29.Text = "%"
        '
        'TxtMch
        '
        Me.TxtMch.Location = New System.Drawing.Point(32, 227)
        Me.TxtMch.Name = "TxtMch"
        Me.TxtMch.Size = New System.Drawing.Size(311, 20)
        Me.TxtMch.TabIndex = 2
        Me.TxtMch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(357, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(25, 19)
        Me.Label30.TabIndex = 26
        Me.Label30.Text = "%"
        '
        'TxtPlaquetas
        '
        Me.TxtPlaquetas.Location = New System.Drawing.Point(32, 279)
        Me.TxtPlaquetas.Name = "TxtPlaquetas"
        Me.TxtPlaquetas.Size = New System.Drawing.Size(311, 20)
        Me.TxtPlaquetas.TabIndex = 1
        Me.TxtPlaquetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtWbc
        '
        Me.TxtWbc.Location = New System.Drawing.Point(32, 19)
        Me.TxtWbc.Name = "TxtWbc"
        Me.TxtWbc.Size = New System.Drawing.Size(311, 20)
        Me.TxtWbc.TabIndex = 0
        Me.TxtWbc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblPlaquetas)
        Me.GroupBox4.Controls.Add(Me.LblMonocitos)
        Me.GroupBox4.Controls.Add(Me.LblMchc)
        Me.GroupBox4.Controls.Add(Me.LblWbc)
        Me.GroupBox4.Controls.Add(Me.LblMch)
        Me.GroupBox4.Controls.Add(Me.LblLinfocitos)
        Me.GroupBox4.Controls.Add(Me.LblMcv)
        Me.GroupBox4.Controls.Add(Me.Lblgranulitos)
        Me.GroupBox4.Controls.Add(Me.LblHematocrito)
        Me.GroupBox4.Controls.Add(Me.LblHemoglobina)
        Me.GroupBox4.Controls.Add(Me.LblRbc)
        Me.GroupBox4.Location = New System.Drawing.Point(699, 182)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(279, 317)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'LblPlaquetas
        '
        Me.LblPlaquetas.AutoSize = True
        Me.LblPlaquetas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlaquetas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblPlaquetas.Location = New System.Drawing.Point(43, 278)
        Me.LblPlaquetas.Name = "LblPlaquetas"
        Me.LblPlaquetas.Size = New System.Drawing.Size(110, 19)
        Me.LblPlaquetas.TabIndex = 36
        Me.LblPlaquetas.Text = "156 - 342 10*/1"
        '
        'LblMonocitos
        '
        Me.LblMonocitos.AutoSize = True
        Me.LblMonocitos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonocitos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblMonocitos.Location = New System.Drawing.Point(43, 96)
        Me.LblMonocitos.Name = "LblMonocitos"
        Me.LblMonocitos.Size = New System.Drawing.Size(90, 19)
        Me.LblMonocitos.TabIndex = 29
        Me.LblMonocitos.Text = "4.5 - 12.1 %"
        '
        'LblMchc
        '
        Me.LblMchc.AutoSize = True
        Me.LblMchc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMchc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblMchc.Location = New System.Drawing.Point(43, 252)
        Me.LblMchc.Name = "LblMchc"
        Me.LblMchc.Size = New System.Drawing.Size(106, 19)
        Me.LblMchc.TabIndex = 35
        Me.LblMchc.Text = "31.7 - 34.2 g/dl"
        '
        'LblWbc
        '
        Me.LblWbc.AutoSize = True
        Me.LblWbc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWbc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblWbc.Location = New System.Drawing.Point(43, 18)
        Me.LblWbc.Name = "LblWbc"
        Me.LblWbc.Size = New System.Drawing.Size(105, 19)
        Me.LblWbc.TabIndex = 26
        Me.LblWbc.Text = "4.00 - 11.60 %"
        '
        'LblMch
        '
        Me.LblMch.AutoSize = True
        Me.LblMch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblMch.Location = New System.Drawing.Point(43, 226)
        Me.LblMch.Name = "LblMch"
        Me.LblMch.Size = New System.Drawing.Size(98, 19)
        Me.LblMch.TabIndex = 34
        Me.LblMch.Text = "27.5 - 32.4 pg"
        '
        'LblLinfocitos
        '
        Me.LblLinfocitos.AutoSize = True
        Me.LblLinfocitos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLinfocitos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblLinfocitos.Location = New System.Drawing.Point(43, 44)
        Me.LblLinfocitos.Name = "LblLinfocitos"
        Me.LblLinfocitos.Size = New System.Drawing.Size(98, 19)
        Me.LblLinfocitos.TabIndex = 27
        Me.LblLinfocitos.Text = "19.1 - 48.5 %"
        '
        'LblMcv
        '
        Me.LblMcv.AutoSize = True
        Me.LblMcv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMcv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblMcv.Location = New System.Drawing.Point(43, 200)
        Me.LblMcv.Name = "LblMcv"
        Me.LblMcv.Size = New System.Drawing.Size(67, 19)
        Me.LblMcv.TabIndex = 33
        Me.LblMcv.Text = "84 - 98 fl"
        '
        'Lblgranulitos
        '
        Me.Lblgranulitos.AutoSize = True
        Me.Lblgranulitos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblgranulitos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Lblgranulitos.Location = New System.Drawing.Point(43, 70)
        Me.Lblgranulitos.Name = "Lblgranulitos"
        Me.Lblgranulitos.Size = New System.Drawing.Size(98, 19)
        Me.Lblgranulitos.TabIndex = 28
        Me.Lblgranulitos.Text = "43.6 - 73.4 %"
        '
        'LblHematocrito
        '
        Me.LblHematocrito.AutoSize = True
        Me.LblHematocrito.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHematocrito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblHematocrito.Location = New System.Drawing.Point(43, 174)
        Me.LblHematocrito.Name = "LblHematocrito"
        Me.LblHematocrito.Size = New System.Drawing.Size(106, 19)
        Me.LblHematocrito.TabIndex = 32
        Me.LblHematocrito.Text = "34.0 - 45.40 %"
        '
        'LblHemoglobina
        '
        Me.LblHemoglobina.AutoSize = True
        Me.LblHemoglobina.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHemoglobina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblHemoglobina.Location = New System.Drawing.Point(43, 122)
        Me.LblHemoglobina.Name = "LblHemoglobina"
        Me.LblHemoglobina.Size = New System.Drawing.Size(105, 19)
        Me.LblHemoglobina.TabIndex = 30
        Me.LblHemoglobina.Text = "11.5 - 15.1 g/dl"
        '
        'LblRbc
        '
        Me.LblRbc.AutoSize = True
        Me.LblRbc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRbc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LblRbc.Location = New System.Drawing.Point(43, 148)
        Me.LblRbc.Name = "LblRbc"
        Me.LblRbc.Size = New System.Drawing.Size(118, 19)
        Me.LblRbc.TabIndex = 31
        Me.LblRbc.Text = "3.79 - 5.14 10*/1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 505)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(966, 75)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(157, 17)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(784, 46)
        Me.TextBox1.TabIndex = 16
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(26, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(125, 19)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "COMENTARIO:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DataGridView1)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(966, 451)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(101, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(766, 358)
        Me.DataGridView1.TabIndex = 0
        '
        'Hemograma
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(990, 675)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtIdResultado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnQuimicaG)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Hemograma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hemograma"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents Label5 As Label
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
    Friend WithEvents TxtIdMedico As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtIdResultado As TextBox
    Friend WithEvents BtnQuimicaG As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtLinfocitos As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtGranulocitos As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtMonocitos As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TxtHemoglobina As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TxtRbc As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TxtHematocrito As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TxtMcv As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TxtMchc As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TxtMch As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TxtPlaquetas As TextBox
    Friend WithEvents TxtWbc As TextBox
    Friend WithEvents LblPlaquetas As Label
    Friend WithEvents LblMonocitos As Label
    Friend WithEvents LblMchc As Label
    Friend WithEvents LblWbc As Label
    Friend WithEvents LblMch As Label
    Friend WithEvents LblLinfocitos As Label
    Friend WithEvents LblMcv As Label
    Friend WithEvents Lblgranulitos As Label
    Friend WithEvents LblHematocrito As Label
    Friend WithEvents LblHemoglobina As Label
    Friend WithEvents LblRbc As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
