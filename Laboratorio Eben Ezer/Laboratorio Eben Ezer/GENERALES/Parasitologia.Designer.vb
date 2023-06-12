<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parasitologia
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbSM = New System.Windows.Forms.ComboBox()
        Me.CmbMoco = New System.Windows.Forms.ComboBox()
        Me.CmbConsistencia = New System.Windows.Forms.ComboBox()
        Me.CmbColor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmbLeucocitos = New System.Windows.Forms.ComboBox()
        Me.CmbLarvas = New System.Windows.Forms.ComboBox()
        Me.TxtOtros = New System.Windows.Forms.TextBox()
        Me.TxtEritrocitos = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtHuevos = New System.Windows.Forms.TextBox()
        Me.TxtQuistes = New System.Windows.Forms.TextBox()
        Me.TxtTrofozoitos = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtIdResultado = New System.Windows.Forms.TextBox()
        Me.BtnQuimicaG = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(328, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PARASITOLOGIA"
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 80)
        Me.GroupBox1.TabIndex = 6
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
        Me.CmbGenero.FormattingEnabled = True
        Me.CmbGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.CmbGenero.Location = New System.Drawing.Point(650, 16)
        Me.CmbGenero.Name = "CmbGenero"
        Me.CmbGenero.Size = New System.Drawing.Size(121, 21)
        Me.CmbGenero.TabIndex = 6
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(650, 48)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(121, 20)
        Me.TxtEdad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(585, 47)
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
        Me.Label3.Location = New System.Drawing.Point(562, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "GENERO:"
        '
        'TxtNombre
        '
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
        Me.TxtIdMedico.TabIndex = 13
        Me.TxtIdMedico.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbSM)
        Me.GroupBox2.Controls.Add(Me.CmbMoco)
        Me.GroupBox2.Controls.Add(Me.CmbConsistencia)
        Me.GroupBox2.Controls.Add(Me.CmbColor)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(966, 73)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'CmbSM
        '
        Me.CmbSM.FormattingEnabled = True
        Me.CmbSM.Items.AddRange(New Object() {"ESCASO", "MODERADO", "ABUNDANTE"})
        Me.CmbSM.Location = New System.Drawing.Point(650, 41)
        Me.CmbSM.Name = "CmbSM"
        Me.CmbSM.Size = New System.Drawing.Size(245, 21)
        Me.CmbSM.TabIndex = 14
        '
        'CmbMoco
        '
        Me.CmbMoco.FormattingEnabled = True
        Me.CmbMoco.Items.AddRange(New Object() {"SUIGENERIS", "FETIDO"})
        Me.CmbMoco.Location = New System.Drawing.Point(650, 13)
        Me.CmbMoco.Name = "CmbMoco"
        Me.CmbMoco.Size = New System.Drawing.Size(245, 21)
        Me.CmbMoco.TabIndex = 13
        '
        'CmbConsistencia
        '
        Me.CmbConsistencia.FormattingEnabled = True
        Me.CmbConsistencia.Items.AddRange(New Object() {"AMARILLO CLARO", "AMARILLO OBSCURO", "ROJIZO", "AMBAR"})
        Me.CmbConsistencia.Location = New System.Drawing.Point(156, 41)
        Me.CmbConsistencia.Name = "CmbConsistencia"
        Me.CmbConsistencia.Size = New System.Drawing.Size(245, 21)
        Me.CmbConsistencia.TabIndex = 12
        '
        'CmbColor
        '
        Me.CmbColor.FormattingEnabled = True
        Me.CmbColor.Items.AddRange(New Object() {"TRANSPARENTE", "LIGERO TURBIO", "TURBIO"})
        Me.CmbColor.Location = New System.Drawing.Point(156, 13)
        Me.CmbColor.Name = "CmbColor"
        Me.CmbColor.Size = New System.Drawing.Size(245, 21)
        Me.CmbColor.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(17, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "CONSISTENCIA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(79, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "COLOR:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(498, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 19)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "SANGRE MACRO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(579, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "MOCO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(368, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "EXAMEN FISICO"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CmbLeucocitos)
        Me.GroupBox4.Controls.Add(Me.CmbLarvas)
        Me.GroupBox4.Controls.Add(Me.TxtOtros)
        Me.GroupBox4.Controls.Add(Me.TxtEritrocitos)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.TxtHuevos)
        Me.GroupBox4.Controls.Add(Me.TxtQuistes)
        Me.GroupBox4.Controls.Add(Me.TxtTrofozoitos)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 393)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(966, 164)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'CmbLeucocitos
        '
        Me.CmbLeucocitos.FormattingEnabled = True
        Me.CmbLeucocitos.Items.AddRange(New Object() {"ESCASO", "MODERADO", "SEVERO"})
        Me.CmbLeucocitos.Location = New System.Drawing.Point(673, 45)
        Me.CmbLeucocitos.Name = "CmbLeucocitos"
        Me.CmbLeucocitos.Size = New System.Drawing.Size(194, 21)
        Me.CmbLeucocitos.TabIndex = 31
        '
        'CmbLarvas
        '
        Me.CmbLarvas.FormattingEnabled = True
        Me.CmbLarvas.Items.AddRange(New Object() {"ESCASAS", "MODERADAS", "ABUNDANTES"})
        Me.CmbLarvas.Location = New System.Drawing.Point(673, 14)
        Me.CmbLarvas.Name = "CmbLarvas"
        Me.CmbLarvas.Size = New System.Drawing.Size(194, 21)
        Me.CmbLarvas.TabIndex = 15
        '
        'TxtOtros
        '
        Me.TxtOtros.Location = New System.Drawing.Point(169, 114)
        Me.TxtOtros.Multiline = True
        Me.TxtOtros.Name = "TxtOtros"
        Me.TxtOtros.Size = New System.Drawing.Size(698, 44)
        Me.TxtOtros.TabIndex = 30
        '
        'TxtEritrocitos
        '
        Me.TxtEritrocitos.Location = New System.Drawing.Point(673, 78)
        Me.TxtEritrocitos.Name = "TxtEritrocitos"
        Me.TxtEritrocitos.Size = New System.Drawing.Size(194, 20)
        Me.TxtEritrocitos.TabIndex = 28
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(94, 113)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 19)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "OTROS:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(543, 79)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(124, 19)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "ERITROCITOS:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(551, 45)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(116, 19)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "LEUCOCITOS:"
        '
        'TxtHuevos
        '
        Me.TxtHuevos.Location = New System.Drawing.Point(169, 78)
        Me.TxtHuevos.Name = "TxtHuevos"
        Me.TxtHuevos.Size = New System.Drawing.Size(194, 20)
        Me.TxtHuevos.TabIndex = 19
        '
        'TxtQuistes
        '
        Me.TxtQuistes.Location = New System.Drawing.Point(169, 46)
        Me.TxtQuistes.Name = "TxtQuistes"
        Me.TxtQuistes.Size = New System.Drawing.Size(194, 20)
        Me.TxtQuistes.TabIndex = 18
        '
        'TxtTrofozoitos
        '
        Me.TxtTrofozoitos.Location = New System.Drawing.Point(169, 14)
        Me.TxtTrofozoitos.Name = "TxtTrofozoitos"
        Me.TxtTrofozoitos.Size = New System.Drawing.Size(194, 20)
        Me.TxtTrofozoitos.TabIndex = 12
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(592, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 19)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "LARVAS:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(84, 77)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(79, 19)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "HUEVOS:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(82, 45)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 19)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "QUISTES:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(36, 13)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(127, 19)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "TROFOZOITOS:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(310, 360)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(317, 26)
        Me.Label31.TabIndex = 17
        Me.Label31.Text = "EXAMEN MICROSCÓPICO"
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(97, 572)
        Me.TxtNota.Multiline = True
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(593, 74)
        Me.TxtNota.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(22, 571)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 19)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "NOTA:"
        '
        'TxtIdResultado
        '
        Me.TxtIdResultado.Location = New System.Drawing.Point(737, 626)
        Me.TxtIdResultado.Name = "TxtIdResultado"
        Me.TxtIdResultado.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdResultado.TabIndex = 36
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
        Me.BtnQuimicaG.Location = New System.Drawing.Point(843, 572)
        Me.BtnQuimicaG.Name = "BtnQuimicaG"
        Me.BtnQuimicaG.Size = New System.Drawing.Size(132, 74)
        Me.BtnQuimicaG.TabIndex = 35
        Me.BtnQuimicaG.Text = "GUARDAR"
        Me.BtnQuimicaG.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 166)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(969, 400)
        Me.GroupBox5.TabIndex = 37
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
        'Parasitologia
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(990, 675)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.TxtIdResultado)
        Me.Controls.Add(Me.TxtNota)
        Me.Controls.Add(Me.BtnQuimicaG)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Parasitologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parasitologia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbSM As ComboBox
    Friend WithEvents CmbMoco As ComboBox
    Friend WithEvents CmbConsistencia As ComboBox
    Friend WithEvents CmbColor As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CmbLeucocitos As ComboBox
    Friend WithEvents CmbLarvas As ComboBox
    Friend WithEvents TxtOtros As TextBox
    Friend WithEvents TxtEritrocitos As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TxtHuevos As TextBox
    Friend WithEvents TxtQuistes As TextBox
    Friend WithEvents TxtTrofozoitos As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtIdMedico As TextBox
    Friend WithEvents TxtIdResultado As TextBox
    Friend WithEvents BtnQuimicaG As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
