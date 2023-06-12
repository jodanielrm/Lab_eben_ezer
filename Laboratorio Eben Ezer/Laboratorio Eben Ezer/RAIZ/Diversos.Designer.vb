<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diversos
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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMedico = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtExamen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbGenero = New System.Windows.Forms.ComboBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtIdMedico = New System.Windows.Forms.TextBox()
        Me.BtnAddClientes = New System.Windows.Forms.Button()
        Me.BtnAddMedico = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TxtIdResultado = New System.Windows.Forms.TextBox()
        Me.BtnQuimicaG = New System.Windows.Forms.Button()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(184, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(580, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INFORME DE EXAMENES DIVERSOS"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(190, 192)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(383, 20)
        Me.TxtNombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(95, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(190, 244)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(417, 20)
        Me.TxtFecha.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(109, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha:"
        '
        'TxtMedico
        '
        Me.TxtMedico.Location = New System.Drawing.Point(190, 299)
        Me.TxtMedico.Name = "TxtMedico"
        Me.TxtMedico.Size = New System.Drawing.Size(604, 20)
        Me.TxtMedico.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(98, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Medico:"
        '
        'TxtExamen
        '
        Me.TxtExamen.Location = New System.Drawing.Point(190, 360)
        Me.TxtExamen.Name = "TxtExamen"
        Me.TxtExamen.Size = New System.Drawing.Size(638, 20)
        Me.TxtExamen.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Examen Solicitado:"
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(190, 424)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(638, 20)
        Me.TxtResultado.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(81, 423)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Resultado:"
        '
        'CmbGenero
        '
        Me.CmbGenero.FormattingEnabled = True
        Me.CmbGenero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.CmbGenero.Location = New System.Drawing.Point(707, 243)
        Me.CmbGenero.Name = "CmbGenero"
        Me.CmbGenero.Size = New System.Drawing.Size(121, 21)
        Me.CmbGenero.TabIndex = 16
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(706, 192)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(121, 20)
        Me.TxtEdad.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(641, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "EDAD:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(619, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "GENERO:"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(462, 192)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 17
        Me.TxtId.Visible = False
        '
        'TxtIdMedico
        '
        Me.TxtIdMedico.Location = New System.Drawing.Point(190, 298)
        Me.TxtIdMedico.Name = "TxtIdMedico"
        Me.TxtIdMedico.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdMedico.TabIndex = 18
        Me.TxtIdMedico.Visible = False
        '
        'BtnAddClientes
        '
        Me.BtnAddClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnAddClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnAddClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddClientes.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddClientes.ForeColor = System.Drawing.Color.White
        Me.BtnAddClientes.Location = New System.Drawing.Point(579, 189)
        Me.BtnAddClientes.Name = "BtnAddClientes"
        Me.BtnAddClientes.Size = New System.Drawing.Size(28, 25)
        Me.BtnAddClientes.TabIndex = 19
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
        Me.BtnAddMedico.Location = New System.Drawing.Point(800, 295)
        Me.BtnAddMedico.Name = "BtnAddMedico"
        Me.BtnAddMedico.Size = New System.Drawing.Size(28, 25)
        Me.BtnAddMedico.TabIndex = 20
        Me.BtnAddMedico.Text = "..."
        Me.BtnAddMedico.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 326)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(969, 251)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(101, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(766, 186)
        Me.DataGridView1.TabIndex = 0
        '
        'TxtIdResultado
        '
        Me.TxtIdResultado.Location = New System.Drawing.Point(740, 643)
        Me.TxtIdResultado.Name = "TxtIdResultado"
        Me.TxtIdResultado.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdResultado.TabIndex = 38
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
        Me.BtnQuimicaG.Location = New System.Drawing.Point(846, 589)
        Me.BtnQuimicaG.Name = "BtnQuimicaG"
        Me.BtnQuimicaG.Size = New System.Drawing.Size(132, 74)
        Me.BtnQuimicaG.TabIndex = 37
        Me.BtnQuimicaG.Text = "GUARDAR"
        Me.BtnQuimicaG.UseVisualStyleBackColor = False
        '
        'Diversos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(990, 675)
        Me.Controls.Add(Me.TxtIdResultado)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.BtnQuimicaG)
        Me.Controls.Add(Me.BtnAddMedico)
        Me.Controls.Add(Me.BtnAddClientes)
        Me.Controls.Add(Me.CmbGenero)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtExamen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtMedico)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.TxtIdMedico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Diversos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diversos"
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMedico As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtExamen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbGenero As ComboBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtIdMedico As TextBox
    Friend WithEvents BtnAddClientes As Button
    Friend WithEvents BtnAddMedico As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtIdResultado As TextBox
    Friend WithEvents BtnQuimicaG As Button
End Class
