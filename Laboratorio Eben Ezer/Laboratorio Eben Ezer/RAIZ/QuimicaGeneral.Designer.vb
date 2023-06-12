<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuimicaGeneral
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblicreatinina = New System.Windows.Forms.Label()
        Me.lblildl = New System.Windows.Forms.Label()
        Me.lblihdl = New System.Windows.Forms.Label()
        Me.lblicolesterolt = New System.Windows.Forms.Label()
        Me.lbliacido = New System.Windows.Forms.Label()
        Me.TxtCreatinina = New System.Windows.Forms.TextBox()
        Me.TxtLDL = New System.Windows.Forms.TextBox()
        Me.TxtHDL = New System.Windows.Forms.TextBox()
        Me.TxtColesterolT = New System.Windows.Forms.TextBox()
        Me.TxtAU = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblisgpt = New System.Windows.Forms.Label()
        Me.lblisgot = New System.Windows.Forms.Label()
        Me.lblitri = New System.Windows.Forms.Label()
        Me.lbliurea = New System.Windows.Forms.Label()
        Me.lbliglucosa = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtSGPT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSGOT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTrigli = New System.Windows.Forms.TextBox()
        Me.TxtUrea = New System.Windows.Forms.TextBox()
        Me.TxtGluco = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnQuimicaG = New System.Windows.Forms.Button()
        Me.TxtIdResultado = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(272, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "QUIMICA GENERAL"
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 80)
        Me.GroupBox1.TabIndex = 7
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(223, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Resultado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(57, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Examen:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(385, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 38)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Valores " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nominales:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(855, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 38)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Valores " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nominales:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(691, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Resultado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(546, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 19)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Examen:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblicreatinina)
        Me.GroupBox2.Controls.Add(Me.lblildl)
        Me.GroupBox2.Controls.Add(Me.lblihdl)
        Me.GroupBox2.Controls.Add(Me.lblicolesterolt)
        Me.GroupBox2.Controls.Add(Me.lbliacido)
        Me.GroupBox2.Controls.Add(Me.TxtCreatinina)
        Me.GroupBox2.Controls.Add(Me.TxtLDL)
        Me.GroupBox2.Controls.Add(Me.TxtHDL)
        Me.GroupBox2.Controls.Add(Me.TxtColesterolT)
        Me.GroupBox2.Controls.Add(Me.TxtAU)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 212)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'lblicreatinina
        '
        Me.lblicreatinina.AutoSize = True
        Me.lblicreatinina.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblicreatinina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblicreatinina.Location = New System.Drawing.Point(326, 167)
        Me.lblicreatinina.Name = "lblicreatinina"
        Me.lblicreatinina.Size = New System.Drawing.Size(0, 19)
        Me.lblicreatinina.TabIndex = 22
        '
        'lblildl
        '
        Me.lblildl.AutoSize = True
        Me.lblildl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblildl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblildl.Location = New System.Drawing.Point(325, 131)
        Me.lblildl.Name = "lblildl"
        Me.lblildl.Size = New System.Drawing.Size(42, 19)
        Me.lblildl.TabIndex = 21
        Me.lblildl.Text = ">130"
        '
        'lblihdl
        '
        Me.lblihdl.AutoSize = True
        Me.lblihdl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblihdl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblihdl.Location = New System.Drawing.Point(326, 89)
        Me.lblihdl.Name = "lblihdl"
        Me.lblihdl.Size = New System.Drawing.Size(0, 19)
        Me.lblihdl.TabIndex = 20
        '
        'lblicolesterolt
        '
        Me.lblicolesterolt.AutoSize = True
        Me.lblicolesterolt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblicolesterolt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblicolesterolt.Location = New System.Drawing.Point(326, 55)
        Me.lblicolesterolt.Name = "lblicolesterolt"
        Me.lblicolesterolt.Size = New System.Drawing.Size(42, 19)
        Me.lblicolesterolt.TabIndex = 19
        Me.lblicolesterolt.Text = ">200"
        '
        'lbliacido
        '
        Me.lbliacido.AutoSize = True
        Me.lbliacido.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliacido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lbliacido.Location = New System.Drawing.Point(326, 16)
        Me.lbliacido.Name = "lbliacido"
        Me.lbliacido.Size = New System.Drawing.Size(0, 19)
        Me.lbliacido.TabIndex = 18
        '
        'TxtCreatinina
        '
        Me.TxtCreatinina.Location = New System.Drawing.Point(198, 168)
        Me.TxtCreatinina.Name = "TxtCreatinina"
        Me.TxtCreatinina.Size = New System.Drawing.Size(121, 20)
        Me.TxtCreatinina.TabIndex = 17
        '
        'TxtLDL
        '
        Me.TxtLDL.Location = New System.Drawing.Point(198, 130)
        Me.TxtLDL.Name = "TxtLDL"
        Me.TxtLDL.Size = New System.Drawing.Size(121, 20)
        Me.TxtLDL.TabIndex = 16
        '
        'TxtHDL
        '
        Me.TxtHDL.Location = New System.Drawing.Point(198, 90)
        Me.TxtHDL.Name = "TxtHDL"
        Me.TxtHDL.Size = New System.Drawing.Size(121, 20)
        Me.TxtHDL.TabIndex = 15
        '
        'TxtColesterolT
        '
        Me.TxtColesterolT.Location = New System.Drawing.Point(198, 54)
        Me.TxtColesterolT.Name = "TxtColesterolT"
        Me.TxtColesterolT.Size = New System.Drawing.Size(121, 20)
        Me.TxtColesterolT.TabIndex = 14
        '
        'TxtAU
        '
        Me.TxtAU.Location = New System.Drawing.Point(198, 16)
        Me.TxtAU.Name = "TxtAU"
        Me.TxtAU.Size = New System.Drawing.Size(121, 20)
        Me.TxtAU.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(69, 167)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 19)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "CREATININA:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(28, 129)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(155, 19)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "COLESTEROL LDL:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(26, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(157, 19)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "COLESTEROL HDL:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(8, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(175, 19)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "COLESTEROL TOTAL:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(61, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 19)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "ACIDO URICO:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblisgpt)
        Me.GroupBox3.Controls.Add(Me.lblisgot)
        Me.GroupBox3.Controls.Add(Me.lblitri)
        Me.GroupBox3.Controls.Add(Me.lbliurea)
        Me.GroupBox3.Controls.Add(Me.lbliglucosa)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TxtSGPT)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TxtSGOT)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TxtTrigli)
        Me.GroupBox3.Controls.Add(Me.TxtUrea)
        Me.GroupBox3.Controls.Add(Me.TxtGluco)
        Me.GroupBox3.Location = New System.Drawing.Point(498, 238)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(480, 212)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'lblisgpt
        '
        Me.lblisgpt.AutoSize = True
        Me.lblisgpt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblisgpt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblisgpt.Location = New System.Drawing.Point(324, 167)
        Me.lblisgpt.Name = "lblisgpt"
        Me.lblisgpt.Size = New System.Drawing.Size(0, 19)
        Me.lblisgpt.TabIndex = 29
        '
        'lblisgot
        '
        Me.lblisgot.AutoSize = True
        Me.lblisgot.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblisgot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblisgot.Location = New System.Drawing.Point(324, 129)
        Me.lblisgot.Name = "lblisgot"
        Me.lblisgot.Size = New System.Drawing.Size(0, 19)
        Me.lblisgot.TabIndex = 23
        '
        'lblitri
        '
        Me.lblitri.AutoSize = True
        Me.lblitri.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitri.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblitri.Location = New System.Drawing.Point(330, 91)
        Me.lblitri.Name = "lblitri"
        Me.lblitri.Size = New System.Drawing.Size(42, 19)
        Me.lblitri.TabIndex = 28
        Me.lblitri.Text = ">150"
        '
        'lbliurea
        '
        Me.lbliurea.AutoSize = True
        Me.lbliurea.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliurea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lbliurea.Location = New System.Drawing.Point(326, 55)
        Me.lbliurea.Name = "lbliurea"
        Me.lbliurea.Size = New System.Drawing.Size(54, 19)
        Me.lbliurea.TabIndex = 23
        Me.lbliurea.Text = "10 - 50"
        '
        'lbliglucosa
        '
        Me.lbliglucosa.AutoSize = True
        Me.lbliglucosa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliglucosa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lbliglucosa.Location = New System.Drawing.Point(324, 16)
        Me.lbliglucosa.Name = "lbliglucosa"
        Me.lbliglucosa.Size = New System.Drawing.Size(146, 57)
        Me.lbliglucosa.TabIndex = 23
        Me.lbliglucosa.Text = "Neonatos = 30 - 80" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Niños        = 60 - 100" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adulto      = 74 - 115"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(95, 167)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 19)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "SGPT:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(92, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 19)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "SGOT:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(6, 91)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 19)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "TRIGLICERIDOS:"
        '
        'TxtSGPT
        '
        Me.TxtSGPT.Location = New System.Drawing.Point(179, 168)
        Me.TxtSGPT.Name = "TxtSGPT"
        Me.TxtSGPT.Size = New System.Drawing.Size(121, 20)
        Me.TxtSGPT.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(90, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 19)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "UREA:"
        '
        'TxtSGOT
        '
        Me.TxtSGOT.Location = New System.Drawing.Point(179, 130)
        Me.TxtSGOT.Name = "TxtSGOT"
        Me.TxtSGOT.Size = New System.Drawing.Size(121, 20)
        Me.TxtSGOT.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(58, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 19)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "GLUCOSA:"
        '
        'TxtTrigli
        '
        Me.TxtTrigli.Location = New System.Drawing.Point(179, 90)
        Me.TxtTrigli.Name = "TxtTrigli"
        Me.TxtTrigli.Size = New System.Drawing.Size(121, 20)
        Me.TxtTrigli.TabIndex = 25
        '
        'TxtUrea
        '
        Me.TxtUrea.Location = New System.Drawing.Point(179, 54)
        Me.TxtUrea.Name = "TxtUrea"
        Me.TxtUrea.Size = New System.Drawing.Size(121, 20)
        Me.TxtUrea.TabIndex = 24
        '
        'TxtGluco
        '
        Me.TxtGluco.Location = New System.Drawing.Point(179, 16)
        Me.TxtGluco.Name = "TxtGluco"
        Me.TxtGluco.Size = New System.Drawing.Size(121, 20)
        Me.TxtGluco.TabIndex = 23
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtNota)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 466)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(966, 80)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(119, 16)
        Me.TxtNota.Multiline = True
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(822, 58)
        Me.TxtNota.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(26, 15)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(58, 19)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "NOTA:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(966, 415)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(100, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(766, 358)
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
        Me.BtnQuimicaG.Location = New System.Drawing.Point(796, 582)
        Me.BtnQuimicaG.Name = "BtnQuimicaG"
        Me.BtnQuimicaG.Size = New System.Drawing.Size(132, 65)
        Me.BtnQuimicaG.TabIndex = 22
        Me.BtnQuimicaG.Text = "GUARDAR"
        Me.BtnQuimicaG.UseVisualStyleBackColor = False
        '
        'TxtIdResultado
        '
        Me.TxtIdResultado.Location = New System.Drawing.Point(48, 606)
        Me.TxtIdResultado.Name = "TxtIdResultado"
        Me.TxtIdResultado.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdResultado.TabIndex = 15
        Me.TxtIdResultado.Visible = False
        '
        'QuimicaGeneral
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(990, 675)
        Me.Controls.Add(Me.TxtIdResultado)
        Me.Controls.Add(Me.BtnQuimicaG)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuimicaGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuimicaGeneral"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCreatinina As TextBox
    Friend WithEvents TxtLDL As TextBox
    Friend WithEvents TxtHDL As TextBox
    Friend WithEvents TxtColesterolT As TextBox
    Friend WithEvents TxtAU As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtSGPT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSGOT As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtTrigli As TextBox
    Friend WithEvents TxtUrea As TextBox
    Friend WithEvents TxtGluco As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents lbliacido As Label
    Friend WithEvents lblicolesterolt As Label
    Friend WithEvents lblicreatinina As Label
    Friend WithEvents lblildl As Label
    Friend WithEvents lblihdl As Label
    Friend WithEvents lbliglucosa As Label
    Friend WithEvents lblisgot As Label
    Friend WithEvents lblitri As Label
    Friend WithEvents lbliurea As Label
    Friend WithEvents lblisgpt As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnQuimicaG As Button
    Friend WithEvents TxtIdResultado As TextBox
End Class
