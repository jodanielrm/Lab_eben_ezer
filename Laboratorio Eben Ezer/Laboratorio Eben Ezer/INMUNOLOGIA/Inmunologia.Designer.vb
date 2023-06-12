<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inmunologia
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbIgm = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbIgc = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnInmunologia = New System.Windows.Forms.Button()
        Me.TxtIdResultado = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(347, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INMUNOLOGIA"
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 106)
        Me.GroupBox1.TabIndex = 3
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
        Me.Medico.Location = New System.Drawing.Point(45, 67)
        Me.Medico.Name = "Medico"
        Me.Medico.Size = New System.Drawing.Size(79, 23)
        Me.Medico.TabIndex = 8
        Me.Medico.Text = "Medico:"
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
        Me.Label4.Location = New System.Drawing.Point(596, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Edad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(580, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Genero:"
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
        Me.Label2.Location = New System.Drawing.Point(45, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'TxtIdMedico
        '
        Me.TxtIdMedico.Location = New System.Drawing.Point(392, 68)
        Me.TxtIdMedico.Name = "TxtIdMedico"
        Me.TxtIdMedico.Size = New System.Drawing.Size(100, 22)
        Me.TxtIdMedico.TabIndex = 12
        Me.TxtIdMedico.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(347, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 45)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EXAMEN"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbIgm)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(329, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 40)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'CmbIgm
        '
        Me.CmbIgm.FormattingEnabled = True
        Me.CmbIgm.Items.AddRange(New Object() {"Negativo", "Positivo"})
        Me.CmbIgm.Location = New System.Drawing.Point(165, 12)
        Me.CmbIgm.Name = "CmbIgm"
        Me.CmbIgm.Size = New System.Drawing.Size(121, 24)
        Me.CmbIgm.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(49, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "IgM:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(364, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Examen:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(520, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Resultado:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbIgc)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(329, 337)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 38)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'CmbIgc
        '
        Me.CmbIgc.FormattingEnabled = True
        Me.CmbIgc.Items.AddRange(New Object() {"Negativo", "Positivo"})
        Me.CmbIgc.Location = New System.Drawing.Point(165, 11)
        Me.CmbIgc.Name = "CmbIgc"
        Me.CmbIgc.Size = New System.Drawing.Size(121, 24)
        Me.CmbIgc.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(49, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "IgG:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 230)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(965, 385)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(101, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(766, 298)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnInmunologia
        '
        Me.BtnInmunologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnInmunologia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInmunologia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.BtnInmunologia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.BtnInmunologia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInmunologia.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInmunologia.ForeColor = System.Drawing.Color.White
        Me.BtnInmunologia.Location = New System.Drawing.Point(840, 598)
        Me.BtnInmunologia.Name = "BtnInmunologia"
        Me.BtnInmunologia.Size = New System.Drawing.Size(132, 65)
        Me.BtnInmunologia.TabIndex = 23
        Me.BtnInmunologia.Text = "GUARDAR"
        Me.BtnInmunologia.UseVisualStyleBackColor = False
        '
        'TxtIdResultado
        '
        Me.TxtIdResultado.Location = New System.Drawing.Point(26, 632)
        Me.TxtIdResultado.Name = "TxtIdResultado"
        Me.TxtIdResultado.Size = New System.Drawing.Size(100, 22)
        Me.TxtIdResultado.TabIndex = 24
        Me.TxtIdResultado.Visible = False
        '
        'Inmunologia
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(990, 675)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.TxtIdResultado)
        Me.Controls.Add(Me.BtnInmunologia)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inmunologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inmunologia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtMedico As TextBox
    Friend WithEvents Medico As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents CmbGenero As ComboBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAddClientes As Button
    Friend WithEvents BtnAddMedico As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbIgm As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmbIgc As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnInmunologia As Button
    Friend WithEvents TxtIdResultado As TextBox
    Friend WithEvents TxtIdMedico As TextBox
End Class
