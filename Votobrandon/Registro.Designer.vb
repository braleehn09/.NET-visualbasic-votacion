<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.Btninicio = New System.Windows.Forms.Button()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtIdentificacion = New System.Windows.Forms.TextBox()
        Me.RtxtPropuesta = New System.Windows.Forms.RichTextBox()
        Me.PbxFoto = New System.Windows.Forms.PictureBox()
        Me.RbtnUno = New System.Windows.Forms.RadioButton()
        Me.RbtnDos = New System.Windows.Forms.RadioButton()
        Me.RbtnTres = New System.Windows.Forms.RadioButton()
        Me.BtnRegistar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSubir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Subir = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btninicio
        '
        Me.Btninicio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btninicio.Location = New System.Drawing.Point(424, 394)
        Me.Btninicio.Name = "Btninicio"
        Me.Btninicio.Size = New System.Drawing.Size(100, 29)
        Me.Btninicio.TabIndex = 2
        Me.Btninicio.Text = "Inicio"
        Me.Btninicio.UseVisualStyleBackColor = True
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(39, 93)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(193, 22)
        Me.TxtNombres.TabIndex = 3
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(39, 141)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(193, 22)
        Me.TxtApellidos.TabIndex = 4
        '
        'TxtIdentificacion
        '
        Me.TxtIdentificacion.Location = New System.Drawing.Point(39, 188)
        Me.TxtIdentificacion.Name = "TxtIdentificacion"
        Me.TxtIdentificacion.Size = New System.Drawing.Size(193, 22)
        Me.TxtIdentificacion.TabIndex = 5
        '
        'RtxtPropuesta
        '
        Me.RtxtPropuesta.Location = New System.Drawing.Point(38, 310)
        Me.RtxtPropuesta.Name = "RtxtPropuesta"
        Me.RtxtPropuesta.Size = New System.Drawing.Size(327, 127)
        Me.RtxtPropuesta.TabIndex = 6
        Me.RtxtPropuesta.Text = ""
        '
        'PbxFoto
        '
        Me.PbxFoto.BackColor = System.Drawing.Color.White
        Me.PbxFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PbxFoto.Image = CType(resources.GetObject("PbxFoto.Image"), System.Drawing.Image)
        Me.PbxFoto.Location = New System.Drawing.Point(408, 93)
        Me.PbxFoto.Name = "PbxFoto"
        Me.PbxFoto.Size = New System.Drawing.Size(116, 122)
        Me.PbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxFoto.TabIndex = 7
        Me.PbxFoto.TabStop = False
        '
        'RbtnUno
        '
        Me.RbtnUno.AutoSize = True
        Me.RbtnUno.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RbtnUno.Location = New System.Drawing.Point(39, 257)
        Me.RbtnUno.Name = "RbtnUno"
        Me.RbtnUno.Size = New System.Drawing.Size(93, 21)
        Me.RbtnUno.TabIndex = 8
        Me.RbtnUno.TabStop = True
        Me.RbtnUno.Text = "Tarjeton #1"
        Me.RbtnUno.UseVisualStyleBackColor = True
        '
        'RbtnDos
        '
        Me.RbtnDos.AutoSize = True
        Me.RbtnDos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RbtnDos.Location = New System.Drawing.Point(138, 257)
        Me.RbtnDos.Name = "RbtnDos"
        Me.RbtnDos.Size = New System.Drawing.Size(93, 21)
        Me.RbtnDos.TabIndex = 9
        Me.RbtnDos.TabStop = True
        Me.RbtnDos.Text = "Tarjeton #2"
        Me.RbtnDos.UseVisualStyleBackColor = True
        '
        'RbtnTres
        '
        Me.RbtnTres.AutoSize = True
        Me.RbtnTres.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RbtnTres.Location = New System.Drawing.Point(237, 257)
        Me.RbtnTres.Name = "RbtnTres"
        Me.RbtnTres.Size = New System.Drawing.Size(93, 21)
        Me.RbtnTres.TabIndex = 10
        Me.RbtnTres.TabStop = True
        Me.RbtnTres.Text = "Tarjeton #3"
        Me.RbtnTres.UseVisualStyleBackColor = True
        '
        'BtnRegistar
        '
        Me.BtnRegistar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnRegistar.Location = New System.Drawing.Point(424, 340)
        Me.BtnRegistar.Name = "BtnRegistar"
        Me.BtnRegistar.Size = New System.Drawing.Size(100, 29)
        Me.BtnRegistar.TabIndex = 11
        Me.BtnRegistar.Text = "Registar"
        Me.BtnRegistar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(39, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "-Escribir nombres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(39, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "-Escribir apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(39, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "-Escribir Identificacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(37, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "-Seleccionar el numero del candidato:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(38, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "-Propuesta del  candidato:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(436, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 17
        '
        'BtnSubir
        '
        Me.BtnSubir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSubir.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSubir.Location = New System.Drawing.Point(408, 218)
        Me.BtnSubir.Name = "BtnSubir"
        Me.BtnSubir.Size = New System.Drawing.Size(116, 23)
        Me.BtnSubir.TabIndex = 18
        Me.BtnSubir.Text = "Subir Foto"
        Me.BtnSubir.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(171, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Registro de Candidatos"
        '
        'Subir
        '
        Me.Subir.FileName = "OpenFileDialog1"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(558, 462)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnSubir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegistar)
        Me.Controls.Add(Me.RbtnTres)
        Me.Controls.Add(Me.RbtnDos)
        Me.Controls.Add(Me.RbtnUno)
        Me.Controls.Add(Me.PbxFoto)
        Me.Controls.Add(Me.RtxtPropuesta)
        Me.Controls.Add(Me.TxtIdentificacion)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtNombres)
        Me.Controls.Add(Me.Btninicio)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        CType(Me.PbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btninicio As Button
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtIdentificacion As TextBox
    Friend WithEvents RtxtPropuesta As RichTextBox
    Friend WithEvents PbxFoto As PictureBox
    Friend WithEvents RbtnUno As RadioButton
    Friend WithEvents RbtnDos As RadioButton
    Friend WithEvents RbtnTres As RadioButton
    Friend WithEvents BtnRegistar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSubir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Subir As OpenFileDialog
End Class
